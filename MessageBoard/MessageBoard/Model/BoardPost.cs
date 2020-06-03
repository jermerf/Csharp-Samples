using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MessageBoard.Model {
    public class BoardPost {
        public int Id { get; set; }
        public int userId { get; set; }
        public string content { get; set; }
        public DateTime postedOn { get; set; }
    }
}
