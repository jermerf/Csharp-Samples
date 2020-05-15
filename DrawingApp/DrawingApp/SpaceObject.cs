using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingApp {
  class SpaceObject {
    public int radius { get; set; } = 10;
    public double x { get; set; } = 300;
    public double y { get; set; } = 300;
    public double vx { get; set; } = 0;
    public double vy { get; set; } = 0;
    double mass = 1000000000;

    public SpaceObject() { }

    public SpaceObject(int x, int y) {
      this.x = x;
      this.y = y;
    }
    public SpaceObject(int x, int y, double mass) : this(x, y) {
      this.mass = mass;
    }
    public SpaceObject(int x, int y, double mass, int vx, int vy) : this(x, y, mass) {
      this.vx = vx;
      this.vy = vy;
    }

    public void updateVelocities(List<SpaceObject> spaceObjects, int time) {
      double fx = 0;
      double fy = 0;
      foreach (SpaceObject o in spaceObjects) {
        if (o == this) continue;
        
        double dx = o.x - x;
        double dy = o.y - y;
        double r = Math.Sqrt(dx * dx + dy * dy);
        double fg = gravForce(mass, o.mass, r);
        double angle = Math.Atan2(dy, dx);
        fx += fg * Math.Cos(angle);
        fy += fg * Math.Sin(angle);
      }
      vx += (time / 1000.0) * fx / mass;
      vy += (time / 1000.0) * fy / mass;
    }

    private double gravForce(double m1, double m2, double r) {
      double G = 0.00000667;
      return G * m1 * m2 / (r * r);
    }

  }
}
