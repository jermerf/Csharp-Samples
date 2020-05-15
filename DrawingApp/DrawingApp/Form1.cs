using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DrawingApp {
  public partial class Form1 : Form {
    public Form1() {
      InitializeComponent();
      bmp = new Bitmap(imgCanvas.Size.Width, imgCanvas.Size.Height);
      spaceObjects.Add(new SpaceObject());
      spaceObjects.Add(new SpaceObject(100, 100));
      spaceObjects.Add(new SpaceObject(100, 200));
      spaceObjects.Add(new SpaceObject(200, 100));
      spaceObjects.Add(new SpaceObject(200, 400));

      spaceObjects.Add(new SpaceObject(0, 0));
      var secondObj = new SpaceObject(350, 200);
      secondObj.vy = 1;
      spaceObjects.Add(secondObj);
    }

    Pen pen = new Pen(Color.Black, 1);
    Bitmap bmp;
    Image cat = Image.FromFile("../../cat.bmp");

    List<SpaceObject> spaceObjects = new List<SpaceObject>();

    private void timer_Tick(object sender, EventArgs e) {
      updateSpaceObjects();
      drawSpaceObjects();
    }

    private void updateSpaceObjects() {
      foreach (SpaceObject obj in spaceObjects) {
        obj.updateVelocities(spaceObjects, timer.Interval);
        obj.x += obj.vx;
        obj.y += obj.vy;
      }
    }

    private void drawSpaceObjects() {
      Graphics g = Graphics.FromImage(bmp);
      g.Clear(Color.Empty);
      foreach(SpaceObject obj in spaceObjects) {
        //g.DrawArc(pen, (int)obj.x, (int)obj.y, obj.radius*2, obj.radius * 2, 0, 360);
        g.DrawImage(cat, (int)obj.x, (int)obj.y, obj.radius * 2, obj.radius * 2);
        g.DrawString("vx: " + obj.vx, new Font("Arial", 10), pen.Brush, (int)obj.x + obj.radius * 2, (int)obj.y);
      }
      
      imgCanvas.Image = bmp;
    }

    private void Form1_Load(object sender, EventArgs e) {
      this.Location = new Point(Location.X, -600);
    }
  }
}
