// ReSharper disable All

namespace Rdatasets.robustbase
{
    using System.Collections.Generic;

    /// <summary>
    /// Heart Catherization Data
    /// </summary>

    public class heart
    {
        public readonly int κ;
        public readonly double height;
        public readonly double weight;
        public readonly int clength;

        public heart(int κ, double height, double weight, int clength)
        {
            this.κ = κ;
            this.height = height;
            this.weight = weight;
            this.clength = clength;
        }

        public static IEnumerable<heart> Data
        {
            get
            {
                yield return new heart(1, 42.8, 40, 37);
                yield return new heart(2, 63.5, 93.5, 50);
                yield return new heart(3, 37.5, 35.5, 34);
                yield return new heart(4, 39.5, 30, 36);
                yield return new heart(5, 45.5, 52, 43);
                yield return new heart(6, 38.5, 17, 28);
                yield return new heart(7, 43, 38.5, 37);
                yield return new heart(8, 22.5, 8.5, 20);
                yield return new heart(9, 37, 33, 34);
                yield return new heart(10, 23.5, 9.5, 30);
                yield return new heart(11, 33, 21, 38);
                yield return new heart(12, 58, 79, 47);
            }
        }
    }
}
