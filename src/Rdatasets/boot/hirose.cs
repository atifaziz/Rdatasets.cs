// ReSharper disable All

namespace Rdatasets.boot
{
    using System.Collections.Generic;

    /// <summary>
    /// Failure Time of PET Film
    /// </summary>

    public class hirose
    {
        public readonly int volt;
        public readonly double time;
        public readonly int cens;

        public hirose(int volt, double time, int cens)
        {
            this.volt = volt;
            this.time = time;
            this.cens = cens;
        }

        public static IEnumerable<hirose> Data
        {
            get
            {
                yield return new hirose(5, 7131, 1);
                yield return new hirose(5, 8482, 1);
                yield return new hirose(5, 8559, 1);
                yield return new hirose(5, 8762, 1);
                yield return new hirose(5, 9026, 1);
                yield return new hirose(5, 9034, 1);
                yield return new hirose(5, 9104, 1);
                yield return new hirose(5, 9104.25, 0);
                yield return new hirose(5, 9104.25, 0);
                yield return new hirose(5, 9104.25, 0);
                yield return new hirose(7, 50.25, 1);
                yield return new hirose(7, 87.75, 1);
                yield return new hirose(7, 87.76, 1);
                yield return new hirose(7, 87.77, 1);
                yield return new hirose(7, 92.9, 1);
                yield return new hirose(7, 92.91, 1);
                yield return new hirose(7, 95.96, 1);
                yield return new hirose(7, 108.3, 1);
                yield return new hirose(7, 108.3, 1);
                yield return new hirose(7, 117.9, 1);
                yield return new hirose(7, 123.9, 1);
                yield return new hirose(7, 124.3, 1);
                yield return new hirose(7, 129.7, 1);
                yield return new hirose(7, 135.6, 1);
                yield return new hirose(7, 135.6, 1);
                yield return new hirose(10, 15.17, 1);
                yield return new hirose(10, 19.87, 1);
                yield return new hirose(10, 20.18, 1);
                yield return new hirose(10, 21.5, 1);
                yield return new hirose(10, 21.88, 1);
                yield return new hirose(10, 22.23, 1);
                yield return new hirose(10, 23.02, 1);
                yield return new hirose(10, 23.9, 1);
                yield return new hirose(10, 28.17, 1);
                yield return new hirose(10, 29.7, 1);
                yield return new hirose(15, 2.4, 1);
                yield return new hirose(15, 2.42, 1);
                yield return new hirose(15, 3.17, 1);
                yield return new hirose(15, 3.75, 1);
                yield return new hirose(15, 4.65, 1);
                yield return new hirose(15, 4.95, 1);
                yield return new hirose(15, 6.23, 1);
                yield return new hirose(15, 6.68, 1);
                yield return new hirose(15, 7.3, 1);
            }
        }
    }
}
