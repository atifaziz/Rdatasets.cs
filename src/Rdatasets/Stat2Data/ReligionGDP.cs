// ReSharper disable All

namespace Rdatasets.Stat2Data
{
    using System.Collections.Generic;

    /// <summary>
    /// ReligionGDP
    /// </summary>

    public class ReligionGDP
    {
        public readonly int κ;
        public readonly string Country;
        public readonly double Religiosity;
        public readonly int GDP;
        public readonly int Africa;
        public readonly int EastEurope;
        public readonly int MiddleEast;
        public readonly int Asia;
        public readonly int WestEurope;
        public readonly int Americas;

        public ReligionGDP(int κ, string Country, double Religiosity, int GDP, int Africa, int EastEurope, int MiddleEast, int Asia, int WestEurope, int Americas)
        {
            this.κ = κ;
            this.Country = Country;
            this.Religiosity = Religiosity;
            this.GDP = GDP;
            this.Africa = Africa;
            this.EastEurope = EastEurope;
            this.MiddleEast = MiddleEast;
            this.Asia = Asia;
            this.WestEurope = WestEurope;
            this.Americas = Americas;
        }

        public static IEnumerable<ReligionGDP> Data
        {
            get
            {
                yield return new ReligionGDP(1, "United_States", 1.7, 47440, 0, 0, 0, 0, 0, 1);
                yield return new ReligionGDP(2, "Canada", 0.88, 45085, 0, 0, 0, 0, 0, 1);
                yield return new ReligionGDP(3, "Argentina", 1.07, 8171, 0, 0, 0, 0, 0, 1);
                yield return new ReligionGDP(4, "Bolivia", 1.86, 1656, 0, 0, 0, 0, 0, 1);
                yield return new ReligionGDP(5, "Brazil", 2.34, 8295, 0, 0, 0, 0, 0, 1);
                yield return new ReligionGDP(6, "Chile", 1.35, 10117, 0, 0, 0, 0, 0, 1);
                yield return new ReligionGDP(7, "Mexico", 1.38, 10200, 0, 0, 0, 0, 0, 1);
                yield return new ReligionGDP(8, "Peru", 1.95, 4448, 0, 0, 0, 0, 0, 1);
                yield return new ReligionGDP(9, "Venezuela", 1.54, 11388, 0, 0, 0, 0, 0, 1);
                yield return new ReligionGDP(10, "Britain", 0.58, 43734, 0, 0, 0, 0, 1, 0);
                yield return new ReligionGDP(11, "France", 0.42, 46037, 0, 0, 0, 0, 1, 0);
                yield return new ReligionGDP(12, "Germany", 0.86, 44729, 0, 0, 0, 0, 1, 0);
                yield return new ReligionGDP(13, "Italy", 0.75, 38996, 0, 0, 0, 0, 1, 0);
                yield return new ReligionGDP(14, "Spain", 0.62, 35117, 0, 0, 0, 0, 1, 0);
                yield return new ReligionGDP(15, "Sweden", 0.28, 52181, 0, 0, 0, 0, 1, 0);
                yield return new ReligionGDP(16, "Bulgaria", 0.44, 6561, 0, 1, 0, 0, 0, 0);
                yield return new ReligionGDP(17, "Czech_Republic", 0.35, 20760, 0, 1, 0, 0, 0, 0);
                yield return new ReligionGDP(18, "Poland", 1.04, 13846, 0, 1, 0, 0, 0, 0);
                yield return new ReligionGDP(19, "Russia", 0.59, 11807, 0, 1, 0, 0, 0, 0);
                yield return new ReligionGDP(20, "Slovakia", 0.97, 17646, 0, 1, 0, 0, 0, 0);
                yield return new ReligionGDP(21, "Ukraine", 0.88, 3910, 0, 1, 0, 0, 0, 0);
                yield return new ReligionGDP(22, "Turkey", 1.81, 10479, 0, 0, 1, 0, 0, 0);
                yield return new ReligionGDP(23, "Egypt", 2.08, 2162, 0, 0, 1, 0, 0, 0);
                yield return new ReligionGDP(24, "Jordan", 2.54, 3626, 0, 0, 1, 0, 0, 0);
                yield return new ReligionGDP(25, "Kuwait", 2.75, 45920, 0, 0, 1, 0, 0, 0);
                yield return new ReligionGDP(26, "Lebanon", 1.67, 7708, 0, 0, 1, 0, 0, 0);
                yield return new ReligionGDP(27, "Israel", 0.94, 28409, 0, 0, 1, 0, 0, 0);
                yield return new ReligionGDP(28, "Pakistan", 2.5, 1022, 0, 0, 0, 1, 0, 0);
                yield return new ReligionGDP(29, "Bangladesh", 2.57, 521, 0, 0, 0, 1, 0, 0);
                yield return new ReligionGDP(30, "Indonesia", 2.87, 2239, 0, 0, 0, 1, 0, 0);
                yield return new ReligionGDP(31, "Malaysia", 2.56, 8118, 0, 0, 0, 1, 0, 0);
                yield return new ReligionGDP(32, "India", 2.16, 1017, 0, 0, 0, 1, 0, 0);
                yield return new ReligionGDP(33, "Japan", 0.57, 38457, 0, 0, 0, 1, 0, 0);
                yield return new ReligionGDP(34, "South_Korea", 0.87, 19136, 0, 0, 0, 1, 0, 0);
                yield return new ReligionGDP(35, "Ethiopia", 2.39, 333, 1, 0, 0, 0, 0, 0);
                yield return new ReligionGDP(36, "Ghana", 2.26, 739, 1, 0, 0, 0, 0, 0);
                yield return new ReligionGDP(37, "Ivory_Coast", 2.43, 1132, 1, 0, 0, 0, 0, 0);
                yield return new ReligionGDP(38, "Kenya", 2.4, 838, 1, 0, 0, 0, 0, 0);
                yield return new ReligionGDP(39, "Mali", 2.6, 657, 1, 0, 0, 0, 0, 0);
                yield return new ReligionGDP(40, "Nigeria", 2.63, 1401, 1, 0, 0, 0, 0, 0);
                yield return new ReligionGDP(41, "Senegal", 2.83, 1066, 1, 0, 0, 0, 0, 0);
                yield return new ReligionGDP(42, "South_Africa", 2.11, 5685, 1, 0, 0, 0, 0, 0);
                yield return new ReligionGDP(43, "Tanzania", 2.19, 520, 1, 0, 0, 0, 0, 0);
                yield return new ReligionGDP(44, "Uganda", 2.33, 455, 1, 0, 0, 0, 0, 0);
            }
        }
    }
}
