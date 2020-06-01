using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using FileUploads.Model;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace FileUploads.Pages {
    public class IndexModel : PageModel {
        
        public IndexModel(IWebHostEnvironment env) {
            this.env = env;
        }

        private readonly IWebHostEnvironment env;
        
        public IFormFile UploadedFile { get; set; }
        public List<UploadFile> fileList = new List<UploadFile>();

        private List<string> imageExtensions =new List<string> {".jpg", ".jpeg", ".png"};

        private void updateFileList() {
            string uploadPath = Path.Combine(env.ContentRootPath, "wwwroot", "uploads");
            DirectoryInfo uploadInfo = new DirectoryInfo(uploadPath);
            FileInfo[] files = uploadInfo.GetFiles();
            foreach (var f in files) {
                fileList.Add(new UploadFile {
                    name = f.Name,
                    isImage = imageExtensions.Contains(f.Extension)
                });
            }
        }

        public void OnGet() {
            updateFileList();
        }

        public void OnPost(string password) {
            if (password == "secret") {
                string copyPath = Path.Combine(env.ContentRootPath, "wwwroot", "uploads", UploadedFile.FileName);
                UploadedFile.CopyTo(new FileStream(copyPath, FileMode.OpenOrCreate));
                //Log in database or use somewhere
                Console.WriteLine($"File: {UploadedFile.Name}");
            } else {
                Console.WriteLine($"File: {UploadedFile.Name} declined. Bad password: {password}");
            }

            updateFileList();
        }

    }
}
