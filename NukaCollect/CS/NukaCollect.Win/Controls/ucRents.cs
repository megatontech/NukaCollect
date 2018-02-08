using DevExpress.Xpo;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;

namespace NukaCollect.Win.Controls
{
    public partial class ucRents : XtraUserControl
    {
        private Session session;
        private Movie movie;

        public ucRents() : base()
        {
            InitializeComponent();
            ElementConstStringLoader.LoadConstStringsForUCRents(this);
        }

        public void InitData(Session session, Movie movie)
        {
            this.session = session;
            this.movie = movie;
            InitRentsGrid();
            ucGridSwitcherBar.ChangeState += SwitchRentsGrid;
            ucGridSwitcherBar.Checked = true;
        }

        private void InitRentsGrid()
        {
            colCustomer.ColumnEdit = EditorHelper.CreateCustomerGridLookUpEdit(session, gcRents.RepositoryItems);
            gcRents.DataSource = movie.Rents;
        }

        private void SwitchRentsGrid(object sender, ucBarOneCheckedButton.ChangeStateEventArgs e)
        {
            if (e.Checked) gvRents.ActiveFilter.Add(colActive, new ColumnFilterInfo(colActive, true));
            else gvRents.ActiveFilter.Remove(colActive);
            colActive.Visible = !e.Checked;
        }
    }
}