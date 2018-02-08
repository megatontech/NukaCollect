using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using NukaCollect.Win.Forms;
using DevExpress.XtraGrid.Views.BandedGrid.ViewInfo;
using DevExpress.Utils.Drawing;
using DevExpress.LookAndFeel;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.Xpo;
using DevExpress.XtraBars.Docking;
using DevExpress.XtraBars;
using DevExpress.XtraGrid.Localization;
using NukaCollect.Resources;

namespace NukaCollect.Win.Modules {
    public partial class Movies : GridExportTutorialControl {
        public Movies() {
            InitializeComponent();
            ElementConstStringLoader.LoadConstStringsForMovies(this);
        }
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        protected override void RefreshGridDataSource() {
            VideoRentBaseObject current = CurrentEditObject;
            gridControl1.DataSource = new XPCollection<Movie>(Session, null,
                new DevExpress.Xpo.SortProperty("[Title]", DevExpress.Xpo.DB.SortingDirection.Ascending));
            WinHelper.GridViewFocusObject(MainView, current);
        }
        protected override void BeginRefreshData() {
            base.BeginRefreshData();
            RefreshGridDataSource();
        }
        protected override ColumnView CurrentView { get { return gridControl1.MainView as ColumnView; } }
        public override string EditObjectName { get { return ConstStrings.Get("Movie"); } }
        public override string EditObjectsName { get { return ConstStrings.Get("Movies"); } }
        protected override ColumnView MainView { get { return advBandedGridView1; } }
        protected override ColumnView AlternateView { get { return layoutView1; } }
        protected override DockManager MainDockManager { get { return dockManager1; } }
        protected override VideoRentBaseObject CurrentEditObject { get { return CurrentMovie; } }
        protected override bool Landscape { get { return CurrentView == MainView; } }
        Movie CurrentMovie {
            get {
                if(CurrentView == null) return null;
                if(CurrentView.FocusedRowHandle < 0) return null;
                return CurrentView.GetRow(CurrentView.FocusedRowHandle) as Movie;
            }
        }
        protected override bool AllowEdit(DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitInfo info) {
            return IsButtonColumn(info.Column);
        }
        private void gridControl1_KeyDown(object sender, KeyEventArgs e) {
            if(e.KeyCode == Keys.Enter)
                EditMovie();
        }
        protected override void InitData() {
            base.InitData();
            riccbGenre.SetFlags(typeof(MovieGenre));
            colLanguage.ColumnEdit = EditorHelper.CreateLanguageLookUpEdit(Session, gridControl1.RepositoryItems, true);
            colRating.ColumnEdit = EditorHelper.CreateRatingImageComboBox(gridControl1.RepositoryItems);
            ucScreens1.InitParent(dpScreens);
            InitScreens();
            new GridViewImageTextToolTipController(advBandedGridView1, "PhotoExist", ConstStrings.Get("Info"), true, 120);
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
            WinHelper.GridViewFocusObject(CurrentView, currentObject as VideoRentBaseObject);
        }
        void EditMovie() {
            if(!IsDetailExist(CurrentMovie.Oid))
                ShowModuleDialog(new MovieDetail(this.FindForm(), GetSession, CurrentMovie, MenuManager, CloseDetailForm));
        }
        void AddMovie() {
            if(!IsDetailExist(Guid.Empty))
                ShowModuleDialog(new MovieDetail(this.FindForm(), GetSession, null, MenuManager, CloseDetailFormAndReload));
        }
        public override void Add() {
            base.Add();
            AddMovie();
        }
        public override void Edit() {
            base.Edit();
            EditMovie();
        }
        protected internal override bool Delete() {
            bool ret = base.Delete();
            InitScreens();
            return ret;
        }
        int downRowHandle = -1;
        int hotRowHandle = -1;
        int DownRowHandle {
            get { return downRowHandle; }
            set {
                if(downRowHandle == value) return;
                MainView.Invalidate();
                downRowHandle = value;
            }
        }
        int HotRowHandle {
            get { return hotRowHandle; }
            set {
                if(hotRowHandle == value) return;
                MainView.Invalidate();
                hotRowHandle = value;
            }
        }
        bool IsButtonColumn(GridColumn column) {
            if(column == null) return false;
            return "WebSite".Equals(column.FieldName);
        }
        private void advBandedGridView1_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e) {
            if(IsButtonColumn(e.Column)) {
                if(e.DisplayText != string.Empty) {
                    Rectangle rect = e.Bounds;
                    e.Appearance.ForeColor = LookAndFeelHelper.GetSystemColor(UserLookAndFeel.Default, SystemColors.ControlText);
                    e.Appearance.BackColor = SystemColors.Control;
                    StyleObjectInfoArgs obj = new StyleObjectInfoArgs(e.Cache, rect, e.Appearance);
                    if(DownRowHandle == e.RowHandle) 
                        obj.State = ObjectState.Pressed;
                    if(rect.Contains(gridControl1.PointToClient(new Point(MousePosition.X, MousePosition.Y))) 
                        && obj.State != ObjectState.Pressed) obj.State = ObjectState.Hot;
                    UserLookAndFeel.Default.Painter.Button.DrawObject(obj);
                    rect.Inflate(-4, 0);
                    UserLookAndFeel.Default.Painter.Button.DrawCaption(obj, ConstStrings.Get("LookupDetails"), e.Appearance.Font, e.Appearance.GetForeBrush(e.Cache), rect, e.Appearance.GetStringFormat());
                    e.Handled = true;
                }
            }
        }
        private void gridControl1_MouseDown(object sender, MouseEventArgs e) {
            BandedGridHitInfo info = advBandedGridView1.CalcHitInfo(new Point(e.X, e.Y));
            if(info.InRow && IsButtonColumn(info.Column))
                DownRowHandle = info.RowHandle;
            else DownRowHandle = -1;
        }
        private void gridControl1_MouseUp(object sender, MouseEventArgs e) {
            if(DownRowHandle != -1 && DownRowHandle == HotRowHandle)
                LinkButtonClick(MainView.GetRow(DownRowHandle) as Movie);
            DownRowHandle = -1;
        }
        private void gridControl1_MouseMove(object sender, MouseEventArgs e) {
            BandedGridHitInfo info = advBandedGridView1.CalcHitInfo(new Point(e.X, e.Y));
            if(info.InRow && IsButtonColumn(info.Column))
                HotRowHandle = info.RowHandle;
            else HotRowHandle = -1;
        }
        void LinkButtonClick(Movie movie) {
            ObjectHelper.ShowWebSite(movie.WebSite);
        }
        protected override void DoFocusedRowChanged() {
            base.DoFocusedRowChanged();
            InitScreens();
        }
        void InitScreens() {
            if(CurrentMovie == null || CurrentView.FocusedRowHandle < 0) 
                ucScreens1.InitData(null, null, FindForm());
            else
                ucScreens1.InitData(CurrentMovie.Pictures, CurrentMovie, FindForm());
        }
        protected override void LoadFormLayout() {
            base.LoadFormLayout();
            InitScreens();
        }
        string GetCardFilterValue(string filter) {
            int start = filter.IndexOf("%");
            if(start == -1) return string.Empty;
            int end = filter.IndexOf("%", start + 1);
            if(end == -1) return string.Empty;
            return filter.Substring(start + 1, end - start - 1);
        }
        protected internal override void ViewStylesPopup(object sender) {
            base.ViewStylesPopup(sender);
            ParentFormMain.MainViewButton.Caption = ConstStrings.Get("Grid");
            ParentFormMain.AlternateViewButton.Caption = ConstStrings.Get("Cards");
        }
        protected internal override void DoViewChange(bool mainView) {
            VideoRentBaseObject currentObject = CurrentMovie;
            gridControl1.MainView = mainView ? MainView : AlternateView;
            WinHelper.GridViewFocusObject(CurrentView, currentObject);
        }
        protected internal override void ShowMovieCategories() {
            using(frmMovieCategoriesList form = new frmMovieCategoriesList(this.FindForm(), Session, this.MenuManager)) {
                ObjectHelper.SetFormContainerSize(form, ((frmMain)FindForm()).ChildContainer);
                ObjectHelper.ShowFormDialog(form, this.FindForm());
            }
        }
        NukaCollect.Movie GetCurrentKey(object row) {
            return row as NukaCollect.Movie;
        }
        private void advBandedGridView1_CustomUnboundColumnData(object sender, CustomColumnDataEventArgs e) {
            NukaCollect.Movie key = GetCurrentKey(e.Row);
            if(e.Column == colInfo && e.IsGetData && key != null)
                e.Value = key.GetMovieInfoHtml();
        }

        private void advBandedGridView1_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e) {
            ObjectHelper.RemoveCustomizationItemsFromColumnMenu(e);
        }
    }
}
