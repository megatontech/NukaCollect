using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using NukaCollect.Resources;

namespace NukaCollect.Win.Forms {
    public partial class frmLayoutOptions : XtraForm {
        FormLayoutManager layoutManager;
        public frmLayoutOptions() {
            InitializeComponent();
            ElementConstStringLoader.LoadConstStringsForFrmLayoutOptions(this);
        }
        WinFormProperty CurrentProperty { get { return layoutManager.Properties.CurrentProperty; } }
        public frmLayoutOptions(FormLayoutManager layoutManager)
            : this() {
            this.layoutManager = layoutManager;
            InitData();
        }

        void InitData() {
            ceAllowRestoreFormLayout.Checked = CurrentProperty.AllowRestoreFormLayout;
            ceAllowRestoreLayoutControlLayout.Checked = CurrentProperty.AllowRestoreLayoutControlLayout;
            ceAllowRestoreGridViewLayout.Checked = CurrentProperty.AllowRestoreGridViewLayout;
            ceAllowRestoreDockingLayout.Checked = CurrentProperty.AllowRestoreDockingLayout;
            ceDefaultEditGridViewInDetailForms.Checked = CurrentProperty.DefaultEditGridViewInDetailForms;
        }
        
        private void sbClearLayouts_Click(object sender, EventArgs e) {
            layoutManager.ClearLayouts();
        }

        protected override void OnClosing(CancelEventArgs e) {
            base.OnClosing(e);
            if(this.DialogResult == DialogResult.OK) 
                SaveData();
        }

        void SaveData() {
            CurrentProperty.AllowRestoreFormLayout = ceAllowRestoreFormLayout.Checked;
            CurrentProperty.AllowRestoreLayoutControlLayout = ceAllowRestoreLayoutControlLayout.Checked;
            CurrentProperty.AllowRestoreGridViewLayout = ceAllowRestoreGridViewLayout.Checked;
            CurrentProperty.AllowRestoreDockingLayout = ceAllowRestoreDockingLayout.Checked;
            CurrentProperty.DefaultEditGridViewInDetailForms = ceDefaultEditGridViewInDetailForms.Checked;
            layoutManager.Properties.Save();
        }
    }
}
