// ReSharper disable All

namespace Rdatasets.datasets
{
    using System.Collections.Generic;

    /// <summary>
    /// UK Quarterly Gas Consumption
    /// </summary>

    public class UKgas
    {
        public readonly double time;
        public readonly double value;

        public UKgas(double time, double value)
        {
            this.time = time;
            this.value = value;
        }

        public static IEnumerable<UKgas> Data
        {
            get
            {
                yield return new UKgas(1960, 160.1);
                yield return new UKgas(1960.25, 129.7);
                yield return new UKgas(1960.5, 84.8);
                yield return new UKgas(1960.75, 120.1);
                yield return new UKgas(1961, 160.1);
                yield return new UKgas(1961.25, 124.9);
                yield return new UKgas(1961.5, 84.8);
                yield return new UKgas(1961.75, 116.9);
                yield return new UKgas(1962, 169.7);
                yield return new UKgas(1962.25, 140.9);
                yield return new UKgas(1962.5, 89.7);
                yield return new UKgas(1962.75, 123.3);
                yield return new UKgas(1963, 187.3);
                yield return new UKgas(1963.25, 144.1);
                yield return new UKgas(1963.5, 92.9);
                yield return new UKgas(1963.75, 120.1);
                yield return new UKgas(1964, 176.1);
                yield return new UKgas(1964.25, 147.3);
                yield return new UKgas(1964.5, 89.7);
                yield return new UKgas(1964.75, 123.3);
                yield return new UKgas(1965, 185.7);
                yield return new UKgas(1965.25, 155.3);
                yield return new UKgas(1965.5, 99.3);
                yield return new UKgas(1965.75, 131.3);
                yield return new UKgas(1966, 200.1);
                yield return new UKgas(1966.25, 161.7);
                yield return new UKgas(1966.5, 102.5);
                yield return new UKgas(1966.75, 136.1);
                yield return new UKgas(1967, 204.9);
                yield return new UKgas(1967.25, 176.1);
                yield return new UKgas(1967.5, 112.1);
                yield return new UKgas(1967.75, 140.9);
                yield return new UKgas(1968, 227.3);
                yield return new UKgas(1968.25, 195.3);
                yield return new UKgas(1968.5, 115.3);
                yield return new UKgas(1968.75, 142.5);
                yield return new UKgas(1969, 244.9);
                yield return new UKgas(1969.25, 214.5);
                yield return new UKgas(1969.5, 118.5);
                yield return new UKgas(1969.75, 153.7);
                yield return new UKgas(1970, 244.9);
                yield return new UKgas(1970.25, 216.1);
                yield return new UKgas(1970.5, 188.9);
                yield return new UKgas(1970.75, 142.5);
                yield return new UKgas(1971, 301);
                yield return new UKgas(1971.25, 196.9);
                yield return new UKgas(1971.5, 136.1);
                yield return new UKgas(1971.75, 267.3);
                yield return new UKgas(1972, 317);
                yield return new UKgas(1972.25, 230.5);
                yield return new UKgas(1972.5, 152.1);
                yield return new UKgas(1972.75, 336.2);
                yield return new UKgas(1973, 371.4);
                yield return new UKgas(1973.25, 240.1);
                yield return new UKgas(1973.5, 158.5);
                yield return new UKgas(1973.75, 355.4);
                yield return new UKgas(1974, 449.9);
                yield return new UKgas(1974.25, 286.6);
                yield return new UKgas(1974.5, 179.3);
                yield return new UKgas(1974.75, 403.4);
                yield return new UKgas(1975, 491.5);
                yield return new UKgas(1975.25, 321.8);
                yield return new UKgas(1975.5, 177.7);
                yield return new UKgas(1975.75, 409.8);
                yield return new UKgas(1976, 593.9);
                yield return new UKgas(1976.25, 329.8);
                yield return new UKgas(1976.5, 176.1);
                yield return new UKgas(1976.75, 483.5);
                yield return new UKgas(1977, 584.3);
                yield return new UKgas(1977.25, 395.4);
                yield return new UKgas(1977.5, 187.3);
                yield return new UKgas(1977.75, 485.1);
                yield return new UKgas(1978, 669.2);
                yield return new UKgas(1978.25, 421);
                yield return new UKgas(1978.5, 216.1);
                yield return new UKgas(1978.75, 509.1);
                yield return new UKgas(1979, 827.7);
                yield return new UKgas(1979.25, 467.5);
                yield return new UKgas(1979.5, 209.7);
                yield return new UKgas(1979.75, 542.7);
                yield return new UKgas(1980, 840.5);
                yield return new UKgas(1980.25, 414.6);
                yield return new UKgas(1980.5, 217.7);
                yield return new UKgas(1980.75, 670.8);
                yield return new UKgas(1981, 848.5);
                yield return new UKgas(1981.25, 437);
                yield return new UKgas(1981.5, 209.7);
                yield return new UKgas(1981.75, 701.2);
                yield return new UKgas(1982, 925.3);
                yield return new UKgas(1982.25, 443.4);
                yield return new UKgas(1982.5, 214.5);
                yield return new UKgas(1982.75, 683.6);
                yield return new UKgas(1983, 917.3);
                yield return new UKgas(1983.25, 515.5);
                yield return new UKgas(1983.5, 224.1);
                yield return new UKgas(1983.75, 694.8);
                yield return new UKgas(1984, 989.4);
                yield return new UKgas(1984.25, 477.1);
                yield return new UKgas(1984.5, 233.7);
                yield return new UKgas(1984.75, 730);
                yield return new UKgas(1985, 1087);
                yield return new UKgas(1985.25, 534.7);
                yield return new UKgas(1985.5, 281.8);
                yield return new UKgas(1985.75, 787.6);
                yield return new UKgas(1986, 1163.9);
                yield return new UKgas(1986.25, 613.1);
                yield return new UKgas(1986.5, 347.4);
                yield return new UKgas(1986.75, 782.8);
            }
        }
    }
}
