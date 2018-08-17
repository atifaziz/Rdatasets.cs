// ReSharper disable All

namespace Rdatasets.boot
{
    using System.Collections.Generic;

    /// <summary>
    /// Number of Flaws in Cloth
    /// </summary>

    public class cloth
    {
        public readonly double x;
        public readonly int y;

        public cloth(double x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public static IEnumerable<cloth> Data
        {
            get
            {
                yield return new cloth(1.22, 1);
                yield return new cloth(1.7, 4);
                yield return new cloth(2.71, 5);
                yield return new cloth(3.71, 14);
                yield return new cloth(3.72, 7);
                yield return new cloth(3.75, 9);
                yield return new cloth(4.17, 2);
                yield return new cloth(4.41, 8);
                yield return new cloth(4.58, 4);
                yield return new cloth(4.91, 7);
                yield return new cloth(4.92, 4);
                yield return new cloth(4.95, 7);
                yield return new cloth(5.22, 6);
                yield return new cloth(5.42, 9);
                yield return new cloth(5.43, 8);
                yield return new cloth(5.51, 6);
                yield return new cloth(6.3, 7);
                yield return new cloth(6.42, 10);
                yield return new cloth(6.45, 6);
                yield return new cloth(6.51, 4);
                yield return new cloth(6.57, 9);
                yield return new cloth(7.15, 14);
                yield return new cloth(7.16, 3);
                yield return new cloth(7.35, 17);
                yield return new cloth(7.38, 9);
                yield return new cloth(7.49, 10);
                yield return new cloth(8.32, 17);
                yield return new cloth(8.42, 9);
                yield return new cloth(8.68, 8);
                yield return new cloth(8.95, 28);
                yield return new cloth(9.05, 23);
                yield return new cloth(9.52, 9);
            }
        }
    }
}
