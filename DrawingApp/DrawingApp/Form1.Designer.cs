﻿namespace DrawingApp {
  partial class Form1 {
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
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
      this.imgCanvas = new System.Windows.Forms.PictureBox();
      this.timer = new System.Windows.Forms.Timer(this.components);
      ((System.ComponentModel.ISupportInitialize)(this.imgCanvas)).BeginInit();
      this.SuspendLayout();
      // 
      // imgCanvas
      // 
      this.imgCanvas.Location = new System.Drawing.Point(0, 0);
      this.imgCanvas.Name = "imgCanvas";
      this.imgCanvas.Size = new System.Drawing.Size(698, 414);
      this.imgCanvas.TabIndex = 0;
      this.imgCanvas.TabStop = false;
      // 
      // timer
      // 
      this.timer.Enabled = true;
      this.timer.Interval = 30;
      this.timer.Tick += new System.EventHandler(this.timer_Tick);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(698, 414);
      this.Controls.Add(this.imgCanvas);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "Form1";
      this.Text = "Drawing";
      this.Load += new System.EventHandler(this.Form1_Load);
      ((System.ComponentModel.ISupportInitialize)(this.imgCanvas)).EndInit();
      this.ResumeLayout(false);

    }

        #endregion

        private System.Windows.Forms.PictureBox imgCanvas;
        private System.Windows.Forms.Timer timer;
    }
}

