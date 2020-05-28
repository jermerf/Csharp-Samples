using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AjaxAndPost.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AjaxAndPost.Pages {
    public class PeopleModel : PageModel {

        private ClassroomContext db;

        public List<Individual> people = new List<Individual>();

        public PeopleModel(ClassroomContext classroom) {
            db = classroom;
        }

        public void OnGet() {
            people = db.Person.ToList();
        }
    }
}