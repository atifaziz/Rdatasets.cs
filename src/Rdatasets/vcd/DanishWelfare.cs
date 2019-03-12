// ReSharper disable All

namespace Rdatasets.vcd
{
    using System.Collections.Generic;

    /// <summary>
    /// Danish Welfare Study Data
    /// </summary>

    public class DanishWelfare
    {
        public readonly int κ;
        public readonly int Freq;
        public readonly string Alcohol;
        public readonly string Income;
        public readonly string Status;
        public readonly string Urban;

        public DanishWelfare(int κ, int Freq, string Alcohol, string Income, string Status, string Urban)
        {
            this.κ = κ;
            this.Freq = Freq;
            this.Alcohol = Alcohol;
            this.Income = Income;
            this.Status = Status;
            this.Urban = Urban;
        }

        public static IEnumerable<DanishWelfare> Data
        {
            get
            {
                yield return new DanishWelfare(1, 1, "<1", "0-50", "Widow", "Copenhagen");
                yield return new DanishWelfare(2, 4, "<1", "0-50", "Widow", "SubCopenhagen");
                yield return new DanishWelfare(3, 1, "<1", "0-50", "Widow", "LargeCity");
                yield return new DanishWelfare(4, 8, "<1", "0-50", "Widow", "City");
                yield return new DanishWelfare(5, 6, "<1", "0-50", "Widow", "Country");
                yield return new DanishWelfare(6, 14, "<1", "0-50", "Married", "Copenhagen");
                yield return new DanishWelfare(7, 8, "<1", "0-50", "Married", "SubCopenhagen");
                yield return new DanishWelfare(8, 41, "<1", "0-50", "Married", "LargeCity");
                yield return new DanishWelfare(9, 100, "<1", "0-50", "Married", "City");
                yield return new DanishWelfare(10, 175, "<1", "0-50", "Married", "Country");
                yield return new DanishWelfare(11, 6, "<1", "0-50", "Unmarried", "Copenhagen");
                yield return new DanishWelfare(12, 1, "<1", "0-50", "Unmarried", "SubCopenhagen");
                yield return new DanishWelfare(13, 2, "<1", "0-50", "Unmarried", "LargeCity");
                yield return new DanishWelfare(14, 6, "<1", "0-50", "Unmarried", "City");
                yield return new DanishWelfare(15, 9, "<1", "0-50", "Unmarried", "Country");
                yield return new DanishWelfare(16, 8, "<1", "50-100", "Widow", "Copenhagen");
                yield return new DanishWelfare(17, 2, "<1", "50-100", "Widow", "SubCopenhagen");
                yield return new DanishWelfare(18, 7, "<1", "50-100", "Widow", "LargeCity");
                yield return new DanishWelfare(19, 14, "<1", "50-100", "Widow", "City");
                yield return new DanishWelfare(20, 5, "<1", "50-100", "Widow", "Country");
                yield return new DanishWelfare(21, 42, "<1", "50-100", "Married", "Copenhagen");
                yield return new DanishWelfare(22, 51, "<1", "50-100", "Married", "SubCopenhagen");
                yield return new DanishWelfare(23, 62, "<1", "50-100", "Married", "LargeCity");
                yield return new DanishWelfare(24, 234, "<1", "50-100", "Married", "City");
                yield return new DanishWelfare(25, 255, "<1", "50-100", "Married", "Country");
                yield return new DanishWelfare(26, 7, "<1", "50-100", "Unmarried", "Copenhagen");
                yield return new DanishWelfare(27, 5, "<1", "50-100", "Unmarried", "SubCopenhagen");
                yield return new DanishWelfare(28, 9, "<1", "50-100", "Unmarried", "LargeCity");
                yield return new DanishWelfare(29, 20, "<1", "50-100", "Unmarried", "City");
                yield return new DanishWelfare(30, 27, "<1", "50-100", "Unmarried", "Country");
                yield return new DanishWelfare(31, 2, "<1", "100-150", "Widow", "Copenhagen");
                yield return new DanishWelfare(32, 3, "<1", "100-150", "Widow", "SubCopenhagen");
                yield return new DanishWelfare(33, 1, "<1", "100-150", "Widow", "LargeCity");
                yield return new DanishWelfare(34, 5, "<1", "100-150", "Widow", "City");
                yield return new DanishWelfare(35, 2, "<1", "100-150", "Widow", "Country");
                yield return new DanishWelfare(36, 21, "<1", "100-150", "Married", "Copenhagen");
                yield return new DanishWelfare(37, 30, "<1", "100-150", "Married", "SubCopenhagen");
                yield return new DanishWelfare(38, 23, "<1", "100-150", "Married", "LargeCity");
                yield return new DanishWelfare(39, 87, "<1", "100-150", "Married", "City");
                yield return new DanishWelfare(40, 77, "<1", "100-150", "Married", "Country");
                yield return new DanishWelfare(41, 3, "<1", "100-150", "Unmarried", "Copenhagen");
                yield return new DanishWelfare(42, 2, "<1", "100-150", "Unmarried", "SubCopenhagen");
                yield return new DanishWelfare(43, 1, "<1", "100-150", "Unmarried", "LargeCity");
                yield return new DanishWelfare(44, 12, "<1", "100-150", "Unmarried", "City");
                yield return new DanishWelfare(45, 4, "<1", "100-150", "Unmarried", "Country");
                yield return new DanishWelfare(46, 42, "<1", ">150", "Widow", "Copenhagen");
                yield return new DanishWelfare(47, 29, "<1", ">150", "Widow", "SubCopenhagen");
                yield return new DanishWelfare(48, 17, "<1", ">150", "Widow", "LargeCity");
                yield return new DanishWelfare(49, 95, "<1", ">150", "Widow", "City");
                yield return new DanishWelfare(50, 46, "<1", ">150", "Widow", "Country");
                yield return new DanishWelfare(51, 24, "<1", ">150", "Married", "Copenhagen");
                yield return new DanishWelfare(52, 30, "<1", ">150", "Married", "SubCopenhagen");
                yield return new DanishWelfare(53, 50, "<1", ">150", "Married", "LargeCity");
                yield return new DanishWelfare(54, 167, "<1", ">150", "Married", "City");
                yield return new DanishWelfare(55, 232, "<1", ">150", "Married", "Country");
                yield return new DanishWelfare(56, 33, "<1", ">150", "Unmarried", "Copenhagen");
                yield return new DanishWelfare(57, 24, "<1", ">150", "Unmarried", "SubCopenhagen");
                yield return new DanishWelfare(58, 15, "<1", ">150", "Unmarried", "LargeCity");
                yield return new DanishWelfare(59, 64, "<1", ">150", "Unmarried", "City");
                yield return new DanishWelfare(60, 68, "<1", ">150", "Unmarried", "Country");
                yield return new DanishWelfare(61, 3, "1-2", "0-50", "Widow", "Copenhagen");
                yield return new DanishWelfare(62, 0, "1-2", "0-50", "Widow", "SubCopenhagen");
                yield return new DanishWelfare(63, 1, "1-2", "0-50", "Widow", "LargeCity");
                yield return new DanishWelfare(64, 4, "1-2", "0-50", "Widow", "City");
                yield return new DanishWelfare(65, 2, "1-2", "0-50", "Widow", "Country");
                yield return new DanishWelfare(66, 15, "1-2", "0-50", "Married", "Copenhagen");
                yield return new DanishWelfare(67, 7, "1-2", "0-50", "Married", "SubCopenhagen");
                yield return new DanishWelfare(68, 15, "1-2", "0-50", "Married", "LargeCity");
                yield return new DanishWelfare(69, 25, "1-2", "0-50", "Married", "City");
                yield return new DanishWelfare(70, 48, "1-2", "0-50", "Married", "Country");
                yield return new DanishWelfare(71, 2, "1-2", "0-50", "Unmarried", "Copenhagen");
                yield return new DanishWelfare(72, 3, "1-2", "0-50", "Unmarried", "SubCopenhagen");
                yield return new DanishWelfare(73, 9, "1-2", "0-50", "Unmarried", "LargeCity");
                yield return new DanishWelfare(74, 9, "1-2", "0-50", "Unmarried", "City");
                yield return new DanishWelfare(75, 7, "1-2", "0-50", "Unmarried", "Country");
                yield return new DanishWelfare(76, 1, "1-2", "50-100", "Widow", "Copenhagen");
                yield return new DanishWelfare(77, 1, "1-2", "50-100", "Widow", "SubCopenhagen");
                yield return new DanishWelfare(78, 3, "1-2", "50-100", "Widow", "LargeCity");
                yield return new DanishWelfare(79, 8, "1-2", "50-100", "Widow", "City");
                yield return new DanishWelfare(80, 4, "1-2", "50-100", "Widow", "Country");
                yield return new DanishWelfare(81, 39, "1-2", "50-100", "Married", "Copenhagen");
                yield return new DanishWelfare(82, 59, "1-2", "50-100", "Married", "SubCopenhagen");
                yield return new DanishWelfare(83, 68, "1-2", "50-100", "Married", "LargeCity");
                yield return new DanishWelfare(84, 172, "1-2", "50-100", "Married", "City");
                yield return new DanishWelfare(85, 143, "1-2", "50-100", "Married", "Country");
                yield return new DanishWelfare(86, 12, "1-2", "50-100", "Unmarried", "Copenhagen");
                yield return new DanishWelfare(87, 3, "1-2", "50-100", "Unmarried", "SubCopenhagen");
                yield return new DanishWelfare(88, 11, "1-2", "50-100", "Unmarried", "LargeCity");
                yield return new DanishWelfare(89, 20, "1-2", "50-100", "Unmarried", "City");
                yield return new DanishWelfare(90, 23, "1-2", "50-100", "Unmarried", "Country");
                yield return new DanishWelfare(91, 5, "1-2", "100-150", "Widow", "Copenhagen");
                yield return new DanishWelfare(92, 4, "1-2", "100-150", "Widow", "SubCopenhagen");
                yield return new DanishWelfare(93, 1, "1-2", "100-150", "Widow", "LargeCity");
                yield return new DanishWelfare(94, 9, "1-2", "100-150", "Widow", "City");
                yield return new DanishWelfare(95, 4, "1-2", "100-150", "Widow", "Country");
                yield return new DanishWelfare(96, 32, "1-2", "100-150", "Married", "Copenhagen");
                yield return new DanishWelfare(97, 68, "1-2", "100-150", "Married", "SubCopenhagen");
                yield return new DanishWelfare(98, 43, "1-2", "100-150", "Married", "LargeCity");
                yield return new DanishWelfare(99, 128, "1-2", "100-150", "Married", "City");
                yield return new DanishWelfare(100, 86, "1-2", "100-150", "Married", "Country");
                yield return new DanishWelfare(101, 6, "1-2", "100-150", "Unmarried", "Copenhagen");
                yield return new DanishWelfare(102, 10, "1-2", "100-150", "Unmarried", "SubCopenhagen");
                yield return new DanishWelfare(103, 5, "1-2", "100-150", "Unmarried", "LargeCity");
                yield return new DanishWelfare(104, 21, "1-2", "100-150", "Unmarried", "City");
                yield return new DanishWelfare(105, 15, "1-2", "100-150", "Unmarried", "Country");
                yield return new DanishWelfare(106, 26, "1-2", ">150", "Widow", "Copenhagen");
                yield return new DanishWelfare(107, 34, "1-2", ">150", "Widow", "SubCopenhagen");
                yield return new DanishWelfare(108, 14, "1-2", ">150", "Widow", "LargeCity");
                yield return new DanishWelfare(109, 48, "1-2", ">150", "Widow", "City");
                yield return new DanishWelfare(110, 24, "1-2", ">150", "Widow", "Country");
                yield return new DanishWelfare(111, 43, "1-2", ">150", "Married", "Copenhagen");
                yield return new DanishWelfare(112, 76, "1-2", ">150", "Married", "SubCopenhagen");
                yield return new DanishWelfare(113, 70, "1-2", ">150", "Married", "LargeCity");
                yield return new DanishWelfare(114, 198, "1-2", ">150", "Married", "City");
                yield return new DanishWelfare(115, 136, "1-2", ">150", "Married", "Country");
                yield return new DanishWelfare(116, 36, "1-2", ">150", "Unmarried", "Copenhagen");
                yield return new DanishWelfare(117, 23, "1-2", ">150", "Unmarried", "SubCopenhagen");
                yield return new DanishWelfare(118, 48, "1-2", ">150", "Unmarried", "LargeCity");
                yield return new DanishWelfare(119, 89, "1-2", ">150", "Unmarried", "City");
                yield return new DanishWelfare(120, 64, "1-2", ">150", "Unmarried", "Country");
                yield return new DanishWelfare(121, 2, ">2", "0-50", "Widow", "Copenhagen");
                yield return new DanishWelfare(122, 0, ">2", "0-50", "Widow", "SubCopenhagen");
                yield return new DanishWelfare(123, 2, ">2", "0-50", "Widow", "LargeCity");
                yield return new DanishWelfare(124, 1, ">2", "0-50", "Widow", "City");
                yield return new DanishWelfare(125, 0, ">2", "0-50", "Widow", "Country");
                yield return new DanishWelfare(126, 1, ">2", "0-50", "Married", "Copenhagen");
                yield return new DanishWelfare(127, 2, ">2", "0-50", "Married", "SubCopenhagen");
                yield return new DanishWelfare(128, 2, ">2", "0-50", "Married", "LargeCity");
                yield return new DanishWelfare(129, 7, ">2", "0-50", "Married", "City");
                yield return new DanishWelfare(130, 7, ">2", "0-50", "Married", "Country");
                yield return new DanishWelfare(131, 3, ">2", "0-50", "Unmarried", "Copenhagen");
                yield return new DanishWelfare(132, 0, ">2", "0-50", "Unmarried", "SubCopenhagen");
                yield return new DanishWelfare(133, 1, ">2", "0-50", "Unmarried", "LargeCity");
                yield return new DanishWelfare(134, 5, ">2", "0-50", "Unmarried", "City");
                yield return new DanishWelfare(135, 1, ">2", "0-50", "Unmarried", "Country");
                yield return new DanishWelfare(136, 3, ">2", "50-100", "Widow", "Copenhagen");
                yield return new DanishWelfare(137, 0, ">2", "50-100", "Widow", "SubCopenhagen");
                yield return new DanishWelfare(138, 2, ">2", "50-100", "Widow", "LargeCity");
                yield return new DanishWelfare(139, 1, ">2", "50-100", "Widow", "City");
                yield return new DanishWelfare(140, 3, ">2", "50-100", "Widow", "Country");
                yield return new DanishWelfare(141, 14, ">2", "50-100", "Married", "Copenhagen");
                yield return new DanishWelfare(142, 21, ">2", "50-100", "Married", "SubCopenhagen");
                yield return new DanishWelfare(143, 14, ">2", "50-100", "Married", "LargeCity");
                yield return new DanishWelfare(144, 38, ">2", "50-100", "Married", "City");
                yield return new DanishWelfare(145, 35, ">2", "50-100", "Married", "Country");
                yield return new DanishWelfare(146, 2, ">2", "50-100", "Unmarried", "Copenhagen");
                yield return new DanishWelfare(147, 0, ">2", "50-100", "Unmarried", "SubCopenhagen");
                yield return new DanishWelfare(148, 3, ">2", "50-100", "Unmarried", "LargeCity");
                yield return new DanishWelfare(149, 12, ">2", "50-100", "Unmarried", "City");
                yield return new DanishWelfare(150, 13, ">2", "50-100", "Unmarried", "Country");
                yield return new DanishWelfare(151, 2, ">2", "100-150", "Widow", "Copenhagen");
                yield return new DanishWelfare(152, 1, ">2", "100-150", "Widow", "SubCopenhagen");
                yield return new DanishWelfare(153, 1, ">2", "100-150", "Widow", "LargeCity");
                yield return new DanishWelfare(154, 1, ">2", "100-150", "Widow", "City");
                yield return new DanishWelfare(155, 0, ">2", "100-150", "Widow", "Country");
                yield return new DanishWelfare(156, 20, ">2", "100-150", "Married", "Copenhagen");
                yield return new DanishWelfare(157, 31, ">2", "100-150", "Married", "SubCopenhagen");
                yield return new DanishWelfare(158, 10, ">2", "100-150", "Married", "LargeCity");
                yield return new DanishWelfare(159, 36, ">2", "100-150", "Married", "City");
                yield return new DanishWelfare(160, 21, ">2", "100-150", "Married", "Country");
                yield return new DanishWelfare(161, 0, ">2", "100-150", "Unmarried", "Copenhagen");
                yield return new DanishWelfare(162, 2, ">2", "100-150", "Unmarried", "SubCopenhagen");
                yield return new DanishWelfare(163, 3, ">2", "100-150", "Unmarried", "LargeCity");
                yield return new DanishWelfare(164, 9, ">2", "100-150", "Unmarried", "City");
                yield return new DanishWelfare(165, 7, ">2", "100-150", "Unmarried", "Country");
                yield return new DanishWelfare(166, 21, ">2", ">150", "Widow", "Copenhagen");
                yield return new DanishWelfare(167, 13, ">2", ">150", "Widow", "SubCopenhagen");
                yield return new DanishWelfare(168, 5, ">2", ">150", "Widow", "LargeCity");
                yield return new DanishWelfare(169, 20, ">2", ">150", "Widow", "City");
                yield return new DanishWelfare(170, 8, ">2", ">150", "Widow", "Country");
                yield return new DanishWelfare(171, 23, ">2", ">150", "Married", "Copenhagen");
                yield return new DanishWelfare(172, 47, ">2", ">150", "Married", "SubCopenhagen");
                yield return new DanishWelfare(173, 21, ">2", ">150", "Married", "LargeCity");
                yield return new DanishWelfare(174, 53, ">2", ">150", "Married", "City");
                yield return new DanishWelfare(175, 36, ">2", ">150", "Married", "Country");
                yield return new DanishWelfare(176, 38, ">2", ">150", "Unmarried", "Copenhagen");
                yield return new DanishWelfare(177, 20, ">2", ">150", "Unmarried", "SubCopenhagen");
                yield return new DanishWelfare(178, 13, ">2", ">150", "Unmarried", "LargeCity");
                yield return new DanishWelfare(179, 39, ">2", ">150", "Unmarried", "City");
                yield return new DanishWelfare(180, 26, ">2", ">150", "Unmarried", "Country");
            }
        }
    }
}
