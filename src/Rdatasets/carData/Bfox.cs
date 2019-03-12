// ReSharper disable All

namespace Rdatasets.carData
{
    using System.Collections.Generic;

    /// <summary>
    /// Canadian Women's Labour-Force Participation
    /// </summary>

    public class Bfox
    {
        public readonly int κ;
        public readonly double partic;
        public readonly int tfr;
        public readonly double menwage;
        public readonly double womwage;
        public readonly double debt;
        public readonly double parttime;

        public Bfox(int κ, double partic, int tfr, double menwage, double womwage, double debt, double parttime)
        {
            this.κ = κ;
            this.partic = partic;
            this.tfr = tfr;
            this.menwage = menwage;
            this.womwage = womwage;
            this.debt = debt;
            this.parttime = parttime;
        }

        public static IEnumerable<Bfox> Data
        {
            get
            {
                yield return new Bfox(1946, 25.3, 3748, 25.35, 14.05, 18.18, 10.28);
                yield return new Bfox(1947, 24.4, 3996, 26.14, 14.61, 28.33, 9.28);
                yield return new Bfox(1948, 24.2, 3725, 25.11, 14.23, 30.55, 9.51);
                yield return new Bfox(1949, 24.2, 3750, 25.45, 14.61, 35.81, 8.87);
                yield return new Bfox(1950, 23.7, 3669, 26.79, 15.26, 38.39, 8.54);
                yield return new Bfox(1951, 24.2, 3682, 26.33, 14.58, 26.52, 8.84);
                yield return new Bfox(1952, 24.1, 3845, 27.89, 15.66, 45.65, 8.6);
                yield return new Bfox(1953, 23.8, 3905, 29.15, 16.3, 52.99, 5.49);
                yield return new Bfox(1954, 23.6, 4047, 29.52, 16.57, 54.84, 6.67);
                yield return new Bfox(1955, 24.3, 4043, 32.05, 17.99, 65.53, 6.25);
                yield return new Bfox(1956, 25.1, 4092, 32.98, 18.33, 72.56, 6.32);
                yield return new Bfox(1957, 26.2, 4168, 32.25, 17.64, 69.49, 7.3);
                yield return new Bfox(1958, 26.6, 4073, 32.52, 18.16, 71.71, 8.65);
                yield return new Bfox(1959, 26.9, 4100, 33.95, 18.58, 78.89, 8.8);
                yield return new Bfox(1960, 27.9, 4119, 34.63, 18.95, 84.99, 9.39);
                yield return new Bfox(1961, 29.1, 4159, 35.14, 18.78, 87.71, 10.23);
                yield return new Bfox(1962, 29.9, 4134, 34.49, 18.74, 95.31, 10.77);
                yield return new Bfox(1963, 29.8, 4017, 35.99, 19.71, 104.4, 10.84);
                yield return new Bfox(1964, 30.9, 3886, 36.68, 20.06, 116.8, 11.7);
                yield return new Bfox(1965, 32.1, 3467, 37.96, 20.94, 130.99, 12.33);
                yield return new Bfox(1966, 33.2, 3150, 38.68, 21.2, 135.25, 12.18);
                yield return new Bfox(1967, 34.5, 2879, 39.65, 21.95, 142.93, 13.67);
                yield return new Bfox(1968, 35.1, 2681, 41.2, 22.68, 155.47, 13.82);
                yield return new Bfox(1969, 36.1, 2563, 42.44, 23.75, 165.04, 14.91);
                yield return new Bfox(1970, 36.9, 2571, 42.02, 25.63, 164.53, 15.52);
                yield return new Bfox(1971, 37, 2503, 45.32, 26.79, 169.63, 15.47);
                yield return new Bfox(1972, 37.9, 2302, 45.61, 27.51, 190.62, 15.85);
                yield return new Bfox(1973, 40.1, 2931, 45.59, 27.35, 209.6, 15.4);
                yield return new Bfox(1974, 40.6, 1875, 48.06, 29.64, 216.66, 16.23);
                yield return new Bfox(1975, 42.2, 1866, 46.12, 29.33, 224.34, 16.71);
            }
        }
    }
}
