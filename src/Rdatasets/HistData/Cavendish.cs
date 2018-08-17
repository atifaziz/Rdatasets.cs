// ReSharper disable All

namespace Rdatasets.HistData
{
    using System.Collections.Generic;

    /// <summary>
    /// Cavendish's Determinations of the Density of the Earth
    /// </summary>

    public class Cavendish
    {
        public readonly double density;
        public readonly double density2;
        public readonly string density3;

        public Cavendish(double density, double density2, string density3)
        {
            this.density = density;
            this.density2 = density2;
            this.density3 = density3;
        }

        public static IEnumerable<Cavendish> Data
        {
            get
            {
                yield return new Cavendish(5.5, 5.5, null);
                yield return new Cavendish(5.61, 5.61, null);
                yield return new Cavendish(4.88, 5.88, null);
                yield return new Cavendish(5.07, 5.07, null);
                yield return new Cavendish(5.26, 5.26, null);
                yield return new Cavendish(5.55, 5.55, null);
                yield return new Cavendish(5.36, 5.36, "5.36");
                yield return new Cavendish(5.29, 5.29, "5.29");
                yield return new Cavendish(5.58, 5.58, "5.58");
                yield return new Cavendish(5.65, 5.65, "5.65");
                yield return new Cavendish(5.57, 5.57, "5.57");
                yield return new Cavendish(5.53, 5.53, "5.53");
                yield return new Cavendish(5.62, 5.62, "5.62");
                yield return new Cavendish(5.29, 5.29, "5.29");
                yield return new Cavendish(5.44, 5.44, "5.44");
                yield return new Cavendish(5.34, 5.34, "5.34");
                yield return new Cavendish(5.79, 5.79, "5.79");
                yield return new Cavendish(5.1, 5.1, "5.1");
                yield return new Cavendish(5.27, 5.27, "5.27");
                yield return new Cavendish(5.39, 5.39, "5.39");
                yield return new Cavendish(5.42, 5.42, "5.42");
                yield return new Cavendish(5.47, 5.47, "5.47");
                yield return new Cavendish(5.63, 5.63, "5.63");
                yield return new Cavendish(5.34, 5.34, "5.34");
                yield return new Cavendish(5.46, 5.46, "5.46");
                yield return new Cavendish(5.3, 5.3, "5.3");
                yield return new Cavendish(5.75, 5.75, "5.75");
                yield return new Cavendish(5.68, 5.68, "5.68");
                yield return new Cavendish(5.85, 5.85, "5.85");
            }
        }
    }
}
