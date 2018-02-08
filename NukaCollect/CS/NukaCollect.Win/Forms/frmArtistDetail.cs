using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.Utils.Menu;
using NukaCollect.Win.Modules;
using DevExpress.Xpo;

namespace NukaCollect.Win.Forms {
    public partial class frmArtistDetail : frmDetailBase {
        ArtistDetail artists = null;
        public frmArtistDetail(Form parent, GetSessionCallback session, Artist artist, IDXMenuManager manager, CloseDetailForm closeForm)
            : base(parent) {
            InitializeComponent();
            ElementConstStringLoader.LoadConstStringsForFrmArtistDetail(this);
            AddArtistDetail(parent, session, artist, manager, closeForm);
        }

        void AddArtistDetail(Form parent, GetSessionCallback session, Artist artist, IDXMenuManager manager, CloseDetailForm closeForm) {
            artists = new ArtistDetail(parent, session, artist, manager, closeForm);
            artists.Dock = DockStyle.Fill;
            this.Controls.Add(artists);
            artists.BringToFront();
            Text = artists.PageCaption;
        }
        protected override void SaveData() {
            base.SaveData();
            if(artists.SaveAndClose())
                this.Close();
        }
    }
}

