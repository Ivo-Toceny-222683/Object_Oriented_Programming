using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV7_Comparable
{
    public class Rectangle : Object2D
    {
        public double A { get; protected set; }
        public double B { get; protected set; }

        public Rectangle(double a, double b)
        {
            this.A = (a < 0) ? 0 : a;
            this.B = (b < 0) ? 0 : b;
        }

        public override double Area()
        {
            return A * B;
        }

        public override string ToString()
        {
            return String.Format($"Rectangle: a= {A}, b= {B}, Area={this.Area()}");
        }
    }
}
