using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV8_Files
{
    class Program
    {
        static void Main(string[] args)
        {
            TmpArchive archiv = TmpArchive.LoadFromFile("D:\\Documents\\Toceny_222683\\Object_Oriented_Programming\\CV8-Files\\Archive.txt");

            archiv.PrintArchive();
            archiv.PrintAvgYearArchive();
            archiv.PrintAvgMonthArchive();

            archiv.Calibration(0.1);
            try
            {
                Console.WriteLine("AverageTemp of 2010 after calibration: " + archiv.GetYearTmp(2010).AvgTemp);
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine(e.ToString());
            }

            archiv.SaveToFile("D:\\Documents\\Toceny_222683\\Object_Oriented_Programming\\CV8-Files\\Archive.txt");
        }
    }
}
