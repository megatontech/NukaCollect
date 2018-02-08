using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraLayout;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.Xpo;
using System.IO;
using DevExpress.Data.Filtering;
using System.Drawing;
using DevExpress.LookAndFeel;
using DevExpress.XtraBars.Docking;
using NukaCollect.Win.Forms;
using DevExpress.Utils.Menu;
using DevExpress.XtraNavBar;
using NukaCollect.Helpers;
using DevExpress.XtraBars.Ribbon;
using DevExpress.Utils.Serializing;
using DevExpress.Utils;
using NukaCollect.Resources;

namespace NukaCollect.Win {
    public class WinFormLayout : VideoRentBaseObject {
        public WinFormLayout(Session session) : base(session) { }
        public WinFormLayout(Session session, string name)
            : this(session) {
            Name = name;
        }
        public override void AfterConstruction() {
            base.AfterConstruction();
            MainView = true;
        }
        public string Name {
            get { return GetPropertyValue<string>("Name"); }
            set { SetPropertyValue<string>("Name", value); }
        }
        [DevExpress.Xpo.ValueConverter(typeof(RectangleValueConverter))]
        public Rectangle FormBounds {
            get { return GetPropertyValue<Rectangle>("FormBounds"); }
            set { SetPropertyValue<Rectangle>("FormBounds", value); }
        }
        public FormWindowState WindowState {
            get { return GetPropertyValue<FormWindowState>("WindowState"); }
            set { SetPropertyValue<FormWindowState>("WindowState", value); }
        }
        [DevExpress.Xpo.ValueConverter(typeof(MemoryStreamValueConverter))]
        public MemoryStream MainLayoutControlLayout {
            get { return GetPropertyValue<MemoryStream>("MainLayoutControlLayout"); }
            set { SetPropertyValue<MemoryStream>("MainLayoutControlLayout", value); }
        }
        [DevExpress.Xpo.ValueConverter(typeof(MemoryStreamValueConverter))]
        public MemoryStream MainColumnViewLayout {
            get { return GetPropertyValue<MemoryStream>("MainColumnViewLayout"); }
            set { SetPropertyValue<MemoryStream>("MainColumnViewLayout", value); }
        }
        [DevExpress.Xpo.ValueConverter(typeof(MemoryStreamValueConverter))]
        public MemoryStream AlternateColumnViewLayout {
            get { return GetPropertyValue<MemoryStream>("AlternateColumnViewLayout"); }
            set { SetPropertyValue<MemoryStream>("AlternateColumnViewLayout", value); }
        }
        [DevExpress.Xpo.ValueConverter(typeof(MemoryStreamValueConverter))]
        public MemoryStream MainDockingLayout {
            get { return GetPropertyValue<MemoryStream>("MainDockingLayout"); }
            set { SetPropertyValue<MemoryStream>("MainDockingLayout", value); }
        }
        [DevExpress.Xpo.ValueConverter(typeof(MemoryStreamValueConverter))]
        public MemoryStream QuickAccessToolbar {
            get { return GetPropertyValue<MemoryStream>("QuickAccessToolbar"); }
            set { SetPropertyValue<MemoryStream>("QuickAccessToolbar", value); }
        }
        public bool MainView {
            get { return GetPropertyValue<bool>("MainView"); }
            set { SetPropertyValue<bool>("MainView", value); }
        }
    }
    public class WinFormProperty : VideoRentBaseObject {
        public WinFormProperty(Session session) : base(session) { }
        public override void AfterConstruction() {
            base.AfterConstruction();
            AllowRestoreFormLayout = true;
            AllowRestoreLayoutControlLayout = true;
            AllowRestoreGridViewLayout = true;
            AllowRestoreDockingLayout = true;
            DefaultEditGridViewInDetailForms = true;
            NavPaneState = NavPaneState.Expanded;
        }
        public bool AllowRestoreFormLayout {
            get { return GetPropertyValue<bool>("AllowRestoreFormLayout"); }
            set { SetPropertyValue<bool>("AllowRestoreFormLayout", value); }
        }
        public bool AllowRestoreLayoutControlLayout {
            get { return GetPropertyValue<bool>("AllowRestoreLayoutControlLayout"); }
            set { SetPropertyValue<bool>("AllowRestoreLayoutControlLayout", value); }
        }
        public bool AllowRestoreGridViewLayout {
            get { return GetPropertyValue<bool>("AllowRestoreGridViewLayout"); }
            set { SetPropertyValue<bool>("AllowRestoreGridViewLayout", value); }
        }
        public bool AllowRestoreDockingLayout {
            get { return GetPropertyValue<bool>("AllowRestoreDockingLayout"); }
            set { SetPropertyValue<bool>("AllowRestoreDockingLayout", value); }
        }
        public bool DefaultEditGridViewInDetailForms {
            get { return GetPropertyValue<bool>("DefaultEditGridViewInDetailForms"); }
            set { SetPropertyValue<bool>("DefaultEditGridViewInDetailForms", value); }
        }
        public string DefaultSkinName {
            get { return GetPropertyValue<string>("DefaultSkinName"); }
            set { SetPropertyValue<string>("DefaultSkinName", value); }
        }
        public string ChartPaletteAppearance {
            get { return GetPropertyValue<string>("ChartPaletteAppearance"); }
            set { SetPropertyValue<string>("ChartPaletteAppearance", value); }
        }
        [Size(SizeAttribute.Unlimited)]
        public string ImagePath {
            get { return GetPropertyValue<string>("ImagePath"); }
            set { SetPropertyValue<string>("ImagePath", value); }
        }
        public Guid CurrentCustomerId {
            get { return GetPropertyValue<Guid>("CurrentCustomerId"); }
            set { SetPropertyValue<Guid>("CurrentCustomerId", value); }
        }
        public NavPaneState NavPaneState {
            get { return GetPropertyValue<NavPaneState>("NavPaneState"); }
            set { SetPropertyValue<NavPaneState>("NavPaneState", value); }
        }
    }
    public delegate void SetCustomerInfoDelegate(string caption);
    public class FormLayoutInfo {
        string name;
        Form form;
        LayoutControl layoutControl;
        ColumnView view;
        DockManager dockManager;
        ColumnView alternateView;
        RibbonQuickAccessToolbar toolbar;
        public FormLayoutInfo(Form form) : this(form, null) { }
        public FormLayoutInfo(Form form, LayoutControl layoutControl, RibbonQuickAccessToolbar toolbar) : this(string.Empty, form, layoutControl, null, null, null, toolbar) { }
        public FormLayoutInfo(string name, ColumnView view) : this(name, null, null, view, null) { }
        public FormLayoutInfo(string name, LayoutControl layoutControl) : this(name, null, layoutControl, null, null) { }
        public FormLayoutInfo(string name, ColumnView view, DockManager dockManager) : this(name, null, null, view, dockManager) { }
        public FormLayoutInfo(Form form, LayoutControl layoutControl) : this(string.Empty, form, layoutControl, null, null) { }
        public FormLayoutInfo(string name, Form form, LayoutControl layoutControl, ColumnView view, DockManager dockManager) : this(name, form, layoutControl, view, null, dockManager, null) { }
        public FormLayoutInfo(string name, Form form, LayoutControl layoutControl, ColumnView view, ColumnView alternateView, DockManager dockManager, RibbonQuickAccessToolbar toolbar) {
            this.name = name;
            this.form = form;
            this.layoutControl = layoutControl;
            this.view = view;
            this.alternateView = alternateView;
            this.dockManager = dockManager;
            this.toolbar = toolbar;
        }
        public string Name {
            get {
                if(!string.IsNullOrEmpty(name)) return name;
                if(form != null) return form.Name;
                return string.Empty;
            }
        }
        public Form Form { get { return form; } }
        public LayoutControl LayoutControl { get { return layoutControl; } }
        public ColumnView ColumnView { get { return view; } }
        public ColumnView AlternateColumnView { get { return alternateView; } }
        public DockManager DockManager { get { return dockManager; } }
        public RibbonQuickAccessToolbar QuickAccessToolbar { get { return toolbar; } }
        public bool ShowMainView {
            get {
                return ColumnView != null && ColumnView.GridControl.MainView == ColumnView;
            }
        }
    }
    public interface IFormWithLayoutManager {
        FormLayoutManager LayoutManager { get; }
    }
    public class FormLayoutManager {
        UnitOfWork session;
        UnitOfWork dataSession;
        WinFormProperties properties;
        SetCustomerInfoDelegate setCustomerInfo;
        Customer currentCustomer;
        public event EventHandler CurrentCustomerChanged;
        public FormLayoutManager(IDataLayer layer, SetCustomerInfoDelegate setInfo, UnitOfWork dataSession) {
            this.session = new UnitOfWork(layer);
            properties = new WinFormProperties(this.session);
            this.setCustomerInfo = setInfo;
            this.dataSession = dataSession;
            SetCustomerExample();
        }
        void RaiseCurrentCustomerChanged() {
            if(CurrentCustomerChanged != null)
                CurrentCustomerChanged(CurrentCustomer, EventArgs.Empty); 
        }
        public Customer GetCustomer(Customer customer) {
            return SessionHelper.GetObject(customer, dataSession);
        }
        public Customer CurrentCustomer {
            get {
                return currentCustomer; 
            }
            set {
                if(object.Equals(currentCustomer, value)) return;
                currentCustomer = value;
                SetCustomerExample();
                setCustomerInfo(string.Format(ConstStrings.Get("CurrentCustomerInfo"), 
                    currentCustomer == null ? ConstStrings.Get("Nothing") : currentCustomer.FullName));
                RaiseCurrentCustomerChanged();
            }
        }
        public Guid CurrentCustomerId {
            get {
                if(CurrentCustomer == null) return Guid.Empty;
                return CurrentCustomer.Oid;
            }
        }
        public UnitOfWork Session { get { return session; } }
        public WinFormProperties Properties { get { return properties; } }
        
        public static MemoryStream SaveControlLayout(ISupportXtraSerializer control) {
            if(control == null) return null;
            MemoryStream stream = new System.IO.MemoryStream();
            control.SaveLayoutToStream(stream);
            return stream;
        }
        public static void RestoreControlLayout(MemoryStream layout, ISupportXtraSerializer control) {
            if(layout == null || layout == MemoryStream.Null || control == null) return;
            layout.Seek(0, SeekOrigin.Begin);
            control.RestoreLayoutFromStream(layout);
        }
        public void SaveFormLayout(FormLayoutInfo info) {
            WinFormLayout layout = Session.FindObject<WinFormLayout>(CriteriaOperator.Parse("Name = ? and CreatedBy = ?", info.Name, VideoRentCurrentUser.GetCurrentUser(Session)));
            if(layout == null)
                layout = new WinFormLayout(Session, info.Name);
            if(info.Form != null) {
                layout.WindowState = info.Form.WindowState;
                if(info.Form.WindowState == FormWindowState.Maximized) {
                    layout.FormBounds = info.Form.RestoreBounds;
                }
                else {
                    layout.FormBounds = info.Form.Bounds;
                }
            }
            layout.MainLayoutControlLayout = SaveControlLayout(info.LayoutControl);
            layout.MainColumnViewLayout = SaveControlLayout(info.ColumnView);
            layout.AlternateColumnViewLayout = SaveControlLayout(info.AlternateColumnView);
            layout.MainDockingLayout = SaveControlLayout(info.DockManager);
            layout.QuickAccessToolbar = SaveControlLayout(info.QuickAccessToolbar);
            layout.MainView = info.ShowMainView;
            SessionHelper.CommitSession(Session, new ExceptionsProcesser(null));
        }
        public void RestoreFormLayout(FormLayoutInfo info) {
            WinFormLayout layout = Session.FindObject<WinFormLayout>(CriteriaOperator.Parse("Name = ? and CreatedBy = ?", info.Name, VideoRentCurrentUser.GetCurrentUser(Session)));
            if(layout == null) return;
            if(Properties.CurrentProperty.AllowRestoreLayoutControlLayout)
                RestoreControlLayout(layout.MainLayoutControlLayout, info.LayoutControl);
            if(Properties.CurrentProperty.AllowRestoreGridViewLayout) {
                RestoreControlLayout(layout.MainColumnViewLayout, info.ColumnView);
                RestoreControlLayout(layout.AlternateColumnViewLayout, info.AlternateColumnView);
            }
            if(Properties.CurrentProperty.AllowRestoreDockingLayout)
                RestoreControlLayout(layout.MainDockingLayout, info.DockManager);
            RestoreControlLayout(layout.QuickAccessToolbar, info.QuickAccessToolbar);
            if(info.ColumnView != null && info.AlternateColumnView != null && !layout.MainView)
                info.ColumnView.GridControl.MainView = info.AlternateColumnView;
            if(!layout.FormBounds.IsEmpty && info.Form != null && Properties.CurrentProperty.AllowRestoreFormLayout) {
                info.Form.Size = layout.FormBounds.Size;
                info.Form.Location = ControlUtils.CalcFormLocation(layout.FormBounds.Location, layout.FormBounds.Size);
                info.Form.WindowState = layout.WindowState;
            }
        }

        internal void ClearLayouts() {
            Cursor.Current = Cursors.WaitCursor;
            XPCollection<WinFormLayout> xpLayouts = new XPCollection<WinFormLayout>(Session, CriteriaOperator.Parse("CreatedBy = ?", VideoRentCurrentUser.GetCurrentUser(Session)));
            foreach(WinFormLayout layout in xpLayouts) {
                layout.FormBounds = Rectangle.Empty;
                layout.MainLayoutControlLayout = null;
                layout.MainColumnViewLayout = null;
                layout.AlternateColumnViewLayout = null;
                layout.MainDockingLayout = null;
                layout.MainView = true;
            }
            SessionHelper.CommitSession(Session, new ExceptionsProcesser(null));
        }
        public void ShowOpenImageDialog(NukaCollect.Win.Forms.frmOpenImageDialog.SetImageDelegate imageDelegate, Form parent) {
            using(frmOpenImageDialog form = new frmOpenImageDialog(imageDelegate, this)) {
                form.CurrentPath = Properties.ImagePath;
                form.ShowDialog(parent);
                Properties.ImagePath = form.CurrentPath;
            }
        }
        internal void SetDefaultCurrentCustomer(UnitOfWork session) {
            CurrentCustomer = session.GetObjectByKey<Customer>(Properties.CurrentProperty.CurrentCustomerId);
        }
        void SetCustomerExample() {
            if(CurrentCustomer == null)
                CurrentCustomer = dataSession.FindObject<Customer>(CriteriaOperator.Parse("[FirstName] = 'Essie'"));
            if(CurrentCustomer == null)
                CurrentCustomer = dataSession.FindObject<Customer>(null);
        }
        public void ShowFindCustomerForm(Form parent, IDXMenuManager menuManager) {
            ShowFindCustomerForm(parent, menuManager, CurrentCustomer != null);
        }
        public void ShowFindCustomerForm(Form parent, IDXMenuManager menuManager, bool showClear) {
            Cursor.Current = Cursors.WaitCursor;
            using(frmFindCustomer form = new frmFindCustomer(this, menuManager, dataSession, showClear)) {
                ObjectHelper.SetFormContainerSize(form, ((frmMain)parent).ChildContainer);
                ObjectHelper.ShowFormDialog(form, parent);
            }
        }
        bool MoveCustomer(bool prev) {
            XPCollection<Customer> customers = new XPCollection<Customer>(dataSession, null, new SortProperty("CustomerId", DevExpress.Xpo.DB.SortingDirection.Ascending));
            int index = customers.IndexOf(CurrentCustomer);
            if(index == -1) return false;
            index = prev ? index-=1 : index+=1;
            if(index > customers.Count - 1) index = 0;
            if(index < 0) index = customers.Count - 1;
            CurrentCustomer = customers[index];
            return true;
        }
        internal void NextCustomer() {
            MoveCustomer(false);
        }
        internal void PrevCustomer() {
            MoveCustomer(true);
        }
        internal bool AllowPrevCustomer { get { return new XPCollection<Customer>(dataSession).Count > 0; } }
        internal bool AllowNextCustomer { get { return AllowPrevCustomer; } }
    }
    public class WinFormProperties {
        UnitOfWork session;
        public WinFormProperties(UnitOfWork session) {
            this.session = session;
        }
        public UnitOfWork Session { get { return session; } }
        public WinFormProperty CurrentProperty {
            get {
                WinFormProperty wfProperty = Session.FindObject<WinFormProperty>(CriteriaOperator.Parse("CreatedBy = ?", VideoRentCurrentUser.GetCurrentUser(Session)));
                if(wfProperty == null) {
                    wfProperty = new WinFormProperty(Session);
                    Save();
                }
                return wfProperty;
            }
        }
        public void Save() {
            SessionHelper.CommitSession(Session, new ExceptionsProcesser(null));
        }
        public void LoadDefaultSkin() {
            if(CurrentProperty.DefaultSkinName == null) return;
            string[] lfName = CurrentProperty.DefaultSkinName.Split('@');
            if(lfName.Length < 2) return;
            switch(lfName[0]) { 
                case "WindowsXP":
                    UserLookAndFeel.Default.SetWindowsXPStyle();
                    break;
                case "Office2003":
                    UserLookAndFeel.Default.SetOffice2003Style();
                    break;
                case "Flat":
                    UserLookAndFeel.Default.SetFlatStyle();
                    break;
                case "Style3D":
                    UserLookAndFeel.Default.SetStyle3D();
                    break;
                case "UltraFlat":
                    UserLookAndFeel.Default.SetUltraFlatStyle();
                    break;
                default:
                    UserLookAndFeel.Default.SetSkinStyle(lfName[1]);
                    break;
            }
        }
        public void LoadChartPaletteAppearance(ChartAppearanceManager chartManager) {
            string[] styles = null;
            if (CurrentProperty.ChartPaletteAppearance == null)
            {
                styles = "Solstice@Default@0".Split('@');
            }
            else
            {
                styles = CurrentProperty.ChartPaletteAppearance.Split('@');
            }
            if (styles.Length < 3) return;
            chartManager.AppearanceName = styles[1];
            chartManager.ColorIndex = Convert.ToInt32(styles[2]);
            chartManager.PaletteName = styles[0];
            chartManager.UpdateCurrentPalette();
            chartManager.UpdateCurrentAppearance();
        }
        void SaveDefaultSkin() {
            CurrentProperty.DefaultSkinName = string.Format("{0}@{1}",
                UserLookAndFeel.Default.ActiveStyle,
                UserLookAndFeel.Default.ActiveSkinName);
        }
        void SaveChartAppearences(ChartAppearanceManager chartManager) {
            CurrentProperty.ChartPaletteAppearance = string.Format("{0}@{1}@{2}",
                chartManager.PaletteName, chartManager.AppearanceName, chartManager.ColorIndex);
        }
        public string ImagePath {
            get { return CurrentProperty.ImagePath; }
            set {
                if(CurrentProperty.ImagePath == value) return;
                CurrentProperty.ImagePath = value;
                Save();
            }
        }
        void SaveCurrentCustomer(FormLayoutManager manager) {
            CurrentProperty.CurrentCustomerId = manager.CurrentCustomer == null ? Guid.Empty : manager.CurrentCustomer.Oid;
        }
        void SaveNavPaneState(NavPaneState state) {
            CurrentProperty.NavPaneState = state;
        }

        public void SaveDefaultProperties(FormLayoutManager manager, NavPaneState state, ChartAppearanceManager chartManager) {
            SaveDefaultSkin();
            SaveCurrentCustomer(manager);
            SaveNavPaneState(state);
            SaveChartAppearences(chartManager);
            Save();
        }
    }
    public enum PeriodType { All, Receipt, KPI }
    public class PeriodManager {
        static Period receiptPeriod, kpiPeriod;

        public static Period ReceiptPeriod {
            get {
                if(receiptPeriod == null)
                    receiptPeriod = new Period(-12);
                return receiptPeriod;
            }
        }
        public static Period KPIPeriod {
            get {
                if(kpiPeriod == null)
                    kpiPeriod = new Period(-24);
                return kpiPeriod;
            }
        }
    }
    public class Period {
        DateTime startDate;
        DateTime endDate;
        public Period(int months) {
            SetStartDate(DateTime.Today.AddMonths(months));
            SetEndDate(DateTime.Now);
        }
        void SetStartDate(DateTime date) {
            startDate = new DateTime(date.Year, date.Month, date.Day, 0, 0, 0);
        }
        void SetEndDate(DateTime date) {
            if(date < startDate)
                date = startDate;
            endDate = new DateTime(date.Year, date.Month, date.Day, 23, 59, 59);
        }
        public DateTime StartDate {
            get { return startDate; }
            set { SetStartDate(value); }
        }
        public DateTime EndDate {
            get { return endDate; }
            set { SetEndDate(value); }
        }
    }
}
