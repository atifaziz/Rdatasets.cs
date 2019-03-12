// ReSharper disable All

namespace Rdatasets.gamclass
{
    using System.Collections.Generic;

    /// <summary>
    /// Chronic bronchitis in a sample of men in Cardiff
    /// </summary>

    public class bronchitis
    {
        public readonly int κ;
        public readonly double cig;
        public readonly double poll;
        public readonly int r;
        public readonly string rfac;

        public bronchitis(int κ, double cig, double poll, int r, string rfac)
        {
            this.κ = κ;
            this.cig = cig;
            this.poll = poll;
            this.r = r;
            this.rfac = rfac;
        }

        public static IEnumerable<bronchitis> Data
        {
            get
            {
                yield return new bronchitis(1, 5.15, 67.1, 0, "abs");
                yield return new bronchitis(2, 6.75, 64.4, 0, "abs");
                yield return new bronchitis(3, 0, 65.9, 0, "abs");
                yield return new bronchitis(4, 5.15, 67, 1, "pres");
                yield return new bronchitis(5, 5.25, 64.2, 0, "abs");
                yield return new bronchitis(6, 0, 62.7, 0, "abs");
                yield return new bronchitis(7, 0, 63.1, 0, "abs");
                yield return new bronchitis(8, 1.1, 62.4, 0, "abs");
                yield return new bronchitis(9, 1.6, 63, 0, "abs");
                yield return new bronchitis(10, 13.75, 63.8, 1, "pres");
                yield return new bronchitis(11, 0, 62.5, 0, "abs");
                yield return new bronchitis(12, 0, 61.4, 0, "abs");
                yield return new bronchitis(13, 0, 60.9, 0, "abs");
                yield return new bronchitis(14, 12.5, 62.6, 1, "pres");
                yield return new bronchitis(15, 6.75, 62.7, 1, "pres");
                yield return new bronchitis(16, 2.4, 60.6, 0, "abs");
                yield return new bronchitis(17, 5, 61.3, 0, "abs");
                yield return new bronchitis(18, 0.9, 59.7, 0, "abs");
                yield return new bronchitis(19, 6.6, 59.4, 1, "pres");
                yield return new bronchitis(20, 0, 59.7, 0, "abs");
                yield return new bronchitis(21, 0, 60.8, 0, "abs");
                yield return new bronchitis(22, 1.9, 59.4, 0, "abs");
                yield return new bronchitis(23, 6.9, 59, 1, "pres");
                yield return new bronchitis(24, 15, 59.4, 1, "pres");
                yield return new bronchitis(25, 1.4, 54.2, 0, "abs");
                yield return new bronchitis(26, 2.45, 53.7, 0, "abs");
                yield return new bronchitis(27, 10.05, 53.9, 0, "abs");
                yield return new bronchitis(28, 0, 54.9, 0, "abs");
                yield return new bronchitis(29, 10.5, 54, 1, "pres");
                yield return new bronchitis(30, 0, 55.5, 0, "abs");
                yield return new bronchitis(31, 5.25, 56.4, 0, "abs");
                yield return new bronchitis(32, 10.9, 57.6, 1, "pres");
                yield return new bronchitis(33, 2.65, 57.8, 0, "abs");
                yield return new bronchitis(34, 15, 58.1, 0, "abs");
                yield return new bronchitis(35, 0.55, 58.1, 0, "abs");
                yield return new bronchitis(36, 3.2, 57.1, 0, "abs");
                yield return new bronchitis(37, 0, 57.5, 0, "abs");
                yield return new bronchitis(38, 3.7, 57.2, 1, "pres");
                yield return new bronchitis(39, 10.05, 53.1, 0, "abs");
                yield return new bronchitis(40, 0.75, 52.6, 0, "abs");
                yield return new bronchitis(41, 0.55, 52.7, 0, "abs");
                yield return new bronchitis(42, 0.8, 53.7, 0, "abs");
                yield return new bronchitis(43, 0.6, 53, 0, "abs");
                yield return new bronchitis(44, 0.25, 53.2, 0, "abs");
                yield return new bronchitis(45, 20.25, 54.9, 1, "pres");
                yield return new bronchitis(46, 10, 57.4, 0, "abs");
                yield return new bronchitis(47, 0.9, 56.5, 0, "abs");
                yield return new bronchitis(48, 0.95, 56.3, 0, "abs");
                yield return new bronchitis(49, 17.2, 55.9, 0, "abs");
                yield return new bronchitis(50, 0.6, 57, 0, "abs");
                yield return new bronchitis(51, 12.3, 55.2, 1, "pres");
                yield return new bronchitis(52, 10, 55.5, 1, "pres");
                yield return new bronchitis(53, 9, 56.1, 1, "pres");
                yield return new bronchitis(54, 0, 66.9, 1, "pres");
                yield return new bronchitis(55, 0, 64.4, 0, "abs");
                yield return new bronchitis(56, 0.75, 67.1, 0, "abs");
                yield return new bronchitis(57, 30, 66.3, 1, "pres");
                yield return new bronchitis(58, 10.05, 64.6, 0, "abs");
                yield return new bronchitis(59, 0.55, 62.7, 0, "abs");
                yield return new bronchitis(60, 3.4, 63, 0, "abs");
                yield return new bronchitis(61, 1.8, 64.4, 0, "abs");
                yield return new bronchitis(62, 6.2, 62.2, 0, "abs");
                yield return new bronchitis(63, 0, 63.1, 0, "abs");
                yield return new bronchitis(64, 14.8, 61.7, 1, "pres");
                yield return new bronchitis(65, 0.25, 61.4, 0, "abs");
                yield return new bronchitis(66, 5.9, 60.8, 0, "abs");
                yield return new bronchitis(67, 0, 62.1, 0, "abs");
                yield return new bronchitis(68, 0, 62.7, 0, "abs");
                yield return new bronchitis(69, 10.05, 60.4, 0, "abs");
                yield return new bronchitis(70, 0.6, 60.7, 0, "abs");
                yield return new bronchitis(71, 0, 59.5, 0, "abs");
                yield return new bronchitis(72, 1, 58.5, 0, "abs");
                yield return new bronchitis(73, 5, 59.4, 1, "pres");
                yield return new bronchitis(74, 11.25, 60.4, 1, "pres");
                yield return new bronchitis(75, 0.45, 59.8, 0, "abs");
                yield return new bronchitis(76, 2.35, 58.6, 0, "abs");
                yield return new bronchitis(77, 0, 59.4, 0, "abs");
                yield return new bronchitis(78, 0.5, 54, 0, "abs");
                yield return new bronchitis(79, 1.75, 53.1, 0, "abs");
                yield return new bronchitis(80, 0.55, 53.2, 0, "abs");
                yield return new bronchitis(81, 0, 54.5, 0, "abs");
                yield return new bronchitis(82, 0.5, 55.8, 0, "abs");
                yield return new bronchitis(83, 0.96, 54.9, 0, "abs");
                yield return new bronchitis(84, 0, 55.9, 1, "pres");
                yield return new bronchitis(85, 0, 57.7, 0, "abs");
                yield return new bronchitis(86, 0.55, 58.4, 0, "abs");
                yield return new bronchitis(87, 0, 57.9, 0, "abs");
                yield return new bronchitis(88, 10, 57.9, 1, "pres");
                yield return new bronchitis(89, 0, 58.9, 1, "pres");
                yield return new bronchitis(90, 2.35, 57.2, 0, "abs");
                yield return new bronchitis(91, 17.1, 57.3, 0, "abs");
                yield return new bronchitis(92, 1.15, 53, 0, "abs");
                yield return new bronchitis(93, 0, 53.1, 0, "abs");
                yield return new bronchitis(94, 0.95, 52.6, 0, "abs");
                yield return new bronchitis(95, 1.55, 53.1, 0, "abs");
                yield return new bronchitis(96, 0.4, 53.9, 0, "abs");
                yield return new bronchitis(97, 3.6, 53.4, 0, "abs");
                yield return new bronchitis(98, 0.95, 54.6, 0, "abs");
                yield return new bronchitis(99, 3.4, 57.3, 0, "abs");
                yield return new bronchitis(100, 0, 56.8, 0, "abs");
                yield return new bronchitis(101, 1.06, 56.3, 0, "abs");
                yield return new bronchitis(102, 1.65, 56, 0, "abs");
                yield return new bronchitis(103, 8.25, 56.7, 1, "pres");
                yield return new bronchitis(104, 1.15, 56.9, 0, "abs");
                yield return new bronchitis(105, 0.6, 55.3, 0, "abs");
                yield return new bronchitis(106, 0, 55.9, 0, "abs");
                yield return new bronchitis(107, 2.5, 66.7, 0, "abs");
                yield return new bronchitis(108, 0, 65.1, 1, "pres");
                yield return new bronchitis(109, 5.25, 67.9, 0, "abs");
                yield return new bronchitis(110, 0, 65.7, 0, "abs");
                yield return new bronchitis(111, 0, 63.5, 0, "abs");
                yield return new bronchitis(112, 9.5, 62.1, 1, "pres");
                yield return new bronchitis(113, 2.2, 62.7, 0, "abs");
                yield return new bronchitis(114, 0, 64.2, 0, "abs");
                yield return new bronchitis(115, 14.75, 62.3, 0, "abs");
                yield return new bronchitis(116, 7.5, 62.7, 1, "pres");
                yield return new bronchitis(117, 3.5, 61.6, 1, "pres");
                yield return new bronchitis(118, 1.55, 62, 0, "abs");
                yield return new bronchitis(119, 16.45, 60.6, 0, "abs");
                yield return new bronchitis(120, 14.55, 61.7, 0, "abs");
                yield return new bronchitis(121, 0, 61.7, 1, "pres");
                yield return new bronchitis(122, 12.75, 61.7, 1, "pres");
                yield return new bronchitis(123, 0, 60.8, 0, "abs");
                yield return new bronchitis(124, 8.75, 59.6, 1, "pres");
                yield return new bronchitis(125, 0, 60, 0, "abs");
                yield return new bronchitis(126, 2.55, 59.2, 0, "abs");
                yield return new bronchitis(127, 0, 60.2, 0, "abs");
                yield return new bronchitis(128, 0, 59.7, 1, "pres");
                yield return new bronchitis(129, 3.95, 59.7, 0, "abs");
                yield return new bronchitis(130, 0.95, 59.4, 0, "abs");
                yield return new bronchitis(131, 0.6, 53.8, 0, "abs");
                yield return new bronchitis(132, 0, 54.4, 0, "abs");
                yield return new bronchitis(133, 0.85, 53.2, 0, "abs");
                yield return new bronchitis(134, 1.45, 54.2, 0, "abs");
                yield return new bronchitis(135, 9.2, 55.5, 1, "pres");
                yield return new bronchitis(136, 1, 54.6, 0, "abs");
                yield return new bronchitis(137, 9, 55.8, 0, "abs");
                yield return new bronchitis(138, 0, 57.6, 0, "abs");
                yield return new bronchitis(139, 0, 58.2, 0, "abs");
                yield return new bronchitis(140, 0, 57.3, 0, "abs");
                yield return new bronchitis(141, 0, 57.6, 0, "abs");
                yield return new bronchitis(142, 6.8, 58.6, 1, "pres");
                yield return new bronchitis(143, 24.9, 58, 0, "abs");
                yield return new bronchitis(144, 0, 57.5, 0, "abs");
                yield return new bronchitis(145, 18.25, 53, 1, "pres");
                yield return new bronchitis(146, 4.2, 53, 0, "abs");
                yield return new bronchitis(147, 0, 52.1, 0, "abs");
                yield return new bronchitis(148, 0.4, 53.3, 0, "abs");
                yield return new bronchitis(149, 7.5, 53.7, 1, "pres");
                yield return new bronchitis(150, 0.95, 53.2, 0, "abs");
                yield return new bronchitis(151, 4.25, 54.1, 0, "abs");
                yield return new bronchitis(152, 0, 57.3, 0, "abs");
                yield return new bronchitis(153, 0, 56.6, 0, "abs");
                yield return new bronchitis(154, 13.3, 56.2, 0, "abs");
                yield return new bronchitis(155, 5, 55.8, 1, "pres");
                yield return new bronchitis(156, 0.9, 56.4, 0, "abs");
                yield return new bronchitis(157, 2.2, 56.7, 0, "abs");
                yield return new bronchitis(158, 9.5, 56.5, 0, "abs");
                yield return new bronchitis(159, 0.5, 55.5, 0, "abs");
                yield return new bronchitis(160, 1.75, 65.8, 0, "abs");
                yield return new bronchitis(161, 9.5, 66.2, 1, "pres");
                yield return new bronchitis(162, 8, 68.1, 1, "pres");
                yield return new bronchitis(163, 0, 65.2, 0, "abs");
                yield return new bronchitis(164, 3.4, 63, 1, "pres");
                yield return new bronchitis(165, 12.5, 63.7, 1, "pres");
                yield return new bronchitis(166, 6.7, 63.1, 0, "abs");
                yield return new bronchitis(167, 3.6, 64.2, 1, "pres");
                yield return new bronchitis(168, 0.35, 63.7, 0, "abs");
                yield return new bronchitis(169, 1, 62.9, 0, "abs");
                yield return new bronchitis(170, 0, 61.6, 0, "abs");
                yield return new bronchitis(171, 0, 61.8, 1, "pres");
                yield return new bronchitis(172, 2.65, 62.9, 0, "abs");
                yield return new bronchitis(173, 11, 61, 1, "pres");
                yield return new bronchitis(174, 1.75, 60.9, 0, "abs");
                yield return new bronchitis(175, 0, 61.9, 0, "abs");
                yield return new bronchitis(176, 0.85, 60.5, 0, "abs");
                yield return new bronchitis(177, 0.8, 59.1, 0, "abs");
                yield return new bronchitis(178, 8.15, 59.8, 1, "pres");
                yield return new bronchitis(179, 1.2, 58.6, 0, "abs");
                yield return new bronchitis(180, 2, 60, 0, "abs");
                yield return new bronchitis(181, 0, 59, 0, "abs");
                yield return new bronchitis(182, 0.6, 59.6, 0, "abs");
                yield return new bronchitis(183, 0, 59.3, 0, "abs");
                yield return new bronchitis(184, 0, 53.7, 0, "abs");
                yield return new bronchitis(185, 3.1, 54.2, 0, "abs");
                yield return new bronchitis(186, 1.1, 54.9, 0, "abs");
                yield return new bronchitis(187, 2.05, 54.2, 0, "abs");
                yield return new bronchitis(188, 0.55, 55.6, 0, "abs");
                yield return new bronchitis(189, 0, 56.9, 0, "abs");
                yield return new bronchitis(190, 1.6, 55.6, 0, "abs");
                yield return new bronchitis(191, 2.25, 57.8, 0, "abs");
                yield return new bronchitis(192, 4.5, 58, 1, "pres");
                yield return new bronchitis(193, 4.2, 58.3, 0, "abs");
                yield return new bronchitis(194, 7.1, 57.3, 0, "abs");
                yield return new bronchitis(195, 0, 58.7, 0, "abs");
                yield return new bronchitis(196, 2.65, 57.9, 0, "abs");
                yield return new bronchitis(197, 0.95, 57.2, 0, "abs");
                yield return new bronchitis(198, 10, 52.9, 0, "abs");
                yield return new bronchitis(199, 0.8, 52.9, 0, "abs");
                yield return new bronchitis(200, 3.1, 54.1, 0, "abs");
                yield return new bronchitis(201, 6.2, 53, 0, "abs");
                yield return new bronchitis(202, 7.15, 53.4, 0, "abs");
                yield return new bronchitis(203, 2.8, 54.9, 0, "abs");
                yield return new bronchitis(204, 4.15, 54.2, 0, "abs");
                yield return new bronchitis(205, 3.6, 56.7, 0, "abs");
                yield return new bronchitis(206, 6.4, 56.5, 1, "pres");
                yield return new bronchitis(207, 1.1, 56.6, 0, "abs");
                yield return new bronchitis(208, 2.1, 55.7, 0, "abs");
                yield return new bronchitis(209, 0, 56.5, 0, "abs");
                yield return new bronchitis(210, 3.6, 56, 0, "abs");
                yield return new bronchitis(211, 0.7, 56.3, 0, "abs");
                yield return new bronchitis(212, 0.9, 55.4, 0, "abs");
            }
        }
    }
}
