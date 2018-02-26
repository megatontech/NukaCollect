using DevExpress.Utils.Menu;
using DevExpress.Xpo;
using DevExpress.Xpo.DB;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.DXErrorProvider;
using NukaCollect.Resources;
using NukaCollect.Win.Forms;
using System;
using System.Windows.Forms;

namespace NukaCollect.Win.Modules
{
    public partial class ArtistDetail : DetailBase
    {
        public ArtistDetail(Form parent, GetSessionCallback session, Artist artist, IDXMenuManager manager, CloseDetailForm closeForm)
            : base(parent, session, artist, manager, closeForm)
        {
            InitializeComponent();
            ElementConstStringLoader.LoadConstStringsForArtistDetail(this);
            teLink.Properties.Buttons[0].ToolTip = ConstStrings.Get("GoToWebsite");
            Text = artist != null ? artist.FullName : ConstStrings.Get("NewActor");
        }

        protected override string HomeButtonCaption { get { return ConstStrings.Get("ArtistList"); } }
        public Artist Artist { get { return editObject as Artist; } }

        protected override void InitData()
        {
            base.InitData();
            InitEditors();
            if (Artist == null) return;
            teFirstName.Text = Artist.FirstName;
            teLastName.Text = Artist.LastName;
            cbeGender.EditValue = Artist.Gender;
            teNickName.Text = Artist.NickName;
            teBirthName.Text = Artist.BirthName;
            if (Artist.BirthDate != null) deBirthDate.DateTime = Artist.BirthDate.Value;
            EditorHelper.CreateCountryLookUpEdit(Session, lueBirthCountry.Properties, null);
            lueBirthCountry.EditValue = Artist.BirthCountry;
            teBirthLocation.Text = Artist.BirthLocation;
            meBiography.Text = Artist.Biography;
            teLink.Text = Artist.Link;
            ucPictureCollection1.Init(Artist, Session, LayoutManager, InitDeleteButtonEnabled);
            InitMovies();
            InitDeleteButtonEnabled();
        }

        protected override bool ValidateData()
        {
            ValidationRule rule = null;
            if (string.IsNullOrEmpty(teFirstName.Text) && string.IsNullOrEmpty(teLastName.Text))
                rule = ValidationRulesHelper.RuleIsNotBlank;
            ValidationProvider.SetValidationRule(teFirstName, rule);
            ValidationProvider.SetValidationRule(teLastName, rule);
            return base.ValidateData();
        }

        //protected override void InitValidation() {
        //    //ValidationProvider.SetValidationRule(
        //    //ValidationProvider.SetValidationRule(teFirstName, ValidationRulesHelper.RuleIsNotBlank);
        //    //ValidationProvider.SetValidationRule(teLastName, ValidationRulesHelper.RuleIsNotBlank);
        //}
        private void InitEditors()
        {
            EditorHelper.CreateGenderImageComboBox(cbeGender.Properties, null);
        }

        private void InitMovies()
        {
            colMovie.ColumnEdit = EditorHelper.CreateMovieGridLookUpEdit(Session, gcMovies.RepositoryItems);
            colLine.ColumnEdit = EditorHelper.CreateMovieArtistLineLookUpEdit(Session, gcMovies.RepositoryItems);
            Artist.Movies.Sorting.AddRange(new SortProperty[] {
                new SortProperty("[Line.Name]", SortingDirection.Ascending),
                new SortProperty("[Movie.Title]", SortingDirection.Ascending)});
            gcMovies.DataSource = Artist.Movies;
            ucGridEditBarMovies.Init(gvMovies);
        }

        protected override void SaveData()
        {
            base.SaveData();

            gvMovies.CloseEditor();

            Artist.Link = teLink.Text;
            Artist.Biography = meBiography.Text;
            Artist.BirthLocation = teBirthLocation.Text;
            Artist.BirthCountry = (Country)lueBirthCountry.EditValue;
            Artist.BirthDate = deBirthDate.DateTime;
            if (Artist.BirthDate == DateTime.MinValue) Artist.BirthDate = null;
            Artist.BirthName = teBirthName.Text;
            Artist.NickName = teNickName.Text;
            Artist.Gender = (PersonGender)cbeGender.EditValue;
            Artist.LastName = teLastName.Text;
            Artist.FirstName = teFirstName.Text;
            CommitSession();
        }

        protected override VideoRentBaseObject CreateNewObject()
        {
            base.CreateNewObject();
            return new Artist(Session);
        }

        private MovieArtist CurrentMovieArtist
        {
            get
            {
                return gvMovies.GetRow(gvMovies.FocusedRowHandle) as MovieArtist;
            }
        }

        private void ucGridEditBarMovies_AddRecord(object sender, EventArgs e)
        {
            using (frmArtistAddMovie form = new frmArtistAddMovie(FindForm(), Session, Artist, lcMain.MenuManager))
            {
                if (form.ShowDialog() == DialogResult.Cancel) return;
                WinHelper.GridViewFocusObject(gvMovies, form.MovieArtist);
            }
        }

        private void ucGridEditBarMovies_DeleteRecord(object sender, EventArgs e)
        {
            if (CurrentMovieArtist != null)
            {
                gvMovies.HideEditor();
                gvMovies.UpdateCurrentRow();
                ObjectHelper.SafeDelete(this.FindForm(), CurrentMovieArtist, false);
            }
        }

        private void teLink_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            string link = ((TextEdit)sender).Text;
            if (string.IsNullOrEmpty(link)) link = "http://www.imdb.com/find?s=nm&q=" + Artist.FirstName + "+" + Artist.LastName;
            ObjectHelper.ShowWebSite(link);
        }

        protected internal override void AddPicture()
        {
            ucPictureCollection1.AddPicture();
            InitDeleteButtonEnabled();
        }

        protected internal override void DeletePicture()
        {
            ucPictureCollection1.DeletePicture();
            InitDeleteButtonEnabled();
        }

        private void InitDeleteButtonEnabled()
        {
            if (ParentFormMain != null)
                ParentFormMain.DeletePictureButton.Enabled = ucPictureCollection1.DeleteButtonEnabled;
        }

    }
}