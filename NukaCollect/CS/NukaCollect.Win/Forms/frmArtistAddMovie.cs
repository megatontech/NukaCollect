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
using NukaCollect.Resources;

namespace NukaCollect.Win.Forms {
    public partial class frmArtistAddMovie : frmAddBase {
        Artist artist;
        public frmArtistAddMovie(Form parent, UnitOfWork session, Artist artist, IDXMenuManager manager)
            : base(parent, session, null, manager) {
            InitializeComponent();
            ElementConstStringLoader.LoadConstStringsForFrmArtistAddMovie(this);
            this.artist = artist;
            Text = string.Format(ConstStrings.Get("AddMovieTo"), artist.FullName);
        }
        public MovieArtist MovieArtist { get { return editObject as MovieArtist; } }
        protected override void CreateNewObject() {
            base.CreateNewObject();
            editObject = new MovieArtist(Session);
        }
        protected override void InitData() {
            base.InitData();
            InitEditors();
        }
        protected override void InitValidation() {
            ValidationProvider.SetValidationRule(lueMovie, ValidationRulesHelper.RuleIsNotBlank);
            ValidationProvider.SetValidationRule(lueLine, ValidationRulesHelper.RuleIsNotBlank);
        }
        void InitEditors() {
            EditorHelper.CreateMovieGridLookUpEdit(Session, lueMovie.Properties, null);
            EditorHelper.CreateMovieArtistLineLookUpEdit(Session, lueLine.Properties, null);
        }
        protected override void SaveData() {
            base.SaveData();
            MovieArtist.Artist = artist;
            MovieArtist.Movie = (Movie)lueMovie.EditValue;
            MovieArtist.Line = (MovieArtistLine)lueLine.EditValue;
            MovieArtist.Description = meDescription.Text;
        }
    }
}
