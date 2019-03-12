// ReSharper disable All

namespace Rdatasets.drc
{
    using System.Collections.Generic;

    /// <summary>
    /// Effect of technical grade and commercially formulated auxin herbicides
    /// </summary>

    public class auxins
    {
        public readonly int κ;
        public readonly int r;
        public readonly int h;
        public readonly int w;
        public readonly double y;
        public readonly double dose;

        public auxins(int κ, int r, int h, int w, double y, double dose)
        {
            this.κ = κ;
            this.r = r;
            this.h = h;
            this.w = w;
            this.y = y;
            this.dose = dose;
        }

        public static IEnumerable<auxins> Data
        {
            get
            {
                yield return new auxins(1, 1, 0, 0, 1.51, 0);
                yield return new auxins(2, 1, 0, 0, 1.43, 0);
                yield return new auxins(3, 1, 1, 1, 0.05, 1);
                yield return new auxins(4, 1, 1, 2, 0.06, 0.5);
                yield return new auxins(5, 1, 1, 4, 0.15, 0.25);
                yield return new auxins(6, 1, 1, 8, 0.4, 0.125);
                yield return new auxins(7, 1, 1, 16, 0.76, 0.0625);
                yield return new auxins(8, 1, 1, 32, 0.95, 0.03125);
                yield return new auxins(9, 1, 2, 1, 0.04, 1);
                yield return new auxins(10, 1, 2, 2, 0.07, 0.5);
                yield return new auxins(11, 1, 2, 4, 0.13, 0.25);
                yield return new auxins(12, 1, 2, 8, 0.52, 0.125);
                yield return new auxins(13, 1, 2, 16, 0.79, 0.0625);
                yield return new auxins(14, 1, 2, 32, 1.17, 0.03125);
                yield return new auxins(15, 1, 3, 1, 0.05, 1);
                yield return new auxins(16, 1, 3, 2, 0.26, 0.5);
                yield return new auxins(17, 1, 3, 4, 0.28, 0.25);
                yield return new auxins(18, 1, 3, 8, 0.7, 0.125);
                yield return new auxins(19, 1, 3, 16, 1.05, 0.0625);
                yield return new auxins(20, 1, 3, 32, 1.3, 0.03125);
                yield return new auxins(21, 1, 4, 1, 0.11, 1);
                yield return new auxins(22, 1, 4, 2, 0.42, 0.5);
                yield return new auxins(23, 1, 4, 4, 0.59, 0.25);
                yield return new auxins(24, 1, 4, 8, 0.9, 0.125);
                yield return new auxins(25, 1, 4, 16, 1.08, 0.0625);
                yield return new auxins(26, 1, 4, 32, 1.24, 0.03125);
                yield return new auxins(27, 1, 5, 1, 0.04, 1);
                yield return new auxins(28, 1, 5, 2, 0.06, 0.5);
                yield return new auxins(29, 1, 5, 4, 0.19, 0.25);
                yield return new auxins(30, 1, 5, 8, 0.5, 0.125);
                yield return new auxins(31, 1, 5, 16, 0.84, 0.0625);
                yield return new auxins(32, 1, 5, 32, 1.17, 0.03125);
                yield return new auxins(33, 1, 6, 1, 0.04, 1);
                yield return new auxins(34, 1, 6, 2, 0.04, 0.5);
                yield return new auxins(35, 1, 6, 4, 0.24, 0.25);
                yield return new auxins(36, 1, 6, 8, 0.7, 0.125);
                yield return new auxins(37, 1, 6, 16, 1.21, 0.0625);
                yield return new auxins(38, 1, 6, 32, 1.01, 0.03125);
                yield return new auxins(39, 1, 7, 1, 0.05, 1);
                yield return new auxins(40, 1, 7, 2, 0.08, 0.5);
                yield return new auxins(41, 1, 7, 4, 0.14, 0.25);
                yield return new auxins(42, 1, 7, 8, 0.6, 0.125);
                yield return new auxins(43, 1, 7, 16, 1.2, 0.0625);
                yield return new auxins(44, 1, 7, 32, 1.3, 0.03125);
                yield return new auxins(45, 1, 8, 1, 0.38, 1);
                yield return new auxins(46, 1, 8, 2, 0.64, 0.5);
                yield return new auxins(47, 1, 8, 4, 0.88, 0.25);
                yield return new auxins(48, 1, 8, 8, 1.09, 0.125);
                yield return new auxins(49, 1, 8, 16, 1.5, 0.0625);
                yield return new auxins(50, 1, 8, 32, 1.3, 0.03125);
                yield return new auxins(51, 2, 0, 0, 1.01, 0);
                yield return new auxins(52, 2, 0, 0, 1.34, 0);
                yield return new auxins(53, 2, 1, 1, 0.05, 1);
                yield return new auxins(54, 2, 1, 2, 0.07, 0.5);
                yield return new auxins(55, 2, 1, 4, 0.09, 0.25);
                yield return new auxins(56, 2, 1, 8, 0.26, 0.125);
                yield return new auxins(57, 2, 1, 16, 0.55, 0.0625);
                yield return new auxins(58, 2, 1, 32, 1.21, 0.03125);
                yield return new auxins(59, 2, 2, 1, 0.04, 1);
                yield return new auxins(60, 2, 2, 2, 0.06, 0.5);
                yield return new auxins(61, 2, 2, 4, 0.19, 0.25);
                yield return new auxins(62, 2, 2, 8, 1.16, 0.125);
                yield return new auxins(63, 2, 2, 16, 0.96, 0.0625);
                yield return new auxins(64, 2, 2, 32, 1.13, 0.03125);
                yield return new auxins(65, 2, 3, 1, 0.04, 1);
                yield return new auxins(66, 2, 3, 2, 0.17, 0.5);
                yield return new auxins(67, 2, 3, 4, 0.33, 0.25);
                yield return new auxins(68, 2, 3, 8, 0.5, 0.125);
                yield return new auxins(69, 2, 3, 16, 1.11, 0.0625);
                yield return new auxins(70, 2, 3, 32, 1.2, 0.03125);
                yield return new auxins(71, 2, 4, 1, 0.12, 1);
                yield return new auxins(72, 2, 4, 2, 0.3, 0.5);
                yield return new auxins(73, 2, 4, 4, 0.41, 0.25);
                yield return new auxins(74, 2, 4, 8, 1.06, 0.125);
                yield return new auxins(75, 2, 4, 16, 1.29, 0.0625);
                yield return new auxins(76, 2, 4, 32, 1.17, 0.03125);
                yield return new auxins(77, 2, 5, 1, 0.04, 1);
                yield return new auxins(78, 2, 5, 2, 0.07, 0.5);
                yield return new auxins(79, 2, 5, 4, 0.19, 0.25);
                yield return new auxins(80, 2, 5, 8, 0.36, 0.125);
                yield return new auxins(81, 2, 5, 16, 0.88, 0.0625);
                yield return new auxins(82, 2, 5, 32, 1.16, 0.03125);
                yield return new auxins(83, 2, 6, 1, 0.04, 1);
                yield return new auxins(84, 2, 6, 2, 0.05, 0.5);
                yield return new auxins(85, 2, 6, 4, 0.22, 0.25);
                yield return new auxins(86, 2, 6, 8, 0.61, 0.125);
                yield return new auxins(87, 2, 6, 16, 1.15, 0.0625);
                yield return new auxins(88, 2, 6, 32, 1.39, 0.03125);
                yield return new auxins(89, 2, 7, 1, 0.04, 1);
                yield return new auxins(90, 2, 7, 2, 0.18, 0.5);
                yield return new auxins(91, 2, 7, 4, 0.27, 0.25);
                yield return new auxins(92, 2, 7, 8, 0.88, 0.125);
                yield return new auxins(93, 2, 7, 16, 0.97, 0.0625);
                yield return new auxins(94, 2, 7, 32, 1.26, 0.03125);
                yield return new auxins(95, 2, 8, 1, 0.29, 1);
                yield return new auxins(96, 2, 8, 2, 0.98, 0.5);
                yield return new auxins(97, 2, 8, 4, 1.12, 0.25);
                yield return new auxins(98, 2, 8, 8, 1.1, 0.125);
                yield return new auxins(99, 2, 8, 16, 1.13, 0.0625);
                yield return new auxins(100, 2, 8, 32, 1.31, 0.03125);
                yield return new auxins(101, 3, 0, 0, 1.21, 0);
                yield return new auxins(102, 3, 0, 0, 1.1, 0);
                yield return new auxins(103, 3, 1, 1, 0.04, 1);
                yield return new auxins(104, 3, 1, 2, 0.09, 0.5);
                yield return new auxins(105, 3, 1, 4, 0.12, 0.25);
                yield return new auxins(106, 3, 1, 8, 0.25, 0.125);
                yield return new auxins(107, 3, 1, 16, 0.56, 0.0625);
                yield return new auxins(108, 3, 1, 32, 1.04, 0.03125);
                yield return new auxins(109, 3, 2, 1, 0.05, 1);
                yield return new auxins(110, 3, 2, 2, 0.06, 0.5);
                yield return new auxins(111, 3, 2, 4, 0.14, 0.25);
                yield return new auxins(112, 3, 2, 8, 0.35, 0.125);
                yield return new auxins(113, 3, 2, 16, 0.9, 0.0625);
                yield return new auxins(114, 3, 2, 32, 1.12, 0.03125);
                yield return new auxins(115, 3, 3, 1, 0.06, 1);
                yield return new auxins(116, 3, 3, 2, 0.21, 0.5);
                yield return new auxins(117, 3, 3, 4, 0.37, 0.25);
                yield return new auxins(118, 3, 3, 8, 0.6, 0.125);
                yield return new auxins(119, 3, 3, 16, 1.01, 0.0625);
                yield return new auxins(120, 3, 3, 32, 0.7, 0.03125);
                yield return new auxins(121, 3, 4, 1, 0.1, 1);
                yield return new auxins(122, 3, 4, 2, 0.2, 0.5);
                yield return new auxins(123, 3, 4, 4, 0.47, 0.25);
                yield return new auxins(124, 3, 4, 8, 0.95, 0.125);
                yield return new auxins(125, 3, 4, 16, 1.07, 0.0625);
                yield return new auxins(126, 3, 4, 32, 0.93, 0.03125);
                yield return new auxins(127, 3, 5, 1, 0.05, 1);
                yield return new auxins(128, 3, 5, 2, 0.07, 0.5);
                yield return new auxins(129, 3, 5, 4, 0.09, 0.25);
                yield return new auxins(130, 3, 5, 8, 0.29, 0.125);
                yield return new auxins(131, 3, 5, 16, 0.78, 0.0625);
                yield return new auxins(132, 3, 5, 32, 1.05, 0.03125);
                yield return new auxins(133, 3, 6, 1, 0.05, 1);
                yield return new auxins(134, 3, 6, 2, 0.07, 0.5);
                yield return new auxins(135, 3, 6, 4, 0.16, 0.25);
                yield return new auxins(136, 3, 6, 8, 0.39, 0.125);
                yield return new auxins(137, 3, 6, 16, 0.78, 0.0625);
                yield return new auxins(138, 3, 6, 32, 0.97, 0.03125);
                yield return new auxins(139, 3, 7, 1, 0.04, 1);
                yield return new auxins(140, 3, 7, 2, 0.11, 0.5);
                yield return new auxins(141, 3, 7, 4, 0.24, 0.25);
                yield return new auxins(142, 3, 7, 8, 0.48, 0.125);
                yield return new auxins(143, 3, 7, 16, 0.94, 0.0625);
                yield return new auxins(144, 3, 7, 32, 1.3, 0.03125);
                yield return new auxins(145, 3, 8, 1, 0.15, 1);
                yield return new auxins(146, 3, 8, 2, 0.26, 0.5);
                yield return new auxins(147, 3, 8, 4, 0.6, 0.25);
                yield return new auxins(148, 3, 8, 8, 0.87, 0.125);
                yield return new auxins(149, 3, 8, 16, 0.61, 0.0625);
                yield return new auxins(150, 3, 8, 32, 0.98, 0.03125);
            }
        }
    }
}
