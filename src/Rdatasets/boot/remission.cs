// ReSharper disable All

namespace Rdatasets.boot
{
    using System.Collections.Generic;

    /// <summary>
    /// Cancer Remission and Cell Activity
    /// </summary>

    public class remission
    {
        public readonly int κ;
        public readonly double LI;
        public readonly int m;
        public readonly int r;

        public remission(int κ, double LI, int m, int r)
        {
            this.κ = κ;
            this.LI = LI;
            this.m = m;
            this.r = r;
        }

        public static IEnumerable<remission> Data
        {
            get
            {
                yield return new remission(1, 0.4, 1, 0);
                yield return new remission(2, 0.4, 1, 0);
                yield return new remission(3, 0.5, 1, 0);
                yield return new remission(4, 0.5, 1, 0);
                yield return new remission(5, 0.6, 1, 0);
                yield return new remission(6, 0.6, 1, 0);
                yield return new remission(7, 0.6, 1, 0);
                yield return new remission(8, 0.7, 1, 0);
                yield return new remission(9, 0.7, 1, 0);
                yield return new remission(10, 0.7, 1, 0);
                yield return new remission(11, 0.8, 1, 0);
                yield return new remission(12, 0.8, 1, 0);
                yield return new remission(13, 0.8, 1, 0);
                yield return new remission(14, 0.9, 1, 1);
                yield return new remission(15, 1, 1, 0);
                yield return new remission(16, 1, 1, 1);
                yield return new remission(17, 1, 1, 1);
                yield return new remission(18, 1.1, 1, 0);
                yield return new remission(19, 1.1, 1, 1);
                yield return new remission(20, 1.2, 1, 0);
                yield return new remission(21, 1.3, 1, 1);
                yield return new remission(22, 1.4, 1, 1);
                yield return new remission(23, 1.6, 1, 0);
                yield return new remission(24, 1.7, 1, 1);
                yield return new remission(25, 1.9, 1, 0);
                yield return new remission(26, 1.9, 1, 1);
                yield return new remission(27, 1.9, 1, 1);
            }
        }
    }
}
