using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars.Ribbon.Drawing;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;

namespace NukaCollect.Win.Controls {
    public partial class RibbonApplicationUserControl : XtraUserControl {
        public RibbonApplicationUserControl() {
            InitializeComponent();
        }
        public BackstageViewControl BackstageView {
            get {
                if(Parent == null)
                    return null;
                return Parent.Parent as BackstageViewControl;
            }
        }
        protected override void OnPaint(PaintEventArgs e) {
            base.OnPaint(e);
            if(BackstageView != null)
                BackstageViewPainter.DrawBackstageViewImage(e, this, BackstageView);
        }
    }
}
