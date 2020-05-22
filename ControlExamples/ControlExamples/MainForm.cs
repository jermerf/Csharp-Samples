using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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

    
    private void timerFrameCounter_Tick(object sender, EventArgs e) {
      this.Refresh();
    }

    private void moveTree(int speed) {
      imgTree.Left -= speed;
      if (imgTree.Left < -imgTree.Width) {
        imgTree.Left = this.Width + imgTree.Width;
      }
    }
    
    int baseSpeed = 15;
    // Measured in 0.000 000 1 seconds or /10,000 to get miliseconds
    long lastTime = DateTime.UtcNow.Ticks;
    private void MainForm_Paint(object sender, PaintEventArgs e) {
      long now = DateTime.UtcNow.Ticks;
      double dt = (now - lastTime) / 10000.0;

      lastTime = now;
      Console.WriteLine(dt);
      double scaleFactor = dt / timerFrameCounter.Interval;
      int speed = Convert.ToInt32(baseSpeed * scaleFactor);
      moveTree(speed);
    }
  }
}
