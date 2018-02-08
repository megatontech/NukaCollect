using DevExpress.Utils.Menu;
using DevExpress.Xpo;
using NukaCollect.Resources;
using System.Windows.Forms;

namespace NukaCollect.Win.Forms
{
    public partial class frmArtistAddMovie : frmAddBase
    {
        private Artist artist;

        public frmArtistAddMovie(Form parent, UnitOfWork session, Artist artist, IDXMenuManager manager)
            : base(parent, session, null, manager)
        {
            InitializeComponent();
            ElementConstStringLoader.LoadConstStringsForFrmArtistAddMovie(this);
            this.artist = artist;
            Text = string.Format(ConstStrings.Get("AddMovieTo"), artist.FullName);
        }

        public MovieArtist MovieArtist { get { return editObject as MovieArtist; } }

        protected override void CreateNewObject()
        {
            base.CreateNewObject();
            editObject = new MovieArtist(Session);
        }

        protected override void InitData()
        {
            base.InitData();
            InitEditors();
        }

        protected override void InitValidation()
        {
            ValidationProvider.SetValidationRule(lueMovie, ValidationRulesHelper.RuleIsNotBlank);
            ValidationProvider.SetValidationRule(lueLine, ValidationRulesHelper.RuleIsNotBlank);
        }

        private void InitEditors()
        {
            EditorHelper.CreateMovieGridLookUpEdit(Session, lueMovie.Properties, null);
            EditorHelper.CreateMovieArtistLineLookUpEdit(Session, lueLine.Properties, null);
        }

        protected override void SaveData()
        {
            base.SaveData();
            MovieArtist.Artist = artist;
            MovieArtist.Movie = (Movie)lueMovie.EditValue;
            MovieArtist.Line = (MovieArtistLine)lueLine.EditValue;
            MovieArtist.Description = meDescription.Text;
        }
    }
}