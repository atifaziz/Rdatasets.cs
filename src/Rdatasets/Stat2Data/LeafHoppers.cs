// ReSharper disable All

namespace Rdatasets.Stat2Data
{
    using System.Collections.Generic;

    /// <summary>
    /// LeafHoppers
    /// </summary>

    public class LeafHoppers
    {
        public readonly string Diet;
        public readonly double Days;

        public LeafHoppers(string Diet, double Days)
        {
            this.Diet = Diet;
            this.Days = Days;
        }

        public static IEnumerable<LeafHoppers> Data
        {
            get
            {
                yield return new LeafHoppers("Control", 2.3);
                yield return new LeafHoppers("Control", 2.7);
                yield return new LeafHoppers("Glucose", 2.9);
                yield return new LeafHoppers("Glucose", 2.7);
                yield return new LeafHoppers("Fructose", 2.1);
                yield return new LeafHoppers("Fructose", 2.3);
                yield return new LeafHoppers("Sucrose", 4);
                yield return new LeafHoppers("Sucrose", 3.6);
            }
        }
    }
}
