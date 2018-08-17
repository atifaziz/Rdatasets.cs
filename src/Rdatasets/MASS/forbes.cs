// ReSharper disable All

namespace Rdatasets.MASS
{
    using System.Collections.Generic;

    /// <summary>
    /// Forbes' Data on Boiling Points in the Alps
    /// </summary>

    public class forbes
    {
        public readonly double bp;
        public readonly double pres;

        public forbes(double bp, double pres)
        {
            this.bp = bp;
            this.pres = pres;
        }

        public static IEnumerable<forbes> Data
        {
            get
            {
                yield return new forbes(194.5, 20.79);
                yield return new forbes(194.3, 20.79);
                yield return new forbes(197.9, 22.4);
                yield return new forbes(198.4, 22.67);
                yield return new forbes(199.4, 23.15);
                yield return new forbes(199.9, 23.35);
                yield return new forbes(200.9, 23.89);
                yield return new forbes(201.1, 23.99);
                yield return new forbes(201.4, 24.02);
                yield return new forbes(201.3, 24.01);
                yield return new forbes(203.6, 25.14);
                yield return new forbes(204.6, 26.57);
                yield return new forbes(209.5, 28.49);
                yield return new forbes(208.6, 27.76);
                yield return new forbes(210.7, 29.04);
                yield return new forbes(211.9, 29.88);
                yield return new forbes(212.2, 30.06);
            }
        }
    }
}
