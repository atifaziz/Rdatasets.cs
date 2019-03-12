// ReSharper disable All

namespace Rdatasets.robustbase
{
    using System.Collections.Generic;

    /// <summary>
    /// Cloud point of a Liquid
    /// </summary>

    public class cloud
    {
        public readonly int κ;
        public readonly int Percentage;
        public readonly double CloudPoint;

        public cloud(int κ, int Percentage, double CloudPoint)
        {
            this.κ = κ;
            this.Percentage = Percentage;
            this.CloudPoint = CloudPoint;
        }

        public static IEnumerable<cloud> Data
        {
            get
            {
                yield return new cloud(1, 0, 22.1);
                yield return new cloud(2, 1, 24.5);
                yield return new cloud(3, 2, 26);
                yield return new cloud(4, 3, 26.8);
                yield return new cloud(5, 4, 28.2);
                yield return new cloud(6, 5, 28.9);
                yield return new cloud(7, 6, 30);
                yield return new cloud(8, 7, 30.4);
                yield return new cloud(9, 8, 31.4);
                yield return new cloud(10, 0, 21.9);
                yield return new cloud(11, 2, 26.1);
                yield return new cloud(12, 4, 28.5);
                yield return new cloud(13, 6, 30.3);
                yield return new cloud(14, 8, 31.5);
                yield return new cloud(15, 10, 33.1);
                yield return new cloud(16, 0, 22.8);
                yield return new cloud(17, 3, 27.3);
                yield return new cloud(18, 6, 29.8);
                yield return new cloud(19, 9, 31.8);
            }
        }
    }
}
