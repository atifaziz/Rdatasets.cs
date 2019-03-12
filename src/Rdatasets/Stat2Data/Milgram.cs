// ReSharper disable All

namespace Rdatasets.Stat2Data
{
    using System.Collections.Generic;

    /// <summary>
    /// Milgram
    /// </summary>

    public class Milgram
    {
        public readonly int κ;
        public readonly string Results;
        public readonly int Score;

        public Milgram(int κ, string Results, int Score)
        {
            this.κ = κ;
            this.Results = Results;
            this.Score = Score;
        }

        public static IEnumerable<Milgram> Data
        {
            get
            {
                yield return new Milgram(1, "Actual", 6);
                yield return new Milgram(2, "Actual", 1);
                yield return new Milgram(3, "Actual", 7);
                yield return new Milgram(4, "Actual", 2);
                yield return new Milgram(5, "Actual", 1);
                yield return new Milgram(6, "Actual", 7);
                yield return new Milgram(7, "Actual", 3);
                yield return new Milgram(8, "Actual", 4);
                yield return new Milgram(9, "Actual", 1);
                yield return new Milgram(10, "Actual", 1);
                yield return new Milgram(11, "Actual", 1);
                yield return new Milgram(12, "Actual", 6);
                yield return new Milgram(13, "Actual", 3);
                yield return new Milgram(14, "Complied", 1);
                yield return new Milgram(15, "Complied", 3);
                yield return new Milgram(16, "Complied", 7);
                yield return new Milgram(17, "Complied", 6);
                yield return new Milgram(18, "Complied", 7);
                yield return new Milgram(19, "Complied", 4);
                yield return new Milgram(20, "Complied", 3);
                yield return new Milgram(21, "Complied", 1);
                yield return new Milgram(22, "Complied", 1);
                yield return new Milgram(23, "Complied", 2);
                yield return new Milgram(24, "Complied", 5);
                yield return new Milgram(25, "Complied", 5);
                yield return new Milgram(26, "Complied", 5);
                yield return new Milgram(27, "Refused", 5);
                yield return new Milgram(28, "Refused", 7);
                yield return new Milgram(29, "Refused", 7);
                yield return new Milgram(30, "Refused", 6);
                yield return new Milgram(31, "Refused", 6);
                yield return new Milgram(32, "Refused", 6);
                yield return new Milgram(33, "Refused", 7);
                yield return new Milgram(34, "Refused", 2);
                yield return new Milgram(35, "Refused", 6);
                yield return new Milgram(36, "Refused", 3);
                yield return new Milgram(37, "Refused", 6);
            }
        }
    }
}
