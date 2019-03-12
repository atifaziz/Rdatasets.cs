// ReSharper disable All

namespace Rdatasets.KMsurv
{
    using System.Collections.Generic;

    /// <summary>
    /// data from Section 1.18
    /// </summary>

    public class bcdeter
    {
        public readonly int κ;
        public readonly int lower;
        public readonly int? upper;
        public readonly int treat;

        public bcdeter(int κ, int lower, int? upper, int treat)
        {
            this.κ = κ;
            this.lower = lower;
            this.upper = upper;
            this.treat = treat;
        }

        public static IEnumerable<bcdeter> Data
        {
            get
            {
                yield return new bcdeter(1, 0, 5, 1);
                yield return new bcdeter(2, 0, 7, 1);
                yield return new bcdeter(3, 0, 8, 1);
                yield return new bcdeter(4, 4, 11, 1);
                yield return new bcdeter(5, 5, 11, 1);
                yield return new bcdeter(6, 5, 12, 1);
                yield return new bcdeter(7, 6, 10, 1);
                yield return new bcdeter(8, 7, 14, 1);
                yield return new bcdeter(9, 7, 16, 1);
                yield return new bcdeter(10, 11, 15, 1);
                yield return new bcdeter(11, 11, 18, 1);
                yield return new bcdeter(12, 17, 25, 1);
                yield return new bcdeter(13, 17, 25, 1);
                yield return new bcdeter(14, 18, 26, 1);
                yield return new bcdeter(15, 19, 35, 1);
                yield return new bcdeter(16, 25, 37, 1);
                yield return new bcdeter(17, 26, 40, 1);
                yield return new bcdeter(18, 27, 34, 1);
                yield return new bcdeter(19, 36, 44, 1);
                yield return new bcdeter(20, 36, 48, 1);
                yield return new bcdeter(21, 37, 44, 1);
                yield return new bcdeter(22, 0, 5, 2);
                yield return new bcdeter(23, 0, 22, 2);
                yield return new bcdeter(24, 4, 8, 2);
                yield return new bcdeter(25, 4, 9, 2);
                yield return new bcdeter(26, 5, 8, 2);
                yield return new bcdeter(27, 8, 12, 2);
                yield return new bcdeter(28, 8, 21, 2);
                yield return new bcdeter(29, 10, 17, 2);
                yield return new bcdeter(30, 10, 35, 2);
                yield return new bcdeter(31, 11, 13, 2);
                yield return new bcdeter(32, 11, 17, 2);
                yield return new bcdeter(33, 11, 20, 2);
                yield return new bcdeter(34, 12, 20, 2);
                yield return new bcdeter(35, 13, 39, 2);
                yield return new bcdeter(36, 14, 17, 2);
                yield return new bcdeter(37, 14, 19, 2);
                yield return new bcdeter(38, 15, 22, 2);
                yield return new bcdeter(39, 16, 20, 2);
                yield return new bcdeter(40, 16, 24, 2);
                yield return new bcdeter(41, 16, 24, 2);
                yield return new bcdeter(42, 16, 60, 2);
                yield return new bcdeter(43, 17, 23, 2);
                yield return new bcdeter(44, 17, 26, 2);
                yield return new bcdeter(45, 17, 27, 2);
                yield return new bcdeter(46, 18, 24, 2);
                yield return new bcdeter(47, 18, 25, 2);
                yield return new bcdeter(48, 19, 32, 2);
                yield return new bcdeter(49, 22, 32, 2);
                yield return new bcdeter(50, 24, 30, 2);
                yield return new bcdeter(51, 24, 31, 2);
                yield return new bcdeter(52, 30, 34, 2);
                yield return new bcdeter(53, 30, 36, 2);
                yield return new bcdeter(54, 33, 40, 2);
                yield return new bcdeter(55, 34, 34, 2);
                yield return new bcdeter(56, 35, 39, 2);
                yield return new bcdeter(57, 44, 48, 2);
                yield return new bcdeter(58, 48, 48, 2);
                yield return new bcdeter(59, 15, null, 1);
                yield return new bcdeter(60, 17, null, 1);
                yield return new bcdeter(61, 18, null, 1);
                yield return new bcdeter(62, 22, null, 1);
                yield return new bcdeter(63, 24, null, 1);
                yield return new bcdeter(64, 24, null, 1);
                yield return new bcdeter(65, 32, null, 1);
                yield return new bcdeter(66, 33, null, 1);
                yield return new bcdeter(67, 34, null, 1);
                yield return new bcdeter(68, 36, null, 1);
                yield return new bcdeter(69, 36, null, 1);
                yield return new bcdeter(70, 37, null, 1);
                yield return new bcdeter(71, 37, null, 1);
                yield return new bcdeter(72, 37, null, 1);
                yield return new bcdeter(73, 38, null, 1);
                yield return new bcdeter(74, 40, null, 1);
                yield return new bcdeter(75, 45, null, 1);
                yield return new bcdeter(76, 46, null, 1);
                yield return new bcdeter(77, 46, null, 1);
                yield return new bcdeter(78, 46, null, 1);
                yield return new bcdeter(79, 46, null, 1);
                yield return new bcdeter(80, 46, null, 1);
                yield return new bcdeter(81, 46, null, 1);
                yield return new bcdeter(82, 46, null, 1);
                yield return new bcdeter(83, 46, null, 1);
                yield return new bcdeter(84, 11, null, 2);
                yield return new bcdeter(85, 11, null, 2);
                yield return new bcdeter(86, 13, null, 2);
                yield return new bcdeter(87, 13, null, 2);
                yield return new bcdeter(88, 13, null, 2);
                yield return new bcdeter(89, 21, null, 2);
                yield return new bcdeter(90, 23, null, 2);
                yield return new bcdeter(91, 31, null, 2);
                yield return new bcdeter(92, 32, null, 2);
                yield return new bcdeter(93, 34, null, 2);
                yield return new bcdeter(94, 34, null, 2);
                yield return new bcdeter(95, 35, null, 2);
            }
        }
    }
}
