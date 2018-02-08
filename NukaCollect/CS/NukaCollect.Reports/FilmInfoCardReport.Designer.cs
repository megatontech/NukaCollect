namespace NukaCollect.Reports {
    partial class FilmInfoCardReport {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilmInfoCardReport));
            DevExpress.XtraPrinting.BarCode.Code128Generator code128Generator1 = new DevExpress.XtraPrinting.BarCode.Code128Generator();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrPanelFilmInfoCard = new DevExpress.XtraReports.UI.XRPanel();
            this.xrLabelMovieTitle = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableFilmInfo = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRowGenreInfo = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCellGenreLable = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCellGenre = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRowYearInfo = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCellYearLable = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCellYear = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRowRatingInfo = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCellRatingLable = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCellRating = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRowLocationInfo = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCellLocationLable = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCellLocation = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrBarCodeMoviItemId = new DevExpress.XtraReports.UI.XRBarCode();
            this.topMarginBand = new DevExpress.XtraReports.UI.TopMarginBand();
            this.bottomMarginBand = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.xrPageInfoPageCount = new DevExpress.XtraReports.UI.XRPageInfo();
            this.xpCollectionMovieItems = new DevExpress.Xpo.XPCollection(this.components);
            this.xpCollectionMovies = new DevExpress.Xpo.XPCollection(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.xrTableFilmInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollectionMovieItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollectionMovies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPanelFilmInfoCard});
            resources.ApplyResources(this.Detail, "Detail");
            this.Detail.MultiColumn.ColumnCount = 2;
            this.Detail.MultiColumn.Layout = DevExpress.XtraPrinting.ColumnLayout.AcrossThenDown;
            this.Detail.MultiColumn.Mode = DevExpress.XtraReports.UI.MultiColumnMode.UseColumnCount;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            // 
            // xrPanelFilmInfoCard
            // 
            resources.ApplyResources(this.xrPanelFilmInfoCard, "xrPanelFilmInfoCard");
            this.xrPanelFilmInfoCard.Borders = DevExpress.XtraPrinting.BorderSide.Left;
            this.xrPanelFilmInfoCard.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabelMovieTitle,
            this.xrTableFilmInfo,
            this.xrBarCodeMoviItemId});
            this.xrPanelFilmInfoCard.Name = "xrPanelFilmInfoCard";
            this.xrPanelFilmInfoCard.StylePriority.UseBackColor = false;
            this.xrPanelFilmInfoCard.StylePriority.UseBorderColor = false;
            this.xrPanelFilmInfoCard.StylePriority.UseBorders = false;
            // 
            // xrLabelMovieTitle
            // 
            this.xrLabelMovieTitle.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabelMovieTitle.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Movie.Title")});
            resources.ApplyResources(this.xrLabelMovieTitle, "xrLabelMovieTitle");
            this.xrLabelMovieTitle.Name = "xrLabelMovieTitle";
            this.xrLabelMovieTitle.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 100F);
            this.xrLabelMovieTitle.StylePriority.UseBorders = false;
            this.xrLabelMovieTitle.StylePriority.UseFont = false;
            this.xrLabelMovieTitle.StylePriority.UsePadding = false;
            this.xrLabelMovieTitle.StylePriority.UseTextAlignment = false;
            // 
            // xrTableFilmInfo
            // 
            this.xrTableFilmInfo.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrTableFilmInfo.BorderWidth = 1;
            resources.ApplyResources(this.xrTableFilmInfo, "xrTableFilmInfo");
            this.xrTableFilmInfo.Name = "xrTableFilmInfo";
            this.xrTableFilmInfo.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRowGenreInfo,
            this.xrTableRowYearInfo,
            this.xrTableRowRatingInfo,
            this.xrTableRowLocationInfo});
            this.xrTableFilmInfo.StylePriority.UseBorders = false;
            this.xrTableFilmInfo.StylePriority.UseBorderWidth = false;
            this.xrTableFilmInfo.StylePriority.UseFont = false;
            this.xrTableFilmInfo.StylePriority.UseTextAlignment = false;
            // 
            // xrTableRowGenreInfo
            // 
            this.xrTableRowGenreInfo.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCellGenreLable,
            this.xrTableCellGenre});
            this.xrTableRowGenreInfo.Name = "xrTableRowGenreInfo";
            this.xrTableRowGenreInfo.Weight = 0.17450354620551689;
            // 
            // xrTableCellGenreLable
            // 
            resources.ApplyResources(this.xrTableCellGenreLable, "xrTableCellGenreLable");
            this.xrTableCellGenreLable.Name = "xrTableCellGenreLable";
            this.xrTableCellGenreLable.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100F);
            this.xrTableCellGenreLable.StylePriority.UseFont = false;
            this.xrTableCellGenreLable.StylePriority.UsePadding = false;
            this.xrTableCellGenreLable.StylePriority.UseTextAlignment = false;
            this.xrTableCellGenreLable.Weight = 0.875170230911391;
            // 
            // xrTableCellGenre
            // 
            this.xrTableCellGenre.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Movie.Genre")});
            resources.ApplyResources(this.xrTableCellGenre, "xrTableCellGenre");
            this.xrTableCellGenre.Multiline = true;
            this.xrTableCellGenre.Name = "xrTableCellGenre";
            this.xrTableCellGenre.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 0, 0, 0, 100F);
            this.xrTableCellGenre.StylePriority.UseFont = false;
            this.xrTableCellGenre.StylePriority.UsePadding = false;
            this.xrTableCellGenre.Weight = 2.1248297690886089;
            // 
            // xrTableRowYearInfo
            // 
            this.xrTableRowYearInfo.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCellYearLable,
            this.xrTableCellYear});
            this.xrTableRowYearInfo.Name = "xrTableRowYearInfo";
            this.xrTableRowYearInfo.Weight = 0.17450354408026392;
            // 
            // xrTableCellYearLable
            // 
            this.xrTableCellYearLable.CanGrow = false;
            resources.ApplyResources(this.xrTableCellYearLable, "xrTableCellYearLable");
            this.xrTableCellYearLable.Name = "xrTableCellYearLable";
            this.xrTableCellYearLable.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100F);
            this.xrTableCellYearLable.StylePriority.UseFont = false;
            this.xrTableCellYearLable.StylePriority.UsePadding = false;
            this.xrTableCellYearLable.StylePriority.UseTextAlignment = false;
            this.xrTableCellYearLable.Weight = 0.875170230911391;
            // 
            // xrTableCellYear
            // 
            this.xrTableCellYear.CanGrow = false;
            this.xrTableCellYear.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Movie.ReleaseDate", "{0:yyyy}")});
            resources.ApplyResources(this.xrTableCellYear, "xrTableCellYear");
            this.xrTableCellYear.Multiline = true;
            this.xrTableCellYear.Name = "xrTableCellYear";
            this.xrTableCellYear.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 0, 0, 0, 100F);
            this.xrTableCellYear.StylePriority.UseFont = false;
            this.xrTableCellYear.StylePriority.UsePadding = false;
            this.xrTableCellYear.Weight = 2.1248297690886089;
            // 
            // xrTableRowRatingInfo
            // 
            this.xrTableRowRatingInfo.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCellRatingLable,
            this.xrTableCellRating});
            this.xrTableRowRatingInfo.Name = "xrTableRowRatingInfo";
            this.xrTableRowRatingInfo.Weight = 0.17450354098189264;
            // 
            // xrTableCellRatingLable
            // 
            this.xrTableCellRatingLable.CanGrow = false;
            resources.ApplyResources(this.xrTableCellRatingLable, "xrTableCellRatingLable");
            this.xrTableCellRatingLable.Name = "xrTableCellRatingLable";
            this.xrTableCellRatingLable.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100F);
            this.xrTableCellRatingLable.StylePriority.UseFont = false;
            this.xrTableCellRatingLable.StylePriority.UsePadding = false;
            this.xrTableCellRatingLable.StylePriority.UseTextAlignment = false;
            this.xrTableCellRatingLable.Weight = 0.875170230911391;
            // 
            // xrTableCellRating
            // 
            this.xrTableCellRating.CanGrow = false;
            this.xrTableCellRating.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Movie.Rating")});
            resources.ApplyResources(this.xrTableCellRating, "xrTableCellRating");
            this.xrTableCellRating.Multiline = true;
            this.xrTableCellRating.Name = "xrTableCellRating";
            this.xrTableCellRating.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 0, 0, 0, 100F);
            this.xrTableCellRating.StylePriority.UseFont = false;
            this.xrTableCellRating.StylePriority.UsePadding = false;
            this.xrTableCellRating.Weight = 2.1248297690886089;
            // 
            // xrTableRowLocationInfo
            // 
            this.xrTableRowLocationInfo.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCellLocationLable,
            this.xrTableCellLocation});
            this.xrTableRowLocationInfo.Name = "xrTableRowLocationInfo";
            this.xrTableRowLocationInfo.Weight = 0.17450354098189264;
            // 
            // xrTableCellLocationLable
            // 
            this.xrTableCellLocationLable.CanGrow = false;
            resources.ApplyResources(this.xrTableCellLocationLable, "xrTableCellLocationLable");
            this.xrTableCellLocationLable.Name = "xrTableCellLocationLable";
            this.xrTableCellLocationLable.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100F);
            this.xrTableCellLocationLable.StylePriority.UseFont = false;
            this.xrTableCellLocationLable.StylePriority.UsePadding = false;
            this.xrTableCellLocationLable.StylePriority.UseTextAlignment = false;
            this.xrTableCellLocationLable.Weight = 0.875170230911391;
            // 
            // xrTableCellLocation
            // 
            this.xrTableCellLocation.CanGrow = false;
            this.xrTableCellLocation.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Location")});
            resources.ApplyResources(this.xrTableCellLocation, "xrTableCellLocation");
            this.xrTableCellLocation.Multiline = true;
            this.xrTableCellLocation.Name = "xrTableCellLocation";
            this.xrTableCellLocation.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 0, 0, 0, 100F);
            this.xrTableCellLocation.StylePriority.UseFont = false;
            this.xrTableCellLocation.StylePriority.UsePadding = false;
            this.xrTableCellLocation.Weight = 2.1248297690886089;
            // 
            // xrBarCodeMoviItemId
            // 
            this.xrBarCodeMoviItemId.AutoModule = true;
            resources.ApplyResources(this.xrBarCodeMoviItemId, "xrBarCodeMoviItemId");
            this.xrBarCodeMoviItemId.BarCodeOrientation = DevExpress.XtraPrinting.BarCode.BarCodeOrientation.RotateLeft;
            this.xrBarCodeMoviItemId.Borders = DevExpress.XtraPrinting.BorderSide.Left;
            this.xrBarCodeMoviItemId.Name = "xrBarCodeMoviItemId";
            this.xrBarCodeMoviItemId.Padding = new DevExpress.XtraPrinting.PaddingInfo(10, 5, 10, 10, 100F);
            this.xrBarCodeMoviItemId.StylePriority.UseBackColor = false;
            this.xrBarCodeMoviItemId.StylePriority.UseBorderColor = false;
            this.xrBarCodeMoviItemId.StylePriority.UseBorders = false;
            this.xrBarCodeMoviItemId.StylePriority.UseFont = false;
            this.xrBarCodeMoviItemId.StylePriority.UsePadding = false;
            this.xrBarCodeMoviItemId.StylePriority.UseTextAlignment = false;
            this.xrBarCodeMoviItemId.Symbology = code128Generator1;
            this.xrBarCodeMoviItemId.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.xrBarCode2_BeforePrint);
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
            // xpCollectionMovieItems
            // 
            this.xpCollectionMovieItems.ObjectType = typeof(NukaCollect.MovieItem);
            this.xpCollectionMovieItems.Sorting.AddRange(new DevExpress.Xpo.SortProperty[] {
            new DevExpress.Xpo.SortProperty("[MovieTitle]", DevExpress.Xpo.DB.SortingDirection.Ascending)});
            this.xpCollectionMovieItems.ResolveSession += new DevExpress.Xpo.ResolveSessionEventHandler(this.xpCollectionMovieItems_ResolveSession);
            // 
            // xpCollectionMovies
            // 
            this.xpCollectionMovies.ObjectType = typeof(NukaCollect.Movie);
            this.xpCollectionMovies.Sorting.AddRange(new DevExpress.Xpo.SortProperty[] {
            new DevExpress.Xpo.SortProperty("[Title]", DevExpress.Xpo.DB.SortingDirection.Ascending)});
            this.xpCollectionMovies.ResolveSession += new DevExpress.Xpo.ResolveSessionEventHandler(this.xpCollectionMovies_ResolveSession);
            // 
            // FilmInfoCardReport
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.topMarginBand,
            this.bottomMarginBand});
            this.DataSource = this.xpCollectionMovieItems;
            this.FilterString = "[Status] <> \'SoldOut\' And [Status] <> \'Damage\' And [Status] <> \'Lost\'";
            this.Margins = new System.Drawing.Printing.Margins(50, 51, 23, 37);
            this.RequestParameters = false;
            this.Version = "12.1";
            ((System.ComponentModel.ISupportInitialize)(this.xrTableFilmInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollectionMovieItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollectionMovies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand topMarginBand;
        private DevExpress.XtraReports.UI.BottomMarginBand bottomMarginBand;
        private DevExpress.Xpo.XPCollection xpCollectionMovieItems;
        private DevExpress.XtraReports.UI.XRPanel xrPanelFilmInfoCard;
        private DevExpress.XtraReports.UI.XRTable xrTableFilmInfo;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRowGenreInfo;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCellGenreLable;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCellGenre;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRowYearInfo;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCellYearLable;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCellYear;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRowRatingInfo;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCellRatingLable;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCellRating;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRowLocationInfo;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCellLocationLable;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCellLocation;
        private DevExpress.XtraReports.UI.XRBarCode xrBarCodeMoviItemId;
        private DevExpress.XtraReports.UI.XRPageInfo xrPageInfoPageCount;
        private DevExpress.Xpo.XPCollection xpCollectionMovies;
        private DevExpress.XtraReports.UI.XRLabel xrLabelMovieTitle;
    }
}
