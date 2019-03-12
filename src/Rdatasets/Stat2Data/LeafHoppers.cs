// ReSharper disable All

namespace Rdatasets.Stat2Data
{
    using System.Collections.Generic;

    /// <summary>
    /// LeafHoppers
    /// </summary>

    public class LeafHoppers
    {
        public readonly int κ;
        public readonly string Diet;
        public readonly double Days;

        public LeafHoppers(int κ, string Diet, double Days)
        {
            this.κ = κ;
            this.Diet = Diet;
            this.Days = Days;
        }

        public static IEnumerable<LeafHoppers> Data
        {
            get
            {
                yield return new LeafHoppers(1, "Control", 2.3);
                yield return new LeafHoppers(2, "Control", 2.7);
                yield return new LeafHoppers(3, "Glucose", 2.9);
                yield return new LeafHoppers(4, "Glucose", 2.7);
                yield return new LeafHoppers(5, "Fructose", 2.1);
                yield return new LeafHoppers(6, "Fructose", 2.3);
                yield return new LeafHoppers(7, "Sucrose", 4);
                yield return new LeafHoppers(8, "Sucrose", 3.6);
            }
        }
    }
}
