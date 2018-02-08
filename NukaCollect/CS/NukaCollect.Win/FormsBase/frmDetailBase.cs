using DevExpress.XtraEditors;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace NukaCollect.Win.Forms
{
    public partial class frmDetailBase : XtraForm, IFormWithLayoutManager
    {
        private Form parent;

        public frmDetailBase() : this(null)
        {
        }

        public frmDetailBase(Form parent)
        {
            InitializeComponent();
            ElementConstStringLoader.LoadConstStringsForFrmDetailBase(this);
            this.parent = parent;
        }

        public virtual FormLayoutManager LayoutManager
        {
            get
            {
                if (parent is IFormWithLayoutManager)
                    return ((IFormWithLayoutManager)parent).LayoutManager;
                return null;
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (parent == null) return;
            this.Location = new Point(parent.Left + (parent.Width - this.Width) / 2,
                parent.Top + (parent.Height - this.Height) / 2);
            LoadFormLayout();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            SaveFormLayout();
        }

        protected virtual void LoadFormLayout()
        {
            if (LayoutManager == null) return;
            LayoutManager.RestoreFormLayout(new FormLayoutInfo(this, null));
        }

        protected virtual void SaveFormLayout()
        {
            if (LayoutManager == null) return;
            LayoutManager.SaveFormLayout(new FormLayoutInfo(this, null));
        }

        private void sbOK_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        protected virtual void SaveData()
        {
        }
    }
}