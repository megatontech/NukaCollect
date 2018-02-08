using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.Xpo;
using DevExpress.Utils.Menu;
using DevExpress.XtraEditors.DXErrorProvider;
using NukaCollect.Resources;

namespace NukaCollect.Win.Forms {
    public partial class frmMovieAddItems : frmAddBase {
        Movie movie;
        XPCollection<MovieItem> movieItems;
        public frmMovieAddItems(Form parent, UnitOfWork session, Movie movie, IDXMenuManager manager)
            : base(parent, session, null, manager) {
            InitializeComponent();
            ElementConstStringLoader.LoadConstStringsForFrmMovieAddItems(this);
            this.movie = movie;
        }
        public MovieItem MovieItem { get { return editObject as MovieItem; } }
        public XPCollection<MovieItem> MovieItems { get { return movieItems; } }
        protected override void CreateNewObject() {
            base.CreateNewObject();
            editObject = new MovieItem(this.movie);
        }
        protected override void InitData() {
            base.InitData();
            InitEditors();
            InitValidationRules();
            if(MovieItem == null) return;
            lueFormat.EditValue = MovieItem.Format;
            ceAvailableForSell.Checked = MovieItem.AvailableForSell;
            seSellPrice.Value = MovieItem.SellingPrice;
        }

        void InitValidationRules() {
            ConditionValidationRule rule = new ConditionValidationRule();
            rule.ConditionOperator = ConditionOperator.Greater;
            rule.Value1 = 0;
            rule.ErrorText = ConstStrings.Get("PriceError");
            rule.ErrorType = ErrorType.Critical;
            dxValidationProvider1.SetValidationRule(seSellPrice, rule);
        }
        void InitEditors() {
            EditorHelper.CreateMovieItemFormatImageComboBox(lueFormat.Properties, null);
            lueFormat.EditValue = MovieItemFormat.DVD;
        }
        protected override void InitValidation() {
            base.InitValidation();
            ValidationProvider.SetValidationRule(seCount, ValidationRulesHelper.RuleGreaterOrEqual(1));
            ValidationProvider.SetValidationRule(seSellPrice, ValidationRulesHelper.RuleGreaterOrEqualZero);
        }
        protected override void SaveData() {
            base.SaveData();
            MovieItem.Format = (MovieItemFormat)lueFormat.EditValue;
            MovieItem.AvailableForSell = ceAvailableForSell.Checked;
            MovieItem.SellingPrice = seSellPrice.Value;
            movieItems = MovieItem.CreateFewItems(MovieItem, (int)seCount.Value - 1);
            movieItems.Add(MovieItem);
        }
        protected override void OnClosing(CancelEventArgs e) {
            if(ceAvailableForSell.Checked && DialogResult == DialogResult.OK)
                if(!dxValidationProvider1.Validate()) {
                    e.Cancel = true;
                    return;
                }
            base.OnClosing(e);
        }
    }
}
