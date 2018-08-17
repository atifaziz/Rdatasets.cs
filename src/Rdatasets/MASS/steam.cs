// ReSharper disable All

namespace Rdatasets.MASS
{
    using System.Collections.Generic;

    /// <summary>
    /// The Saturated Steam Pressure Data
    /// </summary>

    public class steam
    {
        public readonly int Temp;
        public readonly double Press;

        public steam(int Temp, double Press)
        {
            this.Temp = Temp;
            this.Press = Press;
        }

        public static IEnumerable<steam> Data
        {
            get
            {
                yield return new steam(0, 4.14);
                yield return new steam(10, 8.52);
                yield return new steam(20, 16.31);
                yield return new steam(30, 32.18);
                yield return new steam(40, 64.62);
                yield return new steam(50, 98.76);
                yield return new steam(60, 151.13);
                yield return new steam(70, 224.74);
                yield return new steam(80, 341.35);
                yield return new steam(85, 423.36);
                yield return new steam(90, 522.78);
                yield return new steam(95, 674.32);
                yield return new steam(100, 782.04);
                yield return new steam(105, 920.01);
            }
        }
    }
}
