using DevExpress.Utils;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Nodes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace NukaCollect.Win.Forms
{
    public partial class frmOpenImageDialog : XtraForm
    {
        private class FileAssociatedIcons
        {
            private ImageCollection collection;
            private Dictionary<string, int> indexes;

            public FileAssociatedIcons()
            {
                collection = new ImageCollection();
                indexes = new Dictionary<string, int>();
            }

            public ImageCollection Collection { get { return collection; } }

            public int IconIndex(string file, bool folderOpen)
            {
                string type = GetFileType(file, folderOpen);
                if (indexes.ContainsKey(type)) return indexes[type];
                collection.AddImage(GetIcon(type, file));
                indexes.Add(type, collection.Images.Count - 1);
                return indexes[type];
            }

            private static Image GetIcon(string type, string file)
            {
                if (type == "Drive") return ElementHelper.FolderIcons.Images[0];
                if (type == "Open Folder") return ElementHelper.FolderIcons.Images[1];
                if (type == "Close Folder") return ElementHelper.FolderIcons.Images[2];
                Icon icon = WinApiWrapper.GetIconBySHGetFileInfo(file, true);
                return icon == null ? null : icon.ToBitmap();
            }

            private static string GetFileType(string file, bool folderOpen)
            {
                if (IsDrive(file)) return "Drive";
                if (IsFolder(file)) return folderOpen ? "Open Folder" : "Close Folder";
                return WinApiWrapper.GetTypeNameBySHGetFileInfo(file);
            }

            public static bool IsFolder(string file)
            {
                DirectoryInfo di = new DirectoryInfo(file);
                try
                {
                    return (di.Attributes & FileAttributes.Directory) != 0;
                }
                catch
                {
                    return false;
                }
            }

            public static bool IsDrive(string file)
            {
                DirectoryInfo di = new DirectoryInfo(file);
                string[] drives = Directory.GetLogicalDrives();
                foreach (string drive in drives)
                {
                    if (drive == di.Name) return true;
                }
                return false;
            }
        }

        public delegate void SetImageDelegate(Image value);

        private bool loadDrives = false;
        private SetImageDelegate resultImage;
        private static FileAssociatedIcons icons = new FileAssociatedIcons();
        private string currentPath;
        private Size maxImageSize = new Size(3000, 2000);
        private Timer nodeChangedTimer;
        private FormLayoutManager layoutManager;
        private BarManager bManager;

        public string CurrentPath
        {
            get { return currentPath; }
            set { currentPath = value; }
        }

        public frmOpenImageDialog(SetImageDelegate resultImage) : this(resultImage, null)
        {
        }

        public frmOpenImageDialog(SetImageDelegate resultImage, FormLayoutManager manager) : base()
        {
            InitializeComponent();
            ElementConstStringLoader.LoadConstStringsForFrmOpenImageDialog(this);
            InitData();
            this.resultImage = resultImage;
            bManager = new BarManager();
            bManager.Form = this;
            treeList.StateImageList = icons.Collection;
            treeList.MenuManager = bManager;
            teImageScale.MenuManager = bManager;
            layoutControl.MenuManager = bManager;
            nodeChangedTimer = new Timer();
            nodeChangedTimer.Interval = 300;
            nodeChangedTimer.Tick += new EventHandler(nodeChangedTimer_Tick);
            layoutManager = manager;
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            if (disposing) bManager.Dispose();
            base.Dispose(disposing);
        }

        private void InitData()
        {
            treeList.DataSource = new object();
        }

        private string[] pictureExtensions = { ".png", ".bmp", ".dib", ".jpg", ".jpeg", ".jpe", ".jfif", ".gif", ".tif", ".tiff", ".ico" };

        private bool IsPicture(string path)
        {
            foreach (string mask in pictureExtensions)
            {
                if (path.Length <= mask.Length) continue;
                if (path.Substring(path.Length - mask.Length, mask.Length) == mask) return true;
            }
            return false;
        }

        private void treeList_VirtualTreeGetChildNodes(object sender, DevExpress.XtraTreeList.VirtualTreeGetChildNodesInfo e)
        {
            Cursor currentCursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;
            if (!loadDrives)
            {
                string[] roots = Directory.GetLogicalDrives();
                e.Children = roots;
                loadDrives = true;
            }
            else
            {
                try
                {
                    string path = (string)e.Node;
                    if (Directory.Exists(path))
                    {
                        string[] dirs = Directory.GetDirectories(path);
                        string[] files = Directory.GetFiles(path);
                        string[] imageFiles = new string[files.Length];
                        int imageFilesCount = 0;
                        foreach (string file in files)
                        {
                            if (IsPicture(file)) imageFiles[imageFilesCount++] = file;
                        }
                        string[] arr = new string[dirs.Length + imageFilesCount];
                        dirs.CopyTo(arr, 0);
                        for (int i = 0; i < imageFilesCount; ++i)
                        {
                            arr[dirs.Length + i] = imageFiles[i];
                        }
                        e.Children = arr;
                    }
                    else e.Children = new object[] { };
                }
                catch { e.Children = new object[] { }; }
            }
            Cursor.Current = currentCursor;
        }

        private void treeList_VirtualTreeGetCellValue(object sender, DevExpress.XtraTreeList.VirtualTreeGetCellValueInfo e)
        {
            string path = (string)e.Node;
            DirectoryInfo di = new DirectoryInfo(path);
            if (e.Column == colName) e.CellData = di.Name;
            else e.CellData = path;
        }

        private void treeList_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {
            nodeChangedTimer.Stop();
            sbOk.Enabled = false;
            CurrentPath = (string)e.Node.GetValue(1);
            teImageScale.Text = string.Empty;
            pictureEdit.CancelLoadAsync();
            if (FileAssociatedIcons.IsFolder(CurrentPath)) pictureEdit.Image = null;
            else
                nodeChangedTimer.Start();
        }

        private void nodeChangedTimer_Tick(object sender, EventArgs e)
        {
            pictureEdit.LoadAsync(CurrentPath);
            nodeChangedTimer.Stop();
        }

        private void treeList_GetStateImage(object sender, DevExpress.XtraTreeList.GetStateImageEventArgs e)
        {
            e.NodeImageIndex = icons.IconIndex(e.Node.GetDisplayText("Path"), e.Node.Expanded);
        }

        private void pictureEdit_LoadCompleted(object sender, EventArgs e)
        {
            PictureEdit pictureEdit = (PictureEdit)((RepositoryItemPictureEdit)sender).OwnerEdit;
            if (pictureEdit.Image == null) return;
            teImageScale.Text = string.Format("{0} x {1}", pictureEdit.Image.Size.Width, pictureEdit.Image.Size.Height);
            sbOk.Enabled = true;
        }

        private void teImageScale_Click(object sender, EventArgs e)
        {
            treeList.Focus();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.SuspendLayout();
            LoadFormLayout();
            treeList.ForceInitialize();
            DrawPath(CurrentPath);
            this.ResumeLayout();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (DialogResult == DialogResult.OK && resultImage != null) resultImage(pictureEdit.Image);
            SaveFormLayout();
        }

        public void DrawPath(string path)
        {
            CurrentPath = path;
            treeList.CollapseAll();
            if (string.IsNullOrEmpty(path)) return;
            if (path[path.Length - 1] == '\\') path = path.Remove(path.Length - 1);
            string[] pathParts = path.Split(new char[] { '\\' });
            string nodePath = string.Empty;
            TreeListNode lastNode = null;
            for (int i = 0; i < pathParts.Length; ++i)
            {
                nodePath += pathParts[i];
                string nodePathWithBackslash = nodePath + "\\";
                if (nodePath[nodePath.Length - 1] == ':') nodePath = nodePathWithBackslash;
                TreeListNode node = treeList.FindNodeByFieldValue("Path", nodePath);
                if (node != null) node.Expanded = true;
                lastNode = node;
                nodePath = nodePathWithBackslash;
            }
            if (lastNode != null)
            {
                lastNode.Expanded = false;
                treeList.SetFocusedNode(lastNode);
            }
        }

        private void pictureEdit_EditValueChanging(object sender, ChangingEventArgs e)
        {
            Bitmap bmp = e.NewValue as Bitmap;
            try
            {
                if (bmp != null && (bmp.Width > maxImageSize.Width || bmp.Height > maxImageSize.Height))
                {
                    decimal delta = Math.Max((decimal)bmp.Width / maxImageSize.Width, (decimal)bmp.Height / maxImageSize.Height);
                    Size size = new Size((int)(bmp.Width / delta), (int)(bmp.Height / delta));
                    Bitmap resized = new Bitmap(bmp, size);
                    bmp.Dispose();
                    e.NewValue = resized;
                }
            }
            catch { }
        }

        private void treeList_CompareNodeValues(object sender, CompareNodeValuesEventArgs e)
        {
            string path1 = (string)e.Node1.GetValue(1);
            string path2 = (string)e.Node2.GetValue(1);
            bool isFolder1 = FileAssociatedIcons.IsFolder(path1);
            bool isFolder2 = FileAssociatedIcons.IsFolder(path2);
            if (isFolder1 && !isFolder2) e.Result = e.SortOrder == SortOrder.Ascending ? -1 : 1;
            if (!isFolder1 && isFolder2) e.Result = e.SortOrder == SortOrder.Ascending ? 1 : -1;
        }

        private void LoadFormLayout()
        {
            if (layoutManager == null) return;
            layoutManager.RestoreFormLayout(new FormLayoutInfo(this, layoutControl));
        }

        private void SaveFormLayout()
        {
            if (layoutManager == null) return;
            layoutManager.SaveFormLayout(new FormLayoutInfo(this, layoutControl));
        }

    }
}