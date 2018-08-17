// ReSharper disable All

namespace Rdatasets.Stat2Data
{
    using System.Collections.Generic;

    /// <summary>
    /// Fingers
    /// </summary>

    public class Fingers
    {
        public readonly string Subject;
        public readonly string Drug;
        public readonly int TapRate;

        public Fingers(string Subject, string Drug, int TapRate)
        {
            this.Subject = Subject;
            this.Drug = Drug;
            this.TapRate = TapRate;
        }

        public static IEnumerable<Fingers> Data
        {
            get
            {
                yield return new Fingers("I", "Placebo", 11);
                yield return new Fingers("II", "Placebo", 56);
                yield return new Fingers("III", "Placebo", 15);
                yield return new Fingers("IV", "Placebo", 6);
                yield return new Fingers("I", "Caffeine", 26);
                yield return new Fingers("II", "Caffeine", 83);
                yield return new Fingers("III", "Caffeine", 34);
                yield return new Fingers("IV", "Caffeine", 13);
                yield return new Fingers("I", "Theobromine", 20);
                yield return new Fingers("II", "Theobromine", 71);
                yield return new Fingers("III", "Theobromine", 41);
                yield return new Fingers("IV", "Theobromine", 32);
            }
        }
    }
}
