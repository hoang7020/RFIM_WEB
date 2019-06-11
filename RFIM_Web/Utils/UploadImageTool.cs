using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace RFIM_Web.Utils
{
    public class UploadImageTool
    {
        public static string UploadImage(IFormFile fHinh, string folder)
        {
            string fileName = "";
            if(fHinh != null)
            {
                string fullPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Hinh", folder, fHinh.FileName);
                using(var file = new FileStream(fullPath, FileMode.Create))
                {
                    fHinh.CopyTo(file);
                    fileName = fHinh.FileName;
                }
            }
            return fileName;
        }
    }
}
