// ReSharper disable All

namespace Rdatasets.lattice
{
    using System.Collections.Generic;

    /// <summary>
    /// Melanoma skin cancer incidence
    /// </summary>

    public class melanoma
    {
        public readonly int κ;
        public readonly int year;
        public readonly double incidence;

        public melanoma(int κ, int year, double incidence)
        {
            this.κ = κ;
            this.year = year;
            this.incidence = incidence;
        }

        public static IEnumerable<melanoma> Data
        {
            get
            {
                yield return new melanoma(1, 1936, 0.9);
                yield return new melanoma(2, 1937, 0.8);
                yield return new melanoma(3, 1938, 0.8);
                yield return new melanoma(4, 1939, 1.3);
                yield return new melanoma(5, 1940, 1.4);
                yield return new melanoma(6, 1941, 1.2);
                yield return new melanoma(7, 1942, 1.7);
                yield return new melanoma(8, 1943, 1.8);
                yield return new melanoma(9, 1944, 1.6);
                yield return new melanoma(10, 1945, 1.5);
                yield return new melanoma(11, 1946, 1.5);
                yield return new melanoma(12, 1947, 2);
                yield return new melanoma(13, 1948, 2.5);
                yield return new melanoma(14, 1949, 2.7);
                yield return new melanoma(15, 1950, 2.9);
                yield return new melanoma(16, 1951, 2.5);
                yield return new melanoma(17, 1952, 3.1);
                yield return new melanoma(18, 1953, 2.4);
                yield return new melanoma(19, 1954, 2.2);
                yield return new melanoma(20, 1955, 2.9);
                yield return new melanoma(21, 1956, 2.5);
                yield return new melanoma(22, 1957, 2.6);
                yield return new melanoma(23, 1958, 3.2);
                yield return new melanoma(24, 1959, 3.8);
                yield return new melanoma(25, 1960, 4.2);
                yield return new melanoma(26, 1961, 3.9);
                yield return new melanoma(27, 1962, 3.7);
                yield return new melanoma(28, 1963, 3.3);
                yield return new melanoma(29, 1964, 3.7);
                yield return new melanoma(30, 1965, 3.9);
                yield return new melanoma(31, 1966, 4.1);
                yield return new melanoma(32, 1967, 3.8);
                yield return new melanoma(33, 1968, 4.7);
                yield return new melanoma(34, 1969, 4.4);
                yield return new melanoma(35, 1970, 4.8);
                yield return new melanoma(36, 1971, 4.8);
                yield return new melanoma(37, 1972, 4.8);
            }
        }
    }
}
