using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using DevExpress.XtraCharts;
using DevExpress.XtraLayout;
using DevExpress.XtraPivotGrid;
using NukaCollect.Helpers;
using NukaCollect.Resources;
using NukaCollect.Win.Modules;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace NukaCollect.Win.ModulesStatistics
{
    public partial class CustomerRevenueStatistics : ChartExportTutorialControl
    {
        private int currentMonth;
        private Customer topCustomer;

        protected internal override bool UseList { get { return false; } }
        protected internal override ViewType ChartViewType { get { return ViewType.Line; } }
        protected override ChartControl MainChart { get { return chart; } }
        public override string EditObjectName { get { return ConstStrings.Get("Customer"); } }
        protected override LayoutControl MainLayoutControl { get { return layoutControl1; } }
        protected override bool ShouldTransponsePivotOnPrint { get { return true; } }
        protected override bool AllowFlipLayout { get { return true; } }

        public CustomerRevenueStatistics()
        {
            InitializeComponent();
            pivotGrid.LookAndFeel.StyleChanged += new EventHandler(delegate { pivotGrid.BestFit(); });
            ElementConstStringLoader.LoadConstStringsForCustomerRevenueStatistics(this);
        }

        protected override void InitData()
        {
            base.InitData();
            this.currentMonth = DateTime.Now.Month;
            DateTime startDate = DateTime.Now.AddYears(-1);
            XPCollection<Receipt> receipts = new XPCollection<Receipt>(Session,
                new BinaryOperator("Date", startDate, BinaryOperatorType.GreaterOrEqual));
            pivotGrid.DataSource = receipts;
        }

        protected override void BeginRefreshData()
        {
            Cursor.Current = Cursors.WaitCursor;
            ApplyFilter();
        }

        protected override void DoParentChanged()
        {
            base.DoParentChanged();
            LayoutManager.CurrentCustomerChanged += new EventHandler(OnCurrentCustomerChanged);
            ApplyFilter();
        }

        private void ApplyFilter()
        {
            this.topCustomer = null;
            decimal topCustomerRevenues = 0;
            foreach (Customer customer in fieldCustomer.GetUniqueValues())
            {
                decimal customerRevenues = Convert.ToDecimal(pivotGrid.GetCellValue(null, new object[] { customer }, fieldRevenue));
                if (customerRevenues > topCustomerRevenues)
                {
                    topCustomer = customer;
                    topCustomerRevenues = customerRevenues;
                }
            }
            List<Customer> customersToShow = new List<Customer>();
            customersToShow.Add(this.topCustomer);
            Customer currentCustomer = SessionHelper.GetObject(LayoutManager.CurrentCustomer, Session);
            if (this.topCustomer != currentCustomer)
                customersToShow.Add(currentCustomer);
            fieldCustomer.FilterValues.ValuesIncluded = customersToShow.ToArray();
            pivotGrid.BestFit();

            chart.Titles[0].Text = string.Format("{0} {1}", LayoutManager.CurrentCustomer.FullName, ConstStrings.Get("Revenue12Months"));
            ucCustomerInfo1.Init(LayoutManager.CurrentCustomer, ConstStrings.Get("FindCustomerHint"), ConstStrings.Get("CustomerDetailTooltip"));
        }

        private void OnCurrentCustomerChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void pivotGrid_CustomFieldSort(object sender, PivotGridCustomFieldSortEventArgs e)
        {
            if (e.Field == fieldCustomer)
            {
                int value1 = e.Value1 == this.topCustomer ? 1 : 0,
                    value2 = e.Value2 == this.topCustomer ? 1 : 0;
                int res = Comparer<int>.Default.Compare(value1, value2);
                if (res != 0)
                {
                    e.Result = res;
                    e.Handled = true;
                }
            }
        }

        private void pivotGrid_FieldValueDisplayText(object sender, PivotFieldDisplayTextEventArgs e)
        {
            if (e.Field == fieldCustomer)
            {
                Customer valueAsCustomer = (Customer)e.Value;
                if (valueAsCustomer != null)
                    e.DisplayText = valueAsCustomer.FullName;
                else
                    e.DisplayText = ConstStrings.Get("NullString");

                if (valueAsCustomer == this.topCustomer)
                    e.DisplayText = string.Format("{0} - {1}", e.DisplayText, ConstStrings.Get("TopCustomer"));
            }
            if (e.Field == fieldMonth)
            {
                DateTime valueAsDate = (DateTime)e.Value;
                e.DisplayText = valueAsDate.ToString("MMM yyyy");
            }
            if (e.Field == null && !e.IsColumn)
                e.DisplayText = ConstStrings.Get("RevenueDifference");
        }

        private void pivotGrid_CustomGroupInterval(object sender, PivotCustomGroupIntervalEventArgs e)
        {
            if (e.Field == fieldMonth)
            {
                DateTime valueAsDate = (DateTime)e.Value;
                e.GroupValue = new DateTime(valueAsDate.Year, valueAsDate.Month, 1);
            }
        }

        private void chart_BoundDataChanged(object sender, EventArgs e)
        {
            Series compareSeries = GetTopCustomerSeries();
            if (compareSeries != null)
            {
                LineSeriesView view = (LineSeriesView)compareSeries.View;
                view.LineStyle.DashStyle = DashStyle.Dash;
                view.LineMarkerOptions.FillStyle.FillMode = FillMode.Solid;
            }
        }

        private Series GetTopCustomerSeries()
        {
            if (topCustomer == null)
                return null;
            foreach (Series series in chart.Series)
            {
                if (series.Name.Contains(topCustomer.FullName))
                    return series;
            }
            return null;
        }

        private void pivotGrid_CustomSummary(object sender, PivotGridCustomSummaryEventArgs e)
        {
            if (e.DataField == fieldRevenue)
            {
                if (e.RowField == null)
                {
                    decimal currentSum = 0, topSum = 0;
                    PivotDrillDownDataSource ds = e.CreateDrillDownDataSource();
                    for (int i = 0; i < ds.RowCount; i++)
                    {
                        decimal val = Convert.ToDecimal(ds[i][fieldRevenue]);
                        if (ds[i][fieldCustomer] == this.topCustomer)
                            topSum += val;
                        else
                            currentSum += val;
                    }
                    e.CustomValue = currentSum - topSum;
                }
                else
                    e.CustomValue = e.SummaryValue.Summary;
            }
        }

        private void pivotGrid_CustomDrawCell(object sender, PivotCustomDrawCellEventArgs e)
        {
            if (e.RowField == null)
            {
                decimal value = Convert.ToDecimal(e.Value);
                if (value > 0)
                    e.Appearance.ForeColor = Color.Green;
                else if (value < 0)
                    e.Appearance.ForeColor = Color.Red;
            }
        }

        private void ucCustomerInfo1_DoEdit(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (!IsDetailExist(LayoutManager.CurrentCustomer.Oid))
                ShowModuleDialog(new CustomerDetail(this.FindForm(), GetSession, LayoutManager.CurrentCustomer, MenuManager, CloseDetailForm), true);
            Cursor.Current = Cursors.Default;
        }

        protected internal override void Prev()
        {
            LayoutManager.PrevCustomer();
            UpdateNavigationButtons();
        }

        protected internal override void Next()
        {
            LayoutManager.NextCustomer();
            UpdateNavigationButtons();
        }

        protected override void DoShow()
        {
            base.DoShow();
            UpdateNavigationButtons();
        }

        private void UpdateNavigationButtons()
        {
            if (ParentFormMain == null || LayoutManager == null) return;
            ParentFormMain.PrevButton.Enabled = LayoutManager.AllowPrevCustomer;
            ParentFormMain.NextButton.Enabled = LayoutManager.AllowNextCustomer;
        }
    }
}