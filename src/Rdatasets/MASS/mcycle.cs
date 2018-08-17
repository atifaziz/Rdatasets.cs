// ReSharper disable All

namespace Rdatasets.MASS
{
    using System.Collections.Generic;

    /// <summary>
    /// Data from a Simulated Motorcycle Accident
    /// </summary>

    public class mcycle
    {
        public readonly double times;
        public readonly double accel;

        public mcycle(double times, double accel)
        {
            this.times = times;
            this.accel = accel;
        }

        public static IEnumerable<mcycle> Data
        {
            get
            {
                yield return new mcycle(2.4, 0);
                yield return new mcycle(2.6, -1.3);
                yield return new mcycle(3.2, -2.7);
                yield return new mcycle(3.6, 0);
                yield return new mcycle(4, -2.7);
                yield return new mcycle(6.2, -2.7);
                yield return new mcycle(6.6, -2.7);
                yield return new mcycle(6.8, -1.3);
                yield return new mcycle(7.8, -2.7);
                yield return new mcycle(8.2, -2.7);
                yield return new mcycle(8.8, -1.3);
                yield return new mcycle(8.8, -2.7);
                yield return new mcycle(9.6, -2.7);
                yield return new mcycle(10, -2.7);
                yield return new mcycle(10.2, -5.4);
                yield return new mcycle(10.6, -2.7);
                yield return new mcycle(11, -5.4);
                yield return new mcycle(11.4, 0);
                yield return new mcycle(13.2, -2.7);
                yield return new mcycle(13.6, -2.7);
                yield return new mcycle(13.8, 0);
                yield return new mcycle(14.6, -13.3);
                yield return new mcycle(14.6, -5.4);
                yield return new mcycle(14.6, -5.4);
                yield return new mcycle(14.6, -9.3);
                yield return new mcycle(14.6, -16);
                yield return new mcycle(14.6, -22.8);
                yield return new mcycle(14.8, -2.7);
                yield return new mcycle(15.4, -22.8);
                yield return new mcycle(15.4, -32.1);
                yield return new mcycle(15.4, -53.5);
                yield return new mcycle(15.4, -54.9);
                yield return new mcycle(15.6, -40.2);
                yield return new mcycle(15.6, -21.5);
                yield return new mcycle(15.8, -21.5);
                yield return new mcycle(15.8, -50.8);
                yield return new mcycle(16, -42.9);
                yield return new mcycle(16, -26.8);
                yield return new mcycle(16.2, -21.5);
                yield return new mcycle(16.2, -50.8);
                yield return new mcycle(16.2, -61.7);
                yield return new mcycle(16.4, -5.4);
                yield return new mcycle(16.4, -80.4);
                yield return new mcycle(16.6, -59);
                yield return new mcycle(16.8, -71);
                yield return new mcycle(16.8, -91.1);
                yield return new mcycle(16.8, -77.7);
                yield return new mcycle(17.6, -37.5);
                yield return new mcycle(17.6, -85.6);
                yield return new mcycle(17.6, -123.1);
                yield return new mcycle(17.6, -101.9);
                yield return new mcycle(17.8, -99.1);
                yield return new mcycle(17.8, -104.4);
                yield return new mcycle(18.6, -112.5);
                yield return new mcycle(18.6, -50.8);
                yield return new mcycle(19.2, -123.1);
                yield return new mcycle(19.4, -85.6);
                yield return new mcycle(19.4, -72.3);
                yield return new mcycle(19.6, -127.2);
                yield return new mcycle(20.2, -123.1);
                yield return new mcycle(20.4, -117.9);
                yield return new mcycle(21.2, -134);
                yield return new mcycle(21.4, -101.9);
                yield return new mcycle(21.8, -108.4);
                yield return new mcycle(22, -123.1);
                yield return new mcycle(23.2, -123.1);
                yield return new mcycle(23.4, -128.5);
                yield return new mcycle(24, -112.5);
                yield return new mcycle(24.2, -95.1);
                yield return new mcycle(24.2, -81.8);
                yield return new mcycle(24.6, -53.5);
                yield return new mcycle(25, -64.4);
                yield return new mcycle(25, -57.6);
                yield return new mcycle(25.4, -72.3);
                yield return new mcycle(25.4, -44.3);
                yield return new mcycle(25.6, -26.8);
                yield return new mcycle(26, -5.4);
                yield return new mcycle(26.2, -107.1);
                yield return new mcycle(26.2, -21.5);
                yield return new mcycle(26.4, -65.6);
                yield return new mcycle(27, -16);
                yield return new mcycle(27.2, -45.6);
                yield return new mcycle(27.2, -24.2);
                yield return new mcycle(27.2, 9.5);
                yield return new mcycle(27.6, 4);
                yield return new mcycle(28.2, 12);
                yield return new mcycle(28.4, -21.5);
                yield return new mcycle(28.4, 37.5);
                yield return new mcycle(28.6, 46.9);
                yield return new mcycle(29.4, -17.4);
                yield return new mcycle(30.2, 36.2);
                yield return new mcycle(31, 75);
                yield return new mcycle(31.2, 8.1);
                yield return new mcycle(32, 54.9);
                yield return new mcycle(32, 48.2);
                yield return new mcycle(32.8, 46.9);
                yield return new mcycle(33.4, 16);
                yield return new mcycle(33.8, 45.6);
                yield return new mcycle(34.4, 1.3);
                yield return new mcycle(34.8, 75);
                yield return new mcycle(35.2, -16);
                yield return new mcycle(35.2, -54.9);
                yield return new mcycle(35.4, 69.6);
                yield return new mcycle(35.6, 34.8);
                yield return new mcycle(35.6, 32.1);
                yield return new mcycle(36.2, -37.5);
                yield return new mcycle(36.2, 22.8);
                yield return new mcycle(38, 46.9);
                yield return new mcycle(38, 10.7);
                yield return new mcycle(39.2, 5.4);
                yield return new mcycle(39.4, -1.3);
                yield return new mcycle(40, -21.5);
                yield return new mcycle(40.4, -13.3);
                yield return new mcycle(41.6, 30.8);
                yield return new mcycle(41.6, -10.7);
                yield return new mcycle(42.4, 29.4);
                yield return new mcycle(42.8, 0);
                yield return new mcycle(42.8, -10.7);
                yield return new mcycle(43, 14.7);
                yield return new mcycle(44, -1.3);
                yield return new mcycle(44.4, 0);
                yield return new mcycle(45, 10.7);
                yield return new mcycle(46.6, 10.7);
                yield return new mcycle(47.8, -26.8);
                yield return new mcycle(47.8, -14.7);
                yield return new mcycle(48.8, -13.3);
                yield return new mcycle(50.6, 0);
                yield return new mcycle(52, 10.7);
                yield return new mcycle(53.2, -14.7);
                yield return new mcycle(55, -2.7);
                yield return new mcycle(55, 10.7);
                yield return new mcycle(55.4, -2.7);
                yield return new mcycle(57.6, 10.7);
            }
        }
    }
}
