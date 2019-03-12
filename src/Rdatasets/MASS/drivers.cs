// ReSharper disable All

namespace Rdatasets.MASS
{
    using System.Collections.Generic;

    /// <summary>
    /// Deaths of Car Drivers in Great Britain 1969-84
    /// </summary>

    public class drivers
    {
        public readonly int κ;
        public readonly double time;
        public readonly int value;

        public drivers(int κ, double time, int value)
        {
            this.κ = κ;
            this.time = time;
            this.value = value;
        }

        public static IEnumerable<drivers> Data
        {
            get
            {
                yield return new drivers(1, 1969, 1687);
                yield return new drivers(2, 1969.08333333333, 1508);
                yield return new drivers(3, 1969.16666666667, 1507);
                yield return new drivers(4, 1969.25, 1385);
                yield return new drivers(5, 1969.33333333333, 1632);
                yield return new drivers(6, 1969.41666666667, 1511);
                yield return new drivers(7, 1969.5, 1559);
                yield return new drivers(8, 1969.58333333333, 1630);
                yield return new drivers(9, 1969.66666666667, 1579);
                yield return new drivers(10, 1969.75, 1653);
                yield return new drivers(11, 1969.83333333333, 2152);
                yield return new drivers(12, 1969.91666666667, 2148);
                yield return new drivers(13, 1970, 1752);
                yield return new drivers(14, 1970.08333333333, 1765);
                yield return new drivers(15, 1970.16666666667, 1717);
                yield return new drivers(16, 1970.25, 1558);
                yield return new drivers(17, 1970.33333333333, 1575);
                yield return new drivers(18, 1970.41666666667, 1520);
                yield return new drivers(19, 1970.5, 1805);
                yield return new drivers(20, 1970.58333333333, 1800);
                yield return new drivers(21, 1970.66666666667, 1719);
                yield return new drivers(22, 1970.75, 2008);
                yield return new drivers(23, 1970.83333333333, 2242);
                yield return new drivers(24, 1970.91666666667, 2478);
                yield return new drivers(25, 1971, 2030);
                yield return new drivers(26, 1971.08333333333, 1655);
                yield return new drivers(27, 1971.16666666667, 1693);
                yield return new drivers(28, 1971.25, 1623);
                yield return new drivers(29, 1971.33333333333, 1805);
                yield return new drivers(30, 1971.41666666667, 1746);
                yield return new drivers(31, 1971.5, 1795);
                yield return new drivers(32, 1971.58333333333, 1926);
                yield return new drivers(33, 1971.66666666667, 1619);
                yield return new drivers(34, 1971.75, 1992);
                yield return new drivers(35, 1971.83333333333, 2233);
                yield return new drivers(36, 1971.91666666667, 2192);
                yield return new drivers(37, 1972, 2080);
                yield return new drivers(38, 1972.08333333333, 1768);
                yield return new drivers(39, 1972.16666666667, 1835);
                yield return new drivers(40, 1972.25, 1569);
                yield return new drivers(41, 1972.33333333333, 1976);
                yield return new drivers(42, 1972.41666666667, 1853);
                yield return new drivers(43, 1972.5, 1965);
                yield return new drivers(44, 1972.58333333333, 1689);
                yield return new drivers(45, 1972.66666666667, 1778);
                yield return new drivers(46, 1972.75, 1976);
                yield return new drivers(47, 1972.83333333333, 2397);
                yield return new drivers(48, 1972.91666666667, 2654);
                yield return new drivers(49, 1973, 2097);
                yield return new drivers(50, 1973.08333333333, 1963);
                yield return new drivers(51, 1973.16666666667, 1677);
                yield return new drivers(52, 1973.25, 1941);
                yield return new drivers(53, 1973.33333333333, 2003);
                yield return new drivers(54, 1973.41666666667, 1813);
                yield return new drivers(55, 1973.5, 2012);
                yield return new drivers(56, 1973.58333333333, 1912);
                yield return new drivers(57, 1973.66666666667, 2084);
                yield return new drivers(58, 1973.75, 2080);
                yield return new drivers(59, 1973.83333333333, 2118);
                yield return new drivers(60, 1973.91666666667, 2150);
                yield return new drivers(61, 1974, 1608);
                yield return new drivers(62, 1974.08333333333, 1503);
                yield return new drivers(63, 1974.16666666667, 1548);
                yield return new drivers(64, 1974.25, 1382);
                yield return new drivers(65, 1974.33333333333, 1731);
                yield return new drivers(66, 1974.41666666667, 1798);
                yield return new drivers(67, 1974.5, 1779);
                yield return new drivers(68, 1974.58333333333, 1887);
                yield return new drivers(69, 1974.66666666667, 2004);
                yield return new drivers(70, 1974.75, 2077);
                yield return new drivers(71, 1974.83333333333, 2092);
                yield return new drivers(72, 1974.91666666667, 2051);
                yield return new drivers(73, 1975, 1577);
                yield return new drivers(74, 1975.08333333333, 1356);
                yield return new drivers(75, 1975.16666666667, 1652);
                yield return new drivers(76, 1975.25, 1382);
                yield return new drivers(77, 1975.33333333333, 1519);
                yield return new drivers(78, 1975.41666666667, 1421);
                yield return new drivers(79, 1975.5, 1442);
                yield return new drivers(80, 1975.58333333333, 1543);
                yield return new drivers(81, 1975.66666666667, 1656);
                yield return new drivers(82, 1975.75, 1561);
                yield return new drivers(83, 1975.83333333333, 1905);
                yield return new drivers(84, 1975.91666666667, 2199);
                yield return new drivers(85, 1976, 1473);
                yield return new drivers(86, 1976.08333333333, 1655);
                yield return new drivers(87, 1976.16666666667, 1407);
                yield return new drivers(88, 1976.25, 1395);
                yield return new drivers(89, 1976.33333333333, 1530);
                yield return new drivers(90, 1976.41666666667, 1309);
                yield return new drivers(91, 1976.5, 1526);
                yield return new drivers(92, 1976.58333333333, 1327);
                yield return new drivers(93, 1976.66666666667, 1627);
                yield return new drivers(94, 1976.75, 1748);
                yield return new drivers(95, 1976.83333333333, 1958);
                yield return new drivers(96, 1976.91666666667, 2274);
                yield return new drivers(97, 1977, 1648);
                yield return new drivers(98, 1977.08333333333, 1401);
                yield return new drivers(99, 1977.16666666667, 1411);
                yield return new drivers(100, 1977.25, 1403);
                yield return new drivers(101, 1977.33333333333, 1394);
                yield return new drivers(102, 1977.41666666667, 1520);
                yield return new drivers(103, 1977.5, 1528);
                yield return new drivers(104, 1977.58333333333, 1643);
                yield return new drivers(105, 1977.66666666667, 1515);
                yield return new drivers(106, 1977.75, 1685);
                yield return new drivers(107, 1977.83333333333, 2000);
                yield return new drivers(108, 1977.91666666667, 2215);
                yield return new drivers(109, 1978, 1956);
                yield return new drivers(110, 1978.08333333333, 1462);
                yield return new drivers(111, 1978.16666666667, 1563);
                yield return new drivers(112, 1978.25, 1459);
                yield return new drivers(113, 1978.33333333333, 1446);
                yield return new drivers(114, 1978.41666666667, 1622);
                yield return new drivers(115, 1978.5, 1657);
                yield return new drivers(116, 1978.58333333333, 1638);
                yield return new drivers(117, 1978.66666666667, 1643);
                yield return new drivers(118, 1978.75, 1683);
                yield return new drivers(119, 1978.83333333333, 2050);
                yield return new drivers(120, 1978.91666666667, 2262);
                yield return new drivers(121, 1979, 1813);
                yield return new drivers(122, 1979.08333333333, 1445);
                yield return new drivers(123, 1979.16666666667, 1762);
                yield return new drivers(124, 1979.25, 1461);
                yield return new drivers(125, 1979.33333333333, 1556);
                yield return new drivers(126, 1979.41666666667, 1431);
                yield return new drivers(127, 1979.5, 1427);
                yield return new drivers(128, 1979.58333333333, 1554);
                yield return new drivers(129, 1979.66666666667, 1645);
                yield return new drivers(130, 1979.75, 1653);
                yield return new drivers(131, 1979.83333333333, 2016);
                yield return new drivers(132, 1979.91666666667, 2207);
                yield return new drivers(133, 1980, 1665);
                yield return new drivers(134, 1980.08333333333, 1361);
                yield return new drivers(135, 1980.16666666667, 1506);
                yield return new drivers(136, 1980.25, 1360);
                yield return new drivers(137, 1980.33333333333, 1453);
                yield return new drivers(138, 1980.41666666667, 1522);
                yield return new drivers(139, 1980.5, 1460);
                yield return new drivers(140, 1980.58333333333, 1552);
                yield return new drivers(141, 1980.66666666667, 1548);
                yield return new drivers(142, 1980.75, 1827);
                yield return new drivers(143, 1980.83333333333, 1737);
                yield return new drivers(144, 1980.91666666667, 1941);
                yield return new drivers(145, 1981, 1474);
                yield return new drivers(146, 1981.08333333333, 1458);
                yield return new drivers(147, 1981.16666666667, 1542);
                yield return new drivers(148, 1981.25, 1404);
                yield return new drivers(149, 1981.33333333333, 1522);
                yield return new drivers(150, 1981.41666666667, 1385);
                yield return new drivers(151, 1981.5, 1641);
                yield return new drivers(152, 1981.58333333333, 1510);
                yield return new drivers(153, 1981.66666666667, 1681);
                yield return new drivers(154, 1981.75, 1938);
                yield return new drivers(155, 1981.83333333333, 1868);
                yield return new drivers(156, 1981.91666666667, 1726);
                yield return new drivers(157, 1982, 1456);
                yield return new drivers(158, 1982.08333333333, 1445);
                yield return new drivers(159, 1982.16666666667, 1456);
                yield return new drivers(160, 1982.25, 1365);
                yield return new drivers(161, 1982.33333333333, 1487);
                yield return new drivers(162, 1982.41666666667, 1558);
                yield return new drivers(163, 1982.5, 1488);
                yield return new drivers(164, 1982.58333333333, 1684);
                yield return new drivers(165, 1982.66666666667, 1594);
                yield return new drivers(166, 1982.75, 1850);
                yield return new drivers(167, 1982.83333333333, 1998);
                yield return new drivers(168, 1982.91666666667, 2079);
                yield return new drivers(169, 1983, 1494);
                yield return new drivers(170, 1983.08333333333, 1057);
                yield return new drivers(171, 1983.16666666667, 1218);
                yield return new drivers(172, 1983.25, 1168);
                yield return new drivers(173, 1983.33333333333, 1236);
                yield return new drivers(174, 1983.41666666667, 1076);
                yield return new drivers(175, 1983.5, 1174);
                yield return new drivers(176, 1983.58333333333, 1139);
                yield return new drivers(177, 1983.66666666667, 1427);
                yield return new drivers(178, 1983.75, 1487);
                yield return new drivers(179, 1983.83333333333, 1483);
                yield return new drivers(180, 1983.91666666667, 1513);
                yield return new drivers(181, 1984, 1357);
                yield return new drivers(182, 1984.08333333333, 1165);
                yield return new drivers(183, 1984.16666666667, 1282);
                yield return new drivers(184, 1984.25, 1110);
                yield return new drivers(185, 1984.33333333333, 1297);
                yield return new drivers(186, 1984.41666666667, 1185);
                yield return new drivers(187, 1984.5, 1222);
                yield return new drivers(188, 1984.58333333333, 1284);
                yield return new drivers(189, 1984.66666666667, 1444);
                yield return new drivers(190, 1984.75, 1575);
                yield return new drivers(191, 1984.83333333333, 1737);
                yield return new drivers(192, 1984.91666666667, 1763);
            }
        }
    }
}
