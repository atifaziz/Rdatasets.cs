// ReSharper disable All

namespace Rdatasets.datasets
{
    using System.Collections.Generic;

    /// <summary>
    /// Populations Recorded by the US Census
    /// </summary>

    public class uspop
    {
        public readonly int κ;
        public readonly int time;
        public readonly double value;

        public uspop(int κ, int time, double value)
        {
            this.κ = κ;
            this.time = time;
            this.value = value;
        }

        public static IEnumerable<uspop> Data
        {
            get
            {
                yield return new uspop(1, 1790, 3.93);
                yield return new uspop(2, 1800, 5.31);
                yield return new uspop(3, 1810, 7.24);
                yield return new uspop(4, 1820, 9.64);
                yield return new uspop(5, 1830, 12.9);
                yield return new uspop(6, 1840, 17.1);
                yield return new uspop(7, 1850, 23.2);
                yield return new uspop(8, 1860, 31.4);
                yield return new uspop(9, 1870, 39.8);
                yield return new uspop(10, 1880, 50.2);
                yield return new uspop(11, 1890, 62.9);
                yield return new uspop(12, 1900, 76);
                yield return new uspop(13, 1910, 92);
                yield return new uspop(14, 1920, 105.7);
                yield return new uspop(15, 1930, 122.8);
                yield return new uspop(16, 1940, 131.7);
                yield return new uspop(17, 1950, 151.3);
                yield return new uspop(18, 1960, 179.3);
                yield return new uspop(19, 1970, 203.2);
            }
        }
    }
}
