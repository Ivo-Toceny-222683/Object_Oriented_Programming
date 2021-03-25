using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV7_Comparable
{
    class Circle : Object2D
    {
        public double R { get; protected set; }

        public Circle(double r)
        {
            this.R = r;
        }

        public override double Area()
        {
            return Math.PI * Math.Pow(R, 2);
        }

        public override string ToString()
        {
            return String.Format("Circle: r= {0}, Area={1}", R, this.Area());
        }
    }
}
