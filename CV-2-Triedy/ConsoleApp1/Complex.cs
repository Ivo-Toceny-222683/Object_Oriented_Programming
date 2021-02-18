using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Complex
    {
        private static char Cmpx = 'i';
        public static double Epsilon = 1E-6; 
        public double Realna;
        public double Imaginarni;

        public Complex(double Real, double Imag)
       {
            Realna = Real;
            Imaginarni = Imag;
       }

        public static Complex operator +(Complex number, Complex number2)
        {
            return new Complex(number.Realna + number2.Realna, number.Imaginarni + number2.Imaginarni);
        }

        public static Complex operator -(Complex number, Complex number2)
        {
            return new Complex(number.Realna - number2.Realna, number.Imaginarni - number2.Imaginarni);
        }

        /* LOGIKA ZA VÝPOČTOM:
         * Realna -> Vynásobené realne časti - vynásobené imag. časti   -> kvoli i^2 je tam -
         * Imagin -> Vynásobené opačné časti, teda Realna * Imaginárna v oboch
        */
        public static Complex operator *(Complex number, Complex number2)
        {
            return new Complex(number.Realna * number2.Realna - number.Imaginarni * number2.Imaginarni,
                number.Realna * number2.Imaginarni + number.Imaginarni * number2.Realna);
        }

        /* LOGIKA ZA VÝPOČTOM:
         * 1. Vynásobenie čitateľa a menovateľa združeným komplexným menovateľom (teda *1 vo výsledku) na odstránenie i v menovateli
         * 2. Spočítanie násobenia:   number1 * (združ. number2) / (number2.Realna^2 + number2.Imaginarna^2)
         * 3. Rozdelenie častí: menovateľ ostáva a už len rozdelíme časti na reálnu a imaginárnu z čitateľa
        */
        public static Complex operator /(Complex number, Complex number2)
        {
            return new Complex((number.Realna * number2.Realna - number.Imaginarni * (- number2.Imaginarni)) / (number2.Realna * number2.Realna + number2.Imaginarni * number2.Imaginarni),
                (number.Realna * (- number2.Imaginarni) + number.Imaginarni * number2.Realna) / (number2.Realna * number2.Realna + number2.Imaginarni * number2.Imaginarni));
        }

        public static bool operator ==(Complex number, Complex number2)
        {
            if(Math.Abs(number.Realna - number2.Realna) < Epsilon && Math.Abs(number.Imaginarni - number2.Imaginarni) < Epsilon)
            {
                return true;
            }
            return false;
            
        }

        public static bool operator !=(Complex number, Complex number2)
        {
            return !(number == number2);
        }

        public static Complex operator -(Complex number)
        {
            return new Complex(-number.Realna, - number.Imaginarni);
        }

        public static Complex KomplexneZdruzene(Complex number)
        {
            return new Complex(number.Realna, -number.Imaginarni);
        }

        public static double Modul(Complex number)
        {
            return Math.Sqrt(number.Realna * number.Realna + number.Imaginarni * number.Imaginarni);
        }

        public static double Argument(Complex number)
        {
            return Math.Atan(number.Imaginarni / number.Realna);
        }

        public override string ToString()
        {
            if (Imaginarni < 0)
            {
                return string.Format("{0} - {1}{2}", Realna, -Imaginarni, Cmpx);
            }
            else
            {
                return string.Format("{0} + {1}{2}", Realna, Imaginarni, Cmpx);
            }
        }
    }
    
}
