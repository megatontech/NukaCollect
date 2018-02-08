using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraPrinting;
using System.Drawing.Imaging;

namespace NukaCollect.Win.Controls {
    public partial class ExportControl : RibbonApplicationUserControl {
        public ExportControl() {
            InitializeComponent();
        }
        string rtfText;
        public string RtfText {
            get { return rtfText; }
            set { rtfText = value; }
        }
        private void galleryControlGallery1_ItemClick(object sender, DevExpress.XtraBars.Ribbon.GalleryItemClickEventArgs e) {
            if(e.Item.Caption.Contains("PDF"))
                saveFileDialog1.Filter = "PDF files (*.pdf)|*.pdf";
            else if(e.Item.Caption.Contains("HTML"))
                saveFileDialog1.Filter = "HTML files (*.html)|*.html";
            else if(e.Item.Caption.Contains("MHT"))
                saveFileDialog1.Filter = "MHT files (*.mht)|*.mht";
            else if(e.Item.Caption.Contains("RTF"))
                saveFileDialog1.Filter = "RTF files (*.rtf)|*.rtf";
            else if(e.Item.Caption.Contains("XLS"))
                saveFileDialog1.Filter = "XLS files (*.xls)|*.xls";
            else if(e.Item.Caption.Contains("XLSX"))
                saveFileDialog1.Filter = "XLSX files (*.xls)|*.xls";
            else if(e.Item.Caption.Contains("CSV"))
                saveFileDialog1.Filter = "CSV files (*.csv)|*.csv";
            else if(e.Item.Caption.Contains("Text File"))
                saveFileDialog1.Filter = "Text files (*.txt)|*.txt";
            else if(e.Item.Caption.Contains("Image"))
                saveFileDialog1.Filter = "BMP files (*.bmp)|*.bmp|Gif files (*.gif)|*.gif|Jpeg files (*.jpeg)|*.jpeg|PNG files (*.png)|*.png|Tiff files (*.tiff)|*.tiff|EMF files (*.emf)|.emf|WMF files (*.wmf)|*.wmf";
            saveFileDialog1.Filter += "|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 0;
            if(saveFileDialog1.ShowDialog() != DialogResult.OK)
                return;
            PrintingSystem ps = new PrintingSystem();
            Link link = new Link(ps);
            link.RtfReportHeader = RtfText;
            link.CreateDocument();
            if(e.Item.Caption.Contains("PDF"))
                ps.ExportToPdf(saveFileDialog1.FileName);
            else if(e.Item.Caption.Contains("HTML"))
                ps.ExportToHtml(saveFileDialog1.FileName);
            else if(e.Item.Caption.Contains("MHT"))
                ps.ExportToMht(saveFileDialog1.FileName);
            else if(e.Item.Caption.Contains("RTF"))
                ps.ExportToRtf(saveFileDialog1.FileName);
            else if(e.Item.Caption.Contains("XLS"))
                ps.ExportToXls(saveFileDialog1.FileName);
            else if(e.Item.Caption.Contains("XLSX"))
                ps.ExportToXlsx(saveFileDialog1.FileName);
            else if(e.Item.Caption.Contains("CSV"))
                ps.ExportToCsv(saveFileDialog1.FileName);
            else if(e.Item.Caption.Contains("Text File"))
                ps.ExportToText(saveFileDialog1.FileName);
            else if(e.Item.Caption.Contains("Image")) {
                ImageFormat fmt = ImageFormat.Bmp;
                switch(saveFileDialog1.FilterIndex) { 
                    case 0: fmt = ImageFormat.Bmp; break;
                    case 1: fmt = ImageFormat.Gif; break;
                    case 2: fmt = ImageFormat.Jpeg; break;
                    case 3: fmt = ImageFormat.Png; break;
                    case 4: fmt = ImageFormat.Tiff; break;
                    case 5: fmt = ImageFormat.Emf; break;
                    case 6: fmt = ImageFormat.Wmf; break;
                }
                ps.ExportToImage(saveFileDialog1.FileName, fmt);
            }
        }
    }
}
