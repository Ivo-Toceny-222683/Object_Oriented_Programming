using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV7_Comparable
{
    public class Ellipse : Object2D
    {
        public double A { get; protected set; }
        public double B { get; protected set; }

        public Ellipse(double a, double b)
        {
            this.A = (a < 0) ? 0 : a;
            this.B = (b < 0) ? 0 : b;
        }

        public override double Area()
        {
            return A * B * Math.PI;
        }

        public override string ToString()
        {
            return String.Format("Ellipse: a= {0}, b= {1}, Area={2}", A, B, this.Area());
        }
    }
}
