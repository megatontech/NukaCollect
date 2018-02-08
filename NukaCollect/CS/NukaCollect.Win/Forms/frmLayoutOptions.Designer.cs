namespace NukaCollect.Win.Forms {
    partial class frmLayoutOptions {
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
            this.lcMain = new DevExpress.XtraLayout.LayoutControl();
            this.ceAllowRestoreDockingLayout = new DevExpress.XtraEditors.CheckEdit();
            this.ceDefaultEditGridViewInDetailForms = new DevExpress.XtraEditors.CheckEdit();
            this.sbCancel = new DevExpress.XtraEditors.SimpleButton();
            this.sbOK = new DevExpress.XtraEditors.SimpleButton();
            this.ceAllowRestoreGridViewLayout = new DevExpress.XtraEditors.CheckEdit();
            this.ceAllowRestoreLayoutControlLayout = new DevExpress.XtraEditors.CheckEdit();
            this.ceAllowRestoreFormLayout = new DevExpress.XtraEditors.CheckEdit();
            this.sbClearLayouts = new DevExpress.XtraEditors.SimpleButton();
            this.lcgMain = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).BeginInit();
            this.lcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ceAllowRestoreDockingLayout.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceDefaultEditGridViewInDetailForms.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceAllowRestoreGridViewLayout.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceAllowRestoreLayoutControlLayout.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceAllowRestoreFormLayout.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            this.SuspendLayout();
            // 
            // lcMain
            // 
            this.lcMain.AllowCustomizationMenu = false;
            this.lcMain.Controls.Add(this.ceAllowRestoreDockingLayout);
            this.lcMain.Controls.Add(this.ceDefaultEditGridViewInDetailForms);
            this.lcMain.Controls.Add(this.sbCancel);
            this.lcMain.Controls.Add(this.sbOK);
            this.lcMain.Controls.Add(this.ceAllowRestoreGridViewLayout);
            this.lcMain.Controls.Add(this.ceAllowRestoreLayoutControlLayout);
            this.lcMain.Controls.Add(this.ceAllowRestoreFormLayout);
            this.lcMain.Controls.Add(this.sbClearLayouts);
            this.lcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcMain.Location = new System.Drawing.Point(0, 0);
            this.lcMain.Name = "lcMain";
            this.lcMain.Root = this.lcgMain;
            this.lcMain.Size = new System.Drawing.Size(338, 285);
            this.lcMain.TabIndex = 1;
            this.lcMain.Text = "layoutControl1";
            // 
            // ceAllowRestoreDockingLayout
            // 
            this.ceAllowRestoreDockingLayout.Location = new System.Drawing.Point(12, 78);
            this.ceAllowRestoreDockingLayout.Name = "ceAllowRestoreDockingLayout";
            this.ceAllowRestoreDockingLayout.Properties.Caption = "Save and restore dock window layouts";
            this.ceAllowRestoreDockingLayout.Size = new System.Drawing.Size(314, 18);
            this.ceAllowRestoreDockingLayout.StyleController = this.lcMain;
            this.ceAllowRestoreDockingLayout.TabIndex = 11;
            // 
            // ceDefaultEditGridViewInDetailForms
            // 
            this.ceDefaultEditGridViewInDetailForms.Location = new System.Drawing.Point(12, 100);
            this.ceDefaultEditGridViewInDetailForms.Name = "ceDefaultEditGridViewInDetailForms";
            this.ceDefaultEditGridViewInDetailForms.Properties.Caption = "Enable data editing within the grid";
            this.ceDefaultEditGridViewInDetailForms.Size = new System.Drawing.Size(314, 18);
            this.ceDefaultEditGridViewInDetailForms.StyleController = this.lcMain;
            this.ceDefaultEditGridViewInDetailForms.TabIndex = 10;
            // 
            // sbCancel
            // 
            this.sbCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.sbCancel.Location = new System.Drawing.Point(246, 251);
            this.sbCancel.Name = "sbCancel";
            this.sbCancel.Size = new System.Drawing.Size(80, 22);
            this.sbCancel.StyleController = this.lcMain;
            this.sbCancel.TabIndex = 9;
            this.sbCancel.Text = "&Cancel";
            // 
            // sbOK
            // 
            this.sbOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.sbOK.Location = new System.Drawing.Point(166, 251);
            this.sbOK.Name = "sbOK";
            this.sbOK.Size = new System.Drawing.Size(76, 22);
            this.sbOK.StyleController = this.lcMain;
            this.sbOK.TabIndex = 8;
            this.sbOK.Text = "&OK";
            // 
            // ceAllowRestoreGridViewLayout
            // 
            this.ceAllowRestoreGridViewLayout.Location = new System.Drawing.Point(12, 56);
            this.ceAllowRestoreGridViewLayout.Name = "ceAllowRestoreGridViewLayout";
            this.ceAllowRestoreGridViewLayout.Properties.Caption = "Save and restore grid control layouts";
            this.ceAllowRestoreGridViewLayout.Size = new System.Drawing.Size(314, 18);
            this.ceAllowRestoreGridViewLayout.StyleController = this.lcMain;
            this.ceAllowRestoreGridViewLayout.TabIndex = 7;
            // 
            // ceAllowRestoreLayoutControlLayout
            // 
            this.ceAllowRestoreLayoutControlLayout.Location = new System.Drawing.Point(12, 34);
            this.ceAllowRestoreLayoutControlLayout.Name = "ceAllowRestoreLayoutControlLayout";
            this.ceAllowRestoreLayoutControlLayout.Properties.Caption = "Save and restore control layout within forms";
            this.ceAllowRestoreLayoutControlLayout.Size = new System.Drawing.Size(314, 18);
            this.ceAllowRestoreLayoutControlLayout.StyleController = this.lcMain;
            this.ceAllowRestoreLayoutControlLayout.TabIndex = 6;
            // 
            // ceAllowRestoreFormLayout
            // 
            this.ceAllowRestoreFormLayout.Location = new System.Drawing.Point(12, 12);
            this.ceAllowRestoreFormLayout.Name = "ceAllowRestoreFormLayout";
            this.ceAllowRestoreFormLayout.Properties.Caption = "Save and restore Detail View layouts";
            this.ceAllowRestoreFormLayout.Size = new System.Drawing.Size(314, 18);
            this.ceAllowRestoreFormLayout.StyleController = this.lcMain;
            this.ceAllowRestoreFormLayout.TabIndex = 5;
            // 
            // sbClearLayouts
            // 
            this.sbClearLayouts.Location = new System.Drawing.Point(12, 215);
            this.sbClearLayouts.Name = "sbClearLayouts";
            this.sbClearLayouts.Size = new System.Drawing.Size(314, 22);
            this.sbClearLayouts.StyleController = this.lcMain;
            this.sbClearLayouts.TabIndex = 4;
            this.sbClearLayouts.Text = "Clear Layouts";
            this.sbClearLayouts.Click += new System.EventHandler(this.sbClearLayouts_Click);
            // 
            // lcgMain
            // 
            this.lcgMain.CustomizationFormText = "lcgMain";
            this.lcgMain.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.lcgMain.GroupBordersVisible = false;
            this.lcgMain.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem1,
            this.emptySpaceItem1,
            this.emptySpaceItem2,
            this.emptySpaceItem3,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.layoutControlItem8});
            this.lcgMain.Location = new System.Drawing.Point(0, 0);
            this.lcgMain.Name = "lcgMain";
            this.lcgMain.Size = new System.Drawing.Size(338, 285);
            this.lcgMain.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.lcgMain.Text = "lcgMain";
            this.lcgMain.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.ceAllowRestoreFormLayout;
            this.layoutControlItem2.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(318, 22);
            this.layoutControlItem2.Text = "layoutControlItem2";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextToControlDistance = 0;
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.ceAllowRestoreLayoutControlLayout;
            this.layoutControlItem3.CustomizationFormText = "layoutControlItem3";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 22);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(318, 22);
            this.layoutControlItem3.Text = "layoutControlItem3";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextToControlDistance = 0;
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.ceAllowRestoreGridViewLayout;
            this.layoutControlItem4.CustomizationFormText = "layoutControlItem4";
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 44);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(318, 22);
            this.layoutControlItem4.Text = "layoutControlItem4";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextToControlDistance = 0;
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.sbClearLayouts;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 203);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(318, 26);
            this.layoutControlItem1.Text = "layoutControlItem1";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextToControlDistance = 0;
            this.layoutControlItem1.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 110);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(318, 93);
            this.emptySpaceItem1.Text = "emptySpaceItem1";
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.CustomizationFormText = "emptySpaceItem2";
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 229);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(318, 10);
            this.emptySpaceItem2.Text = "emptySpaceItem2";
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.CustomizationFormText = "emptySpaceItem3";
            this.emptySpaceItem3.Location = new System.Drawing.Point(0, 239);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(154, 26);
            this.emptySpaceItem3.Text = "emptySpaceItem3";
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.sbOK;
            this.layoutControlItem5.CustomizationFormText = "layoutControlItem5";
            this.layoutControlItem5.Location = new System.Drawing.Point(154, 239);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(80, 26);
            this.layoutControlItem5.Text = "layoutControlItem5";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextToControlDistance = 0;
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.sbCancel;
            this.layoutControlItem6.CustomizationFormText = "layoutControlItem6";
            this.layoutControlItem6.Location = new System.Drawing.Point(234, 239);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(84, 26);
            this.layoutControlItem6.Text = "layoutControlItem6";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextToControlDistance = 0;
            this.layoutControlItem6.TextVisible = false;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.ceDefaultEditGridViewInDetailForms;
            this.layoutControlItem7.CustomizationFormText = "layoutControlItem7";
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 88);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(318, 22);
            this.layoutControlItem7.Text = "layoutControlItem7";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextToControlDistance = 0;
            this.layoutControlItem7.TextVisible = false;
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.ceAllowRestoreDockingLayout;
            this.layoutControlItem8.CustomizationFormText = "layoutControlItem8";
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 66);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(318, 22);
            this.layoutControlItem8.Text = "layoutControlItem8";
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextToControlDistance = 0;
            this.layoutControlItem8.TextVisible = false;
            // 
            // frmLayoutOptions
            // 
            this.AcceptButton = this.sbOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.sbCancel;
            this.ClientSize = new System.Drawing.Size(338, 285);
            this.Controls.Add(this.lcMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLayoutOptions";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Layout options";
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).EndInit();
            this.lcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ceAllowRestoreDockingLayout.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceDefaultEditGridViewInDetailForms.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceAllowRestoreGridViewLayout.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceAllowRestoreLayoutControlLayout.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceAllowRestoreFormLayout.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected DevExpress.XtraLayout.LayoutControl lcMain;
        private DevExpress.XtraEditors.SimpleButton sbClearLayouts;
        protected DevExpress.XtraLayout.LayoutControlGroup lcgMain;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.CheckEdit ceAllowRestoreGridViewLayout;
        private DevExpress.XtraEditors.CheckEdit ceAllowRestoreLayoutControlLayout;
        private DevExpress.XtraEditors.CheckEdit ceAllowRestoreFormLayout;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraEditors.SimpleButton sbCancel;
        private DevExpress.XtraEditors.SimpleButton sbOK;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraEditors.CheckEdit ceDefaultEditGridViewInDetailForms;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraEditors.CheckEdit ceAllowRestoreDockingLayout;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
    }
}
