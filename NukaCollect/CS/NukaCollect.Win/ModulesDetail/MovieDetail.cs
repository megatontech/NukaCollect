using DevExpress.Utils.Menu;
using DevExpress.Xpo;
using DevExpress.Xpo.DB;
using NukaCollect.Resources;
using NukaCollect.Win.Forms;
using System;
using System.Windows.Forms;

namespace NukaCollect.Win.Modules
{
    public partial class MovieDetail : DetailBase
    {
        public MovieDetail(Form parent, GetSessionCallback session, Movie movie, IDXMenuManager manager, CloseDetailForm closeForm)
            : base(parent, session, movie, manager, closeForm)
        {
            InitializeComponent();
            ElementConstStringLoader.LoadConstStringsForMovieDetail(this);
            teWebSite.Properties.Buttons[0].ToolTip = ConstStrings.Get("GoToWebsite");
            Text = movie != null ? movie.Title : ConstStrings.Get("NewMovie");
        }

        protected override string HomeButtonCaption { get { return ConstStrings.Get("MovieList"); } }
        public Movie Movie { get { return editObject as Movie; } }

        protected override void InitData()
        {
            base.InitData();
            InitEditors();
            if (Movie == null) return;
            if (Movie.ReleaseDate != null) deReleaseDate.DateTime = Movie.ReleaseDate.Value;
            ccbGenre.SetEditValue(Movie.Genre);
            icbRating.EditValue = Movie.Rating;
            teRunTime.Time = new DateTime(Movie.RunTime.HasValue ? Movie.RunTime.Value.Ticks : 0);
            ceIsColor.Checked = Movie.IsColor;
            pePhoto.Image = Movie.Photo;
            meTagline.Text = Movie.Tagline;
            mePlot.Text = Movie.Plot;
            teWebSite.Text = Movie.WebSite;
            teAwards.Text = Movie.Awards;
            teAspectRatio.Text = Movie.AspectRatio;
            ccbCountries.SetEditValue(Movie.CountriesAsString);
            lueLanguage.EditValue = Movie.Language;
            teTitle.Text = Movie.Title;
            teDirectors.Text = Movie.Directors;
            InitArtistGrid();
            InitCompanyGrid();
            lueCategory.EditValue = Movie.Category;
            ucMovieFormatsInfo.Init(Movie.Category, Movie.Items, lcMain.MenuManager);
            ucPictureEditBar1.Init(pePhoto, LayoutManager);
        }

        protected override void UpdateReadOnlyData()
        {
            base.UpdateReadOnlyData();
            lueCategory.Properties.Buttons[1].Enabled = !ReadOnly;
            lciBar.Visibility = ReadOnly ? DevExpress.XtraLayout.Utils.LayoutVisibility.Never : DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
        }

        private void InitEditors()
        {
            ccbGenre.Properties.SetFlags(typeof(MovieGenre));
            EditorHelper.CreateRatingImageComboBox(icbRating.Properties, null);
            EditorHelper.CreateLanguageLookUpEdit(Session, lueLanguage.Properties, null);
            EditorHelper.CreateMovieCountriesCheckedComboBox(Session, ccbCountries.Properties);
            EditorHelper.CreateMovieCategoryLookUpEdit(Session, lueCategory.Properties, null);
            pePhoto.Properties.NullText = ConstStrings.Get("NoImageData");
        }

        private void InitCompanyGrid()
        {
            colCompany.ColumnEdit = EditorHelper.CreateCompanyLookUpEdit(Session, gcCompanies.RepositoryItems);
            gcCompanies.DataSource = Movie.Companies;
            ucGridEditBarCompanies.Init(gvCompanies);
        }

        private void InitArtistGrid()
        {
            colArtist.ColumnEdit = EditorHelper.CreateArtistGridLookUpEdit(Session, gcArtists.RepositoryItems);
            colLine.ColumnEdit = EditorHelper.CreateMovieArtistLineLookUpEdit(Session, gcArtists.RepositoryItems);
            Movie.Artists.Sorting.AddRange(new SortProperty[] {
                new SortProperty("[Line.Name]", SortingDirection.Ascending),
                new SortProperty("[Artist.FullName]", SortingDirection.Ascending)});
            gcArtists.DataSource = Movie.Artists;
            ucGridEditBarArtist.Init(gvArtist);
        }

        protected override void InitValidation()
        {
            ValidationProvider.SetValidationRule(teTitle, ValidationRulesHelper.RuleIsNotBlank);
        }

        protected override void SaveData()
        {
            base.SaveData();

            gvArtist.CloseEditor();
            gvCompanies.CloseEditor();

            Movie.Title = teTitle.Text.Replace("\r\n", " ");
            Movie.Language = (Language)lueLanguage.EditValue;
            Movie.AspectRatio = teAspectRatio.Text;
            Movie.Awards = teAwards.Text;
            Movie.WebSite = teWebSite.Text;
            Movie.Tagline = meTagline.Text;
            Movie.Plot = mePlot.Text;
            Movie.Photo = pePhoto.Image;
            Movie.IsColor = ceIsColor.Checked;
            Movie.RunTime = teRunTime.Time.TimeOfDay;
            Movie.CountriesAsString = string.Format("{0}", ccbCountries.EditValue);
            if (Movie.RunTime.Value.Ticks == 0) Movie.RunTime = null;
            Movie.Rating = (MovieRating)icbRating.EditValue;
            Movie.Genre = (MovieGenre)ccbGenre.EditValue;
            Movie.ReleaseDate = deReleaseDate.DateTime.Date;
            if (Movie.ReleaseDate == DateTime.MinValue) Movie.ReleaseDate = null;
            Movie.Category = (MovieCategory)lueCategory.EditValue;
            CommitSession();
        }

        protected override VideoRentBaseObject CreateNewObject()
        {
            base.CreateNewObject();
            return new Movie(Session, "New film");
        }

        private void gvArtist_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            CheckDirectors();
        }

        public void CheckDirectors()
        {
            teDirectors.Text = string.Empty;
            MovieArtistLine directorLine = MovieArtistLine.GetDirector(Session);
            if (directorLine == null) return;
            XPCollection<MovieArtist> directors = new XPCollection<MovieArtist>(Session, false);
            for (int rowIndex = 0; rowIndex < gvArtist.RowCount; ++rowIndex)
            {
                MovieArtist movieArtist = gvArtist.GetRow(rowIndex) as MovieArtist;
                if (movieArtist.Line != directorLine) continue;
                directors.Add(movieArtist);
            }
            directors.Sorting.Add(new SortProperty("[Artist.FullName]", SortingDirection.Ascending));
            foreach (MovieArtist director in directors)
            {
                teDirectors.Text += ", " + director.Artist.FullName;
            }
            if (teDirectors.Text.Length != 0) teDirectors.Text = teDirectors.Text.Remove(0, 2);
        }

        private void gvArtist_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column != colArtist) return;
            MovieArtist mArtist = gvArtist.GetRow(e.RowHandle) as MovieArtist;
            if (mArtist == null || mArtist.Line == null ||
                string.Format("{0}", mArtist.Line.Name).IndexOf(ReferenceData.DirectorString) != 0) return;
            e.Appearance.Font = ElementHelper.FontBold;
        }

        private void teWebSite_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ObjectHelper.ShowWebSite(teWebSite.Text);
        }

        private void ucGridEditBarCompanies_AddRecord(object sender, EventArgs e)
        {
            using (frmMovieAddCompany form = new frmMovieAddCompany(FindForm(), Session, Movie, lcMain.MenuManager))
            {
                if (form.ShowDialog() == DialogResult.Cancel) return;
                WinHelper.GridViewFocusObject(gvCompanies, form.MovieCompany);
            }
        }

        private MovieCompany CurrentMovieCompany
        {
            get
            {
                return gvCompanies.GetRow(gvCompanies.FocusedRowHandle) as MovieCompany;
            }
        }

        private void ucGridEditBarCompanies_DeleteRecord(object sender, EventArgs e)
        {
            if (CurrentMovieCompany != null)
            {
                gvCompanies.HideEditor();
                gvCompanies.UpdateCurrentRow();
                ObjectHelper.SafeDelete(this.FindForm(), CurrentMovieCompany, false);
            }
        }

        private void ucGridEditBarArtist_AddRecord(object sender, EventArgs e)
        {
            using (frmMovieAddArtist form = new frmMovieAddArtist(FindForm(), Session, Movie, lcMain.MenuManager))
            {
                if (form.ShowDialog() == DialogResult.Cancel) return;
                if (form.NeedUpdateArtistsList) InitArtistGrid();
                WinHelper.GridViewFocusObject(gvArtist, form.MovieArtist);
                CheckDirectors();
            }
        }

        private MovieArtist CurrentMovieArtist
        {
            get { return gvArtist.GetRow(gvArtist.FocusedRowHandle) as MovieArtist; }
        }

        private void ucGridEditBarArtist_DeleteRecord(object sender, EventArgs e)
        {
            if (CurrentMovieArtist != null)
            {
                gvArtist.HideEditor();
                gvArtist.UpdateCurrentRow();
                if (ObjectHelper.SafeDelete(this.FindForm(), CurrentMovieArtist, false))
                    CheckDirectors();
            }
        }

        private void lueCategory_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Index != 1) return;
            using (frmNewMovieCategory form = new frmNewMovieCategory(this.FindForm(), (XPCollection<MovieCategory>)lueCategory.Properties.DataSource, lcMain.MenuManager))
            {
                form.ShowDialog(this);
                if (form.DialogResult == DialogResult.OK)
                {
                    lueCategory.EditValue = form.MovieCategory;
                    ucMovieFormatsInfo.Init(form.MovieCategory, Movie.Items, lcMain.MenuManager);
                }
            }
        }

        protected internal override void MovieAddItem()
        {
            lcMain.FocusHelper.PlaceItemIntoView(lciFormatsInfo);
            base.MovieAddItem();
            using (frmMovieAddItems form = new frmMovieAddItems(this.FindForm(), Session, Movie, lcMain.MenuManager))
            {
                form.ShowDialog();
                if (form.DialogResult == DialogResult.OK)
                {
                    if (form.MovieItems != null && form.MovieItems.Count != 0)
                    {
                        Movie.Items.AddRange(form.MovieItems);
                        UpdateActiveRibbonPageCaption();
                    }
                    ucMovieFormatsInfo.Init((MovieCategory)lueCategory.EditValue, Movie.Items, lcMain.MenuManager);
                }
            }
        }

        protected internal override void MovieManageItems()
        {
            lcMain.FocusHelper.PlaceItemIntoView(lciFormatsInfo);
            base.MovieManageItems();
            using (frmMovieItems form = new frmMovieItems(Session, Movie, lcMain.MenuManager))
            {
                ObjectHelper.SetFormContainerSize(form, ((frmMain)FindForm()).ChildContainer);
                ObjectHelper.ShowFormDialog(form, this.FindForm());
                ucMovieFormatsInfo.Init((MovieCategory)lueCategory.EditValue, Movie.Items, lcMain.MenuManager);
                UpdateActiveRibbonPageCaption();
            }
        }

        private void lueCategory_EditValueChanged(object sender, EventArgs e)
        {
            ucMovieFormatsInfo.Init((MovieCategory)lueCategory.EditValue, Movie.Items, lcMain.MenuManager);
        }

        protected internal override void LoadPicture()
        {
            base.LoadPicture();
            ucPictureEditBar1.LoadPicture();
        }

        protected internal override void ClearPicture()
        {
            base.ClearPicture();
            ucPictureEditBar1.ClearPicture();
        }

#       if DebugTest
        public MemoEdit GetTitleEditor() { return teTitle; }
        public PictureEdit GetPhotoEditor() { return pePhoto; }
        public DateEdit GetRealiseDateEditor() { return deReleaseDate; }
        public ImageComboBoxEdit GetRatingEditor() { return icbRating; }
        public CheckedComboBoxEdit GetGenreEditor() { return ccbGenre; }
        public MemoEdit GetPlotEditor() { return mePlot; }
        public MemoEdit GetTaglineEditor() { return meTagline; }
        public TextEdit GetAwardsEditor() { return teAwards; }
        public TextEdit GetDirectorsEditor() { return teDirectors; }
        public XtraGrid.GridControl GetArtistsEditor() { return gcArtists; }
        public XtraGrid.Views.Grid.GridView GetArtistsEditorView() { return gvArtist; }
        public TextEdit GetAspectRatioEditor() { return teAspectRatio; }
        public TimeEdit GetRunTimeEditor() { return teRunTime; }
        public CheckedComboBoxEdit GetCountriesEditor() { return ccbCountries; }
        public LookUpEdit GetLanguageEditor() { return lueLanguage; }
        public TextEdit GetWebSiteEditor() { return teWebSite; }
        public CheckEdit GetColorEditor() { return ceIsColor; }
        public XtraGrid.GridControl GetCompaniesEditor() { return gcCompanies; }
        public XtraGrid.Views.Grid.GridView GetCompaniesEditorView() { return gvCompanies; }
#       endif
    }
}