// ReSharper disable All

namespace Rdatasets.DAAG
{
    using System.Collections.Generic;

    /// <summary>
    /// Oxygen uptake versus mechanical power, for humans
    /// </summary>

    public class humanpower2
    {
        public readonly int κ;
        public readonly double wattsPerKg;
        public readonly double o2;
        public readonly int id;

        public humanpower2(int κ, double wattsPerKg, double o2, int id)
        {
            this.κ = κ;
            this.wattsPerKg = wattsPerKg;
            this.o2 = o2;
            this.id = id;
        }

        public static IEnumerable<humanpower2> Data
        {
            get
            {
                yield return new humanpower2(1, 2.72, 41.09, 1);
                yield return new humanpower2(2, 3.2, 46.61, 1);
                yield return new humanpower2(3, 3.66, 52.22, 1);
                yield return new humanpower2(4, 4.1, 59.51, 1);
                yield return new humanpower2(5, 4.56, 67.32, 1);
                yield return new humanpower2(6, 5.03, 69.05, 1);
                yield return new humanpower2(7, 2.91, 33.75, 2);
                yield return new humanpower2(8, 3.48, 41.22, 2);
                yield return new humanpower2(9, 4.07, 48.86, 2);
                yield return new humanpower2(10, 4.65, 53.91, 2);
                yield return new humanpower2(11, 5.23, 59.86, 2);
                yield return new humanpower2(12, 5.86, 66.12, 2);
                yield return new humanpower2(13, 6.43, 69.48, 2);
                yield return new humanpower2(14, 3.18, 41.83, 3);
                yield return new humanpower2(21, 3.65, 45.79, 3);
                yield return new humanpower2(31, 4.12, 50.62, 3);
                yield return new humanpower2(41, 4.56, 55.48, 3);
                yield return new humanpower2(51, 5.02, 59.96, 3);
                yield return new humanpower2(61, 5.47, 67.04, 3);
                yield return new humanpower2(71, 5.93, 68.17, 3);
                yield return new humanpower2(15, 2.59, 37.27, 4);
                yield return new humanpower2(22, 3.1, 45.18, 4);
                yield return new humanpower2(32, 3.62, 51.08, 4);
                yield return new humanpower2(42, 4.14, 57.4, 4);
                yield return new humanpower2(52, 4.67, 64.15, 4);
                yield return new humanpower2(62, 4.81, 67.63, 4);
            }
        }
    }
}
