// ReSharper disable All

namespace Rdatasets.drc
{
    using System.Collections.Generic;

    /// <summary>
    /// The effect of terbuthylazin on growth rate
    /// </summary>

    public class terbuthylazin
    {
        public readonly int κ;
        public readonly double dose;
        public readonly double rgr;

        public terbuthylazin(int κ, double dose, double rgr)
        {
            this.κ = κ;
            this.dose = dose;
            this.rgr = rgr;
        }

        public static IEnumerable<terbuthylazin> Data
        {
            get
            {
                yield return new terbuthylazin(1, 0, 0.301773087);
                yield return new terbuthylazin(2, 0, 0.276029147);
                yield return new terbuthylazin(3, 0, 0.314525678);
                yield return new terbuthylazin(4, 0, 0.266317413);
                yield return new terbuthylazin(5, 0, 0.287130279);
                yield return new terbuthylazin(6, 0, 0.38057718);
                yield return new terbuthylazin(7, 12.109375, 0.327505284);
                yield return new terbuthylazin(8, 12.109375, 0.281334937);
                yield return new terbuthylazin(9, 12.109375, 0.310153564);
                yield return new terbuthylazin(10, 24.21875, 0.281363466);
                yield return new terbuthylazin(11, 24.21875, 0.289717585);
                yield return new terbuthylazin(12, 24.21875, 0.288542754);
                yield return new terbuthylazin(13, 48.4375, 0.232920155);
                yield return new terbuthylazin(14, 48.4375, 0.265290594);
                yield return new terbuthylazin(15, 48.4375, 0.258416528);
                yield return new terbuthylazin(16, 96.875, 0.216333408);
                yield return new terbuthylazin(17, 96.875, 0.226247106);
                yield return new terbuthylazin(18, 96.875, 0.199386103);
                yield return new terbuthylazin(19, 193.75, 0.103517717);
                yield return new terbuthylazin(20, 193.75, 0.149762764);
                yield return new terbuthylazin(21, 193.75, 0.208224879);
                yield return new terbuthylazin(22, 387.5, 0.0785257);
                yield return new terbuthylazin(23, 387.5, 0.091162153);
                yield return new terbuthylazin(24, 387.5, 0.116551942);
                yield return new terbuthylazin(25, 775, 0.014877372);
                yield return new terbuthylazin(26, 775, 0.035288521);
                yield return new terbuthylazin(27, 775, 0.051944135);
                yield return new terbuthylazin(28, 1550, 0.012263292);
                yield return new terbuthylazin(29, 1550, 0.03711101);
                yield return new terbuthylazin(30, 1550, 0.033358339);
            }
        }
    }
}
