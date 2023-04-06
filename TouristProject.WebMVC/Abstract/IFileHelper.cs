using Microsoft.AspNetCore.Http;

namespace TouristProject.WebMVC.Abstract
{
    public interface IFileHelper
    {
        void DeleteFile(string imageUrl);
        string UploadFile(IFormFile file);

    }
}
