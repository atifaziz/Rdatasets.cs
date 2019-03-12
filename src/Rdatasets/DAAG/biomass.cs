// ReSharper disable All

namespace Rdatasets.DAAG
{
    using System.Collections.Generic;

    /// <summary>
    /// Biomass Data
    /// </summary>

    public class biomass
    {
        public readonly int κ;
        public readonly int dbh;
        public readonly int? wood;
        public readonly int? bark;
        public readonly double? root;
        public readonly double? rootsk;
        public readonly int? branch;
        public readonly string species;
        public readonly string fac26;

        public biomass(int κ, int dbh, int? wood, int? bark, double? root, double? rootsk, int? branch, string species, string fac26)
        {
            this.κ = κ;
            this.dbh = dbh;
            this.wood = wood;
            this.bark = bark;
            this.root = root;
            this.rootsk = rootsk;
            this.branch = branch;
            this.species = species;
            this.fac26 = fac26;
        }

        public static IEnumerable<biomass> Data
        {
            get
            {
                yield return new biomass(1, 90, 5528, null, 460, null, null, "E. maculata", "z");
                yield return new biomass(2, 106, 13650, null, 1500, 665, null, "E. pilularis", "2");
                yield return new biomass(3, 112, 11200, null, 1100, 680, null, "E. pilularis", "2");
                yield return new biomass(4, 34, 1000, null, 430, 40, null, "E. pilularis", "2");
                yield return new biomass(5, 130, null, null, 3000, 1030, null, "E. maculata", "z");
                yield return new biomass(6, 86, 7027, null, 550, 290, 94, "E. botryoides", "z");
                yield return new biomass(7, 39, 1086, null, 220, 48, null, "E. maculata", "z");
                yield return new biomass(8, 50, null, null, 524, 74, null, "E. pilularis", "2");
                yield return new biomass(9, 30, null, null, 150, 27, null, "E. pilularis", "2");
                yield return new biomass(10, 39, null, null, 245, 28, null, "E. pilularis", "2");
                yield return new biomass(11, 103, 15396, 1800, 1400, 653, null, "E. pilularis", "2");
                yield return new biomass(12, 50, 3047, null, 240, 98, 83, "E. botryoides", "z");
                yield return new biomass(13, 110, 17841, null, 2000, 474, null, "E. pilularis", "2");
                yield return new biomass(14, 77, null, null, 600, 280, null, "E. pilularis", "2");
                yield return new biomass(15, 5, null, null, 7, 0.3, null, "E. pilularis", "2");
                yield return new biomass(16, 7, null, null, 6, 0.4, null, "E. pilularis", "2");
                yield return new biomass(17, 26, null, null, 85, 19, null, "E. pilularis", "2");
                yield return new biomass(18, 8, null, null, 6.2, 0.5, null, "E. pilularis", "2");
                yield return new biomass(19, 8, null, null, 7, 0.4, null, "E. pilularis", "2");
                yield return new biomass(20, 9, null, null, 10, 0.7, null, "E. pilularis", "2");
                yield return new biomass(21, 14, null, null, 25, 3.1, null, "E. pilularis", "2");
                yield return new biomass(22, 85, null, null, 1900, 317, null, "E. pilularis", "2");
                yield return new biomass(23, 6, null, null, 8, 0.2, null, "E. pilularis", "2");
                yield return new biomass(24, 24, null, null, 112, 14, null, "E. botryoides", "z");
                yield return new biomass(25, 46, null, null, 175, 63, null, "E. pilularis", "2");
                yield return new biomass(26, 28, null, null, 88, 30, null, "E. botryoides", "z");
                yield return new biomass(27, 6, null, null, 6, 0.3, null, "Acacia mabellae", "z");
                yield return new biomass(28, 4, null, null, 1.2, 0.07, null, "E. maculata", "z");
                yield return new biomass(29, 36, 1130, null, null, null, null, "E. pilularis", "2");
                yield return new biomass(30, 22, 440, null, null, null, null, "E. pilularis", "2");
                yield return new biomass(31, 54, 4082, null, null, null, 58, "E. maculata", "z");
                yield return new biomass(32, 37, 1387, null, 125, 27, 56, "E. botryoides", "z");
                yield return new biomass(33, 44, 2479, null, 135, 45, 97, "E. botryoides", "z");
                yield return new biomass(34, 17, 192, 59, null, null, 18, "E. pilularis", "2");
                yield return new biomass(35, 130, 25116, null, null, null, null, "E. maculata", "z");
                yield return new biomass(36, 13, 126, null, 30, 3, null, "E. pilularis", "2");
                yield return new biomass(37, 11, 98, null, 17, 2, null, "E. maculata", "z");
                yield return new biomass(38, 15, 190, null, 21, 9, 21, "E. maculata", "z");
                yield return new biomass(39, 15, 168, null, 26, 4.4, 17, "E. pilularis", "2");
                yield return new biomass(40, 12, 110, null, 18, 4, 16, "E. maculata", "z");
                yield return new biomass(41, 13, 170, null, null, null, 17, "E. pilularis", "2");
                yield return new biomass(42, 14, 151, null, null, null, 11, "E. maculata", "z");
                yield return new biomass(43, 16, 170, null, 24, 13, null, "E. pilularis", "2");
                yield return new biomass(44, 11, 81, null, 20, 2.2, null, "E. pilularis", "2");
                yield return new biomass(45, 60, 4220, 667, null, null, 274, "E. maculata", "z");
                yield return new biomass(46, 100, 16196, 1653, null, null, 371, "E. maculata", "z");
                yield return new biomass(47, 50, 2957, null, null, null, null, "E. botryoides", "z");
                yield return new biomass(48, 145, 22300, 1808, 2250, 977, null, "E. maculata", "z");
                yield return new biomass(49, 7, 13, null, null, null, null, "E. maculata", "z");
                yield return new biomass(50, 7, 17, null, null, null, null, "E. maculata", "z");
                yield return new biomass(51, 6, 11, null, null, null, null, "E. maculata", "z");
                yield return new biomass(52, 7, 16, null, null, null, null, "E. maculata", "z");
                yield return new biomass(53, 8, 20, 7, null, null, 7, "E. maculata", "z");
                yield return new biomass(54, 9, 31, null, null, null, null, "E. maculata", "z");
                yield return new biomass(55, 12, 60, 20, null, null, 11, "E. maculata", "");
                yield return new biomass(56, 4, 6, null, null, null, null, "E. maculata", "z");
                yield return new biomass(57, 5, 6, null, null, null, null, "E. maculata", "z");
                yield return new biomass(58, 7, 21, null, null, null, null, "E. maculata", "z");
                yield return new biomass(59, 4, 4, null, null, null, null, "E. maculata", "z");
                yield return new biomass(60, 4, 3, null, null, null, null, "E. maculata", "z");
                yield return new biomass(61, 23, 353, null, 135, 13, 35, "Acacia mabellae", "z");
                yield return new biomass(62, 20, 208, null, null, null, 41, "Acacia mabellae", "z");
                yield return new biomass(63, 23, 445, null, null, null, 50, "Acacia mabellae", "z");
                yield return new biomass(64, 54, 3300, null, null, null, 142, "E. maculata", "z");
                yield return new biomass(65, 24, 590, null, null, null, null, "Acacia mabellae", "z");
                yield return new biomass(66, 43, 2200, 328, null, null, 144, "E. maculata", "z");
                yield return new biomass(67, 41, 1575, null, null, null, 133, "E. maculata", "z");
                yield return new biomass(68, 55, 4350, 696, null, null, 151, "E. maculata", "z");
                yield return new biomass(69, 55, 3000, null, null, null, 279, "E. maculata", "z");
                yield return new biomass(70, 11, 74, null, 20, 1, 8, "E. pilularis", "2");
                yield return new biomass(71, 3, 3, null, 0.3, 0.05, null, "E. pilularis", "2");
                yield return new biomass(72, 10, 56, null, 20, 2, 8, "E. pilularis", "2");
                yield return new biomass(73, 4, 5, null, null, null, null, "E. pilularis", "2");
                yield return new biomass(74, 5, 15, null, null, null, null, "E. pilularis", "2");
                yield return new biomass(75, 7, 27, null, null, null, null, "E. pilularis", "2");
                yield return new biomass(76, 6, 12, null, null, null, null, "E. pilularis", "2");
                yield return new biomass(77, 8, 25, null, null, null, null, "E. pilularis", "2");
                yield return new biomass(78, 5, 8, null, null, null, null, "E. pilularis", "2");
                yield return new biomass(79, 8, 29, null, null, null, null, "E. pilularis", "2");
                yield return new biomass(80, 5, 14, null, 2, 2.4, null, "Acacia mabellae", "z");
                yield return new biomass(81, 5, 10, null, null, null, null, "Acacia mabellae", "z");
                yield return new biomass(82, 8, 31, null, null, null, null, "Acacia mabellae", "z");
                yield return new biomass(83, 10, 59, null, null, null, null, "Acacia mabellae", "z");
                yield return new biomass(84, 8, 30, null, 6, 1, 4, "Acacia mabellae", "z");
                yield return new biomass(85, 63, 5094, null, null, null, null, "E. pilularis", "2");
                yield return new biomass(86, 47, 2147, 456, null, null, 99, "E. pilularis", "2");
                yield return new biomass(87, 37, 1728, 229, null, null, 87, "E. pilularis", "2");
                yield return new biomass(88, 45, 1979, 397, null, null, 87, "E. pilularis", "2");
                yield return new biomass(89, 50, 2706, null, null, null, 105, "E. pilularis", "2");
                yield return new biomass(90, 50, 2638, 401, null, null, 112, "E. pilularis", "2");
                yield return new biomass(91, 8, 35, null, null, null, 9, "E. pilularis", "2");
                yield return new biomass(92, 9, 42, null, null, null, 10, "E. pilularis", "2");
                yield return new biomass(93, 9, 42, null, null, null, null, "E. pilularis", "2");
                yield return new biomass(94, 9, 42, null, null, null, 9, "E. pilularis", "2");
                yield return new biomass(95, 22, 320, null, 51, 17, 30, "Acacia mabellae", "z");
                yield return new biomass(96, 9, 20, null, 6, 1, 13, "Acacia mabellae", "z");
                yield return new biomass(97, 10, 29, null, null, null, 10, "Acacia mabellae", "z");
                yield return new biomass(98, 10, 35, null, 9, 2, 17, "Acacia mabellae", "z");
                yield return new biomass(99, 19, 203, null, 16, 11, 46, "Acacia mabellae", "z");
                yield return new biomass(100, 35, 1090, null, 66, 24, 92, "Acacia mabellae", "z");
                yield return new biomass(101, 18, null, null, 100, 9, null, "E. botryoides", "z");
                yield return new biomass(102, 6, 10, null, null, null, 11, "C. fraseri", "z");
                yield return new biomass(103, 4, 7, null, null, null, 6, "C. fraseri", "z");
                yield return new biomass(104, 4, 3, null, null, null, 5, "C. fraseri", "");
                yield return new biomass(105, 6, 13, null, null, null, 5, "C. fraseri", "z");
                yield return new biomass(106, 5, 9, null, null, null, 8, "C. fraseri", "z");
                yield return new biomass(107, 8, 20, null, null, null, 9, "C. fraseri", "");
                yield return new biomass(108, 6, 16, null, null, null, 6, "C. fraseri", "");
                yield return new biomass(109, 5, 7, null, null, null, 8, "C. fraseri", "z");
                yield return new biomass(110, 7, 29, null, null, null, 14, "C. fraseri", "z");
                yield return new biomass(111, 5, 12, null, null, null, 8, "C. fraseri", "");
                yield return new biomass(112, 7, 25, null, null, null, 16, "C. fraseri", "z");
                yield return new biomass(113, 6, 10, null, null, null, 9, "C. fraseri", "z");
                yield return new biomass(114, 25, 506, null, null, null, 45, "Acmena smithii", "6");
                yield return new biomass(115, 24, 508, null, null, null, 65, "Acmena smithii", "6");
                yield return new biomass(116, 31, 817, null, null, null, 95, "Acmena smithii", "6");
                yield return new biomass(117, 21, 274, null, null, null, 31, "Acmena smithii", "6");
                yield return new biomass(118, 16, 162, null, null, null, 25, "Acmena smithii", "6");
                yield return new biomass(119, 27, 540, null, null, null, 55, "Acmena smithii", "6");
                yield return new biomass(120, 19, 272, null, null, null, 52, "Acmena smithii", "6");
                yield return new biomass(121, 21, 293, null, null, null, null, "Acmena smithii", "6");
                yield return new biomass(122, 10, 77, null, null, null, null, "Acmena smithii", "6");
                yield return new biomass(123, 23, 408, null, null, null, null, "Acmena smithii", "6");
                yield return new biomass(124, 27, 550, 105, 44, 9, 59, "B. myrtifolia", "z");
                yield return new biomass(125, 26, 414, 78, 38, 13, 44, "B. myrtifolia", "z");
                yield return new biomass(126, 9, 42, 8, 5, 1.3, 7, "B. myrtifolia", "z");
                yield return new biomass(127, 12, 85, 13, 17, 2.2, 16, "B. myrtifolia", "z");
                yield return new biomass(128, 9, 35, null, null, null, 9, "B. myrtifolia", "z");
                yield return new biomass(129, 11, 60, null, null, null, 13, "B. myrtifolia", "z");
                yield return new biomass(130, 10, 60, null, null, null, 12, "B. myrtifolia", "z");
                yield return new biomass(131, 37, 1250, null, null, null, 76, "B. myrtifolia", "z");
                yield return new biomass(132, 37, 990, null, null, null, 90, "B. myrtifolia", "z");
                yield return new biomass(133, 20, 290, null, null, null, 36, "B. myrtifolia", "z");
                yield return new biomass(134, 56, 1500, null, null, null, null, "B. myrtifolia", "z");
                yield return new biomass(135, 9, 40, null, null, null, null, "Acmena smithii", "6");
                yield return new biomass(136, 17, 216, null, null, null, 40, "Acmena smithii", "6");
                yield return new biomass(137, 17, 208, null, null, null, null, "Acmena smithii", "6");
                yield return new biomass(138, 10, 50, null, null, null, null, "Acmena smithii", "6");
                yield return new biomass(139, 6, 18, null, null, null, null, "Acmena smithii", "6");
                yield return new biomass(140, 22, 382, null, null, null, null, "Acmena smithii", "6");
                yield return new biomass(141, 15, 161, null, null, null, null, "Acmena smithii", "6");
                yield return new biomass(142, 15, 140, null, null, null, null, "Acmena smithii", "6");
                yield return new biomass(143, 19, 280, null, null, null, null, "Acmena smithii", "6");
                yield return new biomass(144, 11, 84, null, null, null, null, "Acmena smithii", "6");
                yield return new biomass(145, 9, 50, null, null, null, null, "Acmena smithii", "6");
                yield return new biomass(146, 25, 510, null, null, null, 45, "Acmena smithii", "6");
                yield return new biomass(147, 22, 400, null, null, null, 35, "Acmena smithii", "6");
                yield return new biomass(148, 10, 70, null, null, null, null, "Acmena smithii", "6");
                yield return new biomass(149, 12, 115, null, null, null, null, "Acmena smithii", "6");
                yield return new biomass(150, 48, 1530, null, null, null, 120, "Acmena smithii", "6");
                yield return new biomass(151, 43, 1540, null, null, null, 60, "Other", "z");
                yield return new biomass(152, 35, 720, null, null, null, 60, "Other", "z");
                yield return new biomass(153, 29, 560, null, null, null, 42, "Other", "z");
            }
        }
    }
}
