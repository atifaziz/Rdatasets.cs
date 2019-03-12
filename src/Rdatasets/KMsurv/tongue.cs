// ReSharper disable All

namespace Rdatasets.KMsurv
{
    using System.Collections.Generic;

    /// <summary>
    /// data from Section 1.11
    /// </summary>

    public class tongue
    {
        public readonly int κ;
        public readonly int type;
        public readonly int time;
        public readonly int delta;

        public tongue(int κ, int type, int time, int delta)
        {
            this.κ = κ;
            this.type = type;
            this.time = time;
            this.delta = delta;
        }

        public static IEnumerable<tongue> Data
        {
            get
            {
                yield return new tongue(1, 1, 1, 1);
                yield return new tongue(2, 1, 3, 1);
                yield return new tongue(3, 1, 3, 1);
                yield return new tongue(4, 1, 4, 1);
                yield return new tongue(5, 1, 10, 1);
                yield return new tongue(6, 1, 13, 1);
                yield return new tongue(7, 1, 13, 1);
                yield return new tongue(8, 1, 16, 1);
                yield return new tongue(9, 1, 16, 1);
                yield return new tongue(10, 1, 24, 1);
                yield return new tongue(11, 1, 26, 1);
                yield return new tongue(12, 1, 27, 1);
                yield return new tongue(13, 1, 28, 1);
                yield return new tongue(14, 1, 30, 1);
                yield return new tongue(15, 1, 30, 1);
                yield return new tongue(16, 1, 32, 1);
                yield return new tongue(17, 1, 41, 1);
                yield return new tongue(18, 1, 51, 1);
                yield return new tongue(19, 1, 65, 1);
                yield return new tongue(20, 1, 67, 1);
                yield return new tongue(21, 1, 70, 1);
                yield return new tongue(22, 1, 72, 1);
                yield return new tongue(23, 1, 73, 1);
                yield return new tongue(24, 1, 77, 1);
                yield return new tongue(25, 1, 91, 1);
                yield return new tongue(26, 1, 93, 1);
                yield return new tongue(27, 1, 96, 1);
                yield return new tongue(28, 1, 100, 1);
                yield return new tongue(29, 1, 104, 1);
                yield return new tongue(30, 1, 157, 1);
                yield return new tongue(31, 1, 167, 1);
                yield return new tongue(32, 1, 61, 0);
                yield return new tongue(33, 1, 74, 0);
                yield return new tongue(34, 1, 79, 0);
                yield return new tongue(35, 1, 80, 0);
                yield return new tongue(36, 1, 81, 0);
                yield return new tongue(37, 1, 87, 0);
                yield return new tongue(38, 1, 87, 0);
                yield return new tongue(39, 1, 88, 0);
                yield return new tongue(40, 1, 89, 0);
                yield return new tongue(41, 1, 93, 0);
                yield return new tongue(42, 1, 97, 0);
                yield return new tongue(43, 1, 101, 0);
                yield return new tongue(44, 1, 104, 0);
                yield return new tongue(45, 1, 108, 0);
                yield return new tongue(46, 1, 109, 0);
                yield return new tongue(47, 1, 120, 0);
                yield return new tongue(48, 1, 131, 0);
                yield return new tongue(49, 1, 150, 0);
                yield return new tongue(50, 1, 231, 0);
                yield return new tongue(51, 1, 240, 0);
                yield return new tongue(52, 1, 400, 0);
                yield return new tongue(53, 2, 1, 1);
                yield return new tongue(54, 2, 3, 1);
                yield return new tongue(55, 2, 4, 1);
                yield return new tongue(56, 2, 5, 1);
                yield return new tongue(57, 2, 5, 1);
                yield return new tongue(58, 2, 8, 1);
                yield return new tongue(59, 2, 12, 1);
                yield return new tongue(60, 2, 13, 1);
                yield return new tongue(61, 2, 18, 1);
                yield return new tongue(62, 2, 23, 1);
                yield return new tongue(63, 2, 26, 1);
                yield return new tongue(64, 2, 27, 1);
                yield return new tongue(65, 2, 30, 1);
                yield return new tongue(66, 2, 42, 1);
                yield return new tongue(67, 2, 56, 1);
                yield return new tongue(68, 2, 62, 1);
                yield return new tongue(69, 2, 69, 1);
                yield return new tongue(70, 2, 104, 1);
                yield return new tongue(71, 2, 104, 1);
                yield return new tongue(72, 2, 112, 1);
                yield return new tongue(73, 2, 129, 1);
                yield return new tongue(74, 2, 181, 1);
                yield return new tongue(75, 2, 8, 0);
                yield return new tongue(76, 2, 67, 0);
                yield return new tongue(77, 2, 76, 0);
                yield return new tongue(78, 2, 104, 0);
                yield return new tongue(79, 2, 176, 0);
                yield return new tongue(80, 2, 231, 0);
            }
        }
    }
}
