// ReSharper disable All

namespace Rdatasets.DAAG
{
    using System.Collections.Generic;

    /// <summary>
    /// Dewpoint Data
    /// </summary>

    public class dewpoint
    {
        public readonly int κ;
        public readonly int maxtemp;
        public readonly int mintemp;
        public readonly int dewpt;

        public dewpoint(int κ, int maxtemp, int mintemp, int dewpt)
        {
            this.κ = κ;
            this.maxtemp = maxtemp;
            this.mintemp = mintemp;
            this.dewpt = dewpt;
        }

        public static IEnumerable<dewpoint> Data
        {
            get
            {
                yield return new dewpoint(1, 18, 8, 7);
                yield return new dewpoint(2, 18, 10, 10);
                yield return new dewpoint(3, 20, 6, 5);
                yield return new dewpoint(4, 20, 8, 7);
                yield return new dewpoint(5, 20, 10, 9);
                yield return new dewpoint(6, 20, 12, 12);
                yield return new dewpoint(7, 22, 8, 6);
                yield return new dewpoint(8, 22, 10, 9);
                yield return new dewpoint(9, 22, 12, 11);
                yield return new dewpoint(10, 22, 14, 14);
                yield return new dewpoint(11, 22, 16, 16);
                yield return new dewpoint(12, 24, 8, 5);
                yield return new dewpoint(13, 24, 10, 8);
                yield return new dewpoint(14, 24, 12, 10);
                yield return new dewpoint(15, 24, 14, 13);
                yield return new dewpoint(16, 24, 16, 15);
                yield return new dewpoint(17, 24, 18, 18);
                yield return new dewpoint(18, 26, 10, 7);
                yield return new dewpoint(19, 26, 12, 9);
                yield return new dewpoint(20, 26, 14, 12);
                yield return new dewpoint(21, 26, 16, 14);
                yield return new dewpoint(22, 26, 18, 17);
                yield return new dewpoint(23, 26, 20, 20);
                yield return new dewpoint(24, 28, 10, 5);
                yield return new dewpoint(25, 28, 12, 8);
                yield return new dewpoint(26, 28, 14, 11);
                yield return new dewpoint(27, 28, 16, 13);
                yield return new dewpoint(28, 28, 18, 16);
                yield return new dewpoint(29, 28, 20, 19);
                yield return new dewpoint(30, 28, 22, 22);
                yield return new dewpoint(31, 28, 24, 24);
                yield return new dewpoint(32, 30, 12, 7);
                yield return new dewpoint(33, 30, 14, 9);
                yield return new dewpoint(34, 30, 16, 12);
                yield return new dewpoint(35, 30, 18, 14);
                yield return new dewpoint(36, 30, 20, 18);
                yield return new dewpoint(37, 30, 22, 20);
                yield return new dewpoint(38, 30, 24, 23);
                yield return new dewpoint(39, 30, 26, 26);
                yield return new dewpoint(40, 32, 12, 5);
                yield return new dewpoint(41, 32, 14, 8);
                yield return new dewpoint(42, 32, 16, 11);
                yield return new dewpoint(43, 32, 18, 13);
                yield return new dewpoint(44, 32, 20, 16);
                yield return new dewpoint(45, 32, 22, 19);
                yield return new dewpoint(46, 32, 24, 22);
                yield return new dewpoint(47, 32, 26, 25);
                yield return new dewpoint(48, 34, 14, 6);
                yield return new dewpoint(49, 34, 16, 9);
                yield return new dewpoint(50, 34, 18, 12);
                yield return new dewpoint(51, 34, 20, 15);
                yield return new dewpoint(52, 34, 22, 18);
                yield return new dewpoint(53, 34, 24, 21);
                yield return new dewpoint(54, 34, 26, 25);
                yield return new dewpoint(55, 36, 14, 5);
                yield return new dewpoint(56, 36, 16, 7);
                yield return new dewpoint(57, 36, 18, 10);
                yield return new dewpoint(58, 36, 20, 13);
                yield return new dewpoint(59, 36, 22, 16);
                yield return new dewpoint(60, 36, 24, 19);
                yield return new dewpoint(61, 36, 26, 22);
                yield return new dewpoint(62, 38, 16, 5);
                yield return new dewpoint(63, 38, 18, 7);
                yield return new dewpoint(64, 38, 20, 10);
                yield return new dewpoint(65, 38, 22, 13);
                yield return new dewpoint(66, 38, 24, 17);
                yield return new dewpoint(67, 38, 26, 20);
                yield return new dewpoint(68, 40, 18, 5);
                yield return new dewpoint(69, 40, 20, 8);
                yield return new dewpoint(70, 40, 22, 11);
                yield return new dewpoint(71, 40, 24, 14);
                yield return new dewpoint(72, 40, 26, 17);
            }
        }
    }
}
