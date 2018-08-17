// ReSharper disable All

namespace Rdatasets.Stat2Data
{
    using System.Collections.Generic;

    /// <summary>
    /// PigFeed
    /// </summary>

    public class PigFeed
    {
        public readonly int WgtGain;
        public readonly string Antibiotic;
        public readonly string B12;

        public PigFeed(int WgtGain, string Antibiotic, string B12)
        {
            this.WgtGain = WgtGain;
            this.Antibiotic = Antibiotic;
            this.B12 = B12;
        }

        public static IEnumerable<PigFeed> Data
        {
            get
            {
                yield return new PigFeed(30, "No", "No");
                yield return new PigFeed(8, "No", "No");
                yield return new PigFeed(19, "No", "No");
                yield return new PigFeed(5, "Yes", "No");
                yield return new PigFeed(0, "Yes", "No");
                yield return new PigFeed(4, "Yes", "No");
                yield return new PigFeed(26, "No", "Yes");
                yield return new PigFeed(21, "No", "Yes");
                yield return new PigFeed(19, "No", "Yes");
                yield return new PigFeed(52, "Yes", "Yes");
                yield return new PigFeed(56, "Yes", "Yes");
                yield return new PigFeed(54, "Yes", "Yes");
            }
        }
    }
}
