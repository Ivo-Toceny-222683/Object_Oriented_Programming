using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV6_Interfaces.GeoShapes
{
    public class Rectangle : Object2D
    {
        public double A { get; protected set; }
        public double B { get; protected set; }

        public Rectangle(double a, double b)
        {
            this.A = a;
            this.B = b;
        }

        public override double GetArea()
        {
            return A*B;
        }

        public override void Draw()
        {
            Console.WriteLine("Rectangle: a= {0}, b= {1}", A, B);
        }
    }
}
