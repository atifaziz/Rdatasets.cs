// ReSharper disable All

namespace Rdatasets.Stat2Data
{
    using System.Collections.Generic;

    /// <summary>
    /// ReligionGDP
    /// </summary>

    public class ReligionGDP
    {
        public readonly string Country;
        public readonly double Religiosity;
        public readonly int GDP;
        public readonly int Africa;
        public readonly int EastEurope;
        public readonly int MiddleEast;
        public readonly int Asia;
        public readonly int WestEurope;
        public readonly int Americas;

        public ReligionGDP(string Country, double Religiosity, int GDP, int Africa, int EastEurope, int MiddleEast, int Asia, int WestEurope, int Americas)
        {
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
                yield return new ReligionGDP("United_States", 1.7, 47440, 0, 0, 0, 0, 0, 1);
                yield return new ReligionGDP("Canada", 0.88, 45085, 0, 0, 0, 0, 0, 1);
                yield return new ReligionGDP("Argentina", 1.07, 8171, 0, 0, 0, 0, 0, 1);
                yield return new ReligionGDP("Bolivia", 1.86, 1656, 0, 0, 0, 0, 0, 1);
                yield return new ReligionGDP("Brazil", 2.34, 8295, 0, 0, 0, 0, 0, 1);
                yield return new ReligionGDP("Chile", 1.35, 10117, 0, 0, 0, 0, 0, 1);
                yield return new ReligionGDP("Mexico", 1.38, 10200, 0, 0, 0, 0, 0, 1);
                yield return new ReligionGDP("Peru", 1.95, 4448, 0, 0, 0, 0, 0, 1);
                yield return new ReligionGDP("Venezuela", 1.54, 11388, 0, 0, 0, 0, 0, 1);
                yield return new ReligionGDP("Britain", 0.58, 43734, 0, 0, 0, 0, 1, 0);
                yield return new ReligionGDP("France", 0.42, 46037, 0, 0, 0, 0, 1, 0);
                yield return new ReligionGDP("Germany", 0.86, 44729, 0, 0, 0, 0, 1, 0);
                yield return new ReligionGDP("Italy", 0.75, 38996, 0, 0, 0, 0, 1, 0);
                yield return new ReligionGDP("Spain", 0.62, 35117, 0, 0, 0, 0, 1, 0);
                yield return new ReligionGDP("Sweden", 0.28, 52181, 0, 0, 0, 0, 1, 0);
                yield return new ReligionGDP("Bulgaria", 0.44, 6561, 0, 1, 0, 0, 0, 0);
                yield return new ReligionGDP("Czech_Republic", 0.35, 20760, 0, 1, 0, 0, 0, 0);
                yield return new ReligionGDP("Poland", 1.04, 13846, 0, 1, 0, 0, 0, 0);
                yield return new ReligionGDP("Russia", 0.59, 11807, 0, 1, 0, 0, 0, 0);
                yield return new ReligionGDP("Slovakia", 0.97, 17646, 0, 1, 0, 0, 0, 0);
                yield return new ReligionGDP("Ukraine", 0.88, 3910, 0, 1, 0, 0, 0, 0);
                yield return new ReligionGDP("Turkey", 1.81, 10479, 0, 0, 1, 0, 0, 0);
                yield return new ReligionGDP("Egypt", 2.08, 2162, 0, 0, 1, 0, 0, 0);
                yield return new ReligionGDP("Jordan", 2.54, 3626, 0, 0, 1, 0, 0, 0);
                yield return new ReligionGDP("Kuwait", 2.75, 45920, 0, 0, 1, 0, 0, 0);
                yield return new ReligionGDP("Lebanon", 1.67, 7708, 0, 0, 1, 0, 0, 0);
                yield return new ReligionGDP("Israel", 0.94, 28409, 0, 0, 1, 0, 0, 0);
                yield return new ReligionGDP("Pakistan", 2.5, 1022, 0, 0, 0, 1, 0, 0);
                yield return new ReligionGDP("Bangladesh", 2.57, 521, 0, 0, 0, 1, 0, 0);
                yield return new ReligionGDP("Indonesia", 2.87, 2239, 0, 0, 0, 1, 0, 0);
                yield return new ReligionGDP("Malaysia", 2.56, 8118, 0, 0, 0, 1, 0, 0);
                yield return new ReligionGDP("India", 2.16, 1017, 0, 0, 0, 1, 0, 0);
                yield return new ReligionGDP("Japan", 0.57, 38457, 0, 0, 0, 1, 0, 0);
                yield return new ReligionGDP("South_Korea", 0.87, 19136, 0, 0, 0, 1, 0, 0);
                yield return new ReligionGDP("Ethiopia", 2.39, 333, 1, 0, 0, 0, 0, 0);
                yield return new ReligionGDP("Ghana", 2.26, 739, 1, 0, 0, 0, 0, 0);
                yield return new ReligionGDP("Ivory_Coast", 2.43, 1132, 1, 0, 0, 0, 0, 0);
                yield return new ReligionGDP("Kenya", 2.4, 838, 1, 0, 0, 0, 0, 0);
                yield return new ReligionGDP("Mali", 2.6, 657, 1, 0, 0, 0, 0, 0);
                yield return new ReligionGDP("Nigeria", 2.63, 1401, 1, 0, 0, 0, 0, 0);
                yield return new ReligionGDP("Senegal", 2.83, 1066, 1, 0, 0, 0, 0, 0);
                yield return new ReligionGDP("South_Africa", 2.11, 5685, 1, 0, 0, 0, 0, 0);
                yield return new ReligionGDP("Tanzania", 2.19, 520, 1, 0, 0, 0, 0, 0);
                yield return new ReligionGDP("Uganda", 2.33, 455, 1, 0, 0, 0, 0, 0);
            }
        }
    }
}
