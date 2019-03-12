// ReSharper disable All

namespace Rdatasets.boot
{
    using System.Collections.Generic;

    /// <summary>
    /// Tuna Sighting Data
    /// </summary>

    public class tuna
    {
        public readonly int κ;
        public readonly double y;

        public tuna(int κ, double y)
        {
            this.κ = κ;
            this.y = y;
        }

        public static IEnumerable<tuna> Data
        {
            get
            {
                yield return new tuna(1, 0.19);
                yield return new tuna(2, 0.28);
                yield return new tuna(3, 0.29);
                yield return new tuna(4, 0.45);
                yield return new tuna(5, 0.64);
                yield return new tuna(6, 0.65);
                yield return new tuna(7, 0.78);
                yield return new tuna(8, 0.85);
                yield return new tuna(9, 1);
                yield return new tuna(10, 1.16);
                yield return new tuna(11, 1.17);
                yield return new tuna(12, 1.29);
                yield return new tuna(13, 1.31);
                yield return new tuna(14, 1.34);
                yield return new tuna(15, 1.55);
                yield return new tuna(16, 1.6);
                yield return new tuna(17, 1.83);
                yield return new tuna(18, 1.91);
                yield return new tuna(19, 1.97);
                yield return new tuna(20, 2.05);
                yield return new tuna(21, 2.1);
                yield return new tuna(22, 2.17);
                yield return new tuna(23, 2.28);
                yield return new tuna(24, 2.41);
                yield return new tuna(25, 2.46);
                yield return new tuna(26, 2.51);
                yield return new tuna(27, 2.89);
                yield return new tuna(28, 2.89);
                yield return new tuna(29, 2.9);
                yield return new tuna(30, 2.92);
                yield return new tuna(31, 3.03);
                yield return new tuna(32, 3.19);
                yield return new tuna(33, 3.48);
                yield return new tuna(34, 3.79);
                yield return new tuna(35, 3.83);
                yield return new tuna(36, 3.94);
                yield return new tuna(37, 3.95);
                yield return new tuna(38, 4.11);
                yield return new tuna(39, 4.14);
                yield return new tuna(40, 4.19);
                yield return new tuna(41, 4.36);
                yield return new tuna(42, 4.53);
                yield return new tuna(43, 4.97);
                yield return new tuna(44, 5.02);
                yield return new tuna(45, 5.13);
                yield return new tuna(46, 5.75);
                yield return new tuna(47, 6.03);
                yield return new tuna(48, 6.19);
                yield return new tuna(49, 6.19);
                yield return new tuna(50, 6.45);
                yield return new tuna(51, 7.13);
                yield return new tuna(52, 7.35);
                yield return new tuna(53, 7.77);
                yield return new tuna(54, 7.8);
                yield return new tuna(55, 8.81);
                yield return new tuna(56, 9.22);
                yield return new tuna(57, 9.29);
                yield return new tuna(58, 9.78);
                yield return new tuna(59, 10.15);
                yield return new tuna(60, 11.32);
                yield return new tuna(61, 13.21);
                yield return new tuna(62, 13.27);
                yield return new tuna(63, 14.39);
                yield return new tuna(64, 16.26);
            }
        }
    }
}
