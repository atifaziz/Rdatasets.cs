// ReSharper disable All

namespace Rdatasets.MASS
{
    using System.Collections.Generic;

    /// <summary>
    /// Monthly Deaths from Lung Diseases in the UK
    /// </summary>

    public class deaths
    {
        public readonly int κ;
        public readonly double time;
        public readonly int value;

        public deaths(int κ, double time, int value)
        {
            this.κ = κ;
            this.time = time;
            this.value = value;
        }

        public static IEnumerable<deaths> Data
        {
            get
            {
                yield return new deaths(1, 1974, 3035);
                yield return new deaths(2, 1974.08333333333, 2552);
                yield return new deaths(3, 1974.16666666667, 2704);
                yield return new deaths(4, 1974.25, 2554);
                yield return new deaths(5, 1974.33333333333, 2014);
                yield return new deaths(6, 1974.41666666667, 1655);
                yield return new deaths(7, 1974.5, 1721);
                yield return new deaths(8, 1974.58333333333, 1524);
                yield return new deaths(9, 1974.66666666667, 1596);
                yield return new deaths(10, 1974.75, 2074);
                yield return new deaths(11, 1974.83333333333, 2199);
                yield return new deaths(12, 1974.91666666667, 2512);
                yield return new deaths(13, 1975, 2933);
                yield return new deaths(14, 1975.08333333333, 2889);
                yield return new deaths(15, 1975.16666666667, 2938);
                yield return new deaths(16, 1975.25, 2497);
                yield return new deaths(17, 1975.33333333333, 1870);
                yield return new deaths(18, 1975.41666666667, 1726);
                yield return new deaths(19, 1975.5, 1607);
                yield return new deaths(20, 1975.58333333333, 1545);
                yield return new deaths(21, 1975.66666666667, 1396);
                yield return new deaths(22, 1975.75, 1787);
                yield return new deaths(23, 1975.83333333333, 2076);
                yield return new deaths(24, 1975.91666666667, 2837);
                yield return new deaths(25, 1976, 2787);
                yield return new deaths(26, 1976.08333333333, 3891);
                yield return new deaths(27, 1976.16666666667, 3179);
                yield return new deaths(28, 1976.25, 2011);
                yield return new deaths(29, 1976.33333333333, 1636);
                yield return new deaths(30, 1976.41666666667, 1580);
                yield return new deaths(31, 1976.5, 1489);
                yield return new deaths(32, 1976.58333333333, 1300);
                yield return new deaths(33, 1976.66666666667, 1356);
                yield return new deaths(34, 1976.75, 1653);
                yield return new deaths(35, 1976.83333333333, 2013);
                yield return new deaths(36, 1976.91666666667, 2823);
                yield return new deaths(37, 1977, 3102);
                yield return new deaths(38, 1977.08333333333, 2294);
                yield return new deaths(39, 1977.16666666667, 2385);
                yield return new deaths(40, 1977.25, 2444);
                yield return new deaths(41, 1977.33333333333, 1748);
                yield return new deaths(42, 1977.41666666667, 1554);
                yield return new deaths(43, 1977.5, 1498);
                yield return new deaths(44, 1977.58333333333, 1361);
                yield return new deaths(45, 1977.66666666667, 1346);
                yield return new deaths(46, 1977.75, 1564);
                yield return new deaths(47, 1977.83333333333, 1640);
                yield return new deaths(48, 1977.91666666667, 2293);
                yield return new deaths(49, 1978, 2815);
                yield return new deaths(50, 1978.08333333333, 3137);
                yield return new deaths(51, 1978.16666666667, 2679);
                yield return new deaths(52, 1978.25, 1969);
                yield return new deaths(53, 1978.33333333333, 1870);
                yield return new deaths(54, 1978.41666666667, 1633);
                yield return new deaths(55, 1978.5, 1529);
                yield return new deaths(56, 1978.58333333333, 1366);
                yield return new deaths(57, 1978.66666666667, 1357);
                yield return new deaths(58, 1978.75, 1570);
                yield return new deaths(59, 1978.83333333333, 1535);
                yield return new deaths(60, 1978.91666666667, 2491);
                yield return new deaths(61, 1979, 3084);
                yield return new deaths(62, 1979.08333333333, 2605);
                yield return new deaths(63, 1979.16666666667, 2573);
                yield return new deaths(64, 1979.25, 2143);
                yield return new deaths(65, 1979.33333333333, 1693);
                yield return new deaths(66, 1979.41666666667, 1504);
                yield return new deaths(67, 1979.5, 1461);
                yield return new deaths(68, 1979.58333333333, 1354);
                yield return new deaths(69, 1979.66666666667, 1333);
                yield return new deaths(70, 1979.75, 1492);
                yield return new deaths(71, 1979.83333333333, 1781);
                yield return new deaths(72, 1979.91666666667, 1915);
            }
        }
    }
}
