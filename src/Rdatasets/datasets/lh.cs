// ReSharper disable All

namespace Rdatasets.datasets
{
    using System.Collections.Generic;

    /// <summary>
    /// Luteinizing Hormone in Blood Samples
    /// </summary>

    public class lh
    {
        public readonly int time;
        public readonly double value;

        public lh(int time, double value)
        {
            this.time = time;
            this.value = value;
        }

        public static IEnumerable<lh> Data
        {
            get
            {
                yield return new lh(1, 2.4);
                yield return new lh(2, 2.4);
                yield return new lh(3, 2.4);
                yield return new lh(4, 2.2);
                yield return new lh(5, 2.1);
                yield return new lh(6, 1.5);
                yield return new lh(7, 2.3);
                yield return new lh(8, 2.3);
                yield return new lh(9, 2.5);
                yield return new lh(10, 2);
                yield return new lh(11, 1.9);
                yield return new lh(12, 1.7);
                yield return new lh(13, 2.2);
                yield return new lh(14, 1.8);
                yield return new lh(15, 3.2);
                yield return new lh(16, 3.2);
                yield return new lh(17, 2.7);
                yield return new lh(18, 2.2);
                yield return new lh(19, 2.2);
                yield return new lh(20, 1.9);
                yield return new lh(21, 1.9);
                yield return new lh(22, 1.8);
                yield return new lh(23, 2.7);
                yield return new lh(24, 3);
                yield return new lh(25, 2.3);
                yield return new lh(26, 2);
                yield return new lh(27, 2);
                yield return new lh(28, 2.9);
                yield return new lh(29, 2.9);
                yield return new lh(30, 2.7);
                yield return new lh(31, 2.7);
                yield return new lh(32, 2.3);
                yield return new lh(33, 2.6);
                yield return new lh(34, 2.4);
                yield return new lh(35, 1.8);
                yield return new lh(36, 1.7);
                yield return new lh(37, 1.5);
                yield return new lh(38, 1.4);
                yield return new lh(39, 2.1);
                yield return new lh(40, 3.3);
                yield return new lh(41, 3.5);
                yield return new lh(42, 3.5);
                yield return new lh(43, 3.1);
                yield return new lh(44, 2.6);
                yield return new lh(45, 2.1);
                yield return new lh(46, 3.4);
                yield return new lh(47, 3);
                yield return new lh(48, 2.9);
            }
        }
    }
}
