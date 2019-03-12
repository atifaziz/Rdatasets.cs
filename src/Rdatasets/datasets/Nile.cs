// ReSharper disable All

namespace Rdatasets.datasets
{
    using System.Collections.Generic;

    /// <summary>
    /// Flow of the River Nile
    /// </summary>

    public class Nile
    {
        public readonly int κ;
        public readonly int time;
        public readonly int value;

        public Nile(int κ, int time, int value)
        {
            this.κ = κ;
            this.time = time;
            this.value = value;
        }

        public static IEnumerable<Nile> Data
        {
            get
            {
                yield return new Nile(1, 1871, 1120);
                yield return new Nile(2, 1872, 1160);
                yield return new Nile(3, 1873, 963);
                yield return new Nile(4, 1874, 1210);
                yield return new Nile(5, 1875, 1160);
                yield return new Nile(6, 1876, 1160);
                yield return new Nile(7, 1877, 813);
                yield return new Nile(8, 1878, 1230);
                yield return new Nile(9, 1879, 1370);
                yield return new Nile(10, 1880, 1140);
                yield return new Nile(11, 1881, 995);
                yield return new Nile(12, 1882, 935);
                yield return new Nile(13, 1883, 1110);
                yield return new Nile(14, 1884, 994);
                yield return new Nile(15, 1885, 1020);
                yield return new Nile(16, 1886, 960);
                yield return new Nile(17, 1887, 1180);
                yield return new Nile(18, 1888, 799);
                yield return new Nile(19, 1889, 958);
                yield return new Nile(20, 1890, 1140);
                yield return new Nile(21, 1891, 1100);
                yield return new Nile(22, 1892, 1210);
                yield return new Nile(23, 1893, 1150);
                yield return new Nile(24, 1894, 1250);
                yield return new Nile(25, 1895, 1260);
                yield return new Nile(26, 1896, 1220);
                yield return new Nile(27, 1897, 1030);
                yield return new Nile(28, 1898, 1100);
                yield return new Nile(29, 1899, 774);
                yield return new Nile(30, 1900, 840);
                yield return new Nile(31, 1901, 874);
                yield return new Nile(32, 1902, 694);
                yield return new Nile(33, 1903, 940);
                yield return new Nile(34, 1904, 833);
                yield return new Nile(35, 1905, 701);
                yield return new Nile(36, 1906, 916);
                yield return new Nile(37, 1907, 692);
                yield return new Nile(38, 1908, 1020);
                yield return new Nile(39, 1909, 1050);
                yield return new Nile(40, 1910, 969);
                yield return new Nile(41, 1911, 831);
                yield return new Nile(42, 1912, 726);
                yield return new Nile(43, 1913, 456);
                yield return new Nile(44, 1914, 824);
                yield return new Nile(45, 1915, 702);
                yield return new Nile(46, 1916, 1120);
                yield return new Nile(47, 1917, 1100);
                yield return new Nile(48, 1918, 832);
                yield return new Nile(49, 1919, 764);
                yield return new Nile(50, 1920, 821);
                yield return new Nile(51, 1921, 768);
                yield return new Nile(52, 1922, 845);
                yield return new Nile(53, 1923, 864);
                yield return new Nile(54, 1924, 862);
                yield return new Nile(55, 1925, 698);
                yield return new Nile(56, 1926, 845);
                yield return new Nile(57, 1927, 744);
                yield return new Nile(58, 1928, 796);
                yield return new Nile(59, 1929, 1040);
                yield return new Nile(60, 1930, 759);
                yield return new Nile(61, 1931, 781);
                yield return new Nile(62, 1932, 865);
                yield return new Nile(63, 1933, 845);
                yield return new Nile(64, 1934, 944);
                yield return new Nile(65, 1935, 984);
                yield return new Nile(66, 1936, 897);
                yield return new Nile(67, 1937, 822);
                yield return new Nile(68, 1938, 1010);
                yield return new Nile(69, 1939, 771);
                yield return new Nile(70, 1940, 676);
                yield return new Nile(71, 1941, 649);
                yield return new Nile(72, 1942, 846);
                yield return new Nile(73, 1943, 812);
                yield return new Nile(74, 1944, 742);
                yield return new Nile(75, 1945, 801);
                yield return new Nile(76, 1946, 1040);
                yield return new Nile(77, 1947, 860);
                yield return new Nile(78, 1948, 874);
                yield return new Nile(79, 1949, 848);
                yield return new Nile(80, 1950, 890);
                yield return new Nile(81, 1951, 744);
                yield return new Nile(82, 1952, 749);
                yield return new Nile(83, 1953, 838);
                yield return new Nile(84, 1954, 1050);
                yield return new Nile(85, 1955, 918);
                yield return new Nile(86, 1956, 986);
                yield return new Nile(87, 1957, 797);
                yield return new Nile(88, 1958, 923);
                yield return new Nile(89, 1959, 975);
                yield return new Nile(90, 1960, 815);
                yield return new Nile(91, 1961, 1020);
                yield return new Nile(92, 1962, 906);
                yield return new Nile(93, 1963, 901);
                yield return new Nile(94, 1964, 1170);
                yield return new Nile(95, 1965, 912);
                yield return new Nile(96, 1966, 746);
                yield return new Nile(97, 1967, 919);
                yield return new Nile(98, 1968, 718);
                yield return new Nile(99, 1969, 714);
                yield return new Nile(100, 1970, 740);
            }
        }
    }
}
