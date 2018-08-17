// ReSharper disable All

namespace Rdatasets.boot
{
    using System.Collections.Generic;

    /// <summary>
    /// Data from a Simulated Motorcycle Accident
    /// </summary>

    public class motor
    {
        public readonly double times;
        public readonly double accel;
        public readonly int strata;
        public readonly double v;

        public motor(double times, double accel, int strata, double v)
        {
            this.times = times;
            this.accel = accel;
            this.strata = strata;
            this.v = v;
        }

        public static IEnumerable<motor> Data
        {
            get
            {
                yield return new motor(2.4, 0, 1, 3.7);
                yield return new motor(2.6, -1.3, 1, 3.7);
                yield return new motor(3.2, -2.7, 1, 3.7);
                yield return new motor(3.6, 0, 1, 3.7);
                yield return new motor(4, -2.7, 1, 3.7);
                yield return new motor(6.2, -2.7, 1, 3.7);
                yield return new motor(6.6, -2.7, 1, 3.7);
                yield return new motor(6.8, -1.3, 1, 3.7);
                yield return new motor(7.8, -2.7, 1, 3.7);
                yield return new motor(8.2, -2.7, 1, 3.7);
                yield return new motor(8.8, -1.3, 1, 3.7);
                yield return new motor(9.6, -2.7, 1, 3.7);
                yield return new motor(10, -2.7, 1, 3.7);
                yield return new motor(10.2, -5.4, 1, 3.7);
                yield return new motor(10.6, -2.7, 1, 3.7);
                yield return new motor(11, -5.4, 1, 3.7);
                yield return new motor(11.4, 0, 1, 3.7);
                yield return new motor(13.2, -2.7, 2, 607);
                yield return new motor(13.6, -2.7, 2, 607);
                yield return new motor(13.8, 0, 2, 607);
                yield return new motor(14.6, -13.3, 2, 607);
                yield return new motor(14.8, -2.7, 2, 607);
                yield return new motor(15.4, -22.8, 2, 607);
                yield return new motor(15.6, -40.2, 2, 607);
                yield return new motor(15.8, -21.5, 2, 607);
                yield return new motor(16, -42.9, 2, 607);
                yield return new motor(16.2, -21.5, 2, 607);
                yield return new motor(16.4, -5.4, 2, 607);
                yield return new motor(16.6, -59, 2, 607);
                yield return new motor(16.8, -71, 2, 607);
                yield return new motor(17.6, -37.5, 2, 607);
                yield return new motor(17.8, -99.1, 2, 607);
                yield return new motor(18.6, -112.5, 2, 607);
                yield return new motor(19.2, -123.1, 2, 607);
                yield return new motor(19.4, -85.6, 2, 607);
                yield return new motor(19.6, -127.2, 2, 607);
                yield return new motor(20.2, -123.1, 2, 607);
                yield return new motor(20.4, -117.9, 2, 607);
                yield return new motor(21.2, -134, 2, 607);
                yield return new motor(21.4, -101.9, 2, 607);
                yield return new motor(21.8, -108.4, 2, 607);
                yield return new motor(22, -123.1, 2, 607);
                yield return new motor(23.2, -123.1, 2, 607);
                yield return new motor(23.4, -128.5, 2, 607);
                yield return new motor(24, -112.5, 2, 607);
                yield return new motor(24.2, -95.1, 2, 607);
                yield return new motor(24.6, -53.5, 2, 607);
                yield return new motor(25, -64.4, 2, 607);
                yield return new motor(25.4, -72.3, 2, 607);
                yield return new motor(25.6, -26.8, 2, 607);
                yield return new motor(26, -5.4, 2, 607);
                yield return new motor(26.2, -107.1, 2, 607);
                yield return new motor(26.4, -65.6, 2, 607);
                yield return new motor(27, -16, 2, 607);
                yield return new motor(27.2, -45.6, 2, 607);
                yield return new motor(27.6, 4, 2, 607);
                yield return new motor(28.2, 12, 2, 607);
                yield return new motor(28.4, -21.5, 2, 607);
                yield return new motor(28.6, 46.9, 2, 607);
                yield return new motor(29.4, -17.4, 2, 607);
                yield return new motor(30.2, 36.2, 2, 607);
                yield return new motor(31, 75, 2, 607);
                yield return new motor(31.2, 8.1, 2, 607);
                yield return new motor(32, 54.9, 2, 607);
                yield return new motor(32.8, 46.9, 2, 607);
                yield return new motor(33.4, 16, 2, 607);
                yield return new motor(33.8, 45.6, 2, 607);
                yield return new motor(34.4, 1.3, 2, 607);
                yield return new motor(34.8, 75, 2, 607);
                yield return new motor(35.2, -16, 2, 607);
                yield return new motor(35.4, 69.6, 2, 607);
                yield return new motor(35.6, 34.8, 2, 607);
                yield return new motor(36.2, -37.5, 2, 607);
                yield return new motor(38, 46.9, 2, 607);
                yield return new motor(39.2, 5.4, 2, 607);
                yield return new motor(39.4, -1.3, 2, 607);
                yield return new motor(40, -21.5, 2, 607);
                yield return new motor(40.4, -13.3, 2, 607);
                yield return new motor(41.6, 30.8, 3, 138);
                yield return new motor(42.4, 29.4, 3, 138);
                yield return new motor(42.8, 0, 3, 138);
                yield return new motor(43, 14.7, 3, 138);
                yield return new motor(44, -1.3, 3, 138);
                yield return new motor(44.4, 0, 3, 138);
                yield return new motor(45, 10.7, 3, 138);
                yield return new motor(46.6, 10.7, 3, 138);
                yield return new motor(47.8, -26.8, 3, 138);
                yield return new motor(48.8, -13.3, 3, 138);
                yield return new motor(50.6, 0, 3, 138);
                yield return new motor(52, 10.7, 3, 138);
                yield return new motor(53.2, -14.7, 3, 138);
                yield return new motor(55, -2.7, 3, 138);
                yield return new motor(55.4, -2.7, 3, 138);
                yield return new motor(57.6, 10.7, 3, 138);
            }
        }
    }
}
