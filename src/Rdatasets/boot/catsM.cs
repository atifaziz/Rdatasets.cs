// ReSharper disable All

namespace Rdatasets.boot
{
    using System.Collections.Generic;

    /// <summary>
    /// Weight Data for Domestic Cats
    /// </summary>

    public class catsM
    {
        public readonly int κ;
        public readonly string Sex;
        public readonly double Bwt;
        public readonly double Hwt;

        public catsM(int κ, string Sex, double Bwt, double Hwt)
        {
            this.κ = κ;
            this.Sex = Sex;
            this.Bwt = Bwt;
            this.Hwt = Hwt;
        }

        public static IEnumerable<catsM> Data
        {
            get
            {
                yield return new catsM(1, "M", 2, 6.5);
                yield return new catsM(2, "M", 2, 6.5);
                yield return new catsM(3, "M", 2.1, 10.1);
                yield return new catsM(4, "M", 2.2, 7.2);
                yield return new catsM(5, "M", 2.2, 7.6);
                yield return new catsM(6, "M", 2.2, 7.9);
                yield return new catsM(7, "M", 2.2, 8.5);
                yield return new catsM(8, "M", 2.2, 9.1);
                yield return new catsM(9, "M", 2.2, 9.6);
                yield return new catsM(10, "M", 2.2, 9.6);
                yield return new catsM(11, "M", 2.2, 10.7);
                yield return new catsM(12, "M", 2.3, 9.6);
                yield return new catsM(13, "M", 2.4, 7.3);
                yield return new catsM(14, "M", 2.4, 7.9);
                yield return new catsM(15, "M", 2.4, 7.9);
                yield return new catsM(16, "M", 2.4, 9.1);
                yield return new catsM(17, "M", 2.4, 9.3);
                yield return new catsM(18, "M", 2.5, 7.9);
                yield return new catsM(19, "M", 2.5, 8.6);
                yield return new catsM(20, "M", 2.5, 8.8);
                yield return new catsM(21, "M", 2.5, 8.8);
                yield return new catsM(22, "M", 2.5, 9.3);
                yield return new catsM(23, "M", 2.5, 11);
                yield return new catsM(24, "M", 2.5, 12.7);
                yield return new catsM(25, "M", 2.5, 12.7);
                yield return new catsM(26, "M", 2.6, 7.7);
                yield return new catsM(27, "M", 2.6, 8.3);
                yield return new catsM(28, "M", 2.6, 9.4);
                yield return new catsM(29, "M", 2.6, 9.4);
                yield return new catsM(30, "M", 2.6, 10.5);
                yield return new catsM(31, "M", 2.6, 11.5);
                yield return new catsM(32, "M", 2.7, 8);
                yield return new catsM(33, "M", 2.7, 9);
                yield return new catsM(34, "M", 2.7, 9.6);
                yield return new catsM(35, "M", 2.7, 9.6);
                yield return new catsM(36, "M", 2.7, 9.8);
                yield return new catsM(37, "M", 2.7, 10.4);
                yield return new catsM(38, "M", 2.7, 11.1);
                yield return new catsM(39, "M", 2.7, 12);
                yield return new catsM(40, "M", 2.7, 12.5);
                yield return new catsM(41, "M", 2.8, 9.1);
                yield return new catsM(42, "M", 2.8, 10);
                yield return new catsM(43, "M", 2.8, 10.2);
                yield return new catsM(44, "M", 2.8, 11.4);
                yield return new catsM(45, "M", 2.8, 12);
                yield return new catsM(46, "M", 2.8, 13.3);
                yield return new catsM(47, "M", 2.8, 13.5);
                yield return new catsM(48, "M", 2.9, 9.4);
                yield return new catsM(49, "M", 2.9, 10.1);
                yield return new catsM(50, "M", 2.9, 10.6);
                yield return new catsM(51, "M", 2.9, 11.3);
                yield return new catsM(52, "M", 2.9, 11.8);
                yield return new catsM(53, "M", 3, 10);
                yield return new catsM(54, "M", 3, 10.4);
                yield return new catsM(55, "M", 3, 10.6);
                yield return new catsM(56, "M", 3, 11.6);
                yield return new catsM(57, "M", 3, 12.2);
                yield return new catsM(58, "M", 3, 12.4);
                yield return new catsM(59, "M", 3, 12.7);
                yield return new catsM(60, "M", 3, 13.3);
                yield return new catsM(61, "M", 3, 13.8);
                yield return new catsM(62, "M", 3.1, 9.9);
                yield return new catsM(63, "M", 3.1, 11.5);
                yield return new catsM(64, "M", 3.1, 12.1);
                yield return new catsM(65, "M", 3.1, 12.5);
                yield return new catsM(66, "M", 3.1, 13);
                yield return new catsM(67, "M", 3.1, 14.3);
                yield return new catsM(68, "M", 3.2, 11.6);
                yield return new catsM(69, "M", 3.2, 11.9);
                yield return new catsM(70, "M", 3.2, 12.3);
                yield return new catsM(71, "M", 3.2, 13);
                yield return new catsM(72, "M", 3.2, 13.5);
                yield return new catsM(73, "M", 3.2, 13.6);
                yield return new catsM(74, "M", 3.3, 11.5);
                yield return new catsM(75, "M", 3.3, 12);
                yield return new catsM(76, "M", 3.3, 14.1);
                yield return new catsM(77, "M", 3.3, 14.9);
                yield return new catsM(78, "M", 3.3, 15.4);
                yield return new catsM(79, "M", 3.4, 11.2);
                yield return new catsM(80, "M", 3.4, 12.2);
                yield return new catsM(81, "M", 3.4, 12.4);
                yield return new catsM(82, "M", 3.4, 12.8);
                yield return new catsM(83, "M", 3.4, 14.4);
                yield return new catsM(84, "M", 3.5, 11.7);
                yield return new catsM(85, "M", 3.5, 12.9);
                yield return new catsM(86, "M", 3.5, 15.6);
                yield return new catsM(87, "M", 3.5, 15.7);
                yield return new catsM(88, "M", 3.5, 17.2);
                yield return new catsM(89, "M", 3.6, 11.8);
                yield return new catsM(90, "M", 3.6, 13.3);
                yield return new catsM(91, "M", 3.6, 14.8);
                yield return new catsM(92, "M", 3.6, 15);
                yield return new catsM(93, "M", 3.7, 11);
                yield return new catsM(94, "M", 3.8, 14.8);
                yield return new catsM(95, "M", 3.8, 16.8);
                yield return new catsM(96, "M", 3.9, 14.4);
                yield return new catsM(97, "M", 3.9, 20.5);
            }
        }
    }
}
