// ReSharper disable All

namespace Rdatasets.carData
{
    using System.Collections.Generic;

    /// <summary>
    /// Agricultural Production in Mazulu Village
    /// </summary>

    public class Sahlins
    {
        public readonly int κ;
        public readonly double consumers;
        public readonly double acres;

        public Sahlins(int κ, double consumers, double acres)
        {
            this.κ = κ;
            this.consumers = consumers;
            this.acres = acres;
        }

        public static IEnumerable<Sahlins> Data
        {
            get
            {
                yield return new Sahlins(1, 1, 1.71);
                yield return new Sahlins(2, 1.08, 1.52);
                yield return new Sahlins(3, 1.15, 1.29);
                yield return new Sahlins(4, 1.15, 3.09);
                yield return new Sahlins(5, 1.2, 2.21);
                yield return new Sahlins(6, 1.3, 2.26);
                yield return new Sahlins(7, 1.37, 2.4);
                yield return new Sahlins(8, 1.37, 2.1);
                yield return new Sahlins(9, 1.43, 1.96);
                yield return new Sahlins(10, 1.46, 2.09);
                yield return new Sahlins(11, 1.52, 2.02);
                yield return new Sahlins(12, 1.57, 1.31);
                yield return new Sahlins(13, 1.65, 2.17);
                yield return new Sahlins(14, 1.65, 2.28);
                yield return new Sahlins(15, 1.65, 2.41);
                yield return new Sahlins(16, 1.66, 2.23);
                yield return new Sahlins(17, 1.87, 3.04);
                yield return new Sahlins(18, 2.03, 2.06);
                yield return new Sahlins(19, 2.05, 2.73);
                yield return new Sahlins(20, 2.3, 2.36);
            }
        }
    }
}
