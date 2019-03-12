// ReSharper disable All

namespace Rdatasets.fpp2
{
    using System.Collections.Generic;

    /// <summary>
    /// Electricity sales to residential customers in South Australia.
    /// </summary>

    public class elecsales
    {
        public readonly int κ;
        public readonly int time;
        public readonly double value;

        public elecsales(int κ, int time, double value)
        {
            this.κ = κ;
            this.time = time;
            this.value = value;
        }

        public static IEnumerable<elecsales> Data
        {
            get
            {
                yield return new elecsales(1, 1989, 2354.34);
                yield return new elecsales(2, 1990, 2379.71);
                yield return new elecsales(3, 1991, 2318.52);
                yield return new elecsales(4, 1992, 2468.99);
                yield return new elecsales(5, 1993, 2386.09);
                yield return new elecsales(6, 1994, 2569.47);
                yield return new elecsales(7, 1995, 2575.72);
                yield return new elecsales(8, 1996, 2762.72);
                yield return new elecsales(9, 1997, 2844.5);
                yield return new elecsales(10, 1998, 3000.7);
                yield return new elecsales(11, 1999, 3108.1);
                yield return new elecsales(12, 2000, 3357.5);
                yield return new elecsales(13, 2001, 3075.7);
                yield return new elecsales(14, 2002, 3180.6);
                yield return new elecsales(15, 2003, 3221.6);
                yield return new elecsales(16, 2004, 3176.2);
                yield return new elecsales(17, 2005, 3430.6);
                yield return new elecsales(18, 2006, 3527.48);
                yield return new elecsales(19, 2007, 3637.89);
                yield return new elecsales(20, 2008, 3655);
            }
        }
    }
}
