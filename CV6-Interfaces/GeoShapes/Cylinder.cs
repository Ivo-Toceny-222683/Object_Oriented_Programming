using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV6_Interfaces.GeoShapes
{
    public class Cylinder : Object3D
    {
        public double R { get; protected set; }
        public double V { get; protected set; }

        public Cylinder(double r, double v)
        {
            this.R = r;
            this.V = v;
        }

        public override double GetSurface()
        {
            return 2 * Math.PI * R * (R + V);
        }

        public override double GetVolume()
        {
            return Math.PI * Math.Pow(R, 2) * V;
        }

        public override void Draw()
        {
            Console.WriteLine("Cylinder: r= {0}, v= {1}", R, V);
        }
    }
}
