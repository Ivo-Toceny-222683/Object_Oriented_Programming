using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV7_Comparable
{
    public abstract class Object2D : I2D, IComparable
    {
        public abstract double Area();

        public int CompareTo(object obj)
        {
            if(obj == null)
            {
                return 1;
            }
            try
            {
                return Area().CompareTo(((Object2D)obj).Area());
            }
            catch(ArgumentException e)
            {
                Console.WriteLine(e.Message);
                return -1;
            }          
        }
    }
}
