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
    public partial class frmArtistGridOptions : frmGridOptionsBase {
        public frmArtistGridOptions(Form parent, GridView view) : base(parent, ConstStrings.Get("ListViewOptions"), view) {
            InitializeComponent();
            ElementConstStringLoader.LoadConstStringsForFrmArtistGridOptions(this);
        }
        string FieldNames = "ArtistId, Gender"; 
        protected override void InitOptions() {
            base.InitOptions();
            cePreview.Checked = View.OptionsView.ShowPreview;
            ceVertLines.Checked = View.OptionsView.ShowVerticalLines != DevExpress.Utils.DefaultBoolean.False;
            ceAutoFilterRow.Checked = View.OptionsView.ShowAutoFilterRow;
            ceEditing.Checked = View.OptionsBehavior.Editable;
            ceAutoZoomDetail.Checked = View.OptionsDetail.AutoZoomDetail;
            ceMasterDetail.Checked = View.OptionsDetail.EnableMasterViewMode;
        }
        protected override void SetOptions() {
            base.SetOptions();
            View.OptionsView.ShowPreview = cePreview.Checked;
            View.OptionsView.ShowVerticalLines = ceVertLines.Checked ? DevExpress.Utils.DefaultBoolean.True : DevExpress.Utils.DefaultBoolean.False;
            View.OptionsView.ShowAutoFilterRow = ceAutoFilterRow.Checked;
            foreach(GridColumn column in View.Columns) {
                column.OptionsColumn.AllowFocus = ceEditing.Checked;
                if(FieldNames.IndexOf(column.FieldName) == -1)
                    column.OptionsColumn.AllowEdit = ceEditing.Checked;
            }
            View.OptionsBehavior.Editable = ceEditing.Checked;
            View.OptionsDetail.AutoZoomDetail = ceAutoZoomDetail.Checked;
            View.OptionsDetail.EnableMasterViewMode = ceMasterDetail.Checked;
        }
    }
}

