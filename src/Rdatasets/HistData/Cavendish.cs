// ReSharper disable All

namespace Rdatasets.HistData
{
    using System.Collections.Generic;

    /// <summary>
    /// Cavendish's Determinations of the Density of the Earth
    /// </summary>

    public class Cavendish
    {
        public readonly int κ;
        public readonly double density;
        public readonly double density2;
        public readonly double? density3;

        public Cavendish(int κ, double density, double density2, double? density3)
        {
            this.κ = κ;
            this.density = density;
            this.density2 = density2;
            this.density3 = density3;
        }

        public static IEnumerable<Cavendish> Data
        {
            get
            {
                yield return new Cavendish(1, 5.5, 5.5, null);
                yield return new Cavendish(2, 5.61, 5.61, null);
                yield return new Cavendish(3, 4.88, 5.88, null);
                yield return new Cavendish(4, 5.07, 5.07, null);
                yield return new Cavendish(5, 5.26, 5.26, null);
                yield return new Cavendish(6, 5.55, 5.55, null);
                yield return new Cavendish(7, 5.36, 5.36, 5.36);
                yield return new Cavendish(8, 5.29, 5.29, 5.29);
                yield return new Cavendish(9, 5.58, 5.58, 5.58);
                yield return new Cavendish(10, 5.65, 5.65, 5.65);
                yield return new Cavendish(11, 5.57, 5.57, 5.57);
                yield return new Cavendish(12, 5.53, 5.53, 5.53);
                yield return new Cavendish(13, 5.62, 5.62, 5.62);
                yield return new Cavendish(14, 5.29, 5.29, 5.29);
                yield return new Cavendish(15, 5.44, 5.44, 5.44);
                yield return new Cavendish(16, 5.34, 5.34, 5.34);
                yield return new Cavendish(17, 5.79, 5.79, 5.79);
                yield return new Cavendish(18, 5.1, 5.1, 5.1);
                yield return new Cavendish(19, 5.27, 5.27, 5.27);
                yield return new Cavendish(20, 5.39, 5.39, 5.39);
                yield return new Cavendish(21, 5.42, 5.42, 5.42);
                yield return new Cavendish(22, 5.47, 5.47, 5.47);
                yield return new Cavendish(23, 5.63, 5.63, 5.63);
                yield return new Cavendish(24, 5.34, 5.34, 5.34);
                yield return new Cavendish(25, 5.46, 5.46, 5.46);
                yield return new Cavendish(26, 5.3, 5.3, 5.3);
                yield return new Cavendish(27, 5.75, 5.75, 5.75);
                yield return new Cavendish(28, 5.68, 5.68, 5.68);
                yield return new Cavendish(29, 5.85, 5.85, 5.85);
            }
        }
    }
}
