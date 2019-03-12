// ReSharper disable All

namespace Rdatasets.quantreg
{
    using System.Collections.Generic;

    /// <summary>
    /// Garland(1983) Data on Running Speed of Mammals
    /// </summary>

    public class Mammals
    {
        public readonly int κ;
        public readonly double weight;
        public readonly double speed;
        public readonly bool hoppers;
        public readonly bool specials;

        public Mammals(int κ, double weight, double speed, bool hoppers, bool specials)
        {
            this.κ = κ;
            this.weight = weight;
            this.speed = speed;
            this.hoppers = hoppers;
            this.specials = specials;
        }

        public static IEnumerable<Mammals> Data
        {
            get
            {
                yield return new Mammals(1, 6000, 35, false, false);
                yield return new Mammals(2, 4000, 26, false, false);
                yield return new Mammals(3, 3000, 25, false, false);
                yield return new Mammals(4, 1400, 45, false, false);
                yield return new Mammals(5, 400, 70, false, false);
                yield return new Mammals(6, 350, 70, false, false);
                yield return new Mammals(7, 300, 64, false, false);
                yield return new Mammals(8, 260, 70, false, false);
                yield return new Mammals(9, 250, 40, false, false);
                yield return new Mammals(10, 3800, 25, false, true);
                yield return new Mammals(11, 1000, 60, false, false);
                yield return new Mammals(12, 900, 70, false, false);
                yield return new Mammals(13, 900, 56, false, false);
                yield return new Mammals(14, 800, 29, false, false);
                yield return new Mammals(15, 750, 57, false, false);
                yield return new Mammals(16, 500, 32, false, false);
                yield return new Mammals(17, 450, 56, false, false);
                yield return new Mammals(18, 300, 72, false, false);
                yield return new Mammals(19, 300, 90, false, false);
                yield return new Mammals(20, 250, 80, false, false);
                yield return new Mammals(21, 250, 56, false, false);
                yield return new Mammals(22, 170, 80, false, false);
                yield return new Mammals(23, 150, 48, false, false);
                yield return new Mammals(24, 130, 70, false, false);
                yield return new Mammals(25, 120, 80, false, false);
                yield return new Mammals(26, 120, 61, false, false);
                yield return new Mammals(27, 110, 33, false, false);
                yield return new Mammals(28, 100, 64, false, false);
                yield return new Mammals(29, 85, 55, false, false);
                yield return new Mammals(30, 80, 65, false, false);
                yield return new Mammals(31, 72, 56, false, false);
                yield return new Mammals(32, 70, 45, false, false);
                yield return new Mammals(33, 65, 60, false, false);
                yield return new Mammals(34, 62, 81, false, false);
                yield return new Mammals(35, 50, 100, false, false);
                yield return new Mammals(36, 50, 60, false, false);
                yield return new Mammals(37, 50, 40, false, false);
                yield return new Mammals(38, 50, 47, false, false);
                yield return new Mammals(39, 37, 105, false, false);
                yield return new Mammals(40, 35, 80, false, false);
                yield return new Mammals(41, 34, 97, false, false);
                yield return new Mammals(42, 30, 97, false, false);
                yield return new Mammals(43, 30, 80, false, false);
                yield return new Mammals(44, 30, 45, false, false);
                yield return new Mammals(45, 20, 81, false, false);
                yield return new Mammals(46, 400, 40, false, false);
                yield return new Mammals(47, 300, 48, false, false);
                yield return new Mammals(48, 230, 56, false, false);
                yield return new Mammals(49, 150, 59, false, false);
                yield return new Mammals(50, 135, 48, false, false);
                yield return new Mammals(51, 65, 65, false, false);
                yield return new Mammals(52, 60, 60, false, false);
                yield return new Mammals(53, 55, 110, false, false);
                yield return new Mammals(54, 45, 50, false, false);
                yield return new Mammals(55, 40, 64, false, false);
                yield return new Mammals(56, 25, 67, false, false);
                yield return new Mammals(57, 20, 70, false, false);
                yield return new Mammals(58, 16, 65, false, false);
                yield return new Mammals(59, 12, 24, false, true);
                yield return new Mammals(60, 11, 30, false, true);
                yield return new Mammals(61, 10, 56, false, false);
                yield return new Mammals(62, 7, 60, false, false);
                yield return new Mammals(63, 6, 72, false, false);
                yield return new Mammals(64, 5, 64, false, false);
                yield return new Mammals(65, 5, 27, false, true);
                yield return new Mammals(66, 3, 16, false, true);
                yield return new Mammals(67, 127, 32, false, false);
                yield return new Mammals(68, 70, 40, false, true);
                yield return new Mammals(69, 13, 37, false, true);
                yield return new Mammals(70, 9, 3.2, false, true);
                yield return new Mammals(71, 4, 16, false, false);
                yield return new Mammals(72, 0.6, 36, false, false);
                yield return new Mammals(73, 0.6, 20, false, false);
                yield return new Mammals(74, 0.55, 27, false, false);
                yield return new Mammals(75, 0.5, 18, false, false);
                yield return new Mammals(76, 0.4, 20, false, false);
                yield return new Mammals(77, 0.3, 13, false, false);
                yield return new Mammals(78, 0.25, 9.7, false, false);
                yield return new Mammals(79, 0.22, 15, false, false);
                yield return new Mammals(80, 0.11, 9, false, false);
                yield return new Mammals(81, 0.1, 17, false, false);
                yield return new Mammals(82, 0.056, 21, true, false);
                yield return new Mammals(83, 0.05, 11, false, false);
                yield return new Mammals(84, 0.045, 16, false, false);
                yield return new Mammals(85, 0.035, 32, true, false);
                yield return new Mammals(86, 0.035, 14, true, false);
                yield return new Mammals(87, 0.03, 6.8, false, false);
                yield return new Mammals(88, 0.03, 9.1, false, false);
                yield return new Mammals(89, 0.025, 11, false, false);
                yield return new Mammals(90, 0.025, 8.6, false, false);
                yield return new Mammals(91, 0.018, 8.9, false, false);
                yield return new Mammals(92, 0.016, 13, false, false);
                yield return new Mammals(93, 0.1, 4, false, false);
                yield return new Mammals(94, 0.1, 2.4, false, false);
                yield return new Mammals(95, 0.016, 3.6, false, false);
                yield return new Mammals(96, 4.6, 64, true, false);
                yield return new Mammals(97, 4.4, 72, true, false);
                yield return new Mammals(98, 4, 72, true, false);
                yield return new Mammals(99, 3.5, 56, true, false);
                yield return new Mammals(100, 2, 64, true, false);
                yield return new Mammals(101, 1.9, 56, true, false);
                yield return new Mammals(102, 1.5, 50, true, false);
                yield return new Mammals(103, 1.5, 40, true, false);
                yield return new Mammals(104, 50, 65, false, false);
                yield return new Mammals(105, 5, 7.4, false, true);
                yield return new Mammals(106, 0.024, 13, false, false);
                yield return new Mammals(107, 4, 1.6, false, true);
            }
        }
    }
}
