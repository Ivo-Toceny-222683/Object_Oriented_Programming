using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV7_Comparable
{
    public class Extremes
    {
        public static T Biggest<T>(T[] items) where T : IComparable
        {
            T max = items[0];
            foreach (T thing in items)
            {
                if (thing.CompareTo(max) > 0)
                {
                    max = thing;
                }
            }        
            return max;
        }

        public static T Lowest<T>(T[] items) where T : IComparable
        {
            T min = items[0];
            foreach (T thing in items)
            {
                if (thing.CompareTo(min) < 0)
                {
                    min = thing;
                }
            }
            return min;
        }
    }
}
