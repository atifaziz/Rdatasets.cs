// ReSharper disable All

namespace Rdatasets.robustbase
{
    using System.Collections.Generic;

    /// <summary>
    /// Phosphorus Content Data
    /// </summary>

    public class phosphor
    {
        public readonly int κ;
        public readonly double inorg;
        public readonly int organic;
        public readonly int plant;

        public phosphor(int κ, double inorg, int organic, int plant)
        {
            this.κ = κ;
            this.inorg = inorg;
            this.organic = organic;
            this.plant = plant;
        }

        public static IEnumerable<phosphor> Data
        {
            get
            {
                yield return new phosphor(1, 0.4, 53, 64);
                yield return new phosphor(2, 0.4, 23, 60);
                yield return new phosphor(3, 3.1, 19, 71);
                yield return new phosphor(4, 0.6, 34, 61);
                yield return new phosphor(5, 4.7, 24, 54);
                yield return new phosphor(6, 1.7, 65, 77);
                yield return new phosphor(7, 9.4, 44, 81);
                yield return new phosphor(8, 10.1, 31, 93);
                yield return new phosphor(9, 11.6, 29, 93);
                yield return new phosphor(10, 12.6, 58, 51);
                yield return new phosphor(11, 10.9, 37, 76);
                yield return new phosphor(12, 23.1, 46, 96);
                yield return new phosphor(13, 23.1, 50, 77);
                yield return new phosphor(14, 21.6, 44, 93);
                yield return new phosphor(15, 23.1, 56, 95);
                yield return new phosphor(16, 1.9, 36, 54);
                yield return new phosphor(17, 26.8, 58, 168);
                yield return new phosphor(18, 29.9, 51, 99);
            }
        }
    }
}
