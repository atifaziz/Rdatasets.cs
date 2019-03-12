// ReSharper disable All

namespace Rdatasets.Ecdat
{
    using System.Collections.Generic;

    /// <summary>
    /// Growth of CRAN
    /// </summary>

    public class CRANpackages
    {
        public readonly int κ;
        public readonly double Version;
        public readonly string Date;
        public readonly int Packages;
        public readonly string Source;

        public CRANpackages(int κ, double Version, string Date, int Packages, string Source)
        {
            this.κ = κ;
            this.Version = Version;
            this.Date = Date;
            this.Packages = Packages;
            this.Source = Source;
        }

        public static IEnumerable<CRANpackages> Data
        {
            get
            {
                yield return new CRANpackages(1, 1.3, "2001-06-21", 110, "John Fox ");
                yield return new CRANpackages(2, 1.4, "2001-12-17", 129, "John Fox ");
                yield return new CRANpackages(3, 1.5, "2002-05-29", 162, "John Fox ");
                yield return new CRANpackages(4, 1.6, "2002-10-01", 163, "John Fox, updated");
                yield return new CRANpackages(5, 1.7, "2003-05-27", 219, "John Fox ");
                yield return new CRANpackages(6, 1.8, "2003-11-16", 273, "John Fox ");
                yield return new CRANpackages(7, 1.9, "2004-06-05", 357, "John Fox ");
                yield return new CRANpackages(8, 2.0, "2004-10-12", 406, "John Fox ");
                yield return new CRANpackages(9, 2.1, "2005-06-18", 548, "John Fox ");
                yield return new CRANpackages(10, 2.2, "2005-12-16", 647, "John Fox ");
                yield return new CRANpackages(11, 2.3, "2006-05-31", 739, "John Fox ");
                yield return new CRANpackages(12, 2.4, "2006-12-12", 911, "John Fox ");
                yield return new CRANpackages(13, 2.5, "2007-04-12", 1000, "John Fox ");
                yield return new CRANpackages(14, 2.6, "2007-11-16", 1300, "John Fox ");
                yield return new CRANpackages(15, 2.7, "2008-03-18", 1427, "John Fox ");
                yield return new CRANpackages(16, 2.8, "2008-10-18", 1614, "John Fox ");
                yield return new CRANpackages(17, 2.9, "2009-04-17", 1952, "John Fox ");
                yield return new CRANpackages(18, 2.10, "2009-10-26", 2088, "John Fox ");
                yield return new CRANpackages(19, 2.11, "2010-04-22", 2445, "John Fox ");
                yield return new CRANpackages(20, 2.12, "2010-10-15", 2837, "John Fox ");
                yield return new CRANpackages(21, 2.13, "2011-04-13", 3286, "John Fox ");
                yield return new CRANpackages(22, 2.14, "2011-06-20", 3618, "John Fox ");
                yield return new CRANpackages(23, 2.14, "2012-06-12", 3786, "Spencer Graves");
                yield return new CRANpackages(24, 2.15, "2012-07-07", 4000, "John Fox ");
                yield return new CRANpackages(25, 2.15, "2012-11-01", 4082, "Spencer Graves");
                yield return new CRANpackages(26, 2.15, "2012-12-14", 4210, "Spencer Graves");
                yield return new CRANpackages(27, 2.15, "2013-10-28", 4960, "Spencer Graves");
                yield return new CRANpackages(28, 2.15, "2013-11-08", 5000, "Spencer Graves");
                yield return new CRANpackages(29, 3.1, "2014-04-13", 5428, "Spencer Graves");
            }
        }
    }
}
