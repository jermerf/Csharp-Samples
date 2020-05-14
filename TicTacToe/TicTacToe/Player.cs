using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe {
  class Player {
    private string name { get; }
    private int score { get; set; }

    public Player(string name, int score) {
      this.name = name;
      this.score = score;
    }
  }
}
