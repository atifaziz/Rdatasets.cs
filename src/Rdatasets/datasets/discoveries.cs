// ReSharper disable All

namespace Rdatasets.datasets
{
    using System.Collections.Generic;

    /// <summary>
    /// Yearly Numbers of Important Discoveries
    /// </summary>

    public class discoveries
    {
        public readonly int time;
        public readonly int value;

        public discoveries(int time, int value)
        {
            this.time = time;
            this.value = value;
        }

        public static IEnumerable<discoveries> Data
        {
            get
            {
                yield return new discoveries(1860, 5);
                yield return new discoveries(1861, 3);
                yield return new discoveries(1862, 0);
                yield return new discoveries(1863, 2);
                yield return new discoveries(1864, 0);
                yield return new discoveries(1865, 3);
                yield return new discoveries(1866, 2);
                yield return new discoveries(1867, 3);
                yield return new discoveries(1868, 6);
                yield return new discoveries(1869, 1);
                yield return new discoveries(1870, 2);
                yield return new discoveries(1871, 1);
                yield return new discoveries(1872, 2);
                yield return new discoveries(1873, 1);
                yield return new discoveries(1874, 3);
                yield return new discoveries(1875, 3);
                yield return new discoveries(1876, 3);
                yield return new discoveries(1877, 5);
                yield return new discoveries(1878, 2);
                yield return new discoveries(1879, 4);
                yield return new discoveries(1880, 4);
                yield return new discoveries(1881, 0);
                yield return new discoveries(1882, 2);
                yield return new discoveries(1883, 3);
                yield return new discoveries(1884, 7);
                yield return new discoveries(1885, 12);
                yield return new discoveries(1886, 3);
                yield return new discoveries(1887, 10);
                yield return new discoveries(1888, 9);
                yield return new discoveries(1889, 2);
                yield return new discoveries(1890, 3);
                yield return new discoveries(1891, 7);
                yield return new discoveries(1892, 7);
                yield return new discoveries(1893, 2);
                yield return new discoveries(1894, 3);
                yield return new discoveries(1895, 3);
                yield return new discoveries(1896, 6);
                yield return new discoveries(1897, 2);
                yield return new discoveries(1898, 4);
                yield return new discoveries(1899, 3);
                yield return new discoveries(1900, 5);
                yield return new discoveries(1901, 2);
                yield return new discoveries(1902, 2);
                yield return new discoveries(1903, 4);
                yield return new discoveries(1904, 0);
                yield return new discoveries(1905, 4);
                yield return new discoveries(1906, 2);
                yield return new discoveries(1907, 5);
                yield return new discoveries(1908, 2);
                yield return new discoveries(1909, 3);
                yield return new discoveries(1910, 3);
                yield return new discoveries(1911, 6);
                yield return new discoveries(1912, 5);
                yield return new discoveries(1913, 8);
                yield return new discoveries(1914, 3);
                yield return new discoveries(1915, 6);
                yield return new discoveries(1916, 6);
                yield return new discoveries(1917, 0);
                yield return new discoveries(1918, 5);
                yield return new discoveries(1919, 2);
                yield return new discoveries(1920, 2);
                yield return new discoveries(1921, 2);
                yield return new discoveries(1922, 6);
                yield return new discoveries(1923, 3);
                yield return new discoveries(1924, 4);
                yield return new discoveries(1925, 4);
                yield return new discoveries(1926, 2);
                yield return new discoveries(1927, 2);
                yield return new discoveries(1928, 4);
                yield return new discoveries(1929, 7);
                yield return new discoveries(1930, 5);
                yield return new discoveries(1931, 3);
                yield return new discoveries(1932, 3);
                yield return new discoveries(1933, 0);
                yield return new discoveries(1934, 2);
                yield return new discoveries(1935, 2);
                yield return new discoveries(1936, 2);
                yield return new discoveries(1937, 1);
                yield return new discoveries(1938, 3);
                yield return new discoveries(1939, 4);
                yield return new discoveries(1940, 2);
                yield return new discoveries(1941, 2);
                yield return new discoveries(1942, 1);
                yield return new discoveries(1943, 1);
                yield return new discoveries(1944, 1);
                yield return new discoveries(1945, 2);
                yield return new discoveries(1946, 1);
                yield return new discoveries(1947, 4);
                yield return new discoveries(1948, 4);
                yield return new discoveries(1949, 3);
                yield return new discoveries(1950, 2);
                yield return new discoveries(1951, 1);
                yield return new discoveries(1952, 4);
                yield return new discoveries(1953, 1);
                yield return new discoveries(1954, 1);
                yield return new discoveries(1955, 1);
                yield return new discoveries(1956, 0);
                yield return new discoveries(1957, 0);
                yield return new discoveries(1958, 2);
                yield return new discoveries(1959, 0);
            }
        }
    }
}
