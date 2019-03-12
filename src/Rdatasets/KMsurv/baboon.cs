// ReSharper disable All

namespace Rdatasets.KMsurv
{
    using System.Collections.Generic;

    /// <summary>
    /// data from Exercise 5.8, p147
    /// </summary>

    public class baboon
    {
        public readonly int κ;
        public readonly string date;
        public readonly int time;
        public readonly int observed;

        public baboon(int κ, string date, int time, int observed)
        {
            this.κ = κ;
            this.date = date;
            this.time = time;
            this.observed = observed;
        }

        public static IEnumerable<baboon> Data
        {
            get
            {
                yield return new baboon(1, "25/11/63", 656, 1);
                yield return new baboon(2, "29/10/63", 659, 1);
                yield return new baboon(3, "5/11/63", 720, 1);
                yield return new baboon(4, "12/2/64", 721, 1);
                yield return new baboon(5, "29/3/64", 743, 1);
                yield return new baboon(6, "14/2/64", 747, 1);
                yield return new baboon(7, "18/2/64", 750, 1);
                yield return new baboon(8, "1/4/64", 751, 1);
                yield return new baboon(9, "8/2/64", 754, 1);
                yield return new baboon(10, "26/5/64", 758, 1);
                yield return new baboon(11, "19/2/64", 805, 1);
                yield return new baboon(12, "7/6/64", 808, 1);
                yield return new baboon(13, "22/6/64", 810, 1);
                yield return new baboon(14, "24/5/64", 811, 1);
                yield return new baboon(15, "21/2/64", 815, 1);
                yield return new baboon(16, "13/2/64", 815, 1);
                yield return new baboon(17, "11/6/64", 820, 1);
                yield return new baboon(18, "21/6/64", 820, 1);
                yield return new baboon(19, "13/3/64", 825, 1);
                yield return new baboon(20, "12/7/64", 827, 1);
                yield return new baboon(21, "30/6/64", 828, 1);
                yield return new baboon(22, "5/5/64", 831, 1);
                yield return new baboon(23, "12/5/64", 832, 1);
                yield return new baboon(24, "25/4/64", 832, 1);
                yield return new baboon(25, "26/3/64", 833, 1);
                yield return new baboon(26, "18/3/64", 836, 1);
                yield return new baboon(27, "15/3/64", 840, 1);
                yield return new baboon(28, "6/3/64", 842, 1);
                yield return new baboon(29, "11/5/64", 844, 1);
                yield return new baboon(30, "5/6/64", 844, 1);
                yield return new baboon(31, "17/7/64", 845, 1);
                yield return new baboon(32, "12/6/64", 846, 1);
                yield return new baboon(33, "28/2/64", 848, 1);
                yield return new baboon(34, "14/5/64", 850, 1);
                yield return new baboon(35, "7/7/64", 855, 1);
                yield return new baboon(36, "6/7/64", 858, 1);
                yield return new baboon(37, "2/7/64", 858, 1);
                yield return new baboon(38, "17/3/64", 859, 1);
                yield return new baboon(39, "10/6/64", 859, 1);
                yield return new baboon(40, "11/3/64", 900, 1);
                yield return new baboon(41, "23/7/64", 904, 1);
                yield return new baboon(42, "27/2/64", 905, 1);
                yield return new baboon(43, "31/3/64", 905, 1);
                yield return new baboon(44, "10/4/64", 907, 1);
                yield return new baboon(45, "22/4/64", 908, 1);
                yield return new baboon(46, "7/3/64", 910, 1);
                yield return new baboon(47, "29/2/64", 910, 1);
                yield return new baboon(48, "13/5/64", 915, 1);
                yield return new baboon(49, "20/4/64", 920, 1);
                yield return new baboon(50, "27/4/64", 930, 1);
                yield return new baboon(51, "28/4/64", 930, 1);
                yield return new baboon(52, "23/4/64", 932, 1);
                yield return new baboon(53, "4/3/64", 935, 1);
                yield return new baboon(54, "6/5/64", 935, 1);
                yield return new baboon(55, "26/6/64", 945, 1);
                yield return new baboon(56, "25/3/64", 948, 1);
                yield return new baboon(57, "8/7/64", 952, 1);
                yield return new baboon(58, "21/4/64", 1027, 1);
                yield return new baboon(59, "1/12/63", 705, 0);
                yield return new baboon(60, "6/11/63", 710, 0);
                yield return new baboon(61, "24/10/63", 715, 0);
                yield return new baboon(62, "26/11/63", 720, 0);
                yield return new baboon(63, "18/10/63", 720, 0);
                yield return new baboon(64, "7/5/64", 730, 0);
                yield return new baboon(65, "7/11/63", 740, 0);
                yield return new baboon(66, "23/11/63", 750, 0);
                yield return new baboon(67, "28/11/63", 750, 0);
                yield return new baboon(68, "27/11/63", 753, 0);
                yield return new baboon(69, "28/5/64", 755, 0);
                yield return new baboon(70, "5/7/64", 757, 0);
                yield return new baboon(71, "28/3/64", 800, 0);
                yield return new baboon(72, "23/3/64", 805, 0);
                yield return new baboon(73, "26/10/63", 805, 0);
                yield return new baboon(74, "11/7/64", 805, 0);
                yield return new baboon(75, "27/7/64", 807, 0);
                yield return new baboon(76, "9/6/64", 810, 0);
                yield return new baboon(77, "24/6/64", 812, 0);
                yield return new baboon(78, "16/10/63", 812, 0);
                yield return new baboon(79, "25/2/64", 813, 0);
                yield return new baboon(80, "6/6/64", 814, 0);
                yield return new baboon(81, "22/11/63", 815, 0);
                yield return new baboon(82, "10/10/63", 815, 0);
                yield return new baboon(83, "2/11/63", 815, 0);
                yield return new baboon(84, "23/6/64", 817, 0);
                yield return new baboon(85, "24/4/64", 823, 0);
                yield return new baboon(86, "3/7/64", 830, 0);
                yield return new baboon(87, "29/4/64", 831, 0);
                yield return new baboon(88, "4/8/63", 838, 0);
                yield return new baboon(89, "7/10/63", 840, 0);
                yield return new baboon(90, "13/10/63", 840, 0);
                yield return new baboon(91, "4/7/64", 845, 0);
                yield return new baboon(92, "3/5/64", 850, 0);
                yield return new baboon(93, "25/5/64", 851, 0);
                yield return new baboon(94, "24/11/63", 853, 0);
                yield return new baboon(95, "15/7/64", 855, 0);
                yield return new baboon(96, "16/2/64", 856, 0);
                yield return new baboon(97, "10/3/64", 857, 0);
                yield return new baboon(98, "28/7/64", 858, 0);
                yield return new baboon(99, "18/6/64", 858, 0);
                yield return new baboon(100, "20/2/64", 858, 0);
                yield return new baboon(101, "2/8/64", 859, 0);
                yield return new baboon(102, "27/5/64", 900, 0);
                yield return new baboon(103, "28/10/64", 905, 0);
                yield return new baboon(104, "15/5/64", 907, 0);
                yield return new baboon(105, "10/5/64", 908, 0);
                yield return new baboon(106, "27/6/64", 915, 0);
                yield return new baboon(107, "11/10/63", 915, 0);
                yield return new baboon(108, "17/2/64", 920, 0);
                yield return new baboon(109, "22/10/63", 920, 0);
                yield return new baboon(110, "10/7/64", 925, 0);
                yield return new baboon(111, "14/7/64", 926, 0);
                yield return new baboon(112, "11/4/64", 931, 0);
                yield return new baboon(113, "23/5/64", 933, 0);
                yield return new baboon(114, "30/7/64", 943, 0);
                yield return new baboon(115, "18/7/64", 945, 0);
                yield return new baboon(116, "29/7/64", 946, 0);
                yield return new baboon(117, "16/7/64", 950, 0);
                yield return new baboon(118, "22/7/64", 955, 0);
                yield return new baboon(119, "15/10/63", 955, 0);
                yield return new baboon(120, "19/10/63", 1005, 0);
                yield return new baboon(121, "2/5/64", 1012, 0);
                yield return new baboon(122, "1/3/64", 1018, 0);
                yield return new baboon(123, "17/10/63", 1020, 0);
                yield return new baboon(124, "23/10/63", 1020, 0);
                yield return new baboon(125, "25/7/64", 1020, 0);
                yield return new baboon(126, "13/7/64", 1031, 0);
                yield return new baboon(127, "8/6/64", 1050, 0);
                yield return new baboon(128, "9/3/64", 1050, 0);
                yield return new baboon(129, "26/4/64", 1100, 0);
                yield return new baboon(130, "14/10/63", 1205, 0);
                yield return new baboon(131, "18/11/63", 1245, 0);
                yield return new baboon(132, "2/3/64", 1250, 0);
                yield return new baboon(133, "8/5/64", 1405, 0);
                yield return new baboon(134, "1/7/64", 1407, 0);
                yield return new baboon(135, "12/10/63", 1500, 0);
                yield return new baboon(136, "31/7/64", 1531, 0);
                yield return new baboon(137, "6/10/63", 1535, 0);
                yield return new baboon(138, "19/6/64", 1556, 0);
                yield return new baboon(139, "29/6/64", 1603, 0);
                yield return new baboon(140, "9/5/64", 1605, 0);
                yield return new baboon(141, "9/10/63", 1625, 0);
                yield return new baboon(142, "8/3/64", 1625, 0);
                yield return new baboon(143, "11/2/64", 1653, 0);
                yield return new baboon(144, "30/5/64", 1705, 0);
                yield return new baboon(145, "5/3/64", 1708, 0);
                yield return new baboon(146, "26/2/64", 1722, 0);
                yield return new baboon(147, "4/5/64", 1728, 0);
                yield return new baboon(148, "12/3/64", 1730, 0);
                yield return new baboon(149, "25/10/63", 1730, 0);
                yield return new baboon(150, "29/11/63", 1750, 0);
                yield return new baboon(151, "22/2/64", 1801, 0);
                yield return new baboon(152, "22/3/64", 1829, 0);
            }
        }
    }
}
