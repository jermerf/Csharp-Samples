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

      lblStatus.MouseMove += lblStatus_MouseMove;
      this.MouseMove += lblStatus_MouseMove;
      txtSendToUtils.KeyPress += txtInput_keyPress;
      txtSendToUtils.KeyDown += txtInput_keyDown;
      txtSendToUtils.KeyUp += txtInput_keyUp;
    }


    private void lblStatus_MouseMove(object sender, MouseEventArgs e) {
      lblStatus.Text = e.X + ", " + e.Y;
    }

    char pressedChar;
    int repeatCount = 0;
    private void txtInput_keyPress(object sender, KeyPressEventArgs e) {
      if (e.KeyChar == pressedChar) {
        repeatCount++;
      } else {
        repeatCount = 0;
      }
      pressedChar = e.KeyChar;
      Console.WriteLine("Pressed " + pressedChar + ": " + repeatCount);
    }

    Keys pressedKey = Keys.None;

    private void txtInput_keyDown(object sender, KeyEventArgs e) {
      if (e.KeyCode == pressedKey) {
        repeatCount++;
      } else {
        repeatCount = 0;
      }
      pressedKey = e.KeyCode;
      Console.WriteLine("Down " + pressedKey + ": " + repeatCount);
    }
    private void txtInput_keyUp(object sender, KeyEventArgs e) {
      if (e.KeyCode == pressedKey) {
        repeatCount++;
      } else {
        repeatCount = 0;
      }
      pressedKey = e.KeyCode;
      Console.WriteLine("Up " + pressedKey + ": " + repeatCount);
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
