// ReSharper disable All

namespace Rdatasets.boot
{
    using System.Collections.Generic;

    /// <summary>
    /// Dates of Coal Mining Disasters
    /// </summary>

    public class coal
    {
        public readonly int κ;
        public readonly double date;

        public coal(int κ, double date)
        {
            this.κ = κ;
            this.date = date;
        }

        public static IEnumerable<coal> Data
        {
            get
            {
                yield return new coal(1, 1851.20260095825);
                yield return new coal(2, 1851.63244353183);
                yield return new coal(3, 1851.96919917864);
                yield return new coal(4, 1851.97467488022);
                yield return new coal(5, 1852.31416837782);
                yield return new coal(6, 1852.34702258727);
                yield return new coal(7, 1852.35797399042);
                yield return new coal(8, 1852.38535249829);
                yield return new coal(9, 1852.97672826831);
                yield return new coal(10, 1853.19575633128);
                yield return new coal(11, 1853.22861054073);
                yield return new coal(12, 1853.3189596167);
                yield return new coal(13, 1853.49965776865);
                yield return new coal(14, 1854.13483915127);
                yield return new coal(15, 1856.39630390144);
                yield return new coal(16, 1856.50581793292);
                yield return new coal(17, 1856.53867214237);
                yield return new coal(18, 1856.61806981519);
                yield return new coal(19, 1857.13826146475);
                yield return new coal(20, 1857.4038329911);
                yield return new coal(21, 1857.58179329227);
                yield return new coal(22, 1858.09103353867);
                yield return new coal(23, 1858.15400410678);
                yield return new coal(24, 1858.40588637919);
                yield return new coal(25, 1858.94524298426);
                yield return new coal(26, 1860.12525667351);
                yield return new coal(27, 1860.16906228611);
                yield return new coal(28, 1860.59069130732);
                yield return new coal(29, 1860.8507871321);
                yield return new coal(30, 1860.91923340178);
                yield return new coal(31, 1860.97125256674);
                yield return new coal(32, 1861.18480492813);
                yield return new coal(33, 1861.73785078713);
                yield return new coal(34, 1861.83641341547);
                yield return new coal(35, 1862.13757700205);
                yield return new coal(36, 1862.8932238193);
                yield return new coal(37, 1862.9370294319);
                yield return new coal(38, 1863.17796030116);
                yield return new coal(39, 1863.79397672827);
                yield return new coal(40, 1863.93908281999);
                yield return new coal(41, 1863.98562628337);
                yield return new coal(42, 1865.45859000684);
                yield return new coal(43, 1865.97056810404);
                yield return new coal(44, 1866.0636550308);
                yield return new coal(45, 1866.3401779603);
                yield return new coal(46, 1866.45242984257);
                yield return new coal(47, 1866.83299110199);
                yield return new coal(48, 1866.94798083504);
                yield return new coal(49, 1866.95071868583);
                yield return new coal(50, 1867.63518138261);
                yield return new coal(51, 1867.85420944559);
                yield return new coal(52, 1867.86242299795);
                yield return new coal(53, 1868.74948665298);
                yield return new coal(54, 1868.90280629706);
                yield return new coal(55, 1868.98767967146);
                yield return new coal(56, 1869.25051334702);
                yield return new coal(57, 1869.44216290212);
                yield return new coal(58, 1869.55441478439);
                yield return new coal(59, 1869.8090349076);
                yield return new coal(60, 1869.87474332649);
                yield return new coal(61, 1870.12388774812);
                yield return new coal(62, 1870.51540041068);
                yield return new coal(63, 1870.55920602327);
                yield return new coal(64, 1870.63312799452);
                yield return new coal(65, 1871.02737850787);
                yield return new coal(66, 1871.15058179329);
                yield return new coal(67, 1871.16700889801);
                yield return new coal(68, 1871.73648186174);
                yield return new coal(69, 1871.81587953457);
                yield return new coal(70, 1872.12251882272);
                yield return new coal(71, 1872.24024640657);
                yield return new coal(72, 1872.76865160849);
                yield return new coal(73, 1873.13552361396);
                yield return new coal(74, 1874.28542094456);
                yield return new coal(75, 1874.54551676934);
                yield return new coal(76, 1874.88774811773);
                yield return new coal(77, 1874.98083504449);
                yield return new coal(78, 1875.32854209446);
                yield return new coal(79, 1875.92539356605);
                yield return new coal(80, 1875.93086926762);
                yield return new coal(81, 1875.93086926762);
                yield return new coal(82, 1876.96577686516);
                yield return new coal(83, 1877.0643394935);
                yield return new coal(84, 1877.1054072553);
                yield return new coal(85, 1877.19028062971);
                yield return new coal(86, 1877.77891854894);
                yield return new coal(87, 1877.8090349076);
                yield return new coal(88, 1878.18412046543);
                yield return new coal(89, 1878.19507186858);
                yield return new coal(90, 1878.23613963039);
                yield return new coal(91, 1878.43326488706);
                yield return new coal(92, 1878.69609856263);
                yield return new coal(93, 1879.03559206023);
                yield return new coal(94, 1879.17248459959);
                yield return new coal(95, 1879.50102669405);
                yield return new coal(96, 1880.05681040383);
                yield return new coal(97, 1880.53867214237);
                yield return new coal(98, 1880.68925393566);
                yield return new coal(99, 1880.94387405886);
                yield return new coal(100, 1881.1054072553);
                yield return new coal(101, 1881.96783025325);
                yield return new coal(102, 1882.12936344969);
                yield return new coal(103, 1882.29637234771);
                yield return new coal(104, 1882.29911019849);
                yield return new coal(105, 1882.33470225873);
                yield return new coal(106, 1882.85215605749);
                yield return new coal(107, 1883.79671457906);
                yield return new coal(108, 1883.8514715948);
                yield return new coal(109, 1884.07323750856);
                yield return new coal(110, 1884.85626283368);
                yield return new coal(111, 1885.16837782341);
                yield return new coal(112, 1885.46406570842);
                yield return new coal(113, 1885.9787816564);
                yield return new coal(114, 1886.6167008898);
                yield return new coal(115, 1886.69336071184);
                yield return new coal(116, 1886.75359342916);
                yield return new coal(117, 1886.92060232717);
                yield return new coal(118, 1887.13415468857);
                yield return new coal(119, 1887.4052019165);
                yield return new coal(120, 1888.2977412731);
                yield return new coal(121, 1889.05065023956);
                yield return new coal(122, 1889.19849418207);
                yield return new coal(123, 1889.79260780287);
                yield return new coal(124, 1890.10198494182);
                yield return new coal(125, 1890.18959616701);
                yield return new coal(126, 1891.25188227242);
                yield return new coal(127, 1891.66529774127);
                yield return new coal(128, 1892.65366187543);
                yield return new coal(129, 1893.50787132101);
                yield return new coal(130, 1894.47707049966);
                yield return new coal(131, 1895.31759069131);
                yield return new coal(132, 1896.07049965777);
                yield return new coal(133, 1896.28405201916);
                yield return new coal(134, 1896.33059548255);
                yield return new coal(135, 1899.62970568104);
                yield return new coal(136, 1901.39288158795);
                yield return new coal(137, 1902.67145790554);
                yield return new coal(138, 1905.05612594114);
                yield return new coal(139, 1905.18754277892);
                yield return new coal(140, 1905.52429842574);
                yield return new coal(141, 1906.77275838467);
                yield return new coal(142, 1908.13620807666);
                yield return new coal(143, 1908.27036276523);
                yield return new coal(144, 1908.62902121834);
                yield return new coal(145, 1909.1273100616);
                yield return new coal(146, 1909.82546201232);
                yield return new coal(147, 1910.35660506502);
                yield return new coal(148, 1910.96988364134);
                yield return new coal(149, 1912.51950718686);
                yield return new coal(150, 1913.78439425051);
                yield return new coal(151, 1914.40862422998);
                yield return new coal(152, 1916.61533196441);
                yield return new coal(153, 1918.03080082136);
                yield return new coal(154, 1922.52908966461);
                yield return new coal(155, 1922.67693360712);
                yield return new coal(156, 1923.56947296372);
                yield return new coal(157, 1927.16153319644);
                yield return new coal(158, 1928.11430527036);
                yield return new coal(159, 1930.15400410678);
                yield return new coal(160, 1930.74811772758);
                yield return new coal(161, 1931.07665982204);
                yield return new coal(162, 1931.8295687885);
                yield return new coal(163, 1931.88432580424);
                yield return new coal(164, 1932.06502395619);
                yield return new coal(165, 1932.86447638604);
                yield return new coal(166, 1932.87542778919);
                yield return new coal(167, 1933.88295687885);
                yield return new coal(168, 1934.7234770705);
                yield return new coal(169, 1935.64339493498);
                yield return new coal(170, 1935.69541409993);
                yield return new coal(171, 1936.5961670089);
                yield return new coal(172, 1937.49965776865);
                yield return new coal(173, 1938.35386721424);
                yield return new coal(174, 1939.82135523614);
                yield return new coal(175, 1940.21834360027);
                yield return new coal(176, 1940.42368240931);
                yield return new coal(177, 1941.42026009582);
                yield return new coal(178, 1941.52156057495);
                yield return new coal(179, 1941.5735797399);
                yield return new coal(180, 1942.0006844627);
                yield return new coal(181, 1942.12936344969);
                yield return new coal(182, 1942.48254620123);
                yield return new coal(183, 1946.94524298426);
                yield return new coal(184, 1947.02464065708);
                yield return new coal(185, 1947.61875427789);
                yield return new coal(186, 1947.6379192334);
                yield return new coal(187, 1947.68720054757);
                yield return new coal(188, 1951.4052019165);
                yield return new coal(189, 1957.88295687885);
                yield return new coal(190, 1960.4893908282);
                yield return new coal(191, 1962.21971252567);
            }
        }
    }
}
