// ReSharper disable All

namespace Rdatasets.KMsurv
{
    using System.Collections.Generic;

    /// <summary>
    /// data from Section 1.10
    /// </summary>

    public class hodg
    {
        public readonly int κ;
        public readonly int gtype;
        public readonly int dtype;
        public readonly int time;
        public readonly int delta;
        public readonly int score;
        public readonly int wtime;

        public hodg(int κ, int gtype, int dtype, int time, int delta, int score, int wtime)
        {
            this.κ = κ;
            this.gtype = gtype;
            this.dtype = dtype;
            this.time = time;
            this.delta = delta;
            this.score = score;
            this.wtime = wtime;
        }

        public static IEnumerable<hodg> Data
        {
            get
            {
                yield return new hodg(1, 1, 1, 28, 1, 90, 24);
                yield return new hodg(2, 1, 1, 32, 1, 30, 7);
                yield return new hodg(3, 1, 1, 49, 1, 40, 8);
                yield return new hodg(4, 1, 1, 84, 1, 60, 10);
                yield return new hodg(5, 1, 1, 357, 1, 70, 42);
                yield return new hodg(6, 1, 1, 933, 0, 90, 9);
                yield return new hodg(7, 1, 1, 1078, 0, 100, 16);
                yield return new hodg(8, 1, 1, 1183, 0, 90, 16);
                yield return new hodg(9, 1, 1, 1560, 0, 80, 20);
                yield return new hodg(10, 1, 1, 2114, 0, 80, 27);
                yield return new hodg(11, 1, 1, 2144, 0, 90, 5);
                yield return new hodg(12, 1, 2, 2, 1, 20, 34);
                yield return new hodg(13, 1, 2, 4, 1, 50, 28);
                yield return new hodg(14, 1, 2, 72, 1, 80, 59);
                yield return new hodg(15, 1, 2, 77, 1, 60, 102);
                yield return new hodg(16, 1, 2, 79, 1, 70, 71);
                yield return new hodg(17, 2, 1, 42, 1, 80, 19);
                yield return new hodg(18, 2, 1, 53, 1, 90, 17);
                yield return new hodg(19, 2, 1, 57, 1, 30, 9);
                yield return new hodg(20, 2, 1, 63, 1, 60, 13);
                yield return new hodg(21, 2, 1, 81, 1, 50, 12);
                yield return new hodg(22, 2, 1, 140, 1, 100, 11);
                yield return new hodg(23, 2, 1, 81, 1, 50, 12);
                yield return new hodg(24, 2, 1, 252, 1, 90, 21);
                yield return new hodg(25, 2, 1, 524, 1, 90, 39);
                yield return new hodg(26, 2, 1, 210, 0, 90, 16);
                yield return new hodg(27, 2, 1, 476, 0, 90, 24);
                yield return new hodg(28, 2, 1, 1037, 0, 90, 84);
                yield return new hodg(29, 2, 2, 30, 1, 90, 73);
                yield return new hodg(30, 2, 2, 36, 1, 80, 61);
                yield return new hodg(31, 2, 2, 41, 1, 70, 34);
                yield return new hodg(32, 2, 2, 52, 1, 60, 18);
                yield return new hodg(33, 2, 2, 62, 1, 90, 40);
                yield return new hodg(34, 2, 2, 108, 1, 70, 65);
                yield return new hodg(35, 2, 2, 132, 1, 60, 17);
                yield return new hodg(36, 2, 2, 180, 0, 100, 61);
                yield return new hodg(37, 2, 2, 307, 0, 100, 24);
                yield return new hodg(38, 2, 2, 406, 0, 100, 48);
                yield return new hodg(39, 2, 2, 446, 0, 100, 52);
                yield return new hodg(40, 2, 2, 484, 0, 90, 84);
                yield return new hodg(41, 2, 2, 748, 0, 90, 171);
                yield return new hodg(42, 2, 2, 1290, 0, 90, 20);
                yield return new hodg(43, 2, 2, 1345, 0, 80, 98);
            }
        }
    }
}
