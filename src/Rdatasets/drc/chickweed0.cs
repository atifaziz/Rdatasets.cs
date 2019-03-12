// ReSharper disable All

namespace Rdatasets.drc
{
    using System.Collections.Generic;

    /// <summary>
    /// Germination of common chickweed (_Stellaria media_)
    /// </summary>

    public class chickweed0
    {
        public readonly int κ;
        public readonly double time;
        public readonly int count;

        public chickweed0(int κ, double time, int count)
        {
            this.κ = κ;
            this.time = time;
            this.count = count;
        }

        public static IEnumerable<chickweed0> Data
        {
            get
            {
                yield return new chickweed0(1, 12, 0);
                yield return new chickweed0(2, 22, 0);
                yield return new chickweed0(3, 30, 0);
                yield return new chickweed0(4, 36, 0);
                yield return new chickweed0(5, 46, 0);
                yield return new chickweed0(6, 54, 0);
                yield return new chickweed0(7, 60, 0);
                yield return new chickweed0(8, 71, 0);
                yield return new chickweed0(9, 78, 0);
                yield return new chickweed0(10, 84, 0);
                yield return new chickweed0(11, 95, 0);
                yield return new chickweed0(12, 103, 0);
                yield return new chickweed0(13, 109, 0);
                yield return new chickweed0(14, 120, 0);
                yield return new chickweed0(15, 129, 0);
                yield return new chickweed0(16, 133, 0);
                yield return new chickweed0(17, 143, 2);
                yield return new chickweed0(18, 151, 2);
                yield return new chickweed0(19, 158.5, 2);
                yield return new chickweed0(20, 169.5, 2);
                yield return new chickweed0(21, 176.5, 2);
                yield return new chickweed0(22, 182.5, 5);
                yield return new chickweed0(23, 192.5, 15);
                yield return new chickweed0(24, 200.5, 26);
                yield return new chickweed0(25, 206.5, 32);
                yield return new chickweed0(26, 216.5, 37);
                yield return new chickweed0(27, 224.5, 39);
                yield return new chickweed0(28, 230.5, 39);
                yield return new chickweed0(29, 241.5, 39);
                yield return new chickweed0(30, 249.5, 39);
                yield return new chickweed0(31, 254.5, 39);
                yield return new chickweed0(32, 266.5, 39);
                yield return new chickweed0(33, 276.5, 40);
                yield return new chickweed0(34, 281.5, 40);
            }
        }
    }
}
