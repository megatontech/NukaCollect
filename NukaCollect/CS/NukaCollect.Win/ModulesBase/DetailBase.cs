using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Xpo;
using DevExpress.XtraEditors.DXErrorProvider;
using DevExpress.Utils.Menu;
using DevExpress.XtraGrid;
using NukaCollect.Win.Controls;
using NukaCollect.Helpers;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars;
using DevExpress.XtraGrid.Views.Base;
using NukaCollect.Resources;

namespace NukaCollect.Win.Modules {
    public partial class DetailBase : XtraUserControl, IFormWithLayoutManager {
        protected internal VideoRentBaseObject editObject;
        GetSessionCallback externalSession;
        UnitOfWork session;
        Form parent;
        bool dirty = false;
        bool createNewObject = false;
        CloseDetailForm closeForm = null;
        DialogResult returnResult = DialogResult.Cancel;
        RibbonPage page = null;
        Guid id = Guid.Empty;
        bool readOnly = false;
        public RibbonPage ActiveRibbonPage {
            get { return page; }
        }
        public void CreateActiveRibbonPage(RibbonPage page) {
            this.page = page.Clone() as RibbonPage;
            UpdateActiveRibbonPageCaption();
            ActiveRibbonPage.Tag = this;
            page.Ribbon.Pages.Add(ActiveRibbonPage);
            page.Category.Pages.Add(ActiveRibbonPage);
            foreach(RibbonPageGroup group in ActiveRibbonPage.Groups)
                foreach(BarButtonItemLink link in group.ItemLinks)
                    if(link.Item.Caption == ParentFormMain.HomeButton.Caption && HomeButtonCaption != string.Empty) {
                        if(link.Item.Hint != string.Empty) {
                            link.UserDefine = BarLinkUserDefines.Caption;
                            link.UserCaption = HomeButtonCaption;
                        }
                    }
        }
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
                if(ActiveRibbonPage != null)
                    ActiveRibbonPage.Dispose();
            }
            base.Dispose(disposing);
        }
        public bool ReadOnly { 
            get { return readOnly; }
            set {
                readOnly = value;
                UpdateReadOnlyData();
            } 
        }
        public frmMain ParentFormMain { get { return parent as frmMain; } }
        public Guid ID { get { return id; } }
        public DetailBase() {
            InitializeComponent();
            ElementConstStringLoader.LoadConstStringsForDetailBase(this);
        }
        public DetailBase(Form parent, GetSessionCallback session, VideoRentBaseObject editObject, IDXMenuManager manager, CloseDetailForm closeForm)
            : this() {
            this.parent = parent;
            this.externalSession = session;
            this.editObject = editObject;
            lcMain.MenuManager = manager;
            this.closeForm = closeForm;
        }
        protected virtual void SetEditObject(GetSessionCallback session, VideoRentBaseObject editObject) {
            this.externalSession = session;
            this.session = session == null ? null : new UnitOfWork(session().DataLayer);
            if(session == null && editObject == null) return;
            try {
                this.editObject = editObject != null ? SessionHelper.GetObject(editObject, this.Session) : CreateNewObject();
            } catch(ObjectDisposedException) {
                this.editObject = null;
            }
            if(this.editObject == null) {
                ShowCloseDialog = false;
                Close();
                return;
            }
            if(editObject != null) this.id = editObject.Oid;
            InitData();
        }
        protected virtual void UpdateReadOnlyData() {
            if(page != null) {
                foreach(RibbonPageGroup group in page.Groups) {
                    UpdateItemLinks(group, ReadOnly);
                    group.Visible = !IsEmpty(group);
                }
            }
            SetDefaultOptions();
            if(ReadOnly) {
                foreach(Control item in lcMain.Controls) {
                    BaseEdit be = item as BaseEdit;
                    if(be != null) be.Properties.ReadOnly = true;
                }
                ActiveRibbonPage.Text = string.Format(ConstStrings.Get("ReadOnlyCaption"), ActiveRibbonPage.Text);
            }
        }
        static bool IsEmpty(RibbonPageGroup group) {
            foreach(BarButtonItemLink link in group.ItemLinks)
                if(link.Visible) return false;
            return true;
        }
        static void UpdateItemLinks(RibbonPageGroup group, bool ReadOnly) {
            foreach(BarButtonItemLink link in group.ItemLinks)
                if("ReadOnly".Equals(link.Item.Tag))
                    link.Visible =  !ReadOnly;
        }
        public FormLayoutManager LayoutManager { 
            get { 
                if(parent is IFormWithLayoutManager)
                    return ((IFormWithLayoutManager)parent).LayoutManager;
                return null;
            }
        }
        public UnitOfWork Session { get { return session; } }        
        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            SetEditObject(externalSession, editObject);
            InitValidation();
            if(parent != null)
                this.Location = new Point(parent.Left + (parent.Width - this.Width) / 2, parent.Top + (parent.Height - this.Height) / 2);
            LoadFormLayout();
            SetDefaultOptions();
            foreach(Control item in lcMain.Controls) {
                AddControl(item);
            }
        }
        protected void AddControl(Control item) {
            BaseEdit edit = item as BaseEdit;
            if(edit != null) {
                edit.MenuManager = lcMain.MenuManager;
                edit.EditValueChanged += new EventHandler(edit_EditValueChanged);
            }
            IEditsContainer userControl = item as IEditsContainer;
            if(userControl != null) {
                userControl.EditValueChanged += new EventHandler(edit_EditValueChanged);
            }
            GridControl grid = item as GridControl;
            if(grid != null) {
                grid.MenuManager = lcMain.MenuManager;
            }
        }
        void SetDefaultOptions() {
            if(LayoutManager == null) return;
            foreach(Control item in lcMain.Controls) {
                ucGridEditBar editBar = item as ucGridEditBar;
                if(editBar != null) {
                    editBar.SetAllowEditing(LayoutManager.Properties.CurrentProperty.DefaultEditGridViewInDetailForms && !ReadOnly);
                    if(ReadOnly) editBar.DasabledButtons();
                }
            }
        }
        void edit_EditValueChanged(object sender, EventArgs e) {
            Dirty = true;
        }
        bool showCloseDialog = true;
        public bool ShowCloseDialog { get { return showCloseDialog; } set { showCloseDialog = value; } }
        public DXValidationProvider ValidationProvider { get { return dxValidationProvider; } }
        protected virtual void CloseCancelForm() { }
        protected virtual VideoRentBaseObject CreateNewObject() {
            createNewObject = true;
            return null; 
        }
        protected virtual void InitValidation() { }
        protected virtual void InitData() { }
        protected virtual void SaveData() {
            Cursor.Current = Cursors.WaitCursor;
        }
        protected void CommitSession() {
            UnitOfWork oldSession = Session;
            SessionHelper.CommitSession(oldSession, new ExceptionsProcesser(this.FindForm()));
            SetEditObject(externalSession, editObject);
            oldSession.Dispose();
        }
        protected virtual bool HasObjectToSave {
            get { 
                return Session.GetObjectsToSave().Count > (createNewObject ? 1 : 0);
            }
        }
        public virtual bool Dirty {
            get {
                return dirty || (Session != null && (HasObjectToSave || Session.GetObjectsToDelete().Count > 0));
            }
            set {
                dirty = value;
                UpdateActiveRibbonPageCaption();
            }
        }
        public void UpdateActiveRibbonPageCaption() {
            if(ActiveRibbonPage == null) return;
            ActiveRibbonPage.Text = string.Format("{0}{1}", PageCaption, Dirty ? "*" : string.Empty);
        }
        protected virtual void LoadFormLayout() {
            if(LayoutManager == null) return;
            LayoutManager.RestoreFormLayout(new FormLayoutInfo(this.GetType().Name, lcMain));
        }
        protected virtual void SaveFormLayout() {
            if(LayoutManager == null) return;
            LayoutManager.SaveFormLayout(new FormLayoutInfo(this.GetType().Name, lcMain));
        }
        protected virtual string HomeButtonCaption { get { return string.Empty; } }
        #region IDetailControl Members
        public void Close() {
            BeforeModuleClose();
            if(returnResult != DialogResult.OK) {
                if(showCloseDialog && Dirty) {
                    DialogResult result = XtraMessageBox.Show(this, ConstStrings.Get("CloseCancelFormWarning"), ConstStrings.Get("Warning"), MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                    if(result == DialogResult.Cancel) return;
                    if(result == DialogResult.Yes) Save();
                }
                else {
                    CloseCancelForm();
                }
            }
            if(Session != null) {
                this.editObject = SessionHelper.GetObject<VideoRentBaseObject>(this.editObject, externalSession());
                this.session.Dispose();
                this.session = null;
                SaveFormLayout();
                if(editObject != null) editObject.Reload();
            }
            Cursor.Current = Cursors.Default;
            if(closeForm != null) closeForm(returnResult, editObject);
            this.Dispose();
        }

        protected virtual void BeforeModuleClose() {
            foreach(Control ctrl in lcMain.Controls) {
                GridControl grid = ctrl as GridControl;
                if(grid != null) {
                    ColumnView view = grid.MainView as ColumnView;
                    if(view == null) continue;
                    view.CloseEditor();
                    view.UpdateCurrentRow();
                }
            }
        }
        protected virtual bool ValidateData() { return ValidationProvider.Validate(); }
        public bool Save() {
            BeforeModuleClose();
            if(ValidateData()) {
                SaveData();
                Dirty = false;
                returnResult = DialogResult.Yes;
                return true;
            }
            return false;
        }
        public bool SaveAndClose() {
            if(Save()) {
                returnResult = DialogResult.OK;
                Close();
                return true;
            }
            return false;
        }
        public string PageCaption { 
            get {
                int maxLength = 70;
                if(Text.Length <= maxLength)
                    return Text;
                return string.Format("{0}...", Text.Substring(0, maxLength));
            } 
        }
        protected internal virtual void LoadPicture() { }
        protected internal virtual void ClearPicture() { }
        protected internal virtual void AddPicture() { }
        protected internal virtual void DeletePicture() { }
        protected internal virtual void MovieAddItem() { }
        protected internal virtual void MovieManageItems() { }
        #endregion
        #if DebugTest
        public DialogResult ReturnResult {
            get { return returnResult; }
            set { returnResult = value; }
        }
        public void SendOnLoad() { OnLoad(EventArgs.Empty); }
        #endif
    }
    public delegate UnitOfWork GetSessionCallback();
}
