using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars.Ribbon;
using System.Runtime.InteropServices;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraNavBar;
using DevExpress.Utils.Menu;
using NukaCollect.Resources;

namespace NukaCollect.Win {
    public partial class frmMainBase : RibbonForm {
        [DllImport("kernel32.dll")]
        public static extern bool SetProcessWorkingSetSize(IntPtr handle,
            int minimumWorkingSetSize, int maximumWorkingSetSize);
        public frmMainBase() {
            InitializeComponent();
            ElementConstStringLoader.LoadConstStringsForFrmMainBase(this);
            nbMain.SelectedLinkChanged += new DevExpress.XtraNavBar.ViewInfo.NavBarSelectedLinkChangedEventHandler(nbMain_SelectedLinkChanged);
            nbMain.CustomDrawGroupCaption += new DevExpress.XtraNavBar.ViewInfo.CustomDrawNavBarElementEventHandler(nbMain_CustomDrawGroupCaption);
            nbMain.LinkClicked += new NavBarLinkEventHandler(nbMain_LinkClicked);
            nbMain.MenuManager = rcMain.Manager;
            InitRibbonElementsImages();
        }
        public PanelControl MainContainer { get { return pnlMainContainer; } }
        void InitRibbonElementsImages() {
            bbiAbout.LargeGlyph = ElementHelper.GetImage("Info", ImageSize.Large32);
            bbiAbout.Glyph = ElementHelper.GetImage("Info", ImageSize.Small16);
        }
        public PanelControl ChildContainer { get { return pnlControl; } }
        public IDXMenuManager MenuManager { get { return rcMain.Manager; } }
        public RibbonControl RibbonControl { get { return rcMain; } }
        public NavBarControl NavigationBar { get { return nbMain; } }
        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            RegisterTutorials();
            FillNavBar();
            ModuleInfo info = ModulesInfo.GetItem(0);
            if(info == null) return;
            ShowModule(info.Name);
        }
        protected internal RibbonStatusBar MainStatusBar { get { return rsbMain; } }
        protected virtual string DemoName { get { return "BaseForm"; } }
        protected virtual void RegisterTutorials() { }
        protected virtual void FillNavBar() {
            ModulesInfo.FillNavBar(nbMain);
            InitMenu();
        }
        protected virtual void InitMenu() { }
        string prevModuleName = string.Empty;
        public void ShowModule(string name) {
            if(ModulesInfo.Instance.CurrentModuleBase != null) prevModuleName = ModulesInfo.Instance.CurrentModuleBase.Name;
            pnlControl.Parent.SuspendLayout();
            pnlControl.SuspendLayout();
            ShowModule(name, pnlControl);
            this.StatusBar.Visible = name != ConstStrings.Get("AboutGroup");
            TutorialControlBase currentModule = ModulesInfo.Instance.CurrentModuleBase.TModule as TutorialControlBase;
            try {
                if(currentModule == null) return;
                Text = string.Format("{0} - {1}", ElementHelper.GetSingleLineString(name), DemoName);
            }
            finally {
                pnlControl.ResumeLayout();
                pnlControl.Parent.ResumeLayout();
                currentModule.Invalidate();
                SetProcessWorkingSetSize(System.Diagnostics.Process.GetCurrentProcess().Handle, -1, -1);
            }
        }
        protected virtual void ShowModule(string name, PanelControl parent) { }
        NavBarItemLink prevLink = null;
        void nbMain_SelectedLinkChanged(object sender, DevExpress.XtraNavBar.ViewInfo.NavBarSelectedLinkChangedEventArgs e) {
            if(e.Link == null) return;
            if(ModulesInfo.Instance.CurrentModuleBase.TModule.AllowModuleChange) {
                ShowModule(e.Link.Caption);
                prevLink = e.Link;
            }
            else {
                nbMain.SelectedLink = prevLink;
            }
        }
        void nbMain_LinkClicked(object sender, NavBarLinkEventArgs e) {
            if(ModulesInfo.CurrentModule == null || e.Link == null) return;
            ModuleInfo info = e.Link.Item.Tag as ModuleInfo;
            if(info == null) return;
            if(ModulesInfo.CurrentModule.Name == info.TypeName)
                ModulesInfo.CurrentModule.ShowMasterModule();
        }
        public void ResetNavbarSelectedLink() {
            nbMain.SelectedLink = null;
        }
        protected override void OnKeyDown(KeyEventArgs e) {
            base.OnKeyDown(e);
            if(prevModuleName == string.Empty) return;
            bool isAbout = ModulesInfo.Instance.CurrentModuleBase.Name == ModulesInfo.GetItem(0).Name;
            if(e.KeyData == Keys.F1 && !isAbout) {
                ShowModule(ModulesInfo.GetItem(0).Name);
                ResetNavbarSelectedLink();
            }
            if(e.KeyData == Keys.Escape && isAbout) {
                ShowModule(prevModuleName);
                if(prevLink != null) nbMain.SelectedLink = prevLink;
            }
        }
        protected virtual void nbMain_CustomDrawGroupCaption(object sender, DevExpress.XtraNavBar.ViewInfo.CustomDrawNavBarElementEventArgs e) {}
        public void SetUserInfo(string caption) { bsUser.Caption = caption; }
        public void SetDataInfo(string caption) { bsData.Caption = caption; }

        private void nbMain_Resize(object sender, EventArgs e) {
            pnlMainContainer.Width = ((Control)sender).Width + pnlMainContainer.Padding.Left;
        }

        private void bbiAbout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            frmAbout.ShowAbout(this);
        }
    }
}
