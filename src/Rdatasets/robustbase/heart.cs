// ReSharper disable All

namespace Rdatasets.robustbase
{
    using System.Collections.Generic;

    /// <summary>
    /// Heart Catherization Data
    /// </summary>

    public class heart
    {
        public readonly double height;
        public readonly double weight;
        public readonly int clength;

        public heart(double height, double weight, int clength)
        {
            this.height = height;
            this.weight = weight;
            this.clength = clength;
        }

        public static IEnumerable<heart> Data
        {
            get
            {
                yield return new heart(42.8, 40, 37);
                yield return new heart(63.5, 93.5, 50);
                yield return new heart(37.5, 35.5, 34);
                yield return new heart(39.5, 30, 36);
                yield return new heart(45.5, 52, 43);
                yield return new heart(38.5, 17, 28);
                yield return new heart(43, 38.5, 37);
                yield return new heart(22.5, 8.5, 20);
                yield return new heart(37, 33, 34);
                yield return new heart(23.5, 9.5, 30);
                yield return new heart(33, 21, 38);
                yield return new heart(58, 79, 47);
            }
        }
    }
}
