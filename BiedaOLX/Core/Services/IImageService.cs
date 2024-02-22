using BiedaOLX.Core.Models.Domains;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace BiedaOLX.Core.Services
{
    public interface IImageService
    {
        string UploadImage(IFormFile ImageFile);
        void DeletImage(string imgeFilePath);

	}
}
