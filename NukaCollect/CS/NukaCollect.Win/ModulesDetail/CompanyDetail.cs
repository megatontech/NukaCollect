using DevExpress.Utils.Menu;
using DevExpress.XtraEditors.Controls;
using NukaCollect.Resources;
using NukaCollect.Win.Forms;
using System;
using System.Windows.Forms;

namespace NukaCollect.Win.Modules
{
    public partial class CompanyDetail : DetailBase
    {
        public CompanyDetail(Form parent, GetSessionCallback session, Company company, IDXMenuManager manager, CloseDetailForm closeForm)
            : base(parent, session, company, manager, closeForm)
        {
            InitializeComponent();
            ElementConstStringLoader.LoadConstStringsForCompanyDetail(this);
            beWebSite.Properties.Buttons[0].ToolTip = ConstStrings.Get("GoToWebsite");
            Text = company != null ? company.Name : ConstStrings.Get("NewCompany");
        }

        protected override string HomeButtonCaption { get { return ConstStrings.Get("CompanyList"); } }
        public Company Company { get { return editObject as Company; } }

        protected override void InitData()
        {
            base.InitData();
            InitEditors();
            if (Company == null) return;
            teName.Text = Company.Name;
            lueType.EditValue = Company.Type;
            beWebSite.Text = Company.WebSite;
            lueCountry.EditValue = Company.Country;
            InitMoviesGrid();
        }

        private void InitEditors()
        {
            EditorHelper.CreateCompanyTypeLookUpEdit(Session, lueType.Properties, null);
            EditorHelper.CreateCountryLookUpEdit(Session, lueCountry.Properties, null);
        }

        private void InitMoviesGrid()
        {
            colMovie.ColumnEdit = EditorHelper.CreateMovieGridLookUpEdit(Session, gcMovies.RepositoryItems);
            gcMovies.DataSource = Company.Movies;
            ucGridEditBar.Init(gvMovies);
        }

        protected override void InitValidation()
        {
            ValidationProvider.SetValidationRule(teName, ValidationRulesHelper.RuleIsNotBlank);
        }

        protected override void SaveData()
        {
            base.SaveData();
            Company.Name = teName.Text;
            Company.Type = (CompanyType)lueType.EditValue;
            Company.WebSite = beWebSite.Text;
            Company.Country = (Country)lueCountry.EditValue;
            CommitSession();
        }

        protected override VideoRentBaseObject CreateNewObject()
        {
            base.CreateNewObject();
            return new Company(Session, ConstStrings.Get("NewCompany"));
        }

        private MovieCompany CurrentMovieCompany
        {
            get { return gvMovies.GetRow(gvMovies.FocusedRowHandle) as MovieCompany; }
        }

        private void ucGridEditBar_DeleteRecord(object sender, EventArgs e)
        {
            if (CurrentMovieCompany != null)
            {
                gvMovies.HideEditor();
                gvMovies.UpdateCurrentRow();
                ObjectHelper.SafeDelete(this.FindForm(), CurrentMovieCompany, false);
            }
        }

        private void ucGridEditBar_AddRecord(object sender, EventArgs e)
        {
            using (frmCompanyAddMovie form = new frmCompanyAddMovie(this.FindForm(), Session, Company, lcMain.MenuManager))
            {
                if (form.ShowDialog() == DialogResult.Cancel) return;
                WinHelper.GridViewFocusObject(gvMovies, form.MovieCompany);
            }
        }

        private void beWebSite_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            ObjectHelper.ShowWebSite(beWebSite.Text);
        }

        private void lueCountry_EditValueChanged(object sender, EventArgs e)
        {
            Country country = lueCountry.EditValue as Country;
            peFlag.Image = country == null ? null : country.Flag;
        }
    }
}