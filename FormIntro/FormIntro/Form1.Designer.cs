namespace FormIntro {
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
      this.btnChange = new System.Windows.Forms.Button();
      this.txtTitle = new System.Windows.Forms.TextBox();
      this.listStudent = new System.Windows.Forms.ListBox();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.txtStudent = new System.Windows.Forms.TextBox();
      this.button2 = new System.Windows.Forms.Button();
      this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
      this.webBrowser1 = new System.Windows.Forms.WebBrowser();
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.SuspendLayout();
      // 
      // btnChange
      // 
      this.btnChange.Location = new System.Drawing.Point(6, 19);
      this.btnChange.Name = "btnChange";
      this.btnChange.Size = new System.Drawing.Size(131, 23);
      this.btnChange.TabIndex = 0;
      this.btnChange.Text = "Change";
      this.btnChange.UseVisualStyleBackColor = true;
      this.btnChange.Click += new System.EventHandler(this.change_Click);
      // 
      // txtTitle
      // 
      this.txtTitle.Location = new System.Drawing.Point(143, 19);
      this.txtTitle.Name = "txtTitle";
      this.txtTitle.Size = new System.Drawing.Size(100, 20);
      this.txtTitle.TabIndex = 1;
      // 
      // listStudent
      // 
      this.listStudent.FormattingEnabled = true;
      this.listStudent.Location = new System.Drawing.Point(6, 48);
      this.listStudent.Name = "listStudent";
      this.listStudent.Size = new System.Drawing.Size(237, 95);
      this.listStudent.TabIndex = 2;
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.btnChange);
      this.groupBox1.Controls.Add(this.txtTitle);
      this.groupBox1.Location = new System.Drawing.Point(12, 13);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(265, 60);
      this.groupBox1.TabIndex = 3;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Change Title";
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.txtStudent);
      this.groupBox2.Controls.Add(this.button2);
      this.groupBox2.Controls.Add(this.listStudent);
      this.groupBox2.Location = new System.Drawing.Point(12, 79);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(265, 160);
      this.groupBox2.TabIndex = 4;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Students";
      // 
      // txtStudent
      // 
      this.txtStudent.Location = new System.Drawing.Point(143, 19);
      this.txtStudent.Name = "txtStudent";
      this.txtStudent.Size = new System.Drawing.Size(100, 20);
      this.txtStudent.TabIndex = 4;
      // 
      // button2
      // 
      this.button2.Location = new System.Drawing.Point(6, 19);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(131, 23);
      this.button2.TabIndex = 3;
      this.button2.Text = "Add";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.addStudent_Click);
      // 
      // dateTimePicker1
      // 
      this.dateTimePicker1.Location = new System.Drawing.Point(283, 13);
      this.dateTimePicker1.Name = "dateTimePicker1";
      this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
      this.dateTimePicker1.TabIndex = 5;
      // 
      // webBrowser1
      // 
      this.webBrowser1.Location = new System.Drawing.Point(284, 39);
      this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
      this.webBrowser1.Name = "webBrowser1";
      this.webBrowser1.Size = new System.Drawing.Size(421, 250);
      this.webBrowser1.TabIndex = 6;
      this.webBrowser1.Url = new System.Uri("https://jermerf.com/media", System.UriKind.Absolute);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(764, 332);
      this.Controls.Add(this.webBrowser1);
      this.Controls.Add(this.dateTimePicker1);
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.groupBox1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "Form1";
      this.Text = "My C# Awesome Window";
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.TextBox txtTitle;
    private System.Windows.Forms.ListBox listStudent;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.TextBox txtStudent;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.DateTimePicker dateTimePicker1;
    private System.Windows.Forms.WebBrowser webBrowser1;
  }
}

