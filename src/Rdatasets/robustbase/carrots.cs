// ReSharper disable All

namespace Rdatasets.robustbase
{
    using System.Collections.Generic;

    /// <summary>
    /// Insect Damages on Carrots
    /// </summary>

    public class carrots
    {
        public readonly int κ;
        public readonly int success;
        public readonly int total;
        public readonly double logdose;
        public readonly string block;

        public carrots(int κ, int success, int total, double logdose, string block)
        {
            this.κ = κ;
            this.success = success;
            this.total = total;
            this.logdose = logdose;
            this.block = block;
        }

        public static IEnumerable<carrots> Data
        {
            get
            {
                yield return new carrots(1, 10, 35, 1.52, "B1");
                yield return new carrots(2, 16, 42, 1.64, "B1");
                yield return new carrots(3, 8, 50, 1.76, "B1");
                yield return new carrots(4, 6, 42, 1.88, "B1");
                yield return new carrots(5, 9, 35, 2, "B1");
                yield return new carrots(6, 9, 42, 2.12, "B1");
                yield return new carrots(7, 1, 32, 2.24, "B1");
                yield return new carrots(8, 2, 28, 2.36, "B1");
                yield return new carrots(9, 17, 38, 1.52, "B2");
                yield return new carrots(10, 10, 40, 1.64, "B2");
                yield return new carrots(11, 8, 33, 1.76, "B2");
                yield return new carrots(12, 8, 39, 1.88, "B2");
                yield return new carrots(13, 5, 47, 2, "B2");
                yield return new carrots(14, 17, 42, 2.12, "B2");
                yield return new carrots(15, 6, 35, 2.24, "B2");
                yield return new carrots(16, 4, 35, 2.36, "B2");
                yield return new carrots(17, 10, 34, 1.52, "B3");
                yield return new carrots(18, 10, 38, 1.64, "B3");
                yield return new carrots(19, 5, 36, 1.76, "B3");
                yield return new carrots(20, 3, 35, 1.88, "B3");
                yield return new carrots(21, 2, 49, 2, "B3");
                yield return new carrots(22, 1, 40, 2.12, "B3");
                yield return new carrots(23, 3, 22, 2.24, "B3");
                yield return new carrots(24, 2, 31, 2.36, "B3");
            }
        }
    }
}
