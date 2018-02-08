using System;
using DevExpress.XtraPrinting.Preview;
using DevExpress.XtraPrinting;
using System.Collections.Generic;
using DevExpress.XtraBars;
using DevExpress.XtraReports.UI;
using System.IO;
using System.Windows.Forms;
using DevExpress.LookAndFeel;
using DevExpress.Utils;
using DevExpress.XtraBars.Ribbon;
using NukaCollect.Reports;

namespace NukaCollect.Win.ModulesReports {
    public partial class ReportModuleBase : NukaCollect.Win.TutorialControl {
        ReportBase report;
        string fileName = string.Empty;
        bool showDesignerAfterPrint = false;

        public ReportModuleBase() {
            InitializeComponent();
            report = CreateReport();
            printControl.PrintingSystem = report.PrintingSystem;
            fileName = GetReportPath(report, "repx");
            SetCommandsVisibility(report);
            report.AfterPrint += report_AfterPrint;
        }
        protected virtual void SetCommandsVisibility(ReportBase report) {
            report.PrintingSystem.SetCommandVisibility(PrintingSystemCommand.ClosePreview, CommandVisibility.None);
            report.PrintingSystem.SetCommandVisibility(PrintingSystemCommand.Open, CommandVisibility.None);
            report.PrintingSystem.SetCommandVisibility(PrintingSystemCommand.Save, CommandVisibility.None);
        }
        protected override void DoHide() {
            base.DoHide();
            report.PrintingSystem.ExecCommand(PrintingSystemCommand.StopPageBuilding);
            if(!(ModulesInfo.Instance.CurrentModuleBase.TModule is ReportModuleBase))
                ParentFormMain.HidePreviewPage();
        }
        protected override void DoShow() {
            base.DoShow();
            ParentFormMain.ShowPreviewPage();
            report.Session = Session;
            ParentFormMain.PrintRibbonController.PrintControl = printControl;
            if(report.Pages.Count == 0)
                report.CreateDocument(true);
        }
        void OnDesignerButtonClick(object sender, ItemClickEventArgs e) {
            if(ModulesInfo.Instance.CurrentModuleBase.TModule != this)
                return;
            if(report.PrintingSystem.Document.IsCreating) {
                showDesignerAfterPrint = true;
                report.PrintingSystem.ExecCommand(PrintingSystemCommand.StopPageBuilding);
            } else
                ShowReportDesigner();
        }
        void report_AfterPrint(object sender, EventArgs e) {
            report.PrintingSystem.Document.CanChangePageSettings = false;
            if(showDesignerAfterPrint) {
                showDesignerAfterPrint = false;
                ShowReportDesigner();
            }
        }
        void ShowReportDesigner() {
            Cursor.Current = Cursors.WaitCursor;
            string saveFileName = GetReportPath(report, "sav");
            report.SaveLayout(saveFileName);
            using(XtraReport newReport = XtraReport.FromFile(saveFileName, true)) {
                ((ReportBase)newReport).Session = this.Session;
                RibbonReportDesigner.MainForm designForm = new RibbonReportDesigner.MainForm();
                designForm.AllowFormGlass = this.ParentFormMain.AllowFormGlass;
                designForm.Ribbon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010;
                designForm.OpenReport(newReport);
                designForm.ActiveXRDesignPanel.FileName = fileName;
                Cursor.Current = Cursors.Default;
                ShowDesignerForm(designForm, this.FindForm());
                Cursor.Current = Cursors.WaitCursor;
                if(designForm.ActiveXRDesignPanel.FileName != fileName && File.Exists(designForm.ActiveXRDesignPanel.FileName))
                    File.Copy(designForm.ActiveXRDesignPanel.FileName, fileName, true);
                designForm.Dispose();
            }
            if(File.Exists(fileName)) {
                report.LoadLayout(fileName);
                File.Delete(fileName);
                Cursor.Current = Cursors.Default;
                report.CreateDocument(true);
            }
            File.Delete(saveFileName);
            Cursor.Current = Cursors.Default;
        }
        static string GetReportPath(XtraReport report, string ext) {
            System.Reflection.Assembly asm = System.Reflection.Assembly.GetExecutingAssembly();
            string repName = report.Name;
            if(repName.Length == 0)
                repName = report.GetType().Name;
            string dirName = Path.GetDirectoryName(asm.Location);
            return Path.Combine(dirName, String.Format("{0}.{1}", repName, ext));
        }
        void ShowDesignerForm(Form designForm, Form parentForm) {
            designForm.MinimumSize = parentForm.MinimumSize;
            if(parentForm.WindowState == FormWindowState.Normal)
                designForm.Bounds = parentForm.Bounds;
            designForm.WindowState = parentForm.WindowState;
            parentForm.Visible = false;
            designForm.ShowDialog();
            parentForm.Visible = true;
        }
        protected override void BeginRefreshData() {
            report.CreateDocument(true);
        }
        protected override void EndRefreshData() { }
        protected override void DoParentChanged() {
            base.DoParentChanged();
            ParentFormMain.SubscribeOnDesignerButtonClick(OnDesignerButtonClick);
        }
        protected virtual ReportBase CreateReport() {
            return new ReportBase();
        }
    }
}
