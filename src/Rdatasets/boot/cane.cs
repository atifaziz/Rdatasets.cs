// ReSharper disable All

namespace Rdatasets.boot
{
    using System.Collections.Generic;

    /// <summary>
    /// Sugar-cane Disease Data
    /// </summary>

    public class cane
    {
        public readonly int n;
        public readonly int r;
        public readonly int x;
        public readonly int var;
        public readonly string block;

        public cane(int n, int r, int x, int var, string block)
        {
            this.n = n;
            this.r = r;
            this.x = x;
            this.var = var;
            this.block = block;
        }

        public static IEnumerable<cane> Data
        {
            get
            {
                yield return new cane(87, 76, 19, 1, "A");
                yield return new cane(119, 8, 14, 2, "A");
                yield return new cane(94, 74, 9, 3, "A");
                yield return new cane(95, 11, 12, 4, "A");
                yield return new cane(134, 0, 12, 5, "A");
                yield return new cane(92, 0, 3, 6, "A");
                yield return new cane(118, 11, 17, 7, "A");
                yield return new cane(70, 32, 3, 8, "A");
                yield return new cane(128, 33, 3, 9, "A");
                yield return new cane(85, 14, 21, 10, "A");
                yield return new cane(77, 3, 8, 11, "A");
                yield return new cane(29, 3, 3, 12, "A");
                yield return new cane(109, 28, 7, 13, "A");
                yield return new cane(209, 63, 10, 14, "A");
                yield return new cane(89, 3, 7, 15, "A");
                yield return new cane(171, 16, 14, 16, "A");
                yield return new cane(243, 11, 17, 17, "A");
                yield return new cane(109, 2, 14, 18, "A");
                yield return new cane(66, 8, 18, 19, "A");
                yield return new cane(177, 62, 12, 20, "A");
                yield return new cane(124, 14, 18, 21, "A");
                yield return new cane(159, 34, 10, 22, "A");
                yield return new cane(68, 0, 6, 23, "A");
                yield return new cane(136, 13, 12, 24, "A");
                yield return new cane(86, 7, 10, 25, "A");
                yield return new cane(75, 12, 16, 26, "A");
                yield return new cane(100, 0, 13, 27, "A");
                yield return new cane(147, 22, 18, 28, "A");
                yield return new cane(49, 5, 6, 29, "A");
                yield return new cane(111, 17, 13, 30, "A");
                yield return new cane(134, 0, 8, 31, "A");
                yield return new cane(179, 15, 32, 32, "A");
                yield return new cane(120, 20, 5, 33, "A");
                yield return new cane(169, 27, 6, 34, "A");
                yield return new cane(45, 0, 2, 35, "A");
                yield return new cane(105, 0, 10, 36, "A");
                yield return new cane(65, 6, 7, 37, "A");
                yield return new cane(192, 25, 15, 38, "A");
                yield return new cane(92, 2, 18, 39, "A");
                yield return new cane(212, 112, 12, 40, "A");
                yield return new cane(79, 9, 10, 41, "A");
                yield return new cane(119, 10, 15, 42, "A");
                yield return new cane(97, 0, 10, 43, "A");
                yield return new cane(129, 1, 9, 44, "A");
                yield return new cane(72, 27, 8, 45, "A");
                yield return new cane(70, 70, 12, 1, "B");
                yield return new cane(125, 21, 13, 2, "B");
                yield return new cane(105, 95, 9, 3, "B");
                yield return new cane(104, 21, 12, 4, "B");
                yield return new cane(115, 6, 25, 5, "B");
                yield return new cane(195, 63, 17, 6, "B");
                yield return new cane(111, 7, 15, 7, "B");
                yield return new cane(131, 22, 6, 8, "B");
                yield return new cane(108, 77, 3, 9, "B");
                yield return new cane(121, 12, 21, 10, "B");
                yield return new cane(74, 0, 4, 11, "B");
                yield return new cane(111, 26, 5, 12, "B");
                yield return new cane(120, 50, 10, 13, "B");
                yield return new cane(231, 105, 12, 14, "B");
                yield return new cane(113, 18, 12, 15, "B");
                yield return new cane(131, 32, 15, 16, "B");
                yield return new cane(222, 9, 9, 17, "B");
                yield return new cane(109, 0, 12, 18, "B");
                yield return new cane(161, 36, 19, 19, "B");
                yield return new cane(112, 9, 14, 20, "B");
                yield return new cane(121, 17, 16, 21, "B");
                yield return new cane(191, 110, 10, 22, "B");
                yield return new cane(85, 0, 8, 23, "B");
                yield return new cane(143, 14, 17, 24, "B");
                yield return new cane(82, 7, 12, 25, "B");
                yield return new cane(105, 22, 13, 26, "B");
                yield return new cane(140, 8, 15, 27, "B");
                yield return new cane(167, 7, 11, 28, "B");
                yield return new cane(38, 0, 3, 29, "B");
                yield return new cane(81, 13, 11, 30, "B");
                yield return new cane(162, 1, 6, 31, "B");
                yield return new cane(243, 11, 18, 32, "B");
                yield return new cane(66, 18, 5, 33, "B");
                yield return new cane(120, 25, 6, 34, "B");
                yield return new cane(133, 0, 6, 35, "B");
                yield return new cane(119, 10, 15, 36, "B");
                yield return new cane(92, 43, 6, 37, "B");
                yield return new cane(162, 6, 26, 38, "B");
                yield return new cane(131, 17, 26, 39, "B");
                yield return new cane(108, 48, 9, 40, "B");
                yield return new cane(46, 0, 5, 41, "B");
                yield return new cane(147, 16, 20, 42, "B");
                yield return new cane(130, 11, 14, 43, "B");
                yield return new cane(148, 0, 17, 44, "B");
                yield return new cane(100, 64, 17, 45, "B");
                yield return new cane(73, 54, 25, 1, "C");
                yield return new cane(130, 10, 12, 2, "C");
                yield return new cane(71, 44, 6, 3, "C");
                yield return new cane(104, 15, 13, 4, "C");
                yield return new cane(195, 3, 19, 5, "C");
                yield return new cane(99, 21, 11, 6, "C");
                yield return new cane(63, 8, 12, 7, "C");
                yield return new cane(85, 28, 5, 8, "C");
                yield return new cane(59, 11, 4, 9, "C");
                yield return new cane(113, 13, 28, 10, "C");
                yield return new cane(63, 0, 3, 11, "C");
                yield return new cane(50, 3, 1, 12, "C");
                yield return new cane(102, 36, 10, 13, "C");
                yield return new cane(223, 59, 10, 14, "C");
                yield return new cane(91, 5, 15, 15, "C");
                yield return new cane(169, 4, 7, 16, "C");
                yield return new cane(130, 57, 7, 17, "C");
                yield return new cane(103, 0, 8, 18, "C");
                yield return new cane(98, 22, 17, 19, "C");
                yield return new cane(173, 92, 17, 20, "C");
                yield return new cane(152, 21, 22, 21, "C");
                yield return new cane(137, 57, 7, 22, "C");
                yield return new cane(33, 0, 5, 23, "C");
                yield return new cane(123, 24, 10, 24, "C");
                yield return new cane(88, 0, 11, 25, "C");
                yield return new cane(99, 8, 9, 26, "C");
                yield return new cane(153, 1, 9, 27, "C");
                yield return new cane(154, 6, 16, 28, "C");
                yield return new cane(78, 4, 12, 29, "C");
                yield return new cane(80, 6, 17, 30, "C");
                yield return new cane(161, 0, 13, 31, "C");
                yield return new cane(184, 7, 25, 32, "C");
                yield return new cane(69, 18, 2, 33, "C");
                yield return new cane(141, 10, 8, 34, "C");
                yield return new cane(113, 8, 4, 35, "C");
                yield return new cane(132, 2, 10, 36, "C");
                yield return new cane(63, 24, 3, 37, "C");
                yield return new cane(161, 22, 19, 38, "C");
                yield return new cane(111, 10, 20, 39, "C");
                yield return new cane(78, 8, 7, 40, "C");
                yield return new cane(71, 0, 6, 41, "C");
                yield return new cane(118, 16, 20, 42, "C");
                yield return new cane(84, 6, 8, 43, "C");
                yield return new cane(175, 0, 12, 44, "C");
                yield return new cane(143, 42, 24, 45, "C");
                yield return new cane(59, 39, 14, 1, "D");
                yield return new cane(177, 26, 15, 2, "D");
                yield return new cane(48, 38, 3, 3, "D");
                yield return new cane(165, 41, 11, 4, "D");
                yield return new cane(150, 5, 15, 5, "D");
                yield return new cane(135, 47, 19, 6, "D");
                yield return new cane(97, 15, 11, 7, "D");
                yield return new cane(75, 18, 3, 8, "D");
                yield return new cane(51, 11, 3, 9, "D");
                yield return new cane(135, 28, 19, 10, "D");
                yield return new cane(102, 0, 6, 11, "D");
                yield return new cane(57, 39, 4, 12, "D");
                yield return new cane(58, 13, 9, 13, "D");
                yield return new cane(157, 23, 9, 14, "D");
                yield return new cane(94, 1, 13, 15, "D");
                yield return new cane(172, 69, 10, 16, "D");
                yield return new cane(105, 24, 2, 17, "D");
                yield return new cane(147, 1, 10, 18, "D");
                yield return new cane(94, 30, 36, 19, "D");
                yield return new cane(106, 23, 10, 20, "D");
                yield return new cane(137, 15, 13, 21, "D");
                yield return new cane(243, 131, 17, 22, "D");
                yield return new cane(137, 4, 10, 23, "D");
                yield return new cane(104, 2, 17, 24, "D");
                yield return new cane(116, 3, 13, 25, "D");
                yield return new cane(102, 13, 10, 26, "D");
                yield return new cane(151, 3, 15, 27, "D");
                yield return new cane(113, 7, 15, 28, "D");
                yield return new cane(67, 3, 8, 29, "D");
                yield return new cane(111, 13, 12, 30, "D");
                yield return new cane(132, 0, 12, 31, "D");
                yield return new cane(220, 6, 14, 32, "D");
                yield return new cane(67, 2, 4, 33, "D");
                yield return new cane(146, 10, 9, 34, "D");
                yield return new cane(110, 0, 4, 35, "D");
                yield return new cane(93, 2, 11, 36, "D");
                yield return new cane(79, 11, 3, 37, "D");
                yield return new cane(167, 36, 26, 38, "D");
                yield return new cane(144, 16, 14, 39, "D");
                yield return new cane(182, 63, 17, 40, "D");
                yield return new cane(61, 2, 8, 41, "D");
                yield return new cane(154, 12, 35, 42, "D");
                yield return new cane(98, 0, 8, 43, "D");
                yield return new cane(129, 9, 14, 44, "D");
                yield return new cane(130, 24, 20, 45, "D");
            }
        }
    }
}
