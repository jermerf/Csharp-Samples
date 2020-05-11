using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormIntro {
  public partial class Form1 : Form {
    public Form1() {
      InitializeComponent();
    }

    private void change_Click(object sender, EventArgs e) {
      this.Text = txtTitle.Text;
    }

    private void addStudent_Click(object sender, EventArgs e) {
      listStudent.Items.Add(txtStudent.Text);
    }
  }
}
