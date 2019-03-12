// ReSharper disable All

namespace Rdatasets.Stat2Data
{
    using System.Collections.Generic;

    /// <summary>
    /// Sea Slugs
    /// </summary>

    public class SeaSlugs
    {
        public readonly int κ;
        public readonly int Time;
        public readonly double Percent;

        public SeaSlugs(int κ, int Time, double Percent)
        {
            this.κ = κ;
            this.Time = Time;
            this.Percent = Percent;
        }

        public static IEnumerable<SeaSlugs> Data
        {
            get
            {
                yield return new SeaSlugs(1, 0, 0.5);
                yield return new SeaSlugs(2, 0, 0.467);
                yield return new SeaSlugs(3, 0, 0.857);
                yield return new SeaSlugs(4, 0, 0.5);
                yield return new SeaSlugs(5, 0, 0.357);
                yield return new SeaSlugs(6, 0, 0.533);
                yield return new SeaSlugs(7, 5, 0.467);
                yield return new SeaSlugs(8, 5, 0.467);
                yield return new SeaSlugs(9, 5, 0.125);
                yield return new SeaSlugs(10, 5, 0.4);
                yield return new SeaSlugs(11, 5, 0.214);
                yield return new SeaSlugs(12, 5, 0.4);
                yield return new SeaSlugs(13, 10, 0.067);
                yield return new SeaSlugs(14, 10, 0.067);
                yield return new SeaSlugs(15, 10, 0.333);
                yield return new SeaSlugs(16, 10, 0.333);
                yield return new SeaSlugs(17, 10, 0.133);
                yield return new SeaSlugs(18, 10, 0.133);
                yield return new SeaSlugs(19, 15, 0.267);
                yield return new SeaSlugs(20, 15, 0.286);
                yield return new SeaSlugs(21, 15, 0.333);
                yield return new SeaSlugs(22, 15, 0.214);
                yield return new SeaSlugs(23, 15, 0);
                yield return new SeaSlugs(24, 15, 0);
                yield return new SeaSlugs(25, 20, 0.267);
                yield return new SeaSlugs(26, 20, 0.2);
                yield return new SeaSlugs(27, 20, 0.267);
                yield return new SeaSlugs(28, 20, 0.437);
                yield return new SeaSlugs(29, 20, 0.077);
                yield return new SeaSlugs(30, 20, 0.067);
                yield return new SeaSlugs(31, 25, 0.133);
                yield return new SeaSlugs(32, 25, 0.267);
                yield return new SeaSlugs(33, 25, 0.412);
                yield return new SeaSlugs(34, 25, 0);
                yield return new SeaSlugs(35, 25, 0.067);
                yield return new SeaSlugs(36, 25, 0.133);
            }
        }
    }
}
