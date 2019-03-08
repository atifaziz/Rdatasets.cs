// ReSharper disable All

namespace Rdatasets.drc
{
    using System.Collections.Generic;

    /// <summary>
    /// Effect of sodium pentachlorophenate on growth of fathead minnow
    /// </summary>

    public class P_promelas
    {
        public readonly int conc;
        public readonly double dryweight;

        public P_promelas(int conc, double dryweight)
        {
            this.conc = conc;
            this.dryweight = dryweight;
        }

        public static IEnumerable<P_promelas> Data
        {
            get
            {
                yield return new P_promelas(0, 0.711);
                yield return new P_promelas(0, 0.662);
                yield return new P_promelas(0, 0.718);
                yield return new P_promelas(0, 0.767);
                yield return new P_promelas(32, 0.646);
                yield return new P_promelas(32, 0.626);
                yield return new P_promelas(32, 0.723);
                yield return new P_promelas(32, 0.7);
                yield return new P_promelas(64, 0.669);
                yield return new P_promelas(64, 0.669);
                yield return new P_promelas(64, 0.694);
                yield return new P_promelas(64, 0.676);
                yield return new P_promelas(128, 0.629);
                yield return new P_promelas(128, 0.68);
                yield return new P_promelas(128, 0.513);
                yield return new P_promelas(128, 0.672);
                yield return new P_promelas(256, 0.65);
                yield return new P_promelas(256, 0.558);
                yield return new P_promelas(256, 0.606);
                yield return new P_promelas(256, 0.508);
                yield return new P_promelas(512, 0.358);
                yield return new P_promelas(512, 0.543);
                yield return new P_promelas(512, 0.488);
                yield return new P_promelas(512, 0.495);
            }
        }
    }
}
