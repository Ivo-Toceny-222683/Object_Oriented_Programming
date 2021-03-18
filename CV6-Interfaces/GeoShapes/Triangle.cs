using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV6_Interfaces.GeoShapes
{
    public class Triangle : Object2D
    {
        public double A { get; protected set; }
        public double B { get; protected set; }
        public double C { get; protected set; }
        private readonly double s;


        public Triangle(double a, double b, double c)
        {
            this.A = a;
            this.B = b;
            this.C = c;
            s = (A + B + C) / 2;
        }

        public override double GetArea()
        {
            return Math.Sqrt(s * (s - A) * (s - B) * (s - C));
        }

        public override void Draw()
        {
            if( ((A + B) > C) && ((B + C) > A) && ((A + C) > B) )
            {
                Console.WriteLine("Triangle: a= {0}, b= {1}, c= {2}", A, B, C);
            }
            else
            {
                Console.WriteLine("Triangle: Cant draw this object.");
            }
        }
    }
}
