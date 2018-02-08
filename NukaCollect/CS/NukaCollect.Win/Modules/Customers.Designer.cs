namespace NukaCollect.Win.Modules {
    partial class Customers {
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
            this.xcCustomers = new DevExpress.Xpo.XPCollection();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.advBandedGridView1 = new DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView();
            this.gbPhoto = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colPhoto = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.repositoryItemPictureEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.gbData = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colCustomerId = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colName1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colBirthDate = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colPhone = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colEmail = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colGender = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gbAddress = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colAddress = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.repositoryItemMemoEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.gbComments = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colComments = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.repositoryItemMemoEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.colLevel = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colDiscount = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.repositoryItemMemoExEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit();
            this.repositoryItemImageEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGender2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBirthDate2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCardNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddress2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhone2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhoto2 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.xcCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advBandedGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoExEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // xcCustomers
            // 
            this.xcCustomers.LoadingEnabled = false;
            this.xcCustomers.ObjectType = typeof(NukaCollect.Customer);
            this.xcCustomers.Sorting.AddRange(new DevExpress.Xpo.SortProperty[] {
            new DevExpress.Xpo.SortProperty("[CustomerId]", DevExpress.Xpo.DB.SortingDirection.Ascending)});
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.xcCustomers;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(6, 6);
            this.gridControl1.MainView = this.advBandedGridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemPictureEdit1,
            this.repositoryItemMemoEdit1,
            this.repositoryItemMemoExEdit1,
            this.repositoryItemMemoEdit2,
            this.repositoryItemImageEdit1});
            this.gridControl1.ShowOnlyPredefinedDetails = true;
            this.gridControl1.Size = new System.Drawing.Size(941, 559);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.advBandedGridView1,
            this.gridView1});
            // 
            // advBandedGridView1
            // 
            this.advBandedGridView1.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gbPhoto,
            this.gbData,
            this.gbAddress,
            this.gbComments});
            this.advBandedGridView1.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.colName1,
            this.colGender,
            this.colBirthDate,
            this.colCustomerId,
            this.colEmail,
            this.colAddress,
            this.colPhone,
            this.colComments,
            this.colPhoto,
            this.colLevel,
            this.colDiscount});
            this.advBandedGridView1.GridControl = this.gridControl1;
            this.advBandedGridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "Oid", null, "")});
            this.advBandedGridView1.Name = "advBandedGridView1";
            this.advBandedGridView1.OptionsBehavior.Editable = false;
            this.advBandedGridView1.OptionsCustomization.AllowQuickHideColumns = false;
            this.advBandedGridView1.OptionsFind.AlwaysVisible = true;
            this.advBandedGridView1.OptionsView.ColumnAutoWidth = true;
            this.advBandedGridView1.OptionsView.ShowBands = false;
            this.advBandedGridView1.OptionsView.ShowGroupPanel = false;
            this.advBandedGridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.advBandedGridView1_FocusedRowChanged);
            this.advBandedGridView1.FocusedColumnChanged += new DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventHandler(this.advBandedGridView1_FocusedColumnChanged);
            this.advBandedGridView1.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.advBandedGridView1_CustomDrawCell);
            this.advBandedGridView1.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(this.advBandedGridView1_PopupMenuShowing);
            this.advBandedGridView1.CustomDrawColumnHeader += new DevExpress.XtraGrid.Views.Grid.ColumnHeaderCustomDrawEventHandler(this.advBandedGridView1_CustomDrawColumnHeader);
            // 
            // gbPhoto
            // 
            this.gbPhoto.Caption = "Photo";
            this.gbPhoto.Columns.Add(this.colPhoto);
            this.gbPhoto.Name = "gbPhoto";
            this.gbPhoto.OptionsBand.FixedWidth = true;
            this.gbPhoto.Width = 43;
            // 
            // colPhoto
            // 
            this.colPhoto.AutoFillDown = true;
            this.colPhoto.ColumnEdit = this.repositoryItemPictureEdit1;
            this.colPhoto.FieldName = "Photo";
            this.colPhoto.Name = "colPhoto";
            this.colPhoto.OptionsColumn.AllowFocus = false;
            this.colPhoto.OptionsColumn.AllowSize = false;
            this.colPhoto.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colPhoto.OptionsColumn.FixedWidth = true;
            this.colPhoto.OptionsFilter.AllowAutoFilter = false;
            this.colPhoto.OptionsFilter.AllowFilter = false;
            this.colPhoto.Visible = true;
            this.colPhoto.Width = 43;
            // 
            // repositoryItemPictureEdit1
            // 
            this.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1";
            this.repositoryItemPictureEdit1.NullText = " ";
            this.repositoryItemPictureEdit1.PictureInterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            this.repositoryItemPictureEdit1.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            // 
            // gbData
            // 
            this.gbData.Caption = "Data";
            this.gbData.Columns.Add(this.colCustomerId);
            this.gbData.Columns.Add(this.colName1);
            this.gbData.Columns.Add(this.colBirthDate);
            this.gbData.Columns.Add(this.colPhone);
            this.gbData.Columns.Add(this.colEmail);
            this.gbData.Columns.Add(this.colGender);
            this.gbData.Name = "gbData";
            this.gbData.Width = 497;
            // 
            // colCustomerId
            // 
            this.colCustomerId.AppearanceCell.Options.UseTextOptions = true;
            this.colCustomerId.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colCustomerId.Caption = "Card Number";
            this.colCustomerId.FieldName = "CustomerId";
            this.colCustomerId.Name = "colCustomerId";
            this.colCustomerId.OptionsColumn.AllowFocus = false;
            this.colCustomerId.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colCustomerId.Visible = true;
            this.colCustomerId.Width = 107;
            // 
            // colName1
            // 
            this.colName1.Caption = "Name";
            this.colName1.FieldName = "FullName";
            this.colName1.Name = "colName1";
            this.colName1.OptionsColumn.AllowFocus = false;
            this.colName1.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colName1.Visible = true;
            this.colName1.Width = 246;
            // 
            // colBirthDate
            // 
            this.colBirthDate.FieldName = "BirthDate";
            this.colBirthDate.Name = "colBirthDate";
            this.colBirthDate.OptionsColumn.AllowFocus = false;
            this.colBirthDate.Visible = true;
            this.colBirthDate.Width = 144;
            // 
            // colPhone
            // 
            this.colPhone.FieldName = "Phone";
            this.colPhone.Name = "colPhone";
            this.colPhone.OptionsColumn.AllowFocus = false;
            this.colPhone.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colPhone.RowIndex = 1;
            this.colPhone.Visible = true;
            this.colPhone.Width = 107;
            // 
            // colEmail
            // 
            this.colEmail.FieldName = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.OptionsColumn.AllowFocus = false;
            this.colEmail.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colEmail.RowIndex = 1;
            this.colEmail.Visible = true;
            this.colEmail.Width = 246;
            // 
            // colGender
            // 
            this.colGender.FieldName = "Gender";
            this.colGender.Name = "colGender";
            this.colGender.OptionsColumn.AllowFocus = false;
            this.colGender.RowIndex = 1;
            this.colGender.Visible = true;
            this.colGender.Width = 144;
            // 
            // gbAddress
            // 
            this.gbAddress.Caption = "Address";
            this.gbAddress.Columns.Add(this.colAddress);
            this.gbAddress.Name = "gbAddress";
            this.gbAddress.Width = 172;
            // 
            // colAddress
            // 
            this.colAddress.AutoFillDown = true;
            this.colAddress.ColumnEdit = this.repositoryItemMemoEdit1;
            this.colAddress.FieldName = "Address";
            this.colAddress.Name = "colAddress";
            this.colAddress.OptionsColumn.AllowFocus = false;
            this.colAddress.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colAddress.Visible = true;
            this.colAddress.Width = 172;
            // 
            // repositoryItemMemoEdit1
            // 
            this.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1";
            // 
            // gbComments
            // 
            this.gbComments.Caption = "Comments";
            this.gbComments.Columns.Add(this.colComments);
            this.gbComments.Columns.Add(this.colLevel);
            this.gbComments.Columns.Add(this.colDiscount);
            this.gbComments.Name = "gbComments";
            this.gbComments.Width = 208;
            // 
            // colComments
            // 
            this.colComments.AutoFillDown = true;
            this.colComments.ColumnEdit = this.repositoryItemMemoEdit2;
            this.colComments.FieldName = "Comments";
            this.colComments.Name = "colComments";
            this.colComments.OptionsColumn.AllowFocus = false;
            this.colComments.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colComments.Visible = true;
            this.colComments.Width = 208;
            // 
            // repositoryItemMemoEdit2
            // 
            this.repositoryItemMemoEdit2.Name = "repositoryItemMemoEdit2";
            // 
            // colLevel
            // 
            this.colLevel.FieldName = "DiscountLevel";
            this.colLevel.Name = "colLevel";
            this.colLevel.OptionsColumn.AllowFocus = false;
            this.colLevel.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colLevel.RowIndex = 1;
            this.colLevel.Visible = true;
            this.colLevel.Width = 101;
            // 
            // colDiscount
            // 
            this.colDiscount.DisplayFormat.FormatString = "P";
            this.colDiscount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDiscount.FieldName = "Discount";
            this.colDiscount.Name = "colDiscount";
            this.colDiscount.OptionsColumn.AllowFocus = false;
            this.colDiscount.RowIndex = 1;
            this.colDiscount.Visible = true;
            this.colDiscount.Width = 107;
            // 
            // repositoryItemMemoExEdit1
            // 
            this.repositoryItemMemoExEdit1.AutoHeight = false;
            this.repositoryItemMemoExEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemMemoExEdit1.Name = "repositoryItemMemoExEdit1";
            // 
            // repositoryItemImageEdit1
            // 
            this.repositoryItemImageEdit1.AutoHeight = false;
            this.repositoryItemImageEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageEdit1.Name = "repositoryItemImageEdit1";
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName,
            this.colGender2,
            this.colBirthDate2,
            this.colCardNumber,
            this.colAddress2,
            this.colPhone2,
            this.gridColumn10,
            this.colPhoto2});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.advBandedGridView1_FocusedRowChanged);
            this.gridView1.FocusedColumnChanged += new DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventHandler(this.advBandedGridView1_FocusedColumnChanged);
            this.gridView1.CustomDrawColumnHeader += new DevExpress.XtraGrid.Views.Grid.ColumnHeaderCustomDrawEventHandler(this.advBandedGridView1_CustomDrawColumnHeader);
            // 
            // colName
            // 
            this.colName.Caption = "Name";
            this.colName.FieldName = "FullName";
            this.colName.Name = "colName";
            this.colName.OptionsColumn.AllowFocus = false;
            this.colName.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colName.Visible = true;
            this.colName.VisibleIndex = 2;
            // 
            // colGender2
            // 
            this.colGender2.FieldName = "Gender";
            this.colGender2.Name = "colGender2";
            this.colGender2.OptionsColumn.AllowFocus = false;
            this.colGender2.OptionsColumn.FixedWidth = true;
            this.colGender2.OptionsColumn.ShowCaption = false;
            this.colGender2.OptionsFilter.AllowAutoFilter = false;
            this.colGender2.Visible = true;
            this.colGender2.VisibleIndex = 0;
            this.colGender2.Width = 40;
            // 
            // colBirthDate2
            // 
            this.colBirthDate2.FieldName = "BirthDate";
            this.colBirthDate2.Name = "colBirthDate2";
            this.colBirthDate2.OptionsColumn.AllowFocus = false;
            this.colBirthDate2.Visible = true;
            this.colBirthDate2.VisibleIndex = 3;
            // 
            // colCardNumber
            // 
            this.colCardNumber.AppearanceCell.Options.UseTextOptions = true;
            this.colCardNumber.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colCardNumber.Caption = "Card Number";
            this.colCardNumber.FieldName = "CustomerId";
            this.colCardNumber.Name = "colCardNumber";
            this.colCardNumber.OptionsColumn.AllowFocus = false;
            this.colCardNumber.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colCardNumber.Visible = true;
            this.colCardNumber.VisibleIndex = 1;
            // 
            // colAddress2
            // 
            this.colAddress2.FieldName = "Address";
            this.colAddress2.Name = "colAddress2";
            this.colAddress2.OptionsColumn.AllowFocus = false;
            this.colAddress2.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colAddress2.Visible = true;
            this.colAddress2.VisibleIndex = 4;
            // 
            // colPhone2
            // 
            this.colPhone2.FieldName = "Phone";
            this.colPhone2.Name = "colPhone2";
            this.colPhone2.OptionsColumn.AllowFocus = false;
            this.colPhone2.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colPhone2.Visible = true;
            this.colPhone2.VisibleIndex = 5;
            // 
            // gridColumn10
            // 
            this.gridColumn10.ColumnEdit = this.repositoryItemMemoExEdit1;
            this.gridColumn10.FieldName = "Comments";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.OptionsColumn.AllowFocus = false;
            this.gridColumn10.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 7;
            // 
            // colPhoto2
            // 
            this.colPhoto2.ColumnEdit = this.repositoryItemImageEdit1;
            this.colPhoto2.FieldName = "Photo";
            this.colPhoto2.Name = "colPhoto2";
            this.colPhoto2.OptionsColumn.AllowFocus = false;
            this.colPhoto2.OptionsFilter.AllowAutoFilter = false;
            this.colPhoto2.OptionsFilter.AllowFilter = false;
            this.colPhoto2.Visible = true;
            this.colPhoto2.VisibleIndex = 6;
            // 
            // Customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Name = "Customers";
            this.Padding = new System.Windows.Forms.Padding(6);
            this.Size = new System.Drawing.Size(953, 571);
            ((System.ComponentModel.ISupportInitialize)(this.xcCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advBandedGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoExEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Xpo.XPCollection xcCustomers;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView advBandedGridView1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colPhoto;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colCustomerId;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colName1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colGender;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colBirthDate;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colEmail;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colPhone;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colAddress;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colComments;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colLevel;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gbPhoto;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gbData;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gbAddress;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gbComments;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colDiscount;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colGender2;
        private DevExpress.XtraGrid.Columns.GridColumn colBirthDate2;
        private DevExpress.XtraGrid.Columns.GridColumn colCardNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colAddress2;
        private DevExpress.XtraGrid.Columns.GridColumn colPhone2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn colPhoto2;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit repositoryItemMemoExEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit2;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageEdit repositoryItemImageEdit1;
    }
}
