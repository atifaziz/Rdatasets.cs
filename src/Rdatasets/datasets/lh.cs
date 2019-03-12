// ReSharper disable All

namespace Rdatasets.datasets
{
    using System.Collections.Generic;

    /// <summary>
    /// Luteinizing Hormone in Blood Samples
    /// </summary>

    public class lh
    {
        public readonly int κ;
        public readonly int time;
        public readonly double value;

        public lh(int κ, int time, double value)
        {
            this.κ = κ;
            this.time = time;
            this.value = value;
        }

        public static IEnumerable<lh> Data
        {
            get
            {
                yield return new lh(1, 1, 2.4);
                yield return new lh(2, 2, 2.4);
                yield return new lh(3, 3, 2.4);
                yield return new lh(4, 4, 2.2);
                yield return new lh(5, 5, 2.1);
                yield return new lh(6, 6, 1.5);
                yield return new lh(7, 7, 2.3);
                yield return new lh(8, 8, 2.3);
                yield return new lh(9, 9, 2.5);
                yield return new lh(10, 10, 2);
                yield return new lh(11, 11, 1.9);
                yield return new lh(12, 12, 1.7);
                yield return new lh(13, 13, 2.2);
                yield return new lh(14, 14, 1.8);
                yield return new lh(15, 15, 3.2);
                yield return new lh(16, 16, 3.2);
                yield return new lh(17, 17, 2.7);
                yield return new lh(18, 18, 2.2);
                yield return new lh(19, 19, 2.2);
                yield return new lh(20, 20, 1.9);
                yield return new lh(21, 21, 1.9);
                yield return new lh(22, 22, 1.8);
                yield return new lh(23, 23, 2.7);
                yield return new lh(24, 24, 3);
                yield return new lh(25, 25, 2.3);
                yield return new lh(26, 26, 2);
                yield return new lh(27, 27, 2);
                yield return new lh(28, 28, 2.9);
                yield return new lh(29, 29, 2.9);
                yield return new lh(30, 30, 2.7);
                yield return new lh(31, 31, 2.7);
                yield return new lh(32, 32, 2.3);
                yield return new lh(33, 33, 2.6);
                yield return new lh(34, 34, 2.4);
                yield return new lh(35, 35, 1.8);
                yield return new lh(36, 36, 1.7);
                yield return new lh(37, 37, 1.5);
                yield return new lh(38, 38, 1.4);
                yield return new lh(39, 39, 2.1);
                yield return new lh(40, 40, 3.3);
                yield return new lh(41, 41, 3.5);
                yield return new lh(42, 42, 3.5);
                yield return new lh(43, 43, 3.1);
                yield return new lh(44, 44, 2.6);
                yield return new lh(45, 45, 2.1);
                yield return new lh(46, 46, 3.4);
                yield return new lh(47, 47, 3);
                yield return new lh(48, 48, 2.9);
            }
        }
    }
}
