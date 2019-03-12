// ReSharper disable All

namespace Rdatasets.Zelig
{
    using System.Collections.Generic;

    /// <summary>
    /// Social Security Expenditure Data
    /// </summary>

    public class hoff
    {
        public readonly int κ;
        public readonly int year;
        public readonly double L2SocSec;
        public readonly double Just503D;
        public readonly double Just503R;
        public readonly int RGovDumy;

        public hoff(int κ, int year, double L2SocSec, double Just503D, double Just503R, int RGovDumy)
        {
            this.κ = κ;
            this.year = year;
            this.L2SocSec = L2SocSec;
            this.Just503D = Just503D;
            this.Just503R = Just503R;
            this.RGovDumy = RGovDumy;
        }

        public static IEnumerable<hoff> Data
        {
            get
            {
                yield return new hoff(1, 1948, 1.83, 0, 2.44, 0);
                yield return new hoff(2, 1949, 3.44, 0, 2.44, 0);
                yield return new hoff(3, 1950, 3.05, 0, 2.44, 0);
                yield return new hoff(4, 1951, 3.57, 0, 2.44, 0);
                yield return new hoff(5, 1952, 4.73, 5.41, 3.5, 1);
                yield return new hoff(6, 1953, 6.47, 5.41, 3.5, 1);
                yield return new hoff(7, 1954, 7.75, 5.41, 3.5, 1);
                yield return new hoff(8, 1955, 8.7, 5.41, 3.5, 1);
                yield return new hoff(9, 1956, 9.97, 3.04, 1.03, 1);
                yield return new hoff(10, 1957, 10.57, 3.04, 1.03, 1);
                yield return new hoff(11, 1958, 12.58, 3.04, 1.03, 1);
                yield return new hoff(12, 1959, 12.76, 3.04, 1.03, 1);
                yield return new hoff(13, 1960, 13.45, 2.01, 0.84, 0);
                yield return new hoff(14, 1961, 14.18, 2.01, 0.84, 0);
                yield return new hoff(15, 1962, 14.02, 2.01, 0.84, 0);
                yield return new hoff(16, 1963, 14.77, 2.01, 0.84, 0);
                yield return new hoff(17, 1964, 15.38, 0.82, 0.28, 0);
                yield return new hoff(18, 1965, 13.92, 0.82, 0.28, 0);
                yield return new hoff(19, 1966, 13.29, 0.82, 0.28, 0);
                yield return new hoff(20, 1967, 14.86, 0.82, 0.28, 0);
                yield return new hoff(21, 1968, 15.47, 0.62, 0.2, 1);
                yield return new hoff(22, 1969, 17.07, 0.62, 0.2, 1);
                yield return new hoff(23, 1970, 17.41, 0.62, 0.2, 1);
                yield return new hoff(24, 1971, 19.98, 0.62, 0.2, 1);
                yield return new hoff(25, 1972, 20.74, 1.8, 0.18, 1);
                yield return new hoff(26, 1973, 19.46, 1.8, 0.18, 1);
                yield return new hoff(27, 1974, 19.88, 1.8, 0.18, 1);
                yield return new hoff(28, 1975, 20.79, 1.8, 0.18, 1);
                yield return new hoff(29, 1976, 20.46, 0.67, 0.62, 0);
                yield return new hoff(30, 1977, 20.67, 0.67, 0.62, 0);
                yield return new hoff(31, 1978, 20.06, 0.67, 0.62, 0);
                yield return new hoff(32, 1979, 20.58, 0.67, 0.62, 0);
                yield return new hoff(33, 1980, 20.91, 3.14, 2.28, 1);
                yield return new hoff(34, 1981, 21.12, 3.14, 2.28, 1);
                yield return new hoff(35, 1982, 20.92, 3.14, 2.28, 1);
                yield return new hoff(36, 1983, 19.93, 3.14, 2.28, 1);
            }
        }
    }
}
