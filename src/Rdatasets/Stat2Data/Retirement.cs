// ReSharper disable All

namespace Rdatasets.Stat2Data
{
    using System.Collections.Generic;

    /// <summary>
    /// Retirement
    /// </summary>

    public class Retirement
    {
        public readonly int κ;
        public readonly int Year;
        public readonly double SRA;

        public Retirement(int κ, int Year, double SRA)
        {
            this.κ = κ;
            this.Year = Year;
            this.SRA = SRA;
        }

        public static IEnumerable<Retirement> Data
        {
            get
            {
                yield return new Retirement(1, 1997, 787.08);
                yield return new Retirement(2, 1998, 968.16);
                yield return new Retirement(3, 1999, 1975.08);
                yield return new Retirement(4, 2000, 3990);
                yield return new Retirement(5, 2001, 5455.8);
                yield return new Retirement(6, 2002, 6338.6);
                yield return new Retirement(7, 2003, 566.25);
                yield return new Retirement(8, 2004, 7014.9);
                yield return new Retirement(9, 2005, 10500);
                yield return new Retirement(10, 2006, 10945.06);
                yield return new Retirement(11, 2007, 12250.8);
                yield return new Retirement(12, 2008, 13035.45);
                yield return new Retirement(13, 2009, 13053.15);
                yield return new Retirement(14, 2010, 14993.6);
                yield return new Retirement(15, 2011, 952.04);
                yield return new Retirement(16, 2012, 17349.69);
            }
        }
    }
}
