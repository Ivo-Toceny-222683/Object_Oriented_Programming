using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Complex cislo_1 = new Complex(3.33, 0.142);
            Complex cislo_2 = new Complex(2.8, -5.3);

            Complex Sum = new Complex(6.13, -5.158);
            TestComplex.Test(Sum, cislo_1 + cislo_2, "Test sčítania");

            Complex Rozd = new Complex(0.53, 5.442);
            TestComplex.Test(Rozd, cislo_1 - cislo_2, "Test odčítania");

            Complex Suč = new Complex(10.0766, -17.2514);
            TestComplex.Test(Suč, cislo_1 * cislo_2, "Test súčinu");

            Complex Del = new Complex(0.2385583078, 0.5022710827);
            TestComplex.Test(Del, cislo_1 / cislo_2, "Test delenia");

            Complex Unar = new Complex(-3.33, -0.142);
            TestComplex.Test(Unar, -cislo_1, "Test unar");

            Complex Komp = new Complex(3.33, -0.142);
            TestComplex.Test(Komp, Complex.KomplexneZdruzene(cislo_1), "Test komplex");

            Console.WriteLine("");

            Console.WriteLine("Equals: {0}", cislo_1 == cislo_2);
            Console.WriteLine("NotEquals: {0}", cislo_1 != cislo_2);
            Console.WriteLine("Modul 3.33 + 0.142: {0}", Complex.Modul(cislo_1));
            Console.WriteLine("Argument 3.33 + 0.142: {0}", Complex.Argument(cislo_1));
            Console.ReadLine();
        }
    }
}
