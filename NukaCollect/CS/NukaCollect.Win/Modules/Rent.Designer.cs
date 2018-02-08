namespace NukaCollect.Win.Modules {
    partial class Rent {
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
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition1 = new DevExpress.XtraGrid.StyleFormatCondition();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode2 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode3 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition2 = new DevExpress.XtraGrid.StyleFormatCondition();
            this.colActive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gvRents = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colRentId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReturnedOn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDays = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMovieInfo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPaymentRent = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcReceipts = new DevExpress.XtraGrid.GridControl();
            this.gvOverdue = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colOverdueRentId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMovieInfoOverdue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOverdue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOverduePayment = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gvSales = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSaleId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMovieInfoSale = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPaymentSale = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gvReceipts = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPayment = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReceiptId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiscount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOverdueActive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lcMain = new DevExpress.XtraLayout.LayoutControl();
            this.gcActiveRents = new DevExpress.XtraGrid.GridControl();
            this.gvActiveRents = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colRentIdActive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDaysActive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colActiveRent = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRentedOn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPaymentActive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMovieTitleActive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colActiveType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReturn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colItemFormat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ucCustomerInfo1 = new NukaCollect.Win.Controls.ucCustomerInfo();
            this.lcgMain = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciCustomerInfo = new DevExpress.XtraLayout.LayoutControlItem();
            this.splitterItem1 = new DevExpress.XtraLayout.SplitterItem();
            this.tcgViews = new DevExpress.XtraLayout.TabbedControlGroup();
            this.lcgReceipts = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciRecepts = new DevExpress.XtraLayout.LayoutControlItem();
            this.lcgActiveRents = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciActiveRents = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.gvRents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcReceipts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvOverdue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvReceipts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).BeginInit();
            this.lcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcActiveRents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvActiveRents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCustomerInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tcgViews)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgReceipts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciRecepts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgActiveRents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciActiveRents)).BeginInit();
            this.SuspendLayout();
            // 
            // colActive
            // 
            this.colActive.FieldName = "Active";
            this.colActive.Name = "colActive";
            this.colActive.OptionsColumn.AllowFocus = false;
            this.colActive.Visible = true;
            this.colActive.VisibleIndex = 4;
            this.colActive.Width = 82;
            // 
            // gvRents
            // 
            this.gvRents.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colRentId,
            this.colReturnedOn,
            this.colDays,
            this.colActive,
            this.colMovieInfo,
            this.colPaymentRent});
            styleFormatCondition1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            styleFormatCondition1.Appearance.Options.UseFont = true;
            styleFormatCondition1.ApplyToRow = true;
            styleFormatCondition1.Column = this.colActive;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
            styleFormatCondition1.Value1 = true;
            this.gvRents.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1});
            this.gvRents.GridControl = this.gcReceipts;
            this.gvRents.Name = "gvRents";
            this.gvRents.OptionsBehavior.Editable = false;
            this.gvRents.OptionsView.AllowHtmlDrawHeaders = true;
            this.gvRents.OptionsView.ShowGroupPanel = false;
            this.gvRents.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False;
            // 
            // colRentId
            // 
            this.colRentId.AppearanceCell.Options.UseTextOptions = true;
            this.colRentId.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colRentId.Caption = "<b>Rental</b> Id";
            this.colRentId.DisplayFormat.FormatString = "d8";
            this.colRentId.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colRentId.FieldName = "RentId";
            this.colRentId.Name = "colRentId";
            this.colRentId.OptionsColumn.AllowFocus = false;
            this.colRentId.Visible = true;
            this.colRentId.VisibleIndex = 0;
            this.colRentId.Width = 100;
            // 
            // colReturnedOn
            // 
            this.colReturnedOn.FieldName = "ReturnedOn";
            this.colReturnedOn.Name = "colReturnedOn";
            this.colReturnedOn.OptionsColumn.AllowFocus = false;
            this.colReturnedOn.Visible = true;
            this.colReturnedOn.VisibleIndex = 2;
            this.colReturnedOn.Width = 82;
            // 
            // colDays
            // 
            this.colDays.FieldName = "Days";
            this.colDays.Name = "colDays";
            this.colDays.OptionsColumn.AllowFocus = false;
            this.colDays.Visible = true;
            this.colDays.VisibleIndex = 3;
            this.colDays.Width = 82;
            // 
            // colMovieInfo
            // 
            this.colMovieInfo.Caption = "Movie";
            this.colMovieInfo.FieldName = "MovieInfo";
            this.colMovieInfo.Name = "colMovieInfo";
            this.colMovieInfo.OptionsColumn.AllowFocus = false;
            this.colMovieInfo.Visible = true;
            this.colMovieInfo.VisibleIndex = 1;
            this.colMovieInfo.Width = 248;
            // 
            // colPaymentRent
            // 
            this.colPaymentRent.DisplayFormat.FormatString = "c";
            this.colPaymentRent.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPaymentRent.FieldName = "Payment";
            this.colPaymentRent.Name = "colPaymentRent";
            this.colPaymentRent.OptionsColumn.AllowFocus = false;
            this.colPaymentRent.Visible = true;
            this.colPaymentRent.VisibleIndex = 5;
            this.colPaymentRent.Width = 96;
            // 
            // gcReceipts
            // 
            gridLevelNode1.LevelTemplate = this.gvRents;
            gridLevelNode1.RelationName = "Rents";
            gridLevelNode2.LevelTemplate = this.gvOverdue;
            gridLevelNode2.RelationName = "OverdueRents";
            gridLevelNode3.LevelTemplate = this.gvSales;
            gridLevelNode3.RelationName = "Sales";
            this.gcReceipts.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1,
            gridLevelNode2,
            gridLevelNode3});
            this.gcReceipts.Location = new System.Drawing.Point(241, 24);
            this.gcReceipts.MainView = this.gvReceipts;
            this.gcReceipts.Name = "gcReceipts";
            this.gcReceipts.ShowOnlyPredefinedDetails = true;
            this.gcReceipts.Size = new System.Drawing.Size(724, 498);
            this.gcReceipts.TabIndex = 1;
            this.gcReceipts.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvOverdue,
            this.gvSales,
            this.gvReceipts,
            this.gvRents});
            // 
            // gvOverdue
            // 
            this.gvOverdue.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colOverdueRentId,
            this.colMovieInfoOverdue,
            this.colOverdue,
            this.colOverduePayment});
            this.gvOverdue.GridControl = this.gcReceipts;
            this.gvOverdue.Name = "gvOverdue";
            this.gvOverdue.OptionsBehavior.Editable = false;
            this.gvOverdue.OptionsView.AllowHtmlDrawHeaders = true;
            this.gvOverdue.OptionsView.ShowGroupPanel = false;
            this.gvOverdue.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False;
            // 
            // colOverdueRentId
            // 
            this.colOverdueRentId.AppearanceCell.Options.UseTextOptions = true;
            this.colOverdueRentId.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colOverdueRentId.Caption = "<b>Rental</b> Id";
            this.colOverdueRentId.DisplayFormat.FormatString = "d8";
            this.colOverdueRentId.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colOverdueRentId.FieldName = "RentId";
            this.colOverdueRentId.Name = "colOverdueRentId";
            this.colOverdueRentId.OptionsColumn.AllowFocus = false;
            this.colOverdueRentId.Visible = true;
            this.colOverdueRentId.VisibleIndex = 0;
            this.colOverdueRentId.Width = 102;
            // 
            // colMovieInfoOverdue
            // 
            this.colMovieInfoOverdue.Caption = "Movie";
            this.colMovieInfoOverdue.FieldName = "MovieInfo";
            this.colMovieInfoOverdue.Name = "colMovieInfoOverdue";
            this.colMovieInfoOverdue.OptionsColumn.AllowFocus = false;
            this.colMovieInfoOverdue.Visible = true;
            this.colMovieInfoOverdue.VisibleIndex = 1;
            this.colMovieInfoOverdue.Width = 312;
            // 
            // colOverdue
            // 
            this.colOverdue.Caption = "Days Overdue";
            this.colOverdue.FieldName = "Overdue";
            this.colOverdue.Name = "colOverdue";
            this.colOverdue.OptionsColumn.AllowFocus = false;
            this.colOverdue.Visible = true;
            this.colOverdue.VisibleIndex = 2;
            this.colOverdue.Width = 134;
            // 
            // colOverduePayment
            // 
            this.colOverduePayment.Caption = "Payment <b>Due</b>";
            this.colOverduePayment.DisplayFormat.FormatString = "c";
            this.colOverduePayment.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colOverduePayment.FieldName = "OverduePayment";
            this.colOverduePayment.Name = "colOverduePayment";
            this.colOverduePayment.OptionsColumn.AllowFocus = false;
            this.colOverduePayment.Visible = true;
            this.colOverduePayment.VisibleIndex = 3;
            this.colOverduePayment.Width = 142;
            // 
            // gvSales
            // 
            this.gvSales.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSaleId,
            this.colMovieInfoSale,
            this.colPaymentSale});
            this.gvSales.GridControl = this.gcReceipts;
            this.gvSales.Name = "gvSales";
            this.gvSales.OptionsBehavior.Editable = false;
            this.gvSales.OptionsView.AllowHtmlDrawHeaders = true;
            this.gvSales.OptionsView.ShowGroupPanel = false;
            this.gvSales.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False;
            // 
            // colSaleId
            // 
            this.colSaleId.AppearanceCell.Options.UseTextOptions = true;
            this.colSaleId.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colSaleId.Caption = "<b>Purchase</b> Id";
            this.colSaleId.DisplayFormat.FormatString = "d8";
            this.colSaleId.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSaleId.FieldName = "RentId";
            this.colSaleId.Name = "colSaleId";
            this.colSaleId.OptionsColumn.AllowFocus = false;
            this.colSaleId.Visible = true;
            this.colSaleId.VisibleIndex = 0;
            this.colSaleId.Width = 110;
            // 
            // colMovieInfoSale
            // 
            this.colMovieInfoSale.Caption = "Movie";
            this.colMovieInfoSale.FieldName = "MovieInfo";
            this.colMovieInfoSale.Name = "colMovieInfoSale";
            this.colMovieInfoSale.OptionsColumn.AllowFocus = false;
            this.colMovieInfoSale.Visible = true;
            this.colMovieInfoSale.VisibleIndex = 1;
            this.colMovieInfoSale.Width = 406;
            // 
            // colPaymentSale
            // 
            this.colPaymentSale.DisplayFormat.FormatString = "c";
            this.colPaymentSale.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPaymentSale.FieldName = "Payment";
            this.colPaymentSale.Name = "colPaymentSale";
            this.colPaymentSale.OptionsColumn.AllowFocus = false;
            this.colPaymentSale.Visible = true;
            this.colPaymentSale.VisibleIndex = 2;
            this.colPaymentSale.Width = 187;
            // 
            // gvReceipts
            // 
            this.gvReceipts.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gvReceipts.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDate,
            this.colPayment,
            this.colReceiptId,
            this.colType,
            this.colDiscount});
            this.gvReceipts.DetailTabHeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Left;
            this.gvReceipts.DetailVerticalIndent = 8;
            this.gvReceipts.GridControl = this.gcReceipts;
            this.gvReceipts.GroupCount = 1;
            this.gvReceipts.OptionsView.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.Hidden;
            this.gvReceipts.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "ReceiptId", null, ""),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Payment", this.colPayment, "SUM={0:c}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Discount", this.colDiscount, "SUM={0:c}")});
            this.gvReceipts.Name = "gvReceipts";
            this.gvReceipts.OptionsBehavior.Editable = false;
            this.gvReceipts.OptionsDetail.ShowDetailTabs = false;
            this.gvReceipts.OptionsDetail.SmartDetailExpandButtonMode = DevExpress.XtraGrid.Views.Grid.DetailExpandButtonMode.CheckAllDetails;
            this.gvReceipts.OptionsPrint.ExpandAllDetails = true;
            this.gvReceipts.OptionsPrint.PrintDetails = true;
            this.gvReceipts.OptionsView.ShowAutoFilterRow = true;
            this.gvReceipts.OptionsView.ShowFooter = true;
            this.gvReceipts.OptionsView.ShowIndicator = false;
            this.gvReceipts.OptionsView.ShowViewCaption = true;
            this.gvReceipts.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colType, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colReceiptId, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gvReceipts.SynchronizeClones = false;
            this.gvReceipts.ViewCaption = "Receipts period";
            this.gvReceipts.MasterRowGetLevelDefaultView += new DevExpress.XtraGrid.Views.Grid.MasterRowGetLevelDefaultViewEventHandler(this.gvReceipts_MasterRowGetLevelDefaultView);
            this.gvReceipts.MasterRowGetRelationDisplayCaption += new DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationNameEventHandler(this.gvReceipts_MasterRowGetRelationDisplayCaption);
            this.gvReceipts.EndGrouping += new System.EventHandler(this.gvReceipts_EndGrouping);
            // 
            // colDate
            // 
            this.colDate.FieldName = "Date";
            this.colDate.Name = "colDate";
            this.colDate.OptionsColumn.AllowFocus = false;
            this.colDate.Visible = true;
            this.colDate.VisibleIndex = 1;
            this.colDate.Width = 184;
            // 
            // colPayment
            // 
            this.colPayment.DisplayFormat.FormatString = "c";
            this.colPayment.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPayment.FieldName = "Payment";
            this.colPayment.Name = "colPayment";
            this.colPayment.OptionsColumn.AllowFocus = false;
            this.colPayment.SummaryItem.DisplayFormat = "SUM={0:c}";
            this.colPayment.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colPayment.Visible = true;
            this.colPayment.VisibleIndex = 3;
            this.colPayment.Width = 158;
            // 
            // colReceiptId
            // 
            this.colReceiptId.AppearanceCell.Options.UseTextOptions = true;
            this.colReceiptId.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colReceiptId.DisplayFormat.FormatString = "d8";
            this.colReceiptId.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colReceiptId.FieldName = "ReceiptId";
            this.colReceiptId.Name = "colReceiptId";
            this.colReceiptId.OptionsColumn.AllowFocus = false;
            this.colReceiptId.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colReceiptId.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count;
            this.colReceiptId.Visible = true;
            this.colReceiptId.VisibleIndex = 0;
            this.colReceiptId.Width = 205;
            // 
            // colType
            // 
            this.colType.FieldName = "Type";
            this.colType.Name = "colType";
            this.colType.OptionsColumn.AllowFocus = false;
            this.colType.Visible = true;
            this.colType.VisibleIndex = 1;
            this.colType.Width = 167;
            // 
            // colDiscount
            // 
            this.colDiscount.DisplayFormat.FormatString = "c";
            this.colDiscount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDiscount.FieldName = "Discount";
            this.colDiscount.Name = "colDiscount";
            this.colDiscount.OptionsColumn.AllowFocus = false;
            this.colDiscount.SummaryItem.DisplayFormat = "SUM={0:c}";
            this.colDiscount.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colDiscount.Visible = true;
            this.colDiscount.VisibleIndex = 2;
            this.colDiscount.Width = 159;
            // 
            // colOverdueActive
            // 
            this.colOverdueActive.Caption = "Days <b>Overdue</b>";
            this.colOverdueActive.DisplayFormat.FormatString = "0;(0)";
            this.colOverdueActive.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colOverdueActive.FieldName = "Overdue";
            this.colOverdueActive.Name = "colOverdueActive";
            this.colOverdueActive.OptionsColumn.AllowEdit = false;
            this.colOverdueActive.OptionsColumn.AllowFocus = false;
            this.colOverdueActive.OptionsColumn.ReadOnly = true;
            this.colOverdueActive.Visible = true;
            this.colOverdueActive.VisibleIndex = 7;
            this.colOverdueActive.Width = 103;
            // 
            // lcMain
            // 
            this.lcMain.AllowCustomizationMenu = false;
            this.lcMain.Controls.Add(this.gcActiveRents);
            this.lcMain.Controls.Add(this.ucCustomerInfo1);
            this.lcMain.Controls.Add(this.gcReceipts);
            this.lcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcMain.Location = new System.Drawing.Point(6, 6);
            this.lcMain.Name = "lcMain";
            this.lcMain.Root = this.lcgMain;
            this.lcMain.Size = new System.Drawing.Size(968, 525);
            this.lcMain.TabIndex = 2;
            this.lcMain.Text = "layoutControl1";
            // 
            // gcActiveRents
            // 
            this.gcActiveRents.Location = new System.Drawing.Point(241, 24);
            this.gcActiveRents.MainView = this.gvActiveRents;
            this.gcActiveRents.Name = "gcActiveRents";
            this.gcActiveRents.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.gcActiveRents.ShowOnlyPredefinedDetails = true;
            this.gcActiveRents.Size = new System.Drawing.Size(724, 498);
            this.gcActiveRents.TabIndex = 5;
            this.gcActiveRents.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvActiveRents});
            // 
            // gvActiveRents
            // 
            this.gvActiveRents.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gvActiveRents.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colRentIdActive,
            this.colDaysActive,
            this.colOverdueActive,
            this.colActiveRent,
            this.colRentedOn,
            this.colPaymentActive,
            this.colMovieTitleActive,
            this.colActiveType,
            this.colReturn,
            this.colItemFormat});
            styleFormatCondition2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            styleFormatCondition2.Appearance.Options.UseFont = true;
            styleFormatCondition2.ApplyToRow = true;
            styleFormatCondition2.Column = this.colOverdueActive;
            styleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Greater;
            styleFormatCondition2.Value1 = 0;
            this.gvActiveRents.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition2});
            this.gvActiveRents.GridControl = this.gcActiveRents;
            this.gvActiveRents.Name = "gvActiveRents";
            this.gvActiveRents.OptionsView.AllowHtmlDrawHeaders = true;
            this.gvActiveRents.OptionsView.ShowGroupPanel = false;
            this.gvActiveRents.OptionsView.ShowIndicator = false;
            this.gvActiveRents.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False;
            this.gvActiveRents.CustomUnboundColumnData += new DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(this.gvActiveRents_CustomUnboundColumnData);
            // 
            // colRentIdActive
            // 
            this.colRentIdActive.AppearanceCell.Options.UseTextOptions = true;
            this.colRentIdActive.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colRentIdActive.Caption = "<b>Rental</b> Id";
            this.colRentIdActive.DisplayFormat.FormatString = "d8";
            this.colRentIdActive.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colRentIdActive.FieldName = "RentId";
            this.colRentIdActive.Name = "colRentIdActive";
            this.colRentIdActive.OptionsColumn.AllowEdit = false;
            this.colRentIdActive.OptionsColumn.AllowFocus = false;
            this.colRentIdActive.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colRentIdActive.Visible = true;
            this.colRentIdActive.VisibleIndex = 2;
            this.colRentIdActive.Width = 92;
            // 
            // colDaysActive
            // 
            this.colDaysActive.FieldName = "Days";
            this.colDaysActive.Name = "colDaysActive";
            this.colDaysActive.OptionsColumn.AllowEdit = false;
            this.colDaysActive.OptionsColumn.AllowFocus = false;
            this.colDaysActive.Visible = true;
            this.colDaysActive.VisibleIndex = 6;
            this.colDaysActive.Width = 43;
            // 
            // colActiveRent
            // 
            this.colActiveRent.FieldName = "Active";
            this.colActiveRent.Name = "colActiveRent";
            this.colActiveRent.OptionsColumn.AllowFocus = false;
            this.colActiveRent.OptionsColumn.ReadOnly = true;
            // 
            // colRentedOn
            // 
            this.colRentedOn.FieldName = "RentedOn";
            this.colRentedOn.Name = "colRentedOn";
            this.colRentedOn.OptionsColumn.AllowEdit = false;
            this.colRentedOn.OptionsColumn.AllowFocus = false;
            this.colRentedOn.OptionsColumn.ReadOnly = true;
            this.colRentedOn.Visible = true;
            this.colRentedOn.VisibleIndex = 5;
            this.colRentedOn.Width = 68;
            // 
            // colPaymentActive
            // 
            this.colPaymentActive.DisplayFormat.FormatString = "c";
            this.colPaymentActive.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPaymentActive.FieldName = "Payment";
            this.colPaymentActive.Name = "colPaymentActive";
            this.colPaymentActive.OptionsColumn.AllowEdit = false;
            this.colPaymentActive.OptionsColumn.AllowFocus = false;
            this.colPaymentActive.Visible = true;
            this.colPaymentActive.VisibleIndex = 8;
            this.colPaymentActive.Width = 91;
            // 
            // colMovieTitleActive
            // 
            this.colMovieTitleActive.FieldName = "MovieTitle";
            this.colMovieTitleActive.Name = "colMovieTitleActive";
            this.colMovieTitleActive.OptionsColumn.AllowEdit = false;
            this.colMovieTitleActive.OptionsColumn.AllowFocus = false;
            this.colMovieTitleActive.OptionsColumn.ReadOnly = true;
            this.colMovieTitleActive.Visible = true;
            this.colMovieTitleActive.VisibleIndex = 3;
            this.colMovieTitleActive.Width = 216;
            // 
            // colActiveType
            // 
            this.colActiveType.FieldName = "ActiveType";
            this.colActiveType.ImageAlignment = System.Drawing.StringAlignment.Center;
            this.colActiveType.Name = "colActiveType";
            this.colActiveType.OptionsColumn.AllowEdit = false;
            this.colActiveType.OptionsColumn.AllowFocus = false;
            this.colActiveType.OptionsColumn.AllowMove = false;
            this.colActiveType.OptionsColumn.AllowSize = false;
            this.colActiveType.OptionsColumn.FixedWidth = true;
            this.colActiveType.OptionsColumn.ShowCaption = false;
            this.colActiveType.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colActiveType.Visible = true;
            this.colActiveType.VisibleIndex = 1;
            this.colActiveType.Width = 40;
            // 
            // colReturn
            // 
            this.colReturn.ColumnEdit = this.repositoryItemCheckEdit1;
            this.colReturn.FieldName = "Return";
            this.colReturn.ImageAlignment = System.Drawing.StringAlignment.Center;
            this.colReturn.Name = "colReturn";
            this.colReturn.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colReturn.OptionsColumn.AllowMove = false;
            this.colReturn.OptionsColumn.AllowSize = false;
            this.colReturn.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colReturn.OptionsColumn.FixedWidth = true;
            this.colReturn.OptionsColumn.ShowCaption = false;
            this.colReturn.OptionsFilter.AllowAutoFilter = false;
            this.colReturn.OptionsFilter.AllowFilter = false;
            this.colReturn.UnboundType = DevExpress.Data.UnboundColumnType.Boolean;
            this.colReturn.Visible = true;
            this.colReturn.VisibleIndex = 0;
            this.colReturn.Width = 40;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            this.repositoryItemCheckEdit1.CheckStateChanged += new System.EventHandler(this.repositoryItemCheckEdit1_CheckStateChanged);
            // 
            // colItemFormat
            // 
            this.colItemFormat.Caption = "Format";
            this.colItemFormat.FieldName = "ItemFormat";
            this.colItemFormat.Name = "colItemFormat";
            this.colItemFormat.OptionsColumn.AllowEdit = false;
            this.colItemFormat.OptionsColumn.AllowFocus = false;
            this.colItemFormat.Visible = true;
            this.colItemFormat.VisibleIndex = 4;
            this.colItemFormat.Width = 62;
            // 
            // ucCustomerInfo1
            // 
            this.ucCustomerInfo1.Location = new System.Drawing.Point(2, 2);
            this.ucCustomerInfo1.Name = "ucCustomerInfo1";
            this.ucCustomerInfo1.Size = new System.Drawing.Size(228, 521);
            this.ucCustomerInfo1.TabIndex = 4;
            this.ucCustomerInfo1.DoEdit += new System.EventHandler(this.ucCustomerInfo1_DoEdit);
            // 
            // lcgMain
            // 
            this.lcgMain.CustomizationFormText = "Root";
            this.lcgMain.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.lcgMain.GroupBordersVisible = false;
            this.lcgMain.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciCustomerInfo,
            this.splitterItem1,
            this.tcgViews});
            this.lcgMain.Location = new System.Drawing.Point(0, 0);
            this.lcgMain.Name = "lcgMain";
            this.lcgMain.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.lcgMain.Size = new System.Drawing.Size(968, 525);
            this.lcgMain.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.lcgMain.Text = "lcgMain";
            this.lcgMain.TextVisible = false;
            // 
            // lciCustomerInfo
            // 
            this.lciCustomerInfo.Control = this.ucCustomerInfo1;
            this.lciCustomerInfo.CustomizationFormText = "Current Customer:";
            this.lciCustomerInfo.Location = new System.Drawing.Point(0, 0);
            this.lciCustomerInfo.Name = "lciCustomerInfo";
            this.lciCustomerInfo.Size = new System.Drawing.Size(232, 525);
            this.lciCustomerInfo.Text = "Current Customer:";
            this.lciCustomerInfo.TextLocation = DevExpress.Utils.Locations.Top;
            this.lciCustomerInfo.TextSize = new System.Drawing.Size(0, 0);
            this.lciCustomerInfo.TextToControlDistance = 0;
            this.lciCustomerInfo.TextVisible = false;
            // 
            // splitterItem1
            // 
            this.splitterItem1.AllowHotTrack = true;
            this.splitterItem1.CustomizationFormText = "splitterItem1";
            this.splitterItem1.Location = new System.Drawing.Point(232, 0);
            this.splitterItem1.Name = "splitterItem1";
            this.splitterItem1.Size = new System.Drawing.Size(6, 525);
            // 
            // tcgViews
            // 
            this.tcgViews.CustomizationFormText = "tcgViews";
            this.tcgViews.Location = new System.Drawing.Point(238, 0);
            this.tcgViews.Name = "tcgViews";
            this.tcgViews.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.tcgViews.SelectedTabPage = this.lcgReceipts;
            this.tcgViews.SelectedTabPageIndex = 0;
            this.tcgViews.Size = new System.Drawing.Size(730, 525);
            this.tcgViews.TabPages.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lcgReceipts,
            this.lcgActiveRents});
            this.tcgViews.Text = "tcgViews";
            // 
            // lcgReceipts
            // 
            this.lcgReceipts.CustomizationFormText = "Receipts";
            this.lcgReceipts.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciRecepts});
            this.lcgReceipts.Location = new System.Drawing.Point(0, 0);
            this.lcgReceipts.Name = "lcgReceipts";
            this.lcgReceipts.Size = new System.Drawing.Size(724, 498);
            this.lcgReceipts.Text = "Receipts";
            // 
            // lciRecepts
            // 
            this.lciRecepts.Control = this.gcReceipts;
            this.lciRecepts.CustomizationFormText = "Recepts:";
            this.lciRecepts.Location = new System.Drawing.Point(0, 0);
            this.lciRecepts.Name = "lciRecepts";
            this.lciRecepts.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.lciRecepts.Size = new System.Drawing.Size(724, 498);
            this.lciRecepts.Text = "Recepts:";
            this.lciRecepts.TextLocation = DevExpress.Utils.Locations.Top;
            this.lciRecepts.TextSize = new System.Drawing.Size(0, 0);
            this.lciRecepts.TextToControlDistance = 0;
            this.lciRecepts.TextVisible = false;
            // 
            // lcgActiveRents
            // 
            this.lcgActiveRents.CustomizationFormText = "Active Rents";
            this.lcgActiveRents.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciActiveRents});
            this.lcgActiveRents.Location = new System.Drawing.Point(0, 0);
            this.lcgActiveRents.Name = "lcgActiveRents";
            this.lcgActiveRents.Size = new System.Drawing.Size(724, 498);
            this.lcgActiveRents.Text = "Active Rentals";
            // 
            // lciActiveRents
            // 
            this.lciActiveRents.Control = this.gcActiveRents;
            this.lciActiveRents.CustomizationFormText = "lciActiveRents";
            this.lciActiveRents.Location = new System.Drawing.Point(0, 0);
            this.lciActiveRents.Name = "lciActiveRents";
            this.lciActiveRents.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.lciActiveRents.Size = new System.Drawing.Size(724, 498);
            this.lciActiveRents.Text = "lciActiveRents";
            this.lciActiveRents.TextSize = new System.Drawing.Size(0, 0);
            this.lciActiveRents.TextToControlDistance = 0;
            this.lciActiveRents.TextVisible = false;
            // 
            // Rent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lcMain);
            this.Name = "Rent";
            this.Padding = new System.Windows.Forms.Padding(6);
            this.Size = new System.Drawing.Size(980, 537);
            ((System.ComponentModel.ISupportInitialize)(this.gvRents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcReceipts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvOverdue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvReceipts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).EndInit();
            this.lcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcActiveRents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvActiveRents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCustomerInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tcgViews)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgReceipts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciRecepts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgActiveRents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciActiveRents)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcReceipts;
        private DevExpress.XtraGrid.Views.Grid.GridView gvReceipts;
        private DevExpress.XtraGrid.Views.Grid.GridView gvRents;
        private DevExpress.XtraGrid.Columns.GridColumn colDate;
        private DevExpress.XtraGrid.Columns.GridColumn colPayment;
        private DevExpress.XtraGrid.Columns.GridColumn colReceiptId;
        private DevExpress.XtraGrid.Columns.GridColumn colType;
        private DevExpress.XtraGrid.Views.Grid.GridView gvOverdue;
        private DevExpress.XtraLayout.LayoutControl lcMain;
        private NukaCollect.Win.Controls.ucCustomerInfo ucCustomerInfo1;
        private DevExpress.XtraLayout.LayoutControlGroup lcgMain;
        private DevExpress.XtraLayout.LayoutControlItem lciCustomerInfo;
        private DevExpress.XtraLayout.SplitterItem splitterItem1;
        private DevExpress.XtraLayout.TabbedControlGroup tcgViews;
        private DevExpress.XtraLayout.LayoutControlGroup lcgReceipts;
        private DevExpress.XtraLayout.LayoutControlItem lciRecepts;
        private DevExpress.XtraLayout.LayoutControlGroup lcgActiveRents;
        private DevExpress.XtraGrid.Columns.GridColumn colRentId;
        private DevExpress.XtraGrid.Columns.GridColumn colReturnedOn;
        private DevExpress.XtraGrid.Columns.GridColumn colDays;
        private DevExpress.XtraGrid.Columns.GridColumn colActive;
        private DevExpress.XtraGrid.Columns.GridColumn colMovieInfo;
        private DevExpress.XtraGrid.Columns.GridColumn colPaymentRent;
        private DevExpress.XtraGrid.Views.Grid.GridView gvSales;
        private DevExpress.XtraGrid.Columns.GridColumn colSaleId;
        private DevExpress.XtraGrid.Columns.GridColumn colMovieInfoSale;
        private DevExpress.XtraGrid.Columns.GridColumn colPaymentSale;
        private DevExpress.XtraGrid.Columns.GridColumn colOverdueRentId;
        private DevExpress.XtraGrid.Columns.GridColumn colMovieInfoOverdue;
        private DevExpress.XtraGrid.Columns.GridColumn colOverdue;
        private DevExpress.XtraGrid.Columns.GridColumn colOverduePayment;
        private DevExpress.XtraGrid.Columns.GridColumn colDiscount;
        private DevExpress.XtraGrid.GridControl gcActiveRents;
        private DevExpress.XtraGrid.Views.Grid.GridView gvActiveRents;
        private DevExpress.XtraGrid.Columns.GridColumn colRentIdActive;
        private DevExpress.XtraGrid.Columns.GridColumn colDaysActive;
        private DevExpress.XtraGrid.Columns.GridColumn colOverdueActive;
        private DevExpress.XtraGrid.Columns.GridColumn colActiveRent;
        private DevExpress.XtraGrid.Columns.GridColumn colRentedOn;
        private DevExpress.XtraGrid.Columns.GridColumn colPaymentActive;
        private DevExpress.XtraGrid.Columns.GridColumn colMovieTitleActive;
        private DevExpress.XtraLayout.LayoutControlItem lciActiveRents;
        private DevExpress.XtraGrid.Columns.GridColumn colActiveType;
        private DevExpress.XtraGrid.Columns.GridColumn colReturn;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colItemFormat;
    }
}
