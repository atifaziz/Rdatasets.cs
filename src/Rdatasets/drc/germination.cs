// ReSharper disable All

namespace Rdatasets.drc
{
    using System.Collections.Generic;

    /// <summary>
    /// Germination of three crops
    /// </summary>

    public class germination
    {
        public readonly int κ;
        public readonly int temp;
        public readonly string species;
        public readonly int start;
        public readonly string end;
        public readonly int germinated;

        public germination(int κ, int temp, string species, int start, string end, int germinated)
        {
            this.κ = κ;
            this.temp = temp;
            this.species = species;
            this.start = start;
            this.end = end;
            this.germinated = germinated;
        }

        public static IEnumerable<germination> Data
        {
            get
            {
                yield return new germination(1, 10, "wheat", 0, "1", 0);
                yield return new germination(2, 10, "wheat", 1, "2", 0);
                yield return new germination(3, 10, "wheat", 2, "3", 0);
                yield return new germination(4, 10, "wheat", 3, "4", 0);
                yield return new germination(5, 10, "wheat", 4, "5", 0);
                yield return new germination(6, 10, "wheat", 5, "6", 4);
                yield return new germination(7, 10, "wheat", 6, "7", 6);
                yield return new germination(8, 10, "wheat", 7, "9", 8);
                yield return new germination(9, 10, "wheat", 9, "10", 0);
                yield return new germination(10, 10, "wheat", 10, "11", 0);
                yield return new germination(11, 10, "wheat", 11, "12", 0);
                yield return new germination(12, 10, "wheat", 12, "13", 0);
                yield return new germination(13, 10, "wheat", 13, "14", 0);
                yield return new germination(14, 10, "wheat", 14, "16", 0);
                yield return new germination(15, 10, "wheat", 16, "17", 0);
                yield return new germination(16, 10, "wheat", 17, "18", 0);
                yield return new germination(17, 10, "wheat", 18, "Inf", 2);
                yield return new germination(18, 10, "mungbean", 0, "2", 0);
                yield return new germination(19, 10, "mungbean", 2, "3", 4);
                yield return new germination(20, 10, "mungbean", 3, "4", 0);
                yield return new germination(21, 10, "mungbean", 4, "5", 0);
                yield return new germination(22, 10, "mungbean", 5, "6", 9);
                yield return new germination(23, 10, "mungbean", 6, "7", 7);
                yield return new germination(24, 10, "mungbean", 7, "Inf", 0);
                yield return new germination(25, 16, "wheat", 0, "2", 0);
                yield return new germination(26, 16, "wheat", 2, "3", 0);
                yield return new germination(27, 16, "wheat", 3, "4", 11);
                yield return new germination(28, 16, "wheat", 4, "5", 7);
                yield return new germination(29, 16, "wheat", 5, "6", 0);
                yield return new germination(30, 16, "wheat", 6, "7", 1);
                yield return new germination(31, 16, "wheat", 7, "9", 0);
                yield return new germination(32, 16, "wheat", 9, "10", 0);
                yield return new germination(33, 16, "wheat", 10, "11", 0);
                yield return new germination(34, 16, "wheat", 11, "12", 0);
                yield return new germination(35, 16, "wheat", 12, "13", 0);
                yield return new germination(36, 16, "wheat", 13, "14", 0);
                yield return new germination(37, 16, "wheat", 14, "16", 0);
                yield return new germination(38, 16, "wheat", 16, "17", 0);
                yield return new germination(39, 16, "wheat", 17, "18", 0);
                yield return new germination(40, 16, "wheat", 18, "Inf", 1);
                yield return new germination(41, 16, "rice", 0, "2", 0);
                yield return new germination(42, 16, "rice", 2, "3", 0);
                yield return new germination(43, 16, "rice", 3, "4", 0);
                yield return new germination(44, 16, "rice", 4, "5", 0);
                yield return new germination(45, 16, "rice", 5, "6", 0);
                yield return new germination(46, 16, "rice", 6, "7", 4);
                yield return new germination(47, 16, "rice", 7, "9", 4);
                yield return new germination(48, 16, "rice", 9, "10", 2);
                yield return new germination(49, 16, "rice", 10, "11", 0);
                yield return new germination(50, 16, "rice", 11, "12", 0);
                yield return new germination(51, 16, "rice", 12, "13", 0);
                yield return new germination(52, 16, "rice", 13, "16", 0);
                yield return new germination(53, 16, "rice", 16, "17", 0);
                yield return new germination(54, 16, "rice", 17, "18", 0);
                yield return new germination(55, 16, "rice", 18, "Inf", 10);
                yield return new germination(56, 16, "mungbean", 0, "1", 0);
                yield return new germination(57, 16, "mungbean", 1, "2", 1);
                yield return new germination(58, 16, "mungbean", 2, "3", 7);
                yield return new germination(59, 16, "mungbean", 3, "4", 12);
                yield return new germination(60, 16, "mungbean", 4, "5", 0);
                yield return new germination(61, 16, "mungbean", 5, "6", 0);
                yield return new germination(62, 16, "mungbean", 5, "Inf", 0);
                yield return new germination(63, 22, "wheat", 0, "2", 0);
                yield return new germination(64, 22, "wheat", 2, "3", 1);
                yield return new germination(65, 22, "wheat", 3, "4", 12);
                yield return new germination(66, 22, "wheat", 4, "5", 3);
                yield return new germination(67, 22, "wheat", 5, "6", 0);
                yield return new germination(68, 22, "wheat", 6, "7", 3);
                yield return new germination(69, 22, "wheat", 7, "9", 0);
                yield return new germination(70, 22, "wheat", 9, "10", 0);
                yield return new germination(71, 22, "wheat", 10, "11", 0);
                yield return new germination(72, 22, "wheat", 11, "12", 0);
                yield return new germination(73, 22, "wheat", 12, "13", 0);
                yield return new germination(74, 22, "wheat", 13, "14", 0);
                yield return new germination(75, 22, "wheat", 14, "16", 0);
                yield return new germination(76, 22, "wheat", 16, "17", 0);
                yield return new germination(77, 22, "wheat", 17, "18", 0);
                yield return new germination(78, 22, "wheat", 18, "Inf", 1);
                yield return new germination(79, 22, "rice", 0, "2", 0);
                yield return new germination(80, 22, "rice", 2, "3", 0);
                yield return new germination(81, 22, "rice", 3, "4", 5);
                yield return new germination(82, 22, "rice", 4, "5", 2);
                yield return new germination(83, 22, "rice", 5, "6", 0);
                yield return new germination(84, 22, "rice", 6, "7", 2);
                yield return new germination(85, 22, "rice", 7, "9", 0);
                yield return new germination(86, 22, "rice", 9, "10", 2);
                yield return new germination(87, 22, "rice", 10, "11", 0);
                yield return new germination(88, 22, "rice", 11, "12", 0);
                yield return new germination(89, 22, "rice", 12, "13", 0);
                yield return new germination(90, 22, "rice", 13, "15", 0);
                yield return new germination(91, 22, "rice", 15, "16", 0);
                yield return new germination(92, 22, "rice", 16, "17", 0);
                yield return new germination(93, 22, "rice", 17, "18", 0);
                yield return new germination(94, 22, "rice", 18, "Inf", 9);
                yield return new germination(95, 28, "wheat", 0, "1", 0);
                yield return new germination(96, 28, "wheat", 1, "2", 0);
                yield return new germination(97, 28, "wheat", 2, "3", 0);
                yield return new germination(98, 28, "wheat", 3, "4", 8);
                yield return new germination(99, 28, "wheat", 4, "5", 0);
                yield return new germination(100, 28, "wheat", 5, "6", 8);
                yield return new germination(101, 28, "wheat", 6, "7", 3);
                yield return new germination(102, 28, "wheat", 7, "9", 0);
                yield return new germination(103, 28, "wheat", 9, "10", 0);
                yield return new germination(104, 28, "wheat", 10, "11", 0);
                yield return new germination(105, 28, "wheat", 11, "12", 0);
                yield return new germination(106, 28, "wheat", 12, "13", 0);
                yield return new germination(107, 28, "wheat", 13, "14", 0);
                yield return new germination(108, 28, "wheat", 14, "16", 0);
                yield return new germination(109, 28, "wheat", 16, "17", 0);
                yield return new germination(110, 28, "wheat", 17, "18", 0);
                yield return new germination(111, 28, "wheat", 18, "Inf", 1);
                yield return new germination(112, 28, "rice", 0, "2", 0);
                yield return new germination(113, 28, "rice", 2, "3", 0);
                yield return new germination(114, 28, "rice", 3, "5", 17);
                yield return new germination(115, 28, "rice", 5, "6", 0);
                yield return new germination(116, 28, "rice", 6, "7", 0);
                yield return new germination(117, 28, "rice", 7, "9", 0);
                yield return new germination(118, 28, "rice", 9, "10", 1);
                yield return new germination(119, 28, "rice", 10, "11", 0);
                yield return new germination(120, 28, "rice", 11, "12", 0);
                yield return new germination(121, 28, "rice", 12, "13", 0);
                yield return new germination(122, 28, "rice", 13, "14", 0);
                yield return new germination(123, 28, "rice", 14, "16", 0);
                yield return new germination(124, 28, "rice", 16, "17", 0);
                yield return new germination(125, 28, "rice", 17, "18", 0);
                yield return new germination(126, 28, "rice", 18, "Inf", 2);
                yield return new germination(127, 34, "wheat", 0, "2", 0);
                yield return new germination(128, 34, "wheat", 2, "3", 5);
                yield return new germination(129, 34, "wheat", 3, "4", 11);
                yield return new germination(130, 34, "wheat", 4, "5", 1);
                yield return new germination(131, 34, "wheat", 5, "6", 1);
                yield return new germination(132, 34, "wheat", 6, "7", 0);
                yield return new germination(133, 34, "wheat", 7, "9", 0);
                yield return new germination(134, 34, "wheat", 9, "10", 0);
                yield return new germination(135, 34, "wheat", 10, "11", 0);
                yield return new germination(136, 34, "wheat", 11, "12", 1);
                yield return new germination(137, 34, "wheat", 12, "13", 0);
                yield return new germination(138, 34, "wheat", 13, "14", 0);
                yield return new germination(139, 34, "wheat", 14, "16", 0);
                yield return new germination(140, 34, "wheat", 16, "17", 0);
                yield return new germination(141, 34, "wheat", 17, "18", 0);
                yield return new germination(142, 34, "wheat", 18, "Inf", 1);
                yield return new germination(143, 34, "rice", 0, "2", 0);
                yield return new germination(144, 34, "rice", 2, "3", 1);
                yield return new germination(145, 34, "rice", 3, "4", 13);
                yield return new germination(146, 34, "rice", 4, "5", 1);
                yield return new germination(147, 34, "rice", 5, "6", 1);
                yield return new germination(148, 34, "rice", 6, "8", 0);
                yield return new germination(149, 34, "rice", 8, "9", 0);
                yield return new germination(150, 34, "rice", 9, "10", 1);
                yield return new germination(151, 34, "rice", 10, "11", 0);
                yield return new germination(152, 34, "rice", 11, "12", 0);
                yield return new germination(153, 34, "rice", 12, "13", 0);
                yield return new germination(154, 34, "rice", 13, "14", 0);
                yield return new germination(155, 34, "rice", 14, "16", 0);
                yield return new germination(156, 34, "rice", 16, "17", 0);
                yield return new germination(157, 34, "rice", 17, "18", 0);
                yield return new germination(158, 34, "rice", 18, "Inf", 3);
                yield return new germination(159, 40, "wheat", 0, "1", 0);
                yield return new germination(160, 40, "wheat", 1, "2", 0);
                yield return new germination(161, 40, "wheat", 2, "3", 0);
                yield return new germination(162, 40, "wheat", 3, "4", 0);
                yield return new germination(163, 40, "wheat", 4, "5", 0);
                yield return new germination(164, 40, "wheat", 5, "6", 0);
                yield return new germination(165, 40, "wheat", 6, "7", 0);
                yield return new germination(166, 40, "wheat", 7, "9", 0);
                yield return new germination(167, 40, "wheat", 9, "10", 1);
                yield return new germination(168, 40, "wheat", 10, "11", 2);
                yield return new germination(169, 40, "wheat", 11, "12", 0);
                yield return new germination(170, 40, "wheat", 12, "13", 0);
                yield return new germination(171, 40, "wheat", 13, "14", 0);
                yield return new germination(172, 40, "wheat", 14, "16", 0);
                yield return new germination(173, 40, "wheat", 16, "17", 0);
                yield return new germination(174, 40, "wheat", 17, "18", 0);
                yield return new germination(175, 40, "wheat", 18, "Inf", 17);
                yield return new germination(176, 40, "rice", 0, "1", 0);
                yield return new germination(177, 40, "rice", 1, "2", 0);
                yield return new germination(178, 40, "rice", 2, "3", 1);
                yield return new germination(179, 40, "rice", 3, "4", 6);
                yield return new germination(180, 40, "rice", 4, "5", 1);
                yield return new germination(181, 40, "rice", 5, "6", 0);
                yield return new germination(182, 40, "rice", 6, "7", 0);
                yield return new germination(183, 40, "rice", 7, "9", 0);
                yield return new germination(184, 40, "rice", 9, "10", 0);
                yield return new germination(185, 40, "rice", 10, "11", 0);
                yield return new germination(186, 40, "rice", 11, "12", 0);
                yield return new germination(187, 40, "rice", 12, "13", 0);
                yield return new germination(188, 40, "rice", 13, "14", 0);
                yield return new germination(189, 40, "rice", 14, "16", 0);
                yield return new germination(190, 40, "rice", 16, "17", 0);
                yield return new germination(191, 40, "rice", 17, "18", 0);
                yield return new germination(192, 40, "rice", 18, "Inf", 12);
            }
        }
    }
}
