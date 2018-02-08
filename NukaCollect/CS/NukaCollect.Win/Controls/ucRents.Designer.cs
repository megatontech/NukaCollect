namespace NukaCollect.Win.Controls {
    partial class ucRents {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
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
            this.layoutControl = new DevExpress.XtraLayout.LayoutControl();
            this.ucGridSwitcherBar = new NukaCollect.Win.Controls.ucBarOneCheckedButton();
            this.gcRents = new DevExpress.XtraGrid.GridControl();
            this.gvRents = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colRentId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomer = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDays = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRentedOn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReturnedOn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colActive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroupMain = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lcgRents = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciGridRentsBar = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciRents = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).BeginInit();
            this.layoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcRents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvRents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgRents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciGridRentsBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciRents)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl
            // 
            this.layoutControl.Controls.Add(this.ucGridSwitcherBar);
            this.layoutControl.Controls.Add(this.gcRents);
            this.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl.Location = new System.Drawing.Point(0, 0);
            this.layoutControl.Name = "layoutControl";
            this.layoutControl.Root = this.layoutControlGroupMain;
            this.layoutControl.Size = new System.Drawing.Size(708, 306);
            this.layoutControl.TabIndex = 0;
            this.layoutControl.Text = "layoutControl1";
            // 
            // ucGridSwitcherBar
            // 
            this.ucGridSwitcherBar.ButtonCaption = "Only Active";
            this.ucGridSwitcherBar.Checked = false;
            this.ucGridSwitcherBar.Location = new System.Drawing.Point(24, 44);
            this.ucGridSwitcherBar.Name = "ucGridSwitcherBar";
            this.ucGridSwitcherBar.Size = new System.Drawing.Size(660, 20);
            this.ucGridSwitcherBar.TabIndex = 38;
            // 
            // gcRents
            // 
            this.gcRents.Location = new System.Drawing.Point(24, 68);
            this.gcRents.MainView = this.gvRents;
            this.gcRents.Name = "gcRents";
            this.gcRents.Size = new System.Drawing.Size(660, 214);
            this.gcRents.TabIndex = 26;
            this.gcRents.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvRents});
            // 
            // gvRents
            // 
            this.gvRents.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colRentId,
            this.colCustomer,
            this.colDays,
            this.colRentedOn,
            this.colReturnedOn,
            this.colActive});
            this.gvRents.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gvRents.GridControl = this.gcRents;
            this.gvRents.Name = "gvRents";
            this.gvRents.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvRents.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvRents.OptionsBehavior.Editable = false;
            this.gvRents.OptionsBehavior.ReadOnly = true;
            this.gvRents.OptionsView.ShowDetailButtons = false;
            this.gvRents.OptionsView.ShowGroupPanel = false;
            // 
            // colRentId
            // 
            this.colRentId.FieldName = "RentId";
            this.colRentId.Name = "colRentId";
            this.colRentId.Visible = true;
            this.colRentId.VisibleIndex = 0;
            // 
            // colCustomer
            // 
            this.colCustomer.Caption = "Customer";
            this.colCustomer.FieldName = "Customer!";
            this.colCustomer.Name = "colCustomer";
            this.colCustomer.Visible = true;
            this.colCustomer.VisibleIndex = 1;
            // 
            // colDays
            // 
            this.colDays.FieldName = "Days";
            this.colDays.Name = "colDays";
            this.colDays.Visible = true;
            this.colDays.VisibleIndex = 2;
            // 
            // colRentedOn
            // 
            this.colRentedOn.FieldName = "RentedOn";
            this.colRentedOn.Name = "colRentedOn";
            this.colRentedOn.Visible = true;
            this.colRentedOn.VisibleIndex = 3;
            // 
            // colReturnedOn
            // 
            this.colReturnedOn.FieldName = "ReturnedOn";
            this.colReturnedOn.Name = "colReturnedOn";
            this.colReturnedOn.Visible = true;
            this.colReturnedOn.VisibleIndex = 4;
            // 
            // colActive
            // 
            this.colActive.Caption = "Active";
            this.colActive.FieldName = "Active";
            this.colActive.Name = "colActive";
            this.colActive.Visible = true;
            this.colActive.VisibleIndex = 5;
            // 
            // layoutControlGroupMain
            // 
            this.layoutControlGroupMain.CustomizationFormText = "layoutControlGroupMain";
            this.layoutControlGroupMain.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroupMain.GroupBordersVisible = false;
            this.layoutControlGroupMain.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lcgRents});
            this.layoutControlGroupMain.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroupMain.Name = "layoutControlGroupMain";
            this.layoutControlGroupMain.Size = new System.Drawing.Size(708, 306);
            this.layoutControlGroupMain.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroupMain.Text = "layoutControlGroupMain";
            this.layoutControlGroupMain.TextVisible = false;
            // 
            // lcgRents
            // 
            this.lcgRents.CustomizationFormText = "Rents";
            this.lcgRents.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciGridRentsBar,
            this.lciRents});
            this.lcgRents.Location = new System.Drawing.Point(0, 0);
            this.lcgRents.Name = "lcgRents";
            this.lcgRents.Size = new System.Drawing.Size(688, 286);
            this.lcgRents.Text = "Rents";
            // 
            // lciGridRentsBar
            // 
            this.lciGridRentsBar.Control = this.ucGridSwitcherBar;
            this.lciGridRentsBar.CustomizationFormText = "lciGridBar";
            this.lciGridRentsBar.Location = new System.Drawing.Point(0, 0);
            this.lciGridRentsBar.Name = "lciGridRentsBar";
            this.lciGridRentsBar.Size = new System.Drawing.Size(664, 24);
            this.lciGridRentsBar.Text = "Rents";
            this.lciGridRentsBar.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.lciGridRentsBar.TextLocation = DevExpress.Utils.Locations.Top;
            this.lciGridRentsBar.TextSize = new System.Drawing.Size(0, 0);
            this.lciGridRentsBar.TextToControlDistance = 0;
            this.lciGridRentsBar.TextVisible = false;
            // 
            // lciRents
            // 
            this.lciRents.Control = this.gcRents;
            this.lciRents.CustomizationFormText = "Current Rents";
            this.lciRents.Location = new System.Drawing.Point(0, 24);
            this.lciRents.Name = "lciRents";
            this.lciRents.Size = new System.Drawing.Size(664, 218);
            this.lciRents.Text = "Rents";
            this.lciRents.TextLocation = DevExpress.Utils.Locations.Top;
            this.lciRents.TextSize = new System.Drawing.Size(0, 0);
            this.lciRents.TextToControlDistance = 0;
            this.lciRents.TextVisible = false;
            // 
            // ucRents
            // 
            this.Controls.Add(this.layoutControl);
            this.Name = "ucRents";
            this.Size = new System.Drawing.Size(708, 306);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).EndInit();
            this.layoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcRents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvRents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgRents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciGridRentsBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciRents)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroupMain;
        private DevExpress.XtraGrid.GridControl gcRents;
        private DevExpress.XtraGrid.Views.Grid.GridView gvRents;
        private DevExpress.XtraLayout.LayoutControlItem lciRents;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomer;
        private DevExpress.XtraGrid.Columns.GridColumn colDays;
        private DevExpress.XtraGrid.Columns.GridColumn colRentedOn;
        private DevExpress.XtraGrid.Columns.GridColumn colReturnedOn;
        private DevExpress.XtraGrid.Columns.GridColumn colRentId;
        private NukaCollect.Win.Controls.ucBarOneCheckedButton ucGridSwitcherBar;
        private DevExpress.XtraLayout.LayoutControlItem lciGridRentsBar;
        private DevExpress.XtraLayout.LayoutControlGroup lcgRents;
        private DevExpress.XtraGrid.Columns.GridColumn colActive;
    }
}
