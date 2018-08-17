// ReSharper disable All

namespace Rdatasets.MASS
{
    using System.Collections.Generic;

    /// <summary>
    /// Ecological Factors in Farm Management
    /// </summary>

    public class farms
    {
        public readonly string Mois;
        public readonly string Manag;
        public readonly string Use;
        public readonly string Manure;

        public farms(string Mois, string Manag, string Use, string Manure)
        {
            this.Mois = Mois;
            this.Manag = Manag;
            this.Use = Use;
            this.Manure = Manure;
        }

        public static IEnumerable<farms> Data
        {
            get
            {
                yield return new farms("M1", "SF", "U2", "C4");
                yield return new farms("M1", "BF", "U2", "C2");
                yield return new farms("M2", "SF", "U2", "C4");
                yield return new farms("M2", "SF", "U2", "C4");
                yield return new farms("M1", "HF", "U1", "C2");
                yield return new farms("M1", "HF", "U2", "C2");
                yield return new farms("M1", "HF", "U3", "C3");
                yield return new farms("M5", "HF", "U3", "C3");
                yield return new farms("M4", "HF", "U1", "C1");
                yield return new farms("M2", "BF", "U1", "C1");
                yield return new farms("M1", "BF", "U3", "C1");
                yield return new farms("M4", "SF", "U2", "C2");
                yield return new farms("M5", "SF", "U2", "C3");
                yield return new farms("M5", "NM", "U3", "C0");
                yield return new farms("M5", "NM", "U2", "C0");
                yield return new farms("M5", "SF", "U3", "C3");
                yield return new farms("M2", "NM", "U1", "C0");
                yield return new farms("M1", "NM", "U1", "C0");
                yield return new farms("M5", "NM", "U1", "C0");
                yield return new farms("M5", "NM", "U1", "C0");
            }
        }
    }
}
