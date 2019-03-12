// ReSharper disable All

namespace Rdatasets.boot
{
    using System.Collections.Generic;

    /// <summary>
    /// Data from a Simulated Motorcycle Accident
    /// </summary>

    public class motor
    {
        public readonly int κ;
        public readonly double times;
        public readonly double accel;
        public readonly int strata;
        public readonly double v;

        public motor(int κ, double times, double accel, int strata, double v)
        {
            this.κ = κ;
            this.times = times;
            this.accel = accel;
            this.strata = strata;
            this.v = v;
        }

        public static IEnumerable<motor> Data
        {
            get
            {
                yield return new motor(1, 2.4, 0, 1, 3.7);
                yield return new motor(2, 2.6, -1.3, 1, 3.7);
                yield return new motor(3, 3.2, -2.7, 1, 3.7);
                yield return new motor(4, 3.6, 0, 1, 3.7);
                yield return new motor(5, 4, -2.7, 1, 3.7);
                yield return new motor(6, 6.2, -2.7, 1, 3.7);
                yield return new motor(7, 6.6, -2.7, 1, 3.7);
                yield return new motor(8, 6.8, -1.3, 1, 3.7);
                yield return new motor(9, 7.8, -2.7, 1, 3.7);
                yield return new motor(10, 8.2, -2.7, 1, 3.7);
                yield return new motor(11, 8.8, -1.3, 1, 3.7);
                yield return new motor(13, 9.6, -2.7, 1, 3.7);
                yield return new motor(14, 10, -2.7, 1, 3.7);
                yield return new motor(15, 10.2, -5.4, 1, 3.7);
                yield return new motor(16, 10.6, -2.7, 1, 3.7);
                yield return new motor(17, 11, -5.4, 1, 3.7);
                yield return new motor(18, 11.4, 0, 1, 3.7);
                yield return new motor(19, 13.2, -2.7, 2, 607);
                yield return new motor(20, 13.6, -2.7, 2, 607);
                yield return new motor(21, 13.8, 0, 2, 607);
                yield return new motor(22, 14.6, -13.3, 2, 607);
                yield return new motor(28, 14.8, -2.7, 2, 607);
                yield return new motor(29, 15.4, -22.8, 2, 607);
                yield return new motor(33, 15.6, -40.2, 2, 607);
                yield return new motor(35, 15.8, -21.5, 2, 607);
                yield return new motor(37, 16, -42.9, 2, 607);
                yield return new motor(39, 16.2, -21.5, 2, 607);
                yield return new motor(42, 16.4, -5.4, 2, 607);
                yield return new motor(44, 16.6, -59, 2, 607);
                yield return new motor(45, 16.8, -71, 2, 607);
                yield return new motor(48, 17.6, -37.5, 2, 607);
                yield return new motor(52, 17.8, -99.1, 2, 607);
                yield return new motor(54, 18.6, -112.5, 2, 607);
                yield return new motor(56, 19.2, -123.1, 2, 607);
                yield return new motor(57, 19.4, -85.6, 2, 607);
                yield return new motor(59, 19.6, -127.2, 2, 607);
                yield return new motor(60, 20.2, -123.1, 2, 607);
                yield return new motor(61, 20.4, -117.9, 2, 607);
                yield return new motor(62, 21.2, -134, 2, 607);
                yield return new motor(63, 21.4, -101.9, 2, 607);
                yield return new motor(64, 21.8, -108.4, 2, 607);
                yield return new motor(65, 22, -123.1, 2, 607);
                yield return new motor(66, 23.2, -123.1, 2, 607);
                yield return new motor(67, 23.4, -128.5, 2, 607);
                yield return new motor(68, 24, -112.5, 2, 607);
                yield return new motor(69, 24.2, -95.1, 2, 607);
                yield return new motor(71, 24.6, -53.5, 2, 607);
                yield return new motor(72, 25, -64.4, 2, 607);
                yield return new motor(74, 25.4, -72.3, 2, 607);
                yield return new motor(76, 25.6, -26.8, 2, 607);
                yield return new motor(77, 26, -5.4, 2, 607);
                yield return new motor(78, 26.2, -107.1, 2, 607);
                yield return new motor(80, 26.4, -65.6, 2, 607);
                yield return new motor(81, 27, -16, 2, 607);
                yield return new motor(82, 27.2, -45.6, 2, 607);
                yield return new motor(85, 27.6, 4, 2, 607);
                yield return new motor(86, 28.2, 12, 2, 607);
                yield return new motor(87, 28.4, -21.5, 2, 607);
                yield return new motor(89, 28.6, 46.9, 2, 607);
                yield return new motor(90, 29.4, -17.4, 2, 607);
                yield return new motor(91, 30.2, 36.2, 2, 607);
                yield return new motor(92, 31, 75, 2, 607);
                yield return new motor(93, 31.2, 8.1, 2, 607);
                yield return new motor(94, 32, 54.9, 2, 607);
                yield return new motor(96, 32.8, 46.9, 2, 607);
                yield return new motor(97, 33.4, 16, 2, 607);
                yield return new motor(98, 33.8, 45.6, 2, 607);
                yield return new motor(99, 34.4, 1.3, 2, 607);
                yield return new motor(100, 34.8, 75, 2, 607);
                yield return new motor(101, 35.2, -16, 2, 607);
                yield return new motor(103, 35.4, 69.6, 2, 607);
                yield return new motor(104, 35.6, 34.8, 2, 607);
                yield return new motor(106, 36.2, -37.5, 2, 607);
                yield return new motor(108, 38, 46.9, 2, 607);
                yield return new motor(110, 39.2, 5.4, 2, 607);
                yield return new motor(111, 39.4, -1.3, 2, 607);
                yield return new motor(112, 40, -21.5, 2, 607);
                yield return new motor(113, 40.4, -13.3, 2, 607);
                yield return new motor(114, 41.6, 30.8, 3, 138);
                yield return new motor(116, 42.4, 29.4, 3, 138);
                yield return new motor(117, 42.8, 0, 3, 138);
                yield return new motor(119, 43, 14.7, 3, 138);
                yield return new motor(120, 44, -1.3, 3, 138);
                yield return new motor(121, 44.4, 0, 3, 138);
                yield return new motor(122, 45, 10.7, 3, 138);
                yield return new motor(123, 46.6, 10.7, 3, 138);
                yield return new motor(124, 47.8, -26.8, 3, 138);
                yield return new motor(126, 48.8, -13.3, 3, 138);
                yield return new motor(127, 50.6, 0, 3, 138);
                yield return new motor(128, 52, 10.7, 3, 138);
                yield return new motor(129, 53.2, -14.7, 3, 138);
                yield return new motor(130, 55, -2.7, 3, 138);
                yield return new motor(132, 55.4, -2.7, 3, 138);
                yield return new motor(133, 57.6, 10.7, 3, 138);
            }
        }
    }
}
