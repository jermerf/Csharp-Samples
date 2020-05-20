namespace TicTacToe {
  partial class MainForm {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
      this.btnNewGame = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.selectX = new System.Windows.Forms.ComboBox();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.selectO = new System.Windows.Forms.ComboBox();
      this.btnAddPlayer = new System.Windows.Forms.Button();
      this.txtAddPlayer = new System.Windows.Forms.TextBox();
      this.btnAddPlayerCancel = new System.Windows.Forms.Button();
      this.listScores = new System.Windows.Forms.ListBox();
      this.SuspendLayout();
      // 
      // btnNewGame
      // 
      this.btnNewGame.Location = new System.Drawing.Point(12, 313);
      this.btnNewGame.Name = "btnNewGame";
      this.btnNewGame.Size = new System.Drawing.Size(194, 23);
      this.btnNewGame.TabIndex = 0;
      this.btnNewGame.Text = "&New Game";
      this.btnNewGame.UseVisualStyleBackColor = true;
      this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 13);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(65, 13);
      this.label1.TabIndex = 2;
      this.label1.Text = "High Scores";
      // 
      // selectX
      // 
      this.selectX.FormattingEnabled = true;
      this.selectX.Location = new System.Drawing.Point(12, 224);
      this.selectX.Name = "selectX";
      this.selectX.Size = new System.Drawing.Size(194, 21);
      this.selectX.TabIndex = 3;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(12, 208);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(14, 13);
      this.label2.TabIndex = 4;
      this.label2.Text = "X";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(12, 252);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(15, 13);
      this.label3.TabIndex = 6;
      this.label3.Text = "O";
      // 
      // selectO
      // 
      this.selectO.FormattingEnabled = true;
      this.selectO.Location = new System.Drawing.Point(12, 268);
      this.selectO.Name = "selectO";
      this.selectO.Size = new System.Drawing.Size(194, 21);
      this.selectO.TabIndex = 5;
      // 
      // btnAddPlayer
      // 
      this.btnAddPlayer.Location = new System.Drawing.Point(54, 183);
      this.btnAddPlayer.Name = "btnAddPlayer";
      this.btnAddPlayer.Size = new System.Drawing.Size(109, 23);
      this.btnAddPlayer.TabIndex = 7;
      this.btnAddPlayer.Text = "Add &Player";
      this.btnAddPlayer.UseVisualStyleBackColor = true;
      this.btnAddPlayer.Click += new System.EventHandler(this.btnAddPlayer_Click);
      // 
      // txtAddPlayer
      // 
      this.txtAddPlayer.Location = new System.Drawing.Point(12, 185);
      this.txtAddPlayer.Name = "txtAddPlayer";
      this.txtAddPlayer.Size = new System.Drawing.Size(130, 20);
      this.txtAddPlayer.TabIndex = 8;
      this.txtAddPlayer.Visible = false;
      this.txtAddPlayer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAddPlayer_KeyPress);
      // 
      // btnAddPlayerCancel
      // 
      this.btnAddPlayerCancel.Location = new System.Drawing.Point(148, 183);
      this.btnAddPlayerCancel.Name = "btnAddPlayerCancel";
      this.btnAddPlayerCancel.Size = new System.Drawing.Size(58, 23);
      this.btnAddPlayerCancel.TabIndex = 9;
      this.btnAddPlayerCancel.Text = "Cancel";
      this.btnAddPlayerCancel.UseVisualStyleBackColor = true;
      this.btnAddPlayerCancel.Visible = false;
      this.btnAddPlayerCancel.Click += new System.EventHandler(this.btnAddPlayerCancel_Click);
      // 
      // listScores
      // 
      this.listScores.FormattingEnabled = true;
      this.listScores.Location = new System.Drawing.Point(12, 29);
      this.listScores.Name = "listScores";
      this.listScores.Size = new System.Drawing.Size(195, 147);
      this.listScores.TabIndex = 10;
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(219, 345);
      this.Controls.Add(this.listScores);
      this.Controls.Add(this.btnAddPlayer);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.selectO);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.selectX);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.btnNewGame);
      this.Controls.Add(this.txtAddPlayer);
      this.Controls.Add(this.btnAddPlayerCancel);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "MainForm";
      this.Text = "TicTacToe";
      this.Load += new System.EventHandler(this.MainForm_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

        #endregion

        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox selectX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox selectO;
        private System.Windows.Forms.Button btnAddPlayer;
        private System.Windows.Forms.TextBox txtAddPlayer;
        private System.Windows.Forms.Button btnAddPlayerCancel;
        private System.Windows.Forms.ListBox listScores;
    }
}

