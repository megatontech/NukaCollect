using DevExpress.XtraPrinting;
using NukaCollect.Reports;

namespace NukaCollect.Win.ModulesReports {
    public partial class TopNFilms : ReportModuleBase {
        public TopNFilms() {
            InitializeComponent();
        }

        protected override ReportBase CreateReport() {
            return new TopNFilmsReport();
        }
        protected override void SetCommandsVisibility(ReportBase report) {
            base.SetCommandsVisibility(report);
            HideUnsupportedExportCommands(report);
            HideUnsupportedSendCommands(report);
        }
        static void HideUnsupportedExportCommands(ReportBase report) {
            report.PrintingSystem.SetCommandVisibility(PrintingSystemCommand.ExportMht, CommandVisibility.None);
            report.PrintingSystem.SetCommandVisibility(PrintingSystemCommand.ExportHtm, CommandVisibility.None);
            report.PrintingSystem.SetCommandVisibility(PrintingSystemCommand.ExportCsv, CommandVisibility.None);
            report.PrintingSystem.SetCommandVisibility(PrintingSystemCommand.ExportXls, CommandVisibility.None);
            report.PrintingSystem.SetCommandVisibility(PrintingSystemCommand.ExportRtf, CommandVisibility.None);
            report.PrintingSystem.SetCommandVisibility(PrintingSystemCommand.ExportTxt, CommandVisibility.None);
            report.PrintingSystem.SetCommandVisibility(PrintingSystemCommand.ExportXlsx, CommandVisibility.None);
            report.PrintingSystem.SetCommandVisibility(PrintingSystemCommand.ExportXps, CommandVisibility.None);
        }
        static void HideUnsupportedSendCommands(ReportBase report) {
            report.PrintingSystem.SetCommandVisibility(PrintingSystemCommand.SendMht, CommandVisibility.None);
            report.PrintingSystem.SetCommandVisibility(PrintingSystemCommand.SendCsv, CommandVisibility.None);
            report.PrintingSystem.SetCommandVisibility(PrintingSystemCommand.SendXls, CommandVisibility.None);
            report.PrintingSystem.SetCommandVisibility(PrintingSystemCommand.SendRtf, CommandVisibility.None);
            report.PrintingSystem.SetCommandVisibility(PrintingSystemCommand.SendTxt, CommandVisibility.None);
            report.PrintingSystem.SetCommandVisibility(PrintingSystemCommand.SendXlsx, CommandVisibility.None);
            report.PrintingSystem.SetCommandVisibility(PrintingSystemCommand.SendXps, CommandVisibility.None);
        }
    }
}
