using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.Utils.Menu;
using DevExpress.Xpo;
using NukaCollect.Resources;

namespace NukaCollect.Win.Forms {
    public partial class frmCompanyAddMovie : frmAddBase {
        Company company;
        public frmCompanyAddMovie(Form parent, UnitOfWork session, Company company, IDXMenuManager manager) : base(parent, session, null, manager) {
            InitializeComponent();
            ElementConstStringLoader.LoadConstStringsForFrmCompanyAddMovie(this);
            this.company = company;
            Text = string.Format(ConstStrings.Get("AddMovieTo"), company.Name);
        }
        public MovieCompany MovieCompany { get { return editObject as MovieCompany; } }
        protected override void CreateNewObject() {
            base.CreateNewObject();
            editObject = new MovieCompany(Session);
        }
        protected override void InitData() {
            base.InitData();
            InitEditors();
        }
        private void InitEditors() {
            EditorHelper.CreateMovieGridLookUpEdit(Session, lueMovie.Properties, null);
        }
        protected override void InitValidation() {
            base.InitValidation();
            ValidationProvider.SetValidationRule(lueMovie, ValidationRulesHelper.RuleIsNotBlank);
        }
        protected override void SaveData() {
            base.SaveData();
            MovieCompany.Company = company;
            MovieCompany.Movie = (Movie)lueMovie.EditValue;
            MovieCompany.Description = teDescription.Text;
        }
    }
}
