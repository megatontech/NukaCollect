using DevExpress.Data.Filtering;
using DevExpress.Utils.Menu;
using DevExpress.Xpo;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.DXErrorProvider;
using DevExpress.XtraGrid;
using DevExpress.XtraLayout;
using NukaCollect.Resources;
using System;
using System.Windows.Forms;

namespace NukaCollect.Win.Controls
{
    public partial class ucMovieCategoryDetail : XtraUserControl, IEditsContainer
    {
        private MovieCategory category;
        private XPCollection<MovieCategory> allCategories;

        public event EventHandler EditValueChanged;

        private EventHandler editValueChangedDelegate;

        public ucMovieCategoryDetail()
            : base()
        {
            InitializeComponent();
            ElementConstStringLoader.LoadConstStringsForUCMovieCategoryDetail(this);
            editValueChangedDelegate = new EventHandler(edit_EditValueChanged);
            InitTabPages();
            lcMain.Images = ImagesHelper.Current.DiskIcons;
            foreach (Control item in lcMain.Controls)
                AddControl(item);
        }

        public void SetFocus()
        {
            teName.Focus();
        }

        public void SetLayoutManager(IDXMenuManager manager)
        {
            this.lcMain.MenuManager = manager;
            foreach (Control item in lcMain.Controls)
            {
                BaseEdit edit = item as BaseEdit;
                if (edit != null)
                    edit.MenuManager = manager;
                ucMovieCategoryPriceDetail price = item as ucMovieCategoryPriceDetail;
                if (price != null)
                    price.SetLayoutManager(manager);
            }
        }

        public void Init(MovieCategory category, XPCollection<MovieCategory> allCategories)
        {
            this.category = category;
            this.allCategories = allCategories;
            InitData();
            InitValidation();
        }

        protected void AddControl(Control item)
        {
            BaseEdit edit = item as BaseEdit;
            if (edit != null)
            {
                edit.MenuManager = lcMain.MenuManager;
                edit.EditValueChanged += editValueChangedDelegate;
            }
            IEditsContainer editsContainer = item as IEditsContainer;
            if (editsContainer != null) editsContainer.EditValueChanged += editValueChangedDelegate;
        }

        protected void RemoveControl(Control item)
        {
            BaseEdit edit = item as BaseEdit;
            if (edit != null)
            {
                edit.MenuManager = lcMain.MenuManager;
                edit.EditValueChanged -= editValueChangedDelegate;
            }
            IEditsContainer editsContainer = item as IEditsContainer;
            if (editsContainer != null) editsContainer.EditValueChanged -= editValueChangedDelegate;
            GridControl grid = item as GridControl;
            if (grid != null) grid.MenuManager = lcMain.MenuManager;
        }

        private void InitValidation()
        {
            ConditionValidationRule ruleUniqueName = new ConditionValidationRule();
            ruleUniqueName.ConditionOperator = ConditionOperator.NotAnyOf;
            ruleUniqueName.Values.Add(null);
            ruleUniqueName.Values.Add(string.Empty);
            foreach (MovieCategory category in allCategories)
            {
                if (category == this.category) continue;
                ruleUniqueName.Values.Add(category.Name);
            }
            ruleUniqueName.ErrorText = ConstStrings.Get("RuleUniqueName");
            ruleUniqueName.ErrorType = ErrorType.Critical;
            validationProvider.SetValidationRule(teName, ruleUniqueName);
        }

        private void InitTabPages()
        {
            for (int i = tcgMain.TabPages.Count - 1; i >= 0; i--)
                tcgMain.RemoveTabPage(tcgMain.TabPages[i]);
            MovieItemFormat[] formats = (MovieItemFormat[])Enum.GetValues(typeof(MovieItemFormat));
            for (int i = 0; i < formats.Length; ++i)
            {
                MovieItemFormat format = formats[i];
                LayoutGroup tab = tcgMain.AddTabPage();
                tab.CaptionImageIndex = i;
                tab.Text = EnumTitlesKeeper<MovieItemFormat>.GetTitle(format);
                LayoutControlItem item = tab.AddItem() as LayoutControlItem;
                ucMovieCategoryPriceDetail ucPrices = new ucMovieCategoryPriceDetail(null);
                ucPrices.Tag = format;
                item.Control = ucPrices;
                item.TextVisible = false;
                AddControl(ucPrices);
            }
            tcgMain.SelectedTabPageIndex = 0;
        }

        private void InitData()
        {
            teName.Text = this.category.Name;
            foreach (Control ctrl in lcMain.Controls)
            {
                ucMovieCategoryPriceDetail ucPrice = ctrl as ucMovieCategoryPriceDetail;
                if (ucPrice != null)
                {
                    MovieItemFormat format = (MovieItemFormat)ucPrice.Tag;
                    ucPrice.InitData(category.GetPrice(format));
                }
            }
        }

        public bool ValidateData()
        {
            return validationProvider.Validate();
        }

        public void SaveData()
        {
            if (this.category == null) return;
            this.category.Name = teName.Text;
            foreach (Control ctrl in lcMain.Controls)
            {
                ucMovieCategoryPriceDetail ucPrice = ctrl as ucMovieCategoryPriceDetail;
                if (ucPrice != null)
                    ucPrice.SaveData();
            }
        }

        private void edit_EditValueChanged(object sender, EventArgs e)
        {
            if (EditValueChanged != null)
                EditValueChanged(sender, e);
        }

        public static MovieCategory CreateNewMovieCategory(Session session, XPBaseCollection categories)
        {
            string name = ConstStrings.Get("NewMovieCategory");
            int suffix = 0;
            string nameWithSuffix;
            while (true)
            {
                nameWithSuffix = name + (suffix == 0 ? string.Empty : "(" + suffix.ToString() + ")");
                categories.Filter = CriteriaOperator.Parse("Name = ?", nameWithSuffix);
                if (categories.Count == 0) break;
                ++suffix;
            }
            categories.Filter = null;
            return new MovieCategory(session, nameWithSuffix);
        }
    }
}