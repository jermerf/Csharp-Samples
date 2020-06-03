using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MessageBoard.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace MessageBoard.Pages {
    public class IndexModel : PageModel {
        public IndexModel(ClassroomContext db) {
            this.db = db;
        }

        private readonly ClassroomContext db;

        public string Username { get; set; }
        public List<BoardPost> Posts { get; set; } = new List<BoardPost>();

        public void OnGet() {
            Username = HttpContext.Session.GetString("username");
            Posts = db.BoardPosts.ToList();
        }

        public void OnPost(string content) {
            var newPost = new BoardPost {
                userId = (int)HttpContext.Session.GetInt32("userId"),
                content = content,
                postedOn = DateTime.Now
            };
            db.BoardPosts.Add(newPost);
            db.SaveChanges();
            OnGet();
        }

    }
}
