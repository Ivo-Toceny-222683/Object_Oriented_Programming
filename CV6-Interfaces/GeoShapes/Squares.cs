using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV6_Interfaces.GeoShapes
{
    class Squares : Object3D
    {
        private readonly double a;
        private readonly double b;
        private readonly double c;

        public Squares(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public override double GetSurface()
        {
            return a*b*2 + a*c*2;
        }

        public override double GetVolume()
        {
            return a * b * c;
        }

        public override void Kresli()
        {
            Console.WriteLine("Squares: a= {0}, b= {1}, c= {2}", a, b, c);
        }
    }
}
