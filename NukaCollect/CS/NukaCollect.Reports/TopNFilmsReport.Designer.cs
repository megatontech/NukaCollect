namespace NukaCollect.Reports {
    partial class TopNFilmsReport {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TopNFilmsReport));
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrTableRentsCount = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRowRentsCountLabel = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCellRentsCountLabel = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRowRentsCount = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCellRentsCount = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrPictureBoxCover = new DevExpress.XtraReports.UI.XRPictureBox();
            this.xrTableTopFilmInfo = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRowMovieTitle = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCellMovieTitle = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRowFilmInfo = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCellFilmInfo = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableFilmInfo = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRowReleaseDate = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCellReleaseDateLabel = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCellReleaseDate = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRowPlot = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCellPlotLabel = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCellPlot = new DevExpress.XtraReports.UI.XRTableCell();
            this.topMarginBand = new DevExpress.XtraReports.UI.TopMarginBand();
            this.bottomMarginBand = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.xrPageInfoPageCount = new DevExpress.XtraReports.UI.XRPageInfo();
            this.calculatedFieldRentsCount = new DevExpress.XtraReports.UI.CalculatedField();
            this.xpCollectionMovies = new DevExpress.Xpo.XPCollection(this.components);
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.xrHeader = new DevExpress.XtraReports.UI.XRLabel();
            this.xrControlStyle1 = new DevExpress.XtraReports.UI.XRControlStyle();
            ((System.ComponentModel.ISupportInitialize)(this.xrTableRentsCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTableTopFilmInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTableFilmInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollectionMovies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTableRentsCount,
            this.xrPictureBoxCover,
            this.xrTableTopFilmInfo});
            resources.ApplyResources(this.Detail, "Detail");
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.SortFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("calculatedFieldRentsCount", DevExpress.XtraReports.UI.XRColumnSortOrder.Descending)});
            // 
            // xrTableRentsCount
            // 
            resources.ApplyResources(this.xrTableRentsCount, "xrTableRentsCount");
            this.xrTableRentsCount.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
                        | DevExpress.XtraPrinting.BorderSide.Right)
                        | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableRentsCount.Name = "xrTableRentsCount";
            this.xrTableRentsCount.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRowRentsCountLabel,
            this.xrTableRowRentsCount});
            this.xrTableRentsCount.StylePriority.UseBackColor = false;
            this.xrTableRentsCount.StylePriority.UseBorderColor = false;
            this.xrTableRentsCount.StylePriority.UseBorders = false;
            // 
            // xrTableRowRentsCountLabel
            // 
            this.xrTableRowRentsCountLabel.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCellRentsCountLabel});
            this.xrTableRowRentsCountLabel.Name = "xrTableRowRentsCountLabel";
            this.xrTableRowRentsCountLabel.Weight = 0.38461538461538469;
            // 
            // xrTableCellRentsCountLabel
            // 
            this.xrTableCellRentsCountLabel.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
                        | DevExpress.XtraPrinting.BorderSide.Right)));
            resources.ApplyResources(this.xrTableCellRentsCountLabel, "xrTableCellRentsCountLabel");
            this.xrTableCellRentsCountLabel.Name = "xrTableCellRentsCountLabel";
            this.xrTableCellRentsCountLabel.StylePriority.UseBorders = false;
            this.xrTableCellRentsCountLabel.StylePriority.UseFont = false;
            this.xrTableCellRentsCountLabel.StylePriority.UseTextAlignment = false;
            this.xrTableCellRentsCountLabel.Weight = 2.0208334350585937;
            // 
            // xrTableRowRentsCount
            // 
            this.xrTableRowRentsCount.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCellRentsCount});
            this.xrTableRowRentsCount.Name = "xrTableRowRentsCount";
            this.xrTableRowRentsCount.Weight = 1.6153846153846154;
            // 
            // xrTableCellRentsCount
            // 
            this.xrTableCellRentsCount.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right)
                        | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCellRentsCount.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "calculatedFieldRentsCount")});
            resources.ApplyResources(this.xrTableCellRentsCount, "xrTableCellRentsCount");
            this.xrTableCellRentsCount.Name = "xrTableCellRentsCount";
            this.xrTableCellRentsCount.StylePriority.UseBorders = false;
            this.xrTableCellRentsCount.StylePriority.UseFont = false;
            this.xrTableCellRentsCount.StylePriority.UseTextAlignment = false;
            this.xrTableCellRentsCount.Weight = 2.0208334350585937;
            // 
            // xrPictureBoxCover
            // 
            this.xrPictureBoxCover.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Image", null, "Photo")});
            resources.ApplyResources(this.xrPictureBoxCover, "xrPictureBoxCover");
            this.xrPictureBoxCover.Name = "xrPictureBoxCover";
            this.xrPictureBoxCover.Sizing = DevExpress.XtraPrinting.ImageSizeMode.Squeeze;
            this.xrPictureBoxCover.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.xrPictureBoxCover_BeforePrint);
            // 
            // xrTableTopFilmInfo
            // 
            resources.ApplyResources(this.xrTableTopFilmInfo, "xrTableTopFilmInfo");
            this.xrTableTopFilmInfo.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
                        | DevExpress.XtraPrinting.BorderSide.Right)
                        | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableTopFilmInfo.BorderWidth = 1;
            this.xrTableTopFilmInfo.KeepTogether = true;
            this.xrTableTopFilmInfo.Name = "xrTableTopFilmInfo";
            this.xrTableTopFilmInfo.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRowMovieTitle,
            this.xrTableRowFilmInfo});
            this.xrTableTopFilmInfo.StylePriority.UseBorderColor = false;
            this.xrTableTopFilmInfo.StylePriority.UseBorders = false;
            this.xrTableTopFilmInfo.StylePriority.UseBorderWidth = false;
            this.xrTableTopFilmInfo.StylePriority.UseFont = false;
            this.xrTableTopFilmInfo.StylePriority.UseTextAlignment = false;
            // 
            // xrTableRowMovieTitle
            // 
            this.xrTableRowMovieTitle.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCellMovieTitle});
            this.xrTableRowMovieTitle.Name = "xrTableRowMovieTitle";
            this.xrTableRowMovieTitle.Weight = 0.43749999904632575;
            // 
            // xrTableCellMovieTitle
            // 
            resources.ApplyResources(this.xrTableCellMovieTitle, "xrTableCellMovieTitle");
            this.xrTableCellMovieTitle.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
                        | DevExpress.XtraPrinting.BorderSide.Right)
                        | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCellMovieTitle.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Title")});
            this.xrTableCellMovieTitle.Multiline = true;
            this.xrTableCellMovieTitle.Name = "xrTableCellMovieTitle";
            this.xrTableCellMovieTitle.Padding = new DevExpress.XtraPrinting.PaddingInfo(136, 0, 0, 0, 100F);
            this.xrTableCellMovieTitle.StylePriority.UseBackColor = false;
            this.xrTableCellMovieTitle.StylePriority.UseBorders = false;
            this.xrTableCellMovieTitle.StylePriority.UseFont = false;
            this.xrTableCellMovieTitle.StylePriority.UsePadding = false;
            this.xrTableCellMovieTitle.StylePriority.UseTextAlignment = false;
            this.xrTableCellMovieTitle.Weight = 4.2162157014543444;
            // 
            // xrTableRowFilmInfo
            // 
            this.xrTableRowFilmInfo.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCellFilmInfo});
            this.xrTableRowFilmInfo.Name = "xrTableRowFilmInfo";
            this.xrTableRowFilmInfo.Weight = 1.5625000009536745;
            // 
            // xrTableCellFilmInfo
            // 
            resources.ApplyResources(this.xrTableCellFilmInfo, "xrTableCellFilmInfo");
            this.xrTableCellFilmInfo.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTableFilmInfo});
            this.xrTableCellFilmInfo.Name = "xrTableCellFilmInfo";
            this.xrTableCellFilmInfo.StylePriority.UseBackColor = false;
            this.xrTableCellFilmInfo.StylePriority.UseFont = false;
            this.xrTableCellFilmInfo.Weight = 4.2162157014543444;
            // 
            // xrTableFilmInfo
            // 
            this.xrTableFilmInfo.Borders = DevExpress.XtraPrinting.BorderSide.None;
            resources.ApplyResources(this.xrTableFilmInfo, "xrTableFilmInfo");
            this.xrTableFilmInfo.Name = "xrTableFilmInfo";
            this.xrTableFilmInfo.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRowReleaseDate,
            this.xrTableRowPlot});
            this.xrTableFilmInfo.StylePriority.UseBorders = false;
            // 
            // xrTableRowReleaseDate
            // 
            this.xrTableRowReleaseDate.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCellReleaseDateLabel,
            this.xrTableCellReleaseDate});
            this.xrTableRowReleaseDate.Name = "xrTableRowReleaseDate";
            this.xrTableRowReleaseDate.Weight = 1;
            // 
            // xrTableCellReleaseDateLabel
            // 
            this.xrTableCellReleaseDateLabel.CanGrow = false;
            resources.ApplyResources(this.xrTableCellReleaseDateLabel, "xrTableCellReleaseDateLabel");
            this.xrTableCellReleaseDateLabel.Name = "xrTableCellReleaseDateLabel";
            this.xrTableCellReleaseDateLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(1, 0, 0, 0, 100F);
            this.xrTableCellReleaseDateLabel.StylePriority.UseFont = false;
            this.xrTableCellReleaseDateLabel.StylePriority.UseForeColor = false;
            this.xrTableCellReleaseDateLabel.StylePriority.UsePadding = false;
            this.xrTableCellReleaseDateLabel.StylePriority.UseTextAlignment = false;
            this.xrTableCellReleaseDateLabel.Weight = 0.58768033539163955;
            // 
            // xrTableCellReleaseDate
            // 
            this.xrTableCellReleaseDate.CanGrow = false;
            this.xrTableCellReleaseDate.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "ReleaseDate", "{0:d}")});
            resources.ApplyResources(this.xrTableCellReleaseDate, "xrTableCellReleaseDate");
            this.xrTableCellReleaseDate.Name = "xrTableCellReleaseDate";
            this.xrTableCellReleaseDate.Padding = new DevExpress.XtraPrinting.PaddingInfo(1, 1, 0, 1, 100F);
            this.xrTableCellReleaseDate.StylePriority.UseFont = false;
            this.xrTableCellReleaseDate.StylePriority.UsePadding = false;
            this.xrTableCellReleaseDate.StylePriority.UseTextAlignment = false;
            this.xrTableCellReleaseDate.Weight = 2.4123196646083604;
            // 
            // xrTableRowPlot
            // 
            this.xrTableRowPlot.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCellPlotLabel,
            this.xrTableCellPlot});
            this.xrTableRowPlot.Name = "xrTableRowPlot";
            this.xrTableRowPlot.Weight = 2.4000006713868212;
            // 
            // xrTableCellPlotLabel
            // 
            resources.ApplyResources(this.xrTableCellPlotLabel, "xrTableCellPlotLabel");
            this.xrTableCellPlotLabel.Name = "xrTableCellPlotLabel";
            this.xrTableCellPlotLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(1, 0, 0, 0, 100F);
            this.xrTableCellPlotLabel.StylePriority.UseFont = false;
            this.xrTableCellPlotLabel.StylePriority.UseForeColor = false;
            this.xrTableCellPlotLabel.StylePriority.UsePadding = false;
            this.xrTableCellPlotLabel.StylePriority.UseTextAlignment = false;
            this.xrTableCellPlotLabel.Weight = 0.58768033539163955;
            // 
            // xrTableCellPlot
            // 
            this.xrTableCellPlot.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Plot")});
            resources.ApplyResources(this.xrTableCellPlot, "xrTableCellPlot");
            this.xrTableCellPlot.Name = "xrTableCellPlot";
            this.xrTableCellPlot.Padding = new DevExpress.XtraPrinting.PaddingInfo(1, 1, 0, 1, 100F);
            this.xrTableCellPlot.StylePriority.UseFont = false;
            this.xrTableCellPlot.StylePriority.UsePadding = false;
            this.xrTableCellPlot.StylePriority.UseTextAlignment = false;
            this.xrTableCellPlot.Weight = 2.4123196646083604;
            // 
            // topMarginBand
            // 
            resources.ApplyResources(this.topMarginBand, "topMarginBand");
            this.topMarginBand.Name = "topMarginBand";
            this.topMarginBand.StylePriority.UseFont = false;
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
            // calculatedFieldRentsCount
            // 
            this.calculatedFieldRentsCount.Name = "calculatedFieldRentsCount";
            this.calculatedFieldRentsCount.GetValue += new DevExpress.XtraReports.UI.GetValueEventHandler(this.calculatedFieldRentsCount_GetValue);
            // 
            // xpCollectionMovies
            // 
            this.xpCollectionMovies.CaseSensitive = true;
            this.xpCollectionMovies.ObjectType = typeof(NukaCollect.Movie);
            this.xpCollectionMovies.ResolveSession += new DevExpress.Xpo.ResolveSessionEventHandler(this.xpCollectionMovies_ResolveSession);
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrHeader});
            resources.ApplyResources(this.ReportHeader, "ReportHeader");
            this.ReportHeader.Name = "ReportHeader";
            this.ReportHeader.StylePriority.UseTextAlignment = false;
            // 
            // xrHeader
            // 
            resources.ApplyResources(this.xrHeader, "xrHeader");
            this.xrHeader.Name = "xrHeader";
            this.xrHeader.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrHeader.StyleName = "xrControlStyle1";
            this.xrHeader.StylePriority.UseFont = false;
            this.xrHeader.StylePriority.UseTextAlignment = false;
            // 
            // xrControlStyle1
            // 
            this.xrControlStyle1.Name = "xrControlStyle1";
            this.xrControlStyle1.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            // 
            // TopNFilmsReport
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.topMarginBand,
            this.bottomMarginBand,
            this.ReportHeader});
            this.CalculatedFields.AddRange(new DevExpress.XtraReports.UI.CalculatedField[] {
            this.calculatedFieldRentsCount});
            this.DataSource = this.xpCollectionMovies;
            this.Extensions.Add("ParametersRequestExtension", "TimePeriodReport");
            this.Extensions.Add("DataSerializationExtension", "TimePeriodReport");
            this.Extensions.Add("DataEditorExtension", "TimePeriodReport");
            this.Extensions.Add("ParameterEditorExtension", "TimePeriodReport");
            this.Margins = new System.Drawing.Printing.Margins(100, 100, 50, 50);
            this.ReportPrintOptions.PrintOnEmptyDataSource = false;
            this.RequestParameters = false;
            this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.xrControlStyle1});
            this.Version = "12.1";
            this.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.TopNFilmsReport_BeforePrint);
            ((System.ComponentModel.ISupportInitialize)(this.xrTableRentsCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTableTopFilmInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTableFilmInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollectionMovies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand topMarginBand;
        private DevExpress.XtraReports.UI.BottomMarginBand bottomMarginBand;
        private DevExpress.Xpo.XPCollection xpCollectionMovies;
        private DevExpress.XtraReports.UI.CalculatedField calculatedFieldRentsCount;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.UI.XRLabel xrHeader;
        private DevExpress.XtraReports.UI.XRPageInfo xrPageInfoPageCount;
        private DevExpress.XtraReports.UI.XRTable xrTableTopFilmInfo;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRowMovieTitle;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCellMovieTitle;
        private DevExpress.XtraReports.UI.XRControlStyle xrControlStyle1;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRowFilmInfo;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCellFilmInfo;
        private DevExpress.XtraReports.UI.XRTable xrTableFilmInfo;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRowReleaseDate;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCellReleaseDateLabel;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCellReleaseDate;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRowPlot;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCellPlotLabel;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCellPlot;
        private DevExpress.XtraReports.UI.XRTable xrTableRentsCount;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRowRentsCountLabel;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCellRentsCountLabel;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRowRentsCount;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCellRentsCount;
        private DevExpress.XtraReports.UI.XRPictureBox xrPictureBoxCover;
    }
}
