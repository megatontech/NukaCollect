using DevExpress.Utils.Menu;
using DevExpress.Xpo;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using NukaCollect.Resources;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace NukaCollect.Win.Forms
{
    public partial class frmFindCustomer : XtraForm
    {
        private FormLayoutManager layoutManager;

        public frmFindCustomer()
        {
            InitializeComponent();
            ElementConstStringLoader.LoadConstStringsForFrmFindCustomer(this);
        }

        public frmFindCustomer(FormLayoutManager layoutManager, IDXMenuManager manager, Session session, bool showClear) : this()
        {
            gridControl1.MenuManager = manager;
            this.layoutManager = layoutManager;
            xcCustomers.Session = session;
            sbClear.Visible = false; //showClear;
        }

        private Customer CurrentCustomer
        {
            get
            {
                if (gridView1.FocusedRowHandle < 0) return null;
                return gridView1.GetRow(gridView1.FocusedRowHandle) as Customer;
            }
        }

        private void sbOK_Click(object sender, EventArgs e)
        {
            layoutManager.CurrentCustomer = CurrentCustomer;
        }

        private void sbClear_Click(object sender, EventArgs e)
        {
            layoutManager.CurrentCustomer = null;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            InitEditors();
            gridControl1.ForceInitialize();
            LoadFormLayout();
            if (layoutManager.CurrentCustomer != null)
                WinHelper.GridViewFocusObject(gridView1, layoutManager.CurrentCustomer);
            else gridView1.FocusedRowHandle = GridControl.AutoFilterRowHandle;
            ChangedFocusedRow();
        }

        private void InitEditors()
        {
            colGender.ColumnEdit = EditorHelper.CreateGenderImageComboBox(gridControl1.RepositoryItems);
            colCustomerId.ColumnEdit = EditorHelper.CreateCardNumberTextEdit(gridControl1.RepositoryItems);
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            SaveFormLayout();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (e.FocusedRowHandle == GridControl.AutoFilterRowHandle)
                gridView1.FocusedColumn = colCustomerId;
            else if (e.FocusedRowHandle >= 0)
                gridView1.FocusedColumn = null;
            ChangedFocusedRow();
        }

        private void gridView1_ColumnFilterChanged(object sender, EventArgs e)
        {
            ChangedFocusedRow();
        }

        private void ChangedFocusedRow()
        {
            sbOK.Enabled = CurrentCustomer != null;
            ucCustomerInfo1.Init(CurrentCustomer, ConstStrings.Get("AutoFilterRowHint"));
        }

        private void gridControl1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            GridHitInfo info = gridView1.CalcHitInfo(new Point(e.X, e.Y));
            if (CurrentCustomer != null && info.InRow)
            {
                layoutManager.CurrentCustomer = CurrentCustomer;
                DialogResult = DialogResult.OK;
            }
        }

        protected virtual void LoadFormLayout()
        {
            layoutManager.RestoreFormLayout(new FormLayoutInfo(null, null, lcMain, gridView1, null));
        }

        protected virtual void SaveFormLayout()
        {
            layoutManager.SaveFormLayout(new FormLayoutInfo(null, null, lcMain, gridView1, null));
        }
    }
}