#if DebugTest
using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Xpo.DB;
using System.Data;
using NukaCollect.Helpers;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;

namespace NukaCollect.Win.Tests {

    [TestFixture]
    public class BaseCollectionsTests : NukaCollect.Tests.XPOObjectsBaseTests {
        protected override void CreateData(UnitOfWork session) {
        }
        [Test]
        public void MoviesCollection_AddFirstItemTest() {
            XtraForm form = new XtraForm();
            GridControl grid = new GridControl();
            grid.MainView = new GridView();
            grid.Dock = System.Windows.Forms.DockStyle.Fill;
            grid.Parent = form;
            form.Show();
            XPCollection<Movie> collection = new XPCollection<Movie>(Session);
            collection.Add(new Movie(Session, "Test Film"));
            Session.CommitChanges();
            Assert.AreEqual(collection.Count, 1);
            grid.DataSource = collection;
            form.Refresh();
        }
    }
}
#endif
