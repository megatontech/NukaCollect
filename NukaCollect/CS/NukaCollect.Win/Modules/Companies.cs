using DevExpress.Xpo;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using NukaCollect.Resources;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace NukaCollect.Win.Modules
{
    public partial class Companies : GridExportTutorialControl
    {
        public Companies()
        {
            InitializeComponent();
            ElementConstStringLoader.LoadConstStringsForCompanies(this);
        }

        private void xcCompanies_ResolveSession(object sender, DevExpress.Xpo.ResolveSessionEventArgs e)
        {
            e.Session = Session;
        }

        protected override void RefreshGridDataSource()
        {
            VideoRentBaseObject current = CurrentEditObject;
            gridControl1.DataSource = new XPCollection<Company>(Session, null,
                new DevExpress.Xpo.SortProperty("[MoviesCount]", DevExpress.Xpo.DB.SortingDirection.Descending),
                new DevExpress.Xpo.SortProperty("[Name]", DevExpress.Xpo.DB.SortingDirection.Ascending)
                );
            WinHelper.GridViewFocusObject(MainView, current);
        }

        protected override void BeginRefreshData()
        {
            base.BeginRefreshData();
            RefreshGridDataSource();
        }

        public override string EditObjectName { get { return ConstStrings.Get("Company"); } }
        public override string EditObjectsName { get { return ConstStrings.Get("Companies"); } }
        protected override ColumnView MainView { get { return gridView1; } }
        protected override VideoRentBaseObject CurrentEditObject { get { return CurrentCompany; } }

        private Company CurrentCompany
        {
            get
            {
                if (MainView.FocusedRowHandle < 0) return null;
                return MainView.GetRow(MainView.FocusedRowHandle) as Company;
            }
        }

        protected override void InitData()
        {
            base.InitData();
            colCountry.ColumnEdit = EditorHelper.CreateCountryLookUpEdit(Session, gridControl1.RepositoryItems, true);
            colType.ColumnEdit = EditorHelper.CreateCompanyTypeLookUpEdit(Session, null, gridControl1.RepositoryItems, true);
        }

        public override void Add()
        {
            base.Add();
            AddCompany();
        }

        public override void Edit()
        {
            base.Edit();
            EditCompany();
        }

        protected override void CloseDetailForm(DialogResult result, object currentObject)
        {
            base.CloseDetailForm(result, currentObject);
            if (result != DialogResult.Cancel)
                RefreshData();
        }

        protected override void CloseDetailFormAndReload(DialogResult result, object currentObject)
        {
            base.CloseDetailFormAndReload(result, currentObject);
            if (result == DialogResult.Cancel) return;
            RefreshData();
            WinHelper.GridViewFocusObject(MainView, currentObject as VideoRentBaseObject);
        }

        private void AddCompany()
        {
            if (!IsDetailExist(Guid.Empty))
                ShowModuleDialog(new CompanyDetail(this.FindForm(), GetSession, null, MenuManager, CloseDetailFormAndReload));
        }

        private void EditCompany()
        {
            if (!IsDetailExist(CurrentCompany.Oid))
                ShowModuleDialog(new CompanyDetail(this.FindForm(), GetSession, CurrentCompany, MenuManager, CloseDetailForm));
        }

        private void gridControl1_MouseDown(object sender, MouseEventArgs e)
        {
            GridHitInfo info = gridView1.CalcHitInfo(new Point(e.X, e.Y));
            if (info.InRow && info.Column == colWebSite)
            {
                string link = string.Format("{0}", gridView1.GetRowCellValue(info.RowHandle, info.Column));
                ObjectHelper.ShowWebSite(link);
            }
        }

        private void layoutView1_CustomCardLayout(object sender, DevExpress.XtraGrid.Views.Layout.Events.LayoutViewCustomCardLayoutEventArgs e)
        {
            string description = string.Format("{0}", ((ColumnView)sender).GetRowCellValue(e.RowHandle, colDescription));
            if (description == string.Empty)
                e.CardDifferences.AddItemDifference("layoutViewField_layoutViewColumn1", DevExpress.XtraGrid.Views.Layout.LayoutItemDifferenceType.ItemVisibility, false);
        }
    }
}