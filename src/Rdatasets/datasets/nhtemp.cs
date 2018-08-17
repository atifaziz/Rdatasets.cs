// ReSharper disable All

namespace Rdatasets.datasets
{
    using System.Collections.Generic;

    /// <summary>
    /// Average Yearly Temperatures in New Haven
    /// </summary>

    public class nhtemp
    {
        public readonly int time;
        public readonly double value;

        public nhtemp(int time, double value)
        {
            this.time = time;
            this.value = value;
        }

        public static IEnumerable<nhtemp> Data
        {
            get
            {
                yield return new nhtemp(1912, 49.9);
                yield return new nhtemp(1913, 52.3);
                yield return new nhtemp(1914, 49.4);
                yield return new nhtemp(1915, 51.1);
                yield return new nhtemp(1916, 49.4);
                yield return new nhtemp(1917, 47.9);
                yield return new nhtemp(1918, 49.8);
                yield return new nhtemp(1919, 50.9);
                yield return new nhtemp(1920, 49.3);
                yield return new nhtemp(1921, 51.9);
                yield return new nhtemp(1922, 50.8);
                yield return new nhtemp(1923, 49.6);
                yield return new nhtemp(1924, 49.3);
                yield return new nhtemp(1925, 50.6);
                yield return new nhtemp(1926, 48.4);
                yield return new nhtemp(1927, 50.7);
                yield return new nhtemp(1928, 50.9);
                yield return new nhtemp(1929, 50.6);
                yield return new nhtemp(1930, 51.5);
                yield return new nhtemp(1931, 52.8);
                yield return new nhtemp(1932, 51.8);
                yield return new nhtemp(1933, 51.1);
                yield return new nhtemp(1934, 49.8);
                yield return new nhtemp(1935, 50.2);
                yield return new nhtemp(1936, 50.4);
                yield return new nhtemp(1937, 51.6);
                yield return new nhtemp(1938, 51.8);
                yield return new nhtemp(1939, 50.9);
                yield return new nhtemp(1940, 48.8);
                yield return new nhtemp(1941, 51.7);
                yield return new nhtemp(1942, 51);
                yield return new nhtemp(1943, 50.6);
                yield return new nhtemp(1944, 51.7);
                yield return new nhtemp(1945, 51.5);
                yield return new nhtemp(1946, 52.1);
                yield return new nhtemp(1947, 51.3);
                yield return new nhtemp(1948, 51);
                yield return new nhtemp(1949, 54);
                yield return new nhtemp(1950, 51.4);
                yield return new nhtemp(1951, 52.7);
                yield return new nhtemp(1952, 53.1);
                yield return new nhtemp(1953, 54.6);
                yield return new nhtemp(1954, 52);
                yield return new nhtemp(1955, 52);
                yield return new nhtemp(1956, 50.9);
                yield return new nhtemp(1957, 52.6);
                yield return new nhtemp(1958, 50.2);
                yield return new nhtemp(1959, 52.6);
                yield return new nhtemp(1960, 51.6);
                yield return new nhtemp(1961, 51.9);
                yield return new nhtemp(1962, 50.5);
                yield return new nhtemp(1963, 50.9);
                yield return new nhtemp(1964, 51.7);
                yield return new nhtemp(1965, 51.4);
                yield return new nhtemp(1966, 51.7);
                yield return new nhtemp(1967, 50.8);
                yield return new nhtemp(1968, 51.9);
                yield return new nhtemp(1969, 51.8);
                yield return new nhtemp(1970, 51.9);
                yield return new nhtemp(1971, 53);
            }
        }
    }
}
