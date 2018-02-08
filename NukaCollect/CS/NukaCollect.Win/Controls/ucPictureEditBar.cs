using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Utils.Controls;
using NukaCollect.Win.Forms;
using NukaCollect.Resources;

namespace NukaCollect.Win.Controls {
    public partial class ucPictureEditBar : XtraUserControl, IXtraResizableControl {
        PictureEdit edit;
        FormLayoutManager layoutManager;
        public ucPictureEditBar() {
            InitializeComponent();
            ElementConstStringLoader.LoadConstStringsForUCPictureEditBar(this);
            bbiLoad.Glyph = ImagesHelper.Current.BarImages.Images[4];
            bbiClear.Glyph = ImagesHelper.Current.BarImages.Images[2];
        }
        public void Init(PictureEdit edit, FormLayoutManager layoutManager) {
            this.edit = edit;
            this.layoutManager = layoutManager;
        }
        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            RaiseChanged();
        }
        void LoadPicture(Image image) {
            edit.Image = image;
        }
        public void LoadPicture() {
            layoutManager.ShowOpenImageDialog(new frmOpenImageDialog.SetImageDelegate(LoadPicture), this.FindForm());
        }
        public void ClearPicture() {
            edit.Image = null;
        }
        private void bbiLoad_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            LoadPicture();
        }
        private void bbiClear_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            ClearPicture();
        }
        #region IXtraResizableControl Members
        public event EventHandler Changed;
        protected virtual void RaiseChanged() {
            if(Changed != null)
                Changed(this, EventArgs.Empty);
        }
        public bool IsCaptionVisible {
            get { return false; }
        }
        public Size MaxSize {
            get { return new Size(3000, ControlHeight); }
        }
        public Size MinSize {
            get { return new Size(170, ControlHeight); }
        }
        int ControlHeight {
            get {
                if(mainBar == null || mainBar.Size.IsEmpty || mainBar.Size.Height == 0)
                    return 25;
                return mainBar.Size.Height;
            }
        }
        #endregion
    }
}
