using DevExpress.XtraReports.UI;
using DevExpress.Xpo;

namespace NukaCollect.Reports {
    public partial class CustomerInfoCardReport : CustomerSelectionReportBase {
        public CustomerInfoCardReport() {
            InitializeComponent();
            DisplayName = Properties.Resources.CustomerCardsReport;
        }

        void xrBarCodeCustomer_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e) {
            XRBarCode barCode = sender as XRBarCode;
            Customer customer = GetCurrentRow() as Customer;
            barCode.Text = string.Format("{0:d6}", customer.CustomerId);
        }
        void xpCollectionCustomers_ResolveSession(object sender, ResolveSessionEventArgs e) {
            e.Session = Session;
        }
        void xrPictBoxPhoto_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e) {
            XRPictureBox photo = sender as XRPictureBox;
            if(photo.Image == null) {
                photo.Image = ReferenceImages.UnknownPerson;
            }
        }
    }
}
