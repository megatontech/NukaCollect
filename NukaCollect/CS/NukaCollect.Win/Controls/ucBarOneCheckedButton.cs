using DevExpress.Utils.Controls;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using System;
using System.Drawing;

namespace NukaCollect.Win.Controls
{
    public partial class ucBarOneCheckedButton : XtraUserControl, IXtraResizableControl
    {
        public class ChangeStateEventArgs : EventArgs
        {
            private bool isChecked;

            public ChangeStateEventArgs(bool isChecked) : base()
            {
                this.isChecked = isChecked;
            }

            public bool Checked { get { return isChecked; } }
        }

        public delegate void ChangeStateEventHandler(object sender, ChangeStateEventArgs e);

        public event ChangeStateEventHandler ChangeState;

        public ucBarOneCheckedButton()
        {
            InitializeComponent();
            ElementConstStringLoader.LoadConstStringsForUCBarOneCheckedButton(this);
        }

        public bool Checked
        {
            get { return bciSwitch.Checked; }
            set { bciSwitch.Checked = value; }
        }

        public string ButtonCaption
        {
            get { return bciSwitch.Caption; }
            set { bciSwitch.Caption = value; }
        }

        private void bciSwitch_CheckedChanged(object sender, ItemClickEventArgs e)
        {
            if (ChangeState != null) ChangeState(this, new ChangeStateEventArgs(Checked));
        }

        #region IXtraResizableControl Members

        public event EventHandler Changed;

        protected virtual void RaiseChanged()
        {
            if (Changed != null)
                Changed(this, EventArgs.Empty);
        }

        public bool IsCaptionVisible
        {
            get { return false; }
        }

        public Size MaxSize
        {
            get { return new Size(3000, ControlHeight); }
        }

        public Size MinSize
        {
            get { return new Size(170, ControlHeight); }
        }

        private int ControlHeight
        {
            get
            {
                if (mainBar == null || mainBar.Size.IsEmpty || mainBar.Size.Height == 0)
                    return 25;
                return mainBar.Size.Height;
            }
        }

        #endregion IXtraResizableControl Members
    }
}