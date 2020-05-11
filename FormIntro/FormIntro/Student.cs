using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormIntro {
  class Student {
    private string name;

    public string Name {
      get {
        return name;
      }
      set {
        if(value == null || value.Length == 0) {
          throw new Exception("Bad value, need a name");
        }
        this.name = value;
      }
    }

    public int Age { get; set; }

    public Student(string name) {
      Name = name;
    }
  }
}
