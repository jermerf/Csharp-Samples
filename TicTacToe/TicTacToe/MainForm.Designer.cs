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
      this.listScores = new System.Windows.Forms.ListView();
      this.SuspendLayout();
      // 
      // btnNewGame
      // 
      this.btnNewGame.Location = new System.Drawing.Point(12, 250);
      this.btnNewGame.Name = "btnNewGame";
      this.btnNewGame.Size = new System.Drawing.Size(194, 23);
      this.btnNewGame.TabIndex = 0;
      this.btnNewGame.Text = "New Game";
      this.btnNewGame.UseVisualStyleBackColor = true;
      this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
      // 
      // listScores
      // 
      this.listScores.HideSelection = false;
      this.listScores.Location = new System.Drawing.Point(12, 12);
      this.listScores.Name = "listScores";
      this.listScores.Size = new System.Drawing.Size(194, 232);
      this.listScores.TabIndex = 1;
      this.listScores.UseCompatibleStateImageBehavior = false;
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(219, 281);
      this.Controls.Add(this.listScores);
      this.Controls.Add(this.btnNewGame);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "MainForm";
      this.Text = "TicTacToe";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
      this.ResumeLayout(false);

    }

        #endregion

        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.ListView listScores;
    }
}

