using System;
using System.Collections.Generic;
using System.Text;
using DevExpress.Utils;
using System.Drawing;
using DevExpress.Utils.Controls;
using NukaCollect.Resources.Helpers;
using System.Windows.Media;

namespace NukaCollect.Resources {
    public class ImagesSourceHelper {
        static ImagesSourceHelper current;
        static List<ImageSource> diskIcons;
        static List<ImageSource> personImages;
        static List<ImageSource> receiptTypeImages;
        static List<ImageSource> ratingImages;
        static List<ImageSource> ratingLargeImages;
        static List<ImageSource> activeRents;
        static List<ImageSource> columnHeaderImages;
        static List<ImageSource> columnHeaderSmoothImages;
        static List<ImageSource> barImages;
        static List<ImageSource> folderIcons;

        public static ImagesSourceHelper Current {
            get {
                if(current == null)
                    current = new ImagesSourceHelper();
                return current;
            }
        }
        public List<ImageSource> DiskIcons {
            get {
                if(diskIcons == null)
                    diskIcons = DrawingImageToImageSourceConverter.Convert(ImagesHelper.Current.DiskIcons);
                return ImagesSourceHelper.diskIcons;
            }
        }
        public List<ImageSource> PersonIcons {
            get {
                if(personImages == null)
                    personImages = DrawingImageToImageSourceConverter.Convert(ImagesHelper.Current.PersonImages);
                return personImages;
            }
        }
        public List<ImageSource> ReceiptTypes {
            get {
                if(receiptTypeImages == null)
                    receiptTypeImages = DrawingImageToImageSourceConverter.Convert(ImagesHelper.Current.ReceiptTypeImages);
                return receiptTypeImages;
            }
        }
        public List<ImageSource> Ratings {
            get {
                if(ratingImages == null)
                    ratingImages = DrawingImageToImageSourceConverter.Convert(ImagesHelper.Current.RatingImages);
                return ratingImages;
            }
        }
        public List<ImageSource> RatingsLarge {
            get {
                if(ratingLargeImages == null)
                    ratingLargeImages = DrawingImageToImageSourceConverter.Convert(ImagesHelper.Current.RatingLargeImages);
                return ratingLargeImages;
            }
        }
        public List<ImageSource> RentTypes {
            get {
                if(activeRents == null)
                    activeRents = DrawingImageToImageSourceConverter.Convert(ImagesHelper.Current.ActiveRents);
                return activeRents;
            }
        }
        public List<ImageSource> BarIcons {
            get {
                if(barImages == null)
                    barImages = DrawingImageToImageSourceConverter.Convert(ImagesHelper.Current.BarImages);
                return barImages;
            }
        }
        public List<ImageSource> ColumnHeaderIcons {
            get {
                if(columnHeaderImages == null)
                    columnHeaderImages = DrawingImageToImageSourceConverter.Convert(ImagesHelper.Current.ColumnHeaderImages);
                return columnHeaderImages;
            }
        }
        public List<ImageSource> ColumnHeaderIconsSmooth {
            get {
                if(columnHeaderSmoothImages == null)
                    columnHeaderSmoothImages = DrawingImageToImageSourceConverter.Convert(ImagesHelper.Current.ColumnHeaderSmoothImages);
                return columnHeaderSmoothImages;
            }
        }
        public List<ImageSource> FolderIcons {
            get {
                if(folderIcons == null)
                    folderIcons = DrawingImageToImageSourceConverter.Convert(ImagesHelper.Current.FolderIcons);
                return folderIcons;
            }
        }
    }
}
