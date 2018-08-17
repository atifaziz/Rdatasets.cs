// ReSharper disable All

namespace Rdatasets.datasets
{
    using System.Collections.Generic;

    /// <summary>
    /// Quarterly Time Series of the Number of Australian Residents
    /// </summary>

    public class austres
    {
        public readonly double time;
        public readonly double value;

        public austres(double time, double value)
        {
            this.time = time;
            this.value = value;
        }

        public static IEnumerable<austres> Data
        {
            get
            {
                yield return new austres(1971.25, 13067.3);
                yield return new austres(1971.5, 13130.5);
                yield return new austres(1971.75, 13198.4);
                yield return new austres(1972, 13254.2);
                yield return new austres(1972.25, 13303.7);
                yield return new austres(1972.5, 13353.9);
                yield return new austres(1972.75, 13409.3);
                yield return new austres(1973, 13459.2);
                yield return new austres(1973.25, 13504.5);
                yield return new austres(1973.5, 13552.6);
                yield return new austres(1973.75, 13614.3);
                yield return new austres(1974, 13669.5);
                yield return new austres(1974.25, 13722.6);
                yield return new austres(1974.5, 13772.1);
                yield return new austres(1974.75, 13832);
                yield return new austres(1975, 13862.6);
                yield return new austres(1975.25, 13893);
                yield return new austres(1975.5, 13926.8);
                yield return new austres(1975.75, 13968.9);
                yield return new austres(1976, 14004.7);
                yield return new austres(1976.25, 14033.1);
                yield return new austres(1976.5, 14066);
                yield return new austres(1976.75, 14110.1);
                yield return new austres(1977, 14155.6);
                yield return new austres(1977.25, 14192.2);
                yield return new austres(1977.5, 14231.7);
                yield return new austres(1977.75, 14281.5);
                yield return new austres(1978, 14330.3);
                yield return new austres(1978.25, 14359.3);
                yield return new austres(1978.5, 14396.6);
                yield return new austres(1978.75, 14430.8);
                yield return new austres(1979, 14478.4);
                yield return new austres(1979.25, 14515.7);
                yield return new austres(1979.5, 14554.9);
                yield return new austres(1979.75, 14602.5);
                yield return new austres(1980, 14646.4);
                yield return new austres(1980.25, 14695.4);
                yield return new austres(1980.5, 14746.6);
                yield return new austres(1980.75, 14807.4);
                yield return new austres(1981, 14874.4);
                yield return new austres(1981.25, 14923.3);
                yield return new austres(1981.5, 14988.7);
                yield return new austres(1981.75, 15054.1);
                yield return new austres(1982, 15121.7);
                yield return new austres(1982.25, 15184.2);
                yield return new austres(1982.5, 15239.3);
                yield return new austres(1982.75, 15288.9);
                yield return new austres(1983, 15346.2);
                yield return new austres(1983.25, 15393.5);
                yield return new austres(1983.5, 15439);
                yield return new austres(1983.75, 15483.5);
                yield return new austres(1984, 15531.5);
                yield return new austres(1984.25, 15579.4);
                yield return new austres(1984.5, 15628.5);
                yield return new austres(1984.75, 15677.3);
                yield return new austres(1985, 15736.7);
                yield return new austres(1985.25, 15788.3);
                yield return new austres(1985.5, 15839.7);
                yield return new austres(1985.75, 15900.6);
                yield return new austres(1986, 15961.5);
                yield return new austres(1986.25, 16018.3);
                yield return new austres(1986.5, 16076.9);
                yield return new austres(1986.75, 16139);
                yield return new austres(1987, 16203);
                yield return new austres(1987.25, 16263.3);
                yield return new austres(1987.5, 16327.9);
                yield return new austres(1987.75, 16398.9);
                yield return new austres(1988, 16478.3);
                yield return new austres(1988.25, 16538.2);
                yield return new austres(1988.5, 16621.6);
                yield return new austres(1988.75, 16697);
                yield return new austres(1989, 16777.2);
                yield return new austres(1989.25, 16833.1);
                yield return new austres(1989.5, 16891.6);
                yield return new austres(1989.75, 16956.8);
                yield return new austres(1990, 17026.3);
                yield return new austres(1990.25, 17085.4);
                yield return new austres(1990.5, 17106.9);
                yield return new austres(1990.75, 17169.4);
                yield return new austres(1991, 17239.4);
                yield return new austres(1991.25, 17292);
                yield return new austres(1991.5, 17354.2);
                yield return new austres(1991.75, 17414.2);
                yield return new austres(1992, 17447.3);
                yield return new austres(1992.25, 17482.6);
                yield return new austres(1992.5, 17526);
                yield return new austres(1992.75, 17568.7);
                yield return new austres(1993, 17627.1);
                yield return new austres(1993.25, 17661.5);
            }
        }
    }
}
