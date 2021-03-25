using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV7_Comparable
{
    class Rectangle : Object2D
    {
        public double A { get; protected set; }
        public double B { get; protected set; }

        public Rectangle(double a, double b)
        {
            this.A = a;
            this.B = b;
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
