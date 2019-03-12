// ReSharper disable All

namespace Rdatasets.MASS
{
    using System.Collections.Generic;

    /// <summary>
    /// Ecological Factors in Farm Management
    /// </summary>

    public class farms
    {
        public readonly int κ;
        public readonly string Mois;
        public readonly string Manag;
        public readonly string Use;
        public readonly string Manure;

        public farms(int κ, string Mois, string Manag, string Use, string Manure)
        {
            this.κ = κ;
            this.Mois = Mois;
            this.Manag = Manag;
            this.Use = Use;
            this.Manure = Manure;
        }

        public static IEnumerable<farms> Data
        {
            get
            {
                yield return new farms(1, "M1", "SF", "U2", "C4");
                yield return new farms(2, "M1", "BF", "U2", "C2");
                yield return new farms(3, "M2", "SF", "U2", "C4");
                yield return new farms(4, "M2", "SF", "U2", "C4");
                yield return new farms(5, "M1", "HF", "U1", "C2");
                yield return new farms(6, "M1", "HF", "U2", "C2");
                yield return new farms(7, "M1", "HF", "U3", "C3");
                yield return new farms(8, "M5", "HF", "U3", "C3");
                yield return new farms(9, "M4", "HF", "U1", "C1");
                yield return new farms(10, "M2", "BF", "U1", "C1");
                yield return new farms(11, "M1", "BF", "U3", "C1");
                yield return new farms(12, "M4", "SF", "U2", "C2");
                yield return new farms(13, "M5", "SF", "U2", "C3");
                yield return new farms(14, "M5", "NM", "U3", "C0");
                yield return new farms(15, "M5", "NM", "U2", "C0");
                yield return new farms(16, "M5", "SF", "U3", "C3");
                yield return new farms(17, "M2", "NM", "U1", "C0");
                yield return new farms(18, "M1", "NM", "U1", "C0");
                yield return new farms(19, "M5", "NM", "U1", "C0");
                yield return new farms(20, "M5", "NM", "U1", "C0");
            }
        }
    }
}
