// ReSharper disable All

namespace Rdatasets.datasets
{
    using System.Collections.Generic;

    /// <summary>
    /// Annual Precipitation in US Cities
    /// </summary>

    public class precip
    {
        public readonly double dat;

        public precip(double dat)
        {
            this.dat = dat;
        }

        public static IEnumerable<precip> Data
        {
            get
            {
                yield return new precip(67);
                yield return new precip(54.7);
                yield return new precip(7);
                yield return new precip(48.5);
                yield return new precip(14);
                yield return new precip(17.2);
                yield return new precip(20.7);
                yield return new precip(13);
                yield return new precip(43.4);
                yield return new precip(40.2);
                yield return new precip(38.9);
                yield return new precip(54.5);
                yield return new precip(59.8);
                yield return new precip(48.3);
                yield return new precip(22.9);
                yield return new precip(11.5);
                yield return new precip(34.4);
                yield return new precip(35.1);
                yield return new precip(38.7);
                yield return new precip(30.8);
                yield return new precip(30.6);
                yield return new precip(43.1);
                yield return new precip(56.8);
                yield return new precip(40.8);
                yield return new precip(41.8);
                yield return new precip(42.5);
                yield return new precip(31);
                yield return new precip(31.7);
                yield return new precip(30.2);
                yield return new precip(25.9);
                yield return new precip(49.2);
                yield return new precip(37);
                yield return new precip(35.9);
                yield return new precip(15);
                yield return new precip(30.2);
                yield return new precip(7.2);
                yield return new precip(36.2);
                yield return new precip(45.5);
                yield return new precip(7.8);
                yield return new precip(33.4);
                yield return new precip(36.1);
                yield return new precip(40.2);
                yield return new precip(42.7);
                yield return new precip(42.5);
                yield return new precip(16.2);
                yield return new precip(39);
                yield return new precip(35);
                yield return new precip(37);
                yield return new precip(31.4);
                yield return new precip(37.6);
                yield return new precip(39.9);
                yield return new precip(36.2);
                yield return new precip(42.8);
                yield return new precip(46.4);
                yield return new precip(24.7);
                yield return new precip(49.1);
                yield return new precip(46);
                yield return new precip(35.9);
                yield return new precip(7.8);
                yield return new precip(48.2);
                yield return new precip(15.2);
                yield return new precip(32.5);
                yield return new precip(44.7);
                yield return new precip(42.6);
                yield return new precip(38.8);
                yield return new precip(17.4);
                yield return new precip(40.8);
                yield return new precip(29.1);
                yield return new precip(14.6);
                yield return new precip(59.2);
            }
        }
    }
}
