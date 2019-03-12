// ReSharper disable All

namespace Rdatasets.datasets
{
    using System.Collections.Generic;

    /// <summary>
    /// Effectiveness of Insect Sprays
    /// </summary>

    public class InsectSprays
    {
        public readonly int κ;
        public readonly int count;
        public readonly string spray;

        public InsectSprays(int κ, int count, string spray)
        {
            this.κ = κ;
            this.count = count;
            this.spray = spray;
        }

        public static IEnumerable<InsectSprays> Data
        {
            get
            {
                yield return new InsectSprays(1, 10, "A");
                yield return new InsectSprays(2, 7, "A");
                yield return new InsectSprays(3, 20, "A");
                yield return new InsectSprays(4, 14, "A");
                yield return new InsectSprays(5, 14, "A");
                yield return new InsectSprays(6, 12, "A");
                yield return new InsectSprays(7, 10, "A");
                yield return new InsectSprays(8, 23, "A");
                yield return new InsectSprays(9, 17, "A");
                yield return new InsectSprays(10, 20, "A");
                yield return new InsectSprays(11, 14, "A");
                yield return new InsectSprays(12, 13, "A");
                yield return new InsectSprays(13, 11, "B");
                yield return new InsectSprays(14, 17, "B");
                yield return new InsectSprays(15, 21, "B");
                yield return new InsectSprays(16, 11, "B");
                yield return new InsectSprays(17, 16, "B");
                yield return new InsectSprays(18, 14, "B");
                yield return new InsectSprays(19, 17, "B");
                yield return new InsectSprays(20, 17, "B");
                yield return new InsectSprays(21, 19, "B");
                yield return new InsectSprays(22, 21, "B");
                yield return new InsectSprays(23, 7, "B");
                yield return new InsectSprays(24, 13, "B");
                yield return new InsectSprays(25, 0, "C");
                yield return new InsectSprays(26, 1, "C");
                yield return new InsectSprays(27, 7, "C");
                yield return new InsectSprays(28, 2, "C");
                yield return new InsectSprays(29, 3, "C");
                yield return new InsectSprays(30, 1, "C");
                yield return new InsectSprays(31, 2, "C");
                yield return new InsectSprays(32, 1, "C");
                yield return new InsectSprays(33, 3, "C");
                yield return new InsectSprays(34, 0, "C");
                yield return new InsectSprays(35, 1, "C");
                yield return new InsectSprays(36, 4, "C");
                yield return new InsectSprays(37, 3, "D");
                yield return new InsectSprays(38, 5, "D");
                yield return new InsectSprays(39, 12, "D");
                yield return new InsectSprays(40, 6, "D");
                yield return new InsectSprays(41, 4, "D");
                yield return new InsectSprays(42, 3, "D");
                yield return new InsectSprays(43, 5, "D");
                yield return new InsectSprays(44, 5, "D");
                yield return new InsectSprays(45, 5, "D");
                yield return new InsectSprays(46, 5, "D");
                yield return new InsectSprays(47, 2, "D");
                yield return new InsectSprays(48, 4, "D");
                yield return new InsectSprays(49, 3, "E");
                yield return new InsectSprays(50, 5, "E");
                yield return new InsectSprays(51, 3, "E");
                yield return new InsectSprays(52, 5, "E");
                yield return new InsectSprays(53, 3, "E");
                yield return new InsectSprays(54, 6, "E");
                yield return new InsectSprays(55, 1, "E");
                yield return new InsectSprays(56, 1, "E");
                yield return new InsectSprays(57, 3, "E");
                yield return new InsectSprays(58, 2, "E");
                yield return new InsectSprays(59, 6, "E");
                yield return new InsectSprays(60, 4, "E");
                yield return new InsectSprays(61, 11, "F");
                yield return new InsectSprays(62, 9, "F");
                yield return new InsectSprays(63, 15, "F");
                yield return new InsectSprays(64, 22, "F");
                yield return new InsectSprays(65, 15, "F");
                yield return new InsectSprays(66, 16, "F");
                yield return new InsectSprays(67, 13, "F");
                yield return new InsectSprays(68, 10, "F");
                yield return new InsectSprays(69, 26, "F");
                yield return new InsectSprays(70, 26, "F");
                yield return new InsectSprays(71, 24, "F");
                yield return new InsectSprays(72, 13, "F");
            }
        }
    }
}
