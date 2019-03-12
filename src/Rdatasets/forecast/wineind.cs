// ReSharper disable All

namespace Rdatasets.forecast
{
    using System.Collections.Generic;

    /// <summary>
    /// Australian total wine sales
    /// </summary>

    public class wineind
    {
        public readonly int κ;
        public readonly double time;
        public readonly int value;

        public wineind(int κ, double time, int value)
        {
            this.κ = κ;
            this.time = time;
            this.value = value;
        }

        public static IEnumerable<wineind> Data
        {
            get
            {
                yield return new wineind(1, 1980, 15136);
                yield return new wineind(2, 1980.08333333333, 16733);
                yield return new wineind(3, 1980.16666666667, 20016);
                yield return new wineind(4, 1980.25, 17708);
                yield return new wineind(5, 1980.33333333333, 18019);
                yield return new wineind(6, 1980.41666666667, 19227);
                yield return new wineind(7, 1980.5, 22893);
                yield return new wineind(8, 1980.58333333333, 23739);
                yield return new wineind(9, 1980.66666666667, 21133);
                yield return new wineind(10, 1980.75, 22591);
                yield return new wineind(11, 1980.83333333333, 26786);
                yield return new wineind(12, 1980.91666666667, 29740);
                yield return new wineind(13, 1981, 15028);
                yield return new wineind(14, 1981.08333333333, 17977);
                yield return new wineind(15, 1981.16666666667, 20008);
                yield return new wineind(16, 1981.25, 21354);
                yield return new wineind(17, 1981.33333333333, 19498);
                yield return new wineind(18, 1981.41666666667, 22125);
                yield return new wineind(19, 1981.5, 25817);
                yield return new wineind(20, 1981.58333333333, 28779);
                yield return new wineind(21, 1981.66666666667, 20960);
                yield return new wineind(22, 1981.75, 22254);
                yield return new wineind(23, 1981.83333333333, 27392);
                yield return new wineind(24, 1981.91666666667, 29945);
                yield return new wineind(25, 1982, 16933);
                yield return new wineind(26, 1982.08333333333, 17892);
                yield return new wineind(27, 1982.16666666667, 20533);
                yield return new wineind(28, 1982.25, 23569);
                yield return new wineind(29, 1982.33333333333, 22417);
                yield return new wineind(30, 1982.41666666667, 22084);
                yield return new wineind(31, 1982.5, 26580);
                yield return new wineind(32, 1982.58333333333, 27454);
                yield return new wineind(33, 1982.66666666667, 24081);
                yield return new wineind(34, 1982.75, 23451);
                yield return new wineind(35, 1982.83333333333, 28991);
                yield return new wineind(36, 1982.91666666667, 31386);
                yield return new wineind(37, 1983, 16896);
                yield return new wineind(38, 1983.08333333333, 20045);
                yield return new wineind(39, 1983.16666666667, 23471);
                yield return new wineind(40, 1983.25, 21747);
                yield return new wineind(41, 1983.33333333333, 25621);
                yield return new wineind(42, 1983.41666666667, 23859);
                yield return new wineind(43, 1983.5, 25500);
                yield return new wineind(44, 1983.58333333333, 30998);
                yield return new wineind(45, 1983.66666666667, 24475);
                yield return new wineind(46, 1983.75, 23145);
                yield return new wineind(47, 1983.83333333333, 29701);
                yield return new wineind(48, 1983.91666666667, 34365);
                yield return new wineind(49, 1984, 17556);
                yield return new wineind(50, 1984.08333333333, 22077);
                yield return new wineind(51, 1984.16666666667, 25702);
                yield return new wineind(52, 1984.25, 22214);
                yield return new wineind(53, 1984.33333333333, 26886);
                yield return new wineind(54, 1984.41666666667, 23191);
                yield return new wineind(55, 1984.5, 27831);
                yield return new wineind(56, 1984.58333333333, 35406);
                yield return new wineind(57, 1984.66666666667, 23195);
                yield return new wineind(58, 1984.75, 25110);
                yield return new wineind(59, 1984.83333333333, 30009);
                yield return new wineind(60, 1984.91666666667, 36242);
                yield return new wineind(61, 1985, 18450);
                yield return new wineind(62, 1985.08333333333, 21845);
                yield return new wineind(63, 1985.16666666667, 26488);
                yield return new wineind(64, 1985.25, 22394);
                yield return new wineind(65, 1985.33333333333, 28057);
                yield return new wineind(66, 1985.41666666667, 25451);
                yield return new wineind(67, 1985.5, 24872);
                yield return new wineind(68, 1985.58333333333, 33424);
                yield return new wineind(69, 1985.66666666667, 24052);
                yield return new wineind(70, 1985.75, 28449);
                yield return new wineind(71, 1985.83333333333, 33533);
                yield return new wineind(72, 1985.91666666667, 37351);
                yield return new wineind(73, 1986, 19969);
                yield return new wineind(74, 1986.08333333333, 21701);
                yield return new wineind(75, 1986.16666666667, 26249);
                yield return new wineind(76, 1986.25, 24493);
                yield return new wineind(77, 1986.33333333333, 24603);
                yield return new wineind(78, 1986.41666666667, 26485);
                yield return new wineind(79, 1986.5, 30723);
                yield return new wineind(80, 1986.58333333333, 34569);
                yield return new wineind(81, 1986.66666666667, 26689);
                yield return new wineind(82, 1986.75, 26157);
                yield return new wineind(83, 1986.83333333333, 32064);
                yield return new wineind(84, 1986.91666666667, 38870);
                yield return new wineind(85, 1987, 21337);
                yield return new wineind(86, 1987.08333333333, 19419);
                yield return new wineind(87, 1987.16666666667, 23166);
                yield return new wineind(88, 1987.25, 28286);
                yield return new wineind(89, 1987.33333333333, 24570);
                yield return new wineind(90, 1987.41666666667, 24001);
                yield return new wineind(91, 1987.5, 33151);
                yield return new wineind(92, 1987.58333333333, 24878);
                yield return new wineind(93, 1987.66666666667, 26804);
                yield return new wineind(94, 1987.75, 28967);
                yield return new wineind(95, 1987.83333333333, 33311);
                yield return new wineind(96, 1987.91666666667, 40226);
                yield return new wineind(97, 1988, 20504);
                yield return new wineind(98, 1988.08333333333, 23060);
                yield return new wineind(99, 1988.16666666667, 23562);
                yield return new wineind(100, 1988.25, 27562);
                yield return new wineind(101, 1988.33333333333, 23940);
                yield return new wineind(102, 1988.41666666667, 24584);
                yield return new wineind(103, 1988.5, 34303);
                yield return new wineind(104, 1988.58333333333, 25517);
                yield return new wineind(105, 1988.66666666667, 23494);
                yield return new wineind(106, 1988.75, 29095);
                yield return new wineind(107, 1988.83333333333, 32903);
                yield return new wineind(108, 1988.91666666667, 34379);
                yield return new wineind(109, 1989, 16991);
                yield return new wineind(110, 1989.08333333333, 21109);
                yield return new wineind(111, 1989.16666666667, 23740);
                yield return new wineind(112, 1989.25, 25552);
                yield return new wineind(113, 1989.33333333333, 21752);
                yield return new wineind(114, 1989.41666666667, 20294);
                yield return new wineind(115, 1989.5, 29009);
                yield return new wineind(116, 1989.58333333333, 25500);
                yield return new wineind(117, 1989.66666666667, 24166);
                yield return new wineind(118, 1989.75, 26960);
                yield return new wineind(119, 1989.83333333333, 31222);
                yield return new wineind(120, 1989.91666666667, 38641);
                yield return new wineind(121, 1990, 14672);
                yield return new wineind(122, 1990.08333333333, 17543);
                yield return new wineind(123, 1990.16666666667, 25453);
                yield return new wineind(124, 1990.25, 32683);
                yield return new wineind(125, 1990.33333333333, 22449);
                yield return new wineind(126, 1990.41666666667, 22316);
                yield return new wineind(127, 1990.5, 27595);
                yield return new wineind(128, 1990.58333333333, 25451);
                yield return new wineind(129, 1990.66666666667, 25421);
                yield return new wineind(130, 1990.75, 25288);
                yield return new wineind(131, 1990.83333333333, 32568);
                yield return new wineind(132, 1990.91666666667, 35110);
                yield return new wineind(133, 1991, 16052);
                yield return new wineind(134, 1991.08333333333, 22146);
                yield return new wineind(135, 1991.16666666667, 21198);
                yield return new wineind(136, 1991.25, 19543);
                yield return new wineind(137, 1991.33333333333, 22084);
                yield return new wineind(138, 1991.41666666667, 23816);
                yield return new wineind(139, 1991.5, 29961);
                yield return new wineind(140, 1991.58333333333, 26773);
                yield return new wineind(141, 1991.66666666667, 26635);
                yield return new wineind(142, 1991.75, 26972);
                yield return new wineind(143, 1991.83333333333, 30207);
                yield return new wineind(144, 1991.91666666667, 38687);
                yield return new wineind(145, 1992, 16974);
                yield return new wineind(146, 1992.08333333333, 21697);
                yield return new wineind(147, 1992.16666666667, 24179);
                yield return new wineind(148, 1992.25, 23757);
                yield return new wineind(149, 1992.33333333333, 25013);
                yield return new wineind(150, 1992.41666666667, 24019);
                yield return new wineind(151, 1992.5, 30345);
                yield return new wineind(152, 1992.58333333333, 24488);
                yield return new wineind(153, 1992.66666666667, 25156);
                yield return new wineind(154, 1992.75, 25650);
                yield return new wineind(155, 1992.83333333333, 30923);
                yield return new wineind(156, 1992.91666666667, 37240);
                yield return new wineind(157, 1993, 17466);
                yield return new wineind(158, 1993.08333333333, 19463);
                yield return new wineind(159, 1993.16666666667, 24352);
                yield return new wineind(160, 1993.25, 26805);
                yield return new wineind(161, 1993.33333333333, 25236);
                yield return new wineind(162, 1993.41666666667, 24735);
                yield return new wineind(163, 1993.5, 29356);
                yield return new wineind(164, 1993.58333333333, 31234);
                yield return new wineind(165, 1993.66666666667, 22724);
                yield return new wineind(166, 1993.75, 28496);
                yield return new wineind(167, 1993.83333333333, 32857);
                yield return new wineind(168, 1993.91666666667, 37198);
                yield return new wineind(169, 1994, 13652);
                yield return new wineind(170, 1994.08333333333, 22784);
                yield return new wineind(171, 1994.16666666667, 23565);
                yield return new wineind(172, 1994.25, 26323);
                yield return new wineind(173, 1994.33333333333, 23779);
                yield return new wineind(174, 1994.41666666667, 27549);
                yield return new wineind(175, 1994.5, 29660);
                yield return new wineind(176, 1994.58333333333, 23356);
            }
        }
    }
}
