using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace MessageBoard.Pages {
    public class IndexModel : PageModel {
        
        public string Username { get; set; }

        public void OnGet() {
            Username = HttpContext.Session.GetString("username");
        }

    }
}
