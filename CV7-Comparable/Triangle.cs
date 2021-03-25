using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV7_Comparable
{
    class Triangle : Object2D
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

        public override double Area()
        {
            if (((A + B) > C) && ((B + C) > A) && ((A + C) > B))
            {
                return Math.Sqrt(s * (s - A) * (s - B) * (s - C));
            }
            else
            {
                return 0;
            }

        }

        public override string ToString()
        {
            if (((A + B) > C) && ((B + C) > A) && ((A + C) > B))
            {
                return String.Format("Triangle: a= {0}, b= {1}, c= {2}, Area={3}", A, B, C, this.Area());
            }
            else
            {
                return String.Format("Triangle: Cant draw this object.");
            }
        }
    }
}
