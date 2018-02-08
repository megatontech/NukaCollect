using NukaCollect.Resources;
using System;
using System.Reflection;

namespace NukaCollect.Win
{
    public class ElementConstStringLoader
    {
        public static void LoadConstStringsForCustomerRevenueStatistics(object element)
        {
            SetPropertyPathValue(element, "fieldCustomer.Caption", ConstStrings.Get("Customer"));
            SetPropertyPathValue(element, "fieldRevenue.Caption", ConstStrings.Get("Revenue"));
            SetPropertyPathValue(element, "fieldMonth.Caption", ConstStrings.Get("Month"));
        }

        public static void LoadConstStringsForTopCustomersStatistics(object element)
        {
            SetPropertyPathValue(element, "fieldCustomer.Caption", ConstStrings.Get("Customer"));
            SetPropertyPathValue(element, "fieldRevenue.Caption", ConstStrings.Get("Income"));
            SetPropertyPathValue(element, "layoutControlItem3.Text", ConstStrings.Get("Period") + ":");
            SetPropertyPathValue(element, "layoutControlItem4.Text", ConstStrings.Get("CustomerCount") + ":");
        }

        public static void LoadConstStringsForRevenueSplitStatistics(object element)
        {
            SetPropertyPathValue(element, "fieldMonth.Caption", ConstStrings.Get("Month"));
            SetPropertyPathValue(element, "fieldRevenue.Caption", ConstStrings.Get("Revenue"));
            SetPropertyPathValue(element, "fieldReceiptType.Caption", ConstStrings.Get("ReceiptType"));
        }

        public static void LoadConstStringsForNetIncomeStatistics(object element)
        {
            SetPropertyPathValue(element, "fieldMonth.Caption", ConstStrings.Get("Month"));
            SetPropertyPathValue(element, "fieldPeriod.Caption", ConstStrings.Get("Period"));
        }

        public static void LoadConstStringsForCustomerByDatesKPI(object element)
        {
            SetPropertyPathValue(element, "fieldPayment.Caption", ConstStrings.Get("Payment"));
            SetPropertyPathValue(element, "fieldCustomer.Caption", ConstStrings.Get("Customer"));
            SetPropertyPathValue(element, "Year.Caption", ConstStrings.Get("Year"));
            SetPropertyPathValue(element, "Quarter.Caption", ConstStrings.Get("Quarter"));
            SetPropertyPathValue(element, "layoutControlItem1.Text", ConstStrings.Get("SortBy"));
        }

        public static void LoadConstStringsForCustomerKPI(object element)
        {
            SetPropertyPathValue(element, "fieldPayment.Caption", ConstStrings.Get("Payment"));
            SetPropertyPathValue(element, "fieldCustomer.Caption", ConstStrings.Get("Customer"));
            SetPropertyPathValue(element, "Year.Caption", ConstStrings.Get("Year"));
            SetPropertyPathValue(element, "Quarter.Caption", ConstStrings.Get("Quarter"));
        }

        public static void LoadConstStringsForMoviesKPI(object element)
        {
            SetPropertyPathValue(element, "fieldPayment.Caption", ConstStrings.Get("Payment"));
            SetPropertyPathValue(element, "fieldMovie.Caption", ConstStrings.Get("Movie"));
            SetPropertyPathValue(element, "Year.Caption", ConstStrings.Get("Year"));
            SetPropertyPathValue(element, "Quarter.Caption", ConstStrings.Get("Quarter"));
        }

        public static void LoadConstStringsForFrmAddBase(object element)
        {
            SetPropertyPathValue(element, "sbSave.Text", ConstStrings.Get("ButtonTextAdd"));
            SetPropertyPathValue(element, "sbCancel.Text", ConstStrings.Get("ButtonTextCancel"));
        }

        public static void LoadConstStringsForFrmDetailBase(object element)
        {
            SetPropertyPathValue(element, "sbOK.Text", ConstStrings.Get("ButtonTextOK"));
            SetPropertyPathValue(element, "sbCancel.Text", ConstStrings.Get("ButtonTextCancel"));
        }

        public static void LoadConstStringsForFrmGridOptionsBase(object element)
        {
            SetPropertyPathValue(element, "sbSave.Text", ConstStrings.Get("ButtonTextOK"));
            SetPropertyPathValue(element, "sbCancel.Text", ConstStrings.Get("ButtonTextCancel"));
        }

        public static void LoadConstStringsForFrmMainBase(object element)
        {
            SetPropertyPathValue(element, "bbiAbout.Caption", ConstStrings.Get("About"));
            SetPropertyPathValue(element, "bbiAbout.Hint", ConstStrings.Get("AboutThisDemo"));
        }

        public static void LoadConstStringsForAbout(object element)
        {
            SetPropertyPathValue(element, "lcAbout1.Text", ConstStrings.Get("WelcomeText1"));
            SetPropertyPathValue(element, "lcAbout2.Text", ConstStrings.Get("WelcomeText2"));
            SetPropertyPathValue(element, "lcLink1.Text", ConstStrings.Get("WelcomeLink1"));
            SetPropertyPathValue(element, "lcLink1.LinkText", AssemblyInfo.DXLinkGetStarted);
            SetPropertyPathValue(element, "lcLink2.Text", ConstStrings.Get("WelcomeLink2"));
            SetPropertyPathValue(element, "lcLink2.LinkText", AssemblyInfo.DXLinkTrial);
            SetPropertyPathValue(element, "lcLink3.Text", ConstStrings.Get("WelcomeLink3"));
            SetPropertyPathValue(element, "lcLink3.LinkText", AssemblyInfo.DXLinkBuyNow);
            SetPropertyPathValue(element, "lcControlsText.Text", ConstStrings.Get("WelcomeText3"));
            SetPropertyPathValue(element, "lcHint.Text", ConstStrings.Get("WelcomeText4"));
        }

        public static void LoadConstStringsForArtists(object element)
        {
            SetPropertyPathValue(element, "cardView1.CardCaptionFormat", ConstStrings.Get("PhotoNumber"));
            SetPropertyPathValue(element, "colPicture.Caption", ConstStrings.Get("Image"));
            SetPropertyPathValue(element, "colGender.Caption", ConstStrings.Get("Gender"));
            SetPropertyPathValue(element, "colBirthCountry.Caption", ConstStrings.Get("BirthCountry"));
            SetPropertyPathValue(element, "colBirthLocation.Caption", ConstStrings.Get("BirthLocation"));
            SetPropertyPathValue(element, "colFirstName.Caption", ConstStrings.Get("FirstName"));
            SetPropertyPathValue(element, "colLastName.Caption", ConstStrings.Get("LastName"));
            SetPropertyPathValue(element, "colBirthName.Caption", ConstStrings.Get("BirthName"));
            SetPropertyPathValue(element, "colBirthDate.Caption", ConstStrings.Get("BirthDate"));
            SetPropertyPathValue(element, "colBiography.Caption", ConstStrings.Get("Biography"));
            SetPropertyPathValue(element, "colNickName.Caption", ConstStrings.Get("NickName"));
            SetPropertyPathValue(element, "colLink.Caption", ConstStrings.Get("Link"));
        }

        public static void LoadConstStringsForCategories(object element)
        {
            SetPropertyPathValue(element, "colName.Caption", ConstStrings.Get("Name"));
            SetPropertyPathValue(element, "colIsDefault.Caption", ConstStrings.Get("Default"));
        }

        public static void LoadConstStringsForCompanies(object element)
        {
            SetPropertyPathValue(element, "layoutView1.CardCaptionFormat", ConstStrings.Get("MovieOf"));
            SetPropertyPathValue(element, "colDescription.Caption", ConstStrings.Get("Description"));
            SetPropertyPathValue(element, "colName.Caption", ConstStrings.Get("Name"));
            SetPropertyPathValue(element, "colType.Caption", ConstStrings.Get("Type"));
            SetPropertyPathValue(element, "colWebSite.Caption", ConstStrings.Get("WebSite"));
            SetPropertyPathValue(element, "colCountry.Caption", ConstStrings.Get("Country"));
            SetPropertyPathValue(element, "colFlag.Caption", ConstStrings.Get("Flag"));
        }

        public static void LoadConstStringsForCustomers(object element)
        {
            SetPropertyPathValue(element, "colPhoto.Caption", ConstStrings.Get("Photo"));
            SetPropertyPathValue(element, "colCustomerId.Caption", ConstStrings.Get("CardNumber"));
            SetPropertyPathValue(element, "colName1.Caption", ConstStrings.Get("Name"));
            SetPropertyPathValue(element, "colBirthDate.Caption", ConstStrings.Get("BirthDate"));
            SetPropertyPathValue(element, "colPhone.Caption", ConstStrings.Get("Phone"));
            SetPropertyPathValue(element, "colEmail.Caption", ConstStrings.Get("Email"));
            SetPropertyPathValue(element, "colGender.Caption", ConstStrings.Get("Gender"));
            SetPropertyPathValue(element, "colAddress.Caption", ConstStrings.Get("Address"));
            SetPropertyPathValue(element, "colComments.Caption", ConstStrings.Get("Comments"));
            SetPropertyPathValue(element, "colLevel.Caption", ConstStrings.Get("DiscountLevel"));
            SetPropertyPathValue(element, "colDiscount.Caption", ConstStrings.Get("Discount"));
            SetPropertyPathValue(element, "colName.Caption", ConstStrings.Get("Name"));
            SetPropertyPathValue(element, "colGender2.Caption", ConstStrings.Get("Gender"));
            SetPropertyPathValue(element, "colBirthDate2.Caption", ConstStrings.Get("BirthDate"));
            SetPropertyPathValue(element, "colCardNumber.Caption", ConstStrings.Get("CardNumber"));
            SetPropertyPathValue(element, "colAddress2.Caption", ConstStrings.Get("Address"));
            SetPropertyPathValue(element, "colPhone2.Caption", ConstStrings.Get("Phone"));
            SetPropertyPathValue(element, "gridColumn10.Caption", ConstStrings.Get("Comments"));
            SetPropertyPathValue(element, "colPhoto2.Caption", ConstStrings.Get("Photo"));
        }

        public static void LoadConstStringsForEmployee(object element)
        {
            SetPropertyPathValue(element, "simpleButton1.Text", ConstStrings.Get("Save"));
        }

        public static void LoadConstStringsForMovies(object element)
        {
            SetPropertyPathValue(element, "colPicturesCount.Caption", ConstStrings.Get("PicturesCount"));
            SetPropertyPathValue(element, "colPhoto.Caption", ConstStrings.Get("Photo"));
            SetPropertyPathValue(element, "colTitle.Caption", ConstStrings.Get("Title"));
            SetPropertyPathValue(element, "colReleaseDate.Caption", ConstStrings.Get("ReleaseDate"));
            SetPropertyPathValue(element, "colPlot.Caption", ConstStrings.Get("Plot"));
            SetPropertyPathValue(element, "colTagline.Caption", ConstStrings.Get("Tagline"));
            SetPropertyPathValue(element, "colAwards.Caption", ConstStrings.Get("Awards"));
            SetPropertyPathValue(element, "colGenre.Caption", ConstStrings.Get("Genre"));
            SetPropertyPathValue(element, "colWebSite.Caption", ConstStrings.Get("WebSite"));
            SetPropertyPathValue(element, "colDirectors.Caption", ConstStrings.Get("Directors"));
            SetPropertyPathValue(element, "colRunTime.Caption", ConstStrings.Get("RunTime"));
            SetPropertyPathValue(element, "colAspectRatio.Caption", ConstStrings.Get("AspectRatio"));
            SetPropertyPathValue(element, "colLanguage.Caption", ConstStrings.Get("Language"));
            SetPropertyPathValue(element, "colRating.Caption", ConstStrings.Get("Rating"));
            SetPropertyPathValue(element, "colColor.Caption", ConstStrings.Get("Color"));
            SetPropertyPathValue(element, "colInfo.Caption", ConstStrings.Get("Info"));
            SetPropertyPathValue(element, "layoutView1.CardCaptionFormat", ConstStrings.Get("MovieOf"));
            SetPropertyPathValue(element, "colTitle1.Caption", ConstStrings.Get("Title"));
            SetPropertyPathValue(element, "colReleaseDate1.Caption", ConstStrings.Get("ReleaseDate"));
            SetPropertyPathValue(element, "colPlot1.Caption", ConstStrings.Get("Plot"));
            SetPropertyPathValue(element, "dpScreens.Text", ConstStrings.Get("Screens"));
        }

        public static void LoadConstStringsForRent(object element)
        {
            SetPropertyPathValue(element, "colActive.Caption", ConstStrings.Get("Active"));
            SetPropertyPathValue(element, "colRentId.Caption", ConstStrings.Get("RentalIdHtml"));
            SetPropertyPathValue(element, "colReturnedOn.Caption", ConstStrings.Get("ReturnedOn"));
            SetPropertyPathValue(element, "colDays.Caption", ConstStrings.Get("Days"));
            SetPropertyPathValue(element, "colMovieInfo.Caption", ConstStrings.Get("Movie"));
            SetPropertyPathValue(element, "colPaymentRent.Caption", ConstStrings.Get("Payment"));
            SetPropertyPathValue(element, "colOverdueRentId.Caption", ConstStrings.Get("RentalIdHtml"));
            SetPropertyPathValue(element, "colMovieInfoOverdue.Caption", ConstStrings.Get("Movie"));
            SetPropertyPathValue(element, "colOverdue.Caption", ConstStrings.Get("DaysOverdue"));
            SetPropertyPathValue(element, "colOverduePayment.Caption", ConstStrings.Get("PaymentDueHtml"));
            SetPropertyPathValue(element, "colSaleId.Caption", ConstStrings.Get("PurchaseIdHtml"));
            SetPropertyPathValue(element, "colMovieInfoSale.Caption", ConstStrings.Get("Movie"));
            SetPropertyPathValue(element, "colPaymentSale.Caption", ConstStrings.Get("Payment"));
            SetPropertyPathValue(element, "gvReceipts.ViewCaption", ConstStrings.Get("ReceiptsPeriod"));
            SetPropertyPathValue(element, "colDate.Caption", ConstStrings.Get("Date"));
            SetPropertyPathValue(element, "colPayment.Caption", ConstStrings.Get("Payment"));
            SetPropertyPathValue(element, "colReceiptId.Caption", ConstStrings.Get("ReceiptId"));
            SetPropertyPathValue(element, "colType.Caption", ConstStrings.Get("Type"));
            SetPropertyPathValue(element, "colDiscount.Caption", ConstStrings.Get("Discount"));
            SetPropertyPathValue(element, "colOverdueActive.Caption", ConstStrings.Get("DaysOverdueHtml"));
            SetPropertyPathValue(element, "colRentIdActive.Caption", ConstStrings.Get("RentalIdHtml"));
            SetPropertyPathValue(element, "colDaysActive.Caption", ConstStrings.Get("Days"));
            SetPropertyPathValue(element, "colActiveRent.Caption", ConstStrings.Get("Active"));
            SetPropertyPathValue(element, "colRentedOn.Caption", ConstStrings.Get("RentedOn"));
            SetPropertyPathValue(element, "colPaymentActive.Caption", ConstStrings.Get("Payment"));
            SetPropertyPathValue(element, "colMovieTitleActive.Caption", ConstStrings.Get("MovieTitle"));
            SetPropertyPathValue(element, "colActiveType.Caption", ConstStrings.Get("ActiveType"));
            SetPropertyPathValue(element, "colReturn.Caption", ConstStrings.Get("Return"));
            SetPropertyPathValue(element, "colItemFormat.Caption", ConstStrings.Get("Format"));
            SetPropertyPathValue(element, "lciCustomerInfo.CustomizationFormText", ConstStrings.Get("CurrentCustomer"));
            SetPropertyPathValue(element, "lciCustomerInfo.Text", ConstStrings.Get("CurrentCustomer") + ":");
            SetPropertyPathValue(element, "lcgReceipts.CustomizationFormText", ConstStrings.Get("Receipts"));
            SetPropertyPathValue(element, "lcgReceipts.Text", ConstStrings.Get("Receipts"));
            SetPropertyPathValue(element, "lcgActiveRents.CustomizationFormText", ConstStrings.Get("ActiveRentals"));
            SetPropertyPathValue(element, "lcgActiveRents.Text", ConstStrings.Get("ActiveRentals"));
        }

        public static void LoadConstStringsForDetailBase(object element)
        {
        }

        public static void LoadConstStringsForArtistDetail(object element)
        {
            SetPropertyPathValue(element, "lcgAdditionalDetail.CustomizationFormText", ConstStrings.Get("AdditionalDetails"));
            SetPropertyPathValue(element, "lcgAdditionalDetail.Text", ConstStrings.Get("AdditionalDetails"));
            SetPropertyPathValue(element, "lcgArtist.CustomizationFormText", ConstStrings.Get("ActorsCrew"));
            SetPropertyPathValue(element, "lcgArtist.Text", ConstStrings.Get("ActorsCrew"));
            SetPropertyPathValue(element, "lcgRentalInfo.CustomizationFormText", ConstStrings.Get("RentalSalesInfo"));
            SetPropertyPathValue(element, "lcgRentalInfo.Text", ConstStrings.Get("RentalSalesInfo"));
            SetPropertyPathValue(element, "lciFirstName.CustomizationFormText", ConstStrings.Get("FirstName"));
            SetPropertyPathValue(element, "lciFirstName.Text", ConstStrings.Get("FirstName") + ":");
            SetPropertyPathValue(element, "lciLastName.CustomizationFormText", ConstStrings.Get("LastName"));
            SetPropertyPathValue(element, "lciLastName.Text", ConstStrings.Get("LastName") + ":");
            SetPropertyPathValue(element, "lciNickName.CustomizationFormText", ConstStrings.Get("NickName"));
            SetPropertyPathValue(element, "lciNickName.Text", ConstStrings.Get("NickName") + ":");
            SetPropertyPathValue(element, "lciBirthLocation.CustomizationFormText", ConstStrings.Get("BirthLocation"));
            SetPropertyPathValue(element, "lciBirthLocation.Text", ConstStrings.Get("BirthLocation") + ":");
            SetPropertyPathValue(element, "lciBirthName.CustomizationFormText", ConstStrings.Get("BirthName"));
            SetPropertyPathValue(element, "lciBirthName.Text", ConstStrings.Get("BirthName") + ":");
            SetPropertyPathValue(element, "lciLink.CustomizationFormText", ConstStrings.Get("Link"));
            SetPropertyPathValue(element, "lciLink.Text", ConstStrings.Get("Link") + ":");
            SetPropertyPathValue(element, "lciGender.CustomizationFormText", ConstStrings.Get("Gender"));
            SetPropertyPathValue(element, "lciGender.Text", ConstStrings.Get("Gender") + ":");
            SetPropertyPathValue(element, "lciBirthDate.CustomizationFormText", ConstStrings.Get("BirthDate"));
            SetPropertyPathValue(element, "lciBirthDate.Text", ConstStrings.Get("BirthDate") + ":");
            SetPropertyPathValue(element, "lciBirthCountry.CustomizationFormText", ConstStrings.Get("BirthCountry"));
            SetPropertyPathValue(element, "lciBirthCountry.Text", ConstStrings.Get("BirthCountry") + ":");
            SetPropertyPathValue(element, "lccBiography.CustomizationFormText", ConstStrings.Get("Biography"));
            SetPropertyPathValue(element, "lccBiography.Text", ConstStrings.Get("Biography"));
            SetPropertyPathValue(element, "lcgMovies.CustomizationFormText", ConstStrings.Get("Movies"));
            SetPropertyPathValue(element, "lcgMovies.Text", ConstStrings.Get("Movies"));
            SetPropertyPathValue(element, "colMovie.Caption", ConstStrings.Get("Movie"));
            SetPropertyPathValue(element, "colDescription.Caption", ConstStrings.Get("Description"));
            SetPropertyPathValue(element, "colLine.Caption", ConstStrings.Get("Line"));
        }

        public static void LoadConstStringsForCompanyDetail(object element)
        {
            SetPropertyPathValue(element, "colMovie.Caption", ConstStrings.Get("Movie"));
            SetPropertyPathValue(element, "colDescription.Caption", ConstStrings.Get("Description"));
            SetPropertyPathValue(element, "lciName.CustomizationFormText", ConstStrings.Get("Name"));
            SetPropertyPathValue(element, "lciName.Text", ConstStrings.Get("Name") + ":");
            SetPropertyPathValue(element, "lciType.CustomizationFormText", ConstStrings.Get("Type"));
            SetPropertyPathValue(element, "lciType.Text", ConstStrings.Get("Type") + ":");
            SetPropertyPathValue(element, "lciWebSite.CustomizationFormText", ConstStrings.Get("WebSite"));
            SetPropertyPathValue(element, "lciWebSite.Text", ConstStrings.Get("WebSite") + ":");
            SetPropertyPathValue(element, "lciCountry.CustomizationFormText", ConstStrings.Get("Country"));
            SetPropertyPathValue(element, "lciCountry.Text", ConstStrings.Get("Country") + ":");
            SetPropertyPathValue(element, "lciMoviesGridBar.CustomizationFormText", ConstStrings.Get("LinkedMovies"));
            SetPropertyPathValue(element, "lciMoviesGridBar.Text", ConstStrings.Get("LinkedMovies") + ":");
        }

        public static void LoadConstStringsForCustomerDetail(object element)
        {
            SetPropertyPathValue(element, "lciFirstName.CustomizationFormText", ConstStrings.Get("FirstName"));
            SetPropertyPathValue(element, "lciFirstName.Text", ConstStrings.Get("FirstName") + ":");
            SetPropertyPathValue(element, "lciMiddleName.CustomizationFormText", ConstStrings.Get("MiddleName"));
            SetPropertyPathValue(element, "lciMiddleName.Text", ConstStrings.Get("MiddleName") + ":");
            SetPropertyPathValue(element, "lciLastName.CustomizationFormText", ConstStrings.Get("LastName"));
            SetPropertyPathValue(element, "lciLastName.Text", ConstStrings.Get("LastName") + ":");
            SetPropertyPathValue(element, "lciGender.CustomizationFormText", ConstStrings.Get("Gender"));
            SetPropertyPathValue(element, "lciGender.Text", ConstStrings.Get("Gender") + ":");
            SetPropertyPathValue(element, "lciBirthDate.CustomizationFormText", ConstStrings.Get("BirthDate"));
            SetPropertyPathValue(element, "lciBirthDate.Text", ConstStrings.Get("BirthDate") + ":");
            SetPropertyPathValue(element, "lciAddress.CustomizationFormText", ConstStrings.Get("Address"));
            SetPropertyPathValue(element, "lciAddress.Text", ConstStrings.Get("Address") + ":");
            SetPropertyPathValue(element, "lciEmail.CustomizationFormText", ConstStrings.Get("Email"));
            SetPropertyPathValue(element, "lciEmail.Text", ConstStrings.Get("Email") + ":");
            SetPropertyPathValue(element, "lcgAddress.CustomizationFormText", ConstStrings.Get("Address"));
            SetPropertyPathValue(element, "lcgAddress.Text", ConstStrings.Get("Address"));
            SetPropertyPathValue(element, "lciPhone.CustomizationFormText", ConstStrings.Get("Phone"));
            SetPropertyPathValue(element, "lciPhone.Text", ConstStrings.Get("Phone") + ":");
            SetPropertyPathValue(element, "lcgDiscount.CustomizationFormText", ConstStrings.Get("Discount"));
            SetPropertyPathValue(element, "lcgDiscount.Text", ConstStrings.Get("Discount"));
            SetPropertyPathValue(element, "lciLevel.CustomizationFormText", ConstStrings.Get("Level"));
            SetPropertyPathValue(element, "lciLevel.Text", ConstStrings.Get("Level") + ":");
            SetPropertyPathValue(element, "lciDiscount.CustomizationFormText", ConstStrings.Get("Discount"));
            SetPropertyPathValue(element, "lciDiscount.Text", ConstStrings.Get("Discount") + ":");
            SetPropertyPathValue(element, "lciComments.CustomizationFormText", ConstStrings.Get("Comments"));
            SetPropertyPathValue(element, "lciComments.Text", ConstStrings.Get("Comments") + ":");
        }

        public static void LoadConstStringsForMovieDetail(object element)
        {
            SetPropertyPathValue(element, "ceIsColor.Properties.Caption", ConstStrings.Get("Color"));
            SetPropertyPathValue(element, "lciTitle.CustomizationFormText", ConstStrings.Get("Title"));
            SetPropertyPathValue(element, "lciTitle.Text", ConstStrings.Get("Title") + ":");
            SetPropertyPathValue(element, "lcgGeneralInfo.CustomizationFormText", ConstStrings.Get("GeneralInfo"));
            SetPropertyPathValue(element, "lcgGeneralInfo.Text", ConstStrings.Get("GeneralInfo"));
            SetPropertyPathValue(element, "lciPlot.CustomizationFormText", ConstStrings.Get("Plot"));
            SetPropertyPathValue(element, "lciPlot.Text", ConstStrings.Get("Plot") + ":");
            SetPropertyPathValue(element, "lciAwards.CustomizationFormText", ConstStrings.Get("Awards"));
            SetPropertyPathValue(element, "lciAwards.Text", ConstStrings.Get("Awards") + ":");
            SetPropertyPathValue(element, "lciTagline.CustomizationFormText", ConstStrings.Get("Tagline"));
            SetPropertyPathValue(element, "lciTagline.Text", ConstStrings.Get("Tagline") + ":");
            SetPropertyPathValue(element, "lciGenre.CustomizationFormText", ConstStrings.Get("Genre"));
            SetPropertyPathValue(element, "lciGenre.Text", ConstStrings.Get("Genre") + ":");
            SetPropertyPathValue(element, "lciRealeaseDate.CustomizationFormText", ConstStrings.Get("RealeaseDate"));
            SetPropertyPathValue(element, "lciRealeaseDate.Text", ConstStrings.Get("RealeaseDate") + ":");
            SetPropertyPathValue(element, "lciRating.CustomizationFormText", ConstStrings.Get("Rating"));
            SetPropertyPathValue(element, "lciRating.Text", ConstStrings.Get("Rating") + ":");
            SetPropertyPathValue(element, "lcgAdditionalDetail.CustomizationFormText", ConstStrings.Get("AdditionalDetails"));
            SetPropertyPathValue(element, "lcgAdditionalDetail.Text", ConstStrings.Get("AdditionalDetails"));
            SetPropertyPathValue(element, "lciWebSite.CustomizationFormText", ConstStrings.Get("WebSite"));
            SetPropertyPathValue(element, "lciWebSite.Text", ConstStrings.Get("WebSite") + ":");
            SetPropertyPathValue(element, "lciAspectRatio.CustomizationFormText", ConstStrings.Get("AspectRatio"));
            SetPropertyPathValue(element, "lciAspectRatio.Text", ConstStrings.Get("AspectRatio") + ":");
            SetPropertyPathValue(element, "lciRunTime.CustomizationFormText", ConstStrings.Get("RunTime"));
            SetPropertyPathValue(element, "lciRunTime.Text", ConstStrings.Get("RunTime") + ":");
            SetPropertyPathValue(element, "lciCountries.CustomizationFormText", ConstStrings.Get("Countries"));
            SetPropertyPathValue(element, "lciCountries.Text", ConstStrings.Get("Countries") + ":");
            SetPropertyPathValue(element, "lciLanguage.CustomizationFormText", ConstStrings.Get("Language"));
            SetPropertyPathValue(element, "lciLanguage.Text", ConstStrings.Get("Language") + ":");
            SetPropertyPathValue(element, "lcgCompanies.CustomizationFormText", ConstStrings.Get("Companies"));
            SetPropertyPathValue(element, "lcgCompanies.Text", ConstStrings.Get("Companies"));
            SetPropertyPathValue(element, "colCompany.Caption", ConstStrings.Get("Company"));
            SetPropertyPathValue(element, "colCompanyDescription.Caption", ConstStrings.Get("Description"));
            SetPropertyPathValue(element, "lcgArtist.CustomizationFormText", ConstStrings.Get("ActorsCrew"));
            SetPropertyPathValue(element, "lcgArtist.Text", ConstStrings.Get("ActorsCrew"));
            SetPropertyPathValue(element, "lciDirector.CustomizationFormText", ConstStrings.Get("Directors"));
            SetPropertyPathValue(element, "lciDirector.Text", ConstStrings.Get("Directors") + ":");
            SetPropertyPathValue(element, "lcgArtists.CustomizationFormText", ConstStrings.Get("ActorsCrew"));
            SetPropertyPathValue(element, "lcgArtists.Text", ConstStrings.Get("ActorsCrew"));
            SetPropertyPathValue(element, "colArtist.Caption", ConstStrings.Get("Name"));
            SetPropertyPathValue(element, "colDescription.FieldName", ConstStrings.Get("Description"));
            SetPropertyPathValue(element, "colLine.Caption", ConstStrings.Get("Line"));
            SetPropertyPathValue(element, "lcgRentalInfo.CustomizationFormText", ConstStrings.Get("RentalSalesInfo"));
            SetPropertyPathValue(element, "lcgRentalInfo.Text", ConstStrings.Get("RentalSalesInfo"));
            SetPropertyPathValue(element, "lciCategory.CustomizationFormText", ConstStrings.Get("RentalCategory"));
            SetPropertyPathValue(element, "lciCategory.Text", ConstStrings.Get("RentalCategory") + ":");
        }

        public static void LoadConstStringsForFrmMovieAddCompany(object element)
        {
            SetPropertyPathValue(element, "lciCompany.CustomizationFormText", ConstStrings.Get("Company"));
            SetPropertyPathValue(element, "lciCompany.Text", ConstStrings.Get("Company") + ":");
            SetPropertyPathValue(element, "lciDescription.CustomizationFormText", ConstStrings.Get("Description"));
            SetPropertyPathValue(element, "lciDescription.Text", ConstStrings.Get("Description") + ":");
        }

        public static void LoadConstStringsForFrmMovieAddItems(object element)
        {
            SetPropertyPathValue(element, "lciFormat.CustomizationFormText", ConstStrings.Get("Format"));
            SetPropertyPathValue(element, "lciFormat.Text", ConstStrings.Get("Format") + ":");
            SetPropertyPathValue(element, "lciCount.CustomizationFormText", ConstStrings.Get("Count"));
            SetPropertyPathValue(element, "lciCount.Text", ConstStrings.Get("Count") + ":");
            SetPropertyPathValue(element, "lciSellPrice.CustomizationFormText", ConstStrings.Get("Price"));
            SetPropertyPathValue(element, "lciSellPrice.Text", ConstStrings.Get("Price") + ":");
            SetPropertyPathValue(element, "ceAvailableForSell.Properties.Caption", ConstStrings.Get("AvailableForSaleHtml"));
            SetPropertyPathValue(element, "Text", ConstStrings.Get("AddToMovieInventory"));
        }

        public static void LoadConstStringsForFrmMovieCategoriesList(object element)
        {
            SetPropertyPathValue(element, "colName.Caption", ConstStrings.Get("Name"));
            SetPropertyPathValue(element, "colIsDefault.Caption", ConstStrings.Get("Default"));
            SetPropertyPathValue(element, "sbSave.Text", ConstStrings.Get("ButtonTextSaveAndClose"));
            SetPropertyPathValue(element, "sbCancel.Text", ConstStrings.Get("ButtonTextClose"));
            SetPropertyPathValue(element, "barEditCategories.Text", ConstStrings.Get("EditCategories"));
            SetPropertyPathValue(element, "bbiAdd.Caption", ConstStrings.Get("Add"));
            SetPropertyPathValue(element, "bbiAdd.Hint", ConstStrings.Get("AddNewCategory"));
            SetPropertyPathValue(element, "bbiDelete.Caption", ConstStrings.Get("Delete"));
            SetPropertyPathValue(element, "bbiDelete.Hint", ConstStrings.Get("DeleteCurrentCategory"));
            SetPropertyPathValue(element, "Text", ConstStrings.Get("MovieCategories"));
        }

        public static void LoadConstStringsForFrmMovieItems(object element)
        {
            SetPropertyPathValue(element, "colStatus.Caption", ConstStrings.Get("Status"));
            SetPropertyPathValue(element, "colFormat.Caption", ConstStrings.Get("Format"));
            SetPropertyPathValue(element, "colSellingPrice.Caption", ConstStrings.Get("SellingPrice"));
            SetPropertyPathValue(element, "colAvailableForSell.Caption", ConstStrings.Get("AvailableForSell"));
            SetPropertyPathValue(element, "colLocation.Caption", ConstStrings.Get("Location"));
            SetPropertyPathValue(element, "bbiAdd.Caption", ConstStrings.Get("AddItems"));
            SetPropertyPathValue(element, "bbiAdd.Hint", ConstStrings.Get("AddMovieItems"));
            SetPropertyPathValue(element, "bbiDelete.Caption", ConstStrings.Get("Delete"));
            SetPropertyPathValue(element, "bbiDelete.Hint", ConstStrings.Get("DeleteSelectedItems"));
            SetPropertyPathValue(element, "sbClose.Text", ConstStrings.Get("ButtonTextClose"));
            SetPropertyPathValue(element, "Text", ConstStrings.Get("MovieItems"));
        }

        public static void LoadConstStringsForFrmNewMovieCategory(object element)
        {
            SetPropertyPathValue(element, "sbOk.Text", ConstStrings.Get("ButtonTextSaveAndClose"));
            SetPropertyPathValue(element, "sbCancel.Text", ConstStrings.Get("ButtonTextClose"));
            SetPropertyPathValue(element, "Text", ConstStrings.Get("NewMovieCategory"));
        }

        public static void LoadConstStringsForFrmOpenImageDialog(object element)
        {
            SetPropertyPathValue(element, "colName.Caption", ConstStrings.Get("Name"));
            SetPropertyPathValue(element, "colPath.Caption", ConstStrings.Get("Path"));
            SetPropertyPathValue(element, "sbOk.Text", ConstStrings.Get("OK"));
            SetPropertyPathValue(element, "sbCancel.Text", ConstStrings.Get("Cancel"));
            SetPropertyPathValue(element, "Text", ConstStrings.Get("OpenImage"));
        }

        public static void LoadConstStringsForFrmPeriod(object element)
        {
            SetPropertyPathValue(element, "sbCancel.Text", ConstStrings.Get("ButtonTextCancel"));
            SetPropertyPathValue(element, "sbOK.Text", ConstStrings.Get("ButtonTextOK"));
            SetPropertyPathValue(element, "lcgKPI.CustomizationFormText", ConstStrings.Get("KPIPeriod"));
            SetPropertyPathValue(element, "lcgKPI.Text", ConstStrings.Get("KPIPeriod"));
            SetPropertyPathValue(element, "lcgReceipt.CustomizationFormText", ConstStrings.Get("ReceiptPeriod"));
            SetPropertyPathValue(element, "lcgReceipt.Text", ConstStrings.Get("ReceiptPeriod"));
            SetPropertyPathValue(element, "Text", ConstStrings.Get("SpecifyDateIntervals") + " ");
        }

        public static void LoadConstStringsForFrmProgress(object element)
        {
            SetPropertyPathValue(element, "labelControl1.Text", ConstStrings.Get("ChangingLookAndFeelHtml") + ":");
        }

        public static void LoadConstStringsForFrmReceiptGridOptions(object element)
        {
            SetPropertyPathValue(element, "ceGroupRowFooter.Properties.Caption", ConstStrings.Get("ShowGroupRowFooter"));
            SetPropertyPathValue(element, "ceIndicator.Properties.Caption", ConstStrings.Get("ShowIndicator"));
            SetPropertyPathValue(element, "ceDetailTabs.Properties.Caption", ConstStrings.Get("ShowDetailTabs"));
            SetPropertyPathValue(element, "ceVertLines.Properties.Caption", ConstStrings.Get("ShowVerticalLines"));
            SetPropertyPathValue(element, "ceAutoFilterRow.Properties.Caption", ConstStrings.Get("ShowTheAutoFilterRow"));
            SetPropertyPathValue(element, "ceViewCaption.Properties.Caption", ConstStrings.Get("ShowViewCaption"));
        }

        public static void LoadConstStringsForUCScreens(object element)
        {
            SetPropertyPathValue(element, "brMain.Text", ConstStrings.Get("MainMenu"));
            SetPropertyPathValue(element, "bbiAdd.Caption", ConstStrings.Get("Add"));
            SetPropertyPathValue(element, "bbiAdd.Hint", ConstStrings.Get("AddNewImage"));
            SetPropertyPathValue(element, "bbiDelete.Caption", ConstStrings.Get("Delete"));
            SetPropertyPathValue(element, "bbiDelete.Hint", ConstStrings.Get("DeleteCurrentImage"));
        }

        public static void LoadConstStringsForFrmAbout(object element)
        {
        }

        public static void LoadConstStringsForFrmArtistAddMovie(object element)
        {
            SetPropertyPathValue(element, "lciArtist.CustomizationFormText", ConstStrings.Get("Movie"));
            SetPropertyPathValue(element, "lciArtist.Text", ConstStrings.Get("Movie") + ":");
            SetPropertyPathValue(element, "lciLine.Text", ConstStrings.Get("Credits") + ":");
            SetPropertyPathValue(element, "lciDescription.CustomizationFormText", ConstStrings.Get("Description"));
            SetPropertyPathValue(element, "lciDescription.Text", ConstStrings.Get("Description") + ":");
        }

        public static void LoadConstStringsForFrmArtistDetail(object element)
        {
        }

        public static void LoadConstStringsForFrmArtistGridOptions(object element)
        {
            SetPropertyPathValue(element, "cePreview.Properties.Caption", ConstStrings.Get("ShowRowPreviews"));
            SetPropertyPathValue(element, "ceEditing.Properties.Caption", ConstStrings.Get("AllowDataEditingViaListViews"));
            SetPropertyPathValue(element, "ceAutoZoomDetail.Properties.Caption", ConstStrings.Get("AutoZoomDetails"));
            SetPropertyPathValue(element, "ceVertLines.Properties.Caption", ConstStrings.Get("ShowVerticalLines"));
            SetPropertyPathValue(element, "ceAutoFilterRow.Properties.Caption", ConstStrings.Get("ShowTheAutoFilterRow"));
            SetPropertyPathValue(element, "ceMasterDetail.Properties.Caption", ConstStrings.Get("EnableMasterViewMode"));
        }

        public static void LoadConstStringsForFrmCompanyAddMovie(object element)
        {
            SetPropertyPathValue(element, "lciMovie.CustomizationFormText", ConstStrings.Get("Movie"));
            SetPropertyPathValue(element, "lciMovie.Text", ConstStrings.Get("Movie") + ":");
            SetPropertyPathValue(element, "lciDescription.CustomizationFormText", ConstStrings.Get("Description"));
            SetPropertyPathValue(element, "lciDescription.Text", ConstStrings.Get("Description") + ":");
        }

        public static void LoadConstStringsForFrmCreateInitialDB(object element)
        {
            SetPropertyPathValue(element, "sbCreate.Text", ConstStrings.Get("Create"));
            SetPropertyPathValue(element, "ceGenerateRentsHistory.Properties.Caption", ConstStrings.Get("GenerateRentsHistory"));
            SetPropertyPathValue(element, "lciRentsHistory.CustomizationFormText", ConstStrings.Get("GeneratingData"));
            SetPropertyPathValue(element, "lciRentsHistory.Text", ConstStrings.Get("GeneratingData") + ":");
            SetPropertyPathValue(element, "lciType.CustomizationFormText", ConstStrings.Get("DatabaseType"));
            SetPropertyPathValue(element, "lciType.Text", ConstStrings.Get("DatabaseType") + ":");
            SetPropertyPathValue(element, "lciCreatingDB.CustomizationFormText", ConstStrings.Get("CreatingDatabase"));
            SetPropertyPathValue(element, "lciCreatingDB.Text", ConstStrings.Get("CreatingDatabase") + ":");
            SetPropertyPathValue(element, "lciDatabase.CustomizationFormText", ConstStrings.Get("Database"));
            SetPropertyPathValue(element, "lciDatabase.Text", ConstStrings.Get("Database") + ":");
            SetPropertyPathValue(element, "lciServer.CustomizationFormText", ConstStrings.Get("SQLServer"));
            SetPropertyPathValue(element, "lciServer.Text", ConstStrings.Get("SQLServer") + ":");
            SetPropertyPathValue(element, "lciDatabaseSQL.CustomizationFormText", ConstStrings.Get("Database"));
            SetPropertyPathValue(element, "lciDatabaseSQL.Text", ConstStrings.Get("Database") + ":");
            SetPropertyPathValue(element, "lciLogin.CustomizationFormText", ConstStrings.Get("Login"));
            SetPropertyPathValue(element, "lciLogin.Text", ConstStrings.Get("Login") + ":");
            SetPropertyPathValue(element, "lciPassword.CustomizationFormText", ConstStrings.Get("Password"));
            SetPropertyPathValue(element, "lciPassword.Text", ConstStrings.Get("Password") + ":");
            SetPropertyPathValue(element, "Text", ConstStrings.Get("CreateDatabase"));
        }

        public static void LoadConstStringsForFrmEditAppointment(object element)
        {
            SetPropertyPathValue(element, "btnClose.Text", ConstStrings.Get("ButtonTextClose"));
            SetPropertyPathValue(element, "chkActiveRental.Properties.AccessibleName", ConstStrings.Get("AllDayEvent"));
            SetPropertyPathValue(element, "chkActiveRental.Properties.Caption", ConstStrings.Get("ActiveRental"));
            SetPropertyPathValue(element, "edtResource.Properties.AccessibleName", ConstStrings.Get("Owner") + ":");
            SetPropertyPathValue(element, "chkRentOverdue.Properties.AccessibleName", ConstStrings.Get("AllDayEvent"));
            SetPropertyPathValue(element, "chkRentOverdue.Properties.Caption", ConstStrings.Get("RentOverdue"));
            SetPropertyPathValue(element, "lciMovieTitle.CustomizationFormText", ConstStrings.Get("MovieTitle"));
            SetPropertyPathValue(element, "lciMovieTitle.Text", ConstStrings.Get("MovieTitle") + ":");
            SetPropertyPathValue(element, "lciFormat.CustomizationFormText", ConstStrings.Get("Format"));
            SetPropertyPathValue(element, "lciFormat.Text", ConstStrings.Get("Format") + ":");
            SetPropertyPathValue(element, "lciDescription.CustomizationFormText", ConstStrings.Get("Description"));
            SetPropertyPathValue(element, "lciDescription.Text", ConstStrings.Get("Description") + ":");
            SetPropertyPathValue(element, "lciRentedOn.CustomizationFormText", ConstStrings.Get("RentedOn"));
            SetPropertyPathValue(element, "lciRentedOn.Text", ConstStrings.Get("RentedOn") + ":");
            SetPropertyPathValue(element, "lciReturnedOn.CustomizationFormText", ConstStrings.Get("ReturnedOn"));
            SetPropertyPathValue(element, "lciReturnedOn.Text", ConstStrings.Get("ReturnedOn") + ":");
            SetPropertyPathValue(element, "lciPayment.CustomizationFormText", ConstStrings.Get("Payment"));
            SetPropertyPathValue(element, "lciPayment.Text", ConstStrings.Get("Payment") + ":");
            SetPropertyPathValue(element, "lciOverduePayment.CustomizationFormText", ConstStrings.Get("OverduePayment"));
            SetPropertyPathValue(element, "lciOverduePayment.Text", ConstStrings.Get("OverduePayment") + ":");
            SetPropertyPathValue(element, "lciCustomer.CustomizationFormText", ConstStrings.Get("Customer"));
            SetPropertyPathValue(element, "lciCustomer.Text", ConstStrings.Get("Customer") + ":");
            SetPropertyPathValue(element, "lciLanguage.CustomizationFormText", ConstStrings.Get("Language"));
            SetPropertyPathValue(element, "lciLanguage.Text", ConstStrings.Get("Language") + ":");
            SetPropertyPathValue(element, "Text", ConstStrings.Get("RentalDetailsReadOnly"));
        }

        public static void LoadConstStringsForFrmFindCustomer(object element)
        {
            SetPropertyPathValue(element, "sbClear.Text", ConstStrings.Get("ClearCurrentCustomer"));
            SetPropertyPathValue(element, "sbOK.Text", ConstStrings.Get("ButtonTextOK"));
            SetPropertyPathValue(element, "sbClose.Text", ConstStrings.Get("ButtonTextClose"));
            SetPropertyPathValue(element, "colFirstName.Caption", ConstStrings.Get("FirstName"));
            SetPropertyPathValue(element, "colLastName.Caption", ConstStrings.Get("LastName"));
            SetPropertyPathValue(element, "colGender.Caption", ConstStrings.Get("Gender"));
            SetPropertyPathValue(element, "colBirthDate.Caption", ConstStrings.Get("BirthDate"));
            SetPropertyPathValue(element, "colFullName.Caption", ConstStrings.Get("Name"));
            SetPropertyPathValue(element, "colCustomerId.Caption", ConstStrings.Get("CardNumber"));
            SetPropertyPathValue(element, "colMiddleName.Caption", ConstStrings.Get("MiddleName"));
            SetPropertyPathValue(element, "colEmail.Caption", ConstStrings.Get("Email"));
            SetPropertyPathValue(element, "colAddress.Caption", ConstStrings.Get("Address"));
            SetPropertyPathValue(element, "colPhone.Caption", ConstStrings.Get("Phone"));
            SetPropertyPathValue(element, "colComments.Caption", ConstStrings.Get("Comments"));
            SetPropertyPathValue(element, "Text", ConstStrings.Get("FindCustomer"));
        }

        public static void LoadConstStringsForFrmLayoutOptions(object element)
        {
            SetPropertyPathValue(element, "ceAllowRestoreDockingLayout.Properties.Caption", ConstStrings.Get("SaveAndRestoreDockWindowLayouts"));
            SetPropertyPathValue(element, "ceDefaultEditGridViewInDetailForms.Properties.Caption", ConstStrings.Get("EnableDataEditingWithinTheGrid"));
            SetPropertyPathValue(element, "sbCancel.Text", ConstStrings.Get("ButtonTextCancel"));
            SetPropertyPathValue(element, "sbOK.Text", ConstStrings.Get("ButtonTextOK"));
            SetPropertyPathValue(element, "ceAllowRestoreGridViewLayout.Properties.Caption", ConstStrings.Get("SaveAndRestoreGridControlLayouts"));
            SetPropertyPathValue(element, "ceAllowRestoreLayoutControlLayout.Properties.Caption", ConstStrings.Get("SaveAndRestoreControlLayoutWithinForms"));
            SetPropertyPathValue(element, "ceAllowRestoreFormLayout.Properties.Caption", ConstStrings.Get("SaveAndRestoreDetailViewLayouts"));
            SetPropertyPathValue(element, "sbClearLayouts.Text", ConstStrings.Get("ClearLayouts"));
            SetPropertyPathValue(element, "Text", ConstStrings.Get("LayoutOptions"));
        }

        public static void LoadConstStringsForFrmMovieAddArtist(object element)
        {
            SetPropertyPathValue(element, "lciArtist.CustomizationFormText", ConstStrings.Get("ActorCrew"));
            SetPropertyPathValue(element, "lciArtist.Text", ConstStrings.Get("ActorCrew") + ":");
            SetPropertyPathValue(element, "lciLine.CustomizationFormText", ConstStrings.Get("Credits"));
            SetPropertyPathValue(element, "lciLine.Text", ConstStrings.Get("Credits") + ":");
            SetPropertyPathValue(element, "lciDescription.CustomizationFormText", ConstStrings.Get("Description"));
            SetPropertyPathValue(element, "lciDescription.Text", ConstStrings.Get("Description") + ":");
        }

        public static void LoadConstStringsForFrmMain(object element)
        {
            SetPropertyPathValue(element, "bbiDelete.Caption", ConstStrings.Get("Delete"));
            SetPropertyPathValue(element, "rcMain.ExpandCollapseItem.Hint", ConstStrings.Get("HideDisplayRibbon"));
            SetPropertyPathValue(element, "rpMovies.Text", ConstStrings.Get("Movies"));
            SetPropertyPathValue(element, "rpgMoviesManager.Text", ConstStrings.Get("MovieRecordManagement"));
            SetPropertyPathValue(element, "bbiAdd.Caption", ConstStrings.Get("Add"));
            SetPropertyPathValue(element, "bbiEdit.Caption", ConstStrings.Get("Edit"));
            SetPropertyPathValue(element, "bbiRefresh.Caption", ConstStrings.Get("Refresh"));
            SetPropertyPathValue(element, "bbiMovieCategories.Caption", ConstStrings.Get("RentalCategory"));
            SetPropertyPathValue(element, "bsiViews.Caption", ConstStrings.Get("DisplayStyle"));
            SetPropertyPathValue(element, "bsiViews.Hint", ConstStrings.Get("ChangeGridStyle"));
            SetPropertyPathValue(element, "bbiMainView.Caption", ConstStrings.Get("MainView"));
            SetPropertyPathValue(element, "bbiAlternateView.Caption", ConstStrings.Get("AlternateView"));
            SetPropertyPathValue(element, "rpgMoviesNavigation.Text", ConstStrings.Get("Navigation"));
            SetPropertyPathValue(element, "bbiPrev.Caption", ConstStrings.Get("Up"));
            SetPropertyPathValue(element, "bbiNext.Caption", ConstStrings.Get("Down"));
            SetPropertyPathValue(element, "rpgMoviesPrint.Text", ConstStrings.Get("PrintAndExport"));
            SetPropertyPathValue(element, "bbiPrintPreview.Caption", ConstStrings.Get("PrintPreview"));
            SetPropertyPathValue(element, "bbiExport.Caption", ConstStrings.Get("Export"));
            SetPropertyPathValue(element, "bbiExportToPDF.Caption", ConstStrings.Get("ExportToPDF"));
            SetPropertyPathValue(element, "bbiExportToXML.Caption", ConstStrings.Get("ExportToXML"));
            SetPropertyPathValue(element, "bbiExportToHTML.Caption", ConstStrings.Get("ExportToHTML"));
            SetPropertyPathValue(element, "bbiExportToMHT.Caption", ConstStrings.Get("ExportToMHT"));
            SetPropertyPathValue(element, "bbiExportToXLS.Caption", ConstStrings.Get("ExportToXLS"));
            SetPropertyPathValue(element, "bbiExportToXLSX.Caption", ConstStrings.Get("ExportToXLSX"));
            SetPropertyPathValue(element, "bbiExportToRTF.Caption", ConstStrings.Get("ExportToRTF"));
            SetPropertyPathValue(element, "bbiExportToImage.Caption", ConstStrings.Get("ExportToImage"));
            SetPropertyPathValue(element, "bbiExportToText.Caption", ConstStrings.Get("ExportToText"));
            SetPropertyPathValue(element, "rpgMovieDetail.Text", ConstStrings.Get("Details"));
            SetPropertyPathValue(element, "bbiCloseDetails.Caption", ConstStrings.Get("CloseDetailViews"));
            SetPropertyPathValue(element, "bbiCloseDetails.Hint", ConstStrings.Get("CloseAllOpenDetailViews"));
            SetPropertyPathValue(element, "rpRent.Text", ConstStrings.Get("Rent"));
            SetPropertyPathValue(element, "rpgRentManager.Text", ConstStrings.Get("RentalRecordManagement"));
            SetPropertyPathValue(element, "bbiRent.Caption", ConstStrings.Get("RentSell"));
            SetPropertyPathValue(element, "bbiRent.Hint", ConstStrings.Get("RentOrSellMovie"));
            SetPropertyPathValue(element, "bbiReturn.Caption", ConstStrings.Get("Return"));
            SetPropertyPathValue(element, "bbiReturn.Hint", ConstStrings.Get("ReturnSelectedMoviesCheckedItemsFromTheActiveRen"));
            SetPropertyPathValue(element, "bbiActiveRent.Caption", ConstStrings.Get("CheckActiveRentals"));
            SetPropertyPathValue(element, "bbiActiveRent.Hint", ConstStrings.Get("CheckActiveRentalsForTheCurrentCustomer"));
            SetPropertyPathValue(element, "bbiChangeCustomer.Caption", ConstStrings.Get("ChangeCustomer"));
            SetPropertyPathValue(element, "bbiChangeCustomer.Hint", ConstStrings.Get("ChangeCurrentCustomer"));
            SetPropertyPathValue(element, "bbiReceiptPeriod.Caption", ConstStrings.Get("ReceiptPeriod"));
            SetPropertyPathValue(element, "rpgRentOptions.Text", ConstStrings.Get("Options"));
            SetPropertyPathValue(element, "bbiOptions.Caption", ConstStrings.Get("ViewOptions"));
            SetPropertyPathValue(element, "rpgRentLayout.Text", ConstStrings.Get("Layout"));
            SetPropertyPathValue(element, "bbiLayoutFlip.Caption", ConstStrings.Get("FlipLayout"));
            SetPropertyPathValue(element, "bbiLayoutFlip.Hint", ConstStrings.Get("FlipDisplayLayout"));
            SetPropertyPathValue(element, "rpgRentPrint.Text", ConstStrings.Get("PrintAndExport"));
            SetPropertyPathValue(element, "rpgRentDetail.Text", ConstStrings.Get("Details"));
            SetPropertyPathValue(element, "rpActors.Text", ConstStrings.Get("Actors"));
            SetPropertyPathValue(element, "rpgActorsManager.Text", ConstStrings.Get("ActorsCrewRecordManagement"));
            SetPropertyPathValue(element, "rpgActorsNavigation.Text", ConstStrings.Get("Navigation"));
            SetPropertyPathValue(element, "rpgActorsPrint.Text", ConstStrings.Get("PrintAndExport"));
            SetPropertyPathValue(element, "rpgActorsDetail.Text", ConstStrings.Get("Details"));
            SetPropertyPathValue(element, "rpCustomers.Text", ConstStrings.Get("Customers"));
            SetPropertyPathValue(element, "rpgCustomersManager.Text", ConstStrings.Get("CustomerRecordManagement"));
            SetPropertyPathValue(element, "bbiCurrentCustomer.Caption", ConstStrings.Get("SetAsCurrentCustomer"));
            SetPropertyPathValue(element, "bbiCurrentCustomer.Hint", ConstStrings.Get("SetAsCurrentCustomer"));
            SetPropertyPathValue(element, "rpgCustomersNavigation.Text", ConstStrings.Get("Navigation"));
            SetPropertyPathValue(element, "rpgCustomersPrint.Text", ConstStrings.Get("PrintAndExport"));
            SetPropertyPathValue(element, "rpgCostomerDetail.Text", ConstStrings.Get("Details"));
            SetPropertyPathValue(element, "rpView.Text", ConstStrings.Get("View"));
            SetPropertyPathValue(element, "rpbNavigation.Text", ConstStrings.Get("Navigation"));
            SetPropertyPathValue(element, "bsiModules.Caption", ConstStrings.Get("Modules"));
            SetPropertyPathValue(element, "rpgAppearance.Text", ConstStrings.Get("Appearance"));
            SetPropertyPathValue(element, "rgbiSkins.Caption", ConstStrings.Get("Skins"));
            SetPropertyPathValue(element, "rpgViewOptions.Text", ConstStrings.Get("Options"));
            SetPropertyPathValue(element, "bbiLayoutOptions.Caption", ConstStrings.Get("LayoutOptions"));
            SetPropertyPathValue(element, "bbiPeriod.Caption", ConstStrings.Get("TimePeriods"));
            SetPropertyPathValue(element, "bbiPeriod.Hint", ConstStrings.Get("KPIReceiptsPeriods"));
            SetPropertyPathValue(element, "bciFormSkin.Caption", ConstStrings.Get("AllowFormSkins"));
            SetPropertyPathValue(element, "bbiSave.Caption", ConstStrings.Get("Save"));
            SetPropertyPathValue(element, "bbiSaveCurrentRecord.Caption", ConstStrings.Get("SaveCurrentRecord"));
            SetPropertyPathValue(element, "bbiSave.Hint", ConstStrings.Get("SaveChangesToCurrentRecord"));
            SetPropertyPathValue(element, "bbiSaveCurrentRecord.Hint", ConstStrings.Get("SaveChangesToCurrentRecord"));
            SetPropertyPathValue(element, "bbiSaveAndClose.Caption", ConstStrings.Get("SaveAndClose"));
            SetPropertyPathValue(element, "bbiSaveAndClose.Hint", ConstStrings.Get("SaveChangesToCurrentRecordAndCloseTheDetailView"));
            SetPropertyPathValue(element, "bbiClose.Caption", ConstStrings.Get("Close"));
            SetPropertyPathValue(element, "bbiClose.Hint", ConstStrings.Get("CloseDetailView"));
            SetPropertyPathValue(element, "rpMovie.Text", ConstStrings.Get("Movie"));
            SetPropertyPathValue(element, "rpgHomeMovie.Text", ConstStrings.Get("Home"));
            SetPropertyPathValue(element, "bbiHome.Caption", ConstStrings.Get("Home"));
            SetPropertyPathValue(element, "rpgMoviePicture.Text", ConstStrings.Get("MovieImage"));
            SetPropertyPathValue(element, "bbiLoadPicture.Caption", ConstStrings.Get("LoadImage"));
            SetPropertyPathValue(element, "bbiLoadPicture.Hint", ConstStrings.Get("LoadImage"));
            SetPropertyPathValue(element, "bbiClearPicture.Caption", ConstStrings.Get("ClearImage"));
            SetPropertyPathValue(element, "bbiClearPicture.Hint", ConstStrings.Get("ClearImage"));
            SetPropertyPathValue(element, "rpgMovieManager.Text", ConstStrings.Get("MovieItemsManager"));
            SetPropertyPathValue(element, "bbiAddItems.Caption", ConstStrings.Get("AddToInventory"));
            SetPropertyPathValue(element, "bbiManageItems.Caption", ConstStrings.Get("ManageInventory"));
            SetPropertyPathValue(element, "rpgMovieMain.Text", ConstStrings.Get("Main"));
            SetPropertyPathValue(element, "rpcDetail.Text", ConstStrings.Get("Details"));
            SetPropertyPathValue(element, "rpArtist.Text", ConstStrings.Get("Actor"));
            SetPropertyPathValue(element, "rpgHomeActor.Text", ConstStrings.Get("Home"));
            SetPropertyPathValue(element, "rpgArtistPhoto.Text", ConstStrings.Get("ActorPhotos"));
            SetPropertyPathValue(element, "bbiAddPicture.Caption", ConstStrings.Get("AddImage"));
            SetPropertyPathValue(element, "bbiAddPicture.Hint", ConstStrings.Get("AddANewImage"));
            SetPropertyPathValue(element, "bbiDeletePicture.Caption", ConstStrings.Get("DeleteImage"));
            SetPropertyPathValue(element, "bbiDeletePicture.Hint", ConstStrings.Get("DeleteTheCurrentImage"));
            SetPropertyPathValue(element, "rpgArtistMain.Text", ConstStrings.Get("Main"));
            SetPropertyPathValue(element, "rpCustomer.Text", ConstStrings.Get("Customer"));
            SetPropertyPathValue(element, "rpgHomeCustomer.Text", ConstStrings.Get("Home"));
            SetPropertyPathValue(element, "rpgCustomerPhoto.Text", ConstStrings.Get("CustomerPhoto"));
            SetPropertyPathValue(element, "rpgCustomerMain.Text", ConstStrings.Get("Main"));
            SetPropertyPathValue(element, "rpCompany.Text", ConstStrings.Get("Company"));
            SetPropertyPathValue(element, "rpgCompanyMain.Text", ConstStrings.Get("Main"));
            SetPropertyPathValue(element, "rpCompanies.Text", ConstStrings.Get("Companies"));
            SetPropertyPathValue(element, "rpgCompaniesManager.Text", ConstStrings.Get("CompanyRecordManagement"));
            SetPropertyPathValue(element, "rpgCompaniesNavigation.Text", ConstStrings.Get("Navigation"));
            SetPropertyPathValue(element, "rpgCompaniesPrint.Text", ConstStrings.Get("PrintAndExport"));
            SetPropertyPathValue(element, "rpgCompaniesDetail.Text", ConstStrings.Get("Details"));
            SetPropertyPathValue(element, "rpCustomerRevenueStatistics.Text", ConstStrings.Get("CustomerStatistics"));
            SetPropertyPathValue(element, "rpgCustomerStatisticLayout.Text", ConstStrings.Get("Layout"));
            SetPropertyPathValue(element, "rpgCustomerStatisticNavigation.Text", ConstStrings.Get("Navigation"));
            SetPropertyPathValue(element, "rpgCustomerStatisticChartAppearance.Text", ConstStrings.Get("ChartAppearance"));
            SetPropertyPathValue(element, "bbiChartPalette.Caption", ConstStrings.Get("Palette"));
            SetPropertyPathValue(element, "rgbiChartAppearance.Caption", ConstStrings.Get("Appearances"));
            SetPropertyPathValue(element, "rpgPrintCustomerStatistics.Text", ConstStrings.Get("PrintAndExport"));
            SetPropertyPathValue(element, "rbpCustomerRevenueDetail.Text", ConstStrings.Get("Details"));
            SetPropertyPathValue(element, "rpMediaPerformanceStatistics.Text", ConstStrings.Get("MediaStatistics"));
            SetPropertyPathValue(element, "rpgMediaPerformanceStatisticsLayout.Text", ConstStrings.Get("Layout"));
            SetPropertyPathValue(element, "bbiLayoutRotate.Caption", ConstStrings.Get("RotateLayout"));
            SetPropertyPathValue(element, "bbiLayoutRotate.Hint", ConstStrings.Get("RotateDisplayLayout"));
            SetPropertyPathValue(element, "rpgMediaStatisticChartAppearance.Text", ConstStrings.Get("ChartAppearance"));
            SetPropertyPathValue(element, "rpgPrintMediaPerformanceStatistics.Text", ConstStrings.Get("PrintAndExport"));
            SetPropertyPathValue(element, "rpgMediaPerformanceDetail.Text", ConstStrings.Get("Details"));
            SetPropertyPathValue(element, "rpTopCustomers.Text", ConstStrings.Get("TopCustomers"));
            SetPropertyPathValue(element, "rpgTopCustomersLayout.Text", ConstStrings.Get("Layout"));
            SetPropertyPathValue(element, "rpgTopCustomersChartAppearance.Text", ConstStrings.Get("ChartAppearance"));
            SetPropertyPathValue(element, "rpgPrintTopCustomers.Text", ConstStrings.Get("PrintAndExport1"));
            SetPropertyPathValue(element, "rpIncomeStatistics.Text", ConstStrings.Get("IncomeStatistics"));
            SetPropertyPathValue(element, "rpgIncomeStatisticsChartAppearance.Text", ConstStrings.Get("ChartAppearance"));
            SetPropertyPathValue(element, "rpgPrintIncomeStatistics.Text", ConstStrings.Get("PrintAndExport"));
            SetPropertyPathValue(element, "rpRevenueStatistics.Text", ConstStrings.Get("RevenueStatistics"));
            SetPropertyPathValue(element, "rpgRevenueStatisticsChartAppearance.Text", ConstStrings.Get("ChartAppearance"));
            SetPropertyPathValue(element, "rpgPrintRevenueStatistics.Text", ConstStrings.Get("PrintAndExport"));
            SetPropertyPathValue(element, "rpScheduler.Text", ConstStrings.Get("Scheduler"));
            SetPropertyPathValue(element, "rpMovieKPI.Text", ConstStrings.Get("MovieKPI"));
            SetPropertyPathValue(element, "rpgMoviesKPILayout.Text", ConstStrings.Get("Layout"));
            SetPropertyPathValue(element, "rpgMoviesKPIChartAppearance.Text", ConstStrings.Get("ChartAppearance"));
            SetPropertyPathValue(element, "rpgPrintMoviewKPI.Text", ConstStrings.Get("PrintAndExport"));
            SetPropertyPathValue(element, "rpCustomerDiscount.Text", ConstStrings.Get("CustomerDiscount"));
            SetPropertyPathValue(element, "rpgCustomerDiscountLayout.Text", ConstStrings.Get("Layout"));
            SetPropertyPathValue(element, "rpgCustomerDiscountChartAppearance.Text", ConstStrings.Get("ChartAppearance"));
            SetPropertyPathValue(element, "rpgCustomerDiscountPrint.Text", ConstStrings.Get("PrintAndExport"));
            SetPropertyPathValue(element, "rpDiscountKPI.Text", ConstStrings.Get("DiscountKPI"));
            SetPropertyPathValue(element, "rpgDiscountLayout.Text", ConstStrings.Get("Layout"));
            SetPropertyPathValue(element, "rpgDiscountChartAppearance.Text", ConstStrings.Get("ChartAppearance"));
            SetPropertyPathValue(element, "rpgDiscountPrint.Text", ConstStrings.Get("PrintAndExport"));
            SetPropertyPathValue(element, "sbExit.Text", ConstStrings.Get("ExitApplication"));
            SetPropertyPathValue(element, "bbiSkins.Caption", ConstStrings.Get("ChooseSkin"));
            SetPropertyPathValue(element, "rpgCategoriesRecordManagement.Text", ConstStrings.Get("RecordManagement"));
            SetPropertyPathValue(element, "rpgCategoriesNavigation.Text", ConstStrings.Get("LayoutAndNavigation"));
            SetPropertyPathValue(element, "rpgCategoryChartAppearance.Text", ConstStrings.Get("ChartAppearance"));
        }

        public static void LoadConstStringsForUCBarOneCheckedButton(object element)
        {
            SetPropertyPathValue(element, "mainBar.Text", ConstStrings.Get("Tools"));
            SetPropertyPathValue(element, "bciSwitch.Caption", ConstStrings.Get("Text"));
            SetPropertyPathValue(element, "biSwitch.Caption", ConstStrings.Get("OnlyActive"));
        }

        public static void LoadConstStringsForUCBarTwoButtons(object element)
        {
        }

        public static void LoadConstStringsForUCControlAbout(object element)
        {
        }

        public static void LoadConstStringsForUCCustomerInfo(object element)
        {
        }

        public static void LoadConstStringsForUCGridEditBar(object element)
        {
            SetPropertyPathValue(element, "bciAllowEditing.Caption", ConstStrings.Get("AllowEditing"));
            SetPropertyPathValue(element, "bciAllowEditing.Hint", ConstStrings.Get("AllowEditing"));
            SetPropertyPathValue(element, "bbiAdd.Caption", ConstStrings.Get("Add"));
            SetPropertyPathValue(element, "bbiAdd.Hint", ConstStrings.Get("AddNewRecord"));
            SetPropertyPathValue(element, "bbiDelete.Caption", ConstStrings.Get("Delete"));
            SetPropertyPathValue(element, "bbiDelete.Hint", ConstStrings.Get("DeleteCurrentRecord"));
        }

        public static void LoadConstStringsForUCMovieCategoryDetail(object element)
        {
            SetPropertyPathValue(element, "lciName.CustomizationFormText", ConstStrings.Get("Name"));
            SetPropertyPathValue(element, "lciName.Text", ConstStrings.Get("Name") + ":");
            SetPropertyPathValue(element, "layoutControlGroup1.Text", ConstStrings.Get("Format"));
        }

        public static void LoadConstStringsForUCMovieCategoryPriceDetail(object element)
        {
            SetPropertyPathValue(element, "lciDays1Price.CustomizationFormText", ConstStrings.Get("PricePerDayFor1DayRental"));
            SetPropertyPathValue(element, "lciDays1Price.Text", ConstStrings.Get("PricePerDayFor1DayRental") + ":");
            SetPropertyPathValue(element, "lciDays2Price.CustomizationFormText", ConstStrings.Get("PricePerDayFor2DayRental"));
            SetPropertyPathValue(element, "lciDays2Price.Text", ConstStrings.Get("PricePerDayFor2DayRental") + ":");
            SetPropertyPathValue(element, "lciDays3Price.CustomizationFormText", ConstStrings.Get("PricePerDayFor3DayRental"));
            SetPropertyPathValue(element, "lciDays3Price.Text", ConstStrings.Get("PricePerDayFor3DayRental") + ":");
            SetPropertyPathValue(element, "lciDays4Price.CustomizationFormText", ConstStrings.Get("PricePerDayFor4DayRental"));
            SetPropertyPathValue(element, "lciDays4Price.Text", ConstStrings.Get("PricePerDayFor4DayRental") + ":");
            SetPropertyPathValue(element, "lciDays5Price.CustomizationFormText", ConstStrings.Get("PricePerDayFor5DayRental"));
            SetPropertyPathValue(element, "lciDays5Price.Text", ConstStrings.Get("PricePerDayFor5DayRental") + ":");
            SetPropertyPathValue(element, "lciDays6Price.CustomizationFormText", ConstStrings.Get("PricePerDayFor6DayRental"));
            SetPropertyPathValue(element, "lciDays6Price.Text", ConstStrings.Get("PricePerDayFor6DayRental") + ":");
            SetPropertyPathValue(element, "lciDays7Price.CustomizationFormText", ConstStrings.Get("PricePerDayFor7DayRental"));
            SetPropertyPathValue(element, "lciDays7Price.Text", ConstStrings.Get("PricePerDayFor7DayRental") + ":");
            SetPropertyPathValue(element, "lciLatePrice.CustomizationFormText", ConstStrings.Get("LatePricePerDay"));
            SetPropertyPathValue(element, "lciLatePrice.Text", ConstStrings.Get("LatePricePerDay") + ":");
            SetPropertyPathValue(element, "lciDefaultDays.CustomizationFormText", ConstStrings.Get("DefaultRentalDays"));
            SetPropertyPathValue(element, "lciDefaultDays.Text", ConstStrings.Get("DefaultRentalDays") + ":");
        }

        public static void LoadConstStringsForUCMovieInfo(object element)
        {
        }

        public static void LoadConstStringsForUCMovieItemsInfo(object element)
        {
            SetPropertyPathValue(element, "tpFormat.Text", ConstStrings.Get("Format"));
            SetPropertyPathValue(element, "lciLastRentedOn.CustomizationFormText", ConstStrings.Get("LastRentedOn"));
            SetPropertyPathValue(element, "lciLastRentedOn.Text", ConstStrings.Get("LastRentedOn") + ":");
        }

        public static void LoadConstStringsForUCPeriod(object element)
        {
            SetPropertyPathValue(element, "layoutControlItem1.CustomizationFormText", ConstStrings.Get("Period"));
            SetPropertyPathValue(element, "layoutControlItem1.Text", ConstStrings.Get("Period") + ":");
            SetPropertyPathValue(element, "layoutControlItem2.CustomizationFormText", ConstStrings.Get("StartDate"));
            SetPropertyPathValue(element, "layoutControlItem2.Text", ConstStrings.Get("StartDate") + ":");
            SetPropertyPathValue(element, "layoutControlItem3.CustomizationFormText", ConstStrings.Get("EndDate"));
            SetPropertyPathValue(element, "layoutControlItem3.Text", ConstStrings.Get("EndDate") + ":");
        }

        public static void LoadConstStringsForUCPictureCollection(object element)
        {
            SetPropertyPathValue(element, "bbiPrev.Caption", ConstStrings.Get("Prev"));
            SetPropertyPathValue(element, "bbiPrev.Hint", ConstStrings.Get("PreviousPhoto"));
            SetPropertyPathValue(element, "bbiNext.Caption", ConstStrings.Get("Next"));
            SetPropertyPathValue(element, "bbiNext.Hint", ConstStrings.Get("NextPhoto"));
            SetPropertyPathValue(element, "bbiAdd.Caption", ConstStrings.Get("AddImage"));
            SetPropertyPathValue(element, "bbiAdd.Hint", ConstStrings.Get("AddNewPhoto"));
            SetPropertyPathValue(element, "bbiDelete.Caption", ConstStrings.Get("DeleteImage"));
            SetPropertyPathValue(element, "bbiDelete.Hint", ConstStrings.Get("DeleteCurrentPhoto"));
        }

        public static void LoadConstStringsForUCPictureEditBar(object element)
        {
            SetPropertyPathValue(element, "mainBar.Text", ConstStrings.Get("MainMenu"));
            SetPropertyPathValue(element, "bbiLoad.Caption", ConstStrings.Get("LoadImage"));
            SetPropertyPathValue(element, "bbiClear.Caption", ConstStrings.Get("ClearImage"));
        }

        public static void LoadConstStringsForUCRentalSalesInfo(object element)
        {
            SetPropertyPathValue(element, "lciDefaultDays.CustomizationFormText", ConstStrings.Get("DefaultRentalDays"));
            SetPropertyPathValue(element, "lciDefaultDays.Text", ConstStrings.Get("DefaultRentalDays") + ":");
            SetPropertyPathValue(element, "lciDefaultPrice.CustomizationFormText", ConstStrings.Get("DefaultLateFee"));
            SetPropertyPathValue(element, "lciDefaultPrice.Text", ConstStrings.Get("DefaultLateFee") + ":");
        }

        public static void LoadConstStringsForUCRents(object element)
        {
            SetPropertyPathValue(element, "ucGridSwitcherBar.ButtonCaption", ConstStrings.Get("OnlyActive"));
            SetPropertyPathValue(element, "colRentId.Caption", ConstStrings.Get("RentId"));
            SetPropertyPathValue(element, "colCustomer.Caption", ConstStrings.Get("Customer"));
            SetPropertyPathValue(element, "colDays.Caption", ConstStrings.Get("Days"));
            SetPropertyPathValue(element, "colRentedOn.Caption", ConstStrings.Get("RentedOn"));
            SetPropertyPathValue(element, "colReturnedOn.Caption", ConstStrings.Get("ReturnedOn"));
            SetPropertyPathValue(element, "colActive.Caption", ConstStrings.Get("Active"));
            SetPropertyPathValue(element, "lcgRents.CustomizationFormText", ConstStrings.Get("Rents"));
            SetPropertyPathValue(element, "lcgRents.Text", ConstStrings.Get("Rents"));
        }

        internal static void SetPropertyPathValue(object obj, string path, object value)
        {
            string[] pathParts = path.Split('.');
            if (pathParts.Length == 0) return;
            object target = obj;
            for (int i = 0; i < pathParts.Length - 1; ++i)
            {
                if (target == null) break;
                target = GetMemberValue(target, pathParts[i]);
            }
            if (target != null)
                SetMemberValue(target, pathParts[pathParts.Length - 1], value);
        }

        private const int fieldMaxDepth = 1;

        private static object GetMemberValue(object obj, string memberName)
        {
            Type objectType = obj.GetType();
            PropertyInfo declaredPropertyInfo = objectType.GetProperty(memberName, BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.DeclaredOnly);
            if (declaredPropertyInfo != null)
                return declaredPropertyInfo.GetValue(obj, null);
            FieldInfo fieldInfo = objectType.GetField(memberName, BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);
            if (fieldInfo != null)
                return fieldInfo.GetValue(obj);
            try
            {
                PropertyInfo propertyInfo = objectType.GetProperty(memberName, BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);
                if (propertyInfo != null)
                    return propertyInfo.GetValue(obj, null);
            }
            catch (AmbiguousMatchException) { }
            for (int i = 0; i < fieldMaxDepth; ++i)
            {
                objectType = objectType.BaseType;
                if (objectType == typeof(object)) break;
                FieldInfo f = objectType.GetField(memberName, BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.DeclaredOnly);
                if (f != null)
                    return f.GetValue(obj);
            }
            return null;
        }

        private static void SetMemberValue(object obj, string memberName, object value)
        {
            Type objectType = obj.GetType();
            PropertyInfo declaredPropertyInfo = objectType.GetProperty(memberName, BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.DeclaredOnly);
            if (declaredPropertyInfo != null)
            {
                declaredPropertyInfo.SetValue(obj, value, null);
                return;
            }
            FieldInfo fieldInfo = objectType.GetField(memberName, BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);
            if (fieldInfo != null)
            {
                fieldInfo.SetValue(obj, value);
                return;
            }
            try
            {
                PropertyInfo propertyInfo = objectType.GetProperty(memberName, BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);
                if (propertyInfo != null)
                {
                    propertyInfo.SetValue(obj, value, null);
                    return;
                }
            }
            catch (AmbiguousMatchException) { }
            for (int i = 0; i < fieldMaxDepth; ++i)
            {
                objectType = objectType.BaseType;
                if (objectType == typeof(object)) break;
                FieldInfo f = objectType.GetField(memberName, BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.DeclaredOnly);
                if (f != null)
                {
                    f.SetValue(obj, value);
                    return;
                }
            }
        }
    }
}