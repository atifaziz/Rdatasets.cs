// ReSharper disable All

namespace Rdatasets.MASS
{
    using System.Collections.Generic;

    /// <summary>
    /// Heat Evolved by Setting Cements
    /// </summary>

    public class cement
    {
        public readonly int κ;
        public readonly int x1;
        public readonly int x2;
        public readonly int x3;
        public readonly int x4;
        public readonly double y;

        public cement(int κ, int x1, int x2, int x3, int x4, double y)
        {
            this.κ = κ;
            this.x1 = x1;
            this.x2 = x2;
            this.x3 = x3;
            this.x4 = x4;
            this.y = y;
        }

        public static IEnumerable<cement> Data
        {
            get
            {
                yield return new cement(1, 7, 26, 6, 60, 78.5);
                yield return new cement(2, 1, 29, 15, 52, 74.3);
                yield return new cement(3, 11, 56, 8, 20, 104.3);
                yield return new cement(4, 11, 31, 8, 47, 87.6);
                yield return new cement(5, 7, 52, 6, 33, 95.9);
                yield return new cement(6, 11, 55, 9, 22, 109.2);
                yield return new cement(7, 3, 71, 17, 6, 102.7);
                yield return new cement(8, 1, 31, 22, 44, 72.5);
                yield return new cement(9, 2, 54, 18, 22, 93.1);
                yield return new cement(10, 21, 47, 4, 26, 115.9);
                yield return new cement(11, 1, 40, 23, 34, 83.8);
                yield return new cement(12, 11, 66, 9, 12, 113.3);
                yield return new cement(13, 10, 68, 8, 12, 109.4);
            }
        }
    }
}
