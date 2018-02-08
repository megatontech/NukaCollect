using NukaCollect.Reports;

namespace NukaCollect.Win.ModulesReports
{
    public partial class ActiveCustomersList : ReportModuleBase
    {
        public ActiveCustomersList()
        {
            InitializeComponent();
        }

        protected override ReportBase CreateReport()
        {
            return new ActiveCustomersListReport();
        }
    }
}