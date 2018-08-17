// ReSharper disable All

namespace Rdatasets.boot
{
    using System.Collections.Generic;

    /// <summary>
    /// Water Salinity and River Discharge
    /// </summary>

    public class salinity
    {
        public readonly double sal;
        public readonly double lag;
        public readonly int trend;
        public readonly double dis;

        public salinity(double sal, double lag, int trend, double dis)
        {
            this.sal = sal;
            this.lag = lag;
            this.trend = trend;
            this.dis = dis;
        }

        public static IEnumerable<salinity> Data
        {
            get
            {
                yield return new salinity(7.6, 8.2, 4, 23.01);
                yield return new salinity(7.7, 7.6, 5, 22.87);
                yield return new salinity(4.3, 4.6, 0, 26.42);
                yield return new salinity(5.9, 4.3, 1, 24.87);
                yield return new salinity(5, 5.9, 2, 29.9);
                yield return new salinity(6.5, 5, 3, 24.2);
                yield return new salinity(8.3, 6.5, 4, 23.22);
                yield return new salinity(8.2, 8.3, 5, 22.86);
                yield return new salinity(13.2, 10.1, 0, 22.27);
                yield return new salinity(12.6, 13.2, 1, 23.83);
                yield return new salinity(10.4, 12.6, 2, 25.14);
                yield return new salinity(10.8, 10.4, 3, 22.43);
                yield return new salinity(13.1, 10.8, 4, 21.79);
                yield return new salinity(12.3, 13.1, 5, 22.38);
                yield return new salinity(10.4, 13.3, 0, 23.93);
                yield return new salinity(10.5, 10.4, 1, 33.44);
                yield return new salinity(7.7, 10.5, 2, 24.86);
                yield return new salinity(9.5, 7.7, 3, 22.69);
                yield return new salinity(12, 10, 0, 21.79);
                yield return new salinity(12.6, 12, 1, 22.04);
                yield return new salinity(13.6, 12.1, 4, 21.03);
                yield return new salinity(14.1, 13.6, 5, 21.01);
                yield return new salinity(13.5, 15, 0, 25.87);
                yield return new salinity(11.5, 13.5, 1, 26.29);
                yield return new salinity(12, 11.5, 2, 22.93);
                yield return new salinity(13, 12, 3, 21.31);
                yield return new salinity(14.1, 13, 4, 20.77);
                yield return new salinity(15.1, 14.1, 5, 21.39);
            }
        }
    }
}
