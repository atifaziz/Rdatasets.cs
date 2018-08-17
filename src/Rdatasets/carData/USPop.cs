// ReSharper disable All

namespace Rdatasets.carData
{
    using System.Collections.Generic;

    /// <summary>
    /// Population of the United States
    /// </summary>

    public class USPop
    {
        public readonly int year;
        public readonly double population;

        public USPop(int year, double population)
        {
            this.year = year;
            this.population = population;
        }

        public static IEnumerable<USPop> Data
        {
            get
            {
                yield return new USPop(1790, 3.929214);
                yield return new USPop(1800, 5.308483);
                yield return new USPop(1810, 7.239881);
                yield return new USPop(1820, 9.638453);
                yield return new USPop(1830, 12.860702);
                yield return new USPop(1840, 17.063353);
                yield return new USPop(1850, 23.191876);
                yield return new USPop(1860, 31.443321);
                yield return new USPop(1870, 38.558371);
                yield return new USPop(1880, 50.189209);
                yield return new USPop(1890, 62.979766);
                yield return new USPop(1900, 76.212168);
                yield return new USPop(1910, 92.228496);
                yield return new USPop(1920, 106.021537);
                yield return new USPop(1930, 123.202624);
                yield return new USPop(1940, 132.164569);
                yield return new USPop(1950, 151.325798);
                yield return new USPop(1960, 179.323175);
                yield return new USPop(1970, 203.302031);
                yield return new USPop(1980, 226.542199);
                yield return new USPop(1990, 248.709873);
                yield return new USPop(2000, 281.421906);
            }
        }
    }
}
