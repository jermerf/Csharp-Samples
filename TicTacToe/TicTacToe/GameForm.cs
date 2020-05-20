using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe {
  public partial class GameForm : Form {

    public const char X = 'X';
    public const char O = 'O';
    private Button[] buttons = new Button[9];
    private char[] board;
    private int[,] combos = new int[,] {
      {0,1,2},{3,4,5},{6,7,8}, // Horizontal Lines
      {0,3,6},{1,4,7},{2,5,8}, // Vertical Lines
      {0,4,8},{2,4,6 }  //Diagonal Lines
    };
    private char player = X;
    private SaveData save;
    private Player playerX;
    private Player playerO;

    public GameForm(SaveData save, Player x, Player o) {
      InitializeComponent();
      this.save = save;
      this.playerX = x;
      this.playerO = o;
      buttons[0] = this.button1;
      buttons[1] = this.button2;
      buttons[2] = this.button3;
      buttons[3] = this.button4;
      buttons[4] = this.button5;
      buttons[5] = this.button6;
      buttons[6] = this.button7;
      buttons[7] = this.button8;
      buttons[8] = this.button9;
      resetGame();
    }

    private void playButton_Click(object sender, EventArgs e) {
      Button btnClicked = (Button)sender;
      int playPosition = Array.IndexOf(buttons, btnClicked);
      if(play(playPosition)) {
        // Do nothing extra
      } else {
        lblStatus.Text = $"Played at position {playPosition + 1}. Now player {player}";
      }
      
    }

    // Returns true if the game is over
    // Win-Draw
    private bool play(int position) {
      if (board[position] != '-') {
        lblStatus.Text = $"You can't play at position {position},\nthat spot is taken";
        return false;
      }
      board[position] = player;
      buttons[position].Text = player.ToString();
      if (isWinner()) {
        gameWon();
        return true;
      } else if (boardFull()) {
        MessageBox.Show($"There was a Draw");
        resetGame();
        return true;
      }
      if (player == X) {
        player = O;
      } else {
        player = X;
      }
      return false;
    }

    // True if the current player is the winner
    private bool isWinner() {
      for (int i = 0; i < combos.GetLength(0); i++) {
        int p0 = combos[i, 0];
        int p1 = combos[i, 1];
        int p2 = combos[i, 2];
        if (board[p0] != '-' && board[p0] == board[p1] && board[p1] == board[p2]) {
          return true;
        }
      }
      return false;
    }

    private bool boardFull() {
      foreach(char c in board) {
        if(c == '-') {
          return false;
        }
      }
      return true;
    }

    private void gameWon() {
      if(player == X) {
        playerX.Wins++;
      }else {
        playerO.Wins++;
      }
      save.saveChanges();
      MessageBox.Show($"Player {player} won!");
      resetGame();
    }

    private void resetGame() {
      char[] newBoard = {
        '-', '-', '-',
        '-', '-', '-',
        '-', '-', '-'
      };
      board = newBoard;
      this.lblStatus.Text = "Player " + player;
      foreach(Button btn in buttons) {
        btn.Text = "";
      }
    }

    private void GameForm_Load(object sender, EventArgs e) {

    }
  }
}
