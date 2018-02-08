using DevExpress.Utils.Menu;
using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;

namespace NukaCollect.Win.Controls
{
    public interface IEditsContainer
    {
        event EventHandler EditValueChanged;
    }

    public partial class ucMovieCategoryPriceDetail : XtraUserControl, IEditsContainer
    {
        private MovieCategoryPrice categoryPrice;

        public event EventHandler EditValueChanged;

        public ucMovieCategoryPriceDetail()
            : base()
        {
            InitializeComponent();
            ElementConstStringLoader.LoadConstStringsForUCMovieCategoryPriceDetail(this);
        }

        public ucMovieCategoryPriceDetail(MovieCategoryPrice categoryPrice)
            : this()
        {
            Init(categoryPrice);
        }

        public void SetLayoutManager(IDXMenuManager manager)
        {
            this.lcMain.MenuManager = manager;
            foreach (Control item in lcMain.Controls)
            {
                BaseEdit edit = item as BaseEdit;
                if (edit != null)
                    edit.MenuManager = manager;
            }
        }

        public void Init(MovieCategoryPrice categoryPrice)
        {
            InitData(categoryPrice);
            foreach (Control item in lcMain.Controls)
                AddControl(item);
        }

        protected void AddControl(Control item)
        {
            BaseEdit edit = item as BaseEdit;
            if (edit != null)
            {
                edit.MenuManager = lcMain.MenuManager;
                edit.EditValueChanged += new EventHandler(edit_EditValueChanged);
            }
            IEditsContainer editsContainer = item as IEditsContainer;
            if (editsContainer != null) editsContainer.EditValueChanged += new EventHandler(edit_EditValueChanged);
        }

        public void InitData(MovieCategoryPrice categoryPrice)
        {
            if (categoryPrice == null) return;
            this.categoryPrice = categoryPrice;
            seDays1Price.Value = categoryPrice.Days1RentPrice;
            seDays2Price.Value = categoryPrice.Days2RentPrice;
            seDays3Price.Value = categoryPrice.Days3RentPrice;
            seDays4Price.Value = categoryPrice.Days4RentPrice;
            seDays5Price.Value = categoryPrice.Days5RentPrice;
            seDays6Price.Value = categoryPrice.Days6RentPrice;
            seDays7Price.Value = categoryPrice.Days7RentPrice;
            seLatePrice.Value = categoryPrice.LateRentPrice;
            seDefaultDays.Value = categoryPrice.DefaultRentDays;
        }

        public void SaveData()
        {
            categoryPrice.Days1RentPrice = seDays1Price.Value;
            categoryPrice.Days2RentPrice = seDays2Price.Value;
            categoryPrice.Days3RentPrice = seDays3Price.Value;
            categoryPrice.Days4RentPrice = seDays4Price.Value;
            categoryPrice.Days5RentPrice = seDays5Price.Value;
            categoryPrice.Days6RentPrice = seDays6Price.Value;
            categoryPrice.Days7RentPrice = seDays7Price.Value;
            categoryPrice.LateRentPrice = seLatePrice.Value;
            categoryPrice.DefaultRentDays = (int)seDefaultDays.Value;
        }

        private void edit_EditValueChanged(object sender, EventArgs e)
        {
            if (EditValueChanged != null)
                EditValueChanged(sender, e);
        }
    }
}