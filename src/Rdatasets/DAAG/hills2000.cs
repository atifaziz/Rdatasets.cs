// ReSharper disable All

namespace Rdatasets.DAAG
{
    using System.Collections.Generic;

    /// <summary>
    /// Scottish Hill Races Data - 2000
    /// </summary>

    public class hills2000
    {
        public readonly double dist;
        public readonly int climb;
        public readonly double time;
        public readonly string timef;

        public hills2000(double dist, int climb, double time, string timef)
        {
            this.dist = dist;
            this.climb = climb;
            this.time = time;
            this.timef = timef;
        }

        public static IEnumerable<hills2000> Data
        {
            get
            {
                yield return new hills2000(6, 2500, 0.782222222222222, "0.919166666666667");
                yield return new hills2000(7, 1800, 0.793333333333333, "1.00333333333333");
                yield return new hills2000(1.5, 1400, 0.314444444444444, "0.376666666666667");
                yield return new hills2000(5, 700, 0.464166666666667, "0.609166666666667");
                yield return new hills2000(6, 900, 0.546111111111111, "0.625833333333333");
                yield return new hills2000(5, 1200, 0.623333333333333, "0.734166666666667");
                yield return new hills2000(4, 1300, 0.458888888888889, "0.543611111111111");
                yield return new hills2000(10.5, 3500, 1.27888888888889, "1.48777777777778");
                yield return new hills2000(3.5, 800, 0.395555555555556, "0.464166666666667");
                yield return new hills2000(14, 5000, 1.98333333333333, "2.39888888888889");
                yield return new hills2000(5, 1250, 0.552777777777778, "0.637777777777778");
                yield return new hills2000(9, 3192, 1.03777777777778, "1.19916666666667");
                yield return new hills2000(4, 800, 0.387222222222222, "0.4525");
                yield return new hills2000(8, 2866, 1.22777777777778, "1.52638888888889");
                yield return new hills2000(3.5, 1250, 0.431111111111111, "0.54");
                yield return new hills2000(7, 600, 0.678888888888889, "0.837222222222222");
                yield return new hills2000(5, 800, 0.495833333333333, "0.579166666666667");
                yield return new hills2000(5.5, 800, 0.618333333333333, null);
                yield return new hills2000(46, 7500, 8.30694444444445, "13.5477777777778");
                yield return new hills2000(6, 1400, 0.739722222222222, "0.874166666666667");
                yield return new hills2000(6.5, 650, 0.623888888888889, "0.748611111111111");
                yield return new hills2000(8, 2500, 1.19305555555556, "1.45111111111111");
                yield return new hills2000(2.5, 1400, 0.381666666666667, "0.484722222222222");
                yield return new hills2000(13, 5500, 2.22027777777778, "2.70472222222222");
                yield return new hills2000(10, 2000, 1.19805555555556, "1.44972222222222");
                yield return new hills2000(6, 1500, 0.742222222222222, "0.870277777777778");
                yield return new hills2000(6, 900, 0.572777777777778, "0.695");
                yield return new hills2000(6, 2000, 0.638333333333333, "0.773611111111111");
                yield return new hills2000(9, 2950, 1.32777777777778, "1.78277777777778");
                yield return new hills2000(4, 600, 0.447777777777778, "0.532222222222222");
                yield return new hills2000(4.5, 2400, 0.744722222222222, "0.936111111111111");
                yield return new hills2000(6, 1400, 0.773888888888889, "1.015");
                yield return new hills2000(5.5, 728, 0.508888888888889, "0.768333333333333");
                yield return new hills2000(3.5, 1500, 0.465, "0.609722222222222");
                yield return new hills2000(2, 900, 0.284722222222222, "0.360555555555556");
                yield return new hills2000(2, 900, 0.294166666666667, "0.473055555555556");
                yield return new hills2000(6, 2500, 0.794166666666667, "1.05194444444444");
                yield return new hills2000(14, 4900, 1.97611111111111, "2.35583333333333");
                yield return new hills2000(7, 500, 0.716666666666667, "0.943333333333333");
                yield return new hills2000(3, 1223, 0.463888888888889, "0.601666666666667");
                yield return new hills2000(15, 5500, 2.56722222222222, "2.96222222222222");
                yield return new hills2000(2.5, 800, 0.208611111111111, "0.246666666666667");
                yield return new hills2000(5.5, 741, 0.563611111111111, "0.724166666666667");
                yield return new hills2000(6, 1220, 0.665833333333333, "0.817777777777778");
                yield return new hills2000(9, 2200, 1.05305555555556, "1.29388888888889");
                yield return new hills2000(2.25, 500, 0.232222222222222, "0.298888888888889");
                yield return new hills2000(10, 4400, 1.42611111111111, "1.72361111111111");
                yield return new hills2000(2, 1500, 0.332222222222222, "0.436944444444444");
                yield return new hills2000(6, 1400, 0.704444444444444, "0.809722222222222");
                yield return new hills2000(16, 2250, 1.66472222222222, "1.96333333333333");
                yield return new hills2000(5, 1700, 0.609166666666667, "0.785833333333333");
                yield return new hills2000(8, 2710, 1.13333333333333, "1.39472222222222");
                yield return new hills2000(18, 4900, 2.56583333333333, "3.08833333333333");
                yield return new hills2000(10, 2300, 1.18444444444444, "1.4975");
                yield return new hills2000(16, 6200, 2.37777777777778, "2.785");
                yield return new hills2000(4.5, 1500, 0.499444444444444, "0.581111111111111");
            }
        }
    }
}
