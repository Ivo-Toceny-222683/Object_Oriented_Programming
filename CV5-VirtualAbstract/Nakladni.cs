using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV5_VirtualAbstract
{
    class Nakladni : Auto
    {
        private int currCarry = 0;

        private readonly int maxCarry;
        public int CurrCarry
        {
            get 
            {
                return CurrCarry;
            }
            set
            {
                if(value < 0 || value > maxCarry)
                {
                    Console.WriteLine("Warning!: Cant set this value of current carry.\n");
                }
                else
                {
                    currCarry = value;
                }
            }
        }

        public Nakladni(FuelType fuel, int sizeOfTank, int maxCarry) : base(fuel, sizeOfTank)
        {
            this.maxCarry = (maxCarry < 0) ? 0 : maxCarry;      
        }

        public override string ToString()
        {
            return string.Format("Nakladni auto.\nMaxCarry: {0}\nCurrentCarry: {1}\nTypeOfFuel: {2}\nSizeOfTank: {3}\nStateOfTank: {4}\n{5}",
                                    maxCarry, currCarry, Fuel, SizeOfTank, StateOfTank, RadioInfo());
        }


    }
}
