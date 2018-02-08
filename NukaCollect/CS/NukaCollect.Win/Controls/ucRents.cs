using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.Xpo;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraEditors;
using NukaCollect.Resources;

namespace NukaCollect.Win.Controls {
    public partial class ucRents : XtraUserControl {
        Session session;
        Movie movie;
        public ucRents() : base() {
            InitializeComponent();
            ElementConstStringLoader.LoadConstStringsForUCRents(this);
        }
        public void InitData(Session session, Movie movie) {
            this.session = session;
            this.movie = movie;
            InitRentsGrid();
            ucGridSwitcherBar.ChangeState += SwitchRentsGrid;
            ucGridSwitcherBar.Checked = true;
        }
        void InitRentsGrid() {
            colCustomer.ColumnEdit = EditorHelper.CreateCustomerGridLookUpEdit(session, gcRents.RepositoryItems);
            gcRents.DataSource = movie.Rents;
        }
        void SwitchRentsGrid(object sender, ucBarOneCheckedButton.ChangeStateEventArgs e) {
            if(e.Checked) gvRents.ActiveFilter.Add(colActive, new ColumnFilterInfo(colActive, true));
            else gvRents.ActiveFilter.Remove(colActive);
            colActive.Visible = !e.Checked;
        }
    }
}
