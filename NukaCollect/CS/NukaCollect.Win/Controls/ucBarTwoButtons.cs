using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.Utils.Controls;

namespace NukaCollect.Win.Controls {
    public partial class ucBarTwoButtons : XtraUserControl, IXtraResizableControl {
        public ucBarTwoButtons() {
            InitializeComponent();
            ElementConstStringLoader.LoadConstStringsForUCBarTwoButtons(this);
        }
        public event EventHandler Button0Click;
        public event EventHandler Button1Click;
        public string Button0Caption {
            get { return bbiButton0.Caption; }
            set { bbiButton0.Caption = value; }
        }
        public string Button1Caption {
            get { return bbiButton1.Caption; }
            set { bbiButton1.Caption = value; }
        }
        public Image Button0Glyph {
            get { return bbiButton0.Glyph; }
            set { bbiButton0.Glyph = value; }
        }
        public Image Button1Glyph {
            get { return bbiButton1.Glyph; }
            set { bbiButton1.Glyph = value; }
        }
        private void bbiButton0_ItemClick(object sender, ItemClickEventArgs e) {
            if(Button0Click != null) Button0Click(this, new EventArgs());
        }
        private void bbiButton1_ItemClick(object sender, ItemClickEventArgs e) {
            if(Button1Click != null) Button1Click(this, new EventArgs());
        }
        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            RaiseChanged();
        }
        #region IXtraResizableControl Members
        public event EventHandler Changed;
        protected virtual void RaiseChanged() {
            if(Changed != null)
                Changed(this, EventArgs.Empty);
        }
        public bool IsCaptionVisible {
            get { return false; }
        }
        public Size MaxSize {
            get { return new Size(3000, ControlHeight); }
        }
        public Size MinSize {
            get { return new Size(170, ControlHeight); }
        }
        int ControlHeight {
            get {
                if(mainBar == null || mainBar.Size.IsEmpty || mainBar.Size.Height == 0)
                    return 25;
                return mainBar.Size.Height;
            }
        }
        #endregion
    }
}
