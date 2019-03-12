// ReSharper disable All

namespace Rdatasets.datasets
{
    using System.Collections.Generic;

    /// <summary>
    /// Annual Precipitation in US Cities
    /// </summary>

    public class precip
    {
        public readonly int κ;
        public readonly double dat;

        public precip(int κ, double dat)
        {
            this.κ = κ;
            this.dat = dat;
        }

        public static IEnumerable<precip> Data
        {
            get
            {
                yield return new precip(1, 67);
                yield return new precip(2, 54.7);
                yield return new precip(3, 7);
                yield return new precip(4, 48.5);
                yield return new precip(5, 14);
                yield return new precip(6, 17.2);
                yield return new precip(7, 20.7);
                yield return new precip(8, 13);
                yield return new precip(9, 43.4);
                yield return new precip(10, 40.2);
                yield return new precip(11, 38.9);
                yield return new precip(12, 54.5);
                yield return new precip(13, 59.8);
                yield return new precip(14, 48.3);
                yield return new precip(15, 22.9);
                yield return new precip(16, 11.5);
                yield return new precip(17, 34.4);
                yield return new precip(18, 35.1);
                yield return new precip(19, 38.7);
                yield return new precip(20, 30.8);
                yield return new precip(21, 30.6);
                yield return new precip(22, 43.1);
                yield return new precip(23, 56.8);
                yield return new precip(24, 40.8);
                yield return new precip(25, 41.8);
                yield return new precip(26, 42.5);
                yield return new precip(27, 31);
                yield return new precip(28, 31.7);
                yield return new precip(29, 30.2);
                yield return new precip(30, 25.9);
                yield return new precip(31, 49.2);
                yield return new precip(32, 37);
                yield return new precip(33, 35.9);
                yield return new precip(34, 15);
                yield return new precip(35, 30.2);
                yield return new precip(36, 7.2);
                yield return new precip(37, 36.2);
                yield return new precip(38, 45.5);
                yield return new precip(39, 7.8);
                yield return new precip(40, 33.4);
                yield return new precip(41, 36.1);
                yield return new precip(42, 40.2);
                yield return new precip(43, 42.7);
                yield return new precip(44, 42.5);
                yield return new precip(45, 16.2);
                yield return new precip(46, 39);
                yield return new precip(47, 35);
                yield return new precip(48, 37);
                yield return new precip(49, 31.4);
                yield return new precip(50, 37.6);
                yield return new precip(51, 39.9);
                yield return new precip(52, 36.2);
                yield return new precip(53, 42.8);
                yield return new precip(54, 46.4);
                yield return new precip(55, 24.7);
                yield return new precip(56, 49.1);
                yield return new precip(57, 46);
                yield return new precip(58, 35.9);
                yield return new precip(59, 7.8);
                yield return new precip(60, 48.2);
                yield return new precip(61, 15.2);
                yield return new precip(62, 32.5);
                yield return new precip(63, 44.7);
                yield return new precip(64, 42.6);
                yield return new precip(65, 38.8);
                yield return new precip(66, 17.4);
                yield return new precip(67, 40.8);
                yield return new precip(68, 29.1);
                yield return new precip(69, 14.6);
                yield return new precip(70, 59.2);
            }
        }
    }
}
