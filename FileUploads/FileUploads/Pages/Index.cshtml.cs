using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace FileUploads.Pages {
    public class IndexModel : PageModel {
        
        public IndexModel(IHostingEnvironment env) {
            this.env = env;
        }

        private readonly IHostingEnvironment env;
        
        public IFormFile UploadedFile { get; set; }
        public List<string> fileList = new List<string>();

        private void updateFileList() {
            string uploadPath = Path.Combine(env.ContentRootPath, "wwwroot", "uploads");
            DirectoryInfo uploadInfo = new DirectoryInfo(uploadPath);
            FileInfo[] files = uploadInfo.GetFiles();
            foreach (var f in files) {
                fileList.Add(f.Name);
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
