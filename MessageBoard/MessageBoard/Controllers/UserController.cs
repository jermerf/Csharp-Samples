using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MessageBoard.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MessageBoard.Controllers {
    [Route("[controller]")]
    [ApiController]
    public class UserController : ControllerBase {

        public UserController(ClassroomContext db) {
            this.db = db;
        }

        private readonly ClassroomContext db;

        [HttpGet]
        public IEnumerable<BoardUser> OnGet() {
            return db.BoardUsers.ToList();
        }

        [HttpPost]
        public bool OnPost() {
            string action = Request.Form["action"];
            string username = Request.Form["username"];
            string password = Request.Form["password"];
            if (username.Length > 50) username = username.Substring(0, 50);
            if (password.Length > 50) password = password.Substring(0, 50);

            switch (action) {
                case "login":
                    try {
                        var user = db.BoardUsers.Where(
                            u => u.username == username &&
                                    u.password == password
                        ).Single();
                        loginSuccessful(user);
                        return true;
                    } catch {
                        return false;
                    }
                case "register":
                    try {
                        var newUser = new BoardUser {
                            username = username,
                            password = password,
                        };
                        db.BoardUsers.Add(newUser);
                        db.SaveChanges();
                        loginSuccessful(newUser);
                        return true;
                    } catch {
                        return false;
                    }
                default:
                    return false;
            }
        }

        private void loginSuccessful(BoardUser user) {
            HttpContext.Session.SetInt32("userId", user.Id);
            HttpContext.Session.SetString("username", user.username);
        }

    }
}
