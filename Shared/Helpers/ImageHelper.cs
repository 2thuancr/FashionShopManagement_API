using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Helpers 
{ 
    public static class ImageHelper
    {
        private static Cloudinary cloudinary = new Cloudinary();
        //private static Cloudinary cloudinary = new Cloudinary(Properties.Settings.Default.cloudinary_url);

        public static ImageUploadResult UploadImage(string filePath, string fileName = null, string fileFormat = "jpg", string folder = "job-management", decimal? width = null, decimal? height = null)
        {
            // Khởi tạo đối tượng upload image chứa các thông tin cần thiết
            var uploadParams = new ImageUploadParams()
            {
                File = new FileDescription(filePath), // Thông tin đường dẫn đến file
                AssetFolder = folder,
                Folder = folder,
                UseFilename = true,
                FilenameOverride = fileName,
                Format = fileFormat, // Định dạng hình ảnh
                UniqueFilename = false,  
                Overwrite = true, // xác định trùng tên có muốn ghi đè.
                UseFilenameAsDisplayName = true,
            };
            // nếu muốn thu gọn hình
            if (width.HasValue && height.HasValue) 
            {
                // cắt hình với chiều dài , rộng 
                uploadParams.Transformation = new Transformation()
                    .Width(width.Value)
                    .Height(height.Value)
                    .Crop("fill");
            }
            var uploadResult = cloudinary.Upload(uploadParams); // Đem thông tin upload lên cloud
            return uploadResult; // Trả về kết quả.
        }

    }
}
