using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV7_Comparable
{
    abstract class Object2D : I2D, IComparable
    {
        public abstract double Area();

        public int CompareTo(Object obj)
        {
            double size = ((Object2D)obj).Area() - this.Area();
            if (size < 0)
            {
                return 1;
            }
            if(size == 0)
            {
                return 0;
            }
            return -1;
            
        }
    }
}
