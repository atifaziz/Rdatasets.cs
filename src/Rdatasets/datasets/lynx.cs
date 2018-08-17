// ReSharper disable All

namespace Rdatasets.datasets
{
    using System.Collections.Generic;

    /// <summary>
    /// Annual Canadian Lynx trappings 1821-1934
    /// </summary>

    public class lynx
    {
        public readonly int time;
        public readonly int value;

        public lynx(int time, int value)
        {
            this.time = time;
            this.value = value;
        }

        public static IEnumerable<lynx> Data
        {
            get
            {
                yield return new lynx(1821, 269);
                yield return new lynx(1822, 321);
                yield return new lynx(1823, 585);
                yield return new lynx(1824, 871);
                yield return new lynx(1825, 1475);
                yield return new lynx(1826, 2821);
                yield return new lynx(1827, 3928);
                yield return new lynx(1828, 5943);
                yield return new lynx(1829, 4950);
                yield return new lynx(1830, 2577);
                yield return new lynx(1831, 523);
                yield return new lynx(1832, 98);
                yield return new lynx(1833, 184);
                yield return new lynx(1834, 279);
                yield return new lynx(1835, 409);
                yield return new lynx(1836, 2285);
                yield return new lynx(1837, 2685);
                yield return new lynx(1838, 3409);
                yield return new lynx(1839, 1824);
                yield return new lynx(1840, 409);
                yield return new lynx(1841, 151);
                yield return new lynx(1842, 45);
                yield return new lynx(1843, 68);
                yield return new lynx(1844, 213);
                yield return new lynx(1845, 546);
                yield return new lynx(1846, 1033);
                yield return new lynx(1847, 2129);
                yield return new lynx(1848, 2536);
                yield return new lynx(1849, 957);
                yield return new lynx(1850, 361);
                yield return new lynx(1851, 377);
                yield return new lynx(1852, 225);
                yield return new lynx(1853, 360);
                yield return new lynx(1854, 731);
                yield return new lynx(1855, 1638);
                yield return new lynx(1856, 2725);
                yield return new lynx(1857, 2871);
                yield return new lynx(1858, 2119);
                yield return new lynx(1859, 684);
                yield return new lynx(1860, 299);
                yield return new lynx(1861, 236);
                yield return new lynx(1862, 245);
                yield return new lynx(1863, 552);
                yield return new lynx(1864, 1623);
                yield return new lynx(1865, 3311);
                yield return new lynx(1866, 6721);
                yield return new lynx(1867, 4254);
                yield return new lynx(1868, 687);
                yield return new lynx(1869, 255);
                yield return new lynx(1870, 473);
                yield return new lynx(1871, 358);
                yield return new lynx(1872, 784);
                yield return new lynx(1873, 1594);
                yield return new lynx(1874, 1676);
                yield return new lynx(1875, 2251);
                yield return new lynx(1876, 1426);
                yield return new lynx(1877, 756);
                yield return new lynx(1878, 299);
                yield return new lynx(1879, 201);
                yield return new lynx(1880, 229);
                yield return new lynx(1881, 469);
                yield return new lynx(1882, 736);
                yield return new lynx(1883, 2042);
                yield return new lynx(1884, 2811);
                yield return new lynx(1885, 4431);
                yield return new lynx(1886, 2511);
                yield return new lynx(1887, 389);
                yield return new lynx(1888, 73);
                yield return new lynx(1889, 39);
                yield return new lynx(1890, 49);
                yield return new lynx(1891, 59);
                yield return new lynx(1892, 188);
                yield return new lynx(1893, 377);
                yield return new lynx(1894, 1292);
                yield return new lynx(1895, 4031);
                yield return new lynx(1896, 3495);
                yield return new lynx(1897, 587);
                yield return new lynx(1898, 105);
                yield return new lynx(1899, 153);
                yield return new lynx(1900, 387);
                yield return new lynx(1901, 758);
                yield return new lynx(1902, 1307);
                yield return new lynx(1903, 3465);
                yield return new lynx(1904, 6991);
                yield return new lynx(1905, 6313);
                yield return new lynx(1906, 3794);
                yield return new lynx(1907, 1836);
                yield return new lynx(1908, 345);
                yield return new lynx(1909, 382);
                yield return new lynx(1910, 808);
                yield return new lynx(1911, 1388);
                yield return new lynx(1912, 2713);
                yield return new lynx(1913, 3800);
                yield return new lynx(1914, 3091);
                yield return new lynx(1915, 2985);
                yield return new lynx(1916, 3790);
                yield return new lynx(1917, 674);
                yield return new lynx(1918, 81);
                yield return new lynx(1919, 80);
                yield return new lynx(1920, 108);
                yield return new lynx(1921, 229);
                yield return new lynx(1922, 399);
                yield return new lynx(1923, 1132);
                yield return new lynx(1924, 2432);
                yield return new lynx(1925, 3574);
                yield return new lynx(1926, 2935);
                yield return new lynx(1927, 1537);
                yield return new lynx(1928, 529);
                yield return new lynx(1929, 485);
                yield return new lynx(1930, 662);
                yield return new lynx(1931, 1000);
                yield return new lynx(1932, 1590);
                yield return new lynx(1933, 2657);
                yield return new lynx(1934, 3396);
            }
        }
    }
}
