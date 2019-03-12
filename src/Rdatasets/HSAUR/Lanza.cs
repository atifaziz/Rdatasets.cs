// ReSharper disable All

namespace Rdatasets.HSAUR
{
    using System.Collections.Generic;

    /// <summary>
    /// Prevention of Gastointestinal Damages
    /// </summary>

    public class Lanza
    {
        public readonly int κ;
        public readonly string study;
        public readonly string treatment;
        public readonly int classification;

        public Lanza(int κ, string study, string treatment, int classification)
        {
            this.κ = κ;
            this.study = study;
            this.treatment = treatment;
            this.classification = classification;
        }

        public static IEnumerable<Lanza> Data
        {
            get
            {
                yield return new Lanza(1, "I", "Misoprostol", 1);
                yield return new Lanza(2, "I", "Misoprostol", 1);
                yield return new Lanza(3, "I", "Misoprostol", 1);
                yield return new Lanza(4, "I", "Misoprostol", 1);
                yield return new Lanza(5, "I", "Misoprostol", 1);
                yield return new Lanza(6, "I", "Misoprostol", 1);
                yield return new Lanza(7, "I", "Misoprostol", 1);
                yield return new Lanza(8, "I", "Misoprostol", 1);
                yield return new Lanza(9, "I", "Misoprostol", 1);
                yield return new Lanza(10, "I", "Misoprostol", 1);
                yield return new Lanza(11, "I", "Misoprostol", 1);
                yield return new Lanza(12, "I", "Misoprostol", 1);
                yield return new Lanza(13, "I", "Misoprostol", 1);
                yield return new Lanza(14, "I", "Misoprostol", 1);
                yield return new Lanza(15, "I", "Misoprostol", 1);
                yield return new Lanza(16, "I", "Misoprostol", 1);
                yield return new Lanza(17, "I", "Misoprostol", 1);
                yield return new Lanza(18, "I", "Misoprostol", 1);
                yield return new Lanza(19, "I", "Misoprostol", 1);
                yield return new Lanza(20, "I", "Misoprostol", 1);
                yield return new Lanza(21, "I", "Misoprostol", 1);
                yield return new Lanza(22, "I", "Misoprostol", 2);
                yield return new Lanza(23, "I", "Misoprostol", 2);
                yield return new Lanza(24, "I", "Misoprostol", 3);
                yield return new Lanza(25, "I", "Misoprostol", 3);
                yield return new Lanza(26, "I", "Misoprostol", 3);
                yield return new Lanza(27, "I", "Misoprostol", 3);
                yield return new Lanza(28, "I", "Misoprostol", 4);
                yield return new Lanza(29, "I", "Misoprostol", 4);
                yield return new Lanza(30, "I", "Placebo", 1);
                yield return new Lanza(31, "I", "Placebo", 1);
                yield return new Lanza(32, "I", "Placebo", 2);
                yield return new Lanza(33, "I", "Placebo", 2);
                yield return new Lanza(34, "I", "Placebo", 3);
                yield return new Lanza(35, "I", "Placebo", 3);
                yield return new Lanza(36, "I", "Placebo", 3);
                yield return new Lanza(37, "I", "Placebo", 3);
                yield return new Lanza(38, "I", "Placebo", 4);
                yield return new Lanza(39, "I", "Placebo", 4);
                yield return new Lanza(40, "I", "Placebo", 4);
                yield return new Lanza(41, "I", "Placebo", 4);
                yield return new Lanza(42, "I", "Placebo", 4);
                yield return new Lanza(43, "I", "Placebo", 4);
                yield return new Lanza(44, "I", "Placebo", 4);
                yield return new Lanza(45, "I", "Placebo", 4);
                yield return new Lanza(46, "I", "Placebo", 4);
                yield return new Lanza(47, "I", "Placebo", 5);
                yield return new Lanza(48, "I", "Placebo", 5);
                yield return new Lanza(49, "I", "Placebo", 5);
                yield return new Lanza(50, "I", "Placebo", 5);
                yield return new Lanza(51, "I", "Placebo", 5);
                yield return new Lanza(52, "I", "Placebo", 5);
                yield return new Lanza(53, "I", "Placebo", 5);
                yield return new Lanza(54, "I", "Placebo", 5);
                yield return new Lanza(55, "I", "Placebo", 5);
                yield return new Lanza(56, "I", "Placebo", 5);
                yield return new Lanza(57, "I", "Placebo", 5);
                yield return new Lanza(58, "I", "Placebo", 5);
                yield return new Lanza(59, "I", "Placebo", 5);
                yield return new Lanza(60, "II", "Misoprostol", 1);
                yield return new Lanza(61, "II", "Misoprostol", 1);
                yield return new Lanza(62, "II", "Misoprostol", 1);
                yield return new Lanza(63, "II", "Misoprostol", 1);
                yield return new Lanza(64, "II", "Misoprostol", 1);
                yield return new Lanza(65, "II", "Misoprostol", 1);
                yield return new Lanza(66, "II", "Misoprostol", 1);
                yield return new Lanza(67, "II", "Misoprostol", 1);
                yield return new Lanza(68, "II", "Misoprostol", 1);
                yield return new Lanza(69, "II", "Misoprostol", 1);
                yield return new Lanza(70, "II", "Misoprostol", 1);
                yield return new Lanza(71, "II", "Misoprostol", 1);
                yield return new Lanza(72, "II", "Misoprostol", 1);
                yield return new Lanza(73, "II", "Misoprostol", 1);
                yield return new Lanza(74, "II", "Misoprostol", 1);
                yield return new Lanza(75, "II", "Misoprostol", 1);
                yield return new Lanza(76, "II", "Misoprostol", 1);
                yield return new Lanza(77, "II", "Misoprostol", 1);
                yield return new Lanza(78, "II", "Misoprostol", 1);
                yield return new Lanza(79, "II", "Misoprostol", 1);
                yield return new Lanza(80, "II", "Misoprostol", 2);
                yield return new Lanza(81, "II", "Misoprostol", 2);
                yield return new Lanza(82, "II", "Misoprostol", 2);
                yield return new Lanza(83, "II", "Misoprostol", 2);
                yield return new Lanza(84, "II", "Misoprostol", 3);
                yield return new Lanza(85, "II", "Misoprostol", 3);
                yield return new Lanza(86, "II", "Misoprostol", 3);
                yield return new Lanza(87, "II", "Misoprostol", 3);
                yield return new Lanza(88, "II", "Misoprostol", 3);
                yield return new Lanza(89, "II", "Misoprostol", 3);
                yield return new Lanza(90, "II", "Placebo", 1);
                yield return new Lanza(91, "II", "Placebo", 1);
                yield return new Lanza(92, "II", "Placebo", 1);
                yield return new Lanza(93, "II", "Placebo", 1);
                yield return new Lanza(94, "II", "Placebo", 1);
                yield return new Lanza(95, "II", "Placebo", 1);
                yield return new Lanza(96, "II", "Placebo", 1);
                yield return new Lanza(97, "II", "Placebo", 1);
                yield return new Lanza(98, "II", "Placebo", 2);
                yield return new Lanza(99, "II", "Placebo", 2);
                yield return new Lanza(100, "II", "Placebo", 2);
                yield return new Lanza(101, "II", "Placebo", 2);
                yield return new Lanza(102, "II", "Placebo", 3);
                yield return new Lanza(103, "II", "Placebo", 3);
                yield return new Lanza(104, "II", "Placebo", 3);
                yield return new Lanza(105, "II", "Placebo", 3);
                yield return new Lanza(106, "II", "Placebo", 3);
                yield return new Lanza(107, "II", "Placebo", 3);
                yield return new Lanza(108, "II", "Placebo", 3);
                yield return new Lanza(109, "II", "Placebo", 3);
                yield return new Lanza(110, "II", "Placebo", 3);
                yield return new Lanza(111, "II", "Placebo", 4);
                yield return new Lanza(112, "II", "Placebo", 4);
                yield return new Lanza(113, "II", "Placebo", 4);
                yield return new Lanza(114, "II", "Placebo", 4);
                yield return new Lanza(115, "II", "Placebo", 5);
                yield return new Lanza(116, "II", "Placebo", 5);
                yield return new Lanza(117, "II", "Placebo", 5);
                yield return new Lanza(118, "II", "Placebo", 5);
                yield return new Lanza(119, "II", "Placebo", 5);
                yield return new Lanza(120, "III", "Misoprostol", 1);
                yield return new Lanza(121, "III", "Misoprostol", 1);
                yield return new Lanza(122, "III", "Misoprostol", 1);
                yield return new Lanza(123, "III", "Misoprostol", 1);
                yield return new Lanza(124, "III", "Misoprostol", 1);
                yield return new Lanza(125, "III", "Misoprostol", 1);
                yield return new Lanza(126, "III", "Misoprostol", 1);
                yield return new Lanza(127, "III", "Misoprostol", 1);
                yield return new Lanza(128, "III", "Misoprostol", 1);
                yield return new Lanza(129, "III", "Misoprostol", 1);
                yield return new Lanza(130, "III", "Misoprostol", 1);
                yield return new Lanza(131, "III", "Misoprostol", 1);
                yield return new Lanza(132, "III", "Misoprostol", 1);
                yield return new Lanza(133, "III", "Misoprostol", 1);
                yield return new Lanza(134, "III", "Misoprostol", 1);
                yield return new Lanza(135, "III", "Misoprostol", 1);
                yield return new Lanza(136, "III", "Misoprostol", 1);
                yield return new Lanza(137, "III", "Misoprostol", 1);
                yield return new Lanza(138, "III", "Misoprostol", 1);
                yield return new Lanza(139, "III", "Misoprostol", 1);
                yield return new Lanza(140, "III", "Misoprostol", 2);
                yield return new Lanza(141, "III", "Misoprostol", 2);
                yield return new Lanza(142, "III", "Misoprostol", 2);
                yield return new Lanza(143, "III", "Misoprostol", 2);
                yield return new Lanza(144, "III", "Misoprostol", 3);
                yield return new Lanza(145, "III", "Misoprostol", 3);
                yield return new Lanza(146, "III", "Misoprostol", 3);
                yield return new Lanza(147, "III", "Misoprostol", 4);
                yield return new Lanza(148, "III", "Misoprostol", 5);
                yield return new Lanza(149, "III", "Misoprostol", 5);
                yield return new Lanza(150, "III", "Placebo", 2);
                yield return new Lanza(151, "III", "Placebo", 2);
                yield return new Lanza(152, "III", "Placebo", 3);
                yield return new Lanza(153, "III", "Placebo", 3);
                yield return new Lanza(154, "III", "Placebo", 3);
                yield return new Lanza(155, "III", "Placebo", 3);
                yield return new Lanza(156, "III", "Placebo", 3);
                yield return new Lanza(157, "III", "Placebo", 4);
                yield return new Lanza(158, "III", "Placebo", 4);
                yield return new Lanza(159, "III", "Placebo", 4);
                yield return new Lanza(160, "III", "Placebo", 4);
                yield return new Lanza(161, "III", "Placebo", 4);
                yield return new Lanza(162, "III", "Placebo", 5);
                yield return new Lanza(163, "III", "Placebo", 5);
                yield return new Lanza(164, "III", "Placebo", 5);
                yield return new Lanza(165, "III", "Placebo", 5);
                yield return new Lanza(166, "III", "Placebo", 5);
                yield return new Lanza(167, "III", "Placebo", 5);
                yield return new Lanza(168, "III", "Placebo", 5);
                yield return new Lanza(169, "III", "Placebo", 5);
                yield return new Lanza(170, "III", "Placebo", 5);
                yield return new Lanza(171, "III", "Placebo", 5);
                yield return new Lanza(172, "III", "Placebo", 5);
                yield return new Lanza(173, "III", "Placebo", 5);
                yield return new Lanza(174, "III", "Placebo", 5);
                yield return new Lanza(175, "III", "Placebo", 5);
                yield return new Lanza(176, "III", "Placebo", 5);
                yield return new Lanza(177, "III", "Placebo", 5);
                yield return new Lanza(178, "III", "Placebo", 5);
                yield return new Lanza(179, "IV", "Misoprostol", 1);
                yield return new Lanza(180, "IV", "Misoprostol", 2);
                yield return new Lanza(181, "IV", "Misoprostol", 2);
                yield return new Lanza(182, "IV", "Misoprostol", 2);
                yield return new Lanza(183, "IV", "Misoprostol", 2);
                yield return new Lanza(184, "IV", "Misoprostol", 3);
                yield return new Lanza(185, "IV", "Misoprostol", 3);
                yield return new Lanza(186, "IV", "Misoprostol", 3);
                yield return new Lanza(187, "IV", "Misoprostol", 3);
                yield return new Lanza(188, "IV", "Misoprostol", 3);
                yield return new Lanza(189, "IV", "Placebo", 4);
                yield return new Lanza(190, "IV", "Placebo", 4);
                yield return new Lanza(191, "IV", "Placebo", 4);
                yield return new Lanza(192, "IV", "Placebo", 4);
                yield return new Lanza(193, "IV", "Placebo", 5);
                yield return new Lanza(194, "IV", "Placebo", 5);
                yield return new Lanza(195, "IV", "Placebo", 5);
                yield return new Lanza(196, "IV", "Placebo", 5);
                yield return new Lanza(197, "IV", "Placebo", 5);
                yield return new Lanza(198, "IV", "Placebo", 5);
            }
        }
    }
}
