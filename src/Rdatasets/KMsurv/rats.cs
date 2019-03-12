// ReSharper disable All

namespace Rdatasets.KMsurv
{
    using System.Collections.Generic;

    /// <summary>
    /// data from Exercise 7.13, p225
    /// </summary>

    public class rats
    {
        public readonly int κ;
        public readonly int time;
        public readonly int tumor;
        public readonly int trt;
        public readonly int litter;

        public rats(int κ, int time, int tumor, int trt, int litter)
        {
            this.κ = κ;
            this.time = time;
            this.tumor = tumor;
            this.trt = trt;
            this.litter = litter;
        }

        public static IEnumerable<rats> Data
        {
            get
            {
                yield return new rats(1, 101, 0, 1, 1);
                yield return new rats(2, 104, 0, 1, 2);
                yield return new rats(3, 104, 0, 1, 3);
                yield return new rats(4, 77, 0, 1, 4);
                yield return new rats(5, 89, 0, 1, 5);
                yield return new rats(6, 88, 1, 1, 6);
                yield return new rats(7, 104, 1, 1, 7);
                yield return new rats(8, 96, 1, 1, 8);
                yield return new rats(9, 82, 0, 1, 9);
                yield return new rats(10, 70, 1, 1, 10);
                yield return new rats(11, 89, 1, 1, 11);
                yield return new rats(12, 91, 0, 1, 12);
                yield return new rats(13, 39, 1, 1, 13);
                yield return new rats(14, 103, 1, 1, 14);
                yield return new rats(15, 93, 0, 1, 15);
                yield return new rats(16, 85, 0, 1, 16);
                yield return new rats(17, 104, 0, 1, 17);
                yield return new rats(18, 104, 0, 1, 18);
                yield return new rats(19, 81, 0, 1, 19);
                yield return new rats(20, 67, 1, 1, 20);
                yield return new rats(21, 104, 0, 1, 21);
                yield return new rats(22, 104, 0, 1, 22);
                yield return new rats(23, 104, 0, 1, 23);
                yield return new rats(24, 87, 0, 1, 24);
                yield return new rats(25, 104, 0, 1, 25);
                yield return new rats(26, 89, 0, 1, 26);
                yield return new rats(27, 78, 0, 1, 27);
                yield return new rats(28, 104, 0, 1, 28);
                yield return new rats(29, 86, 1, 1, 29);
                yield return new rats(30, 34, 1, 1, 30);
                yield return new rats(31, 76, 0, 1, 31);
                yield return new rats(32, 103, 1, 1, 32);
                yield return new rats(33, 102, 1, 1, 33);
                yield return new rats(34, 80, 1, 1, 34);
                yield return new rats(35, 45, 1, 1, 35);
                yield return new rats(36, 94, 1, 1, 36);
                yield return new rats(37, 104, 0, 1, 37);
                yield return new rats(38, 104, 0, 1, 38);
                yield return new rats(39, 76, 0, 1, 39);
                yield return new rats(40, 80, 1, 1, 40);
                yield return new rats(41, 72, 1, 1, 41);
                yield return new rats(42, 73, 1, 1, 42);
                yield return new rats(43, 92, 1, 1, 43);
                yield return new rats(44, 104, 0, 1, 44);
                yield return new rats(45, 55, 0, 1, 45);
                yield return new rats(46, 49, 0, 1, 46);
                yield return new rats(47, 89, 1, 1, 47);
                yield return new rats(48, 88, 0, 1, 48);
                yield return new rats(49, 103, 1, 1, 49);
                yield return new rats(50, 104, 0, 1, 50);
                yield return new rats(51, 104, 0, 0, 1);
                yield return new rats(52, 104, 0, 0, 2);
                yield return new rats(53, 104, 0, 0, 3);
                yield return new rats(54, 97, 0, 0, 4);
                yield return new rats(55, 104, 0, 0, 5);
                yield return new rats(56, 104, 0, 0, 6);
                yield return new rats(57, 94, 0, 0, 7);
                yield return new rats(58, 104, 0, 0, 8);
                yield return new rats(59, 104, 0, 0, 9);
                yield return new rats(60, 104, 0, 0, 10);
                yield return new rats(61, 91, 0, 0, 11);
                yield return new rats(62, 92, 0, 0, 12);
                yield return new rats(63, 50, 1, 0, 13);
                yield return new rats(64, 91, 0, 0, 14);
                yield return new rats(65, 104, 0, 0, 15);
                yield return new rats(66, 104, 0, 0, 16);
                yield return new rats(67, 104, 0, 0, 17);
                yield return new rats(68, 104, 0, 0, 18);
                yield return new rats(69, 104, 0, 0, 19);
                yield return new rats(70, 104, 0, 0, 20);
                yield return new rats(71, 104, 0, 0, 21);
                yield return new rats(72, 104, 0, 0, 22);
                yield return new rats(73, 83, 0, 0, 23);
                yield return new rats(74, 104, 0, 0, 24);
                yield return new rats(75, 104, 0, 0, 25);
                yield return new rats(76, 104, 0, 0, 26);
                yield return new rats(77, 104, 0, 0, 27);
                yield return new rats(78, 81, 1, 0, 28);
                yield return new rats(79, 94, 0, 0, 29);
                yield return new rats(80, 104, 0, 0, 30);
                yield return new rats(81, 87, 0, 0, 31);
                yield return new rats(82, 84, 1, 0, 32);
                yield return new rats(83, 104, 0, 0, 33);
                yield return new rats(84, 104, 0, 0, 34);
                yield return new rats(85, 104, 0, 0, 35);
                yield return new rats(86, 104, 0, 0, 36);
                yield return new rats(87, 104, 0, 0, 37);
                yield return new rats(88, 101, 1, 0, 38);
                yield return new rats(89, 84, 1, 0, 39);
                yield return new rats(90, 80, 1, 0, 40);
                yield return new rats(91, 104, 0, 0, 41);
                yield return new rats(92, 104, 0, 0, 42);
                yield return new rats(93, 104, 0, 0, 43);
                yield return new rats(94, 98, 0, 0, 44);
                yield return new rats(95, 104, 0, 0, 45);
                yield return new rats(96, 83, 0, 0, 46);
                yield return new rats(97, 104, 0, 0, 47);
                yield return new rats(98, 99, 0, 0, 48);
                yield return new rats(99, 104, 0, 0, 49);
                yield return new rats(100, 104, 0, 0, 50);
                yield return new rats(101, 49, 1, 0, 1);
                yield return new rats(102, 102, 0, 0, 2);
                yield return new rats(103, 104, 0, 0, 3);
                yield return new rats(104, 79, 0, 0, 4);
                yield return new rats(105, 104, 0, 0, 5);
                yield return new rats(106, 96, 1, 0, 6);
                yield return new rats(107, 77, 1, 0, 7);
                yield return new rats(108, 104, 0, 0, 8);
                yield return new rats(109, 77, 0, 0, 9);
                yield return new rats(110, 77, 0, 0, 10);
                yield return new rats(111, 90, 0, 0, 11);
                yield return new rats(112, 70, 0, 0, 12);
                yield return new rats(113, 45, 0, 0, 13);
                yield return new rats(114, 69, 0, 0, 14);
                yield return new rats(115, 103, 0, 0, 15);
                yield return new rats(116, 72, 0, 0, 16);
                yield return new rats(117, 63, 0, 0, 17);
                yield return new rats(118, 74, 0, 0, 18);
                yield return new rats(119, 69, 0, 0, 19);
                yield return new rats(120, 68, 1, 0, 20);
                yield return new rats(121, 104, 0, 0, 21);
                yield return new rats(122, 104, 0, 0, 22);
                yield return new rats(123, 40, 1, 0, 23);
                yield return new rats(124, 104, 0, 0, 24);
                yield return new rats(125, 104, 0, 0, 25);
                yield return new rats(126, 104, 0, 0, 26);
                yield return new rats(127, 104, 0, 0, 27);
                yield return new rats(128, 64, 1, 0, 28);
                yield return new rats(129, 55, 1, 0, 29);
                yield return new rats(130, 54, 1, 0, 30);
                yield return new rats(131, 74, 0, 0, 31);
                yield return new rats(132, 73, 1, 0, 32);
                yield return new rats(133, 80, 0, 0, 33);
                yield return new rats(134, 73, 0, 0, 34);
                yield return new rats(135, 79, 0, 0, 35);
                yield return new rats(136, 104, 0, 0, 36);
                yield return new rats(137, 104, 0, 0, 37);
                yield return new rats(138, 94, 0, 0, 38);
                yield return new rats(139, 78, 1, 0, 39);
                yield return new rats(140, 76, 0, 0, 40);
                yield return new rats(141, 95, 0, 0, 41);
                yield return new rats(142, 66, 1, 0, 42);
                yield return new rats(143, 102, 1, 0, 43);
                yield return new rats(144, 78, 0, 0, 44);
                yield return new rats(145, 104, 0, 0, 45);
                yield return new rats(146, 77, 0, 0, 46);
                yield return new rats(147, 104, 0, 0, 47);
                yield return new rats(148, 79, 0, 0, 48);
                yield return new rats(149, 91, 0, 0, 49);
                yield return new rats(150, 79, 1, 0, 50);
            }
        }
    }
}
