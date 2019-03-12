// ReSharper disable All

namespace Rdatasets.fpp2
{
    using System.Collections.Generic;

    /// <summary>
    /// Quarterly Australian Electricity production
    /// </summary>

    public class qauselec
    {
        public readonly int κ;
        public readonly double time;
        public readonly double value;

        public qauselec(int κ, double time, double value)
        {
            this.κ = κ;
            this.time = time;
            this.value = value;
        }

        public static IEnumerable<qauselec> Data
        {
            get
            {
                yield return new qauselec(1, 1956, 3.923);
                yield return new qauselec(2, 1956.25, 4.436);
                yield return new qauselec(3, 1956.5, 4.806);
                yield return new qauselec(4, 1956.75, 4.418);
                yield return new qauselec(5, 1957, 4.339);
                yield return new qauselec(6, 1957.25, 4.811);
                yield return new qauselec(7, 1957.5, 5.259);
                yield return new qauselec(8, 1957.75, 4.735);
                yield return new qauselec(9, 1958, 4.608);
                yield return new qauselec(10, 1958.25, 5.196);
                yield return new qauselec(11, 1958.5, 5.609);
                yield return new qauselec(12, 1958.75, 4.977);
                yield return new qauselec(13, 1959, 4.883);
                yield return new qauselec(14, 1959.25, 5.744);
                yield return new qauselec(15, 1959.5, 6.035);
                yield return new qauselec(16, 1959.75, 5.514);
                yield return new qauselec(17, 1960, 5.387);
                yield return new qauselec(18, 1960.25, 6.211);
                yield return new qauselec(19, 1960.5, 6.659);
                yield return new qauselec(20, 1960.75, 5.983);
                yield return new qauselec(21, 1961, 5.709);
                yield return new qauselec(22, 1961.25, 6.458);
                yield return new qauselec(23, 1961.5, 6.875);
                yield return new qauselec(24, 1961.75, 6.162);
                yield return new qauselec(25, 1962, 6.098);
                yield return new qauselec(26, 1962.25, 7.075);
                yield return new qauselec(27, 1962.5, 7.595);
                yield return new qauselec(28, 1962.75, 6.891);
                yield return new qauselec(29, 1963, 6.707);
                yield return new qauselec(30, 1963.25, 7.874);
                yield return new qauselec(31, 1963.5, 8.555);
                yield return new qauselec(32, 1963.75, 7.503);
                yield return new qauselec(33, 1964, 7.469);
                yield return new qauselec(34, 1964.25, 8.829);
                yield return new qauselec(35, 1964.5, 9.513);
                yield return new qauselec(36, 1964.75, 8.415);
                yield return new qauselec(37, 1965, 8.17);
                yield return new qauselec(38, 1965.25, 9.503);
                yield return new qauselec(39, 1965.5, 10.306);
                yield return new qauselec(40, 1965.75, 9.077);
                yield return new qauselec(41, 1966, 8.65);
                yield return new qauselec(42, 1966.25, 10.18);
                yield return new qauselec(43, 1966.5, 11.234);
                yield return new qauselec(44, 1966.75, 9.836);
                yield return new qauselec(45, 1967, 9.49);
                yield return new qauselec(46, 1967.25, 10.991);
                yield return new qauselec(47, 1967.5, 12.17);
                yield return new qauselec(48, 1967.75, 10.47);
                yield return new qauselec(49, 1968, 10.087);
                yield return new qauselec(50, 1968.25, 11.858);
                yield return new qauselec(51, 1968.5, 13.198);
                yield return new qauselec(52, 1968.75, 11.413);
                yield return new qauselec(53, 1969, 11.136);
                yield return new qauselec(54, 1969.25, 13.04);
                yield return new qauselec(55, 1969.5, 14.248);
                yield return new qauselec(56, 1969.75, 12.759);
                yield return new qauselec(57, 1970, 12.328);
                yield return new qauselec(58, 1970.25, 14.493);
                yield return new qauselec(59, 1970.5, 15.664);
                yield return new qauselec(60, 1970.75, 13.781);
                yield return new qauselec(61, 1971, 13.299);
                yield return new qauselec(62, 1971.25, 15.23);
                yield return new qauselec(63, 1971.5, 16.667);
                yield return new qauselec(64, 1971.75, 14.484);
                yield return new qauselec(65, 1972, 13.838);
                yield return new qauselec(66, 1972.25, 15.919);
                yield return new qauselec(67, 1972.5, 17.149);
                yield return new qauselec(68, 1972.75, 15.564);
                yield return new qauselec(69, 1973, 15.024);
                yield return new qauselec(70, 1973.25, 17.064);
                yield return new qauselec(71, 1973.5, 18.512);
                yield return new qauselec(72, 1973.75, 16.467);
                yield return new qauselec(73, 1974, 16.249);
                yield return new qauselec(74, 1974.25, 18.515);
                yield return new qauselec(75, 1974.5, 20.377);
                yield return new qauselec(76, 1974.75, 17.681);
                yield return new qauselec(77, 1975, 16.692);
                yield return new qauselec(78, 1975.25, 19.184);
                yield return new qauselec(79, 1975.5, 20.078);
                yield return new qauselec(80, 1975.75, 18.26);
                yield return new qauselec(81, 1976, 18.023);
                yield return new qauselec(82, 1976.25, 20.234);
                yield return new qauselec(83, 1976.5, 22.272);
                yield return new qauselec(84, 1976.75, 19.684);
                yield return new qauselec(85, 1977, 19.031);
                yield return new qauselec(86, 1977.25, 21.545);
                yield return new qauselec(87, 1977.5, 23.27);
                yield return new qauselec(88, 1977.75, 20.107);
                yield return new qauselec(89, 1978, 20.084);
                yield return new qauselec(90, 1978.25, 22.634);
                yield return new qauselec(91, 1978.5, 24.494);
                yield return new qauselec(92, 1978.75, 21.396);
                yield return new qauselec(93, 1979, 21.323);
                yield return new qauselec(94, 1979.25, 23.644);
                yield return new qauselec(95, 1979.5, 25.994);
                yield return new qauselec(96, 1979.75, 22.802);
                yield return new qauselec(97, 1980, 22.604);
                yield return new qauselec(98, 1980.25, 24.51);
                yield return new qauselec(99, 1980.5, 26.69);
                yield return new qauselec(100, 1980.75, 24.132);
                yield return new qauselec(101, 1981, 23.639);
                yield return new qauselec(102, 1981.25, 26.32);
                yield return new qauselec(103, 1981.5, 28.345);
                yield return new qauselec(104, 1981.75, 24.89);
                yield return new qauselec(105, 1982, 24.675);
                yield return new qauselec(106, 1982.25, 27.122);
                yield return new qauselec(107, 1982.5, 28.59);
                yield return new qauselec(108, 1982.75, 25.371);
                yield return new qauselec(109, 1983, 24.687);
                yield return new qauselec(110, 1983.25, 27.285);
                yield return new qauselec(111, 1983.5, 29.29);
                yield return new qauselec(112, 1983.75, 26.684);
                yield return new qauselec(113, 1984, 26.641);
                yield return new qauselec(114, 1984.25, 29.042);
                yield return new qauselec(115, 1984.5, 31.856);
                yield return new qauselec(116, 1984.75, 28.343);
                yield return new qauselec(117, 1985, 28.982);
                yield return new qauselec(118, 1985.25, 30.838);
                yield return new qauselec(119, 1985.5, 33.165);
                yield return new qauselec(120, 1985.75, 29.648);
                yield return new qauselec(121, 1986, 29.506);
                yield return new qauselec(122, 1986.25, 32.002);
                yield return new qauselec(123, 1986.5, 34.375);
                yield return new qauselec(124, 1986.75, 31.046);
                yield return new qauselec(125, 1987, 31.015);
                yield return new qauselec(126, 1987.25, 33.685);
                yield return new qauselec(127, 1987.5, 35.85);
                yield return new qauselec(128, 1987.75, 33.211);
                yield return new qauselec(129, 1988, 33.142);
                yield return new qauselec(130, 1988.25, 34.664);
                yield return new qauselec(131, 1988.5, 37.154);
                yield return new qauselec(132, 1988.75, 35.303);
                yield return new qauselec(133, 1989, 36.905);
                yield return new qauselec(134, 1989.25, 37.333);
                yield return new qauselec(135, 1989.5, 40.413);
                yield return new qauselec(136, 1989.75, 36.579);
                yield return new qauselec(137, 1990, 37.016);
                yield return new qauselec(138, 1990.25, 39.103);
                yield return new qauselec(139, 1990.5, 41.067);
                yield return new qauselec(140, 1990.75, 37.653);
                yield return new qauselec(141, 1991, 37.554);
                yield return new qauselec(142, 1991.25, 38.752);
                yield return new qauselec(143, 1991.5, 41.424);
                yield return new qauselec(144, 1991.75, 38.101);
                yield return new qauselec(145, 1992, 38.332);
                yield return new qauselec(146, 1992.25, 39.774);
                yield return new qauselec(147, 1992.5, 42.246);
                yield return new qauselec(148, 1992.75, 38.498);
                yield return new qauselec(149, 1993, 39.46);
                yield return new qauselec(150, 1993.25, 41.356);
                yield return new qauselec(151, 1993.5, 42.949);
                yield return new qauselec(152, 1993.75, 40.974);
                yield return new qauselec(153, 1994, 40.162);
                yield return new qauselec(154, 1994.25, 41.199);
                yield return new qauselec(155, 1994.5, 44.095);
                yield return new qauselec(156, 1994.75, 41.745);
                yield return new qauselec(157, 1995, 41.768);
                yield return new qauselec(158, 1995.25, 43.686);
                yield return new qauselec(159, 1995.5, 46.022);
                yield return new qauselec(160, 1995.75, 42.8);
                yield return new qauselec(161, 1996, 43.661);
                yield return new qauselec(162, 1996.25, 44.707);
                yield return new qauselec(163, 1996.5, 46.326);
                yield return new qauselec(164, 1996.75, 43.346);
                yield return new qauselec(165, 1997, 43.938);
                yield return new qauselec(166, 1997.25, 45.828);
                yield return new qauselec(167, 1997.5, 48.448);
                yield return new qauselec(168, 1997.75, 46.096);
                yield return new qauselec(169, 1998, 46.198);
                yield return new qauselec(170, 1998.25, 47.237);
                yield return new qauselec(171, 1998.5, 49.041);
                yield return new qauselec(172, 1998.75, 46.192);
                yield return new qauselec(173, 1999, 48.089);
                yield return new qauselec(174, 1999.25, 48.227);
                yield return new qauselec(175, 1999.5, 49.784);
                yield return new qauselec(176, 1999.75, 47.588);
                yield return new qauselec(177, 2000, 49.32);
                yield return new qauselec(178, 2000.25, 50.67);
                yield return new qauselec(179, 2000.5, 52.623);
                yield return new qauselec(180, 2000.75, 49.35);
                yield return new qauselec(181, 2001, 51.658);
                yield return new qauselec(182, 2001.25, 51.103);
                yield return new qauselec(183, 2001.5, 52.226);
                yield return new qauselec(184, 2001.75, 50.778);
                yield return new qauselec(185, 2002, 50.639);
                yield return new qauselec(186, 2002.25, 51.486);
                yield return new qauselec(187, 2002.5, 53.299);
                yield return new qauselec(188, 2002.75, 51.646);
                yield return new qauselec(189, 2003, 51.415);
                yield return new qauselec(190, 2003.25, 51.379);
                yield return new qauselec(191, 2003.5, 54.808);
                yield return new qauselec(192, 2003.75, 52.453);
                yield return new qauselec(193, 2004, 54.561);
                yield return new qauselec(194, 2004.25, 54.644);
                yield return new qauselec(195, 2004.5, 55.915);
                yield return new qauselec(196, 2004.75, 52.85);
                yield return new qauselec(197, 2005, 55.035);
                yield return new qauselec(198, 2005.25, 55.117);
                yield return new qauselec(199, 2005.5, 56.043);
                yield return new qauselec(200, 2005.75, 54.992);
                yield return new qauselec(201, 2006, 57.112);
                yield return new qauselec(202, 2006.25, 57.157);
                yield return new qauselec(203, 2006.5, 58.4);
                yield return new qauselec(204, 2006.75, 56.249);
                yield return new qauselec(205, 2007, 56.244);
                yield return new qauselec(206, 2007.25, 55.036);
                yield return new qauselec(207, 2007.5, 59.806);
                yield return new qauselec(208, 2007.75, 56.411);
                yield return new qauselec(209, 2008, 59.118);
                yield return new qauselec(210, 2008.25, 56.66);
                yield return new qauselec(211, 2008.5, 64.067);
                yield return new qauselec(212, 2008.75, 59.045);
                yield return new qauselec(213, 2009, 58.368);
                yield return new qauselec(214, 2009.25, 57.471);
                yield return new qauselec(215, 2009.5, 58.394);
                yield return new qauselec(216, 2009.75, 57.336);
                yield return new qauselec(217, 2010, 58.309);
                yield return new qauselec(218, 2010.25, 58.041);
            }
        }
    }
}
