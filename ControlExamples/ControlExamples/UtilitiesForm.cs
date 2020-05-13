using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlExamples {
  public partial class UtilitiesForm : Form {
    private string message;

    public UtilitiesForm(string message) {
      InitializeComponent();
      this.message = message;
      this.Text = message;
    }

    private void back_Click(object sender, EventArgs e) {
      this.Hide();
    }

    private void btnOpen_Click(object sender, EventArgs e) {
      OpenFileDialog dialog = new OpenFileDialog();
      DialogResult result = dialog.ShowDialog();
      if (File.Exists(dialog.FileName)) {
        imgFile.Image = Image.FromFile(dialog.FileName);
      }
    }

    private void messageBoxOkCancel_Click(object sender, EventArgs e) {
      DialogResult result = MessageBox.Show(
        "It is ok?",
        "Hey you!",
        MessageBoxButtons.OKCancel);

      if (result == DialogResult.OK) {
        MessageBox.Show("Ok, cool");
      } else {
        MessageBox.Show("Well that aint not good, isn't it?");
      }
    }

    private void chart1_Click(object sender, EventArgs e) {
       
    }
  }
}
