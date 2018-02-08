using DevExpress.Utils.Menu;
using DevExpress.Xpo;
using NukaCollect.Resources;
using System.Windows.Forms;

namespace NukaCollect.Win.Forms
{
    public partial class frmMovieAddCompany : frmAddBase
    {
        private Movie movie;

        public frmMovieAddCompany(Form parent, UnitOfWork session, Movie movie, IDXMenuManager manager) : base(parent, session, null, manager)
        {
            InitializeComponent();
            ElementConstStringLoader.LoadConstStringsForFrmMovieAddCompany(this);
            this.movie = movie;
            Text = string.Format(ConstStrings.Get("AddCompanyTo"), movie.Title);
        }

        public MovieCompany MovieCompany { get { return editObject as MovieCompany; } }

        protected override void CreateNewObject()
        {
            base.CreateNewObject();
            editObject = new MovieCompany(Session);
        }

        protected override void InitData()
        {
            base.InitData();
            InitEditors();
        }

        protected override void InitValidation()
        {
            ValidationProvider.SetValidationRule(lueCompany, ValidationRulesHelper.RuleIsNotBlank);
        }

        private void InitEditors()
        {
            EditorHelper.CreateCompanyLookUpEdit(Session, lueCompany.Properties, null);
        }

        protected override void SaveData()
        {
            base.SaveData();
            MovieCompany.Movie = movie;
            MovieCompany.Company = (Company)lueCompany.EditValue;
            MovieCompany.Description = meDescription.Text;
        }
    }
}