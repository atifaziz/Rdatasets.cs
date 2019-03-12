// ReSharper disable All

namespace Rdatasets.DAAG
{
    using System.Collections.Generic;

    /// <summary>
    /// Frosted Flakes data
    /// </summary>

    public class frostedflakes
    {
        public readonly int κ;
        public readonly double Lab;
        public readonly double IA400;

        public frostedflakes(int κ, double Lab, double IA400)
        {
            this.κ = κ;
            this.Lab = Lab;
            this.IA400 = IA400;
        }

        public static IEnumerable<frostedflakes> Data
        {
            get
            {
                yield return new frostedflakes(1, 36.3, 35.1);
                yield return new frostedflakes(2, 33.2, 35.9);
                yield return new frostedflakes(3, 39, 40.1);
                yield return new frostedflakes(4, 37.3, 35.5);
                yield return new frostedflakes(5, 40.7, 37.9);
                yield return new frostedflakes(6, 38.4, 39.5);
                yield return new frostedflakes(7, 35.8, 38.5);
                yield return new frostedflakes(8, 36, 37.9);
                yield return new frostedflakes(9, 37.9, 41.2);
                yield return new frostedflakes(10, 42.6, 45.7);
                yield return new frostedflakes(11, 40, 38.3);
                yield return new frostedflakes(12, 43.5, 42.3);
                yield return new frostedflakes(13, 36.6, 39);
                yield return new frostedflakes(14, 33.7, 30.8);
                yield return new frostedflakes(15, 40.5, 37.3);
                yield return new frostedflakes(16, 38.7, 39.5);
                yield return new frostedflakes(17, 36.2, 40.3);
                yield return new frostedflakes(18, 41.6, 42);
                yield return new frostedflakes(19, 37.8, 36.9);
                yield return new frostedflakes(20, 40.5, 41.2);
                yield return new frostedflakes(21, 38.9, 39.3);
                yield return new frostedflakes(22, 36, 35.6);
                yield return new frostedflakes(23, 41.1, 40.9);
                yield return new frostedflakes(24, 40, 37.6);
                yield return new frostedflakes(25, 35.5, 35.5);
                yield return new frostedflakes(26, 34.3, 35.5);
                yield return new frostedflakes(27, 33, 32.4);
                yield return new frostedflakes(28, 36.9, 36.1);
                yield return new frostedflakes(29, 36.3, 36.1);
                yield return new frostedflakes(30, 38.5, 39);
                yield return new frostedflakes(31, 35.1, 38.5);
                yield return new frostedflakes(32, 38.7, 40);
                yield return new frostedflakes(33, 34, 35.4);
                yield return new frostedflakes(34, 42.3, 40.9);
                yield return new frostedflakes(35, 41.4, 39.4);
                yield return new frostedflakes(36, 38.2, 38.6);
                yield return new frostedflakes(37, 38.3, 39.6);
                yield return new frostedflakes(38, 37.4, 39.2);
                yield return new frostedflakes(39, 37.5, 36.4);
                yield return new frostedflakes(40, 36.5, 36.1);
                yield return new frostedflakes(41, 34.8, 38.1);
                yield return new frostedflakes(42, 38.1, 39.6);
                yield return new frostedflakes(43, 41, 40.8);
                yield return new frostedflakes(44, 35.4, 37.4);
                yield return new frostedflakes(45, 35, 37.6);
                yield return new frostedflakes(46, 37.9, 36);
                yield return new frostedflakes(47, 39.1, 37.2);
                yield return new frostedflakes(48, 33.3, 33);
                yield return new frostedflakes(49, 40.4, 41.9);
                yield return new frostedflakes(50, 34.9, 37.9);
                yield return new frostedflakes(51, 33.5, 38.1);
                yield return new frostedflakes(52, 35.8, 37.4);
                yield return new frostedflakes(53, 36.6, 40.1);
                yield return new frostedflakes(54, 38.3, 40.7);
                yield return new frostedflakes(55, 33.1, 35.4);
                yield return new frostedflakes(56, 37.4, 41.4);
                yield return new frostedflakes(57, 39.9, 40.2);
                yield return new frostedflakes(58, 38.4, 39.1);
                yield return new frostedflakes(59, 36.1, 34.7);
                yield return new frostedflakes(60, 33.6, 33.9);
                yield return new frostedflakes(61, 35.1, 36.7);
                yield return new frostedflakes(62, 37.4, 36.3);
                yield return new frostedflakes(63, 38.2, 38.8);
                yield return new frostedflakes(64, 39, 43);
                yield return new frostedflakes(65, 31.6, 33.9);
                yield return new frostedflakes(66, 36.1, 35.6);
                yield return new frostedflakes(67, 36.6, 34.8);
                yield return new frostedflakes(68, 36.4, 35.8);
                yield return new frostedflakes(69, 39.9, 41.4);
                yield return new frostedflakes(70, 38.8, 39.2);
                yield return new frostedflakes(71, 39.1, 36.9);
                yield return new frostedflakes(72, 34.7, 33.7);
                yield return new frostedflakes(73, 37.3, 36.1);
                yield return new frostedflakes(74, 39.1, 40.2);
                yield return new frostedflakes(75, 38.8, 39.9);
                yield return new frostedflakes(76, 38.7, 36.6);
                yield return new frostedflakes(77, 36.5, 35.8);
                yield return new frostedflakes(78, 37.3, 38.6);
                yield return new frostedflakes(79, 39.9, 37.5);
                yield return new frostedflakes(80, 34, 33.7);
                yield return new frostedflakes(81, 39.4, 39.9);
                yield return new frostedflakes(82, 36.4, 35.5);
                yield return new frostedflakes(83, 34.8, 34.9);
                yield return new frostedflakes(84, 41.1, 40.7);
                yield return new frostedflakes(85, 33.8, 31.3);
                yield return new frostedflakes(86, 41.4, 39.5);
                yield return new frostedflakes(87, 39.1, 37.9);
                yield return new frostedflakes(88, 38.3, 38.7);
                yield return new frostedflakes(89, 37.7, 36.1);
                yield return new frostedflakes(90, 38.4, 42.8);
                yield return new frostedflakes(91, 40.9, 42.7);
                yield return new frostedflakes(92, 36.5, 40.9);
                yield return new frostedflakes(93, 40.5, 40);
                yield return new frostedflakes(94, 39.7, 41.2);
                yield return new frostedflakes(95, 40.6, 41.5);
                yield return new frostedflakes(96, 38.9, 42);
                yield return new frostedflakes(97, 39.3, 42.6);
                yield return new frostedflakes(98, 37.1, 40.8);
                yield return new frostedflakes(99, 35.6, 40.2);
                yield return new frostedflakes(100, 36.8, 40.6);
            }
        }
    }
}
