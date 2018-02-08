using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.Utils;
using DevExpress.Utils.Drawing;
using DevExpress.Utils.Drawing.Helpers;
using DevExpress.Utils.Win;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraCharts;
using DevExpress.XtraCharts.Localization;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraPivotGrid;
using NukaCollect.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace NukaCollect.Win
{
    public class GridViewImageTextToolTipController : IDisposable
    {
        private string fieldName = null;
        private string dataName = null;
        private GridView view;
        private ToolTipController controller;
        private GridHitInfo hotTrackInfo = null;
        private bool isImage = true;
        private int pictureMaxLineSize = 300;

        public GridViewImageTextToolTipController(GridView view, string fieldName) : this(view, fieldName, true)
        {
        }

        public GridViewImageTextToolTipController(GridView view, string fieldName, bool image) : this(view, fieldName, null, image)
        {
        }

        public GridViewImageTextToolTipController(GridView view, string fieldName, string dataName, bool image) : this(view, fieldName, dataName, image, 0)
        {
        }

        public GridViewImageTextToolTipController(GridView view, string fieldName, string dataName, bool image, int pictureMaxLineSize)
        {
            this.view = view;
            this.fieldName = fieldName;
            this.dataName = dataName;
            this.isImage = image;
            this.view.Disposed += new EventHandler(delegate { Dispose(); });
            if (pictureMaxLineSize > 0)
                this.pictureMaxLineSize = pictureMaxLineSize;
            controller = new ToolTipController();
            controller.ToolTipType = ToolTipType.SuperTip;
            controller.AllowHtmlText = dataName != null;
            controller.ReshowDelay = controller.InitialDelay;
            if (dataName != null || !isImage)
                controller.AutoPopDelay = 10000;
            if (view.GridControl == null) return;
            view.GridControl.MouseMove += new System.Windows.Forms.MouseEventHandler(GridControl_MouseMove);
            view.TopRowChanged += new EventHandler(view_TopRowChanged);
            view.ShownEditor += new EventHandler(delegate { controller.HideHint(); });
            view.GridControl.MouseDown += new MouseEventHandler(delegate { controller.HideHint(); });
            view.GridControl.MouseLeave += new EventHandler(delegate { controller.HideHint(); });
        }

        public GridHitInfo HotTrackInfo
        {
            get { return hotTrackInfo; }
            set
            {
                if (!value.InRowCell)
                {
                    controller.HideHint();
                    hotTrackInfo = null;
                    return;
                }
                if (hotTrackInfo != null &&
                    hotTrackInfo.Column == value.Column &&
                    hotTrackInfo.RowHandle == value.RowHandle) return;
                hotTrackInfo = value;
                ShowToolTip();
            }
        }

        private bool IsEditing
        {
            get
            {
                return view.ActiveEditor != null &&
                    HotTrackInfo.Column == view.FocusedColumn &&
                    HotTrackInfo.RowHandle == view.FocusedRowHandle;
            }
        }

        private void ShowToolTip()
        {
            if (!HotTrackInfo.InRowCell || HotTrackInfo.Column.FieldName != fieldName ||
                IsEditing)
            {
                controller.HideHint();
                return;
            }
            ToolTipControlInfo info = new ToolTipControlInfo();
            ToolTipItem item = new ToolTipItem();
            item.ImageToTextDistance = 0;
            if (isImage)
            {
                item.Image = ImageCreator.CreateImage(
                    view.GetRowCellValue(HotTrackInfo.RowHandle, HotTrackInfo.Column) as Image,
                    pictureMaxLineSize, pictureMaxLineSize);
                if (dataName != null)
                {
                    item.Text = string.Format("{0}", view.GetRowCellValue(HotTrackInfo.RowHandle, view.Columns[dataName]));
                    item.ImageToTextDistance = 10;
                }
            }
            else
                item.Text = string.Format("{0}", view.GetRowCellValue(HotTrackInfo.RowHandle, HotTrackInfo.Column));
            info.Object = HotTrackInfo;
            info.SuperTip = new SuperToolTip();
            info.SuperTip.Items.Add(item);
            info.ToolTipPosition = Cursor.Position;
            controller.ShowHint(info);
        }

        private void GridControl_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            HotTrackInfo = view.CalcHitInfo(e.X, e.Y);
        }

        private void view_TopRowChanged(object sender, EventArgs e)
        {
            controller.HideHint();
            HotTrackInfo = view.CalcHitInfo(view.GridControl.PointToClient(Cursor.Position));
        }

        #region IDisposable Members

        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                this.controller.Dispose();
            }
        }

        ~GridViewImageTextToolTipController()
        {
            Dispose(false);
        }

        #endregion IDisposable Members
    }

    public class ObjectToolTipController : IDisposable
    {
        private ToolTipController controller;
        private Control parent;
        private object editObject;
        public object EditObject { get { return editObject; } }

        public ObjectToolTipController(Control parent)
        {
            this.parent = parent;
            this.parent.Disposed += new EventHandler(delegate { Dispose(); });
            this.controller = new ToolTipController();
            this.controller.ToolTipType = ToolTipType.SuperTip;
            this.controller.AllowHtmlText = true;
            this.controller.ReshowDelay = controller.InitialDelay;
            this.controller.AutoPopDelay = 10000;
            parent.MouseDown += new MouseEventHandler(delegate { HideHint(false); });
            parent.MouseLeave += new EventHandler(delegate { HideHint(true); });
            if (parent is PivotGridControl)
                ((PivotGridControl)parent).LeftTopCellChanged += new EventHandler<PivotLeftTopCellChangedEventArgs>(delegate { HideHint(true); });
        }

        public void ShowHint(object editObject, Point location)
        {
            if (object.Equals(editObject, this.editObject)) return;
            this.editObject = editObject;
            ToolTipControlInfo info = new ToolTipControlInfo();
            ToolTipItem item = new ToolTipItem();
            InitToolTipItem(item);
            item.ImageToTextDistance = 10;
            info.Object = DateTime.Now.Ticks;
            info.SuperTip = new SuperToolTip();
            info.SuperTip.Items.Add(item);
            info.ToolTipPosition = this.parent.PointToScreen(location);
            controller.ShowHint(info);
        }

        protected virtual void InitToolTipItem(ToolTipItem item)
        {
        }

        public void HideHint(bool clearCurrentObject)
        {
            if (clearCurrentObject) this.editObject = null;
            this.controller.HideHint();
        }

        #region IDisposable Members

        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                this.controller.Dispose();
            }
        }

        ~ObjectToolTipController()
        {
            Dispose(false);
        }

        #endregion IDisposable Members
    }

    public class CustomerDiscountLevelToolTipController : ObjectToolTipController
    {
        public CustomerDiscountLevelToolTipController(Control parent) : base(parent)
        {
        }

        protected override void InitToolTipItem(ToolTipItem item)
        {
            if (EditObject == null) return;
            CustomerDiscountLevel currentLevel = (CustomerDiscountLevel)EditObject;
            item.Text = string.Format(ConstStrings.Get("CustomerDiscountLevelToolTipHtml"), EnumTitlesKeeper<CustomerDiscountLevel>.GetTitle(currentLevel),
                ReferenceData.GetDiscount(currentLevel), ReferenceData.CustomerDiscountLevel[(int)currentLevel]);
        }
    }

    public class CustomerToolTipController : ObjectToolTipController
    {
        private const int MaxPhotoWidth = 120, MaxPhotoHeight = 120;

        public CustomerToolTipController(Control parent) : base(parent)
        {
        }

        private Customer CurrentCustomer
        { get { return EditObject as Customer; } }

        protected override void InitToolTipItem(ToolTipItem item)
        {
            if (CurrentCustomer == null) return;
            if (CurrentCustomer.PhotoExist != null)
                item.Image = ImageCreator.CreateImage(CurrentCustomer.PhotoExist, MaxPhotoWidth, MaxPhotoHeight);
            item.Text = CurrentCustomer.GetCustomerInfoHtml();
        }
    }

    public class MovieToolTipController : ObjectToolTipController
    {
        private int MaxPhotoWidth = 100, MaxPhotoHeight = 120;

        public MovieToolTipController(Control parent) : base(parent)
        {
        }

        private Movie CurrentMovie
        { get { return EditObject as Movie; } }

        protected override void InitToolTipItem(ToolTipItem item)
        {
            if (CurrentMovie == null) return;
            if (CurrentMovie.PhotoExist != null)
                item.Image = ImageCreator.CreateImage(CurrentMovie.PhotoExist, MaxPhotoWidth, MaxPhotoHeight);
            item.Text = CurrentMovie.GetMovieInfoHtml();
        }
    }

    public delegate void ChartAppearanceEventHandler(object sender, ChartAppearanceEventArgs e);

    public class ChartAppearanceEventArgs : EventArgs
    {
        private string palette, appearance;
        private int color;

        public ChartAppearanceEventArgs(string palette, string appearance, int color)
        {
            this.palette = palette;
            this.appearance = appearance;
            this.color = color;
        }

        public string PaletteName { get { return palette; } }
        public string AppearanceName { get { return appearance; } }
        public int ColorIndex { get { return color; } }
    }

    public class ChartAppearanceManager
    {
        private ChartControl chartControl;
        private GalleryDropDown paletteGallery;
        private RibbonGalleryBarItem styleGalleryBarItem;
        private BarButtonItem paletteButton;
        private ViewType viewType = ViewType.Bar;

        public event ChartAppearanceEventHandler StyleChanged;

        public ChartAppearanceManager(GalleryDropDown paletteGallery, RibbonGalleryBarItem styleGalleryBarItem, BarButtonItem paletteButton)
        {
            this.paletteGallery = paletteGallery;
            this.styleGalleryBarItem = styleGalleryBarItem;
            this.paletteButton = paletteButton;
            chartControl = new ChartControl();
            this.paletteGallery.GalleryItemClick += new GalleryItemClickEventHandler(paletteGallery_GalleryItemClick);
            this.styleGalleryBarItem.GalleryInitDropDownGallery += new InplaceGalleryEventHandler(styleGalleryBarItem_GalleryInitDropDownGallery);
            this.styleGalleryBarItem.GalleryPopupClose += new InplaceGalleryEventHandler(styleGalleryBarItem_GalleryPopupClose);
            this.styleGalleryBarItem.GalleryItemClick += new GalleryItemClickEventHandler(styleGalleryBarItem_GalleryItemClick);
            InitChartPaletteGallery(this.paletteGallery);
            UserLookAndFeel.Default.StyleChanged += new EventHandler(Default_StyleChanged);

            //InitChartAppearanceGallery(this.styleGalleryBarItem, chart.PaletteName);
        }

        public ViewType ViewType
        {
            get { return viewType; }
            set
            {
                if (ViewType == value) return;
                viewType = value;
                InitChartAppearanceGallery(styleGalleryBarItem, chartControl.PaletteName);
            }
        }

        private void Default_StyleChanged(object sender, EventArgs e)
        {
            InitChartAppearanceGallery(styleGalleryBarItem, chartControl.PaletteName);
        }

        private void styleGalleryBarItem_GalleryPopupClose(object sender, InplaceGalleryEventArgs e)
        {
            List<GalleryItem> items = e.Item.Gallery.GetCheckedItems();
            if (items.Count > 0)
            {
                e.Item.Gallery.MakeVisible(items[0]);
                UpdateStyle();
            }
        }

        private void styleGalleryBarItem_GalleryInitDropDownGallery(object sender, InplaceGalleryEventArgs e)
        {
            e.PopupGallery.ItemCheckMode = DevExpress.XtraBars.Ribbon.Gallery.ItemCheckMode.SingleRadio;
            e.PopupGallery.ColumnCount = 7;
            e.PopupGallery.DrawImageBackground = true;
            e.PopupGallery.ShowGroupCaption = true;
            e.PopupGallery.SynchWithInRibbonGallery = true;
            e.PopupGallery.AutoSize = GallerySizeMode.Vertical;
        }

        private void paletteGallery_GalleryItemClick(object sender, GalleryItemClickEventArgs e)
        {
            chartControl.PaletteName = e.Item.Caption;
            UpdateStyle(true);
        }

        private void styleGalleryBarItem_GalleryItemClick(object sender, GalleryItemClickEventArgs e)
        {
            UpdateStyle();
        }

        private void UpdateStyle()
        {
            UpdateStyle(false);
        }

        private static int GetPaletteColor(Palette palette, int value)
        {
            if (value < 0) return 0;
            if (value >= palette.Count) return palette.Count - 1;
            return value;
        }

        private void UpdateStyle(bool updateAppearance)
        {
            string currentPalette = chartControl.PaletteName;
            chartControl.AppearanceName = CurrentAppearanceName;
            chartControl.PaletteBaseColorNumber = GetPaletteColor(chartControl.PaletteRepository[chartControl.PaletteName], CurrentPaletteColor);
            if (currentPalette != chartControl.PaletteName || updateAppearance)
                InitChartAppearanceGallery(this.styleGalleryBarItem, chartControl.PaletteName);
            UpdateCurrentPalette();
            RaiseCtyleChanged();
        }

        private void RaiseCtyleChanged()
        {
            if (StyleChanged != null) StyleChanged(this, new ChartAppearanceEventArgs(PaletteName, AppearanceName, ColorIndex));
        }

        public string PaletteName
        {
            get { return chartControl.PaletteName; }
            set { chartControl.PaletteName = value; }
        }

        public string AppearanceName
        {
            get { return chartControl.AppearanceName; }
            set { chartControl.AppearanceName = value; }
        }

        public int ColorIndex
        {
            get { return chartControl.PaletteBaseColorNumber; }
            set { chartControl.PaletteBaseColorNumber = value; }
        }

        #region CurrentStyle

        private string CurrentAppearanceName
        {
            get
            {
                List<GalleryItem> innerCheckedList = this.styleGalleryBarItem.Gallery.GetCheckedItems();
                return innerCheckedList[0].Caption;
            }
        }

        private int CurrentPaletteColor
        {
            get
            {
                List<GalleryItem> innerCheckedList = this.styleGalleryBarItem.Gallery.GetCheckedItems();
                return (int)innerCheckedList[0].Tag;
            }
        }

        #endregion CurrentStyle

        #region InitData

        private void InitChartPaletteGallery(GalleryDropDown gallery)
        {
            gallery.Gallery.DestroyItems();
            string[] paletteNames = chartControl.GetPaletteNames();
            gallery.Gallery.BeginUpdate();
            for (int i = 0; i < paletteNames.Length; i++)
            {
                GalleryItem gPaletteItem = new GalleryItem();
                gPaletteItem.Caption = paletteNames[i];
                gPaletteItem.Hint = paletteNames[i];
                gPaletteItem.Image = CreateEditorImage(chartControl.PaletteRepository[paletteNames[i]]);
                gallery.Gallery.Groups[0].Items.Add(gPaletteItem);
            }
            gallery.Gallery.EndUpdate();
            UpdateCurrentPalette();
        }

        public void UpdateCurrentPalette()
        {
            List<GalleryItem> innerList = this.paletteGallery.Gallery.GetAllItems();
            foreach (GalleryItem item in innerList)
            {
                if (item.Caption == chartControl.PaletteName)
                {
                    paletteGallery.Gallery.SetItemCheck(item, true, true);
                    paletteButton.Hint = string.Format(ConstStrings.Get("PaletteButtonHint"), chartControl.PaletteName);
                    return;
                }
            }
        }

        public void UpdateCurrentAppearance()
        {
            InitChartAppearanceGallery(this.styleGalleryBarItem, chartControl.PaletteName);
        }

        private void InitChartAppearanceGallery(RibbonGalleryBarItem galleryBarItem, string paletteName)
        {
            GalleryItem checkedItem = null;
            galleryBarItem.Gallery.DestroyItems();
            galleryBarItem.Gallery.Groups.Clear();
            Palette palette = chartControl.PaletteRepository[paletteName];
            galleryBarItem.Gallery.BeginUpdate();
            foreach (ChartAppearance appearance in chartControl.AppearanceRepository)
            {
                Palette currentPalette = chartControl.PaletteRepository[chartControl.PaletteName];
                if (!appearance.IsDefault && !String.IsNullOrEmpty(appearance.PaletteName))
                    continue;
                GalleryItemGroup group = new GalleryItemGroup();
                group.Caption = appearance.Name;
                galleryBarItem.Gallery.Groups.Add(group);
                for (int i = 0; i <= palette.Count; i++)
                {
                    GalleryItem gAppearanceItem = new GalleryItem();
                    gAppearanceItem.Caption = appearance.Name;
                    gAppearanceItem.Hint = GetStyleName(appearance, i);
                    gAppearanceItem.Tag = i;
                    gAppearanceItem.Image = AppearanceImageHelper.CreateImage(ViewType, appearance, palette, i);
                    group.Items.Add(gAppearanceItem);
                    if (chartControl.AppearanceName == appearance.Name && chartControl.PaletteBaseColorNumber == i)
                        checkedItem = gAppearanceItem;
                }
            }
            galleryBarItem.Gallery.EndUpdate();
            galleryBarItem.Tag = palette.Count;
            galleryBarItem.Gallery.SetItemCheck(checkedItem, true, true);
            RibbonControl ribbon = ((RibbonBarManager)galleryBarItem.Manager).Ribbon;
            ribbon.UpdateViewInfo();
            checkedItem.MakeVisible();
        }

        private static string GetStyleName(ChartAppearance appearance, int index)
        {
            if (index == 0)
            {
                return string.Format("{0} ({1})", appearance.Name, ChartLocalizer.GetString(ChartStringId.StyleAllColors));
            }
            string colorString = String.Format(ChartLocalizer.GetString(ChartStringId.StyleColorNumber), index);
            return string.Format("{0} ({1})", appearance.Name, colorString);
        }

        public static Image CreateEditorImage(Palette palette)
        {
            const int imageSize = 10;
            Bitmap image = null;
            try
            {
                image = new Bitmap(palette.Count * (imageSize + 1) - 1, imageSize);
                using (Graphics g = Graphics.FromImage(image))
                {
                    Rectangle rect = new Rectangle(Point.Empty, new Size(imageSize, imageSize));
                    for (int i = 0; i < palette.Count; i++, rect.X += 11)
                    {
                        using (Brush brush = new SolidBrush(palette[i].Color))
                            g.FillRectangle(brush, rect);
                        Rectangle penRect = rect;
                        penRect.Width--;
                        penRect.Height--;
                        using (Pen pen = new Pen(Color.Gray))
                            g.DrawRectangle(pen, penRect);
                    }
                }
            }
            catch
            {
                if (image != null)
                {
                    image.Dispose();
                    image = null;
                }
            }
            return image;
        }

        #endregion InitData
    }

    public class StickLookAndFeelForm : CustomTopForm
    {
        private EmptySkinElementPainter painter = new EmptySkinElementPainter();

        public StickLookAndFeelForm()
        {
            UserLookAndFeel.Default.StyleChanged += new EventHandler(Default_StyleChanged);
            UpdateRegion();
        }

        private void Default_StyleChanged(object sender, EventArgs e)
        {
            UpdateRegion();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Skin skin = BarSkins.GetSkin(UserLookAndFeel.Default);
            GraphicsCache cache = new GraphicsCache(e);
            DrawContent(cache, skin);
            DrawTopElement(cache, skin);
            base.OnPaint(e);
        }

        private Rectangle GetTopElementRectangle()
        {
            Rectangle r = this.ClientRectangle;
            return new Rectangle(r.X, r.Y, r.Width, 10);
        }

        private void DrawContent(GraphicsCache graphicsCache, Skin skin)
        {
            SkinElement element = skin[BarSkins.SkinAlertWindow];
            SkinElementInfo eInfo = new SkinElementInfo(element, this.ClientRectangle);
            ObjectPainter.DrawObject(graphicsCache, SkinElementPainter.Default, eInfo);
        }

        private void DrawTopElement(GraphicsCache graphicsCache, Skin skin)
        {
            SkinElement element = skin[BarSkins.SkinAlertCaptionTop];
            SkinElementInfo eInfo = new SkinElementInfo(element, GetTopElementRectangle());
            ObjectPainter.DrawObject(graphicsCache, painter, eInfo);
        }

        internal void UpdateRegion()
        {
            SkinElement se = BarSkins.GetSkin(UserLookAndFeel.Default)[BarSkins.SkinAlertWindow];
            if (se == null)
            {
                this.Region = null;
                return;
            }
            int cornerRadius = se.Properties.GetInteger(BarSkins.SkinAlertWindowCornerRadius);
            if (cornerRadius == 0) this.Region = null;
            else this.Region = NativeMethods.CreateRoundRegion(new Rectangle(Point.Empty, this.Size), cornerRadius);
        }

        protected override bool HasSystemShadow { get { return true; } }

        private class EmptySkinElementPainter : SkinElementPainter
        {
            protected override void DrawSkinForeground(SkinElementInfo ee)
            {
            }
        }
    }

    public class FormAnimationSizer
    {
        private Form parent;
        private Size sizeInit;
        private Timer tmr = null;
        private int minHeight = 0;
        private int step = 10;
        private int heightStep = 0;

        public FormAnimationSizer(Form form)
        {
            parent = form;
            sizeInit = form.ClientSize;
            parent.StartPosition = FormStartPosition.Manual;
            parent.Location = new Point(Screen.PrimaryScreen.WorkingArea.Left + (Screen.PrimaryScreen.WorkingArea.Width - sizeInit.Width) / 2,
                Screen.PrimaryScreen.WorkingArea.Top + (Screen.PrimaryScreen.WorkingArea.Height - sizeInit.Height) / 2);
            tmr = new Timer();
            tmr.Enabled = false;
            tmr.Interval = 20;
            tmr.Tick += new EventHandler(tmr_Tick);
        }

        private void tmr_Tick(object sender, EventArgs e)
        {
            int allowHeight = parent.ClientSize.Height + (minHeight > parent.ClientSize.Height ? heightStep : -heightStep);
            heightStep += step / 2;
            if (Math.Abs(allowHeight - minHeight) <= heightStep)
            {
                parent.ClientSize = new Size(sizeInit.Width, minHeight);
                tmr.Stop();
            }
            else
            {
                parent.ClientSize = new Size(sizeInit.Width, allowHeight);
            }
        }

        public void SetMinHeight(int height)
        {
            bool animation = minHeight != 0;
            minHeight = height;
            if (animation)
            {
                heightStep = step;
                tmr.Start();
            }
            else
                parent.ClientSize = new Size(sizeInit.Width, minHeight);
        }
    }

    public class HotLabel : LabelControl
    {
        private string linkText = string.Empty;

        public HotLabel()
        {
            LookAndFeel.StyleChanged += new EventHandler(Default_StyleChanged);
            UpdateColors();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                LookAndFeel.StyleChanged -= new EventHandler(Default_StyleChanged);
            }
            base.Dispose(disposing);
        }

        [DefaultValue("")]
        public string LinkText
        {
            get { return linkText; }
            set
            {
                if (linkText == value) return;
                linkText = value;
            }
        }

        private void Default_StyleChanged(object sender, EventArgs e)
        {
            UpdateColors();
        }

        public void UpdateColors()
        {
            if (DesignMode) return;
            this.Appearance.ForeColor = WinHelper.GetLinkColor(LookAndFeel);
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            if (DesignMode) return;
            Appearance.Font = new Font(Appearance.Font, FontStyle.Underline);
            Cursor = Cursors.Hand;
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            if (DesignMode) return;
            Appearance.Font = new Font(Appearance.Font, FontStyle.Regular);
            Cursor = Cursors.Default;
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);
            if (DesignMode || string.IsNullOrEmpty(LinkText)) return;
            Cursor = Cursors.WaitCursor;
            ObjectHelper.ShowWebSite(LinkText);
        }
    }
}