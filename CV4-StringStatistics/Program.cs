using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV4_StringStatistics
{
    class Program
    {
        public static void PrintArray(string[] array)
        {
            foreach (string word in array)
            {
                if(word.Length == 0)
                {
                    continue;
                }

                Console.Write(word + " ");
            }
        }

        static void Main(string[] args)
        {
            string testovaciText = "Toto je retezec predstavovany nekolika radky,\n"
                                 + "ktere jsou od sebe oddeleny znakem LF (Line Feed).\n"
                                 + "Je tu i nejaky ten vykricnik! Pro ucely testovani i otaznik?\n"
                                 + "Toto je jen zkratka zkr. ale ne konec vety. A toto je\n"
                                 + "posledni veta!";

            string[] array;

            StringStatistics input = new StringStatistics(testovaciText);

            Console.WriteLine(testovaciText + '\n');
            Console.WriteLine("Počet slov: " + input.WordsCount());
            Console.WriteLine("Počet riadkov: " + input.RowsCount());
            Console.WriteLine("Počet viet: " + input.SentencesCount());

            array = input.LongestWords();
            Console.WriteLine("\nNajdlhsie slova:");
            PrintArray(array);

            array = input.ShortestWords();
            Console.WriteLine("\n\nNajkratsie slova:");
            PrintArray(array);

            array = input.CountestWords();
            Console.WriteLine("\n\nNajpocetnejsie slova:");
            PrintArray(array);

            array = input.SortedArray();
            Console.WriteLine("\n\nZoradene slova:");
            PrintArray(array);

            Console.ReadLine();
        }
    }
}
