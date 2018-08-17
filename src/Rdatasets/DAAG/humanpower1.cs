// ReSharper disable All

namespace Rdatasets.DAAG
{
    using System.Collections.Generic;

    /// <summary>
    /// Oxygen uptake versus mechanical power, for humans
    /// </summary>

    public class humanpower1
    {
        public readonly double wattsPerKg;
        public readonly double o2;
        public readonly int id;

        public humanpower1(double wattsPerKg, double o2, int id)
        {
            this.wattsPerKg = wattsPerKg;
            this.o2 = o2;
            this.id = id;
        }

        public static IEnumerable<humanpower1> Data
        {
            get
            {
                yield return new humanpower1(2.02, 28.56, 1);
                yield return new humanpower1(2.45, 36.22, 1);
                yield return new humanpower1(2.83, 46.04, 1);
                yield return new humanpower1(3.24, 45.9, 1);
                yield return new humanpower1(3.64, 55.14, 1);
                yield return new humanpower1(4.04, 62.21, 1);
                yield return new humanpower1(4.23, 63.42, 1);
                yield return new humanpower1(4.44, 66.08, 1);
                yield return new humanpower1(2.12, 30.81, 2);
                yield return new humanpower1(2.64, 35.45, 2);
                yield return new humanpower1(3.18, 46.17, 2);
                yield return new humanpower1(3.45, 51.98, 2);
                yield return new humanpower1(3.71, 52.88, 2);
                yield return new humanpower1(3.96, 58.38, 2);
                yield return new humanpower1(4.23, 55.59, 2);
                yield return new humanpower1(2.51, 35.18, 3);
                yield return new humanpower1(3.06, 45, 3);
                yield return new humanpower1(3.62, 57.84, 3);
                yield return new humanpower1(3.89, 59.95, 3);
                yield return new humanpower1(2.14, 31.8, 4);
                yield return new humanpower1(2.49, 38.38, 4);
                yield return new humanpower1(2.85, 44.32, 4);
                yield return new humanpower1(3.21, 44.64, 4);
                yield return new humanpower1(3.38, 47.48, 4);
                yield return new humanpower1(2.31, 35.99, 5);
                yield return new humanpower1(2.87, 41.17, 5);
                yield return new humanpower1(3.46, 46.17, 5);
                yield return new humanpower1(4.03, 54.19, 5);
            }
        }
    }
}
