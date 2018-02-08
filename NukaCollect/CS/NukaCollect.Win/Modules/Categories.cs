using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using NukaCollect.Resources;
using DevExpress.Xpo;
using DevExpress.XtraEditors;
using NukaCollect.Win.Controls;
using DevExpress.XtraGrid;
using DevExpress.Data;
using DevExpress.XtraGrid.Views.Base;
using NukaCollect.Helpers;
using DevExpress.XtraCharts;

namespace NukaCollect.Win.Modules {
    public partial class Categories : TutorialControl {
        bool lockUpdate = false;
        bool rowChangeDoOnce = false;

        protected internal override ViewType ChartViewType { get { return ViewType.Line; } }
        protected override ChartControl MainChart { get { return chartControl1; } }
        public override string EditObjectName { get { return ConstStrings.Get("MovieCategory"); } }
        public override string EditObjectsName { get { return ConstStrings.Get("MovieCategories"); } }
        protected override ColumnView MainView { get { return gvCategories; } }
        protected override DevExpress.XtraLayout.LayoutControl MainLayoutControl { get { return lcMain; } }
        protected override VideoRentBaseObject CurrentEditObject { get { return CurrentCategory; } }
        protected override bool AllowFlipLayout { get { return true; } }
        public override bool AllowModuleChange { 
            get {
                if(Session == null) return true;
                SaveData();
                return ucMovieCategoryDetail.ValidateData(); 
            } 
        }
        MovieCategory CurrentCategory {
            get {
                return gvCategories.GetRow(gvCategories.FocusedRowHandle) as MovieCategory;
            }
        }
        public Categories() {
            InitializeComponent();
            ElementConstStringLoader.LoadConstStringsForCategories(this);
            ((XYDiagram)this.chartControl1.Diagram).AxisX.Title.Text = ConstStrings.Get("DaysChart");
            ((XYDiagram)this.chartControl1.Diagram).AxisY.Title.Text = string.Format("{0} ({1})", ConstStrings.Get("Payment"), Application.CurrentCulture.NumberFormat.CurrencySymbol);
            foreach(Control item in lcMain.Controls)
                AddControl(item);
        }
        protected override void DoParentChanged() {
            base.DoParentChanged();
            ucMovieCategoryDetail.SetLayoutManager(MenuManager);
        }
        protected override void RefreshGridDataSource() {
            VideoRentBaseObject current = CurrentEditObject;
            gcCategories.Focus();
            gcCategories.DataSource = new XPCollection<MovieCategory>(Session);
            WinHelper.GridViewFocusObject(MainView, current);
            ucMovieCategoryDetail.SetFocus();
        }
        protected override void BeginRefreshData() {
            base.BeginRefreshData();
            RefreshGridDataSource();
        }
        protected override void DoShow() {
            base.DoShow();
            RefreshData();
            ucMovieCategoryDetail.Init(CurrentCategory, AllCategories);
            UpdateButtons();
            ParentFormMain.SaveCurrentRecordButton.Enabled = false;
        }
        protected void AddControl(Control item) {
            BaseEdit edit = item as BaseEdit;
            if(edit != null) {
                edit.MenuManager = lcMain.MenuManager;
                edit.EditValueChanged += new EventHandler(edit_EditValueChanged);
            }
            IEditsContainer editsContainer = item as IEditsContainer;
            if(editsContainer != null) editsContainer.EditValueChanged += new EventHandler(edit_EditValueChanged);
            GridControl grid = item as GridControl;
            if(grid != null) grid.MenuManager = lcMain.MenuManager;
        }
        void edit_EditValueChanged(object sender, EventArgs e) {
            ParentFormMain.SaveCurrentRecordButton.Enabled = true;
        }
        void FocusedRowChanged(int rowHandle) {
            if(rowChangeDoOnce) {
                rowChangeDoOnce = false;
                return;
            }
            if(!ucMovieCategoryDetail.ValidateData()) {
                rowChangeDoOnce = true;
                if(rowHandle >= 0)
                    gvCategories.FocusedRowHandle = rowHandle;
                return;
            }
            if(CurrentCategory != null) ShowCurrentCategory(rowHandle >= 0);
        }
        private void gvCategories_ColumnFilterChanged(object sender, EventArgs e) {
            FocusedRowChanged(-1);
        }
        private void gvCategories_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e) {
            if(lockUpdate) return;
            FocusedRowChanged(e.PrevFocusedRowHandle);
        }
        protected override void DoFocusedRowChanged() {
            UpdateButtons();
        }
        void UpdateButtons() {
            ParentFormMain.RibbonMenuController.SetAllowDelete(CurrentCategory == null || !CurrentCategory.IsDefault);
            ParentFormMain.RibbonMenuController.SetAllowNavigation(CurrentView.FocusedRowHandle > 0, !CurrentView.IsLastRow);
            SetChartData(CurrentCategory);
        }
        void SetChartData(MovieCategory current) {
            if(current == null) return;
            chartControl1.DataSource = current.GetPrices();
        }
        void ShowCurrentCategory(bool save) {
            if(save) {
                ucMovieCategoryDetail.SaveData();
            }
            ucMovieCategoryDetail.Init(CurrentCategory, AllCategories);
            ParentFormMain.SaveCurrentRecordButton.Enabled = false;
        }
        private XPCollection<MovieCategory> AllCategories { get { return (XPCollection<MovieCategory>)gcCategories.DataSource; } }
        void SaveData() {
            if(!ucMovieCategoryDetail.ValidateData()) return;
            Cursor.Current = Cursors.WaitCursor;
            ucMovieCategoryDetail.SaveData();
            try {
                SessionHelper.CommitSession(Session, null);
            }
            catch { }
            finally {
                Cursor.Current = Cursors.Default;
            }
            ParentFormMain.SaveCurrentRecordButton.Enabled = false;
        }
        public override void Add() {
            if(!ucMovieCategoryDetail.ValidateData()) return;
            lockUpdate = true;
            MovieCategory category = ucMovieCategoryDetail.CreateNewMovieCategory(Session, AllCategories);
            try {
                AllCategories.Add(category);
            }
            finally {
                lockUpdate = false;
            }
            WinHelper.GridViewFocusObject(gvCategories, category);
            ucMovieCategoryDetail.SetFocus();
            SaveData();
            UpdateButtons();
        }
        protected internal override bool Delete() {
            bool ret = base.Delete();
            ucMovieCategoryDetail.Init(CurrentCategory, AllCategories);
            UpdateButtons();
            return ret;
        }
        protected internal override void SaveCurrentRecord() {
            base.SaveCurrentRecord();
            SaveData();
            SetChartData(CurrentCategory);
        }
    }
}
