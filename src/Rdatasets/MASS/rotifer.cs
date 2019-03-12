// ReSharper disable All

namespace Rdatasets.MASS
{
    using System.Collections.Generic;

    /// <summary>
    /// Numbers of Rotifers by Fluid Density
    /// </summary>

    public class rotifer
    {
        public readonly int κ;
        public readonly double density;
        public readonly int pm_y;
        public readonly int pm_tot;
        public readonly int kc_y;
        public readonly int kc_tot;

        public rotifer(int κ, double density, int pm_y, int pm_tot, int kc_y, int kc_tot)
        {
            this.κ = κ;
            this.density = density;
            this.pm_y = pm_y;
            this.pm_tot = pm_tot;
            this.kc_y = kc_y;
            this.kc_tot = kc_tot;
        }

        public static IEnumerable<rotifer> Data
        {
            get
            {
                yield return new rotifer(1, 1.019, 11, 58, 13, 161);
                yield return new rotifer(2, 1.02, 7, 86, 14, 248);
                yield return new rotifer(3, 1.021, 10, 76, 30, 234);
                yield return new rotifer(4, 1.03, 19, 83, 10, 283);
                yield return new rotifer(5, 1.03, 9, 56, 14, 129);
                yield return new rotifer(6, 1.03, 21, 73, 35, 161);
                yield return new rotifer(7, 1.031, 13, 29, 26, 167);
                yield return new rotifer(8, 1.04, 34, 44, 32, 286);
                yield return new rotifer(9, 1.04, 10, 31, 22, 117);
                yield return new rotifer(10, 1.041, 36, 56, 23, 162);
                yield return new rotifer(11, 1.048, 20, 27, 7, 42);
                yield return new rotifer(12, 1.049, 54, 59, 22, 48);
                yield return new rotifer(13, 1.05, 20, 22, 9, 49);
                yield return new rotifer(14, 1.05, 9, 14, 34, 160);
                yield return new rotifer(15, 1.06, 14, 17, 71, 74);
                yield return new rotifer(16, 1.061, 10, 22, 25, 45);
                yield return new rotifer(17, 1.063, 64, 66, 94, 101);
                yield return new rotifer(18, 1.07, 68, 86, 63, 68);
                yield return new rotifer(19, 1.07, 488, 492, 178, 190);
                yield return new rotifer(20, 1.07, 88, 89, 154, 154);
            }
        }
    }
}
