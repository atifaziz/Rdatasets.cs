// ReSharper disable All

namespace Rdatasets.KMsurv
{
    using System.Collections.Generic;

    /// <summary>
    /// data from Exercise 7.7, p223
    /// </summary>

    public class bnct
    {
        public readonly int trt;
        public readonly int time;
        public readonly int death;

        public bnct(int trt, int time, int death)
        {
            this.trt = trt;
            this.time = time;
            this.death = death;
        }

        public static IEnumerable<bnct> Data
        {
            get
            {
                yield return new bnct(1, 20, 1);
                yield return new bnct(1, 21, 1);
                yield return new bnct(1, 23, 1);
                yield return new bnct(1, 24, 1);
                yield return new bnct(1, 24, 1);
                yield return new bnct(1, 26, 1);
                yield return new bnct(1, 26, 1);
                yield return new bnct(1, 27, 1);
                yield return new bnct(1, 28, 1);
                yield return new bnct(1, 30, 1);
                yield return new bnct(2, 26, 1);
                yield return new bnct(2, 28, 1);
                yield return new bnct(2, 29, 1);
                yield return new bnct(2, 29, 1);
                yield return new bnct(2, 30, 1);
                yield return new bnct(2, 30, 1);
                yield return new bnct(2, 31, 1);
                yield return new bnct(2, 31, 1);
                yield return new bnct(2, 32, 1);
                yield return new bnct(2, 35, 0);
                yield return new bnct(3, 31, 1);
                yield return new bnct(3, 32, 1);
                yield return new bnct(3, 34, 1);
                yield return new bnct(3, 35, 1);
                yield return new bnct(3, 36, 1);
                yield return new bnct(3, 38, 1);
                yield return new bnct(3, 38, 1);
                yield return new bnct(3, 39, 1);
                yield return new bnct(3, 42, 0);
                yield return new bnct(3, 42, 0);
            }
        }
    }
}
