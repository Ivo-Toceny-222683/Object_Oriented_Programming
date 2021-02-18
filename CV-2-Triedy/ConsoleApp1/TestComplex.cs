using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class TestComplex
    {
        public static double Epsilon = 1E-6;

        public static void Test(Complex skutocna, Complex ocakavana, string nazov)
        {
            if(Math.Abs(skutocna.Realna - ocakavana.Realna) < Epsilon && Math.Abs(skutocna.Imaginarni - ocakavana.Imaginarni) < Epsilon)
            {
                Console.WriteLine("{0}: OK", nazov);
            }
            else
            {
                Console.WriteLine("{0}: Chyba, Očakávaná hodnota: {1}, Skutočná hodnota: {2}", nazov, ocakavana, skutocna);
            }
        }

    }
}
