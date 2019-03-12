// ReSharper disable All

namespace Rdatasets.carData
{
    using System.Collections.Generic;

    /// <summary>
    /// Contrived Collinear Data
    /// </summary>

    public class Mandel
    {
        public readonly int κ;
        public readonly double x1;
        public readonly double x2;
        public readonly double y;

        public Mandel(int κ, double x1, double x2, double y)
        {
            this.κ = κ;
            this.x1 = x1;
            this.x2 = x2;
            this.y = y;
        }

        public static IEnumerable<Mandel> Data
        {
            get
            {
                yield return new Mandel(1, 16.85, 1.46, 41.38);
                yield return new Mandel(2, 24.81, -4.61, 31.01);
                yield return new Mandel(3, 18.85, -0.21, 37.41);
                yield return new Mandel(4, 12.63, 4.93, 50.05);
                yield return new Mandel(5, 21.38, -1.36, 39.17);
                yield return new Mandel(6, 18.78, -0.08, 38.86);
                yield return new Mandel(7, 15.58, 2.98, 46.14);
                yield return new Mandel(8, 16.3, 1.73, 44.47);
            }
        }
    }
}
