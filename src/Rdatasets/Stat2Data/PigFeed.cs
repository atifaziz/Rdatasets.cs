// ReSharper disable All

namespace Rdatasets.Stat2Data
{
    using System.Collections.Generic;

    /// <summary>
    /// PigFeed
    /// </summary>

    public class PigFeed
    {
        public readonly int κ;
        public readonly int WgtGain;
        public readonly string Antibiotic;
        public readonly string B12;

        public PigFeed(int κ, int WgtGain, string Antibiotic, string B12)
        {
            this.κ = κ;
            this.WgtGain = WgtGain;
            this.Antibiotic = Antibiotic;
            this.B12 = B12;
        }

        public static IEnumerable<PigFeed> Data
        {
            get
            {
                yield return new PigFeed(1, 30, "No", "No");
                yield return new PigFeed(2, 8, "No", "No");
                yield return new PigFeed(3, 19, "No", "No");
                yield return new PigFeed(4, 5, "Yes", "No");
                yield return new PigFeed(5, 0, "Yes", "No");
                yield return new PigFeed(6, 4, "Yes", "No");
                yield return new PigFeed(7, 26, "No", "Yes");
                yield return new PigFeed(8, 21, "No", "Yes");
                yield return new PigFeed(9, 19, "No", "Yes");
                yield return new PigFeed(10, 52, "Yes", "Yes");
                yield return new PigFeed(11, 56, "Yes", "Yes");
                yield return new PigFeed(12, 54, "Yes", "Yes");
            }
        }
    }
}
