using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlExamples {
  public partial class MainForm : Form {

    UtilitiesForm utils;

    public MainForm() {
      InitializeComponent();
    }

    private void utilities_Clicked(object sender, EventArgs e) {
      if(utils == null) {
        // Utils not made yet, so make it
        utils = new UtilitiesForm(txtSendToUtils.Text);
      }
      utils.Visible = !utils.Visible;
      utils.Location = this.Location;
    }

    private void MainForm_Load(object sender, EventArgs e) {
      this.Location = new Point(100, -600);
    }
  }
}
