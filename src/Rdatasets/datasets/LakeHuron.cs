// ReSharper disable All

namespace Rdatasets.datasets
{
    using System.Collections.Generic;

    /// <summary>
    /// Level of Lake Huron 1875-1972
    /// </summary>

    public class LakeHuron
    {
        public readonly int time;
        public readonly double value;

        public LakeHuron(int time, double value)
        {
            this.time = time;
            this.value = value;
        }

        public static IEnumerable<LakeHuron> Data
        {
            get
            {
                yield return new LakeHuron(1875, 580.38);
                yield return new LakeHuron(1876, 581.86);
                yield return new LakeHuron(1877, 580.97);
                yield return new LakeHuron(1878, 580.8);
                yield return new LakeHuron(1879, 579.79);
                yield return new LakeHuron(1880, 580.39);
                yield return new LakeHuron(1881, 580.42);
                yield return new LakeHuron(1882, 580.82);
                yield return new LakeHuron(1883, 581.4);
                yield return new LakeHuron(1884, 581.32);
                yield return new LakeHuron(1885, 581.44);
                yield return new LakeHuron(1886, 581.68);
                yield return new LakeHuron(1887, 581.17);
                yield return new LakeHuron(1888, 580.53);
                yield return new LakeHuron(1889, 580.01);
                yield return new LakeHuron(1890, 579.91);
                yield return new LakeHuron(1891, 579.14);
                yield return new LakeHuron(1892, 579.16);
                yield return new LakeHuron(1893, 579.55);
                yield return new LakeHuron(1894, 579.67);
                yield return new LakeHuron(1895, 578.44);
                yield return new LakeHuron(1896, 578.24);
                yield return new LakeHuron(1897, 579.1);
                yield return new LakeHuron(1898, 579.09);
                yield return new LakeHuron(1899, 579.35);
                yield return new LakeHuron(1900, 578.82);
                yield return new LakeHuron(1901, 579.32);
                yield return new LakeHuron(1902, 579.01);
                yield return new LakeHuron(1903, 579);
                yield return new LakeHuron(1904, 579.8);
                yield return new LakeHuron(1905, 579.83);
                yield return new LakeHuron(1906, 579.72);
                yield return new LakeHuron(1907, 579.89);
                yield return new LakeHuron(1908, 580.01);
                yield return new LakeHuron(1909, 579.37);
                yield return new LakeHuron(1910, 578.69);
                yield return new LakeHuron(1911, 578.19);
                yield return new LakeHuron(1912, 578.67);
                yield return new LakeHuron(1913, 579.55);
                yield return new LakeHuron(1914, 578.92);
                yield return new LakeHuron(1915, 578.09);
                yield return new LakeHuron(1916, 579.37);
                yield return new LakeHuron(1917, 580.13);
                yield return new LakeHuron(1918, 580.14);
                yield return new LakeHuron(1919, 579.51);
                yield return new LakeHuron(1920, 579.24);
                yield return new LakeHuron(1921, 578.66);
                yield return new LakeHuron(1922, 578.86);
                yield return new LakeHuron(1923, 578.05);
                yield return new LakeHuron(1924, 577.79);
                yield return new LakeHuron(1925, 576.75);
                yield return new LakeHuron(1926, 576.75);
                yield return new LakeHuron(1927, 577.82);
                yield return new LakeHuron(1928, 578.64);
                yield return new LakeHuron(1929, 580.58);
                yield return new LakeHuron(1930, 579.48);
                yield return new LakeHuron(1931, 577.38);
                yield return new LakeHuron(1932, 576.9);
                yield return new LakeHuron(1933, 576.94);
                yield return new LakeHuron(1934, 576.24);
                yield return new LakeHuron(1935, 576.84);
                yield return new LakeHuron(1936, 576.85);
                yield return new LakeHuron(1937, 576.9);
                yield return new LakeHuron(1938, 577.79);
                yield return new LakeHuron(1939, 578.18);
                yield return new LakeHuron(1940, 577.51);
                yield return new LakeHuron(1941, 577.23);
                yield return new LakeHuron(1942, 578.42);
                yield return new LakeHuron(1943, 579.61);
                yield return new LakeHuron(1944, 579.05);
                yield return new LakeHuron(1945, 579.26);
                yield return new LakeHuron(1946, 579.22);
                yield return new LakeHuron(1947, 579.38);
                yield return new LakeHuron(1948, 579.1);
                yield return new LakeHuron(1949, 577.95);
                yield return new LakeHuron(1950, 578.12);
                yield return new LakeHuron(1951, 579.75);
                yield return new LakeHuron(1952, 580.85);
                yield return new LakeHuron(1953, 580.41);
                yield return new LakeHuron(1954, 579.96);
                yield return new LakeHuron(1955, 579.61);
                yield return new LakeHuron(1956, 578.76);
                yield return new LakeHuron(1957, 578.18);
                yield return new LakeHuron(1958, 577.21);
                yield return new LakeHuron(1959, 577.13);
                yield return new LakeHuron(1960, 579.1);
                yield return new LakeHuron(1961, 578.25);
                yield return new LakeHuron(1962, 577.91);
                yield return new LakeHuron(1963, 576.89);
                yield return new LakeHuron(1964, 575.96);
                yield return new LakeHuron(1965, 576.8);
                yield return new LakeHuron(1966, 577.68);
                yield return new LakeHuron(1967, 578.38);
                yield return new LakeHuron(1968, 578.52);
                yield return new LakeHuron(1969, 579.74);
                yield return new LakeHuron(1970, 579.31);
                yield return new LakeHuron(1971, 579.89);
                yield return new LakeHuron(1972, 579.96);
            }
        }
    }
}
