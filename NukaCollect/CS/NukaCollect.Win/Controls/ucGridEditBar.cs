using DevExpress.Utils.Controls;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using NukaCollect.Resources;
using System;
using System.Drawing;

namespace NukaCollect.Win.Controls
{
    public partial class ucGridEditBar : XtraUserControl, IXtraResizableControl
    {
        public event EventHandler AddRecord;

        public event EventHandler DeleteRecord;

        private GridView view;

        public ucGridEditBar()
        {
            InitializeComponent();
            ElementConstStringLoader.LoadConstStringsForUCGridEditBar(this);
            bbiAdd.Glyph = ImagesHelper.Current.BarImages.Images[0];
            bbiDelete.Glyph = ImagesHelper.Current.BarImages.Images[2];
            bciAllowEditing.Glyph = ImagesHelper.Current.BarImages.Images[5];
        }

        public void Init(GridView view)
        {
            this.view = view;
            bciAllowEditing.Checked = view.OptionsBehavior.Editable;
            InitButtons();
            SetGridOptions();
            view.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(view_FocusedRowChanged);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            RaiseChanged();
        }

        public void SetAllowEditing(bool allow)
        {
            bciAllowEditing.Checked = allow;
        }

        private void view_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            InitButtons();
        }

        private void InitButtons()
        {
            bbiAdd.Enabled = bciAllowEditing.Checked;
            bbiDelete.Enabled = bciAllowEditing.Checked && view.GetRow(view.FocusedRowHandle) != null;
        }

        private void bciAllowEditing_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            InitButtons();
            SetGridOptions();
        }

        private void SetGridOptions()
        {
            view.OptionsBehavior.Editable = bciAllowEditing.Checked;
            view.OptionsView.ShowIndicator = bciAllowEditing.Checked;
            foreach (GridColumn column in view.Columns)
                column.OptionsColumn.AllowFocus = bciAllowEditing.Checked;
        }

        private void bbiAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (AddRecord != null) AddRecord(this, e);
        }

        private void bbiDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (DeleteRecord != null) DeleteRecord(this, e);
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

        internal void DasabledButtons()
        {
            bbiAdd.Enabled = bbiDelete.Enabled = bciAllowEditing.Enabled = false;
        }
    }
}