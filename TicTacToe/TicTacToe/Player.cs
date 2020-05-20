using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe{
  [Serializable]
  public class Player: IComparable<Player> {

    public string Name { get; set; }
    public int Wins { get; set; } = 0;

    public Player(string name) {
      Name = name;
    }

    public int CompareTo(Player other) {
      if (other.Wins > Wins) {
        return 1;
      } else if (other.Wins < Wins) {
        return -1;
      } else {
        return 0;
      }
    }

    
    public override string ToString() {
      return Name + ": " + Wins;
    }
  }

  
}
