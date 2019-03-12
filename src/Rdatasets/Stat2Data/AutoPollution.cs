// ReSharper disable All

namespace Rdatasets.Stat2Data
{
    using System.Collections.Generic;

    /// <summary>
    /// AutoPollution
    /// </summary>

    public class AutoPollution
    {
        public readonly int κ;
        public readonly int Noise;
        public readonly int Size;
        public readonly int Type;
        public readonly int Side;

        public AutoPollution(int κ, int Noise, int Size, int Type, int Side)
        {
            this.κ = κ;
            this.Noise = Noise;
            this.Size = Size;
            this.Type = Type;
            this.Side = Side;
        }

        public static IEnumerable<AutoPollution> Data
        {
            get
            {
                yield return new AutoPollution(1, 810, 1, 1, 1);
                yield return new AutoPollution(2, 820, 1, 1, 1);
                yield return new AutoPollution(3, 820, 1, 1, 1);
                yield return new AutoPollution(4, 840, 2, 1, 1);
                yield return new AutoPollution(5, 840, 2, 1, 1);
                yield return new AutoPollution(6, 845, 2, 1, 1);
                yield return new AutoPollution(7, 785, 3, 1, 1);
                yield return new AutoPollution(8, 790, 3, 1, 1);
                yield return new AutoPollution(9, 785, 3, 1, 1);
                yield return new AutoPollution(10, 835, 1, 1, 2);
                yield return new AutoPollution(11, 835, 1, 1, 2);
                yield return new AutoPollution(12, 835, 1, 1, 2);
                yield return new AutoPollution(13, 845, 2, 1, 2);
                yield return new AutoPollution(14, 855, 2, 1, 2);
                yield return new AutoPollution(15, 850, 2, 1, 2);
                yield return new AutoPollution(16, 760, 3, 1, 2);
                yield return new AutoPollution(17, 760, 3, 1, 2);
                yield return new AutoPollution(18, 770, 3, 1, 2);
                yield return new AutoPollution(19, 820, 1, 2, 1);
                yield return new AutoPollution(20, 820, 1, 2, 1);
                yield return new AutoPollution(21, 820, 1, 2, 1);
                yield return new AutoPollution(22, 820, 2, 2, 1);
                yield return new AutoPollution(23, 820, 2, 2, 1);
                yield return new AutoPollution(24, 825, 2, 2, 1);
                yield return new AutoPollution(25, 775, 3, 2, 1);
                yield return new AutoPollution(26, 775, 3, 2, 1);
                yield return new AutoPollution(27, 775, 3, 2, 1);
                yield return new AutoPollution(28, 825, 1, 2, 2);
                yield return new AutoPollution(29, 825, 1, 2, 2);
                yield return new AutoPollution(30, 825, 1, 2, 2);
                yield return new AutoPollution(31, 815, 2, 2, 2);
                yield return new AutoPollution(32, 825, 2, 2, 2);
                yield return new AutoPollution(33, 825, 2, 2, 2);
                yield return new AutoPollution(34, 770, 3, 2, 2);
                yield return new AutoPollution(35, 760, 3, 2, 2);
                yield return new AutoPollution(36, 765, 3, 2, 2);
            }
        }
    }
}
