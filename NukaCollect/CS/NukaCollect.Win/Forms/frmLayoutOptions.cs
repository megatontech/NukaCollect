using DevExpress.XtraEditors;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace NukaCollect.Win.Forms
{
    public partial class frmLayoutOptions : XtraForm
    {
        private FormLayoutManager layoutManager;

        public frmLayoutOptions()
        {
            InitializeComponent();
            ElementConstStringLoader.LoadConstStringsForFrmLayoutOptions(this);
        }

        private WinFormProperty CurrentProperty
        { get { return layoutManager.Properties.CurrentProperty; } }

        public frmLayoutOptions(FormLayoutManager layoutManager)
            : this()
        {
            this.layoutManager = layoutManager;
            InitData();
        }

        private void InitData()
        {
            ceAllowRestoreFormLayout.Checked = CurrentProperty.AllowRestoreFormLayout;
            ceAllowRestoreLayoutControlLayout.Checked = CurrentProperty.AllowRestoreLayoutControlLayout;
            ceAllowRestoreGridViewLayout.Checked = CurrentProperty.AllowRestoreGridViewLayout;
            ceAllowRestoreDockingLayout.Checked = CurrentProperty.AllowRestoreDockingLayout;
            ceDefaultEditGridViewInDetailForms.Checked = CurrentProperty.DefaultEditGridViewInDetailForms;
        }

        private void sbClearLayouts_Click(object sender, EventArgs e)
        {
            layoutManager.ClearLayouts();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            if (this.DialogResult == DialogResult.OK)
                SaveData();
        }

        private void SaveData()
        {
            CurrentProperty.AllowRestoreFormLayout = ceAllowRestoreFormLayout.Checked;
            CurrentProperty.AllowRestoreLayoutControlLayout = ceAllowRestoreLayoutControlLayout.Checked;
            CurrentProperty.AllowRestoreGridViewLayout = ceAllowRestoreGridViewLayout.Checked;
            CurrentProperty.AllowRestoreDockingLayout = ceAllowRestoreDockingLayout.Checked;
            CurrentProperty.DefaultEditGridViewInDetailForms = ceDefaultEditGridViewInDetailForms.Checked;
            layoutManager.Properties.Save();
        }
    }
}