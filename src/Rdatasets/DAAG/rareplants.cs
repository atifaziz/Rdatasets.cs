// ReSharper disable All

namespace Rdatasets.DAAG
{
    using System.Collections.Generic;

    /// <summary>
    /// Rare and Endangered Plant Species
    /// </summary>

    public class rareplants
    {
        public readonly string κ;
        public readonly int D;
        public readonly int W;
        public readonly int WD;

        public rareplants(string κ, int D, int W, int WD)
        {
            this.κ = κ;
            this.D = D;
            this.W = W;
            this.WD = WD;
        }

        public static IEnumerable<rareplants> Data
        {
            get
            {
                yield return new rareplants("CC", 37, 190, 94);
                yield return new rareplants("CR", 23, 59, 23);
                yield return new rareplants("RC", 10, 141, 28);
                yield return new rareplants("RR", 15, 58, 16);
            }
        }
    }
}
