using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Xpo;
using NukaCollect.Win.Controls;
using DevExpress.Utils.Menu;
using DevExpress.XtraGrid;
using NukaCollect.Helpers;
using NukaCollect.Resources;

namespace NukaCollect.Win.Forms {
    public partial class frmNewMovieCategory : XtraForm {
        Form parent;
        XPCollection<MovieCategory> allCategories;
        NestedUnitOfWork session;
        MovieCategory movieCategory;
        IDXMenuManager menuManager;
        bool dirty = false;
        bool createNewObject = true;
        public frmNewMovieCategory(Form parent, XPCollection<MovieCategory> allCategories, IDXMenuManager menuManager) {
            InitializeComponent();
            ElementConstStringLoader.LoadConstStringsForFrmNewMovieCategory(this);
            this.parent = parent;
            this.allCategories = allCategories;
            this.session = allCategories.Session.BeginNestedUnitOfWork();
            this.menuManager = menuManager;
            this.movieCategory = CreateNewCategory();
            ucMovieCategoryDetail.SetLayoutManager(menuManager);
            ucMovieCategoryDetail.Init(this.movieCategory, allCategories);
            AddControl(ucMovieCategoryDetail);
        }
        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            if(parent != null) this.Location = new Point(parent.Left + (parent.Width - this.Width) / 2, parent.Top + (parent.Height - this.Height) / 2);
            LoadFormLayout();
        }
        public MovieCategory MovieCategory { get { return movieCategory; } }
        protected void AddControl(Control item) {
            BaseEdit edit = item as BaseEdit;
            if(edit != null) {
                edit.MenuManager = menuManager;
                edit.EditValueChanged += new EventHandler(edit_EditValueChanged);
            }
            IEditsContainer editsContainer = item as IEditsContainer;
            if(editsContainer != null) editsContainer.EditValueChanged += new EventHandler(edit_EditValueChanged);
            GridControl grid = item as GridControl;
            if(grid != null) grid.MenuManager = menuManager;
        }
        protected virtual bool HasObjectToSave {
            get {
                return session.GetObjectsToSave().Count > (createNewObject ? 1 + Enum.GetValues(typeof(MovieItemFormat)).Length : 0);
            }
        }
        private bool Dirty {
            get {
                return dirty || (session != null && (HasObjectToSave || session.GetObjectsToDelete().Count > 0));
            }
        }
        private void edit_EditValueChanged(object sender, EventArgs e) {
            dirty = true;
        }
        private MovieCategory CreateNewCategory() {
            return ucMovieCategoryDetail.CreateNewMovieCategory(session, allCategories);
        }
        private void frmNewCategory_FormClosing(object sender, FormClosingEventArgs e) {
            if(DialogResult == DialogResult.OK) {
                if(!ucMovieCategoryDetail.ValidateData()) {
                    e.Cancel = true;
                    return;
                }
                Cursor.Current = Cursors.WaitCursor;
                ucMovieCategoryDetail.SaveData();
                session.CommitChanges();
                Cursor.Current = Cursors.Default;

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
                movieCategory = null;
            }
            movieCategory = SessionHelper.GetObject<MovieCategory>(movieCategory, session.Parent);
            allCategories.Add(movieCategory);
            session.Dispose();
            SaveFormLayout();
        }
        protected virtual void LoadFormLayout() {
            if(LayoutManager == null) return;
            LayoutManager.RestoreFormLayout(new FormLayoutInfo(this, null));
        }
        protected virtual void SaveFormLayout() {
            if(LayoutManager == null) return;
            LayoutManager.SaveFormLayout(new FormLayoutInfo(this, null));
        }
        public FormLayoutManager LayoutManager {
            get {
                if(parent is IFormWithLayoutManager)
                    return ((IFormWithLayoutManager)parent).LayoutManager;
                return null;
            }
        }
    }
}
