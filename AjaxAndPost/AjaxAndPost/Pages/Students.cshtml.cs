using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AjaxAndPost.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StudentEditor.Model;

namespace AjaxAndPost.Pages {
    public class StudentsModel : PageModel {

        private ClassroomContext db;

        public List<Student> Students = new List<Student>();

        public StudentsModel(ClassroomContext classroom) {
            db = classroom;
        }

        public void OnGet() {
            Students = db.Students.ToList();
        }
    }
}