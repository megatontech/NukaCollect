using DevExpress.Data;
using DevExpress.LookAndFeel;
using DevExpress.Utils.Menu;
using DevExpress.Xpo;
using DevExpress.XtraBars.Docking;
using DevExpress.XtraCharts;
using DevExpress.XtraCharts.Printing;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraLayout;
using DevExpress.XtraPivotGrid;
using DevExpress.XtraPrinting;
using DevExpress.XtraPrinting.Links;
using DevExpress.XtraPrintingLinks;
using DevExpress.XtraReports;
using DevExpress.XtraReports.UI;
using DevExpress.XtraScheduler;
using NukaCollect.Helpers;
using NukaCollect.Resources;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace NukaCollect.Win
{
    public class TutorialControl : TutorialControlBase
    {
        private UnitOfWork session = null;

        public TutorialControl()
        {
        }

        public void SetParent(Form parent)
        {
            if (this.ParentFormMain == parent) return;
            this.ParentFormMain = parent as frmMain;
            if (parent != null)
            {
                AddMenuManager(this.ParentFormMain.MenuManager);
                this.RibbonMenuController.AddPageForControl(this);
            }
            DoParentChanged();
        }

        protected virtual void DoParentChanged()
        {
            RefreshGridDataSource();
        }

        protected virtual void RefreshGridDataSource()
        {
        }

        public void SetSession(UnitOfWork session)
        {
            if (this.session == null)
            {
                this.session = session;
                InitData();
            }
        }

        public UnitOfWork Session { get { return session; } }

        protected UnitOfWork GetSession()
        {
            return Session;
        }

        protected virtual void InitData()
        {
            if (MainView != null)
            {
                MainView.FocusedRowChanged += new FocusedRowChangedEventHandler(MainView_FocusedRowChanged);
                MainView.ColumnFilterChanged += new EventHandler(MainView_ColumnFilterChanged);
                MainView.GridControl.MouseDoubleClick += new MouseEventHandler(GridControl_MouseDoubleClick);
                MainView.GridControl.KeyDown += new KeyEventHandler(GridControl_KeyDown);
            }
            if (AlternateView != null)
            {
                AlternateView.FocusedRowChanged += new FocusedRowChangedEventHandler(MainView_FocusedRowChanged);
                AlternateView.ColumnFilterChanged += new EventHandler(MainView_ColumnFilterChanged);
            }
        }

        private void GridControl_KeyDown(object sender, KeyEventArgs e)
        {
            if (MainView.OptionsBehavior.Editable == false && CurrentEditObject != null && e.KeyCode == Keys.Enter)
                DoEdit();
        }

        private void DoEdit()
        {
            Cursor.Current = Cursors.WaitCursor;
            Edit();
            Cursor.Current = Cursors.Default;
        }

        private void GridControl_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            GridView gv = ((GridControl)sender).MainView as GridView;
            if (gv != null)
            {
                GridHitInfo info = gv.CalcHitInfo(new Point(e.X, e.Y));
                if (CurrentEditObject == null || !info.InRow || AllowEdit(info)) return;
                DoEdit();
            }
            else
            {
                ColumnView cv = ((GridControl)sender).MainView as ColumnView;
                if (cv != null)
                {
                    if (CurrentEditObject == null) return;
                    DoEdit();
                }
            }
        }

        protected virtual bool AllowEdit(GridHitInfo info)
        {
            return false;
        }

        private void MainView_ColumnFilterChanged(object sender, EventArgs e)
        {
            DoFocusedRowChanged();
        }

        private void MainView_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            DoFocusedRowChanged();
        }

        protected virtual void DoFocusedRowChanged()
        {
            SetCurrentObject(CurrentEditObject);
        }

        protected override void SetControlManager(Control ctrl, IDXMenuManager manager)
        {
            GridControl grid = ctrl as GridControl;
            if (grid != null) grid.MenuManager = manager;
            LayoutControl layout = ctrl as LayoutControl;
            if (layout != null) layout.MenuManager = manager;
            PivotGridControl pGrid = ctrl as PivotGridControl;
            if (pGrid != null) pGrid.MenuManager = manager;
            SchedulerControl scheduler = ctrl as SchedulerControl;
            if (scheduler != null) scheduler.MenuManager = manager;
        }

        protected override void UpdateMenu()
        {
            base.UpdateMenu();
            if (RibbonMenuController != null) RibbonMenuController.UpdateMenu();
        }

        protected override void CreateDetailRibbon()
        {
            base.CreateDetailRibbon();
            if (RibbonMenuController != null) RibbonMenuController.CreateDetailRibbon();
        }

        protected override void DoShow()
        {
            base.DoShow();
            RibbonMenuController.CurrentControl = this;
            SetCurrentObject(CurrentEditObject);
            RibbonMenuController.CalcCloseAllDetails();
            LoadFormLayout();
            if (CurrentView != null)
            {
                CurrentView.GridControl.ForceInitialize();
                CurrentView.Focus();
            }
            AllowExport();
            EnableSimpleActions();
        }

        private void EnableSimpleActions()
        {
            //add other actions
            if (CurrentEditObject == null)
                ParentFormMain.RibbonMenuController.CalcDetailFormItemsEnabling(false, false, false);
            ParentFormMain.RotateLayoutButton.Enabled = AllowRotateLayout;
            ParentFormMain.FlipLayoutButton.Enabled = AllowFlipLayout;
        }

        protected override void DoHide()
        {
            base.DoHide();
            if (Session == null) return;
            SessionHelper.CommitSession(Session, new ExceptionsProcesser(this.FindForm()));
            SaveFormLayout();
        }

        internal void ForceHide()
        {
            DoHide();
        }

        private void SetCurrentObject(object obj)
        {
            if (CurrentView == null || ParentFormMain == null) return;
            RibbonMenuController.CalcDetailFormItemsEnabling(obj != null, CurrentView.FocusedRowHandle == 0, CurrentView.FocusedRowHandle == ((IDataControllerVisualClient)CurrentView).VisibleRowCount - 1);
            RibbonMenuController.CalcCustomerItemsEnabling(obj != null);
        }

        protected override void LoadFormLayout()
        {
            if (LayoutManager == null || ActiveDetailControl != null) return;
            LayoutManager.RestoreFormLayout(new FormLayoutInfo(this.Name, null, MainLayoutControl, MainView, AlternateView, MainDockManager, null));
        }

        protected override void SaveFormLayout()
        {
            if (LayoutManager == null || ActiveDetailControl != null) return;
            LayoutManager.SaveFormLayout(new FormLayoutInfo(this.Name, null, MainLayoutControl, MainView, AlternateView, MainDockManager, null));
        }

        protected internal virtual void ShowTutorial()
        { }

        #region Editing

        public virtual void Add()
        {
        }

        public virtual void Edit()
        {
        }

        protected internal virtual bool Delete()
        {
            if (CurrentEditObject == null) return false;
            if (IsDetailExist(CurrentEditObject.Oid)) return false;
            if (XtraMessageBox.Show(this.FindForm(),
                string.Format(ConstStrings.Get("DeleteRecord"), EditObjectName), ConstStrings.Get("Question"), MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                bool ret = ObjectHelper.SafeDelete(this.FindForm(), CurrentEditObject, true);
                return ret;
            }
            return false;
        }

        public virtual void EditOptions()
        {
        }

        protected internal virtual void Next()
        {
            CurrentView.FocusedRowHandle++;
        }

        protected internal virtual void Prev()
        {
            CurrentView.FocusedRowHandle--;
        }

        internal void SetCurrentCustomer()
        {
            Customer customer = ActiveDetailControl != null ? ActiveDetailControl.editObject as Customer : CurrentEditObject as Customer;
            if (customer == null) return;
            LayoutManager.CurrentCustomer = LayoutManager.GetCustomer(customer);
        }

        protected internal virtual void RentMovie()
        {
        }

        protected internal virtual void ReturnMovie()
        {
        }

        protected internal virtual void CheckActiveItems()
        {
        }

        internal void LoadPicture()
        {
            if (ActiveDetailControl != null) ActiveDetailControl.LoadPicture();
        }

        internal void ClearPicture()
        {
            if (ActiveDetailControl != null) ActiveDetailControl.ClearPicture();
        }

        internal void AddPicture()
        {
            if (ActiveDetailControl != null) ActiveDetailControl.AddPicture();
        }

        internal void DeletePicture()
        {
            if (ActiveDetailControl != null) ActiveDetailControl.DeletePicture();
        }

        internal void MovieAddItem()
        {
            if (ActiveDetailControl != null) ActiveDetailControl.MovieAddItem();
        }

        internal void MovieManageItems()
        {
            if (ActiveDetailControl != null) ActiveDetailControl.MovieManageItems();
        }

        protected internal virtual void ViewStylesPopup(object sender)
        {
            ParentFormMain.MainViewButton.Down = CurrentView == MainView;
            ParentFormMain.AlternateViewButton.Down = CurrentView == AlternateView;
        }

        protected internal virtual void ShowMovieCategories()
        {
        }

        protected internal virtual void DoViewChange(bool mainView)
        {
        }

        internal void RefreshData()
        {
            BeginRefreshData();
            EndRefreshData();
        }

        private Session oldSession;

        protected virtual void BeginRefreshData()
        {
            Cursor.Current = Cursors.WaitCursor;
            oldSession = Session;
            if (Session != null)
                session = new UnitOfWork(Session.DataLayer);
        }

        protected virtual void EndRefreshData()
        {
            if (oldSession != null)
            {
                oldSession.Dispose();
                oldSession = null;
            }
        }

        internal void RotateLayout()
        {
            if (!AllowRotateLayout || MainLayoutControl == null) return;
            MainLayoutControl.Root.RotateLayout();
        }

        internal void FlipLayout()
        {
            if (!AllowFlipLayout || MainLayoutControl == null) return;
            MainLayoutControl.Root.FlipLayout();
        }

        protected internal virtual void SaveCurrentRecord()
        {
        }

        #endregion Editing

        #region Properties

        public virtual string EditObjectName { get { return string.Empty; } }
        public virtual string EditObjectsName { get { return string.Empty; } }
        protected virtual ColumnView CurrentView { get { return MainView; } }
        protected virtual ColumnView MainView { get { return null; } }
        protected virtual ColumnView AlternateView { get { return null; } }
        protected virtual DockManager MainDockManager { get { return null; } }
        protected virtual LayoutControl MainLayoutControl { get { return null; } }
        protected virtual VideoRentBaseObject CurrentEditObject { get { return null; } }
        protected internal virtual ViewType ChartViewType { get { return ViewType.Bar; } }
        protected virtual bool AllowRotateLayout { get { return false; } }
        protected virtual bool AllowFlipLayout { get { return false; } }

        #endregion Properties

        #region Print and Export

        protected virtual void AllowExport()
        {
            EnabledPrintExportActions(false);
        }

        internal void EnabledPrintExportActions(bool allow)
        {
            EnabledPrintExportActions(allow, allow, allow, allow, allow, allow, allow, allow, allow, allow);
        }

        internal void EnabledPrintExportActions(bool allowPrintPreview, bool allowExportToPDF, bool allowExportToXML,
            bool allowExportToHTML, bool allowExportToMHT, bool allowExportToXLS, bool allowExportToRTF, bool allowExportToImage, bool allowExportToText, bool allowExportToXLSX)
        {
            ParentFormMain.ExportToPDFButton.Enabled = allowExportToPDF;
            ParentFormMain.ExportToXMLButton.Enabled = allowExportToXML;
            ParentFormMain.ExportToHTMLButton.Enabled = allowExportToHTML;
            ParentFormMain.ExportToMHTButton.Enabled = allowExportToMHT;
            ParentFormMain.ExportToXLSButton.Enabled = allowExportToXLS;
            ParentFormMain.ExportToXLSXButton.Enabled = allowExportToXLSX;
            ParentFormMain.ExportToRTFButton.Enabled = allowExportToRTF;
            ParentFormMain.ExportToImageButton.Enabled = allowExportToImage;
            ParentFormMain.ExportToTextButton.Enabled = allowExportToText;
            ParentFormMain.PrintPreviewButton.Enabled = allowPrintPreview;
            ParentFormMain.ExportButton.Enabled = allowExportToPDF || allowExportToXML || allowExportToHTML ||
                 allowExportToMHT || allowExportToXLS || allowExportToRTF ||
                 allowExportToImage || allowExportToText || allowExportToXLSX;
        }

        protected internal virtual void PrintPreview()
        {
        }

        protected void ShowRibbonPreviewDialog(LinkBase link)
        {
            InitPrintTool(new LinkPrintTool(link));
        }

        protected void ShowRibbonPreviewDialog(IReport report)
        {
            InitPrintTool(new ReportPrintTool(report));
        }

        protected virtual void InitPrintTool(PrintTool tool)
        {
            tool.PreviewRibbonForm.AllowFormGlass = this.ParentFormMain.AllowFormGlass;
            tool.PreviewRibbonForm.RibbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010;
            tool.PreviewRibbonForm.RibbonControl.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            tool.PreviewRibbonForm.RibbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            tool.ShowRibbonPreviewDialog(UserLookAndFeel.Default);
        }

        protected internal virtual void ExportToPDF()
        {
        }

        protected internal virtual void ExportToXML()
        {
        }

        protected internal virtual void ExportToHTML()
        {
        }

        protected internal virtual void ExportToMHT()
        {
        }

        protected internal virtual void ExportToXLS()
        {
        }

        protected internal virtual void ExportToXLSX()
        {
        }

        protected internal virtual void ExportToRTF()
        {
        }

        protected internal virtual void ExportToImage()
        {
        }

        protected internal virtual void ExportToText()
        {
        }

        #endregion Print and Export
    }

    public class GridExportTutorialControl : TutorialControl
    {
        private PrintingSystem printingSystem = null;

        private PrintingSystem Printing
        {
            get
            {
                if (printingSystem == null) printingSystem = new PrintingSystem();
                return printingSystem;
            }
        }

        protected virtual BaseView ExportView { get { return MainView; } }
        protected virtual bool Landscape { get { return false; } }
        protected virtual string ExportFileName { get { return EditObjectsName; } }

        protected override void AllowExport()
        {
            EnabledPrintExportActions(true, true, false, true, true, true, true, false, true, true);
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
            if (disposing && printingSystem != null)
                printingSystem.Dispose();
        }

        protected internal override void PrintPreview()
        {
            if (ExportView != null)
            {
                PrintableComponentLink printableLink = new PrintableComponentLink();
                printableLink.Component = ExportView.GridControl;
                printableLink.Landscape = Landscape;
                printableLink.CreateDocument(Printing);
                ShowRibbonPreviewDialog(printableLink);
            }
        }

        private void ExportTo(string ext, string filter)
        {
            string fileName = ObjectHelper.GetFileName(string.Format("*.{0}", ext), filter, ObjectHelper.GetPossibleFileName(ExportFileName));
            if (!String.IsNullOrEmpty(fileName))
                try
                {
                    ExportToCore(fileName, ext);
                    ObjectHelper.OpenExportedFile(fileName);
                }
                catch
                {
                    EndExport();
                    ObjectHelper.ShowExportErrorMessage();
                }
        }

        private void ExportToCore(String filename, string ext)
        {
            if (ExportView == null) return;
            StartExport();
            Cursor currentCursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;
            if (ext == "rtf") ExportView.ExportToRtf(filename);
            if (ext == "pdf") ExportView.ExportToPdf(filename);
            if (ext == "mht") ExportView.ExportToMht(filename);
            if (ext == "html") ExportView.ExportToHtml(filename);
            if (ext == "txt") ExportView.ExportToText(filename);
            if (ext == "xls") ExportView.ExportToXls(filename);
            if (ext == "xlsx") ExportView.ExportToXlsx(filename);
            Cursor.Current = currentCursor;
            EndExport();
        }

        protected virtual void StartExport()
        {
        }

        protected virtual void EndExport()
        {
        }

        protected internal override void ExportToPDF()
        {
            ExportTo("pdf", ConstStrings.Get("PDFOpenFileFilter"));
        }

        protected internal override void ExportToHTML()
        {
            ExportTo("html", ConstStrings.Get("HTMLOpenFileFilter"));
        }

        protected internal override void ExportToMHT()
        {
            ExportTo("mht", ConstStrings.Get("MHTOpenFileFilter"));
        }

        protected internal override void ExportToXLS()
        {
            ExportTo("xls", ConstStrings.Get("XLSOpenFileFilter"));
        }

        protected internal override void ExportToXLSX()
        {
            ExportTo("xlsx", ConstStrings.Get("XLSXOpenFileFilter"));
        }

        protected internal override void ExportToRTF()
        {
            ExportTo("rtf", "RTF document (*.rtf)|*.rtf");
        }

        protected internal override void ExportToText()
        {
            ExportTo("txt", "Text document (*.txt)|*.txt");
        }
    }

    public class ChartExportTutorialControl : TutorialControl
    {
        private PrintingSystem printingSystem = new PrintingSystem();

        protected virtual bool ShouldTransponsePivotOnPrint { get { return false; } }

        protected override void AllowExport()
        {
            EnabledPrintExportActions(true, true, false, true, true, true, false, true, false, true);
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
            if (disposing)
                printingSystem.Dispose();
        }

        private PivotGridControl MainPivotGrid
        {
            get
            {
                if (MainLayoutControl == null) return null;
                foreach (Control ctrl in MainLayoutControl.Controls)
                    if (ctrl is PivotGridControl)
                        return ctrl as PivotGridControl;
                return null;
            }
        }

        private void TransposePivotGrid(PivotGridControl pivotGrid)
        {
            pivotGrid.BeginUpdate();
            foreach (PivotGridField field in pivotGrid.Fields)
            {
                if (field.Area == PivotArea.ColumnArea)
                    field.Area = PivotArea.RowArea;
                else if (field.Area == PivotArea.RowArea)
                    field.Area = PivotArea.ColumnArea;
            }
            pivotGrid.OptionsChartDataSource.ProvideDataByColumns = !pivotGrid.OptionsChartDataSource.ProvideDataByColumns;
            pivotGrid.EndUpdate();
            pivotGrid.BestFit();
        }

        private PrintableComponentLink CreatePrintableLink(IPrintable printable)
        {
            ChartControl chart = printable as ChartControl;
            if (chart != null)
                chart.OptionsPrint.SizeMode = PrintSizeMode.Stretch;
            PrintableComponentLink printableLink = new PrintableComponentLink();
            printableLink.Component = printable;
            return printableLink;
        }

        private CompositeLink GetPrintableLink()
        {
            CompositeLink link = new CompositeLink(printingSystem);
            ChartControl mainChart = MainChart;
            ChartControl alternateChart = AlternateChart;
            PivotGridControl pivotGrid = MainPivotGrid;
            if (mainChart != null)
                link.Links.Add(CreatePrintableLink(mainChart));
            if (alternateChart != null)
                link.Links.Add(CreatePrintableLink(alternateChart));
            if (pivotGrid != null)
            {
                if (ShouldTransponsePivotOnPrint)
                    TransposePivotGrid(pivotGrid);
                link.Links.Add(CreatePrintableLink(pivotGrid));
            }
            link.Landscape = true;
            link.CreateDocument();
            if (pivotGrid != null && ShouldTransponsePivotOnPrint)
                TransposePivotGrid(pivotGrid);
            return link;
        }

        protected internal override void PrintPreview()
        {
            ShowRibbonPreviewDialog(GetPrintableLink());
        }

        protected internal override void ExportToPDF()
        {
            string fileName = ObjectHelper.GetFileName("*.pdf", ConstStrings.Get("PDFOpenFileFilter"));
            if (!String.IsNullOrEmpty(fileName))
                try
                {
                    GetPrintableLink().PrintingSystem.ExportToPdf(fileName);
                    ObjectHelper.OpenExportedFile(fileName);
                }
                catch
                {
                    ObjectHelper.ShowExportErrorMessage();
                }
        }

        protected internal override void ExportToHTML()
        {
            string fileName = ObjectHelper.GetFileName("*.html", ConstStrings.Get("HTMLOpenFileFilter"));
            if (!String.IsNullOrEmpty(fileName))
                try
                {
                    GetPrintableLink().PrintingSystem.ExportToHtml(fileName);
                    ObjectHelper.OpenExportedFile(fileName);
                }
                catch
                {
                    ObjectHelper.ShowExportErrorMessage();
                }
        }

        protected internal override void ExportToMHT()
        {
            string fileName = ObjectHelper.GetFileName("*.mht", ConstStrings.Get("MHTOpenFileFilter"));
            if (!String.IsNullOrEmpty(fileName))
                try
                {
                    GetPrintableLink().PrintingSystem.ExportToMht(fileName);
                    ObjectHelper.OpenExportedFile(fileName);
                }
                catch
                {
                    ObjectHelper.ShowExportErrorMessage();
                }
        }

        protected internal override void ExportToXLS()
        {
            string fileName = ObjectHelper.GetFileName("*.xls", ConstStrings.Get("XLSOpenFileFilter"));
            if (!String.IsNullOrEmpty(fileName))
                try
                {
                    GetPrintableLink().PrintingSystem.ExportToXls(fileName);
                    ObjectHelper.OpenExportedFile(fileName);
                }
                catch
                {
                    ObjectHelper.ShowExportErrorMessage();
                }
        }

        protected internal override void ExportToXLSX()
        {
            string fileName = ObjectHelper.GetFileName("*.xlsx", ConstStrings.Get("XLSXOpenFileFilter"));
            if (!String.IsNullOrEmpty(fileName))
                try
                {
                    GetPrintableLink().PrintingSystem.ExportToXlsx(fileName);
                    ObjectHelper.OpenExportedFile(fileName);
                }
                catch
                {
                    ObjectHelper.ShowExportErrorMessage();
                }
        }

        protected internal override void ExportToImage()
        {
            string fileName = ObjectHelper.GetFileName("*.png", ConstStrings.Get("PNGOpenFileFilter"));
            if (!String.IsNullOrEmpty(fileName))
                try
                {
                    GetPrintableLink().PrintingSystem.ExportToImage(fileName, new ImageExportOptions(ImageFormat.Png));
                    ObjectHelper.OpenExportedFile(fileName);
                }
                catch
                {
                    ObjectHelper.ShowExportErrorMessage();
                }
        }
    }
}