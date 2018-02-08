namespace NukaCollect.Reports {
    partial class TheMostProfitableGenresListReport {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TheMostProfitableGenresListReport));
            DevExpress.XtraReports.UI.XRGroupSortingSummary xrGroupSortingSummary1 = new DevExpress.XtraReports.UI.XRGroupSortingSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary1 = new DevExpress.XtraReports.UI.XRSummary();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrTableFilmInfo = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCellMovieTitle = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCellRevenue = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRowFilmInfo = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCellCover = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrPictureBoxCover = new DevExpress.XtraReports.UI.XRPictureBox();
            this.xrTableCellMovie = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableFilmFullInfo = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRowFilmTitleAndReleaseDate = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCellReleaseDateLabel = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCellReleaseDate = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRowTagLine = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCellPlotLabel = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCellPlot = new DevExpress.XtraReports.UI.XRTableCell();
            this.topMarginBand = new DevExpress.XtraReports.UI.TopMarginBand();
            this.bottomMarginBand = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.xrPageInfoPageCount = new DevExpress.XtraReports.UI.XRPageInfo();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.xrLabelHeader = new DevExpress.XtraReports.UI.XRLabel();
            this.xpCollectionMovies = new DevExpress.Xpo.XPCollection(this.components);
            this.GroupHeaderGenreGroup = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.xrRichText1 = new DevExpress.XtraReports.UI.XRRichText();
            this.xrLabelTotalRevenueLabel = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabelTotalRevenue = new DevExpress.XtraReports.UI.XRLabel();
            ((System.ComponentModel.ISupportInitialize)(this.xrTableFilmInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTableFilmFullInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollectionMovies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTableFilmInfo});
            resources.ApplyResources(this.Detail, "Detail");
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            // 
            // xrTableFilmInfo
            // 
            resources.ApplyResources(this.xrTableFilmInfo, "xrTableFilmInfo");
            this.xrTableFilmInfo.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right)
                        | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableFilmInfo.BorderWidth = 1;
            this.xrTableFilmInfo.KeepTogether = true;
            this.xrTableFilmInfo.Name = "xrTableFilmInfo";
            this.xrTableFilmInfo.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1,
            this.xrTableRowFilmInfo});
            this.xrTableFilmInfo.StylePriority.UseBorderColor = false;
            this.xrTableFilmInfo.StylePriority.UseBorders = false;
            this.xrTableFilmInfo.StylePriority.UseBorderWidth = false;
            this.xrTableFilmInfo.StylePriority.UseFont = false;
            this.xrTableFilmInfo.StylePriority.UseTextAlignment = false;
            // 
            // xrTableRow1
            // 
            this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCellMovieTitle,
            this.xrTableCellRevenue});
            this.xrTableRow1.Name = "xrTableRow1";
            this.xrTableRow1.Weight = 0.27777777353922528;
            // 
            // xrTableCellMovieTitle
            // 
            resources.ApplyResources(this.xrTableCellMovieTitle, "xrTableCellMovieTitle");
            this.xrTableCellMovieTitle.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right)
                        | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCellMovieTitle.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Title")});
            this.xrTableCellMovieTitle.Name = "xrTableCellMovieTitle";
            this.xrTableCellMovieTitle.Padding = new DevExpress.XtraPrinting.PaddingInfo(10, 10, 0, 0, 100F);
            this.xrTableCellMovieTitle.StylePriority.UseBackColor = false;
            this.xrTableCellMovieTitle.StylePriority.UseBorderColor = false;
            this.xrTableCellMovieTitle.StylePriority.UseBorders = false;
            this.xrTableCellMovieTitle.StylePriority.UseFont = false;
            this.xrTableCellMovieTitle.StylePriority.UseForeColor = false;
            this.xrTableCellMovieTitle.StylePriority.UsePadding = false;
            this.xrTableCellMovieTitle.StylePriority.UseTextAlignment = false;
            this.xrTableCellMovieTitle.Weight = 3.0486482764362184;
            // 
            // xrTableCellRevenue
            // 
            resources.ApplyResources(this.xrTableCellRevenue, "xrTableCellRevenue");
            this.xrTableCellRevenue.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCellRevenue.Name = "xrTableCellRevenue";
            this.xrTableCellRevenue.StylePriority.UseBackColor = false;
            this.xrTableCellRevenue.StylePriority.UseBorderColor = false;
            this.xrTableCellRevenue.StylePriority.UseBorders = false;
            this.xrTableCellRevenue.StylePriority.UseFont = false;
            this.xrTableCellRevenue.StylePriority.UseForeColor = false;
            this.xrTableCellRevenue.Weight = 1.1675674250181261;
            // 
            // xrTableRowFilmInfo
            // 
            this.xrTableRowFilmInfo.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCellCover,
            this.xrTableCellMovie});
            this.xrTableRowFilmInfo.Name = "xrTableRowFilmInfo";
            this.xrTableRowFilmInfo.Weight = 1.7222222264607747;
            // 
            // xrTableCellCover
            // 
            this.xrTableCellCover.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrTableCellCover.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPictureBoxCover});
            this.xrTableCellCover.Name = "xrTableCellCover";
            this.xrTableCellCover.StylePriority.UseBorders = false;
            resources.ApplyResources(this.xrTableCellCover, "xrTableCellCover");
            this.xrTableCellCover.Weight = 0.77837832493913406;
            // 
            // xrPictureBoxCover
            // 
            resources.ApplyResources(this.xrPictureBoxCover, "xrPictureBoxCover");
            this.xrPictureBoxCover.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right)
                        | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrPictureBoxCover.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Image", null, "Photo")});
            this.xrPictureBoxCover.Name = "xrPictureBoxCover";
            this.xrPictureBoxCover.Padding = new DevExpress.XtraPrinting.PaddingInfo(10, 10, 10, 10, 100F);
            this.xrPictureBoxCover.Sizing = DevExpress.XtraPrinting.ImageSizeMode.Squeeze;
            this.xrPictureBoxCover.StylePriority.UseBackColor = false;
            this.xrPictureBoxCover.StylePriority.UseBorders = false;
            this.xrPictureBoxCover.StylePriority.UsePadding = false;
            this.xrPictureBoxCover.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.xrPictureBoxCover_BeforePrint);
            // 
            // xrTableCellMovie
            // 
            this.xrTableCellMovie.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrTableCellMovie.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTableFilmFullInfo});
            resources.ApplyResources(this.xrTableCellMovie, "xrTableCellMovie");
            this.xrTableCellMovie.Multiline = true;
            this.xrTableCellMovie.Name = "xrTableCellMovie";
            this.xrTableCellMovie.StylePriority.UseBorders = false;
            this.xrTableCellMovie.StylePriority.UseFont = false;
            this.xrTableCellMovie.Weight = 3.43783737651521;
            // 
            // xrTableFilmFullInfo
            // 
            this.xrTableFilmFullInfo.Borders = DevExpress.XtraPrinting.BorderSide.None;
            resources.ApplyResources(this.xrTableFilmFullInfo, "xrTableFilmFullInfo");
            this.xrTableFilmFullInfo.Name = "xrTableFilmFullInfo";
            this.xrTableFilmFullInfo.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRowFilmTitleAndReleaseDate,
            this.xrTableRowTagLine});
            this.xrTableFilmFullInfo.StylePriority.UseBorders = false;
            this.xrTableFilmFullInfo.StylePriority.UseTextAlignment = false;
            // 
            // xrTableRowFilmTitleAndReleaseDate
            // 
            this.xrTableRowFilmTitleAndReleaseDate.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrTableRowFilmTitleAndReleaseDate.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCellReleaseDateLabel,
            this.xrTableCellReleaseDate});
            this.xrTableRowFilmTitleAndReleaseDate.Name = "xrTableRowFilmTitleAndReleaseDate";
            this.xrTableRowFilmTitleAndReleaseDate.Padding = new DevExpress.XtraPrinting.PaddingInfo(10, 0, 0, 0, 100F);
            this.xrTableRowFilmTitleAndReleaseDate.StylePriority.UseBorders = false;
            this.xrTableRowFilmTitleAndReleaseDate.StylePriority.UsePadding = false;
            this.xrTableRowFilmTitleAndReleaseDate.StylePriority.UseTextAlignment = false;
            resources.ApplyResources(this.xrTableRowFilmTitleAndReleaseDate, "xrTableRowFilmTitleAndReleaseDate");
            this.xrTableRowFilmTitleAndReleaseDate.Weight = 0.11788778790443251;
            // 
            // xrTableCellReleaseDateLabel
            // 
            resources.ApplyResources(this.xrTableCellReleaseDateLabel, "xrTableCellReleaseDateLabel");
            this.xrTableCellReleaseDateLabel.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrTableCellReleaseDateLabel.BorderWidth = 1;
            this.xrTableCellReleaseDateLabel.Name = "xrTableCellReleaseDateLabel";
            this.xrTableCellReleaseDateLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(10, 10, 0, 0, 100F);
            this.xrTableCellReleaseDateLabel.StylePriority.UseBackColor = false;
            this.xrTableCellReleaseDateLabel.StylePriority.UseBorders = false;
            this.xrTableCellReleaseDateLabel.StylePriority.UseBorderWidth = false;
            this.xrTableCellReleaseDateLabel.StylePriority.UseFont = false;
            this.xrTableCellReleaseDateLabel.StylePriority.UsePadding = false;
            this.xrTableCellReleaseDateLabel.StylePriority.UseTextAlignment = false;
            this.xrTableCellReleaseDateLabel.Weight = 0.40829361735037595;
            // 
            // xrTableCellReleaseDate
            // 
            resources.ApplyResources(this.xrTableCellReleaseDate, "xrTableCellReleaseDate");
            this.xrTableCellReleaseDate.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrTableCellReleaseDate.BorderWidth = 1;
            this.xrTableCellReleaseDate.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "ReleaseDate", "{0:d}")});
            this.xrTableCellReleaseDate.Name = "xrTableCellReleaseDate";
            this.xrTableCellReleaseDate.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 100F);
            this.xrTableCellReleaseDate.StylePriority.UseBackColor = false;
            this.xrTableCellReleaseDate.StylePriority.UseBorders = false;
            this.xrTableCellReleaseDate.StylePriority.UseBorderWidth = false;
            this.xrTableCellReleaseDate.StylePriority.UseFont = false;
            this.xrTableCellReleaseDate.StylePriority.UseForeColor = false;
            this.xrTableCellReleaseDate.StylePriority.UsePadding = false;
            this.xrTableCellReleaseDate.StylePriority.UseTextAlignment = false;
            this.xrTableCellReleaseDate.Weight = 2.5917063826496238;
            // 
            // xrTableRowTagLine
            // 
            this.xrTableRowTagLine.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCellPlotLabel,
            this.xrTableCellPlot});
            this.xrTableRowTagLine.Name = "xrTableRowTagLine";
            this.xrTableRowTagLine.Weight = 0.47428028811004519;
            // 
            // xrTableCellPlotLabel
            // 
            resources.ApplyResources(this.xrTableCellPlotLabel, "xrTableCellPlotLabel");
            this.xrTableCellPlotLabel.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrTableCellPlotLabel.Name = "xrTableCellPlotLabel";
            this.xrTableCellPlotLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(10, 10, 0, 10, 100F);
            this.xrTableCellPlotLabel.StylePriority.UseBackColor = false;
            this.xrTableCellPlotLabel.StylePriority.UseBorders = false;
            this.xrTableCellPlotLabel.StylePriority.UseFont = false;
            this.xrTableCellPlotLabel.StylePriority.UsePadding = false;
            this.xrTableCellPlotLabel.StylePriority.UseTextAlignment = false;
            this.xrTableCellPlotLabel.Weight = 0.40829380889109568;
            // 
            // xrTableCellPlot
            // 
            resources.ApplyResources(this.xrTableCellPlot, "xrTableCellPlot");
            this.xrTableCellPlot.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrTableCellPlot.BorderWidth = 1;
            this.xrTableCellPlot.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Plot")});
            this.xrTableCellPlot.Name = "xrTableCellPlot";
            this.xrTableCellPlot.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 5, 100F);
            this.xrTableCellPlot.StylePriority.UseBackColor = false;
            this.xrTableCellPlot.StylePriority.UseBorders = false;
            this.xrTableCellPlot.StylePriority.UseBorderWidth = false;
            this.xrTableCellPlot.StylePriority.UseFont = false;
            this.xrTableCellPlot.StylePriority.UseForeColor = false;
            this.xrTableCellPlot.StylePriority.UsePadding = false;
            this.xrTableCellPlot.StylePriority.UseTextAlignment = false;
            this.xrTableCellPlot.Weight = 2.5917061911089045;
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
            // xpCollectionMovies
            // 
            this.xpCollectionMovies.CaseSensitive = true;
            this.xpCollectionMovies.ObjectType = typeof(NukaCollect.Movie);
            this.xpCollectionMovies.ResolveSession += new DevExpress.Xpo.ResolveSessionEventHandler(this.xpCollectionTheMostProfitableGenres_ResolveSession);
            // 
            // GroupHeaderGenreGroup
            // 
            this.GroupHeaderGenreGroup.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrRichText1,
            this.xrLabelTotalRevenueLabel,
            this.xrLabelTotalRevenue});
            this.GroupHeaderGenreGroup.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("Genre", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeaderGenreGroup.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            resources.ApplyResources(this.GroupHeaderGenreGroup, "GroupHeaderGenreGroup");
            this.GroupHeaderGenreGroup.Name = "GroupHeaderGenreGroup";
            xrGroupSortingSummary1.Enabled = true;
            xrGroupSortingSummary1.FieldName = "MovieId";
            xrGroupSortingSummary1.Function = DevExpress.XtraReports.UI.SortingSummaryFunction.Custom;
            xrGroupSortingSummary1.SortOrder = DevExpress.XtraReports.UI.XRColumnSortOrder.Descending;
            this.GroupHeaderGenreGroup.SortingSummary = xrGroupSortingSummary1;
            this.GroupHeaderGenreGroup.SortingSummaryReset += new System.EventHandler(this.GroupHeaderGenreGroup_SortingSummaryReset);
            this.GroupHeaderGenreGroup.SortingSummaryGetResult += new DevExpress.XtraReports.UI.GroupSortingSummaryGetResultEventHandler(this.GroupHeaderGenreGroup_SortingSummaryGetResult);
            this.GroupHeaderGenreGroup.SortingSummaryRowChanged += new DevExpress.XtraReports.UI.GroupSortingSummaryRowChangedEventHandler(this.GroupHeaderGenreGroup_SortingSummaryRowChanged);
            // 
            // xrRichText1
            // 
            this.xrRichText1.Bookmark = "Genres";
            this.xrRichText1.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Bookmark", null, "Genre")});
            resources.ApplyResources(this.xrRichText1, "xrRichText1");
            this.xrRichText1.Name = "xrRichText1";
            this.xrRichText1.SerializableRtfString = resources.GetString("xrRichText1.SerializableRtfString");
            this.xrRichText1.StylePriority.UseFont = false;
            // 
            // xrLabelTotalRevenueLabel
            // 
            resources.ApplyResources(this.xrLabelTotalRevenueLabel, "xrLabelTotalRevenueLabel");
            this.xrLabelTotalRevenueLabel.Name = "xrLabelTotalRevenueLabel";
            this.xrLabelTotalRevenueLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabelTotalRevenueLabel.StylePriority.UseFont = false;
            this.xrLabelTotalRevenueLabel.StylePriority.UseTextAlignment = false;
            // 
            // xrLabelTotalRevenue
            // 
            this.xrLabelTotalRevenue.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "MovieId")});
            resources.ApplyResources(this.xrLabelTotalRevenue, "xrLabelTotalRevenue");
            this.xrLabelTotalRevenue.Name = "xrLabelTotalRevenue";
            this.xrLabelTotalRevenue.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabelTotalRevenue.StylePriority.UseFont = false;
            this.xrLabelTotalRevenue.StylePriority.UseTextAlignment = false;
            resources.ApplyResources(xrSummary1, "xrSummary1");
            xrSummary1.Func = DevExpress.XtraReports.UI.SummaryFunc.Custom;
            xrSummary1.IgnoreNullValues = true;
            xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrLabelTotalRevenue.Summary = xrSummary1;
            this.xrLabelTotalRevenue.WordWrap = false;
            this.xrLabelTotalRevenue.SummaryReset += new System.EventHandler(this.xrLabelTotalRevenue_SummaryReset);
            this.xrLabelTotalRevenue.SummaryRowChanged += new System.EventHandler(this.xrLabelTotalRevenue_SummaryRowChanged);
            this.xrLabelTotalRevenue.SummaryGetResult += new DevExpress.XtraReports.UI.SummaryGetResultHandler(this.xrLabelTotalRevenue_SummaryGetResult);
            // 
            // TheMostProfitableGenresListReport
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.topMarginBand,
            this.bottomMarginBand,
            this.ReportHeader,
            this.GroupHeaderGenreGroup});
            this.Bookmark = "Genres";
            this.DataSource = this.xpCollectionMovies;
            this.Extensions.Add("ParametersRequestExtension", "TimePeriodReport");
            this.Extensions.Add("DataSerializationExtension", "TimePeriodReport");
            this.Extensions.Add("DataEditorExtension", "TimePeriodReport");
            this.Extensions.Add("ParameterEditorExtension", "TimePeriodReport");
            this.Margins = new System.Drawing.Printing.Margins(100, 100, 46, 50);
            this.RequestParameters = false;
            this.Version = "12.1";
            ((System.ComponentModel.ISupportInitialize)(this.xrTableFilmInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTableFilmFullInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollectionMovies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand topMarginBand;
        private DevExpress.XtraReports.UI.BottomMarginBand bottomMarginBand;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.UI.XRLabel xrLabelHeader;
        private DevExpress.Xpo.XPCollection xpCollectionMovies;
        private DevExpress.XtraReports.UI.XRPageInfo xrPageInfoPageCount;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeaderGenreGroup;
        private DevExpress.XtraReports.UI.XRLabel xrLabelTotalRevenue;
        private DevExpress.XtraReports.UI.XRTable xrTableFilmInfo;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRowFilmInfo;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCellCover;
        private DevExpress.XtraReports.UI.XRPictureBox xrPictureBoxCover;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCellMovie;
        private DevExpress.XtraReports.UI.XRTable xrTableFilmFullInfo;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRowFilmTitleAndReleaseDate;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCellReleaseDateLabel;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCellReleaseDate;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRowTagLine;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCellPlot;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow1;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCellMovieTitle;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCellRevenue;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCellPlotLabel;
        private DevExpress.XtraReports.UI.XRLabel xrLabelTotalRevenueLabel;
        private DevExpress.XtraReports.UI.XRRichText xrRichText1;
    }
}
