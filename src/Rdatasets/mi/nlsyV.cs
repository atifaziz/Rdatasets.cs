// ReSharper disable All

namespace Rdatasets.mi
{
    using System.Collections.Generic;

    /// <summary>
    /// National Longitudinal Survey of Youth Extract
    /// </summary>

    public class nlsyV
    {
        public readonly int? ppvtr_36;
        public readonly int first;
        public readonly int? b_marr;
        public readonly int? income;
        public readonly int momage;
        public readonly int? momed;
        public readonly int? momrace;

        public nlsyV(int? ppvtr_36, int first, int? b_marr, int? income, int momage, int? momed, int? momrace)
        {
            this.ppvtr_36 = ppvtr_36;
            this.first = first;
            this.b_marr = b_marr;
            this.income = income;
            this.momage = momage;
            this.momed = momed;
            this.momrace = momrace;
        }

        public static IEnumerable<nlsyV> Data
        {
            get
            {
                yield return new nlsyV(105, 1, 1, 21446, 20, 2, 3);
                yield return new nlsyV(91, 1, 1, 12125, 22, 2, 3);
                yield return new nlsyV(89, 0, 1, 13560, 22, 2, 1);
                yield return new nlsyV(85, 0, 1, 24500, 28, 3, null);
                yield return new nlsyV(66, 0, 0, 3304, 20, 1, null);
                yield return new nlsyV(null, 0, 0, 5832, 27, 2, null);
                yield return new nlsyV(92, 1, 0, 17022, 26, 2, 3);
                yield return new nlsyV(94, 1, 1, 13000, 23, 3, 3);
                yield return new nlsyV(124, 1, 1, 30100, 25, 4, null);
                yield return new nlsyV(null, 1, 1, 34424, 26, 3, 2);
                yield return new nlsyV(83, 0, 0, 17500, 23, 3, 1);
                yield return new nlsyV(69, 1, 0, 25000, 20, 3, 1);
                yield return new nlsyV(null, 0, 1, 22153, 27, 2, 2);
                yield return new nlsyV(87, 0, 1, null, 21, 1, null);
                yield return new nlsyV(41, 0, 1, 46000, 25, 1, 2);
                yield return new nlsyV(null, 0, 1, null, 27, 3, null);
                yield return new nlsyV(null, 1, 1, 2441, 23, 2, 2);
                yield return new nlsyV(97, 1, 1, 25600, 23, 2, 3);
                yield return new nlsyV(76, 0, 0, 0, 24, 1, 2);
                yield return new nlsyV(115, 1, 1, 39700, 24, 2, 3);
                yield return new nlsyV(106, 0, 1, null, 28, null, 3);
                yield return new nlsyV(57, 0, 1, 5016, 25, 1, 2);
                yield return new nlsyV(92, 0, 0, 18000, 28, 2, 3);
                yield return new nlsyV(null, 0, 1, 44800, 27, 4, 3);
                yield return new nlsyV(null, 0, 1, 18650, 29, 2, 3);
                yield return new nlsyV(75, 1, 1, 14040, 25, 2, null);
                yield return new nlsyV(69, 1, 0, 5200, 25, 3, 2);
                yield return new nlsyV(104, 1, 1, 21600, 26, 3, null);
                yield return new nlsyV(52, 0, 1, null, 22, 2, null);
                yield return new nlsyV(83, 0, 1, 24640, 25, 2, 3);
                yield return new nlsyV(120, 0, 1, null, 28, 2, 3);
                yield return new nlsyV(70, 0, 0, 6384, 24, 1, 1);
                yield return new nlsyV(82, 0, 1, 10200, 24, 2, 2);
                yield return new nlsyV(66, 0, 1, null, 28, 3, 2);
                yield return new nlsyV(44, 0, 1, null, 25, 1, 2);
                yield return new nlsyV(55, 0, 1, 32000, 25, 3, null);
                yield return new nlsyV(null, 0, 0, 6096, 26, null, 1);
                yield return new nlsyV(106, 1, 1, 37000, 26, 1, 3);
                yield return new nlsyV(74, 0, 1, 17528, 26, 1, null);
                yield return new nlsyV(88, 1, 0, 4410, 19, null, null);
                yield return new nlsyV(null, 1, 0, 0, 23, 1, 1);
                yield return new nlsyV(72, 1, 1, 94000, 28, 2, null);
                yield return new nlsyV(74, 0, 1, 6696, 21, 1, 3);
                yield return new nlsyV(50, 0, 1, null, 24, 3, 2);
                yield return new nlsyV(99, 1, 1, 28350, 24, 4, 3);
                yield return new nlsyV(107, 0, 1, 31000, 26, 3, 3);
                yield return new nlsyV(90, 0, 1, 23000, 21, 2, 1);
                yield return new nlsyV(null, 1, null, null, 23, 3, 3);
                yield return new nlsyV(132, 0, 1, 23490, 24, 3, 3);
                yield return new nlsyV(87, 0, 0, 1343, 19, 1, null);
                yield return new nlsyV(null, 1, 1, null, 26, null, 3);
                yield return new nlsyV(null, 0, 1, 57720, 23, 3, 3);
                yield return new nlsyV(null, 0, 0, null, 23, 2, null);
                yield return new nlsyV(null, 0, 1, 12810, 28, 3, 3);
                yield return new nlsyV(85, 1, 0, 15000, 20, 2, 1);
                yield return new nlsyV(78, 0, 1, 13000, 24, 1, 3);
                yield return new nlsyV(95, 0, 1, 99000, 29, 4, 3);
                yield return new nlsyV(103, 0, 1, 15960, 18, 1, 2);
                yield return new nlsyV(70, 1, 0, 4820, 23, 1, 1);
                yield return new nlsyV(null, 1, 1, null, 26, 2, null);
                yield return new nlsyV(54, 0, 0, 7164, 21, 1, null);
                yield return new nlsyV(null, 0, 0, null, 23, 1, 1);
                yield return new nlsyV(84, 0, 1, 19315, 29, 3, 3);
                yield return new nlsyV(87, 0, 1, 65750, 31, 4, 3);
                yield return new nlsyV(92, 0, 1, 11750, 22, 2, 3);
                yield return new nlsyV(59, 1, 0, null, 23, 1, null);
                yield return new nlsyV(79, 0, 1, 28500, 25, 2, 2);
                yield return new nlsyV(53, 0, null, null, 26, 1, 3);
                yield return new nlsyV(87, 1, null, null, 26, 1, 3);
                yield return new nlsyV(93, 1, 0, 25000, 21, 2, 1);
                yield return new nlsyV(null, 0, 1, 27000, 28, 3, 2);
                yield return new nlsyV(96, 1, 1, null, 19, 2, null);
                yield return new nlsyV(124, 1, 1, 60500, 31, 4, 3);
                yield return new nlsyV(58, 1, 0, null, 19, 2, 1);
                yield return new nlsyV(116, 0, 1, 32050, 26, null, 3);
                yield return new nlsyV(null, 0, 1, 9000, 21, 1, 2);
                yield return new nlsyV(null, 0, 1, 72800, 24, 3, 3);
                yield return new nlsyV(106, 0, 1, 21300, 23, 3, 3);
                yield return new nlsyV(null, 0, 1, 34000, 26, 2, 3);
                yield return new nlsyV(null, 0, 1, 19000, 24, 2, 3);
                yield return new nlsyV(null, 0, 1, 13418, 27, 2, null);
                yield return new nlsyV(89, 1, 1, 14500, 19, 1, 3);
                yield return new nlsyV(83, 0, 1, null, 18, 1, 3);
                yield return new nlsyV(83, 1, 1, 38047, 23, null, 2);
                yield return new nlsyV(78, 0, 0, 1000, 21, 1, 2);
                yield return new nlsyV(106, 1, 1, null, 22, 4, null);
                yield return new nlsyV(98, 1, 1, 29674, 21, 3, 3);
                yield return new nlsyV(70, 0, 1, null, 24, 1, 2);
                yield return new nlsyV(104, 0, 1, 47776, 27, 3, 1);
                yield return new nlsyV(90, 0, 1, null, 29, 3, null);
                yield return new nlsyV(null, 0, 1, null, 29, 2, 3);
                yield return new nlsyV(72, 1, 0, null, 22, 2, null);
                yield return new nlsyV(81, 0, 1, 43020, 26, 2, 3);
                yield return new nlsyV(80, 0, 1, 9400, 24, 1, 3);
                yield return new nlsyV(88, 1, 0, 3420, 21, 2, 1);
                yield return new nlsyV(86, 1, 1, 28506, 23, 1, 3);
                yield return new nlsyV(79, 0, 1, 12056, 18, 1, 2);
                yield return new nlsyV(null, 0, 1, 24700, 27, 2, 3);
                yield return new nlsyV(104, 0, 1, 12000, 20, 1, 2);
                yield return new nlsyV(66, 1, 1, null, 22, null, null);
                yield return new nlsyV(88, 1, 1, 40200, 26, 3, 3);
                yield return new nlsyV(46, 0, 1, 13000, 28, 3, 2);
                yield return new nlsyV(72, 0, 0, 2532, 23, null, 1);
                yield return new nlsyV(86, 0, 1, 17501, 23, 2, 3);
                yield return new nlsyV(72, 0, 1, 20180, 21, 2, 3);
                yield return new nlsyV(87, 1, 0, 16000, 21, 3, 1);
                yield return new nlsyV(82, 1, 1, null, 22, 2, 2);
                yield return new nlsyV(92, 1, 1, 25000, 25, 2, 3);
                yield return new nlsyV(122, 0, 1, 39350, 27, 3, 3);
                yield return new nlsyV(122, 1, 1, 42043, 22, 3, 3);
                yield return new nlsyV(91, 1, 0, null, 25, 2, null);
                yield return new nlsyV(52, 1, 0, 410, 19, 2, 1);
                yield return new nlsyV(99, 1, 1, null, 17, 1, null);
                yield return new nlsyV(102, 1, 1, 32328, 23, 2, 3);
                yield return new nlsyV(null, 1, 1, 21600, 22, 2, 2);
                yield return new nlsyV(91, 0, 0, 26464, 19, 2, null);
                yield return new nlsyV(86, 0, 0, 4716, 28, 1, null);
                yield return new nlsyV(75, 0, 1, 10400, 23, 1, 3);
                yield return new nlsyV(99, 0, 1, 33054, 26, 2, 3);
                yield return new nlsyV(105, 0, 1, null, 20, 1, null);
                yield return new nlsyV(null, 1, 0, 74000, 28, 3, null);
                yield return new nlsyV(70, 0, 0, null, 23, 3, null);
                yield return new nlsyV(84, 0, 1, 14588, 23, 3, null);
                yield return new nlsyV(83, 0, 1, 17000, 26, 1, null);
                yield return new nlsyV(108, 1, 0, 7800, 26, 3, 3);
                yield return new nlsyV(87, 1, 1, 49000, 32, 3, 3);
                yield return new nlsyV(null, 1, 1, 26800, 30, null, 1);
                yield return new nlsyV(91, 1, 1, 15418, 21, 3, 3);
                yield return new nlsyV(104, 0, 1, 3634, 19, 1, 3);
                yield return new nlsyV(94, 0, 0, 7022, 23, 1, 3);
                yield return new nlsyV(null, 1, null, null, 25, null, null);
                yield return new nlsyV(null, 0, 0, 5952, 23, 1, 3);
                yield return new nlsyV(89, 0, 1, 40568, 25, 2, 3);
                yield return new nlsyV(null, 0, 1, null, 26, 2, 1);
                yield return new nlsyV(73, 0, 0, 5172, 21, 1, null);
                yield return new nlsyV(95, 0, 0, 16000, 25, 1, 3);
                yield return new nlsyV(null, 1, 0, 12000, 22, 2, null);
                yield return new nlsyV(null, 1, 0, 15000, 20, 2, 1);
                yield return new nlsyV(90, 1, 0, 4024, 22, null, 1);
                yield return new nlsyV(62, 0, 1, 5625, 24, 2, null);
                yield return new nlsyV(63, 0, 1, 53000, 28, 1, 2);
                yield return new nlsyV(131, 1, 0, 12000, 24, 4, null);
                yield return new nlsyV(null, 0, 1, 7879, 24, 1, 2);
                yield return new nlsyV(106, 1, 1, 20480, 23, 3, 3);
                yield return new nlsyV(114, 0, 1, 1057448, 29, 4, 3);
                yield return new nlsyV(62, 0, 1, 12000, 25, 3, null);
                yield return new nlsyV(91, 0, 0, 27000, 25, 3, null);
                yield return new nlsyV(100, 1, 1, 24000, 18, 2, 2);
                yield return new nlsyV(82, 0, 0, 5768, 20, 1, null);
                yield return new nlsyV(79, 0, 1, 14709, 23, 2, 2);
                yield return new nlsyV(88, 1, 1, 9556, 18, 1, 3);
                yield return new nlsyV(null, 1, 1, 23353, 19, 2, 3);
                yield return new nlsyV(72, 0, 0, 6786, 20, 1, 2);
                yield return new nlsyV(91, 1, 1, 34020, 25, 2, null);
                yield return new nlsyV(76, 0, 1, 23700, 20, 2, 2);
                yield return new nlsyV(87, 1, 0, null, 25, 3, null);
                yield return new nlsyV(82, 0, 0, 5205, 24, null, 1);
                yield return new nlsyV(65, 0, 1, 23000, 26, 3, null);
                yield return new nlsyV(null, 0, 0, 11000, 24, null, 2);
                yield return new nlsyV(null, 1, 1, 8000, 29, 2, 2);
                yield return new nlsyV(102, 0, 1, 20100, 27, null, 3);
                yield return new nlsyV(57, 0, 1, 6000, 22, null, 2);
                yield return new nlsyV(105, 0, 1, 47000, 31, null, 3);
                yield return new nlsyV(67, 0, 0, 4440, 23, 1, 1);
                yield return new nlsyV(90, 1, 1, 23000, 22, 2, 3);
                yield return new nlsyV(null, 0, 0, 3542, 27, 1, null);
                yield return new nlsyV(97, 0, 1, 19000, 26, null, 3);
                yield return new nlsyV(69, 1, 1, 12766, 20, 2, 3);
                yield return new nlsyV(83, 0, 0, 4728, 27, 2, null);
                yield return new nlsyV(58, 1, 1, null, 27, 1, 2);
                yield return new nlsyV(110, 1, 1, 37150, 26, 3, null);
                yield return new nlsyV(109, 1, 1, 30000, 22, 3, 2);
                yield return new nlsyV(88, 0, 1, 16100, 26, 1, null);
                yield return new nlsyV(94, 0, 1, 100001, 28, 4, 3);
                yield return new nlsyV(70, 1, 1, 7500, 23, 2, 2);
                yield return new nlsyV(98, 1, 1, 11005, 24, 2, null);
                yield return new nlsyV(113, 1, 1, 34100, 30, 2, 3);
                yield return new nlsyV(106, 1, 1, 31540, 23, 3, 3);
                yield return new nlsyV(117, 1, 1, 37386, 27, 3, 3);
                yield return new nlsyV(80, 1, 0, 35000, 20, 1, 1);
                yield return new nlsyV(78, 0, 1, 25102, 21, 1, 2);
                yield return new nlsyV(77, 0, 1, 9000, 24, 2, 2);
                yield return new nlsyV(null, 0, 1, 38050, 28, 2, 2);
                yield return new nlsyV(127, 0, 1, 15532, 21, 2, 3);
                yield return new nlsyV(96, 1, 1, 5000, 17, 1, null);
                yield return new nlsyV(null, 0, 0, 15000, 25, 1, 3);
                yield return new nlsyV(41, 1, 0, 25000, 16, 1, 1);
                yield return new nlsyV(88, 0, 0, null, 24, 2, 1);
                yield return new nlsyV(88, 0, 1, 31304, 29, 3, 1);
                yield return new nlsyV(null, 0, 0, 17500, 22, 2, null);
                yield return new nlsyV(84, 0, null, null, 21, 2, 1);
                yield return new nlsyV(97, 0, 0, 11400, 24, 3, null);
                yield return new nlsyV(102, 0, 1, 27500, 24, 1, 3);
                yield return new nlsyV(null, 0, 1, 11220, 21, 1, null);
                yield return new nlsyV(59, 1, 0, null, 18, 2, 1);
                yield return new nlsyV(77, 1, 0, null, 20, 2, 1);
                yield return new nlsyV(89, 1, null, null, 27, 4, null);
                yield return new nlsyV(55, 0, 0, 4692, 25, null, null);
                yield return new nlsyV(null, 0, 0, 6816, 27, 1, null);
                yield return new nlsyV(59, 0, 0, 6000, 22, 2, 1);
                yield return new nlsyV(72, 0, 0, 12000, 28, 3, null);
                yield return new nlsyV(108, 0, 1, 46020, 28, 2, 3);
                yield return new nlsyV(74, 0, 1, 16800, 28, 3, 1);
                yield return new nlsyV(95, 0, 0, 5220, 24, 2, null);
                yield return new nlsyV(112, 1, 1, 100001, 26, 4, 3);
                yield return new nlsyV(90, 1, 0, null, 20, 1, 2);
                yield return new nlsyV(92, 0, 1, null, 26, 2, 2);
                yield return new nlsyV(98, 1, 1, 18585, 23, 2, 3);
                yield return new nlsyV(78, 0, 1, null, 26, 2, 3);
                yield return new nlsyV(104, 0, 1, 8262, 22, 1, null);
                yield return new nlsyV(70, 0, 1, 15796, 20, 2, 2);
                yield return new nlsyV(101, 1, 1, 18000, 27, 2, 3);
                yield return new nlsyV(100, 0, 1, 10832, 23, 2, 3);
                yield return new nlsyV(null, 1, 1, 100001, 23, null, null);
                yield return new nlsyV(110, 1, 1, 44600, 24, 3, 3);
                yield return new nlsyV(58, 1, 1, 13000, 23, 3, null);
                yield return new nlsyV(52, 1, 1, 1446, 18, 2, 2);
                yield return new nlsyV(54, 1, 0, 6970, 21, 1, null);
                yield return new nlsyV(88, 0, 1, 14072, 24, 2, 3);
                yield return new nlsyV(84, 0, 0, null, 26, 4, null);
                yield return new nlsyV(101, 0, 0, 5040, 28, 1, 1);
                yield return new nlsyV(122, 1, 1, 18352, 18, 1, 3);
                yield return new nlsyV(90, 1, 1, null, 20, 2, 1);
                yield return new nlsyV(64, 1, 1, 35000, 23, 2, 2);
                yield return new nlsyV(null, 1, 1, 29550, 27, 3, 3);
                yield return new nlsyV(58, 0, 1, 21865, 26, 1, 2);
                yield return new nlsyV(69, 1, 1, null, 19, 2, 3);
                yield return new nlsyV(63, 0, 1, null, 25, null, 2);
                yield return new nlsyV(63, 0, 1, 27081, 25, 1, 3);
                yield return new nlsyV(108, 1, 1, 34150, 25, 1, 3);
                yield return new nlsyV(102, 1, 1, 26800, 22, 2, null);
                yield return new nlsyV(null, 1, null, null, 24, 2, 3);
                yield return new nlsyV(94, 0, 1, null, 27, 2, 3);
                yield return new nlsyV(103, 0, 1, 53200, 25, 3, null);
                yield return new nlsyV(82, 0, 1, 8002, 21, 1, 3);
                yield return new nlsyV(75, 0, 0, 5328, 27, 1, 1);
                yield return new nlsyV(91, 0, 1, null, 25, 2, null);
                yield return new nlsyV(null, 0, 1, 30000, 29, 4, 3);
                yield return new nlsyV(97, 1, 0, 3650, 19, 2, 3);
                yield return new nlsyV(81, 0, 1, 15000, 21, 2, null);
                yield return new nlsyV(88, 0, 1, 18150, 23, null, 3);
                yield return new nlsyV(64, 0, 1, 16745, 24, 1, 2);
                yield return new nlsyV(87, 0, 1, 14000, 26, 1, 3);
                yield return new nlsyV(65, 0, 1, 7712, 22, null, null);
                yield return new nlsyV(81, 0, 1, 34000, 30, 4, null);
                yield return new nlsyV(null, 0, 1, 44000, 28, null, 3);
                yield return new nlsyV(null, 1, 1, 24043, 22, 2, null);
                yield return new nlsyV(85, 1, 0, 37960, 19, 1, 3);
                yield return new nlsyV(109, 0, 1, 15300, 21, 1, null);
                yield return new nlsyV(80, 1, 0, 2520, 19, 1, null);
                yield return new nlsyV(105, 1, 1, 69000, 30, 4, 3);
                yield return new nlsyV(null, 0, 1, 26088, 24, null, 3);
                yield return new nlsyV(93, 1, 1, null, 23, 3, 3);
                yield return new nlsyV(52, 0, 1, 36000, 25, 2, 1);
                yield return new nlsyV(77, 0, 1, 41000, 29, 2, 3);
                yield return new nlsyV(52, 1, 1, 28400, 25, 3, 2);
                yield return new nlsyV(66, 1, 0, 5870, 19, 1, 3);
                yield return new nlsyV(null, 0, 1, 30000, 24, 1, 3);
                yield return new nlsyV(75, 0, 1, 39815, 23, 3, 3);
                yield return new nlsyV(64, 1, 1, 14725, 18, 1, 2);
                yield return new nlsyV(86, 1, 0, 4992, 18, 1, 1);
                yield return new nlsyV(90, 1, 0, 0, 21, 1, 3);
                yield return new nlsyV(82, 1, 0, 3890, 18, 2, 2);
                yield return new nlsyV(79, 0, 1, 46583, 26, 3, 3);
                yield return new nlsyV(104, 1, null, null, 24, 4, 1);
                yield return new nlsyV(108, 1, 1, 38300, 26, 3, 3);
                yield return new nlsyV(109, 0, 1, null, 24, null, null);
                yield return new nlsyV(109, 0, 1, 33100, 24, 3, 1);
                yield return new nlsyV(99, 0, 1, 36000, 30, 4, 3);
                yield return new nlsyV(null, 0, 0, 11680, 24, 3, null);
                yield return new nlsyV(52, 0, 1, 8562, 23, 1, 2);
                yield return new nlsyV(58, 0, 1, 17812, 29, 1, null);
                yield return new nlsyV(65, 1, 0, 4200, 17, 1, 3);
                yield return new nlsyV(66, 0, 1, 60000, 20, 2, null);
                yield return new nlsyV(null, 1, 1, 39143, 29, null, 3);
                yield return new nlsyV(86, 1, 0, 6000, 19, 2, 3);
                yield return new nlsyV(null, 0, 0, 3012, 22, 1, null);
                yield return new nlsyV(107, 1, 1, 21002, 21, 1, 3);
                yield return new nlsyV(null, 1, 1, 21000, 19, 2, 2);
                yield return new nlsyV(79, 1, 0, 12600, 21, 3, 1);
                yield return new nlsyV(87, 1, 0, null, 16, 1, 3);
                yield return new nlsyV(52, 0, 1, 10800, 26, 2, 2);
                yield return new nlsyV(87, 1, 1, 37341, 21, 2, null);
                yield return new nlsyV(100, 0, null, null, 26, 1, null);
                yield return new nlsyV(84, 1, 1, 12415, 25, 2, null);
                yield return new nlsyV(null, 0, 1, null, 23, 2, 3);
                yield return new nlsyV(114, 1, 1, null, 27, 2, 3);
                yield return new nlsyV(121, 1, 1, 51000, 28, 3, 3);
                yield return new nlsyV(70, 1, 1, null, 17, 1, 3);
                yield return new nlsyV(94, 1, 0, 24000, 21, null, null);
                yield return new nlsyV(null, 1, 1, 24000, 25, 3, null);
                yield return new nlsyV(114, 1, 1, 41030, 25, 2, 3);
                yield return new nlsyV(74, 0, 0, 2370, 22, 2, null);
                yield return new nlsyV(64, 1, 1, null, 26, 1, 2);
                yield return new nlsyV(54, 0, 0, 8292, 26, 1, 2);
                yield return new nlsyV(104, 0, 1, 18392, 20, 1, null);
                yield return new nlsyV(86, 0, 0, 6852, 21, null, null);
                yield return new nlsyV(null, 0, 0, 6636, 25, 1, 2);
                yield return new nlsyV(110, 1, 1, 21000, 25, null, null);
                yield return new nlsyV(72, 0, 1, 11596, 25, 1, 1);
                yield return new nlsyV(73, 0, 1, null, 26, 1, 2);
                yield return new nlsyV(99, 0, 0, 5268, 25, null, null);
                yield return new nlsyV(122, 1, 1, 1057448, 32, null, 3);
                yield return new nlsyV(129, 1, 1, 44080, 25, 2, 3);
                yield return new nlsyV(78, 0, 0, 13500, 27, 2, null);
                yield return new nlsyV(106, 0, 1, 18078, 24, 2, 3);
                yield return new nlsyV(null, 1, 1, null, 28, 2, 2);
                yield return new nlsyV(null, 0, 1, null, 22, null, null);
                yield return new nlsyV(null, 0, 0, 3564, 23, 2, 2);
                yield return new nlsyV(76, 0, 1, 33160, 27, 2, null);
                yield return new nlsyV(62, 1, 1, 71300, 22, 1, null);
                yield return new nlsyV(44, 1, 1, 11672, 21, 1, 2);
                yield return new nlsyV(79, 1, 0, 3000, 31, 3, 1);
                yield return new nlsyV(76, 1, 0, 32000, 23, 3, 1);
                yield return new nlsyV(108, 1, 1, 50000, 24, null, 3);
                yield return new nlsyV(98, 1, 1, null, 24, 2, 3);
                yield return new nlsyV(98, 1, 1, 72020, 30, 2, 2);
                yield return new nlsyV(82, 0, 1, 6412, 20, 2, 1);
                yield return new nlsyV(98, 0, 1, 16700, 24, 1, 3);
                yield return new nlsyV(79, 0, 1, 30000, 22, 2, null);
                yield return new nlsyV(null, 0, 1, 50000, 26, 2, 3);
                yield return new nlsyV(75, 0, 1, null, 24, 3, null);
                yield return new nlsyV(95, 1, 1, 3600, 23, 1, 2);
                yield return new nlsyV(46, 0, 0, 4641, 23, 1, 3);
                yield return new nlsyV(54, 1, 0, null, 19, 2, 1);
                yield return new nlsyV(94, 0, 1, 24385, 26, 2, 3);
                yield return new nlsyV(null, 0, 1, 29600, 22, 2, 3);
                yield return new nlsyV(106, 1, null, null, 28, 4, 2);
                yield return new nlsyV(91, 1, 0, null, 22, 1, 3);
                yield return new nlsyV(101, 0, 0, 8675, 22, 2, null);
                yield return new nlsyV(null, 0, 1, 12020, 20, 1, null);
                yield return new nlsyV(null, 0, 0, 10428, 26, 1, null);
                yield return new nlsyV(102, 1, 1, 20180, 22, 2, null);
                yield return new nlsyV(93, 0, 1, 36350, 24, 3, 2);
                yield return new nlsyV(72, 0, 0, 3400, 21, null, 1);
                yield return new nlsyV(83, 0, 1, 5200, 23, 1, 2);
                yield return new nlsyV(null, 0, 1, 8307, 22, 1, 3);
                yield return new nlsyV(null, 0, 1, 32856, 25, 3, 2);
                yield return new nlsyV(null, 1, 1, 14408, 20, 2, null);
                yield return new nlsyV(82, 0, 1, 15000, 24, null, 2);
                yield return new nlsyV(92, 0, 0, null, 20, 3, null);
                yield return new nlsyV(74, 1, 0, 12000, 19, null, 1);
                yield return new nlsyV(90, 0, 1, 1057448, 31, 4, 3);
                yield return new nlsyV(114, 0, 1, 22510, 22, 2, null);
                yield return new nlsyV(53, 1, 0, 10000, 22, null, 1);
                yield return new nlsyV(56, 0, 0, 3404, 22, 2, 1);
                yield return new nlsyV(110, 1, 1, 25990, 22, 2, 3);
                yield return new nlsyV(110, 1, 1, 23000, 23, 3, 2);
                yield return new nlsyV(91, 1, 0, 14928, 19, 2, null);
                yield return new nlsyV(80, 0, null, null, 26, 2, 3);
                yield return new nlsyV(67, 0, 1, 10000, 20, null, 2);
                yield return new nlsyV(98, 0, 1, 25502, 21, 3, null);
                yield return new nlsyV(null, 1, 0, 1848, 20, 1, 1);
                yield return new nlsyV(81, 1, 1, 26000, 27, 3, null);
                yield return new nlsyV(118, 1, 1, null, 25, 4, null);
                yield return new nlsyV(80, 0, 0, 7328, 26, 1, null);
                yield return new nlsyV(94, 0, 1, 21000, 26, 4, 3);
                yield return new nlsyV(46, 0, null, null, 28, 1, null);
                yield return new nlsyV(73, 1, 1, 16630, 22, 1, 3);
                yield return new nlsyV(null, 0, 1, 18000, 27, 1, null);
                yield return new nlsyV(85, 1, 1, 17500, 21, 2, 2);
                yield return new nlsyV(null, 0, 1, 10000, 20, 1, 3);
                yield return new nlsyV(null, 1, 1, 36012, 28, 3, 3);
                yield return new nlsyV(76, 1, 0, null, 20, 3, 1);
                yield return new nlsyV(null, 1, 1, 29000, 24, 2, null);
                yield return new nlsyV(83, 0, 1, null, 22, 1, null);
                yield return new nlsyV(109, 1, 1, 28010, 22, 2, 3);
                yield return new nlsyV(109, 1, 1, 14700, 23, 3, 3);
                yield return new nlsyV(84, 1, 0, null, 23, 2, null);
                yield return new nlsyV(105, 1, 1, 25000, 19, 3, 3);
                yield return new nlsyV(56, 0, 0, 7392, 27, 1, null);
                yield return new nlsyV(96, 1, 1, null, 22, 2, 3);
                yield return new nlsyV(110, 1, 1, null, 19, 1, 1);
                yield return new nlsyV(77, 1, 0, 7332, 25, 1, 2);
                yield return new nlsyV(68, 1, 1, 15000, 22, 3, 2);
                yield return new nlsyV(106, 1, 1, 47000, 28, null, 2);
                yield return new nlsyV(76, 1, 1, 21836, 24, 2, null);
                yield return new nlsyV(95, 1, 1, null, 27, 4, 3);
                yield return new nlsyV(95, 0, 1, 53000, 27, 1, 2);
                yield return new nlsyV(97, 0, 1, null, 23, 3, 1);
                yield return new nlsyV(null, 0, 1, null, 18, 1, 2);
                yield return new nlsyV(96, 0, 1, null, 25, 3, 1);
                yield return new nlsyV(99, 0, 1, 9750, 22, 1, 3);
                yield return new nlsyV(83, 0, 0, 8298, 24, 1, 2);
                yield return new nlsyV(78, 0, 0, 29000, 21, 2, 1);
                yield return new nlsyV(79, 0, 1, 6700, 23, 1, 2);
                yield return new nlsyV(83, 1, 1, null, 19, 3, 2);
                yield return new nlsyV(125, 1, 1, 60140, 26, 3, 3);
                yield return new nlsyV(80, 0, 1, 23539, 24, 3, null);
                yield return new nlsyV(80, 1, 0, null, 18, 1, null);
                yield return new nlsyV(80, 1, 0, 30000, 22, 4, null);
                yield return new nlsyV(50, 0, 1, 9051, 23, 1, 2);
                yield return new nlsyV(84, 0, 1, 33000, 23, 2, null);
                yield return new nlsyV(90, 1, 0, 1415, 23, 2, 3);
                yield return new nlsyV(null, 0, 1, null, 23, null, 2);
                yield return new nlsyV(null, 0, 1, 63906, 28, 4, null);
                yield return new nlsyV(100, 0, 1, 39017, 28, 2, 3);
                yield return new nlsyV(92, 0, 1, 52000, 28, 3, 3);
                yield return new nlsyV(99, 0, 0, 4000, 22, 1, 2);
                yield return new nlsyV(102, 1, 1, 42125, 30, 4, 3);
            }
        }
    }
}
