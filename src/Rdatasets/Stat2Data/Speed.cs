// ReSharper disable All

namespace Rdatasets.Stat2Data
{
    using System.Collections.Generic;

    /// <summary>
    /// Speed
    /// </summary>

    public class Speed
    {
        public readonly int Year;
        public readonly double FatalityRate;
        public readonly int StateControl;

        public Speed(int Year, double FatalityRate, int StateControl)
        {
            this.Year = Year;
            this.FatalityRate = FatalityRate;
            this.StateControl = StateControl;
        }

        public static IEnumerable<Speed> Data
        {
            get
            {
                yield return new Speed(1987, 2.41, 0);
                yield return new Speed(1988, 2.32, 0);
                yield return new Speed(1989, 2.17, 0);
                yield return new Speed(1990, 2.08, 0);
                yield return new Speed(1991, 1.91, 0);
                yield return new Speed(1992, 1.75, 0);
                yield return new Speed(1993, 1.75, 0);
                yield return new Speed(1994, 1.73, 0);
                yield return new Speed(1995, 1.72, 1);
                yield return new Speed(1996, 1.69, 1);
                yield return new Speed(1997, 1.65, 1);
                yield return new Speed(1998, 1.58, 1);
                yield return new Speed(1999, 1.55, 1);
                yield return new Speed(2000, 1.53, 1);
                yield return new Speed(2001, 1.51, 1);
                yield return new Speed(2002, 1.51, 1);
                yield return new Speed(2003, 1.48, 1);
                yield return new Speed(2004, 1.44, 1);
                yield return new Speed(2005, 1.46, 1);
                yield return new Speed(2006, 1.42, 1);
                yield return new Speed(2007, 1.36, 1);
            }
        }
    }
}
