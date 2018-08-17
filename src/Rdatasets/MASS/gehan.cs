// ReSharper disable All

namespace Rdatasets.MASS
{
    using System.Collections.Generic;

    /// <summary>
    /// Remission Times of Leukaemia Patients
    /// </summary>

    public class gehan
    {
        public readonly int pair;
        public readonly int time;
        public readonly int cens;
        public readonly string treat;

        public gehan(int pair, int time, int cens, string treat)
        {
            this.pair = pair;
            this.time = time;
            this.cens = cens;
            this.treat = treat;
        }

        public static IEnumerable<gehan> Data
        {
            get
            {
                yield return new gehan(1, 1, 1, "control");
                yield return new gehan(1, 10, 1, "6-MP");
                yield return new gehan(2, 22, 1, "control");
                yield return new gehan(2, 7, 1, "6-MP");
                yield return new gehan(3, 3, 1, "control");
                yield return new gehan(3, 32, 0, "6-MP");
                yield return new gehan(4, 12, 1, "control");
                yield return new gehan(4, 23, 1, "6-MP");
                yield return new gehan(5, 8, 1, "control");
                yield return new gehan(5, 22, 1, "6-MP");
                yield return new gehan(6, 17, 1, "control");
                yield return new gehan(6, 6, 1, "6-MP");
                yield return new gehan(7, 2, 1, "control");
                yield return new gehan(7, 16, 1, "6-MP");
                yield return new gehan(8, 11, 1, "control");
                yield return new gehan(8, 34, 0, "6-MP");
                yield return new gehan(9, 8, 1, "control");
                yield return new gehan(9, 32, 0, "6-MP");
                yield return new gehan(10, 12, 1, "control");
                yield return new gehan(10, 25, 0, "6-MP");
                yield return new gehan(11, 2, 1, "control");
                yield return new gehan(11, 11, 0, "6-MP");
                yield return new gehan(12, 5, 1, "control");
                yield return new gehan(12, 20, 0, "6-MP");
                yield return new gehan(13, 4, 1, "control");
                yield return new gehan(13, 19, 0, "6-MP");
                yield return new gehan(14, 15, 1, "control");
                yield return new gehan(14, 6, 1, "6-MP");
                yield return new gehan(15, 8, 1, "control");
                yield return new gehan(15, 17, 0, "6-MP");
                yield return new gehan(16, 23, 1, "control");
                yield return new gehan(16, 35, 0, "6-MP");
                yield return new gehan(17, 5, 1, "control");
                yield return new gehan(17, 6, 1, "6-MP");
                yield return new gehan(18, 11, 1, "control");
                yield return new gehan(18, 13, 1, "6-MP");
                yield return new gehan(19, 4, 1, "control");
                yield return new gehan(19, 9, 0, "6-MP");
                yield return new gehan(20, 1, 1, "control");
                yield return new gehan(20, 6, 0, "6-MP");
                yield return new gehan(21, 8, 1, "control");
                yield return new gehan(21, 10, 0, "6-MP");
            }
        }
    }
}
