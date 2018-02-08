namespace NukaCollect.Reports {
    partial class CustomerSelectionReportBase {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.xpCollectionCustomers = new DevExpress.Xpo.XPCollection();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollectionCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // xpCollectionCustomers
            // 
            this.xpCollectionCustomers.ObjectType = typeof(NukaCollect.Customer);
            this.xpCollectionCustomers.Sorting.AddRange(new DevExpress.Xpo.SortProperty[] {
            new DevExpress.Xpo.SortProperty("[FullNameLastSorting]", DevExpress.Xpo.DB.SortingDirection.Ascending)});
            this.xpCollectionCustomers.ResolveSession += new DevExpress.Xpo.ResolveSessionEventHandler(this.xpCollectionCustomers_ResolveSession);
            // 
            // CustomerSelectionReportBase
            // 
            this.DataSource = this.xpCollectionCustomers;
            this.RequestParameters = false;
            this.Version = "10.2";
            ((System.ComponentModel.ISupportInitialize)(this.xpCollectionCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.Xpo.XPCollection xpCollectionCustomers;
    }
}
