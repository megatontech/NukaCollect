using DevExpress.XtraEditors;
using DevExpress.XtraLayout.Utils;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace NukaCollect.Win.Controls
{
    public partial class ucMovieInfo : XtraUserControl
    {
        public event EventHandler DoEdit;

        private Timer tmr;

        public ucMovieInfo()
        {
            InitializeComponent();
            ElementConstStringLoader.LoadConstStringsForUCMovieInfo(this);
            if (this.FindForm() != null)
                this.FindForm().SizeChanged += new EventHandler(ucMovieInfo_SizeChanged);
        }

        private Timer PictureTimer
        {
            get
            {
                if (tmr == null)
                {
                    tmr = new Timer();
                    tmr.Interval = 100;
                    tmr.Enabled = false;
                    tmr.Tick += new EventHandler(tmr_Tick);
                }
                return tmr;
            }
        }

        private void tmr_Tick(object sender, EventArgs e)
        {
            SizePhoto();
            PictureTimer.Stop();
        }

        public void Init(Movie movie)
        {
            if (movie != null)
                pePhoto.Image = movie.Photo;
            else
                pePhoto.Image = null;
            lciInfo.Visibility = movie == null ? LayoutVisibility.Never : LayoutVisibility.Always;
            lcInfo.Text = movie != null ? movie.GetFullMovieInfoHtml() : string.Empty;
            SizePhoto();
            this.Refresh();
        }

        private bool lockResize = false;

        private void SizePhoto()
        {
            if (lockResize) return;
            lockResize = true;
            Image img = pePhoto.Image;
            try
            {
                if (img == null)
                {
                    lciPhoto.Visibility = LayoutVisibility.Never;
                    return;
                }
                else lciPhoto.Visibility = LayoutVisibility.Always;
                lciInfo.Width = lcMain.Width - Math.Min(lciPhoto.Height * img.Width / img.Height, img.Width);
            }
            finally
            {
                lockResize = false;
            }
        }

        private void pePhoto_Resize(object sender, EventArgs e)
        {
            PictureTimer.Start();
        }

        private void ucMovieInfo_SizeChanged(object sender, EventArgs e)
        {
            PictureTimer.Start();
        }

        private void RaiseDoEdit()
        {
            if (DoEdit != null) DoEdit(this, EventArgs.Empty);
        }

        private void pePhoto_DoubleClick(object sender, EventArgs e)
        {
            RaiseDoEdit();
        }

        private void lcInfo_DoubleClick(object sender, EventArgs e)
        {
            RaiseDoEdit();
        }
    }
}