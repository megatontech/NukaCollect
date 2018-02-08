namespace NukaCollect.Reports {
    partial class CustomerInfoCardReport {
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerInfoCardReport));
            DevExpress.XtraPrinting.BarCode.Code128Generator code128Generator1 = new DevExpress.XtraPrinting.BarCode.Code128Generator();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrPanelCustomerInfoCard = new DevExpress.XtraReports.UI.XRPanel();
            this.xrLabelDiscountLevel = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabelFullName = new DevExpress.XtraReports.UI.XRLabel();
            this.xrPictBoxPhoto = new DevExpress.XtraReports.UI.XRPictureBox();
            this.xrTableCustomerInfo = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRowBirthdayInfo = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCellBirthdayLabel = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCellBirthday = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRowAddressInfo = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCellAddressLabel = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCellAddress = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRowPhoneInfo = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCellPhoneLabel = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCellPhone = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrBarCodeCustomerId = new DevExpress.XtraReports.UI.XRBarCode();
            this.topMarginBand = new DevExpress.XtraReports.UI.TopMarginBand();
            this.bottomMarginBand = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.xrPageInfoPageCount = new DevExpress.XtraReports.UI.XRPageInfo();
            this.xpCollectionCustomers = new DevExpress.Xpo.XPCollection(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.xrTableCustomerInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollectionCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPanelCustomerInfoCard});
            resources.ApplyResources(this.Detail, "Detail");
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            // 
            // xrPanelCustomerInfoCard
            // 
            resources.ApplyResources(this.xrPanelCustomerInfoCard, "xrPanelCustomerInfoCard");
            this.xrPanelCustomerInfoCard.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
                        | DevExpress.XtraPrinting.BorderSide.Right)
                        | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrPanelCustomerInfoCard.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabelDiscountLevel,
            this.xrLabelFullName,
            this.xrPictBoxPhoto,
            this.xrTableCustomerInfo,
            this.xrBarCodeCustomerId});
            this.xrPanelCustomerInfoCard.Name = "xrPanelCustomerInfoCard";
            this.xrPanelCustomerInfoCard.Padding = new DevExpress.XtraPrinting.PaddingInfo(15, 0, 0, 0, 100F);
            this.xrPanelCustomerInfoCard.StylePriority.UseBackColor = false;
            this.xrPanelCustomerInfoCard.StylePriority.UseBorderColor = false;
            this.xrPanelCustomerInfoCard.StylePriority.UseBorders = false;
            this.xrPanelCustomerInfoCard.StylePriority.UsePadding = false;
            // 
            // xrLabelDiscountLevel
            // 
            this.xrLabelDiscountLevel.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabelDiscountLevel.CanGrow = false;
            this.xrLabelDiscountLevel.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "DiscountLevelCaption")});
            resources.ApplyResources(this.xrLabelDiscountLevel, "xrLabelDiscountLevel");
            this.xrLabelDiscountLevel.Name = "xrLabelDiscountLevel";
            this.xrLabelDiscountLevel.Padding = new DevExpress.XtraPrinting.PaddingInfo(1, 0, 0, 0, 100F);
            this.xrLabelDiscountLevel.StylePriority.UseBorders = false;
            this.xrLabelDiscountLevel.StylePriority.UseFont = false;
            this.xrLabelDiscountLevel.StylePriority.UseForeColor = false;
            this.xrLabelDiscountLevel.StylePriority.UsePadding = false;
            // 
            // xrLabelFullName
            // 
            this.xrLabelFullName.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabelFullName.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "FullNameLastSorting")});
            resources.ApplyResources(this.xrLabelFullName, "xrLabelFullName");
            this.xrLabelFullName.Name = "xrLabelFullName";
            this.xrLabelFullName.Padding = new DevExpress.XtraPrinting.PaddingInfo(1, 0, 0, 0, 100F);
            this.xrLabelFullName.StylePriority.UseBorders = false;
            this.xrLabelFullName.StylePriority.UseFont = false;
            this.xrLabelFullName.StylePriority.UseForeColor = false;
            this.xrLabelFullName.StylePriority.UsePadding = false;
            this.xrLabelFullName.StylePriority.UseTextAlignment = false;
            // 
            // xrPictBoxPhoto
            // 
            resources.ApplyResources(this.xrPictBoxPhoto, "xrPictBoxPhoto");
            this.xrPictBoxPhoto.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
                        | DevExpress.XtraPrinting.BorderSide.Right)
                        | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrPictBoxPhoto.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Image", null, "Photo")});
            this.xrPictBoxPhoto.Name = "xrPictBoxPhoto";
            this.xrPictBoxPhoto.Padding = new DevExpress.XtraPrinting.PaddingInfo(8, 8, 8, 8, 100F);
            this.xrPictBoxPhoto.Sizing = DevExpress.XtraPrinting.ImageSizeMode.Squeeze;
            this.xrPictBoxPhoto.StylePriority.UseBackColor = false;
            this.xrPictBoxPhoto.StylePriority.UseBorderColor = false;
            this.xrPictBoxPhoto.StylePriority.UseBorders = false;
            this.xrPictBoxPhoto.StylePriority.UsePadding = false;
            this.xrPictBoxPhoto.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.xrPictBoxPhoto_BeforePrint);
            // 
            // xrTableCustomerInfo
            // 
            resources.ApplyResources(this.xrTableCustomerInfo, "xrTableCustomerInfo");
            this.xrTableCustomerInfo.Borders = DevExpress.XtraPrinting.BorderSide.Right;
            this.xrTableCustomerInfo.Name = "xrTableCustomerInfo";
            this.xrTableCustomerInfo.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRowBirthdayInfo,
            this.xrTableRowAddressInfo,
            this.xrTableRowPhoneInfo});
            this.xrTableCustomerInfo.StylePriority.UseBackColor = false;
            this.xrTableCustomerInfo.StylePriority.UseBorders = false;
            this.xrTableCustomerInfo.StylePriority.UseFont = false;
            // 
            // xrTableRowBirthdayInfo
            // 
            this.xrTableRowBirthdayInfo.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCellBirthdayLabel,
            this.xrTableCellBirthday});
            this.xrTableRowBirthdayInfo.Name = "xrTableRowBirthdayInfo";
            this.xrTableRowBirthdayInfo.Weight = 0.55990991683711044;
            // 
            // xrTableCellBirthdayLabel
            // 
            resources.ApplyResources(this.xrTableCellBirthdayLabel, "xrTableCellBirthdayLabel");
            this.xrTableCellBirthdayLabel.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrTableCellBirthdayLabel.CanGrow = false;
            this.xrTableCellBirthdayLabel.Name = "xrTableCellBirthdayLabel";
            this.xrTableCellBirthdayLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(11, 0, 0, 0, 100F);
            this.xrTableCellBirthdayLabel.StylePriority.UseBackColor = false;
            this.xrTableCellBirthdayLabel.StylePriority.UseBorders = false;
            this.xrTableCellBirthdayLabel.StylePriority.UseFont = false;
            this.xrTableCellBirthdayLabel.StylePriority.UseForeColor = false;
            this.xrTableCellBirthdayLabel.StylePriority.UsePadding = false;
            this.xrTableCellBirthdayLabel.StylePriority.UseTextAlignment = false;
            this.xrTableCellBirthdayLabel.Weight = 0.7152040187714277;
            // 
            // xrTableCellBirthday
            // 
            resources.ApplyResources(this.xrTableCellBirthday, "xrTableCellBirthday");
            this.xrTableCellBirthday.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrTableCellBirthday.CanGrow = false;
            this.xrTableCellBirthday.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "BirthDate", "{0:d}")});
            this.xrTableCellBirthday.Multiline = true;
            this.xrTableCellBirthday.Name = "xrTableCellBirthday";
            this.xrTableCellBirthday.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 15, 0, 0, 100F);
            this.xrTableCellBirthday.StylePriority.UseBackColor = false;
            this.xrTableCellBirthday.StylePriority.UseBorderColor = false;
            this.xrTableCellBirthday.StylePriority.UseBorders = false;
            this.xrTableCellBirthday.StylePriority.UseFont = false;
            this.xrTableCellBirthday.StylePriority.UseForeColor = false;
            this.xrTableCellBirthday.StylePriority.UsePadding = false;
            this.xrTableCellBirthday.StylePriority.UseTextAlignment = false;
            this.xrTableCellBirthday.Weight = 2.2847959812285721;
            // 
            // xrTableRowAddressInfo
            // 
            this.xrTableRowAddressInfo.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCellAddressLabel,
            this.xrTableCellAddress});
            this.xrTableRowAddressInfo.Name = "xrTableRowAddressInfo";
            this.xrTableRowAddressInfo.Weight = 0.55990991683711044;
            // 
            // xrTableCellAddressLabel
            // 
            resources.ApplyResources(this.xrTableCellAddressLabel, "xrTableCellAddressLabel");
            this.xrTableCellAddressLabel.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrTableCellAddressLabel.CanGrow = false;
            this.xrTableCellAddressLabel.Name = "xrTableCellAddressLabel";
            this.xrTableCellAddressLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(11, 0, 0, 0, 100F);
            this.xrTableCellAddressLabel.StylePriority.UseBackColor = false;
            this.xrTableCellAddressLabel.StylePriority.UseBorders = false;
            this.xrTableCellAddressLabel.StylePriority.UseFont = false;
            this.xrTableCellAddressLabel.StylePriority.UseForeColor = false;
            this.xrTableCellAddressLabel.StylePriority.UsePadding = false;
            this.xrTableCellAddressLabel.StylePriority.UseTextAlignment = false;
            this.xrTableCellAddressLabel.Weight = 0.7152040187714277;
            // 
            // xrTableCellAddress
            // 
            resources.ApplyResources(this.xrTableCellAddress, "xrTableCellAddress");
            this.xrTableCellAddress.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrTableCellAddress.CanGrow = false;
            this.xrTableCellAddress.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Phone")});
            this.xrTableCellAddress.Multiline = true;
            this.xrTableCellAddress.Name = "xrTableCellAddress";
            this.xrTableCellAddress.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 15, 0, 0, 100F);
            this.xrTableCellAddress.StylePriority.UseBackColor = false;
            this.xrTableCellAddress.StylePriority.UseBorderColor = false;
            this.xrTableCellAddress.StylePriority.UseBorders = false;
            this.xrTableCellAddress.StylePriority.UseFont = false;
            this.xrTableCellAddress.StylePriority.UseForeColor = false;
            this.xrTableCellAddress.StylePriority.UsePadding = false;
            this.xrTableCellAddress.StylePriority.UseTextAlignment = false;
            this.xrTableCellAddress.Weight = 2.2847959812285721;
            // 
            // xrTableRowPhoneInfo
            // 
            this.xrTableRowPhoneInfo.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCellPhoneLabel,
            this.xrTableCellPhone});
            this.xrTableRowPhoneInfo.Name = "xrTableRowPhoneInfo";
            this.xrTableRowPhoneInfo.Weight = 1.1198198336742209;
            // 
            // xrTableCellPhoneLabel
            // 
            resources.ApplyResources(this.xrTableCellPhoneLabel, "xrTableCellPhoneLabel");
            this.xrTableCellPhoneLabel.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrTableCellPhoneLabel.Name = "xrTableCellPhoneLabel";
            this.xrTableCellPhoneLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(11, 0, 5, 0, 100F);
            this.xrTableCellPhoneLabel.StylePriority.UseBackColor = false;
            this.xrTableCellPhoneLabel.StylePriority.UseBorders = false;
            this.xrTableCellPhoneLabel.StylePriority.UseFont = false;
            this.xrTableCellPhoneLabel.StylePriority.UseForeColor = false;
            this.xrTableCellPhoneLabel.StylePriority.UsePadding = false;
            this.xrTableCellPhoneLabel.StylePriority.UseTextAlignment = false;
            this.xrTableCellPhoneLabel.Weight = 0.7152040187714277;
            // 
            // xrTableCellPhone
            // 
            resources.ApplyResources(this.xrTableCellPhone, "xrTableCellPhone");
            this.xrTableCellPhone.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrTableCellPhone.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Address")});
            this.xrTableCellPhone.Multiline = true;
            this.xrTableCellPhone.Name = "xrTableCellPhone";
            this.xrTableCellPhone.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 15, 0, 0, 100F);
            this.xrTableCellPhone.StylePriority.UseBackColor = false;
            this.xrTableCellPhone.StylePriority.UseBorderColor = false;
            this.xrTableCellPhone.StylePriority.UseBorders = false;
            this.xrTableCellPhone.StylePriority.UseFont = false;
            this.xrTableCellPhone.StylePriority.UseForeColor = false;
            this.xrTableCellPhone.StylePriority.UsePadding = false;
            this.xrTableCellPhone.StylePriority.UseTextAlignment = false;
            this.xrTableCellPhone.Weight = 2.2847959812285721;
            // 
            // xrBarCodeCustomerId
            // 
            this.xrBarCodeCustomerId.AutoModule = true;
            this.xrBarCodeCustomerId.Borders = DevExpress.XtraPrinting.BorderSide.None;
            resources.ApplyResources(this.xrBarCodeCustomerId, "xrBarCodeCustomerId");
            this.xrBarCodeCustomerId.Name = "xrBarCodeCustomerId";
            this.xrBarCodeCustomerId.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 100F);
            this.xrBarCodeCustomerId.StylePriority.UseBorders = false;
            this.xrBarCodeCustomerId.StylePriority.UseFont = false;
            this.xrBarCodeCustomerId.StylePriority.UsePadding = false;
            this.xrBarCodeCustomerId.StylePriority.UseTextAlignment = false;
            this.xrBarCodeCustomerId.Symbology = code128Generator1;
            this.xrBarCodeCustomerId.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.xrBarCodeCustomer_BeforePrint);
            // 
            // topMarginBand
            // 
            resources.ApplyResources(this.topMarginBand, "topMarginBand");
            this.topMarginBand.Name = "topMarginBand";
            // 
            // bottomMarginBand
            // 
            this.bottomMarginBand.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPageInfoPageCount});
            resources.ApplyResources(this.bottomMarginBand, "bottomMarginBand");
            this.bottomMarginBand.Name = "bottomMarginBand";
            // 
            // xrPageInfoPageCount
            // 
            resources.ApplyResources(this.xrPageInfoPageCount, "xrPageInfoPageCount");
            this.xrPageInfoPageCount.Name = "xrPageInfoPageCount";
            this.xrPageInfoPageCount.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrPageInfoPageCount.StylePriority.UseFont = false;
            this.xrPageInfoPageCount.StylePriority.UseTextAlignment = false;
            // 
            // xpCollectionCustomers
            // 
            this.xpCollectionCustomers.ObjectType = typeof(NukaCollect.Customer);
            this.xpCollectionCustomers.Sorting.AddRange(new DevExpress.Xpo.SortProperty[] {
            new DevExpress.Xpo.SortProperty("[FullNameLastSorting]", DevExpress.Xpo.DB.SortingDirection.Ascending)});
            this.xpCollectionCustomers.ResolveSession += new DevExpress.Xpo.ResolveSessionEventHandler(this.xpCollectionCustomers_ResolveSession);
            // 
            // CustomerInfoCardReport
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.topMarginBand,
            this.bottomMarginBand});
            this.DataSource = this.xpCollectionCustomers;
            this.Margins = new System.Drawing.Printing.Margins(51, 50, 22, 35);
            this.Version = "12.1";
            ((System.ComponentModel.ISupportInitialize)(this.xrTableCustomerInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollectionCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand topMarginBand;
        private DevExpress.XtraReports.UI.BottomMarginBand bottomMarginBand;
        private DevExpress.XtraReports.UI.XRPanel xrPanelCustomerInfoCard;
        private DevExpress.XtraReports.UI.XRPictureBox xrPictBoxPhoto;
        private DevExpress.XtraReports.UI.XRTable xrTableCustomerInfo;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRowBirthdayInfo;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCellBirthdayLabel;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCellBirthday;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRowAddressInfo;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCellAddressLabel;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRowPhoneInfo;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCellPhoneLabel;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCellPhone;
        private DevExpress.XtraReports.UI.XRBarCode xrBarCodeCustomerId;
        private DevExpress.Xpo.XPCollection xpCollectionCustomers;
        private DevExpress.XtraReports.UI.XRPageInfo xrPageInfoPageCount;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCellAddress;
        private DevExpress.XtraReports.UI.XRLabel xrLabelDiscountLevel;
        private DevExpress.XtraReports.UI.XRLabel xrLabelFullName;
    }
}
