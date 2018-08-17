// ReSharper disable All

namespace Rdatasets.datasets
{
    using System.Collections.Generic;

    /// <summary>
    /// Flow of the River Nile
    /// </summary>

    public class Nile
    {
        public readonly int time;
        public readonly int value;

        public Nile(int time, int value)
        {
            this.time = time;
            this.value = value;
        }

        public static IEnumerable<Nile> Data
        {
            get
            {
                yield return new Nile(1871, 1120);
                yield return new Nile(1872, 1160);
                yield return new Nile(1873, 963);
                yield return new Nile(1874, 1210);
                yield return new Nile(1875, 1160);
                yield return new Nile(1876, 1160);
                yield return new Nile(1877, 813);
                yield return new Nile(1878, 1230);
                yield return new Nile(1879, 1370);
                yield return new Nile(1880, 1140);
                yield return new Nile(1881, 995);
                yield return new Nile(1882, 935);
                yield return new Nile(1883, 1110);
                yield return new Nile(1884, 994);
                yield return new Nile(1885, 1020);
                yield return new Nile(1886, 960);
                yield return new Nile(1887, 1180);
                yield return new Nile(1888, 799);
                yield return new Nile(1889, 958);
                yield return new Nile(1890, 1140);
                yield return new Nile(1891, 1100);
                yield return new Nile(1892, 1210);
                yield return new Nile(1893, 1150);
                yield return new Nile(1894, 1250);
                yield return new Nile(1895, 1260);
                yield return new Nile(1896, 1220);
                yield return new Nile(1897, 1030);
                yield return new Nile(1898, 1100);
                yield return new Nile(1899, 774);
                yield return new Nile(1900, 840);
                yield return new Nile(1901, 874);
                yield return new Nile(1902, 694);
                yield return new Nile(1903, 940);
                yield return new Nile(1904, 833);
                yield return new Nile(1905, 701);
                yield return new Nile(1906, 916);
                yield return new Nile(1907, 692);
                yield return new Nile(1908, 1020);
                yield return new Nile(1909, 1050);
                yield return new Nile(1910, 969);
                yield return new Nile(1911, 831);
                yield return new Nile(1912, 726);
                yield return new Nile(1913, 456);
                yield return new Nile(1914, 824);
                yield return new Nile(1915, 702);
                yield return new Nile(1916, 1120);
                yield return new Nile(1917, 1100);
                yield return new Nile(1918, 832);
                yield return new Nile(1919, 764);
                yield return new Nile(1920, 821);
                yield return new Nile(1921, 768);
                yield return new Nile(1922, 845);
                yield return new Nile(1923, 864);
                yield return new Nile(1924, 862);
                yield return new Nile(1925, 698);
                yield return new Nile(1926, 845);
                yield return new Nile(1927, 744);
                yield return new Nile(1928, 796);
                yield return new Nile(1929, 1040);
                yield return new Nile(1930, 759);
                yield return new Nile(1931, 781);
                yield return new Nile(1932, 865);
                yield return new Nile(1933, 845);
                yield return new Nile(1934, 944);
                yield return new Nile(1935, 984);
                yield return new Nile(1936, 897);
                yield return new Nile(1937, 822);
                yield return new Nile(1938, 1010);
                yield return new Nile(1939, 771);
                yield return new Nile(1940, 676);
                yield return new Nile(1941, 649);
                yield return new Nile(1942, 846);
                yield return new Nile(1943, 812);
                yield return new Nile(1944, 742);
                yield return new Nile(1945, 801);
                yield return new Nile(1946, 1040);
                yield return new Nile(1947, 860);
                yield return new Nile(1948, 874);
                yield return new Nile(1949, 848);
                yield return new Nile(1950, 890);
                yield return new Nile(1951, 744);
                yield return new Nile(1952, 749);
                yield return new Nile(1953, 838);
                yield return new Nile(1954, 1050);
                yield return new Nile(1955, 918);
                yield return new Nile(1956, 986);
                yield return new Nile(1957, 797);
                yield return new Nile(1958, 923);
                yield return new Nile(1959, 975);
                yield return new Nile(1960, 815);
                yield return new Nile(1961, 1020);
                yield return new Nile(1962, 906);
                yield return new Nile(1963, 901);
                yield return new Nile(1964, 1170);
                yield return new Nile(1965, 912);
                yield return new Nile(1966, 746);
                yield return new Nile(1967, 919);
                yield return new Nile(1968, 718);
                yield return new Nile(1969, 714);
                yield return new Nile(1970, 740);
            }
        }
    }
}
