// ReSharper disable All

namespace Rdatasets.carData
{
    using System.Collections.Generic;

    /// <summary>
    /// Population of the United States
    /// </summary>

    public class USPop
    {
        public readonly int κ;
        public readonly int year;
        public readonly double population;

        public USPop(int κ, int year, double population)
        {
            this.κ = κ;
            this.year = year;
            this.population = population;
        }

        public static IEnumerable<USPop> Data
        {
            get
            {
                yield return new USPop(1, 1790, 3.929214);
                yield return new USPop(2, 1800, 5.308483);
                yield return new USPop(3, 1810, 7.239881);
                yield return new USPop(4, 1820, 9.638453);
                yield return new USPop(5, 1830, 12.860702);
                yield return new USPop(6, 1840, 17.063353);
                yield return new USPop(7, 1850, 23.191876);
                yield return new USPop(8, 1860, 31.443321);
                yield return new USPop(9, 1870, 38.558371);
                yield return new USPop(10, 1880, 50.189209);
                yield return new USPop(11, 1890, 62.979766);
                yield return new USPop(12, 1900, 76.212168);
                yield return new USPop(13, 1910, 92.228496);
                yield return new USPop(14, 1920, 106.021537);
                yield return new USPop(15, 1930, 123.202624);
                yield return new USPop(16, 1940, 132.164569);
                yield return new USPop(17, 1950, 151.325798);
                yield return new USPop(18, 1960, 179.323175);
                yield return new USPop(19, 1970, 203.302031);
                yield return new USPop(20, 1980, 226.542199);
                yield return new USPop(21, 1990, 248.709873);
                yield return new USPop(22, 2000, 281.421906);
            }
        }
    }
}
