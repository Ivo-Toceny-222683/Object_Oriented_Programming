using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV5_VirtualAbstract
{
    class Auto
    {
        public enum FuelType
        {
            Benzin,
            Nafta
        }

        protected int SizeOfTank;
        protected int StateOfTank;
        protected FuelType Fuel;
        Autoradio radio;

        class Autoradio
        {
            public double SetFrequency = double.NaN;
            public bool RadioOn = false;
            protected Dictionary<int, double> Radios = new Dictionary<int, double>();

            public void MakeShortage(int shortage, double frequency)
            {
                Radios[shortage] = frequency;
            }

            public void SetShortage(int shortage)
            {
                if(RadioOn && Radios.ContainsKey(shortage))
                {
                    SetFrequency = Radios[shortage];
                }
                else
                {
                    throw new Exception("Firstly make shortage for this value and turn your radio on if it wasnt.");
                }
            }

            public override string ToString()
            {
                return string.Format("RadioOn: {0}\nSetFrequency: {1}\n", RadioOn, SetFrequency);
            }
        }

        public Auto(FuelType fuel, int sizeOfTank)
        {
            StateOfTank = 0;
            Fuel = fuel;
            SizeOfTank = (sizeOfTank < 0) ? 0 : sizeOfTank;
            radio = new Autoradio();
        }

        public void TurnRadioOn()
        {
            radio.RadioOn = true;
        }

        public void TurnRadioOff()
        {
            radio.RadioOn = false;
        }

        public string RadioInfo()
        {
            return radio.ToString();
        }

        public void SetRadioShortage(int shortage)
        {
            radio.SetShortage(shortage);
        }

        public void MakeRadioShortage(int shortage, double frequency)
        {
            radio.MakeShortage(shortage, frequency);
        }

        public void AddFuel(FuelType fuel, int amount)
        {
            if(Fuel != fuel || amount > SizeOfTank || amount < 0 || amount + StateOfTank > SizeOfTank)
            {
                throw new Exception("Warning!: Cant add this fuel, would be overflowing.\n");
            }
            else
            {
                StateOfTank += amount;
            }
        }
    }
}
