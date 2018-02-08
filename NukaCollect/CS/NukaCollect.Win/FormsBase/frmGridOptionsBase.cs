using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Xpo;
using DevExpress.XtraGrid.Views.Grid;
using NukaCollect.Resources;

namespace NukaCollect.Win.Forms {
    public partial class frmGridOptionsBase : XtraForm {
        GridView view;
        Form parent;
        public frmGridOptionsBase() {
            InitializeComponent();
            ElementConstStringLoader.LoadConstStringsForFrmGridOptionsBase(this);
        }
        public frmGridOptionsBase(Form parent, string caption, GridView view) : this() {
            this.view = view;
            this.parent = parent;
            Text = caption;            
        }
        public GridView View { get { return view; } }
        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            if(parent == null) return;
            InitOptions();
            this.Location = new Point(parent.Left + (parent.Width - this.Width) / 2,
                parent.Top + (parent.Height - this.Height) / 2);
        }
        protected override void OnClosing(CancelEventArgs e) {
            base.OnClosing(e);
            if(DialogResult == DialogResult.OK) 
                SetOptions();
        }

        protected virtual void InitOptions() { }
        protected virtual void SetOptions() { }
    }
}
