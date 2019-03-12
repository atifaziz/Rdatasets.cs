// ReSharper disable All

namespace Rdatasets.Stat2Data
{
    using System.Collections.Generic;

    /// <summary>
    /// Kids198
    /// </summary>

    public class Kids198
    {
        public readonly int κ;
        public readonly double Height;
        public readonly int Weight;
        public readonly int Age;
        public readonly int Sex;
        public readonly int Race;

        public Kids198(int κ, double Height, int Weight, int Age, int Sex, int Race)
        {
            this.κ = κ;
            this.Height = Height;
            this.Weight = Weight;
            this.Age = Age;
            this.Sex = Sex;
            this.Race = Race;
        }

        public static IEnumerable<Kids198> Data
        {
            get
            {
                yield return new Kids198(1, 67.8, 166, 210, 0, 1);
                yield return new Kids198(2, 63, 93, 144, 1, 0);
                yield return new Kids198(3, 50.1, 54, 119, 0, 0);
                yield return new Kids198(4, 55.7, 69, 130, 1, 0);
                yield return new Kids198(5, 63.2, 115, 157, 0, 0);
                yield return new Kids198(6, 48.8, 52, 102, 0, 0);
                yield return new Kids198(7, 63.8, 108, 198, 1, 0);
                yield return new Kids198(8, 61.3, 89, 155, 0, 0);
                yield return new Kids198(9, 61.1, 118, 199, 1, 0);
                yield return new Kids198(10, 54.7, 80, 134, 0, 0);
                yield return new Kids198(11, 68.2, 139, 186, 0, 0);
                yield return new Kids198(12, 68.1, 129, 162, 0, 0);
                yield return new Kids198(13, 51.3, 55, 122, 1, 0);
                yield return new Kids198(14, 62.6, 113, 196, 1, 0);
                yield return new Kids198(15, 62.3, 112, 184, 1, 1);
                yield return new Kids198(16, 53.4, 60, 113, 1, 0);
                yield return new Kids198(17, 47.4, 47, 105, 0, 0);
                yield return new Kids198(18, 66.4, 121, 173, 0, 0);
                yield return new Kids198(19, 60.1, 79, 151, 1, 0);
                yield return new Kids198(20, 54.1, 63, 111, 0, 0);
                yield return new Kids198(21, 69.2, 132, 206, 0, 0);
                yield return new Kids198(22, 53.3, 73, 119, 1, 0);
                yield return new Kids198(23, 57.1, 106, 138, 1, 0);
                yield return new Kids198(24, 52.8, 68, 103, 1, 0);
                yield return new Kids198(25, 52.7, 60, 109, 0, 0);
                yield return new Kids198(26, 68.1, 163, 198, 0, 0);
                yield return new Kids198(27, 58.5, 76, 142, 0, 0);
                yield return new Kids198(28, 70.6, 150, 191, 0, 0);
                yield return new Kids198(29, 60.8, 98, 161, 0, 0);
                yield return new Kids198(30, 50.8, 59, 106, 1, 0);
                yield return new Kids198(31, 51.5, 56, 108, 1, 0);
                yield return new Kids198(32, 72.4, 174, 188, 0, 0);
                yield return new Kids198(33, 62.1, 114, 209, 1, 0);
                yield return new Kids198(34, 55.3, 79, 159, 0, 0);
                yield return new Kids198(35, 67, 132, 188, 0, 0);
                yield return new Kids198(36, 70.9, 171, 184, 0, 0);
                yield return new Kids198(37, 60, 89, 148, 1, 1);
                yield return new Kids198(38, 57.6, 97, 149, 0, 0);
                yield return new Kids198(39, 61.4, 97, 176, 0, 0);
                yield return new Kids198(40, 70.3, 131, 179, 1, 0);
                yield return new Kids198(41, 52.6, 67, 133, 1, 0);
                yield return new Kids198(42, 59.5, 77, 190, 1, 0);
                yield return new Kids198(43, 56.9, 81, 151, 1, 0);
                yield return new Kids198(44, 60.6, 128, 183, 1, 0);
                yield return new Kids198(45, 62.8, 119, 210, 1, 0);
                yield return new Kids198(46, 57.6, 111, 129, 0, 0);
                yield return new Kids198(47, 62.5, 112, 221, 1, 0);
                yield return new Kids198(48, 54.1, 89, 104, 0, 0);
                yield return new Kids198(49, 60, 103, 147, 0, 0);
                yield return new Kids198(50, 65.4, 106, 188, 1, 0);
                yield return new Kids198(51, 69.3, 145, 200, 0, 0);
                yield return new Kids198(52, 62.8, 99, 151, 0, 0);
                yield return new Kids198(53, 50.1, 56, 108, 1, 0);
                yield return new Kids198(54, 58.5, 75, 137, 1, 0);
                yield return new Kids198(55, 63.7, 129, 171, 0, 0);
                yield return new Kids198(56, 70.6, 133, 180, 0, 0);
                yield return new Kids198(57, 59.6, 114, 151, 0, 0);
                yield return new Kids198(58, 61.1, 89, 178, 0, 0);
                yield return new Kids198(59, 60.9, 90, 141, 1, 0);
                yield return new Kids198(60, 56.2, 82, 127, 0, 0);
                yield return new Kids198(61, 56.9, 75, 127, 0, 0);
                yield return new Kids198(62, 55.6, 67, 129, 1, 0);
                yield return new Kids198(63, 68.7, 129, 192, 0, 0);
                yield return new Kids198(64, 64.3, 157, 189, 1, 0);
                yield return new Kids198(65, 68.5, 137, 185, 0, 0);
                yield return new Kids198(66, 61.2, 95, 183, 1, 1);
                yield return new Kids198(67, 61.7, 116, 216, 1, 0);
                yield return new Kids198(68, 64.4, 89, 160, 1, 1);
                yield return new Kids198(69, 66.9, 146, 174, 0, 0);
                yield return new Kids198(70, 53.5, 72, 105, 0, 1);
                yield return new Kids198(71, 52.1, 58, 110, 1, 0);
                yield return new Kids198(72, 60.6, 116, 146, 1, 0);
                yield return new Kids198(73, 50, 51, 105, 1, 0);
                yield return new Kids198(74, 70.5, 180, 217, 0, 0);
                yield return new Kids198(75, 63.9, 111, 148, 0, 0);
                yield return new Kids198(76, 57.8, 83, 148, 0, 1);
                yield return new Kids198(77, 48.5, 58, 113, 1, 0);
                yield return new Kids198(78, 58.2, 81, 146, 1, 0);
                yield return new Kids198(79, 70.2, 141, 195, 0, 0);
                yield return new Kids198(80, 66.6, 155, 170, 0, 0);
                yield return new Kids198(81, 52.8, 57, 107, 0, 0);
                yield return new Kids198(82, 63.2, 113, 191, 1, 0);
                yield return new Kids198(83, 62.8, 125, 151, 0, 0);
                yield return new Kids198(84, 60.1, 112, 201, 1, 0);
                yield return new Kids198(85, 66.3, 91, 163, 1, 0);
                yield return new Kids198(86, 63.7, 104, 154, 1, 0);
                yield return new Kids198(87, 65, 121, 161, 1, 0);
                yield return new Kids198(88, 55.1, 75, 123, 1, 1);
                yield return new Kids198(89, 69.7, 147, 197, 0, 0);
                yield return new Kids198(90, 54.6, 63, 158, 0, 0);
                yield return new Kids198(91, 61.1, 101, 153, 0, 0);
                yield return new Kids198(92, 56, 102, 110, 1, 0);
                yield return new Kids198(93, 55.4, 63, 128, 1, 0);
                yield return new Kids198(94, 58.6, 103, 137, 1, 0);
                yield return new Kids198(95, 59.8, 88, 177, 0, 0);
                yield return new Kids198(96, 58.9, 88, 158, 0, 1);
                yield return new Kids198(97, 66.5, 112, 178, 0, 0);
                yield return new Kids198(98, 57.8, 82, 150, 1, 0);
                yield return new Kids198(99, 56.6, 72, 130, 0, 0);
                yield return new Kids198(100, 56.9, 87, 134, 1, 0);
                yield return new Kids198(101, 58.3, 109, 128, 1, 1);
                yield return new Kids198(102, 66.7, 158, 174, 0, 0);
                yield return new Kids198(103, 67.4, 131, 157, 0, 0);
                yield return new Kids198(104, 69.1, 151, 212, 0, 0);
                yield return new Kids198(105, 59, 101, 217, 1, 0);
                yield return new Kids198(106, 67.1, 138, 186, 0, 0);
                yield return new Kids198(107, 56.4, 120, 117, 0, 0);
                yield return new Kids198(108, 48.8, 54, 99, 1, 1);
                yield return new Kids198(109, 66.2, 138, 164, 1, 0);
                yield return new Kids198(110, 63.5, 106, 164, 0, 0);
                yield return new Kids198(111, 62.8, 154, 155, 1, 0);
                yield return new Kids198(112, 59.1, 75, 150, 0, 0);
                yield return new Kids198(113, 61.1, 97, 146, 0, 0);
                yield return new Kids198(114, 51.4, 47, 106, 1, 1);
                yield return new Kids198(115, 65.1, 172, 208, 1, 0);
                yield return new Kids198(116, 62, 123, 217, 1, 0);
                yield return new Kids198(117, 67, 129, 178, 1, 1);
                yield return new Kids198(118, 67.4, 155, 219, 1, 1);
                yield return new Kids198(119, 52, 70, 108, 1, 0);
                yield return new Kids198(120, 49.7, 53, 106, 1, 0);
                yield return new Kids198(121, 57.5, 95, 132, 0, 0);
                yield return new Kids198(122, 61.6, 117, 171, 1, 1);
                yield return new Kids198(123, 62.1, 130, 174, 1, 0);
                yield return new Kids198(124, 65.4, 119, 221, 1, 0);
                yield return new Kids198(125, 67.6, 140, 181, 0, 0);
                yield return new Kids198(126, 58.4, 83, 141, 1, 0);
                yield return new Kids198(127, 50.4, 51, 110, 1, 0);
                yield return new Kids198(128, 66.5, 128, 167, 1, 0);
                yield return new Kids198(129, 62.2, 95, 172, 0, 0);
                yield return new Kids198(130, 60.2, 100, 133, 1, 0);
                yield return new Kids198(131, 50.6, 59, 106, 1, 0);
                yield return new Kids198(132, 59.1, 98, 156, 1, 0);
                yield return new Kids198(133, 70.7, 160, 211, 0, 0);
                yield return new Kids198(134, 61.3, 108, 159, 1, 0);
                yield return new Kids198(135, 61.5, 108, 171, 1, 0);
                yield return new Kids198(136, 63.3, 121, 172, 0, 0);
                yield return new Kids198(137, 54.8, 66, 123, 1, 1);
                yield return new Kids198(138, 60.9, 88, 184, 1, 0);
                yield return new Kids198(139, 65, 124, 203, 1, 0);
                yield return new Kids198(140, 72.1, 142, 198, 0, 1);
                yield return new Kids198(141, 58.9, 99, 135, 1, 0);
                yield return new Kids198(142, 55.1, 116, 117, 0, 0);
                yield return new Kids198(143, 50.2, 58, 118, 1, 0);
                yield return new Kids198(144, 69.8, 144, 189, 0, 0);
                yield return new Kids198(145, 62, 111, 157, 1, 0);
                yield return new Kids198(146, 61.1, 109, 160, 1, 0);
                yield return new Kids198(147, 53, 103, 124, 0, 0);
                yield return new Kids198(148, 59.9, 93, 145, 1, 0);
                yield return new Kids198(149, 65.7, 103, 194, 0, 0);
                yield return new Kids198(150, 59.4, 85, 158, 1, 0);
                yield return new Kids198(151, 60.4, 108, 160, 1, 0);
                yield return new Kids198(152, 57.4, 104, 142, 0, 0);
                yield return new Kids198(153, 61.7, 93, 162, 1, 0);
                yield return new Kids198(154, 57.2, 102, 144, 0, 0);
                yield return new Kids198(155, 52.5, 61, 110, 0, 0);
                yield return new Kids198(156, 66.7, 111, 155, 0, 0);
                yield return new Kids198(157, 58.5, 94, 131, 0, 0);
                yield return new Kids198(158, 55.6, 64, 133, 1, 0);
                yield return new Kids198(159, 53.8, 61, 120, 0, 0);
                yield return new Kids198(160, 68.2, 153, 168, 0, 0);
                yield return new Kids198(161, 66.1, 142, 199, 1, 0);
                yield return new Kids198(162, 63.9, 121, 203, 0, 0);
                yield return new Kids198(163, 71.6, 198, 208, 0, 0);
                yield return new Kids198(164, 62.2, 105, 200, 1, 0);
                yield return new Kids198(165, 72.7, 158, 176, 0, 0);
                yield return new Kids198(166, 71.7, 162, 217, 0, 0);
                yield return new Kids198(167, 55.1, 75, 152, 1, 0);
                yield return new Kids198(168, 60.9, 87, 172, 0, 0);
                yield return new Kids198(169, 53.8, 71, 109, 0, 0);
                yield return new Kids198(170, 54.1, 71, 143, 1, 1);
                yield return new Kids198(171, 71, 194, 219, 0, 0);
                yield return new Kids198(172, 59.5, 81, 134, 0, 1);
                yield return new Kids198(173, 53.5, 75, 128, 1, 0);
                yield return new Kids198(174, 67.2, 154, 166, 0, 1);
                yield return new Kids198(175, 60.1, 93, 157, 1, 0);
                yield return new Kids198(176, 53.7, 66, 105, 1, 0);
                yield return new Kids198(177, 56.2, 77, 118, 1, 0);
                yield return new Kids198(178, 62.5, 115, 181, 0, 0);
                yield return new Kids198(179, 60.7, 129, 146, 1, 1);
                yield return new Kids198(180, 62.8, 114, 210, 1, 0);
                yield return new Kids198(181, 54.9, 66, 115, 0, 0);
                yield return new Kids198(182, 65.7, 117, 177, 0, 0);
                yield return new Kids198(183, 50.6, 61, 100, 1, 0);
                yield return new Kids198(184, 54.9, 62, 106, 0, 0);
                yield return new Kids198(185, 68.7, 157, 179, 0, 0);
                yield return new Kids198(186, 50, 55, 110, 0, 0);
                yield return new Kids198(187, 66.9, 126, 192, 0, 0);
                yield return new Kids198(188, 53.2, 66, 135, 0, 0);
                yield return new Kids198(189, 65.6, 136, 213, 1, 0);
                yield return new Kids198(190, 64, 99, 163, 1, 0);
                yield return new Kids198(191, 63.1, 142, 220, 1, 0);
                yield return new Kids198(192, 60.5, 94, 166, 1, 0);
                yield return new Kids198(193, 71.2, 161, 208, 0, 1);
                yield return new Kids198(194, 62.8, 94, 183, 0, 0);
                yield return new Kids198(195, 64.5, 130, 189, 1, 1);
                yield return new Kids198(196, 66.1, 135, 189, 1, 0);
                yield return new Kids198(197, 66.1, 119, 174, 1, 0);
                yield return new Kids198(198, 59.1, 86, 148, 1, 1);
            }
        }
    }
}
