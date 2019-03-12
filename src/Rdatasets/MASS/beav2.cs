// ReSharper disable All

namespace Rdatasets.MASS
{
    using System.Collections.Generic;

    /// <summary>
    /// Body Temperature Series of Beaver 2
    /// </summary>

    public class beav2
    {
        public readonly int κ;
        public readonly int day;
        public readonly int time;
        public readonly double temp;
        public readonly int activ;

        public beav2(int κ, int day, int time, double temp, int activ)
        {
            this.κ = κ;
            this.day = day;
            this.time = time;
            this.temp = temp;
            this.activ = activ;
        }

        public static IEnumerable<beav2> Data
        {
            get
            {
                yield return new beav2(1, 307, 930, 36.58, 0);
                yield return new beav2(2, 307, 940, 36.73, 0);
                yield return new beav2(3, 307, 950, 36.93, 0);
                yield return new beav2(4, 307, 1000, 37.15, 0);
                yield return new beav2(5, 307, 1010, 37.23, 0);
                yield return new beav2(6, 307, 1020, 37.24, 0);
                yield return new beav2(7, 307, 1030, 37.24, 0);
                yield return new beav2(8, 307, 1040, 36.9, 0);
                yield return new beav2(9, 307, 1050, 36.95, 0);
                yield return new beav2(10, 307, 1100, 36.89, 0);
                yield return new beav2(11, 307, 1110, 36.95, 0);
                yield return new beav2(12, 307, 1120, 37, 0);
                yield return new beav2(13, 307, 1130, 36.9, 0);
                yield return new beav2(14, 307, 1140, 36.99, 0);
                yield return new beav2(15, 307, 1150, 36.99, 0);
                yield return new beav2(16, 307, 1200, 37.01, 0);
                yield return new beav2(17, 307, 1210, 37.04, 0);
                yield return new beav2(18, 307, 1220, 37.04, 0);
                yield return new beav2(19, 307, 1230, 37.14, 0);
                yield return new beav2(20, 307, 1240, 37.07, 0);
                yield return new beav2(21, 307, 1250, 36.98, 0);
                yield return new beav2(22, 307, 1300, 37.01, 0);
                yield return new beav2(23, 307, 1310, 36.97, 0);
                yield return new beav2(24, 307, 1320, 36.97, 0);
                yield return new beav2(25, 307, 1330, 37.12, 0);
                yield return new beav2(26, 307, 1340, 37.13, 0);
                yield return new beav2(27, 307, 1350, 37.14, 0);
                yield return new beav2(28, 307, 1400, 37.15, 0);
                yield return new beav2(29, 307, 1410, 37.17, 0);
                yield return new beav2(30, 307, 1420, 37.12, 0);
                yield return new beav2(31, 307, 1430, 37.12, 0);
                yield return new beav2(32, 307, 1440, 37.17, 0);
                yield return new beav2(33, 307, 1450, 37.28, 0);
                yield return new beav2(34, 307, 1500, 37.28, 0);
                yield return new beav2(35, 307, 1510, 37.44, 0);
                yield return new beav2(36, 307, 1520, 37.51, 0);
                yield return new beav2(37, 307, 1530, 37.64, 0);
                yield return new beav2(38, 307, 1540, 37.51, 0);
                yield return new beav2(39, 307, 1550, 37.98, 1);
                yield return new beav2(40, 307, 1600, 38.02, 1);
                yield return new beav2(41, 307, 1610, 38, 1);
                yield return new beav2(42, 307, 1620, 38.24, 1);
                yield return new beav2(43, 307, 1630, 38.1, 1);
                yield return new beav2(44, 307, 1640, 38.24, 1);
                yield return new beav2(45, 307, 1650, 38.11, 1);
                yield return new beav2(46, 307, 1700, 38.02, 1);
                yield return new beav2(47, 307, 1710, 38.11, 1);
                yield return new beav2(48, 307, 1720, 38.01, 1);
                yield return new beav2(49, 307, 1730, 37.91, 1);
                yield return new beav2(50, 307, 1740, 37.96, 1);
                yield return new beav2(51, 307, 1750, 38.03, 1);
                yield return new beav2(52, 307, 1800, 38.17, 1);
                yield return new beav2(53, 307, 1810, 38.19, 1);
                yield return new beav2(54, 307, 1820, 38.18, 1);
                yield return new beav2(55, 307, 1830, 38.15, 1);
                yield return new beav2(56, 307, 1840, 38.04, 1);
                yield return new beav2(57, 307, 1850, 37.96, 1);
                yield return new beav2(58, 307, 1900, 37.84, 1);
                yield return new beav2(59, 307, 1910, 37.83, 1);
                yield return new beav2(60, 307, 1920, 37.84, 1);
                yield return new beav2(61, 307, 1930, 37.74, 1);
                yield return new beav2(62, 307, 1940, 37.76, 1);
                yield return new beav2(63, 307, 1950, 37.76, 1);
                yield return new beav2(64, 307, 2000, 37.64, 1);
                yield return new beav2(65, 307, 2010, 37.63, 1);
                yield return new beav2(66, 307, 2020, 38.06, 1);
                yield return new beav2(67, 307, 2030, 38.19, 1);
                yield return new beav2(68, 307, 2040, 38.35, 1);
                yield return new beav2(69, 307, 2050, 38.25, 1);
                yield return new beav2(70, 307, 2100, 37.86, 1);
                yield return new beav2(71, 307, 2110, 37.95, 1);
                yield return new beav2(72, 307, 2120, 37.95, 1);
                yield return new beav2(73, 307, 2130, 37.76, 1);
                yield return new beav2(74, 307, 2140, 37.6, 1);
                yield return new beav2(75, 307, 2150, 37.89, 1);
                yield return new beav2(76, 307, 2200, 37.86, 1);
                yield return new beav2(77, 307, 2210, 37.71, 1);
                yield return new beav2(78, 307, 2220, 37.78, 1);
                yield return new beav2(79, 307, 2230, 37.82, 1);
                yield return new beav2(80, 307, 2240, 37.76, 1);
                yield return new beav2(81, 307, 2250, 37.81, 1);
                yield return new beav2(82, 307, 2300, 37.84, 1);
                yield return new beav2(83, 307, 2310, 38.01, 1);
                yield return new beav2(84, 307, 2320, 38.1, 1);
                yield return new beav2(85, 307, 2330, 38.15, 1);
                yield return new beav2(86, 307, 2340, 37.92, 1);
                yield return new beav2(87, 307, 2350, 37.64, 1);
                yield return new beav2(88, 308, 0, 37.7, 1);
                yield return new beav2(89, 308, 10, 37.46, 1);
                yield return new beav2(90, 308, 20, 37.41, 1);
                yield return new beav2(91, 308, 30, 37.46, 1);
                yield return new beav2(92, 308, 40, 37.56, 1);
                yield return new beav2(93, 308, 50, 37.55, 1);
                yield return new beav2(94, 308, 100, 37.75, 1);
                yield return new beav2(95, 308, 110, 37.76, 1);
                yield return new beav2(96, 308, 120, 37.73, 1);
                yield return new beav2(97, 308, 130, 37.77, 1);
                yield return new beav2(98, 308, 140, 38.01, 1);
                yield return new beav2(99, 308, 150, 38.04, 1);
                yield return new beav2(100, 308, 200, 38.07, 1);
            }
        }
    }
}
