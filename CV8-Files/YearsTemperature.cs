using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV8_Files
{
    public class YearsTemperature
    {
        private readonly List<double> mnthVls;
        private readonly bool filledList = false;
        public int Year;
        public List<double> MonthlyValues
        {
            get { return mnthVls; }
        }
        public double MaxTemp
        {
            get { return GetMaxTemp(); }
        }
        public double MinTemp
        {
            get { return GetMinTemp(); }
        }
        public double AvgTemp
        {
            get { return GetAvgTemp(); }
        }

        public YearsTemperature(int year, List<double> doubles)
        {
            Year = year;
            if((doubles != null) && (doubles.Any()))
            {
                mnthVls = new List<double>(doubles);
                filledList = true;
            }                 
        }

        private double GetMaxTemp()
        {
            if(filledList)
            {
                return MonthlyValues.Max();
            }
            return double.NaN;
        }

        private double GetMinTemp()
        {
            if (filledList)
            {
                return MonthlyValues.Min();
            }
            return double.NaN;
        }

        private double GetAvgTemp()
        {
            if (filledList)
            {
                return MonthlyValues.Average();
            }
            return double.NaN;
        }
    }
}
