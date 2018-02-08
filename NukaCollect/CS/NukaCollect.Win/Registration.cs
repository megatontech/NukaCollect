using System;
using NukaCollect.Reports;
using NukaCollect.Resources;

namespace NukaCollect.Win {
    [Flags]
    public enum DemoProducts { None = 0, Grid = 1, Reports = 2, Charts = 4, Pivot = 8, Scheduler = 16 }; 
    public class RegisterTutorials {
        public static void Register() {
            DemosInfo.Add(ConstStrings.Get("AboutGroup"), typeof(NukaCollect.Win.Modules.About), "", null, ConstStrings.Get("AboutGroup"));
            DemosInfo.Add(ConstStrings.Get("RentModule"), typeof(NukaCollect.Win.Modules.Rent), "", "Sale", ConstStrings.Get("RentalGroup"), DemoProducts.Grid);
            DemosInfo.Add(ConstStrings.Get("CustomersModule"), typeof(NukaCollect.Win.Modules.Customers), "", "Person", ConstStrings.Get("RentalGroup"), DemoProducts.Grid);
            DemosInfo.Add(ConstStrings.Get("MoviesModule"), typeof(NukaCollect.Win.Modules.Movies), "", "Movie", ConstStrings.Get("CatalogGroup"), DemoProducts.Grid);
            DemosInfo.Add(ConstStrings.Get("MovieCategories"), typeof(NukaCollect.Win.Modules.Categories), "", "Categories", ConstStrings.Get("CatalogGroup"), DemoProducts.None);
            DemosInfo.Add(ConstStrings.Get("ActorsModule"), typeof(NukaCollect.Win.Modules.Artists), "", "Actor", ConstStrings.Get("CatalogGroup"), DemoProducts.Grid);
            DemosInfo.Add(ConstStrings.Get("CompaniesModule"), typeof(NukaCollect.Win.Modules.Companies), "", "Company", ConstStrings.Get("CatalogGroup"), DemoProducts.Grid);
            DemosInfo.Add(ConstStrings.Get("MoviesKPIModule"), typeof(NukaCollect.Win.ModulesKPI.MoviesKPI), "", "MoviesKPI", ConstStrings.Get("KPIGroup"), DemoProducts.Pivot);
            DemosInfo.Add(ConstStrings.Get("CustomersKPIModule"), typeof(NukaCollect.Win.ModulesKPI.CustomersKPI), "", "CustomersKPI", ConstStrings.Get("KPIGroup"), DemoProducts.Pivot);
            DemosInfo.Add(ConstStrings.Get("CustomersDatesModule"), typeof(NukaCollect.Win.ModulesKPI.CustomersByDatesKPI), "", "CustomersByDate", ConstStrings.Get("KPIGroup"), DemoProducts.Pivot);
            DemosInfo.Add(ConstStrings.Get("Revenue12MonthsModule"), typeof(NukaCollect.Win.ModulesStatistics.NetIncomeStatistics), "", "Revenue", ConstStrings.Get("StatisticsGroup"));
            DemosInfo.Add(ConstStrings.Get("RevenueSplitModule"), typeof(NukaCollect.Win.ModulesStatistics.RevenueSplitStatistics), "", "RevenueSplit", ConstStrings.Get("StatisticsGroup"));
            DemosInfo.Add(ConstStrings.Get("TopCustomersModule"), typeof(NukaCollect.Win.ModulesStatistics.TopCustomersStatistics), "", "TopCustomers", ConstStrings.Get("StatisticsGroup"), DemoProducts.Charts);
            DemosInfo.Add(ConstStrings.Get("CustomerRevenueModule"), typeof(NukaCollect.Win.ModulesStatistics.CustomerRevenueStatistics), "", "CustomerRevenue", ConstStrings.Get("StatisticsGroup"), DemoProducts.Charts);
            DemosInfo.Add(ConstStrings.Get("MediaPerformanceModule"), typeof(NukaCollect.Win.ModulesStatistics.MediaPerformanceStatistics), "", "MediaPerformance", ConstStrings.Get("StatisticsGroup"), DemoProducts.Charts);
            DemosInfo.Add(ConstStrings.Get("RentScheduleModule"), typeof(NukaCollect.Win.ModulesScheduler.RentalCalendar), "", "Scheduler", ConstStrings.Get("RentalGroup"), DemoProducts.Scheduler);
            DemosInfo.Add(NukaCollect.Reports.Properties.Resources.TopFilmsReport, typeof(NukaCollect.Win.ModulesReports.TopNFilms), "", "TopFilmList", ConstStrings.Get("ReportsGroup"), DemoProducts.Reports);
            DemosInfo.Add(NukaCollect.Reports.Properties.Resources.ActiveCustomerReport, typeof(NukaCollect.Win.ModulesReports.ActiveCustomersList), "", "ActiveCustomersList", ConstStrings.Get("ReportsGroup"), DemoProducts.Reports);
            DemosInfo.Add(NukaCollect.Reports.Properties.Resources.FilmRentsReport, typeof(NukaCollect.Win.ModulesReports.CustomerFilmRentsList), "", "CustomerFilmRentsList", ConstStrings.Get("ReportsGroup"), DemoProducts.Reports);
            DemosInfo.Add(NukaCollect.Reports.Properties.Resources.GenresReport, typeof(NukaCollect.Win.ModulesReports.TheMostProfitableGenresList), "", "TheMostProfitableGenresList", ConstStrings.Get("ReportsGroup"));
            DemosInfo.Add(NukaCollect.Reports.Properties.Resources.CustomerCardsReport, typeof(NukaCollect.Win.ModulesReports.CustomerInfoCard), "", "CustomerInfoCards", ConstStrings.Get("ReportsGroup"), DemoProducts.Reports);
            DemosInfo.Add(NukaCollect.Reports.Properties.Resources.FilmCardsReport, typeof(NukaCollect.Win.ModulesReports.FilmInfoCard), "", "FilmItemInfoCards", ConstStrings.Get("ReportsGroup"));
            
            //TODO DemosInfo.Add(ConstStrings.EmployeesModule, typeof(NukaCollect.Win.Modules.Employee), "", "Employee", ConstStrings.AdminGroup);
        }
    }
}
