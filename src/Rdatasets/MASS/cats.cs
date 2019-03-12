// ReSharper disable All

namespace Rdatasets.MASS
{
    using System.Collections.Generic;

    /// <summary>
    /// Anatomical Data from Domestic Cats
    /// </summary>

    public class cats
    {
        public readonly int κ;
        public readonly string Sex;
        public readonly double Bwt;
        public readonly double Hwt;

        public cats(int κ, string Sex, double Bwt, double Hwt)
        {
            this.κ = κ;
            this.Sex = Sex;
            this.Bwt = Bwt;
            this.Hwt = Hwt;
        }

        public static IEnumerable<cats> Data
        {
            get
            {
                yield return new cats(1, "F", 2, 7);
                yield return new cats(2, "F", 2, 7.4);
                yield return new cats(3, "F", 2, 9.5);
                yield return new cats(4, "F", 2.1, 7.2);
                yield return new cats(5, "F", 2.1, 7.3);
                yield return new cats(6, "F", 2.1, 7.6);
                yield return new cats(7, "F", 2.1, 8.1);
                yield return new cats(8, "F", 2.1, 8.2);
                yield return new cats(9, "F", 2.1, 8.3);
                yield return new cats(10, "F", 2.1, 8.5);
                yield return new cats(11, "F", 2.1, 8.7);
                yield return new cats(12, "F", 2.1, 9.8);
                yield return new cats(13, "F", 2.2, 7.1);
                yield return new cats(14, "F", 2.2, 8.7);
                yield return new cats(15, "F", 2.2, 9.1);
                yield return new cats(16, "F", 2.2, 9.7);
                yield return new cats(17, "F", 2.2, 10.9);
                yield return new cats(18, "F", 2.2, 11);
                yield return new cats(19, "F", 2.3, 7.3);
                yield return new cats(20, "F", 2.3, 7.9);
                yield return new cats(21, "F", 2.3, 8.4);
                yield return new cats(22, "F", 2.3, 9);
                yield return new cats(23, "F", 2.3, 9);
                yield return new cats(24, "F", 2.3, 9.5);
                yield return new cats(25, "F", 2.3, 9.6);
                yield return new cats(26, "F", 2.3, 9.7);
                yield return new cats(27, "F", 2.3, 10.1);
                yield return new cats(28, "F", 2.3, 10.1);
                yield return new cats(29, "F", 2.3, 10.6);
                yield return new cats(30, "F", 2.3, 11.2);
                yield return new cats(31, "F", 2.4, 6.3);
                yield return new cats(32, "F", 2.4, 8.7);
                yield return new cats(33, "F", 2.4, 8.8);
                yield return new cats(34, "F", 2.4, 10.2);
                yield return new cats(35, "F", 2.5, 9);
                yield return new cats(36, "F", 2.5, 10.9);
                yield return new cats(37, "F", 2.6, 8.7);
                yield return new cats(38, "F", 2.6, 10.1);
                yield return new cats(39, "F", 2.6, 10.1);
                yield return new cats(40, "F", 2.7, 8.5);
                yield return new cats(41, "F", 2.7, 10.2);
                yield return new cats(42, "F", 2.7, 10.8);
                yield return new cats(43, "F", 2.9, 9.9);
                yield return new cats(44, "F", 2.9, 10.1);
                yield return new cats(45, "F", 2.9, 10.1);
                yield return new cats(46, "F", 3, 10.6);
                yield return new cats(47, "F", 3, 13);
                yield return new cats(48, "M", 2, 6.5);
                yield return new cats(49, "M", 2, 6.5);
                yield return new cats(50, "M", 2.1, 10.1);
                yield return new cats(51, "M", 2.2, 7.2);
                yield return new cats(52, "M", 2.2, 7.6);
                yield return new cats(53, "M", 2.2, 7.9);
                yield return new cats(54, "M", 2.2, 8.5);
                yield return new cats(55, "M", 2.2, 9.1);
                yield return new cats(56, "M", 2.2, 9.6);
                yield return new cats(57, "M", 2.2, 9.6);
                yield return new cats(58, "M", 2.2, 10.7);
                yield return new cats(59, "M", 2.3, 9.6);
                yield return new cats(60, "M", 2.4, 7.3);
                yield return new cats(61, "M", 2.4, 7.9);
                yield return new cats(62, "M", 2.4, 7.9);
                yield return new cats(63, "M", 2.4, 9.1);
                yield return new cats(64, "M", 2.4, 9.3);
                yield return new cats(65, "M", 2.5, 7.9);
                yield return new cats(66, "M", 2.5, 8.6);
                yield return new cats(67, "M", 2.5, 8.8);
                yield return new cats(68, "M", 2.5, 8.8);
                yield return new cats(69, "M", 2.5, 9.3);
                yield return new cats(70, "M", 2.5, 11);
                yield return new cats(71, "M", 2.5, 12.7);
                yield return new cats(72, "M", 2.5, 12.7);
                yield return new cats(73, "M", 2.6, 7.7);
                yield return new cats(74, "M", 2.6, 8.3);
                yield return new cats(75, "M", 2.6, 9.4);
                yield return new cats(76, "M", 2.6, 9.4);
                yield return new cats(77, "M", 2.6, 10.5);
                yield return new cats(78, "M", 2.6, 11.5);
                yield return new cats(79, "M", 2.7, 8);
                yield return new cats(80, "M", 2.7, 9);
                yield return new cats(81, "M", 2.7, 9.6);
                yield return new cats(82, "M", 2.7, 9.6);
                yield return new cats(83, "M", 2.7, 9.8);
                yield return new cats(84, "M", 2.7, 10.4);
                yield return new cats(85, "M", 2.7, 11.1);
                yield return new cats(86, "M", 2.7, 12);
                yield return new cats(87, "M", 2.7, 12.5);
                yield return new cats(88, "M", 2.8, 9.1);
                yield return new cats(89, "M", 2.8, 10);
                yield return new cats(90, "M", 2.8, 10.2);
                yield return new cats(91, "M", 2.8, 11.4);
                yield return new cats(92, "M", 2.8, 12);
                yield return new cats(93, "M", 2.8, 13.3);
                yield return new cats(94, "M", 2.8, 13.5);
                yield return new cats(95, "M", 2.9, 9.4);
                yield return new cats(96, "M", 2.9, 10.1);
                yield return new cats(97, "M", 2.9, 10.6);
                yield return new cats(98, "M", 2.9, 11.3);
                yield return new cats(99, "M", 2.9, 11.8);
                yield return new cats(100, "M", 3, 10);
                yield return new cats(101, "M", 3, 10.4);
                yield return new cats(102, "M", 3, 10.6);
                yield return new cats(103, "M", 3, 11.6);
                yield return new cats(104, "M", 3, 12.2);
                yield return new cats(105, "M", 3, 12.4);
                yield return new cats(106, "M", 3, 12.7);
                yield return new cats(107, "M", 3, 13.3);
                yield return new cats(108, "M", 3, 13.8);
                yield return new cats(109, "M", 3.1, 9.9);
                yield return new cats(110, "M", 3.1, 11.5);
                yield return new cats(111, "M", 3.1, 12.1);
                yield return new cats(112, "M", 3.1, 12.5);
                yield return new cats(113, "M", 3.1, 13);
                yield return new cats(114, "M", 3.1, 14.3);
                yield return new cats(115, "M", 3.2, 11.6);
                yield return new cats(116, "M", 3.2, 11.9);
                yield return new cats(117, "M", 3.2, 12.3);
                yield return new cats(118, "M", 3.2, 13);
                yield return new cats(119, "M", 3.2, 13.5);
                yield return new cats(120, "M", 3.2, 13.6);
                yield return new cats(121, "M", 3.3, 11.5);
                yield return new cats(122, "M", 3.3, 12);
                yield return new cats(123, "M", 3.3, 14.1);
                yield return new cats(124, "M", 3.3, 14.9);
                yield return new cats(125, "M", 3.3, 15.4);
                yield return new cats(126, "M", 3.4, 11.2);
                yield return new cats(127, "M", 3.4, 12.2);
                yield return new cats(128, "M", 3.4, 12.4);
                yield return new cats(129, "M", 3.4, 12.8);
                yield return new cats(130, "M", 3.4, 14.4);
                yield return new cats(131, "M", 3.5, 11.7);
                yield return new cats(132, "M", 3.5, 12.9);
                yield return new cats(133, "M", 3.5, 15.6);
                yield return new cats(134, "M", 3.5, 15.7);
                yield return new cats(135, "M", 3.5, 17.2);
                yield return new cats(136, "M", 3.6, 11.8);
                yield return new cats(137, "M", 3.6, 13.3);
                yield return new cats(138, "M", 3.6, 14.8);
                yield return new cats(139, "M", 3.6, 15);
                yield return new cats(140, "M", 3.7, 11);
                yield return new cats(141, "M", 3.8, 14.8);
                yield return new cats(142, "M", 3.8, 16.8);
                yield return new cats(143, "M", 3.9, 14.4);
                yield return new cats(144, "M", 3.9, 20.5);
            }
        }
    }
}
