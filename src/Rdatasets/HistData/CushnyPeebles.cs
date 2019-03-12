// ReSharper disable All

namespace Rdatasets.HistData
{
    using System.Collections.Generic;

    /// <summary>
    /// Cushny-Peebles Data: Soporific Effects of Scopolamine Derivatives
    /// </summary>

    public class CushnyPeebles
    {
        public readonly int κ;
        public readonly double? Control;
        public readonly double L_hyoscyamine;
        public readonly double L_hyoscine;
        public readonly double DL_hyoscine;

        public CushnyPeebles(int κ, double? Control, double L_hyoscyamine, double L_hyoscine, double DL_hyoscine)
        {
            this.κ = κ;
            this.Control = Control;
            this.L_hyoscyamine = L_hyoscyamine;
            this.L_hyoscine = L_hyoscine;
            this.DL_hyoscine = DL_hyoscine;
        }

        public static IEnumerable<CushnyPeebles> Data
        {
            get
            {
                yield return new CushnyPeebles(1, 0.6, 1.3, 2.5, 2.1);
                yield return new CushnyPeebles(2, 3, 1.4, 3.8, 4.4);
                yield return new CushnyPeebles(3, 4.7, 4.5, 5.8, 4.7);
                yield return new CushnyPeebles(4, 5.5, 4.3, 5.6, 4.8);
                yield return new CushnyPeebles(5, 6.2, 6.1, 6.1, 6.7);
                yield return new CushnyPeebles(6, 3.2, 6.6, 7.6, 8.3);
                yield return new CushnyPeebles(7, 2.5, 6.2, 8, 8.2);
                yield return new CushnyPeebles(8, 2.8, 3.6, 4.4, 4.3);
                yield return new CushnyPeebles(9, 1.1, 1.1, 5.7, 5.8);
                yield return new CushnyPeebles(10, 2.9, 4.9, 6.3, 6.4);
                yield return new CushnyPeebles(11, null, 6.3, 6.8, 7.3);
            }
        }
    }
}
