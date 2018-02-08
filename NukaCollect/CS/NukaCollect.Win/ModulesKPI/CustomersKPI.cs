using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.Xpo;
using DevExpress.XtraCharts;
using DevExpress.XtraLayout;
using DevExpress.XtraPivotGrid;
using DevExpress.Data.PivotGrid;
using DevExpress.Data.Filtering;
using NukaCollect.Resources;

namespace NukaCollect.Win.ModulesKPI {
    public partial class CustomersKPI : ChartExportTutorialControl {
        const int selectedRowsCount = 5;

        bool inSelectionUpdate;
        CustomerToolTipController tooltip;
        CustomerDiscountLevelToolTipController tooltipDiscount;
        PivotGridControl discountOverTimeGrid;

        XYDiagram Diagram { get { return discountChart.Diagram as XYDiagram; } }
        protected internal override ViewType ChartViewType { get { return ViewType.FullStackedSplineArea; } }
        protected override ChartControl MainChart { get { return discountChart; } }
        protected override LayoutControl MainLayoutControl { get { return layoutControl1; } }
        protected override bool AllowFlipLayout { get { return true; } }

        public CustomersKPI() {
            InitializeComponent();
            tooltip = new CustomerToolTipController(discountGrid);
            tooltipDiscount = new CustomerDiscountLevelToolTipController(discountChart);
            discountChart.Series[0].LegendText = EnumTitlesKeeper<CustomerDiscountLevel>.GetTitle(CustomerDiscountLevel.FirstTime);
            discountChart.Series[1].LegendText = EnumTitlesKeeper<CustomerDiscountLevel>.GetTitle(CustomerDiscountLevel.Basic);
            discountChart.Series[2].LegendText = EnumTitlesKeeper<CustomerDiscountLevel>.GetTitle(CustomerDiscountLevel.Occasional);
            discountChart.Series[3].LegendText = EnumTitlesKeeper<CustomerDiscountLevel>.GetTitle(CustomerDiscountLevel.Active);
            discountChart.Series[4].LegendText = EnumTitlesKeeper<CustomerDiscountLevel>.GetTitle(CustomerDiscountLevel.Prodigious);
            discountChart.Titles[0].Text = ConstStrings.Get("CustomerRevenueModule");
            ((XYDiagram)discountChart.Diagram).AxisY.Title.Text = string.Format("{0} {1}", ConstStrings.Get("Payment"), Application.CurrentCulture.NumberFormat.CurrencySymbol);
            ElementConstStringLoader.LoadConstStringsForCustomerKPI(this);
        }
        void AddConstantLine(AxisY axis, CustomerDiscountLevel level) {
            ConstantLine constantLine = new ConstantLine(level.ToString(), (int)ReferenceData.GetDiscountLevelPayment(level));
            constantLine.Title.Text = EnumTitlesKeeper<CustomerDiscountLevel>.GetTitle(level) + " (" + ((int)ReferenceData.GetDiscountLevelPayment(level)).ToString() + ")";
            constantLine.ShowInLegend = false;
            axis.ConstantLines.Add(constantLine);
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
        void DiscountKPI_Load(object sender, EventArgs e) {
            if (Diagram != null) {
                AddConstantLine(Diagram.AxisY, CustomerDiscountLevel.Basic);
                AddConstantLine(Diagram.AxisY, CustomerDiscountLevel.Occasional);
                AddConstantLine(Diagram.AxisY, CustomerDiscountLevel.Active);
                AddConstantLine(Diagram.AxisY, CustomerDiscountLevel.Prodigious);
            }

            discountGrid.Cells.Selection = new Rectangle(0, 0, discountGrid.Cells.ColumnCount, selectedRowsCount);
            discountChart.DataSource = discountGrid;

            discountOverTimeGrid = new PivotGridControl();
            discountOverTimeGrid.DataSource = receiptsCollection;
            discountOverTimeGrid.OptionsChartDataSource.ProvideDataByColumns = false;
            discountOverTimeGrid.OptionsChartDataSource.SelectionOnly = false;
            discountOverTimeGrid.OptionsChartDataSource.ProvideColumnGrandTotals = false;
            discountOverTimeGrid.OptionsChartDataSource.ProvideColumnTotals = false;
            discountOverTimeGrid.OptionsChartDataSource.ProvideRowGrandTotals = false;
            discountOverTimeGrid.OptionsChartDataSource.ProvideRowTotals = false;
            discountOverTimeGrid.OptionsChartDataSource.ProvideColumnCustomTotals = false;
            discountOverTimeGrid.OptionsChartDataSource.ProvideRowCustomTotals = false;
            PivotGridField paymentField = new PivotGridField("Payment", PivotArea.DataArea);
            paymentField.CellFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            paymentField.CellFormat.FormatString = "f";
            paymentField.SummaryType = PivotSummaryType.Custom;
            discountOverTimeGrid.Fields.Add(paymentField);
            discountOverTimeGrid.Fields.Add(new PivotGridField("Customer!", PivotArea.RowArea));
            PivotGridField yearField = new PivotGridField("Date", PivotArea.ColumnArea);
            yearField.GroupInterval = PivotGroupInterval.DateYear;
            yearField.RunningTotal = true;
            PivotGridField quarterField = new PivotGridField("Date", PivotArea.ColumnArea);
            quarterField.GroupInterval = PivotGroupInterval.DateQuarter;
            quarterField.RunningTotal = true;
            discountOverTimeGrid.Fields.Add(yearField);
            discountOverTimeGrid.Fields.Add(quarterField);
            discountOverTimeGrid.CustomSummary += new PivotGridCustomSummaryEventHandler(pivotGrid_CustomSummary);

            BindSeries(discountOverTimeGrid, CustomerDiscountLevel.FirstTime);
            BindSeries(discountOverTimeGrid, CustomerDiscountLevel.Basic);
            BindSeries(discountOverTimeGrid, CustomerDiscountLevel.Occasional);
            BindSeries(discountOverTimeGrid, CustomerDiscountLevel.Active);
            BindSeries(discountOverTimeGrid, CustomerDiscountLevel.Prodigious);
        }
        void BindSeries(PivotGridControl pivotGrid, CustomerDiscountLevel level) {
            Series series = discountChart.Series[level.ToString()];
            series.DataSource = pivotGrid;
            series.ArgumentDataMember = "Arguments";
            series.ValueDataMembers[0] = "Values";
            series.SummaryFunction = "COUNT()";
            series.DataFilters.Add(new DataFilter("Values", typeof(decimal).ToString(), DataFilterCondition.Equal, (decimal)level));
        }
        void pivotGrid_CustomSummary(object sender, PivotGridCustomSummaryEventArgs e) {
            e.CustomValue = Customer.GetDiscount((decimal)e.SummaryValue.Summary);
        }
        void SetColors(Series series, DrawOptions drawOptions, int colorIndex) {
            PaletteEntry palleteEntry = discountChart.GetPaletteEntries(5)[colorIndex];
            ISupportTransparency view = series.View as ISupportTransparency;
            byte transparency = view != null? view.Transparency : byte.MinValue;
            transparency = (byte)(byte.MaxValue - transparency);
            drawOptions.Color = Color.FromArgb(transparency, palleteEntry.Color);
            BarDrawOptions barDrawoptions = drawOptions as BarDrawOptions;
            if (barDrawoptions != null) {
                RectangleGradientFillOptions gradientOptions = barDrawoptions.FillStyle.Options as RectangleGradientFillOptions;
                if (gradientOptions != null)
                    gradientOptions.Color2 = Color.FromArgb(transparency, palleteEntry.Color2);
            }
        }
        void SetColors(CustomDrawSeriesEventArgs e, int colorIndex) {
            SetColors(e.Series, e.SeriesDrawOptions, colorIndex);
            SetColors(e.Series, e.LegendDrawOptions, colorIndex);
        }
        void discountChart_CustomDrawSeries(object sender, CustomDrawSeriesEventArgs e) {
            switch (e.Series.Name) {
                case "FirstTime":
                    SetColors(e, 4);
                    break;
                case "Basic":
                    SetColors(e, 3);
                    break;
                case "Occasional":
                    SetColors(e, 2);
                    break;
                case "Active":
                    SetColors(e, 1);
                    break;
                case "Prodigious":
                    SetColors(e, 0);
                    break;
            }
        }
        void discountGrid_FocusedCellChanged(object sender, EventArgs e) {
            if (inSelectionUpdate)
                return;
            inSelectionUpdate = true;
            if (discountGrid.Cells.MultiSelection.SelectedCells.Count == 0) {
                List<Point> selectedCells = new List<Point>();
                for (int x = 0; x < discountGrid.Cells.ColumnCount; x++)
                    selectedCells.Add(new Point(x, discountGrid.Cells.FocusedCell.Y));
                discountGrid.Cells.MultiSelection.SetSelection(selectedCells.ToArray());
            }
            inSelectionUpdate = false;
        }
        void discountGrid_CellSelectionChanged(object sender, EventArgs e) {
            if (inSelectionUpdate)
                return;
            inSelectionUpdate = true;
            SetSelection(GetSelectedRows());
            inSelectionUpdate = false;
        }
        List<int> GetSelectedRows() {
            List<int> selectedRows = new List<int>();
            for (int i = 0; i < discountGrid.Cells.MultiSelection.SelectedCells.Count; i++)
                if (!selectedRows.Contains(discountGrid.Cells.MultiSelection.SelectedCells[i].Y))
                    selectedRows.Add(discountGrid.Cells.MultiSelection.SelectedCells[i].Y);
            return selectedRows;
        }
        void SetSelection(List<int> selectedRows) {
            List<Point> selectedCells = new List<Point>();
            for (int x = 0; x < discountGrid.Cells.ColumnCount; x++)
                for (int i = 0; i < selectedRows.Count; i++)
                    selectedCells.Add(new Point(x, selectedRows[i]));
            discountGrid.Cells.MultiSelection.SetSelection(selectedCells.ToArray());
        }
        void discountGrid_MouseMove(object sender, MouseEventArgs e) {
            PivotGridHitInfo hitInfo = discountGrid.CalcHitInfo(e.Location);
            if(MustShowCustomerTooltip(hitInfo)) {
                Customer customer = hitInfo.ValueInfo.Value as Customer;
                if (customer != null) {
                    Point location = e.Location;
                    location.Offset(20, 20);
                    tooltip.ShowHint(customer, location);
                }
            }
            else
                tooltip.HideHint(true);
        }
        void discountChart_MouseMove(object sender, MouseEventArgs e) {
            ChartHitInfo hitInfo = discountChart.CalcHitInfo(e.X, e.Y);
            if (hitInfo.Series != null) {
                Series series = hitInfo.Series as Series;
                if (series != null) {
                    switch (series.Name) {
                        case "First-Time Renter":
                            tooltipDiscount.ShowHint(CustomerDiscountLevel.FirstTime, e.Location);
                            return;
                        case "Basic Renter":
                            tooltipDiscount.ShowHint(CustomerDiscountLevel.Basic, e.Location);
                            return;
                        case "Occasional Renter":
                            tooltipDiscount.ShowHint(CustomerDiscountLevel.Occasional, e.Location);
                            return;
                        case "Active Renter":
                            tooltipDiscount.ShowHint(CustomerDiscountLevel.Active, e.Location);
                            return;
                        case "Prodigious Renter":
                            tooltipDiscount.ShowHint(CustomerDiscountLevel.Prodigious, e.Location);
                            return;
                    }

                }
            }
            tooltipDiscount.HideHint(true);
        }
        void discountGrid_FieldTooltipShowing(object sender, PivotFieldTooltipShowingEventArgs e) {
            PivotGridHitInfo hitInfo = e.HitInfo;
            if(MustShowCustomerTooltip(hitInfo)) {
                e.ShowTooltip = false;
            }
        }
        bool MustShowCustomerTooltip(PivotGridHitInfo hitInfo) {
            return hitInfo.HitTest == PivotGridHitTest.Value && hitInfo.ValueInfo.Field == fieldCustomer;
        }
        protected override void BeginRefreshData() {
            base.BeginRefreshData();
            discountChart.BeginInit();
            try {
                List<int> selectedRows = GetSelectedRows();
                discountGrid.BeginUpdate();
                try {
                    SetDateFilter();
                }
                finally {
                    discountGrid.EndUpdate();
                }
                SetSelection(selectedRows);
            }
            finally {
                discountChart.EndInit();
            }
        }
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            if (disposing) {
                if (discountOverTimeGrid != null) {
                    discountOverTimeGrid.Dispose();
                }
            }
            base.Dispose(disposing);
        }
    }
}
