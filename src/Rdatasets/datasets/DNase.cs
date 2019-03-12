// ReSharper disable All

namespace Rdatasets.datasets
{
    using System.Collections.Generic;

    /// <summary>
    /// Elisa assay of DNase
    /// </summary>

    public class DNase
    {
        public readonly int κ;
        public readonly int Run;
        public readonly double conc;
        public readonly double density;

        public DNase(int κ, int Run, double conc, double density)
        {
            this.κ = κ;
            this.Run = Run;
            this.conc = conc;
            this.density = density;
        }

        public static IEnumerable<DNase> Data
        {
            get
            {
                yield return new DNase(1, 1, 0.04882812, 0.017);
                yield return new DNase(2, 1, 0.04882812, 0.018);
                yield return new DNase(3, 1, 0.1953125, 0.121);
                yield return new DNase(4, 1, 0.1953125, 0.124);
                yield return new DNase(5, 1, 0.390625, 0.206);
                yield return new DNase(6, 1, 0.390625, 0.215);
                yield return new DNase(7, 1, 0.78125, 0.377);
                yield return new DNase(8, 1, 0.78125, 0.374);
                yield return new DNase(9, 1, 1.5625, 0.614);
                yield return new DNase(10, 1, 1.5625, 0.609);
                yield return new DNase(11, 1, 3.125, 1.019);
                yield return new DNase(12, 1, 3.125, 1.001);
                yield return new DNase(13, 1, 6.25, 1.334);
                yield return new DNase(14, 1, 6.25, 1.364);
                yield return new DNase(15, 1, 12.5, 1.73);
                yield return new DNase(16, 1, 12.5, 1.71);
                yield return new DNase(17, 2, 0.04882812, 0.045);
                yield return new DNase(18, 2, 0.04882812, 0.05);
                yield return new DNase(19, 2, 0.1953125, 0.137);
                yield return new DNase(20, 2, 0.1953125, 0.123);
                yield return new DNase(21, 2, 0.390625, 0.225);
                yield return new DNase(22, 2, 0.390625, 0.207);
                yield return new DNase(23, 2, 0.78125, 0.401);
                yield return new DNase(24, 2, 0.78125, 0.383);
                yield return new DNase(25, 2, 1.5625, 0.672);
                yield return new DNase(26, 2, 1.5625, 0.681);
                yield return new DNase(27, 2, 3.125, 1.116);
                yield return new DNase(28, 2, 3.125, 1.078);
                yield return new DNase(29, 2, 6.25, 1.554);
                yield return new DNase(30, 2, 6.25, 1.526);
                yield return new DNase(31, 2, 12.5, 1.932);
                yield return new DNase(32, 2, 12.5, 1.914);
                yield return new DNase(33, 3, 0.04882812, 0.07);
                yield return new DNase(34, 3, 0.04882812, 0.068);
                yield return new DNase(35, 3, 0.1953125, 0.173);
                yield return new DNase(36, 3, 0.1953125, 0.165);
                yield return new DNase(37, 3, 0.390625, 0.277);
                yield return new DNase(38, 3, 0.390625, 0.248);
                yield return new DNase(39, 3, 0.78125, 0.434);
                yield return new DNase(40, 3, 0.78125, 0.426);
                yield return new DNase(41, 3, 1.5625, 0.703);
                yield return new DNase(42, 3, 1.5625, 0.689);
                yield return new DNase(43, 3, 3.125, 1.067);
                yield return new DNase(44, 3, 3.125, 1.077);
                yield return new DNase(45, 3, 6.25, 1.629);
                yield return new DNase(46, 3, 6.25, 1.479);
                yield return new DNase(47, 3, 12.5, 2.003);
                yield return new DNase(48, 3, 12.5, 1.884);
                yield return new DNase(49, 4, 0.04882812, 0.011);
                yield return new DNase(50, 4, 0.04882812, 0.016);
                yield return new DNase(51, 4, 0.1953125, 0.118);
                yield return new DNase(52, 4, 0.1953125, 0.108);
                yield return new DNase(53, 4, 0.390625, 0.2);
                yield return new DNase(54, 4, 0.390625, 0.206);
                yield return new DNase(55, 4, 0.78125, 0.364);
                yield return new DNase(56, 4, 0.78125, 0.36);
                yield return new DNase(57, 4, 1.5625, 0.62);
                yield return new DNase(58, 4, 1.5625, 0.64);
                yield return new DNase(59, 4, 3.125, 0.979);
                yield return new DNase(60, 4, 3.125, 0.973);
                yield return new DNase(61, 4, 6.25, 1.424);
                yield return new DNase(62, 4, 6.25, 1.399);
                yield return new DNase(63, 4, 12.5, 1.74);
                yield return new DNase(64, 4, 12.5, 1.732);
                yield return new DNase(65, 5, 0.04882812, 0.035);
                yield return new DNase(66, 5, 0.04882812, 0.035);
                yield return new DNase(67, 5, 0.1953125, 0.132);
                yield return new DNase(68, 5, 0.1953125, 0.135);
                yield return new DNase(69, 5, 0.390625, 0.224);
                yield return new DNase(70, 5, 0.390625, 0.22);
                yield return new DNase(71, 5, 0.78125, 0.385);
                yield return new DNase(72, 5, 0.78125, 0.39);
                yield return new DNase(73, 5, 1.5625, 0.658);
                yield return new DNase(74, 5, 1.5625, 0.647);
                yield return new DNase(75, 5, 3.125, 1.06);
                yield return new DNase(76, 5, 3.125, 1.031);
                yield return new DNase(77, 5, 6.25, 1.425);
                yield return new DNase(78, 5, 6.25, 1.409);
                yield return new DNase(79, 5, 12.5, 1.75);
                yield return new DNase(80, 5, 12.5, 1.738);
                yield return new DNase(81, 6, 0.04882812, 0.086);
                yield return new DNase(82, 6, 0.04882812, 0.103);
                yield return new DNase(83, 6, 0.1953125, 0.191);
                yield return new DNase(84, 6, 0.1953125, 0.189);
                yield return new DNase(85, 6, 0.390625, 0.272);
                yield return new DNase(86, 6, 0.390625, 0.277);
                yield return new DNase(87, 6, 0.78125, 0.44);
                yield return new DNase(88, 6, 0.78125, 0.426);
                yield return new DNase(89, 6, 1.5625, 0.686);
                yield return new DNase(90, 6, 1.5625, 0.676);
                yield return new DNase(91, 6, 3.125, 1.062);
                yield return new DNase(92, 6, 3.125, 1.072);
                yield return new DNase(93, 6, 6.25, 1.424);
                yield return new DNase(94, 6, 6.25, 1.459);
                yield return new DNase(95, 6, 12.5, 1.768);
                yield return new DNase(96, 6, 12.5, 1.806);
                yield return new DNase(97, 7, 0.04882812, 0.094);
                yield return new DNase(98, 7, 0.04882812, 0.092);
                yield return new DNase(99, 7, 0.1953125, 0.182);
                yield return new DNase(100, 7, 0.1953125, 0.182);
                yield return new DNase(101, 7, 0.390625, 0.282);
                yield return new DNase(102, 7, 0.390625, 0.273);
                yield return new DNase(103, 7, 0.78125, 0.444);
                yield return new DNase(104, 7, 0.78125, 0.439);
                yield return new DNase(105, 7, 1.5625, 0.686);
                yield return new DNase(106, 7, 1.5625, 0.668);
                yield return new DNase(107, 7, 3.125, 1.052);
                yield return new DNase(108, 7, 3.125, 1.035);
                yield return new DNase(109, 7, 6.25, 1.409);
                yield return new DNase(110, 7, 6.25, 1.392);
                yield return new DNase(111, 7, 12.5, 1.759);
                yield return new DNase(112, 7, 12.5, 1.739);
                yield return new DNase(113, 8, 0.04882812, 0.054);
                yield return new DNase(114, 8, 0.04882812, 0.054);
                yield return new DNase(115, 8, 0.1953125, 0.152);
                yield return new DNase(116, 8, 0.1953125, 0.148);
                yield return new DNase(117, 8, 0.390625, 0.226);
                yield return new DNase(118, 8, 0.390625, 0.222);
                yield return new DNase(119, 8, 0.78125, 0.392);
                yield return new DNase(120, 8, 0.78125, 0.383);
                yield return new DNase(121, 8, 1.5625, 0.658);
                yield return new DNase(122, 8, 1.5625, 0.644);
                yield return new DNase(123, 8, 3.125, 1.043);
                yield return new DNase(124, 8, 3.125, 1.002);
                yield return new DNase(125, 8, 6.25, 1.466);
                yield return new DNase(126, 8, 6.25, 1.381);
                yield return new DNase(127, 8, 12.5, 1.743);
                yield return new DNase(128, 8, 12.5, 1.724);
                yield return new DNase(129, 9, 0.04882812, 0.032);
                yield return new DNase(130, 9, 0.04882812, 0.043);
                yield return new DNase(131, 9, 0.1953125, 0.142);
                yield return new DNase(132, 9, 0.1953125, 0.155);
                yield return new DNase(133, 9, 0.390625, 0.239);
                yield return new DNase(134, 9, 0.390625, 0.242);
                yield return new DNase(135, 9, 0.78125, 0.42);
                yield return new DNase(136, 9, 0.78125, 0.395);
                yield return new DNase(137, 9, 1.5625, 0.624);
                yield return new DNase(138, 9, 1.5625, 0.705);
                yield return new DNase(139, 9, 3.125, 1.046);
                yield return new DNase(140, 9, 3.125, 1.026);
                yield return new DNase(141, 9, 6.25, 1.398);
                yield return new DNase(142, 9, 6.25, 1.405);
                yield return new DNase(143, 9, 12.5, 1.693);
                yield return new DNase(144, 9, 12.5, 1.729);
                yield return new DNase(145, 10, 0.04882812, 0.052);
                yield return new DNase(146, 10, 0.04882812, 0.094);
                yield return new DNase(147, 10, 0.1953125, 0.164);
                yield return new DNase(148, 10, 0.1953125, 0.166);
                yield return new DNase(149, 10, 0.390625, 0.259);
                yield return new DNase(150, 10, 0.390625, 0.256);
                yield return new DNase(151, 10, 0.78125, 0.439);
                yield return new DNase(152, 10, 0.78125, 0.439);
                yield return new DNase(153, 10, 1.5625, 0.69);
                yield return new DNase(154, 10, 1.5625, 0.701);
                yield return new DNase(155, 10, 3.125, 1.042);
                yield return new DNase(156, 10, 3.125, 1.075);
                yield return new DNase(157, 10, 6.25, 1.34);
                yield return new DNase(158, 10, 6.25, 1.406);
                yield return new DNase(159, 10, 12.5, 1.699);
                yield return new DNase(160, 10, 12.5, 1.708);
                yield return new DNase(161, 11, 0.04882812, 0.047);
                yield return new DNase(162, 11, 0.04882812, 0.057);
                yield return new DNase(163, 11, 0.1953125, 0.159);
                yield return new DNase(164, 11, 0.1953125, 0.155);
                yield return new DNase(165, 11, 0.390625, 0.246);
                yield return new DNase(166, 11, 0.390625, 0.252);
                yield return new DNase(167, 11, 0.78125, 0.427);
                yield return new DNase(168, 11, 0.78125, 0.411);
                yield return new DNase(169, 11, 1.5625, 0.704);
                yield return new DNase(170, 11, 1.5625, 0.684);
                yield return new DNase(171, 11, 3.125, 0.994);
                yield return new DNase(172, 11, 3.125, 0.98);
                yield return new DNase(173, 11, 6.25, 1.421);
                yield return new DNase(174, 11, 6.25, 1.385);
                yield return new DNase(175, 11, 12.5, 1.715);
                yield return new DNase(176, 11, 12.5, 1.721);
            }
        }
    }
}
