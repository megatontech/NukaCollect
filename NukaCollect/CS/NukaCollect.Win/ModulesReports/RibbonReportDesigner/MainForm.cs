using System;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraReports.UserDesigner;
using DevExpress.LookAndFeel;
using DevExpress.XtraBars.Helpers;

namespace RibbonReportDesigner {
    public partial class MainForm : RibbonForm {
        public MainForm() {
            InitializeComponent();
        }
        void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            Close();
        }
        public void OpenReport(DevExpress.XtraReports.UI.XtraReport newReport) {
            reportDesigner1.OpenReport(newReport);
        }
        public void CreateNewReport() {
            reportDesigner1.CreateNewReport();
        }
        public XRDesignPanel ActiveXRDesignPanel {
            get { return reportDesigner1.ActiveDesignPanel; }
        }
    }
}
