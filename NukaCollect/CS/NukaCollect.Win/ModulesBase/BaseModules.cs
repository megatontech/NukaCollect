using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.Collections;
using DevExpress.XtraNavBar;
using DevExpress.XtraEditors;
using System.ComponentModel;
using DevExpress.XtraBars.Docking;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraBars;
using DevExpress.Utils.Menu;
using System.Drawing;
using NukaCollect.Win.Modules;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraCharts;
using NukaCollect.Resources;

namespace NukaCollect.Win {
    public delegate void CloseDetailForm(DialogResult result, object CurrentObject);
    public class ModuleInfo {
        string name;
        string description;
        string group;
        Type type;
        string imageName;
        bool wasShown;
        TutorialControlBase module;
        DemoProducts products = DemoProducts.None;

        public ModuleInfo(string name, Type type, string description, string imageName, string group, DemoProducts products) {
            if(!type.IsSubclassOf(typeof(UserControl)))
                throw new ArgumentException(ConstStrings.Get("SubclassError"));
            this.name = name;
            this.type = type;
            this.imageName = imageName;
            this.description = description;
            this.group = group;
            this.module = null;
            this.products = products;
        }
        public string Name { get { return this.name; } }
        public Image SmallImage { get { return ElementHelper.GetImage(imageName, ImageSize.Small16); } }
        public Image LargeImage { get { return ElementHelper.GetImage(imageName, ImageSize.Large32); } }
        public string Description { get { return this.description; } }
        public string Group { get { return this.group; } }
        public bool Created { get { return this.module != null; } }
        public bool WasShown { get { return wasShown; } set { wasShown = value; } }
        public DemoProducts Products { get { return products; } }
        public string TypeName {
            get {
                if(Created)
                    return TModule.GetType().Name;
                return string.Empty;
            }
        }
        public void ModuleDispose() {
            if(this.module != null && this.module.AllowDispose) {
                this.module.ResetPibbonPage();
                this.module.Dispose();
                this.module = null;
            }
        }
        public TutorialControlBase TModule {
            get {
                if(this.module == null) {
                    ConstructorInfo constructorInfoObj = type.GetConstructor(Type.EmptyTypes);
                    if(constructorInfoObj == null)
                        throw new ApplicationException(string.Format(ConstStrings.Get("PublicConstructorError"), type.FullName));
                    this.module = constructorInfoObj.Invoke(null) as TutorialControlBase;
                }
                return this.module;
            }
        }
    }
    public class ModuleInfoCollection : CollectionBase {
        public ModuleInfo this[int index] {
            get {
                if(List.Count > index)
                    return List[index] as ModuleInfo;
                return null;
            }
        }
        public ModuleInfo this[string name] {
            get {
                foreach(ModuleInfo info in this)
                    if(info.Name.Equals(name))
                        return info;
                return null;
            }
        }
        public void Add(ModuleInfo value) {
            if(!List.Contains(value))
                List.Add(value);
        }
        public void Remove(ModuleInfo value) {
            if(List.Contains(value))
                List.Remove(value);
        }
    }
    public class ModulesInfo {
        public event EventHandler CurrentModuleChanged;
        static ModulesInfo instance;
        ModuleInfoCollection collection;
        ModuleInfo currentModule;

        public ModuleInfoCollection Collection { get { return collection; } }
        public ModuleInfo CurrentModuleBase { get { return currentModule; } set { currentModule = value; } }

        public static void Add(string name, Type type, string description, string imageName, string group) {
            Add(name, type, description, imageName, group, DemoProducts.None);
        }
        public static void Add(string name, Type type, string description, string imageName, string group, DemoProducts product) {
            ModuleInfo item = new ModuleInfo(name, type, description, imageName, group, product);
            Instance.Collection.Add(item);
        }
        public static int Count { get { return instance.Collection.Count; } }
        public static ModuleInfo GetItem(int index) { return instance.Collection[index]; }
        public static ModuleInfo GetItem(string name) { return instance.Collection[name]; }
        public static void RemoveItem(string name) { 
            ModuleInfo info = GetItem(name);
            if(info != null)
                instance.Collection.Remove(info);
        }
        public static ModulesInfo Instance { get { return instance; } }
        public static ModuleInfo CurrentModuleInfo { get { return instance.currentModule; } }
        public static TutorialControlBase CurrentModule {
            get {
                if(CurrentModuleInfo != null)
                    return CurrentModuleInfo.TModule;
                return null;
            }
        }
        static ModulesInfo() {
            instance = new ModulesInfo();
        }
        public ModulesInfo() {
            this.collection = new ModuleInfoCollection();
            this.currentModule = null;
        }
        protected static void RaiseModuleChanged() {
            if(Instance.CurrentModuleChanged != null)
                Instance.CurrentModuleChanged(Instance, EventArgs.Empty);
        }
        public static void FillNavBar(NavBarControl navBar) {
            FillNavBar(navBar, NavBarGroupStyle.LargeIconsText, NavBarImage.Small);
        }
        public static void FillNavBar(NavBarControl navBar, NavBarGroupStyle groupStyle, NavBarImage groupCaptionImage) {
            if(navBar == null) return;
            navBar.BeginUpdate();
            for(int i = 0; i < Count; i++) {
                if(GetItem(i).Group == ConstStrings.Get("AboutGroup")) continue;
                NavBarItem item = new NavBarItem();
                navBar.Items.Add(item);
                item.Caption = GetItem(i).Name;
                item.SmallImage = GetItem(i).SmallImage;
                item.LargeImage = GetItem(i).LargeImage;
                item.Tag = GetItem(i);
                GetNavBarGroup(navBar, GetItem(i).Group, groupStyle, groupCaptionImage).ItemLinks.Add(new NavBarItemLink(item));
            }
            navBar.EndUpdate();
        }
        static NavBarGroup GetNavBarGroup(NavBarControl navBar, string groupName, NavBarGroupStyle groupStyle, NavBarImage groupCaptionImage) {
            foreach(NavBarGroup group in navBar.Groups)
                if(group.Caption == groupName) return group;
            NavBarGroup newGroup = navBar.Groups.Add();
            newGroup.Caption = groupName;
            newGroup.Name = groupName;
            newGroup.GroupStyle = groupStyle;
            newGroup.GroupCaptionUseImage = groupCaptionImage;
            return newGroup;
        }
    }
    public class DetailModulesCollection : CollectionBase {
        TutorialControlBase owner;
        public DetailModulesCollection(TutorialControlBase owner) {
            this.owner = owner;
        }
        public DetailBase this[int index] {
            get {
                if(List.Count > index)
                    return List[index] as DetailBase;
                return null;
            }
        }
        DetailBase IsDetailExist(DetailBase value) {
            foreach(DetailBase detail in List)
                if(detail.ID == value.ID)
                    return detail;
            return null;
        }
        public bool IsDetailExist(Guid id) {
            foreach(DetailBase detail in List)
                if(detail.ID == id) {
                    owner.ActiveDetailControl = detail;
                    return true;
                }
            return false;
        }
        public bool IsDirtyDetailExist() {
            foreach(DetailBase detail in List)
                if(detail.Dirty) return true;
            return false;
        }
        public void Add(DetailBase value) {
            DetailBase existDetail = IsDetailExist(value);
            if(existDetail == null) {
                List.Add(value);
                owner.ActiveDetailControl = value;
            }
            else {
                value.Dispose();
                owner.ActiveDetailControl = existDetail;
            }
            owner.RibbonMenuController.CalcCloseAllDetails();
        }
        public void Remove(DetailBase value) {
            int index = List.IndexOf(value);

            if(List.Contains(value))
                List.Remove(value);

            if(index != -1 && List.Count > 0) {
                if(index >= List.Count)
                    index = List.Count - 1;
                owner.ActiveDetailControl = (DetailBase)List[index];    
            }
            else 
                owner.ActiveDetailControl = null;

            if(value != null)
                value.Dispose();
            owner.RibbonMenuController.CalcCloseAllDetails();
        }
        public void RemoveAll(bool closeEditing) {
            for(int i = List.Count - 1; i >= 0; i--) {
                DetailBase temp = this[i];
                if(temp.Dirty && !closeEditing) continue;
                List.RemoveAt(i);
                temp.Dispose();
            }
            owner.ActiveDetailControl = null;
            owner.RibbonMenuController.CalcCloseAllDetails();
        }
        internal void HideDetails() {
            foreach(DetailBase detail in List)
                detail.Hide();
        }
    }
    [ToolboxItem(false)]
    public class TutorialControlBase : XtraUserControl {
        RibbonPage ribbonPage = null;
        frmMain parent = null;
        DetailModulesCollection detailModuleCollection = null;
        private string name = string.Empty;
        public frmMain ParentFormMain { 
            get { return parent; }
            set {
                if(parent != null) return;
                parent = value;
            }
        }
        public virtual bool AllowModuleChange { get { return true; } }
        public RibbonMenuController RibbonMenuController {
            get {
                if(parent != null) return parent.RibbonMenuController;
                return null;
            }
        }
        public FormLayoutManager LayoutManager {
            get {
                if(parent != null)
                    return parent.LayoutManager;
                return null;
            }
        }
        public IDXMenuManager MenuManager {
            get {
                if(parent == null) return null;
                return parent.MenuManager;
            }
        }
        public RibbonPage ActiveRibbonPage {
            get { return ribbonPage; }
            set {
                if(ribbonPage != null) return;
                ribbonPage = value;
            }
        }
        public string DetailTypeName { 
            get {
                if(ActiveDetailControl != null) return ActiveDetailControl.GetType().Name;
                return null; 
            } 
        }
        public string TypeName { get { return GetType().Name; }}
        public bool IsSuitablePage(RibbonPage page) {
            if(page.Tag == null) return false;
            if(detailModuleCollection != null) {
                foreach(DetailBase detail in detailModuleCollection)
                    if(detail.ActiveRibbonPage == page) return true;
            }
            return ActiveRibbonPage == page;
        }
        public TutorialControlBase() {
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.LookAndFeel.StyleChanged += new EventHandler(LookAndFeel_StyleChanged);
        }

        void LookAndFeel_StyleChanged(object sender, EventArgs e) {
            OnStyleChanged();
        }

        public string TutorialName {
            get { return name; }
            set { name = value; }
        }
        DetailBase activeDetailControl = null;
        public DetailBase ActiveDetailControl {
            get { return activeDetailControl; }
            set {
                if(activeDetailControl == value) {
                    UpdateActiveDetailControl();
                    return;
                }
                activeDetailControl = value;
                if(ActiveDetailControl == null) {
                    if(this.ActiveRibbonPage != null)
                        this.ActiveRibbonPage.Ribbon.SelectedPage = ActiveRibbonPage;
                    RemoveCloseDetailButton();
                }
                else {
                    CreateDetailRibbon();
                    UpdateMenu();
                    ShowActiveDetailControlRibbonPage();
                    AddCloseDetailButton();
                }
            }
        }
        internal void DumpActiveDetailControl() {
            activeDetailControl = null;
            RemoveCloseDetailButton();
        }
        internal void AddCloseDetailButton() {
            if(ActiveDetailControl == null) return;
            if(!RibbonPageHeaderItemLinkCollectionContainsBarItem(ParentFormMain.CloseButton, 
                ParentFormMain.RibbonControl.PageHeaderItemLinks))
                ParentFormMain.RibbonControl.PageHeaderItemLinks.Add(ParentFormMain.CloseButton);
        }
        internal void RemoveCloseDetailButton() {
            ParentFormMain.RibbonControl.PageHeaderItemLinks.Remove(ParentFormMain.CloseButton);
        }
        static bool RibbonPageHeaderItemLinkCollectionContainsBarItem(BarButtonItem item, RibbonPageHeaderItemLinkCollection collection) {
            foreach(BarItemLink link in collection)
                if(link.Item == item) return true;
            return false;
        }
        void UpdateActiveDetailControl() {
            if(ActiveDetailControl != null) ShowActiveDetailControlRibbonPage();
        }
        void ShowActiveDetailControlRibbonPage() {
            ActiveDetailControl.ActiveRibbonPage.Ribbon.SelectedPage = ActiveDetailControl.ActiveRibbonPage;
        }
        void CloseActiveDetailForm() {
            DetailModulesCollection.Remove(ActiveDetailControl);
        }
        protected virtual void CloseDetailForm(DialogResult result, object currentObject) {
            CloseActiveDetailForm();
        }
        protected virtual void CloseDetailFormAndReload(DialogResult result, object currentObject) {
            CloseActiveDetailForm();
        }
        protected virtual void UpdateMenu() { }
        protected virtual void CreateDetailRibbon() { }
        public bool IsDetailsExist { get { return detailModuleCollection != null && detailModuleCollection.Count > 0; } }
        public bool IsDirtyDetailsExist { 
            get {
                if(detailModuleCollection == null) return false;
                return detailModuleCollection.IsDirtyDetailExist();
            } 
        }
        public DetailModulesCollection DetailModulesCollection {
            get {
                if(detailModuleCollection == null)
                    detailModuleCollection = new DetailModulesCollection(this);
                return detailModuleCollection;
            }
        }
        protected internal void CloseAllDetails() {
            if(detailModuleCollection != null)
                detailModuleCollection.RemoveAll(IsDirtyDetailsExist && 
                    XtraMessageBox.Show(this, ConstStrings.Get("CloseCancelFormsWarning"), ConstStrings.Get("Warning"), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes);
        }
        public void ShowModuleDialog(DetailBase module) {
            ShowModuleDialog(module, false);
        }
        public void ShowModuleDialog(DetailBase module, bool readOnly) {
            module.Bounds = this.DisplayRectangle;
            module.Parent = this.Parent;
            module.Dock = DockStyle.Fill;
            DetailModulesCollection.Add(module as DetailBase);
            module.ReadOnly = readOnly;
        }
        internal bool IsDetailExist(Guid id) {
            if(detailModuleCollection == null) return false;
            return detailModuleCollection.IsDetailExist(id);
        }
        protected internal virtual void DetailSave() {
            if(ActiveDetailControl != null) ActiveDetailControl.Save();
        }
        protected internal virtual void DetailClose() {
            if(ActiveDetailControl != null) ActiveDetailControl.Close();
        }
        protected internal virtual void DetailSaveAndClose() {
            if(ActiveDetailControl != null) ActiveDetailControl.SaveAndClose();
        }
        protected virtual void OnSwitchStyle() { }
        protected virtual void OnStyleChanged() { }
        protected override void OnVisibleChanged(EventArgs e) {
            if(DesignMode) return;
            base.OnVisibleChanged(e);
            if(this.Visible) 
                DoShow();
            else 
                DoHide();
        }
        protected virtual void DoShow() { }
        protected virtual void DoHide() { }

        bool setManager = false;
        protected void AddMenuManager(IDXMenuManager manager) {
            if(setManager) return;
            AddManager(this.Controls, manager);
            setManager = true;
        }

        void AddManager(ControlCollection collection, IDXMenuManager manager) {
            foreach(Control ctrl in collection) {
                SetControlManager(ctrl, manager);
                AddManager(ctrl.Controls, manager);
            }
        }
        protected virtual void LoadFormLayout() { }
        protected virtual void SaveFormLayout() { }
        protected virtual void SetControlManager(Control ctrl, IDXMenuManager manager) { }
        protected internal virtual bool UseList { get { return true; } }

        internal void HideElements() {
            this.Hide();
            if(detailModuleCollection != null) detailModuleCollection.HideDetails();
        }
        protected virtual ChartControl MainChart { get { return null; } }
        protected virtual ChartControl AlternateChart { get { return null; } }
        protected virtual bool DisposeWhenHide { get { return false; } }
        internal bool AllowDispose {
            get {
                return DisposeWhenHide && !IsDetailsExist;
            }
        }
        public RibbonPage CurrentRibbonPage {
            get { 
                foreach(RibbonPage page in ParentFormMain.Ribbon.TotalPageCategory.Pages) 
                    if(page.Tag == this)
                        return page;
                return null;
            }
        }
        internal void ResetPibbonPage() {
            if(CurrentRibbonPage != null)
                CurrentRibbonPage.Tag = this.TypeName;
        }
        public void CheckChartStyles(ChartAppearanceManager manager) {
            WinHelper.SetChartStyle(MainChart, manager);
            WinHelper.SetChartStyle(AlternateChart, manager);
        }
        internal void ShowMasterModule() {
            ActiveDetailControl = null;             
        }
    }
}
