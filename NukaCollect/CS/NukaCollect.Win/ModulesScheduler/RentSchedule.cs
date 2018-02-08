using System;
using System.Windows.Forms;
using DevExpress.XtraScheduler;
using DevExpress.Data.Filtering;
using NukaCollect.Win.Forms;
using DevExpress.XtraScheduler.Drawing;
using System.Drawing;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraScheduler.Localization;
using NukaCollect.Resources.Properties;

namespace NukaCollect.Win.ModulesScheduler {
    public partial class RentalCalendar : TutorialControl {
        Cursor currentCursor;
        CustomerToolTipController tooltip;
        public RentalCalendar() {
            SchedulerLocalizer.Active = new CustomSchedulerLocalizer();

            InitializeComponent();
            this.tooltip = new CustomerToolTipController(resourcesCheckedListBoxControl1);
            SetupApointmentSearchInterval();
        }
        protected override DevExpress.XtraLayout.LayoutControl MainLayoutControl { get { return lcMain; } }
        protected override void DoParentChanged() {
            base.DoParentChanged();

            this.schedulerControl1.Start = DateTime.Today.AddDays(-10);

            this.schedulerStorage1.ResourceCollectionLoaded += new EventHandler(schedulerStorage1_ResourceCollectionLoaded);
            if(ParentFormMain != null)
                ParentFormMain.UpdateSchedulerRibbonController(this.schedulerControl1);
            BindScheduler();
            foreach(RibbonPageGroup group in this.ActiveRibbonPage.Groups)
                group.ShowCaptionButton = false;


        }
        bool initialization;
        void schedulerStorage1_ResourceCollectionLoaded(object sender, EventArgs e) {
            if(!initialization) {
                int count = schedulerStorage1.Resources.Count;
                for(int i = 0; i < count; i++) {
                    schedulerStorage1.Resources[i].Visible = i >= 0 && i < 8;
                }
                initialization = true;
            }

        }

        private void BindScheduler() {
            this.schedulerStorage1.BeginUpdate();
            try {
                this.schedulerStorage1.Resources.DataSource = xpcCustomers;
                xpcCustomers.LoadingEnabled = true;

                this.schedulerStorage1.Appointments.DataSource = xpcRents;
                SubscribeFetchAppointmentEvent();

            } finally {
                this.schedulerStorage1.EndUpdate();
            }
        }
        private void SetupApointmentSearchInterval() {
            this.schedulerControl1.OptionsView.NavigationButtons.AppointmentSearchInterval = TimeSpan.FromDays(100);
        }
        private void xpcRents_ResolveSession(object sender, DevExpress.Xpo.ResolveSessionEventArgs e) {
            e.Session = Session;
        }
        private void xpcCustomers_ResolveSession(object sender, DevExpress.Xpo.ResolveSessionEventArgs e) {
            e.Session = Session;
        }

        private void schedulerStorage1_FilterAppointment(object sender, DevExpress.XtraScheduler.PersistentObjectCancelEventArgs e) {
            Appointment apt = (Appointment)e.Object;
            ReceiptType receiptType = (ReceiptType)apt.CustomFields["ReceiptType"];
            if(receiptType.Equals(ReceiptType.Purchases))
                e.Cancel = true;
        }
        private void schedulerControl1_EditAppointmentFormShowing(object sender, AppointmentFormEventArgs e) {
            using(RentalDetailsForm form = new RentalDetailsForm(schedulerControl1, e.Appointment, LayoutManager)) {
                form.ShowDialog();
                e.Handled = true;
            }
        }

        private void SubscribeAppointmentChangingEvent() {
            schedulerStorage1.AppointmentChanging += new PersistentObjectCancelEventHandler(schedulerStorage1_AppointmentChanging);
        }
        private void UnsubscribeAppointmentChangingEvent() {
            schedulerStorage1.AppointmentChanging -= new PersistentObjectCancelEventHandler(schedulerStorage1_AppointmentChanging);
        }
        private void schedulerStorage1_AppointmentChanging(object sender, PersistentObjectCancelEventArgs e) {
            e.Cancel = true;
        }
        private void schedulerControl1_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e) {
            SchedulerPopupMenu labelMenu = e.Menu.GetPopupMenuById(SchedulerMenuItemId.LabelSubMenu);
            if(labelMenu != null) {
                labelMenu.Caption = Resources.Properties.Resources.MovieRating;
            }
            SchedulerPopupMenu statusMenu = e.Menu.GetPopupMenuById(SchedulerMenuItemId.StatusSubMenu);
            if(statusMenu != null) {
                statusMenu.Caption = Resources.Properties.Resources.RentType;
            }
        }
        private void SubscribeFetchAppointmentEvent() {
            schedulerStorage1.FetchAppointments += new FetchAppointmentsEventHandler(schedulerStorage1_FetchAppointments);
        }

        TimeInterval lastFetchedInterval = new TimeInterval();
        private void schedulerStorage1_FetchAppointments(object sender, FetchAppointmentsEventArgs e) {
            DateTime start = e.Interval.Start;
            DateTime end = e.Interval.End;
            if(start <= this.lastFetchedInterval.Start || end >= this.lastFetchedInterval.End) {
                this.lastFetchedInterval = new TimeInterval(start - TimeSpan.FromDays(35), end + TimeSpan.FromDays(35));
                xpcRents.Filter = CriteriaOperator.Parse("RentedOn >= ? and ExpectedOn <= ?", lastFetchedInterval.Start, lastFetchedInterval.End);
                xpcRents.LoadingEnabled = true;

                currentCursor = Cursor.Current;
                Cursor.Current = Cursors.WaitCursor;
            }
        }

        private void schedulerControl1_InitAppointmentImages(object sender, AppointmentImagesEventArgs e) {
            Appointment apt = e.Appointment;
            ActiveRentType rentType = (ActiveRentType)apt.StatusId;
            int index = CalculateRentTypeImageIndex(rentType);
            if(index >= 0) {
                AppointmentImageInfo imageInfo = new AppointmentImageInfo();
                imageInfo.Image = ElementHelper.ActiveRentTypeImages.Images[index];
                e.ImageInfoList.Add(imageInfo);
            }
        }
        protected int CalculateRentTypeImageIndex(ActiveRentType type) {
            switch(type) {
                case ActiveRentType.Overdue:
                    return 0;
                case ActiveRentType.Today:
                    return 1;
                case ActiveRentType.Active:
                    return 2;
                default:
                    return -1;
            }
        }
        private void xpcRents_CollectionChanged(object sender, DevExpress.Xpo.XPCollectionChangedEventArgs e) {
            Cursor.Current = currentCursor;
        }
        private void resourcesCheckedListBoxControl1_MouseMove(object sender, MouseEventArgs e) {
            int index = resourcesCheckedListBoxControl1.IndexFromPoint(e.Location);
            if(index >= 0) {
                Customer customer = xpcCustomers[index] as Customer;
                if(customer != null) {
                    Point pt = e.Location;
                    pt.Offset(20, 20);
                    this.tooltip.ShowHint(customer, pt);
                }
            } else {
                this.tooltip.HideHint(true);
            }
        }
    }
    public class CustomSchedulerLocalizer : SchedulerResLocalizer {
        public override string GetLocalizedString(SchedulerStringId id) {
            switch(id) {
                case SchedulerStringId.Caption_PrevAppointment:
                    return Resources.Properties.Resources.SchedulerCaptionPrevAppointment;
                case SchedulerStringId.Caption_NextAppointment:
                    return Resources.Properties.Resources.SchedulerCaptionNextAppointment;
                case SchedulerStringId.Caption_DayViewDescription:
                    return Resources.Properties.Resources.SchedulerCaptionDayViewDescription;
                case SchedulerStringId.Caption_WorkWeekViewDescription:
                    return Resources.Properties.Resources.SchedulerCaptionWorkWeekViewDescription;
                case SchedulerStringId.Caption_WeekViewDescription:
                    return Resources.Properties.Resources.SchedulerCaptionWeekViewDescription;
                case SchedulerStringId.Caption_MonthViewDescription:
                    return Resources.Properties.Resources.SchedulerCaptionMonthViewDescription;
                case SchedulerStringId.Caption_TimelineViewDescription:
                    return Resources.Properties.Resources.SchedulerCaptionTimelineViewDescription;
                case SchedulerStringId.DescCmd_NavigateBackward:
                    return Resources.Properties.Resources.SchedulerDescCmdNavigateBackward;
                case SchedulerStringId.DescCmd_NavigateForward:
                    return Resources.Properties.Resources.SchedulerDescCmdNavigateForward;
                case SchedulerStringId.DescCmd_GotoToday:
                    return Resources.Properties.Resources.SchedulerDescCmdGotoToday;
                case SchedulerStringId.DescCmd_ViewZoomIn:
                    return Resources.Properties.Resources.SchedulerDescCmdViewZoomIn;
                case SchedulerStringId.DescCmd_ViewZoomOut:
                    return Resources.Properties.Resources.SchedulerDescCmdViewZoomOut;
            }
            return base.GetLocalizedString(id);
        }
    }

}
