// ReSharper disable All

namespace Rdatasets.Stat2Data
{
    using System.Collections.Generic;

    /// <summary>
    /// FantasyBaseball
    /// </summary>

    public class FantasyBaseball
    {
        public readonly int Round;
        public readonly int DJ;
        public readonly int AR;
        public readonly int BK;
        public readonly int JW;
        public readonly int TS;
        public readonly int RL;
        public readonly int DR;
        public readonly int MF;

        public FantasyBaseball(int Round, int DJ, int AR, int BK, int JW, int TS, int RL, int DR, int MF)
        {
            this.Round = Round;
            this.DJ = DJ;
            this.AR = AR;
            this.BK = BK;
            this.JW = JW;
            this.TS = TS;
            this.RL = RL;
            this.DR = DR;
            this.MF = MF;
        }

        public static IEnumerable<FantasyBaseball> Data
        {
            get
            {
                yield return new FantasyBaseball(1, 42, 35, 49, 104, 15, 40, 26, 101);
                yield return new FantasyBaseball(2, 84, 26, 65, 101, 17, 143, 43, 16);
                yield return new FantasyBaseball(3, 21, 95, 115, 53, 66, 103, 113, 88);
                yield return new FantasyBaseball(4, 99, 41, 66, 123, 6, 144, 16, 79);
                yield return new FantasyBaseball(5, 25, 129, 53, 144, 6, 162, 113, 48);
                yield return new FantasyBaseball(6, 89, 62, 80, 247, 17, 55, 369, 2);
                yield return new FantasyBaseball(7, 53, 168, 32, 210, 7, 37, 184, 50);
                yield return new FantasyBaseball(8, 174, 47, 161, 164, 5, 36, 138, 84);
                yield return new FantasyBaseball(9, 105, 74, 25, 135, 14, 118, 102, 163);
                yield return new FantasyBaseball(10, 99, 46, 60, 66, 13, 112, 21, 144);
                yield return new FantasyBaseball(11, 30, 7, 25, 399, 107, 17, 55, 27);
                yield return new FantasyBaseball(12, 91, 210, 69, 219, 7, 65, 62, 1);
                yield return new FantasyBaseball(13, 11, 266, 34, 436, 75, 27, 108, 76);
                yield return new FantasyBaseball(14, 93, 7, 21, 235, 5, 53, 23, 187);
                yield return new FantasyBaseball(15, 20, 35, 26, 244, 19, 120, 94, 19);
                yield return new FantasyBaseball(16, 108, 61, 13, 133, 25, 13, 90, 40);
                yield return new FantasyBaseball(17, 95, 124, 9, 68, 5, 35, 95, 171);
                yield return new FantasyBaseball(18, 43, 27, 9, 230, 5, 52, 72, 3);
                yield return new FantasyBaseball(19, 123, 26, 13, 105, 6, 41, 32, 18);
                yield return new FantasyBaseball(20, 75, 58, 50, 103, 13, 38, 57, 86);
                yield return new FantasyBaseball(21, 18, 11, 10, 40, 8, 88, 20, 27);
                yield return new FantasyBaseball(22, 40, 10, 119, 39, 6, 51, 46, 59);
                yield return new FantasyBaseball(23, 33, 56, 20, 244, 6, 38, 13, 41);
                yield return new FantasyBaseball(24, 100, 18, 27, 91, 11, 23, 31, 2);
            }
        }
    }
}
