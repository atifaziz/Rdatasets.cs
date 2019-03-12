// ReSharper disable All

namespace Rdatasets.datasets
{
    using System.Collections.Generic;

    /// <summary>
    /// UK Quarterly Gas Consumption
    /// </summary>

    public class UKgas
    {
        public readonly int κ;
        public readonly double time;
        public readonly double value;

        public UKgas(int κ, double time, double value)
        {
            this.κ = κ;
            this.time = time;
            this.value = value;
        }

        public static IEnumerable<UKgas> Data
        {
            get
            {
                yield return new UKgas(1, 1960, 160.1);
                yield return new UKgas(2, 1960.25, 129.7);
                yield return new UKgas(3, 1960.5, 84.8);
                yield return new UKgas(4, 1960.75, 120.1);
                yield return new UKgas(5, 1961, 160.1);
                yield return new UKgas(6, 1961.25, 124.9);
                yield return new UKgas(7, 1961.5, 84.8);
                yield return new UKgas(8, 1961.75, 116.9);
                yield return new UKgas(9, 1962, 169.7);
                yield return new UKgas(10, 1962.25, 140.9);
                yield return new UKgas(11, 1962.5, 89.7);
                yield return new UKgas(12, 1962.75, 123.3);
                yield return new UKgas(13, 1963, 187.3);
                yield return new UKgas(14, 1963.25, 144.1);
                yield return new UKgas(15, 1963.5, 92.9);
                yield return new UKgas(16, 1963.75, 120.1);
                yield return new UKgas(17, 1964, 176.1);
                yield return new UKgas(18, 1964.25, 147.3);
                yield return new UKgas(19, 1964.5, 89.7);
                yield return new UKgas(20, 1964.75, 123.3);
                yield return new UKgas(21, 1965, 185.7);
                yield return new UKgas(22, 1965.25, 155.3);
                yield return new UKgas(23, 1965.5, 99.3);
                yield return new UKgas(24, 1965.75, 131.3);
                yield return new UKgas(25, 1966, 200.1);
                yield return new UKgas(26, 1966.25, 161.7);
                yield return new UKgas(27, 1966.5, 102.5);
                yield return new UKgas(28, 1966.75, 136.1);
                yield return new UKgas(29, 1967, 204.9);
                yield return new UKgas(30, 1967.25, 176.1);
                yield return new UKgas(31, 1967.5, 112.1);
                yield return new UKgas(32, 1967.75, 140.9);
                yield return new UKgas(33, 1968, 227.3);
                yield return new UKgas(34, 1968.25, 195.3);
                yield return new UKgas(35, 1968.5, 115.3);
                yield return new UKgas(36, 1968.75, 142.5);
                yield return new UKgas(37, 1969, 244.9);
                yield return new UKgas(38, 1969.25, 214.5);
                yield return new UKgas(39, 1969.5, 118.5);
                yield return new UKgas(40, 1969.75, 153.7);
                yield return new UKgas(41, 1970, 244.9);
                yield return new UKgas(42, 1970.25, 216.1);
                yield return new UKgas(43, 1970.5, 188.9);
                yield return new UKgas(44, 1970.75, 142.5);
                yield return new UKgas(45, 1971, 301);
                yield return new UKgas(46, 1971.25, 196.9);
                yield return new UKgas(47, 1971.5, 136.1);
                yield return new UKgas(48, 1971.75, 267.3);
                yield return new UKgas(49, 1972, 317);
                yield return new UKgas(50, 1972.25, 230.5);
                yield return new UKgas(51, 1972.5, 152.1);
                yield return new UKgas(52, 1972.75, 336.2);
                yield return new UKgas(53, 1973, 371.4);
                yield return new UKgas(54, 1973.25, 240.1);
                yield return new UKgas(55, 1973.5, 158.5);
                yield return new UKgas(56, 1973.75, 355.4);
                yield return new UKgas(57, 1974, 449.9);
                yield return new UKgas(58, 1974.25, 286.6);
                yield return new UKgas(59, 1974.5, 179.3);
                yield return new UKgas(60, 1974.75, 403.4);
                yield return new UKgas(61, 1975, 491.5);
                yield return new UKgas(62, 1975.25, 321.8);
                yield return new UKgas(63, 1975.5, 177.7);
                yield return new UKgas(64, 1975.75, 409.8);
                yield return new UKgas(65, 1976, 593.9);
                yield return new UKgas(66, 1976.25, 329.8);
                yield return new UKgas(67, 1976.5, 176.1);
                yield return new UKgas(68, 1976.75, 483.5);
                yield return new UKgas(69, 1977, 584.3);
                yield return new UKgas(70, 1977.25, 395.4);
                yield return new UKgas(71, 1977.5, 187.3);
                yield return new UKgas(72, 1977.75, 485.1);
                yield return new UKgas(73, 1978, 669.2);
                yield return new UKgas(74, 1978.25, 421);
                yield return new UKgas(75, 1978.5, 216.1);
                yield return new UKgas(76, 1978.75, 509.1);
                yield return new UKgas(77, 1979, 827.7);
                yield return new UKgas(78, 1979.25, 467.5);
                yield return new UKgas(79, 1979.5, 209.7);
                yield return new UKgas(80, 1979.75, 542.7);
                yield return new UKgas(81, 1980, 840.5);
                yield return new UKgas(82, 1980.25, 414.6);
                yield return new UKgas(83, 1980.5, 217.7);
                yield return new UKgas(84, 1980.75, 670.8);
                yield return new UKgas(85, 1981, 848.5);
                yield return new UKgas(86, 1981.25, 437);
                yield return new UKgas(87, 1981.5, 209.7);
                yield return new UKgas(88, 1981.75, 701.2);
                yield return new UKgas(89, 1982, 925.3);
                yield return new UKgas(90, 1982.25, 443.4);
                yield return new UKgas(91, 1982.5, 214.5);
                yield return new UKgas(92, 1982.75, 683.6);
                yield return new UKgas(93, 1983, 917.3);
                yield return new UKgas(94, 1983.25, 515.5);
                yield return new UKgas(95, 1983.5, 224.1);
                yield return new UKgas(96, 1983.75, 694.8);
                yield return new UKgas(97, 1984, 989.4);
                yield return new UKgas(98, 1984.25, 477.1);
                yield return new UKgas(99, 1984.5, 233.7);
                yield return new UKgas(100, 1984.75, 730);
                yield return new UKgas(101, 1985, 1087);
                yield return new UKgas(102, 1985.25, 534.7);
                yield return new UKgas(103, 1985.5, 281.8);
                yield return new UKgas(104, 1985.75, 787.6);
                yield return new UKgas(105, 1986, 1163.9);
                yield return new UKgas(106, 1986.25, 613.1);
                yield return new UKgas(107, 1986.5, 347.4);
                yield return new UKgas(108, 1986.75, 782.8);
            }
        }
    }
}
