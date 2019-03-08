// ReSharper disable All

namespace Rdatasets.drc
{
    using System.Collections.Generic;

    /// <summary>
    /// Germination of common chickweed (_Stellaria media_)
    /// </summary>

    public class chickweed0
    {
        public readonly double time;
        public readonly int count;

        public chickweed0(double time, int count)
        {
            this.time = time;
            this.count = count;
        }

        public static IEnumerable<chickweed0> Data
        {
            get
            {
                yield return new chickweed0(12, 0);
                yield return new chickweed0(22, 0);
                yield return new chickweed0(30, 0);
                yield return new chickweed0(36, 0);
                yield return new chickweed0(46, 0);
                yield return new chickweed0(54, 0);
                yield return new chickweed0(60, 0);
                yield return new chickweed0(71, 0);
                yield return new chickweed0(78, 0);
                yield return new chickweed0(84, 0);
                yield return new chickweed0(95, 0);
                yield return new chickweed0(103, 0);
                yield return new chickweed0(109, 0);
                yield return new chickweed0(120, 0);
                yield return new chickweed0(129, 0);
                yield return new chickweed0(133, 0);
                yield return new chickweed0(143, 2);
                yield return new chickweed0(151, 2);
                yield return new chickweed0(158.5, 2);
                yield return new chickweed0(169.5, 2);
                yield return new chickweed0(176.5, 2);
                yield return new chickweed0(182.5, 5);
                yield return new chickweed0(192.5, 15);
                yield return new chickweed0(200.5, 26);
                yield return new chickweed0(206.5, 32);
                yield return new chickweed0(216.5, 37);
                yield return new chickweed0(224.5, 39);
                yield return new chickweed0(230.5, 39);
                yield return new chickweed0(241.5, 39);
                yield return new chickweed0(249.5, 39);
                yield return new chickweed0(254.5, 39);
                yield return new chickweed0(266.5, 39);
                yield return new chickweed0(276.5, 40);
                yield return new chickweed0(281.5, 40);
            }
        }
    }
}
