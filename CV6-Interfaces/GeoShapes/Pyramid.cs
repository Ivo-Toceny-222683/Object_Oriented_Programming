using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV6_Interfaces.GeoShapes
{
    class Pyramid : Object3D
    {
        private readonly double a;
        private readonly double b;
        private readonly double v;

        public Pyramid(double a, double b, double v)
        {
            this.a = a;
            this.b = b;
            this.v = v;
        }

        public override double GetSurface()
        {
            return (a * b + (a * Math.Sqrt(v * v + (b * b) / 4)) + (b * Math.Sqrt(v * v + (a * a) / 4)));
        }

        public override double GetVolume()
        {
            return (1/3.0)*a*b*v;
        }

        public override void Kresli()
        {
            Console.WriteLine("Pyramid: a= {0}, b= {1}, v= {2}", a, b, v);
        }
    }
}
