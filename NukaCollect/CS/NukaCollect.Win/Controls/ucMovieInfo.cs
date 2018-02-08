using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraLayout.Utils;
using DevExpress.LookAndFeel;

namespace NukaCollect.Win.Controls {
    public partial class ucMovieInfo : XtraUserControl {
        public event EventHandler DoEdit;
        Timer tmr;
        public ucMovieInfo() {
            InitializeComponent();
            ElementConstStringLoader.LoadConstStringsForUCMovieInfo(this);
            if(this.FindForm() != null)
                this.FindForm().SizeChanged += new EventHandler(ucMovieInfo_SizeChanged);
        }
        Timer PictureTimer {
            get {
                if(tmr == null) {
                    tmr = new Timer();
                    tmr.Interval = 100;
                    tmr.Enabled = false;
                    tmr.Tick += new EventHandler(tmr_Tick);
                }
                return tmr;
            }
        }
        void tmr_Tick(object sender, EventArgs e) {
            SizePhoto();
            PictureTimer.Stop();
        }
        public void Init(Movie movie) {
            if(movie != null) 
                pePhoto.Image = movie.Photo;
            else
                pePhoto.Image = null;
            lciInfo.Visibility = movie == null ? LayoutVisibility.Never : LayoutVisibility.Always;
            lcInfo.Text = movie != null ? movie.GetFullMovieInfoHtml() : string.Empty;
            SizePhoto();
            this.Refresh();
        }
        bool lockResize = false;
        void SizePhoto() {
            if(lockResize) return;
            lockResize = true;
            Image img = pePhoto.Image;
            try {
                if(img == null) {
                    lciPhoto.Visibility = LayoutVisibility.Never;
                    return;
                }
                else lciPhoto.Visibility = LayoutVisibility.Always;
                lciInfo.Width = lcMain.Width - Math.Min(lciPhoto.Height * img.Width / img.Height, img.Width);
            }
            finally {
                lockResize = false;
            }
        }
        private void pePhoto_Resize(object sender, EventArgs e) {
            PictureTimer.Start();
        }
        void ucMovieInfo_SizeChanged(object sender, EventArgs e) {
            PictureTimer.Start();
        }
        void RaiseDoEdit() {
            if(DoEdit != null) DoEdit(this, EventArgs.Empty);
        }
        private void pePhoto_DoubleClick(object sender, EventArgs e) {
            RaiseDoEdit();
        }

        private void lcInfo_DoubleClick(object sender, EventArgs e) {
            RaiseDoEdit();
        }
    }
}
