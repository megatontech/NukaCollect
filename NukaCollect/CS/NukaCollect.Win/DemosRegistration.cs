using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Utils.Menu;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Docking;
using DevExpress.Xpo;
using DevExpress.XtraNavBar;
using DevExpress.XtraBars.Ribbon;
using NukaCollect.Win.Modules;
using NukaCollect.Resources;

namespace NukaCollect.Win {
    public class DemosInfo : ModulesInfo {
        public static void ShowModule(frmMain parent, string name, PanelControl group, UnitOfWork session) {
            ModuleInfo item = DemosInfo.GetItem(name);
            Cursor currentCursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;
            try {
                TutorialControlBase oldTutorial = null;
                if(Instance.CurrentModuleBase != null) {
                    if(Instance.CurrentModuleBase.Name == name) return;
                    oldTutorial = Instance.CurrentModuleBase.TModule;
                    Instance.CurrentModuleBase.ModuleDispose();
                }

                TutorialControl tutorial = item.TModule as TutorialControl;
                tutorial.Bounds = group.DisplayRectangle;
                Instance.CurrentModuleBase = item;
                tutorial.Visible = false;
                group.Controls.Add(tutorial);
                tutorial.Dock = DockStyle.Fill;

                //-----Init----
                WinHelper.CloseCustomizationForm(oldTutorial);
                //-------------

                //-----Set----
                tutorial.SetSession(session);
                tutorial.SetParent(parent);
                tutorial.TutorialName = name;
                parent.ChartAppearanceManager.ViewType = tutorial.ChartViewType;
                tutorial.CheckChartStyles(parent.ChartAppearanceManager);
                tutorial.ShowTutorial();
                //------------
                
                tutorial.Visible = true;
                tutorial.BringToFront();
                item.WasShown = true;
                if(oldTutorial != null) {
                    oldTutorial.DumpActiveDetailControl();
                    oldTutorial.HideElements();
                }
            }
            finally {
                Cursor.Current = currentCursor;
            }
            RaiseModuleChanged();
        }
    }
    public class RibbonViewMenu {
        public static void CreateNavigationMenu(BarSubItem menu, NavBarControl navBar, BarManager manager) {
            foreach(NavBarGroup group in navBar.Groups)
                menu.ItemLinks.Add(CreateBarSubItem(manager, group));
        }
        static BarItem CreateBarSubItem(BarManager manager, NavBarGroup group) {
            BarSubItem item = new BarSubItem(manager, group.Caption);
            //item.Glyph = group.GetImage();
            item.Popup += new EventHandler(item_Popup);
            foreach(NavBarItemLink link in group.ItemLinks)
                item.ItemLinks.Add(CreateBarButtonItem(manager, link));
            return item;
        }
        static void item_Popup(object sender, EventArgs e) {
            BarSubItem menu = sender as BarSubItem;
            foreach(BarItemLink link in menu.ItemLinks)
                ((BarButtonItem)link.Item).Down = 
                    ModulesInfo.Instance.CurrentModuleBase == GetModuleInfoBarItemLink(link);
        }
        static ModuleInfo GetModuleInfoBarItemLink(BarItemLink link) {
            NavBarItemLink nLink = link.Item.Tag as NavBarItemLink;
            if(nLink == null) return null;
            return nLink.Item.Tag as ModuleInfo;
        }
        static BarButtonItem CreateBarButtonItem(BarManager manager, NavBarItemLink link) {
            BarButtonItem item = new BarButtonItem(manager, link.Item.Caption);
            item.Glyph = link.Item.SmallImage;
            item.ItemClick += new ItemClickEventHandler(item_ItemClick);
            item.Tag = link;
            item.ButtonStyle = BarButtonStyle.Check;
            return item;
        }
        static void item_ItemClick(object sender, ItemClickEventArgs e) {
            NavBarItemLink link = (NavBarItemLink)e.Item.Tag;
            link.NavBar.SelectedLink = link;
            link.NavBar.GetViewInfo().MakeLinkVisible(link);
        }
    }
    public class RibbonMenuController {
        frmMain parent = null;
        TutorialControl currentControl;
        public RibbonControl Ribbon {
            get {
                if(parent == null) return null;
                return parent.RibbonControl; 
            }
        }
        public TutorialControl CurrentControl {
            get { return currentControl; }
            set {
                if(currentControl == value) return;
                currentControl = value;
                if(CurrentControl != null)
                    InitRibbonMenu();
            }
        }
        internal void AddPageForControl(TutorialControl tutorialControl) {
            foreach(RibbonPage page in Ribbon.TotalPageCategory.Pages) {
                if(page.Tag == null) continue;
                if(page.Tag.Equals(tutorialControl.TypeName)) {
                    tutorialControl.ActiveRibbonPage = page;
                    page.Text = ConstStrings.Get("DefaultPageName");
                    page.Tag = tutorialControl;
                    break;
                }
            }
        }
        internal void CreateDetailRibbon() {
            foreach(RibbonPage page in Ribbon.TotalPageCategory.Pages) {
                if(page.Tag == null || 
                    CurrentControl.ActiveDetailControl == null ||
                    CurrentControl.ActiveDetailControl.ActiveRibbonPage != null) continue;
                if(page.Tag.Equals(CurrentControl.DetailTypeName)) 
                    CurrentControl.ActiveDetailControl.CreateActiveRibbonPage(page);
            }
        }
        bool lockPageChanging = false;
        internal void UpdateMenu() {
            lockPageChanging = true;
            foreach(RibbonPage page in Ribbon.TotalPageCategory.Pages) {
                if(page.Tag == null) continue;
                page.Visible = CurrentControl.IsSuitablePage(page);
                if(page.Visible && page.Tag.Equals(CurrentControl)) {
                    parent.RibbonControl.SelectedPage = page;
                }
            }
            lockPageChanging = false;
        }
        void InitRibbonMenu() {
            UpdateMenu();
            parent.AddButton.Hint = string.Format(ConstStrings.Get("AddButtonHint"), CurrentControl.EditObjectName);
            parent.EditButton.Hint = string.Format(ConstStrings.Get("EditButtonHint"), CurrentControl.EditObjectName);
            parent.DeleteButton.Hint = string.Format(ConstStrings.Get("DeleteButtonHint"), CurrentControl.EditObjectName);
            parent.RefreshButton.Hint = CurrentControl.EditObjectName == string.Empty ? ConstStrings.Get("RefreshDefaultButtonHint") : string.Format(ConstStrings.Get("RefreshButtonHint"), CurrentControl.EditObjectName);
            parent.PrevButton.Hint = string.Format(ConstStrings.Get("PrevButtonHint"), CurrentControl.EditObjectName);
            parent.NextButton.Hint = string.Format(ConstStrings.Get("NextButtonHint"), CurrentControl.EditObjectName);
            parent.OptionsButton.Hint = string.Format(ConstStrings.Get("EditViewOptions"), CurrentControl.EditObjectName);
            if(!string.IsNullOrEmpty(CurrentControl.EditObjectName) && CurrentControl.UseList) {
                parent.PrintPreviewButton.Hint = string.Format(ConstStrings.Get("PrintPreviewButtonHint"), CurrentControl.EditObjectName, ObjectHelper.GetArticleByWord(CurrentControl.EditObjectName));
                parent.ExportButton.Hint = string.Format(ConstStrings.Get("ExportButtonHint"), CurrentControl.EditObjectName);
                parent.HomeButton.Hint = string.Format(ConstStrings.Get("HomeButtonHint"), CurrentControl.EditObjectName);
            }
            else {
                parent.PrintPreviewButton.Hint = ConstStrings.Get("PrintPreviewButtonHintDefault");
                parent.ExportButton.Hint = ConstStrings.Get("ExportButtonHintDefault");
                parent.HomeButton.Hint = string.Empty;
            }
        }
        public RibbonMenuController(frmMain parent) {
            this.parent = parent;
            InitRibbonElementsImages();
            InitButtonActions();
            InitStatusBar();
            this.parent.RibbonControl.SelectedPageChanging += new RibbonPageChangingEventHandler(RibbonControl_SelectedPageChanging);    
        }
        Control activeControl = null;
        void RibbonControl_SelectedPageChanging(object sender, RibbonPageChangingEventArgs e) {
            if(lockPageChanging) return;
            Control control = e.Page.Tag as Control;
            if(control == null) return;
            if(!control.Visible) control.Show();
            control.BringToFront();
            if(!Object.Equals(control, activeControl))
                WinHelper.CloseCustomizationForm(CurrentControl);
            activeControl = control;

            lockPageChanging = true;
            try {
                TutorialControlBase tControl = control as TutorialControlBase;
                if(tControl != null) tControl.ActiveDetailControl = null;
                DetailBase dControl = control as DetailBase;
                if(dControl != null) CurrentControl.ActiveDetailControl = dControl;
            }
            finally {
                lockPageChanging = false;
            }
        }
        public static void SetBarButtonImage(BarItem item, string name) {
            item.LargeGlyph = ElementHelper.GetImage(name, ImageSize.Large32);
            item.Glyph = ElementHelper.GetImage(name, ImageSize.Small16);
        }
        void InitRibbonElementsImages() {
            SetBarButtonImage(parent.AddButton, "Add");
            SetBarButtonImage(parent.EditButton, "Edit");
            SetBarButtonImage(parent.DeleteButton, "Delete");
            SetBarButtonImage(parent.PrevButton, "Previous");
            SetBarButtonImage(parent.NextButton, "Next");
            SetBarButtonImage(parent.OptionsButton, "View");
            SetBarButtonImage(parent.CurrentCustomerButton, "Person");
            SetBarButtonImage(parent.ChangeCustomerButton, "UserKey");
            SetBarButtonImage(parent.RentButton, "Order");
            SetBarButtonImage(parent.ActiveRentButton, "ActiveRents");
            SetBarButtonImage(parent.ReturnButton, "Return");
            SetBarButtonImage(parent.SaveButton, "Save");
            SetBarButtonImage(parent.SaveAndCloseButton, "SaveAndClose");
            SetBarButtonImage(parent.CloseButton, "Close");
            SetBarButtonImage(parent.LoadPictureButton, "Open");
            SetBarButtonImage(parent.ClearPictureButton, "Delete");
            SetBarButtonImage(parent.AddPictureButton, "New");
            SetBarButtonImage(parent.DeletePictureButton, "Delete");
            SetBarButtonImage(parent.MovieAddItemButton, "AddItem");
            SetBarButtonImage(parent.MovieManageItemsButton, "ManageItems");
            SetBarButtonImage(parent.LayoutOptionsButton, "LayoutOptions");
            SetBarButtonImage(parent.ViewStylesMenu, "Views");
            SetBarButtonImage(parent.CloseDetailsButton, "CloseDetails");
            SetBarButtonImage(parent.ChartPaletteButton, "Palette");
            SetBarButtonImage(parent.MovieCategoriesButton, "Categories");
            SetBarButtonImage(parent.RefreshButton, "Refresh");
            SetBarButtonImage(parent.HomeButton, "Home");
            SetBarButtonImage(parent.PrintPreviewButton, "Preview");
            SetBarButtonImage(parent.ExportButton, "Export");
            SetBarButtonImage(parent.ExportToPDFButton, "ExportToPDF");
            SetBarButtonImage(parent.ExportToXMLButton, "ExportToXML");
            SetBarButtonImage(parent.ExportToHTMLButton, "ExportToHTML");
            SetBarButtonImage(parent.ExportToMHTButton, "ExportToMHT");
            SetBarButtonImage(parent.ExportToXLSButton, "ExportToExcel");
            SetBarButtonImage(parent.ExportToXLSXButton, "ExportToExcel");
            SetBarButtonImage(parent.ExportToRTFButton, "ExportToRTF");
            SetBarButtonImage(parent.ExportToImageButton, "ExportToIMG");
            SetBarButtonImage(parent.ExportToTextButton, "ExportToTXT");
            SetBarButtonImage(parent.RotateLayoutButton, "LayoutRotate");
            SetBarButtonImage(parent.FlipLayoutButton, "LayoutFlip");
            SetBarButtonImage(parent.PeriodButton, "Period");
            SetBarButtonImage(parent.ReceiptPeriodButton, "Period");
            SetBarButtonImage(parent.SaveCurrentRecordButton, "Save");
        }
        void InitButtonActions() {
            parent.AddButton.ItemClick += new ItemClickEventHandler(delegate { CurrentControl.Add(); });
            parent.EditButton.ItemClick += new ItemClickEventHandler(delegate { CurrentControl.Edit(); });
            parent.DeleteButton.ItemClick += new ItemClickEventHandler(delegate { CurrentControl.Delete(); });
            parent.PrevButton.ItemClick += new ItemClickEventHandler(delegate { CurrentControl.Prev(); });
            parent.NextButton.ItemClick += new ItemClickEventHandler(delegate { CurrentControl.Next(); });
            parent.OptionsButton.ItemClick += new ItemClickEventHandler(delegate { CurrentControl.EditOptions(); });
            parent.CurrentCustomerButton.ItemClick += new ItemClickEventHandler(delegate { CurrentControl.SetCurrentCustomer(); });
            parent.ChangeCustomerButton.ItemClick += new ItemClickEventHandler(delegate { parent.LayoutManager.ShowFindCustomerForm(parent, parent.MenuManager); });
            parent.RentButton.ItemClick += new ItemClickEventHandler(delegate { CurrentControl.RentMovie(); });
            parent.ReturnButton.ItemClick += new ItemClickEventHandler(delegate { CurrentControl.ReturnMovie(); });
            parent.ActiveRentButton.ItemClick += new ItemClickEventHandler(delegate { CurrentControl.CheckActiveItems(); });
            parent.SaveButton.ItemClick += new ItemClickEventHandler(delegate { CurrentControl.DetailSave(); });
            parent.SaveAndCloseButton.ItemClick += new ItemClickEventHandler(delegate { CurrentControl.DetailSaveAndClose(); });
            parent.CloseButton.ItemClick += new ItemClickEventHandler(delegate { CurrentControl.DetailClose(); });
            parent.LoadPictureButton.ItemClick += new ItemClickEventHandler(delegate { CurrentControl.LoadPicture(); });
            parent.ClearPictureButton.ItemClick += new ItemClickEventHandler(delegate { CurrentControl.ClearPicture(); });
            parent.MovieAddItemButton.ItemClick += new ItemClickEventHandler(delegate { CurrentControl.MovieAddItem(); });
            parent.MovieManageItemsButton.ItemClick += new ItemClickEventHandler(delegate { CurrentControl.MovieManageItems(); });
            parent.AddPictureButton.ItemClick += new ItemClickEventHandler(delegate { CurrentControl.AddPicture(); });
            parent.DeletePictureButton.ItemClick += new ItemClickEventHandler(delegate { CurrentControl.DeletePicture(); });
            parent.ViewStylesMenu.Popup += new EventHandler(ViewStylesMenu_Popup);
            parent.MainViewButton.ItemClick += new ItemClickEventHandler( delegate { CurrentControl.DoViewChange(true); });
            parent.AlternateViewButton.ItemClick += new ItemClickEventHandler(delegate { CurrentControl.DoViewChange(false); });
            parent.CloseDetailsButton.ItemClick += new ItemClickEventHandler(delegate { CurrentControl.CloseAllDetails(); });
            parent.MovieCategoriesButton.ItemClick += new ItemClickEventHandler(delegate { CurrentControl.ShowMovieCategories(); });
            parent.RefreshButton.ItemClick += new ItemClickEventHandler(delegate { CurrentControl.RefreshData(); });
            parent.HomeButton.ItemClick += new ItemClickEventHandler(delegate { CurrentControl.ShowMasterModule(); });
            parent.PrintPreviewButton.ItemClick += new ItemClickEventHandler(delegate { CurrentControl.PrintPreview(); });
            parent.ExportToPDFButton.ItemClick += new ItemClickEventHandler(delegate { CurrentControl.ExportToPDF(); });
            parent.ExportToXMLButton.ItemClick += new ItemClickEventHandler(delegate { CurrentControl.ExportToXML(); });
            parent.ExportToHTMLButton.ItemClick += new ItemClickEventHandler(delegate { CurrentControl.ExportToHTML(); });
            parent.ExportToMHTButton.ItemClick += new ItemClickEventHandler(delegate { CurrentControl.ExportToMHT(); });
            parent.ExportToXLSButton.ItemClick += new ItemClickEventHandler(delegate { CurrentControl.ExportToXLS(); });
            parent.ExportToXLSXButton.ItemClick += new ItemClickEventHandler(delegate { CurrentControl.ExportToXLSX(); });
            parent.ExportToRTFButton.ItemClick += new ItemClickEventHandler(delegate { CurrentControl.ExportToRTF(); });
            parent.ExportToImageButton.ItemClick += new ItemClickEventHandler(delegate { CurrentControl.ExportToImage(); });
            parent.ExportToTextButton.ItemClick += new ItemClickEventHandler(delegate { CurrentControl.ExportToText(); });
            parent.RotateLayoutButton.ItemClick += new ItemClickEventHandler(delegate { CurrentControl.RotateLayout(); });
            parent.FlipLayoutButton.ItemClick += new ItemClickEventHandler(delegate { CurrentControl.FlipLayout(); });
            parent.SaveCurrentRecordButton.ItemClick += new ItemClickEventHandler(delegate { CurrentControl.SaveCurrentRecord(); });
        }

        void ViewStylesMenu_Popup(object sender, EventArgs e) {
            CurrentControl.ViewStylesPopup(sender);
        }
        internal void CalcDetailFormItemsEnabling(bool allow, bool first, bool last) {
            parent.EditButton.Enabled = parent.DeleteButton.Enabled = allow;
            parent.PrevButton.Enabled = allow && !first;
            parent.NextButton.Enabled = allow && !last;
        }
        internal void SetAllowDelete(bool allow) {
            parent.DeleteButton.Enabled = allow;
        }
        internal void SetAllowNavigation(bool allowPrev, bool allowNext) {
            parent.PrevButton.Enabled = allowPrev;
            parent.NextButton.Enabled = allowNext;
        }
        internal void CalcCustomerItemsEnabling(bool allow) {
            parent.CurrentCustomerButton.Enabled = allow;
        }
        internal void CalcCloseAllDetails() {
            parent.CloseDetailsButton.Enabled = CurrentControl.IsDetailsExist;
        }
        internal void CalcRentItemsEnabling(bool allowRent, bool allowReturn) {
            //TODO parent.RentButton.Enabled = allowRent;
            parent.RentButton.Enabled = false; //for the future use    
            parent.ReturnButton.Enabled = allowReturn;
        }
        internal void CalcRentItemsEnablingEx(bool allowCheck) {
            parent.ActiveRentButton.Enabled = allowCheck;
        }
        void InitStatusBar() {
            BarItemLink link = parent.MainStatusBar.ItemLinks.Add(parent.ChangeCustomerButton);
            link.Item.Alignment = BarItemLinkAlignment.Right;
            link.UserCaption = "";
            link.UserDefine = BarLinkUserDefines.Caption;
        }
    }
}
