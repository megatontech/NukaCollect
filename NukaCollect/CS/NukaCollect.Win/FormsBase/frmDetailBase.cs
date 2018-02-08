using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Xpo;
using DevExpress.XtraEditors.DXErrorProvider;
using DevExpress.Utils.Menu;
using DevExpress.XtraGrid;
using NukaCollect.Win.Controls;
using NukaCollect.Helpers;
using NukaCollect.Resources;

namespace NukaCollect.Win.Forms {
    public partial class frmDetailBase : XtraForm, IFormWithLayoutManager {
        Form parent;
        public frmDetailBase() : this(null) { }
        public frmDetailBase(Form parent) {
            InitializeComponent();
            ElementConstStringLoader.LoadConstStringsForFrmDetailBase(this);
            this.parent = parent;
        }
        public virtual FormLayoutManager LayoutManager { 
            get { 
                if(parent is IFormWithLayoutManager)
                    return ((IFormWithLayoutManager)parent).LayoutManager;
                return null;
            }
        }
        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            if(parent == null) return;
            this.Location = new Point(parent.Left + (parent.Width - this.Width) / 2,
                parent.Top + (parent.Height - this.Height) / 2);
            LoadFormLayout();
        }
        protected override void OnClosing(CancelEventArgs e) {
            base.OnClosing(e);
            SaveFormLayout();
        }
        protected virtual void LoadFormLayout() {
            if(LayoutManager == null) return;
            LayoutManager.RestoreFormLayout(new FormLayoutInfo(this, null));
        }
        protected virtual void SaveFormLayout() {
            if(LayoutManager == null) return;
            LayoutManager.SaveFormLayout(new FormLayoutInfo(this, null));
        }

        private void sbOK_Click(object sender, EventArgs e) {
            SaveData();
        }

        protected virtual void SaveData() {
        }
    }
}
