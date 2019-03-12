// ReSharper disable All

namespace Rdatasets.boot
{
    using System.Collections.Generic;

    /// <summary>
    /// Acceleration Due to Gravity
    /// </summary>

    public class gravity
    {
        public readonly int κ;
        public readonly int g;
        public readonly int series;

        public gravity(int κ, int g, int series)
        {
            this.κ = κ;
            this.g = g;
            this.series = series;
        }

        public static IEnumerable<gravity> Data
        {
            get
            {
                yield return new gravity(1, 76, 1);
                yield return new gravity(2, 82, 1);
                yield return new gravity(3, 83, 1);
                yield return new gravity(4, 54, 1);
                yield return new gravity(5, 35, 1);
                yield return new gravity(6, 46, 1);
                yield return new gravity(7, 87, 1);
                yield return new gravity(8, 68, 1);
                yield return new gravity(9, 87, 2);
                yield return new gravity(10, 95, 2);
                yield return new gravity(11, 98, 2);
                yield return new gravity(12, 100, 2);
                yield return new gravity(13, 109, 2);
                yield return new gravity(14, 109, 2);
                yield return new gravity(15, 100, 2);
                yield return new gravity(16, 81, 2);
                yield return new gravity(17, 75, 2);
                yield return new gravity(18, 68, 2);
                yield return new gravity(19, 67, 2);
                yield return new gravity(20, 105, 3);
                yield return new gravity(21, 83, 3);
                yield return new gravity(22, 76, 3);
                yield return new gravity(23, 75, 3);
                yield return new gravity(24, 51, 3);
                yield return new gravity(25, 76, 3);
                yield return new gravity(26, 93, 3);
                yield return new gravity(27, 75, 3);
                yield return new gravity(28, 62, 3);
                yield return new gravity(29, 95, 4);
                yield return new gravity(30, 90, 4);
                yield return new gravity(31, 76, 4);
                yield return new gravity(32, 76, 4);
                yield return new gravity(33, 87, 4);
                yield return new gravity(34, 79, 4);
                yield return new gravity(35, 77, 4);
                yield return new gravity(36, 71, 4);
                yield return new gravity(37, 76, 5);
                yield return new gravity(38, 76, 5);
                yield return new gravity(39, 78, 5);
                yield return new gravity(40, 79, 5);
                yield return new gravity(41, 72, 5);
                yield return new gravity(42, 68, 5);
                yield return new gravity(43, 75, 5);
                yield return new gravity(44, 78, 5);
                yield return new gravity(45, 78, 6);
                yield return new gravity(46, 78, 6);
                yield return new gravity(47, 78, 6);
                yield return new gravity(48, 86, 6);
                yield return new gravity(49, 87, 6);
                yield return new gravity(50, 81, 6);
                yield return new gravity(51, 73, 6);
                yield return new gravity(52, 67, 6);
                yield return new gravity(53, 75, 6);
                yield return new gravity(54, 82, 6);
                yield return new gravity(55, 83, 6);
                yield return new gravity(56, 82, 7);
                yield return new gravity(57, 79, 7);
                yield return new gravity(58, 81, 7);
                yield return new gravity(59, 79, 7);
                yield return new gravity(60, 77, 7);
                yield return new gravity(61, 79, 7);
                yield return new gravity(62, 79, 7);
                yield return new gravity(63, 78, 7);
                yield return new gravity(64, 79, 7);
                yield return new gravity(65, 82, 7);
                yield return new gravity(66, 76, 7);
                yield return new gravity(67, 73, 7);
                yield return new gravity(68, 64, 7);
                yield return new gravity(69, 84, 8);
                yield return new gravity(70, 86, 8);
                yield return new gravity(71, 85, 8);
                yield return new gravity(72, 82, 8);
                yield return new gravity(73, 77, 8);
                yield return new gravity(74, 76, 8);
                yield return new gravity(75, 77, 8);
                yield return new gravity(76, 80, 8);
                yield return new gravity(77, 83, 8);
                yield return new gravity(78, 81, 8);
                yield return new gravity(79, 78, 8);
                yield return new gravity(80, 78, 8);
                yield return new gravity(81, 78, 8);
            }
        }
    }
}
