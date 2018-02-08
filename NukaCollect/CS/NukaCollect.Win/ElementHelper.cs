using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.Utils;
using DevExpress.Xpo;
using DevExpress.XtraCharts;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.DXErrorProvider;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Localization;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraLayout;
using NukaCollect.Helpers;
using NukaCollect.Resources;
using NukaCollect.Win.Modules;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace NukaCollect.Win
{
    public class ExceptionsProcesser : IExceptionProcesser
    {
        private IWin32Window owner;

        public ExceptionsProcesser(IWin32Window owner)
        {
            this.owner = owner;
        }

        public void Process(Exception e)
        {
            XtraMessageBox.Show(owner, e.Message, ConstStrings.Get("Warning"), MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }
    }

    public class WinApiWrapper
    {
        public static int GetModuleHandle(string moduleName)
        {
            return Import.GetModuleHandle(moduleName);
        }

        public static Icon ExtractIcon(int hinstance, string file, int iconIndex)
        {
            return IconFromHandle(Import.ExtractIcon(hinstance, file, iconIndex));
        }

        public static Icon GetIconBySHGetFileInfo(string file, bool small)
        {
            Import.SHFILEINFO shFileInfo = new Import.SHFILEINFO(true);
            int fileInfoSize = Marshal.SizeOf(shFileInfo);
            Import.SHGFI flags = Import.SHGFI.Icon | (small ? Import.SHGFI.SmallIcon : Import.SHGFI.LargeIcon);
            Import.SHGetFileInfo(file, 0, ref shFileInfo, (uint)fileInfoSize, (uint)flags);
            return IconFromHandle(shFileInfo.Hicon);
        }

        public static string GetTypeNameBySHGetFileInfo(string file)
        {
            Import.SHFILEINFO shFileInfo = new Import.SHFILEINFO(true);
            int fileInfoSize = Marshal.SizeOf(shFileInfo);
            Import.SHGFI flags = Import.SHGFI.TypeName;
            Import.SHGetFileInfo(file, 0, ref shFileInfo, (uint)fileInfoSize, (uint)flags);
            return shFileInfo.TypeName;
        }

        private static Icon IconFromHandle(IntPtr hicon)
        {
            if (hicon == IntPtr.Zero) return null;
            Icon icon = Icon.FromHandle(hicon);
            Icon ret = new Icon(icon, icon.Size);
            Import.DestroyIcon(hicon);
            return ret;
        }

        private class Import
        {
            [DllImport("Kernel32.dll")]
            public static extern int GetModuleHandle(string moduleName);

            [DllImport("Shell32.dll")]
            public static extern IntPtr ExtractIcon(int hinstance, string file, int iconIndex);

            [DllImport("shell32.dll")]
            public static extern IntPtr SHGetFileInfo(string path, uint fileAttributes, ref SHFILEINFO psfi, uint fileInfo, uint flags);

            [DllImport("user32.dll", SetLastError = true)]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool DestroyIcon(IntPtr hicon);

            public const int MAX_PATH = 260;
            public const int MAX_TYPE = 80;

            [StructLayout(LayoutKind.Sequential)]
            public struct SHFILEINFO
            {
                public SHFILEINFO(bool b)
                {
                    Hicon = IntPtr.Zero;
                    IconIndex = 0;
                    Attributes = 0;
                    DisplayName = string.Empty;
                    TypeName = string.Empty;
                }

                public IntPtr Hicon;
                public int IconIndex;
                public uint Attributes;

                [MarshalAs(UnmanagedType.ByValTStr, SizeConst = MAX_PATH)]
                public string DisplayName;

                [MarshalAs(UnmanagedType.ByValTStr, SizeConst = MAX_TYPE)]
                public string TypeName;
            };

            [Flags]
            public enum SHGFI : uint
            {
                Icon = 0x000000100, DisplayName = 0x000000200, TypeName = 0x000000400, Attributes = 0x000000800, IconLocation = 0x000001000,
                ExeType = 0x000002000, SysIconIndex = 0x000004000, LinkOverlay = 0x000008000, Selected = 0x000010000, AttrSpecified = 0x000020000,
                LargeIcon = 0x000000000, SmallIcon = 0x000000001, OpenIcon = 0x000000002, ShellIconSize = 0x000000004, PIDL = 0x000000008, UseFileAttributes = 0x000000010,
                AddOverlays = 0x000000020, OverlayIndex = 0x000000040
            }
        }
    }

    public class WinHelper
    {
        public static void SetFormClientSize(Rectangle workingArea, Form form, int width, int height)
        {
            Size tempSize = DevExpress.Utils.ScaleUtils.GetScaleSize(new Size(width, height));
            width = tempSize.Width;
            height = tempSize.Height;
            form.ClientSize = new Size(Math.Min(workingArea.Width - 20, width), Math.Min(workingArea.Height - 20, height));
            form.Location = new Point(workingArea.X + (workingArea.Width - form.Width) / 2, workingArea.Y + (workingArea.Height - form.Height) / 2);
        }

        public static void GridViewFocusObject(ColumnView cView, VideoRentBaseObject obj)
        {
            if (obj == null) return;
            int oldFocusedRowHandle = cView.FocusedRowHandle;
            for (int i = 0; i < cView.DataRowCount; ++i)
            {
                VideoRentBaseObject rowObj = cView.GetRow(i) as VideoRentBaseObject;
                if (rowObj == null) continue;
                if (obj.Oid == rowObj.Oid)
                {
                    if (i == oldFocusedRowHandle)
                        cView.FocusedRowHandle = GridControl.InvalidRowHandle;
                    cView.FocusedRowHandle = i;
                    break;
                }
            }
        }

        public static string ReplaceFilterText(object filter, string sourceString, string retString)
        {
            string displayFilterText = string.Format("{0}", filter);
            if (displayFilterText.Contains(sourceString))
                return displayFilterText.Replace(sourceString, retString);
            return null;
        }

        private static BaseView GetBaseViewByControl(Control control)
        {
            if (control == null) return null;
            foreach (Control cntl in control.Controls)
                if (cntl is GridControl)
                    return ((GridControl)cntl).MainView;
            return null;
        }

        private static LayoutControl GetLayoutControlByControl(Control control)
        {
            if (control == null) return null;
            foreach (Control cntl in control.Controls)
                if (cntl is LayoutControl)
                    return cntl as LayoutControl;
            return null;
        }

        private static void CloseElements(Control control)
        {
            foreach (Control ctrl in control.Controls)
                CloseElements(ctrl);
            BaseView view = GetBaseViewByControl(control);
            if (view != null)
            {
                foreach (BaseView bView in view.GridControl.Views)
                    if (bView is GridView)
                        ((GridView)bView).DestroyCustomization();
            }
            LayoutControl layout = GetLayoutControlByControl(control);
            if (layout != null)
                layout.HideCustomizationForm();
        }

        public static void CloseCustomizationForm(TutorialControlBase control)
        {
            if (control == null) return;
            CloseElements(control);
            foreach (DetailBase dBase in control.DetailModulesCollection)
                CloseElements(dBase);
        }

        public static void SetChartStyle(ChartControl chartControl, ChartAppearanceManager manager)
        {
            if (chartControl == null) return;
            chartControl.AppearanceName = manager.AppearanceName;
            chartControl.PaletteBaseColorNumber = manager.ColorIndex;
            chartControl.PaletteName = manager.PaletteName;
        }

        public static Color GetLinkColor(UserLookAndFeel lookAndFeel)
        {
            Color color = Color.Empty;
            if (lookAndFeel.ActiveStyle == DevExpress.LookAndFeel.ActiveLookAndFeelStyle.Skin)
            {
                Skin skin = EditorsSkins.GetSkin(lookAndFeel);
                color = skin.Colors.GetColor(EditorsSkins.SkinHyperlinkTextColor);
            }
            if (color.IsEmpty) color = Color.Blue;
            return color;
        }
    }

    public class ObjectHelper
    {
        public static void ShowWebSite(string url)
        {
            if (url == null) return;
            string processName = url.Replace(" ", string.Empty);
            if (processName.Length == 0) return;
            const string protocol = "http://";
            const string protocol2 = "https://";
            if (processName.IndexOf(protocol) != 0 && processName.IndexOf(protocol2) != 0)
                processName = protocol + processName;
            StartProcess(processName);
        }

        public static void StartProcess(string processName)
        {
            try
            {
                Process.Start(processName);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, ConstStrings.Get("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static bool SafeDelete(IWin32Window owner, VideoRentBaseObject obj, bool commitSession)
        {
            if (!obj.AllowDelete)
            {
                XtraMessageBox.Show(owner, ConstStrings.Get("ObjectCanNotBeDeleted"), ConstStrings.Get("Warning"), MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }
            UnitOfWork uow = (UnitOfWork)obj.Session;
            obj.Delete();
            if (commitSession) SessionHelper.CommitSession(uow, new ExceptionsProcesser(owner));
            return true;
        }

        public static void SetFormContainerSize(Form form, Control control)
        {
            form.StartPosition = FormStartPosition.Manual;
            form.Size = control.Size;
            form.Location = control.FindForm().PointToScreen(control.Location);
        }

        public static void ShowFormDialog(Form form, Form parent)
        {
            try
            {
                parent.Enabled = false;
                form.ShowDialog(parent);
            }
            finally
            {
                parent.Enabled = true;
            }
        }

        public static void OpenExportedFile(string fileName)
        {
            if (XtraMessageBox.Show(ConstStrings.Get("ExportFileOpen"), ConstStrings.Get("Export"), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Process process = new Process();
                try
                {
                    process.StartInfo.FileName = fileName;
                    process.Start();
                }
                catch { }
            }
        }

        public static void ShowExportErrorMessage()
        {
            XtraMessageBox.Show(ConstStrings.Get("ExportError"), ConstStrings.Get("Export"), MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static string GetPossibleFileName(string name)
        {
            return name.Replace("/", "");
        }

        public static string GetFileName(string extension, string filter)
        {
            return GetFileName(extension, filter, string.Empty);
        }

        public static string GetFileName(string extension, string filter, string fileName)
        {
            using (SaveFileDialog dialog = new SaveFileDialog())
            {
                dialog.Filter = filter;
                dialog.FileName = fileName;
                dialog.DefaultExt = extension;
                if (dialog.ShowDialog() == DialogResult.OK)
                    return dialog.FileName;
            }
            return String.Empty;
        }

        public static void RemoveCustomizationItemsFromColumnMenu(DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            if (e.MenuType == DevExpress.XtraGrid.Views.Grid.GridMenuType.Column)
                for (int i = e.Menu.Items.Count - 1; i >= 0; i--)
                    if (GridStringId.MenuColumnColumnCustomization.Equals(e.Menu.Items[i].Tag) ||
                        GridStringId.MenuColumnRemoveColumn.Equals(e.Menu.Items[i].Tag))
                        e.Menu.Items.RemoveAt(i);
        }

        internal static string GetArticleByWord(string word)
        {
            if (string.IsNullOrEmpty(word)) return string.Empty;
            string firstLetter = word.Substring(0, 1).ToLower();
            if (firstLetter == "a") return "an";
            return "a";
        }
    }

    public enum ImageSize { Small16, Large32 }

    public class ElementHelper
    {
        private static ImageCollection receiptTypeImages = null;
        private static ImageCollection activeRentTypeImages = null;
        private static ImageCollection folderIcons = null;
        private static ImageCollection columnHeaderIcons = null;
        private static Icon appIcon = null;

        public static Image GetImage(string name, ImageSize size)
        {
            if (string.IsNullOrEmpty(name)) return null;
            return ResourceImageHelper.CreateImageFromResources(
                string.Format("NukaCollect.Resources.SingleImages.{0}_{1}.png", name, GetImageSizeString(size)),
                typeof(ImagesHelper).Assembly);
        }

        public static Image GetAboutPageImage(string name)
        {
            if (string.IsNullOrEmpty(name)) return null;
            return ResourceImageHelper.CreateImageFromResources(
                string.Format("NukaCollect.Resources.AboutPage.{0}.png", name),
                typeof(ImagesHelper).Assembly);
        }

        public static Image GetGroupImage(string name)
        {
            if (name == null || name == string.Empty) return null;
            return ResourceImageHelper.CreateImageFromResources(
                string.Format("NukaCollect.Resources.SingleImages.Group_{0}.png", name),
                typeof(ImagesHelper).Assembly);
        }

        private static string GetImageSizeString(ImageSize size)
        {
            if (size == ImageSize.Small16) return "16x16";
            return "32x32";
        }

        public static ImageCollection ReceiptTypeImages
        {
            get
            {
                if (ElementHelper.receiptTypeImages == null)
                    ElementHelper.receiptTypeImages = DevExpress.Utils.Controls.ImageHelper.CreateImageCollectionFromResources("NukaCollect.Resources.Images.ReceiptType.png", typeof(ImagesHelper).Assembly, new Size(16, 16));
                return ElementHelper.receiptTypeImages;
            }
        }

        public static ImageCollection ActiveRentTypeImages
        {
            get
            {
                if (ElementHelper.activeRentTypeImages == null)
                    ElementHelper.activeRentTypeImages = DevExpress.Utils.Controls.ImageHelper.CreateImageCollectionFromResources("NukaCollect.Resources.Images.ActiveRents.png", typeof(ImagesHelper).Assembly, new Size(16, 16));
                return ElementHelper.activeRentTypeImages;
            }
        }

        public static ImageCollection FolderIcons
        {
            get
            {
                if (ElementHelper.folderIcons == null)
                    ElementHelper.folderIcons = DevExpress.Utils.Controls.ImageHelper.CreateImageCollectionFromResources("NukaCollect.Resources.Images.FolderIcons16x16.png", typeof(ImagesHelper).Assembly, new Size(16, 16));
                return ElementHelper.folderIcons;
            }
        }

        public static ImageCollection ColumnHeaderIcons
        {
            get
            {
                if (ElementHelper.columnHeaderIcons == null)
                    ElementHelper.columnHeaderIcons = DevExpress.Utils.Controls.ImageHelper.CreateImageCollectionFromResources("NukaCollect.Resources.Images.ColumnHeaderImages.png", typeof(ImagesHelper).Assembly, new Size(13, 13));
                return ElementHelper.columnHeaderIcons;
            }
        }

        public static Icon AppIcon
        {
            get
            {
                if (ElementHelper.appIcon == null)
                    ElementHelper.appIcon = ResourceImageHelper.CreateIconFromResources("NukaCollect.Win.AppIcon.ico", typeof(ElementHelper).Assembly);
                return ElementHelper.appIcon;
            }
        }

#if DebugTest
        static ImageCollection imagesForTests = null;
        public static ImageCollection ImagesForTests {
            get {
                if(ElementHelper.imagesForTests == null)
                    ElementHelper.imagesForTests = DevExpress.Utils.Controls.ImageHelper.CreateImageCollectionFromResources("NukaCollect.Resources.Images.FolderIcons16x16.png", typeof(ImagesHelper).Assembly, new Size(16, 16));
                return ElementHelper.imagesForTests;
            }
        }
#endif
        public static Font FontItalic = new Font("Tahoma", 8, FontStyle.Italic);
        public static Font FontBold = new Font("Tahoma", 8, FontStyle.Bold);

        public static string GetSingleLineString(string text)
        {
            int index = text.IndexOf("\r\n");
            if (index != -1)
                return text.Substring(0, index);
            return text;
        }
    }

    public class BackstageViewLabel : LabelControl
    {
        public BackstageViewLabel()
        {
            Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            //Appearance.ForeColor = System.Drawing.Color.Gray;
            AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            //LineColor = System.Drawing.Color.Silver;
            LineLocation = DevExpress.XtraEditors.LineLocation.Bottom;
            LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            LineVisible = true;
            LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            LookAndFeel.UseDefaultLookAndFeel = false;
            ShowLineShadow = false;
        }
    }

    public class ValidationRulesHelper
    {
        private static ConditionValidationRule ruleIsNotBlank = null;
        private static ConditionValidationRule ruleGreaterOrEqualZero = null;

        public static ConditionValidationRule RuleIsNotBlank
        {
            get
            {
                if (ruleIsNotBlank == null)
                {
                    ruleIsNotBlank = new ConditionValidationRule();
                    ruleIsNotBlank.ConditionOperator = ConditionOperator.IsNotBlank;
                    ruleIsNotBlank.ErrorText = ConstStrings.Get("RuleIsNotBlankWarning");
                    ruleIsNotBlank.ErrorType = ErrorType.Critical;
                }
                return ruleIsNotBlank;
            }
        }

        public static ConditionValidationRule RuleGreaterOrEqualZero
        {
            get
            {
                if (ruleGreaterOrEqualZero == null)
                {
                    ruleGreaterOrEqualZero = new ConditionValidationRule();
                    ruleGreaterOrEqualZero.ConditionOperator = ConditionOperator.GreaterOrEqual;
                    ruleGreaterOrEqualZero.Value1 = 0;
                    ruleGreaterOrEqualZero.ErrorText = ConstStrings.Get("RuleGreaterOrEqualZeroWarning");
                    ruleGreaterOrEqualZero.ErrorType = ErrorType.Critical;
                }
                return ruleGreaterOrEqualZero;
            }
        }

        public static ConditionValidationRule RuleGreaterOrEqual(int value)
        {
            ConditionValidationRule ret = new ConditionValidationRule();
            ret.ConditionOperator = ConditionOperator.GreaterOrEqual;
            ret.Value1 = value;
            ret.ErrorText = ConstStrings.Get("RuleGreaterOrEqualZeroWarning");
            ret.ErrorType = ErrorType.Critical;
            return ret;
        }
    }

    public class EditorHelper
    {
        public static RepositoryItemTextEdit CreateCardNumberTextEdit(RepositoryItemCollection collection)
        {
            return CreateCardNumberTextEdit(null, collection);
        }

        public static RepositoryItemTextEdit CreateCardNumberTextEdit(RepositoryItemTextEdit edit, RepositoryItemCollection collection)
        {
            RepositoryItemTextEdit ret = edit == null ? new RepositoryItemTextEdit() : edit;
            if (collection != null) collection.Add(ret);
            ret.Mask.EditMask = "d6";
            ret.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            ret.Mask.UseMaskAsDisplayFormat = true;
            return ret;
        }

        public static RepositoryItemTextEdit CreatePaymentTextEdit(RepositoryItemCollection collection)
        {
            RepositoryItemTextEdit ret = new RepositoryItemTextEdit();
            if (collection != null) collection.Add(ret);
            ret.Mask.EditMask = "c";
            ret.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            ret.Mask.UseMaskAsDisplayFormat = true;
            return ret;
        }

        public static RepositoryItemImageComboBox CreateGenderImageComboBox(RepositoryItemCollection collection)
        {
            return CreateGenderImageComboBox(null, true, collection);
        }

        public static RepositoryItemImageComboBox CreateGenderImageComboBox(RepositoryItemImageComboBox edit, RepositoryItemCollection collection)
        {
            return CreateGenderImageComboBox(edit, false, collection);
        }

        public static RepositoryItemImageComboBox CreateGenderImageComboBox(RepositoryItemImageComboBox edit, bool center, RepositoryItemCollection collection)
        {
            RepositoryItemImageComboBox ret = edit == null ? new RepositoryItemImageComboBox() : edit;
            if (collection != null) collection.Add(ret);
            Array arr = Enum.GetValues(typeof(PersonGender));
            ret.Items.Clear();
            foreach (PersonGender gender in arr)
                ret.Items.Add(new ImageComboBoxItem(EnumTitlesKeeper<PersonGender>.GetTitle(gender), gender, GetPersonImages(gender)));
            ret.SmallImages = ImagesHelper.Current.PersonImages;
            if (center)
                ret.GlyphAlignment = HorzAlignment.Center;
            return ret;
        }

        private static int GetPersonImages(PersonGender gender)
        {
            if (gender == PersonGender.Female) return 1;
            return 0;
        }

        public static RepositoryItemImageComboBox CreateRatingImageComboBox(RepositoryItemCollection collection)
        {
            return CreateRatingImageComboBox(null, collection);
        }

        public static RepositoryItemImageComboBox CreateRatingImageComboBox(RepositoryItemImageComboBox edit, RepositoryItemCollection collection)
        {
            RepositoryItemImageComboBox ret = edit == null ? new RepositoryItemImageComboBox() : edit;
            if (collection != null) collection.Add(ret);
            Array arr = Enum.GetValues(typeof(MovieRating));
            ret.Items.Clear();
            foreach (MovieRating rating in arr)
                ret.Items.Add(new ImageComboBoxItem(GetRatingString(rating), rating, (int)rating));
            ret.SmallImages = ImagesHelper.Current.RatingImages;
            ret.LargeImages = ImagesHelper.Current.RatingLargeImages;
            ret.GlyphAlignment = HorzAlignment.Center;
            return ret;
        }

        public static RepositoryItemImageComboBox CreateMovieItemFormatImageComboBox(RepositoryItemCollection collection)
        {
            return CreateMovieItemFormatImageComboBox(null, collection);
        }

        public static RepositoryItemImageComboBox CreateMovieItemFormatImageComboBox(RepositoryItemImageComboBox edit, RepositoryItemCollection collection)
        {
            RepositoryItemImageComboBox ret = edit == null ? new RepositoryItemImageComboBox() : edit;
            if (collection != null) collection.Add(ret);
            ret.Items.Clear();
            foreach (MovieItemFormat format in Enum.GetValues(typeof(MovieItemFormat)))
                ret.Items.Add(new ImageComboBoxItem(EnumTitlesKeeper<MovieItemFormat>.GetTitle(format), format, (int)format - 1));
            ret.SmallImages = ImagesHelper.Current.DiskIcons;
            return ret;
        }

        public static RepositoryItemRadioGroup CreateDBFormatRadioGroup(RepositoryItemRadioGroup edit)
        {
            RepositoryItemRadioGroup ret = edit == null ? new RepositoryItemRadioGroup() : edit;
            foreach (DBFormat format in Enum.GetValues(typeof(DBFormat)))
                ret.Items.Add(new RadioGroupItem(format, EnumTitlesKeeper<DBFormat>.GetTitle(format)));
            return ret;
        }

        public static RepositoryItemRadioGroup CreateSqlAuthenticationTypeRadioGroup(RepositoryItemRadioGroup edit)
        {
            RepositoryItemRadioGroup ret = edit == null ? new RepositoryItemRadioGroup() : edit;
            foreach (SqlAuthenticationType authenticationType in Enum.GetValues(typeof(SqlAuthenticationType)))
                ret.Items.Add(new RadioGroupItem(authenticationType, EnumTitlesKeeper<SqlAuthenticationType>.GetTitle(authenticationType)));
            return ret;
        }

        public static RepositoryItemImageComboBox CreateMovieItemStatusImageComboBox(RepositoryItemCollection collection)
        {
            return CreateMovieItemStatusImageComboBox(null, collection);
        }

        public static RepositoryItemImageComboBox CreateMovieItemStatusImageComboBox(RepositoryItemImageComboBox edit, RepositoryItemCollection collection)
        {
            RepositoryItemImageComboBox ret = edit == null ? new RepositoryItemImageComboBox() : edit;
            if (collection != null) collection.Add(ret);
            Array arr = Enum.GetValues(typeof(MovieItemStatus));
            ret.Items.Clear();
            foreach (MovieItemStatus status in arr)
                ret.Items.Add(new ImageComboBoxItem(EnumTitlesKeeper<MovieItemStatus>.GetTitle(status), status, (int)status));
            return ret;
        }

        public static RepositoryItemImageComboBox CreateDiscountLevelImageComboBox(RepositoryItemCollection collection)
        {
            return CreateDiscountLevelImageComboBox(null, collection);
        }

        public static RepositoryItemImageComboBox CreateDiscountLevelImageComboBox(RepositoryItemImageComboBox edit, RepositoryItemCollection collection)
        {
            RepositoryItemImageComboBox ret = edit == null ? new RepositoryItemImageComboBox() : edit;
            if (collection != null) collection.Add(ret);
            Array arr = Enum.GetValues(typeof(CustomerDiscountLevel));
            ret.Items.Clear();
            foreach (CustomerDiscountLevel level in arr)
                ret.Items.Add(new ImageComboBoxItem(EnumTitlesKeeper<CustomerDiscountLevel>.GetTitle(level), level, -1));
            return ret;
        }

        public static RepositoryItemImageComboBox CreateReceiptTypeImageComboBox(RepositoryItemCollection collection)
        {
            return CreateReceiptTypeImageComboBox(null, collection);
        }

        public static RepositoryItemImageComboBox CreateReceiptTypeImageComboBox(RepositoryItemImageComboBox edit, RepositoryItemCollection collection)
        {
            RepositoryItemImageComboBox ret = edit == null ? new RepositoryItemImageComboBox() : edit;
            if (collection != null) collection.Add(ret);
            Array arr = Enum.GetValues(typeof(ReceiptType));
            ret.Items.Clear();
            foreach (ReceiptType type in arr)
                ret.Items.Add(new ImageComboBoxItem(GetReceiptTypeString(type), type, (int)type));
            ret.SmallImages = ElementHelper.ReceiptTypeImages;
            return ret;
        }

        public static RepositoryItemImageComboBox CreateActiveRentTypeImageComboBox(RepositoryItemCollection collection)
        {
            RepositoryItemImageComboBox ret = new RepositoryItemImageComboBox();
            if (collection != null) collection.Add(ret);
            Array arr = Enum.GetValues(typeof(ActiveRentType));
            ret.Items.Clear();
            foreach (ActiveRentType type in arr)
                ret.Items.Add(new ImageComboBoxItem(EnumTitlesKeeper<ActiveRentType>.GetTitle(type), type, (int)type - 1));
            ret.SmallImages = ElementHelper.ActiveRentTypeImages;
            ret.GlyphAlignment = HorzAlignment.Center;
            return ret;
        }

        public static RepositoryItemComboBox CreateLocationComboBox(RepositoryItemCollection collection)
        {
            return CreateLocationComboBox(null, collection);
        }

        public static RepositoryItemComboBox CreateLocationComboBox(RepositoryItemComboBox edit, RepositoryItemCollection collection)
        {
            RepositoryItemComboBox ret = edit == null ? new RepositoryItemComboBox() : edit;
            if (collection != null) collection.Add(ret);
            ret.Items.Clear();
            for (int i = 1; i <= ReferenceData.ShelvesCount; i++)
                ret.Items.Add(string.Format(NukaCollect.Properties.Resources.ShelfPattern, i));
            return ret;
        }

        public static string GetReceiptTypeString(ReceiptType type)
        {
            return EnumTitlesKeeper<ReceiptType>.GetTitle(type);
        }

        public static RepositoryItemTextEdit CreateDiscountTextEdit()
        {
            return CreateDiscountTextEdit(null);
        }

        public static RepositoryItemTextEdit CreateDiscountTextEdit(RepositoryItemTextEdit edit)
        {
            RepositoryItemTextEdit ret = edit == null ? new RepositoryItemTextEdit() : edit;
            ret.Appearance.TextOptions.HAlignment = HorzAlignment.Far;
            ret.Mask.EditMask = "p";
            ret.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            ret.Mask.UseMaskAsDisplayFormat = true;
            return ret;
        }

        private static string GetRatingString(MovieRating rating)
        {
            return rating.ToString().Replace("1", "-1");
        }

        public static RepositoryItemLookUpEdit CreateCountryLookUpEdit(Session session, RepositoryItemCollection collection, bool key)
        {
            return CreateCountryLookUpEdit(session, null, collection, key);
        }

        public static RepositoryItemLookUpEdit CreateCountryLookUpEdit(Session session, RepositoryItemLookUpEdit edit, RepositoryItemCollection collection)
        {
            return CreateCountryLookUpEdit(session, edit, collection, false);
        }

        public static RepositoryItemLookUpEdit CreateCountryLookUpEdit(Session session, RepositoryItemLookUpEdit edit, RepositoryItemCollection collection, bool key)
        {
            RepositoryItemLookUpEdit ret = edit == null ? new RepositoryItemLookUpEdit() : edit;
            if (collection != null) collection.Add(ret);
            ret.ValueMember = key ? "Oid" : "This";
            ret.DisplayMember = "Name";
            ret.DataSource = new XPCollection<Country>(session, null, new SortProperty("Name", DevExpress.Xpo.DB.SortingDirection.Ascending));
            ret.NullText = string.Empty;
            ret.Columns.Clear();
            ret.Columns.Add(new LookUpColumnInfo("Name"));
            ret.TextEditStyle = TextEditStyles.DisableTextEditor;
            ret.ShowHeader = false;
            ret.ShowFooter = false;
            ret.DropDownRows = 14;
            ret.AllowNullInput = DefaultBoolean.True;
            return ret;
        }

        public static RepositoryItemLookUpEdit CreateLanguageLookUpEdit(Session session, RepositoryItemCollection collection, bool key)
        {
            return CreateLanguageLookUpEdit(session, null, collection, key);
        }

        public static RepositoryItemLookUpEdit CreateLanguageLookUpEdit(Session session, RepositoryItemLookUpEdit edit, RepositoryItemCollection collection)
        {
            return CreateLanguageLookUpEdit(session, edit, collection, false);
        }

        public static RepositoryItemLookUpEdit CreateLanguageLookUpEdit(Session session, RepositoryItemLookUpEdit edit, RepositoryItemCollection collection, bool key)
        {
            RepositoryItemLookUpEdit ret = edit == null ? new RepositoryItemLookUpEdit() : edit;
            if (collection != null) collection.Add(ret);
            ret.ValueMember = key ? "Oid" : "This";
            ret.DisplayMember = "Name";
            ret.DataSource = new XPCollection<Language>(session, null, new SortProperty("Name", DevExpress.Xpo.DB.SortingDirection.Ascending));
            ret.NullText = string.Empty;
            ret.Columns.Clear();
            ret.Columns.Add(new LookUpColumnInfo("Name"));
            ret.ShowHeader = false;
            ret.DropDownRows = 9;
            return ret;
        }

        public static RepositoryItemGridLookUpEdit CreateArtistGridLookUpEdit(Session session, RepositoryItemCollection collection)
        {
            return CreateArtistGridLookUpEdit(session, null, collection);
        }

        public static RepositoryItemGridLookUpEdit CreateArtistGridLookUpEdit(Session session, RepositoryItemGridLookUpEdit edit, RepositoryItemCollection collection)
        {
            RepositoryItemGridLookUpEdit ret = edit == null ? new RepositoryItemGridLookUpEdit() : edit;
            if (collection != null) collection.Add(ret);
            ret.AllowNullInput = DefaultBoolean.False;
            ret.ValueMember = "This";
            ret.DisplayMember = "FullName";
            ret.PopupFormSize = new Size(350, 220);
            if (ret.View == null) ret.View = new GridView();
            GridColumn colFullName = new GridColumn();
            GridColumn colBirthDate = new GridColumn();
            GridColumn colGender = new GridColumn();
            //colFullName
            colFullName.FieldName = "FullName";
            colFullName.Caption = ConstStrings.Get("Name");
            colFullName.VisibleIndex = 1;
            colFullName.Width = 664;
            // colBirthDate
            colBirthDate.FieldName = "BirthDate";
            colBirthDate.Caption = ConstStrings.Get("BirthDate");
            colBirthDate.VisibleIndex = 2;
            colBirthDate.Width = 289;
            // colGender
            colGender.FieldName = "Gender";
            colGender.Caption = ConstStrings.Get("Gender");
            colGender.OptionsColumn.FixedWidth = true;
            colGender.VisibleIndex = 0;
            colGender.Width = 57;
            colGender.ColumnEdit = EditorHelper.CreateGenderImageComboBox(ret.View.GridControl.RepositoryItems);
            //
            ret.View.Columns.Clear();
            ret.View.Columns.Add(colGender);
            ret.View.Columns.Add(colFullName);
            ret.View.Columns.Add(colBirthDate);
            ret.View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            ret.View.OptionsSelection.EnableAppearanceFocusedCell = false;
            ret.View.OptionsView.ShowGroupPanel = false;
            ret.View.OptionsView.ShowIndicator = false;
            ret.View.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False;
            ret.DataSource = new XPCollection<Artist>(session, null, new SortProperty("FullName", DevExpress.Xpo.DB.SortingDirection.Ascending));
            return ret;
        }

        public static RepositoryItemGridLookUpEdit CreateMovieGridLookUpEdit(Session session, RepositoryItemCollection collection)
        {
            return CreateMovieGridLookUpEdit(session, null, collection);
        }

        public static RepositoryItemGridLookUpEdit CreateMovieGridLookUpEdit(Session session, RepositoryItemGridLookUpEdit edit, RepositoryItemCollection collection)
        {
            RepositoryItemGridLookUpEdit ret = edit == null ? new RepositoryItemGridLookUpEdit() : edit;
            if (collection != null) collection.Add(ret);
            ret.AllowNullInput = DefaultBoolean.False;
            ret.ValueMember = "This";
            ret.DisplayMember = "Title";
            ret.PopupFormSize = new Size(450, 220);
            if (ret.View == null) ret.View = new GridView();
            GridColumn colTitle = new GridColumn();
            GridColumn colReleaseDate = new GridColumn();
            GridColumn colRating = new GridColumn();
            //colTitle
            colTitle.FieldName = "Title";
            colTitle.Caption = ConstStrings.Get("Title");
            colTitle.VisibleIndex = 0;
            colTitle.Width = 400;
            // colReleaseDate
            colReleaseDate.FieldName = "ReleaseDate";
            colReleaseDate.Caption = ConstStrings.Get("ReleaseDate");
            colReleaseDate.VisibleIndex = 1;
            colReleaseDate.Width = 120;
            // colRating
            colRating.FieldName = "Rating";
            colRating.Caption = ConstStrings.Get("Rating");
            colRating.VisibleIndex = 2;
            colRating.Width = 100;
            colRating.ColumnEdit = EditorHelper.CreateRatingImageComboBox(ret.View.GridControl.RepositoryItems);
            //
            ret.View.Columns.Clear();
            ret.View.Columns.Add(colTitle);
            ret.View.Columns.Add(colReleaseDate);
            ret.View.Columns.Add(colRating);
            ret.View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            ret.View.OptionsSelection.EnableAppearanceFocusedCell = false;
            ret.View.OptionsView.ShowGroupPanel = false;
            ret.View.OptionsView.ShowIndicator = false;
            ret.View.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False;
            ret.DataSource = new XPCollection<Movie>(session, null, new SortProperty("Title", DevExpress.Xpo.DB.SortingDirection.Ascending));
            return ret;
        }

        public static RepositoryItemLookUpEdit CreateMovieArtistLineLookUpEdit(Session session, RepositoryItemCollection collection)
        {
            return CreateMovieArtistLineLookUpEdit(session, null, collection);
        }

        public static RepositoryItemLookUpEdit CreateMovieArtistLineLookUpEdit(Session session, RepositoryItemLookUpEdit edit, RepositoryItemCollection collection)
        {
            RepositoryItemLookUpEdit ret = edit == null ? new RepositoryItemLookUpEdit() : edit;
            if (collection != null) collection.Add(ret);
            ret.AllowNullInput = DefaultBoolean.False;
            ret.ValueMember = "This";
            ret.DisplayMember = "Name";
            ret.DataSource = new XPCollection<MovieArtistLine>(session, null, new SortProperty("Name", DevExpress.Xpo.DB.SortingDirection.Ascending));
            ret.Columns.Clear();
            ret.Columns.Add(new LookUpColumnInfo("Name"));
            ret.ShowHeader = false;
            ret.DropDownRows = 14;
            return ret;
        }

        public static RepositoryItemLookUpEdit CreateCompanyLookUpEdit(Session session, RepositoryItemCollection collection)
        {
            return CreateCompanyLookUpEdit(session, null, collection);
        }

        public static RepositoryItemLookUpEdit CreateCompanyLookUpEdit(Session session, RepositoryItemLookUpEdit edit, RepositoryItemCollection collection)
        {
            RepositoryItemLookUpEdit ret = edit == null ? new RepositoryItemLookUpEdit() : edit;
            if (collection != null) collection.Add(ret);
            ret.AllowNullInput = DefaultBoolean.False;
            ret.ValueMember = "This";
            ret.DisplayMember = "Name";
            ret.DataSource = new XPCollection<Company>(session, null, new SortProperty("Name", DevExpress.Xpo.DB.SortingDirection.Ascending));
            ret.Columns.Clear();
            ret.Columns.Add(new LookUpColumnInfo("Name", 100, ConstStrings.Get("Company")));
            ret.Columns.Add(new LookUpColumnInfo("TypeName", 70, ConstStrings.Get("Type")));
            ret.NullText = string.Empty;
            ret.DropDownRows = 10;
            return ret;
        }

        public static RepositoryItemCheckedComboBoxEdit CreateMovieCountriesCheckedComboBox(Session session)
        {
            return CreateMovieCountriesCheckedComboBox(session, null);
        }

        public static RepositoryItemCheckedComboBoxEdit CreateMovieCountriesCheckedComboBox(Session session, RepositoryItemCheckedComboBoxEdit edit)
        {
            RepositoryItemCheckedComboBoxEdit ret = edit == null ? new RepositoryItemCheckedComboBoxEdit() : edit;
            ret.ValueMember = "Acronym";
            ret.DisplayMember = "Name";
            ret.DataSource = new XPCollection<Country>(session, null, new SortProperty("Name", DevExpress.Xpo.DB.SortingDirection.Ascending));
            ret.DropDownRows = 10;
            return ret;
        }

        public static RepositoryItemLookUpEdit CreateMovieCategoryLookUpEdit(Session session, RepositoryItemCollection collection)
        {
            return CreateMovieCategoryLookUpEdit(session, null, collection);
        }

        public static RepositoryItemLookUpEdit CreateMovieCategoryLookUpEdit(Session session, RepositoryItemLookUpEdit edit, RepositoryItemCollection collection)
        {
            RepositoryItemLookUpEdit ret = edit == null ? new RepositoryItemLookUpEdit() : edit;
            if (collection != null) collection.Add(ret);
            ret.ValueMember = "This";
            ret.DisplayMember = "Name";
            ret.DataSource = new XPCollection<MovieCategory>(session, null, new SortProperty("Name", DevExpress.Xpo.DB.SortingDirection.Ascending));
            ret.Columns.Clear();
            ret.Columns.Add(new LookUpColumnInfo("Name", ConstStrings.Get("Name")));
            ret.DropDownRows = 10;
            return ret;
        }

        public static RepositoryItemLookUpEdit CreateCompanyTypeLookUpEdit(Session session, RepositoryItemLookUpEdit edit, RepositoryItemCollection collection)
        {
            return CreateCompanyTypeLookUpEdit(session, edit, collection, false);
        }

        public static RepositoryItemLookUpEdit CreateCompanyTypeLookUpEdit(Session session, RepositoryItemLookUpEdit edit, RepositoryItemCollection collection, bool key)
        {
            RepositoryItemLookUpEdit ret = edit == null ? new RepositoryItemLookUpEdit() : edit;
            if (collection != null) collection.Add(ret);
            ret.ValueMember = key ? "Oid" : "This";
            ret.DisplayMember = "Name";
            ret.DataSource = new XPCollection<CompanyType>(session, null, new SortProperty("Name", DevExpress.Xpo.DB.SortingDirection.Ascending));
            ret.Columns.Clear();
            ret.Columns.Add(new LookUpColumnInfo("Name"));
            ret.TextEditStyle = TextEditStyles.DisableTextEditor;
            ret.ShowHeader = false;
            ret.ShowFooter = false;
            ret.DropDownRows = 7;
            ret.AllowNullInput = DefaultBoolean.True;
            return ret;
        }

        public static RepositoryItemGridLookUpEdit CreateCustomerGridLookUpEdit(Session session, RepositoryItemCollection collection)
        {
            RepositoryItemGridLookUpEdit ret = new RepositoryItemGridLookUpEdit();
            if (collection != null) collection.Add(ret);
            ret.ValueMember = "This";
            ret.DisplayMember = "FullName";
            ret.DataSource = new XPCollection<Customer>(session, null, new SortProperty("FullName", DevExpress.Xpo.DB.SortingDirection.Ascending));
            return ret;
        }

        public static RepositoryItemSpinEdit CreateMovieItemPriceSpinEdit(Session session, RepositoryItemCollection collection)
        {
            RepositoryItemSpinEdit ret = new RepositoryItemSpinEdit();
            if (collection != null) collection.Add(ret);
            ret.Mask.EditMask = "c";
            ret.Mask.UseMaskAsDisplayFormat = true;
            ret.MinValue = 0;
            ret.MaxValue = 100000;
            return ret;
        }
    }

    public class ColorHelper
    {
        public static void UpdateColor(ImageCollection collection, UserLookAndFeel lf)
        {
            for (int i = 0; i < collection.Images.Count; i++)
                collection.Images[i] = SetColor(collection.Images[i] as Bitmap, GetHeaderForeColor(lf));
        }

        public static Color GetHeaderForeColor(UserLookAndFeel lf)
        {
            Color ret = SystemColors.ControlText;
            if (lf.ActiveStyle != ActiveLookAndFeelStyle.Skin) return ret;
            return GridSkins.GetSkin(lf)[GridSkins.SkinHeader].Color.GetForeColor();
        }

        private static Bitmap SetColor(Bitmap bmp, Color color)
        {
            for (int i = 0; i < bmp.Width; i++)
                for (int j = 0; j < bmp.Height; j++)
                    if (bmp.GetPixel(i, j).Name != "0")
                        bmp.SetPixel(i, j, color);
            return bmp;
        }
    }

    public class ImageCreator
    {
        public static Image CreateImage(Image srcImage, int maxWidth, int maxHeight)
        {
            if (srcImage == null) return null;
            Size size = GetPhotoSize(srcImage, maxWidth, maxHeight);
            Image ret = new Bitmap(size.Width, size.Height);
            using (Graphics gr = Graphics.FromImage(ret))
            {
                gr.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                gr.DrawImage(srcImage, new Rectangle(0, 0, size.Width, size.Height));
            }
            return ret;
        }

        private static Size GetPhotoSize(Image image, int maxWidth, int maxHeight)
        {
            int width = Math.Min(maxWidth, image.Width),
                height = width * image.Height / image.Width;
            if (height > maxHeight)
            {
                height = maxHeight;
                width = height * image.Width / image.Height;
            }
            return new Size(width, height);
        }

        public static Rectangle GetZoomDestRectangle(Rectangle r, Image img)
        {
            float horzRatio = Math.Min((float)r.Width / img.Width, 1);
            float vertRatio = Math.Min((float)r.Height / img.Height, 1);
            float zoomRatio = Math.Min(horzRatio, vertRatio);

            return new Rectangle(
                r.Left + (int)(r.Width - img.Width * zoomRatio) / 2,
                r.Top + (int)(r.Height - img.Height * zoomRatio) / 2,
                (int)(img.Width * zoomRatio),
                (int)(img.Height * zoomRatio));
        }
    }

    public class DateHelper
    {
        public static DateTime GetStartDateForMonths(int count)
        {
            DateTime dt = DateTime.Now.AddMonths(count);
            return new DateTime(dt.Year, dt.Month, 1);
        }
    }
}