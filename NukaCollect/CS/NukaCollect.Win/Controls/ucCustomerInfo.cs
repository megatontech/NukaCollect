using DevExpress.XtraEditors;
using DevExpress.XtraLayout.Utils;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace NukaCollect.Win.Controls
{
    public partial class ucCustomerInfo : XtraUserControl
    {
        public event EventHandler DoEdit;

        private Timer tmr;
        private Customer customer;

        public ucCustomerInfo()
        {
            InitializeComponent();
            ElementConstStringLoader.LoadConstStringsForUCCustomerInfo(this);
            if (this.FindForm() != null)
                this.FindForm().SizeChanged += new EventHandler(ucCustomerInfo_SizeChanged);
        }

        public Customer Customer { get { return customer; } }

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

        public void Init(Customer customer, string hint)
        {
            Init(customer, hint, null);
        }

        public void Init(Customer customer, string hint, string toolTip)
        {
            if (customer != null)
                pePhoto.Image = customer.Photo == null ? ReferenceImages.UnknownPerson : pePhoto.Image = customer.Photo;
            else
                pePhoto.Image = null;
            lciInfo.Visibility = customer == null ? LayoutVisibility.Never : LayoutVisibility.Always;
            lciHint.Visibility = customer != null ? LayoutVisibility.Never : LayoutVisibility.Always;
            emptySpaceItem1.Visibility = customer == null ? LayoutVisibility.Never : LayoutVisibility.Always;
            lcInfo.Text = GetCustomerInfo(customer);
            SizePhoto();
            npMain.Text = hint;
            if (!string.IsNullOrEmpty(toolTip))
            {
                pePhoto.ToolTip = toolTip;
                pePhoto.Cursor = Cursors.Hand;
            }
            else pePhoto.Cursor = Cursors.Default;
            this.customer = customer;
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
                lciPhoto.Height = Math.Min(lciPhoto.Width * img.Height / img.Width, img.Height);
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

        private void ucCustomerInfo_SizeChanged(object sender, EventArgs e)
        {
            PictureTimer.Start();
        }

        private string GetCustomerInfo(Customer customer)
        {
            if (customer == null) return string.Empty;
            return customer.GetCustomerInfoHtml();
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