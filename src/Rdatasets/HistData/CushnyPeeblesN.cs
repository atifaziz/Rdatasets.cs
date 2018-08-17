// ReSharper disable All

namespace Rdatasets.HistData
{
    using System.Collections.Generic;

    /// <summary>
    /// Cushny-Peebles Data: Soporific Effects of Scopolamine Derivatives
    /// </summary>

    public class CushnyPeeblesN
    {
        public readonly int Control;
        public readonly int L_hyoscyamine;
        public readonly int L_hyoscine;
        public readonly int DL_hyoscine;

        public CushnyPeeblesN(int Control, int L_hyoscyamine, int L_hyoscine, int DL_hyoscine)
        {
            this.Control = Control;
            this.L_hyoscyamine = L_hyoscyamine;
            this.L_hyoscine = L_hyoscine;
            this.DL_hyoscine = DL_hyoscine;
        }

        public static IEnumerable<CushnyPeeblesN> Data
        {
            get
            {
                yield return new CushnyPeeblesN(9, 6, 6, 6);
                yield return new CushnyPeeblesN(9, 6, 6, 6);
                yield return new CushnyPeeblesN(8, 6, 6, 6);
                yield return new CushnyPeeblesN(9, 3, 3, 3);
                yield return new CushnyPeeblesN(9, 3, 3, 3);
                yield return new CushnyPeeblesN(8, 4, 3, 3);
                yield return new CushnyPeeblesN(8, 3, 3, 3);
                yield return new CushnyPeeblesN(7, 6, 6, 5);
                yield return new CushnyPeeblesN(8, 5, 6, 5);
                yield return new CushnyPeeblesN(9, 5, 5, 6);
                yield return new CushnyPeeblesN(0, 2, 2, 2);
            }
        }
    }
}
