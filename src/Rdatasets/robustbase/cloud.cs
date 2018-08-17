// ReSharper disable All

namespace Rdatasets.robustbase
{
    using System.Collections.Generic;

    /// <summary>
    /// Cloud point of a Liquid
    /// </summary>

    public class cloud
    {
        public readonly int Percentage;
        public readonly double CloudPoint;

        public cloud(int Percentage, double CloudPoint)
        {
            this.Percentage = Percentage;
            this.CloudPoint = CloudPoint;
        }

        public static IEnumerable<cloud> Data
        {
            get
            {
                yield return new cloud(0, 22.1);
                yield return new cloud(1, 24.5);
                yield return new cloud(2, 26);
                yield return new cloud(3, 26.8);
                yield return new cloud(4, 28.2);
                yield return new cloud(5, 28.9);
                yield return new cloud(6, 30);
                yield return new cloud(7, 30.4);
                yield return new cloud(8, 31.4);
                yield return new cloud(0, 21.9);
                yield return new cloud(2, 26.1);
                yield return new cloud(4, 28.5);
                yield return new cloud(6, 30.3);
                yield return new cloud(8, 31.5);
                yield return new cloud(10, 33.1);
                yield return new cloud(0, 22.8);
                yield return new cloud(3, 27.3);
                yield return new cloud(6, 29.8);
                yield return new cloud(9, 31.8);
            }
        }
    }
}
