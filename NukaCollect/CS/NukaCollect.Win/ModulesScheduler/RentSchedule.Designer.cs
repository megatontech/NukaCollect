namespace NukaCollect.Win.ModulesScheduler {
    partial class RentalCalendar {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraScheduler.TimeRuler timeRuler1 = new DevExpress.XtraScheduler.TimeRuler();
            DevExpress.XtraScheduler.TimeScaleYear timeScaleYear1 = new DevExpress.XtraScheduler.TimeScaleYear();
            DevExpress.XtraScheduler.TimeScaleQuarter timeScaleQuarter1 = new DevExpress.XtraScheduler.TimeScaleQuarter();
            DevExpress.XtraScheduler.TimeScaleMonth timeScaleMonth1 = new DevExpress.XtraScheduler.TimeScaleMonth();
            DevExpress.XtraScheduler.TimeScaleWeek timeScaleWeek1 = new DevExpress.XtraScheduler.TimeScaleWeek();
            DevExpress.XtraScheduler.TimeScaleDay timeScaleDay1 = new DevExpress.XtraScheduler.TimeScaleDay();
            DevExpress.XtraScheduler.TimeScaleHour timeScaleHour1 = new DevExpress.XtraScheduler.TimeScaleHour();
            DevExpress.XtraScheduler.TimeScaleFixedInterval timeScaleFixedInterval1 = new DevExpress.XtraScheduler.TimeScaleFixedInterval();
            DevExpress.XtraScheduler.TimeRuler timeRuler2 = new DevExpress.XtraScheduler.TimeRuler();
            this.lcMain = new DevExpress.XtraLayout.LayoutControl();
            this.schedulerControl1 = new DevExpress.XtraScheduler.SchedulerControl();
            this.schedulerStorage1 = new DevExpress.XtraScheduler.SchedulerStorage(this.components);
            this.resourcesCheckedListBoxControl1 = new DevExpress.XtraScheduler.UI.ResourcesCheckedListBoxControl();
            this.dateNavigator1 = new DevExpress.XtraScheduler.DateNavigator();
            this.resourcesComboBoxControl1 = new DevExpress.XtraScheduler.UI.ResourcesComboBoxControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.splitterItem1 = new DevExpress.XtraLayout.SplitterItem();
            this.xpcRents = new DevExpress.Xpo.XPCollection(this.components);
            this.xpcCustomers = new DevExpress.Xpo.XPCollection(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).BeginInit();
            this.lcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerStorage1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resourcesCheckedListBoxControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNavigator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resourcesComboBoxControl1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpcRents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpcCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // lcMain
            // 
            this.lcMain.Controls.Add(this.schedulerControl1);
            this.lcMain.Controls.Add(this.resourcesCheckedListBoxControl1);
            this.lcMain.Controls.Add(this.dateNavigator1);
            this.lcMain.Controls.Add(this.resourcesComboBoxControl1);
            this.lcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcMain.Location = new System.Drawing.Point(0, 0);
            this.lcMain.Name = "lcMain";
            this.lcMain.Root = this.layoutControlGroup1;
            this.lcMain.Size = new System.Drawing.Size(1035, 622);
            this.lcMain.TabIndex = 0;
            this.lcMain.Text = "layoutControl1";
            // 
            // schedulerControl1
            // 
            this.schedulerControl1.ActiveViewType = DevExpress.XtraScheduler.SchedulerViewType.Timeline;
            this.schedulerControl1.GroupType = DevExpress.XtraScheduler.SchedulerGroupType.Resource;
            this.schedulerControl1.Location = new System.Drawing.Point(208, 8);
            this.schedulerControl1.Name = "schedulerControl1";
            this.schedulerControl1.OptionsCustomization.AllowAppointmentCopy = DevExpress.XtraScheduler.UsedAppointmentType.None;
            this.schedulerControl1.OptionsCustomization.AllowAppointmentCreate = DevExpress.XtraScheduler.UsedAppointmentType.None;
            this.schedulerControl1.OptionsCustomization.AllowAppointmentDelete = DevExpress.XtraScheduler.UsedAppointmentType.None;
            this.schedulerControl1.OptionsCustomization.AllowAppointmentDrag = DevExpress.XtraScheduler.UsedAppointmentType.None;
            this.schedulerControl1.OptionsCustomization.AllowAppointmentDragBetweenResources = DevExpress.XtraScheduler.UsedAppointmentType.None;
            this.schedulerControl1.OptionsCustomization.AllowAppointmentResize = DevExpress.XtraScheduler.UsedAppointmentType.None;
            this.schedulerControl1.OptionsCustomization.AllowInplaceEditor = DevExpress.XtraScheduler.UsedAppointmentType.None;
            this.schedulerControl1.OptionsView.ResourceHeaders.ImageAlign = DevExpress.XtraScheduler.HeaderImageAlign.Top;
            this.schedulerControl1.OptionsView.ResourceHeaders.ImageInterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            this.schedulerControl1.OptionsView.ResourceHeaders.ImageSize = new System.Drawing.Size(50, 80);
            this.schedulerControl1.OptionsView.ResourceHeaders.ImageSizeMode = DevExpress.XtraScheduler.HeaderImageSizeMode.ZoomImage;
            this.schedulerControl1.OptionsView.ShowOnlyResourceAppointments = true;
            this.schedulerControl1.Size = new System.Drawing.Size(819, 606);
            this.schedulerControl1.Start = new System.DateTime(2010, 7, 25, 0, 0, 0, 0);
            this.schedulerControl1.Storage = this.schedulerStorage1;
            this.schedulerControl1.TabIndex = 5;
            this.schedulerControl1.Text = "schedulerControl1";
            this.schedulerControl1.Views.DayView.ResourcesPerPage = 4;
            this.schedulerControl1.Views.DayView.ShowWorkTimeOnly = true;
            this.schedulerControl1.Views.DayView.TimeRulers.Add(timeRuler1);
            this.schedulerControl1.Views.GanttView.Enabled = false;
            this.schedulerControl1.Views.MonthView.ResourcesPerPage = 3;
            this.schedulerControl1.Views.MonthView.WeekCount = 2;
            this.schedulerControl1.Views.TimelineView.ResourcesPerPage = 4;
            timeScaleYear1.Enabled = false;
            timeScaleQuarter1.Enabled = false;
            timeScaleMonth1.Enabled = false;
            timeScaleDay1.Width = 75;
            timeScaleHour1.Enabled = false;
            timeScaleFixedInterval1.Enabled = false;
            this.schedulerControl1.Views.TimelineView.Scales.Add(timeScaleYear1);
            this.schedulerControl1.Views.TimelineView.Scales.Add(timeScaleQuarter1);
            this.schedulerControl1.Views.TimelineView.Scales.Add(timeScaleMonth1);
            this.schedulerControl1.Views.TimelineView.Scales.Add(timeScaleWeek1);
            this.schedulerControl1.Views.TimelineView.Scales.Add(timeScaleDay1);
            this.schedulerControl1.Views.TimelineView.Scales.Add(timeScaleHour1);
            this.schedulerControl1.Views.TimelineView.Scales.Add(timeScaleFixedInterval1);
            this.schedulerControl1.Views.WeekView.ResourcesPerPage = 3;
            this.schedulerControl1.Views.WorkWeekView.ResourcesPerPage = 3;
            this.schedulerControl1.Views.WorkWeekView.ShowWorkTimeOnly = true;
            this.schedulerControl1.Views.WorkWeekView.TimeRulers.Add(timeRuler2);
            this.schedulerControl1.InitAppointmentImages += new DevExpress.XtraScheduler.AppointmentImagesEventHandler(this.schedulerControl1_InitAppointmentImages);
            this.schedulerControl1.PopupMenuShowing += new DevExpress.XtraScheduler.PopupMenuShowingEventHandler(this.schedulerControl1_PopupMenuShowing);
            this.schedulerControl1.EditAppointmentFormShowing += new DevExpress.XtraScheduler.AppointmentFormEventHandler(this.schedulerControl1_EditAppointmentFormShowing);
            // 
            // schedulerStorage1
            // 
            this.schedulerStorage1.Appointments.CustomFieldMappings.Add(new DevExpress.XtraScheduler.AppointmentCustomFieldMapping("ReceiptType", "ReceiptType", DevExpress.XtraScheduler.FieldValueType.Integer));
            this.schedulerStorage1.Appointments.CustomFieldMappings.Add(new DevExpress.XtraScheduler.AppointmentCustomFieldMapping("MovieGenre", "MovieGenre", DevExpress.XtraScheduler.FieldValueType.Integer));
            this.schedulerStorage1.Appointments.CustomFieldMappings.Add(new DevExpress.XtraScheduler.AppointmentCustomFieldMapping("MovieRating", "MovieRating", DevExpress.XtraScheduler.FieldValueType.Integer));
            this.schedulerStorage1.Appointments.CustomFieldMappings.Add(new DevExpress.XtraScheduler.AppointmentCustomFieldMapping("ItemFormat", "ItemFormat", DevExpress.XtraScheduler.FieldValueType.Integer));
            this.schedulerStorage1.Appointments.CustomFieldMappings.Add(new DevExpress.XtraScheduler.AppointmentCustomFieldMapping("MoviePhoto", "MoviePhoto"));
            this.schedulerStorage1.Appointments.CustomFieldMappings.Add(new DevExpress.XtraScheduler.AppointmentCustomFieldMapping("MovieLanguage", "MovieLanguage", DevExpress.XtraScheduler.FieldValueType.String));
            this.schedulerStorage1.Appointments.CustomFieldMappings.Add(new DevExpress.XtraScheduler.AppointmentCustomFieldMapping("Payment", "Payment", DevExpress.XtraScheduler.FieldValueType.Decimal));
            this.schedulerStorage1.Appointments.CustomFieldMappings.Add(new DevExpress.XtraScheduler.AppointmentCustomFieldMapping("OverduePayment", "OverduePayment", DevExpress.XtraScheduler.FieldValueType.Decimal));
            this.schedulerStorage1.Appointments.CustomFieldMappings.Add(new DevExpress.XtraScheduler.AppointmentCustomFieldMapping("ReceiptOverdue", "ReceiptOverdue!"));
            this.schedulerStorage1.Appointments.CustomFieldMappings.Add(new DevExpress.XtraScheduler.AppointmentCustomFieldMapping("ReturnedOn", "ReturnedOn", DevExpress.XtraScheduler.FieldValueType.DateTime));
            this.schedulerStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.SystemColors.Window, "G", "&G"));
            this.schedulerStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(190))))), "PG", "&PG"));
            this.schedulerStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(213)))), ((int)(((byte)(255))))), "PG13", "&PG13"));
            this.schedulerStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(244)))), ((int)(((byte)(156))))), "R", "&R"));
            this.schedulerStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(228)))), ((int)(((byte)(199))))), "NC17", "&NC17"));
            this.schedulerStorage1.Appointments.Mappings.Description = "MoviePlot";
            this.schedulerStorage1.Appointments.Mappings.End = "ExpectedOn";
            this.schedulerStorage1.Appointments.Mappings.Label = "MovieRating";
            this.schedulerStorage1.Appointments.Mappings.ResourceId = "Customer!Key";
            this.schedulerStorage1.Appointments.Mappings.Start = "RentedOn";
            this.schedulerStorage1.Appointments.Mappings.Status = "ActiveType";
            this.schedulerStorage1.Appointments.Mappings.Subject = "MovieTitle";
            this.schedulerStorage1.Appointments.Statuses.Add(new DevExpress.XtraScheduler.AppointmentStatus(DevExpress.XtraScheduler.AppointmentStatusType.Custom, System.Drawing.SystemColors.Window, "None", "&None"));
            this.schedulerStorage1.Appointments.Statuses.Add(new DevExpress.XtraScheduler.AppointmentStatus(DevExpress.XtraScheduler.AppointmentStatusType.Custom, System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192))))), "Overdue", "&Overdue"));
            this.schedulerStorage1.Appointments.Statuses.Add(new DevExpress.XtraScheduler.AppointmentStatus(DevExpress.XtraScheduler.AppointmentStatusType.Custom, System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192))))), "Today", "&Today"));
            this.schedulerStorage1.Appointments.Statuses.Add(new DevExpress.XtraScheduler.AppointmentStatus(DevExpress.XtraScheduler.AppointmentStatusType.Custom, System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192))))), "Active", "&Active"));
            this.schedulerStorage1.EnableReminders = false;
            this.schedulerStorage1.Resources.Mappings.Caption = "FullNameLastSorting";
            this.schedulerStorage1.Resources.Mappings.Id = "Oid";
            this.schedulerStorage1.Resources.Mappings.Image = "PhotoExist";
            this.schedulerStorage1.AppointmentChanging += new DevExpress.XtraScheduler.PersistentObjectCancelEventHandler(this.schedulerStorage1_AppointmentChanging);
            this.schedulerStorage1.FilterAppointment += new DevExpress.XtraScheduler.PersistentObjectCancelEventHandler(this.schedulerStorage1_FilterAppointment);
            // 
            // resourcesCheckedListBoxControl1
            // 
            this.resourcesCheckedListBoxControl1.CheckOnClick = true;
            this.resourcesCheckedListBoxControl1.Location = new System.Drawing.Point(8, 32);
            this.resourcesCheckedListBoxControl1.MaximumSize = new System.Drawing.Size(200, 0);
            this.resourcesCheckedListBoxControl1.Name = "resourcesCheckedListBoxControl1";
            this.resourcesCheckedListBoxControl1.SchedulerControl = this.schedulerControl1;
            this.resourcesCheckedListBoxControl1.Size = new System.Drawing.Size(196, 396);
            this.resourcesCheckedListBoxControl1.StyleController = this.lcMain;
            this.resourcesCheckedListBoxControl1.TabIndex = 8;
            this.resourcesCheckedListBoxControl1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.resourcesCheckedListBoxControl1_MouseMove);
            // 
            // dateNavigator1
            // 
            this.dateNavigator1.HotDate = null;
            this.dateNavigator1.Location = new System.Drawing.Point(8, 437);
            this.dateNavigator1.Name = "dateNavigator1";
            this.dateNavigator1.SchedulerControl = this.schedulerControl1;
            this.dateNavigator1.Size = new System.Drawing.Size(196, 177);
            this.dateNavigator1.TabIndex = 6;
            // 
            // resourcesComboBoxControl1
            // 
            this.resourcesComboBoxControl1.Location = new System.Drawing.Point(8, 8);
            this.resourcesComboBoxControl1.Name = "resourcesComboBoxControl1";
            this.resourcesComboBoxControl1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.resourcesComboBoxControl1.Properties.DropDownRows = 25;
            this.resourcesComboBoxControl1.SchedulerControl = this.schedulerControl1;
            this.resourcesComboBoxControl1.Size = new System.Drawing.Size(196, 20);
            this.resourcesComboBoxControl1.StyleController = this.lcMain;
            this.resourcesComboBoxControl1.TabIndex = 9;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "Root";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem1,
            this.splitterItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(6, 6, 6, 6);
            this.layoutControlGroup1.Size = new System.Drawing.Size(1035, 622);
            this.layoutControlGroup1.Text = "Root";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.schedulerControl1;
            this.layoutControlItem2.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem2.Location = new System.Drawing.Point(200, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(823, 610);
            this.layoutControlItem2.Text = "layoutControlItem2";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextToControlDistance = 0;
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.resourcesCheckedListBoxControl1;
            this.layoutControlItem4.ControlAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.layoutControlItem4.CustomizationFormText = "layoutControlItem4";
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem4.MinSize = new System.Drawing.Size(54, 20);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(200, 400);
            this.layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem4.Text = "layoutControlItem4";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextToControlDistance = 0;
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.resourcesComboBoxControl1;
            this.layoutControlItem5.CustomizationFormText = "layoutControlItem5";
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(200, 24);
            this.layoutControlItem5.Text = "layoutControlItem5";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextToControlDistance = 0;
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.dateNavigator1;
            this.layoutControlItem1.ControlAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 429);
            this.layoutControlItem1.MinSize = new System.Drawing.Size(200, 180);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(200, 181);
            this.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem1.Text = "layoutControlItem1";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextToControlDistance = 0;
            this.layoutControlItem1.TextVisible = false;
            // 
            // splitterItem1
            // 
            this.splitterItem1.AllowHotTrack = true;
            this.splitterItem1.CustomizationFormText = "splitterItem1";
            this.splitterItem1.Location = new System.Drawing.Point(0, 424);
            this.splitterItem1.Name = "splitterItem1";
            this.splitterItem1.Size = new System.Drawing.Size(200, 5);
            // 
            // xpcRents
            // 
            this.xpcRents.LoadingEnabled = false;
            this.xpcRents.ObjectType = typeof(NukaCollect.Rent);
            this.xpcRents.ResolveSession += new DevExpress.Xpo.ResolveSessionEventHandler(this.xpcRents_ResolveSession);
            this.xpcRents.CollectionChanged += new DevExpress.Xpo.XPCollectionChangedEventHandler(this.xpcRents_CollectionChanged);
            // 
            // xpcCustomers
            // 
            this.xpcCustomers.LoadingEnabled = false;
            this.xpcCustomers.ObjectType = typeof(NukaCollect.Customer);
            this.xpcCustomers.Sorting.AddRange(new DevExpress.Xpo.SortProperty[] {
            new DevExpress.Xpo.SortProperty("[FullNameLastSorting]", DevExpress.Xpo.DB.SortingDirection.Ascending)});
            this.xpcCustomers.ResolveSession += new DevExpress.Xpo.ResolveSessionEventHandler(this.xpcCustomers_ResolveSession);
            // 
            // RentalCalendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lcMain);
            this.Name = "RentalCalendar";
            this.Size = new System.Drawing.Size(1035, 622);
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).EndInit();
            this.lcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.schedulerControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerStorage1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resourcesCheckedListBoxControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNavigator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resourcesComboBoxControl1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpcRents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpcCustomers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl lcMain;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraScheduler.SchedulerControl schedulerControl1;
        private DevExpress.XtraScheduler.SchedulerStorage schedulerStorage1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraScheduler.DateNavigator dateNavigator1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraScheduler.UI.ResourcesCheckedListBoxControl resourcesCheckedListBoxControl1;
        private DevExpress.XtraScheduler.UI.ResourcesComboBoxControl resourcesComboBoxControl1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.Xpo.XPCollection xpcRents;
        private DevExpress.Xpo.XPCollection xpcCustomers;
        private DevExpress.XtraLayout.SplitterItem splitterItem1;
    }
}
