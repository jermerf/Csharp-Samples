namespace QueueStack {
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
      this.label1 = new System.Windows.Forms.Label();
      this.listStack = new System.Windows.Forms.ListBox();
      this.listQueue = new System.Windows.Forms.ListBox();
      this.label2 = new System.Windows.Forms.Label();
      this.txtStack = new System.Windows.Forms.TextBox();
      this.txtQueue = new System.Windows.Forms.TextBox();
      this.btnPush = new System.Windows.Forms.Button();
      this.btnPop = new System.Windows.Forms.Button();
      this.btnEnQueue = new System.Windows.Forms.Button();
      this.btnDeQueue = new System.Windows.Forms.Button();
      this.btnLoad = new System.Windows.Forms.Button();
      this.btnSave = new System.Windows.Forms.Button();
      this.lblStatus = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(216, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(35, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Stack";
      // 
      // listStack
      // 
      this.listStack.FormattingEnabled = true;
      this.listStack.Location = new System.Drawing.Point(216, 25);
      this.listStack.Name = "listStack";
      this.listStack.Size = new System.Drawing.Size(198, 173);
      this.listStack.TabIndex = 1;
      // 
      // listQueue
      // 
      this.listQueue.FormattingEnabled = true;
      this.listQueue.Location = new System.Drawing.Point(12, 25);
      this.listQueue.Name = "listQueue";
      this.listQueue.Size = new System.Drawing.Size(198, 173);
      this.listQueue.TabIndex = 3;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(12, 9);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(39, 13);
      this.label2.TabIndex = 2;
      this.label2.Text = "Queue";
      // 
      // txtStack
      // 
      this.txtStack.Location = new System.Drawing.Point(216, 205);
      this.txtStack.Name = "txtStack";
      this.txtStack.Size = new System.Drawing.Size(198, 20);
      this.txtStack.TabIndex = 4;
      // 
      // txtQueue
      // 
      this.txtQueue.Location = new System.Drawing.Point(12, 204);
      this.txtQueue.Name = "txtQueue";
      this.txtQueue.Size = new System.Drawing.Size(198, 20);
      this.txtQueue.TabIndex = 5;
      // 
      // btnPush
      // 
      this.btnPush.Location = new System.Drawing.Point(216, 232);
      this.btnPush.Name = "btnPush";
      this.btnPush.Size = new System.Drawing.Size(94, 23);
      this.btnPush.TabIndex = 6;
      this.btnPush.Text = "Push";
      this.btnPush.UseVisualStyleBackColor = true;
      this.btnPush.Click += new System.EventHandler(this.btnPush_Click);
      // 
      // btnPop
      // 
      this.btnPop.Location = new System.Drawing.Point(320, 232);
      this.btnPop.Name = "btnPop";
      this.btnPop.Size = new System.Drawing.Size(94, 23);
      this.btnPop.TabIndex = 7;
      this.btnPop.Text = "Pop";
      this.btnPop.UseVisualStyleBackColor = true;
      this.btnPop.Click += new System.EventHandler(this.btnPop_Click);
      // 
      // btnEnQueue
      // 
      this.btnEnQueue.Location = new System.Drawing.Point(12, 232);
      this.btnEnQueue.Name = "btnEnQueue";
      this.btnEnQueue.Size = new System.Drawing.Size(94, 23);
      this.btnEnQueue.TabIndex = 8;
      this.btnEnQueue.Text = "EnQueue";
      this.btnEnQueue.UseVisualStyleBackColor = true;
      this.btnEnQueue.Click += new System.EventHandler(this.btnEnQueue_Click);
      // 
      // btnDeQueue
      // 
      this.btnDeQueue.Location = new System.Drawing.Point(116, 232);
      this.btnDeQueue.Name = "btnDeQueue";
      this.btnDeQueue.Size = new System.Drawing.Size(94, 23);
      this.btnDeQueue.TabIndex = 9;
      this.btnDeQueue.Text = "DeQueue";
      this.btnDeQueue.UseVisualStyleBackColor = true;
      this.btnDeQueue.Click += new System.EventHandler(this.btnDeQueue_Click);
      // 
      // btnLoad
      // 
      this.btnLoad.Location = new System.Drawing.Point(12, 261);
      this.btnLoad.Name = "btnLoad";
      this.btnLoad.Size = new System.Drawing.Size(198, 23);
      this.btnLoad.TabIndex = 10;
      this.btnLoad.Text = "Load";
      this.btnLoad.UseVisualStyleBackColor = true;
      this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
      // 
      // btnSave
      // 
      this.btnSave.Location = new System.Drawing.Point(216, 261);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new System.Drawing.Size(198, 23);
      this.btnSave.TabIndex = 11;
      this.btnSave.Text = "Save";
      this.btnSave.UseVisualStyleBackColor = true;
      this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
      // 
      // lblStatus
      // 
      this.lblStatus.AutoSize = true;
      this.lblStatus.Location = new System.Drawing.Point(12, 287);
      this.lblStatus.Name = "lblStatus";
      this.lblStatus.Size = new System.Drawing.Size(35, 13);
      this.lblStatus.TabIndex = 12;
      this.lblStatus.Text = "label3";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(426, 320);
      this.Controls.Add(this.lblStatus);
      this.Controls.Add(this.btnSave);
      this.Controls.Add(this.btnLoad);
      this.Controls.Add(this.btnDeQueue);
      this.Controls.Add(this.btnEnQueue);
      this.Controls.Add(this.btnPop);
      this.Controls.Add(this.btnPush);
      this.Controls.Add(this.txtQueue);
      this.Controls.Add(this.txtStack);
      this.Controls.Add(this.listQueue);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.listStack);
      this.Controls.Add(this.label1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "Form1";
      this.Text = "Stack/Queue";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listStack;
        private System.Windows.Forms.ListBox listQueue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtStack;
        private System.Windows.Forms.TextBox txtQueue;
        private System.Windows.Forms.Button btnPush;
        private System.Windows.Forms.Button btnPop;
        private System.Windows.Forms.Button btnEnQueue;
        private System.Windows.Forms.Button btnDeQueue;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSave;
    private System.Windows.Forms.Label lblStatus;
  }
}

