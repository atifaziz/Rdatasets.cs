// ReSharper disable All

namespace Rdatasets.MASS
{
    using System.Collections.Generic;

    /// <summary>
    /// Data from a Simulated Motorcycle Accident
    /// </summary>

    public class mcycle
    {
        public readonly int κ;
        public readonly double times;
        public readonly double accel;

        public mcycle(int κ, double times, double accel)
        {
            this.κ = κ;
            this.times = times;
            this.accel = accel;
        }

        public static IEnumerable<mcycle> Data
        {
            get
            {
                yield return new mcycle(1, 2.4, 0);
                yield return new mcycle(2, 2.6, -1.3);
                yield return new mcycle(3, 3.2, -2.7);
                yield return new mcycle(4, 3.6, 0);
                yield return new mcycle(5, 4, -2.7);
                yield return new mcycle(6, 6.2, -2.7);
                yield return new mcycle(7, 6.6, -2.7);
                yield return new mcycle(8, 6.8, -1.3);
                yield return new mcycle(9, 7.8, -2.7);
                yield return new mcycle(10, 8.2, -2.7);
                yield return new mcycle(11, 8.8, -1.3);
                yield return new mcycle(12, 8.8, -2.7);
                yield return new mcycle(13, 9.6, -2.7);
                yield return new mcycle(14, 10, -2.7);
                yield return new mcycle(15, 10.2, -5.4);
                yield return new mcycle(16, 10.6, -2.7);
                yield return new mcycle(17, 11, -5.4);
                yield return new mcycle(18, 11.4, 0);
                yield return new mcycle(19, 13.2, -2.7);
                yield return new mcycle(20, 13.6, -2.7);
                yield return new mcycle(21, 13.8, 0);
                yield return new mcycle(22, 14.6, -13.3);
                yield return new mcycle(23, 14.6, -5.4);
                yield return new mcycle(24, 14.6, -5.4);
                yield return new mcycle(25, 14.6, -9.3);
                yield return new mcycle(26, 14.6, -16);
                yield return new mcycle(27, 14.6, -22.8);
                yield return new mcycle(28, 14.8, -2.7);
                yield return new mcycle(29, 15.4, -22.8);
                yield return new mcycle(30, 15.4, -32.1);
                yield return new mcycle(31, 15.4, -53.5);
                yield return new mcycle(32, 15.4, -54.9);
                yield return new mcycle(33, 15.6, -40.2);
                yield return new mcycle(34, 15.6, -21.5);
                yield return new mcycle(35, 15.8, -21.5);
                yield return new mcycle(36, 15.8, -50.8);
                yield return new mcycle(37, 16, -42.9);
                yield return new mcycle(38, 16, -26.8);
                yield return new mcycle(39, 16.2, -21.5);
                yield return new mcycle(40, 16.2, -50.8);
                yield return new mcycle(41, 16.2, -61.7);
                yield return new mcycle(42, 16.4, -5.4);
                yield return new mcycle(43, 16.4, -80.4);
                yield return new mcycle(44, 16.6, -59);
                yield return new mcycle(45, 16.8, -71);
                yield return new mcycle(46, 16.8, -91.1);
                yield return new mcycle(47, 16.8, -77.7);
                yield return new mcycle(48, 17.6, -37.5);
                yield return new mcycle(49, 17.6, -85.6);
                yield return new mcycle(50, 17.6, -123.1);
                yield return new mcycle(51, 17.6, -101.9);
                yield return new mcycle(52, 17.8, -99.1);
                yield return new mcycle(53, 17.8, -104.4);
                yield return new mcycle(54, 18.6, -112.5);
                yield return new mcycle(55, 18.6, -50.8);
                yield return new mcycle(56, 19.2, -123.1);
                yield return new mcycle(57, 19.4, -85.6);
                yield return new mcycle(58, 19.4, -72.3);
                yield return new mcycle(59, 19.6, -127.2);
                yield return new mcycle(60, 20.2, -123.1);
                yield return new mcycle(61, 20.4, -117.9);
                yield return new mcycle(62, 21.2, -134);
                yield return new mcycle(63, 21.4, -101.9);
                yield return new mcycle(64, 21.8, -108.4);
                yield return new mcycle(65, 22, -123.1);
                yield return new mcycle(66, 23.2, -123.1);
                yield return new mcycle(67, 23.4, -128.5);
                yield return new mcycle(68, 24, -112.5);
                yield return new mcycle(69, 24.2, -95.1);
                yield return new mcycle(70, 24.2, -81.8);
                yield return new mcycle(71, 24.6, -53.5);
                yield return new mcycle(72, 25, -64.4);
                yield return new mcycle(73, 25, -57.6);
                yield return new mcycle(74, 25.4, -72.3);
                yield return new mcycle(75, 25.4, -44.3);
                yield return new mcycle(76, 25.6, -26.8);
                yield return new mcycle(77, 26, -5.4);
                yield return new mcycle(78, 26.2, -107.1);
                yield return new mcycle(79, 26.2, -21.5);
                yield return new mcycle(80, 26.4, -65.6);
                yield return new mcycle(81, 27, -16);
                yield return new mcycle(82, 27.2, -45.6);
                yield return new mcycle(83, 27.2, -24.2);
                yield return new mcycle(84, 27.2, 9.5);
                yield return new mcycle(85, 27.6, 4);
                yield return new mcycle(86, 28.2, 12);
                yield return new mcycle(87, 28.4, -21.5);
                yield return new mcycle(88, 28.4, 37.5);
                yield return new mcycle(89, 28.6, 46.9);
                yield return new mcycle(90, 29.4, -17.4);
                yield return new mcycle(91, 30.2, 36.2);
                yield return new mcycle(92, 31, 75);
                yield return new mcycle(93, 31.2, 8.1);
                yield return new mcycle(94, 32, 54.9);
                yield return new mcycle(95, 32, 48.2);
                yield return new mcycle(96, 32.8, 46.9);
                yield return new mcycle(97, 33.4, 16);
                yield return new mcycle(98, 33.8, 45.6);
                yield return new mcycle(99, 34.4, 1.3);
                yield return new mcycle(100, 34.8, 75);
                yield return new mcycle(101, 35.2, -16);
                yield return new mcycle(102, 35.2, -54.9);
                yield return new mcycle(103, 35.4, 69.6);
                yield return new mcycle(104, 35.6, 34.8);
                yield return new mcycle(105, 35.6, 32.1);
                yield return new mcycle(106, 36.2, -37.5);
                yield return new mcycle(107, 36.2, 22.8);
                yield return new mcycle(108, 38, 46.9);
                yield return new mcycle(109, 38, 10.7);
                yield return new mcycle(110, 39.2, 5.4);
                yield return new mcycle(111, 39.4, -1.3);
                yield return new mcycle(112, 40, -21.5);
                yield return new mcycle(113, 40.4, -13.3);
                yield return new mcycle(114, 41.6, 30.8);
                yield return new mcycle(115, 41.6, -10.7);
                yield return new mcycle(116, 42.4, 29.4);
                yield return new mcycle(117, 42.8, 0);
                yield return new mcycle(118, 42.8, -10.7);
                yield return new mcycle(119, 43, 14.7);
                yield return new mcycle(120, 44, -1.3);
                yield return new mcycle(121, 44.4, 0);
                yield return new mcycle(122, 45, 10.7);
                yield return new mcycle(123, 46.6, 10.7);
                yield return new mcycle(124, 47.8, -26.8);
                yield return new mcycle(125, 47.8, -14.7);
                yield return new mcycle(126, 48.8, -13.3);
                yield return new mcycle(127, 50.6, 0);
                yield return new mcycle(128, 52, 10.7);
                yield return new mcycle(129, 53.2, -14.7);
                yield return new mcycle(130, 55, -2.7);
                yield return new mcycle(131, 55, 10.7);
                yield return new mcycle(132, 55.4, -2.7);
                yield return new mcycle(133, 57.6, 10.7);
            }
        }
    }
}
