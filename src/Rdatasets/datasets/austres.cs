// ReSharper disable All

namespace Rdatasets.datasets
{
    using System.Collections.Generic;

    /// <summary>
    /// Quarterly Time Series of the Number of Australian Residents
    /// </summary>

    public class austres
    {
        public readonly int κ;
        public readonly double time;
        public readonly double value;

        public austres(int κ, double time, double value)
        {
            this.κ = κ;
            this.time = time;
            this.value = value;
        }

        public static IEnumerable<austres> Data
        {
            get
            {
                yield return new austres(1, 1971.25, 13067.3);
                yield return new austres(2, 1971.5, 13130.5);
                yield return new austres(3, 1971.75, 13198.4);
                yield return new austres(4, 1972, 13254.2);
                yield return new austres(5, 1972.25, 13303.7);
                yield return new austres(6, 1972.5, 13353.9);
                yield return new austres(7, 1972.75, 13409.3);
                yield return new austres(8, 1973, 13459.2);
                yield return new austres(9, 1973.25, 13504.5);
                yield return new austres(10, 1973.5, 13552.6);
                yield return new austres(11, 1973.75, 13614.3);
                yield return new austres(12, 1974, 13669.5);
                yield return new austres(13, 1974.25, 13722.6);
                yield return new austres(14, 1974.5, 13772.1);
                yield return new austres(15, 1974.75, 13832);
                yield return new austres(16, 1975, 13862.6);
                yield return new austres(17, 1975.25, 13893);
                yield return new austres(18, 1975.5, 13926.8);
                yield return new austres(19, 1975.75, 13968.9);
                yield return new austres(20, 1976, 14004.7);
                yield return new austres(21, 1976.25, 14033.1);
                yield return new austres(22, 1976.5, 14066);
                yield return new austres(23, 1976.75, 14110.1);
                yield return new austres(24, 1977, 14155.6);
                yield return new austres(25, 1977.25, 14192.2);
                yield return new austres(26, 1977.5, 14231.7);
                yield return new austres(27, 1977.75, 14281.5);
                yield return new austres(28, 1978, 14330.3);
                yield return new austres(29, 1978.25, 14359.3);
                yield return new austres(30, 1978.5, 14396.6);
                yield return new austres(31, 1978.75, 14430.8);
                yield return new austres(32, 1979, 14478.4);
                yield return new austres(33, 1979.25, 14515.7);
                yield return new austres(34, 1979.5, 14554.9);
                yield return new austres(35, 1979.75, 14602.5);
                yield return new austres(36, 1980, 14646.4);
                yield return new austres(37, 1980.25, 14695.4);
                yield return new austres(38, 1980.5, 14746.6);
                yield return new austres(39, 1980.75, 14807.4);
                yield return new austres(40, 1981, 14874.4);
                yield return new austres(41, 1981.25, 14923.3);
                yield return new austres(42, 1981.5, 14988.7);
                yield return new austres(43, 1981.75, 15054.1);
                yield return new austres(44, 1982, 15121.7);
                yield return new austres(45, 1982.25, 15184.2);
                yield return new austres(46, 1982.5, 15239.3);
                yield return new austres(47, 1982.75, 15288.9);
                yield return new austres(48, 1983, 15346.2);
                yield return new austres(49, 1983.25, 15393.5);
                yield return new austres(50, 1983.5, 15439);
                yield return new austres(51, 1983.75, 15483.5);
                yield return new austres(52, 1984, 15531.5);
                yield return new austres(53, 1984.25, 15579.4);
                yield return new austres(54, 1984.5, 15628.5);
                yield return new austres(55, 1984.75, 15677.3);
                yield return new austres(56, 1985, 15736.7);
                yield return new austres(57, 1985.25, 15788.3);
                yield return new austres(58, 1985.5, 15839.7);
                yield return new austres(59, 1985.75, 15900.6);
                yield return new austres(60, 1986, 15961.5);
                yield return new austres(61, 1986.25, 16018.3);
                yield return new austres(62, 1986.5, 16076.9);
                yield return new austres(63, 1986.75, 16139);
                yield return new austres(64, 1987, 16203);
                yield return new austres(65, 1987.25, 16263.3);
                yield return new austres(66, 1987.5, 16327.9);
                yield return new austres(67, 1987.75, 16398.9);
                yield return new austres(68, 1988, 16478.3);
                yield return new austres(69, 1988.25, 16538.2);
                yield return new austres(70, 1988.5, 16621.6);
                yield return new austres(71, 1988.75, 16697);
                yield return new austres(72, 1989, 16777.2);
                yield return new austres(73, 1989.25, 16833.1);
                yield return new austres(74, 1989.5, 16891.6);
                yield return new austres(75, 1989.75, 16956.8);
                yield return new austres(76, 1990, 17026.3);
                yield return new austres(77, 1990.25, 17085.4);
                yield return new austres(78, 1990.5, 17106.9);
                yield return new austres(79, 1990.75, 17169.4);
                yield return new austres(80, 1991, 17239.4);
                yield return new austres(81, 1991.25, 17292);
                yield return new austres(82, 1991.5, 17354.2);
                yield return new austres(83, 1991.75, 17414.2);
                yield return new austres(84, 1992, 17447.3);
                yield return new austres(85, 1992.25, 17482.6);
                yield return new austres(86, 1992.5, 17526);
                yield return new austres(87, 1992.75, 17568.7);
                yield return new austres(88, 1993, 17627.1);
                yield return new austres(89, 1993.25, 17661.5);
            }
        }
    }
}
