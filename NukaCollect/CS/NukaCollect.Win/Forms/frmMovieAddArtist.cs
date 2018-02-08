using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using DevExpress.Xpo.DB;
using DevExpress.Utils.Menu;
using NukaCollect.Helpers;
using NukaCollect.Resources;

namespace NukaCollect.Win.Forms {
    public partial class frmMovieAddArtist : frmAddBase {
        Movie movie;
        bool needUpdateArtistsList = false;
        public frmMovieAddArtist(Form parent, UnitOfWork session, Movie movie, IDXMenuManager manager)
            : base(parent, session, null, manager) {
            InitializeComponent();
            ElementConstStringLoader.LoadConstStringsForFrmMovieAddArtist(this);
            this.movie = movie;
            Text = string.Format(ConstStrings.Get("AddArtistTo"), movie.Title);
        }
        public MovieArtist MovieArtist { get { return editObject as MovieArtist; } }
        public bool NeedUpdateArtistsList { get { return needUpdateArtistsList; } }
        protected override void CreateNewObject() {
            base.CreateNewObject();
            editObject = new MovieArtist(Session);
        }
        protected override void InitData() {
            base.InitData();
            InitEditors();
        }
        protected override void InitValidation() {
            ValidationProvider.SetValidationRule(lueArtist, ValidationRulesHelper.RuleIsNotBlank);
            ValidationProvider.SetValidationRule(lueLine, ValidationRulesHelper.RuleIsNotBlank);
        }
        void InitEditors() {
            EditorHelper.CreateArtistGridLookUpEdit(Session, lueArtist.Properties, null);
            EditorHelper.CreateMovieArtistLineLookUpEdit(Session, lueLine.Properties, null);
        }
        protected override void SaveData() {
            base.SaveData();
            MovieArtist.Movie = movie;
            MovieArtist.Artist = (Artist)lueArtist.EditValue;
            MovieArtist.Line = (MovieArtistLine)lueLine.EditValue;
            MovieArtist.Description = meDescription.Text;
        }
        void CloseArtistDetailForm(DialogResult result, object currentObject) {
            EditorHelper.CreateArtistGridLookUpEdit(Session, lueArtist.Properties, null);
            lueArtist.EditValue = SessionHelper.GetObject<Artist>((Artist)currentObject, Session);
            lueArtist.Refresh();
            needUpdateArtistsList = true;
        }
        private void lueArtist_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e) {
            if(e.Button.Index != 1) return;
            using(frmArtistDetail form = new frmArtistDetail(this.FindForm(), GetSession, null, lcMain.MenuManager, CloseArtistDetailForm)) {
                form.ShowDialog();
            }
        }
    }
}
