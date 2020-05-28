using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AjaxAndPost.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AjaxAndPost.Pages {
    public class RegisterModel : PageModel {

        private ClassroomContext db;

        public RegisterModel(ClassroomContext db) {
            this.db = db;
        }

        public void OnPost(string name, string email, string password) {
            var newPerson = new Individual { 
                fullname = name, email = email, password = password
            };
            db.Person.Add(newPerson);
            db.SaveChanges();
            Response.Redirect("/People");
        }
    }
}