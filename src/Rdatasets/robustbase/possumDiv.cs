// ReSharper disable All

namespace Rdatasets.robustbase
{
    using System.Collections.Generic;

    /// <summary>
    /// Possum Diversity Data
    /// </summary>

    public class possumDiv
    {
        public readonly int κ;
        public readonly int Diversity;
        public readonly int Shrubs;
        public readonly int Stumps;
        public readonly int Stags;
        public readonly int Bark;
        public readonly int Habitat;
        public readonly int BAcacia;
        public readonly string eucalyptus;
        public readonly string aspect;

        public possumDiv(int κ, int Diversity, int Shrubs, int Stumps, int Stags, int Bark, int Habitat, int BAcacia, string eucalyptus, string aspect)
        {
            this.κ = κ;
            this.Diversity = Diversity;
            this.Shrubs = Shrubs;
            this.Stumps = Stumps;
            this.Stags = Stags;
            this.Bark = Bark;
            this.Habitat = Habitat;
            this.BAcacia = BAcacia;
            this.eucalyptus = eucalyptus;
            this.aspect = aspect;
        }

        public static IEnumerable<possumDiv> Data
        {
            get
            {
                yield return new possumDiv(1, 3, 6, 1, 12, 29, 9, 31, "regnans", "SW-NW");
                yield return new possumDiv(2, 2, 5, 0, 15, 12, 2, 4, "regnans", "SE-SW");
                yield return new possumDiv(3, 1, 7, 0, 6, 26, 2, 8, "regnans", "NW-NE");
                yield return new possumDiv(4, 2, 6, 0, 14, 16, 8, 16, "regnans", "SW-NW");
                yield return new possumDiv(5, 3, 5, 0, 16, 11, 8, 20, "delegatensis", "SE-SW");
                yield return new possumDiv(6, 2, 3, 0, 16, 6, 10, 31, "regnans", "NW-SE");
                yield return new possumDiv(7, 3, 6, 0, 9, 10, 8, 16, "delegatensis", "SW-NW");
                yield return new possumDiv(8, 2, 13, 0, 20, 4, 8, 17, "regnans", "SE-SW");
                yield return new possumDiv(9, 0, 5, 0, 7, 13, 3, 0, "regnans", "SW-NW");
                yield return new possumDiv(10, 0, 8, 0, 4, 9, 1, 8, "regnans", "SE-SW");
                yield return new possumDiv(11, 1, 11, 1, 6, 3, 2, 8, "regnans", "SE-SW");
                yield return new possumDiv(12, 1, 16, 0, 5, 3, 6, 9, "regnans", "SW-NW");
                yield return new possumDiv(13, 0, 8, 0, 4, 11, 1, 11, "delegatensis", "NW-NE");
                yield return new possumDiv(14, 4, 9, 0, 6, 14, 7, 0, "regnans", "SE-SW");
                yield return new possumDiv(15, 2, 4, 0, 4, 8, 1, 25, "regnans", "NW-SE");
                yield return new possumDiv(16, 3, 9, 0, 10, 13, 7, 16, "regnans", "SE-SW");
                yield return new possumDiv(17, 1, 11, 0, 6, 17, 1, 7, "regnans", "SW-NW");
                yield return new possumDiv(18, 3, 8, 0, 11, 8, 9, 23, "regnans", "NW-SE");
                yield return new possumDiv(19, 3, 4, 0, 11, 7, 8, 19, "regnans", "NW-SE");
                yield return new possumDiv(20, 1, 8, 0, 4, 12, 9, 13, "regnans", "NW-SE");
                yield return new possumDiv(21, 2, 1, 0, 16, 5, 10, 21, "regnans", "SE-SW");
                yield return new possumDiv(22, 2, 3, 1, 8, 9, 8, 23, "delegatensis", "SE-SW");
                yield return new possumDiv(23, 2, 3, 0, 10, 15, 1, 0, "delegatensis", "NW-NE");
                yield return new possumDiv(24, 3, 5, 0, 9, 16, 2, 16, "delegatensis", "NW-SE");
                yield return new possumDiv(25, 4, 3, 0, 7, 16, 8, 20, "nitens", "NW-SE");
                yield return new possumDiv(26, 2, 4, 0, 10, 14, 2, 5, "delegatensis", "NW-SE");
                yield return new possumDiv(27, 1, 5, 0, 15, 18, 0, 1, "regnans", "SE-SW");
                yield return new possumDiv(28, 1, 2, 0, 5, 4, 9, 33, "delegatensis", "SE-SW");
                yield return new possumDiv(29, 2, 6, 0, 7, 22, 10, 3, "nitens", "NW-SE");
                yield return new possumDiv(30, 3, 1, 0, 10, 11, 2, 4, "regnans", "SE-SW");
                yield return new possumDiv(31, 3, 5, 0, 11, 11, 9, 17, "delegatensis", "SE-SW");
                yield return new possumDiv(32, 3, 3, 0, 8, 17, 7, 13, "regnans", "NW-SE");
                yield return new possumDiv(33, 2, 5, 0, 8, 9, 7, 13, "regnans", "SE-SW");
                yield return new possumDiv(34, 3, 21, 1, 3, 23, 4, 3, "regnans", "SE-SW");
                yield return new possumDiv(35, 4, 5, 0, 14, 9, 8, 12, "regnans", "SE-SW");
                yield return new possumDiv(36, 0, 3, 0, 5, 5, 4, 13, "regnans", "SE-SW");
                yield return new possumDiv(37, 2, 4, 0, 8, 6, 9, 20, "regnans", "NW-SE");
                yield return new possumDiv(38, 0, 3, 0, 14, 7, 8, 15, "regnans", "SW-NW");
                yield return new possumDiv(39, 2, 2, 0, 11, 9, 6, 15, "regnans", "NW-SE");
                yield return new possumDiv(40, 1, 6, 0, 2, 7, 6, 11, "regnans", "NW-SE");
                yield return new possumDiv(41, 0, 11, 0, 1, 7, 3, 11, "regnans", "NW-NE");
                yield return new possumDiv(42, 0, 11, 1, 1, 5, 1, 1, "regnans", "NW-SE");
                yield return new possumDiv(43, 3, 5, 0, 7, 8, 8, 27, "regnans", "NW-SE");
                yield return new possumDiv(44, 0, 5, 0, 2, 9, 2, 15, "regnans", "SE-SW");
                yield return new possumDiv(45, 2, 3, 0, 7, 5, 7, 15, "regnans", "NW-SE");
                yield return new possumDiv(46, 2, 5, 0, 7, 5, 5, 23, "regnans", "NW-SE");
                yield return new possumDiv(47, 1, 10, 0, 1, 11, 3, 17, "regnans", "SE-SW");
                yield return new possumDiv(48, 2, 15, 0, 6, 9, 3, 13, "regnans", "NW-SE");
                yield return new possumDiv(49, 1, 8, 0, 8, 5, 1, 9, "regnans", "NW-NE");
                yield return new possumDiv(50, 1, 5, 0, 6, 8, 3, 4, "regnans", "SW-NW");
                yield return new possumDiv(51, 2, 9, 0, 6, 7, 7, 16, "regnans", "NW-NE");
                yield return new possumDiv(52, 1, 7, 0, 5, 5, 1, 2, "regnans", "NW-SE");
                yield return new possumDiv(53, 1, 8, 0, 6, 9, 7, 22, "regnans", "NW-SE");
                yield return new possumDiv(54, 0, 3, 0, 0, 3, 1, 17, "regnans", "SE-SW");
                yield return new possumDiv(55, 1, 0, 0, 0, 6, 1, 12, "regnans", "NW-SE");
                yield return new possumDiv(56, 0, 11, 0, 2, 7, 4, 11, "regnans", "NW-NE");
                yield return new possumDiv(57, 0, 11, 1, 0, 10, 1, 3, "regnans", "SW-NW");
                yield return new possumDiv(58, 1, 10, 1, 1, 15, 2, 4, "regnans", "NW-NE");
                yield return new possumDiv(59, 3, 8, 0, 3, 8, 2, 7, "regnans", "SE-SW");
                yield return new possumDiv(60, 1, 6, 0, 2, 6, 2, 0, "regnans", "SE-SW");
                yield return new possumDiv(61, 1, 4, 0, 2, 4, 2, 3, "nitens", "NW-NE");
                yield return new possumDiv(62, 2, 2, 0, 6, 7, 7, 39, "regnans", "NW-NE");
                yield return new possumDiv(63, 1, 5, 0, 3, 7, 5, 11, "regnans", "NW-SE");
                yield return new possumDiv(64, 2, 2, 0, 4, 6, 6, 23, "delegatensis", "SW-NW");
                yield return new possumDiv(65, 3, 1, 0, 3, 6, 4, 28, "regnans", "NW-NE");
                yield return new possumDiv(66, 1, 8, 0, 4, 10, 7, 19, "regnans", "SE-SW");
                yield return new possumDiv(67, 0, 1, 0, 5, 6, 6, 17, "delegatensis", "NW-SE");
                yield return new possumDiv(68, 2, 1, 0, 2, 7, 5, 24, "delegatensis", "SE-SW");
                yield return new possumDiv(69, 1, 0, 0, 3, 5, 6, 20, "delegatensis", "NW-NE");
                yield return new possumDiv(70, 2, 2, 0, 4, 4, 8, 20, "delegatensis", "NW-NE");
                yield return new possumDiv(71, 1, 7, 0, 4, 5, 4, 5, "regnans", "NW-SE");
                yield return new possumDiv(72, 1, 5, 0, 2, 7, 3, 3, "regnans", "NW-NE");
                yield return new possumDiv(73, 1, 3, 0, 2, 8, 3, 19, "regnans", "SW-NW");
                yield return new possumDiv(74, 2, 0, 0, 10, 6, 7, 19, "regnans", "NW-NE");
                yield return new possumDiv(75, 5, 7, 0, 16, 14, 7, 19, "regnans", "SE-SW");
                yield return new possumDiv(76, 1, 3, 1, 10, 7, 8, 20, "regnans", "NW-NE");
                yield return new possumDiv(77, 1, 6, 0, 4, 12, 6, 16, "nitens", "SE-SW");
                yield return new possumDiv(78, 1, 0, 0, 3, 4, 3, 5, "regnans", "NW-SE");
                yield return new possumDiv(79, 1, 4, 0, 2, 7, 2, 3, "regnans", "NW-SE");
                yield return new possumDiv(80, 1, 8, 0, 2, 9, 3, 12, "regnans", "NW-NE");
                yield return new possumDiv(81, 0, 4, 0, 2, 8, 4, 11, "regnans", "SW-NW");
                yield return new possumDiv(82, 1, 5, 0, 2, 8, 3, 3, "regnans", "NW-SE");
                yield return new possumDiv(83, 1, 1, 0, 3, 4, 4, 17, "delegatensis", "NW-SE");
                yield return new possumDiv(84, 1, 6, 0, 1, 14, 4, 17, "regnans", "NW-SE");
                yield return new possumDiv(85, 0, 4, 1, 6, 12, 7, 16, "regnans", "SW-NW");
                yield return new possumDiv(86, 0, 8, 0, 8, 18, 5, 7, "regnans", "NW-SE");
                yield return new possumDiv(87, 0, 4, 0, 2, 5, 3, 0, "regnans", "NW-NE");
                yield return new possumDiv(88, 2, 2, 0, 4, 6, 2, 0, "nitens", "NW-SE");
                yield return new possumDiv(89, 3, 7, 0, 12, 5, 6, 4, "regnans", "SE-SW");
                yield return new possumDiv(90, 0, 7, 0, 13, 5, 6, 3, "regnans", "SE-SW");
                yield return new possumDiv(91, 2, 1, 0, 3, 7, 7, 21, "regnans", "NW-SE");
                yield return new possumDiv(92, 4, 2, 0, 14, 6, 9, 20, "regnans", "NW-NE");
                yield return new possumDiv(93, 2, 7, 0, 2, 5, 4, 7, "regnans", "NW-NE");
                yield return new possumDiv(94, 2, 1, 0, 4, 9, 6, 24, "regnans", "NW-SE");
                yield return new possumDiv(95, 0, 5, 0, 0, 9, 3, 21, "regnans", "SE-SW");
                yield return new possumDiv(96, 1, 0, 0, 2, 5, 3, 15, "regnans", "SE-SW");
                yield return new possumDiv(97, 0, 2, 0, 3, 5, 5, 13, "nitens", "SW-NW");
                yield return new possumDiv(98, 2, 1, 0, 14, 3, 7, 19, "delegatensis", "SE-SW");
                yield return new possumDiv(99, 2, 1, 0, 29, 6, 4, 1, "regnans", "NW-SE");
                yield return new possumDiv(100, 0, 0, 0, 2, 2, 3, 16, "regnans", "SE-SW");
                yield return new possumDiv(101, 0, 14, 0, 4, 0, 1, 0, "regnans", "SE-SW");
                yield return new possumDiv(102, 3, 0, 0, 6, 6, 6, 25, "regnans", "SE-SW");
                yield return new possumDiv(103, 1, 8, 0, 3, 9, 5, 16, "nitens", "NW-NE");
                yield return new possumDiv(104, 2, 3, 0, 8, 6, 5, 24, "regnans", "NW-SE");
                yield return new possumDiv(105, 1, 3, 0, 4, 5, 5, 13, "regnans", "NW-SE");
                yield return new possumDiv(106, 0, 4, 0, 7, 5, 2, 0, "regnans", "NW-NE");
                yield return new possumDiv(107, 3, 15, 0, 20, 18, 4, 0, "regnans", "NW-SE");
                yield return new possumDiv(108, 1, 0, 0, 4, 3, 3, 0, "delegatensis", "NW-NE");
                yield return new possumDiv(109, 0, 2, 0, 11, 3, 4, 1, "delegatensis", "NW-SE");
                yield return new possumDiv(110, 2, 2, 0, 5, 3, 2, 7, "delegatensis", "SW-NW");
                yield return new possumDiv(111, 1, 0, 0, 1, 3, 2, 1, "delegatensis", "SE-SW");
                yield return new possumDiv(112, 0, 1, 0, 2, 5, 4, 9, "delegatensis", "NW-SE");
                yield return new possumDiv(113, 2, 1, 0, 27, 7, 6, 7, "delegatensis", "SE-SW");
                yield return new possumDiv(114, 5, 9, 0, 24, 16, 8, 17, "regnans", "NW-NE");
                yield return new possumDiv(115, 2, 5, 0, 9, 10, 6, 20, "regnans", "NW-NE");
                yield return new possumDiv(116, 1, 10, 0, 18, 13, 6, 5, "regnans", "NW-NE");
                yield return new possumDiv(117, 2, 3, 0, 3, 5, 5, 15, "nitens", "NW-SE");
                yield return new possumDiv(118, 1, 2, 0, 20, 4, 7, 13, "regnans", "NW-NE");
                yield return new possumDiv(119, 4, 2, 0, 25, 8, 10, 23, "regnans", "SW-NW");
                yield return new possumDiv(120, 2, 0, 0, 4, 6, 7, 23, "regnans", "NW-NE");
                yield return new possumDiv(121, 0, 11, 0, 4, 4, 4, 5, "regnans", "NW-NE");
                yield return new possumDiv(122, 4, 12, 0, 30, 15, 8, 8, "regnans", "SW-NW");
                yield return new possumDiv(123, 5, 10, 0, 24, 9, 8, 4, "regnans", "SE-SW");
                yield return new possumDiv(124, 3, 7, 0, 8, 5, 5, 4, "nitens", "NW-SE");
                yield return new possumDiv(125, 0, 1, 1, 4, 7, 6, 16, "nitens", "SE-SW");
                yield return new possumDiv(126, 1, 3, 0, 6, 3, 4, 0, "delegatensis", "NW-SE");
                yield return new possumDiv(127, 0, 2, 0, 5, 4, 5, 9, "regnans", "NW-SE");
                yield return new possumDiv(128, 2, 3, 0, 3, 6, 5, 5, "nitens", "SE-SW");
                yield return new possumDiv(129, 0, 1, 0, 5, 4, 5, 4, "delegatensis", "SW-NW");
                yield return new possumDiv(130, 2, 1, 0, 2, 6, 6, 19, "regnans", "NW-NE");
                yield return new possumDiv(131, 0, 7, 0, 3, 5, 2, 0, "regnans", "NW-SE");
                yield return new possumDiv(132, 0, 3, 0, 5, 6, 6, 19, "nitens", "SW-NW");
                yield return new possumDiv(133, 2, 6, 0, 7, 5, 4, 4, "regnans", "SW-NW");
                yield return new possumDiv(134, 0, 2, 0, 4, 5, 6, 17, "regnans", "SE-SW");
                yield return new possumDiv(135, 0, 1, 0, 5, 3, 4, 8, "delegatensis", "SW-NW");
                yield return new possumDiv(136, 1, 3, 0, 4, 4, 6, 7, "delegatensis", "NW-NE");
                yield return new possumDiv(137, 0, 6, 0, 4, 7, 5, 4, "regnans", "SW-NW");
                yield return new possumDiv(138, 0, 11, 0, 1, 8, 1, 1, "regnans", "SE-SW");
                yield return new possumDiv(139, 3, 9, 0, 4, 5, 3, 0, "regnans", "SE-SW");
                yield return new possumDiv(140, 0, 1, 0, 23, 4, 6, 3, "delegatensis", "SW-NW");
                yield return new possumDiv(141, 3, 1, 0, 25, 4, 7, 15, "delegatensis", "SE-SW");
                yield return new possumDiv(142, 3, 6, 0, 31, 10, 8, 13, "regnans", "SW-NW");
                yield return new possumDiv(143, 1, 5, 0, 0, 4, 2, 23, "regnans", "NW-NE");
                yield return new possumDiv(144, 2, 8, 1, 8, 3, 7, 12, "regnans", "NW-SE");
                yield return new possumDiv(145, 0, 6, 0, 4, 5, 2, 0, "regnans", "SW-NW");
                yield return new possumDiv(146, 0, 2, 0, 4, 2, 1, 0, "regnans", "NW-NE");
                yield return new possumDiv(147, 1, 5, 1, 1, 0, 2, 0, "regnans", "NW-NE");
                yield return new possumDiv(148, 2, 4, 0, 3, 6, 6, 17, "regnans", "NW-NE");
                yield return new possumDiv(149, 1, 4, 1, 1, 5, 3, 25, "regnans", "NW-SE");
                yield return new possumDiv(150, 0, 5, 0, 1, 4, 2, 16, "delegatensis", "NW-SE");
                yield return new possumDiv(151, 0, 4, 0, 4, 6, 2, 0, "regnans", "SE-SW");
            }
        }
    }
}
