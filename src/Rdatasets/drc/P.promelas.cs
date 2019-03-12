// ReSharper disable All

namespace Rdatasets.drc
{
    using System.Collections.Generic;

    /// <summary>
    /// Effect of sodium pentachlorophenate on growth of fathead minnow
    /// </summary>

    public class P_promelas
    {
        public readonly int κ;
        public readonly int conc;
        public readonly double dryweight;

        public P_promelas(int κ, int conc, double dryweight)
        {
            this.κ = κ;
            this.conc = conc;
            this.dryweight = dryweight;
        }

        public static IEnumerable<P_promelas> Data
        {
            get
            {
                yield return new P_promelas(1, 0, 0.711);
                yield return new P_promelas(2, 0, 0.662);
                yield return new P_promelas(3, 0, 0.718);
                yield return new P_promelas(4, 0, 0.767);
                yield return new P_promelas(5, 32, 0.646);
                yield return new P_promelas(6, 32, 0.626);
                yield return new P_promelas(7, 32, 0.723);
                yield return new P_promelas(8, 32, 0.7);
                yield return new P_promelas(9, 64, 0.669);
                yield return new P_promelas(10, 64, 0.669);
                yield return new P_promelas(11, 64, 0.694);
                yield return new P_promelas(12, 64, 0.676);
                yield return new P_promelas(13, 128, 0.629);
                yield return new P_promelas(14, 128, 0.68);
                yield return new P_promelas(15, 128, 0.513);
                yield return new P_promelas(16, 128, 0.672);
                yield return new P_promelas(17, 256, 0.65);
                yield return new P_promelas(18, 256, 0.558);
                yield return new P_promelas(19, 256, 0.606);
                yield return new P_promelas(20, 256, 0.508);
                yield return new P_promelas(21, 512, 0.358);
                yield return new P_promelas(22, 512, 0.543);
                yield return new P_promelas(23, 512, 0.488);
                yield return new P_promelas(24, 512, 0.495);
            }
        }
    }
}
