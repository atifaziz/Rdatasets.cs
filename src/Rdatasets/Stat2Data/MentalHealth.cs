// ReSharper disable All

namespace Rdatasets.Stat2Data
{
    using System.Collections.Generic;

    /// <summary>
    /// Mental Health Admissions
    /// </summary>

    public class MentalHealth
    {
        public readonly int κ;
        public readonly string Month;
        public readonly string Moon;
        public readonly double Admission;

        public MentalHealth(int κ, string Month, string Moon, double Admission)
        {
            this.κ = κ;
            this.Month = Month;
            this.Moon = Moon;
            this.Admission = Admission;
        }

        public static IEnumerable<MentalHealth> Data
        {
            get
            {
                yield return new MentalHealth(1, "Aug", "Before", 6.4);
                yield return new MentalHealth(2, "Sep", "Before", 7.1);
                yield return new MentalHealth(3, "Oct", "Before", 6.5);
                yield return new MentalHealth(4, "Nov", "Before", 8.6);
                yield return new MentalHealth(5, "Dec", "Before", 8.1);
                yield return new MentalHealth(6, "Jan", "Before", 10.4);
                yield return new MentalHealth(7, "Feb", "Before", 11.5);
                yield return new MentalHealth(8, "Mar", "Before", 13.8);
                yield return new MentalHealth(9, "Apr", "Before", 15.4);
                yield return new MentalHealth(10, "May", "Before", 15.7);
                yield return new MentalHealth(11, "Jun", "Before", 11.7);
                yield return new MentalHealth(12, "Jul", "Before", 15.8);
                yield return new MentalHealth(13, "Aug", "During", 5);
                yield return new MentalHealth(14, "Sep", "During", 13);
                yield return new MentalHealth(15, "Oct", "During", 14);
                yield return new MentalHealth(16, "Nov", "During", 12);
                yield return new MentalHealth(17, "Dec", "During", 6);
                yield return new MentalHealth(18, "Jan", "During", 9);
                yield return new MentalHealth(19, "Feb", "During", 13);
                yield return new MentalHealth(20, "Mar", "During", 16);
                yield return new MentalHealth(21, "Apr", "During", 25);
                yield return new MentalHealth(22, "May", "During", 14);
                yield return new MentalHealth(23, "Jun", "During", 14);
                yield return new MentalHealth(24, "Jul", "During", 20);
                yield return new MentalHealth(25, "Aug", "After", 5.8);
                yield return new MentalHealth(26, "Sep", "After", 9.2);
                yield return new MentalHealth(27, "Oct", "After", 7.9);
                yield return new MentalHealth(28, "Nov", "After", 7.7);
                yield return new MentalHealth(29, "Dec", "After", 11);
                yield return new MentalHealth(30, "Jan", "After", 12.9);
                yield return new MentalHealth(31, "Feb", "After", 13.5);
                yield return new MentalHealth(32, "Mar", "After", 13.1);
                yield return new MentalHealth(33, "Apr", "After", 15.8);
                yield return new MentalHealth(34, "May", "After", 13.3);
                yield return new MentalHealth(35, "Jun", "After", 12.8);
                yield return new MentalHealth(36, "Jul", "After", 14.5);
            }
        }
    }
}
