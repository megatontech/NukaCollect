using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace NukaCollect.Win.Forms
{
    public partial class frmGridOptionsBase : XtraForm
    {
        private GridView view;
        private Form parent;

        public frmGridOptionsBase()
        {
            InitializeComponent();
            ElementConstStringLoader.LoadConstStringsForFrmGridOptionsBase(this);
        }

        public frmGridOptionsBase(Form parent, string caption, GridView view) : this()
        {
            this.view = view;
            this.parent = parent;
            Text = caption;
        }

        public GridView View { get { return view; } }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (parent == null) return;
            InitOptions();
            this.Location = new Point(parent.Left + (parent.Width - this.Width) / 2,
                parent.Top + (parent.Height - this.Height) / 2);
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            if (DialogResult == DialogResult.OK)
                SetOptions();
        }

        protected virtual void InitOptions()
        {
        }

        protected virtual void SetOptions()
        {
        }
    }
}