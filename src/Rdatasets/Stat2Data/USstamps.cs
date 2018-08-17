// ReSharper disable All

namespace Rdatasets.Stat2Data
{
    using System.Collections.Generic;

    /// <summary>
    /// USstamps
    /// </summary>

    public class USstamps
    {
        public readonly int Year;
        public readonly int Price;

        public USstamps(int Year, int Price)
        {
            this.Year = Year;
            this.Price = Price;
        }

        public static IEnumerable<USstamps> Data
        {
            get
            {
                yield return new USstamps(1885, 2);
                yield return new USstamps(1917, 3);
                yield return new USstamps(1919, 2);
                yield return new USstamps(1932, 3);
                yield return new USstamps(1958, 4);
                yield return new USstamps(1963, 5);
                yield return new USstamps(1968, 6);
                yield return new USstamps(1971, 8);
                yield return new USstamps(1974, 10);
                yield return new USstamps(1975, 13);
                yield return new USstamps(1978, 15);
                yield return new USstamps(1981, 18);
                yield return new USstamps(1981, 20);
                yield return new USstamps(1985, 22);
                yield return new USstamps(1988, 25);
                yield return new USstamps(1991, 29);
                yield return new USstamps(1995, 32);
                yield return new USstamps(1999, 33);
                yield return new USstamps(2001, 34);
                yield return new USstamps(2002, 37);
                yield return new USstamps(2006, 39);
                yield return new USstamps(2007, 41);
                yield return new USstamps(2008, 42);
                yield return new USstamps(2009, 44);
                yield return new USstamps(2012, 45);
            }
        }
    }
}
