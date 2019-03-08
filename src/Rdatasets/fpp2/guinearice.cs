// ReSharper disable All

namespace Rdatasets.fpp2
{
    using System.Collections.Generic;

    /// <summary>
    /// Rice production (Guinea)
    /// </summary>

    public class guinearice
    {
        public readonly int time;
        public readonly double value;

        public guinearice(int time, double value)
        {
            this.time = time;
            this.value = value;
        }

        public static IEnumerable<guinearice> Data
        {
            get
            {
                yield return new guinearice(1970, 0.311405);
                yield return new guinearice(1971, 0.32518);
                yield return new guinearice(1972, 0.339565);
                yield return new guinearice(1973, 0.35458);
                yield return new guinearice(1974, 0.370265);
                yield return new guinearice(1975, 0.38664);
                yield return new guinearice(1976, 0.40374);
                yield return new guinearice(1977, 0.4216);
                yield return new guinearice(1978, 0.44025);
                yield return new guinearice(1979, 0.45972);
                yield return new guinearice(1980, 0.480055);
                yield return new guinearice(1981, 0.50129);
                yield return new guinearice(1982, 0.52346);
                yield return new guinearice(1983, 0.54661);
                yield return new guinearice(1984, 0.57079);
                yield return new guinearice(1985, 0.596035);
                yield return new guinearice(1986, 0.622395);
                yield return new guinearice(1987, 0.649925);
                yield return new guinearice(1988, 0.67867);
                yield return new guinearice(1989, 0.70869);
                yield return new guinearice(1990, 0.740035);
                yield return new guinearice(1991, 0.772765);
                yield return new guinearice(1992, 0.806945);
                yield return new guinearice(1993, 0.842635);
                yield return new guinearice(1994, 0.879905);
                yield return new guinearice(1995, 0.918825);
                yield return new guinearice(1996, 0.95946);
                yield return new guinearice(1997, 1.0019);
                yield return new guinearice(1998, 1.04622);
                yield return new guinearice(1999, 1.09249);
                yield return new guinearice(2000, 1.14081);
                yield return new guinearice(2001, 1.03352);
                yield return new guinearice(2002, 1.08867);
                yield return new guinearice(2003, 1.14676);
                yield return new guinearice(2004, 1.20796);
                yield return new guinearice(2005, 1.27242);
                yield return new guinearice(2006, 1.34031);
                yield return new guinearice(2007, 1.40159);
                yield return new guinearice(2008, 1.53409);
                yield return new guinearice(2009, 1.45593);
                yield return new guinearice(2010, 1.49896);
                yield return new guinearice(2011, 1.5);
            }
        }
    }
}
