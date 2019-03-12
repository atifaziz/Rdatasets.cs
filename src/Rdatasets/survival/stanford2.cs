// ReSharper disable All

namespace Rdatasets.survival
{
    using System.Collections.Generic;

    /// <summary>
    /// More Stanford Heart Transplant data
    /// </summary>

    public class stanford2
    {
        public readonly int κ;
        public readonly int id;
        public readonly double time;
        public readonly int status;
        public readonly int age;
        public readonly double? t5;

        public stanford2(int κ, int id, double time, int status, int age, double? t5)
        {
            this.κ = κ;
            this.id = id;
            this.time = time;
            this.status = status;
            this.age = age;
            this.t5 = t5;
        }

        public static IEnumerable<stanford2> Data
        {
            get
            {
                yield return new stanford2(139, 139, 86, 1, 12, 1.26);
                yield return new stanford2(159, 159, 10, 1, 13, 1.49);
                yield return new stanford2(181, 181, 60, 0, 13, null);
                yield return new stanford2(119, 119, 1116, 0, 14, 0.54);
                yield return new stanford2(74, 74, 2006, 0, 15, 1.26);
                yield return new stanford2(120, 120, 1107, 0, 18, 0.25);
                yield return new stanford2(99, 99, 1232, 1, 18, 0.7);
                yield return new stanford2(108, 108, 42, 1, 19, 0.63);
                yield return new stanford2(179, 179, 98, 0, 19, null);
                yield return new stanford2(43, 43, 227, 1, 19, 1.02);
                yield return new stanford2(134, 134, 793, 0, 19, 1.98);
                yield return new stanford2(160, 160, 5, 1, 20, null);
                yield return new stanford2(177, 177, 119, 0, 20, null);
                yield return new stanford2(153, 153, 534, 0, 20, null);
                yield return new stanford2(136, 136, 781, 0, 20, 1.12);
                yield return new stanford2(133, 133, 1, 1, 21, 0.47);
                yield return new stanford2(176, 176, 149, 0, 21, null);
                yield return new stanford2(66, 66, 1634, 1, 23, 1.78);
                yield return new stanford2(157, 157, 468, 0, 24, 1.39);
                yield return new stanford2(114, 114, 1193, 0, 24, 1.15);
                yield return new stanford2(46, 46, 631, 1, 26, 1.46);
                yield return new stanford2(65, 65, 2313, 0, 26, 0.46);
                yield return new stanford2(184, 184, 1, 0, 27, null);
                yield return new stanford2(88, 88, 22, 1, 27, 1.64);
                yield return new stanford2(182, 182, 56, 0, 27, null);
                yield return new stanford2(180, 180, 89, 0, 27, null);
                yield return new stanford2(163, 163, 391, 0, 27, 1.17);
                yield return new stanford2(84, 84, 1778, 0, 27, 0.7);
                yield return new stanford2(90, 90, 7, 1, 28, 1);
                yield return new stanford2(68, 68, 48, 1, 28, 0.77);
                yield return new stanford2(48, 48, 12, 1, 29, 0.61);
                yield return new stanford2(174, 174, 176, 0, 29, 1.72);
                yield return new stanford2(151, 151, 548, 0, 30, 0.47);
                yield return new stanford2(125, 125, 993, 0, 30, 0.95);
                yield return new stanford2(73, 73, 2025, 0, 30, 1.44);
                yield return new stanford2(105, 105, 274, 1, 31, 0.58);
                yield return new stanford2(117, 117, 1150, 1, 32, 2.25);
                yield return new stanford2(96, 96, 1271, 1, 32, 1.05);
                yield return new stanford2(39, 39, 2723, 1, 32, 1.93);
                yield return new stanford2(38, 38, 2984, 0, 32, 0.19);
                yield return new stanford2(106, 106, 31, 1, 33, 0.36);
                yield return new stanford2(14, 14, 1961, 1, 33, 1.06);
                yield return new stanford2(123, 123, 30, 1, 34, 0.84);
                yield return new stanford2(135, 135, 328, 1, 34, 1.02);
                yield return new stanford2(111, 111, 1262, 0, 34, 1.68);
                yield return new stanford2(83, 83, 68, 1, 35, 0.85);
                yield return new stanford2(143, 143, 221, 1, 35, 1.04);
                yield return new stanford2(69, 69, 2127, 1, 35, 0.67);
                yield return new stanford2(27, 27, 44, 1, 36, 0);
                yield return new stanford2(113, 113, 47, 1, 36, 0.16);
                yield return new stanford2(167, 167, 322, 0, 36, 1.73);
                yield return new stanford2(156, 156, 382, 1, 36, null);
                yield return new stanford2(141, 141, 663, 0, 36, 0.47);
                yield return new stanford2(30, 30, 1478, 1, 36, 1.35);
                yield return new stanford2(144, 144, 90, 1, 38, 1);
                yield return new stanford2(158, 158, 464, 0, 38, 2.07);
                yield return new stanford2(79, 79, 731, 1, 38, 0.42);
                yield return new stanford2(102, 102, 1202, 1, 38, null);
                yield return new stanford2(77, 77, 1945, 0, 38, 1.28);
                yield return new stanford2(36, 36, 3021, 0, 38, 0.98);
                yield return new stanford2(183, 183, 2, 0, 39, null);
                yield return new stanford2(122, 122, 195, 1, 39, 0.73);
                yield return new stanford2(162, 162, 406, 0, 39, 1.18);
                yield return new stanford2(121, 121, 1102, 0, 39, 1.35);
                yield return new stanford2(87, 87, 1718, 0, 39, 1.77);
                yield return new stanford2(2, 2, 3, 1, 40, 1.66);
                yield return new stanford2(64, 64, 14, 1, 40, null);
                yield return new stanford2(150, 150, 549, 0, 40, 2.53);
                yield return new stanford2(85, 85, 1722, 0, 40, 0.95);
                yield return new stanford2(71, 71, 2106, 0, 40, 0.86);
                yield return new stanford2(19, 19, 3695, 0, 40, 0.38);
                yield return new stanford2(21, 21, 0.5, 1, 41, 0.87);
                yield return new stanford2(175, 175, 138, 1, 41, null);
                yield return new stanford2(169, 169, 278, 0, 41, 0.98);
                yield return new stanford2(148, 148, 563, 0, 41, null);
                yield return new stanford2(138, 138, 738, 0, 41, 0.53);
                yield return new stanford2(98, 98, 1247, 1, 41, 0.43);
                yield return new stanford2(104, 104, 1373, 0, 41, 1.38);
                yield return new stanford2(103, 103, 1378, 0, 41, 1.65);
                yield return new stanford2(12, 12, 39, 1, 42, 1.38);
                yield return new stanford2(89, 89, 40, 1, 42, 1.59);
                yield return new stanford2(3, 3, 46, 1, 42, 0.61);
                yield return new stanford2(100, 100, 191, 1, 42, 1.74);
                yield return new stanford2(55, 55, 297, 1, 42, 0.6);
                yield return new stanford2(142, 142, 660, 0, 42, 0.75);
                yield return new stanford2(63, 63, 161, 1, 43, 1.2);
                yield return new stanford2(168, 168, 292, 0, 43, 1.4);
                yield return new stanford2(72, 72, 293, 1, 43, 0.7);
                yield return new stanford2(137, 137, 752, 0, 43, 1.5);
                yield return new stanford2(10, 10, 1024, 1, 43, 1.13);
                yield return new stanford2(124, 124, 1040, 0, 43, 0.5);
                yield return new stanford2(17, 17, 836, 1, 44, 1.58);
                yield return new stanford2(94, 94, 1534, 1, 44, 1.71);
                yield return new stanford2(82, 82, 1846, 0, 44, 0.83);
                yield return new stanford2(170, 170, 22, 1, 45, null);
                yield return new stanford2(149, 149, 36, 1, 45, 0.2);
                yield return new stanford2(42, 42, 65, 1, 45, 1.68);
                yield return new stanford2(128, 128, 121, 1, 45, null);
                yield return new stanford2(67, 67, 146, 1, 45, 0.16);
                yield return new stanford2(109, 109, 381, 1, 45, 0.98);
                yield return new stanford2(75, 75, 2000, 0, 45, 1.46);
                yield return new stanford2(26, 26, 3410, 0, 45, 0.98);
                yield return new stanford2(97, 97, 44, 1, 46, 1.71);
                yield return new stanford2(58, 58, 50, 1, 46, 2.25);
                yield return new stanford2(178, 178, 107, 0, 46, null);
                yield return new stanford2(140, 140, 132, 1, 46, 1.09);
                yield return new stanford2(32, 32, 897, 1, 46, null);
                yield return new stanford2(126, 126, 950, 0, 46, null);
                yield return new stanford2(51, 51, 1384, 1, 46, 1.41);
                yield return new stanford2(101, 101, 1393, 0, 46, 0.95);
                yield return new stanford2(29, 29, 51, 1, 47, 1.38);
                yield return new stanford2(33, 33, 148, 1, 47, null);
                yield return new stanford2(164, 164, 374, 0, 47, null);
                yield return new stanford2(60, 60, 431, 1, 47, 0.33);
                yield return new stanford2(152, 152, 541, 0, 47, 0.43);
                yield return new stanford2(145, 145, 619, 0, 47, 0.9);
                yield return new stanford2(112, 112, 1261, 0, 47, 0.82);
                yield return new stanford2(76, 76, 1995, 0, 47, 1.65);
                yield return new stanford2(47, 47, 2734, 0, 47, 0.97);
                yield return new stanford2(118, 118, 45, 1, 48, 0.65);
                yield return new stanford2(5, 5, 126, 1, 48, 0.36);
                yield return new stanford2(129, 129, 202, 1, 48, 1.24);
                yield return new stanford2(31, 31, 254, 1, 48, 1.08);
                yield return new stanford2(35, 35, 323, 1, 48, 1.82);
                yield return new stanford2(40, 40, 550, 1, 48, 0.12);
                yield return new stanford2(130, 130, 841, 0, 48, 0.86);
                yield return new stanford2(28, 28, 994, 1, 48, 0.81);
                yield return new stanford2(56, 56, 1318, 1, 48, 1.44);
                yield return new stanford2(91, 91, 1638, 0, 48, 0.43);
                yield return new stanford2(44, 44, 2805, 0, 48, 1.2);
                yield return new stanford2(23, 23, 54, 1, 49, 2.09);
                yield return new stanford2(37, 37, 66, 1, 49, 0.66);
                yield return new stanford2(70, 70, 263, 1, 49, 0.48);
                yield return new stanford2(132, 132, 265, 1, 49, 1.22);
                yield return new stanford2(9, 9, 279, 1, 49, 1.12);
                yield return new stanford2(81, 81, 538, 1, 49, 2.76);
                yield return new stanford2(59, 59, 547, 1, 49, 0.81);
                yield return new stanford2(127, 127, 729, 1, 49, 1.1);
                yield return new stanford2(131, 131, 834, 0, 49, null);
                yield return new stanford2(80, 80, 1866, 0, 49, 0.51);
                yield return new stanford2(20, 20, 1996, 1, 49, 0.91);
                yield return new stanford2(25, 25, 2878, 1, 49, 0.75);
                yield return new stanford2(165, 165, 50, 1, 50, 0.5);
                yield return new stanford2(24, 24, 51, 1, 50, null);
                yield return new stanford2(172, 172, 145, 1, 50, 0.96);
                yield return new stanford2(146, 146, 618, 0, 50, 0.82);
                yield return new stanford2(86, 86, 928, 1, 50, 1.12);
                yield return new stanford2(107, 107, 1341, 0, 50, 1.13);
                yield return new stanford2(95, 95, 1547, 0, 50, 0.18);
                yield return new stanford2(116, 116, 48, 1, 51, 0.99);
                yield return new stanford2(41, 41, 66, 1, 51, 1.12);
                yield return new stanford2(61, 61, 68, 1, 51, 1.33);
                yield return new stanford2(155, 155, 122, 1, 51, 1.33);
                yield return new stanford2(166, 166, 139, 1, 51, 0.96);
                yield return new stanford2(154, 154, 169, 1, 51, 1.89);
                yield return new stanford2(4, 4, 623, 1, 51, 1.32);
                yield return new stanford2(92, 92, 1612, 0, 51, 1.25);
                yield return new stanford2(93, 93, 25, 1, 52, 0.53);
                yield return new stanford2(62, 62, 26, 1, 52, 0.82);
                yield return new stanford2(34, 34, 51, 1, 52, 1.51);
                yield return new stanford2(15, 15, 136, 1, 52, 1.62);
                yield return new stanford2(173, 173, 188, 0, 52, null);
                yield return new stanford2(171, 171, 231, 0, 52, null);
                yield return new stanford2(52, 52, 544, 1, 52, 1.94);
                yield return new stanford2(110, 110, 1264, 0, 52, 0.64);
                yield return new stanford2(50, 50, 2474, 1, 52, 1.7);
                yield return new stanford2(45, 45, 25, 1, 53, 1.68);
                yield return new stanford2(53, 53, 29, 1, 53, 1.08);
                yield return new stanford2(54, 54, 48, 1, 53, 3.05);
                yield return new stanford2(147, 147, 576, 0, 53, 2.25);
                yield return new stanford2(115, 115, 626, 1, 53, 1.74);
                yield return new stanford2(16, 16, 1, 1, 54, 0.47);
                yield return new stanford2(1, 1, 15, 1, 54, 1.11);
                yield return new stanford2(6, 6, 64, 1, 54, 1.89);
                yield return new stanford2(7, 7, 1350, 1, 54, 0.87);
                yield return new stanford2(57, 57, 1352, 1, 54, 0.68);
                yield return new stanford2(78, 78, 65, 1, 55, 0.69);
                yield return new stanford2(161, 161, 136, 1, 55, null);
                yield return new stanford2(11, 11, 10, 1, 56, 2.76);
                yield return new stanford2(8, 8, 23, 1, 56, 2.05);
                yield return new stanford2(49, 49, 63, 1, 56, 2.16);
                yield return new stanford2(13, 13, 730, 1, 58, 0.96);
                yield return new stanford2(22, 22, 47, 1, 62, 0.87);
                yield return new stanford2(18, 18, 60, 1, 64, 0.69);
            }
        }
    }
}
