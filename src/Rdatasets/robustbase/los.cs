// ReSharper disable All

namespace Rdatasets.robustbase
{
    using System.Collections.Generic;

    /// <summary>
    /// Length of Stay Data
    /// </summary>

    public class los
    {
        public readonly int κ;
        public readonly int dat;

        public los(int κ, int dat)
        {
            this.κ = κ;
            this.dat = dat;
        }

        public static IEnumerable<los> Data
        {
            get
            {
                yield return new los(1, 16);
                yield return new los(2, 13);
                yield return new los(3, 17);
                yield return new los(4, 4);
                yield return new los(5, 15);
                yield return new los(6, 24);
                yield return new los(7, 59);
                yield return new los(8, 18);
                yield return new los(9, 33);
                yield return new los(10, 8);
                yield return new los(11, 42);
                yield return new los(12, 19);
                yield return new los(13, 20);
                yield return new los(14, 4);
                yield return new los(15, 11);
                yield return new los(16, 9);
                yield return new los(17, 3);
                yield return new los(18, 7);
                yield return new los(19, 10);
                yield return new los(20, 3);
                yield return new los(21, 3);
                yield return new los(22, 67);
                yield return new los(23, 4);
                yield return new los(24, 4);
                yield return new los(25, 13);
                yield return new los(26, 16);
                yield return new los(27, 6);
                yield return new los(28, 3);
                yield return new los(29, 3);
                yield return new los(30, 6);
                yield return new los(31, 3);
                yield return new los(32, 4);
                yield return new los(33, 35);
                yield return new los(34, 10);
                yield return new los(35, 16);
                yield return new los(36, 11);
                yield return new los(37, 24);
                yield return new los(38, 7);
                yield return new los(39, 47);
                yield return new los(40, 8);
                yield return new los(41, 8);
                yield return new los(42, 2);
                yield return new los(43, 12);
                yield return new los(44, 3);
                yield return new los(45, 8);
                yield return new los(46, 4);
                yield return new los(47, 3);
                yield return new los(48, 6);
                yield return new los(49, 6);
                yield return new los(50, 102);
                yield return new los(51, 9);
                yield return new los(52, 3);
                yield return new los(53, 15);
                yield return new los(54, 21);
                yield return new los(55, 13);
                yield return new los(56, 8);
                yield return new los(57, 16);
                yield return new los(58, 2);
                yield return new los(59, 5);
                yield return new los(60, 14);
                yield return new los(61, 9);
                yield return new los(62, 21);
                yield return new los(63, 4);
                yield return new los(64, 9);
                yield return new los(65, 11);
                yield return new los(66, 36);
                yield return new los(67, 4);
                yield return new los(68, 8);
                yield return new los(69, 4);
                yield return new los(70, 6);
                yield return new los(71, 4);
                yield return new los(72, 10);
                yield return new los(73, 13);
                yield return new los(74, 11);
                yield return new los(75, 5);
                yield return new los(76, 4);
                yield return new los(77, 16);
                yield return new los(78, 14);
                yield return new los(79, 3);
                yield return new los(80, 22);
                yield return new los(81, 20);
                yield return new los(82, 5);
                yield return new los(83, 2);
                yield return new los(84, 8);
                yield return new los(85, 12);
                yield return new los(86, 14);
                yield return new los(87, 27);
                yield return new los(88, 2);
                yield return new los(89, 13);
                yield return new los(90, 8);
                yield return new los(91, 18);
                yield return new los(92, 18);
                yield return new los(93, 6);
                yield return new los(94, 31);
                yield return new los(95, 3);
                yield return new los(96, 14);
                yield return new los(97, 23);
                yield return new los(98, 13);
                yield return new los(99, 27);
                yield return new los(100, 13);
                yield return new los(101, 6);
                yield return new los(102, 7);
                yield return new los(103, 10);
                yield return new los(104, 12);
                yield return new los(105, 3);
                yield return new los(106, 17);
                yield return new los(107, 30);
                yield return new los(108, 3);
                yield return new los(109, 13);
                yield return new los(110, 13);
                yield return new los(111, 9);
                yield return new los(112, 29);
                yield return new los(113, 4);
                yield return new los(114, 4);
                yield return new los(115, 18);
                yield return new los(116, 7);
                yield return new los(117, 23);
                yield return new los(118, 4);
                yield return new los(119, 20);
                yield return new los(120, 3);
                yield return new los(121, 9);
                yield return new los(122, 4);
                yield return new los(123, 4);
                yield return new los(124, 3);
                yield return new los(125, 3);
                yield return new los(126, 5);
                yield return new los(127, 32);
                yield return new los(128, 11);
                yield return new los(129, 3);
                yield return new los(130, 4);
                yield return new los(131, 5);
                yield return new los(132, 10);
                yield return new los(133, 12);
                yield return new los(134, 7);
                yield return new los(135, 4);
                yield return new los(136, 13);
                yield return new los(137, 10);
                yield return new los(138, 11);
                yield return new los(139, 37);
                yield return new los(140, 6);
                yield return new los(141, 8);
                yield return new los(142, 6);
                yield return new los(143, 3);
                yield return new los(144, 12);
                yield return new los(145, 8);
                yield return new los(146, 10);
                yield return new los(147, 6);
                yield return new los(148, 12);
                yield return new los(149, 7);
                yield return new los(150, 8);
                yield return new los(151, 9);
                yield return new los(152, 5);
                yield return new los(153, 6);
                yield return new los(154, 12);
                yield return new los(155, 5);
                yield return new los(156, 4);
                yield return new los(157, 24);
                yield return new los(158, 7);
                yield return new los(159, 2);
                yield return new los(160, 9);
                yield return new los(161, 2);
                yield return new los(162, 4);
                yield return new los(163, 3);
                yield return new los(164, 8);
                yield return new los(165, 5);
                yield return new los(166, 10);
                yield return new los(167, 5);
                yield return new los(168, 4);
                yield return new los(169, 4);
                yield return new los(170, 7);
                yield return new los(171, 4);
                yield return new los(172, 7);
                yield return new los(173, 7);
                yield return new los(174, 4);
                yield return new los(175, 16);
                yield return new los(176, 4);
                yield return new los(177, 3);
                yield return new los(178, 12);
                yield return new los(179, 4);
                yield return new los(180, 3);
                yield return new los(181, 10);
                yield return new los(182, 27);
                yield return new los(183, 4);
                yield return new los(184, 14);
                yield return new los(185, 7);
                yield return new los(186, 10);
                yield return new los(187, 4);
                yield return new los(188, 9);
                yield return new los(189, 8);
                yield return new los(190, 3);
                yield return new los(191, 5);
                yield return new los(192, 3);
                yield return new los(193, 8);
                yield return new los(194, 5);
                yield return new los(195, 2);
                yield return new los(196, 8);
                yield return new los(197, 38);
                yield return new los(198, 3);
                yield return new los(199, 3);
                yield return new los(200, 3);
                yield return new los(201, 4);
            }
        }
    }
}
