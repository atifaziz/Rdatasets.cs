// ReSharper disable All

namespace Rdatasets.lattice
{
    using System.Collections.Generic;

    /// <summary>
    /// Melanoma skin cancer incidence
    /// </summary>

    public class melanoma
    {
        public readonly int year;
        public readonly double incidence;

        public melanoma(int year, double incidence)
        {
            this.year = year;
            this.incidence = incidence;
        }

        public static IEnumerable<melanoma> Data
        {
            get
            {
                yield return new melanoma(1936, 0.9);
                yield return new melanoma(1937, 0.8);
                yield return new melanoma(1938, 0.8);
                yield return new melanoma(1939, 1.3);
                yield return new melanoma(1940, 1.4);
                yield return new melanoma(1941, 1.2);
                yield return new melanoma(1942, 1.7);
                yield return new melanoma(1943, 1.8);
                yield return new melanoma(1944, 1.6);
                yield return new melanoma(1945, 1.5);
                yield return new melanoma(1946, 1.5);
                yield return new melanoma(1947, 2);
                yield return new melanoma(1948, 2.5);
                yield return new melanoma(1949, 2.7);
                yield return new melanoma(1950, 2.9);
                yield return new melanoma(1951, 2.5);
                yield return new melanoma(1952, 3.1);
                yield return new melanoma(1953, 2.4);
                yield return new melanoma(1954, 2.2);
                yield return new melanoma(1955, 2.9);
                yield return new melanoma(1956, 2.5);
                yield return new melanoma(1957, 2.6);
                yield return new melanoma(1958, 3.2);
                yield return new melanoma(1959, 3.8);
                yield return new melanoma(1960, 4.2);
                yield return new melanoma(1961, 3.9);
                yield return new melanoma(1962, 3.7);
                yield return new melanoma(1963, 3.3);
                yield return new melanoma(1964, 3.7);
                yield return new melanoma(1965, 3.9);
                yield return new melanoma(1966, 4.1);
                yield return new melanoma(1967, 3.8);
                yield return new melanoma(1968, 4.7);
                yield return new melanoma(1969, 4.4);
                yield return new melanoma(1970, 4.8);
                yield return new melanoma(1971, 4.8);
                yield return new melanoma(1972, 4.8);
            }
        }
    }
}
