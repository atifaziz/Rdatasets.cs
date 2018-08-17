// ReSharper disable All

namespace Rdatasets.Stat2Data
{
    using System.Collections.Generic;

    /// <summary>
    /// Mental Health Admissions
    /// </summary>

    public class MentalHealth
    {
        public readonly string Month;
        public readonly string Moon;
        public readonly double Admission;

        public MentalHealth(string Month, string Moon, double Admission)
        {
            this.Month = Month;
            this.Moon = Moon;
            this.Admission = Admission;
        }

        public static IEnumerable<MentalHealth> Data
        {
            get
            {
                yield return new MentalHealth("Aug", "Before", 6.4);
                yield return new MentalHealth("Sep", "Before", 7.1);
                yield return new MentalHealth("Oct", "Before", 6.5);
                yield return new MentalHealth("Nov", "Before", 8.6);
                yield return new MentalHealth("Dec", "Before", 8.1);
                yield return new MentalHealth("Jan", "Before", 10.4);
                yield return new MentalHealth("Feb", "Before", 11.5);
                yield return new MentalHealth("Mar", "Before", 13.8);
                yield return new MentalHealth("Apr", "Before", 15.4);
                yield return new MentalHealth("May", "Before", 15.7);
                yield return new MentalHealth("Jun", "Before", 11.7);
                yield return new MentalHealth("Jul", "Before", 15.8);
                yield return new MentalHealth("Aug", "During", 5);
                yield return new MentalHealth("Sep", "During", 13);
                yield return new MentalHealth("Oct", "During", 14);
                yield return new MentalHealth("Nov", "During", 12);
                yield return new MentalHealth("Dec", "During", 6);
                yield return new MentalHealth("Jan", "During", 9);
                yield return new MentalHealth("Feb", "During", 13);
                yield return new MentalHealth("Mar", "During", 16);
                yield return new MentalHealth("Apr", "During", 25);
                yield return new MentalHealth("May", "During", 14);
                yield return new MentalHealth("Jun", "During", 14);
                yield return new MentalHealth("Jul", "During", 20);
                yield return new MentalHealth("Aug", "After", 5.8);
                yield return new MentalHealth("Sep", "After", 9.2);
                yield return new MentalHealth("Oct", "After", 7.9);
                yield return new MentalHealth("Nov", "After", 7.7);
                yield return new MentalHealth("Dec", "After", 11);
                yield return new MentalHealth("Jan", "After", 12.9);
                yield return new MentalHealth("Feb", "After", 13.5);
                yield return new MentalHealth("Mar", "After", 13.1);
                yield return new MentalHealth("Apr", "After", 15.8);
                yield return new MentalHealth("May", "After", 13.3);
                yield return new MentalHealth("Jun", "After", 12.8);
                yield return new MentalHealth("Jul", "After", 14.5);
            }
        }
    }
}
