using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoListWebApp.Model {
    public class ToDoItem {
        public int Id { get; set; }
        public string text { get; set; }
        public bool complete { get; set; }
    }
}
