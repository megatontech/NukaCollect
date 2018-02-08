using DevExpress.Utils;
using DevExpress.Xpo;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Base;
using NukaCollect.Resources;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace NukaCollect.Win.Modules
{
    public partial class Customers : GridExportTutorialControl
    {
        public Customers()
        {
            InitializeComponent();
            ElementConstStringLoader.LoadConstStringsForCustomers(this);
        }

        public override string EditObjectName { get { return ConstStrings.Get("Customer"); } }
        public override string EditObjectsName { get { return ConstStrings.Get("Customers"); } }

        protected override void RefreshGridDataSource()
        {
            VideoRentBaseObject current = CurrentEditObject;
            gridControl1.DataSource = new XPCollection<Customer>(Session, null, new DevExpress.Xpo.SortProperty("[CustomerId]", DevExpress.Xpo.DB.SortingDirection.Ascending));
            WinHelper.GridViewFocusObject(MainView, current);
        }

        protected override void BeginRefreshData()
        {
            base.BeginRefreshData();
            RefreshGridDataSource();
        }

        protected override ColumnView MainView { get { return advBandedGridView1; } }
        protected override ColumnView CurrentView { get { return gridControl1.MainView as ColumnView; } }
        protected override ColumnView AlternateView { get { return gridView1; } }
        protected override VideoRentBaseObject CurrentEditObject { get { return CurrentCustomer; } }
        protected override bool Landscape { get { return true; } }

        private Customer CurrentCustomer
        {
            get
            {
                if (CurrentView == null || CurrentView.FocusedRowHandle < 0) return null;
                return CurrentView.GetRow(CurrentView.FocusedRowHandle) as Customer;
            }
        }

        protected override void InitData()
        {
            base.InitData();
            xcCustomers.Session = Session;
            colGender.ColumnEdit = EditorHelper.CreateGenderImageComboBox(null, false, gridControl1.RepositoryItems);
            colGender2.ColumnEdit = EditorHelper.CreateGenderImageComboBox(null, true, gridControl1.RepositoryItems);
            colCustomerId.ColumnEdit = EditorHelper.CreateCardNumberTextEdit(gridControl1.RepositoryItems);
            colCardNumber.ColumnEdit = EditorHelper.CreateCardNumberTextEdit(gridControl1.RepositoryItems);
            colLevel.ColumnEdit = EditorHelper.CreateDiscountLevelImageComboBox(gridControl1.RepositoryItems);
            new GridViewImageTextToolTipController(advBandedGridView1, "Photo");
            new GridViewImageTextToolTipController(gridView1, "Photo");
            new GridViewImageTextToolTipController(gridView1, "Comments", false);
            gridView1.Images = ElementHelper.ColumnHeaderIcons;
            colGender2.ImageIndex = 2;
        }

        protected internal override bool Delete()
        {
            if (CurrentCustomer.AllowDelete)
            {
                Guid customerId = CurrentCustomer.Oid;
                if (base.Delete())
                {
                    if (LayoutManager.CurrentCustomer != null && LayoutManager.CurrentCustomerId == customerId)
                        LayoutManager.CurrentCustomer = null;
                }
            }
            else XtraMessageBox.Show(this.FindForm(), string.Format(ConstStrings.Get("CannotDeleteCustomer"), CurrentCustomer.FullName), ConstStrings.Get("Information"), MessageBoxButtons.OK, MessageBoxIcon.Information);
            return false;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            gridControl1.ForceInitialize();
            CurrentView.FocusedRowHandle = GridControl.AutoFilterRowHandle;
        }

        private void advBandedGridView1_CustomDrawColumnHeader(object sender, DevExpress.XtraGrid.Views.Grid.ColumnHeaderCustomDrawEventArgs e)
        {
            if (e.Column != null && e.Column == CurrentView.FocusedColumn)
            {
                e.Appearance.Font = ElementHelper.FontBold;
            }
            else e.Appearance.Font = AppearanceObject.DefaultFont;
        }

        private void advBandedGridView1_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            InitFocusedRow();
        }

        private void InitFocusedRow()
        {
            if (CurrentView.FocusedRowHandle == GridControl.AutoFilterRowHandle)
            {
                MainView.FocusedColumn = colName1;
                AlternateView.FocusedColumn = colName;
            }
            else if (CurrentView.FocusedRowHandle >= 0)
            {
                CurrentView.FocusedColumn = null;
                CurrentView.Invalidate();
            }
        }

        private void advBandedGridView1_FocusedColumnChanged(object sender, FocusedColumnChangedEventArgs e)
        {
            if (CurrentView.FocusedRowHandle == GridControl.AutoFilterRowHandle)
                CurrentView.Invalidate();
        }

        protected override void CloseDetailFormAndReload(DialogResult result, object currentObject)
        {
            base.CloseDetailFormAndReload(result, currentObject);
            if (result == DialogResult.Cancel) return;
            RefreshGridDataSource();
            WinHelper.GridViewFocusObject(CurrentView, currentObject as VideoRentBaseObject);
        }

        private void EditCustomer()
        {
            if (!IsDetailExist(CurrentCustomer.Oid))
                ShowModuleDialog(new CustomerDetail(this.FindForm(), GetSession, CurrentCustomer, MenuManager, CloseDetailForm));
        }

        private void AddCustomer()
        {
            if (!IsDetailExist(Guid.Empty))
                ShowModuleDialog(new CustomerDetail(this.FindForm(), GetSession, null, MenuManager, CloseDetailFormAndReload));
        }

        public override void Add()
        {
            base.Add();
            AddCustomer();
        }

        public override void Edit()
        {
            base.Edit();
            EditCustomer();
        }

        private void advBandedGridView1_CustomDrawCell(object sender, RowCellCustomDrawEventArgs e)
        {
            if (e.Column != colPhoto) return;
            if (e.CellValue == null)
            {
                e.Cache.Graphics.DrawImage(ReferenceImages.UnknownPerson_Small,
                    ImageCreator.GetZoomDestRectangle(e.Bounds, ReferenceImages.UnknownPerson_Small),
                    new Rectangle(0, 0, ReferenceImages.UnknownPerson_Small.Width, ReferenceImages.UnknownPerson_Small.Height), GraphicsUnit.Pixel);
                e.Handled = true;
            }
        }

        protected internal override void ViewStylesPopup(object sender)
        {
            base.ViewStylesPopup(sender);
            ParentFormMain.MainViewButton.Caption = ConstStrings.Get("AdvancedGrid");
            ParentFormMain.AlternateViewButton.Caption = ConstStrings.Get("SimpleGrid");
        }

        protected internal override void DoViewChange(bool mainView)
        {
            VideoRentBaseObject currentObject = CurrentCustomer;
            string filter = CurrentView.ActiveFilterString;
            gridControl1.MainView = mainView ? MainView : AlternateView;
            InitFocusedRow();
            WinHelper.GridViewFocusObject(CurrentView, currentObject);
            CurrentView.ActiveFilterString = filter;
        }

        private void advBandedGridView1_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            ObjectHelper.RemoveCustomizationItemsFromColumnMenu(e);
        }
    }
}