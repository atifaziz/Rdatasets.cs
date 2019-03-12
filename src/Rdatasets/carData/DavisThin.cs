// ReSharper disable All

namespace Rdatasets.carData
{
    using System.Collections.Generic;

    /// <summary>
    /// Davis's Data on Drive for Thinness
    /// </summary>

    public class DavisThin
    {
        public readonly int κ;
        public readonly int DT1;
        public readonly int DT2;
        public readonly int DT3;
        public readonly int DT4;
        public readonly int DT5;
        public readonly int DT6;
        public readonly int DT7;

        public DavisThin(int κ, int DT1, int DT2, int DT3, int DT4, int DT5, int DT6, int DT7)
        {
            this.κ = κ;
            this.DT1 = DT1;
            this.DT2 = DT2;
            this.DT3 = DT3;
            this.DT4 = DT4;
            this.DT5 = DT5;
            this.DT6 = DT6;
            this.DT7 = DT7;
        }

        public static IEnumerable<DavisThin> Data
        {
            get
            {
                yield return new DavisThin(1, 0, 0, 0, 0, 0, 0, 0);
                yield return new DavisThin(2, 0, 0, 0, 0, 0, 0, 0);
                yield return new DavisThin(3, 0, 0, 0, 0, 0, 0, 0);
                yield return new DavisThin(4, 0, 0, 0, 0, 0, 0, 0);
                yield return new DavisThin(5, 0, 0, 0, 0, 0, 0, 0);
                yield return new DavisThin(6, 0, 1, 0, 0, 0, 0, 0);
                yield return new DavisThin(7, 0, 2, 2, 0, 2, 2, 0);
                yield return new DavisThin(8, 2, 3, 3, 2, 3, 3, 3);
                yield return new DavisThin(9, 0, 0, 0, 0, 3, 0, 0);
                yield return new DavisThin(10, 3, 3, 2, 1, 3, 3, 0);
                yield return new DavisThin(11, 1, 0, 3, 3, 3, 1, 3);
                yield return new DavisThin(12, 0, 1, 2, 0, 1, 0, 0);
                yield return new DavisThin(13, 0, 3, 1, 0, 0, 3, 0);
                yield return new DavisThin(14, 1, 3, 2, 2, 1, 3, 0);
                yield return new DavisThin(15, 0, 3, 3, 2, 3, 2, 2);
                yield return new DavisThin(16, 0, 0, 0, 0, 0, 0, 0);
                yield return new DavisThin(17, 0, 2, 3, 2, 3, 2, 0);
                yield return new DavisThin(18, 0, 0, 3, 0, 3, 1, 3);
                yield return new DavisThin(19, 3, 3, 3, 3, 3, 2, 0);
                yield return new DavisThin(20, 0, 0, 0, 0, 0, 0, 0);
                yield return new DavisThin(21, 2, 3, 3, 3, 2, 3, 2);
                yield return new DavisThin(22, 0, 0, 0, 0, 2, 1, 0);
                yield return new DavisThin(23, 0, 3, 0, 0, 3, 0, 0);
                yield return new DavisThin(24, 3, 0, 0, 0, 2, 0, 0);
                yield return new DavisThin(25, 0, 0, 0, 0, 0, 0, 0);
                yield return new DavisThin(26, 0, 0, 0, 0, 0, 0, 0);
                yield return new DavisThin(27, 3, 3, 3, 3, 3, 3, 3);
                yield return new DavisThin(28, 0, 0, 0, 0, 0, 0, 0);
                yield return new DavisThin(29, 0, 0, 0, 0, 0, 0, 0);
                yield return new DavisThin(30, 0, 0, 0, 0, 3, 0, 0);
                yield return new DavisThin(31, 0, 3, 3, 3, 3, 3, 3);
                yield return new DavisThin(32, 0, 0, 0, 0, 0, 0, 0);
                yield return new DavisThin(33, 1, 1, 2, 0, 2, 3, 3);
                yield return new DavisThin(34, 0, 0, 1, 0, 0, 0, 0);
                yield return new DavisThin(35, 0, 0, 0, 0, 0, 0, 0);
                yield return new DavisThin(36, 2, 3, 3, 0, 3, 3, 3);
                yield return new DavisThin(37, 0, 3, 3, 0, 3, 3, 3);
                yield return new DavisThin(38, 0, 0, 0, 0, 0, 0, 0);
                yield return new DavisThin(39, 0, 3, 1, 0, 2, 2, 0);
                yield return new DavisThin(40, 0, 0, 0, 0, 0, 0, 0);
                yield return new DavisThin(41, 0, 0, 1, 0, 0, 0, 0);
                yield return new DavisThin(42, 2, 3, 1, 2, 1, 3, 0);
                yield return new DavisThin(43, 0, 0, 0, 0, 0, 0, 0);
                yield return new DavisThin(44, 0, 3, 3, 0, 3, 3, 3);
                yield return new DavisThin(45, 0, 3, 2, 0, 3, 3, 1);
                yield return new DavisThin(46, 0, 3, 0, 0, 0, 0, 0);
                yield return new DavisThin(47, 2, 3, 3, 0, 3, 3, 1);
                yield return new DavisThin(48, 0, 3, 0, 0, 3, 0, 0);
                yield return new DavisThin(49, 0, 0, 0, 0, 2, 2, 0);
                yield return new DavisThin(50, 0, 0, 0, 0, 0, 0, 0);
                yield return new DavisThin(51, 0, 2, 1, 0, 2, 2, 0);
                yield return new DavisThin(52, 0, 0, 0, 0, 0, 0, 0);
                yield return new DavisThin(53, 0, 0, 0, 0, 0, 0, 0);
                yield return new DavisThin(54, 1, 2, 1, 0, 2, 0, 0);
                yield return new DavisThin(55, 0, 0, 0, 0, 0, 0, 0);
                yield return new DavisThin(56, 0, 3, 1, 1, 3, 0, 0);
                yield return new DavisThin(57, 0, 2, 0, 0, 0, 1, 0);
                yield return new DavisThin(58, 1, 3, 3, 0, 3, 3, 3);
                yield return new DavisThin(59, 0, 0, 0, 0, 0, 0, 0);
                yield return new DavisThin(60, 0, 0, 0, 0, 0, 0, 0);
                yield return new DavisThin(61, 0, 0, 2, 0, 3, 0, 0);
                yield return new DavisThin(62, 1, 0, 0, 0, 0, 0, 0);
                yield return new DavisThin(63, 0, 0, 0, 0, 0, 0, 0);
                yield return new DavisThin(64, 2, 3, 0, 0, 3, 2, 0);
                yield return new DavisThin(65, 1, 0, 0, 0, 0, 0, 0);
                yield return new DavisThin(66, 0, 0, 0, 0, 0, 0, 0);
                yield return new DavisThin(67, 1, 3, 2, 2, 2, 3, 1);
                yield return new DavisThin(68, 0, 0, 0, 0, 0, 0, 0);
                yield return new DavisThin(69, 0, 2, 1, 0, 2, 3, 0);
                yield return new DavisThin(70, 0, 0, 0, 0, 0, 0, 0);
                yield return new DavisThin(71, 0, 0, 0, 0, 0, 0, 0);
                yield return new DavisThin(72, 1, 3, 2, 2, 3, 2, 0);
                yield return new DavisThin(73, 2, 3, 3, 2, 3, 3, 2);
                yield return new DavisThin(74, 0, 0, 3, 0, 2, 1, 0);
                yield return new DavisThin(75, 0, 0, 0, 0, 0, 0, 0);
                yield return new DavisThin(76, 2, 3, 3, 0, 3, 3, 3);
                yield return new DavisThin(77, 0, 0, 0, 0, 0, 0, 0);
                yield return new DavisThin(78, 0, 0, 3, 0, 3, 3, 2);
                yield return new DavisThin(79, 2, 1, 0, 0, 3, 0, 0);
                yield return new DavisThin(80, 0, 0, 0, 0, 0, 0, 0);
                yield return new DavisThin(81, 0, 2, 1, 0, 0, 1, 3);
                yield return new DavisThin(82, 0, 0, 0, 0, 0, 0, 0);
                yield return new DavisThin(83, 0, 0, 0, 0, 0, 1, 1);
                yield return new DavisThin(84, 0, 0, 0, 0, 0, 0, 0);
                yield return new DavisThin(85, 0, 0, 0, 0, 3, 0, 0);
                yield return new DavisThin(86, 0, 0, 0, 0, 0, 0, 0);
                yield return new DavisThin(87, 0, 0, 0, 0, 2, 2, 2);
                yield return new DavisThin(88, 0, 0, 0, 0, 0, 0, 0);
                yield return new DavisThin(89, 0, 0, 0, 0, 0, 0, 0);
                yield return new DavisThin(90, 0, 2, 2, 0, 3, 3, 1);
                yield return new DavisThin(91, 0, 0, 0, 0, 0, 0, 0);
                yield return new DavisThin(92, 3, 0, 0, 0, 0, 0, 0);
                yield return new DavisThin(93, 3, 2, 3, 0, 2, 0, 0);
                yield return new DavisThin(94, 0, 0, 0, 0, 0, 0, 0);
                yield return new DavisThin(95, 0, 0, 1, 0, 0, 0, 0);
                yield return new DavisThin(96, 0, 0, 0, 0, 0, 0, 0);
                yield return new DavisThin(97, 0, 0, 0, 0, 0, 0, 0);
                yield return new DavisThin(98, 0, 0, 0, 0, 0, 0, 0);
                yield return new DavisThin(99, 0, 2, 2, 0, 2, 1, 0);
                yield return new DavisThin(100, 1, 2, 3, 0, 3, 3, 2);
                yield return new DavisThin(101, 0, 0, 0, 0, 0, 0, 0);
                yield return new DavisThin(102, 1, 3, 3, 3, 3, 3, 3);
                yield return new DavisThin(103, 2, 3, 3, 3, 3, 3, 3);
                yield return new DavisThin(104, 0, 3, 3, 0, 3, 3, 3);
                yield return new DavisThin(105, 0, 0, 1, 0, 0, 0, 0);
                yield return new DavisThin(106, 2, 3, 3, 2, 3, 3, 2);
                yield return new DavisThin(107, 0, 0, 0, 0, 0, 0, 0);
                yield return new DavisThin(108, 0, 0, 0, 0, 0, 0, 1);
                yield return new DavisThin(109, 1, 1, 0, 0, 0, 1, 1);
                yield return new DavisThin(110, 2, 2, 1, 0, 0, 1, 0);
                yield return new DavisThin(111, 0, 3, 3, 2, 3, 1, 2);
                yield return new DavisThin(112, 0, 0, 0, 0, 1, 0, 0);
                yield return new DavisThin(113, 0, 0, 0, 0, 0, 0, 0);
                yield return new DavisThin(114, 0, 3, 0, 1, 2, 2, 0);
                yield return new DavisThin(115, 0, 0, 0, 0, 0, 0, 0);
                yield return new DavisThin(116, 3, 3, 3, 2, 3, 3, 2);
                yield return new DavisThin(117, 1, 0, 0, 0, 0, 0, 0);
                yield return new DavisThin(118, 0, 0, 0, 0, 0, 0, 0);
                yield return new DavisThin(119, 2, 2, 2, 0, 3, 2, 2);
                yield return new DavisThin(120, 0, 0, 3, 2, 3, 2, 0);
                yield return new DavisThin(121, 0, 0, 0, 0, 0, 0, 0);
                yield return new DavisThin(122, 0, 1, 1, 0, 1, 1, 0);
                yield return new DavisThin(123, 0, 3, 3, 0, 3, 3, 3);
                yield return new DavisThin(124, 0, 1, 0, 0, 0, 1, 0);
                yield return new DavisThin(125, 1, 1, 0, 0, 0, 0, 0);
                yield return new DavisThin(126, 1, 2, 2, 0, 3, 2, 1);
                yield return new DavisThin(127, 1, 3, 3, 0, 0, 0, 0);
                yield return new DavisThin(128, 0, 1, 0, 0, 2, 2, 2);
                yield return new DavisThin(129, 1, 2, 2, 0, 3, 2, 1);
                yield return new DavisThin(130, 1, 2, 3, 0, 3, 0, 3);
                yield return new DavisThin(131, 1, 0, 0, 0, 0, 1, 0);
                yield return new DavisThin(132, 0, 0, 0, 0, 0, 0, 0);
                yield return new DavisThin(133, 0, 2, 0, 1, 0, 0, 0);
                yield return new DavisThin(134, 1, 3, 3, 0, 3, 3, 3);
                yield return new DavisThin(135, 3, 0, 3, 0, 0, 3, 3);
                yield return new DavisThin(136, 0, 0, 0, 0, 0, 0, 0);
                yield return new DavisThin(137, 0, 0, 0, 0, 0, 0, 0);
                yield return new DavisThin(138, 0, 2, 0, 0, 0, 3, 0);
                yield return new DavisThin(139, 0, 2, 0, 0, 2, 2, 0);
                yield return new DavisThin(140, 0, 3, 3, 0, 3, 3, 3);
                yield return new DavisThin(141, 2, 0, 3, 0, 3, 3, 3);
                yield return new DavisThin(142, 1, 0, 0, 0, 0, 0, 0);
                yield return new DavisThin(143, 0, 1, 2, 0, 0, 0, 0);
                yield return new DavisThin(144, 0, 2, 2, 1, 2, 2, 2);
                yield return new DavisThin(145, 0, 0, 0, 0, 0, 0, 0);
                yield return new DavisThin(146, 0, 3, 3, 1, 3, 3, 2);
                yield return new DavisThin(147, 1, 0, 0, 0, 0, 0, 0);
                yield return new DavisThin(148, 0, 0, 3, 0, 0, 0, 0);
                yield return new DavisThin(149, 0, 2, 3, 2, 2, 2, 0);
                yield return new DavisThin(150, 0, 3, 3, 0, 3, 2, 1);
                yield return new DavisThin(151, 0, 0, 0, 0, 0, 0, 0);
                yield return new DavisThin(152, 0, 0, 0, 0, 0, 0, 0);
                yield return new DavisThin(153, 2, 2, 3, 2, 3, 3, 3);
                yield return new DavisThin(154, 2, 0, 0, 0, 0, 0, 0);
                yield return new DavisThin(155, 0, 0, 0, 0, 0, 0, 0);
                yield return new DavisThin(156, 0, 0, 0, 0, 0, 0, 0);
                yield return new DavisThin(157, 0, 0, 0, 0, 0, 0, 0);
                yield return new DavisThin(158, 0, 0, 0, 0, 1, 2, 0);
                yield return new DavisThin(159, 1, 3, 3, 2, 3, 3, 3);
                yield return new DavisThin(160, 0, 1, 0, 0, 0, 0, 0);
                yield return new DavisThin(161, 0, 0, 0, 0, 0, 0, 0);
                yield return new DavisThin(162, 0, 0, 0, 0, 1, 0, 0);
                yield return new DavisThin(163, 0, 0, 0, 0, 0, 0, 0);
                yield return new DavisThin(164, 0, 3, 0, 1, 0, 2, 0);
                yield return new DavisThin(165, 0, 1, 0, 0, 0, 0, 0);
                yield return new DavisThin(166, 1, 0, 1, 0, 1, 0, 0);
                yield return new DavisThin(167, 0, 0, 0, 0, 1, 0, 0);
                yield return new DavisThin(168, 0, 0, 0, 0, 0, 0, 0);
                yield return new DavisThin(169, 0, 3, 2, 3, 3, 3, 0);
                yield return new DavisThin(170, 0, 0, 0, 2, 1, 1, 0);
                yield return new DavisThin(171, 2, 2, 2, 1, 1, 2, 0);
                yield return new DavisThin(172, 0, 0, 0, 0, 0, 0, 0);
                yield return new DavisThin(173, 1, 0, 0, 0, 0, 0, 0);
                yield return new DavisThin(174, 0, 0, 2, 0, 1, 0, 1);
                yield return new DavisThin(175, 0, 0, 0, 0, 0, 0, 0);
                yield return new DavisThin(176, 0, 0, 2, 0, 0, 0, 0);
                yield return new DavisThin(177, 0, 0, 0, 0, 0, 0, 0);
                yield return new DavisThin(178, 0, 3, 0, 0, 0, 0, 0);
                yield return new DavisThin(179, 0, 3, 2, 0, 1, 0, 0);
                yield return new DavisThin(180, 1, 3, 2, 1, 3, 3, 1);
                yield return new DavisThin(181, 0, 0, 0, 0, 0, 0, 0);
                yield return new DavisThin(182, 0, 0, 0, 0, 0, 0, 0);
                yield return new DavisThin(183, 0, 0, 0, 0, 0, 0, 0);
                yield return new DavisThin(184, 0, 0, 0, 0, 0, 0, 0);
                yield return new DavisThin(185, 2, 1, 3, 0, 0, 0, 0);
                yield return new DavisThin(186, 1, 1, 0, 0, 0, 0, 0);
                yield return new DavisThin(187, 0, 0, 0, 0, 0, 0, 0);
                yield return new DavisThin(188, 2, 0, 1, 0, 3, 0, 1);
                yield return new DavisThin(189, 0, 0, 0, 0, 2, 0, 0);
                yield return new DavisThin(190, 0, 0, 0, 0, 1, 3, 0);
                yield return new DavisThin(191, 0, 0, 0, 0, 0, 0, 0);
            }
        }
    }
}
