using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV6_Interfaces.GeoShapes
{
    public class Circle : Object2D
    {
        public double R { get; protected set; }

        public Circle(double r)
        {
            this.R = r;
        }

        public override double GetArea()
        {
            return Math.PI * Math.Pow(R, 2);
        }

        public override void Draw()
        {
            Console.WriteLine("Circle: r= {0}", R);
        }
    }
}
