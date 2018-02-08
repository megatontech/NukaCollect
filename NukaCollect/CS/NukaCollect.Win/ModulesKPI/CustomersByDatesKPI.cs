using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraCharts;
using DevExpress.XtraLayout;
using DevExpress.Xpo;
using DevExpress.XtraPivotGrid;
using DevExpress.Data.Filtering;
using NukaCollect.Resources;

namespace NukaCollect.Win.ModulesKPI {
    public partial class CustomersByDatesKPI : ChartExportTutorialControl {
        const int selectedRowsCount = 5;
        string customersChartTitleText = ConstStrings.Get("CustomersDatesModule");

        CustomerToolTipController tooltipGrid;
        CustomerToolTipController tooltipChart;
        CustomerDiscountLevelToolTipController tooltipDiscount;

        XYDiagram Diagram { get { return customersChart.Diagram as XYDiagram; } }
        protected override ChartControl MainChart { get { return customersChart; } }
        protected override LayoutControl MainLayoutControl { get { return layoutControl1; } }
        protected override bool AllowFlipLayout { get { return true; } }

        public CustomersByDatesKPI() {
            InitializeComponent();
            customersGrid.BestFit();
            tooltipGrid = new CustomerToolTipController(customersGrid);
            tooltipChart = new CustomerToolTipController(customersChart);
            tooltipDiscount = new CustomerDiscountLevelToolTipController(customersChart);
            customersChart.Series[0].LegendText = EnumTitlesKeeper<CustomerDiscountLevel>.GetTitle(CustomerDiscountLevel.FirstTime);
            customersChart.Series[1].LegendText = EnumTitlesKeeper<CustomerDiscountLevel>.GetTitle(CustomerDiscountLevel.Basic);
            customersChart.Series[2].LegendText = EnumTitlesKeeper<CustomerDiscountLevel>.GetTitle(CustomerDiscountLevel.Occasional);
            customersChart.Series[3].LegendText = EnumTitlesKeeper<CustomerDiscountLevel>.GetTitle(CustomerDiscountLevel.Active);
            customersChart.Series[4].LegendText = EnumTitlesKeeper<CustomerDiscountLevel>.GetTitle(CustomerDiscountLevel.Prodigious);
            ((XYDiagram)customersChart.Diagram).AxisY.Title.Text = string.Format("{0} {1}", ConstStrings.Get("Payment"), Application.CurrentCulture.NumberFormat.CurrencySymbol);
            ElementConstStringLoader.LoadConstStringsForCustomerByDatesKPI(this);
            cbeSortMode.Properties.Items.Clear();
            cbeSortMode.Properties.Items.Add(ConstStrings.Get("Payment"));
            cbeSortMode.Properties.Items.Add(ConstStrings.Get("Customer"));
            cbeSortMode.SelectedIndex = 0;
        }
        void AddConstantLine(AxisY axis, CustomerDiscountLevel level) {
            ConstantLine constantLine = new ConstantLine(level.ToString(), (int)ReferenceData.GetDiscountLevelPayment(level));
            constantLine.Title.Text = EnumTitlesKeeper<CustomerDiscountLevel>.GetTitle(level) + " (" + ((int)ReferenceData.GetDiscountLevelPayment(level)).ToString() + ")";
            constantLine.ShowInLegend = false;
            axis.ConstantLines.Add(constantLine);
        }
        void AddSelection(List<Point> selection, int rowIndex) {
            for (int i = 0; i < selectedRowsCount; i++)
                selection.Add(new Point(0, rowIndex + i));
        }
        void SetColors(DrawOptions drawOptions, int colorIndex) {
            PaletteEntry palleteEntry = customersChart.GetPaletteEntries(5)[colorIndex];
            drawOptions.Color = palleteEntry.Color;
            BarDrawOptions barDrawoptions = drawOptions as BarDrawOptions;
            if (barDrawoptions != null) {
                RectangleGradientFillOptions gradientOptions = barDrawoptions.FillStyle.Options as RectangleGradientFillOptions;
                if (gradientOptions != null)
                    gradientOptions.Color2 = palleteEntry.Color2;
            }
        }
        void CustomerKPI_Load(object sender, EventArgs e) {
            List<Point> selection = new List<Point>();
            AddSelection(selection, 0);
            AddSelection(selection, customersGrid.Cells.RowCount / 3);
            AddSelection(selection, customersGrid.Cells.RowCount - selectedRowsCount);
            customersGrid.Cells.MultiSelection.SetSelection(selection.ToArray());
            customersChart.DataSource = customersGrid;
            if (Diagram != null) {
                AddConstantLine(Diagram.AxisY, CustomerDiscountLevel.Basic);
                AddConstantLine(Diagram.AxisY, CustomerDiscountLevel.Occasional);
                AddConstantLine(Diagram.AxisY, CustomerDiscountLevel.Active);
                AddConstantLine(Diagram.AxisY, CustomerDiscountLevel.Prodigious);
            }
        }
        void SetDateFilter() {
            receiptsCollection.Criteria =
                        new GroupOperator(GroupOperatorType.And,
                            new BinaryOperator(
                                "Date", PeriodManager.KPIPeriod.StartDate, BinaryOperatorType.GreaterOrEqual),
                            new BinaryOperator(
                            "Date", PeriodManager.KPIPeriod.EndDate, BinaryOperatorType.LessOrEqual)
                        );
        }
        void receiptsCollection_ResolveSession(object sender, ResolveSessionEventArgs e) {
            SetDateFilter();
            e.Session = Session;
        }
        void customersChart_BoundDataChanged(object sender, EventArgs e) {
            if (Diagram != null && customersChart.Series.Count > 0) {
                bool isVerticalLabels = customersChart.Series[0].Points.Count > 12;
                Diagram.AxisX.Label.Angle = isVerticalLabels ? -90 : 0;
                foreach (Series series in customersChart.Series)
                    series.Label.TextOrientation = isVerticalLabels ? TextOrientation.BottomToTop : TextOrientation.Horizontal;
                customersChart.Titles[0].Text = customersChartTitleText + " (" + customersChart.Series[0].Name + ")";
            }
        }
        void customersChart_CustomDrawSeries(object sender, CustomDrawSeriesEventArgs e) {
            switch (customersChart.Series.IndexOf(e.Series)) {
                case 1:
                    SetColors(e.LegendDrawOptions, 0);
                    break;
                case 2:
                    SetColors(e.LegendDrawOptions, 1);
                    break;
                case 3:
                    SetColors(e.LegendDrawOptions, 2);
                    break;
                case 4:
                    SetColors(e.LegendDrawOptions, 3);
                    break;
                case 5:
                    SetColors(e.LegendDrawOptions, 4);
                    break;
            }
        }
        void customersChart_CustomDrawSeriesPoint(object sender, CustomDrawSeriesPointEventArgs e) {
            if (e.SeriesPoint.Values[0] >= (int)ReferenceData.GetDiscountLevelPayment(CustomerDiscountLevel.Prodigious))
                SetColors(e.SeriesDrawOptions, 0);
            else if (e.SeriesPoint.Values[0] >= (int)ReferenceData.GetDiscountLevelPayment(CustomerDiscountLevel.Active))
                SetColors(e.SeriesDrawOptions, 1);
            else if (e.SeriesPoint.Values[0] >= (int)ReferenceData.GetDiscountLevelPayment(CustomerDiscountLevel.Occasional))
                SetColors(e.SeriesDrawOptions, 2);
            else if (e.SeriesPoint.Values[0] >= (int)ReferenceData.GetDiscountLevelPayment(CustomerDiscountLevel.Basic))
                SetColors(e.SeriesDrawOptions, 3);
            else
                SetColors(e.SeriesDrawOptions, 4);
        }
        void customersChart_MouseMove(object sender, MouseEventArgs e) {
            ChartHitInfo hitInfo = customersChart.CalcHitInfo(e.X, e.Y);
            if (hitInfo.SeriesPoint != null) {
                int[] cell = hitInfo.SeriesPoint.Tag as int[];
                if (cell != null && cell.Length == 2) {
                    Customer customer = customersGrid.GetFieldValue(fieldCustomer, cell[1]) as Customer;
                    if (customer != null) {
                        tooltipChart.ShowHint(customer, e.Location);
                        return;
                    }
                }
            }
            tooltipChart.HideHint(true);
            if (hitInfo.Series != null) {
                Series series = hitInfo.Series as Series;
                if (series != null) {
                    switch (series.Name) {
                        case "FirstTime":
                            tooltipDiscount.ShowHint(CustomerDiscountLevel.FirstTime, e.Location);
                            return;
                        case "Basic":
                            tooltipDiscount.ShowHint(CustomerDiscountLevel.Basic, e.Location);
                            return;
                        case "Occasional":
                            tooltipDiscount.ShowHint(CustomerDiscountLevel.Occasional, e.Location);
                            return;
                        case "Active":
                            tooltipDiscount.ShowHint(CustomerDiscountLevel.Active, e.Location);
                            return;
                        case "Prodigious":
                            tooltipDiscount.ShowHint(CustomerDiscountLevel.Prodigious, e.Location);
                            return;
                    }
                }
            }
            tooltipDiscount.HideHint(true);
        }
        void customersGrid_MouseMove(object sender, MouseEventArgs e) {
            PivotGridHitInfo hitInfo = customersGrid.CalcHitInfo(e.Location);
            if(MustShowCustomerTooltip(hitInfo)) {
                Customer customer = hitInfo.ValueInfo.Value as Customer;
                if (customer != null) {
                    Point location = e.Location;
                    location.Offset(20, 20);
                    tooltipGrid.ShowHint(customer, location);
                }
            }
            else
                tooltipGrid.HideHint(true);
        }
        void customersGrid_FieldTooltipShowing(object sender, PivotFieldTooltipShowingEventArgs e) {
            PivotGridHitInfo hitInfo = e.HitInfo;
            if (MustShowCustomerTooltip(hitInfo)) {
                e.ShowTooltip = false;
            }
        }
        void cbeSortMode_SelectedIndexChanged(object sender, EventArgs e) {
            if (cbeSortMode.SelectedIndex == 0) {
                customersChart.SeriesTemplate.SeriesPointsSortingKey = SeriesPointKey.Value_1;
                customersChart.SeriesTemplate.SeriesPointsSorting = SortingMode.Descending;
            }
            else {
                customersChart.SeriesTemplate.SeriesPointsSortingKey = SeriesPointKey.Argument;
                customersChart.SeriesTemplate.SeriesPointsSorting = SortingMode.Ascending;
            }
        }
        bool MustShowCustomerTooltip(PivotGridHitInfo hitInfo) {
            return hitInfo.HitTest == PivotGridHitTest.Value && hitInfo.ValueInfo.Field == fieldCustomer;
        }
        protected override void BeginRefreshData() {
            base.BeginRefreshData();
            customersChart.BeginInit();
            try {
                Rectangle selection = customersGrid.Cells.Selection;
                customersGrid.BeginUpdate();
                try {
                    SetDateFilter();
                }
                finally {
                    customersGrid.EndUpdate();
                }
                customersGrid.Cells.Selection = selection;
            }
            finally {
                customersChart.EndInit();
            }
            customersGrid.BestFit();
        }
    }
}
