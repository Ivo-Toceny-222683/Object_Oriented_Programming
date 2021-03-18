using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV6_Interfaces.GeoShapes
{
    class Ellipse : Object2D
    {
        private readonly double a;
        private readonly double b;

        public Ellipse(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public override double GetArea()
        {
            return a * b * Math.PI;
        }

        public override void Kresli()
        {
            Console.WriteLine("Ellipse: a= {0}, b= {1}", a, b);
        }
    }
}
