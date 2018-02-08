using DevExpress.Utils;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace NukaCollect.Resources.Helpers
{
    public class DrawingImageToImageSourceConverter : DependencyObject, IValueConverter
    {
        #region Dependecy Properties

        public static readonly DependencyProperty NullValueProperty;
        public static readonly DependencyProperty ForegroundColorProperty;
        private static readonly DependencyProperty GdiImageProperty;

        static DrawingImageToImageSourceConverter()
        {
            Type ownerType = typeof(DrawingImageToImageSourceConverter);
            NullValueProperty = DependencyProperty.Register("NullValue", typeof(System.Drawing.Image), ownerType, new PropertyMetadata(null));
            GdiImageProperty = DependencyProperty.RegisterAttached("GdiImage", typeof(System.Drawing.Image), ownerType, new PropertyMetadata(null));
            ForegroundColorProperty = DependencyProperty.RegisterAttached("ForegroundColor", typeof(Color), ownerType, new PropertyMetadata(Colors.Transparent, RaiseForegroundColorChanged));
        }

        #endregion Dependecy Properties

        public static Color GetForegroundColor(Image image)
        {
            return (Color)image.GetValue(ForegroundColorProperty);
        }

        public static void SetForegroundColor(Image image, Color color)
        {
            image.SetValue(ForegroundColorProperty, color);
        }

        public static BitmapSource Convert(System.Drawing.Image gdiImage, System.Drawing.Image nullValue)
        {
            System.Drawing.Image gdiImageForConvert = gdiImage == null ? nullValue : gdiImage;
            if (gdiImageForConvert == null)
                return null;
            System.Drawing.Bitmap bitmap = gdiImageForConvert as System.Drawing.Bitmap;
            if (bitmap == null)
                throw new NotSupportedException();
            Int32Rect rect = new Int32Rect(0, 0, bitmap.Width, bitmap.Height);
            BitmapSizeOptions sizeOptions = BitmapSizeOptions.FromWidthAndHeight(bitmap.Width, bitmap.Height);
            IntPtr hbitmap = bitmap.GetHbitmap();
            BitmapSource image = Imaging.CreateBitmapSourceFromHBitmap(hbitmap, IntPtr.Zero, rect, sizeOptions);
            DeleteObject(hbitmap);
            SetGdiImage(image, gdiImage);
            return image;
        }

        [DllImport("gdi32.dll")]
        private static extern bool DeleteObject(IntPtr hObject);

        public static System.Drawing.Image ConvertBack(BitmapSource image)
        {
            if (image == null) return null;
            System.Drawing.Image attachedImage = GetGdiImage(image);
            if (attachedImage != null) return attachedImage;
            string source = RetrieveSourceFileName(image as BitmapImage);
            return source == null ? null : new System.Drawing.Bitmap(source);
        }

        public static List<ImageSource> Convert(ImageCollection imageCollection)
        {
            List<ImageSource> list = new List<ImageSource>();
            foreach (System.Drawing.Image image in imageCollection.Images)
            {
                list.Add(Convert(image, null));
            }
            return list;
        }

        public static Color ConvertColor(System.Drawing.Color color)
        {
            return Color.FromArgb(color.A, color.R, color.G, color.B);
        }

        public static System.Drawing.Color ConvertColorBack(Color color)
        {
            return System.Drawing.Color.FromArgb(color.A, color.R, color.G, color.B);
        }

        private static void RaiseForegroundColorChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            Image image = (Image)d;
            DepPropertyHelper.UnsubscribeFromChanged(image, Image.SourceProperty, RaiseImageSourceChanged);
            DepPropertyHelper.SubscribeToChanged(image, Image.SourceProperty, RaiseImageSourceChanged);
            RaiseImageSourceChanged(image, EventArgs.Empty);
        }

        private static void RaiseImageSourceChanged(object sender, EventArgs e)
        {
            Image image = (Image)sender;
            DepPropertyHelper.UnsubscribeFromChanged(image, Image.SourceProperty, RaiseImageSourceChanged);
            System.Drawing.Image drawingImage = ConvertBack(image.Source as BitmapSource);
            if (drawingImage != null)
            {
                Color color = GetForegroundColor(image);
                if (color != Colors.Transparent)
                {
                    //drawingImage = ColorMatrixHelper.GrayscaleImage(drawingImage);
                    drawingImage = ColorMatrixHelper.InvertImage(drawingImage);
                    drawingImage = ColorMatrixHelper.ColorizeImage(drawingImage, ConvertColorBack(color));
                    image.Source = Convert(drawingImage, null);
                }
            }
            DepPropertyHelper.SubscribeToChanged(image, Image.SourceProperty, RaiseImageSourceChanged);
        }

        private static System.Drawing.Image GetGdiImage(DependencyObject target)
        { return (System.Drawing.Image)target.GetValue(GdiImageProperty); }

        private static void SetGdiImage(DependencyObject target, System.Drawing.Image gdiImage)
        { target.SetValue(GdiImageProperty, gdiImage); }

        private static string RetrieveSourceFileName(BitmapImage bitmapImage)
        {
            if (bitmapImage == null || bitmapImage.StreamSource == null) return null;
            FileStream fileStream = bitmapImage.StreamSource as FileStream;
            if (fileStream == null || fileStream.Name == null) return null;
            return fileStream.Name;
        }

        public System.Drawing.Image NullValue { get { return (System.Drawing.Image)GetValue(NullValueProperty); } set { SetValue(NullValueProperty, value); } }

        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return Convert((System.Drawing.Image)value, NullValue);
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return ConvertBack((BitmapSource)value);
        }
    }

    public class DrawingImageToImageConverter : IValueConverter
    {
        public DrawingImageToImageConverter()
        {
            Width = double.NaN;
            Height = double.NaN;
        }

        public double Width { get; set; }
        public double Height { get; set; }
        public Stretch Stretch { get; set; }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            System.Drawing.Image drawingImage = value as System.Drawing.Image;
            if (drawingImage == null) return null;
            return new Image() { Source = DrawingImageToImageSourceConverter.Convert(drawingImage, null), Width = Width, Height = Height, Stretch = Stretch };
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Image image = value as Image;
            if (image == null) return null;
            return DrawingImageToImageSourceConverter.ConvertBack((BitmapSource)image.Source);
        }
    }
}