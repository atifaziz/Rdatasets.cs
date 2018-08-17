// ReSharper disable All

namespace Rdatasets.MASS
{
    using System.Collections.Generic;

    /// <summary>
    /// Deaths of Car Drivers in Great Britain 1969-84
    /// </summary>

    public class drivers
    {
        public readonly double time;
        public readonly int value;

        public drivers(double time, int value)
        {
            this.time = time;
            this.value = value;
        }

        public static IEnumerable<drivers> Data
        {
            get
            {
                yield return new drivers(1969, 1687);
                yield return new drivers(1969.08333333333, 1508);
                yield return new drivers(1969.16666666667, 1507);
                yield return new drivers(1969.25, 1385);
                yield return new drivers(1969.33333333333, 1632);
                yield return new drivers(1969.41666666667, 1511);
                yield return new drivers(1969.5, 1559);
                yield return new drivers(1969.58333333333, 1630);
                yield return new drivers(1969.66666666667, 1579);
                yield return new drivers(1969.75, 1653);
                yield return new drivers(1969.83333333333, 2152);
                yield return new drivers(1969.91666666667, 2148);
                yield return new drivers(1970, 1752);
                yield return new drivers(1970.08333333333, 1765);
                yield return new drivers(1970.16666666667, 1717);
                yield return new drivers(1970.25, 1558);
                yield return new drivers(1970.33333333333, 1575);
                yield return new drivers(1970.41666666667, 1520);
                yield return new drivers(1970.5, 1805);
                yield return new drivers(1970.58333333333, 1800);
                yield return new drivers(1970.66666666667, 1719);
                yield return new drivers(1970.75, 2008);
                yield return new drivers(1970.83333333333, 2242);
                yield return new drivers(1970.91666666667, 2478);
                yield return new drivers(1971, 2030);
                yield return new drivers(1971.08333333333, 1655);
                yield return new drivers(1971.16666666667, 1693);
                yield return new drivers(1971.25, 1623);
                yield return new drivers(1971.33333333333, 1805);
                yield return new drivers(1971.41666666667, 1746);
                yield return new drivers(1971.5, 1795);
                yield return new drivers(1971.58333333333, 1926);
                yield return new drivers(1971.66666666667, 1619);
                yield return new drivers(1971.75, 1992);
                yield return new drivers(1971.83333333333, 2233);
                yield return new drivers(1971.91666666667, 2192);
                yield return new drivers(1972, 2080);
                yield return new drivers(1972.08333333333, 1768);
                yield return new drivers(1972.16666666667, 1835);
                yield return new drivers(1972.25, 1569);
                yield return new drivers(1972.33333333333, 1976);
                yield return new drivers(1972.41666666667, 1853);
                yield return new drivers(1972.5, 1965);
                yield return new drivers(1972.58333333333, 1689);
                yield return new drivers(1972.66666666667, 1778);
                yield return new drivers(1972.75, 1976);
                yield return new drivers(1972.83333333333, 2397);
                yield return new drivers(1972.91666666667, 2654);
                yield return new drivers(1973, 2097);
                yield return new drivers(1973.08333333333, 1963);
                yield return new drivers(1973.16666666667, 1677);
                yield return new drivers(1973.25, 1941);
                yield return new drivers(1973.33333333333, 2003);
                yield return new drivers(1973.41666666667, 1813);
                yield return new drivers(1973.5, 2012);
                yield return new drivers(1973.58333333333, 1912);
                yield return new drivers(1973.66666666667, 2084);
                yield return new drivers(1973.75, 2080);
                yield return new drivers(1973.83333333333, 2118);
                yield return new drivers(1973.91666666667, 2150);
                yield return new drivers(1974, 1608);
                yield return new drivers(1974.08333333333, 1503);
                yield return new drivers(1974.16666666667, 1548);
                yield return new drivers(1974.25, 1382);
                yield return new drivers(1974.33333333333, 1731);
                yield return new drivers(1974.41666666667, 1798);
                yield return new drivers(1974.5, 1779);
                yield return new drivers(1974.58333333333, 1887);
                yield return new drivers(1974.66666666667, 2004);
                yield return new drivers(1974.75, 2077);
                yield return new drivers(1974.83333333333, 2092);
                yield return new drivers(1974.91666666667, 2051);
                yield return new drivers(1975, 1577);
                yield return new drivers(1975.08333333333, 1356);
                yield return new drivers(1975.16666666667, 1652);
                yield return new drivers(1975.25, 1382);
                yield return new drivers(1975.33333333333, 1519);
                yield return new drivers(1975.41666666667, 1421);
                yield return new drivers(1975.5, 1442);
                yield return new drivers(1975.58333333333, 1543);
                yield return new drivers(1975.66666666667, 1656);
                yield return new drivers(1975.75, 1561);
                yield return new drivers(1975.83333333333, 1905);
                yield return new drivers(1975.91666666667, 2199);
                yield return new drivers(1976, 1473);
                yield return new drivers(1976.08333333333, 1655);
                yield return new drivers(1976.16666666667, 1407);
                yield return new drivers(1976.25, 1395);
                yield return new drivers(1976.33333333333, 1530);
                yield return new drivers(1976.41666666667, 1309);
                yield return new drivers(1976.5, 1526);
                yield return new drivers(1976.58333333333, 1327);
                yield return new drivers(1976.66666666667, 1627);
                yield return new drivers(1976.75, 1748);
                yield return new drivers(1976.83333333333, 1958);
                yield return new drivers(1976.91666666667, 2274);
                yield return new drivers(1977, 1648);
                yield return new drivers(1977.08333333333, 1401);
                yield return new drivers(1977.16666666667, 1411);
                yield return new drivers(1977.25, 1403);
                yield return new drivers(1977.33333333333, 1394);
                yield return new drivers(1977.41666666667, 1520);
                yield return new drivers(1977.5, 1528);
                yield return new drivers(1977.58333333333, 1643);
                yield return new drivers(1977.66666666667, 1515);
                yield return new drivers(1977.75, 1685);
                yield return new drivers(1977.83333333333, 2000);
                yield return new drivers(1977.91666666667, 2215);
                yield return new drivers(1978, 1956);
                yield return new drivers(1978.08333333333, 1462);
                yield return new drivers(1978.16666666667, 1563);
                yield return new drivers(1978.25, 1459);
                yield return new drivers(1978.33333333333, 1446);
                yield return new drivers(1978.41666666667, 1622);
                yield return new drivers(1978.5, 1657);
                yield return new drivers(1978.58333333333, 1638);
                yield return new drivers(1978.66666666667, 1643);
                yield return new drivers(1978.75, 1683);
                yield return new drivers(1978.83333333333, 2050);
                yield return new drivers(1978.91666666667, 2262);
                yield return new drivers(1979, 1813);
                yield return new drivers(1979.08333333333, 1445);
                yield return new drivers(1979.16666666667, 1762);
                yield return new drivers(1979.25, 1461);
                yield return new drivers(1979.33333333333, 1556);
                yield return new drivers(1979.41666666667, 1431);
                yield return new drivers(1979.5, 1427);
                yield return new drivers(1979.58333333333, 1554);
                yield return new drivers(1979.66666666667, 1645);
                yield return new drivers(1979.75, 1653);
                yield return new drivers(1979.83333333333, 2016);
                yield return new drivers(1979.91666666667, 2207);
                yield return new drivers(1980, 1665);
                yield return new drivers(1980.08333333333, 1361);
                yield return new drivers(1980.16666666667, 1506);
                yield return new drivers(1980.25, 1360);
                yield return new drivers(1980.33333333333, 1453);
                yield return new drivers(1980.41666666667, 1522);
                yield return new drivers(1980.5, 1460);
                yield return new drivers(1980.58333333333, 1552);
                yield return new drivers(1980.66666666667, 1548);
                yield return new drivers(1980.75, 1827);
                yield return new drivers(1980.83333333333, 1737);
                yield return new drivers(1980.91666666667, 1941);
                yield return new drivers(1981, 1474);
                yield return new drivers(1981.08333333333, 1458);
                yield return new drivers(1981.16666666667, 1542);
                yield return new drivers(1981.25, 1404);
                yield return new drivers(1981.33333333333, 1522);
                yield return new drivers(1981.41666666667, 1385);
                yield return new drivers(1981.5, 1641);
                yield return new drivers(1981.58333333333, 1510);
                yield return new drivers(1981.66666666667, 1681);
                yield return new drivers(1981.75, 1938);
                yield return new drivers(1981.83333333333, 1868);
                yield return new drivers(1981.91666666667, 1726);
                yield return new drivers(1982, 1456);
                yield return new drivers(1982.08333333333, 1445);
                yield return new drivers(1982.16666666667, 1456);
                yield return new drivers(1982.25, 1365);
                yield return new drivers(1982.33333333333, 1487);
                yield return new drivers(1982.41666666667, 1558);
                yield return new drivers(1982.5, 1488);
                yield return new drivers(1982.58333333333, 1684);
                yield return new drivers(1982.66666666667, 1594);
                yield return new drivers(1982.75, 1850);
                yield return new drivers(1982.83333333333, 1998);
                yield return new drivers(1982.91666666667, 2079);
                yield return new drivers(1983, 1494);
                yield return new drivers(1983.08333333333, 1057);
                yield return new drivers(1983.16666666667, 1218);
                yield return new drivers(1983.25, 1168);
                yield return new drivers(1983.33333333333, 1236);
                yield return new drivers(1983.41666666667, 1076);
                yield return new drivers(1983.5, 1174);
                yield return new drivers(1983.58333333333, 1139);
                yield return new drivers(1983.66666666667, 1427);
                yield return new drivers(1983.75, 1487);
                yield return new drivers(1983.83333333333, 1483);
                yield return new drivers(1983.91666666667, 1513);
                yield return new drivers(1984, 1357);
                yield return new drivers(1984.08333333333, 1165);
                yield return new drivers(1984.16666666667, 1282);
                yield return new drivers(1984.25, 1110);
                yield return new drivers(1984.33333333333, 1297);
                yield return new drivers(1984.41666666667, 1185);
                yield return new drivers(1984.5, 1222);
                yield return new drivers(1984.58333333333, 1284);
                yield return new drivers(1984.66666666667, 1444);
                yield return new drivers(1984.75, 1575);
                yield return new drivers(1984.83333333333, 1737);
                yield return new drivers(1984.91666666667, 1763);
            }
        }
    }
}
