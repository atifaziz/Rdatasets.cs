// ReSharper disable All

namespace Rdatasets.Ecdat
{
    using System.Collections.Generic;

    /// <summary>
    /// Solow's Technological Change Data
    /// </summary>

    public class Solow
    {
        public readonly int κ;
        public readonly double q;
        public readonly double k;
        public readonly double A;

        public Solow(int κ, double q, double k, double A)
        {
            this.κ = κ;
            this.q = q;
            this.k = k;
            this.A = A;
        }

        public static IEnumerable<Solow> Data
        {
            get
            {
                yield return new Solow(1, 0.623, 2.06, 1);
                yield return new Solow(2, 0.616, 2.1, 0.983);
                yield return new Solow(3, 0.647, 2.17, 1.021);
                yield return new Solow(4, 0.652, 2.21, 1.023);
                yield return new Solow(5, 0.68, 2.23, 1.064);
                yield return new Solow(6, 0.682, 2.2, 1.071);
                yield return new Solow(7, 0.669, 2.26, 1.041);
                yield return new Solow(8, 0.7, 2.34, 1.076);
                yield return new Solow(9, 0.679, 2.21, 1.065);
                yield return new Solow(10, 0.729, 2.22, 1.142);
                yield return new Solow(11, 0.767, 2.47, 1.157);
                yield return new Solow(12, 0.721, 2.58, 1.069);
                yield return new Solow(13, 0.77, 2.55, 1.146);
                yield return new Solow(14, 0.788, 2.49, 1.183);
                yield return new Solow(15, 0.809, 2.61, 1.196);
                yield return new Solow(16, 0.836, 2.74, 1.215);
                yield return new Solow(17, 0.872, 2.81, 1.254);
                yield return new Solow(18, 0.869, 2.87, 1.241);
                yield return new Solow(19, 0.871, 2.93, 1.235);
                yield return new Solow(20, 0.874, 3.02, 1.226);
                yield return new Solow(21, 0.895, 3.06, 1.251);
                yield return new Solow(22, 0.88, 3.3, 1.197);
                yield return new Solow(23, 0.904, 3.33, 1.226);
                yield return new Solow(24, 0.879, 3.28, 1.198);
                yield return new Solow(25, 0.869, 3.1, 1.211);
                yield return new Solow(26, 0.921, 3, 1.298);
                yield return new Solow(27, 0.943, 2.87, 1.349);
                yield return new Solow(28, 0.982, 2.72, 1.429);
                yield return new Solow(29, 0.971, 2.71, 1.415);
                yield return new Solow(30, 1, 2.78, 1.445);
                yield return new Solow(31, 1.034, 2.66, 1.514);
                yield return new Solow(32, 1.082, 2.63, 1.59);
                yield return new Solow(33, 1.122, 2.58, 1.66);
                yield return new Solow(34, 1.136, 2.64, 1.665);
                yield return new Solow(35, 1.18, 2.62, 1.692);
                yield return new Solow(36, 1.265, 2.63, 1.812);
                yield return new Solow(37, 1.296, 2.66, 1.85);
                yield return new Solow(38, 1.215, 2.5, 1.769);
                yield return new Solow(39, 1.194, 2.5, 1.739);
                yield return new Solow(40, 1.221, 2.55, 1.767);
                yield return new Solow(41, 1.275, 2.7, 1.809);
            }
        }
    }
}
