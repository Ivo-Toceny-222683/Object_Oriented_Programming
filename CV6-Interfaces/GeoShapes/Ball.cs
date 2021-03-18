using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV6_Interfaces.GeoShapes
{
    public class Ball : Object3D
    {
        public double R { get; protected set; }

        public Ball(double r)
        {
            this.R = r;
        }

        public override double GetSurface()
        {
            return 4 * Math.PI * R * R;
        }

        public override double GetVolume()
        {
            return (4/3.0) * Math.PI * Math.Pow(R, 3);
        }

        public override void Draw()
        {
            Console.WriteLine("Ball: r= {0}", R);
        }
    }
}
