using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TodoListWebApp.Model;

namespace TodoListWebApp.Pages {
    public class AddModel : PageModel {

        private ClassroomContext db;

        public AddModel(ClassroomContext db) {
            this.db = db;
        }

        public void OnPost(string text) {
            if (text.Length > 50) text = text.Substring(0, 50);

            var item = new ToDoItem {
                text = text
            };
            db.ToDo.Add(item);
            db.SaveChanges();
            Response.Redirect("/");
        }
    }
}