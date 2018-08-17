// ReSharper disable All

namespace Rdatasets.datasets
{
    using System.Collections.Generic;

    /// <summary>
    /// Anscombe's Quartet of 'Identical' Simple Linear Regressions
    /// </summary>

    public class anscombe
    {
        public readonly int x1;
        public readonly int x2;
        public readonly int x3;
        public readonly int x4;
        public readonly double y1;
        public readonly double y2;
        public readonly double y3;
        public readonly double y4;

        public anscombe(int x1, int x2, int x3, int x4, double y1, double y2, double y3, double y4)
        {
            this.x1 = x1;
            this.x2 = x2;
            this.x3 = x3;
            this.x4 = x4;
            this.y1 = y1;
            this.y2 = y2;
            this.y3 = y3;
            this.y4 = y4;
        }

        public static IEnumerable<anscombe> Data
        {
            get
            {
                yield return new anscombe(10, 10, 10, 8, 8.04, 9.14, 7.46, 6.58);
                yield return new anscombe(8, 8, 8, 8, 6.95, 8.14, 6.77, 5.76);
                yield return new anscombe(13, 13, 13, 8, 7.58, 8.74, 12.74, 7.71);
                yield return new anscombe(9, 9, 9, 8, 8.81, 8.77, 7.11, 8.84);
                yield return new anscombe(11, 11, 11, 8, 8.33, 9.26, 7.81, 8.47);
                yield return new anscombe(14, 14, 14, 8, 9.96, 8.1, 8.84, 7.04);
                yield return new anscombe(6, 6, 6, 8, 7.24, 6.13, 6.08, 5.25);
                yield return new anscombe(4, 4, 4, 19, 4.26, 3.1, 5.39, 12.5);
                yield return new anscombe(12, 12, 12, 8, 10.84, 9.13, 8.15, 5.56);
                yield return new anscombe(7, 7, 7, 8, 4.82, 7.26, 6.42, 7.91);
                yield return new anscombe(5, 5, 5, 8, 5.68, 4.74, 5.73, 6.89);
            }
        }
    }
}
