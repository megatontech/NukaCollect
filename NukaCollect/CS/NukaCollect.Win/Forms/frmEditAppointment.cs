using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraScheduler.UI;
using DevExpress.XtraScheduler;
using DevExpress.XtraEditors;
using NukaCollect.Resources;

namespace NukaCollect.Win.Forms {

    public partial class RentalDetailsForm : XtraForm {
        SchedulerControl control;
        Appointment apt;
        RentAppointmentFormController controller;
        int suspendUpdateCount;
        FormLayoutManager layoutManager = null;

        public RentalDetailsForm() { }
        public RentalDetailsForm(SchedulerControl control, Appointment apt, FormLayoutManager layoutManager) {
            this.layoutManager = layoutManager;
            if(control == null)
                new ArgumentNullException("control");
            if(apt == null)
                new ArgumentNullException("apt");
            this.apt = apt;
            this.control = control;
            this.controller = new RentAppointmentFormController(control, apt);

            InitializeComponent();
            ElementConstStringLoader.LoadConstStringsForFrmEditAppointment(this);
            InitData();
            UpdateForm();
        }

        void InitData() {
            EditorHelper.CreateMovieItemFormatImageComboBox(txtFormat.Properties, null);
        }
        protected AppointmentStorage Appointments { get { return control.Storage.Appointments; } }
        protected internal bool IsNewAppointment { get { return controller != null ? controller.IsNewAppointment : true; } }
        protected bool IsUpdateSuspended { get { return suspendUpdateCount > 0; } }

        protected void SuspendUpdate() {
            suspendUpdateCount++;
        }
        protected void ResumeUpdate() {
            if(suspendUpdateCount > 0)
                suspendUpdateCount--;
        }

        protected virtual void UpdateForm() {
            UnsubscribeControlsEvents();
            try {
                UpdateFormCore();
            } finally {
                SubscribeControlsEvents();
            }

        }
        protected virtual void UnsubscribeControlsEvents() {
        }
        protected virtual void SubscribeControlsEvents() {
        }
        protected virtual void UpdateFormCore() {
            SuspendUpdate();
            try {
                txSubject.Text = controller.Subject;

                dtStart.DateTime = controller.DisplayStart.Date;
                dtEnd.DateTime = controller.DisplayEnd.Date;

                timeStart.Time = new DateTime(controller.DisplayStart.TimeOfDay.Ticks);
                timeEnd.Time = new DateTime(controller.DisplayEnd.TimeOfDay.Ticks);

                edtResource.SchedulerControl = control;
                edtResource.Storage = control.Storage;
                edtResource.ResourceId = controller.ResourceId;

                txMovieLanguage.Text = controller.MovieLanguage;
                edtDescription.Text = controller.Description;


                pePhoto.Image = controller.MoviePhoto != null ? controller.MoviePhoto : ReferenceImages.UnknownMovie;
                txtFormat.EditValue = controller.MovieFormat;

                txtPayment.EditValue = controller.Payment;
                txtOverduePayment.EditValue = controller.OverduePayment;
                chkRentOverdue.Checked = controller.IsRentOverdue;

                chkActiveRental.Checked = controller.IsActiveRent;
            } finally {
                ResumeUpdate();
            }
        }

        private void CustomAppointmentForm_Load(object sender, EventArgs e) {
            LoadFormLayout();
            lciReturnedOn.Text = controller.IsActiveRent ? ConstStrings.Get("ExpectedOn") : ConstStrings.Get("ReturnedOn");
        }

        private void CustomAppointmentForm_FormClosing(object sender, FormClosingEventArgs e) {
            SaveFormLayout();
        }
        protected virtual void LoadFormLayout() {
            if(layoutManager == null) return;
            layoutManager.RestoreFormLayout(new FormLayoutInfo(this, lcMain));
        }
        protected virtual void SaveFormLayout() {
            if(layoutManager == null) return;
            layoutManager.SaveFormLayout(new FormLayoutInfo(this, lcMain));
        }

        private void dtStart_Properties_QueryPopUp(object sender, CancelEventArgs e) {
            e.Cancel = true;
        }
    }

    public class RentAppointmentFormController : AppointmentFormController {
        public decimal Payment { get { return (decimal)EditedAppointmentCopy.CustomFields["Payment"]; } }
        public decimal OverduePayment { get { return (decimal)EditedAppointmentCopy.CustomFields["OverduePayment"]; } }

        public ReceiptType ReceiptType { get { return (ReceiptType)EditedAppointmentCopy.CustomFields["ReceiptType"]; } }

        public MovieGenre MovieGenre { get { return (MovieGenre)EditedAppointmentCopy.CustomFields["MovieGenre"]; } }
        public string MovieLanguage { get { return (string)EditedAppointmentCopy.CustomFields["MovieLanguage"]; } }
        public Image MoviePhoto { get { return EditedAppointmentCopy.CustomFields["MoviePhoto"] as Image; } }
        public MovieItemFormat MovieFormat { get { return (MovieItemFormat)EditedAppointmentCopy.CustomFields["ItemFormat"]; } }
        public bool IsRentOverdue { get { return EditedAppointmentCopy.CustomFields["ReceiptOverdue"] != null; } }
        public bool IsActiveRent { get { return EditedAppointmentCopy.CustomFields["ReturnedOn"] == null; } }

        public RentAppointmentFormController(SchedulerControl control, Appointment apt)
            : base(control, apt) {
        }
        public override bool IsAppointmentChanged() {
            return false;
        }
    }

}
