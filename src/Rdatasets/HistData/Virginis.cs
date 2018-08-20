// ReSharper disable All

namespace Rdatasets.HistData
{
    using System.Collections.Generic;

    /// <summary>
    /// John F. W. Herschel's Data on the Orbit of the Twin Stars gamma _Virginis_
    /// </summary>

    public class Virginis
    {
        public readonly double year;
        public readonly double? posangle;
        public readonly double? distance;
        public readonly double weight;
        public readonly string notes;
        public readonly string authority;

        public Virginis(double year, double? posangle, double? distance, double weight, string notes, string authority)
        {
            this.year = year;
            this.posangle = posangle;
            this.distance = distance;
            this.weight = weight;
            this.notes = notes;
            this.authority = authority;
        }

        public static IEnumerable<Virginis> Data
        {
            get
            {
                yield return new Virginis(1718.19, 160.8666667, null, 4, "Pound", "Pound");
                yield return new Virginis(1718.2, 160.8666667, null, 4, "Bradley", "Bradley");
                yield return new Virginis(1720.31, 139.1166667, 7.49, 0.1, "Cassini  very uncertain", "Cassini");
                yield return new Virginis(1756, 144.3666667, 6.5, 4, "Mayer", "Mayer");
                yield return new Virginis(1780.06, null, 5.7, 4, "H. Catal. 1782", "H");
                yield return new Virginis(1781.89, 130.7333333, null, 4, "H. Catal  1782", "H");
                yield return new Virginis(1803.2, 120.25, null, 8, "H. Mean of 8 measures", "H");
                yield return new Virginis(1819.4, null, 3.56, 4, "Sigma  Descriptio Tubi Fraunhof., p. 17", "Sigma");
                yield return new Virginis(1820.2, 105.25, null, 4, "Sigma. Addit. Dorp. Obs., ii 178", "Sigma");
                yield return new Virginis(1822.25, 103.4, 3.79, 4, "Sh. Phil Trans 1824", "Sh");
                yield return new Virginis(1822.5, 102.4, null, 4, "Sigma  Descriptio Tubi Fraunhof., p. 17", "Sigma");
                yield return new Virginis(1825.32, 96.88333333, 3.26, 4, "S. Phil Trans", "S");
                yield return new Virginis(1825.35, 97.96666667, 2.38, 4, "Sigma DTF & Mem Ast Soc; mean of dates ", "Sigma");
                yield return new Virginis(1828.35, 90.5, null, 1, "h. One night measure. No reliance", "h");
                yield return new Virginis(1829.16, null, 1.79, 2, "h. 2 nights obs", "h");
                yield return new Virginis(1829.22, 87.71666667, null, 2, "h. 2 nights obs", "h");
                yield return new Virginis(1830.24, null, 2.22, 6, "h. 6 nights obs", "h");
                yield return new Virginis(1830.38, 82.08333333, null, 6, "h. 6 nights obs", "h");
            }
        }
    }
}
