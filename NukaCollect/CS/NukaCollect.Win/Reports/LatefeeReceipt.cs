namespace NukaCollect.Win.Reports
{
    public partial class LatefeeReceipt : DevExpress.XtraReports.UI.XtraReport
    {
        public LatefeeReceipt()
        {
            InitializeComponent();
        }

        public LatefeeReceipt(Receipt overdueReceipt)
            : this()
        {
            InitData(overdueReceipt);
        }

        private void InitData(Receipt overdueReceipt)
        {
            DataSource = overdueReceipt.OverdueRents;
            xrlReceiptNumber.Text = string.Format("# {0:d8}", overdueReceipt.ReceiptId);
            xrlDate.Text = string.Format("({0:g})", overdueReceipt.Date);
            xrlDiscount.Text = string.Format("{0:c}", overdueReceipt.Discount);
            xrlPayment.Text = string.Format("{0:c}", overdueReceipt.Payment);
            xrlCustomerName.Text = overdueReceipt.Customer.FullName;
            xrlCustomerAddress.Text = overdueReceipt.Customer.Address;
            xrlCustomerPhone.Text = overdueReceipt.Customer.Phone;
        }
    }
}