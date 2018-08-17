// ReSharper disable All

namespace Rdatasets.HSAUR
{
    using System.Collections.Generic;

    /// <summary>
    /// Blood Screening Data
    /// </summary>

    public class plasma
    {
        public readonly double fibrinogen;
        public readonly int globulin;
        public readonly string ESR;

        public plasma(double fibrinogen, int globulin, string ESR)
        {
            this.fibrinogen = fibrinogen;
            this.globulin = globulin;
            this.ESR = ESR;
        }

        public static IEnumerable<plasma> Data
        {
            get
            {
                yield return new plasma(2.52, 38, "ESR < 20");
                yield return new plasma(2.56, 31, "ESR < 20");
                yield return new plasma(2.19, 33, "ESR < 20");
                yield return new plasma(2.18, 31, "ESR < 20");
                yield return new plasma(3.41, 37, "ESR < 20");
                yield return new plasma(2.46, 36, "ESR < 20");
                yield return new plasma(3.22, 38, "ESR < 20");
                yield return new plasma(2.21, 37, "ESR < 20");
                yield return new plasma(3.15, 39, "ESR < 20");
                yield return new plasma(2.6, 41, "ESR < 20");
                yield return new plasma(2.29, 36, "ESR < 20");
                yield return new plasma(2.35, 29, "ESR < 20");
                yield return new plasma(3.15, 36, "ESR < 20");
                yield return new plasma(2.68, 34, "ESR < 20");
                yield return new plasma(2.6, 38, "ESR < 20");
                yield return new plasma(2.23, 37, "ESR < 20");
                yield return new plasma(2.88, 30, "ESR < 20");
                yield return new plasma(2.65, 46, "ESR < 20");
                yield return new plasma(2.28, 36, "ESR < 20");
                yield return new plasma(2.67, 39, "ESR < 20");
                yield return new plasma(2.29, 31, "ESR < 20");
                yield return new plasma(2.15, 31, "ESR < 20");
                yield return new plasma(2.54, 28, "ESR < 20");
                yield return new plasma(3.34, 30, "ESR < 20");
                yield return new plasma(2.99, 36, "ESR < 20");
                yield return new plasma(3.32, 35, "ESR < 20");
                yield return new plasma(5.06, 37, "ESR > 20");
                yield return new plasma(3.34, 32, "ESR > 20");
                yield return new plasma(2.38, 37, "ESR > 20");
                yield return new plasma(3.53, 46, "ESR > 20");
                yield return new plasma(2.09, 44, "ESR > 20");
                yield return new plasma(3.93, 32, "ESR > 20");
            }
        }
    }
}
