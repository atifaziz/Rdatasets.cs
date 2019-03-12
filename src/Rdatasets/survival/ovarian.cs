// ReSharper disable All

namespace Rdatasets.survival
{
    using System.Collections.Generic;

    /// <summary>
    /// Ovarian Cancer Survival Data
    /// </summary>

    public class ovarian
    {
        public readonly int κ;
        public readonly int futime;
        public readonly int fustat;
        public readonly double age;
        public readonly int resid_ds;
        public readonly int rx;
        public readonly int ecog_ps;

        public ovarian(int κ, int futime, int fustat, double age, int resid_ds, int rx, int ecog_ps)
        {
            this.κ = κ;
            this.futime = futime;
            this.fustat = fustat;
            this.age = age;
            this.resid_ds = resid_ds;
            this.rx = rx;
            this.ecog_ps = ecog_ps;
        }

        public static IEnumerable<ovarian> Data
        {
            get
            {
                yield return new ovarian(1, 59, 1, 72.3315, 2, 1, 1);
                yield return new ovarian(2, 115, 1, 74.4932, 2, 1, 1);
                yield return new ovarian(3, 156, 1, 66.4658, 2, 1, 2);
                yield return new ovarian(4, 421, 0, 53.3644, 2, 2, 1);
                yield return new ovarian(5, 431, 1, 50.3397, 2, 1, 1);
                yield return new ovarian(6, 448, 0, 56.4301, 1, 1, 2);
                yield return new ovarian(7, 464, 1, 56.937, 2, 2, 2);
                yield return new ovarian(8, 475, 1, 59.8548, 2, 2, 2);
                yield return new ovarian(9, 477, 0, 64.1753, 2, 1, 1);
                yield return new ovarian(10, 563, 1, 55.1781, 1, 2, 2);
                yield return new ovarian(11, 638, 1, 56.7562, 1, 1, 2);
                yield return new ovarian(12, 744, 0, 50.1096, 1, 2, 1);
                yield return new ovarian(13, 769, 0, 59.6301, 2, 2, 2);
                yield return new ovarian(14, 770, 0, 57.0521, 2, 2, 1);
                yield return new ovarian(15, 803, 0, 39.2712, 1, 1, 1);
                yield return new ovarian(16, 855, 0, 43.1233, 1, 1, 2);
                yield return new ovarian(17, 1040, 0, 38.8932, 2, 1, 2);
                yield return new ovarian(18, 1106, 0, 44.6, 1, 1, 1);
                yield return new ovarian(19, 1129, 0, 53.9068, 1, 2, 1);
                yield return new ovarian(20, 1206, 0, 44.2055, 2, 2, 1);
                yield return new ovarian(21, 1227, 0, 59.589, 1, 2, 2);
                yield return new ovarian(22, 268, 1, 74.5041, 2, 1, 2);
                yield return new ovarian(23, 329, 1, 43.137, 2, 1, 1);
                yield return new ovarian(24, 353, 1, 63.2192, 1, 2, 2);
                yield return new ovarian(25, 365, 1, 64.4247, 2, 2, 1);
                yield return new ovarian(26, 377, 0, 58.3096, 1, 2, 1);
            }
        }
    }
}
