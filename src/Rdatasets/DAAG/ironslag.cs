// ReSharper disable All

namespace Rdatasets.DAAG
{
    using System.Collections.Generic;

    /// <summary>
    /// Iron Content Measurements
    /// </summary>

    public class ironslag
    {
        public readonly int κ;
        public readonly int chemical;
        public readonly int magnetic;

        public ironslag(int κ, int chemical, int magnetic)
        {
            this.κ = κ;
            this.chemical = chemical;
            this.magnetic = magnetic;
        }

        public static IEnumerable<ironslag> Data
        {
            get
            {
                yield return new ironslag(1, 24, 25);
                yield return new ironslag(2, 16, 22);
                yield return new ironslag(3, 24, 17);
                yield return new ironslag(4, 18, 21);
                yield return new ironslag(5, 18, 20);
                yield return new ironslag(6, 10, 13);
                yield return new ironslag(7, 14, 16);
                yield return new ironslag(8, 16, 14);
                yield return new ironslag(9, 18, 19);
                yield return new ironslag(10, 20, 10);
                yield return new ironslag(11, 21, 23);
                yield return new ironslag(12, 20, 20);
                yield return new ironslag(13, 21, 19);
                yield return new ironslag(14, 15, 15);
                yield return new ironslag(15, 16, 16);
                yield return new ironslag(16, 15, 16);
                yield return new ironslag(17, 17, 12);
                yield return new ironslag(18, 19, 15);
                yield return new ironslag(19, 16, 15);
                yield return new ironslag(20, 15, 15);
                yield return new ironslag(21, 15, 15);
                yield return new ironslag(22, 13, 17);
                yield return new ironslag(23, 24, 18);
                yield return new ironslag(24, 22, 16);
                yield return new ironslag(25, 21, 18);
                yield return new ironslag(26, 24, 22);
                yield return new ironslag(27, 15, 20);
                yield return new ironslag(28, 20, 21);
                yield return new ironslag(29, 20, 21);
                yield return new ironslag(30, 25, 21);
                yield return new ironslag(31, 27, 25);
                yield return new ironslag(32, 22, 22);
                yield return new ironslag(33, 20, 18);
                yield return new ironslag(34, 24, 21);
                yield return new ironslag(35, 24, 18);
                yield return new ironslag(36, 23, 20);
                yield return new ironslag(37, 29, 25);
                yield return new ironslag(38, 27, 20);
                yield return new ironslag(39, 23, 18);
                yield return new ironslag(40, 19, 19);
                yield return new ironslag(41, 25, 16);
                yield return new ironslag(42, 15, 16);
                yield return new ironslag(43, 16, 16);
                yield return new ironslag(44, 27, 26);
                yield return new ironslag(45, 27, 28);
                yield return new ironslag(46, 30, 28);
                yield return new ironslag(47, 29, 30);
                yield return new ironslag(48, 26, 32);
                yield return new ironslag(49, 25, 28);
                yield return new ironslag(50, 25, 36);
                yield return new ironslag(51, 32, 40);
                yield return new ironslag(52, 28, 33);
                yield return new ironslag(53, 25, 33);
            }
        }
    }
}
