using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV5_VirtualAbstract
{
    class Osobni : Auto
    {
        private int currPeople = 0;
        public Osobni(FuelType fuel, int sizeOfTank, int maxPeople) : base(fuel, sizeOfTank)
        {
            this.maxPeople = (maxPeople < 0) ? 0 : maxPeople;                 
        }

        private readonly int maxPeople;
        public int CurrPeople
        {
            get
            {
                return CurrPeople;
            }
            set
            {
                if (value < 0 || value > maxPeople)
                {
                    throw new Exception("Warning!: Cant set this value of current people.\n");
                }
                else
                {
                    currPeople = value;
                }
            }
        }

        public override string ToString()
        {
            return string.Format("Osobni auto.\nMaxPeople: {0}\nCurrentPeople: {1}\nTypeOfFuel: {2}\nSizeOfTank: {3}\nStateOfTank: {4}\n{5}", 
                                    maxPeople, currPeople, Fuel, SizeOfTank, StateOfTank, RadioInfo());
        }
    }
}
