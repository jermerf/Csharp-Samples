namespace WebcamTracker {
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
      this.chooseCamera = new System.Windows.Forms.ComboBox();
      this.label1 = new System.Windows.Forms.Label();
      this.imgCapture = new System.Windows.Forms.PictureBox();
      this.btnCapture = new System.Windows.Forms.Button();
      this.numThreshold = new System.Windows.Forms.NumericUpDown();
      this.label2 = new System.Windows.Forms.Label();
      this.numLinkSize = new System.Windows.Forms.NumericUpDown();
      this.label3 = new System.Windows.Forms.Label();
      this.checkBlur = new System.Windows.Forms.CheckBox();
      ((System.ComponentModel.ISupportInitialize)(this.imgCapture)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numThreshold)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numLinkSize)).BeginInit();
      this.SuspendLayout();
      // 
      // chooseCamera
      // 
      this.chooseCamera.FormattingEnabled = true;
      this.chooseCamera.Location = new System.Drawing.Point(62, 10);
      this.chooseCamera.Name = "chooseCamera";
      this.chooseCamera.Size = new System.Drawing.Size(594, 21);
      this.chooseCamera.TabIndex = 0;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(13, 13);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(46, 13);
      this.label1.TabIndex = 1;
      this.label1.Text = "Camera:";
      // 
      // imgCapture
      // 
      this.imgCapture.Location = new System.Drawing.Point(16, 66);
      this.imgCapture.Name = "imgCapture";
      this.imgCapture.Size = new System.Drawing.Size(1130, 636);
      this.imgCapture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.imgCapture.TabIndex = 2;
      this.imgCapture.TabStop = false;
      // 
      // btnCapture
      // 
      this.btnCapture.Location = new System.Drawing.Point(16, 37);
      this.btnCapture.Name = "btnCapture";
      this.btnCapture.Size = new System.Drawing.Size(75, 23);
      this.btnCapture.TabIndex = 3;
      this.btnCapture.Text = "Capture";
      this.btnCapture.UseVisualStyleBackColor = true;
      this.btnCapture.Click += new System.EventHandler(this.btnCapture_Click);
      // 
      // numThreshold
      // 
      this.numThreshold.Location = new System.Drawing.Point(167, 39);
      this.numThreshold.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
      this.numThreshold.Name = "numThreshold";
      this.numThreshold.Size = new System.Drawing.Size(56, 20);
      this.numThreshold.TabIndex = 4;
      this.numThreshold.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(104, 42);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(57, 13);
      this.label2.TabIndex = 5;
      this.label2.Text = "Threshold:";
      // 
      // numLinkSize
      // 
      this.numLinkSize.Location = new System.Drawing.Point(339, 40);
      this.numLinkSize.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
      this.numLinkSize.Name = "numLinkSize";
      this.numLinkSize.Size = new System.Drawing.Size(56, 20);
      this.numLinkSize.TabIndex = 8;
      this.numLinkSize.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(266, 41);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(67, 13);
      this.label3.TabIndex = 9;
      this.label3.Text = "Linking Size:";
      // 
      // checkBlur
      // 
      this.checkBlur.AutoSize = true;
      this.checkBlur.Location = new System.Drawing.Point(417, 41);
      this.checkBlur.Name = "checkBlur";
      this.checkBlur.Size = new System.Drawing.Size(77, 17);
      this.checkBlur.TabIndex = 10;
      this.checkBlur.Text = "Blur Edges";
      this.checkBlur.UseVisualStyleBackColor = true;
      this.checkBlur.CheckedChanged += new System.EventHandler(this.checkBlur_CheckedChanged);
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1159, 715);
      this.Controls.Add(this.checkBlur);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.numLinkSize);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.numThreshold);
      this.Controls.Add(this.btnCapture);
      this.Controls.Add(this.imgCapture);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.chooseCamera);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "MainForm";
      this.Text = "Webcam Tracker";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
      this.Load += new System.EventHandler(this.MainForm_Load);
      ((System.ComponentModel.ISupportInitialize)(this.imgCapture)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numThreshold)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numLinkSize)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

        #endregion

        private System.Windows.Forms.ComboBox chooseCamera;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox imgCapture;
        private System.Windows.Forms.Button btnCapture;
        private System.Windows.Forms.NumericUpDown numThreshold;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numLinkSize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBlur;
    }
}

