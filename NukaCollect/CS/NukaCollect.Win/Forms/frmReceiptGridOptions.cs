using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;
using NukaCollect.Resources;

namespace NukaCollect.Win.Forms {
    public partial class frmReceiptGridOptions : frmGridOptionsBase {
        public frmReceiptGridOptions(Form parent, GridView view, string caption)
            : base(parent, caption, view) {
            InitializeComponent();
            ElementConstStringLoader.LoadConstStringsForFrmReceiptGridOptions(this);
        }
        protected override void InitOptions() {
            base.InitOptions();
            ceGroupRowFooter.Checked = View.OptionsView.GroupFooterShowMode == GroupFooterShowMode.VisibleIfExpanded;
            ceVertLines.Checked = View.OptionsView.ShowVerticalLines != DevExpress.Utils.DefaultBoolean.False;
            ceAutoFilterRow.Checked = View.OptionsView.ShowAutoFilterRow;
            ceIndicator.Checked = View.OptionsView.ShowIndicator;
            ceDetailTabs.Checked = View.OptionsDetail.ShowDetailTabs;
            ceViewCaption.Checked = View.OptionsView.ShowViewCaption;
        }
        protected override void SetOptions() {
            base.SetOptions();
            View.OptionsView.GroupFooterShowMode = ceGroupRowFooter.Checked ? GroupFooterShowMode.VisibleIfExpanded : GroupFooterShowMode.Hidden;
            View.OptionsView.ShowVerticalLines = ceVertLines.Checked ? DevExpress.Utils.DefaultBoolean.True : DevExpress.Utils.DefaultBoolean.False;
            View.OptionsView.ShowAutoFilterRow = ceAutoFilterRow.Checked;
            View.OptionsView.ShowIndicator = ceIndicator.Checked;
            View.OptionsDetail.ShowDetailTabs = ceDetailTabs.Checked;
            View.OptionsView.ShowViewCaption = ceViewCaption.Checked;
            SetDetailViewBorder();
        }

        void SetDetailViewBorder() {
            foreach(GridView view in View.GridControl.ViewCollection) {
                if(view != View)
                    view.BorderStyle = View.OptionsDetail.ShowDetailTabs ? DevExpress.XtraEditors.Controls.BorderStyles.NoBorder :
                        DevExpress.XtraEditors.Controls.BorderStyles.Default;
            }
        }
    }
}

