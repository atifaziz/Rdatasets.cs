// ReSharper disable All

namespace Rdatasets.DAAG
{
    using System.Collections.Generic;

    /// <summary>
    /// Oxygen uptake versus mechanical power, for humans
    /// </summary>

    public class humanpower1
    {
        public readonly int κ;
        public readonly double wattsPerKg;
        public readonly double o2;
        public readonly int id;

        public humanpower1(int κ, double wattsPerKg, double o2, int id)
        {
            this.κ = κ;
            this.wattsPerKg = wattsPerKg;
            this.o2 = o2;
            this.id = id;
        }

        public static IEnumerable<humanpower1> Data
        {
            get
            {
                yield return new humanpower1(1, 2.02, 28.56, 1);
                yield return new humanpower1(2, 2.45, 36.22, 1);
                yield return new humanpower1(3, 2.83, 46.04, 1);
                yield return new humanpower1(4, 3.24, 45.9, 1);
                yield return new humanpower1(5, 3.64, 55.14, 1);
                yield return new humanpower1(6, 4.04, 62.21, 1);
                yield return new humanpower1(7, 4.23, 63.42, 1);
                yield return new humanpower1(8, 4.44, 66.08, 1);
                yield return new humanpower1(9, 2.12, 30.81, 2);
                yield return new humanpower1(10, 2.64, 35.45, 2);
                yield return new humanpower1(11, 3.18, 46.17, 2);
                yield return new humanpower1(12, 3.45, 51.98, 2);
                yield return new humanpower1(13, 3.71, 52.88, 2);
                yield return new humanpower1(14, 3.96, 58.38, 2);
                yield return new humanpower1(15, 4.23, 55.59, 2);
                yield return new humanpower1(16, 2.51, 35.18, 3);
                yield return new humanpower1(17, 3.06, 45, 3);
                yield return new humanpower1(18, 3.62, 57.84, 3);
                yield return new humanpower1(19, 3.89, 59.95, 3);
                yield return new humanpower1(22, 2.14, 31.8, 4);
                yield return new humanpower1(23, 2.49, 38.38, 4);
                yield return new humanpower1(24, 2.85, 44.32, 4);
                yield return new humanpower1(25, 3.21, 44.64, 4);
                yield return new humanpower1(26, 3.38, 47.48, 4);
                yield return new humanpower1(27, 2.31, 35.99, 5);
                yield return new humanpower1(28, 2.87, 41.17, 5);
                yield return new humanpower1(20, 3.46, 46.17, 5);
                yield return new humanpower1(21, 4.03, 54.19, 5);
            }
        }
    }
}
