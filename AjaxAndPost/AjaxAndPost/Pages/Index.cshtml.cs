using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AjaxAndPost.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace AjaxAndPost.Pages {
    public class IndexModel : PageModel {

        private ClassroomContext db;

        public int studentCount { get; set; } = 0;

        public IndexModel(ClassroomContext db) {
            this.db = db;
        }

        public void OnGet() {
            studentCount = db.Students.Count();
        }

    }
}
