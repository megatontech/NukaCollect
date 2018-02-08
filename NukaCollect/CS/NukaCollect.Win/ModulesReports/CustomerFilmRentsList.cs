using NukaCollect.Reports;
namespace NukaCollect.Win.ModulesReports {
    public partial class CustomerFilmRentsList : ReportModuleBase {
        public CustomerFilmRentsList() {
            InitializeComponent();
        }

        protected override ReportBase CreateReport() {
            return new CustomerFilmRentsListReport();
        }
    }
}
