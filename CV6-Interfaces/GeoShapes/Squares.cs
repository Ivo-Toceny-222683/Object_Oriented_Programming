using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV6_Interfaces.GeoShapes
{
    public class Squares : Object3D
    {
        public double A { get; protected set; }
        public double B { get; protected set; }
        public double C { get; protected set; }

        public Squares(double a, double b, double c)
        {
            this.A = a;
            this.B = b;
            this.C = c;
        }

        public override double GetSurface()
        {
            return A*B*2 + A*C*2;
        }

        public override double GetVolume()
        {
            return A * B * C;
        }

        public override void Draw()
        {
            Console.WriteLine("Squares: a= {0}, b= {1}, c= {2}", A, B, C);
        }
    }
}
