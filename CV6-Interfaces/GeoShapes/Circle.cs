using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV6_Interfaces.GeoShapes
{
    class Circle : Object2D
    {
        private readonly double r;
        
        public Circle(double r)
        {
            this.r = r;
        }

        public override double GetArea()
        {
            return Math.PI * Math.Pow(r, 2);
        }

        public override void Kresli()
        {
            Console.WriteLine("Circle: r= {0}", r);
        }
    }
}
