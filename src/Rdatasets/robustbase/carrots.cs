// ReSharper disable All

namespace Rdatasets.robustbase
{
    using System.Collections.Generic;

    /// <summary>
    /// Insect Damages on Carrots
    /// </summary>

    public class carrots
    {
        public readonly int success;
        public readonly int total;
        public readonly double logdose;
        public readonly string block;

        public carrots(int success, int total, double logdose, string block)
        {
            this.success = success;
            this.total = total;
            this.logdose = logdose;
            this.block = block;
        }

        public static IEnumerable<carrots> Data
        {
            get
            {
                yield return new carrots(10, 35, 1.52, "B1");
                yield return new carrots(16, 42, 1.64, "B1");
                yield return new carrots(8, 50, 1.76, "B1");
                yield return new carrots(6, 42, 1.88, "B1");
                yield return new carrots(9, 35, 2, "B1");
                yield return new carrots(9, 42, 2.12, "B1");
                yield return new carrots(1, 32, 2.24, "B1");
                yield return new carrots(2, 28, 2.36, "B1");
                yield return new carrots(17, 38, 1.52, "B2");
                yield return new carrots(10, 40, 1.64, "B2");
                yield return new carrots(8, 33, 1.76, "B2");
                yield return new carrots(8, 39, 1.88, "B2");
                yield return new carrots(5, 47, 2, "B2");
                yield return new carrots(17, 42, 2.12, "B2");
                yield return new carrots(6, 35, 2.24, "B2");
                yield return new carrots(4, 35, 2.36, "B2");
                yield return new carrots(10, 34, 1.52, "B3");
                yield return new carrots(10, 38, 1.64, "B3");
                yield return new carrots(5, 36, 1.76, "B3");
                yield return new carrots(3, 35, 1.88, "B3");
                yield return new carrots(2, 49, 2, "B3");
                yield return new carrots(1, 40, 2.12, "B3");
                yield return new carrots(3, 22, 2.24, "B3");
                yield return new carrots(2, 31, 2.36, "B3");
            }
        }
    }
}
