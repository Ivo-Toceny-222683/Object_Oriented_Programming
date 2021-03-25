using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV7_Comparable
{
    class Extremes
    {
        // Code inspired from http://csharphelper.com/blog/2015/05/make-generic-min-and-max-methods-in-c/
        public static T Biggest<T>(T[] items) where T : IComparable
        {
            T max = items[0];
            for (int i = 1; i < items.Length; i++)
            {
                if (items[i].CompareTo(max) > 0)
                {
                    max = items[i];
                }
            }        
            return max;
        }

        public static T Lowest<T>(T[] items) where T : IComparable
        {
            T min = items[0];
            for (int i = 1; i < items.Length; i++)
            {
                if (items[i].CompareTo(min) < 0)
                {
                    min = items[i];
                }
            }
            return min;
        }
    }
}
