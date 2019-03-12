// ReSharper disable All

namespace Rdatasets.MASS
{
    using System.Collections.Generic;

    /// <summary>
    /// Remission Times of Leukaemia Patients
    /// </summary>

    public class gehan
    {
        public readonly int κ;
        public readonly int pair;
        public readonly int time;
        public readonly int cens;
        public readonly string treat;

        public gehan(int κ, int pair, int time, int cens, string treat)
        {
            this.κ = κ;
            this.pair = pair;
            this.time = time;
            this.cens = cens;
            this.treat = treat;
        }

        public static IEnumerable<gehan> Data
        {
            get
            {
                yield return new gehan(1, 1, 1, 1, "control");
                yield return new gehan(2, 1, 10, 1, "6-MP");
                yield return new gehan(3, 2, 22, 1, "control");
                yield return new gehan(4, 2, 7, 1, "6-MP");
                yield return new gehan(5, 3, 3, 1, "control");
                yield return new gehan(6, 3, 32, 0, "6-MP");
                yield return new gehan(7, 4, 12, 1, "control");
                yield return new gehan(8, 4, 23, 1, "6-MP");
                yield return new gehan(9, 5, 8, 1, "control");
                yield return new gehan(10, 5, 22, 1, "6-MP");
                yield return new gehan(11, 6, 17, 1, "control");
                yield return new gehan(12, 6, 6, 1, "6-MP");
                yield return new gehan(13, 7, 2, 1, "control");
                yield return new gehan(14, 7, 16, 1, "6-MP");
                yield return new gehan(15, 8, 11, 1, "control");
                yield return new gehan(16, 8, 34, 0, "6-MP");
                yield return new gehan(17, 9, 8, 1, "control");
                yield return new gehan(18, 9, 32, 0, "6-MP");
                yield return new gehan(19, 10, 12, 1, "control");
                yield return new gehan(20, 10, 25, 0, "6-MP");
                yield return new gehan(21, 11, 2, 1, "control");
                yield return new gehan(22, 11, 11, 0, "6-MP");
                yield return new gehan(23, 12, 5, 1, "control");
                yield return new gehan(24, 12, 20, 0, "6-MP");
                yield return new gehan(25, 13, 4, 1, "control");
                yield return new gehan(26, 13, 19, 0, "6-MP");
                yield return new gehan(27, 14, 15, 1, "control");
                yield return new gehan(28, 14, 6, 1, "6-MP");
                yield return new gehan(29, 15, 8, 1, "control");
                yield return new gehan(30, 15, 17, 0, "6-MP");
                yield return new gehan(31, 16, 23, 1, "control");
                yield return new gehan(32, 16, 35, 0, "6-MP");
                yield return new gehan(33, 17, 5, 1, "control");
                yield return new gehan(34, 17, 6, 1, "6-MP");
                yield return new gehan(35, 18, 11, 1, "control");
                yield return new gehan(36, 18, 13, 1, "6-MP");
                yield return new gehan(37, 19, 4, 1, "control");
                yield return new gehan(38, 19, 9, 0, "6-MP");
                yield return new gehan(39, 20, 1, 1, "control");
                yield return new gehan(40, 20, 6, 0, "6-MP");
                yield return new gehan(41, 21, 8, 1, "control");
                yield return new gehan(42, 21, 10, 0, "6-MP");
            }
        }
    }
}
