using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV7_Comparable
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 2, 8, 1, 15, 3, 7, 9 };
            string[] texts = { "BB", "ab", "CE", "dE", "AA", "aa", "Fe" };
            Circle[] eyes = { new Circle(3.2), new Circle(7), new Circle(4), new Circle(1.5), new Circle(6) };
            Rectangle[] rubbers = { new Rectangle(3, 5.2), new Rectangle(6, 3.5), new Rectangle(1.3, 2.5), new Rectangle(7.7, 9.2)};
            Ellipse[] faces = { new Ellipse(4, 2.5), new Ellipse(5, 6.2), new Ellipse(1.3, 2.4), new Ellipse(7.2, 8.5), new Ellipse(4.5, 3.2) };
            Triangle[] illuminati = { new Triangle(4.2, 5.3, 3.2), new Triangle(1.3, 2.4, 2.2), new Triangle(7.2, 5.4, 6.4) };
            Square[] parcels = { new Square(2.2), new Square(3.5), new Square(1.5), new Square(8.6), new Square(5.3) };

            Console.WriteLine("MaxInt= " + Extremes.Biggest<int>(numbers).ToString());
            Console.WriteLine("MinInt= " + Extremes.Lowest<int>(numbers).ToString() + "\n");

            Console.WriteLine("MaxStr= " + Extremes.Biggest<string>(texts).ToString());
            Console.WriteLine("MinStr= " + Extremes.Lowest<string>(texts).ToString() + "\n");

            Console.WriteLine(Extremes.Biggest<Circle>(eyes).ToString());
            Console.WriteLine(Extremes.Lowest<Circle>(eyes).ToString() + "\n");

            Console.WriteLine(Extremes.Biggest<Rectangle>(rubbers).ToString());
            Console.WriteLine(Extremes.Lowest<Rectangle>(rubbers).ToString() + "\n");

            Console.WriteLine(Extremes.Biggest<Ellipse>(faces).ToString());
            Console.WriteLine(Extremes.Lowest<Ellipse>(faces).ToString() + "\n");

            Console.WriteLine(Extremes.Biggest<Triangle>(illuminati).ToString());
            Console.WriteLine(Extremes.Lowest<Triangle>(illuminati).ToString() + "\n");

            Console.WriteLine(Extremes.Biggest<Square>(parcels).ToString());
            Console.WriteLine(Extremes.Lowest<Square>(parcels).ToString() + "\n");

            IEnumerable<int> nums = new List<int>() { 1, 3, 5, 7, 9 };
            IEnumerable<int> chosen = from n in nums where n >= 4 && n <= 8 select n;
            Console.WriteLine("Chosen array of ints(1, 3, 5, 7, 9):");
            foreach(int i in chosen)
            {
                Console.WriteLine(i);
            }
        }
    }
}
