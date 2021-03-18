using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV6_Interfaces.GeoShapes
{
    class Triangle : Object2D
    {
        private readonly double a;
        private readonly double b;
        private readonly double c;
        private readonly double s;


        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            s = (a + b + c) / 2;
        }

        public override double GetArea()
        {
            return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        }

        public override void Kresli()
        {
            Console.WriteLine("Triangle: a= {0}, b= {1}, c= {2}", a, b, c);
        }
    }
}
