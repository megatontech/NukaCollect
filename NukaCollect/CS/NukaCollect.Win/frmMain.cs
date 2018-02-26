using DevExpress.LookAndFeel;
using DevExpress.Utils;
using DevExpress.Xpo;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Helpers;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraNavBar.ViewInfo;
using DevExpress.XtraPrinting.Preview;
using NukaCollect.Resources;
using NukaCollect.Win.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace NukaCollect.Win
{
    public partial class frmMain : frmMainBase, IFormWithLayoutManager
    {
        private FormLayoutManager layoutManager = null;
        private RibbonMenuController ribbonMenuController = null;
        private UnitOfWork dataSession = null;
        private ChartAppearanceManager chartAppearanceManager = null;
        private frmProgress progress = null;

        #region printing

        private List<BarItemLink> previewLinks = new List<BarItemLink>();
        private List<BarItemLink> links = new List<BarItemLink>();
        private PrintRibbonController printRibbonController = new PrintRibbonController();
        private BarButtonItem designerButton;
        private PrintPreviewRibbonPage previewPage;

        private PrintPreviewRibbonPage PreviewPage
        {
            get
            {
                if (previewPage == null)
                {
                    foreach (PrintPreviewRibbonPage page in printRibbonController.PreviewRibbonPages)
                    {
                        previewPage = page;
                        break;
                    }
                }
                return previewPage;
            }
        }

        public void SubscribeOnDesignerButtonClick(ItemClickEventHandler handler)
        {
            designerButton.ItemClick += handler;
        }

        public PrintRibbonController PrintRibbonController
        {
            get { return printRibbonController; }
        }

        private void InitPrintRibbonController()
        {
            foreach (BarItemLink link in this.StatusBar.ItemLinks)
                links.Add(link);
            printRibbonController.Initialize(this.RibbonControl, this.StatusBar);
            foreach (BarItemLink link in this.StatusBar.ItemLinks)
                if (!links.Contains(link))
                    previewLinks.Add(link);
            InitPreviewPage(PreviewPage);
            HidePreviewPage();
        }

        private void InitPreviewPage(PrintPreviewRibbonPage page)
        {
            if (page != null)
            {
                designerButton = CreateDesignerButton();
                designerButton.Manager = this.RibbonControl.Manager;
                page.Groups[PrintPreviewRibbonPageGroupKind.Document.ToString()].ItemLinks.Add(designerButton);
                page.Text = ConstStrings.Get("DefaultPageName");
                page.Groups[PrintPreviewRibbonPageGroupKind.PageSetup.ToString()].Visible = false;
            }
        }

        public void ShowPreviewPage()
        {
            SetVisibility(links, false);
            SetVisibility(previewLinks, true);
            if (PreviewPage != null)
            {
                PreviewPage.Visible = true;
                SetPageIndex(this.RibbonControl, PreviewPage, 0);
                this.RibbonControl.SelectedPage = PreviewPage;
            }
        }

        private static void SetPageIndex(RibbonControl ribbonControl, RibbonPage page, int index)
        {
            int currentIndex = ribbonControl.Pages.IndexOf(page);
            if (currentIndex != index)
            {
                ribbonControl.Pages.RemoveAt(currentIndex);
                ribbonControl.Pages.Insert(index, page);
                ribbonControl.SelectedPage = page;
            }
        }

        public void HidePreviewPage()
        {
            SetVisibility(links, true);
            SetVisibility(previewLinks, false);
            if (PreviewPage != null)
                PreviewPage.Visible = false;
        }

        private static void SetVisibility(List<BarItemLink> links, bool value)
        {
            foreach (BarItemLink link in links)
                link.Visible = value;
        }

        private static BarButtonItem CreateDesignerButton()
        {
            BarButtonItem buttonItem = new BarButtonItem();
            buttonItem.Caption = ConstStrings.Get("ShowReportDesigner");
            buttonItem.Hint = ConstStrings.Get("ShowReportDesigner");
            buttonItem.Visibility = BarItemVisibility.OnlyInRuntime;
            buttonItem.Glyph = ResourceImageHelper.CreateImageFromResources("NukaCollect.Resources.Images.Action_Report_ShowDesigner.png", typeof(NukaCollect.Resources.ImagesHelper).Assembly);
            buttonItem.LargeGlyph = ResourceImageHelper.CreateImageFromResources("NukaCollect.Resources.Images.Action_Report_ShowDesigner_32x32.png", typeof(NukaCollect.Resources.ImagesHelper).Assembly);
            return buttonItem;
        }

        #endregion printing

        public frmMain()
        {
            InitializeComponent();
            ElementConstStringLoader.LoadConstStringsForFrmMain(this);
            InitStyles();
            ToolTipController.DefaultController.ToolTipType = DevExpress.Utils.ToolTipType.SuperTip;
            ribbonMenuController = new RibbonMenuController(this);
            UserLookAndFeel.Default.StyleChanged += new EventHandler(Default_StyleChanged);
            ((DevExpress.LookAndFeel.Design.UserLookAndFeelDefault)UserLookAndFeel.Default).StyleChangeProgress += new LookAndFeelProgressEventHandler(frmMain_StyleChangeProgress);
            this.Icon = ElementHelper.AppIcon;
            InitPrintRibbonController();
        }

        private frmProgress Progress
        {
            get
            {
                if (progress == null) progress = new frmProgress(this);
                return progress;
            }
        }

        private void frmMain_StyleChangeProgress(object sender, LookAndFeelProgressEventArgs e)
        {
            if (e.State == 0)
            {
                Progress.ShowProgress(e.Progress);
                SuspendLayout();
            }
            if (e.State == 1)
            {
                Progress.Progress(e.Progress);
            }
            if (e.State == 2)
            {
                Progress.HideProgress();
                ResumeLayout();
            }
        }

        public RibbonMenuController RibbonMenuController { get { return ribbonMenuController; } }
        public ChartAppearanceManager ChartAppearanceManager { get { return chartAppearanceManager; } }
        protected override string DemoName { get { return ConstStrings.Get("DemoName"); } }

        protected override void nbMain_CustomDrawGroupCaption(object sender, DevExpress.XtraNavBar.ViewInfo.CustomDrawNavBarElementEventArgs e)
        {
            if (ConstStrings.Get("AdminGroup").Equals(e.Caption))
                e.Appearance.Font = ElementHelper.FontItalic;
            if (NavigationBar.OptionsNavPane.NavPaneState == DevExpress.XtraNavBar.NavPaneState.Collapsed) return;
            NavGroupInfoArgs info = e.ObjectInfo as NavGroupInfoArgs;
            int dx = 7;
            if (info == null) return;
            e.Image = null;
            info.CaptionBounds = new Rectangle(info.CaptionClientBounds.X + dx, info.CaptionClientBounds.Y,
                info.CaptionClientBounds.Width - dx * 2, info.CaptionClientBounds.Height);
        }

        private void Default_StyleChanged(object sender, EventArgs e)
        {
            InitStyles();
        }

        private void InitStyles()
        {
            ColorHelper.UpdateColor(ElementHelper.ColumnHeaderIcons, UserLookAndFeel.Default);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            WinHelper.SetFormClientSize(Screen.GetWorkingArea(this.Location), this, 1080, 840);
            InitDataManagement();
            LayoutManager.Properties.LoadDefaultSkin();
            LayoutManager.Properties.LoadChartPaletteAppearance(ChartAppearanceManager);
            SkinHelper.InitSkinGallery(rgbiSkins, true);
        }

        private void InitDataManagement()
        {
            dataSession = new UnitOfWork(XpoDefault.DataLayer);
            layoutManager = new FormLayoutManager(XpoDefault.DataLayer, SetDataInfo, dataSession);
            LayoutManager.RestoreFormLayout(new FormLayoutInfo(this, null, rcMain.Toolbar));
            //SetUserInfo(VideoRentCurrentUser.GetCurrentUser(dataSession).Login);
            SetUserInfo("admin");
            LayoutManager.SetDefaultCurrentCustomer(dataSession);
            NavigationBar.OptionsNavPane.NavPaneState = LayoutManager.Properties.CurrentProperty.NavPaneState;
        }

        public FormLayoutManager LayoutManager { get { return layoutManager; } }

        protected override void RegisterTutorials()
        {
            NukaCollect.Win.RegisterTutorials.Register();
        }

        protected override void ShowModule(string name, PanelControl parent)
        {
            DemosInfo.ShowModule(this, name, parent, dataSession == null ? null : new UnitOfWork(dataSession.DataLayer));
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            TutorialControl control = DemosInfo.CurrentModule as TutorialControl;
            if (control != null)
                control.ForceHide();
            LayoutManager.SaveFormLayout(new FormLayoutInfo(this, null, rcMain.Toolbar));
            LayoutManager.Properties.SaveDefaultProperties(LayoutManager, NavigationBar.OptionsNavPane.NavPaneState, ChartAppearanceManager);
        }

        #region Ribbon

        protected override void InitMenu()
        {
            SetBarGroupImages();
            SetMenuItemImages();
            SetActionDescriptions();
            RibbonViewMenu.CreateNavigationMenu(bsiModules, NavigationBar, MenuManager as BarManager);
            SkinHelper.InitSkinPopupMenu(pmAppearance);
            SkinHelper.InitSkinGalleryDropDown(gddSkins);
            pmAppearance.ItemLinks[1].BeginGroup = true;
            chartAppearanceManager = new ChartAppearanceManager(gddChartPalette, rgbiChartAppearance, bbiChartPalette);
            chartAppearanceManager.StyleChanged += new ChartAppearanceEventHandler(chartAppearanceManager_StyleChanged);
            sbExit.Image = ElementHelper.GetImage("Delete", ImageSize.Small16);
            appMenu.ItemLinks.Add(bbiAbout, true);
            gddChartPalette.Gallery.ShowGroupCaption = false;
        }

        private void SetActionDescriptions()
        {
            ExportButton.Description = ConstStrings.Get("ExportDescription");
            PrintPreviewButton.Description = ConstStrings.Get("PrintPreviewDescription");
            LayoutOptionsButton.Description = ConstStrings.Get("LayoutOptionDescription");
            PeriodButton.Description = ConstStrings.Get("PeriodDescription");
            bbiAbout.Description = ConstStrings.Get("AboutDescription");
            bbiSkins.Description = ConstStrings.Get("ChooseSkinDescription");
        }

        private void chartAppearanceManager_StyleChanged(object sender, ChartAppearanceEventArgs e)
        {
            ModulesInfo.CurrentModule.CheckChartStyles(ChartAppearanceManager);
        }

        private void SetBarGroupImages()
        {
            NavigationBar.Groups[ConstStrings.Get("RentalGroup")].SmallImage = ElementHelper.GetGroupImage("Rental");
            NavigationBar.Groups[ConstStrings.Get("CatalogGroup")].SmallImage = ElementHelper.GetGroupImage("Catalog");
            NavigationBar.Groups[ConstStrings.Get("KPIGroup")].SmallImage = ElementHelper.GetGroupImage("KPI");
            NavigationBar.Groups[ConstStrings.Get("StatisticsGroup")].SmallImage = ElementHelper.GetGroupImage("Statistics");
            NavigationBar.Groups[ConstStrings.Get("ReportsGroup")].SmallImage = ElementHelper.GetGroupImage("Reports");
            if (NavigationBar.Groups[ConstStrings.Get("AdminGroup")] != null)
                NavigationBar.Groups[ConstStrings.Get("AdminGroup")].SmallImage = ElementHelper.GetGroupImage("Administrator");
        }

        private void SetMenuItemImages()
        {
            RibbonMenuController.SetBarButtonImage(bsiModules, "Navigation");
        }

        private void rpgAppearance_CaptionButtonClick(object sender, DevExpress.XtraBars.Ribbon.RibbonPageGroupEventArgs e)
        {
            pmAppearance.ShowPopup(MousePosition);
        }

        private void pmAppearance_Popup(object sender, EventArgs e)
        {
            bciFormSkin.Checked = DevExpress.Skins.SkinManager.AllowFormSkins;
        }

        private void bciFormSkin_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.AllowFormGlass = DevExpress.Skins.SkinManager.AllowFormSkins ? DefaultBoolean.True : DefaultBoolean.False;
            if (DevExpress.Skins.SkinManager.AllowFormSkins)
                DevExpress.Skins.SkinManager.DisableFormSkins();
            else
                DevExpress.Skins.SkinManager.EnableFormSkins();
        }

        private void bbiLayoutOptions_ItemClick(object sender, ItemClickEventArgs e)
        {
            using (frmLayoutOptions form = new frmLayoutOptions(LayoutManager))
                form.ShowDialog(this);
        }

        private void bbiPeriod_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowPeriod(PeriodType.All);
        }

        private void bbiReceiptPeriod_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowPeriod(PeriodType.Receipt);
        }

        private void ShowPeriod(PeriodType type)
        {
            using (frmPeriod form = new frmPeriod(type))
                if (form.ShowDialog(this) == DialogResult.OK && ModulesInfo.CurrentModule != null)
                    ((TutorialControl)ModulesInfo.CurrentModule).RefreshData();
        }

        private void rcMain_ShowCustomizationMenu(object sender, RibbonCustomizationMenuEventArgs e)
        {
            e.CustomizationMenu.InitializeMenu();
            if (e.Link == null || !"AllowQuickAccess".Equals(e.Link.Item.Tag))
                e.CustomizationMenu.RemoveLink(e.CustomizationMenu.ItemLinks[0]);
        }

        internal BarButtonItem AddButton { get { return bbiAdd; } }
        internal BarButtonItem EditButton { get { return bbiEdit; } }
        internal BarButtonItem DeleteButton { get { return bbiDelete; } }
        internal BarButtonItem PrevButton { get { return bbiPrev; } }
        internal BarButtonItem NextButton { get { return bbiNext; } }
        internal BarButtonItem OptionsButton { get { return bbiOptions; } }
        internal BarButtonItem CurrentCustomerButton { get { return bbiCurrentCustomer; } }
        internal BarButtonItem RentButton { get { return bbiRent; } }
        internal BarButtonItem ReturnButton { get { return bbiReturn; } }
        internal BarButtonItem ActiveRentButton { get { return bbiActiveRent; } }
        internal BarButtonItem ChangeCustomerButton { get { return bbiChangeCustomer; } }
        internal BarButtonItem SaveButton { get { return bbiSave; } }
        internal BarButtonItem SaveAndCloseButton { get { return bbiSaveAndClose; } }
        internal BarButtonItem CloseButton { get { return bbiClose; } }
        internal BarButtonItem LoadPictureButton { get { return bbiLoadPicture; } }
        internal BarButtonItem ClearPictureButton { get { return bbiClearPicture; } }
        internal BarButtonItem MovieAddItemButton { get { return bbiAddItems; } }
        internal BarButtonItem MovieManageItemsButton { get { return bbiManageItems; } }
        internal BarButtonItem AddPictureButton { get { return bbiAddPicture; } }
        internal BarButtonItem DeletePictureButton { get { return bbiDeletePicture; } }
        internal BarButtonItem LayoutOptionsButton { get { return bbiLayoutOptions; } }
        internal BarSubItem ViewStylesMenu { get { return bsiViews; } }
        internal BarButtonItem MainViewButton { get { return bbiMainView; } }
        internal BarButtonItem AlternateViewButton { get { return bbiAlternateView; } }
        internal BarButtonItem CloseDetailsButton { get { return bbiCloseDetails; } }
        internal BarButtonItem ChartPaletteButton { get { return bbiChartPalette; } }
        internal BarButtonItem MovieCategoriesButton { get { return bbiMovieCategories; } }
        internal BarButtonItem RefreshButton { get { return bbiRefresh; } }
        internal BarButtonItem HomeButton { get { return bbiHome; } }
        internal BarButtonItem PrintPreviewButton { get { return bbiPrintPreview; } }
        internal BarButtonItem ExportButton { get { return bbiExport; } }
        internal BarButtonItem ExportToPDFButton { get { return bbiExportToPDF; } }
        internal BarButtonItem ExportToXMLButton { get { return bbiExportToXML; } }
        internal BarButtonItem ExportToHTMLButton { get { return bbiExportToHTML; } }
        internal BarButtonItem ExportToMHTButton { get { return bbiExportToMHT; } }
        internal BarButtonItem ExportToXLSButton { get { return bbiExportToXLS; } }
        internal BarButtonItem ExportToXLSXButton { get { return bbiExportToXLSX; } }
        internal BarButtonItem ExportToRTFButton { get { return bbiExportToRTF; } }
        internal BarButtonItem ExportToImageButton { get { return bbiExportToImage; } }
        internal BarButtonItem ExportToTextButton { get { return bbiExportToText; } }
        internal BarButtonItem RotateLayoutButton { get { return bbiLayoutRotate; } }
        internal BarButtonItem FlipLayoutButton { get { return bbiLayoutFlip; } }
        internal BarButtonItem PeriodButton { get { return bbiPeriod; } }
        internal BarButtonItem ReceiptPeriodButton { get { return bbiReceiptPeriod; } }
        internal BarButtonItem SaveCurrentRecordButton { get { return bbiSaveCurrentRecord; } }

        #endregion Ribbon

        private void sbExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        internal void UpdateSchedulerRibbonController(DevExpress.XtraScheduler.SchedulerControl schedulerControl)
        {
            this.schedulerBarController1.Control = schedulerControl;
        }
    }
}