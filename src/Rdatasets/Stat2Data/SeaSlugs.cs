// ReSharper disable All

namespace Rdatasets.Stat2Data
{
    using System.Collections.Generic;

    /// <summary>
    /// Sea Slugs
    /// </summary>

    public class SeaSlugs
    {
        public readonly int Time;
        public readonly double Percent;

        public SeaSlugs(int Time, double Percent)
        {
            this.Time = Time;
            this.Percent = Percent;
        }

        public static IEnumerable<SeaSlugs> Data
        {
            get
            {
                yield return new SeaSlugs(0, 0.5);
                yield return new SeaSlugs(0, 0.467);
                yield return new SeaSlugs(0, 0.857);
                yield return new SeaSlugs(0, 0.5);
                yield return new SeaSlugs(0, 0.357);
                yield return new SeaSlugs(0, 0.533);
                yield return new SeaSlugs(5, 0.467);
                yield return new SeaSlugs(5, 0.467);
                yield return new SeaSlugs(5, 0.125);
                yield return new SeaSlugs(5, 0.4);
                yield return new SeaSlugs(5, 0.214);
                yield return new SeaSlugs(5, 0.4);
                yield return new SeaSlugs(10, 0.067);
                yield return new SeaSlugs(10, 0.067);
                yield return new SeaSlugs(10, 0.333);
                yield return new SeaSlugs(10, 0.333);
                yield return new SeaSlugs(10, 0.133);
                yield return new SeaSlugs(10, 0.133);
                yield return new SeaSlugs(15, 0.267);
                yield return new SeaSlugs(15, 0.286);
                yield return new SeaSlugs(15, 0.333);
                yield return new SeaSlugs(15, 0.214);
                yield return new SeaSlugs(15, 0);
                yield return new SeaSlugs(15, 0);
                yield return new SeaSlugs(20, 0.267);
                yield return new SeaSlugs(20, 0.2);
                yield return new SeaSlugs(20, 0.267);
                yield return new SeaSlugs(20, 0.437);
                yield return new SeaSlugs(20, 0.077);
                yield return new SeaSlugs(20, 0.067);
                yield return new SeaSlugs(25, 0.133);
                yield return new SeaSlugs(25, 0.267);
                yield return new SeaSlugs(25, 0.412);
                yield return new SeaSlugs(25, 0);
                yield return new SeaSlugs(25, 0.067);
                yield return new SeaSlugs(25, 0.133);
            }
        }
    }
}
