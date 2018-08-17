// ReSharper disable All

namespace Rdatasets.HSAUR
{
    using System.Collections.Generic;

    /// <summary>
    /// Meteorological Measurements for 11 Years
    /// </summary>

    public class meteo
    {
        public readonly string year;
        public readonly double rainNovDec;
        public readonly double temp;
        public readonly double rainJuly;
        public readonly int radiation;
        public readonly double yield;

        public meteo(string year, double rainNovDec, double temp, double rainJuly, int radiation, double yield)
        {
            this.year = year;
            this.rainNovDec = rainNovDec;
            this.temp = temp;
            this.rainJuly = rainJuly;
            this.radiation = radiation;
            this.yield = yield;
        }

        public static IEnumerable<meteo> Data
        {
            get
            {
                yield return new meteo("1920-21", 87.9, 19.6, 1, 1661, 28.37);
                yield return new meteo("1921-22", 89.9, 15.2, 90.1, 968, 23.77);
                yield return new meteo("1922-23", 153, 19.7, 56.6, 1353, 26.04);
                yield return new meteo("1923-24", 132.1, 17, 91, 1293, 25.74);
                yield return new meteo("1924-25", 88.8, 18.3, 93.7, 1153, 26.68);
                yield return new meteo("1925-26", 220.9, 17.8, 106.9, 1286, 24.29);
                yield return new meteo("1926-27", 117.7, 17.8, 65.5, 1104, 28);
                yield return new meteo("1927-28", 109, 18.3, 41.8, 1574, 28.37);
                yield return new meteo("1928-29", 156.1, 17.8, 57.4, 1222, 24.96);
                yield return new meteo("1929-30", 181.5, 16.8, 140.6, 902, 21.66);
                yield return new meteo("1930-31", 181.4, 17, 74.3, 1150, 24.37);
            }
        }
    }
}
