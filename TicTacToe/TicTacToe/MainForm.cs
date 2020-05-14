using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe {
  public partial class MainForm : Form {

    private GameForm game;

    public MainForm() {
      InitializeComponent();
    }

    private void MainForm_FormClosing(object sender, FormClosingEventArgs e) {

    }

    private void btnNewGame_Click(object sender, EventArgs e) {
      if(game == null) {
        game = new GameForm();
      }
      game.Visible = true;
      game.Location = new Point(game.Location.X, -600);
    }
  }
}
