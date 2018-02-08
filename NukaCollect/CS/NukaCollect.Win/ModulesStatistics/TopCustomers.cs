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
using System.Collections;
using DevExpress.XtraEditors;
using NukaCollect.Win.Controls;
using DevExpress.XtraPivotGrid;
using DevExpress.Utils;
using DevExpress.XtraLayout;
using NukaCollect.Resources;

namespace NukaCollect.Win.ModulesStatistics {
    public partial class TopCustomersStatistics : ChartExportTutorialControl {
        XPCollection<Receipt> receipts;
        CustomerToolTipController tooltip;
        bool lockUpdate = false;
        protected internal override ViewType ChartViewType { get { return ViewType.Pie3D; } }
        protected override ChartControl MainChart { get { return chart; } }
        protected override LayoutControl MainLayoutControl { get { return layoutControl1; } }
        protected override bool AllowFlipLayout { get { return true; } }
        public TopCustomersStatistics() {
            InitializeComponent();
            lockUpdate = true;
            this.tooltip = new CustomerToolTipController(pivotGrid);
            pivotGrid.LookAndFeel.StyleChanged += new EventHandler(delegate { pivotGrid.BestFit(); });
            UpdateTopValues();
            chart.Titles[0].Text = ConstStrings.Get("TopCustomers");
            ElementConstStringLoader.LoadConstStringsForTopCustomersStatistics(this);
            comboPeriod.Properties.Items[0] = ConstStrings.Get("ThisMonth");
            comboPeriod.Properties.Items[1] = ConstStrings.Get("LastMonth");
            comboPeriod.Properties.Items[2] = ConstStrings.Get("Last12Months");
            comboPeriod.SelectedIndex = 1;
            lockUpdate = false;
        }
        void ReloadReceipts() {
            receipts = new XPCollection<Receipt>(Session);
        }
        protected override void BeginRefreshData() {
            base.BeginRefreshData();
            ReloadReceipts();
        }
        protected override void InitData() {
            base.InitData();
            ReloadReceipts();
            UpdatePeriod();
            pivotGrid.DataSource = receipts;
            pivotGrid.BestFit();
        }

        private void pivotGrid_FieldValueDisplayText(object sender, DevExpress.XtraPivotGrid.PivotFieldDisplayTextEventArgs e) {
            if(e.Field == fieldCustomer) {
                Customer valueAsCustomer = (Customer)e.Value;
                if(valueAsCustomer != null)
                    e.DisplayText = valueAsCustomer.FullName;
                else
                    e.DisplayText = ConstStrings.Get("NullString");
            }
        }

        private void comboBoxEdit1_SelectedIndexChanged(object sender, EventArgs e) {
            if(!lockUpdate)
                UpdatePeriod();
        }

        private void UpdatePeriod() {
            switch(comboPeriod.SelectedIndex) {
                case 0:
                    this.receipts.Filter =
                        new GroupOperator(GroupOperatorType.And,
                            new BinaryOperator(
                                new FunctionOperator(FunctionOperatorType.GetYear, new OperandProperty("Date")),
                                DateTime.Now.Year, BinaryOperatorType.Equal),
                            new BinaryOperator(new FunctionOperator(FunctionOperatorType.GetMonth, new OperandProperty("Date")),
                                DateTime.Now.Month, BinaryOperatorType.Equal)
                        );
                    break;
                case 1:
                    DateTime dt = DateHelper.GetStartDateForMonths(-1);
                    this.receipts.Filter =
                        new GroupOperator(GroupOperatorType.And,
                            new BinaryOperator(
                                new FunctionOperator(FunctionOperatorType.GetYear, new OperandProperty("Date")),
                                dt.Year, BinaryOperatorType.Equal),
                            new BinaryOperator(new FunctionOperator(FunctionOperatorType.GetMonth, new OperandProperty("Date")),
                            dt.Month, BinaryOperatorType.Equal));
                    break;
                case 2:
                    this.receipts.Filter =
                        new BinaryOperator("Date", DateTime.Now.AddYears(-1), BinaryOperatorType.GreaterOrEqual);
                    break;
            }
            pivotGrid.RefreshData();
        }

        void spinEdit1_EditValueChanged(object sender, EventArgs e) {
            UpdateTopValues();
        }
        void UpdateTopValues() {
            fieldCustomer.TopValueCount = Convert.ToInt32(spinCustomerCount.EditValue);
        }
        void pivotGrid_MouseMove(object sender, MouseEventArgs e) {
            PivotGridHitInfo hitInfo = pivotGrid.CalcHitInfo(e.Location);
            if(MustShowCustomerTooltip(hitInfo)) {
                Customer customer = (Customer)hitInfo.ValueInfo.Value;
                Point pt = e.Location;
                pt.Offset(20, 20);
                this.tooltip.ShowHint(customer, pt);
            } else
                this.tooltip.HideHint(true);
        }
        void pivotGrid_FieldTooltipShowing(object sender, PivotFieldTooltipShowingEventArgs e) {
             PivotGridHitInfo hitInfo = e.HitInfo;
             if(MustShowCustomerTooltip(hitInfo)) {
                 e.ShowTooltip = false;
             }
        }
        bool MustShowCustomerTooltip(PivotGridHitInfo hitInfo) {
            return hitInfo.HitTest == PivotGridHitTest.Value && hitInfo.ValueInfo.Field == fieldCustomer;
        }
    }
}
