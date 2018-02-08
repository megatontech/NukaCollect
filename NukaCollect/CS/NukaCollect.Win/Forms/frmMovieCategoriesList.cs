using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Xpo;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.Utils.Menu;
using NukaCollect.Win.Controls;
using DevExpress.XtraLayout;
using DevExpress.XtraGrid;
using System.Collections;
using DevExpress.Data.Filtering;
using NukaCollect.Helpers;
using NukaCollect.Resources;

namespace NukaCollect.Win.Forms {
    public partial class frmMovieCategoriesList : XtraForm, IFormWithLayoutManager {
        Form parent;
        UnitOfWork session;
        bool dirty;
        bool rowChangeDoOnce = false;
        bool categoryWasChanged;
        public frmMovieCategoriesList(Form parent, UnitOfWork session, IDXMenuManager manager)
            : base() {
            InitializeComponent();
            ElementConstStringLoader.LoadConstStringsForFrmMovieCategoriesList(this);
            this.parent = parent;
            this.session = new UnitOfWork(session.DataLayer);
            this.lcMain.MenuManager = manager;
            InitData();
            LoadFormLayout();
            foreach(Control item in lcMain.Controls)
                AddControl(item);
            bbiAdd.Glyph = ImagesHelper.Current.BarImages.Images[0];
            bbiDelete.Glyph = ImagesHelper.Current.BarImages.Images[2];
            ucMovieCategoryDetail.SetLayoutManager(manager);
        }
        public FormLayoutManager LayoutManager {
            get {
                if(parent is IFormWithLayoutManager)
                    return ((IFormWithLayoutManager)parent).LayoutManager;
                return null;
            }
        }
        public bool CategoryWasChanged { get { return categoryWasChanged; } }
        protected void AddControl(Control item) {
            BaseEdit edit = item as BaseEdit;
            if(edit != null) {
                edit.MenuManager = lcMain.MenuManager;
                edit.EditValueChanged += new EventHandler(edit_EditValueChanged);
            }
            IEditsContainer editsContainer = item as IEditsContainer;
            if(editsContainer != null) editsContainer.EditValueChanged += new EventHandler(edit_EditValueChanged);
            GridControl grid = item as GridControl;
            if(grid != null) grid.MenuManager = lcMain.MenuManager;
        }
        void InitData() {
            gcCategories.DataSource = new XPCollection<MovieCategory>(session);
            ucMovieCategoryDetail.SetFocus();
            categoryWasChanged = false;
        }
        void SaveData() {
            SessionHelper.CommitSession(session, null);
            Cursor.Current = Cursors.Default;
        }
        protected virtual void LoadFormLayout() {
            if(LayoutManager == null) return;
            LayoutManager.RestoreFormLayout(new FormLayoutInfo(this, lcMain));
        }
        protected virtual void SaveFormLayout() {
            if(LayoutManager == null) return;
            LayoutManager.SaveFormLayout(new FormLayoutInfo(this, lcMain));
        }
        MovieCategory CurrentCategory {
            get {
                if(gvCategories.FocusedRowHandle < 0) {
                    return null;
                }
                return gvCategories.GetRow(gvCategories.FocusedRowHandle) as MovieCategory;
            }
        }
        bool Dirty { get { return dirty || session.GetObjectsToSave().Count != 0 || session.GetObjectsToDelete().Count != 0; } }
        void ShowCurrentCategory(bool save) {
            if(save) ucMovieCategoryDetail.SaveData();
            bool dirtySave = dirty;
            ucMovieCategoryDetail.Init(CurrentCategory, AllCategories);
            dirty = dirtySave;
        }
        void FocusedRowChanged(int rowHandle) {
            if(rowChangeDoOnce) {
                rowChangeDoOnce = false;
                return;
            }
            if(!ucMovieCategoryDetail.ValidateData()) {
                rowChangeDoOnce = true;
                if(rowHandle >= 0)
                    gvCategories.FocusedRowHandle = rowHandle;
                return;
            }
            if(CurrentCategory == null || !CurrentCategory.IsDefault) bbiDelete.Enabled = true;
            else bbiDelete.Enabled = false;
            if(CurrentCategory != null) ShowCurrentCategory(rowHandle >= 0);
            categoryWasChanged = true;
        }
        private void gvCategories_ColumnFilterChanged(object sender, EventArgs e) {
            FocusedRowChanged(-1);
        }
        private void gvCategories_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e) {
            if(lockUpdate) return;
            FocusedRowChanged(e.PrevFocusedRowHandle);
        }
        private XPCollection<MovieCategory> AllCategories { get { return (XPCollection<MovieCategory>)gcCategories.DataSource; } }
        bool lockUpdate = false;
        private void bbiAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            if(!ucMovieCategoryDetail.ValidateData()) return;
            lockUpdate = true;
            MovieCategory category = ucMovieCategoryDetail.CreateNewMovieCategory(session, AllCategories);
            try {
                AllCategories.Add(category);
            }
            finally {
                lockUpdate = false;
            }
            WinHelper.GridViewFocusObject(gvCategories, category);
            ucMovieCategoryDetail.SetFocus();
        }
        private void bbiDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            if(CurrentCategory == null || CurrentCategory.IsDefault) return;
            gvCategories.HideEditor();
            gvCategories.UpdateCurrentRow();
            if(ObjectHelper.SafeDelete(this.FindForm(), CurrentCategory, false))
                FocusedRowChanged(-1);
        }
        void edit_EditValueChanged(object sender, EventArgs e) {
            dirty = true;
        }
        private void sbSave_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.OK;
            Close();
        }
        private void frmMovieCategoriesList_FormClosing(object sender, FormClosingEventArgs e) {
            if(DialogResult == DialogResult.OK) {
                if(!ucMovieCategoryDetail.ValidateData()) {
                    e.Cancel = true;
                    return;
                }
                ucMovieCategoryDetail.SaveData();
                Cursor.Current = Cursors.WaitCursor;
                SaveData();
            } else {
                if(Dirty) {
                    DialogResult result = XtraMessageBox.Show(this, ConstStrings.Get("CloseCancelFormWarning"), ConstStrings.Get("Warning"), MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                    if(result == DialogResult.Cancel) {
                        e.Cancel = true;
                        return;
                    }
                    if(result == DialogResult.Yes) {
                        DialogResult = DialogResult.OK;
                        Close();
                        return;
                    }
                }
            }
            this.session.Dispose();
            this.session = null;
            SaveFormLayout();
        }
    }
}
