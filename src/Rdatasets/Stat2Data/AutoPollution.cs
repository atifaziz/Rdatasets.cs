// ReSharper disable All

namespace Rdatasets.Stat2Data
{
    using System.Collections.Generic;

    /// <summary>
    /// AutoPollution
    /// </summary>

    public class AutoPollution
    {
        public readonly int Noise;
        public readonly int Size;
        public readonly int Type;
        public readonly int Side;

        public AutoPollution(int Noise, int Size, int Type, int Side)
        {
            this.Noise = Noise;
            this.Size = Size;
            this.Type = Type;
            this.Side = Side;
        }

        public static IEnumerable<AutoPollution> Data
        {
            get
            {
                yield return new AutoPollution(810, 1, 1, 1);
                yield return new AutoPollution(820, 1, 1, 1);
                yield return new AutoPollution(820, 1, 1, 1);
                yield return new AutoPollution(840, 2, 1, 1);
                yield return new AutoPollution(840, 2, 1, 1);
                yield return new AutoPollution(845, 2, 1, 1);
                yield return new AutoPollution(785, 3, 1, 1);
                yield return new AutoPollution(790, 3, 1, 1);
                yield return new AutoPollution(785, 3, 1, 1);
                yield return new AutoPollution(835, 1, 1, 2);
                yield return new AutoPollution(835, 1, 1, 2);
                yield return new AutoPollution(835, 1, 1, 2);
                yield return new AutoPollution(845, 2, 1, 2);
                yield return new AutoPollution(855, 2, 1, 2);
                yield return new AutoPollution(850, 2, 1, 2);
                yield return new AutoPollution(760, 3, 1, 2);
                yield return new AutoPollution(760, 3, 1, 2);
                yield return new AutoPollution(770, 3, 1, 2);
                yield return new AutoPollution(820, 1, 2, 1);
                yield return new AutoPollution(820, 1, 2, 1);
                yield return new AutoPollution(820, 1, 2, 1);
                yield return new AutoPollution(820, 2, 2, 1);
                yield return new AutoPollution(820, 2, 2, 1);
                yield return new AutoPollution(825, 2, 2, 1);
                yield return new AutoPollution(775, 3, 2, 1);
                yield return new AutoPollution(775, 3, 2, 1);
                yield return new AutoPollution(775, 3, 2, 1);
                yield return new AutoPollution(825, 1, 2, 2);
                yield return new AutoPollution(825, 1, 2, 2);
                yield return new AutoPollution(825, 1, 2, 2);
                yield return new AutoPollution(815, 2, 2, 2);
                yield return new AutoPollution(825, 2, 2, 2);
                yield return new AutoPollution(825, 2, 2, 2);
                yield return new AutoPollution(770, 3, 2, 2);
                yield return new AutoPollution(760, 3, 2, 2);
                yield return new AutoPollution(765, 3, 2, 2);
            }
        }
    }
}
