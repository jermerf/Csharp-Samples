using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using TodoListWebApp.Model;

namespace TodoListWebApp.Pages {
    public class IndexModel : PageModel {

        private ClassroomContext db;
        public List<ToDoItem> todos = new List<ToDoItem>();

        public IndexModel(ClassroomContext db) {
            this.db = db;
        }

        public void OnGet() {
            todos = db.ToDo.ToList();
        }

        public void OnPost(int todoId, string updatedText) {
            todos = db.ToDo.ToList();
            foreach(var item in todos) {
                if(item.Id == todoId) {
                    item.text = updatedText;
                    break;
                }
            }
            db.SaveChanges();
        }


        public void OnPostToggleComplete(int todoId) {
            todos = db.ToDo.ToList();
            foreach (var item in todos) {
                if (item.Id == todoId) {
                    item.complete = !item.complete;
                    break;
                }
            }
            db.SaveChanges();
            var a = new FileInfo("cat");
            a.Extension
        }
    }
}
