// ReSharper disable All

namespace Rdatasets.fpp2
{
    using System.Collections.Generic;

    /// <summary>
    /// Electricity sales to residential customers in South Australia.
    /// </summary>

    public class elecsales
    {
        public readonly int time;
        public readonly double value;

        public elecsales(int time, double value)
        {
            this.time = time;
            this.value = value;
        }

        public static IEnumerable<elecsales> Data
        {
            get
            {
                yield return new elecsales(1989, 2354.34);
                yield return new elecsales(1990, 2379.71);
                yield return new elecsales(1991, 2318.52);
                yield return new elecsales(1992, 2468.99);
                yield return new elecsales(1993, 2386.09);
                yield return new elecsales(1994, 2569.47);
                yield return new elecsales(1995, 2575.72);
                yield return new elecsales(1996, 2762.72);
                yield return new elecsales(1997, 2844.5);
                yield return new elecsales(1998, 3000.7);
                yield return new elecsales(1999, 3108.1);
                yield return new elecsales(2000, 3357.5);
                yield return new elecsales(2001, 3075.7);
                yield return new elecsales(2002, 3180.6);
                yield return new elecsales(2003, 3221.6);
                yield return new elecsales(2004, 3176.2);
                yield return new elecsales(2005, 3430.6);
                yield return new elecsales(2006, 3527.48);
                yield return new elecsales(2007, 3637.89);
                yield return new elecsales(2008, 3655);
            }
        }
    }
}
