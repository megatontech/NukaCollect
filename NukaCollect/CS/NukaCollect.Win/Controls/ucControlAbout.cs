using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Utils.Controls;
using DevExpress.Utils.Frames;
using DevExpress.Data.Helpers;
using DevExpress.XtraNavBar;
using NukaCollect.Resources;

namespace NukaCollect.Win.Controls {
    public partial class ucControlAbout : XtraUserControl, IXtraResizableControl {
        const int LinkHeight = 45;
        const int PictureIndent = 0;
        LabelInfo labelInfo = new LabelInfo(); 
        public ucControlAbout() {
            InitializeComponent();
            ElementConstStringLoader.LoadConstStringsForUCControlAbout(this);
            LookAndFeel.StyleChanged += new EventHandler(LookAndFeel_StyleChanged);
        }
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            if(disposing)
                LookAndFeel.StyleChanged -= new EventHandler(LookAndFeel_StyleChanged);
            base.Dispose(disposing);
        }
        void LookAndFeel_StyleChanged(object sender, EventArgs e) {
            UpdateLabelInfoColor();
        }
        void UpdateLabelInfoColor() {
            foreach(LabelInfoText liText in labelInfo.Texts)
                liText.Color = WinHelper.GetLinkColor(LookAndFeel);
        }
        public void Init(string name, DemoProducts product, Image image) {
            lcName.Text = name;
            peAbout.Image = image;
            if(image != null)
                peAbout.Height = image.Height;
            RaiseChanged();
            CreateLabels(product);
            UpdateLabelInfoColor();
        }

        void CreateLabels(DemoProducts product) {
            labelInfo.BackColor = Color.Transparent;
            labelInfo.Bounds = new Rectangle(0, 0, this.Width, LinkHeight);
            labelInfo.Parent = pnlLinks;
            labelInfo.ItemClick += new LabelInfoItemClickEvent(OnLabelClick);
            foreach(ModuleInfo info in DemosInfo.Instance.Collection)
                if(info.Products.ToString().IndexOf(product.ToString()) >= 0) {
                    if(labelInfo.Text.Length > 0)
                        labelInfo.Texts.Add(ConstStrings.Get("AboutFormSeparator"));
                    LabelInfoText liText = labelInfo.Texts.Add(ElementHelper.GetSingleLineString(info.Name), true);
                    liText.Tag = info;
                }
        }
        void OnLabelClick(object sender, LabelInfoItemClickEventArgs e) {
            frmMain form = this.FindForm() as frmMain;
            if(form == null) return;
            foreach(NavBarGroup group in form.NavigationBar.Groups)
                foreach(NavBarItemLink link in group.ItemLinks)
                    if(e.InfoText.Tag.Equals(link.Item.Tag)) {
                        form.NavigationBar.SelectedLink = link;
                        form.NavigationBar.GetViewInfo().MakeLinkVisible(link);
                        return;
                    }
        }
        protected override void OnFontChanged(EventArgs e) {
            base.OnFontChanged(e);
            lcName.Font = new Font(this.Font.FontFamily, 10);
            labelInfo.Font = new Font(this.Font.FontFamily, 8.75f);
        }
        #region IXtraResizableControl Members
        public event EventHandler Changed;
        protected virtual void RaiseChanged() {
            if(Changed != null)
                Changed(this, EventArgs.Empty);
        }
        public bool IsCaptionVisible {
            get { return false; }
        }
        public Size MaxSize {
            get { return GetAppropriateSize(); }
        }
        public Size MinSize {
            get { return GetAppropriateSize(); }
        }
        Size GetAppropriateSize() { return DevExpress.Utils.ScaleUtils.GetScaleSize(new Size(ControlWidth, ControlHeight)); }
        int ControlWidth { get { return peAbout.Image == null ? 200 : peAbout.Image.Width + PictureIndent * 2; } }
        int ControlHeight { get { return lcName.Height + peAbout.Height + LinkHeight; } }
        #endregion
    }
}
