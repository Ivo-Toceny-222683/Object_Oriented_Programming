using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV5_VirtualAbstract
{
    class Program
    {
        static void Main(string[] args)
        {
            Osobni Car = new Osobni(Auto.FuelType.Benzin, 20, 5);
            try
            {
                Car.CurrPeople = 7;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }     
            Console.WriteLine(Car.ToString());


            Nakladni Car2 = new Nakladni(Auto.FuelType.Nafta, 150, 50);
            Car2.TurnRadioOn();
            Car2.MakeRadioShortage(2, 98.8);
            Car2.SetRadioShortage(2);
            try
            {
                Car2.AddFuel(Auto.FuelType.Nafta, 120);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }     
            Console.WriteLine(Car2.ToString());
        }
    }
}
