// ReSharper disable All

namespace Rdatasets.Zelig
{
    using System.Collections.Generic;

    /// <summary>
    /// Social Security Expenditure Data
    /// </summary>

    public class hoff
    {
        public readonly int year;
        public readonly double L2SocSec;
        public readonly double Just503D;
        public readonly double Just503R;
        public readonly int RGovDumy;

        public hoff(int year, double L2SocSec, double Just503D, double Just503R, int RGovDumy)
        {
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
                yield return new hoff(1948, 1.83, 0, 2.44, 0);
                yield return new hoff(1949, 3.44, 0, 2.44, 0);
                yield return new hoff(1950, 3.05, 0, 2.44, 0);
                yield return new hoff(1951, 3.57, 0, 2.44, 0);
                yield return new hoff(1952, 4.73, 5.41, 3.5, 1);
                yield return new hoff(1953, 6.47, 5.41, 3.5, 1);
                yield return new hoff(1954, 7.75, 5.41, 3.5, 1);
                yield return new hoff(1955, 8.7, 5.41, 3.5, 1);
                yield return new hoff(1956, 9.97, 3.04, 1.03, 1);
                yield return new hoff(1957, 10.57, 3.04, 1.03, 1);
                yield return new hoff(1958, 12.58, 3.04, 1.03, 1);
                yield return new hoff(1959, 12.76, 3.04, 1.03, 1);
                yield return new hoff(1960, 13.45, 2.01, 0.84, 0);
                yield return new hoff(1961, 14.18, 2.01, 0.84, 0);
                yield return new hoff(1962, 14.02, 2.01, 0.84, 0);
                yield return new hoff(1963, 14.77, 2.01, 0.84, 0);
                yield return new hoff(1964, 15.38, 0.82, 0.28, 0);
                yield return new hoff(1965, 13.92, 0.82, 0.28, 0);
                yield return new hoff(1966, 13.29, 0.82, 0.28, 0);
                yield return new hoff(1967, 14.86, 0.82, 0.28, 0);
                yield return new hoff(1968, 15.47, 0.62, 0.2, 1);
                yield return new hoff(1969, 17.07, 0.62, 0.2, 1);
                yield return new hoff(1970, 17.41, 0.62, 0.2, 1);
                yield return new hoff(1971, 19.98, 0.62, 0.2, 1);
                yield return new hoff(1972, 20.74, 1.8, 0.18, 1);
                yield return new hoff(1973, 19.46, 1.8, 0.18, 1);
                yield return new hoff(1974, 19.88, 1.8, 0.18, 1);
                yield return new hoff(1975, 20.79, 1.8, 0.18, 1);
                yield return new hoff(1976, 20.46, 0.67, 0.62, 0);
                yield return new hoff(1977, 20.67, 0.67, 0.62, 0);
                yield return new hoff(1978, 20.06, 0.67, 0.62, 0);
                yield return new hoff(1979, 20.58, 0.67, 0.62, 0);
                yield return new hoff(1980, 20.91, 3.14, 2.28, 1);
                yield return new hoff(1981, 21.12, 3.14, 2.28, 1);
                yield return new hoff(1982, 20.92, 3.14, 2.28, 1);
                yield return new hoff(1983, 19.93, 3.14, 2.28, 1);
            }
        }
    }
}
