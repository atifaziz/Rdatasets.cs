// ReSharper disable All

namespace Rdatasets.HistData
{
    using System.Collections.Generic;

    /// <summary>
    /// Bowley's data on values of British and Irish trade, 1855-1899
    /// </summary>

    public class Bowley
    {
        public readonly int κ;
        public readonly int Year;
        public readonly double Value;

        public Bowley(int κ, int Year, double Value)
        {
            this.κ = κ;
            this.Year = Year;
            this.Value = Value;
        }

        public static IEnumerable<Bowley> Data
        {
            get
            {
                yield return new Bowley(1, 1855, 95.7);
                yield return new Bowley(2, 1856, 115.8);
                yield return new Bowley(3, 1857, 122);
                yield return new Bowley(4, 1858, 116.6);
                yield return new Bowley(5, 1859, 130.4);
                yield return new Bowley(6, 1860, 135.9);
                yield return new Bowley(7, 1861, 125.1);
                yield return new Bowley(8, 1862, 124);
                yield return new Bowley(9, 1863, 146.5);
                yield return new Bowley(10, 1864, 160.4);
                yield return new Bowley(11, 1865, 165.8);
                yield return new Bowley(12, 1866, 188.9);
                yield return new Bowley(13, 1867, 181);
                yield return new Bowley(14, 1868, 179.7);
                yield return new Bowley(15, 1869, 190);
                yield return new Bowley(16, 1870, 199.6);
                yield return new Bowley(17, 1871, 223.1);
                yield return new Bowley(18, 1872, 256.3);
                yield return new Bowley(19, 1873, 255.2);
                yield return new Bowley(20, 1874, 239.6);
                yield return new Bowley(21, 1875, 223.5);
                yield return new Bowley(22, 1876, 200.6);
                yield return new Bowley(23, 1877, 198.9);
                yield return new Bowley(24, 1878, 192.8);
                yield return new Bowley(25, 1879, 191.5);
                yield return new Bowley(26, 1880, 223.1);
                yield return new Bowley(27, 1881, 234);
                yield return new Bowley(28, 1882, 241.5);
                yield return new Bowley(29, 1883, 239.8);
                yield return new Bowley(30, 1884, 233);
                yield return new Bowley(31, 1885, 213.1);
                yield return new Bowley(32, 1886, 212.7);
                yield return new Bowley(33, 1887, 221.9);
                yield return new Bowley(34, 1888, 234.5);
                yield return new Bowley(35, 1889, 248.9);
                yield return new Bowley(36, 1890, 263.5);
                yield return new Bowley(37, 1891, 247.2);
                yield return new Bowley(38, 1892, 227.1);
                yield return new Bowley(39, 1893, 218.1);
                yield return new Bowley(40, 1894, 215.8);
                yield return new Bowley(41, 1895, 225.9);
                yield return new Bowley(42, 1896, 240.1);
                yield return new Bowley(43, 1897, 234.3);
                yield return new Bowley(44, 1898, 233.4);
                yield return new Bowley(45, 1899, 255.4);
            }
        }
    }
}
