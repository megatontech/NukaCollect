using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Xpo;
using DevExpress.XtraBars.Docking;
using NukaCollect.Win.Forms;
using NukaCollect.Resources;

namespace NukaCollect.Win.Controls {
    public partial class ucScreens : XtraUserControl {
        XPCollection<MoviePicture> pictures;
        DockPanel parent;
        Movie currentMovie;
        Form parentForm;
        public ucScreens() {
            InitializeComponent();
            ElementConstStringLoader.LoadConstStringsForUCScreens(this);
            bbiAdd.Glyph = ImagesHelper.Current.BarImages.Images[0];
            bbiDelete.Glyph = ImagesHelper.Current.BarImages.Images[2];
        }
        public void InitParent(DockPanel panel) {
            this.parent = panel;
            parent.DockChanged += new EventHandler(parent_DockChanged);
        }
        public FormLayoutManager LayoutManager {
            get {
                if(parentForm is frmMain)
                    return ((frmMain)parentForm).LayoutManager;
                return null;
            }
        }
        void parent_DockChanged(object sender, EventArgs e) {
            layoutView1.OptionsView.ViewMode = (parent.Dock == DockingStyle.Left || parent.Dock == DockingStyle.Right) ?
                DevExpress.XtraGrid.Views.Layout.LayoutViewMode.Column :
                DevExpress.XtraGrid.Views.Layout.LayoutViewMode.Row;
        }
        MoviePicture CurrentMoviePicture {
            get {
                return layoutView1.GetRow(layoutView1.FocusedRowHandle) as MoviePicture;
            }
        }
        public void InitData(XPCollection<MoviePicture> pictures, Movie movie, Form parentForm) {
            this.pictures = pictures;
            this.currentMovie = movie;
            this.parentForm = parentForm;
            UpdateCaption();
            gridControl1.DataSource = pictures;
            ShowFocusRect();
            InitButtons();
        }

        void UpdateCaption() {
            parent.Text = pictures == null ? ConstStrings.Get("PhotoGallery") : string.Format("{0} ({1})", ConstStrings.Get("PhotoGallery"), pictures.Count);
        }

        private void layoutView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e) {
            InitButtons();
        }

       void InitButtons() {
           bbiDelete.Enabled = CurrentMoviePicture != null;
           bbiAdd.Enabled = currentMovie != null;
        }
        void AddNewScreen(Image image) {
            if(currentMovie == null) return;
            MoviePicture moviePicture = new MoviePicture(currentMovie.Session);
            moviePicture.Image = image;
            moviePicture.Movie = currentMovie;
            WinHelper.GridViewFocusObject(layoutView1, moviePicture);
            ShowFocusRect();
        }
        private void bbiAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            LayoutManager.ShowOpenImageDialog(new frmOpenImageDialog.SetImageDelegate(AddNewScreen), parentForm);
        }

        private void bbiDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            if(CurrentMoviePicture != null && XtraMessageBox.Show(this.FindForm(),
                string.Format(ConstStrings.Get("DeleteRecord"), ConstStrings.Get("PhotoSuffix")), ConstStrings.Get("Question"), MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes) {
                Cursor.Current = Cursors.WaitCursor;
                if(ObjectHelper.SafeDelete(this.FindForm(), CurrentMoviePicture, true)) {
                    UpdateCaption();
                    ShowFocusRect();
                }
                Cursor.Current = Cursors.Default;
            }
        }
        void ShowFocusRect() {
            if(CurrentMoviePicture != null)
                layoutView1.FocusedColumn = lvcImage;
        }
    }
}
