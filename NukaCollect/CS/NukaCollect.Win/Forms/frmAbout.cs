using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Utils;
using NukaCollect.Resources;
using DevExpress.Utils.Drawing;
using DevExpress.Utils.Frames;

namespace NukaCollect.Win {
    public partial class frmAbout : XtraForm {
        bool blnMoving = false;
        int MouseDownX, MouseDownY;
        static string fontName = "Segoe UI";
        LabelInfo labelInfo = new LabelInfo();
        static Color
            color1 = Color.FromArgb(210, 196, 196),
            color2 = Color.FromArgb(143, 133, 127);    
        static AppearanceDefault
            versionAppearance = new AppearanceDefault(color1, Color.Empty, HorzAlignment.Near, VertAlignment.Top, new Font(fontName, 9.25f)),
            descriptionAppearance = new AppearanceDefault(color1, Color.Empty, HorzAlignment.Near, VertAlignment.Top, new Font(fontName, 7.75f)),
            copyrightAppearance = new AppearanceDefault(color2, Color.Empty, HorzAlignment.Center, VertAlignment.Top, new Font(fontName, 7.75f));
        static Rectangle
            versionBounds = new Rectangle(210, 94, 260, 20),
            descriptionBounds = new Rectangle(210, 124, 270, 100),
            copyrightBounds = new Rectangle(20, 280, 485, 20);
        public frmAbout() {
            InitializeComponent();
            ElementConstStringLoader.LoadConstStringsForFrmAbout(this);
            Image bgImage = ResourceImageHelper.CreateImageFromResources(
                "NukaCollect.Resources.Images.About.png", typeof(ImagesHelper).Assembly);
            this.BackgroundImage = bgImage;
            this.Size = bgImage.Size;
            CreateLinks();
        }
        void CreateLinks() {
            labelInfo.Font = new Font(fontName, 8.75f);
            labelInfo.BackColor = Color.Transparent;
            if(LocalizationHelper.IsJapanese) labelInfo.Bounds = new Rectangle(155, 260, 430, 20);
            else labelInfo.Bounds = new Rectangle(55, 260, 430, 20);
            labelInfo.Parent = this;
            labelInfo.ItemClick += new LabelInfoItemClickEvent(OnLabelClick);
            labelInfo.Texts.Add(ConstStrings.Get("AboutFormLink1"), color1, true);
            if(!LocalizationHelper.IsJapanese) {
            labelInfo.Texts.Add(ConstStrings.Get("AboutFormSeparator"), color2);
            labelInfo.Texts.Add(ConstStrings.Get("AboutFormLink2"), color1, true);
            }
            labelInfo.Texts.Add(ConstStrings.Get("AboutFormSeparator"), color2);
            labelInfo.Texts.Add(ConstStrings.Get("AboutFormLink3"), color1, true);
        }
        void OnLabelClick(object sender, LabelInfoItemClickEventArgs e) {
            string name = GetProcessName(e);
            if(name != null)
                ObjectHelper.ShowWebSite(name);
        }
        private string GetProcessName(LabelInfoItemClickEventArgs e) {
            if(e.InfoText.Text.Equals(ConstStrings.Get("AboutFormLink1"))) return AssemblyInfo.DXLinkGetStarted;
            if(e.InfoText.Text.Equals(ConstStrings.Get("AboutFormLink2"))) return AssemblyInfo.DXLinkTrial;
            if(e.InfoText.Text.Equals(ConstStrings.Get("AboutFormLink3"))) return AssemblyInfo.DXLinkBuyNow;
            return null;
        }
        public static void ShowAbout(Form parent) {
            frmAbout about = new frmAbout();
            about.Opacity = 0;
            Timer tmr = new Timer();
            tmr.Tag = about;
            tmr.Interval = 20;
            tmr.Tick += new EventHandler(tmr_Tick);
            tmr.Start();
            about.ShowDialog(parent);
            about.Dispose();
        }

        static void tmr_Tick(object sender, EventArgs e) {
            Timer tmr = sender as Timer;
            Form frm = tmr.Tag as Form;
            if(frm == null) {
                tmr.Stop();
                return;
            }
            try {
                frm.Opacity += 0.07;
                if(frm.Opacity >= 0.99) tmr.Tag = null;
            }
            catch { }
        }

        protected override void OnKeyDown(KeyEventArgs e) {
            if(e.KeyData == Keys.Escape) {
                e.Handled = true;
                Close();
            }
            base.OnKeyDown(e);
        }
        protected override void OnMouseDown(MouseEventArgs e) {
            base.OnMouseDown(e);
            if(e.Y < 250)
                Close();
            else {
                if(e.Button == MouseButtons.Left) {
                    blnMoving = true;
                    MouseDownX = e.X;
                    MouseDownY = e.Y;
                }
            }
        }
        protected override void OnMouseMove(MouseEventArgs e) {
            base.OnMouseMove(e);
            if(blnMoving)
                this.Location = new Point(
                    this.Location.X + (e.X - MouseDownX),
                    this.Location.Y + (e.Y - MouseDownY));
        }
        protected override void OnMouseUp(MouseEventArgs e) {
            base.OnMouseUp(e);
            if(e.Button == MouseButtons.Left)
                blnMoving = false;
        }
        protected override void OnPaint(PaintEventArgs e) {
            using(GraphicsCache cache = new GraphicsCache(e)) {
                cache.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                DrawVersion(cache);
                DrawDescription(cache);
                DrawCopyright(cache);
            }
        }
        void DrawVersion(GraphicsCache cache) {
            AppearanceObject app = new AppearanceObject(versionAppearance);
            app.DrawString(cache, string.Format(ConstStrings.Get("AboutFormVersion"), AssemblyInfo.MarketingVersion), versionBounds);
        }
        void DrawDescription(GraphicsCache cache) {
            AppearanceObject app = new AppearanceObject(descriptionAppearance);
            app.TextOptions.WordWrap = WordWrap.Wrap;
            app.DrawString(cache, ConstStrings.Get("AboutFormDescription"), descriptionBounds);
        }
        void DrawCopyright(GraphicsCache cache) {
            AppearanceObject app = new AppearanceObject(copyrightAppearance);
            app.DrawString(cache, string.Format(ConstStrings.Get("AboutFormCopyright"), DateTime.Now.Year), copyrightBounds);
        }
    }
}
