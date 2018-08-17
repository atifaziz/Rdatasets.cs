// ReSharper disable All

namespace Rdatasets.boot
{
    using System.Collections.Generic;

    /// <summary>
    /// Incidence of Down's Syndrome in British Columbia
    /// </summary>

    public class downs_bc
    {
        public readonly double age;
        public readonly int m;
        public readonly int r;

        public downs_bc(double age, int m, int r)
        {
            this.age = age;
            this.m = m;
            this.r = r;
        }

        public static IEnumerable<downs_bc> Data
        {
            get
            {
                yield return new downs_bc(17, 13555, 16);
                yield return new downs_bc(18.5, 13675, 15);
                yield return new downs_bc(19.5, 18752, 16);
                yield return new downs_bc(20.5, 22005, 22);
                yield return new downs_bc(21.5, 23896, 16);
                yield return new downs_bc(22.5, 24667, 12);
                yield return new downs_bc(23.5, 24807, 17);
                yield return new downs_bc(24.5, 23986, 22);
                yield return new downs_bc(25.5, 22860, 15);
                yield return new downs_bc(26.5, 21450, 14);
                yield return new downs_bc(27.5, 19202, 27);
                yield return new downs_bc(28.5, 17450, 14);
                yield return new downs_bc(29.5, 15685, 9);
                yield return new downs_bc(30.5, 13954, 12);
                yield return new downs_bc(31.5, 11987, 12);
                yield return new downs_bc(32.5, 10983, 18);
                yield return new downs_bc(33.5, 9825, 13);
                yield return new downs_bc(34.5, 8483, 11);
                yield return new downs_bc(35.5, 7448, 23);
                yield return new downs_bc(36.5, 6628, 13);
                yield return new downs_bc(37.5, 5780, 17);
                yield return new downs_bc(38.5, 4834, 15);
                yield return new downs_bc(39.5, 3961, 30);
                yield return new downs_bc(40.5, 2952, 31);
                yield return new downs_bc(41.5, 2276, 33);
                yield return new downs_bc(42.4, 1589, 20);
                yield return new downs_bc(43.5, 1018, 16);
                yield return new downs_bc(44.5, 596, 22);
                yield return new downs_bc(45.5, 327, 11);
                yield return new downs_bc(47, 249, 7);
            }
        }
    }
}
