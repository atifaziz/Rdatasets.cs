// ReSharper disable All

namespace Rdatasets.datasets
{
    using System.Collections.Generic;

    /// <summary>
    /// Level of Lake Huron 1875-1972
    /// </summary>

    public class LakeHuron
    {
        public readonly int κ;
        public readonly int time;
        public readonly double value;

        public LakeHuron(int κ, int time, double value)
        {
            this.κ = κ;
            this.time = time;
            this.value = value;
        }

        public static IEnumerable<LakeHuron> Data
        {
            get
            {
                yield return new LakeHuron(1, 1875, 580.38);
                yield return new LakeHuron(2, 1876, 581.86);
                yield return new LakeHuron(3, 1877, 580.97);
                yield return new LakeHuron(4, 1878, 580.8);
                yield return new LakeHuron(5, 1879, 579.79);
                yield return new LakeHuron(6, 1880, 580.39);
                yield return new LakeHuron(7, 1881, 580.42);
                yield return new LakeHuron(8, 1882, 580.82);
                yield return new LakeHuron(9, 1883, 581.4);
                yield return new LakeHuron(10, 1884, 581.32);
                yield return new LakeHuron(11, 1885, 581.44);
                yield return new LakeHuron(12, 1886, 581.68);
                yield return new LakeHuron(13, 1887, 581.17);
                yield return new LakeHuron(14, 1888, 580.53);
                yield return new LakeHuron(15, 1889, 580.01);
                yield return new LakeHuron(16, 1890, 579.91);
                yield return new LakeHuron(17, 1891, 579.14);
                yield return new LakeHuron(18, 1892, 579.16);
                yield return new LakeHuron(19, 1893, 579.55);
                yield return new LakeHuron(20, 1894, 579.67);
                yield return new LakeHuron(21, 1895, 578.44);
                yield return new LakeHuron(22, 1896, 578.24);
                yield return new LakeHuron(23, 1897, 579.1);
                yield return new LakeHuron(24, 1898, 579.09);
                yield return new LakeHuron(25, 1899, 579.35);
                yield return new LakeHuron(26, 1900, 578.82);
                yield return new LakeHuron(27, 1901, 579.32);
                yield return new LakeHuron(28, 1902, 579.01);
                yield return new LakeHuron(29, 1903, 579);
                yield return new LakeHuron(30, 1904, 579.8);
                yield return new LakeHuron(31, 1905, 579.83);
                yield return new LakeHuron(32, 1906, 579.72);
                yield return new LakeHuron(33, 1907, 579.89);
                yield return new LakeHuron(34, 1908, 580.01);
                yield return new LakeHuron(35, 1909, 579.37);
                yield return new LakeHuron(36, 1910, 578.69);
                yield return new LakeHuron(37, 1911, 578.19);
                yield return new LakeHuron(38, 1912, 578.67);
                yield return new LakeHuron(39, 1913, 579.55);
                yield return new LakeHuron(40, 1914, 578.92);
                yield return new LakeHuron(41, 1915, 578.09);
                yield return new LakeHuron(42, 1916, 579.37);
                yield return new LakeHuron(43, 1917, 580.13);
                yield return new LakeHuron(44, 1918, 580.14);
                yield return new LakeHuron(45, 1919, 579.51);
                yield return new LakeHuron(46, 1920, 579.24);
                yield return new LakeHuron(47, 1921, 578.66);
                yield return new LakeHuron(48, 1922, 578.86);
                yield return new LakeHuron(49, 1923, 578.05);
                yield return new LakeHuron(50, 1924, 577.79);
                yield return new LakeHuron(51, 1925, 576.75);
                yield return new LakeHuron(52, 1926, 576.75);
                yield return new LakeHuron(53, 1927, 577.82);
                yield return new LakeHuron(54, 1928, 578.64);
                yield return new LakeHuron(55, 1929, 580.58);
                yield return new LakeHuron(56, 1930, 579.48);
                yield return new LakeHuron(57, 1931, 577.38);
                yield return new LakeHuron(58, 1932, 576.9);
                yield return new LakeHuron(59, 1933, 576.94);
                yield return new LakeHuron(60, 1934, 576.24);
                yield return new LakeHuron(61, 1935, 576.84);
                yield return new LakeHuron(62, 1936, 576.85);
                yield return new LakeHuron(63, 1937, 576.9);
                yield return new LakeHuron(64, 1938, 577.79);
                yield return new LakeHuron(65, 1939, 578.18);
                yield return new LakeHuron(66, 1940, 577.51);
                yield return new LakeHuron(67, 1941, 577.23);
                yield return new LakeHuron(68, 1942, 578.42);
                yield return new LakeHuron(69, 1943, 579.61);
                yield return new LakeHuron(70, 1944, 579.05);
                yield return new LakeHuron(71, 1945, 579.26);
                yield return new LakeHuron(72, 1946, 579.22);
                yield return new LakeHuron(73, 1947, 579.38);
                yield return new LakeHuron(74, 1948, 579.1);
                yield return new LakeHuron(75, 1949, 577.95);
                yield return new LakeHuron(76, 1950, 578.12);
                yield return new LakeHuron(77, 1951, 579.75);
                yield return new LakeHuron(78, 1952, 580.85);
                yield return new LakeHuron(79, 1953, 580.41);
                yield return new LakeHuron(80, 1954, 579.96);
                yield return new LakeHuron(81, 1955, 579.61);
                yield return new LakeHuron(82, 1956, 578.76);
                yield return new LakeHuron(83, 1957, 578.18);
                yield return new LakeHuron(84, 1958, 577.21);
                yield return new LakeHuron(85, 1959, 577.13);
                yield return new LakeHuron(86, 1960, 579.1);
                yield return new LakeHuron(87, 1961, 578.25);
                yield return new LakeHuron(88, 1962, 577.91);
                yield return new LakeHuron(89, 1963, 576.89);
                yield return new LakeHuron(90, 1964, 575.96);
                yield return new LakeHuron(91, 1965, 576.8);
                yield return new LakeHuron(92, 1966, 577.68);
                yield return new LakeHuron(93, 1967, 578.38);
                yield return new LakeHuron(94, 1968, 578.52);
                yield return new LakeHuron(95, 1969, 579.74);
                yield return new LakeHuron(96, 1970, 579.31);
                yield return new LakeHuron(97, 1971, 579.89);
                yield return new LakeHuron(98, 1972, 579.96);
            }
        }
    }
}
