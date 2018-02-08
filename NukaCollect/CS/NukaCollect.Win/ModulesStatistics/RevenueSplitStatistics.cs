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
using DevExpress.XtraLayout;
using NukaCollect.Resources;

namespace NukaCollect.Win.ModulesStatistics {
    public partial class RevenueSplitStatistics : ChartExportTutorialControl {
        public RevenueSplitStatistics() {
            InitializeComponent();
            chart.Titles[0].Text = ConstStrings.Get("RevenueSplit12Months");
            ElementConstStringLoader.LoadConstStringsForRevenueSplitStatistics(this);
        }
        XPCollection<Receipt> receipts;
        protected override ChartControl MainChart { get { return chart; } }
        protected override LayoutControl MainLayoutControl { get { return layoutControl1; } }
        protected override bool ShouldTransponsePivotOnPrint {  get { return true; } }
        void ReloadReceipts() {
            receipts = new XPCollection<Receipt>(Session,
                new BinaryOperator("Date", DateHelper.GetStartDateForMonths(-11), BinaryOperatorType.GreaterOrEqual));
        }
        protected override void BeginRefreshData() {
            base.BeginRefreshData();
            ReloadReceipts();
        }
        protected override void InitData() {
            base.InitData();
            ReloadReceipts();
            pivotGrid.DataSource = receipts;
        }

        private void pivotGrid_CustomGroupInterval(object sender, DevExpress.XtraPivotGrid.PivotCustomGroupIntervalEventArgs e) {
            if(e.Field == fieldMonth && e.Value != null) {
                DateTime valueAsDate = (DateTime)e.Value;
                e.GroupValue = new DateTime(valueAsDate.Year, valueAsDate.Month, 1);
            }
        }

        private void pivotGrid_FieldValueDisplayText(object sender, DevExpress.XtraPivotGrid.PivotFieldDisplayTextEventArgs e) {
            if(e.Field == fieldMonth && e.Value != null && e.Value is DateTime) {
                DateTime valueAsDate = (DateTime)e.Value;
                e.DisplayText = valueAsDate.ToString("MMM yyyy");
            }
            if(e.Field == fieldReceiptType && e.Value != null) {
                ReceiptType valueAsReceiptType = (ReceiptType)e.Value;
                e.DisplayText = EditorHelper.GetReceiptTypeString(valueAsReceiptType);
            }
        }
    }
}
