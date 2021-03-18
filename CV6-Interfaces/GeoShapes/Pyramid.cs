using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV6_Interfaces.GeoShapes
{
    public class Pyramid : Object3D
    {
        public double A { get; protected set; }
        public double B { get; protected set; }
        public double V { get; protected set; }

        public Pyramid(double a, double b, double v)
        {
            this.A = a;
            this.B = b;
            this.V = v;
        }

        public override double GetSurface()
        {
            return (A * B + (A * Math.Sqrt(V * V + (B * B) / 4)) + (B * Math.Sqrt(V * V + (A * A) / 4)));
        }

        public override double GetVolume()
        {
            return (1/3.0)*A*B*V;
        }

        public override void Draw()
        {
            Console.WriteLine("Pyramid: a= {0}, b= {1}, v= {2}", A, B, V);
        }
    }
}
