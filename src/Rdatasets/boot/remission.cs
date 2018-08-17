// ReSharper disable All

namespace Rdatasets.boot
{
    using System.Collections.Generic;

    /// <summary>
    /// Cancer Remission and Cell Activity
    /// </summary>

    public class remission
    {
        public readonly double LI;
        public readonly int m;
        public readonly int r;

        public remission(double LI, int m, int r)
        {
            this.LI = LI;
            this.m = m;
            this.r = r;
        }

        public static IEnumerable<remission> Data
        {
            get
            {
                yield return new remission(0.4, 1, 0);
                yield return new remission(0.4, 1, 0);
                yield return new remission(0.5, 1, 0);
                yield return new remission(0.5, 1, 0);
                yield return new remission(0.6, 1, 0);
                yield return new remission(0.6, 1, 0);
                yield return new remission(0.6, 1, 0);
                yield return new remission(0.7, 1, 0);
                yield return new remission(0.7, 1, 0);
                yield return new remission(0.7, 1, 0);
                yield return new remission(0.8, 1, 0);
                yield return new remission(0.8, 1, 0);
                yield return new remission(0.8, 1, 0);
                yield return new remission(0.9, 1, 1);
                yield return new remission(1, 1, 0);
                yield return new remission(1, 1, 1);
                yield return new remission(1, 1, 1);
                yield return new remission(1.1, 1, 0);
                yield return new remission(1.1, 1, 1);
                yield return new remission(1.2, 1, 0);
                yield return new remission(1.3, 1, 1);
                yield return new remission(1.4, 1, 1);
                yield return new remission(1.6, 1, 0);
                yield return new remission(1.7, 1, 1);
                yield return new remission(1.9, 1, 0);
                yield return new remission(1.9, 1, 1);
                yield return new remission(1.9, 1, 1);
            }
        }
    }
}
