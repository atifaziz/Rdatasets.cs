// ReSharper disable All

namespace Rdatasets.carData
{
    using System.Collections.Generic;

    /// <summary>
    /// Self-Reports of Height and Weight
    /// </summary>

    public class Davis
    {
        public readonly int κ;
        public readonly string sex;
        public readonly int weight;
        public readonly int height;
        public readonly int? repwt;
        public readonly int? repht;

        public Davis(int κ, string sex, int weight, int height, int? repwt, int? repht)
        {
            this.κ = κ;
            this.sex = sex;
            this.weight = weight;
            this.height = height;
            this.repwt = repwt;
            this.repht = repht;
        }

        public static IEnumerable<Davis> Data
        {
            get
            {
                yield return new Davis(1, "M", 77, 182, 77, 180);
                yield return new Davis(2, "F", 58, 161, 51, 159);
                yield return new Davis(3, "F", 53, 161, 54, 158);
                yield return new Davis(4, "M", 68, 177, 70, 175);
                yield return new Davis(5, "F", 59, 157, 59, 155);
                yield return new Davis(6, "M", 76, 170, 76, 165);
                yield return new Davis(7, "M", 76, 167, 77, 165);
                yield return new Davis(8, "M", 69, 186, 73, 180);
                yield return new Davis(9, "M", 71, 178, 71, 175);
                yield return new Davis(10, "M", 65, 171, 64, 170);
                yield return new Davis(11, "M", 70, 175, 75, 174);
                yield return new Davis(12, "F", 166, 57, 56, 163);
                yield return new Davis(13, "F", 51, 161, 52, 158);
                yield return new Davis(14, "F", 64, 168, 64, 165);
                yield return new Davis(15, "F", 52, 163, 57, 160);
                yield return new Davis(16, "F", 65, 166, 66, 165);
                yield return new Davis(17, "M", 92, 187, 101, 185);
                yield return new Davis(18, "F", 62, 168, 62, 165);
                yield return new Davis(19, "M", 76, 197, 75, 200);
                yield return new Davis(20, "F", 61, 175, 61, 171);
                yield return new Davis(21, "M", 119, 180, 124, 178);
                yield return new Davis(22, "F", 61, 170, 61, 170);
                yield return new Davis(23, "M", 65, 175, 66, 173);
                yield return new Davis(24, "M", 66, 173, 70, 170);
                yield return new Davis(25, "F", 54, 171, 59, 168);
                yield return new Davis(26, "F", 50, 166, 50, 165);
                yield return new Davis(27, "F", 63, 169, 61, 168);
                yield return new Davis(28, "F", 58, 166, 60, 160);
                yield return new Davis(29, "F", 39, 157, 41, 153);
                yield return new Davis(30, "M", 101, 183, 100, 180);
                yield return new Davis(31, "F", 71, 166, 71, 165);
                yield return new Davis(32, "M", 75, 178, 73, 175);
                yield return new Davis(33, "M", 79, 173, 76, 173);
                yield return new Davis(34, "F", 52, 164, 52, 161);
                yield return new Davis(35, "F", 68, 169, 63, 170);
                yield return new Davis(36, "M", 64, 176, 65, 175);
                yield return new Davis(37, "F", 56, 166, 54, 165);
                yield return new Davis(38, "M", 69, 174, 69, 171);
                yield return new Davis(39, "M", 88, 178, 86, 175);
                yield return new Davis(40, "M", 65, 187, 67, 188);
                yield return new Davis(41, "F", 54, 164, 53, 160);
                yield return new Davis(42, "M", 80, 178, 80, 178);
                yield return new Davis(43, "F", 63, 163, 59, 159);
                yield return new Davis(44, "M", 78, 183, 80, 180);
                yield return new Davis(45, "M", 85, 179, 82, 175);
                yield return new Davis(46, "F", 54, 160, 55, 158);
                yield return new Davis(47, "M", 73, 180, null, null);
                yield return new Davis(48, "F", 49, 161, null, null);
                yield return new Davis(49, "F", 54, 174, 56, 173);
                yield return new Davis(50, "F", 75, 162, 75, 158);
                yield return new Davis(51, "M", 82, 182, 85, 183);
                yield return new Davis(52, "F", 56, 165, 57, 163);
                yield return new Davis(53, "M", 74, 169, 73, 170);
                yield return new Davis(54, "M", 102, 185, 107, 185);
                yield return new Davis(55, "M", 64, 177, null, null);
                yield return new Davis(56, "M", 65, 176, 64, 172);
                yield return new Davis(57, "F", 66, 170, 65, null);
                yield return new Davis(58, "M", 73, 183, 74, 180);
                yield return new Davis(59, "M", 75, 172, 70, 169);
                yield return new Davis(60, "M", 57, 173, 58, 170);
                yield return new Davis(61, "M", 68, 165, 69, 165);
                yield return new Davis(62, "M", 71, 177, 71, 170);
                yield return new Davis(63, "M", 71, 180, 76, 175);
                yield return new Davis(64, "F", 78, 173, 75, 169);
                yield return new Davis(65, "M", 97, 189, 98, 185);
                yield return new Davis(66, "F", 60, 162, 59, 160);
                yield return new Davis(67, "F", 64, 165, 63, 163);
                yield return new Davis(68, "F", 64, 164, 62, 161);
                yield return new Davis(69, "F", 52, 158, 51, 155);
                yield return new Davis(70, "M", 80, 178, 76, 175);
                yield return new Davis(71, "F", 62, 175, 61, 171);
                yield return new Davis(72, "M", 66, 173, 66, 175);
                yield return new Davis(73, "F", 55, 165, 54, 163);
                yield return new Davis(74, "F", 56, 163, 57, 159);
                yield return new Davis(75, "F", 50, 166, 50, 161);
                yield return new Davis(76, "F", 50, 171, null, null);
                yield return new Davis(77, "F", 50, 160, 55, 150);
                yield return new Davis(78, "F", 63, 160, 64, 158);
                yield return new Davis(79, "M", 69, 182, 70, 180);
                yield return new Davis(80, "M", 69, 183, 70, 183);
                yield return new Davis(81, "F", 61, 165, 60, 163);
                yield return new Davis(82, "M", 55, 168, 56, 170);
                yield return new Davis(83, "F", 53, 169, 52, 175);
                yield return new Davis(84, "F", 60, 167, 55, 163);
                yield return new Davis(85, "F", 56, 170, 56, 170);
                yield return new Davis(86, "M", 59, 182, 61, 183);
                yield return new Davis(87, "M", 62, 178, 66, 175);
                yield return new Davis(88, "F", 53, 165, 53, 165);
                yield return new Davis(89, "F", 57, 163, 59, 160);
                yield return new Davis(90, "F", 57, 162, 56, 160);
                yield return new Davis(91, "M", 70, 173, 68, 170);
                yield return new Davis(92, "F", 56, 161, 56, 161);
                yield return new Davis(93, "M", 84, 184, 86, 183);
                yield return new Davis(94, "M", 69, 180, 71, 180);
                yield return new Davis(95, "M", 88, 189, 87, 185);
                yield return new Davis(96, "F", 56, 165, 57, 160);
                yield return new Davis(97, "M", 103, 185, 101, 182);
                yield return new Davis(98, "F", 50, 169, 50, 165);
                yield return new Davis(99, "F", 52, 159, 52, 153);
                yield return new Davis(100, "F", 55, 155, null, 154);
                yield return new Davis(101, "F", 55, 164, 55, 163);
                yield return new Davis(102, "M", 63, 178, 63, 175);
                yield return new Davis(103, "F", 47, 163, 47, 160);
                yield return new Davis(104, "F", 45, 163, 45, 160);
                yield return new Davis(105, "F", 62, 175, 63, 173);
                yield return new Davis(106, "F", 53, 164, 51, 160);
                yield return new Davis(107, "F", 52, 152, 51, 150);
                yield return new Davis(108, "F", 57, 167, 55, 164);
                yield return new Davis(109, "F", 64, 166, 64, 165);
                yield return new Davis(110, "F", 59, 166, 55, 163);
                yield return new Davis(111, "M", 84, 183, 90, 183);
                yield return new Davis(112, "M", 79, 179, 79, 171);
                yield return new Davis(113, "F", 55, 174, 57, 171);
                yield return new Davis(114, "M", 67, 179, 67, 179);
                yield return new Davis(115, "F", 76, 167, 77, 165);
                yield return new Davis(116, "F", 62, 168, 62, 163);
                yield return new Davis(117, "M", 83, 184, 83, 181);
                yield return new Davis(118, "M", 96, 184, 94, 183);
                yield return new Davis(119, "M", 75, 169, 76, 165);
                yield return new Davis(120, "M", 65, 178, 66, 178);
                yield return new Davis(121, "M", 78, 178, 77, 175);
                yield return new Davis(122, "M", 69, 167, 73, 165);
                yield return new Davis(123, "F", 68, 178, 68, 175);
                yield return new Davis(124, "F", 55, 165, 55, 163);
                yield return new Davis(125, "M", 67, 179, null, null);
                yield return new Davis(126, "F", 52, 169, 56, null);
                yield return new Davis(127, "F", 47, 153, null, 154);
                yield return new Davis(128, "F", 45, 157, 45, 153);
                yield return new Davis(129, "F", 68, 171, 68, 169);
                yield return new Davis(130, "F", 44, 157, 44, 155);
                yield return new Davis(131, "F", 62, 166, 61, 163);
                yield return new Davis(132, "M", 87, 185, 89, 185);
                yield return new Davis(133, "F", 56, 160, 53, 158);
                yield return new Davis(134, "F", 50, 148, 47, 148);
                yield return new Davis(135, "M", 83, 177, 84, 175);
                yield return new Davis(136, "F", 53, 162, 53, 160);
                yield return new Davis(137, "F", 64, 172, 62, 168);
                yield return new Davis(138, "F", 62, 167, null, null);
                yield return new Davis(139, "M", 90, 188, 91, 185);
                yield return new Davis(140, "M", 85, 191, 83, 188);
                yield return new Davis(141, "M", 66, 175, 68, 175);
                yield return new Davis(142, "F", 52, 163, 53, 160);
                yield return new Davis(143, "F", 53, 165, 55, 163);
                yield return new Davis(144, "F", 54, 176, 55, 176);
                yield return new Davis(145, "F", 64, 171, 66, 171);
                yield return new Davis(146, "F", 55, 160, 55, 155);
                yield return new Davis(147, "F", 55, 165, 55, 165);
                yield return new Davis(148, "F", 59, 157, 55, 158);
                yield return new Davis(149, "F", 70, 173, 67, 170);
                yield return new Davis(150, "M", 88, 184, 86, 183);
                yield return new Davis(151, "F", 57, 168, 58, 165);
                yield return new Davis(152, "F", 47, 162, 47, 160);
                yield return new Davis(153, "F", 47, 150, 45, 152);
                yield return new Davis(154, "F", 55, 162, null, null);
                yield return new Davis(155, "F", 48, 163, 44, 160);
                yield return new Davis(156, "M", 54, 169, 58, 165);
                yield return new Davis(157, "M", 69, 172, 68, 174);
                yield return new Davis(158, "F", 59, 170, null, null);
                yield return new Davis(159, "F", 58, 169, null, null);
                yield return new Davis(160, "F", 57, 167, 56, 165);
                yield return new Davis(161, "F", 51, 163, 50, 160);
                yield return new Davis(162, "F", 54, 161, 54, 160);
                yield return new Davis(163, "F", 53, 162, 52, 158);
                yield return new Davis(164, "F", 59, 172, 58, 171);
                yield return new Davis(165, "M", 56, 163, 58, 161);
                yield return new Davis(166, "F", 59, 159, 59, 155);
                yield return new Davis(167, "F", 63, 170, 62, 168);
                yield return new Davis(168, "F", 66, 166, 66, 165);
                yield return new Davis(169, "M", 96, 191, 95, 188);
                yield return new Davis(170, "F", 53, 158, 50, 155);
                yield return new Davis(171, "M", 76, 169, 75, 165);
                yield return new Davis(172, "F", 54, 163, null, null);
                yield return new Davis(173, "M", 61, 170, 61, 170);
                yield return new Davis(174, "M", 82, 176, null, null);
                yield return new Davis(175, "M", 62, 168, 64, 168);
                yield return new Davis(176, "M", 71, 178, 68, 178);
                yield return new Davis(177, "F", 60, 174, null, null);
                yield return new Davis(178, "M", 66, 170, 67, 165);
                yield return new Davis(179, "M", 81, 178, 82, 175);
                yield return new Davis(180, "M", 68, 174, 68, 173);
                yield return new Davis(181, "M", 80, 176, 78, 175);
                yield return new Davis(182, "F", 43, 154, null, null);
                yield return new Davis(183, "M", 82, 181, null, null);
                yield return new Davis(184, "F", 63, 165, 59, 160);
                yield return new Davis(185, "M", 70, 173, 70, 173);
                yield return new Davis(186, "F", 56, 162, 56, 160);
                yield return new Davis(187, "F", 60, 172, 55, 168);
                yield return new Davis(188, "F", 58, 169, 54, 166);
                yield return new Davis(189, "M", 76, 183, 75, 180);
                yield return new Davis(190, "F", 50, 158, 49, 155);
                yield return new Davis(191, "M", 88, 185, 93, 188);
                yield return new Davis(192, "M", 89, 173, 86, 173);
                yield return new Davis(193, "F", 59, 164, 59, 165);
                yield return new Davis(194, "F", 51, 156, 51, 158);
                yield return new Davis(195, "F", 62, 164, 61, 161);
                yield return new Davis(196, "M", 74, 175, 71, 175);
                yield return new Davis(197, "M", 83, 180, 80, 180);
                yield return new Davis(198, "M", 81, 175, null, null);
                yield return new Davis(199, "M", 90, 181, 91, 178);
                yield return new Davis(200, "M", 79, 177, 81, 178);
            }
        }
    }
}
