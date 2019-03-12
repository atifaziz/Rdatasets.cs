// ReSharper disable All

namespace Rdatasets.HSAUR
{
    using System.Collections.Generic;

    /// <summary>
    /// Blood Screening Data
    /// </summary>

    public class plasma
    {
        public readonly int κ;
        public readonly double fibrinogen;
        public readonly int globulin;
        public readonly string ESR;

        public plasma(int κ, double fibrinogen, int globulin, string ESR)
        {
            this.κ = κ;
            this.fibrinogen = fibrinogen;
            this.globulin = globulin;
            this.ESR = ESR;
        }

        public static IEnumerable<plasma> Data
        {
            get
            {
                yield return new plasma(1, 2.52, 38, "ESR < 20");
                yield return new plasma(2, 2.56, 31, "ESR < 20");
                yield return new plasma(3, 2.19, 33, "ESR < 20");
                yield return new plasma(4, 2.18, 31, "ESR < 20");
                yield return new plasma(5, 3.41, 37, "ESR < 20");
                yield return new plasma(6, 2.46, 36, "ESR < 20");
                yield return new plasma(7, 3.22, 38, "ESR < 20");
                yield return new plasma(8, 2.21, 37, "ESR < 20");
                yield return new plasma(9, 3.15, 39, "ESR < 20");
                yield return new plasma(10, 2.6, 41, "ESR < 20");
                yield return new plasma(11, 2.29, 36, "ESR < 20");
                yield return new plasma(12, 2.35, 29, "ESR < 20");
                yield return new plasma(16, 3.15, 36, "ESR < 20");
                yield return new plasma(18, 2.68, 34, "ESR < 20");
                yield return new plasma(19, 2.6, 38, "ESR < 20");
                yield return new plasma(20, 2.23, 37, "ESR < 20");
                yield return new plasma(21, 2.88, 30, "ESR < 20");
                yield return new plasma(22, 2.65, 46, "ESR < 20");
                yield return new plasma(24, 2.28, 36, "ESR < 20");
                yield return new plasma(25, 2.67, 39, "ESR < 20");
                yield return new plasma(26, 2.29, 31, "ESR < 20");
                yield return new plasma(27, 2.15, 31, "ESR < 20");
                yield return new plasma(28, 2.54, 28, "ESR < 20");
                yield return new plasma(30, 3.34, 30, "ESR < 20");
                yield return new plasma(31, 2.99, 36, "ESR < 20");
                yield return new plasma(32, 3.32, 35, "ESR < 20");
                yield return new plasma(13, 5.06, 37, "ESR > 20");
                yield return new plasma(14, 3.34, 32, "ESR > 20");
                yield return new plasma(15, 2.38, 37, "ESR > 20");
                yield return new plasma(17, 3.53, 46, "ESR > 20");
                yield return new plasma(23, 2.09, 44, "ESR > 20");
                yield return new plasma(29, 3.93, 32, "ESR > 20");
            }
        }
    }
}
