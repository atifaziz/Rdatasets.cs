// ReSharper disable All

namespace Rdatasets.MASS
{
    using System.Collections.Generic;

    /// <summary>
    /// Frequency Table from a Copenhagen Housing Conditions Survey
    /// </summary>

    public class housing
    {
        public readonly int κ;
        public readonly string Sat;
        public readonly string Infl;
        public readonly string Type;
        public readonly string Cont;
        public readonly int Freq;

        public housing(int κ, string Sat, string Infl, string Type, string Cont, int Freq)
        {
            this.κ = κ;
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
                yield return new housing(1, "Low", "Low", "Tower", "Low", 21);
                yield return new housing(2, "Medium", "Low", "Tower", "Low", 21);
                yield return new housing(3, "High", "Low", "Tower", "Low", 28);
                yield return new housing(4, "Low", "Medium", "Tower", "Low", 34);
                yield return new housing(5, "Medium", "Medium", "Tower", "Low", 22);
                yield return new housing(6, "High", "Medium", "Tower", "Low", 36);
                yield return new housing(7, "Low", "High", "Tower", "Low", 10);
                yield return new housing(8, "Medium", "High", "Tower", "Low", 11);
                yield return new housing(9, "High", "High", "Tower", "Low", 36);
                yield return new housing(10, "Low", "Low", "Apartment", "Low", 61);
                yield return new housing(11, "Medium", "Low", "Apartment", "Low", 23);
                yield return new housing(12, "High", "Low", "Apartment", "Low", 17);
                yield return new housing(13, "Low", "Medium", "Apartment", "Low", 43);
                yield return new housing(14, "Medium", "Medium", "Apartment", "Low", 35);
                yield return new housing(15, "High", "Medium", "Apartment", "Low", 40);
                yield return new housing(16, "Low", "High", "Apartment", "Low", 26);
                yield return new housing(17, "Medium", "High", "Apartment", "Low", 18);
                yield return new housing(18, "High", "High", "Apartment", "Low", 54);
                yield return new housing(19, "Low", "Low", "Atrium", "Low", 13);
                yield return new housing(20, "Medium", "Low", "Atrium", "Low", 9);
                yield return new housing(21, "High", "Low", "Atrium", "Low", 10);
                yield return new housing(22, "Low", "Medium", "Atrium", "Low", 8);
                yield return new housing(23, "Medium", "Medium", "Atrium", "Low", 8);
                yield return new housing(24, "High", "Medium", "Atrium", "Low", 12);
                yield return new housing(25, "Low", "High", "Atrium", "Low", 6);
                yield return new housing(26, "Medium", "High", "Atrium", "Low", 7);
                yield return new housing(27, "High", "High", "Atrium", "Low", 9);
                yield return new housing(28, "Low", "Low", "Terrace", "Low", 18);
                yield return new housing(29, "Medium", "Low", "Terrace", "Low", 6);
                yield return new housing(30, "High", "Low", "Terrace", "Low", 7);
                yield return new housing(31, "Low", "Medium", "Terrace", "Low", 15);
                yield return new housing(32, "Medium", "Medium", "Terrace", "Low", 13);
                yield return new housing(33, "High", "Medium", "Terrace", "Low", 13);
                yield return new housing(34, "Low", "High", "Terrace", "Low", 7);
                yield return new housing(35, "Medium", "High", "Terrace", "Low", 5);
                yield return new housing(36, "High", "High", "Terrace", "Low", 11);
                yield return new housing(37, "Low", "Low", "Tower", "High", 14);
                yield return new housing(38, "Medium", "Low", "Tower", "High", 19);
                yield return new housing(39, "High", "Low", "Tower", "High", 37);
                yield return new housing(40, "Low", "Medium", "Tower", "High", 17);
                yield return new housing(41, "Medium", "Medium", "Tower", "High", 23);
                yield return new housing(42, "High", "Medium", "Tower", "High", 40);
                yield return new housing(43, "Low", "High", "Tower", "High", 3);
                yield return new housing(44, "Medium", "High", "Tower", "High", 5);
                yield return new housing(45, "High", "High", "Tower", "High", 23);
                yield return new housing(46, "Low", "Low", "Apartment", "High", 78);
                yield return new housing(47, "Medium", "Low", "Apartment", "High", 46);
                yield return new housing(48, "High", "Low", "Apartment", "High", 43);
                yield return new housing(49, "Low", "Medium", "Apartment", "High", 48);
                yield return new housing(50, "Medium", "Medium", "Apartment", "High", 45);
                yield return new housing(51, "High", "Medium", "Apartment", "High", 86);
                yield return new housing(52, "Low", "High", "Apartment", "High", 15);
                yield return new housing(53, "Medium", "High", "Apartment", "High", 25);
                yield return new housing(54, "High", "High", "Apartment", "High", 62);
                yield return new housing(55, "Low", "Low", "Atrium", "High", 20);
                yield return new housing(56, "Medium", "Low", "Atrium", "High", 23);
                yield return new housing(57, "High", "Low", "Atrium", "High", 20);
                yield return new housing(58, "Low", "Medium", "Atrium", "High", 10);
                yield return new housing(59, "Medium", "Medium", "Atrium", "High", 22);
                yield return new housing(60, "High", "Medium", "Atrium", "High", 24);
                yield return new housing(61, "Low", "High", "Atrium", "High", 7);
                yield return new housing(62, "Medium", "High", "Atrium", "High", 10);
                yield return new housing(63, "High", "High", "Atrium", "High", 21);
                yield return new housing(64, "Low", "Low", "Terrace", "High", 57);
                yield return new housing(65, "Medium", "Low", "Terrace", "High", 23);
                yield return new housing(66, "High", "Low", "Terrace", "High", 13);
                yield return new housing(67, "Low", "Medium", "Terrace", "High", 31);
                yield return new housing(68, "Medium", "Medium", "Terrace", "High", 21);
                yield return new housing(69, "High", "Medium", "Terrace", "High", 13);
                yield return new housing(70, "Low", "High", "Terrace", "High", 5);
                yield return new housing(71, "Medium", "High", "Terrace", "High", 6);
                yield return new housing(72, "High", "High", "Terrace", "High", 13);
            }
        }
    }
}
