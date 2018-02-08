using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.DXErrorProvider;
using DevExpress.XtraEditors.Controls;
using NukaCollect.Resources;
using NukaCollect.Reports;

namespace NukaCollect.Win.Controls {
    public partial class ucPeriod : XtraUserControl {
        DXValidationProvider provider;
        public ucPeriod() {
            InitializeComponent();
            CreatePeriodItems();
            ElementConstStringLoader.LoadConstStringsForUCPeriod(this);
        }
        void CreatePeriodItems() {
            icbPeriod.Properties.Items.Add(new ImageComboBoxItem(NukaCollect.Reports.Properties.Resources.PeriodCustom, 0, -1));
            icbPeriod.Properties.Items.Add(new ImageComboBoxItem(NukaCollect.Reports.Properties.Resources.PeriodMonth, 1, -1));
            icbPeriod.Properties.Items.Add(new ImageComboBoxItem(NukaCollect.Reports.Properties.Resources.PeriodThreeMonths, 3, -1));
            icbPeriod.Properties.Items.Add(new ImageComboBoxItem(NukaCollect.Reports.Properties.Resources.PeriodSixMonths, 6, -1));
            icbPeriod.Properties.Items.Add(new ImageComboBoxItem(NukaCollect.Reports.Properties.Resources.PeriodYear, 12, -1));
            icbPeriod.Properties.Items.Add(new ImageComboBoxItem(NukaCollect.Reports.Properties.Resources.PeriodTwoYears, 24, -1));
            icbPeriod.Properties.Items.Add(new ImageComboBoxItem(NukaCollect.Reports.Properties.Resources.PeriodFiveYears, 60, -1));
            icbPeriod.Properties.Items.Add(new ImageComboBoxItem(NukaCollect.Reports.Properties.Resources.PeriodTenYears, 120, -1));
        }
        public void InitData(DateTime start, DateTime end) {
            deStart.DateTime = start;
            deEnd.DateTime = end;
            if(end.Date != DateTime.Today.Date) return;
            foreach(ImageComboBoxItem item in icbPeriod.Properties.Items) {
                DateTime expectDate = DateTime.Today.Date.AddMonths(-Convert.ToInt32(item.Value));
                if(start.Date == expectDate) {
                    icbPeriod.EditValue = item.Value;
                    return;
                }
            }
        }
        public bool ValidateDates() {
            if(provider != null)
                provider.Dispose();
            provider = new DXValidationProvider();
            ConditionValidationRule rule = new ConditionValidationRule();
            rule.ErrorText = ConstStrings.Get("DateLess");
            rule.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            rule.ConditionOperator = ConditionOperator.GreaterOrEqual;
            rule.Value1 = StartDate;
            provider.SetValidationRule(this.deEnd, rule);
            return provider.Validate();
        }
        bool lockChangeDate = false;
        private void icbPeriod_SelectedIndexChanged(object sender, EventArgs e) {
            int val = Convert.ToInt32(icbPeriod.EditValue);
            if(val == 0) return;
            lockChangeDate = true;
            deStart.DateTime = DateTime.Today.AddMonths(-val);
            deEnd.DateTime = DateTime.Today;
            lockChangeDate = false;
        }
        public DateTime StartDate { get { return deStart.DateTime; } }
        public DateTime EndDate { get { return deEnd.DateTime; } }

        private void deStart_EditValueChanged(object sender, EventArgs e) {
            if(lockChangeDate) return;
            icbPeriod.EditValue = 0;
        }

        private void deEnd_EditValueChanged(object sender, EventArgs e) {
            if(lockChangeDate) return;
            icbPeriod.EditValue = 0;
        }
    }
}
