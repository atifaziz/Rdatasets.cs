// ReSharper disable All

namespace Rdatasets.fpp2
{
    using System.Collections.Generic;

    /// <summary>
    /// Rice production (Guinea)
    /// </summary>

    public class guinearice
    {
        public readonly int κ;
        public readonly int time;
        public readonly double value;

        public guinearice(int κ, int time, double value)
        {
            this.κ = κ;
            this.time = time;
            this.value = value;
        }

        public static IEnumerable<guinearice> Data
        {
            get
            {
                yield return new guinearice(1, 1970, 0.311405);
                yield return new guinearice(2, 1971, 0.32518);
                yield return new guinearice(3, 1972, 0.339565);
                yield return new guinearice(4, 1973, 0.35458);
                yield return new guinearice(5, 1974, 0.370265);
                yield return new guinearice(6, 1975, 0.38664);
                yield return new guinearice(7, 1976, 0.40374);
                yield return new guinearice(8, 1977, 0.4216);
                yield return new guinearice(9, 1978, 0.44025);
                yield return new guinearice(10, 1979, 0.45972);
                yield return new guinearice(11, 1980, 0.480055);
                yield return new guinearice(12, 1981, 0.50129);
                yield return new guinearice(13, 1982, 0.52346);
                yield return new guinearice(14, 1983, 0.54661);
                yield return new guinearice(15, 1984, 0.57079);
                yield return new guinearice(16, 1985, 0.596035);
                yield return new guinearice(17, 1986, 0.622395);
                yield return new guinearice(18, 1987, 0.649925);
                yield return new guinearice(19, 1988, 0.67867);
                yield return new guinearice(20, 1989, 0.70869);
                yield return new guinearice(21, 1990, 0.740035);
                yield return new guinearice(22, 1991, 0.772765);
                yield return new guinearice(23, 1992, 0.806945);
                yield return new guinearice(24, 1993, 0.842635);
                yield return new guinearice(25, 1994, 0.879905);
                yield return new guinearice(26, 1995, 0.918825);
                yield return new guinearice(27, 1996, 0.95946);
                yield return new guinearice(28, 1997, 1.0019);
                yield return new guinearice(29, 1998, 1.04622);
                yield return new guinearice(30, 1999, 1.09249);
                yield return new guinearice(31, 2000, 1.14081);
                yield return new guinearice(32, 2001, 1.03352);
                yield return new guinearice(33, 2002, 1.08867);
                yield return new guinearice(34, 2003, 1.14676);
                yield return new guinearice(35, 2004, 1.20796);
                yield return new guinearice(36, 2005, 1.27242);
                yield return new guinearice(37, 2006, 1.34031);
                yield return new guinearice(38, 2007, 1.40159);
                yield return new guinearice(39, 2008, 1.53409);
                yield return new guinearice(40, 2009, 1.45593);
                yield return new guinearice(41, 2010, 1.49896);
                yield return new guinearice(42, 2011, 1.5);
            }
        }
    }
}
