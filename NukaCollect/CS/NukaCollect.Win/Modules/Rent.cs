using DevExpress.Data.Filtering;
using DevExpress.Utils;
using DevExpress.Xpo;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraReports.UI;
using NukaCollect.Helpers;
using NukaCollect.Resources;
using NukaCollect.Win.Forms;
using NukaCollect.Win.Reports;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace NukaCollect.Win.Modules
{
    public partial class Rent : GridExportTutorialControl
    {
        private Timer tmr;

        public Rent()
        {
            InitializeComponent();
            ElementConstStringLoader.LoadConstStringsForRent(this);
            GridViewInfo.DefaultMinVertTabDetailHeight = 0;
        }

        protected internal override bool UseList { get { return false; } }
        protected override bool AllowFlipLayout { get { return true; } }
        public override string EditObjectName { get { return ConstStrings.Get("Receipt"); } }
        public override string EditObjectsName { get { return ConstStrings.Get("Receipts"); } }
        protected override ColumnView MainView { get { return gvReceipts; } }
        protected override DevExpress.XtraLayout.LayoutControl MainLayoutControl { get { return lcMain; } }

        protected override BaseView ExportView
        {
            get
            {
                if (tcgViews.SelectedTabPage == lcgActiveRents)
                    return gvActiveRents;
                return base.ExportView;
            }
        }

        protected override string ExportFileName
        {
            get
            {
                if (tcgViews.SelectedTabPage == lcgActiveRents)
                    return ConstStrings.Get("ActiveRentals");
                return base.ExportFileName;
            }
        }

        protected override bool Landscape { get { return tcgViews.SelectedTabPage == lcgActiveRents; } }

        private Timer ModuleTimer
        {
            get
            {
                if (tmr == null)
                {
                    tmr = new Timer();
                    tmr.Interval = 100;
                    tmr.Tick += new EventHandler(tmr_Tick);
                }
                return tmr;
            }
        }

        protected override void DoParentChanged()
        {
            base.DoParentChanged();
            LayoutManager.CurrentCustomerChanged += new EventHandler(LayoutManager_CurrentCustomerChanged);
        }

        private void LayoutManager_CurrentCustomerChanged(object sender, EventArgs e)
        {
            ShowCurrentUser();
        }

        private void tmr_Tick(object sender, EventArgs e)
        {
            ModuleTimer.Stop();
            CheckCurrentUser();
        }

        protected internal override void ShowTutorial()
        {
            base.ShowTutorial();
            UpdateCustomer(false);
            ModuleTimer.Start();
        }

        private void RefreshCurrentCustomerInfo()
        {
            LayoutManager.CurrentCustomer.Reload();
            ucCustomerInfo1.Init(LayoutManager.CurrentCustomer, ConstStrings.Get("FindCustomerHint"), ConstStrings.Get("CustomerDetailTooltip"));
        }

        private void CheckCurrentUser()
        {
            if (LayoutManager.CurrentCustomer == null)
            {
                LayoutManager.ShowFindCustomerForm(this.FindForm(), MenuManager, false);
            }
            ShowCurrentUser();
        }

        private void ShowCurrentUser()
        {
            if (!this.Visible) return;
            UpdateCustomer(true);
        }

        private void UpdateCustomer(bool updateData)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                RefreshCurrentCustomerInfo();
                returningItems.Clear();
                UpdateBarButtons(true);
                if (!updateData) return;
                UpdateData();
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        protected override void BeginRefreshData()
        {
            base.BeginRefreshData();
            UpdateData();
        }

        private void UpdateData()
        {
            if (LayoutManager.CurrentCustomer == null)
            {
                gcReceipts.DataSource = null;
                gcActiveRents.DataSource = null;
                UpdateTabCaption(false);
            }
            else
            {
                gvReceipts.ViewCaption = string.Format(ConstStrings.Get("DatePeriodCaption"), PeriodManager.ReceiptPeriod.StartDate, PeriodManager.ReceiptPeriod.EndDate);
                XPCollection<Receipt> receipts = new XPCollection<Receipt>(LayoutManager.CurrentCustomer.Receipts,
                    new GroupOperator(GroupOperatorType.And,
                            new BinaryOperator(
                                "Date", PeriodManager.ReceiptPeriod.StartDate, BinaryOperatorType.GreaterOrEqual),
                            new BinaryOperator(
                                "Date", PeriodManager.ReceiptPeriod.EndDate, BinaryOperatorType.LessOrEqual)
                        ));
                gcReceipts.DataSource = receipts;
                gcActiveRents.DataSource = LayoutManager.CurrentCustomer.ActiveRents;
                UpdateTabCaption(LayoutManager.CurrentCustomer.ActiveRents.Count > 0);
            }
        }

        private void UpdateTabCaption(bool active)
        {
            lcgActiveRents.AppearanceTabPage.Header.Font = lcgActiveRents.AppearanceTabPage.HeaderActive.Font =
                lcgActiveRents.AppearanceTabPage.HeaderHotTracked.Font =
                active ? ElementHelper.FontBold : AppearanceObject.DefaultFont;
        }

        protected override void InitData()
        {
            base.InitData();
            colType.ColumnEdit = EditorHelper.CreateReceiptTypeImageComboBox(gcReceipts.RepositoryItems);
            colPayment.ColumnEdit = colPaymentRent.ColumnEdit = colDiscount.ColumnEdit = colPaymentActive.ColumnEdit =
                colPaymentSale.ColumnEdit = colOverduePayment.ColumnEdit = EditorHelper.CreatePaymentTextEdit(gcReceipts.RepositoryItems);
            colActiveType.ColumnEdit = EditorHelper.CreateActiveRentTypeImageComboBox(gcActiveRents.RepositoryItems);
            colItemFormat.ColumnEdit = EditorHelper.CreateMovieItemFormatImageComboBox(gcActiveRents.RepositoryItems);
            gvActiveRents.Images = ElementHelper.ColumnHeaderIcons;
            colActiveType.ImageIndex = 0;
            colReturn.ImageIndex = 1;
        }

        private void gvReceipts_EndGrouping(object sender, EventArgs e)
        {
            gvReceipts.ExpandAllGroups();
        }

        private void UpdateBarButtons(bool updateCheck)
        {
            RibbonMenuController.CalcRentItemsEnabling(LayoutManager.CurrentCustomer != null, returningItems.Count > 0);
            if (updateCheck)
                RibbonMenuController.CalcRentItemsEnablingEx(LayoutManager.CurrentCustomer != null && LayoutManager.CurrentCustomer.OverdueTodayItemsExist());
        }

        public override void EditOptions()
        {
            base.EditOptions();
            /*string ret = "";
            foreach(NukaCollect.Rent rent in returningItems.Keys)
                ret += rent.RentId.ToString() + "; ";
            XtraMessageBox.Show(ret);*/
            using (frmReceiptGridOptions frm = new frmReceiptGridOptions(this.FindForm(), gvReceipts, ConstStrings.Get("ReceiptsViewOptions")))
                frm.ShowDialog(this);
        }

        private void gvReceipts_MasterRowGetLevelDefaultView(object sender, MasterRowGetLevelDefaultViewEventArgs e)
        {
            GridView view = sender as GridView;
            Receipt receiptParent = view.GetRow(e.RowHandle) as Receipt;
            if (receiptParent == null) return;
            if (receiptParent.Type == ReceiptType.Purchases)
                e.DefaultView = gvSales;
        }

        private void gvReceipts_MasterRowGetRelationDisplayCaption(object sender, MasterRowGetRelationNameEventArgs e)
        {
            GridView view = sender as GridView;
            Receipt receiptParent = view.GetRow(e.RowHandle) as Receipt;
            if (receiptParent == null) return;
            e.RelationName = EnumTitlesKeeper<ReceiptType>.GetTitle(receiptParent.Type);
        }

        private Dictionary<NukaCollect.Rent, bool> returningItems = new Dictionary<NukaCollect.Rent, bool>();

        private void gvActiveRents_CustomUnboundColumnData(object sender, CustomColumnDataEventArgs e)
        {
            NukaCollect.Rent key = GetCurrentKey(e.Row);
            if (e.IsSetData)
            {
                if (returningItems.ContainsKey(key))
                    returningItems.Remove(key);
                if (Convert.ToBoolean(e.Value))
                    returningItems.Add(key, true);
                UpdateBarButtons(false);
            }
            if (e.IsGetData)
            {
                e.Value = returningItems.ContainsKey(key);
            }
        }

        private NukaCollect.Rent GetCurrentKey(object row)
        {
            return row as NukaCollect.Rent;
        }

        private void repositoryItemCheckEdit1_CheckStateChanged(object sender, EventArgs e)
        {
            gvActiveRents.CloseEditor();
        }

        private bool CurrentReturnLateFee
        {
            get
            {
                foreach (NukaCollect.Rent rent in returningItems.Keys)
                    if (rent.ActiveType == ActiveRentType.Overdue) return true;
                return false;
            }
        }

        protected internal override void ReturnMovie()
        {
            base.ReturnMovie();
            Receipt overdueReceipt = null;
            using (NestedUnitOfWork nestedSession = Session.BeginNestedUnitOfWork())
            {
                if (XtraMessageBox.Show(this.FindForm(), CurrentReturnLateFee ? ConstStrings.Get("ReturnAndPaymentLateFeeQuestion") : ConstStrings.Get("ReturnQuestion"), ConstStrings.Get("Question"), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    List<NukaCollect.Rent> returns = new List<NukaCollect.Rent>();
                    foreach (NukaCollect.Rent rent in returningItems.Keys)
                    {
                        returns.Add(SessionHelper.GetObject<NukaCollect.Rent>(rent, nestedSession));
                    }
                    Customer currentCustomer = SessionHelper.GetObject<Customer>(LayoutManager.CurrentCustomer, nestedSession);
                    overdueReceipt = currentCustomer.ReturnRents(returns);
                    SessionHelper.CommitSession(nestedSession, new ExceptionsProcesser(this.FindForm()));
                }
            }
            SessionHelper.CommitSession(Session, new ExceptionsProcesser(this.FindForm()));
            UpdateCustomer(true);
            ShowBill(overdueReceipt);
        }

        private void ShowBill(Receipt overdueReceipt)
        {
            if (overdueReceipt == null) return;
            lcMain.FocusHelper.PlaceItemIntoView(lciRecepts);
            gvReceipts.CollapseAllDetails();
            WinHelper.GridViewFocusObject(gvReceipts, overdueReceipt);
            gvReceipts.ExpandMasterRow(gvReceipts.FocusedRowHandle);
            Cursor.Current = Cursors.WaitCursor;
            XtraReport report = new LatefeeReceipt(gvReceipts.GetRow(gvReceipts.FocusedRowHandle) as Receipt);
            report.CreateDocument();
            ShowRibbonPreviewDialog(report);
            Cursor.Current = Cursors.Default;
        }

        protected internal override void RentMovie()
        {
            base.RentMovie();
            XtraMessageBox.Show("//TODO Rent");
        }

        protected internal override void CheckActiveItems()
        {
            base.CheckActiveItems();
            gvActiveRents.ActiveFilterString = string.Empty;
            lcMain.FocusHelper.PlaceItemIntoView(lciActiveRents);
            foreach (NukaCollect.Rent rent in LayoutManager.CurrentCustomer.ActiveRents)
            {
                if (rent.ActiveType != ActiveRentType.Active && !returningItems.ContainsKey(rent))
                    returningItems.Add(rent, true);
            }
            gvActiveRents.LayoutChanged();
            UpdateBarButtons(false);
        }

        protected override void CloseDetailForm(DialogResult result, object currentObject)
        {
            base.CloseDetailForm(result, currentObject);
            this.Refresh();
            if (result == DialogResult.OK) ShowCurrentUser();
        }

        private void ucCustomerInfo1_DoEdit(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (!IsDetailExist(LayoutManager.CurrentCustomer.Oid))
                ShowModuleDialog(new CustomerDetail(this.FindForm(), GetSession, LayoutManager.CurrentCustomer, MenuManager, CloseDetailForm));
            Cursor.Current = Cursors.Default;
        }
    }
}