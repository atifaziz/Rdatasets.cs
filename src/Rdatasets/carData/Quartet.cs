// ReSharper disable All

namespace Rdatasets.carData
{
    using System.Collections.Generic;

    /// <summary>
    /// Four Regression Datasets
    /// </summary>

    public class Quartet
    {
        public readonly int x;
        public readonly double y1;
        public readonly double y2;
        public readonly double y3;
        public readonly int x4;
        public readonly double y4;

        public Quartet(int x, double y1, double y2, double y3, int x4, double y4)
        {
            this.x = x;
            this.y1 = y1;
            this.y2 = y2;
            this.y3 = y3;
            this.x4 = x4;
            this.y4 = y4;
        }

        public static IEnumerable<Quartet> Data
        {
            get
            {
                yield return new Quartet(10, 8.04, 9.14, 7.46, 8, 6.58);
                yield return new Quartet(8, 6.95, 8.14, 6.77, 8, 5.76);
                yield return new Quartet(13, 7.58, 8.74, 12.74, 8, 7.71);
                yield return new Quartet(9, 8.81, 8.77, 7.11, 8, 8.84);
                yield return new Quartet(11, 8.33, 9.26, 7.81, 8, 8.47);
                yield return new Quartet(14, 9.96, 8.1, 8.84, 8, 7.04);
                yield return new Quartet(6, 7.24, 6.13, 6.08, 8, 5.25);
                yield return new Quartet(4, 4.26, 3.1, 5.39, 19, 12.5);
                yield return new Quartet(12, 10.84, 9.13, 8.15, 8, 5.56);
                yield return new Quartet(7, 4.82, 7.26, 6.42, 8, 7.91);
                yield return new Quartet(5, 5.68, 4.74, 5.73, 8, 6.89);
            }
        }
    }
}
