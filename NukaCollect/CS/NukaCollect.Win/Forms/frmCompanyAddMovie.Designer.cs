namespace NukaCollect.Win.Forms {
    partial class frmCompanyAddMovie {
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
            this.lciMovie = new DevExpress.XtraLayout.LayoutControlItem();
            this.lueMovie = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.lciDescription = new DevExpress.XtraLayout.LayoutControlItem();
            this.teDescription = new DevExpress.XtraEditors.MemoEdit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).BeginInit();
            this.lcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lcgMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciMovie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueMovie.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teDescription.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lcMain
            // 
            this.lcMain.Controls.Add(this.teDescription);
            this.lcMain.Controls.Add(this.lueMovie);
            this.lcMain.Size = new System.Drawing.Size(368, 186);
            // 
            // lcgMain
            // 
            this.lcgMain.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciMovie,
            this.lciDescription});
            this.lcgMain.Size = new System.Drawing.Size(368, 186);
            // 
            // lciMovie
            // 
            this.lciMovie.Control = this.lueMovie;
            this.lciMovie.CustomizationFormText = "lciMovie";
            this.lciMovie.Location = new System.Drawing.Point(0, 0);
            this.lciMovie.Name = "lciMovie";
            this.lciMovie.Size = new System.Drawing.Size(368, 24);
            this.lciMovie.Text = "Movie:";
            this.lciMovie.TextSize = new System.Drawing.Size(57, 13);
            // 
            // lueMovie
            // 
            this.lueMovie.Location = new System.Drawing.Point(63, 2);
            this.lueMovie.Name = "lueMovie";
            this.lueMovie.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueMovie.Properties.NullText = " ";
            this.lueMovie.Properties.View = this.gridLookUpEdit1View;
            this.lueMovie.Size = new System.Drawing.Size(303, 20);
            this.lueMovie.StyleController = this.lcMain;
            this.lueMovie.TabIndex = 4;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // lciDescription
            // 
            this.lciDescription.AppearanceItemCaption.Options.UseTextOptions = true;
            this.lciDescription.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.lciDescription.Control = this.teDescription;
            this.lciDescription.CustomizationFormText = "Description:";
            this.lciDescription.Location = new System.Drawing.Point(0, 24);
            this.lciDescription.Name = "lciDescription";
            this.lciDescription.Size = new System.Drawing.Size(368, 154);
            this.lciDescription.Text = "Description:";
            this.lciDescription.TextSize = new System.Drawing.Size(57, 13);
            // 
            // teDescription
            // 
            this.teDescription.Location = new System.Drawing.Point(63, 26);
            this.teDescription.Name = "teDescription";
            this.teDescription.Size = new System.Drawing.Size(303, 150);
            this.teDescription.StyleController = this.lcMain;
            this.teDescription.TabIndex = 6;
            this.teDescription.TabStop = false;
            // 
            // frmCompanyAddMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 232);
            this.Name = "frmCompanyAddMovie";
            this.ShowIcon = false;
            this.Text = "frmCompanyAddMovie";
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).EndInit();
            this.lcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lcgMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciMovie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueMovie.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teDescription.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControlItem lciMovie;
        private DevExpress.XtraLayout.LayoutControlItem lciDescription;
        private DevExpress.XtraEditors.MemoEdit teDescription;
        private DevExpress.XtraEditors.GridLookUpEdit lueMovie;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
    }
}
