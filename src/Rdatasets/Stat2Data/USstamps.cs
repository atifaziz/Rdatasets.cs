// ReSharper disable All

namespace Rdatasets.Stat2Data
{
    using System.Collections.Generic;

    /// <summary>
    /// USstamps
    /// </summary>

    public class USstamps
    {
        public readonly int κ;
        public readonly int Year;
        public readonly int Price;

        public USstamps(int κ, int Year, int Price)
        {
            this.κ = κ;
            this.Year = Year;
            this.Price = Price;
        }

        public static IEnumerable<USstamps> Data
        {
            get
            {
                yield return new USstamps(1, 1885, 2);
                yield return new USstamps(2, 1917, 3);
                yield return new USstamps(3, 1919, 2);
                yield return new USstamps(4, 1932, 3);
                yield return new USstamps(5, 1958, 4);
                yield return new USstamps(6, 1963, 5);
                yield return new USstamps(7, 1968, 6);
                yield return new USstamps(8, 1971, 8);
                yield return new USstamps(9, 1974, 10);
                yield return new USstamps(10, 1975, 13);
                yield return new USstamps(11, 1978, 15);
                yield return new USstamps(12, 1981, 18);
                yield return new USstamps(13, 1981, 20);
                yield return new USstamps(14, 1985, 22);
                yield return new USstamps(15, 1988, 25);
                yield return new USstamps(16, 1991, 29);
                yield return new USstamps(17, 1995, 32);
                yield return new USstamps(18, 1999, 33);
                yield return new USstamps(19, 2001, 34);
                yield return new USstamps(20, 2002, 37);
                yield return new USstamps(21, 2006, 39);
                yield return new USstamps(22, 2007, 41);
                yield return new USstamps(23, 2008, 42);
                yield return new USstamps(24, 2009, 44);
                yield return new USstamps(25, 2012, 45);
            }
        }
    }
}
