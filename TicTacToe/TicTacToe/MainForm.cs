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

    public MainForm() {
      InitializeComponent();
      save = SaveData.load();
      save.Players.Sort();
      foreach (Player p in save.Players) {
        selectX.Items.Add(p.Name);
        selectO.Items.Add(p.Name);
      }
      listScores.DataSource = save.Players;
    }

    private GameForm game;
    private SaveData save;

    private void btnNewGame_Click(object sender, EventArgs e) {
      if(selectX.SelectedIndex < 0 || selectO.SelectedIndex < 0) {
        MessageBox.Show("You must select two different players");
        return;
      }
      Player x = save.Players[selectX.SelectedIndex];
      Player o = save.Players[selectO.SelectedIndex];
      if (x == o) {
        MessageBox.Show("You can't play against yourself");
        return;
      }

      if (game == null) {
        game = new GameForm(save, x, o);
      }
      game.Visible = true;
      game.Location = new Point(game.Location.X, -600);
    }

    private void btnAddPlayer_Click(object sender, EventArgs e) {
      btnAddPlayer.Visible = false;
      txtAddPlayer.Visible = true;
      txtAddPlayer.Focus();
      btnAddPlayerCancel.Visible = true;
    }

    private void btnAddPlayerCancel_Click(object sender, EventArgs e) {
      btnAddPlayer.Visible = true;
      txtAddPlayer.Visible = false;
      btnAddPlayerCancel.Visible = false;
      txtAddPlayer.Text = "";
    }

    private void txtAddPlayer_KeyPress(object sender, KeyPressEventArgs e) {
      if(e.KeyChar == '\r') {
        save.Players.Add(new Player(txtAddPlayer.Text));
        save.saveChanges();
        selectX.Items.Add(txtAddPlayer.Text);
        selectO.Items.Add(txtAddPlayer.Text);
        
        btnAddPlayerCancel_Click(null, null);
      }
    }

    private void MainForm_Load(object sender, EventArgs e) {
      Location = new Point(Location.X, -600);
    }

  }
}
