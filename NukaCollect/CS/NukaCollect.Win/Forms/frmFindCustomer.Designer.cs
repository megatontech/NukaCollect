namespace NukaCollect.Win.Forms {
    partial class frmFindCustomer {
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.pcButtons = new DevExpress.XtraEditors.PanelControl();
            this.sbClear = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.sbOK = new DevExpress.XtraEditors.SimpleButton();
            this.pcSpace = new DevExpress.XtraEditors.PanelControl();
            this.sbClose = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.xcCustomers = new DevExpress.Xpo.XPCollection();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colFirstName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGender = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBirthDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFullName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMiddleName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colComments = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lcMain = new DevExpress.XtraLayout.LayoutControl();
            this.ucCustomerInfo1 = new NukaCollect.Win.Controls.ucCustomerInfo();
            this.lcgMain = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciGrid = new DevExpress.XtraLayout.LayoutControlItem();
            this.siMain = new DevExpress.XtraLayout.SplitterItem();
            this.lciCustomerInfo = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcButtons)).BeginInit();
            this.pcButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcSpace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xcCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).BeginInit();
            this.lcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lcgMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCustomerInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(12, 430);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Padding = new System.Windows.Forms.Padding(8);
            this.panelControl1.Size = new System.Drawing.Size(799, 12);
            this.panelControl1.TabIndex = 10;
            // 
            // pcButtons
            // 
            this.pcButtons.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pcButtons.Controls.Add(this.sbClear);
            this.pcButtons.Controls.Add(this.panelControl2);
            this.pcButtons.Controls.Add(this.sbOK);
            this.pcButtons.Controls.Add(this.pcSpace);
            this.pcButtons.Controls.Add(this.sbClose);
            this.pcButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pcButtons.Location = new System.Drawing.Point(12, 442);
            this.pcButtons.Name = "pcButtons";
            this.pcButtons.Size = new System.Drawing.Size(799, 22);
            this.pcButtons.TabIndex = 1;
            // 
            // sbClear
            // 
            this.sbClear.DialogResult = System.Windows.Forms.DialogResult.Ignore;
            this.sbClear.Dock = System.Windows.Forms.DockStyle.Left;
            this.sbClear.Location = new System.Drawing.Point(0, 0);
            this.sbClear.Name = "sbClear";
            this.sbClear.Size = new System.Drawing.Size(155, 22);
            this.sbClear.TabIndex = 0;
            this.sbClear.Text = "C&lear current customer";
            this.sbClear.Click += new System.EventHandler(this.sbClear_Click);
            // 
            // panelControl2
            // 
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControl2.Location = new System.Drawing.Point(617, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(8, 22);
            this.panelControl2.TabIndex = 4;
            // 
            // sbOK
            // 
            this.sbOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.sbOK.Dock = System.Windows.Forms.DockStyle.Right;
            this.sbOK.Location = new System.Drawing.Point(625, 0);
            this.sbOK.Name = "sbOK";
            this.sbOK.Size = new System.Drawing.Size(83, 22);
            this.sbOK.TabIndex = 1;
            this.sbOK.Text = "&OK";
            this.sbOK.Click += new System.EventHandler(this.sbOK_Click);
            // 
            // pcSpace
            // 
            this.pcSpace.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pcSpace.Dock = System.Windows.Forms.DockStyle.Right;
            this.pcSpace.Location = new System.Drawing.Point(708, 0);
            this.pcSpace.Name = "pcSpace";
            this.pcSpace.Size = new System.Drawing.Size(8, 22);
            this.pcSpace.TabIndex = 2;
            // 
            // sbClose
            // 
            this.sbClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.sbClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.sbClose.Location = new System.Drawing.Point(716, 0);
            this.sbClose.Name = "sbClose";
            this.sbClose.Size = new System.Drawing.Size(83, 22);
            this.sbClose.TabIndex = 2;
            this.sbClose.Text = "&Close";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.xcCustomers;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.ShowOnlyPredefinedDetails = true;
            this.gridControl1.Size = new System.Drawing.Size(578, 418);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gridControl1_MouseDoubleClick);
            // 
            // xcCustomers
            // 
            this.xcCustomers.BindingBehavior = DevExpress.Xpo.CollectionBindingBehavior.AllowNone;
            this.xcCustomers.ObjectType = typeof(NukaCollect.Customer);
            this.xcCustomers.Sorting.AddRange(new DevExpress.Xpo.SortProperty[] {
            new DevExpress.Xpo.SortProperty("[CustomerId]", DevExpress.Xpo.DB.SortingDirection.Ascending)});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colFirstName,
            this.colLastName,
            this.colGender,
            this.colBirthDate,
            this.colFullName,
            this.colCustomerId,
            this.colMiddleName,
            this.colEmail,
            this.colAddress,
            this.colPhone,
            this.colComments});
            this.gridView1.CustomizationFormBounds = new System.Drawing.Rectangle(563, 394, 216, 199);
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.OptionsView.ShowIndicator = false;
            this.gridView1.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            this.gridView1.ColumnFilterChanged += new System.EventHandler(this.gridView1_ColumnFilterChanged);
            // 
            // colFirstName
            // 
            this.colFirstName.FieldName = "FirstName";
            this.colFirstName.Name = "colFirstName";
            this.colFirstName.OptionsColumn.AllowFocus = false;
            this.colFirstName.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            // 
            // colLastName
            // 
            this.colLastName.FieldName = "LastName";
            this.colLastName.Name = "colLastName";
            this.colLastName.OptionsColumn.AllowFocus = false;
            this.colLastName.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            // 
            // colGender
            // 
            this.colGender.FieldName = "Gender";
            this.colGender.Name = "colGender";
            this.colGender.OptionsColumn.AllowFocus = false;
            this.colGender.OptionsColumn.AllowMove = false;
            this.colGender.OptionsColumn.FixedWidth = true;
            this.colGender.OptionsColumn.ShowCaption = false;
            this.colGender.OptionsFilter.AllowAutoFilter = false;
            this.colGender.Visible = true;
            this.colGender.VisibleIndex = 0;
            this.colGender.Width = 30;
            // 
            // colBirthDate
            // 
            this.colBirthDate.FieldName = "BirthDate";
            this.colBirthDate.Name = "colBirthDate";
            this.colBirthDate.OptionsColumn.AllowFocus = false;
            this.colBirthDate.Width = 99;
            // 
            // colFullName
            // 
            this.colFullName.Caption = "Name";
            this.colFullName.FieldName = "FullName";
            this.colFullName.Name = "colFullName";
            this.colFullName.OptionsColumn.AllowFocus = false;
            this.colFullName.OptionsColumn.ReadOnly = true;
            this.colFullName.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colFullName.Visible = true;
            this.colFullName.VisibleIndex = 2;
            this.colFullName.Width = 180;
            // 
            // colCustomerId
            // 
            this.colCustomerId.AppearanceCell.Options.UseTextOptions = true;
            this.colCustomerId.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colCustomerId.Caption = "Card Number";
            this.colCustomerId.FieldName = "CustomerId";
            this.colCustomerId.Name = "colCustomerId";
            this.colCustomerId.OptionsColumn.AllowFocus = false;
            this.colCustomerId.Visible = true;
            this.colCustomerId.VisibleIndex = 1;
            this.colCustomerId.Width = 92;
            // 
            // colMiddleName
            // 
            this.colMiddleName.FieldName = "MiddleName";
            this.colMiddleName.Name = "colMiddleName";
            this.colMiddleName.OptionsColumn.AllowFocus = false;
            this.colMiddleName.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            // 
            // colEmail
            // 
            this.colEmail.FieldName = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.OptionsColumn.AllowFocus = false;
            this.colEmail.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            // 
            // colAddress
            // 
            this.colAddress.FieldName = "Address";
            this.colAddress.Name = "colAddress";
            this.colAddress.OptionsColumn.AllowFocus = false;
            this.colAddress.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colAddress.Visible = true;
            this.colAddress.VisibleIndex = 4;
            this.colAddress.Width = 173;
            // 
            // colPhone
            // 
            this.colPhone.FieldName = "Phone";
            this.colPhone.Name = "colPhone";
            this.colPhone.OptionsColumn.AllowFocus = false;
            this.colPhone.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colPhone.Visible = true;
            this.colPhone.VisibleIndex = 3;
            this.colPhone.Width = 100;
            // 
            // colComments
            // 
            this.colComments.FieldName = "Comments";
            this.colComments.Name = "colComments";
            this.colComments.OptionsColumn.AllowFocus = false;
            this.colComments.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            // 
            // lcMain
            // 
            this.lcMain.AllowCustomizationMenu = false;
            this.lcMain.Controls.Add(this.ucCustomerInfo1);
            this.lcMain.Controls.Add(this.gridControl1);
            this.lcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcMain.Location = new System.Drawing.Point(12, 12);
            this.lcMain.Name = "lcMain";
            this.lcMain.Root = this.lcgMain;
            this.lcMain.Size = new System.Drawing.Size(799, 418);
            this.lcMain.TabIndex = 0;
            this.lcMain.Text = "layoutControl1";
            // 
            // ucCustomerInfo1
            // 
            this.ucCustomerInfo1.Location = new System.Drawing.Point(584, 0);
            this.ucCustomerInfo1.Margin = new System.Windows.Forms.Padding(0);
            this.ucCustomerInfo1.Name = "ucCustomerInfo1";
            this.ucCustomerInfo1.Size = new System.Drawing.Size(215, 418);
            this.ucCustomerInfo1.TabIndex = 4;
            // 
            // lcgMain
            // 
            this.lcgMain.CustomizationFormText = "Root";
            this.lcgMain.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.lcgMain.GroupBordersVisible = false;
            this.lcgMain.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciGrid,
            this.siMain,
            this.lciCustomerInfo});
            this.lcgMain.Location = new System.Drawing.Point(0, 0);
            this.lcgMain.Name = "Root";
            this.lcgMain.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.lcgMain.Size = new System.Drawing.Size(799, 418);
            this.lcgMain.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.lcgMain.Text = "Root";
            this.lcgMain.TextVisible = false;
            // 
            // lciGrid
            // 
            this.lciGrid.Control = this.gridControl1;
            this.lciGrid.CustomizationFormText = "lciGrid";
            this.lciGrid.Location = new System.Drawing.Point(0, 0);
            this.lciGrid.Name = "lciGrid";
            this.lciGrid.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.lciGrid.Size = new System.Drawing.Size(578, 418);
            this.lciGrid.Text = "lciGrid";
            this.lciGrid.TextSize = new System.Drawing.Size(0, 0);
            this.lciGrid.TextToControlDistance = 0;
            this.lciGrid.TextVisible = false;
            // 
            // siMain
            // 
            this.siMain.AllowHotTrack = true;
            this.siMain.CustomizationFormText = "siMain";
            this.siMain.Location = new System.Drawing.Point(578, 0);
            this.siMain.Name = "siMain";
            this.siMain.Size = new System.Drawing.Size(6, 418);
            // 
            // lciCustomerInfo
            // 
            this.lciCustomerInfo.Control = this.ucCustomerInfo1;
            this.lciCustomerInfo.CustomizationFormText = "lciCustomerInfo";
            this.lciCustomerInfo.Location = new System.Drawing.Point(584, 0);
            this.lciCustomerInfo.Name = "lciCustomerInfo";
            this.lciCustomerInfo.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.lciCustomerInfo.Size = new System.Drawing.Size(215, 418);
            this.lciCustomerInfo.Text = "lciCustomerInfo";
            this.lciCustomerInfo.TextSize = new System.Drawing.Size(0, 0);
            this.lciCustomerInfo.TextToControlDistance = 0;
            this.lciCustomerInfo.TextVisible = false;
            // 
            // frmFindCustomer
            // 
            this.AcceptButton = this.sbOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.sbClose;
            this.ClientSize = new System.Drawing.Size(823, 476);
            this.Controls.Add(this.lcMain);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.pcButtons);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFindCustomer";
            this.Padding = new System.Windows.Forms.Padding(12);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Find Customer";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcButtons)).EndInit();
            this.pcButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcSpace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xcCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).EndInit();
            this.lcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lcgMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCustomerInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl pcButtons;
        private DevExpress.XtraEditors.SimpleButton sbClear;
        private DevExpress.XtraEditors.PanelControl pcSpace;
        private DevExpress.XtraEditors.SimpleButton sbClose;
        private DevExpress.XtraEditors.SimpleButton sbOK;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.Xpo.XPCollection xcCustomers;
        private DevExpress.XtraGrid.Columns.GridColumn colFirstName;
        private DevExpress.XtraGrid.Columns.GridColumn colLastName;
        private DevExpress.XtraGrid.Columns.GridColumn colGender;
        private DevExpress.XtraGrid.Columns.GridColumn colBirthDate;
        private DevExpress.XtraGrid.Columns.GridColumn colFullName;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerId;
        private DevExpress.XtraGrid.Columns.GridColumn colMiddleName;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colPhone;
        private DevExpress.XtraGrid.Columns.GridColumn colComments;
        private DevExpress.XtraLayout.LayoutControl lcMain;
        private DevExpress.XtraLayout.LayoutControlGroup lcgMain;
        private DevExpress.XtraLayout.LayoutControlItem lciGrid;
        private DevExpress.XtraLayout.SplitterItem siMain;
        private NukaCollect.Win.Controls.ucCustomerInfo ucCustomerInfo1;
        private DevExpress.XtraLayout.LayoutControlItem lciCustomerInfo;
    }
}
