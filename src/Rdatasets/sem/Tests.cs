// ReSharper disable All

namespace Rdatasets.sem
{
    using System.Collections.Generic;

    /// <summary>
    /// Six Mental Tests
    /// </summary>

    public class Tests
    {
        public readonly int κ;
        public readonly int? x1;
        public readonly int? x2;
        public readonly int? x3;
        public readonly int? y1;
        public readonly int? y2;
        public readonly int? y3;

        public Tests(int κ, int? x1, int? x2, int? x3, int? y1, int? y2, int? y3)
        {
            this.κ = κ;
            this.x1 = x1;
            this.x2 = x2;
            this.x3 = x3;
            this.y1 = y1;
            this.y2 = y2;
            this.y3 = y3;
        }

        public static IEnumerable<Tests> Data
        {
            get
            {
                yield return new Tests(1, 23, null, 16, 15, 14, 16);
                yield return new Tests(2, 29, 26, 23, 22, 18, 19);
                yield return new Tests(3, 14, 21, null, 15, 16, 18);
                yield return new Tests(4, 20, 18, 17, 18, 21, 19);
                yield return new Tests(5, 25, 26, 22, null, 21, 26);
                yield return new Tests(6, 26, 19, 15, 16, 17, 17);
                yield return new Tests(7, null, 17, 19, 4, 6, 7);
                yield return new Tests(8, 12, 17, 18, 14, 16, null);
                yield return new Tests(9, 25, 19, 22, 22, 20, 20);
                yield return new Tests(10, 7, 12, 15, 10, 11, 8);
                yield return new Tests(11, 29, 24, null, 14, 13, 16);
                yield return new Tests(12, 28, 24, 29, 19, 19, 21);
                yield return new Tests(13, 12, 9, 10, 18, 19, null);
                yield return new Tests(14, 11, null, 12, 15, 16, 16);
                yield return new Tests(15, 20, 14, 15, 24, 23, 16);
                yield return new Tests(16, 26, 25, null, 24, 23, 24);
                yield return new Tests(17, 20, 16, 19, 22, 21, 20);
                yield return new Tests(18, 14, null, 15, 17, 19, 23);
                yield return new Tests(19, 14, 20, 13, 24, null, null);
                yield return new Tests(20, 29, 24, 24, 21, 20, 18);
                yield return new Tests(21, 26, null, 26, 28, 26, 23);
                yield return new Tests(22, 20, 23, 24, 22, 23, 22);
                yield return new Tests(23, 23, 24, 20, 23, 22, 18);
                yield return new Tests(24, 14, null, 17, null, 16, 14);
                yield return new Tests(25, 28, 34, 27, 25, 21, 21);
                yield return new Tests(26, 17, 12, 10, 14, 12, 16);
                yield return new Tests(27, null, 1, 13, 14, 15, 14);
                yield return new Tests(28, 22, 19, 19, 13, 11, 14);
                yield return new Tests(29, 18, 21, null, 15, 18, 19);
                yield return new Tests(30, 12, 12, 10, 13, 13, 16);
                yield return new Tests(31, 22, 14, 20, 20, 18, 19);
                yield return new Tests(32, 29, 21, 22, 13, 17, null);
            }
        }
    }
}
