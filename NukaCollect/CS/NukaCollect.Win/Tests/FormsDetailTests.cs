#if DebugTest

using System;
using System.Windows.Forms;
using System.Drawing;
using NUnit.Framework;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraBars.Docking;
using NukaCollect.Helpers;
using NukaCollect.Win.Forms;
using NukaCollect.Win.Modules;
using DevExpress.XtraBars.Ribbon;

namespace NukaCollect.Win.Tests {
    [TestFixture]
    public class BaseFormsDetailTests : NukaCollect.Tests.XPOObjectsBaseTests {
        frmMain main;
        TutorialControl tutorial;
        RibbonControl ribbon;
        public static readonly TimeSpan MaxWaitTime = new TimeSpan(0, 0, 5);
        public override void Init() {
            base.Init();
            main = new frmMain();
            tutorial = new TutorialControl();
            tutorial.ParentFormMain = main;
            ribbon = new RibbonControl();
            ribbon.Parent = main;
        }
        protected override void FillMoviesProperties(UnitOfWork session) {
     	    base.FillMoviesProperties(session);
            Movie movie = Avatar;
            movie.Photo = ElementHelper.ImagesForTests.Images[1];
        }
        class MovieDetailData {
            string title;
            Image photo;
            DateTime? releaseDate;
            MovieRating rating;
            MovieGenre genre;
            string plot;
            string tagline;
            string awards;
            string aspectRatio;
            TimeSpan? runTime;
            string countries;
            Language language;
            string webSite;
            Image icon;
            bool isColor;
            XPCollection<MovieCompany> companies;
            XPCollection<MovieArtist> artists;
            public MovieDetailData(Movie movie) {
                title = movie.Title;
                photo = movie.Photo;
                releaseDate = movie.ReleaseDate;
                rating = movie.Rating;
                genre = movie.Genre;
                plot = movie.Plot;
                tagline = movie.Tagline;
                awards = movie.Awards;
                aspectRatio = movie.AspectRatio;
                runTime = movie.RunTime;
                countries = movie.CountriesAsString;
                language = movie.Language;
                webSite = movie.WebSite;
                isColor = movie.IsColor;
                companies = movie.Companies;
                artists = movie.Artists;
            }
            public MovieDetailData(MovieDetail form, string titleForWait) {
                DateTime beginTime = DateTime.Now;
                while(form.GetTitleEditor().Text != titleForWait && DateTime.Now - beginTime < MaxWaitTime) Application.DoEvents();
                title = form.GetTitleEditor().Text;
                photo = form.GetPhotoEditor().Image;
                releaseDate = form.GetRealiseDateEditor().DateTime;
                if(releaseDate == DateTime.MinValue) releaseDate = null;
                rating = (MovieRating)form.GetRatingEditor().EditValue;
                genre = (MovieGenre)form.GetGenreEditor().EditValue;
                plot = form.GetPlotEditor().Text;
                tagline = form.GetTaglineEditor().Text;
                awards = form.GetAwardsEditor().Text;
                aspectRatio = form.GetAspectRatioEditor().Text;
                runTime = form.GetRunTimeEditor().Time.TimeOfDay;
                if(runTime == TimeSpan.MinValue) runTime = null;
                countries = (string)form.GetCountriesEditor().EditValue;
                language = (Language)form.GetLanguageEditor().EditValue;
                webSite = form.GetWebSiteEditor().Text;
                isColor = form.GetColorEditor().Checked;
                companies = (XPCollection<MovieCompany>)form.GetCompaniesEditor().DataSource;
                artists = (XPCollection<MovieArtist>)form.GetArtistsEditor().DataSource;
            }
            public MovieDetailData(string title, Image photo, DateTime? releaseDate, MovieRating rating, MovieGenre genre,
                        string plot, string tagline, string awards, string aspectRatio, TimeSpan? runTime, string countries, Language language,
                        string webSite, Image icon, bool isColor) {
                this.title = title;
                this.photo = photo;
                this.releaseDate = releaseDate;
                this.rating = rating;
                this.genre = genre;
                this.plot = plot;
                this.tagline = tagline;
                this.awards = awards;
                this.aspectRatio = aspectRatio;
                this.runTime = runTime;
                this.countries = countries;
                this.language = language;
                this.webSite = webSite;
                this.icon = icon;
                this.isColor = isColor;
            }         
            static bool CollectionsAreEqual<T>(XPCollection<T> a, XPCollection<T> b) where T : VideoRentBaseObject {
                if(a.Count != b.Count) return false;
                foreach(T aObject in a) {
                    int agreementsCount = 0;
                    foreach(T bObject in b) {
                        if(aObject.Oid == bObject.Oid) ++agreementsCount;
                    }
                    if(agreementsCount != 1) return false;
                }
                foreach(T bObject in b) {
                    int agreementsCount = 0;
                    foreach(T aObject in a) {
                        if(aObject.Oid == bObject.Oid) ++agreementsCount;
                    }
                    if(agreementsCount != 1) return false;
                }
                return true;
            }
            public static void AssertAreEqual(MovieDetailData a, MovieDetailData b) {
                Assert.AreEqual(a.title, b.title);
                //Assert.IsTrue(ImagesComparer.AreEqual(a.photo, b.photo));
                Assert.AreEqual(a.releaseDate, b.releaseDate);
                Assert.AreEqual(a.rating, b.rating);
                Assert.AreEqual(a.genre, b.genre);
                Assert.AreEqual(a.plot, b.plot);
                Assert.AreEqual(a.tagline, b.tagline);
                Assert.AreEqual(a.awards, b.awards);
                Assert.AreEqual(a.aspectRatio, b.aspectRatio);
                Assert.AreEqual(a.runTime, b.runTime);
                Assert.AreEqual(a.countries, b.countries);
                Assert.AreEqual(a.language.Oid, b.language.Oid);
                Assert.AreEqual(a.webSite, b.webSite);
                //Assert.IsTrue(ImagesComparer.AreEqual(a.icon, b.icon));
                Assert.AreEqual(a.isColor, b.isColor);
                Assert.IsTrue(CollectionsAreEqual(a.companies, b.companies));
                Assert.IsTrue(CollectionsAreEqual(a.artists, b.artists));
            }
            public void WriteToForm(MovieDetail form) {
                form.GetTitleEditor().Text = title;
                form.GetPhotoEditor().Image = photo;
                if(releaseDate != null) form.GetRealiseDateEditor().DateTime = releaseDate.Value;
                form.GetRatingEditor().EditValue = rating;
                form.GetGenreEditor().EditValue = genre;
                form.GetPlotEditor().Text = plot;
                form.GetTaglineEditor().Text = tagline;
                form.GetAwardsEditor().Text = awards;
                form.GetAspectRatioEditor().Text = aspectRatio;
                form.GetRunTimeEditor().Time = new DateTime(runTime == null ? TimeSpan.MinValue.Ticks : runTime.Value.Ticks);
                form.GetCountriesEditor().SetEditValue(countries);
                form.GetLanguageEditor().EditValue = SessionHelper.GetObject<Language>(language, form.Session);
                form.GetWebSiteEditor().Text = webSite;
                form.GetColorEditor().Checked = isColor;
                companies = (XPCollection<MovieCompany>)form.GetCompaniesEditor().DataSource;
                artists = (XPCollection<MovieArtist>)form.GetArtistsEditor().DataSource;
            }
            public XPCollection<MovieCompany> Companies { get { return companies; } }
            public XPCollection<MovieArtist> Artists { get { return artists; } }
        }
        class ArtistDetailData {
            string firstName;
            string lastName;
            public ArtistDetailData(Artist artist) {
                firstName = artist.FirstName;
                lastName = artist.LastName;
            }
            public ArtistDetailData(ArtistDetail form, string firstNameForWait) {
                DateTime beginTime = DateTime.Now;
                while(form.GetFirstNameEditor().Text != firstNameForWait && DateTime.Now - beginTime < MaxWaitTime) Application.DoEvents();
                firstName = form.GetFirstNameEditor().Text;
                lastName = form.GetLastNameEditor().Text;
            }
            public ArtistDetailData(string firstName, string lastName) {
                this.firstName = firstName;
                this.lastName = lastName;
            }
            public static void AssertAreEqual(ArtistDetailData a, ArtistDetailData b) {
                Assert.AreEqual(a.firstName, b.firstName);
                Assert.AreEqual(a.lastName, b.lastName);
            }
            public void WriteToForm(ArtistDetail form) {
                form.GetFirstNameEditor().Text = firstName;
                form.GetLastNameEditor().Text = lastName;
            }
        }
        private void ShowDetail(DetailBase detail, string pageText) {
            RibbonPage page = new RibbonPage(pageText);
            ribbon.Pages.Add(page);
            detail.CreateActiveRibbonPage(page);
            tutorial.RibbonMenuController.CurrentControl = tutorial;
            tutorial.ActiveRibbonPage = page;
            tutorial.ActiveDetailControl = null;
            tutorial.ShowModuleDialog(detail);
            detail.SendOnLoad();
        }
        [Test]
        public void ChangeMovieInfo() {
            UnitOfWork session = new UnitOfWork(Session.DataLayer);
            Movie movie = SessionHelper.GetObject<Movie>(Avatar, session);
            MovieDetailData movieInfo = new MovieDetailData(movie);
            MovieDetailData newInfo = new MovieDetailData("Film000", ElementHelper.ImagesForTests.Images[2], new DateTime(1888, 1, 2),
                    MovieRating.NC17, MovieGenre.Action, "Avatar new Plot", "Avatar new Tagline", "new Nominated", "1 : 1", new TimeSpan(0, 15, 0), "ru, us",
                    Session.FindObject<Language>(CriteriaOperator.Parse("Name = ?", "French")), "web", ElementHelper.ImagesForTests.Images[1], false);
            using(MovieDetail form = new MovieDetail(main.FindForm(), GetSession, movie, null, null)) {
                ShowDetail(form, "1");
                MovieDetailData formInfo = new MovieDetailData(form, "Avatar");
                MovieDetailData.AssertAreEqual(movieInfo, formInfo);
                newInfo.WriteToForm(form);
                newInfo.Companies.Remove(newInfo.Companies[0]);
                newInfo.Artists.Remove(newInfo.Artists[0]);
                form.ShowCloseDialog = false;
                form.Close();
            }
            session = new UnitOfWork(session.DataLayer);
            movie = SessionHelper.GetObject<Movie>(movie, session);
            MovieDetailData newMovieInfo = new MovieDetailData(movie);
            MovieDetailData.AssertAreEqual(movieInfo, newMovieInfo);
            using(MovieDetail form = new MovieDetail(main.FindForm(), GetSession, movie, null, null)) {
                ShowDetail(form, "2");
                Assert.AreEqual("Avatar", form.GetTitleEditor().Text);
                newInfo.WriteToForm(form);
                newInfo.Companies.Remove(newInfo.Companies[0]);
                newInfo.Artists.Remove(newInfo.Artists[0]);
                form.ShowCloseDialog = false;
                form.SaveAndClose();
            }
            session = new UnitOfWork(session.DataLayer);
            movie = SessionHelper.GetObject<Movie>(movie, session);
            newMovieInfo = new MovieDetailData(movie);
            MovieDetailData.AssertAreEqual(newInfo, newMovieInfo);
        }
        [Test]
        public void Directors() {
            MovieArtist director = Avatar.Director;
            using(MovieDetail form = new MovieDetail(main.FindForm(), GetSession, Avatar, null, null)) {
                ShowDetail(form, "1");
                Assert.AreEqual("James Cameron", form.GetDirectorsEditor().Text);
                MovieArtist directorNestedSession = SessionHelper.GetObject<MovieArtist>(director, form.Session);
                directorNestedSession.Delete();
                form.CheckDirectors();
                Assert.IsEmpty(form.GetDirectorsEditor().Text);
                form.ShowCloseDialog = false;
                form.Close();
            }
        }
        [Test]
        public void ChangeArtistInfo() {
            UnitOfWork session = new UnitOfWork(Session.DataLayer);
            Artist artist = SessionHelper.GetObject<Artist>(Avatar.Director.Artist, session);
            ArtistDetailData ArtistInfo = new ArtistDetailData(artist);
            ArtistDetailData newInfo = new ArtistDetailData("Fn", "Ln");
            using(ArtistDetail form = new ArtistDetail(main.FindForm(), GetSession, artist, null, null)) {
                ShowDetail(form, "1");
                ArtistDetailData formInfo = new ArtistDetailData(form, "James");
                ArtistDetailData.AssertAreEqual(ArtistInfo, formInfo);
                newInfo.WriteToForm(form);
                form.ShowCloseDialog = false;
                form.Close();
            }
            session = new UnitOfWork(session.DataLayer);
            artist = SessionHelper.GetObject<Artist>(artist, session);
            ArtistDetailData newArtistInfo = new ArtistDetailData(artist);
            ArtistDetailData.AssertAreEqual(ArtistInfo, newArtistInfo);
            using(ArtistDetail form = new ArtistDetail(main.FindForm(), GetSession, artist, null, null)) {
                ShowDetail(form, "2");
                newInfo.WriteToForm(form);
                form.ShowCloseDialog = false;
                form.SaveAndClose();
            }
            session = new UnitOfWork(session.DataLayer);
            artist = SessionHelper.GetObject<Artist>(artist, session);
            newArtistInfo = new ArtistDetailData(artist);
            ArtistDetailData.AssertAreEqual(newInfo, newArtistInfo);
        }

    }
}
#endif
