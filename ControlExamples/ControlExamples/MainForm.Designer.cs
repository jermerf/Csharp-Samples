namespace ControlExamples {
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
      this.button1 = new System.Windows.Forms.Button();
      this.txtSendToUtils = new System.Windows.Forms.TextBox();
      this.lblStatus = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(12, 12);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(75, 23);
      this.button1.TabIndex = 0;
      this.button1.Text = "Utilities";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.utilities_Clicked);
      // 
      // txtSendToUtils
      // 
      this.txtSendToUtils.Location = new System.Drawing.Point(93, 15);
      this.txtSendToUtils.Name = "txtSendToUtils";
      this.txtSendToUtils.Size = new System.Drawing.Size(139, 20);
      this.txtSendToUtils.TabIndex = 1;
      // 
      // lblStatus
      // 
      this.lblStatus.AutoSize = true;
      this.lblStatus.Location = new System.Drawing.Point(12, 38);
      this.lblStatus.Name = "lblStatus";
      this.lblStatus.Size = new System.Drawing.Size(37, 13);
      this.lblStatus.TabIndex = 2;
      this.lblStatus.Text = "Status";
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(447, 88);
      this.Controls.Add(this.lblStatus);
      this.Controls.Add(this.txtSendToUtils);
      this.Controls.Add(this.button1);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "MainForm";
      this.Text = "Main Window";
      this.Load += new System.EventHandler(this.MainForm_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

        #endregion

        private System.Windows.Forms.Button button1;
    private System.Windows.Forms.TextBox txtSendToUtils;
        private System.Windows.Forms.Label lblStatus;
    }
}

