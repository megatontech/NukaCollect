namespace NukaCollect.Win.Forms {
    partial class frmMovieItems {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition1 = new DevExpress.XtraGrid.StyleFormatCondition();
            this.colMovieItemId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcMovieItems = new DevExpress.XtraGrid.GridControl();
            this.gvMovieItems = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFormat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSellingPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAvailableForSell = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLocation = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barManager = new DevExpress.XtraBars.BarManager(this.components);
            this.barItems = new DevExpress.XtraBars.Bar();
            this.bbiAdd = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDelete = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.pcFormButtons = new DevExpress.XtraEditors.PanelControl();
            this.sbClose = new DevExpress.XtraEditors.SimpleButton();
            this.pnlAbout = new DevExpress.XtraEditors.PanelControl();
            this.ucMovieInfo1 = new NukaCollect.Win.Controls.ucMovieInfo();
            this.pnlGrid = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gcMovieItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMovieItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcFormButtons)).BeginInit();
            this.pcFormButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlAbout)).BeginInit();
            this.pnlAbout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlGrid)).BeginInit();
            this.pnlGrid.SuspendLayout();
            this.SuspendLayout();
            // 
            // colMovieItemId
            // 
            this.colMovieItemId.AppearanceCell.Options.UseTextOptions = true;
            this.colMovieItemId.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colMovieItemId.Caption = "#";
            this.colMovieItemId.DisplayFormat.FormatString = "d8";
            this.colMovieItemId.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colMovieItemId.FieldName = "MovieItemId";
            this.colMovieItemId.Name = "colMovieItemId";
            this.colMovieItemId.OptionsColumn.AllowEdit = false;
            this.colMovieItemId.OptionsColumn.AllowFocus = false;
            this.colMovieItemId.OptionsColumn.ReadOnly = true;
            this.colMovieItemId.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count;
            this.colMovieItemId.Visible = true;
            this.colMovieItemId.VisibleIndex = 0;
            this.colMovieItemId.Width = 126;
            // 
            // gcMovieItems
            // 
            this.gcMovieItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcMovieItems.Location = new System.Drawing.Point(6, 0);
            this.gcMovieItems.MainView = this.gvMovieItems;
            this.gcMovieItems.Name = "gcMovieItems";
            this.gcMovieItems.Size = new System.Drawing.Size(750, 363);
            this.gcMovieItems.TabIndex = 0;
            this.gcMovieItems.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvMovieItems});
            // 
            // gvMovieItems
            // 
            this.gvMovieItems.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMovieItemId,
            this.colStatus,
            this.colFormat,
            this.colSellingPrice,
            this.colAvailableForSell,
            this.colLocation});
            styleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            styleFormatCondition1.Appearance.Options.UseForeColor = true;
            styleFormatCondition1.ApplyToRow = true;
            styleFormatCondition1.Column = this.colMovieItemId;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
            styleFormatCondition1.Value1 = 0;
            this.gvMovieItems.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1});
            this.gvMovieItems.GridControl = this.gcMovieItems;
            this.gvMovieItems.GroupCount = 1;
            this.gvMovieItems.Name = "gvMovieItems";
            this.gvMovieItems.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvMovieItems.OptionsSelection.MultiSelect = true;
            this.gvMovieItems.OptionsView.ShowDetailButtons = false;
            this.gvMovieItems.OptionsView.ShowFooter = true;
            this.gvMovieItems.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colFormat, DevExpress.Data.ColumnSortOrder.Descending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colStatus, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gvMovieItems.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.gvMovieItems_SelectionChanged);
            this.gvMovieItems.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gvMovieItems_CellValueChanging);
            this.gvMovieItems.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.gvMovieItems_CustomDrawCell);
            this.gvMovieItems.ShowingEditor += new System.ComponentModel.CancelEventHandler(this.gvMovieItems_ShowingEditor);
            this.gvMovieItems.EndGrouping += new System.EventHandler(this.gvMovieItems_EndGrouping);
            this.gvMovieItems.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(this.gvMovieItems_PopupMenuShowing);
            // 
            // colStatus
            // 
            this.colStatus.FieldName = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.OptionsColumn.AllowEdit = false;
            this.colStatus.OptionsColumn.AllowFocus = false;
            this.colStatus.OptionsColumn.ReadOnly = true;
            this.colStatus.Visible = true;
            this.colStatus.VisibleIndex = 1;
            this.colStatus.Width = 176;
            // 
            // colFormat
            // 
            this.colFormat.FieldName = "Format";
            this.colFormat.Name = "colFormat";
            this.colFormat.OptionsColumn.AllowEdit = false;
            this.colFormat.OptionsColumn.AllowFocus = false;
            this.colFormat.OptionsColumn.ReadOnly = true;
            this.colFormat.Width = 180;
            // 
            // colSellingPrice
            // 
            this.colSellingPrice.DisplayFormat.FormatString = "c";
            this.colSellingPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSellingPrice.FieldName = "SellingPrice";
            this.colSellingPrice.Name = "colSellingPrice";
            this.colSellingPrice.Visible = true;
            this.colSellingPrice.VisibleIndex = 2;
            this.colSellingPrice.Width = 142;
            // 
            // colAvailableForSell
            // 
            this.colAvailableForSell.FieldName = "AvailableForSell";
            this.colAvailableForSell.Name = "colAvailableForSell";
            this.colAvailableForSell.Visible = true;
            this.colAvailableForSell.VisibleIndex = 3;
            this.colAvailableForSell.Width = 137;
            // 
            // colLocation
            // 
            this.colLocation.FieldName = "Location";
            this.colLocation.Name = "colLocation";
            this.colLocation.Visible = true;
            this.colLocation.VisibleIndex = 4;
            this.colLocation.Width = 148;
            // 
            // barManager
            // 
            this.barManager.AllowCustomization = false;
            this.barManager.AllowQuickCustomization = false;
            this.barManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.barItems});
            this.barManager.DockControls.Add(this.barDockControlTop);
            this.barManager.DockControls.Add(this.barDockControlBottom);
            this.barManager.DockControls.Add(this.barDockControlLeft);
            this.barManager.DockControls.Add(this.barDockControlRight);
            this.barManager.Form = this;
            this.barManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.bbiAdd,
            this.bbiDelete});
            this.barManager.MaxItemId = 2;
            // 
            // barItems
            // 
            this.barItems.BarName = "Main menu";
            this.barItems.DockCol = 0;
            this.barItems.DockRow = 0;
            this.barItems.DockStyle = DevExpress.XtraBars.BarDockStyle.Left;
            this.barItems.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiAdd),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiDelete)});
            this.barItems.OptionsBar.AllowQuickCustomization = false;
            this.barItems.OptionsBar.DrawDragBorder = false;
            this.barItems.OptionsBar.UseWholeRow = true;
            this.barItems.Text = "Main menu";
            // 
            // bbiAdd
            // 
            this.bbiAdd.Caption = "Add Item(s)";
            this.bbiAdd.Hint = "Add movie item(s)";
            this.bbiAdd.Id = 0;
            this.bbiAdd.Name = "bbiAdd";
            this.bbiAdd.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.bbiAdd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiAddItems_ItemClick);
            // 
            // bbiDelete
            // 
            this.bbiDelete.Caption = "Delete";
            this.bbiDelete.Hint = "Delete selected items";
            this.bbiDelete.Id = 1;
            this.bbiDelete.Name = "bbiDelete";
            this.bbiDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiDelete_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(786, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 505);
            this.barDockControlBottom.Size = new System.Drawing.Size(786, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Size = new System.Drawing.Size(24, 505);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(786, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 505);
            // 
            // pcFormButtons
            // 
            this.pcFormButtons.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pcFormButtons.Controls.Add(this.sbClose);
            this.pcFormButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pcFormButtons.Location = new System.Drawing.Point(24, 467);
            this.pcFormButtons.Name = "pcFormButtons";
            this.pcFormButtons.Padding = new System.Windows.Forms.Padding(8);
            this.pcFormButtons.Size = new System.Drawing.Size(762, 38);
            this.pcFormButtons.TabIndex = 5;
            // 
            // sbClose
            // 
            this.sbClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.sbClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.sbClose.Location = new System.Drawing.Point(671, 8);
            this.sbClose.Name = "sbClose";
            this.sbClose.Size = new System.Drawing.Size(83, 22);
            this.sbClose.TabIndex = 1;
            this.sbClose.Text = "&Close";
            // 
            // pnlAbout
            // 
            this.pnlAbout.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnlAbout.Controls.Add(this.ucMovieInfo1);
            this.pnlAbout.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAbout.Location = new System.Drawing.Point(24, 0);
            this.pnlAbout.Name = "pnlAbout";
            this.pnlAbout.Padding = new System.Windows.Forms.Padding(6);
            this.pnlAbout.Size = new System.Drawing.Size(762, 104);
            this.pnlAbout.TabIndex = 10;
            // 
            // ucMovieInfo1
            // 
            this.ucMovieInfo1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucMovieInfo1.Location = new System.Drawing.Point(6, 6);
            this.ucMovieInfo1.Name = "ucMovieInfo1";
            this.ucMovieInfo1.Size = new System.Drawing.Size(750, 92);
            this.ucMovieInfo1.TabIndex = 0;
            // 
            // pnlGrid
            // 
            this.pnlGrid.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnlGrid.Controls.Add(this.gcMovieItems);
            this.pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGrid.Location = new System.Drawing.Point(24, 104);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.pnlGrid.Size = new System.Drawing.Size(762, 363);
            this.pnlGrid.TabIndex = 11;
            // 
            // frmMovieItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.sbClose;
            this.ClientSize = new System.Drawing.Size(786, 505);
            this.Controls.Add(this.pnlGrid);
            this.Controls.Add(this.pnlAbout);
            this.Controls.Add(this.pcFormButtons);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMovieItems";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Movie Items";
            ((System.ComponentModel.ISupportInitialize)(this.gcMovieItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMovieItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcFormButtons)).EndInit();
            this.pcFormButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlAbout)).EndInit();
            this.pnlAbout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlGrid)).EndInit();
            this.pnlGrid.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcMovieItems;
        private DevExpress.XtraGrid.Views.Grid.GridView gvMovieItems;
        private DevExpress.XtraGrid.Columns.GridColumn colMovieItemId;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colFormat;
        private DevExpress.XtraGrid.Columns.GridColumn colSellingPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colAvailableForSell;
        private DevExpress.XtraBars.BarManager barManager;
        private DevExpress.XtraBars.Bar barItems;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem bbiAdd;
        private DevExpress.XtraBars.BarButtonItem bbiDelete;
        private DevExpress.XtraEditors.PanelControl pcFormButtons;
        private DevExpress.XtraEditors.SimpleButton sbClose;
        private DevExpress.XtraEditors.PanelControl pnlGrid;
        private DevExpress.XtraEditors.PanelControl pnlAbout;
        private NukaCollect.Win.Controls.ucMovieInfo ucMovieInfo1;
        private DevExpress.XtraGrid.Columns.GridColumn colLocation;
    }
}
