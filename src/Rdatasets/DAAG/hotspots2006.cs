// ReSharper disable All

namespace Rdatasets.DAAG
{
    using System.Collections.Generic;

    /// <summary>
    /// Hawaian island chain hotspot Argon-Argon ages
    /// </summary>

    public class hotspots2006
    {
        public readonly double age;
        public readonly double CI95lim;
        public readonly int geoErr;
        public readonly double totplus;
        public readonly double totminus;
        public readonly int distance;

        public hotspots2006(double age, double CI95lim, int geoErr, double totplus, double totminus, int distance)
        {
            this.age = age;
            this.CI95lim = CI95lim;
            this.geoErr = geoErr;
            this.totplus = totplus;
            this.totminus = totminus;
            this.distance = distance;
        }

        public static IEnumerable<hotspots2006> Data
        {
            get
            {
                yield return new hotspots2006(75.8, 0.6, 1, 1.17, 0.6, 5600);
                yield return new hotspots2006(60.9, 0.3, 1, 1.04, 0.3, 4860);
                yield return new hotspots2006(56.3, 0.4, 1, 1.08, 0.4, 4500);
                yield return new hotspots2006(52.6, 0.8, 1, 1.28, 0.8, 3812);
                yield return new hotspots2006(50.4, 0.1, 1, 1, 0.1, 3758);
                yield return new hotspots2006(47.9, 0.2, 1, 1.02, 0.2, 3668);
                yield return new hotspots2006(46.7, 0.1, 1, 1, 0.1, 3493);
                yield return new hotspots2006(41.5, 0.3, 1, 1.04, 0.3, 3280);
                yield return new hotspots2006(38.7, 0.2, 5, 5, 0.2, 3128);
                yield return new hotspots2006(31, 0.2, 1, 1.02, 0.2, 2600);
            }
        }
    }
}
