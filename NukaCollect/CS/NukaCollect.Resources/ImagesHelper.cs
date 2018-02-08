using DevExpress.Utils;
using System.Drawing;

namespace NukaCollect.Resources
{
    public class ImagesHelper
    {
        private static ImagesHelper current;
        private static ImageCollection diskIcons;
        private static ImageCollection personImages;
        private static ImageCollection receiptTypeImages;
        private static ImageCollection ratingImages;
        private static ImageCollection ratingLargeImages;
        private static ImageCollection activeRents;
        private static ImageCollection columnHeaderImages;
        private static ImageCollection columnHeaderSmoothImages;
        private static ImageCollection barImages;
        private static ImageCollection folderIcons;
        private static Image aboutImage;

        public static ImagesHelper Current
        {
            get
            {
                if (current == null)
                    current = new ImagesHelper();
                return current;
            }
        }

        public ImageCollection DiskIcons
        {
            get
            {
                if (ImagesHelper.diskIcons == null)
                    ImagesHelper.diskIcons = DevExpress.Utils.Controls.ImageHelper.CreateImageCollectionFromResources("NukaCollect.Resources.Images.DiskFormats.png", typeof(ImagesHelper).Assembly, new Size(16, 16));
                return ImagesHelper.diskIcons;
            }
        }

        public ImageCollection PersonImages
        {
            get
            {
                if (ImagesHelper.personImages == null)
                    ImagesHelper.personImages = DevExpress.Utils.Controls.ImageHelper.CreateImageCollectionFromResources("NukaCollect.Resources.Images.Persons.png", typeof(ImagesHelper).Assembly, new Size(16, 16));
                return ImagesHelper.personImages;
            }
        }

        public ImageCollection ReceiptTypeImages
        {
            get
            {
                if (ImagesHelper.receiptTypeImages == null)
                    ImagesHelper.receiptTypeImages = DevExpress.Utils.Controls.ImageHelper.CreateImageCollectionFromResources("NukaCollect.Resources.Images.ReceiptType.png", typeof(ImagesHelper).Assembly, new Size(16, 16));
                return ImagesHelper.receiptTypeImages;
            }
        }

        public ImageCollection RatingImages
        {
            get
            {
                if (ratingImages == null)
                    ratingImages = DevExpress.Utils.Controls.ImageHelper.CreateImageCollectionFromResources("NukaCollect.Resources.Images.RatingsSmall.png", typeof(ImagesHelper).Assembly, new Size(38, 16));
                return ratingImages;
            }
        }

        public ImageCollection RatingLargeImages
        {
            get
            {
                if (ratingLargeImages == null)
                    ratingLargeImages = DevExpress.Utils.Controls.ImageHelper.CreateImageCollectionFromResources("NukaCollect.Resources.Images.RatingsLarge.png", typeof(ImagesHelper).Assembly, new Size(250, 37));
                return ratingLargeImages;
            }
        }

        public ImageCollection ActiveRents
        {
            get
            {
                if (activeRents == null)
                    activeRents = DevExpress.Utils.Controls.ImageHelper.CreateImageCollectionFromResources("NukaCollect.Resources.Images.ActiveRents.png", typeof(ImagesHelper).Assembly, new Size(16, 16));
                return activeRents;
            }
        }

        public ImageCollection BarImages
        {
            get
            {
                if (ImagesHelper.barImages == null)
                    ImagesHelper.barImages = DevExpress.Utils.Controls.ImageHelper.CreateImageCollectionFromResources("NukaCollect.Resources.Images.BarImages16x16.png", typeof(NukaCollect.Resources.ImagesHelper).Assembly, new System.Drawing.Size(16, 16));
                return ImagesHelper.barImages;
            }
        }

        public ImageCollection ColumnHeaderImages
        {
            get
            {
                if (ImagesHelper.columnHeaderImages == null)
                    ImagesHelper.columnHeaderImages = DevExpress.Utils.Controls.ImageHelper.CreateImageCollectionFromResources("NukaCollect.Resources.Images.ColumnHeaderImages.png", typeof(NukaCollect.Resources.ImagesHelper).Assembly, new System.Drawing.Size(13, 13));
                return ImagesHelper.columnHeaderImages;
            }
        }

        public ImageCollection ColumnHeaderSmoothImages
        {
            get
            {
                if (ImagesHelper.columnHeaderSmoothImages == null)
                    ImagesHelper.columnHeaderSmoothImages = DevExpress.Utils.Controls.ImageHelper.CreateImageCollectionFromResources("NukaCollect.Resources.Images.ColumnHeaderSmoothImages.png", typeof(NukaCollect.Resources.ImagesHelper).Assembly, new System.Drawing.Size(13, 13));
                return ImagesHelper.columnHeaderSmoothImages;
            }
        }

        public ImageCollection FolderIcons
        {
            get
            {
                if (folderIcons == null)
                    folderIcons = DevExpress.Utils.Controls.ImageHelper.CreateImageCollectionFromResources("NukaCollect.Resources.Images.FolderIcons16x16.png", typeof(NukaCollect.Resources.ImagesHelper).Assembly, new System.Drawing.Size(16, 16));
                return folderIcons;
            }
        }

        public Image AboutImage
        {
            get
            {
                if (ImagesHelper.aboutImage == null)
                    ImagesHelper.aboutImage = ResourceImageHelper.CreateImageFromResources("NukaCollect.Resources.Images.About.png", typeof(NukaCollect.Resources.ImagesHelper).Assembly);
                return ImagesHelper.aboutImage;
            }
        }
    }
}