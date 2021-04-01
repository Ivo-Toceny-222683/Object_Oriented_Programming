using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV8_Files
{
    public class TmpArchive
    {
        private SortedDictionary<int, YearsTemperature> _archive;

        public TmpArchive()
        {
            _archive = new SortedDictionary<int, YearsTemperature>();
        }

        public void AddDataYear(YearsTemperature yearData)
        {
            if (yearData != null)
            {
                _archive.Add(yearData.Year, yearData);
            }
        }

        public void Calibration(double add)
        {
            foreach(var year in _archive)
            {
                for(int month = 0; month < 12; month++)
                {
                    year.Value.MonthlyValues[month] += add;
                }
            }
        }

        public YearsTemperature GetYearTmp(int year)
        {
            if (_archive.TryGetValue(year, out YearsTemperature value))
            {
                return value;
            }
            throw new ArgumentNullException();
            
        }

        public void PrintArchive()
        {
            foreach (var year in _archive)
            {
                Console.Write(year.Key + ":");
                for (int month = 0; month < year.Value.MonthlyValues.Count; month++)
                {
                    Console.Write("   " + year.Value.MonthlyValues[month]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public void PrintAvgYearArchive()
        {
            foreach (var year in _archive)
            {
                Console.WriteLine(year.Key + ":   " + year.Value.AvgTemp);
            }
            Console.WriteLine();
        }

        public void PrintAvgMonthArchive()
        {
            double[] avgmonth = new double[12];

            foreach (var year in _archive)
            {
                for(int month = 0; month < 12; month++)
                {
                    avgmonth[month] += year.Value.MonthlyValues[month];
                }
            }

            Console.Write("Monthly Average:");
            foreach (var month in avgmonth)
            {
                Console.Write("   " + month/(_archive.Count));
            }
            Console.WriteLine();
        }

        public void SaveToFile(string path)
        {
            if(path.Length > 3 && path.Substring(path.Length - 4) == ".txt")
            {
                StreamWriter writer = File.CreateText(path);

                foreach (var year in _archive)
                {
                    writer.Write(year.Key + ": ");
                    for (int month = 0; month < 11; month++)
                    {
                        writer.Write(year.Value.MonthlyValues[month] + "; ");
                    }
                    writer.Write(year.Value.MonthlyValues[11] + writer.NewLine);
                }
                writer.Close();
            }       
        }

        public static TmpArchive LoadFromFile(string path)
        {
            if(File.Exists(path) && path.Length > 3 && path.Substring(path.Length - 4) == ".txt")
            {
                try
                {
                    StreamReader reader = File.OpenText(path);

                    string[] keyValue = new string[2];
                    double[] doubleA = new double[12];
                    List<double> values;
                    string line = null;
                    TmpArchive archive = new TmpArchive();

                    while ((line = reader.ReadLine()) != null)
                    {
                        keyValue = line.Split(':');
                        doubleA = Array.ConvertAll(keyValue[1].Split(';'), Double.Parse);
                        values = new List<double>();
                        foreach (var doubles in doubleA)
                        {
                            values.Add(doubles);
                        }
                        YearsTemperature yearData = new YearsTemperature(Int32.Parse(keyValue[0]), values);
                        archive.AddDataYear(yearData);
                    }
                    reader.Close();
                    return archive;
                }
                catch(Exception)
                {
                    Console.WriteLine("File is not in a right format to read.");
                }
            }
            return null;
        }
    }
}
