// ReSharper disable All

namespace Rdatasets.Stat2Data
{
    using System.Collections.Generic;

    /// <summary>
    /// ICU
    /// </summary>

    public class ICU
    {
        public readonly int κ;
        public readonly int ID;
        public readonly int Survive;
        public readonly int Age;
        public readonly int AgeGroup;
        public readonly int Sex;
        public readonly int Infection;
        public readonly int SysBP;
        public readonly int Pulse;
        public readonly int Emergency;

        public ICU(int κ, int ID, int Survive, int Age, int AgeGroup, int Sex, int Infection, int SysBP, int Pulse, int Emergency)
        {
            this.κ = κ;
            this.ID = ID;
            this.Survive = Survive;
            this.Age = Age;
            this.AgeGroup = AgeGroup;
            this.Sex = Sex;
            this.Infection = Infection;
            this.SysBP = SysBP;
            this.Pulse = Pulse;
            this.Emergency = Emergency;
        }

        public static IEnumerable<ICU> Data
        {
            get
            {
                yield return new ICU(1, 4, 0, 87, 3, 1, 1, 80, 96, 1);
                yield return new ICU(2, 8, 1, 27, 1, 1, 1, 142, 88, 1);
                yield return new ICU(3, 12, 1, 59, 2, 0, 0, 112, 80, 1);
                yield return new ICU(4, 14, 1, 77, 3, 0, 0, 100, 70, 0);
                yield return new ICU(5, 27, 0, 76, 3, 1, 1, 128, 90, 1);
                yield return new ICU(6, 28, 1, 54, 2, 0, 1, 142, 103, 1);
                yield return new ICU(7, 32, 1, 87, 3, 1, 1, 110, 154, 1);
                yield return new ICU(8, 38, 1, 69, 2, 0, 1, 110, 132, 1);
                yield return new ICU(9, 40, 1, 63, 2, 0, 0, 104, 66, 0);
                yield return new ICU(10, 41, 1, 30, 1, 1, 0, 144, 110, 1);
                yield return new ICU(11, 42, 1, 35, 1, 0, 0, 108, 60, 1);
                yield return new ICU(12, 47, 0, 78, 3, 0, 1, 130, 132, 1);
                yield return new ICU(13, 50, 1, 70, 3, 1, 0, 138, 103, 0);
                yield return new ICU(14, 51, 1, 55, 2, 1, 1, 188, 86, 0);
                yield return new ICU(15, 52, 0, 63, 2, 0, 1, 112, 106, 1);
                yield return new ICU(16, 53, 1, 48, 1, 0, 0, 162, 100, 0);
                yield return new ICU(17, 58, 1, 66, 2, 1, 0, 160, 80, 0);
                yield return new ICU(18, 61, 1, 61, 2, 1, 0, 174, 99, 1);
                yield return new ICU(19, 73, 1, 66, 2, 0, 0, 206, 90, 1);
                yield return new ICU(20, 75, 1, 52, 2, 0, 1, 150, 71, 0);
                yield return new ICU(21, 82, 1, 55, 2, 0, 1, 140, 116, 0);
                yield return new ICU(22, 84, 1, 59, 2, 0, 1, 48, 39, 1);
                yield return new ICU(23, 92, 1, 63, 2, 0, 0, 132, 128, 1);
                yield return new ICU(24, 96, 1, 72, 3, 0, 0, 120, 80, 0);
                yield return new ICU(25, 98, 1, 60, 2, 0, 1, 114, 110, 1);
                yield return new ICU(26, 100, 1, 78, 3, 0, 0, 180, 75, 0);
                yield return new ICU(27, 102, 1, 16, 1, 1, 0, 104, 111, 1);
                yield return new ICU(28, 111, 1, 62, 2, 0, 0, 200, 120, 0);
                yield return new ICU(29, 112, 1, 61, 2, 0, 1, 110, 120, 1);
                yield return new ICU(30, 127, 0, 19, 1, 0, 0, 140, 76, 1);
                yield return new ICU(31, 136, 1, 35, 1, 0, 0, 150, 98, 1);
                yield return new ICU(32, 137, 1, 74, 3, 1, 0, 170, 92, 0);
                yield return new ICU(33, 143, 1, 68, 2, 0, 0, 158, 96, 0);
                yield return new ICU(34, 145, 0, 67, 2, 1, 1, 62, 145, 1);
                yield return new ICU(35, 153, 1, 69, 2, 1, 0, 132, 60, 1);
                yield return new ICU(36, 154, 0, 53, 2, 1, 1, 148, 128, 1);
                yield return new ICU(37, 165, 0, 92, 3, 0, 1, 124, 80, 1);
                yield return new ICU(38, 170, 1, 51, 2, 0, 0, 110, 99, 1);
                yield return new ICU(39, 173, 1, 55, 2, 0, 0, 128, 92, 0);
                yield return new ICU(40, 180, 1, 64, 2, 1, 1, 158, 90, 1);
                yield return new ICU(41, 184, 1, 88, 3, 1, 1, 140, 88, 1);
                yield return new ICU(42, 186, 1, 23, 1, 1, 0, 112, 64, 1);
                yield return new ICU(43, 187, 1, 73, 3, 1, 0, 134, 60, 0);
                yield return new ICU(44, 190, 1, 53, 2, 0, 0, 110, 70, 0);
                yield return new ICU(45, 191, 1, 74, 3, 0, 0, 174, 86, 0);
                yield return new ICU(46, 195, 0, 57, 2, 0, 1, 110, 124, 1);
                yield return new ICU(47, 202, 0, 75, 3, 1, 0, 130, 136, 0);
                yield return new ICU(48, 204, 0, 91, 3, 0, 1, 64, 125, 1);
                yield return new ICU(49, 207, 1, 68, 2, 0, 0, 142, 89, 0);
                yield return new ICU(50, 208, 0, 70, 3, 0, 0, 168, 122, 0);
                yield return new ICU(51, 211, 1, 66, 2, 1, 1, 170, 95, 1);
                yield return new ICU(52, 214, 1, 60, 2, 0, 1, 110, 92, 0);
                yield return new ICU(53, 219, 1, 64, 2, 0, 1, 160, 120, 0);
                yield return new ICU(54, 222, 0, 88, 3, 0, 1, 141, 140, 1);
                yield return new ICU(55, 225, 1, 66, 2, 0, 1, 150, 120, 0);
                yield return new ICU(56, 237, 1, 19, 1, 1, 1, 142, 106, 1);
                yield return new ICU(57, 238, 0, 41, 1, 0, 1, 140, 58, 1);
                yield return new ICU(58, 241, 0, 61, 2, 0, 0, 140, 81, 1);
                yield return new ICU(59, 247, 1, 18, 1, 1, 0, 146, 112, 1);
                yield return new ICU(60, 249, 1, 63, 2, 0, 1, 162, 84, 1);
                yield return new ICU(61, 260, 1, 45, 1, 0, 0, 126, 110, 1);
                yield return new ICU(62, 266, 1, 64, 2, 0, 0, 162, 114, 1);
                yield return new ICU(63, 271, 1, 68, 2, 1, 1, 200, 170, 1);
                yield return new ICU(64, 273, 0, 80, 3, 0, 0, 100, 85, 1);
                yield return new ICU(65, 276, 1, 64, 2, 1, 1, 126, 122, 1);
                yield return new ICU(66, 277, 1, 82, 3, 0, 0, 135, 70, 0);
                yield return new ICU(67, 278, 1, 73, 3, 0, 0, 170, 88, 0);
                yield return new ICU(68, 282, 1, 70, 3, 0, 0, 86, 153, 1);
                yield return new ICU(69, 285, 0, 40, 1, 0, 1, 86, 80, 1);
                yield return new ICU(70, 292, 1, 61, 2, 0, 1, 68, 124, 1);
                yield return new ICU(71, 295, 1, 64, 2, 0, 1, 116, 88, 0);
                yield return new ICU(72, 297, 1, 47, 1, 0, 1, 120, 83, 0);
                yield return new ICU(73, 298, 1, 69, 2, 0, 0, 170, 100, 0);
                yield return new ICU(74, 299, 0, 75, 3, 0, 1, 90, 100, 1);
                yield return new ICU(75, 308, 1, 67, 2, 1, 1, 190, 125, 1);
                yield return new ICU(76, 310, 1, 18, 1, 0, 0, 156, 99, 0);
                yield return new ICU(77, 319, 1, 77, 3, 0, 1, 158, 107, 0);
                yield return new ICU(78, 327, 1, 32, 1, 0, 0, 120, 84, 1);
                yield return new ICU(79, 331, 0, 63, 2, 1, 1, 36, 86, 1);
                yield return new ICU(80, 333, 1, 19, 1, 1, 1, 104, 121, 0);
                yield return new ICU(81, 335, 1, 72, 3, 1, 0, 130, 86, 1);
                yield return new ICU(82, 343, 1, 49, 1, 0, 1, 112, 112, 1);
                yield return new ICU(83, 346, 0, 75, 3, 1, 0, 190, 94, 1);
                yield return new ICU(84, 357, 1, 68, 2, 1, 0, 154, 74, 0);
                yield return new ICU(85, 362, 1, 82, 3, 0, 1, 130, 131, 1);
                yield return new ICU(86, 365, 1, 32, 1, 1, 1, 110, 118, 1);
                yield return new ICU(87, 369, 1, 78, 3, 1, 1, 126, 96, 1);
                yield return new ICU(88, 370, 1, 57, 2, 0, 1, 128, 104, 1);
                yield return new ICU(89, 371, 1, 46, 1, 1, 0, 132, 90, 1);
                yield return new ICU(90, 376, 1, 23, 1, 0, 1, 144, 88, 1);
                yield return new ICU(91, 378, 1, 55, 2, 0, 0, 132, 112, 1);
                yield return new ICU(92, 379, 1, 18, 1, 0, 0, 112, 76, 1);
                yield return new ICU(93, 380, 0, 20, 1, 0, 0, 148, 72, 1);
                yield return new ICU(94, 381, 1, 20, 1, 0, 0, 164, 108, 1);
                yield return new ICU(95, 382, 1, 75, 3, 1, 0, 100, 48, 0);
                yield return new ICU(96, 384, 0, 71, 3, 0, 0, 142, 95, 1);
                yield return new ICU(97, 398, 1, 79, 3, 0, 1, 112, 67, 0);
                yield return new ICU(98, 401, 1, 40, 1, 0, 0, 140, 65, 1);
                yield return new ICU(99, 409, 1, 76, 3, 0, 1, 110, 70, 1);
                yield return new ICU(100, 412, 0, 51, 2, 1, 1, 134, 100, 1);
                yield return new ICU(101, 413, 1, 66, 2, 1, 1, 139, 92, 0);
                yield return new ICU(102, 416, 1, 76, 3, 0, 1, 190, 100, 1);
                yield return new ICU(103, 427, 0, 65, 2, 0, 0, 66, 94, 1);
                yield return new ICU(104, 438, 1, 80, 3, 1, 0, 162, 44, 1);
                yield return new ICU(105, 439, 1, 23, 1, 1, 1, 120, 88, 1);
                yield return new ICU(106, 440, 1, 48, 1, 0, 1, 92, 162, 1);
                yield return new ICU(107, 442, 0, 69, 2, 1, 0, 170, 60, 1);
                yield return new ICU(108, 455, 1, 67, 2, 0, 0, 90, 92, 0);
                yield return new ICU(109, 461, 0, 55, 2, 0, 1, 122, 100, 1);
                yield return new ICU(110, 462, 1, 69, 2, 1, 0, 150, 85, 1);
                yield return new ICU(111, 468, 0, 50, 2, 1, 0, 120, 96, 1);
                yield return new ICU(112, 490, 0, 78, 3, 0, 1, 110, 81, 1);
                yield return new ICU(113, 495, 1, 65, 2, 0, 0, 208, 124, 0);
                yield return new ICU(114, 498, 1, 72, 3, 0, 0, 126, 88, 0);
                yield return new ICU(115, 502, 1, 55, 2, 0, 0, 190, 136, 1);
                yield return new ICU(116, 505, 1, 40, 1, 0, 0, 130, 65, 1);
                yield return new ICU(117, 508, 1, 55, 2, 1, 1, 110, 86, 1);
                yield return new ICU(118, 517, 1, 34, 1, 0, 0, 110, 80, 1);
                yield return new ICU(119, 518, 0, 71, 3, 1, 0, 70, 112, 1);
                yield return new ICU(120, 522, 1, 47, 1, 1, 0, 132, 68, 1);
                yield return new ICU(121, 525, 1, 41, 1, 1, 1, 118, 145, 1);
                yield return new ICU(122, 526, 1, 84, 3, 1, 1, 100, 103, 1);
                yield return new ICU(123, 546, 1, 88, 3, 1, 0, 110, 46, 0);
                yield return new ICU(124, 548, 1, 77, 3, 1, 0, 212, 87, 0);
                yield return new ICU(125, 550, 1, 80, 3, 0, 0, 122, 126, 1);
                yield return new ICU(126, 552, 1, 16, 1, 0, 0, 100, 140, 1);
                yield return new ICU(127, 560, 1, 70, 3, 0, 0, 160, 60, 0);
                yield return new ICU(128, 563, 1, 83, 3, 1, 1, 138, 91, 1);
                yield return new ICU(129, 573, 1, 23, 1, 0, 0, 130, 52, 1);
                yield return new ICU(130, 575, 1, 67, 2, 1, 0, 120, 120, 1);
                yield return new ICU(131, 584, 1, 18, 1, 0, 0, 130, 140, 0);
                yield return new ICU(132, 597, 1, 77, 3, 1, 1, 136, 138, 0);
                yield return new ICU(133, 598, 1, 48, 1, 1, 0, 128, 96, 1);
                yield return new ICU(134, 601, 1, 24, 1, 1, 0, 140, 86, 1);
                yield return new ICU(135, 605, 1, 71, 3, 1, 1, 124, 106, 1);
                yield return new ICU(136, 607, 1, 72, 3, 0, 0, 134, 60, 1);
                yield return new ICU(137, 611, 0, 85, 3, 1, 0, 136, 96, 1);
                yield return new ICU(138, 613, 0, 75, 3, 0, 1, 130, 119, 1);
                yield return new ICU(139, 619, 1, 77, 3, 1, 0, 170, 115, 0);
                yield return new ICU(140, 620, 1, 60, 2, 0, 1, 124, 135, 1);
                yield return new ICU(141, 639, 1, 46, 1, 0, 0, 110, 128, 0);
                yield return new ICU(142, 644, 1, 65, 2, 1, 0, 100, 105, 1);
                yield return new ICU(143, 645, 1, 36, 1, 0, 0, 224, 125, 1);
                yield return new ICU(144, 648, 1, 68, 2, 0, 0, 112, 64, 0);
                yield return new ICU(145, 655, 1, 58, 2, 0, 0, 154, 98, 1);
                yield return new ICU(146, 659, 1, 76, 3, 1, 1, 92, 112, 1);
                yield return new ICU(147, 666, 0, 65, 2, 1, 1, 104, 150, 1);
                yield return new ICU(148, 669, 1, 41, 1, 1, 0, 110, 144, 1);
                yield return new ICU(149, 670, 1, 20, 1, 0, 0, 120, 68, 1);
                yield return new ICU(150, 671, 0, 49, 1, 0, 1, 140, 108, 1);
                yield return new ICU(151, 674, 1, 91, 3, 0, 1, 152, 125, 1);
                yield return new ICU(152, 675, 1, 75, 3, 0, 0, 140, 90, 1);
                yield return new ICU(153, 676, 1, 25, 1, 1, 0, 131, 135, 1);
                yield return new ICU(154, 706, 0, 75, 3, 1, 1, 150, 66, 1);
                yield return new ICU(155, 709, 1, 70, 3, 0, 1, 78, 143, 1);
                yield return new ICU(156, 713, 1, 47, 1, 0, 0, 156, 112, 1);
                yield return new ICU(157, 727, 1, 75, 3, 0, 0, 144, 120, 1);
                yield return new ICU(158, 728, 1, 40, 1, 0, 1, 160, 150, 1);
                yield return new ICU(159, 732, 1, 71, 3, 0, 1, 148, 192, 1);
                yield return new ICU(160, 740, 0, 72, 3, 1, 0, 90, 160, 1);
                yield return new ICU(161, 746, 1, 70, 3, 1, 1, 90, 140, 1);
                yield return new ICU(162, 749, 1, 58, 2, 0, 0, 148, 95, 1);
                yield return new ICU(163, 751, 0, 69, 2, 0, 0, 80, 81, 1);
                yield return new ICU(164, 752, 0, 64, 2, 0, 1, 80, 118, 1);
                yield return new ICU(165, 754, 1, 54, 2, 0, 0, 136, 80, 0);
                yield return new ICU(166, 761, 1, 77, 3, 0, 0, 128, 59, 0);
                yield return new ICU(167, 763, 1, 55, 2, 0, 1, 138, 140, 0);
                yield return new ICU(168, 764, 1, 21, 1, 0, 0, 120, 62, 1);
                yield return new ICU(169, 765, 1, 53, 2, 0, 0, 170, 115, 1);
                yield return new ICU(170, 766, 1, 31, 1, 1, 1, 146, 100, 1);
                yield return new ICU(171, 772, 1, 71, 3, 0, 0, 204, 52, 0);
                yield return new ICU(172, 776, 1, 49, 1, 0, 0, 150, 100, 1);
                yield return new ICU(173, 784, 1, 60, 2, 1, 1, 116, 92, 1);
                yield return new ICU(174, 789, 0, 60, 2, 0, 1, 56, 114, 1);
                yield return new ICU(175, 794, 1, 50, 2, 0, 1, 156, 99, 1);
                yield return new ICU(176, 796, 1, 45, 1, 1, 0, 132, 109, 1);
                yield return new ICU(177, 809, 1, 21, 1, 0, 0, 110, 90, 1);
                yield return new ICU(178, 814, 1, 73, 3, 1, 0, 130, 83, 1);
                yield return new ICU(179, 816, 1, 28, 1, 0, 1, 122, 80, 0);
                yield return new ICU(180, 829, 1, 17, 1, 0, 0, 140, 78, 1);
                yield return new ICU(181, 837, 1, 17, 1, 1, 0, 130, 140, 1);
                yield return new ICU(182, 846, 1, 21, 1, 1, 0, 142, 79, 1);
                yield return new ICU(183, 847, 1, 68, 2, 1, 0, 91, 79, 0);
                yield return new ICU(184, 863, 1, 17, 1, 0, 0, 136, 78, 1);
                yield return new ICU(185, 867, 1, 60, 2, 0, 1, 108, 120, 1);
                yield return new ICU(186, 871, 0, 60, 2, 0, 1, 130, 55, 1);
                yield return new ICU(187, 875, 1, 69, 2, 0, 0, 169, 73, 1);
                yield return new ICU(188, 877, 1, 88, 3, 1, 0, 190, 88, 1);
                yield return new ICU(189, 880, 1, 20, 1, 0, 0, 120, 80, 1);
                yield return new ICU(190, 881, 1, 89, 3, 1, 0, 190, 114, 1);
                yield return new ICU(191, 889, 1, 62, 2, 1, 0, 110, 78, 1);
                yield return new ICU(192, 893, 1, 46, 1, 0, 1, 142, 89, 1);
                yield return new ICU(193, 906, 1, 19, 1, 0, 1, 100, 137, 1);
                yield return new ICU(194, 912, 1, 71, 3, 0, 1, 124, 124, 1);
                yield return new ICU(195, 915, 1, 67, 2, 0, 0, 152, 78, 0);
                yield return new ICU(196, 921, 0, 50, 2, 1, 0, 256, 64, 1);
                yield return new ICU(197, 923, 1, 20, 1, 0, 0, 104, 83, 1);
                yield return new ICU(198, 924, 1, 73, 3, 1, 0, 162, 100, 1);
                yield return new ICU(199, 925, 1, 59, 2, 0, 0, 100, 88, 1);
                yield return new ICU(200, 929, 1, 42, 1, 0, 0, 122, 84, 1);
            }
        }
    }
}
