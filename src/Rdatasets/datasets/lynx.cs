// ReSharper disable All

namespace Rdatasets.datasets
{
    using System.Collections.Generic;

    /// <summary>
    /// Annual Canadian Lynx trappings 1821-1934
    /// </summary>

    public class lynx
    {
        public readonly int κ;
        public readonly int time;
        public readonly int value;

        public lynx(int κ, int time, int value)
        {
            this.κ = κ;
            this.time = time;
            this.value = value;
        }

        public static IEnumerable<lynx> Data
        {
            get
            {
                yield return new lynx(1, 1821, 269);
                yield return new lynx(2, 1822, 321);
                yield return new lynx(3, 1823, 585);
                yield return new lynx(4, 1824, 871);
                yield return new lynx(5, 1825, 1475);
                yield return new lynx(6, 1826, 2821);
                yield return new lynx(7, 1827, 3928);
                yield return new lynx(8, 1828, 5943);
                yield return new lynx(9, 1829, 4950);
                yield return new lynx(10, 1830, 2577);
                yield return new lynx(11, 1831, 523);
                yield return new lynx(12, 1832, 98);
                yield return new lynx(13, 1833, 184);
                yield return new lynx(14, 1834, 279);
                yield return new lynx(15, 1835, 409);
                yield return new lynx(16, 1836, 2285);
                yield return new lynx(17, 1837, 2685);
                yield return new lynx(18, 1838, 3409);
                yield return new lynx(19, 1839, 1824);
                yield return new lynx(20, 1840, 409);
                yield return new lynx(21, 1841, 151);
                yield return new lynx(22, 1842, 45);
                yield return new lynx(23, 1843, 68);
                yield return new lynx(24, 1844, 213);
                yield return new lynx(25, 1845, 546);
                yield return new lynx(26, 1846, 1033);
                yield return new lynx(27, 1847, 2129);
                yield return new lynx(28, 1848, 2536);
                yield return new lynx(29, 1849, 957);
                yield return new lynx(30, 1850, 361);
                yield return new lynx(31, 1851, 377);
                yield return new lynx(32, 1852, 225);
                yield return new lynx(33, 1853, 360);
                yield return new lynx(34, 1854, 731);
                yield return new lynx(35, 1855, 1638);
                yield return new lynx(36, 1856, 2725);
                yield return new lynx(37, 1857, 2871);
                yield return new lynx(38, 1858, 2119);
                yield return new lynx(39, 1859, 684);
                yield return new lynx(40, 1860, 299);
                yield return new lynx(41, 1861, 236);
                yield return new lynx(42, 1862, 245);
                yield return new lynx(43, 1863, 552);
                yield return new lynx(44, 1864, 1623);
                yield return new lynx(45, 1865, 3311);
                yield return new lynx(46, 1866, 6721);
                yield return new lynx(47, 1867, 4254);
                yield return new lynx(48, 1868, 687);
                yield return new lynx(49, 1869, 255);
                yield return new lynx(50, 1870, 473);
                yield return new lynx(51, 1871, 358);
                yield return new lynx(52, 1872, 784);
                yield return new lynx(53, 1873, 1594);
                yield return new lynx(54, 1874, 1676);
                yield return new lynx(55, 1875, 2251);
                yield return new lynx(56, 1876, 1426);
                yield return new lynx(57, 1877, 756);
                yield return new lynx(58, 1878, 299);
                yield return new lynx(59, 1879, 201);
                yield return new lynx(60, 1880, 229);
                yield return new lynx(61, 1881, 469);
                yield return new lynx(62, 1882, 736);
                yield return new lynx(63, 1883, 2042);
                yield return new lynx(64, 1884, 2811);
                yield return new lynx(65, 1885, 4431);
                yield return new lynx(66, 1886, 2511);
                yield return new lynx(67, 1887, 389);
                yield return new lynx(68, 1888, 73);
                yield return new lynx(69, 1889, 39);
                yield return new lynx(70, 1890, 49);
                yield return new lynx(71, 1891, 59);
                yield return new lynx(72, 1892, 188);
                yield return new lynx(73, 1893, 377);
                yield return new lynx(74, 1894, 1292);
                yield return new lynx(75, 1895, 4031);
                yield return new lynx(76, 1896, 3495);
                yield return new lynx(77, 1897, 587);
                yield return new lynx(78, 1898, 105);
                yield return new lynx(79, 1899, 153);
                yield return new lynx(80, 1900, 387);
                yield return new lynx(81, 1901, 758);
                yield return new lynx(82, 1902, 1307);
                yield return new lynx(83, 1903, 3465);
                yield return new lynx(84, 1904, 6991);
                yield return new lynx(85, 1905, 6313);
                yield return new lynx(86, 1906, 3794);
                yield return new lynx(87, 1907, 1836);
                yield return new lynx(88, 1908, 345);
                yield return new lynx(89, 1909, 382);
                yield return new lynx(90, 1910, 808);
                yield return new lynx(91, 1911, 1388);
                yield return new lynx(92, 1912, 2713);
                yield return new lynx(93, 1913, 3800);
                yield return new lynx(94, 1914, 3091);
                yield return new lynx(95, 1915, 2985);
                yield return new lynx(96, 1916, 3790);
                yield return new lynx(97, 1917, 674);
                yield return new lynx(98, 1918, 81);
                yield return new lynx(99, 1919, 80);
                yield return new lynx(100, 1920, 108);
                yield return new lynx(101, 1921, 229);
                yield return new lynx(102, 1922, 399);
                yield return new lynx(103, 1923, 1132);
                yield return new lynx(104, 1924, 2432);
                yield return new lynx(105, 1925, 3574);
                yield return new lynx(106, 1926, 2935);
                yield return new lynx(107, 1927, 1537);
                yield return new lynx(108, 1928, 529);
                yield return new lynx(109, 1929, 485);
                yield return new lynx(110, 1930, 662);
                yield return new lynx(111, 1931, 1000);
                yield return new lynx(112, 1932, 1590);
                yield return new lynx(113, 1933, 2657);
                yield return new lynx(114, 1934, 3396);
            }
        }
    }
}
