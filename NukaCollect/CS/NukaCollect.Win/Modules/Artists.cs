using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using NukaCollect.Win.Forms;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Card.ViewInfo;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.Xpo;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using NukaCollect.Resources;

namespace NukaCollect.Win.Modules {
    public partial class Artists : GridExportTutorialControl {
        public Artists() {
            InitializeComponent();
            ElementConstStringLoader.LoadConstStringsForArtists(this);
        }
        public override string EditObjectName { get { return ConstStrings.Get("Artist"); } }
        public override string EditObjectsName { get { return ConstStrings.Get("Artists"); } }
        protected override ColumnView MainView { get { return gridView1; } }
        protected override VideoRentBaseObject CurrentEditObject { get { return CurrentArtist; } }
        protected override bool Landscape { get { return true; } }
        Artist CurrentArtist {
            get {
                if(MainView.FocusedRowHandle < 0) return null;
                return MainView.GetRow(MainView.FocusedRowHandle) as Artist;
            }
        }
        protected override void RefreshGridDataSource() {
            VideoRentBaseObject current = CurrentEditObject;
            gridControl1.DataSource = new XPCollection<Artist>(Session, null, new DevExpress.Xpo.SortProperty("[LastName]", DevExpress.Xpo.DB.SortingDirection.Ascending));
            WinHelper.GridViewFocusObject(MainView, current);
        }
        protected override void BeginRefreshData() {
            base.BeginRefreshData();
            RefreshGridDataSource();
        }
        protected override void InitData() {
            base.InitData();
            colGender.ColumnEdit = EditorHelper.CreateGenderImageComboBox(gridControl1.RepositoryItems);
            colBirthCountry.ColumnEdit = EditorHelper.CreateCountryLookUpEdit(Session, gridControl1.RepositoryItems, true);
            new GridViewImageTextToolTipController(gridView1, ConstStrings.Get("Biography"), false);
        }
        public override void EditOptions() {
            base.EditOptions();
            using(frmArtistGridOptions frm = new frmArtistGridOptions(this.FindForm(), gridView1)) 
                frm.ShowDialog(this);
        }
        protected override void CloseDetailForm(DialogResult result, object currentObject) {
            base.CloseDetailForm(result, currentObject);
            if(result != DialogResult.Cancel) 
                RefreshData();
        }
        protected override void CloseDetailFormAndReload(DialogResult result, object currentObject) {
            base.CloseDetailFormAndReload(result, currentObject);
            if(result == DialogResult.Cancel) return;
            RefreshData();
            WinHelper.GridViewFocusObject(MainView, currentObject as VideoRentBaseObject);
        }
        void EditArtist() {
            if(!IsDetailExist(CurrentArtist.Oid))
                ShowModuleDialog(new ArtistDetail(this.FindForm(), GetSession, CurrentArtist, MenuManager, CloseDetailForm));
        }
        void AddArtist() {
            if(!IsDetailExist(Guid.Empty))
                ShowModuleDialog(new ArtistDetail(this.FindForm(), GetSession, null, MenuManager, CloseDetailFormAndReload));
        }
        public override void Add() {
            base.Add();
            AddArtist();
        }
        public override void Edit() {
            base.Edit();
            EditArtist();
        }

        private void cardView1_CalcFieldHeight(object sender, DevExpress.XtraGrid.Views.Card.FieldHeightEventArgs e) {
            int maxHeigh = gridControl1.Height / 2;
            if(e.FieldHeight > maxHeigh)
                e.FieldHeight = maxHeigh;
        }

        private void gridView1_MasterRowGetRelationDisplayCaption(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationNameEventArgs e) {
            e.RelationName = NukaCollect.Resources.Properties.Resources.Pictures;
        }
    }
}
