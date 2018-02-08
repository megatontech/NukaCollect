using System;
using DevExpress.XtraReports.UI;
using DevExpress.Data.Filtering;
using DevExpress.Xpo;

namespace NukaCollect.Reports {
    public partial class ActiveCustomersListReport : TimePeriodReportBase {
        public ActiveCustomersListReport() {
            InitializeComponent();
            DisplayName = Properties.Resources.ActiveCustomerReport;
        }
        void calculatedFieldCustomerReceiptsCount_GetValue(object sender, GetValueEventArgs e) {
            Customer customer = e.Row as Customer;

            CriteriaOperator filter = new GroupOperator(GroupOperatorType.And,
                new BinaryOperator("Date", (DateTime)Parameters[startDateParamName].Value, BinaryOperatorType.GreaterOrEqual),
                new BinaryOperator("Date", (DateTime)Parameters[endDateParamName].Value, BinaryOperatorType.LessOrEqual));

            using(XPCollection<Receipt> receipts = new XPCollection<Receipt>(customer.Receipts, filter)) {
                e.Value = customer == null ? 0 : receipts.Count;
            }
        }
        void xpCollectionCustomers_ResolveSession(object sender, ResolveSessionEventArgs e) {
            e.Session = Session;
        }
        void xrPictureBoxPhoto_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e) {
            XRPictureBox photo = sender as XRPictureBox;
            if(photo.Image == null) {
                photo.Image = ReferenceImages.UnknownPerson;
            }
        }
        void ActiveCustomersListReport_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e) {
            FilterString = "[calcFieldCustomerReceiptsCount] <> '0'";
            this.BeforePrint -= ActiveCustomersListReport_BeforePrint;
        }
    }
}
