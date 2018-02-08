using DevExpress.Utils.Menu;
using DevExpress.Xpo;
using DevExpress.XtraEditors;
using NukaCollect.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace NukaCollect.Win.Forms
{
    public partial class frmMovieItems : XtraForm
    {
        private Movie movie;
        private IDXMenuManager manager;
        private UnitOfWork session;
        private bool allSelectedItemsAllowDelete = true;

        public frmMovieItems(UnitOfWork session, Movie movie, IDXMenuManager manager)
            : base()
        {
            InitializeComponent();
            ElementConstStringLoader.LoadConstStringsForFrmMovieItems(this);
            bbiAdd.Glyph = ImagesHelper.Current.BarImages.Images[1];
            bbiDelete.Glyph = ImagesHelper.Current.BarImages.Images[2];
            this.session = session;
            this.movie = movie;
            this.manager = manager;
            InitItemsGrid();
            InitData();
        }

        private void InitItemsGrid()
        {
            colFormat.ColumnEdit = EditorHelper.CreateMovieItemFormatImageComboBox(gcMovieItems.RepositoryItems);
            colStatus.ColumnEdit = EditorHelper.CreateMovieItemStatusImageComboBox(gcMovieItems.RepositoryItems);
            colLocation.ColumnEdit = EditorHelper.CreateLocationComboBox(gcMovieItems.RepositoryItems);
            colSellingPrice.ColumnEdit = EditorHelper.CreateMovieItemPriceSpinEdit(movie.Session, gcMovieItems.RepositoryItems);
        }

        private void InitData()
        {
            gcMovieItems.DataSource = movie.Items;
            ucMovieInfo1.Init(movie);
        }

        private void bbiAddItems_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (frmMovieAddItems form = new frmMovieAddItems(this, session, movie, manager))
            {
                form.ShowDialog();
                if (form.DialogResult == DialogResult.OK)
                {
                    if (form.MovieItems != null && form.MovieItems.Count != 0) movie.Items.AddRange(form.MovieItems);
                }
            }
        }

        private void gvMovieItems_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column == colAvailableForSell)
            {
                gvMovieItems.HideEditor();
                MovieItem item = gvMovieItems.GetRow(e.RowHandle) as MovieItem;
                item.AvailableForSell = (bool)e.Value;
                gvMovieItems.UpdateCurrentRow();
            }
            else if (e.Column == colSellingPrice)
            {
                MovieItem item = gvMovieItems.GetRow(e.RowHandle) as MovieItem;
                try
                {
                    item.SellingPrice = Convert.ToDecimal(e.Value);
                }
                catch { }
            }
        }

        private List<MovieItem> GetSelectedItems(bool unselectNotAllowDelete)
        {
            List<MovieItem> items = new List<MovieItem>();
            int[] select = gvMovieItems.GetSelectedRows();
            foreach (int rowHandle in select)
            {
                if (rowHandle < 0)
                {
                    gvMovieItems.UnselectRow(rowHandle);
                    continue;
                }
                MovieItem item = (MovieItem)gvMovieItems.GetRow(rowHandle);
                if (unselectNotAllowDelete && !item.AllowDelete)
                {
                    gvMovieItems.UnselectRow(rowHandle);
                    continue;
                }
                items.Add(item);
            }
            return items;
        }

        private void bbiDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!allSelectedItemsAllowDelete &&
                XtraMessageBox.Show(this.FindForm(), ConstStrings.Get("NotAllItemsCanBeDeleted"), ConstStrings.Get("Question"), MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;
            GetSelectedItems(true);
            gvMovieItems.DeleteSelectedRows();
        }

        private void gvMovieItems_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column == colMovieItemId && 0.Equals(e.CellValue))
                e.DisplayText = ConstStrings.Get("NewRecordsIDString");
            if (e.Column == colStatus && MovieItemStatus.Active.Equals(e.CellValue))
                e.Appearance.Font = ElementHelper.FontBold;
        }

        private void gvMovieItems_EndGrouping(object sender, EventArgs e)
        {
            gvMovieItems.ExpandAllGroups();
        }

        private void gvMovieItems_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            if (e.MenuType == DevExpress.XtraGrid.Views.Grid.GridMenuType.Summary && e.HitInfo.Column == colMovieItemId)
                e.Menu = null;
        }

        private void gvMovieItems_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            List<MovieItem> items = GetSelectedItems(false);
            allSelectedItemsAllowDelete = true;
            if (items.Count == 1)
            {
                bbiDelete.Enabled = items[0].AllowDelete;
                return;
            }
            bool someItemsAllowDelete = false;
            foreach (MovieItem item in items)
            {
                if (!item.AllowDelete)
                {
                    allSelectedItemsAllowDelete = false;
                    if (someItemsAllowDelete) break;
                }
                else
                {
                    someItemsAllowDelete = true;
                    if (!allSelectedItemsAllowDelete) break;
                }
            }
            bbiDelete.Enabled = someItemsAllowDelete;
        }

        private void gvMovieItems_ShowingEditor(object sender, CancelEventArgs e)
        {
            MovieItem item = gvMovieItems.GetRow(gvMovieItems.FocusedRowHandle) as MovieItem;
            if (item != null && item.Status == MovieItemStatus.Active) return;
            e.Cancel = true;
        }
    }
}