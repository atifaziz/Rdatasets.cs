// ReSharper disable All

namespace Rdatasets.datasets
{
    using System.Collections.Generic;

    /// <summary>
    /// Populations Recorded by the US Census
    /// </summary>

    public class uspop
    {
        public readonly int time;
        public readonly double value;

        public uspop(int time, double value)
        {
            this.time = time;
            this.value = value;
        }

        public static IEnumerable<uspop> Data
        {
            get
            {
                yield return new uspop(1790, 3.93);
                yield return new uspop(1800, 5.31);
                yield return new uspop(1810, 7.24);
                yield return new uspop(1820, 9.64);
                yield return new uspop(1830, 12.9);
                yield return new uspop(1840, 17.1);
                yield return new uspop(1850, 23.2);
                yield return new uspop(1860, 31.4);
                yield return new uspop(1870, 39.8);
                yield return new uspop(1880, 50.2);
                yield return new uspop(1890, 62.9);
                yield return new uspop(1900, 76);
                yield return new uspop(1910, 92);
                yield return new uspop(1920, 105.7);
                yield return new uspop(1930, 122.8);
                yield return new uspop(1940, 131.7);
                yield return new uspop(1950, 151.3);
                yield return new uspop(1960, 179.3);
                yield return new uspop(1970, 203.2);
            }
        }
    }
}
