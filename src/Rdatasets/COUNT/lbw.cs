// ReSharper disable All

namespace Rdatasets.COUNT
{
    using System.Collections.Generic;

    /// <summary>
    /// lbw
    /// </summary>

    public class lbw
    {
        public readonly int κ;
        public readonly int low;
        public readonly int smoke;
        public readonly int race;
        public readonly int age;
        public readonly int lwt;
        public readonly int ptl;
        public readonly int ht;
        public readonly int ui;
        public readonly int ftv;
        public readonly int bwt;

        public lbw(int κ, int low, int smoke, int race, int age, int lwt, int ptl, int ht, int ui, int ftv, int bwt)
        {
            this.κ = κ;
            this.low = low;
            this.smoke = smoke;
            this.race = race;
            this.age = age;
            this.lwt = lwt;
            this.ptl = ptl;
            this.ht = ht;
            this.ui = ui;
            this.ftv = ftv;
            this.bwt = bwt;
        }

        public static IEnumerable<lbw> Data
        {
            get
            {
                yield return new lbw(1, 0, 0, 2, 19, 182, 0, 0, 1, 0, 2523);
                yield return new lbw(2, 0, 0, 3, 33, 155, 0, 0, 0, 3, 2551);
                yield return new lbw(3, 0, 1, 1, 20, 105, 0, 0, 0, 1, 2557);
                yield return new lbw(4, 0, 1, 1, 21, 108, 0, 0, 1, 2, 2594);
                yield return new lbw(5, 0, 1, 1, 18, 107, 0, 0, 1, 0, 2600);
                yield return new lbw(6, 0, 0, 3, 21, 124, 0, 0, 0, 0, 2622);
                yield return new lbw(7, 0, 0, 1, 22, 118, 0, 0, 0, 1, 2637);
                yield return new lbw(8, 0, 0, 3, 17, 103, 0, 0, 0, 1, 2637);
                yield return new lbw(9, 0, 1, 1, 29, 123, 0, 0, 0, 1, 2663);
                yield return new lbw(10, 0, 1, 1, 26, 113, 0, 0, 0, 0, 2665);
                yield return new lbw(11, 0, 0, 3, 19, 95, 0, 0, 0, 0, 2722);
                yield return new lbw(12, 0, 0, 3, 19, 150, 0, 0, 0, 1, 2733);
                yield return new lbw(13, 0, 0, 3, 22, 95, 0, 1, 0, 0, 2750);
                yield return new lbw(14, 0, 0, 3, 30, 107, 1, 0, 1, 2, 2750);
                yield return new lbw(15, 0, 1, 1, 18, 100, 0, 0, 0, 0, 2769);
                yield return new lbw(16, 0, 1, 1, 18, 100, 0, 0, 0, 0, 2769);
                yield return new lbw(17, 0, 0, 2, 15, 98, 0, 0, 0, 0, 2778);
                yield return new lbw(18, 0, 1, 1, 25, 118, 0, 0, 0, 3, 2782);
                yield return new lbw(19, 0, 0, 3, 20, 120, 0, 0, 1, 0, 2807);
                yield return new lbw(20, 0, 1, 1, 28, 120, 0, 0, 0, 1, 2821);
                yield return new lbw(21, 0, 0, 3, 32, 121, 0, 0, 0, 2, 2835);
                yield return new lbw(22, 0, 0, 1, 31, 100, 0, 0, 1, 3, 2835);
                yield return new lbw(23, 0, 0, 1, 36, 202, 0, 0, 0, 1, 2836);
                yield return new lbw(24, 0, 0, 3, 28, 120, 0, 0, 0, 0, 2863);
                yield return new lbw(25, 0, 0, 3, 25, 120, 0, 0, 1, 2, 2877);
                yield return new lbw(26, 0, 0, 1, 28, 167, 0, 0, 0, 0, 2877);
                yield return new lbw(27, 0, 1, 1, 17, 122, 0, 0, 0, 0, 2906);
                yield return new lbw(28, 0, 0, 1, 29, 150, 0, 0, 0, 2, 2920);
                yield return new lbw(29, 0, 1, 2, 26, 168, 0, 0, 0, 0, 2920);
                yield return new lbw(30, 0, 0, 2, 17, 113, 0, 0, 0, 1, 2920);
                yield return new lbw(31, 0, 0, 2, 17, 113, 0, 0, 0, 1, 2920);
                yield return new lbw(32, 0, 1, 1, 24, 90, 1, 0, 0, 1, 2948);
                yield return new lbw(33, 0, 1, 2, 35, 121, 1, 0, 0, 1, 2948);
                yield return new lbw(34, 0, 0, 1, 25, 155, 0, 0, 0, 1, 2977);
                yield return new lbw(35, 0, 0, 2, 25, 125, 0, 0, 0, 0, 2977);
                yield return new lbw(36, 0, 1, 1, 29, 140, 0, 0, 0, 2, 2977);
                yield return new lbw(37, 0, 1, 1, 19, 138, 0, 0, 0, 2, 2977);
                yield return new lbw(38, 0, 1, 1, 27, 124, 0, 0, 0, 0, 2922);
                yield return new lbw(39, 0, 1, 1, 31, 215, 0, 0, 0, 2, 3005);
                yield return new lbw(40, 0, 1, 1, 33, 109, 0, 0, 0, 1, 3033);
                yield return new lbw(41, 0, 1, 2, 21, 185, 0, 0, 0, 2, 3042);
                yield return new lbw(42, 0, 0, 1, 19, 189, 0, 0, 0, 2, 3062);
                yield return new lbw(43, 0, 0, 2, 23, 130, 0, 0, 0, 1, 3062);
                yield return new lbw(44, 0, 0, 1, 21, 160, 0, 0, 0, 0, 3062);
                yield return new lbw(45, 0, 1, 1, 18, 90, 0, 0, 1, 0, 3076);
                yield return new lbw(46, 0, 1, 1, 18, 90, 0, 0, 1, 0, 3076);
                yield return new lbw(47, 0, 0, 1, 32, 132, 0, 0, 0, 4, 3080);
                yield return new lbw(48, 0, 0, 3, 19, 132, 0, 0, 0, 0, 3090);
                yield return new lbw(49, 0, 0, 1, 24, 115, 0, 0, 0, 2, 3090);
                yield return new lbw(50, 0, 1, 3, 22, 85, 0, 0, 0, 0, 3090);
                yield return new lbw(51, 0, 0, 1, 22, 120, 0, 1, 0, 1, 3100);
                yield return new lbw(52, 0, 0, 3, 23, 128, 0, 0, 0, 0, 3104);
                yield return new lbw(53, 0, 1, 1, 22, 130, 0, 0, 0, 0, 3132);
                yield return new lbw(54, 0, 1, 1, 30, 95, 0, 0, 0, 2, 3147);
                yield return new lbw(55, 0, 0, 3, 19, 115, 0, 0, 0, 0, 3175);
                yield return new lbw(56, 0, 0, 3, 16, 110, 0, 0, 0, 0, 3175);
                yield return new lbw(57, 0, 1, 3, 21, 110, 0, 0, 1, 0, 3203);
                yield return new lbw(58, 0, 0, 3, 30, 153, 0, 0, 0, 0, 3203);
                yield return new lbw(59, 0, 0, 3, 20, 103, 0, 0, 0, 0, 3203);
                yield return new lbw(60, 0, 0, 3, 17, 119, 0, 0, 0, 0, 3225);
                yield return new lbw(61, 0, 0, 3, 17, 119, 0, 0, 0, 0, 3225);
                yield return new lbw(62, 0, 0, 3, 23, 119, 0, 0, 0, 2, 3232);
                yield return new lbw(63, 0, 0, 3, 24, 110, 0, 0, 0, 0, 3232);
                yield return new lbw(64, 0, 0, 1, 28, 140, 0, 0, 0, 0, 3234);
                yield return new lbw(65, 0, 1, 3, 26, 133, 2, 0, 0, 0, 3260);
                yield return new lbw(66, 0, 0, 3, 20, 169, 1, 0, 1, 1, 3274);
                yield return new lbw(67, 0, 0, 3, 24, 115, 0, 0, 0, 2, 3274);
                yield return new lbw(68, 0, 1, 3, 28, 250, 0, 0, 0, 6, 3303);
                yield return new lbw(69, 0, 0, 1, 20, 141, 2, 0, 1, 1, 3317);
                yield return new lbw(70, 0, 0, 2, 22, 158, 1, 0, 0, 2, 3317);
                yield return new lbw(71, 0, 1, 1, 22, 112, 2, 0, 0, 0, 3317);
                yield return new lbw(72, 0, 1, 3, 31, 150, 0, 0, 0, 2, 3321);
                yield return new lbw(73, 0, 1, 3, 23, 115, 0, 0, 0, 1, 3331);
                yield return new lbw(74, 0, 0, 2, 16, 112, 0, 0, 0, 0, 3374);
                yield return new lbw(75, 0, 1, 1, 16, 135, 0, 0, 0, 0, 3374);
                yield return new lbw(76, 0, 0, 2, 18, 229, 0, 0, 0, 0, 3402);
                yield return new lbw(77, 0, 0, 1, 25, 140, 0, 0, 0, 1, 3416);
                yield return new lbw(78, 0, 1, 1, 32, 134, 1, 0, 0, 4, 3430);
                yield return new lbw(79, 0, 1, 2, 20, 121, 0, 0, 0, 0, 3444);
                yield return new lbw(80, 0, 0, 1, 23, 190, 0, 0, 0, 0, 3459);
                yield return new lbw(81, 0, 0, 1, 22, 131, 0, 0, 0, 1, 3460);
                yield return new lbw(82, 0, 0, 1, 32, 170, 0, 0, 0, 0, 3473);
                yield return new lbw(83, 0, 0, 3, 30, 110, 0, 0, 0, 0, 3475);
                yield return new lbw(84, 0, 0, 3, 20, 127, 0, 0, 0, 0, 3487);
                yield return new lbw(85, 0, 0, 3, 23, 123, 0, 0, 0, 0, 3544);
                yield return new lbw(86, 0, 1, 3, 17, 120, 0, 0, 0, 0, 3572);
                yield return new lbw(87, 0, 0, 3, 19, 105, 0, 0, 0, 0, 3572);
                yield return new lbw(88, 0, 0, 1, 23, 130, 0, 0, 0, 0, 3586);
                yield return new lbw(89, 0, 0, 1, 36, 175, 0, 0, 0, 0, 3600);
                yield return new lbw(90, 0, 0, 1, 22, 125, 0, 0, 0, 1, 3614);
                yield return new lbw(91, 0, 0, 1, 24, 133, 0, 0, 0, 0, 3614);
                yield return new lbw(92, 0, 0, 3, 21, 134, 0, 0, 0, 2, 3629);
                yield return new lbw(93, 0, 1, 1, 19, 235, 0, 1, 0, 0, 3629);
                yield return new lbw(94, 0, 1, 1, 25, 95, 3, 0, 1, 0, 3637);
                yield return new lbw(95, 0, 1, 1, 16, 135, 0, 0, 0, 0, 3643);
                yield return new lbw(96, 0, 0, 1, 29, 135, 0, 0, 0, 1, 3651);
                yield return new lbw(97, 0, 0, 1, 29, 154, 0, 0, 0, 1, 3651);
                yield return new lbw(98, 0, 1, 1, 19, 147, 0, 0, 0, 0, 3651);
                yield return new lbw(99, 0, 1, 1, 19, 147, 0, 0, 0, 0, 3651);
                yield return new lbw(100, 0, 0, 1, 30, 137, 0, 0, 0, 1, 3699);
                yield return new lbw(101, 0, 0, 1, 24, 110, 0, 0, 0, 1, 3728);
                yield return new lbw(102, 0, 1, 1, 19, 184, 0, 1, 0, 0, 3756);
                yield return new lbw(103, 0, 0, 3, 24, 110, 1, 0, 0, 0, 3770);
                yield return new lbw(104, 0, 0, 1, 23, 110, 0, 0, 0, 1, 3770);
                yield return new lbw(105, 0, 0, 3, 20, 120, 0, 0, 0, 0, 3770);
                yield return new lbw(106, 0, 0, 2, 25, 241, 0, 1, 0, 0, 3790);
                yield return new lbw(107, 0, 0, 1, 30, 112, 0, 0, 0, 1, 3799);
                yield return new lbw(108, 0, 0, 1, 22, 169, 0, 0, 0, 0, 3827);
                yield return new lbw(109, 0, 1, 1, 18, 120, 0, 0, 0, 2, 3856);
                yield return new lbw(110, 0, 0, 2, 16, 170, 0, 0, 0, 4, 3860);
                yield return new lbw(111, 0, 0, 1, 32, 186, 0, 0, 0, 2, 3860);
                yield return new lbw(112, 0, 0, 3, 18, 120, 0, 0, 0, 1, 3884);
                yield return new lbw(113, 0, 1, 1, 29, 130, 0, 0, 0, 2, 3884);
                yield return new lbw(114, 0, 0, 1, 33, 117, 0, 0, 1, 1, 3912);
                yield return new lbw(115, 0, 1, 1, 20, 170, 0, 0, 0, 0, 3940);
                yield return new lbw(116, 0, 0, 3, 28, 134, 0, 0, 0, 1, 3941);
                yield return new lbw(117, 0, 0, 1, 14, 135, 0, 0, 0, 0, 3941);
                yield return new lbw(118, 0, 0, 3, 28, 130, 0, 0, 0, 0, 3969);
                yield return new lbw(119, 0, 0, 1, 25, 120, 0, 0, 0, 2, 3983);
                yield return new lbw(120, 0, 0, 3, 16, 95, 0, 0, 0, 1, 3997);
                yield return new lbw(121, 0, 0, 1, 20, 158, 0, 0, 0, 1, 3997);
                yield return new lbw(122, 0, 0, 3, 26, 160, 0, 0, 0, 0, 4054);
                yield return new lbw(123, 0, 0, 1, 21, 115, 0, 0, 0, 1, 4054);
                yield return new lbw(124, 0, 0, 1, 22, 129, 0, 0, 0, 0, 4111);
                yield return new lbw(125, 0, 0, 1, 25, 130, 0, 0, 0, 2, 4153);
                yield return new lbw(126, 0, 0, 1, 31, 120, 0, 0, 0, 2, 4167);
                yield return new lbw(127, 0, 0, 1, 35, 170, 1, 0, 0, 1, 4174);
                yield return new lbw(128, 0, 1, 1, 19, 120, 0, 0, 0, 0, 4238);
                yield return new lbw(129, 0, 0, 1, 24, 116, 0, 0, 0, 1, 4593);
                yield return new lbw(130, 0, 0, 1, 45, 123, 0, 0, 0, 1, 4990);
                yield return new lbw(131, 1, 1, 3, 28, 120, 1, 0, 1, 0, 709);
                yield return new lbw(132, 1, 0, 1, 29, 130, 0, 0, 1, 2, 1021);
                yield return new lbw(133, 1, 1, 2, 34, 187, 0, 1, 0, 0, 1135);
                yield return new lbw(134, 1, 0, 3, 25, 105, 1, 1, 0, 0, 1330);
                yield return new lbw(135, 1, 0, 3, 25, 85, 0, 0, 1, 0, 1474);
                yield return new lbw(136, 1, 0, 3, 27, 150, 0, 0, 0, 0, 1588);
                yield return new lbw(137, 1, 0, 3, 23, 97, 0, 0, 1, 1, 1588);
                yield return new lbw(138, 1, 0, 2, 24, 128, 1, 0, 0, 1, 1701);
                yield return new lbw(139, 1, 0, 3, 24, 132, 0, 1, 0, 0, 1729);
                yield return new lbw(140, 1, 1, 1, 21, 165, 0, 1, 0, 1, 1790);
                yield return new lbw(141, 1, 1, 1, 32, 105, 0, 0, 0, 0, 1818);
                yield return new lbw(142, 1, 1, 1, 19, 91, 2, 0, 1, 0, 1885);
                yield return new lbw(143, 1, 0, 3, 25, 115, 0, 0, 0, 0, 1893);
                yield return new lbw(144, 1, 0, 3, 16, 130, 0, 0, 0, 1, 1899);
                yield return new lbw(145, 1, 1, 1, 25, 92, 0, 0, 0, 0, 1928);
                yield return new lbw(146, 1, 1, 1, 20, 150, 0, 0, 0, 2, 1928);
                yield return new lbw(147, 1, 0, 2, 21, 200, 0, 0, 1, 2, 1928);
                yield return new lbw(148, 1, 1, 1, 24, 155, 1, 0, 0, 0, 1936);
                yield return new lbw(149, 1, 0, 3, 21, 103, 0, 0, 0, 0, 1970);
                yield return new lbw(150, 1, 0, 3, 20, 125, 0, 0, 1, 0, 2055);
                yield return new lbw(151, 1, 0, 3, 25, 89, 2, 0, 0, 1, 2055);
                yield return new lbw(152, 1, 0, 1, 19, 102, 0, 0, 0, 2, 2082);
                yield return new lbw(153, 1, 1, 1, 19, 112, 0, 0, 1, 0, 2084);
                yield return new lbw(154, 1, 1, 1, 26, 117, 1, 0, 0, 0, 2084);
                yield return new lbw(155, 1, 0, 1, 24, 138, 0, 0, 0, 0, 2100);
                yield return new lbw(156, 1, 1, 3, 17, 130, 1, 0, 1, 0, 2125);
                yield return new lbw(157, 1, 1, 2, 20, 120, 0, 0, 0, 3, 2126);
                yield return new lbw(158, 1, 1, 1, 22, 130, 1, 0, 1, 1, 2187);
                yield return new lbw(159, 1, 0, 2, 27, 130, 0, 0, 1, 0, 2187);
                yield return new lbw(160, 1, 1, 3, 20, 80, 0, 0, 1, 0, 2211);
                yield return new lbw(161, 1, 1, 1, 17, 110, 0, 0, 0, 0, 2225);
                yield return new lbw(162, 1, 0, 3, 25, 105, 1, 0, 0, 1, 2240);
                yield return new lbw(163, 1, 0, 3, 20, 109, 0, 0, 0, 0, 2240);
                yield return new lbw(164, 1, 0, 3, 18, 148, 0, 0, 0, 0, 2282);
                yield return new lbw(165, 1, 1, 2, 18, 110, 1, 0, 0, 0, 2296);
                yield return new lbw(166, 1, 1, 1, 20, 121, 1, 0, 1, 0, 2296);
                yield return new lbw(167, 1, 0, 3, 21, 100, 1, 0, 0, 4, 2301);
                yield return new lbw(168, 1, 0, 3, 26, 96, 0, 0, 0, 0, 2325);
                yield return new lbw(169, 1, 1, 1, 31, 102, 1, 0, 0, 1, 2353);
                yield return new lbw(170, 1, 0, 1, 15, 110, 0, 0, 0, 0, 2353);
                yield return new lbw(171, 1, 1, 2, 23, 187, 0, 0, 0, 1, 2367);
                yield return new lbw(172, 1, 1, 2, 20, 122, 0, 0, 0, 0, 2381);
                yield return new lbw(173, 1, 1, 2, 24, 105, 0, 0, 0, 0, 2381);
                yield return new lbw(174, 1, 0, 3, 15, 115, 0, 0, 1, 0, 2381);
                yield return new lbw(175, 1, 0, 3, 23, 120, 0, 0, 0, 0, 2395);
                yield return new lbw(176, 1, 1, 1, 30, 142, 1, 0, 0, 0, 2410);
                yield return new lbw(177, 1, 1, 1, 22, 130, 0, 0, 0, 1, 2410);
                yield return new lbw(178, 1, 1, 1, 17, 120, 0, 0, 0, 3, 2414);
                yield return new lbw(179, 1, 1, 1, 23, 110, 1, 0, 0, 0, 2424);
                yield return new lbw(180, 1, 0, 2, 17, 120, 0, 0, 0, 2, 2438);
                yield return new lbw(181, 1, 0, 3, 26, 154, 1, 1, 0, 1, 2442);
                yield return new lbw(182, 1, 0, 3, 20, 106, 0, 0, 0, 3, 2450);
                yield return new lbw(183, 1, 1, 1, 26, 190, 0, 0, 0, 0, 2466);
                yield return new lbw(184, 1, 1, 3, 14, 101, 1, 0, 0, 0, 2466);
                yield return new lbw(185, 1, 1, 1, 28, 95, 0, 0, 0, 2, 2466);
                yield return new lbw(186, 1, 0, 3, 14, 100, 0, 0, 0, 2, 2495);
                yield return new lbw(187, 1, 1, 3, 23, 94, 0, 0, 0, 0, 2495);
                yield return new lbw(188, 1, 0, 2, 17, 142, 0, 1, 0, 0, 2495);
                yield return new lbw(189, 1, 1, 1, 21, 130, 0, 1, 0, 3, 2495);
            }
        }
    }
}
