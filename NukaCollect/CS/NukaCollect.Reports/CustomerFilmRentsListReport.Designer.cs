namespace NukaCollect.Reports {
    partial class CustomerFilmRentsListReport {
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

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerFilmRentsListReport));
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrLabelCustomerFullName = new DevExpress.XtraReports.UI.XRLabel();
            this.xrPictureBoxCustomerPhoto = new DevExpress.XtraReports.UI.XRPictureBox();
            this.xrTableFilmsColumnHeaders = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRowColumnHeaders = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCellPhotoColumnHeader = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCellFilmInfoColumnHeader = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCellRentStartDateColumnHeader = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCellExpectedOnColumnHeader = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCellRentEndDateColumnHeader = new DevExpress.XtraReports.UI.XRTableCell();
            this.topMarginBand = new DevExpress.XtraReports.UI.TopMarginBand();
            this.bottomMarginBand = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.xrPageInfoPageCount = new DevExpress.XtraReports.UI.XRPageInfo();
            this.DetailReportReceipts = new DevExpress.XtraReports.UI.DetailReportBand();
            this.DetailFilmInfo = new DevExpress.XtraReports.UI.DetailBand();
            this.DetailReportRents = new DevExpress.XtraReports.UI.DetailReportBand();
            this.DetailRents = new DevExpress.XtraReports.UI.DetailBand();
            this.xrTableFilms = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRowFilmInfo = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCellPhoto = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrPictureBoxPhoto = new DevExpress.XtraReports.UI.XRPictureBox();
            this.xrTableCellTitle = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableMovieInfo = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRowMovieTitle = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCellMovieTitle = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRowMovieFormat = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCellMovieFormat = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRowPlot = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCellPlot = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCellRentedOn = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCellExpectedOn = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCellReturnedOn = new DevExpress.XtraReports.UI.XRTableCell();
            this.xpCollectionCustomers = new DevExpress.Xpo.XPCollection(this.components);
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.xrLabelHeader = new DevExpress.XtraReports.UI.XRLabel();
            this.showModeParameter = new DevExpress.XtraReports.Parameters.Parameter();
            ((System.ComponentModel.ISupportInitialize)(this.xrTableFilmsColumnHeaders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTableFilms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTableMovieInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollectionCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabelCustomerFullName,
            this.xrPictureBoxCustomerPhoto,
            this.xrTableFilmsColumnHeaders});
            resources.ApplyResources(this.Detail, "Detail");
            this.Detail.KeepTogether = true;
            this.Detail.KeepTogetherWithDetailReports = true;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            // 
            // xrLabelCustomerFullName
            // 
            this.xrLabelCustomerFullName.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "FullNameLastSorting"),
            new DevExpress.XtraReports.UI.XRBinding("Bookmark", null, "FullNameLastSorting")});
            resources.ApplyResources(this.xrLabelCustomerFullName, "xrLabelCustomerFullName");
            this.xrLabelCustomerFullName.Name = "xrLabelCustomerFullName";
            this.xrLabelCustomerFullName.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabelCustomerFullName.StylePriority.UseFont = false;
            this.xrLabelCustomerFullName.StylePriority.UseTextAlignment = false;
            // 
            // xrPictureBoxCustomerPhoto
            // 
            this.xrPictureBoxCustomerPhoto.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Image", null, "Photo")});
            resources.ApplyResources(this.xrPictureBoxCustomerPhoto, "xrPictureBoxCustomerPhoto");
            this.xrPictureBoxCustomerPhoto.Name = "xrPictureBoxCustomerPhoto";
            this.xrPictureBoxCustomerPhoto.Sizing = DevExpress.XtraPrinting.ImageSizeMode.Squeeze;
            this.xrPictureBoxCustomerPhoto.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.xrPictureBoxCustomerPhoto_BeforePrint);
            // 
            // xrTableFilmsColumnHeaders
            // 
            this.xrTableFilmsColumnHeaders.AnchorVertical = DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom;
            resources.ApplyResources(this.xrTableFilmsColumnHeaders, "xrTableFilmsColumnHeaders");
            this.xrTableFilmsColumnHeaders.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
                        | DevExpress.XtraPrinting.BorderSide.Right)
                        | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableFilmsColumnHeaders.KeepTogether = true;
            this.xrTableFilmsColumnHeaders.Name = "xrTableFilmsColumnHeaders";
            this.xrTableFilmsColumnHeaders.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRowColumnHeaders});
            this.xrTableFilmsColumnHeaders.StylePriority.UseBackColor = false;
            this.xrTableFilmsColumnHeaders.StylePriority.UseBorderColor = false;
            this.xrTableFilmsColumnHeaders.StylePriority.UseBorders = false;
            this.xrTableFilmsColumnHeaders.StylePriority.UseFont = false;
            // 
            // xrTableRowColumnHeaders
            // 
            this.xrTableRowColumnHeaders.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCellPhotoColumnHeader,
            this.xrTableCellFilmInfoColumnHeader,
            this.xrTableCellRentStartDateColumnHeader,
            this.xrTableCellExpectedOnColumnHeader,
            this.xrTableCellRentEndDateColumnHeader});
            this.xrTableRowColumnHeaders.Name = "xrTableRowColumnHeaders";
            this.xrTableRowColumnHeaders.Weight = 1;
            // 
            // xrTableCellPhotoColumnHeader
            // 
            this.xrTableCellPhotoColumnHeader.CanGrow = false;
            resources.ApplyResources(this.xrTableCellPhotoColumnHeader, "xrTableCellPhotoColumnHeader");
            this.xrTableCellPhotoColumnHeader.Name = "xrTableCellPhotoColumnHeader";
            this.xrTableCellPhotoColumnHeader.StylePriority.UseFont = false;
            this.xrTableCellPhotoColumnHeader.StylePriority.UseTextAlignment = false;
            this.xrTableCellPhotoColumnHeader.Weight = 0.52294987794682846;
            // 
            // xrTableCellFilmInfoColumnHeader
            // 
            this.xrTableCellFilmInfoColumnHeader.CanGrow = false;
            resources.ApplyResources(this.xrTableCellFilmInfoColumnHeader, "xrTableCellFilmInfoColumnHeader");
            this.xrTableCellFilmInfoColumnHeader.Name = "xrTableCellFilmInfoColumnHeader";
            this.xrTableCellFilmInfoColumnHeader.StylePriority.UseFont = false;
            this.xrTableCellFilmInfoColumnHeader.StylePriority.UseTextAlignment = false;
            this.xrTableCellFilmInfoColumnHeader.Weight = 1.5688500924089377;
            // 
            // xrTableCellRentStartDateColumnHeader
            // 
            this.xrTableCellRentStartDateColumnHeader.CanGrow = false;
            resources.ApplyResources(this.xrTableCellRentStartDateColumnHeader, "xrTableCellRentStartDateColumnHeader");
            this.xrTableCellRentStartDateColumnHeader.Name = "xrTableCellRentStartDateColumnHeader";
            this.xrTableCellRentStartDateColumnHeader.StylePriority.UseFont = false;
            this.xrTableCellRentStartDateColumnHeader.StylePriority.UseTextAlignment = false;
            this.xrTableCellRentStartDateColumnHeader.Weight = 0.52294970561954968;
            // 
            // xrTableCellExpectedOnColumnHeader
            // 
            this.xrTableCellExpectedOnColumnHeader.CanGrow = false;
            resources.ApplyResources(this.xrTableCellExpectedOnColumnHeader, "xrTableCellExpectedOnColumnHeader");
            this.xrTableCellExpectedOnColumnHeader.Name = "xrTableCellExpectedOnColumnHeader";
            this.xrTableCellExpectedOnColumnHeader.StylePriority.UseFont = false;
            this.xrTableCellExpectedOnColumnHeader.StylePriority.UseTextAlignment = false;
            this.xrTableCellExpectedOnColumnHeader.Weight = 0.52294986247842823;
            // 
            // xrTableCellRentEndDateColumnHeader
            // 
            this.xrTableCellRentEndDateColumnHeader.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
                        | DevExpress.XtraPrinting.BorderSide.Right)
                        | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCellRentEndDateColumnHeader.CanGrow = false;
            resources.ApplyResources(this.xrTableCellRentEndDateColumnHeader, "xrTableCellRentEndDateColumnHeader");
            this.xrTableCellRentEndDateColumnHeader.Name = "xrTableCellRentEndDateColumnHeader";
            this.xrTableCellRentEndDateColumnHeader.StylePriority.UseBorders = false;
            this.xrTableCellRentEndDateColumnHeader.StylePriority.UseFont = false;
            this.xrTableCellRentEndDateColumnHeader.StylePriority.UseTextAlignment = false;
            this.xrTableCellRentEndDateColumnHeader.Weight = 0.52294914954506977;
            // 
            // topMarginBand
            // 
            resources.ApplyResources(this.topMarginBand, "topMarginBand");
            this.topMarginBand.Name = "topMarginBand";
            // 
            // bottomMarginBand
            // 
            this.bottomMarginBand.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPageInfoPageCount});
            resources.ApplyResources(this.bottomMarginBand, "bottomMarginBand");
            this.bottomMarginBand.Name = "bottomMarginBand";
            // 
            // xrPageInfoPageCount
            // 
            resources.ApplyResources(this.xrPageInfoPageCount, "xrPageInfoPageCount");
            this.xrPageInfoPageCount.Name = "xrPageInfoPageCount";
            this.xrPageInfoPageCount.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrPageInfoPageCount.StylePriority.UseFont = false;
            this.xrPageInfoPageCount.StylePriority.UseTextAlignment = false;
            // 
            // DetailReportReceipts
            // 
            this.DetailReportReceipts.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.DetailFilmInfo,
            this.DetailReportRents});
            this.DetailReportReceipts.DataMember = "Receipts";
            this.DetailReportReceipts.DataSource = this.xpCollectionCustomers;
            this.DetailReportReceipts.Level = 0;
            this.DetailReportReceipts.Name = "DetailReportReceipts";
            // 
            // DetailFilmInfo
            // 
            resources.ApplyResources(this.DetailFilmInfo, "DetailFilmInfo");
            this.DetailFilmInfo.Name = "DetailFilmInfo";
            // 
            // DetailReportRents
            // 
            this.DetailReportRents.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.DetailRents});
            this.DetailReportRents.DataMember = "Receipts.Rents";
            this.DetailReportRents.DataSource = this.xpCollectionCustomers;
            this.DetailReportRents.Level = 0;
            this.DetailReportRents.Name = "DetailReportRents";
            this.DetailReportRents.ReportPrintOptions.PrintOnEmptyDataSource = false;
            // 
            // DetailRents
            // 
            this.DetailRents.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTableFilms});
            resources.ApplyResources(this.DetailRents, "DetailRents");
            this.DetailRents.Name = "DetailRents";
            // 
            // xrTableFilms
            // 
            this.xrTableFilms.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right)
                        | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableFilms.KeepTogether = true;
            resources.ApplyResources(this.xrTableFilms, "xrTableFilms");
            this.xrTableFilms.Name = "xrTableFilms";
            this.xrTableFilms.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRowFilmInfo});
            this.xrTableFilms.StylePriority.UseBorders = false;
            // 
            // xrTableRowFilmInfo
            // 
            this.xrTableRowFilmInfo.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCellPhoto,
            this.xrTableCellTitle,
            this.xrTableCellRentedOn,
            this.xrTableCellExpectedOn,
            this.xrTableCellReturnedOn});
            this.xrTableRowFilmInfo.Name = "xrTableRowFilmInfo";
            this.xrTableRowFilmInfo.Weight = 1;
            // 
            // xrTableCellPhoto
            // 
            this.xrTableCellPhoto.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrTableCellPhoto.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPictureBoxPhoto});
            resources.ApplyResources(this.xrTableCellPhoto, "xrTableCellPhoto");
            this.xrTableCellPhoto.Name = "xrTableCellPhoto";
            this.xrTableCellPhoto.StylePriority.UseBorders = false;
            this.xrTableCellPhoto.StylePriority.UseFont = false;
            this.xrTableCellPhoto.StylePriority.UseTextAlignment = false;
            this.xrTableCellPhoto.Weight = 0.42895799503931054;
            // 
            // xrPictureBoxPhoto
            // 
            resources.ApplyResources(this.xrPictureBoxPhoto, "xrPictureBoxPhoto");
            this.xrPictureBoxPhoto.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right)
                        | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrPictureBoxPhoto.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Image", null, "Receipts.Rents.MoviePhoto")});
            this.xrPictureBoxPhoto.Name = "xrPictureBoxPhoto";
            this.xrPictureBoxPhoto.Padding = new DevExpress.XtraPrinting.PaddingInfo(1, 1, 1, 1, 100F);
            this.xrPictureBoxPhoto.Sizing = DevExpress.XtraPrinting.ImageSizeMode.Squeeze;
            this.xrPictureBoxPhoto.StylePriority.UseBackColor = false;
            this.xrPictureBoxPhoto.StylePriority.UseBorderColor = false;
            this.xrPictureBoxPhoto.StylePriority.UseBorders = false;
            this.xrPictureBoxPhoto.StylePriority.UsePadding = false;
            this.xrPictureBoxPhoto.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.xrPictureBoxPhoto_BeforePrint);
            // 
            // xrTableCellTitle
            // 
            this.xrTableCellTitle.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrTableCellTitle.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTableMovieInfo});
            resources.ApplyResources(this.xrTableCellTitle, "xrTableCellTitle");
            this.xrTableCellTitle.Multiline = true;
            this.xrTableCellTitle.Name = "xrTableCellTitle";
            this.xrTableCellTitle.StylePriority.UseBorders = false;
            this.xrTableCellTitle.StylePriority.UseFont = false;
            this.xrTableCellTitle.StylePriority.UseTextAlignment = false;
            this.xrTableCellTitle.Weight = 1.2868742439987364;
            // 
            // xrTableMovieInfo
            // 
            this.xrTableMovieInfo.Borders = DevExpress.XtraPrinting.BorderSide.None;
            resources.ApplyResources(this.xrTableMovieInfo, "xrTableMovieInfo");
            this.xrTableMovieInfo.Name = "xrTableMovieInfo";
            this.xrTableMovieInfo.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRowMovieTitle,
            this.xrTableRowMovieFormat,
            this.xrTableRowPlot});
            this.xrTableMovieInfo.StylePriority.UseBorders = false;
            // 
            // xrTableRowMovieTitle
            // 
            this.xrTableRowMovieTitle.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCellMovieTitle});
            this.xrTableRowMovieTitle.Name = "xrTableRowMovieTitle";
            this.xrTableRowMovieTitle.Weight = 0.43916619757478564;
            // 
            // xrTableCellMovieTitle
            // 
            resources.ApplyResources(this.xrTableCellMovieTitle, "xrTableCellMovieTitle");
            this.xrTableCellMovieTitle.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCellMovieTitle.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Receipts.Rents.MovieTitle")});
            this.xrTableCellMovieTitle.Name = "xrTableCellMovieTitle";
            this.xrTableCellMovieTitle.StylePriority.UseBackColor = false;
            this.xrTableCellMovieTitle.StylePriority.UseBorderColor = false;
            this.xrTableCellMovieTitle.StylePriority.UseBorders = false;
            this.xrTableCellMovieTitle.StylePriority.UseFont = false;
            this.xrTableCellMovieTitle.Weight = 2.5568376159667969;
            // 
            // xrTableRowMovieFormat
            // 
            this.xrTableRowMovieFormat.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCellMovieFormat});
            this.xrTableRowMovieFormat.Name = "xrTableRowMovieFormat";
            this.xrTableRowMovieFormat.Weight = 0.4391661975747857;
            // 
            // xrTableCellMovieFormat
            // 
            resources.ApplyResources(this.xrTableCellMovieFormat, "xrTableCellMovieFormat");
            this.xrTableCellMovieFormat.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCellMovieFormat.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Receipts.Rents.ItemFormatCaption")});
            this.xrTableCellMovieFormat.Name = "xrTableCellMovieFormat";
            this.xrTableCellMovieFormat.StylePriority.UseBackColor = false;
            this.xrTableCellMovieFormat.StylePriority.UseBorderColor = false;
            this.xrTableCellMovieFormat.StylePriority.UseBorders = false;
            this.xrTableCellMovieFormat.StylePriority.UseFont = false;
            this.xrTableCellMovieFormat.StylePriority.UseForeColor = false;
            this.xrTableCellMovieFormat.Weight = 2.5568376159667969;
            // 
            // xrTableRowPlot
            // 
            this.xrTableRowPlot.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCellPlot});
            this.xrTableRowPlot.Name = "xrTableRowPlot";
            this.xrTableRowPlot.Weight = 1.5809977466414493;
            // 
            // xrTableCellPlot
            // 
            resources.ApplyResources(this.xrTableCellPlot, "xrTableCellPlot");
            this.xrTableCellPlot.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCellPlot.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Receipts.Rents.MoviePlot")});
            this.xrTableCellPlot.Name = "xrTableCellPlot";
            this.xrTableCellPlot.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 100F);
            this.xrTableCellPlot.StylePriority.UseBackColor = false;
            this.xrTableCellPlot.StylePriority.UseBorderColor = false;
            this.xrTableCellPlot.StylePriority.UseBorders = false;
            this.xrTableCellPlot.StylePriority.UseFont = false;
            this.xrTableCellPlot.StylePriority.UseForeColor = false;
            this.xrTableCellPlot.StylePriority.UsePadding = false;
            this.xrTableCellPlot.StylePriority.UseTextAlignment = false;
            this.xrTableCellPlot.Weight = 2.5568376159667969;
            // 
            // xrTableCellRentedOn
            // 
            resources.ApplyResources(this.xrTableCellRentedOn, "xrTableCellRentedOn");
            this.xrTableCellRentedOn.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCellRentedOn.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Receipts.Rents.RentedOn", "{0:d}")});
            this.xrTableCellRentedOn.Multiline = true;
            this.xrTableCellRentedOn.Name = "xrTableCellRentedOn";
            this.xrTableCellRentedOn.StylePriority.UseBackColor = false;
            this.xrTableCellRentedOn.StylePriority.UseBorderColor = false;
            this.xrTableCellRentedOn.StylePriority.UseBorders = false;
            this.xrTableCellRentedOn.StylePriority.UseFont = false;
            this.xrTableCellRentedOn.StylePriority.UseForeColor = false;
            this.xrTableCellRentedOn.StylePriority.UseTextAlignment = false;
            this.xrTableCellRentedOn.Weight = 0.42895799100693155;
            // 
            // xrTableCellExpectedOn
            // 
            resources.ApplyResources(this.xrTableCellExpectedOn, "xrTableCellExpectedOn");
            this.xrTableCellExpectedOn.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Receipts.Rents.ClearedReturnedOnDate", "{0:d}")});
            this.xrTableCellExpectedOn.Multiline = true;
            this.xrTableCellExpectedOn.Name = "xrTableCellExpectedOn";
            this.xrTableCellExpectedOn.StylePriority.UseBackColor = false;
            this.xrTableCellExpectedOn.StylePriority.UseBorderColor = false;
            this.xrTableCellExpectedOn.StylePriority.UseFont = false;
            this.xrTableCellExpectedOn.StylePriority.UseForeColor = false;
            this.xrTableCellExpectedOn.StylePriority.UseTextAlignment = false;
            this.xrTableCellExpectedOn.Weight = 0.42895800935788148;
            // 
            // xrTableCellReturnedOn
            // 
            resources.ApplyResources(this.xrTableCellReturnedOn, "xrTableCellReturnedOn");
            this.xrTableCellReturnedOn.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Receipts.Rents.ReturnedOn", "{0:d}")});
            this.xrTableCellReturnedOn.Multiline = true;
            this.xrTableCellReturnedOn.Name = "xrTableCellReturnedOn";
            this.xrTableCellReturnedOn.StylePriority.UseBackColor = false;
            this.xrTableCellReturnedOn.StylePriority.UseBorderColor = false;
            this.xrTableCellReturnedOn.StylePriority.UseFont = false;
            this.xrTableCellReturnedOn.StylePriority.UseForeColor = false;
            this.xrTableCellReturnedOn.StylePriority.UseTextAlignment = false;
            this.xrTableCellReturnedOn.Weight = 0.42895777772454391;
            this.xrTableCellReturnedOn.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.xrTableCellReturnedOn_BeforePrint);
            // 
            // xpCollectionCustomers
            // 
            this.xpCollectionCustomers.CaseSensitive = true;
            this.xpCollectionCustomers.ObjectType = typeof(NukaCollect.Customer);
            this.xpCollectionCustomers.Sorting.AddRange(new DevExpress.Xpo.SortProperty[] {
            new DevExpress.Xpo.SortProperty("[FullNameLastSorting]", DevExpress.Xpo.DB.SortingDirection.Ascending)});
            this.xpCollectionCustomers.ResolveSession += new DevExpress.Xpo.ResolveSessionEventHandler(this.xpCollectionCustomers_ResolveSession);
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabelHeader});
            resources.ApplyResources(this.ReportHeader, "ReportHeader");
            this.ReportHeader.Name = "ReportHeader";
            // 
            // xrLabelHeader
            // 
            resources.ApplyResources(this.xrLabelHeader, "xrLabelHeader");
            this.xrLabelHeader.Name = "xrLabelHeader";
            this.xrLabelHeader.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabelHeader.StylePriority.UseFont = false;
            this.xrLabelHeader.StylePriority.UseTextAlignment = false;
            // 
            // showModeParameter
            // 
            resources.ApplyResources(this.showModeParameter, "showModeParameter");
            this.showModeParameter.Name = "showModeParameter";
            this.showModeParameter.Value = "";
            // 
            // CustomerFilmRentsListReport
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.topMarginBand,
            this.bottomMarginBand,
            this.DetailReportReceipts,
            this.ReportHeader});
            this.Bookmark = "Customers";
            this.DataSource = this.xpCollectionCustomers;
            this.Margins = new System.Drawing.Printing.Margins(75, 75, 50, 50);
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.showModeParameter});
            resources.ApplyResources(this, "$this");
            this.Version = "12.1";
            ((System.ComponentModel.ISupportInitialize)(this.xrTableFilmsColumnHeaders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTableFilms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTableMovieInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollectionCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand topMarginBand;
        private DevExpress.XtraReports.UI.BottomMarginBand bottomMarginBand;
        private DevExpress.XtraReports.UI.DetailReportBand DetailReportReceipts;
        private DevExpress.XtraReports.UI.DetailBand DetailFilmInfo;
        private DevExpress.Xpo.XPCollection xpCollectionCustomers;
        private DevExpress.XtraReports.UI.XRPageInfo xrPageInfoPageCount;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.UI.XRLabel xrLabelHeader;
        private DevExpress.XtraReports.UI.XRLabel xrLabelCustomerFullName;
        private DevExpress.XtraReports.UI.XRPictureBox xrPictureBoxCustomerPhoto;
        private DevExpress.XtraReports.UI.XRTable xrTableFilmsColumnHeaders;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRowColumnHeaders;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCellPhotoColumnHeader;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCellFilmInfoColumnHeader;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCellRentStartDateColumnHeader;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCellRentEndDateColumnHeader;
        private DevExpress.XtraReports.UI.DetailReportBand DetailReportRents;
        private DevExpress.XtraReports.UI.DetailBand DetailRents;
        private DevExpress.XtraReports.UI.XRTable xrTableFilms;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRowFilmInfo;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCellPhoto;
        private DevExpress.XtraReports.UI.XRPictureBox xrPictureBoxPhoto;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCellTitle;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCellRentedOn;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCellReturnedOn;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCellExpectedOnColumnHeader;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCellExpectedOn;
        private DevExpress.XtraReports.UI.XRTable xrTableMovieInfo;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRowMovieTitle;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCellMovieTitle;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRowPlot;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCellPlot;
        private DevExpress.XtraReports.Parameters.Parameter showModeParameter;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRowMovieFormat;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCellMovieFormat;
    }
}
