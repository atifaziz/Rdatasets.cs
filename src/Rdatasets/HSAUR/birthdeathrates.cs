// ReSharper disable All

namespace Rdatasets.HSAUR
{
    using System.Collections.Generic;

    /// <summary>
    /// Birth and Death Rates Data
    /// </summary>

    public class birthdeathrates
    {
        public readonly double birth;
        public readonly double death;

        public birthdeathrates(double birth, double death)
        {
            this.birth = birth;
            this.death = death;
        }

        public static IEnumerable<birthdeathrates> Data
        {
            get
            {
                yield return new birthdeathrates(36.4, 14.6);
                yield return new birthdeathrates(37.3, 8);
                yield return new birthdeathrates(42.1, 15.3);
                yield return new birthdeathrates(55.8, 25.6);
                yield return new birthdeathrates(56.1, 33.1);
                yield return new birthdeathrates(41.8, 15.8);
                yield return new birthdeathrates(46.1, 18.7);
                yield return new birthdeathrates(41.7, 10.1);
                yield return new birthdeathrates(41.4, 19.7);
                yield return new birthdeathrates(35.8, 8.5);
                yield return new birthdeathrates(34, 11);
                yield return new birthdeathrates(36.3, 6.1);
                yield return new birthdeathrates(32.1, 5.5);
                yield return new birthdeathrates(20.9, 8.8);
                yield return new birthdeathrates(27.7, 10.2);
                yield return new birthdeathrates(20.5, 3.9);
                yield return new birthdeathrates(25, 6.2);
                yield return new birthdeathrates(17.3, 7);
                yield return new birthdeathrates(46.3, 6.4);
                yield return new birthdeathrates(14.8, 5.7);
                yield return new birthdeathrates(33.5, 6.4);
                yield return new birthdeathrates(39.2, 11.2);
                yield return new birthdeathrates(28.4, 7.1);
                yield return new birthdeathrates(26.2, 4.3);
                yield return new birthdeathrates(34.8, 7.9);
                yield return new birthdeathrates(23.4, 5.1);
                yield return new birthdeathrates(24.8, 7.8);
                yield return new birthdeathrates(49.9, 8.5);
                yield return new birthdeathrates(33, 8.4);
                yield return new birthdeathrates(47.7, 17.3);
                yield return new birthdeathrates(46.6, 9.7);
                yield return new birthdeathrates(45.1, 10.5);
                yield return new birthdeathrates(42.9, 7.1);
                yield return new birthdeathrates(40.1, 8);
                yield return new birthdeathrates(21.7, 9.6);
                yield return new birthdeathrates(21.8, 8.1);
                yield return new birthdeathrates(17.4, 5.8);
                yield return new birthdeathrates(45, 13.5);
                yield return new birthdeathrates(33.6, 11.8);
                yield return new birthdeathrates(44, 11.7);
                yield return new birthdeathrates(44.2, 13.5);
                yield return new birthdeathrates(27.7, 8.2);
                yield return new birthdeathrates(22.5, 7.8);
                yield return new birthdeathrates(42.8, 6.7);
                yield return new birthdeathrates(18.8, 12.8);
                yield return new birthdeathrates(17.1, 12.7);
                yield return new birthdeathrates(18.2, 12.2);
                yield return new birthdeathrates(16.4, 8.2);
                yield return new birthdeathrates(16.9, 9.5);
                yield return new birthdeathrates(17.6, 19.8);
                yield return new birthdeathrates(18.1, 9.2);
                yield return new birthdeathrates(18.2, 11.7);
                yield return new birthdeathrates(18, 12.5);
                yield return new birthdeathrates(17.4, 7.8);
                yield return new birthdeathrates(13.1, 9.9);
                yield return new birthdeathrates(22.3, 11.9);
                yield return new birthdeathrates(19, 10.2);
                yield return new birthdeathrates(20.9, 8);
                yield return new birthdeathrates(17.5, 10);
                yield return new birthdeathrates(19, 7.5);
                yield return new birthdeathrates(23.5, 10.8);
                yield return new birthdeathrates(15.7, 8.3);
                yield return new birthdeathrates(21.5, 9.1);
                yield return new birthdeathrates(14.8, 10.1);
                yield return new birthdeathrates(18.9, 9.6);
                yield return new birthdeathrates(21.2, 7.2);
                yield return new birthdeathrates(21.4, 8.9);
                yield return new birthdeathrates(21.6, 8.7);
                yield return new birthdeathrates(25.5, 8.8);
            }
        }
    }
}
