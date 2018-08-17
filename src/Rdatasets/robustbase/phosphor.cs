// ReSharper disable All

namespace Rdatasets.robustbase
{
    using System.Collections.Generic;

    /// <summary>
    /// Phosphorus Content Data
    /// </summary>

    public class phosphor
    {
        public readonly double inorg;
        public readonly int organic;
        public readonly int plant;

        public phosphor(double inorg, int organic, int plant)
        {
            this.inorg = inorg;
            this.organic = organic;
            this.plant = plant;
        }

        public static IEnumerable<phosphor> Data
        {
            get
            {
                yield return new phosphor(0.4, 53, 64);
                yield return new phosphor(0.4, 23, 60);
                yield return new phosphor(3.1, 19, 71);
                yield return new phosphor(0.6, 34, 61);
                yield return new phosphor(4.7, 24, 54);
                yield return new phosphor(1.7, 65, 77);
                yield return new phosphor(9.4, 44, 81);
                yield return new phosphor(10.1, 31, 93);
                yield return new phosphor(11.6, 29, 93);
                yield return new phosphor(12.6, 58, 51);
                yield return new phosphor(10.9, 37, 76);
                yield return new phosphor(23.1, 46, 96);
                yield return new phosphor(23.1, 50, 77);
                yield return new phosphor(21.6, 44, 93);
                yield return new phosphor(23.1, 56, 95);
                yield return new phosphor(1.9, 36, 54);
                yield return new phosphor(26.8, 58, 168);
                yield return new phosphor(29.9, 51, 99);
            }
        }
    }
}
