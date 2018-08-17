// ReSharper disable All

namespace Rdatasets.MASS
{
    using System.Collections.Generic;

    /// <summary>
    /// Frequency Table from a Copenhagen Housing Conditions Survey
    /// </summary>

    public class housing
    {
        public readonly string Sat;
        public readonly string Infl;
        public readonly string Type;
        public readonly string Cont;
        public readonly int Freq;

        public housing(string Sat, string Infl, string Type, string Cont, int Freq)
        {
            this.Sat = Sat;
            this.Infl = Infl;
            this.Type = Type;
            this.Cont = Cont;
            this.Freq = Freq;
        }

        public static IEnumerable<housing> Data
        {
            get
            {
                yield return new housing("Low", "Low", "Tower", "Low", 21);
                yield return new housing("Medium", "Low", "Tower", "Low", 21);
                yield return new housing("High", "Low", "Tower", "Low", 28);
                yield return new housing("Low", "Medium", "Tower", "Low", 34);
                yield return new housing("Medium", "Medium", "Tower", "Low", 22);
                yield return new housing("High", "Medium", "Tower", "Low", 36);
                yield return new housing("Low", "High", "Tower", "Low", 10);
                yield return new housing("Medium", "High", "Tower", "Low", 11);
                yield return new housing("High", "High", "Tower", "Low", 36);
                yield return new housing("Low", "Low", "Apartment", "Low", 61);
                yield return new housing("Medium", "Low", "Apartment", "Low", 23);
                yield return new housing("High", "Low", "Apartment", "Low", 17);
                yield return new housing("Low", "Medium", "Apartment", "Low", 43);
                yield return new housing("Medium", "Medium", "Apartment", "Low", 35);
                yield return new housing("High", "Medium", "Apartment", "Low", 40);
                yield return new housing("Low", "High", "Apartment", "Low", 26);
                yield return new housing("Medium", "High", "Apartment", "Low", 18);
                yield return new housing("High", "High", "Apartment", "Low", 54);
                yield return new housing("Low", "Low", "Atrium", "Low", 13);
                yield return new housing("Medium", "Low", "Atrium", "Low", 9);
                yield return new housing("High", "Low", "Atrium", "Low", 10);
                yield return new housing("Low", "Medium", "Atrium", "Low", 8);
                yield return new housing("Medium", "Medium", "Atrium", "Low", 8);
                yield return new housing("High", "Medium", "Atrium", "Low", 12);
                yield return new housing("Low", "High", "Atrium", "Low", 6);
                yield return new housing("Medium", "High", "Atrium", "Low", 7);
                yield return new housing("High", "High", "Atrium", "Low", 9);
                yield return new housing("Low", "Low", "Terrace", "Low", 18);
                yield return new housing("Medium", "Low", "Terrace", "Low", 6);
                yield return new housing("High", "Low", "Terrace", "Low", 7);
                yield return new housing("Low", "Medium", "Terrace", "Low", 15);
                yield return new housing("Medium", "Medium", "Terrace", "Low", 13);
                yield return new housing("High", "Medium", "Terrace", "Low", 13);
                yield return new housing("Low", "High", "Terrace", "Low", 7);
                yield return new housing("Medium", "High", "Terrace", "Low", 5);
                yield return new housing("High", "High", "Terrace", "Low", 11);
                yield return new housing("Low", "Low", "Tower", "High", 14);
                yield return new housing("Medium", "Low", "Tower", "High", 19);
                yield return new housing("High", "Low", "Tower", "High", 37);
                yield return new housing("Low", "Medium", "Tower", "High", 17);
                yield return new housing("Medium", "Medium", "Tower", "High", 23);
                yield return new housing("High", "Medium", "Tower", "High", 40);
                yield return new housing("Low", "High", "Tower", "High", 3);
                yield return new housing("Medium", "High", "Tower", "High", 5);
                yield return new housing("High", "High", "Tower", "High", 23);
                yield return new housing("Low", "Low", "Apartment", "High", 78);
                yield return new housing("Medium", "Low", "Apartment", "High", 46);
                yield return new housing("High", "Low", "Apartment", "High", 43);
                yield return new housing("Low", "Medium", "Apartment", "High", 48);
                yield return new housing("Medium", "Medium", "Apartment", "High", 45);
                yield return new housing("High", "Medium", "Apartment", "High", 86);
                yield return new housing("Low", "High", "Apartment", "High", 15);
                yield return new housing("Medium", "High", "Apartment", "High", 25);
                yield return new housing("High", "High", "Apartment", "High", 62);
                yield return new housing("Low", "Low", "Atrium", "High", 20);
                yield return new housing("Medium", "Low", "Atrium", "High", 23);
                yield return new housing("High", "Low", "Atrium", "High", 20);
                yield return new housing("Low", "Medium", "Atrium", "High", 10);
                yield return new housing("Medium", "Medium", "Atrium", "High", 22);
                yield return new housing("High", "Medium", "Atrium", "High", 24);
                yield return new housing("Low", "High", "Atrium", "High", 7);
                yield return new housing("Medium", "High", "Atrium", "High", 10);
                yield return new housing("High", "High", "Atrium", "High", 21);
                yield return new housing("Low", "Low", "Terrace", "High", 57);
                yield return new housing("Medium", "Low", "Terrace", "High", 23);
                yield return new housing("High", "Low", "Terrace", "High", 13);
                yield return new housing("Low", "Medium", "Terrace", "High", 31);
                yield return new housing("Medium", "Medium", "Terrace", "High", 21);
                yield return new housing("High", "Medium", "Terrace", "High", 13);
                yield return new housing("Low", "High", "Terrace", "High", 5);
                yield return new housing("Medium", "High", "Terrace", "High", 6);
                yield return new housing("High", "High", "Terrace", "High", 13);
            }
        }
    }
}
