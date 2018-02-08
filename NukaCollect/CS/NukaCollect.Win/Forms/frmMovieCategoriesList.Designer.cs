namespace NukaCollect.Win.Forms {
    partial class frmMovieCategoriesList {
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.lcMain = new DevExpress.XtraLayout.LayoutControl();
            this.ucMovieCategoryDetail = new NukaCollect.Win.Controls.ucMovieCategoryDetail();
            this.gcCategories = new DevExpress.XtraGrid.GridControl();
            this.gvCategories = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsDefault = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lcgMain = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciCategories = new DevExpress.XtraLayout.LayoutControlItem();
            this.splitterItem = new DevExpress.XtraLayout.SplitterItem();
            this.lciMovieCategoryDetail = new DevExpress.XtraLayout.LayoutControlItem();
            this.pcButtons = new DevExpress.XtraEditors.PanelControl();
            this.sbSave = new DevExpress.XtraEditors.SimpleButton();
            this.pcSpace = new DevExpress.XtraEditors.PanelControl();
            this.sbCancel = new DevExpress.XtraEditors.SimpleButton();
            this.barManager = new DevExpress.XtraBars.BarManager(this.components);
            this.barEditCategories = new DevExpress.XtraBars.Bar();
            this.bbiAdd = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDelete = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).BeginInit();
            this.lcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcCategories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCategories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCategories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciMovieCategoryDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcButtons)).BeginInit();
            this.pcButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcSpace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lcMain
            // 
            this.lcMain.Controls.Add(this.ucMovieCategoryDetail);
            this.lcMain.Controls.Add(this.gcCategories);
            this.lcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcMain.Location = new System.Drawing.Point(24, 0);
            this.lcMain.Name = "lcMain";
            this.lcMain.Root = this.lcgMain;
            this.lcMain.Size = new System.Drawing.Size(651, 342);
            this.lcMain.TabIndex = 0;
            this.lcMain.Text = "layoutControl1";
            // 
            // ucMovieCategoryDetail
            // 
            this.ucMovieCategoryDetail.Location = new System.Drawing.Point(229, 4);
            this.ucMovieCategoryDetail.Name = "ucMovieCategoryDetail";
            this.ucMovieCategoryDetail.Size = new System.Drawing.Size(418, 338);
            this.ucMovieCategoryDetail.TabIndex = 5;
            // 
            // gcCategories
            // 
            this.gcCategories.Location = new System.Drawing.Point(6, 6);
            this.gcCategories.MainView = this.gvCategories;
            this.gcCategories.Name = "gcCategories";
            this.gcCategories.Size = new System.Drawing.Size(215, 334);
            this.gcCategories.TabIndex = 4;
            this.gcCategories.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCategories});
            // 
            // gvCategories
            // 
            this.gvCategories.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName,
            this.colIsDefault});
            this.gvCategories.GridControl = this.gcCategories;
            this.gvCategories.Name = "gvCategories";
            this.gvCategories.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvCategories.OptionsBehavior.Editable = false;
            this.gvCategories.OptionsBehavior.ReadOnly = true;
            this.gvCategories.OptionsView.ShowDetailButtons = false;
            this.gvCategories.OptionsView.ShowGroupPanel = false;
            this.gvCategories.OptionsView.ShowIndicator = false;
            this.gvCategories.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False;
            this.gvCategories.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvCategories_FocusedRowChanged);
            this.gvCategories.ColumnFilterChanged += new System.EventHandler(this.gvCategories_ColumnFilterChanged);
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.OptionsColumn.AllowFocus = false;
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            this.colName.Width = 217;
            // 
            // colIsDefault
            // 
            this.colIsDefault.Caption = "Default";
            this.colIsDefault.FieldName = "IsDefault";
            this.colIsDefault.Name = "colIsDefault";
            this.colIsDefault.OptionsColumn.AllowFocus = false;
            this.colIsDefault.Visible = true;
            this.colIsDefault.VisibleIndex = 1;
            this.colIsDefault.Width = 94;
            // 
            // lcgMain
            // 
            this.lcgMain.CustomizationFormText = "lcgMain";
            this.lcgMain.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.lcgMain.GroupBordersVisible = false;
            this.lcgMain.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciCategories,
            this.splitterItem,
            this.lciMovieCategoryDetail});
            this.lcgMain.Location = new System.Drawing.Point(0, 0);
            this.lcgMain.Name = "Root";
            this.lcgMain.Padding = new DevExpress.XtraLayout.Utils.Padding(4, 4, 4, 0);
            this.lcgMain.Size = new System.Drawing.Size(651, 342);
            this.lcgMain.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.lcgMain.Text = "Root";
            this.lcgMain.TextVisible = false;
            // 
            // lciCategories
            // 
            this.lciCategories.Control = this.gcCategories;
            this.lciCategories.CustomizationFormText = "lciCategories";
            this.lciCategories.Location = new System.Drawing.Point(0, 0);
            this.lciCategories.Name = "lciCategories";
            this.lciCategories.Size = new System.Drawing.Size(219, 338);
            this.lciCategories.Text = "lciCategories";
            this.lciCategories.TextSize = new System.Drawing.Size(0, 0);
            this.lciCategories.TextToControlDistance = 0;
            this.lciCategories.TextVisible = false;
            // 
            // splitterItem
            // 
            this.splitterItem.AllowHotTrack = true;
            this.splitterItem.CustomizationFormText = "splitterItem";
            this.splitterItem.Location = new System.Drawing.Point(219, 0);
            this.splitterItem.Name = "splitterItem";
            this.splitterItem.Size = new System.Drawing.Size(6, 338);
            // 
            // lciMovieCategoryDetail
            // 
            this.lciMovieCategoryDetail.Control = this.ucMovieCategoryDetail;
            this.lciMovieCategoryDetail.CustomizationFormText = "lciMovieCategoryDetail";
            this.lciMovieCategoryDetail.Location = new System.Drawing.Point(225, 0);
            this.lciMovieCategoryDetail.Name = "lciMovieCategoryDetail";
            this.lciMovieCategoryDetail.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.lciMovieCategoryDetail.Size = new System.Drawing.Size(418, 338);
            this.lciMovieCategoryDetail.Text = "lciMovieCategoryDetail";
            this.lciMovieCategoryDetail.TextSize = new System.Drawing.Size(0, 0);
            this.lciMovieCategoryDetail.TextToControlDistance = 0;
            this.lciMovieCategoryDetail.TextVisible = false;
            // 
            // pcButtons
            // 
            this.pcButtons.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pcButtons.Controls.Add(this.sbSave);
            this.pcButtons.Controls.Add(this.pcSpace);
            this.pcButtons.Controls.Add(this.sbCancel);
            this.pcButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcButtons.Location = new System.Drawing.Point(12, 12);
            this.pcButtons.Name = "pcButtons";
            this.pcButtons.Size = new System.Drawing.Size(627, 22);
            this.pcButtons.TabIndex = 8;
            // 
            // sbSave
            // 
            this.sbSave.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.sbSave.Dock = System.Windows.Forms.DockStyle.Right;
            this.sbSave.Location = new System.Drawing.Point(414, 0);
            this.sbSave.Name = "sbSave";
            this.sbSave.Size = new System.Drawing.Size(124, 22);
            this.sbSave.TabIndex = 3;
            this.sbSave.Text = "S&ave and Close";
            this.sbSave.Click += new System.EventHandler(this.sbSave_Click);
            // 
            // pcSpace
            // 
            this.pcSpace.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pcSpace.Dock = System.Windows.Forms.DockStyle.Right;
            this.pcSpace.Location = new System.Drawing.Point(538, 0);
            this.pcSpace.Name = "pcSpace";
            this.pcSpace.Size = new System.Drawing.Size(6, 22);
            this.pcSpace.TabIndex = 2;
            // 
            // sbCancel
            // 
            this.sbCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.sbCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.sbCancel.Location = new System.Drawing.Point(544, 0);
            this.sbCancel.Name = "sbCancel";
            this.sbCancel.Size = new System.Drawing.Size(83, 22);
            this.sbCancel.TabIndex = 0;
            this.sbCancel.Text = "&Close";
            // 
            // barManager
            // 
            this.barManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.barEditCategories});
            this.barManager.DockControls.Add(this.barDockControlTop);
            this.barManager.DockControls.Add(this.barDockControlBottom);
            this.barManager.DockControls.Add(this.barDockControlLeft);
            this.barManager.DockControls.Add(this.barDockControlRight);
            this.barManager.Form = this;
            this.barManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.bbiAdd,
            this.bbiDelete});
            this.barManager.MaxItemId = 3;
            // 
            // barEditCategories
            // 
            this.barEditCategories.BarName = "Main menu";
            this.barEditCategories.DockCol = 0;
            this.barEditCategories.DockRow = 0;
            this.barEditCategories.DockStyle = DevExpress.XtraBars.BarDockStyle.Left;
            this.barEditCategories.FloatLocation = new System.Drawing.Point(204, 159);
            this.barEditCategories.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiAdd),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiDelete)});
            this.barEditCategories.OptionsBar.AllowQuickCustomization = false;
            this.barEditCategories.OptionsBar.DrawDragBorder = false;
            this.barEditCategories.OptionsBar.MultiLine = true;
            this.barEditCategories.OptionsBar.UseWholeRow = true;
            this.barEditCategories.Text = "Edit Categories";
            // 
            // bbiAdd
            // 
            this.bbiAdd.Caption = "Add";
            this.bbiAdd.Hint = "Add new category";
            this.bbiAdd.Id = 0;
            this.bbiAdd.Name = "bbiAdd";
            this.bbiAdd.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.bbiAdd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiAdd_ItemClick);
            // 
            // bbiDelete
            // 
            this.bbiDelete.Caption = "Delete";
            this.bbiDelete.Hint = "Delete current category";
            this.bbiDelete.Id = 1;
            this.bbiDelete.Name = "bbiDelete";
            this.bbiDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiDelete_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(675, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 388);
            this.barDockControlBottom.Size = new System.Drawing.Size(675, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Size = new System.Drawing.Size(24, 388);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(675, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 388);
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.pcButtons);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(24, 342);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Padding = new System.Windows.Forms.Padding(12);
            this.panelControl1.Size = new System.Drawing.Size(651, 46);
            this.panelControl1.TabIndex = 9;
            // 
            // frmMovieCategoriesList
            // 
            this.AcceptButton = this.sbCancel;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.sbSave;
            this.ClientSize = new System.Drawing.Size(675, 388);
            this.Controls.Add(this.lcMain);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMovieCategoriesList";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Movie Categories";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMovieCategoriesList_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).EndInit();
            this.lcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcCategories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCategories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCategories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciMovieCategoryDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcButtons)).EndInit();
            this.pcButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcSpace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl lcMain;
        private DevExpress.XtraLayout.LayoutControlGroup lcgMain;
        private DevExpress.XtraGrid.GridControl gcCategories;
        private DevExpress.XtraGrid.Views.Grid.GridView gvCategories;
        private DevExpress.XtraLayout.LayoutControlItem lciCategories;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colIsDefault;
        private DevExpress.XtraLayout.SplitterItem splitterItem;
        private DevExpress.XtraBars.BarManager barManager;
        private DevExpress.XtraBars.Bar barEditCategories;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem bbiAdd;
        private DevExpress.XtraBars.BarButtonItem bbiDelete;
        private DevExpress.XtraEditors.PanelControl pcButtons;
        private DevExpress.XtraEditors.SimpleButton sbCancel;
        private DevExpress.XtraEditors.PanelControl pcSpace;
        private DevExpress.XtraEditors.SimpleButton sbSave;
        private NukaCollect.Win.Controls.ucMovieCategoryDetail ucMovieCategoryDetail;
        private DevExpress.XtraLayout.LayoutControlItem lciMovieCategoryDetail;
        private DevExpress.XtraEditors.PanelControl panelControl1;
    }
}
