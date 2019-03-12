// ReSharper disable All

namespace Rdatasets.HSAUR
{
    using System.Collections.Generic;

    /// <summary>
    /// Exoplanets Data
    /// </summary>

    public class planets
    {
        public readonly int κ;
        public readonly double mass;
        public readonly double period;
        public readonly double eccen;

        public planets(int κ, double mass, double period, double eccen)
        {
            this.κ = κ;
            this.mass = mass;
            this.period = period;
            this.eccen = eccen;
        }

        public static IEnumerable<planets> Data
        {
            get
            {
                yield return new planets(1, 0.12, 4.95, 0);
                yield return new planets(2, 0.197, 3.971, 0);
                yield return new planets(3, 0.21, 44.28, 0.34);
                yield return new planets(4, 0.22, 75.8, 0.28);
                yield return new planets(5, 0.23, 6.403, 0.08);
                yield return new planets(6, 0.25, 3.024, 0.02);
                yield return new planets(7, 0.34, 2.985, 0.08);
                yield return new planets(8, 0.4, 10.901, 0.498);
                yield return new planets(9, 0.42, 3.5097, 0);
                yield return new planets(10, 0.47, 4.229, 0);
                yield return new planets(11, 0.48, 3.487, 0.05);
                yield return new planets(12, 0.48, 22.09, 0.3);
                yield return new planets(13, 0.54, 3.097, 0.01);
                yield return new planets(14, 0.56, 30.12, 0.27);
                yield return new planets(15, 0.68, 4.617, 0.02);
                yield return new planets(16, 0.685, 3.52433, 0);
                yield return new planets(17, 0.76, 2594, 0.1);
                yield return new planets(18, 0.77, 14.31, 0.27);
                yield return new planets(19, 0.81, 828.95, 0.04);
                yield return new planets(20, 0.88, 221.6, 0.54);
                yield return new planets(21, 0.88, 2518, 0.6);
                yield return new planets(22, 0.89, 64.62, 0.13);
                yield return new planets(23, 0.9, 1136, 0.33);
                yield return new planets(24, 0.93, 3.092, 0);
                yield return new planets(25, 0.93, 14.66, 0.03);
                yield return new planets(26, 0.99, 39.81, 0.07);
                yield return new planets(27, 0.99, 500.73, 0.1);
                yield return new planets(28, 0.99, 872.3, 0.28);
                yield return new planets(29, 1, 337.11, 0.38);
                yield return new planets(30, 1, 264.9, 0.38);
                yield return new planets(31, 1.01, 540.4, 0.52);
                yield return new planets(32, 1.01, 1942, 0.4);
                yield return new planets(33, 1.02, 10.72, 0.044);
                yield return new planets(34, 1.05, 119.6, 0.35);
                yield return new planets(35, 1.12, 500, 0.23);
                yield return new planets(36, 1.13, 154.8, 0.31);
                yield return new planets(37, 1.15, 2614, 0);
                yield return new planets(38, 1.23, 1326, 0.14);
                yield return new planets(39, 1.24, 391, 0.4);
                yield return new planets(40, 1.24, 435.6, 0.45);
                yield return new planets(41, 1.282, 7.1262, 0.134);
                yield return new planets(42, 1.42, 426, 0.02);
                yield return new planets(43, 1.55, 51.61, 0.649);
                yield return new planets(44, 1.56, 1444.5, 0.2);
                yield return new planets(45, 1.58, 260, 0.24);
                yield return new planets(46, 1.63, 444.6, 0.41);
                yield return new planets(47, 1.64, 406, 0.53);
                yield return new planets(48, 1.65, 401.1, 0.36);
                yield return new planets(49, 1.68, 796.7, 0.68);
                yield return new planets(50, 1.76, 903, 0.2);
                yield return new planets(51, 1.83, 454, 0.2);
                yield return new planets(52, 1.89, 61.02, 0.1);
                yield return new planets(53, 1.9, 6.276, 0.15);
                yield return new planets(54, 1.99, 743, 0.62);
                yield return new planets(55, 2.05, 241.3, 0.24);
                yield return new planets(56, 0.05, 1119, 0.17);
                yield return new planets(57, 2.08, 228.52, 0.304);
                yield return new planets(58, 2.24, 311.3, 0.22);
                yield return new planets(59, 2.54, 1089, 0.06);
                yield return new planets(60, 2.54, 627.34, 0.06);
                yield return new planets(61, 2.55, 2185, 0.18);
                yield return new planets(62, 2.63, 414, 0.21);
                yield return new planets(63, 2.84, 250.5, 0.19);
                yield return new planets(64, 2.94, 229.9, 0.35);
                yield return new planets(65, 3.03, 186.9, 0.41);
                yield return new planets(66, 3.32, 267.2, 0.23);
                yield return new planets(67, 3.36, 1098, 0.22);
                yield return new planets(68, 3.37, 133.71, 0.511);
                yield return new planets(69, 3.44, 1112, 0.52);
                yield return new planets(70, 3.55, 18.2, 0.01);
                yield return new planets(71, 3.81, 340, 0.36);
                yield return new planets(72, 3.9, 111.81, 0.927);
                yield return new planets(73, 4, 15.78, 0.046);
                yield return new planets(74, 4, 5360, 0.16);
                yield return new planets(75, 4.12, 1209.9, 0.65);
                yield return new planets(76, 4.14, 3.313, 0.02);
                yield return new planets(77, 4.27, 1764, 0.353);
                yield return new planets(78, 4.29, 1308.5, 0.31);
                yield return new planets(79, 4.5, 951, 0.45);
                yield return new planets(80, 4.8, 1237, 0.515);
                yield return new planets(81, 5.18, 576, 0.71);
                yield return new planets(82, 5.7, 383, 0.07);
                yield return new planets(83, 6.08, 1074, 0.011);
                yield return new planets(84, 6.292, 71.487, 0.1243);
                yield return new planets(85, 7.17, 256, 0.7);
                yield return new planets(86, 7.39, 1582, 0.478);
                yield return new planets(87, 7.42, 116.7, 0.4);
                yield return new planets(88, 7.5, 2300, 0.395);
                yield return new planets(89, 7.7, 58.116, 0.529);
                yield return new planets(90, 7.95, 1620, 0.22);
                yield return new planets(91, 8, 1558, 0.314);
                yield return new planets(92, 8.64, 550.65, 0.71);
                yield return new planets(93, 9.7, 653.22, 0.41);
                yield return new planets(94, 10, 3030, 0.56);
                yield return new planets(95, 10.37, 2115.2, 0.62);
                yield return new planets(96, 10.96, 84.03, 0.33);
                yield return new planets(97, 11.3, 2189, 0.34);
                yield return new planets(98, 11.98, 1209, 0.37);
                yield return new planets(99, 14.4, 8.428198, 0.277);
                yield return new planets(100, 16.9, 1739.5, 0.228);
                yield return new planets(101, 17.5, 256.03, 0.429);
            }
        }
    }
}
