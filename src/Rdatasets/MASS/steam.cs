// ReSharper disable All

namespace Rdatasets.MASS
{
    using System.Collections.Generic;

    /// <summary>
    /// The Saturated Steam Pressure Data
    /// </summary>

    public class steam
    {
        public readonly int κ;
        public readonly int Temp;
        public readonly double Press;

        public steam(int κ, int Temp, double Press)
        {
            this.κ = κ;
            this.Temp = Temp;
            this.Press = Press;
        }

        public static IEnumerable<steam> Data
        {
            get
            {
                yield return new steam(1, 0, 4.14);
                yield return new steam(2, 10, 8.52);
                yield return new steam(3, 20, 16.31);
                yield return new steam(4, 30, 32.18);
                yield return new steam(5, 40, 64.62);
                yield return new steam(6, 50, 98.76);
                yield return new steam(7, 60, 151.13);
                yield return new steam(8, 70, 224.74);
                yield return new steam(9, 80, 341.35);
                yield return new steam(10, 85, 423.36);
                yield return new steam(11, 90, 522.78);
                yield return new steam(12, 95, 674.32);
                yield return new steam(13, 100, 782.04);
                yield return new steam(14, 105, 920.01);
            }
        }
    }
}
