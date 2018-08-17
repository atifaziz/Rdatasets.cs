// ReSharper disable All

namespace Rdatasets.HistData
{
    using System.Collections.Generic;

    /// <summary>
    /// Bowley's data on values of British and Irish trade, 1855-1899
    /// </summary>

    public class Bowley
    {
        public readonly int Year;
        public readonly double Value;

        public Bowley(int Year, double Value)
        {
            this.Year = Year;
            this.Value = Value;
        }

        public static IEnumerable<Bowley> Data
        {
            get
            {
                yield return new Bowley(1855, 95.7);
                yield return new Bowley(1856, 115.8);
                yield return new Bowley(1857, 122);
                yield return new Bowley(1858, 116.6);
                yield return new Bowley(1859, 130.4);
                yield return new Bowley(1860, 135.9);
                yield return new Bowley(1861, 125.1);
                yield return new Bowley(1862, 124);
                yield return new Bowley(1863, 146.5);
                yield return new Bowley(1864, 160.4);
                yield return new Bowley(1865, 165.8);
                yield return new Bowley(1866, 188.9);
                yield return new Bowley(1867, 181);
                yield return new Bowley(1868, 179.7);
                yield return new Bowley(1869, 190);
                yield return new Bowley(1870, 199.6);
                yield return new Bowley(1871, 223.1);
                yield return new Bowley(1872, 256.3);
                yield return new Bowley(1873, 255.2);
                yield return new Bowley(1874, 239.6);
                yield return new Bowley(1875, 223.5);
                yield return new Bowley(1876, 200.6);
                yield return new Bowley(1877, 198.9);
                yield return new Bowley(1878, 192.8);
                yield return new Bowley(1879, 191.5);
                yield return new Bowley(1880, 223.1);
                yield return new Bowley(1881, 234);
                yield return new Bowley(1882, 241.5);
                yield return new Bowley(1883, 239.8);
                yield return new Bowley(1884, 233);
                yield return new Bowley(1885, 213.1);
                yield return new Bowley(1886, 212.7);
                yield return new Bowley(1887, 221.9);
                yield return new Bowley(1888, 234.5);
                yield return new Bowley(1889, 248.9);
                yield return new Bowley(1890, 263.5);
                yield return new Bowley(1891, 247.2);
                yield return new Bowley(1892, 227.1);
                yield return new Bowley(1893, 218.1);
                yield return new Bowley(1894, 215.8);
                yield return new Bowley(1895, 225.9);
                yield return new Bowley(1896, 240.1);
                yield return new Bowley(1897, 234.3);
                yield return new Bowley(1898, 233.4);
                yield return new Bowley(1899, 255.4);
            }
        }
    }
}
