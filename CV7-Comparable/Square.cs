using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV7_Comparable
{
    public class Square : Object2D
    {
        public double A { get; protected set; }

        public Square(double a)
        {
            this.A = (a < 0) ? 0 : a;
        }

        public override double Area()
        {
            return A * A;
        }

        public override string ToString()
        {
            return String.Format($"Squares: a= {A},  Area={this.Area()}");
        }
    }
}
