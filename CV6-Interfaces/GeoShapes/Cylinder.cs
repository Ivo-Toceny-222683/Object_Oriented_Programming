using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV6_Interfaces.GeoShapes
{
    class Cylinder : Object3D
    {
        private readonly double r;
        private readonly double v;

        public Cylinder(double r, double v)
        {
            this.r = r;
            this.v = v;
        }

        public override double GetSurface()
        {
            return 2 * Math.PI * r * (r + v);
        }

        public override double GetVolume()
        {
            return Math.PI * Math.Pow(r, 2) * v;
        }

        public override void Kresli()
        {
            Console.WriteLine("Cylinder: r= {0}, v= {1}", r, v);
        }
    }
}
