// ReSharper disable All

namespace Rdatasets.Stat2Data
{
    using System.Collections.Generic;

    /// <summary>
    /// Retirement
    /// </summary>

    public class Retirement
    {
        public readonly int Year;
        public readonly double SRA;

        public Retirement(int Year, double SRA)
        {
            this.Year = Year;
            this.SRA = SRA;
        }

        public static IEnumerable<Retirement> Data
        {
            get
            {
                yield return new Retirement(1997, 787.08);
                yield return new Retirement(1998, 968.16);
                yield return new Retirement(1999, 1975.08);
                yield return new Retirement(2000, 3990);
                yield return new Retirement(2001, 5455.8);
                yield return new Retirement(2002, 6338.6);
                yield return new Retirement(2003, 566.25);
                yield return new Retirement(2004, 7014.9);
                yield return new Retirement(2005, 10500);
                yield return new Retirement(2006, 10945.06);
                yield return new Retirement(2007, 12250.8);
                yield return new Retirement(2008, 13035.45);
                yield return new Retirement(2009, 13053.15);
                yield return new Retirement(2010, 14993.6);
                yield return new Retirement(2011, 952.04);
                yield return new Retirement(2012, 17349.69);
            }
        }
    }
}
