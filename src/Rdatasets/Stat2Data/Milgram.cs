// ReSharper disable All

namespace Rdatasets.Stat2Data
{
    using System.Collections.Generic;

    /// <summary>
    /// Milgram
    /// </summary>

    public class Milgram
    {
        public readonly string Results;
        public readonly int Score;

        public Milgram(string Results, int Score)
        {
            this.Results = Results;
            this.Score = Score;
        }

        public static IEnumerable<Milgram> Data
        {
            get
            {
                yield return new Milgram("Actual", 6);
                yield return new Milgram("Actual", 1);
                yield return new Milgram("Actual", 7);
                yield return new Milgram("Actual", 2);
                yield return new Milgram("Actual", 1);
                yield return new Milgram("Actual", 7);
                yield return new Milgram("Actual", 3);
                yield return new Milgram("Actual", 4);
                yield return new Milgram("Actual", 1);
                yield return new Milgram("Actual", 1);
                yield return new Milgram("Actual", 1);
                yield return new Milgram("Actual", 6);
                yield return new Milgram("Actual", 3);
                yield return new Milgram("Complied", 1);
                yield return new Milgram("Complied", 3);
                yield return new Milgram("Complied", 7);
                yield return new Milgram("Complied", 6);
                yield return new Milgram("Complied", 7);
                yield return new Milgram("Complied", 4);
                yield return new Milgram("Complied", 3);
                yield return new Milgram("Complied", 1);
                yield return new Milgram("Complied", 1);
                yield return new Milgram("Complied", 2);
                yield return new Milgram("Complied", 5);
                yield return new Milgram("Complied", 5);
                yield return new Milgram("Complied", 5);
                yield return new Milgram("Refused", 5);
                yield return new Milgram("Refused", 7);
                yield return new Milgram("Refused", 7);
                yield return new Milgram("Refused", 6);
                yield return new Milgram("Refused", 6);
                yield return new Milgram("Refused", 6);
                yield return new Milgram("Refused", 7);
                yield return new Milgram("Refused", 2);
                yield return new Milgram("Refused", 6);
                yield return new Milgram("Refused", 3);
                yield return new Milgram("Refused", 6);
            }
        }
    }
}
