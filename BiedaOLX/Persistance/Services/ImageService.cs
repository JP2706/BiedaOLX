using BiedaOLX.Core.Models.Domains;
using BiedaOLX.Core.Services;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;
using System;
using System.IO;
using System.Threading.Tasks;

namespace BiedaOLX.Persistance.Services
{
    public class ImageService : IImageService
    {
        private IWebHostEnvironment _hostingEnv;
        


		public ImageService(IWebHostEnvironment hostingEnv)
        {
            _hostingEnv = hostingEnv;
        }

        public string UploadImage(IFormFile userFile)
        {
            var folder = "Photo/";
            folder += Guid.NewGuid().ToString() + "_" + userFile.FileName;
            var folderDb = "/" + folder;
            string serverFolder = Path.Combine(_hostingEnv.WebRootPath,folder);
            //string newFilePath = Path.Combine(Directory.GetCurrentDirectory(), "Files");
            //if (newFilePath == null)
            //    Directory.CreateDirectory(uploadFilePath);
            using (Stream stream = new FileStream(serverFolder, FileMode.Create))
            {
                userFile.CopyTo(stream);
            }
            return folderDb;
        }

        public void DeletImage(string imgeFilePath)
        {
            var filePath = imgeFilePath;
            if (filePath != null) 
            {
                var filePathToDelete = Path.Combine(_hostingEnv.WebRootPath, filePath);
                File.Delete(filePathToDelete);
            }
        }
    }
}
