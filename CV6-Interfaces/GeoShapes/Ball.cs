using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV6_Interfaces.GeoShapes
{
    class Ball : Object3D
    {
        private readonly double r;

        public Ball(double r)
        {
            this.r = r;
        }

        public override double GetSurface()
        {
            return 4 * Math.PI * r * r;
        }

        public override double GetVolume()
        {
            return (4/3.0) * Math.PI * Math.Pow(r, 3);
        }

        public override void Kresli()
        {
            Console.WriteLine("Ball: r= {0}", r);
        }
    }
}
