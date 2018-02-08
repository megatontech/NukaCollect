namespace NukaCollect.Win.Forms {
    partial class frmMovieAddArtist {
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
            this.lciArtist = new DevExpress.XtraLayout.LayoutControlItem();
            this.lueArtist = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.lciLine = new DevExpress.XtraLayout.LayoutControlItem();
            this.lueLine = new DevExpress.XtraEditors.LookUpEdit();
            this.meDescription = new DevExpress.XtraEditors.MemoEdit();
            this.lciDescription = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).BeginInit();
            this.lcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lcgMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciArtist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueArtist.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueLine.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDescription)).BeginInit();
            this.SuspendLayout();
            // 
            // lcMain
            // 
            this.lcMain.Controls.Add(this.meDescription);
            this.lcMain.Controls.Add(this.lueLine);
            this.lcMain.Controls.Add(this.lueArtist);
            this.lcMain.Size = new System.Drawing.Size(392, 232);
            // 
            // lcgMain
            // 
            this.lcgMain.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciArtist,
            this.lciLine,
            this.lciDescription});
            this.lcgMain.Size = new System.Drawing.Size(392, 232);
            // 
            // lciArtist
            // 
            this.lciArtist.Control = this.lueArtist;
            this.lciArtist.CustomizationFormText = "Artist";
            this.lciArtist.Location = new System.Drawing.Point(0, 0);
            this.lciArtist.Name = "lciArtist";
            this.lciArtist.Size = new System.Drawing.Size(392, 24);
            this.lciArtist.Text = "Actor/Crew:";
            this.lciArtist.TextSize = new System.Drawing.Size(59, 13);
            // 
            // lueArtist
            // 
            this.lueArtist.Location = new System.Drawing.Point(65, 2);
            this.lueArtist.Name = "lueArtist";
            this.lueArtist.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)});
            this.lueArtist.Properties.NullText = "";
            this.lueArtist.Properties.PopupSizeable = false;
            this.lueArtist.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lueArtist.Properties.View = this.gridLookUpEdit1View;
            this.lueArtist.Size = new System.Drawing.Size(325, 20);
            this.lueArtist.StyleController = this.lcMain;
            this.lueArtist.TabIndex = 4;
            this.lueArtist.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.lueArtist_ButtonClick);
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // lciLine
            // 
            this.lciLine.Control = this.lueLine;
            this.lciLine.CustomizationFormText = "Line";
            this.lciLine.Location = new System.Drawing.Point(0, 24);
            this.lciLine.Name = "lciLine";
            this.lciLine.Size = new System.Drawing.Size(392, 24);
            this.lciLine.Text = "Credits:";
            this.lciLine.TextSize = new System.Drawing.Size(59, 13);
            // 
            // lueLine
            // 
            this.lueLine.Location = new System.Drawing.Point(65, 26);
            this.lueLine.Name = "lueLine";
            this.lueLine.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueLine.Properties.NullText = "";
            this.lueLine.Properties.PopupSizeable = false;
            this.lueLine.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lueLine.Size = new System.Drawing.Size(325, 20);
            this.lueLine.StyleController = this.lcMain;
            this.lueLine.TabIndex = 5;
            // 
            // meDescription
            // 
            this.meDescription.Location = new System.Drawing.Point(65, 50);
            this.meDescription.Name = "meDescription";
            this.meDescription.Size = new System.Drawing.Size(325, 172);
            this.meDescription.StyleController = this.lcMain;
            this.meDescription.TabIndex = 6;
            // 
            // lciDescription
            // 
            this.lciDescription.AppearanceItemCaption.Options.UseTextOptions = true;
            this.lciDescription.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.lciDescription.Control = this.meDescription;
            this.lciDescription.CustomizationFormText = "Description";
            this.lciDescription.Location = new System.Drawing.Point(0, 48);
            this.lciDescription.Name = "lciDescription";
            this.lciDescription.Size = new System.Drawing.Size(392, 176);
            this.lciDescription.Text = "Description:";
            this.lciDescription.TextSize = new System.Drawing.Size(59, 13);
            // 
            // frmMovieAddArtist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 278);
            this.Name = "frmMovieAddArtist";
            this.ShowIcon = false;
            this.Text = "Add Movie Artist";
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).EndInit();
            this.lcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lcgMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciArtist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueArtist.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueLine.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDescription)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControlItem lciArtist;
        private DevExpress.XtraEditors.MemoEdit meDescription;
        private DevExpress.XtraLayout.LayoutControlItem lciLine;
        private DevExpress.XtraLayout.LayoutControlItem lciDescription;
        private DevExpress.XtraEditors.LookUpEdit lueLine;
        private DevExpress.XtraEditors.GridLookUpEdit lueArtist;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
    }
}
