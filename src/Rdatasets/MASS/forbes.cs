// ReSharper disable All

namespace Rdatasets.MASS
{
    using System.Collections.Generic;

    /// <summary>
    /// Forbes' Data on Boiling Points in the Alps
    /// </summary>

    public class forbes
    {
        public readonly int κ;
        public readonly double bp;
        public readonly double pres;

        public forbes(int κ, double bp, double pres)
        {
            this.κ = κ;
            this.bp = bp;
            this.pres = pres;
        }

        public static IEnumerable<forbes> Data
        {
            get
            {
                yield return new forbes(1, 194.5, 20.79);
                yield return new forbes(2, 194.3, 20.79);
                yield return new forbes(3, 197.9, 22.4);
                yield return new forbes(4, 198.4, 22.67);
                yield return new forbes(5, 199.4, 23.15);
                yield return new forbes(6, 199.9, 23.35);
                yield return new forbes(7, 200.9, 23.89);
                yield return new forbes(8, 201.1, 23.99);
                yield return new forbes(9, 201.4, 24.02);
                yield return new forbes(10, 201.3, 24.01);
                yield return new forbes(11, 203.6, 25.14);
                yield return new forbes(12, 204.6, 26.57);
                yield return new forbes(13, 209.5, 28.49);
                yield return new forbes(14, 208.6, 27.76);
                yield return new forbes(15, 210.7, 29.04);
                yield return new forbes(16, 211.9, 29.88);
                yield return new forbes(17, 212.2, 30.06);
            }
        }
    }
}
