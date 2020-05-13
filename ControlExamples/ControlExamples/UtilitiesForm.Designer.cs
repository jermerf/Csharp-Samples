namespace ControlExamples {
  partial class UtilitiesForm {
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
      System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
      System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
      System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
      this.button1 = new System.Windows.Forms.Button();
      this.btnOpen = new System.Windows.Forms.Button();
      this.lblImageFile = new System.Windows.Forms.Label();
      this.imgFile = new System.Windows.Forms.PictureBox();
      this.button2 = new System.Windows.Forms.Button();
      this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
      ((System.ComponentModel.ISupportInitialize)(this.imgFile)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
      this.SuspendLayout();
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(12, 189);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(75, 23);
      this.button1.TabIndex = 0;
      this.button1.Text = "<- Back";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.back_Click);
      // 
      // btnOpen
      // 
      this.btnOpen.Location = new System.Drawing.Point(12, 12);
      this.btnOpen.Name = "btnOpen";
      this.btnOpen.Size = new System.Drawing.Size(75, 23);
      this.btnOpen.TabIndex = 1;
      this.btnOpen.Text = "Open";
      this.btnOpen.UseVisualStyleBackColor = true;
      this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
      // 
      // lblImageFile
      // 
      this.lblImageFile.AutoSize = true;
      this.lblImageFile.Location = new System.Drawing.Point(93, 17);
      this.lblImageFile.Name = "lblImageFile";
      this.lblImageFile.Size = new System.Drawing.Size(29, 13);
      this.lblImageFile.TabIndex = 2;
      this.lblImageFile.Text = "File: ";
      // 
      // imgFile
      // 
      this.imgFile.Location = new System.Drawing.Point(12, 41);
      this.imgFile.Name = "imgFile";
      this.imgFile.Size = new System.Drawing.Size(195, 142);
      this.imgFile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.imgFile.TabIndex = 3;
      this.imgFile.TabStop = false;
      // 
      // button2
      // 
      this.button2.Location = new System.Drawing.Point(346, 7);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(75, 23);
      this.button2.TabIndex = 4;
      this.button2.Text = "OkCancel";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.messageBoxOkCancel_Click);
      // 
      // chart1
      // 
      chartArea1.Name = "ChartArea1";
      this.chart1.ChartAreas.Add(chartArea1);
      legend1.Name = "Legend1";
      this.chart1.Legends.Add(legend1);
      this.chart1.Location = new System.Drawing.Point(232, 36);
      this.chart1.Name = "chart1";
      series1.ChartArea = "ChartArea1";
      series1.Legend = "Legend1";
      series1.Name = "Series1";
      this.chart1.Series.Add(series1);
      this.chart1.Size = new System.Drawing.Size(314, 294);
      this.chart1.TabIndex = 5;
      this.chart1.Text = "chart1";
      this.chart1.Click += new System.EventHandler(this.chart1_Click);
      // 
      // UtilitiesForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(558, 342);
      this.ControlBox = false;
      this.Controls.Add(this.chart1);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.imgFile);
      this.Controls.Add(this.lblImageFile);
      this.Controls.Add(this.btnOpen);
      this.Controls.Add(this.button1);
      this.Name = "UtilitiesForm";
      this.Text = "Utilities";
      ((System.ComponentModel.ISupportInitialize)(this.imgFile)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Label lblImageFile;
        private System.Windows.Forms.PictureBox imgFile;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}