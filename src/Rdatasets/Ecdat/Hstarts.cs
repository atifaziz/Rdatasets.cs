// ReSharper disable All

namespace Rdatasets.Ecdat
{
    using System.Collections.Generic;

    /// <summary>
    /// Housing Starts
    /// </summary>

    public class Hstarts
    {
        public readonly int κ;
        public readonly double hs;
        public readonly double? hssa;

        public Hstarts(int κ, double hs, double? hssa)
        {
            this.κ = κ;
            this.hs = hs;
            this.hssa = hssa;
        }

        public static IEnumerable<Hstarts> Data
        {
            get
            {
                yield return new Hstarts(1, 7.98933, null);
                yield return new Hstarts(2, 8.83961, null);
                yield return new Hstarts(3, 8.94841, null);
                yield return new Hstarts(4, 8.98907, null);
                yield return new Hstarts(5, 8.39087, null);
                yield return new Hstarts(6, 9.09204, null);
                yield return new Hstarts(7, 9.12005, null);
                yield return new Hstarts(8, 9.04617, null);
                yield return new Hstarts(9, 8.41013, null);
                yield return new Hstarts(10, 9.22375, null);
                yield return new Hstarts(11, 9.21443, null);
                yield return new Hstarts(12, 9.14145, null);
                yield return new Hstarts(13, 8.45105, null);
                yield return new Hstarts(14, 9.27685, null);
                yield return new Hstarts(15, 9.33756, null);
                yield return new Hstarts(16, 9.45561, null);
                yield return new Hstarts(17, 8.77976, null);
                yield return new Hstarts(18, 9.27263, null);
                yield return new Hstarts(19, 9.41833, null);
                yield return new Hstarts(20, 9.62011, null);
                yield return new Hstarts(21, 8.75794, null);
                yield return new Hstarts(22, 9.43931, null);
                yield return new Hstarts(23, 9.4839, null);
                yield return new Hstarts(24, 9.47211, null);
                yield return new Hstarts(25, 8.79664, 9.27878);
                yield return new Hstarts(26, 9.11291, 8.91036);
                yield return new Hstarts(27, 9.1644, 9.04028);
                yield return new Hstarts(28, 9.29422, 9.16517);
                yield return new Hstarts(29, 8.48501, 9.02635);
                yield return new Hstarts(30, 9.54072, 9.39636);
                yield return new Hstarts(31, 9.54173, 9.4611);
                yield return new Hstarts(32, 9.32963, 9.28318);
                yield return new Hstarts(33, 8.94546, 9.45438);
                yield return new Hstarts(34, 9.65637, 9.51024);
                yield return new Hstarts(35, 9.53218, 9.41622);
                yield return new Hstarts(36, 9.74087, 9.65592);
                yield return new Hstarts(37, 9.33424, 9.8145);
                yield return new Hstarts(38, 9.74377, 9.58554);
                yield return new Hstarts(39, 9.62086, 9.44651);
                yield return new Hstarts(40, 9.48319, 9.30565);
                yield return new Hstarts(41, 8.77168, 9.23585);
                yield return new Hstarts(42, 9.2078, 9.13058);
                yield return new Hstarts(43, 9.5531, 9.47121);
                yield return new Hstarts(44, 9.8945, 9.79333);
                yield return new Hstarts(45, 8.98494, 9.45001);
                yield return new Hstarts(46, 9.72167, 9.65538);
                yield return new Hstarts(47, 9.79269, 9.67808);
                yield return new Hstarts(48, 9.78452, 9.68191);
                yield return new Hstarts(49, 9.32732, 9.77723);
                yield return new Hstarts(50, 9.87133, 9.76534);
                yield return new Hstarts(51, 9.89598, 9.76884);
                yield return new Hstarts(52, 9.82695, 9.71229);
                yield return new Hstarts(53, 9.31671, 9.77707);
                yield return new Hstarts(54, 9.88422, 9.77881);
                yield return new Hstarts(55, 9.93495, 9.80413);
                yield return new Hstarts(56, 9.85924, 9.74537);
                yield return new Hstarts(57, 9.38782, 9.8029);
                yield return new Hstarts(58, 9.81992, 9.65787);
                yield return new Hstarts(59, 9.60643, 9.45394);
                yield return new Hstarts(60, 9.33082, 9.20672);
                yield return new Hstarts(61, 8.7197, 9.21726);
                yield return new Hstarts(62, 9.64702, 9.55117);
                yield return new Hstarts(63, 9.81971, 9.7525);
                yield return new Hstarts(64, 9.93424, 9.87231);
                yield return new Hstarts(65, 9.41461, 9.83747);
                yield return new Hstarts(66, 9.94131, 9.8189);
                yield return new Hstarts(67, 9.83033, 9.70402);
                yield return new Hstarts(68, 9.81435, 9.69841);
                yield return new Hstarts(69, 9.21837, 9.6367);
                yield return new Hstarts(70, 9.85179, 9.76964);
                yield return new Hstarts(71, 9.85837, 9.77676);
                yield return new Hstarts(72, 9.82785, 9.70147);
                yield return new Hstarts(73, 9.51044, 9.84956);
                yield return new Hstarts(74, 9.62183, 9.50405);
                yield return new Hstarts(75, 9.66669, 9.52819);
                yield return new Hstarts(76, 9.62811, 9.50549);
                yield return new Hstarts(77, 9.07376, 9.43615);
                yield return new Hstarts(78, 9.52627, 9.41328);
                yield return new Hstarts(79, 9.51131, 9.41373);
                yield return new Hstarts(80, 9.59028, 9.51147);
                yield return new Hstarts(81, 8.94841, 9.23936);
                yield return new Hstarts(82, 9.23204, 9.11021);
                yield return new Hstarts(83, 9.33353, 9.26256);
                yield return new Hstarts(84, 9.42907, 9.37326);
                yield return new Hstarts(85, 8.92435, 9.27774);
                yield return new Hstarts(86, 9.68676, 9.56373);
                yield return new Hstarts(87, 9.49022, 9.44123);
                yield return new Hstarts(88, 9.27191, 9.20978);
                yield return new Hstarts(89, 9.07742, 9.278);
                yield return new Hstarts(90, 9.09152, 8.93882);
                yield return new Hstarts(91, 8.85756, 8.8007);
                yield return new Hstarts(92, 9.23682, 9.20978);
                yield return new Hstarts(93, 8.96946, 9.36639);
                yield return new Hstarts(94, 9.7473, 9.53403);
                yield return new Hstarts(95, 9.19638, 9.1643);
                yield return new Hstarts(96, 9.201, 9.1701);
                yield return new Hstarts(97, 8.87905, 9.22441);
                yield return new Hstarts(98, 9.29149, 9.06499);
                yield return new Hstarts(99, 9.22674, 9.17874);
                yield return new Hstarts(100, 9.07879, 9.05499);
                yield return new Hstarts(101, 8.85371, 9.21533);
                yield return new Hstarts(102, 9.48976, 9.29932);
                yield return new Hstarts(103, 9.45644, 9.39659);
                yield return new Hstarts(104, 9.50711, 9.50673);
                yield return new Hstarts(105, 9.06678, 9.45263);
                yield return new Hstarts(106, 9.76025, 9.56119);
                yield return new Hstarts(107, 9.66453, 9.59579);
                yield return new Hstarts(108, 9.62982, 9.63142);
                yield return new Hstarts(109, 9.45355, 9.81024);
                yield return new Hstarts(110, 10.0233, 9.82192);
                yield return new Hstarts(111, 9.91106, 9.83895);
                yield return new Hstarts(112, 9.7007, 9.7047);
                yield return new Hstarts(113, 9.28863, 9.63996);
                yield return new Hstarts(114, 9.88458, 9.68554);
                yield return new Hstarts(115, 9.74936, 9.66689);
                yield return new Hstarts(116, 9.65686, 9.67826);
                yield return new Hstarts(117, 9.38154, 9.72698);
                yield return new Hstarts(118, 9.80212, 9.58075);
                yield return new Hstarts(119, 9.68537, 9.5842);
                yield return new Hstarts(120, 9.62163, 9.63633);
                yield return new Hstarts(121, 9.39831, 9.72549);
                yield return new Hstarts(122, 9.757, 9.53303);
                yield return new Hstarts(123, 9.36826, 9.27253);
                yield return new Hstarts(124, 9.12187, 9.11481);
                yield return new Hstarts(125, 8.55282, 8.94173);
                yield return new Hstarts(126, 9.4664, 9.26625);
                yield return new Hstarts(127, 9.47698, 9.42029);
                yield return new Hstarts(128, 9.40996, 9.45372);
                yield return new Hstarts(129, 8.95299, 9.34526);
                yield return new Hstarts(130, 9.59927, 9.39728);
                yield return new Hstarts(131, 9.46392, 9.35131);
                yield return new Hstarts(132, 9.33586, 9.35203);
                yield return new Hstarts(133, 8.84304, 9.25701);
                yield return new Hstarts(134, 9.48154, 9.26283);
                yield return new Hstarts(135, 9.39041, 9.29626);
                yield return new Hstarts(136, 9.33388, 9.34307);
                yield return new Hstarts(137, 8.84029, 9.25595);
                yield return new Hstarts(138, 9.55185, 9.34914);
                yield return new Hstarts(139, 9.37407, 9.28447);
                yield return new Hstarts(140, 9.17906, 9.17988);
                yield return new Hstarts(141, 8.63498, 9.08692);
                yield return new Hstarts(142, 9.09193, 8.88837);
                yield return new Hstarts(143, 8.98369, 8.85881);
                yield return new Hstarts(144, 8.90404, 8.89373);
                yield return new Hstarts(145, 8.43822, 8.87019);
                yield return new Hstarts(146, 9.24975, 9.04389);
                yield return new Hstarts(147, 9.21207, 9.08345);
                yield return new Hstarts(148, 9.09324, 9.10529);
                yield return new Hstarts(149, 8.80297, 9.25462);
                yield return new Hstarts(150, 9.42889, 9.22276);
                yield return new Hstarts(151, 9.35262, 9.24205);
                yield return new Hstarts(152, 9.25417, 9.25462);
                yield return new Hstarts(153, 8.86733, 9.25383);
                yield return new Hstarts(154, 9.37656, 9.17874);
                yield return new Hstarts(155, 9.24503, 9.13837);
                yield return new Hstarts(156, 9.17713, 9.18701);
                yield return new Hstarts(157, 8.84626, 9.2296);
                yield return new Hstarts(158, 9.44296, 9.25754);
                yield return new Hstarts(159, 9.36823, 9.25754);
                yield return new Hstarts(160, 9.3138, 9.30993);
                yield return new Hstarts(161, 8.95635, 9.32119);
                yield return new Hstarts(162, 9.41121, 9.23503);
                yield return new Hstarts(163, 9.42392, 9.34623);
                yield return new Hstarts(164, 9.33444, 9.31969);
                yield return new Hstarts(165, 9.02091, 9.36211);
                yield return new Hstarts(166, 9.54631, 9.38849);
                yield return new Hstarts(167, 9.43065, 9.34502);
                yield return new Hstarts(168, 9.44894, 9.44277);
            }
        }
    }
}
