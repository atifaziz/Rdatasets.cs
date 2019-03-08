// ReSharper disable All

namespace Rdatasets.fpp2
{
    using System.Collections.Generic;

    /// <summary>
    /// Maximum annual temperatures at Moorabbin Airport, Melbourne
    /// </summary>

    public class maxtemp
    {
        public readonly int time;
        public readonly double value;

        public maxtemp(int time, double value)
        {
            this.time = time;
            this.value = value;
        }

        public static IEnumerable<maxtemp> Data
        {
            get
            {
                yield return new maxtemp(1971, 34.6);
                yield return new maxtemp(1972, 39.3);
                yield return new maxtemp(1973, 40.5);
                yield return new maxtemp(1974, 36.8);
                yield return new maxtemp(1975, 39.7);
                yield return new maxtemp(1976, 40.5);
                yield return new maxtemp(1977, 41.5);
                yield return new maxtemp(1978, 38.2);
                yield return new maxtemp(1979, 41.4);
                yield return new maxtemp(1980, 41.5);
                yield return new maxtemp(1981, 41.9);
                yield return new maxtemp(1982, 43.5);
                yield return new maxtemp(1983, 43.2);
                yield return new maxtemp(1984, 35.1);
                yield return new maxtemp(1985, 42.1);
                yield return new maxtemp(1986, 38.1);
                yield return new maxtemp(1987, 39.6);
                yield return new maxtemp(1988, 39.9);
                yield return new maxtemp(1989, 37.8);
                yield return new maxtemp(1990, 39);
                yield return new maxtemp(1991, 41.3);
                yield return new maxtemp(1992, 38.7);
                yield return new maxtemp(1993, 37.8);
                yield return new maxtemp(1994, 38.9);
                yield return new maxtemp(1995, 39.7);
                yield return new maxtemp(1996, 36.1);
                yield return new maxtemp(1997, 41.3);
                yield return new maxtemp(1998, 40.6);
                yield return new maxtemp(1999, 37.5);
                yield return new maxtemp(2000, 39.6);
                yield return new maxtemp(2001, 38.8);
                yield return new maxtemp(2002, 36.6);
                yield return new maxtemp(2003, 44.3);
                yield return new maxtemp(2004, 39.7);
                yield return new maxtemp(2005, 43);
                yield return new maxtemp(2006, 43.1);
                yield return new maxtemp(2007, 41.5);
                yield return new maxtemp(2008, 40.5);
                yield return new maxtemp(2009, 46.7);
                yield return new maxtemp(2010, 43.9);
                yield return new maxtemp(2011, 39.5);
                yield return new maxtemp(2012, 39.7);
                yield return new maxtemp(2013, 41.5);
                yield return new maxtemp(2014, 43.7);
                yield return new maxtemp(2015, 42.7);
                yield return new maxtemp(2016, 42.9);
            }
        }
    }
}
