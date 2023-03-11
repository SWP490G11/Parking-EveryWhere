using Back_end.Helper;
using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using Microsoft.Extensions.Options;

namespace Back_end.Services
{
    public interface IImageService
    {
        Task<ImageUploadResult> UploadImageAsync(IFormFile file);
        Task<DeletionResult> DeleteImageAsync(string publicID);
    }

    public class ImageService : IImageService
    {
        private readonly Cloudinary _cloudinary;
        

        public ImageService(IOptions<CloudarySettings> config)
        {
            var acc = new Account() {
            ApiKey = config.Value.ApiKey,
            ApiSecret = config.Value.ApiSecret,
            Cloud =config.Value.CloudName
            };
            _cloudinary = new Cloudinary(acc);
        }

        public async Task<ImageUploadResult> UploadImageAsync(IFormFile file)
        {

            var uploadResult = new ImageUploadResult();
            if(file.Length >0)
            {
                using var stream = file.OpenReadStream();
                var upLoadParams = new ImageUploadParams()
                {
                    File = new FileDescription(file.FileName,stream),
                    Transformation = new Transformation().Height(500).Width(500).Crop("fill").Gravity("face")
                    
                };
                uploadResult = await _cloudinary.UploadAsync(upLoadParams);
            }
             
            

            return uploadResult;
        }

        public async Task<DeletionResult> DeleteImageAsync(string publicID)
        {
            var deleteParams = new DeletionParams(publicID);

            var result = await _cloudinary.DestroyAsync(deleteParams);

            return result;
        }
    }
}
