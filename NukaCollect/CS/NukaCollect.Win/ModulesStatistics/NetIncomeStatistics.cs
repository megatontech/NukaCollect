using DevExpress.Data.Filtering;
using DevExpress.Data.PivotGrid;
using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.Xpo;
using DevExpress.XtraCharts;
using DevExpress.XtraLayout;
using DevExpress.XtraPivotGrid;
using NukaCollect.Resources;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace NukaCollect.Win.ModulesStatistics
{
    public partial class NetIncomeStatistics : ChartExportTutorialControl
    {
        private const int CurrentPeriod = 1, ComparePeriod = 2;
        private XPCollection<Receipt> receipts;
        private int currentMonth;
        private string currentPeriodText, comparePeriodText;
        private DateTime currentPeriodDate;

        protected internal override ViewType ChartViewType { get { return ViewType.Line; } }
        protected override ChartControl MainChart { get { return chart; } }
        protected override LayoutControl MainLayoutControl { get { return layoutControl1; } }

        public NetIncomeStatistics()
        {
            InitializeComponent();
            pivotGrid.LookAndFeel.StyleChanged += new EventHandler(delegate { pivotGrid.BestFit(); });
            pivotGrid.FocusedCellChanged += new EventHandler(pivotGrid_FocusedCellChanged);
            ElementConstStringLoader.LoadConstStringsForNetIncomeStatistics(this);
            radioGroup1.Properties.Items[0].Description = ConstStrings.Get("ShowMonthlyRevenue");
            radioGroup1.Properties.Items[1].Description = ConstStrings.Get("ShowMonthlyReceipts");
        }

        private int CorrectMonth(int month)
        {
            if (month > this.currentMonth)
                return month - this.currentMonth;
            else
                return month + 12;
        }

        private void pivotGrid_FocusedCellChanged(object sender, EventArgs e)
        {
            UpdateGauge(GetGaugeValueFromPivot(), GetGaugeTextFromPivot());
        }

        private double GetGaugeValueFromPivot()
        {
            object cellValue = pivotGrid.GetCellValue(pivotGrid.Cells.FocusedCell.X, pivotGrid.Cells.FocusedCell.Y);
            if (cellValue is int) return (double)((int)cellValue);
            if (cellValue is decimal) return (double)((decimal)cellValue);
            return 0.0;
        }

        private string GetGaugeTextFromPivot()
        {
            object fieldValue = pivotGrid.GetFieldValue(fieldMonth, pivotGrid.Cells.FocusedCell.Y);
            return (fieldValue != null) ? fieldMonth.GetDisplayText(fieldValue) : null;
        }

        private void pivotGrid_CustomGroupInterval(object sender, DevExpress.XtraPivotGrid.PivotCustomGroupIntervalEventArgs e)
        {
            if (e.Field == fieldPeriod)
            {
                DateTime valueAsDate = (DateTime)e.Value;
                e.GroupValue = valueAsDate >= this.currentPeriodDate ? CurrentPeriod : ComparePeriod;
            }
        }

        private void pivotGrid_CustomFieldSort(object sender, DevExpress.XtraPivotGrid.PivotGridCustomFieldSortEventArgs e)
        {
            if (e.Field == fieldMonth)
            {
                int value1 = CorrectMonth((int)e.Value1),
                    value2 = CorrectMonth((int)e.Value2);
                e.Result = Comparer<int>.Default.Compare(value1, value2);
                e.Handled = true;
            }
        }

        private void pivotGrid_FieldValueDisplayText(object sender, DevExpress.XtraPivotGrid.PivotFieldDisplayTextEventArgs e)
        {
            if (e.Field == fieldMonth && e.Value != null)
            {
                int val = (int)e.Value;
                if (val < 1) val = 1;
                if (val > 12) val = 12;
                e.DisplayText = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(val);
            }
            if (e.Field == fieldPeriod)
                e.DisplayText = object.Equals(e.Value, CurrentPeriod) ? this.currentPeriodText : this.comparePeriodText;
        }

        private void radioGroup1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdatefieldRevenue();
            UpdateGauge(GetGaugeValueFromPivot(), GetGaugeTextFromPivot());
        }

        private void UpdateGauge(double value, string text)
        {
            double[] values = GetValues(chart.Series[0]);
            double min = 2500;
            double max = 4500;
            double avg = 3000;
            if (values.Length > 0)
            {
                double sum = 0;
                min = values[0]; max = values[0];
                for (int i = 0; i < values.Length; i++)
                {
                    min = Math.Min(min, values[i]);
                    max = Math.Max(max, values[i]);
                    sum += values[i];
                }
                avg = sum / (double)values.Length;
            }
            float overhead = radioGroup1.SelectedIndex == 0 ? 100f : 10f;

            arcScaleComponent1.Labels[0].FormatString = (value == 0.0 || value > max || value < min) ? string.Empty : gaugeTextFormat;

            arcScaleComponent1.MinValue = (float)min - overhead;
            arcScaleComponent1.Value = (float)value;
            arcScaleComponent1.MaxValue = (float)max + overhead;

            arcScaleComponent1.Ranges[0].StartValue = (float)min;
            arcScaleComponent1.Ranges[0].EndValue = (float)avg;
            arcScaleComponent1.Ranges[1].StartValue = (float)avg;
            arcScaleComponent1.Ranges[1].EndValue = (float)max;

            labelComponent1.Text = text;
        }

        private string gaugeTextFormat = "${1:F2}";

        private void UpdatefieldRevenue()
        {
            switch (radioGroup1.SelectedIndex)
            {
                case 0:
                    fieldRevenue.SummaryType = PivotSummaryType.Sum;
                    fieldRevenue.Caption = ConstStrings.Get("Revenue");
                    chart.Titles[0].Text = ConstStrings.Get("Revenue12Months");
                    if (chart.SeriesTemplate.Label != null)
                        chart.SeriesTemplate.Label.PointOptions.ValueNumericOptions.Format = NumericFormat.Currency;
                    gaugeTextFormat = "${1:F2}";
                    break;

                case 1:
                    fieldRevenue.SummaryType = PivotSummaryType.Count;
                    fieldRevenue.Caption = ConstStrings.Get("ReceiptCount");
                    chart.Titles[0].Text = ConstStrings.Get("ReceiptCount12Months");
                    if (chart.SeriesTemplate.Label != null)
                        chart.SeriesTemplate.Label.PointOptions.ValueNumericOptions.Format = NumericFormat.General;
                    gaugeTextFormat = "{1:F0}";
                    break;
            }
        }

        private void pivotGrid_CustomDrawCell(object sender, DevExpress.XtraPivotGrid.PivotCustomDrawCellEventArgs e)
        {
            if (object.Equals(e.GetFieldValue(fieldPeriod), CurrentPeriod))
            {
                object month = e.GetFieldValue(fieldMonth);
                decimal currentValue = Convert.ToDecimal(e.GetCellValue(fieldRevenue)),
                    compareValue = Convert.ToDecimal(e.GetCellValue(new object[] { ComparePeriod },
                        month != null ? new object[] { e.GetFieldValue(fieldMonth) } : null, fieldRevenue));
                if (currentValue > compareValue)
                    e.Appearance.ForeColor = CommonColors.GetInformationColor(UserLookAndFeel.Default);
                else if (currentValue < compareValue)
                    e.Appearance.ForeColor = CommonColors.GetCriticalColor(UserLookAndFeel.Default);
            }
        }

        private void chart_BoundDataChanged(object sender, EventArgs e)
        {
            Series compareSeries = chart.Series[comparePeriodText];
            if (compareSeries != null)
            {
                LineSeriesView view = (LineSeriesView)compareSeries.View;
                view.LineStyle.DashStyle = DashStyle.Dash;
                view.LineMarkerOptions.FillStyle.FillMode = FillMode.Solid;
            }
        }

        private void chart_CustomizeAutoBindingSettings(object sender, EventArgs e)
        {
            pivotGrid.OptionsChartDataSource.FieldValuesProvideMode = PivotChartFieldValuesProvideMode.DisplayText;
            chart.SeriesTemplate.ArgumentScaleType = ScaleType.Qualitative;
        }

        private double[] GetValues(Series series)
        {
            if (series == null || series.Points.Count < 2)
            {
                return new double[0];
            }
            double[] values = new double[series.Points.Count];
            for (int i = 0; i < values.Length; i++)
            {
                values[i] = series.Points[i].Values[0];
            }
            return values;
        }

        private void ReloadReceipts(DateTime startDate)
        {
            receipts = new XPCollection<Receipt>(Session,
                new BinaryOperator("Date", startDate, BinaryOperatorType.GreaterOrEqual));
        }

        protected override void BeginRefreshData()
        {
            base.BeginRefreshData();
            ReloadReceipts(DateTime.Now.AddYears(-2));
        }

        protected override void InitData()
        {
            base.InitData();
            DateTime startDate = DateTime.Now.AddYears(-2);
            this.currentPeriodDate = DateTime.Now.AddYears(-1);
            this.currentMonth = DateTime.Now.Month;

            this.currentPeriodText = string.Format(ConstStrings.Get("TimePeriod"), currentPeriodDate, DateTime.Now.AddDays(-1));
            this.comparePeriodText = string.Format(ConstStrings.Get("ComparePeriod"), startDate, currentPeriodDate.AddDays(-1));

            ReloadReceipts(startDate);
            pivotGrid.DataSource = receipts;
            pivotGrid.BestFit();
            UpdatefieldRevenue();
            UpdateGauge(GetGaugeValueFromPivot(), GetGaugeTextFromPivot());
        }
    }
}