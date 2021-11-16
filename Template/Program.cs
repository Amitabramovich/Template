namespace Template
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;
    using System.Text;
    class Program
    {
        static void Main(string[] args)
        {

            TempMeasurements m1 = new TempMeasurements()
            {
                City = "Jerusalem",
                Year = -4500,
                Degrees = 20,
                Moisture = 0.40,
            };
            TempMeasurements m2 = new TempMeasurements()
            {
                City = "Bnei Brak",
                Year = 1924,
                Degrees = 28,
                Moisture = 0.70,
            };
            TempMeasurements m3 = new TempMeasurements()
            {
                City = "Tel Aviv",
                Year = 1909,
                Degrees = 20,
                Moisture = 0.70,
            };
            TempMeasurements m4 = new TempMeasurements()
            {
                City = "Eilat",
                Year = 1951,
                Degrees = 20,
                Moisture = 0.70,
            };

            List<TempMeasurements> myList = new List<TempMeasurements>();
            myList.Add(m1);
            myList.Add(m2);
            myList.Add(m3);
            myList.Add(m4);
            Compare(TempMeasurements m1, TempMeasurements m2)
        }
    
        class TempMeasurements
        {
            public string City { get; set; }
            public int Year { get; set; }
            public double Degrees { get; set; }
            public double Moisture { get; set; }
        }
        class SortByCity : IComparer<TempMeasurements>
        {
            public static string Compare(TempMeasurements x,TempMeasurements y)
            {
                return x.City.Compare(y.City);
            }

            int IComparer<TempMeasurements>.Compare(TempMeasurements x, TempMeasurements y)
            {
                throw new NotImplementedException();
            }
        }


    }
}






