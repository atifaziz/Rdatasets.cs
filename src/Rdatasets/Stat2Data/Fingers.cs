// ReSharper disable All

namespace Rdatasets.Stat2Data
{
    using System.Collections.Generic;

    /// <summary>
    /// Fingers
    /// </summary>

    public class Fingers
    {
        public readonly int κ;
        public readonly string Subject;
        public readonly string Drug;
        public readonly int TapRate;

        public Fingers(int κ, string Subject, string Drug, int TapRate)
        {
            this.κ = κ;
            this.Subject = Subject;
            this.Drug = Drug;
            this.TapRate = TapRate;
        }

        public static IEnumerable<Fingers> Data
        {
            get
            {
                yield return new Fingers(1, "I", "Placebo", 11);
                yield return new Fingers(2, "II", "Placebo", 56);
                yield return new Fingers(3, "III", "Placebo", 15);
                yield return new Fingers(4, "IV", "Placebo", 6);
                yield return new Fingers(5, "I", "Caffeine", 26);
                yield return new Fingers(6, "II", "Caffeine", 83);
                yield return new Fingers(7, "III", "Caffeine", 34);
                yield return new Fingers(8, "IV", "Caffeine", 13);
                yield return new Fingers(9, "I", "Theobromine", 20);
                yield return new Fingers(10, "II", "Theobromine", 71);
                yield return new Fingers(11, "III", "Theobromine", 41);
                yield return new Fingers(12, "IV", "Theobromine", 32);
            }
        }
    }
}
