using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV6_Interfaces.GeoShapes
{
    class Rectangle : Object2D
    {
        private readonly double a;
        private readonly double b;

        public Rectangle(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public override double GetArea()
        {
            return a*b;
        }

        public override void Kresli()
        {
            Console.WriteLine("Rectangle: a= {0}, b= {1}", a, b);
        }
    }
}
