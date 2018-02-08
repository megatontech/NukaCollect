using NukaCollect.Reports;
namespace NukaCollect.Win.ModulesReports {
    public partial class TheMostProfitableGenresList : ReportModuleBase {
        public TheMostProfitableGenresList() {
            InitializeComponent();
        }

        protected override ReportBase CreateReport() {
            return new TheMostProfitableGenresListReport();
        }
    }
}
