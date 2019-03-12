// ReSharper disable All

namespace Rdatasets.drc
{
    using System.Collections.Generic;

    /// <summary>
    /// Test data from a 21 day fish test
    /// </summary>

    public class O_mykiss
    {
        public readonly int κ;
        public readonly double conc;
        public readonly double? weight;

        public O_mykiss(int κ, double conc, double? weight)
        {
            this.κ = κ;
            this.conc = conc;
            this.weight = weight;
        }

        public static IEnumerable<O_mykiss> Data
        {
            get
            {
                yield return new O_mykiss(1, 0, 2.8);
                yield return new O_mykiss(2, 0, 3);
                yield return new O_mykiss(3, 0, 2.7);
                yield return new O_mykiss(4, 0, 3.9);
                yield return new O_mykiss(5, 0, 3.1);
                yield return new O_mykiss(6, 0, 1.8);
                yield return new O_mykiss(7, 0, 2.9);
                yield return new O_mykiss(8, 0, 2.5);
                yield return new O_mykiss(9, 0, 2.2);
                yield return new O_mykiss(10, 0, 3.1);
                yield return new O_mykiss(11, 1, 2.7);
                yield return new O_mykiss(12, 1, 3.3);
                yield return new O_mykiss(13, 1, 2.9);
                yield return new O_mykiss(14, 1, 2.2);
                yield return new O_mykiss(15, 1, 2);
                yield return new O_mykiss(16, 1, 3.1);
                yield return new O_mykiss(17, 1, 3.2);
                yield return new O_mykiss(18, 1, 2.5);
                yield return new O_mykiss(19, 1, 2.5);
                yield return new O_mykiss(20, 1, 2.6);
                yield return new O_mykiss(21, 2.2, 2.9);
                yield return new O_mykiss(22, 2.2, 2.6);
                yield return new O_mykiss(23, 2.2, 2.7);
                yield return new O_mykiss(24, 2.2, 3.3);
                yield return new O_mykiss(25, 2.2, 2.7);
                yield return new O_mykiss(26, 2.2, 4);
                yield return new O_mykiss(27, 2.2, 3);
                yield return new O_mykiss(28, 2.2, 2.5);
                yield return new O_mykiss(29, 2.2, 2.2);
                yield return new O_mykiss(30, 2.2, null);
                yield return new O_mykiss(31, 4.6, 2.9);
                yield return new O_mykiss(32, 4.6, 3);
                yield return new O_mykiss(33, 4.6, 3.5);
                yield return new O_mykiss(34, 4.6, 2.7);
                yield return new O_mykiss(35, 4.6, 2.3);
                yield return new O_mykiss(36, 4.6, 2.7);
                yield return new O_mykiss(37, 4.6, 2);
                yield return new O_mykiss(38, 4.6, 4);
                yield return new O_mykiss(39, 4.6, 2.2);
                yield return new O_mykiss(40, 4.6, 2.4);
                yield return new O_mykiss(41, 10, 3.4);
                yield return new O_mykiss(42, 10, 2.8);
                yield return new O_mykiss(43, 10, 2.1);
                yield return new O_mykiss(44, 10, 2.3);
                yield return new O_mykiss(45, 10, 3.1);
                yield return new O_mykiss(46, 10, 1.8);
                yield return new O_mykiss(47, 10, 2.4);
                yield return new O_mykiss(48, 10, 3);
                yield return new O_mykiss(49, 10, 2.3);
                yield return new O_mykiss(50, 10, null);
                yield return new O_mykiss(51, 22, 2.7);
                yield return new O_mykiss(52, 22, 2);
                yield return new O_mykiss(53, 22, 3.5);
                yield return new O_mykiss(54, 22, 1.8);
                yield return new O_mykiss(55, 22, 3.1);
                yield return new O_mykiss(56, 22, 3.2);
                yield return new O_mykiss(57, 22, 2.2);
                yield return new O_mykiss(58, 22, 2.5);
                yield return new O_mykiss(59, 22, 1.8);
                yield return new O_mykiss(60, 22, null);
                yield return new O_mykiss(61, 46, 1.6);
                yield return new O_mykiss(62, 46, 2.8);
                yield return new O_mykiss(63, 46, 1.2);
                yield return new O_mykiss(64, 46, 0.9);
                yield return new O_mykiss(65, 46, null);
                yield return new O_mykiss(66, 46, null);
                yield return new O_mykiss(67, 46, null);
                yield return new O_mykiss(68, 46, null);
                yield return new O_mykiss(69, 46, null);
                yield return new O_mykiss(70, 46, null);
            }
        }
    }
}
