using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Globalization;
using DevExpress.Data.PivotGrid;
using DevExpress.XtraCharts;
using DevExpress.XtraPivotGrid;
using DevExpress.XtraLayout;
using NukaCollect.Win.Modules;
using DevExpress.XtraGrid.Views.Base;
using NukaCollect.Resources;

namespace NukaCollect.Win.ModulesStatistics {
    public partial class MediaPerformanceStatistics : ChartExportTutorialControl {
        SalesPivotGridHelper salesGrid;
        MostRentedPivotGridHelper mostRentedPivotGrid;
        MovieItemFormat selectedFormat;

        protected internal override bool UseList { get { return false; } }
        protected override ChartControl MainChart { get { return chart; } }
        protected override ChartControl AlternateChart { get { return chartRevenues; } }
        protected override LayoutControl MainLayoutControl { get { return layoutControl1; } }
        protected override ColumnView MainView { get { return cardView1; } }
        protected override bool AllowRotateLayout { get { return true; } }
        protected override bool AllowFlipLayout { get { return true; } }
        public MediaPerformanceStatistics() {
            InitializeComponent();

            this.salesGrid = new SalesPivotGridHelper();            
            this.chartRevenues.DataSource = this.salesGrid.ChartDataSource;

            this.mostRentedPivotGrid = new MostRentedPivotGridHelper();
            this.selectedFormat = MovieItemFormat.DVD;
            chart.Titles[0].Text = ConstStrings.Get("MovieMediaDB");
            ((PieSeriesView)chart.Series[0].View).Titles[0].Text = ConstStrings.Get("PieHint");
        }
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            if(disposing) {
                salesGrid.Dispose();
                mostRentedPivotGrid.Dispose();
            }
            base.Dispose(disposing);
        }
        public MovieItemFormat SelectedFormat {
            get { return selectedFormat; }
            set {
                if(selectedFormat == value) return;
                selectedFormat = value;
                UpdateFormatStats();
            }
        }

        protected override void InitData() {
            base.InitData();
            XPCollection<MovieItem> movieItems = new XPCollection<MovieItem>(Session);
            chart.DataSource = movieItems;

            UpdateFormatStats();
            UpdateChartSelection();
        }

        MovieItemFormat? GetFormatFromHitInfo(ChartHitInfo hitInfo) {
            if(hitInfo.HitTest == ChartHitTest.Series && hitInfo.SeriesPoint != null &&
                    !string.IsNullOrEmpty(hitInfo.SeriesPoint.Argument)) {
                try {
                    MovieItemFormat format = (MovieItemFormat)Enum.Parse(typeof(MovieItemFormat), hitInfo.SeriesPoint.Argument);
                    return format;
                } catch { }
            }
            return null;
        }

        void chart_MouseClick(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left || e.Button == MouseButtons.Middle) {
                ChartHitInfo hitInfo = chart.CalcHitInfo(e.Location);
                MovieItemFormat? format = GetFormatFromHitInfo(hitInfo);
                if (format == null)
                    return;
                SelectedFormat = format.Value;
            }
        }
        protected override void BeginRefreshData() {
            base.BeginRefreshData();
            UpdateFormatStats();
            UpdateChartSelection();
        }
        void UpdateFormatStats() {
            XPCollection<Rent> rents = new XPCollection<Rent>(Session,
                new GroupOperator(
                    GroupOperatorType.And,
                    new BinaryOperator("Item.Format", SelectedFormat, BinaryOperatorType.Equal),
                    new BinaryOperator("Receipt.Date", DateTime.Now.AddYears(-1), BinaryOperatorType.GreaterOrEqual)
                ));
            this.salesGrid.DataSource = rents;
            this.chartRevenues.Titles[0].Text = string.Format(ConstStrings.Get("MovieRevenues"), EnumTitlesKeeper<MovieItemFormat>.GetTitle(SelectedFormat));
            this.mostRentedPivotGrid.DataSource = rents;
            this.gridControl1.DataSource = this.mostRentedPivotGrid.CreateSummaryDataSource();
            this.cardView1.ViewCaption = string.Format(ConstStrings.Get("MostRentedMovies"), EnumTitlesKeeper<MovieItemFormat>.GetTitle(SelectedFormat));
        }

        void UpdateChartSelection() {
            chart.ClearSelection();
            Series series = chart.Series[0];
            chart.SetObjectSelection(FindSeriesPoint(series, SelectedFormat.ToString()));
        }

        SeriesPoint FindSeriesPoint(Series series, string argument) {
            foreach(SeriesPoint pt in series.Points) {
                if(pt.Argument == argument)
                    return pt;
            }
            return null;
        }

        void chart_MouseMove(object sender, MouseEventArgs e) {
            ChartHitInfo hitInfo = chart.CalcHitInfo(e.Location);
            MovieItemFormat? format = GetFormatFromHitInfo(hitInfo);
            if(format != null)
                chart.Cursor = Cursors.Hand;
            else
                chart.Cursor = Cursors.Default;
        }

        void chart_MouseLeave(object sender, EventArgs e) {
            chart.Cursor = Cursors.Default;
        }

        void chartRevenues_BoundDataChanged(object sender, EventArgs e) {
            Series totalSeries = chartRevenues.Series[SalesPivotGridHelper.TotalText];
            if(totalSeries != null) {
                totalSeries.ChangeView(ViewType.Bar);
                totalSeries.LabelsVisibility = DevExpress.Utils.DefaultBoolean.False; ;
            }
        }

        private void chart_ObjectHotTracked(object sender, HotTrackEventArgs e) {
            if (!e.HitInfo.InSeries)
                e.Cancel = true;
        }

        private void chart_ObjectSelected(object sender, HotTrackEventArgs e) {
            if(!e.HitInfo.InSeries) 
                e.Cancel = true;
        }

        private void cardView1_CalcFieldHeight(object sender, DevExpress.XtraGrid.Views.Card.FieldHeightEventArgs e) {
            if(e.Column != colPhoto) return;
            Image img = cardView1.GetRowCellValue(e.RowHandle, e.Column) as Image;
            if(img != null) 
                e.FieldHeight = Math.Min(img.Height, cardView1.ViewRect.Height - 100);
            if(e.FieldHeight < 20) e.FieldHeight = 20;
        }
        protected override VideoRentBaseObject CurrentEditObject { 
            get {
                PivotSummaryDataRow row = cardView1.GetRow(cardView1.FocusedRowHandle) as PivotSummaryDataRow;
                if(row == null) return null;
                return mostRentedPivotGrid.GetMovie(row.RowIndex);
            } 
        }
        public override void Edit() {
            base.Edit();
            if(!IsDetailExist(CurrentEditObject.Oid))
                ShowModuleDialog(new MovieDetail(this.FindForm(), GetSession, CurrentEditObject as Movie, MenuManager, CloseDetailForm), true);
        }

        private void chart_CustomDrawSeriesPoint(object sender, CustomDrawSeriesPointEventArgs e) {
            MovieItemFormat format = (MovieItemFormat)Enum.Parse(typeof(MovieItemFormat), string.Format("{0}", e.SeriesPoint.Argument));
            e.LabelText = EnumTitlesKeeper<MovieItemFormat>.GetTitle(format);
            e.LegendText = EnumTitlesKeeper<MovieItemFormat>.GetTitle(format);
        }

        private void chartRevenues_CustomDrawSeries(object sender, CustomDrawSeriesEventArgs e) {
            ReceiptType type = (ReceiptType)Enum.Parse(typeof(ReceiptType), string.Format("{0}", e.Series.Name));
            e.LegendText = EnumTitlesKeeper<ReceiptType>.GetTitle(type);
        }
    }

    class SalesPivotGridHelper : IDisposable{
        public static string TotalText = ConstStrings.Get("Total");

        PivotGridControl pivotGrid;
        PivotGridField fieldMonth, fieldReceiptType;

        public SalesPivotGridHelper() {
            this.pivotGrid = new PivotGridControl();
            this.pivotGrid.CustomGroupInterval += new PivotCustomGroupIntervalEventHandler(salesGrid_CustomGroupInterval);
            this.pivotGrid.FieldValueDisplayText += new PivotFieldDisplayTextEventHandler(salesGrid_FieldValueDisplayText);
            this.pivotGrid.OptionsView.RowTotalsLocation = PivotRowTotalsLocation.Near;

            this.pivotGrid.OptionsChartDataSource.ProvideColumnGrandTotals = false;
            this.pivotGrid.OptionsChartDataSource.SelectionOnly = false;
            this.pivotGrid.OptionsChartDataSource.ProvideDataByColumns = false;

            this.pivotGrid.Fields.Add("Payment", PivotArea.DataArea);
            this.fieldMonth = this.pivotGrid.Fields.Add("Receipt.Date", PivotArea.ColumnArea);
            this.fieldMonth.GroupInterval = PivotGroupInterval.Custom;
            this.fieldReceiptType = this.pivotGrid.Fields.Add("Receipt.Type", PivotArea.RowArea);
        }

        public object ChartDataSource {
            get { return this.pivotGrid; }
        }

        public object DataSource {
            get { return this.pivotGrid.DataSource; }
            set { this.pivotGrid.DataSource = value; }
        }

        void salesGrid_FieldValueDisplayText(object sender, PivotFieldDisplayTextEventArgs e) {
            if(e.Field == fieldMonth) {
                DateTime valueAsDate = (DateTime)e.Value;
                e.DisplayText = valueAsDate.ToString("MMM yyyy");
            }
            if(e.Field == null) {
                e.DisplayText = TotalText;
            }
        }

        void salesGrid_CustomGroupInterval(object sender, PivotCustomGroupIntervalEventArgs e) {
            if(e.Field == fieldMonth) {
                DateTime valueAsDate = (DateTime)e.Value;
                e.GroupValue = new DateTime(valueAsDate.Year, valueAsDate.Month, 1);
            }
        }

        #region IDisposable Members
        public void Dispose() {
            if(pivotGrid != null) {
                pivotGrid.CustomGroupInterval -= new PivotCustomGroupIntervalEventHandler(salesGrid_CustomGroupInterval);
                pivotGrid.FieldValueDisplayText -= new PivotFieldDisplayTextEventHandler(salesGrid_FieldValueDisplayText);
                pivotGrid.Fields.Clear();
                pivotGrid.Dispose();
            }
        }
        #endregion
    }
    class MostRentedPivotGridHelper : IDisposable {
        PivotGridControl pivotGrid;
        PivotGridField fieldRentCount, fieldMovie;

        public MostRentedPivotGridHelper() {
            this.pivotGrid = new PivotGridControl();
            this.pivotGrid.FieldValueDisplayText += new PivotFieldDisplayTextEventHandler(pivotGrid_FieldValueDisplayText);
                        
            this.pivotGrid.OptionsChartDataSource.SelectionOnly = false;
            this.pivotGrid.OptionsChartDataSource.ProvideRowGrandTotals = false;
            this.pivotGrid.OptionsDataField.FieldNaming = DataFieldNaming.Name;

            this.fieldRentCount = this.pivotGrid.Fields.Add("Payment", PivotArea.DataArea);
            this.fieldRentCount.Name = "Payment_Sum";
            this.fieldRentCount.SummaryType = PivotSummaryType.Count;

            this.fieldMovie = this.pivotGrid.Fields.Add("Item!.Movie", PivotArea.RowArea);
            this.fieldMovie.Name = "Movie";
            this.fieldMovie.SortBySummaryInfo.Field = this.fieldRentCount;
            this.fieldMovie.SortOrder = PivotSortOrder.Descending;
            this.fieldMovie.TopValueCount = 5;
        }

        public PivotGridControl PivotGrid { get { return pivotGrid; } }

        public Movie GetMovie(int index) {
            return pivotGrid.GetFieldValue(fieldMovie, index) as Movie;
        }

        public PivotSummaryDataSource CreateSummaryDataSource() {
            return this.pivotGrid.CreateSummaryDataSource();
        }

        public object DataSource {
            get { return this.pivotGrid.DataSource; }
            set { this.pivotGrid.DataSource = value; }
        }

        void pivotGrid_FieldValueDisplayText(object sender, PivotFieldDisplayTextEventArgs e) {
            if(e.Field == fieldMovie) {
                Movie valueAsMovie = (Movie)e.Value;
                e.DisplayText = valueAsMovie.Title;
            }
        }

        #region IDisposable Members
        public void Dispose() {
            if(pivotGrid != null) {
                pivotGrid.FieldValueDisplayText -= new PivotFieldDisplayTextEventHandler(pivotGrid_FieldValueDisplayText);
                pivotGrid.Fields.Clear();
                pivotGrid.Dispose();
            }
        }
        #endregion
    }
}
