using DevExpress.Utils.Controls;
using DevExpress.Xpo;
using DevExpress.XtraEditors;
using NukaCollect.Resources;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace NukaCollect.Win.Controls
{
    public partial class ucPictureCollection : XtraUserControl, IXtraResizableControl
    {
        public delegate void RefreshButtons();

        private XPCollection<ArtistPicture> collection;
        private FormLayoutManager layoutManager;
        private UnitOfWork session;
        private Artist currentArtist;
        private RefreshButtons refreshButtons;
        private int currentRecord = -2;

        public ucPictureCollection()
        {
            InitializeComponent();
            ElementConstStringLoader.LoadConstStringsForUCPictureCollection(this);
            bbiAdd.Glyph = ImagesHelper.Current.BarImages.Images[0];
            bbiDelete.Glyph = ImagesHelper.Current.BarImages.Images[2];
            bbiPrev.Glyph = ImagesHelper.Current.BarImages.Images[6];
            bbiNext.Glyph = ImagesHelper.Current.BarImages.Images[7];
            peImage.Properties.NullText = ConstStrings.Get("NoImageData");
        }

        private ArtistPicture CurrentEditObject
        {
            get
            {
                if (currentRecord < 0) return null;
                return collection[currentRecord];
            }
        }

        private int CurrentRecord
        {
            get { return currentRecord; }
            set
            {
                if (value > collection.Count - 1) value = collection.Count - 1;
                if (collection.Count > 0 && value < 0) value = 0;
                if (currentRecord == value) return;
                currentRecord = value;
                RefreshImage();
            }
        }

        public bool DeleteButtonEnabled { get { return CurrentRecord >= 0; } }

        private void RefreshImage()
        {
            peImage.Image = CurrentRecord >= 0 ? collection[CurrentRecord].Image : null;
            bsiRecords.Caption = string.Format(ConstStrings.Get("PhotoOf"), CurrentRecord + 1, collection.Count);
            bbiPrev.Enabled = CurrentRecord > 0;
            bbiNext.Enabled = CurrentRecord >= 0 && CurrentRecord < collection.Count - 1;
            bbiDelete.Enabled = DeleteButtonEnabled;
            if (refreshButtons != null) refreshButtons();
        }

        #region IXtraResizableControl Members

        public event EventHandler Changed;

        protected virtual void RaiseChanged()
        {
            Changed(this, EventArgs.Empty);
        }

        public bool IsCaptionVisible
        {
            get { return false; }
        }

        public Size MaxSize
        {
            get { return new Size(600, 1000); }
        }

        public Size MinSize
        {
            get { return new Size(200, 200); }
        }

        #endregion IXtraResizableControl Members

        public void Init(Artist artist, UnitOfWork session, FormLayoutManager manager, RefreshButtons refreshButtons)
        {
            this.currentArtist = artist;
            this.collection = artist.Pictures;
            this.session = session;
            this.layoutManager = manager;
            this.refreshButtons = refreshButtons;
            CurrentRecord = collection.Count > 0 ? 0 : -1;
        }

        private void bbiPrev_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CurrentRecord--;
        }

        private void bbiNext_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CurrentRecord++;
        }

        private void AddNewPhoto(Image image)
        {
            currentArtist.AddPicture(image);
            CurrentRecord = collection.Count - 1;
        }

        public void AddPicture()
        {
            layoutManager.ShowOpenImageDialog(new NukaCollect.Win.Forms.frmOpenImageDialog.SetImageDelegate(AddNewPhoto), this.FindForm());
        }

        public void DeletePicture()
        {
            if (CurrentEditObject != null && XtraMessageBox.Show(this.FindForm(),
                string.Format(ConstStrings.Get("DeleteRecord"), ConstStrings.Get("PhotoSuffix")), ConstStrings.Get("Question"), MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                if (ObjectHelper.SafeDelete(this.FindForm(), CurrentEditObject, false))
                {
                    CurrentRecord = CurrentRecord == 0 ? -1 : CurrentRecord - 1;
                    RefreshImage();
                }
            }
        }

        private void bbiAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AddPicture();
        }

        private void bbiDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DeletePicture();
        }
    }
}