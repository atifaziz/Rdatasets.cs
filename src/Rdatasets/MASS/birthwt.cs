// ReSharper disable All

namespace Rdatasets.MASS
{
    using System.Collections.Generic;

    /// <summary>
    /// Risk Factors Associated with Low Infant Birth Weight
    /// </summary>

    public class birthwt
    {
        public readonly int κ;
        public readonly int low;
        public readonly int age;
        public readonly int lwt;
        public readonly int race;
        public readonly int smoke;
        public readonly int ptl;
        public readonly int ht;
        public readonly int ui;
        public readonly int ftv;
        public readonly int bwt;

        public birthwt(int κ, int low, int age, int lwt, int race, int smoke, int ptl, int ht, int ui, int ftv, int bwt)
        {
            this.κ = κ;
            this.low = low;
            this.age = age;
            this.lwt = lwt;
            this.race = race;
            this.smoke = smoke;
            this.ptl = ptl;
            this.ht = ht;
            this.ui = ui;
            this.ftv = ftv;
            this.bwt = bwt;
        }

        public static IEnumerable<birthwt> Data
        {
            get
            {
                yield return new birthwt(85, 0, 19, 182, 2, 0, 0, 0, 1, 0, 2523);
                yield return new birthwt(86, 0, 33, 155, 3, 0, 0, 0, 0, 3, 2551);
                yield return new birthwt(87, 0, 20, 105, 1, 1, 0, 0, 0, 1, 2557);
                yield return new birthwt(88, 0, 21, 108, 1, 1, 0, 0, 1, 2, 2594);
                yield return new birthwt(89, 0, 18, 107, 1, 1, 0, 0, 1, 0, 2600);
                yield return new birthwt(91, 0, 21, 124, 3, 0, 0, 0, 0, 0, 2622);
                yield return new birthwt(92, 0, 22, 118, 1, 0, 0, 0, 0, 1, 2637);
                yield return new birthwt(93, 0, 17, 103, 3, 0, 0, 0, 0, 1, 2637);
                yield return new birthwt(94, 0, 29, 123, 1, 1, 0, 0, 0, 1, 2663);
                yield return new birthwt(95, 0, 26, 113, 1, 1, 0, 0, 0, 0, 2665);
                yield return new birthwt(96, 0, 19, 95, 3, 0, 0, 0, 0, 0, 2722);
                yield return new birthwt(97, 0, 19, 150, 3, 0, 0, 0, 0, 1, 2733);
                yield return new birthwt(98, 0, 22, 95, 3, 0, 0, 1, 0, 0, 2751);
                yield return new birthwt(99, 0, 30, 107, 3, 0, 1, 0, 1, 2, 2750);
                yield return new birthwt(100, 0, 18, 100, 1, 1, 0, 0, 0, 0, 2769);
                yield return new birthwt(101, 0, 18, 100, 1, 1, 0, 0, 0, 0, 2769);
                yield return new birthwt(102, 0, 15, 98, 2, 0, 0, 0, 0, 0, 2778);
                yield return new birthwt(103, 0, 25, 118, 1, 1, 0, 0, 0, 3, 2782);
                yield return new birthwt(104, 0, 20, 120, 3, 0, 0, 0, 1, 0, 2807);
                yield return new birthwt(105, 0, 28, 120, 1, 1, 0, 0, 0, 1, 2821);
                yield return new birthwt(106, 0, 32, 121, 3, 0, 0, 0, 0, 2, 2835);
                yield return new birthwt(107, 0, 31, 100, 1, 0, 0, 0, 1, 3, 2835);
                yield return new birthwt(108, 0, 36, 202, 1, 0, 0, 0, 0, 1, 2836);
                yield return new birthwt(109, 0, 28, 120, 3, 0, 0, 0, 0, 0, 2863);
                yield return new birthwt(111, 0, 25, 120, 3, 0, 0, 0, 1, 2, 2877);
                yield return new birthwt(112, 0, 28, 167, 1, 0, 0, 0, 0, 0, 2877);
                yield return new birthwt(113, 0, 17, 122, 1, 1, 0, 0, 0, 0, 2906);
                yield return new birthwt(114, 0, 29, 150, 1, 0, 0, 0, 0, 2, 2920);
                yield return new birthwt(115, 0, 26, 168, 2, 1, 0, 0, 0, 0, 2920);
                yield return new birthwt(116, 0, 17, 113, 2, 0, 0, 0, 0, 1, 2920);
                yield return new birthwt(117, 0, 17, 113, 2, 0, 0, 0, 0, 1, 2920);
                yield return new birthwt(118, 0, 24, 90, 1, 1, 1, 0, 0, 1, 2948);
                yield return new birthwt(119, 0, 35, 121, 2, 1, 1, 0, 0, 1, 2948);
                yield return new birthwt(120, 0, 25, 155, 1, 0, 0, 0, 0, 1, 2977);
                yield return new birthwt(121, 0, 25, 125, 2, 0, 0, 0, 0, 0, 2977);
                yield return new birthwt(123, 0, 29, 140, 1, 1, 0, 0, 0, 2, 2977);
                yield return new birthwt(124, 0, 19, 138, 1, 1, 0, 0, 0, 2, 2977);
                yield return new birthwt(125, 0, 27, 124, 1, 1, 0, 0, 0, 0, 2922);
                yield return new birthwt(126, 0, 31, 215, 1, 1, 0, 0, 0, 2, 3005);
                yield return new birthwt(127, 0, 33, 109, 1, 1, 0, 0, 0, 1, 3033);
                yield return new birthwt(128, 0, 21, 185, 2, 1, 0, 0, 0, 2, 3042);
                yield return new birthwt(129, 0, 19, 189, 1, 0, 0, 0, 0, 2, 3062);
                yield return new birthwt(130, 0, 23, 130, 2, 0, 0, 0, 0, 1, 3062);
                yield return new birthwt(131, 0, 21, 160, 1, 0, 0, 0, 0, 0, 3062);
                yield return new birthwt(132, 0, 18, 90, 1, 1, 0, 0, 1, 0, 3062);
                yield return new birthwt(133, 0, 18, 90, 1, 1, 0, 0, 1, 0, 3062);
                yield return new birthwt(134, 0, 32, 132, 1, 0, 0, 0, 0, 4, 3080);
                yield return new birthwt(135, 0, 19, 132, 3, 0, 0, 0, 0, 0, 3090);
                yield return new birthwt(136, 0, 24, 115, 1, 0, 0, 0, 0, 2, 3090);
                yield return new birthwt(137, 0, 22, 85, 3, 1, 0, 0, 0, 0, 3090);
                yield return new birthwt(138, 0, 22, 120, 1, 0, 0, 1, 0, 1, 3100);
                yield return new birthwt(139, 0, 23, 128, 3, 0, 0, 0, 0, 0, 3104);
                yield return new birthwt(140, 0, 22, 130, 1, 1, 0, 0, 0, 0, 3132);
                yield return new birthwt(141, 0, 30, 95, 1, 1, 0, 0, 0, 2, 3147);
                yield return new birthwt(142, 0, 19, 115, 3, 0, 0, 0, 0, 0, 3175);
                yield return new birthwt(143, 0, 16, 110, 3, 0, 0, 0, 0, 0, 3175);
                yield return new birthwt(144, 0, 21, 110, 3, 1, 0, 0, 1, 0, 3203);
                yield return new birthwt(145, 0, 30, 153, 3, 0, 0, 0, 0, 0, 3203);
                yield return new birthwt(146, 0, 20, 103, 3, 0, 0, 0, 0, 0, 3203);
                yield return new birthwt(147, 0, 17, 119, 3, 0, 0, 0, 0, 0, 3225);
                yield return new birthwt(148, 0, 17, 119, 3, 0, 0, 0, 0, 0, 3225);
                yield return new birthwt(149, 0, 23, 119, 3, 0, 0, 0, 0, 2, 3232);
                yield return new birthwt(150, 0, 24, 110, 3, 0, 0, 0, 0, 0, 3232);
                yield return new birthwt(151, 0, 28, 140, 1, 0, 0, 0, 0, 0, 3234);
                yield return new birthwt(154, 0, 26, 133, 3, 1, 2, 0, 0, 0, 3260);
                yield return new birthwt(155, 0, 20, 169, 3, 0, 1, 0, 1, 1, 3274);
                yield return new birthwt(156, 0, 24, 115, 3, 0, 0, 0, 0, 2, 3274);
                yield return new birthwt(159, 0, 28, 250, 3, 1, 0, 0, 0, 6, 3303);
                yield return new birthwt(160, 0, 20, 141, 1, 0, 2, 0, 1, 1, 3317);
                yield return new birthwt(161, 0, 22, 158, 2, 0, 1, 0, 0, 2, 3317);
                yield return new birthwt(162, 0, 22, 112, 1, 1, 2, 0, 0, 0, 3317);
                yield return new birthwt(163, 0, 31, 150, 3, 1, 0, 0, 0, 2, 3321);
                yield return new birthwt(164, 0, 23, 115, 3, 1, 0, 0, 0, 1, 3331);
                yield return new birthwt(166, 0, 16, 112, 2, 0, 0, 0, 0, 0, 3374);
                yield return new birthwt(167, 0, 16, 135, 1, 1, 0, 0, 0, 0, 3374);
                yield return new birthwt(168, 0, 18, 229, 2, 0, 0, 0, 0, 0, 3402);
                yield return new birthwt(169, 0, 25, 140, 1, 0, 0, 0, 0, 1, 3416);
                yield return new birthwt(170, 0, 32, 134, 1, 1, 1, 0, 0, 4, 3430);
                yield return new birthwt(172, 0, 20, 121, 2, 1, 0, 0, 0, 0, 3444);
                yield return new birthwt(173, 0, 23, 190, 1, 0, 0, 0, 0, 0, 3459);
                yield return new birthwt(174, 0, 22, 131, 1, 0, 0, 0, 0, 1, 3460);
                yield return new birthwt(175, 0, 32, 170, 1, 0, 0, 0, 0, 0, 3473);
                yield return new birthwt(176, 0, 30, 110, 3, 0, 0, 0, 0, 0, 3544);
                yield return new birthwt(177, 0, 20, 127, 3, 0, 0, 0, 0, 0, 3487);
                yield return new birthwt(179, 0, 23, 123, 3, 0, 0, 0, 0, 0, 3544);
                yield return new birthwt(180, 0, 17, 120, 3, 1, 0, 0, 0, 0, 3572);
                yield return new birthwt(181, 0, 19, 105, 3, 0, 0, 0, 0, 0, 3572);
                yield return new birthwt(182, 0, 23, 130, 1, 0, 0, 0, 0, 0, 3586);
                yield return new birthwt(183, 0, 36, 175, 1, 0, 0, 0, 0, 0, 3600);
                yield return new birthwt(184, 0, 22, 125, 1, 0, 0, 0, 0, 1, 3614);
                yield return new birthwt(185, 0, 24, 133, 1, 0, 0, 0, 0, 0, 3614);
                yield return new birthwt(186, 0, 21, 134, 3, 0, 0, 0, 0, 2, 3629);
                yield return new birthwt(187, 0, 19, 235, 1, 1, 0, 1, 0, 0, 3629);
                yield return new birthwt(188, 0, 25, 95, 1, 1, 3, 0, 1, 0, 3637);
                yield return new birthwt(189, 0, 16, 135, 1, 1, 0, 0, 0, 0, 3643);
                yield return new birthwt(190, 0, 29, 135, 1, 0, 0, 0, 0, 1, 3651);
                yield return new birthwt(191, 0, 29, 154, 1, 0, 0, 0, 0, 1, 3651);
                yield return new birthwt(192, 0, 19, 147, 1, 1, 0, 0, 0, 0, 3651);
                yield return new birthwt(193, 0, 19, 147, 1, 1, 0, 0, 0, 0, 3651);
                yield return new birthwt(195, 0, 30, 137, 1, 0, 0, 0, 0, 1, 3699);
                yield return new birthwt(196, 0, 24, 110, 1, 0, 0, 0, 0, 1, 3728);
                yield return new birthwt(197, 0, 19, 184, 1, 1, 0, 1, 0, 0, 3756);
                yield return new birthwt(199, 0, 24, 110, 3, 0, 1, 0, 0, 0, 3770);
                yield return new birthwt(200, 0, 23, 110, 1, 0, 0, 0, 0, 1, 3770);
                yield return new birthwt(201, 0, 20, 120, 3, 0, 0, 0, 0, 0, 3770);
                yield return new birthwt(202, 0, 25, 241, 2, 0, 0, 1, 0, 0, 3790);
                yield return new birthwt(203, 0, 30, 112, 1, 0, 0, 0, 0, 1, 3799);
                yield return new birthwt(204, 0, 22, 169, 1, 0, 0, 0, 0, 0, 3827);
                yield return new birthwt(205, 0, 18, 120, 1, 1, 0, 0, 0, 2, 3856);
                yield return new birthwt(206, 0, 16, 170, 2, 0, 0, 0, 0, 4, 3860);
                yield return new birthwt(207, 0, 32, 186, 1, 0, 0, 0, 0, 2, 3860);
                yield return new birthwt(208, 0, 18, 120, 3, 0, 0, 0, 0, 1, 3884);
                yield return new birthwt(209, 0, 29, 130, 1, 1, 0, 0, 0, 2, 3884);
                yield return new birthwt(210, 0, 33, 117, 1, 0, 0, 0, 1, 1, 3912);
                yield return new birthwt(211, 0, 20, 170, 1, 1, 0, 0, 0, 0, 3940);
                yield return new birthwt(212, 0, 28, 134, 3, 0, 0, 0, 0, 1, 3941);
                yield return new birthwt(213, 0, 14, 135, 1, 0, 0, 0, 0, 0, 3941);
                yield return new birthwt(214, 0, 28, 130, 3, 0, 0, 0, 0, 0, 3969);
                yield return new birthwt(215, 0, 25, 120, 1, 0, 0, 0, 0, 2, 3983);
                yield return new birthwt(216, 0, 16, 95, 3, 0, 0, 0, 0, 1, 3997);
                yield return new birthwt(217, 0, 20, 158, 1, 0, 0, 0, 0, 1, 3997);
                yield return new birthwt(218, 0, 26, 160, 3, 0, 0, 0, 0, 0, 4054);
                yield return new birthwt(219, 0, 21, 115, 1, 0, 0, 0, 0, 1, 4054);
                yield return new birthwt(220, 0, 22, 129, 1, 0, 0, 0, 0, 0, 4111);
                yield return new birthwt(221, 0, 25, 130, 1, 0, 0, 0, 0, 2, 4153);
                yield return new birthwt(222, 0, 31, 120, 1, 0, 0, 0, 0, 2, 4167);
                yield return new birthwt(223, 0, 35, 170, 1, 0, 1, 0, 0, 1, 4174);
                yield return new birthwt(224, 0, 19, 120, 1, 1, 0, 0, 0, 0, 4238);
                yield return new birthwt(225, 0, 24, 116, 1, 0, 0, 0, 0, 1, 4593);
                yield return new birthwt(226, 0, 45, 123, 1, 0, 0, 0, 0, 1, 4990);
                yield return new birthwt(4, 1, 28, 120, 3, 1, 1, 0, 1, 0, 709);
                yield return new birthwt(10, 1, 29, 130, 1, 0, 0, 0, 1, 2, 1021);
                yield return new birthwt(11, 1, 34, 187, 2, 1, 0, 1, 0, 0, 1135);
                yield return new birthwt(13, 1, 25, 105, 3, 0, 1, 1, 0, 0, 1330);
                yield return new birthwt(15, 1, 25, 85, 3, 0, 0, 0, 1, 0, 1474);
                yield return new birthwt(16, 1, 27, 150, 3, 0, 0, 0, 0, 0, 1588);
                yield return new birthwt(17, 1, 23, 97, 3, 0, 0, 0, 1, 1, 1588);
                yield return new birthwt(18, 1, 24, 128, 2, 0, 1, 0, 0, 1, 1701);
                yield return new birthwt(19, 1, 24, 132, 3, 0, 0, 1, 0, 0, 1729);
                yield return new birthwt(20, 1, 21, 165, 1, 1, 0, 1, 0, 1, 1790);
                yield return new birthwt(22, 1, 32, 105, 1, 1, 0, 0, 0, 0, 1818);
                yield return new birthwt(23, 1, 19, 91, 1, 1, 2, 0, 1, 0, 1885);
                yield return new birthwt(24, 1, 25, 115, 3, 0, 0, 0, 0, 0, 1893);
                yield return new birthwt(25, 1, 16, 130, 3, 0, 0, 0, 0, 1, 1899);
                yield return new birthwt(26, 1, 25, 92, 1, 1, 0, 0, 0, 0, 1928);
                yield return new birthwt(27, 1, 20, 150, 1, 1, 0, 0, 0, 2, 1928);
                yield return new birthwt(28, 1, 21, 200, 2, 0, 0, 0, 1, 2, 1928);
                yield return new birthwt(29, 1, 24, 155, 1, 1, 1, 0, 0, 0, 1936);
                yield return new birthwt(30, 1, 21, 103, 3, 0, 0, 0, 0, 0, 1970);
                yield return new birthwt(31, 1, 20, 125, 3, 0, 0, 0, 1, 0, 2055);
                yield return new birthwt(32, 1, 25, 89, 3, 0, 2, 0, 0, 1, 2055);
                yield return new birthwt(33, 1, 19, 102, 1, 0, 0, 0, 0, 2, 2082);
                yield return new birthwt(34, 1, 19, 112, 1, 1, 0, 0, 1, 0, 2084);
                yield return new birthwt(35, 1, 26, 117, 1, 1, 1, 0, 0, 0, 2084);
                yield return new birthwt(36, 1, 24, 138, 1, 0, 0, 0, 0, 0, 2100);
                yield return new birthwt(37, 1, 17, 130, 3, 1, 1, 0, 1, 0, 2125);
                yield return new birthwt(40, 1, 20, 120, 2, 1, 0, 0, 0, 3, 2126);
                yield return new birthwt(42, 1, 22, 130, 1, 1, 1, 0, 1, 1, 2187);
                yield return new birthwt(43, 1, 27, 130, 2, 0, 0, 0, 1, 0, 2187);
                yield return new birthwt(44, 1, 20, 80, 3, 1, 0, 0, 1, 0, 2211);
                yield return new birthwt(45, 1, 17, 110, 1, 1, 0, 0, 0, 0, 2225);
                yield return new birthwt(46, 1, 25, 105, 3, 0, 1, 0, 0, 1, 2240);
                yield return new birthwt(47, 1, 20, 109, 3, 0, 0, 0, 0, 0, 2240);
                yield return new birthwt(49, 1, 18, 148, 3, 0, 0, 0, 0, 0, 2282);
                yield return new birthwt(50, 1, 18, 110, 2, 1, 1, 0, 0, 0, 2296);
                yield return new birthwt(51, 1, 20, 121, 1, 1, 1, 0, 1, 0, 2296);
                yield return new birthwt(52, 1, 21, 100, 3, 0, 1, 0, 0, 4, 2301);
                yield return new birthwt(54, 1, 26, 96, 3, 0, 0, 0, 0, 0, 2325);
                yield return new birthwt(56, 1, 31, 102, 1, 1, 1, 0, 0, 1, 2353);
                yield return new birthwt(57, 1, 15, 110, 1, 0, 0, 0, 0, 0, 2353);
                yield return new birthwt(59, 1, 23, 187, 2, 1, 0, 0, 0, 1, 2367);
                yield return new birthwt(60, 1, 20, 122, 2, 1, 0, 0, 0, 0, 2381);
                yield return new birthwt(61, 1, 24, 105, 2, 1, 0, 0, 0, 0, 2381);
                yield return new birthwt(62, 1, 15, 115, 3, 0, 0, 0, 1, 0, 2381);
                yield return new birthwt(63, 1, 23, 120, 3, 0, 0, 0, 0, 0, 2410);
                yield return new birthwt(65, 1, 30, 142, 1, 1, 1, 0, 0, 0, 2410);
                yield return new birthwt(67, 1, 22, 130, 1, 1, 0, 0, 0, 1, 2410);
                yield return new birthwt(68, 1, 17, 120, 1, 1, 0, 0, 0, 3, 2414);
                yield return new birthwt(69, 1, 23, 110, 1, 1, 1, 0, 0, 0, 2424);
                yield return new birthwt(71, 1, 17, 120, 2, 0, 0, 0, 0, 2, 2438);
                yield return new birthwt(75, 1, 26, 154, 3, 0, 1, 1, 0, 1, 2442);
                yield return new birthwt(76, 1, 20, 105, 3, 0, 0, 0, 0, 3, 2450);
                yield return new birthwt(77, 1, 26, 190, 1, 1, 0, 0, 0, 0, 2466);
                yield return new birthwt(78, 1, 14, 101, 3, 1, 1, 0, 0, 0, 2466);
                yield return new birthwt(79, 1, 28, 95, 1, 1, 0, 0, 0, 2, 2466);
                yield return new birthwt(81, 1, 14, 100, 3, 0, 0, 0, 0, 2, 2495);
                yield return new birthwt(82, 1, 23, 94, 3, 1, 0, 0, 0, 0, 2495);
                yield return new birthwt(83, 1, 17, 142, 2, 0, 0, 1, 0, 0, 2495);
                yield return new birthwt(84, 1, 21, 130, 1, 1, 0, 1, 0, 3, 2495);
            }
        }
    }
}
