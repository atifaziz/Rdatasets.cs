// ReSharper disable All

namespace Rdatasets.KMsurv
{
    using System.Collections.Generic;

    /// <summary>
    /// data from Exercise 7.7, p223
    /// </summary>

    public class bnct
    {
        public readonly int κ;
        public readonly int trt;
        public readonly int time;
        public readonly int death;

        public bnct(int κ, int trt, int time, int death)
        {
            this.κ = κ;
            this.trt = trt;
            this.time = time;
            this.death = death;
        }

        public static IEnumerable<bnct> Data
        {
            get
            {
                yield return new bnct(1, 1, 20, 1);
                yield return new bnct(2, 1, 21, 1);
                yield return new bnct(3, 1, 23, 1);
                yield return new bnct(4, 1, 24, 1);
                yield return new bnct(5, 1, 24, 1);
                yield return new bnct(6, 1, 26, 1);
                yield return new bnct(7, 1, 26, 1);
                yield return new bnct(8, 1, 27, 1);
                yield return new bnct(9, 1, 28, 1);
                yield return new bnct(10, 1, 30, 1);
                yield return new bnct(11, 2, 26, 1);
                yield return new bnct(12, 2, 28, 1);
                yield return new bnct(13, 2, 29, 1);
                yield return new bnct(14, 2, 29, 1);
                yield return new bnct(15, 2, 30, 1);
                yield return new bnct(16, 2, 30, 1);
                yield return new bnct(17, 2, 31, 1);
                yield return new bnct(18, 2, 31, 1);
                yield return new bnct(19, 2, 32, 1);
                yield return new bnct(20, 2, 35, 0);
                yield return new bnct(21, 3, 31, 1);
                yield return new bnct(22, 3, 32, 1);
                yield return new bnct(23, 3, 34, 1);
                yield return new bnct(24, 3, 35, 1);
                yield return new bnct(25, 3, 36, 1);
                yield return new bnct(26, 3, 38, 1);
                yield return new bnct(27, 3, 38, 1);
                yield return new bnct(28, 3, 39, 1);
                yield return new bnct(29, 3, 42, 0);
                yield return new bnct(30, 3, 42, 0);
            }
        }
    }
}
