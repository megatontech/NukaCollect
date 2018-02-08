namespace NukaCollect.Win.Forms {
    partial class frmOpenImageDialog {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.treeList = new DevExpress.XtraTreeList.TreeList();
            this.colName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colPath = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.layoutControl = new DevExpress.XtraLayout.LayoutControl();
            this.pictureEdit = new DevExpress.XtraEditors.PictureEdit();
            this.teImageScale = new DevExpress.XtraEditors.TextEdit();
            this.sbOk = new DevExpress.XtraEditors.SimpleButton();
            this.sbCancel = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciTreeList = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciImageScale = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciPictureEdit = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.splitterItem1 = new DevExpress.XtraLayout.SplitterItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.treeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).BeginInit();
            this.layoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teImageScale.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciTreeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciImageScale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciPictureEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // treeList
            // 
            this.treeList.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colName,
            this.colPath});
            this.treeList.Location = new System.Drawing.Point(12, 12);
            this.treeList.Name = "treeList";
            this.treeList.OptionsBehavior.Editable = false;
            this.treeList.OptionsView.ShowHorzLines = false;
            this.treeList.OptionsView.ShowIndicator = false;
            this.treeList.OptionsView.ShowVertLines = false;
            this.treeList.Size = new System.Drawing.Size(208, 458);
            this.treeList.TabIndex = 0;
            this.treeList.CompareNodeValues += new DevExpress.XtraTreeList.CompareNodeValuesEventHandler(this.treeList_CompareNodeValues);
            this.treeList.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(this.treeList_FocusedNodeChanged);
            this.treeList.GetStateImage += new DevExpress.XtraTreeList.GetStateImageEventHandler(this.treeList_GetStateImage);
            this.treeList.VirtualTreeGetChildNodes += new DevExpress.XtraTreeList.VirtualTreeGetChildNodesEventHandler(this.treeList_VirtualTreeGetChildNodes);
            this.treeList.VirtualTreeGetCellValue += new DevExpress.XtraTreeList.VirtualTreeGetCellValueEventHandler(this.treeList_VirtualTreeGetCellValue);
            // 
            // colName
            // 
            this.colName.Caption = "Name";
            this.colName.FieldName = "Name";
            this.colName.MinWidth = 39;
            this.colName.Name = "colName";
            this.colName.OptionsColumn.AllowEdit = false;
            this.colName.OptionsColumn.AllowFocus = false;
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            // 
            // colPath
            // 
            this.colPath.Caption = "Path";
            this.colPath.FieldName = "Path";
            this.colPath.Name = "colPath";
            // 
            // layoutControl
            // 
            this.layoutControl.Controls.Add(this.pictureEdit);
            this.layoutControl.Controls.Add(this.teImageScale);
            this.layoutControl.Controls.Add(this.treeList);
            this.layoutControl.Controls.Add(this.sbOk);
            this.layoutControl.Controls.Add(this.sbCancel);
            this.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl.Location = new System.Drawing.Point(0, 0);
            this.layoutControl.Name = "layoutControl";
            this.layoutControl.Root = this.layoutControlGroup1;
            this.layoutControl.Size = new System.Drawing.Size(572, 520);
            this.layoutControl.TabIndex = 2;
            this.layoutControl.Text = "layoutControl1";
            // 
            // pictureEdit
            // 
            this.pictureEdit.Location = new System.Drawing.Point(230, 12);
            this.pictureEdit.Name = "pictureEdit";
            this.pictureEdit.Properties.AllowFocused = false;
            this.pictureEdit.Properties.NullText = " ";
            this.pictureEdit.Properties.ShowMenu = false;
            this.pictureEdit.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.pictureEdit.Size = new System.Drawing.Size(330, 434);
            this.pictureEdit.StyleController = this.layoutControl;
            this.pictureEdit.TabIndex = 0;
            this.pictureEdit.TabStop = true;
            this.pictureEdit.LoadCompleted += new System.EventHandler(this.pictureEdit_LoadCompleted);
            this.pictureEdit.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.pictureEdit_EditValueChanging);
            // 
            // teImageScale
            // 
            this.teImageScale.Location = new System.Drawing.Point(230, 450);
            this.teImageScale.Name = "teImageScale";
            this.teImageScale.Properties.ReadOnly = true;
            this.teImageScale.Size = new System.Drawing.Size(330, 20);
            this.teImageScale.StyleController = this.layoutControl;
            this.teImageScale.TabIndex = 0;
            this.teImageScale.TabStop = false;
            this.teImageScale.Click += new System.EventHandler(this.teImageScale_Click);
            // 
            // sbOk
            // 
            this.sbOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.sbOk.Location = new System.Drawing.Point(423, 486);
            this.sbOk.Name = "sbOk";
            this.sbOk.Size = new System.Drawing.Size(66, 22);
            this.sbOk.StyleController = this.layoutControl;
            this.sbOk.TabIndex = 3;
            this.sbOk.Text = "OK";
            // 
            // sbCancel
            // 
            this.sbCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.sbCancel.Location = new System.Drawing.Point(493, 486);
            this.sbCancel.Name = "sbCancel";
            this.sbCancel.Size = new System.Drawing.Size(67, 22);
            this.sbCancel.StyleController = this.layoutControl;
            this.sbCancel.TabIndex = 4;
            this.sbCancel.Text = "Cancel";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciTreeList,
            this.lciImageScale,
            this.lciPictureEdit,
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.emptySpaceItem1,
            this.splitterItem1,
            this.emptySpaceItem2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(572, 520);
            this.layoutControlGroup1.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup1.Text = "Root";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // lciTreeList
            // 
            this.lciTreeList.Control = this.treeList;
            this.lciTreeList.CustomizationFormText = "layoutControlItem1";
            this.lciTreeList.Location = new System.Drawing.Point(0, 0);
            this.lciTreeList.Name = "lciTreeList";
            this.lciTreeList.Size = new System.Drawing.Size(212, 462);
            this.lciTreeList.Text = "lciTreeList";
            this.lciTreeList.TextSize = new System.Drawing.Size(0, 0);
            this.lciTreeList.TextToControlDistance = 0;
            this.lciTreeList.TextVisible = false;
            // 
            // lciImageScale
            // 
            this.lciImageScale.Control = this.teImageScale;
            this.lciImageScale.CustomizationFormText = "lciImageScale";
            this.lciImageScale.Location = new System.Drawing.Point(218, 438);
            this.lciImageScale.Name = "lciImageScale";
            this.lciImageScale.Size = new System.Drawing.Size(334, 24);
            this.lciImageScale.Text = "lciImageScale";
            this.lciImageScale.TextSize = new System.Drawing.Size(0, 0);
            this.lciImageScale.TextToControlDistance = 0;
            this.lciImageScale.TextVisible = false;
            // 
            // lciPictureEdit
            // 
            this.lciPictureEdit.Control = this.pictureEdit;
            this.lciPictureEdit.CustomizationFormText = "lciPictureEdit";
            this.lciPictureEdit.Location = new System.Drawing.Point(218, 0);
            this.lciPictureEdit.Name = "lciPictureEdit";
            this.lciPictureEdit.Size = new System.Drawing.Size(334, 438);
            this.lciPictureEdit.Text = "lciPictureEdit";
            this.lciPictureEdit.TextSize = new System.Drawing.Size(0, 0);
            this.lciPictureEdit.TextToControlDistance = 0;
            this.lciPictureEdit.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.sbOk;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(411, 474);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(70, 26);
            this.layoutControlItem1.Text = "layoutControlItem1";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextToControlDistance = 0;
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.sbCancel;
            this.layoutControlItem2.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem2.Location = new System.Drawing.Point(481, 474);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(71, 26);
            this.layoutControlItem2.Text = "layoutControlItem2";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextToControlDistance = 0;
            this.layoutControlItem2.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 474);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(411, 26);
            this.emptySpaceItem1.Text = "emptySpaceItem1";
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // splitterItem1
            // 
            this.splitterItem1.AllowHotTrack = true;
            this.splitterItem1.CustomizationFormText = "splitterItem1";
            this.splitterItem1.Location = new System.Drawing.Point(212, 0);
            this.splitterItem1.Name = "splitterItem1";
            this.splitterItem1.Size = new System.Drawing.Size(6, 462);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.CustomizationFormText = "emptySpaceItem2";
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 462);
            this.emptySpaceItem2.MaxSize = new System.Drawing.Size(0, 12);
            this.emptySpaceItem2.MinSize = new System.Drawing.Size(1, 12);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(552, 12);
            this.emptySpaceItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem2.Text = "emptySpaceItem2";
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // frmOpenImageDialog
            // 
            this.AcceptButton = this.sbOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.sbCancel;
            this.ClientSize = new System.Drawing.Size(572, 520);
            this.Controls.Add(this.layoutControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmOpenImageDialog";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Open Image";
            ((System.ComponentModel.ISupportInitialize)(this.treeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).EndInit();
            this.layoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teImageScale.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciTreeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciImageScale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciPictureEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTreeList.TreeList treeList;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colName;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colPath;
        private DevExpress.XtraLayout.LayoutControl layoutControl;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem lciTreeList;
        private DevExpress.XtraEditors.SimpleButton sbOk;
        private DevExpress.XtraEditors.SimpleButton sbCancel;
        private DevExpress.XtraEditors.TextEdit teImageScale;
        private DevExpress.XtraLayout.LayoutControlItem lciImageScale;
        private DevExpress.XtraEditors.PictureEdit pictureEdit;
        private DevExpress.XtraLayout.LayoutControlItem lciPictureEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.SplitterItem splitterItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
    }
}
