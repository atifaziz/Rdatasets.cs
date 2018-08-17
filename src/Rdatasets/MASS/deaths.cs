// ReSharper disable All

namespace Rdatasets.MASS
{
    using System.Collections.Generic;

    /// <summary>
    /// Monthly Deaths from Lung Diseases in the UK
    /// </summary>

    public class deaths
    {
        public readonly double time;
        public readonly int value;

        public deaths(double time, int value)
        {
            this.time = time;
            this.value = value;
        }

        public static IEnumerable<deaths> Data
        {
            get
            {
                yield return new deaths(1974, 3035);
                yield return new deaths(1974.08333333333, 2552);
                yield return new deaths(1974.16666666667, 2704);
                yield return new deaths(1974.25, 2554);
                yield return new deaths(1974.33333333333, 2014);
                yield return new deaths(1974.41666666667, 1655);
                yield return new deaths(1974.5, 1721);
                yield return new deaths(1974.58333333333, 1524);
                yield return new deaths(1974.66666666667, 1596);
                yield return new deaths(1974.75, 2074);
                yield return new deaths(1974.83333333333, 2199);
                yield return new deaths(1974.91666666667, 2512);
                yield return new deaths(1975, 2933);
                yield return new deaths(1975.08333333333, 2889);
                yield return new deaths(1975.16666666667, 2938);
                yield return new deaths(1975.25, 2497);
                yield return new deaths(1975.33333333333, 1870);
                yield return new deaths(1975.41666666667, 1726);
                yield return new deaths(1975.5, 1607);
                yield return new deaths(1975.58333333333, 1545);
                yield return new deaths(1975.66666666667, 1396);
                yield return new deaths(1975.75, 1787);
                yield return new deaths(1975.83333333333, 2076);
                yield return new deaths(1975.91666666667, 2837);
                yield return new deaths(1976, 2787);
                yield return new deaths(1976.08333333333, 3891);
                yield return new deaths(1976.16666666667, 3179);
                yield return new deaths(1976.25, 2011);
                yield return new deaths(1976.33333333333, 1636);
                yield return new deaths(1976.41666666667, 1580);
                yield return new deaths(1976.5, 1489);
                yield return new deaths(1976.58333333333, 1300);
                yield return new deaths(1976.66666666667, 1356);
                yield return new deaths(1976.75, 1653);
                yield return new deaths(1976.83333333333, 2013);
                yield return new deaths(1976.91666666667, 2823);
                yield return new deaths(1977, 3102);
                yield return new deaths(1977.08333333333, 2294);
                yield return new deaths(1977.16666666667, 2385);
                yield return new deaths(1977.25, 2444);
                yield return new deaths(1977.33333333333, 1748);
                yield return new deaths(1977.41666666667, 1554);
                yield return new deaths(1977.5, 1498);
                yield return new deaths(1977.58333333333, 1361);
                yield return new deaths(1977.66666666667, 1346);
                yield return new deaths(1977.75, 1564);
                yield return new deaths(1977.83333333333, 1640);
                yield return new deaths(1977.91666666667, 2293);
                yield return new deaths(1978, 2815);
                yield return new deaths(1978.08333333333, 3137);
                yield return new deaths(1978.16666666667, 2679);
                yield return new deaths(1978.25, 1969);
                yield return new deaths(1978.33333333333, 1870);
                yield return new deaths(1978.41666666667, 1633);
                yield return new deaths(1978.5, 1529);
                yield return new deaths(1978.58333333333, 1366);
                yield return new deaths(1978.66666666667, 1357);
                yield return new deaths(1978.75, 1570);
                yield return new deaths(1978.83333333333, 1535);
                yield return new deaths(1978.91666666667, 2491);
                yield return new deaths(1979, 3084);
                yield return new deaths(1979.08333333333, 2605);
                yield return new deaths(1979.16666666667, 2573);
                yield return new deaths(1979.25, 2143);
                yield return new deaths(1979.33333333333, 1693);
                yield return new deaths(1979.41666666667, 1504);
                yield return new deaths(1979.5, 1461);
                yield return new deaths(1979.58333333333, 1354);
                yield return new deaths(1979.66666666667, 1333);
                yield return new deaths(1979.75, 1492);
                yield return new deaths(1979.83333333333, 1781);
                yield return new deaths(1979.91666666667, 1915);
            }
        }
    }
}
