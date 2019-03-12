// ReSharper disable All

namespace Rdatasets.fpp2
{
    using System.Collections.Generic;

    /// <summary>
    /// Monthly corticosteroid drug sales in Australia from July 1991 to June 2008.
    /// </summary>

    public class h02
    {
        public readonly int κ;
        public readonly double time;
        public readonly double value;

        public h02(int κ, double time, double value)
        {
            this.κ = κ;
            this.time = time;
            this.value = value;
        }

        public static IEnumerable<h02> Data
        {
            get
            {
                yield return new h02(1, 1991.5, 0.429795);
                yield return new h02(2, 1991.58333333333, 0.400906);
                yield return new h02(3, 1991.66666666667, 0.432159);
                yield return new h02(4, 1991.75, 0.492543);
                yield return new h02(5, 1991.83333333333, 0.502369);
                yield return new h02(6, 1991.91666666667, 0.602652);
                yield return new h02(7, 1992, 0.660119);
                yield return new h02(8, 1992.08333333333, 0.33622);
                yield return new h02(9, 1992.16666666667, 0.351348);
                yield return new h02(10, 1992.25, 0.379808);
                yield return new h02(11, 1992.33333333333, 0.361801);
                yield return new h02(12, 1992.41666666667, 0.410534);
                yield return new h02(13, 1992.5, 0.48338867);
                yield return new h02(14, 1992.58333333333, 0.47546342);
                yield return new h02(15, 1992.66666666667, 0.53476104);
                yield return new h02(16, 1992.75, 0.56860613);
                yield return new h02(17, 1992.83333333333, 0.59522329);
                yield return new h02(18, 1992.91666666667, 0.77125778);
                yield return new h02(19, 1993, 0.7515028);
                yield return new h02(20, 1993.08333333333, 0.38755434);
                yield return new h02(21, 1993.16666666667, 0.42728322);
                yield return new h02(22, 1993.25, 0.41389018);
                yield return new h02(23, 1993.33333333333, 0.42885882);
                yield return new h02(24, 1993.41666666667, 0.47012642);
                yield return new h02(25, 1993.5, 0.50920969);
                yield return new h02(26, 1993.58333333333, 0.558443);
                yield return new h02(27, 1993.66666666667, 0.60151406);
                yield return new h02(28, 1993.75, 0.6329471);
                yield return new h02(29, 1993.83333333333, 0.69960539);
                yield return new h02(30, 1993.91666666667, 0.96308051);
                yield return new h02(31, 1994, 0.81932534);
                yield return new h02(32, 1994.08333333333, 0.4376698);
                yield return new h02(33, 1994.16666666667, 0.50612127);
                yield return new h02(34, 1994.25, 0.47049117);
                yield return new h02(35, 1994.33333333333, 0.51069626);
                yield return new h02(36, 1994.41666666667, 0.54051379);
                yield return new h02(37, 1994.5, 0.55811892);
                yield return new h02(38, 1994.58333333333, 0.67285206);
                yield return new h02(39, 1994.66666666667, 0.68589738);
                yield return new h02(40, 1994.75, 0.68969198);
                yield return new h02(41, 1994.83333333333, 0.74130358);
                yield return new h02(42, 1994.91666666667, 0.81330763);
                yield return new h02(43, 1995, 0.80311257);
                yield return new h02(44, 1995.08333333333, 0.47525824);
                yield return new h02(45, 1995.16666666667, 0.5525723);
                yield return new h02(46, 1995.25, 0.52710782);
                yield return new h02(47, 1995.33333333333, 0.56124982);
                yield return new h02(48, 1995.41666666667, 0.58897764);
                yield return new h02(49, 1995.5, 0.62313362);
                yield return new h02(50, 1995.58333333333, 0.74083723);
                yield return new h02(51, 1995.66666666667, 0.72537176);
                yield return new h02(52, 1995.75, 0.81580302);
                yield return new h02(53, 1995.83333333333, 0.81400947);
                yield return new h02(54, 1995.91666666667, 0.92665305);
                yield return new h02(55, 1996, 0.93727594);
                yield return new h02(56, 1996.08333333333, 0.52876165);
                yield return new h02(57, 1996.16666666667, 0.55933994);
                yield return new h02(58, 1996.25, 0.57787166);
                yield return new h02(59, 1996.33333333333, 0.61492741);
                yield return new h02(60, 1996.41666666667, 0.59418877);
                yield return new h02(61, 1996.5, 0.70775844);
                yield return new h02(62, 1996.58333333333, 0.71950195);
                yield return new h02(63, 1996.66666666667, 0.74432369);
                yield return new h02(64, 1996.75, 0.80485511);
                yield return new h02(65, 1996.83333333333, 0.78854235);
                yield return new h02(66, 1996.91666666667, 0.9710894);
                yield return new h02(67, 1997, 0.84683354);
                yield return new h02(68, 1997.08333333333, 0.46382252);
                yield return new h02(69, 1997.16666666667, 0.48527317);
                yield return new h02(70, 1997.25, 0.5280586);
                yield return new h02(71, 1997.33333333333, 0.56233647);
                yield return new h02(72, 1997.41666666667, 0.5885704);
                yield return new h02(73, 1997.5, 0.66948036);
                yield return new h02(74, 1997.58333333333, 0.67799365);
                yield return new h02(75, 1997.66666666667, 0.76299549);
                yield return new h02(76, 1997.75, 0.79972374);
                yield return new h02(77, 1997.83333333333, 0.77052192);
                yield return new h02(78, 1997.91666666667, 0.99438934);
                yield return new h02(79, 1998, 0.80054443);
                yield return new h02(80, 1998.08333333333, 0.49055721);
                yield return new h02(81, 1998.16666666667, 0.52440799);
                yield return new h02(82, 1998.25, 0.53664948);
                yield return new h02(83, 1998.33333333333, 0.55209054);
                yield return new h02(84, 1998.41666666667, 0.60336564);
                yield return new h02(85, 1998.5, 0.68124538);
                yield return new h02(86, 1998.58333333333, 0.67807535);
                yield return new h02(87, 1998.66666666667, 0.79489265);
                yield return new h02(88, 1998.75, 0.7846239);
                yield return new h02(89, 1998.83333333333, 0.8130087);
                yield return new h02(90, 1998.91666666667, 0.9777323);
                yield return new h02(91, 1999, 0.89308148);
                yield return new h02(92, 1999.08333333333, 0.51269597);
                yield return new h02(93, 1999.16666666667, 0.65299589);
                yield return new h02(94, 1999.25, 0.5739764);
                yield return new h02(95, 1999.33333333333, 0.63923842);
                yield return new h02(96, 1999.41666666667, 0.70387188);
                yield return new h02(97, 1999.5, 0.77064824);
                yield return new h02(98, 1999.58333333333, 0.84618588);
                yield return new h02(99, 1999.66666666667, 0.89272889);
                yield return new h02(100, 1999.75, 0.89789988);
                yield return new h02(101, 1999.83333333333, 0.94728069);
                yield return new h02(102, 1999.91666666667, 1.05070727);
                yield return new h02(103, 2000, 0.96965567);
                yield return new h02(104, 2000.08333333333, 0.57329151);
                yield return new h02(105, 2000.16666666667, 0.61850684);
                yield return new h02(106, 2000.25, 0.61899573);
                yield return new h02(107, 2000.33333333333, 0.66520922);
                yield return new h02(108, 2000.41666666667, 0.72652015);
                yield return new h02(109, 2000.5, 0.85586494);
                yield return new h02(110, 2000.58333333333, 0.86598429);
                yield return new h02(111, 2000.66666666667, 0.82524883);
                yield return new h02(112, 2000.75, 0.95542102);
                yield return new h02(113, 2000.83333333333, 0.93859596);
                yield return new h02(114, 2000.91666666667, 1.01302442);
                yield return new h02(115, 2001, 1.04380535);
                yield return new h02(116, 2001.08333333333, 0.51064725);
                yield return new h02(117, 2001.16666666667, 0.67256901);
                yield return new h02(118, 2001.25, 0.64847006);
                yield return new h02(119, 2001.33333333333, 0.70411469);
                yield return new h02(120, 2001.41666666667, 0.69943075);
                yield return new h02(121, 2001.5, 0.85192587);
                yield return new h02(122, 2001.58333333333, 0.9077052);
                yield return new h02(123, 2001.66666666667, 0.86744447);
                yield return new h02(124, 2001.75, 1.02429281);
                yield return new h02(125, 2001.83333333333, 1.10959022);
                yield return new h02(126, 2001.91666666667, 1.01231323);
                yield return new h02(127, 2002, 1.14586761);
                yield return new h02(128, 2002.08333333333, 0.57558438);
                yield return new h02(129, 2002.16666666667, 0.64116459);
                yield return new h02(130, 2002.25, 0.67986207);
                yield return new h02(131, 2002.33333333333, 0.7679384);
                yield return new h02(132, 2002.41666666667, 0.75209591);
                yield return new h02(133, 2002.5, 0.91806359);
                yield return new h02(134, 2002.58333333333, 0.92436753);
                yield return new h02(135, 2002.66666666667, 1.01319767);
                yield return new h02(136, 2002.75, 1.02697609);
                yield return new h02(137, 2002.83333333333, 1.00679597);
                yield return new h02(138, 2002.91666666667, 1.10277568);
                yield return new h02(139, 2003, 1.07814487);
                yield return new h02(140, 2003.08333333333, 0.57829619);
                yield return new h02(141, 2003.16666666667, 0.64333332);
                yield return new h02(142, 2003.25, 0.66336735);
                yield return new h02(143, 2003.33333333333, 0.750516);
                yield return new h02(144, 2003.41666666667, 0.80074564);
                yield return new h02(145, 2003.5, 0.91636103);
                yield return new h02(146, 2003.58333333333, 0.91688682);
                yield return new h02(147, 2003.66666666667, 1.08465893);
                yield return new h02(148, 2003.75, 1.15064822);
                yield return new h02(149, 2003.83333333333, 1.05083821);
                yield return new h02(150, 2003.91666666667, 1.22323454);
                yield return new h02(151, 2004, 1.13012521);
                yield return new h02(152, 2004.08333333333, 0.66798867);
                yield return new h02(153, 2004.16666666667, 0.74901428);
                yield return new h02(154, 2004.25, 0.73998602);
                yield return new h02(155, 2004.33333333333, 0.79512863);
                yield return new h02(156, 2004.41666666667, 0.85680282);
                yield return new h02(157, 2004.5, 1.00159317);
                yield return new h02(158, 2004.58333333333, 0.99486433);
                yield return new h02(159, 2004.66666666667, 1.134432);
                yield return new h02(160, 2004.75, 1.181011);
                yield return new h02(161, 2004.83333333333, 1.216037);
                yield return new h02(162, 2004.91666666667, 1.257238);
                yield return new h02(163, 2005, 1.17069);
                yield return new h02(164, 2005.08333333333, 0.597639);
                yield return new h02(165, 2005.16666666667, 0.65259);
                yield return new h02(166, 2005.25, 0.670505);
                yield return new h02(167, 2005.33333333333, 0.695248);
                yield return new h02(168, 2005.41666666667, 0.842263);
                yield return new h02(169, 2005.5, 0.874336);
                yield return new h02(170, 2005.58333333333, 1.006497);
                yield return new h02(171, 2005.66666666667, 1.094736);
                yield return new h02(172, 2005.75, 1.027043);
                yield return new h02(173, 2005.83333333333, 1.149232);
                yield return new h02(174, 2005.91666666667, 1.160712);
                yield return new h02(175, 2006, 1.230691);
                yield return new h02(176, 2006.08333333333, 0.587135);
                yield return new h02(177, 2006.16666666667, 0.706959);
                yield return new h02(178, 2006.25, 0.639641);
                yield return new h02(179, 2006.33333333333, 0.807405);
                yield return new h02(180, 2006.41666666667, 0.79797);
                yield return new h02(181, 2006.5, 0.884312);
                yield return new h02(182, 2006.58333333333, 1.049648);
                yield return new h02(183, 2006.66666666667, 0.995709);
                yield return new h02(184, 2006.75, 1.168253);
                yield return new h02(185, 2006.83333333333, 1.108038);
                yield return new h02(186, 2006.91666666667, 1.120053);
                yield return new h02(187, 2007, 1.223319);
                yield return new h02(188, 2007.08333333333, 0.597753);
                yield return new h02(189, 2007.16666666667, 0.704398);
                yield return new h02(190, 2007.25, 0.56176);
                yield return new h02(191, 2007.33333333333, 0.745258);
                yield return new h02(192, 2007.41666666667, 0.837934);
                yield return new h02(193, 2007.5, 0.954144);
                yield return new h02(194, 2007.58333333333, 1.07821949);
                yield return new h02(195, 2007.66666666667, 1.11098161);
                yield return new h02(196, 2007.75, 1.10997914);
                yield return new h02(197, 2007.83333333333, 1.1635343);
                yield return new h02(198, 2007.91666666667, 1.176589);
                yield return new h02(199, 2008, 1.219941);
                yield return new h02(200, 2008.08333333333, 0.761822);
                yield return new h02(201, 2008.16666666667, 0.649435);
                yield return new h02(202, 2008.25, 0.827887);
                yield return new h02(203, 2008.33333333333, 0.816255);
                yield return new h02(204, 2008.41666666667, 0.762137);
            }
        }
    }
}
