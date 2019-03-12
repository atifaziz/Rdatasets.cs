// ReSharper disable All

namespace Rdatasets.KMsurv
{
    using System.Collections.Generic;

    /// <summary>
    /// data from Section 1.2
    /// </summary>

    public class drug6mp
    {
        public readonly int κ;
        public readonly int pair;
        public readonly int remstat;
        public readonly int t1;
        public readonly int t2;
        public readonly int relapse;

        public drug6mp(int κ, int pair, int remstat, int t1, int t2, int relapse)
        {
            this.κ = κ;
            this.pair = pair;
            this.remstat = remstat;
            this.t1 = t1;
            this.t2 = t2;
            this.relapse = relapse;
        }

        public static IEnumerable<drug6mp> Data
        {
            get
            {
                yield return new drug6mp(1, 1, 1, 1, 10, 1);
                yield return new drug6mp(2, 2, 2, 22, 7, 1);
                yield return new drug6mp(3, 3, 2, 3, 32, 0);
                yield return new drug6mp(4, 4, 2, 12, 23, 1);
                yield return new drug6mp(5, 5, 2, 8, 22, 1);
                yield return new drug6mp(6, 6, 1, 17, 6, 1);
                yield return new drug6mp(7, 7, 2, 2, 16, 1);
                yield return new drug6mp(8, 8, 2, 11, 34, 0);
                yield return new drug6mp(9, 9, 2, 8, 32, 0);
                yield return new drug6mp(10, 10, 2, 12, 25, 0);
                yield return new drug6mp(11, 11, 2, 2, 11, 0);
                yield return new drug6mp(12, 12, 1, 5, 20, 0);
                yield return new drug6mp(13, 13, 2, 4, 19, 0);
                yield return new drug6mp(14, 14, 2, 15, 6, 1);
                yield return new drug6mp(15, 15, 2, 8, 17, 0);
                yield return new drug6mp(16, 16, 1, 23, 35, 0);
                yield return new drug6mp(17, 17, 1, 5, 6, 1);
                yield return new drug6mp(18, 18, 2, 11, 13, 1);
                yield return new drug6mp(19, 19, 2, 4, 9, 0);
                yield return new drug6mp(20, 20, 2, 1, 6, 0);
                yield return new drug6mp(21, 21, 2, 8, 10, 0);
            }
        }
    }
}
