// ReSharper disable All

namespace Rdatasets.carData
{
    using System.Collections.Generic;

    /// <summary>
    /// Contrived Collinear Data
    /// </summary>

    public class Mandel
    {
        public readonly double x1;
        public readonly double x2;
        public readonly double y;

        public Mandel(double x1, double x2, double y)
        {
            this.x1 = x1;
            this.x2 = x2;
            this.y = y;
        }

        public static IEnumerable<Mandel> Data
        {
            get
            {
                yield return new Mandel(16.85, 1.46, 41.38);
                yield return new Mandel(24.81, -4.61, 31.01);
                yield return new Mandel(18.85, -0.21, 37.41);
                yield return new Mandel(12.63, 4.93, 50.05);
                yield return new Mandel(21.38, -1.36, 39.17);
                yield return new Mandel(18.78, -0.08, 38.86);
                yield return new Mandel(15.58, 2.98, 46.14);
                yield return new Mandel(16.3, 1.73, 44.47);
            }
        }
    }
}
