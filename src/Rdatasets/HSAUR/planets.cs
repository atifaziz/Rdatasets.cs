// ReSharper disable All

namespace Rdatasets.HSAUR
{
    using System.Collections.Generic;

    /// <summary>
    /// Exoplanets Data
    /// </summary>

    public class planets
    {
        public readonly double mass;
        public readonly double period;
        public readonly double eccen;

        public planets(double mass, double period, double eccen)
        {
            this.mass = mass;
            this.period = period;
            this.eccen = eccen;
        }

        public static IEnumerable<planets> Data
        {
            get
            {
                yield return new planets(0.12, 4.95, 0);
                yield return new planets(0.197, 3.971, 0);
                yield return new planets(0.21, 44.28, 0.34);
                yield return new planets(0.22, 75.8, 0.28);
                yield return new planets(0.23, 6.403, 0.08);
                yield return new planets(0.25, 3.024, 0.02);
                yield return new planets(0.34, 2.985, 0.08);
                yield return new planets(0.4, 10.901, 0.498);
                yield return new planets(0.42, 3.5097, 0);
                yield return new planets(0.47, 4.229, 0);
                yield return new planets(0.48, 3.487, 0.05);
                yield return new planets(0.48, 22.09, 0.3);
                yield return new planets(0.54, 3.097, 0.01);
                yield return new planets(0.56, 30.12, 0.27);
                yield return new planets(0.68, 4.617, 0.02);
                yield return new planets(0.685, 3.52433, 0);
                yield return new planets(0.76, 2594, 0.1);
                yield return new planets(0.77, 14.31, 0.27);
                yield return new planets(0.81, 828.95, 0.04);
                yield return new planets(0.88, 221.6, 0.54);
                yield return new planets(0.88, 2518, 0.6);
                yield return new planets(0.89, 64.62, 0.13);
                yield return new planets(0.9, 1136, 0.33);
                yield return new planets(0.93, 3.092, 0);
                yield return new planets(0.93, 14.66, 0.03);
                yield return new planets(0.99, 39.81, 0.07);
                yield return new planets(0.99, 500.73, 0.1);
                yield return new planets(0.99, 872.3, 0.28);
                yield return new planets(1, 337.11, 0.38);
                yield return new planets(1, 264.9, 0.38);
                yield return new planets(1.01, 540.4, 0.52);
                yield return new planets(1.01, 1942, 0.4);
                yield return new planets(1.02, 10.72, 0.044);
                yield return new planets(1.05, 119.6, 0.35);
                yield return new planets(1.12, 500, 0.23);
                yield return new planets(1.13, 154.8, 0.31);
                yield return new planets(1.15, 2614, 0);
                yield return new planets(1.23, 1326, 0.14);
                yield return new planets(1.24, 391, 0.4);
                yield return new planets(1.24, 435.6, 0.45);
                yield return new planets(1.282, 7.1262, 0.134);
                yield return new planets(1.42, 426, 0.02);
                yield return new planets(1.55, 51.61, 0.649);
                yield return new planets(1.56, 1444.5, 0.2);
                yield return new planets(1.58, 260, 0.24);
                yield return new planets(1.63, 444.6, 0.41);
                yield return new planets(1.64, 406, 0.53);
                yield return new planets(1.65, 401.1, 0.36);
                yield return new planets(1.68, 796.7, 0.68);
                yield return new planets(1.76, 903, 0.2);
                yield return new planets(1.83, 454, 0.2);
                yield return new planets(1.89, 61.02, 0.1);
                yield return new planets(1.9, 6.276, 0.15);
                yield return new planets(1.99, 743, 0.62);
                yield return new planets(2.05, 241.3, 0.24);
                yield return new planets(0.05, 1119, 0.17);
                yield return new planets(2.08, 228.52, 0.304);
                yield return new planets(2.24, 311.3, 0.22);
                yield return new planets(2.54, 1089, 0.06);
                yield return new planets(2.54, 627.34, 0.06);
                yield return new planets(2.55, 2185, 0.18);
                yield return new planets(2.63, 414, 0.21);
                yield return new planets(2.84, 250.5, 0.19);
                yield return new planets(2.94, 229.9, 0.35);
                yield return new planets(3.03, 186.9, 0.41);
                yield return new planets(3.32, 267.2, 0.23);
                yield return new planets(3.36, 1098, 0.22);
                yield return new planets(3.37, 133.71, 0.511);
                yield return new planets(3.44, 1112, 0.52);
                yield return new planets(3.55, 18.2, 0.01);
                yield return new planets(3.81, 340, 0.36);
                yield return new planets(3.9, 111.81, 0.927);
                yield return new planets(4, 15.78, 0.046);
                yield return new planets(4, 5360, 0.16);
                yield return new planets(4.12, 1209.9, 0.65);
                yield return new planets(4.14, 3.313, 0.02);
                yield return new planets(4.27, 1764, 0.353);
                yield return new planets(4.29, 1308.5, 0.31);
                yield return new planets(4.5, 951, 0.45);
                yield return new planets(4.8, 1237, 0.515);
                yield return new planets(5.18, 576, 0.71);
                yield return new planets(5.7, 383, 0.07);
                yield return new planets(6.08, 1074, 0.011);
                yield return new planets(6.292, 71.487, 0.1243);
                yield return new planets(7.17, 256, 0.7);
                yield return new planets(7.39, 1582, 0.478);
                yield return new planets(7.42, 116.7, 0.4);
                yield return new planets(7.5, 2300, 0.395);
                yield return new planets(7.7, 58.116, 0.529);
                yield return new planets(7.95, 1620, 0.22);
                yield return new planets(8, 1558, 0.314);
                yield return new planets(8.64, 550.65, 0.71);
                yield return new planets(9.7, 653.22, 0.41);
                yield return new planets(10, 3030, 0.56);
                yield return new planets(10.37, 2115.2, 0.62);
                yield return new planets(10.96, 84.03, 0.33);
                yield return new planets(11.3, 2189, 0.34);
                yield return new planets(11.98, 1209, 0.37);
                yield return new planets(14.4, 8.428198, 0.277);
                yield return new planets(16.9, 1739.5, 0.228);
                yield return new planets(17.5, 256.03, 0.429);
            }
        }
    }
}
