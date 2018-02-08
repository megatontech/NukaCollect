#if DebugTest
using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using System.IO;
using NukaCollect.Win.Forms;
using DevExpress.XtraTreeList.Nodes;
using System.Drawing;
using System.Windows.Forms;

namespace NukaCollect.Win.Tests {
    [TestFixture]
    public class OpenImageDialogTests {
        [Test]
        public void DrawPath() {
            const string testFile = "testFileDrawPath.png";
            using(Image image = new Bitmap(16, 16)) image.Save(testFile);
            string[] paths = new string[6];
            paths[0] = Directory.GetLogicalDrives()[0];
            paths[1] = paths[0];
            paths[2] = Path.GetFullPath(testFile);
            paths[3] = paths[2];
            paths[4] = paths[2].Remove(paths[2].LastIndexOf('\\') + 1);
            paths[5] = paths[4].Remove(paths[4].Length - 1);
            for(int i = 0; i < paths.Length - 1; i += 2) {
                using(frmOpenImageDialog form = new frmOpenImageDialog(null)) {
                    form.Show();
                    form.DrawPath(paths[i]);
                    TreeListNode node = form.GetTreeList().FindNodeByFieldValue("Path", paths[i + 1]);
                    Assert.IsNotNull(node);
                    Assert.IsTrue(node.Focused);
                    Assert.IsFalse(node.Expanded);
                }
            }
            try {
                File.Delete(testFile);
            } catch(IOException) {
            }
        }
    }
}
#endif
