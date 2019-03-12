// ReSharper disable All

namespace Rdatasets.gap
{
    using System.Collections.Generic;

    /// <summary>
    /// Friedreich Ataxia data
    /// </summary>

    public class fa
    {
        public readonly int κ;
        public readonly int y;
        public readonly int loci1;
        public readonly int loci2;
        public readonly int loci3;
        public readonly int loci4;
        public readonly int loci5;
        public readonly int loci6;
        public readonly int loci7;
        public readonly int loci8;
        public readonly int loci9;
        public readonly int loci10;
        public readonly int loci11;
        public readonly int loci12;

        public fa(int κ, int y, int loci1, int loci2, int loci3, int loci4, int loci5, int loci6, int loci7, int loci8, int loci9, int loci10, int loci11, int loci12)
        {
            this.κ = κ;
            this.y = y;
            this.loci1 = loci1;
            this.loci2 = loci2;
            this.loci3 = loci3;
            this.loci4 = loci4;
            this.loci5 = loci5;
            this.loci6 = loci6;
            this.loci7 = loci7;
            this.loci8 = loci8;
            this.loci9 = loci9;
            this.loci10 = loci10;
            this.loci11 = loci11;
            this.loci12 = loci12;
        }

        public static IEnumerable<fa> Data
        {
            get
            {
                yield return new fa(1, 1, 2, 7, 8, 2, 5, 9, 2, 2, 2, 2, 6, 3);
                yield return new fa(2, 1, 3, 7, 8, 2, 5, 9, 2, 2, 2, 2, 6, 3);
                yield return new fa(3, 1, 3, 1, 8, 2, 5, 9, 2, 2, 2, 2, 14, 5);
                yield return new fa(4, 1, 2, 5, 7, 2, 5, 9, 2, 2, 2, 2, 14, 3);
                yield return new fa(5, 1, 14, 7, 8, 5, 6, 2, 3, 2, 2, 2, 14, 9);
                yield return new fa(6, 1, 8, 4, 7, 7, 3, 2, 3, 4, 2, 2, 14, 9);
                yield return new fa(7, 1, 8, 4, 8, 2, 5, 9, 2, 1, 3, 1, 14, 11);
                yield return new fa(8, 1, 8, 4, 8, 2, 5, 9, 2, 1, 3, 1, 14, 11);
                yield return new fa(9, 1, 3, 2, 8, 2, 5, 9, 2, 2, 2, 2, 6, 3);
                yield return new fa(10, 1, 8, 4, 8, 2, 5, 9, 2, 2, 2, 2, 10, 6);
                yield return new fa(11, 1, 1, 7, 8, 2, 14, 9, 2, 2, 2, 2, 14, 3);
                yield return new fa(12, 1, 3, 5, 8, 5, 14, 2, 3, 2, 2, 2, 14, 9);
                yield return new fa(13, 1, 8, 7, 8, 2, 5, 9, 2, 2, 2, 2, 6, 3);
                yield return new fa(14, 1, 2, 7, 8, 2, 5, 9, 2, 2, 2, 2, 6, 14);
                yield return new fa(15, 1, 3, 5, 8, 2, 5, 9, 2, 2, 2, 2, 6, 3);
                yield return new fa(16, 1, 2, 7, 8, 8, 1, 3, 3, 2, 4, 5, 9, 10);
                yield return new fa(17, 1, 3, 5, 8, 5, 6, 2, 2, 1, 4, 2, 14, 5);
                yield return new fa(18, 1, 8, 5, 8, 5, 6, 2, 3, 2, 2, 5, 14, 5);
                yield return new fa(19, 1, 8, 4, 7, 7, 3, 3, 3, 4, 2, 2, 7, 5);
                yield return new fa(20, 1, 7, 7, 7, 7, 3, 3, 3, 4, 2, 2, 7, 5);
                yield return new fa(21, 1, 9, 2, 8, 14, 5, 9, 3, 4, 14, 14, 14, 5);
                yield return new fa(22, 1, 3, 7, 8, 7, 6, 2, 3, 4, 14, 14, 14, 11);
                yield return new fa(23, 1, 4, 14, 8, 3, 14, 9, 2, 4, 4, 5, 14, 14);
                yield return new fa(24, 1, 14, 7, 8, 3, 5, 2, 2, 2, 2, 5, 14, 5);
                yield return new fa(25, 1, 14, 7, 8, 7, 6, 9, 3, 4, 4, 5, 14, 5);
                yield return new fa(26, 1, 2, 14, 8, 2, 14, 9, 2, 2, 2, 2, 6, 14);
                yield return new fa(27, 1, 2, 7, 8, 2, 5, 9, 2, 2, 2, 2, 6, 3);
                yield return new fa(28, 1, 1, 7, 8, 2, 5, 9, 2, 2, 2, 2, 6, 3);
                yield return new fa(29, 1, 2, 7, 8, 2, 5, 9, 2, 2, 2, 2, 6, 3);
                yield return new fa(30, 1, 2, 7, 8, 2, 5, 9, 2, 2, 2, 2, 6, 14);
                yield return new fa(31, 1, 14, 7, 8, 6, 2, 2, 3, 2, 3, 2, 6, 11);
                yield return new fa(32, 1, 14, 7, 8, 7, 6, 2, 3, 2, 3, 3, 5, 5);
                yield return new fa(33, 1, 4, 5, 5, 10, 3, 8, 3, 4, 2, 5, 14, 5);
                yield return new fa(34, 1, 7, 7, 8, 2, 5, 9, 2, 2, 2, 2, 14, 3);
                yield return new fa(35, 1, 2, 1, 8, 2, 5, 9, 2, 2, 2, 2, 14, 5);
                yield return new fa(36, 1, 8, 5, 8, 2, 5, 9, 2, 2, 2, 2, 14, 3);
                yield return new fa(37, 1, 1, 7, 8, 2, 5, 9, 2, 2, 2, 2, 14, 3);
                yield return new fa(38, 1, 2, 7, 8, 2, 5, 9, 2, 2, 2, 2, 14, 1);
                yield return new fa(39, 1, 3, 2, 8, 2, 5, 9, 2, 2, 2, 2, 6, 3);
                yield return new fa(40, 1, 1, 5, 8, 5, 6, 3, 3, 2, 2, 2, 1, 5);
                yield return new fa(41, 1, 1, 6, 8, 5, 6, 3, 3, 2, 2, 2, 1, 9);
                yield return new fa(42, 1, 8, 3, 8, 4, 5, 9, 3, 2, 2, 2, 9, 10);
                yield return new fa(43, 1, 2, 7, 8, 7, 6, 3, 3, 2, 3, 3, 5, 14);
                yield return new fa(44, 1, 8, 5, 8, 2, 5, 9, 2, 2, 2, 2, 6, 14);
                yield return new fa(45, 1, 2, 1, 8, 2, 5, 14, 2, 2, 2, 2, 14, 5);
                yield return new fa(46, 1, 3, 5, 8, 2, 5, 14, 2, 2, 2, 2, 14, 3);
                yield return new fa(47, 1, 14, 7, 8, 2, 5, 9, 2, 2, 2, 14, 6, 10);
                yield return new fa(48, 1, 14, 4, 7, 7, 3, 3, 3, 4, 4, 2, 7, 5);
                yield return new fa(49, 1, 14, 8, 7, 7, 3, 3, 3, 4, 4, 2, 7, 9);
                yield return new fa(50, 1, 8, 7, 3, 6, 3, 14, 2, 2, 3, 2, 13, 3);
                yield return new fa(51, 1, 2, 7, 8, 2, 5, 14, 2, 2, 2, 2, 9, 5);
                yield return new fa(52, 1, 2, 7, 8, 2, 5, 9, 2, 2, 2, 2, 6, 3);
                yield return new fa(53, 1, 2, 7, 8, 2, 5, 9, 2, 2, 2, 2, 6, 5);
                yield return new fa(54, 1, 8, 7, 8, 7, 6, 3, 3, 2, 3, 2, 14, 9);
                yield return new fa(55, 1, 2, 7, 8, 2, 5, 9, 2, 2, 2, 2, 14, 3);
                yield return new fa(56, 1, 2, 7, 8, 7, 6, 9, 3, 4, 5, 4, 14, 14);
                yield return new fa(57, 1, 14, 5, 8, 2, 5, 9, 14, 2, 2, 2, 14, 11);
                yield return new fa(58, 1, 14, 6, 8, 5, 6, 3, 14, 2, 2, 2, 14, 5);
                yield return new fa(59, 0, 2, 7, 5, 3, 5, 9, 2, 2, 5, 3, 7, 6);
                yield return new fa(60, 0, 3, 4, 7, 7, 6, 3, 2, 4, 3, 2, 13, 9);
                yield return new fa(61, 0, 4, 7, 6, 3, 5, 3, 2, 2, 4, 5, 14, 10);
                yield return new fa(62, 0, 3, 7, 6, 6, 6, 9, 3, 2, 4, 2, 14, 14);
                yield return new fa(63, 0, 8, 14, 9, 5, 14, 9, 3, 4, 2, 2, 14, 14);
                yield return new fa(64, 0, 8, 14, 7, 7, 14, 2, 3, 4, 2, 2, 14, 14);
                yield return new fa(65, 0, 8, 14, 7, 5, 14, 3, 3, 2, 4, 5, 14, 14);
                yield return new fa(66, 0, 2, 7, 8, 7, 8, 2, 3, 4, 4, 5, 14, 11);
                yield return new fa(67, 0, 8, 6, 3, 6, 5, 12, 3, 2, 2, 2, 14, 11);
                yield return new fa(68, 0, 2, 6, 8, 3, 5, 4, 3, 2, 4, 5, 13, 9);
                yield return new fa(69, 0, 8, 4, 8, 7, 6, 9, 3, 4, 5, 4, 13, 11);
                yield return new fa(70, 0, 14, 14, 8, 8, 14, 12, 2, 1, 4, 2, 6, 14);
                yield return new fa(71, 0, 8, 7, 9, 7, 5, 9, 1, 2, 2, 2, 14, 10);
                yield return new fa(72, 0, 2, 7, 8, 3, 6, 9, 2, 2, 2, 2, 14, 9);
                yield return new fa(73, 0, 8, 8, 8, 2, 5, 10, 2, 4, 4, 4, 9, 11);
                yield return new fa(74, 0, 2, 7, 8, 3, 6, 9, 2, 2, 2, 2, 14, 9);
                yield return new fa(75, 0, 8, 8, 8, 2, 5, 10, 2, 4, 4, 4, 9, 11);
                yield return new fa(76, 0, 2, 7, 8, 2, 5, 3, 3, 1, 2, 2, 7, 9);
                yield return new fa(77, 0, 8, 7, 8, 1, 5, 7, 2, 4, 2, 4, 7, 10);
                yield return new fa(78, 0, 1, 7, 4, 9, 2, 3, 3, 1, 3, 1, 9, 4);
                yield return new fa(79, 0, 3, 5, 7, 7, 2, 0, 3, 1, 3, 6, 14, 10);
                yield return new fa(80, 0, 3, 6, 2, 5, 4, 4, 3, 1, 3, 0, 14, 5);
                yield return new fa(81, 0, 3, 4, 8, 4, 5, 6, 2, 2, 4, 4, 9, 11);
                yield return new fa(82, 0, 8, 7, 3, 6, 3, 5, 2, 4, 4, 4, 5, 9);
                yield return new fa(83, 0, 3, 14, 8, 1, 14, 2, 2, 14, 14, 14, 14, 14);
                yield return new fa(84, 0, 4, 14, 3, 4, 6, 2, 4, 2, 14, 2, 14, 14);
                yield return new fa(85, 0, 2, 14, 7, 7, 14, 3, 1, 5, 4, 14, 14, 14);
                yield return new fa(86, 0, 8, 4, 5, 6, 3, 6, 2, 2, 4, 2, 14, 9);
                yield return new fa(87, 0, 9, 4, 5, 8, 2, 8, 3, 4, 3, 5, 14, 5);
                yield return new fa(88, 0, 14, 7, 9, 8, 1, 9, 3, 2, 4, 5, 9, 4);
                yield return new fa(89, 0, 14, 7, 2, 6, 4, 3, 3, 1, 2, 2, 13, 5);
                yield return new fa(90, 0, 14, 8, 7, 8, 1, 3, 2, 4, 4, 5, 14, 9);
                yield return new fa(91, 0, 14, 7, 6, 3, 5, 2, 3, 2, 3, 2, 14, 5);
                yield return new fa(92, 0, 7, 5, 6, 5, 5, 9, 2, 1, 3, 3, 13, 10);
                yield return new fa(93, 0, 2, 7, 7, 6, 4, 9, 3, 2, 3, 2, 13, 3);
                yield return new fa(94, 0, 8, 14, 7, 9, 14, 3, 3, 4, 4, 5, 9, 14);
                yield return new fa(95, 0, 3, 14, 9, 14, 14, 6, 2, 4, 4, 2, 8, 14);
                yield return new fa(96, 0, 2, 14, 8, 3, 14, 4, 3, 2, 3, 6, 14, 14);
                yield return new fa(97, 0, 14, 14, 8, 3, 14, 9, 3, 2, 4, 5, 10, 14);
                yield return new fa(98, 0, 14, 14, 5, 7, 14, 9, 3, 1, 3, 2, 13, 14);
                yield return new fa(99, 0, 14, 14, 4, 4, 14, 14, 2, 2, 4, 2, 14, 5);
                yield return new fa(100, 0, 14, 7, 8, 3, 5, 9, 3, 2, 4, 2, 9, 5);
                yield return new fa(101, 0, 3, 14, 9, 6, 2, 14, 14, 14, 3, 2, 14, 9);
                yield return new fa(102, 0, 8, 1, 9, 7, 4, 3, 1, 2, 2, 2, 14, 10);
                yield return new fa(103, 0, 2, 7, 8, 3, 5, 9, 3, 4, 5, 4, 14, 11);
                yield return new fa(104, 0, 3, 7, 6, 5, 4, 6, 2, 1, 3, 2, 14, 5);
                yield return new fa(105, 0, 2, 7, 8, 2, 4, 3, 3, 4, 3, 2, 13, 3);
                yield return new fa(106, 0, 7, 7, 5, 6, 3, 8, 3, 2, 3, 6, 8, 5);
                yield return new fa(107, 0, 3, 6, 8, 3, 5, 12, 3, 4, 2, 2, 13, 3);
                yield return new fa(108, 0, 3, 5, 8, 3, 5, 12, 3, 1, 4, 5, 14, 14);
                yield return new fa(109, 0, 2, 7, 5, 6, 2, 4, 2, 4, 4, 5, 14, 14);
                yield return new fa(110, 0, 14, 7, 7, 7, 6, 4, 2, 2, 2, 5, 13, 14);
                yield return new fa(111, 0, 14, 3, 7, 7, 7, 4, 3, 4, 2, 3, 7, 14);
                yield return new fa(112, 0, 4, 7, 6, 4, 4, 9, 2, 2, 4, 4, 5, 14);
                yield return new fa(113, 0, 2, 4, 7, 8, 6, 4, 3, 2, 4, 5, 9, 14);
                yield return new fa(114, 0, 3, 14, 6, 7, 14, 4, 2, 2, 4, 5, 8, 14);
                yield return new fa(115, 0, 8, 14, 14, 5, 14, 9, 2, 1, 3, 3, 13, 14);
                yield return new fa(116, 0, 4, 14, 6, 4, 14, 9, 3, 2, 2, 1, 5, 14);
                yield return new fa(117, 0, 14, 14, 8, 7, 14, 9, 2, 2, 4, 4, 8, 14);
                yield return new fa(118, 0, 2, 14, 6, 9, 14, 3, 3, 1, 4, 5, 10, 14);
                yield return new fa(119, 0, 5, 14, 5, 6, 14, 3, 3, 2, 3, 6, 11, 14);
                yield return new fa(120, 0, 7, 0, 8, 1, 5, 14, 1, 2, 4, 2, 13, 9);
                yield return new fa(121, 0, 3, 6, 1, 6, 2, 14, 3, 4, 2, 2, 6, 9);
                yield return new fa(122, 0, 3, 14, 4, 7, 14, 7, 3, 2, 2, 2, 5, 14);
                yield return new fa(123, 0, 3, 14, 8, 5, 14, 9, 3, 4, 4, 5, 8, 14);
                yield return new fa(124, 0, 14, 14, 8, 3, 14, 14, 3, 4, 4, 4, 14, 14);
                yield return new fa(125, 0, 14, 14, 3, 6, 14, 3, 2, 2, 4, 4, 14, 14);
                yield return new fa(126, 0, 8, 5, 4, 6, 3, 3, 14, 2, 4, 5, 14, 9);
                yield return new fa(127, 0, 14, 14, 8, 3, 14, 14, 14, 2, 14, 14, 14, 14);
            }
        }
    }
}
