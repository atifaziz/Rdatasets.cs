// ReSharper disable All

namespace Rdatasets.lme4
{
    using System.Collections.Generic;

    /// <summary>
    /// Reaction times in a sleep deprivation study
    /// </summary>

    public class sleepstudy
    {
        public readonly double Reaction;
        public readonly int Days;
        public readonly int Subject;

        public sleepstudy(double Reaction, int Days, int Subject)
        {
            this.Reaction = Reaction;
            this.Days = Days;
            this.Subject = Subject;
        }

        public static IEnumerable<sleepstudy> Data
        {
            get
            {
                yield return new sleepstudy(249.56, 0, 308);
                yield return new sleepstudy(258.7047, 1, 308);
                yield return new sleepstudy(250.8006, 2, 308);
                yield return new sleepstudy(321.4398, 3, 308);
                yield return new sleepstudy(356.8519, 4, 308);
                yield return new sleepstudy(414.6901, 5, 308);
                yield return new sleepstudy(382.2038, 6, 308);
                yield return new sleepstudy(290.1486, 7, 308);
                yield return new sleepstudy(430.5853, 8, 308);
                yield return new sleepstudy(466.3535, 9, 308);
                yield return new sleepstudy(222.7339, 0, 309);
                yield return new sleepstudy(205.2658, 1, 309);
                yield return new sleepstudy(202.9778, 2, 309);
                yield return new sleepstudy(204.707, 3, 309);
                yield return new sleepstudy(207.7161, 4, 309);
                yield return new sleepstudy(215.9618, 5, 309);
                yield return new sleepstudy(213.6303, 6, 309);
                yield return new sleepstudy(217.7272, 7, 309);
                yield return new sleepstudy(224.2957, 8, 309);
                yield return new sleepstudy(237.3142, 9, 309);
                yield return new sleepstudy(199.0539, 0, 310);
                yield return new sleepstudy(194.3322, 1, 310);
                yield return new sleepstudy(234.32, 2, 310);
                yield return new sleepstudy(232.8416, 3, 310);
                yield return new sleepstudy(229.3074, 4, 310);
                yield return new sleepstudy(220.4579, 5, 310);
                yield return new sleepstudy(235.4208, 6, 310);
                yield return new sleepstudy(255.7511, 7, 310);
                yield return new sleepstudy(261.0125, 8, 310);
                yield return new sleepstudy(247.5153, 9, 310);
                yield return new sleepstudy(321.5426, 0, 330);
                yield return new sleepstudy(300.4002, 1, 330);
                yield return new sleepstudy(283.8565, 2, 330);
                yield return new sleepstudy(285.133, 3, 330);
                yield return new sleepstudy(285.7973, 4, 330);
                yield return new sleepstudy(297.5855, 5, 330);
                yield return new sleepstudy(280.2396, 6, 330);
                yield return new sleepstudy(318.2613, 7, 330);
                yield return new sleepstudy(305.3495, 8, 330);
                yield return new sleepstudy(354.0487, 9, 330);
                yield return new sleepstudy(287.6079, 0, 331);
                yield return new sleepstudy(285, 1, 331);
                yield return new sleepstudy(301.8206, 2, 331);
                yield return new sleepstudy(320.1153, 3, 331);
                yield return new sleepstudy(316.2773, 4, 331);
                yield return new sleepstudy(293.3187, 5, 331);
                yield return new sleepstudy(290.075, 6, 331);
                yield return new sleepstudy(334.8177, 7, 331);
                yield return new sleepstudy(293.7469, 8, 331);
                yield return new sleepstudy(371.5811, 9, 331);
                yield return new sleepstudy(234.8606, 0, 332);
                yield return new sleepstudy(242.8118, 1, 332);
                yield return new sleepstudy(272.9613, 2, 332);
                yield return new sleepstudy(309.7688, 3, 332);
                yield return new sleepstudy(317.4629, 4, 332);
                yield return new sleepstudy(309.9976, 5, 332);
                yield return new sleepstudy(454.1619, 6, 332);
                yield return new sleepstudy(346.8311, 7, 332);
                yield return new sleepstudy(330.3003, 8, 332);
                yield return new sleepstudy(253.8644, 9, 332);
                yield return new sleepstudy(283.8424, 0, 333);
                yield return new sleepstudy(289.555, 1, 333);
                yield return new sleepstudy(276.7693, 2, 333);
                yield return new sleepstudy(299.8097, 3, 333);
                yield return new sleepstudy(297.171, 4, 333);
                yield return new sleepstudy(338.1665, 5, 333);
                yield return new sleepstudy(332.0265, 6, 333);
                yield return new sleepstudy(348.8399, 7, 333);
                yield return new sleepstudy(333.36, 8, 333);
                yield return new sleepstudy(362.0428, 9, 333);
                yield return new sleepstudy(265.4731, 0, 334);
                yield return new sleepstudy(276.2012, 1, 334);
                yield return new sleepstudy(243.3647, 2, 334);
                yield return new sleepstudy(254.6723, 3, 334);
                yield return new sleepstudy(279.0244, 4, 334);
                yield return new sleepstudy(284.1912, 5, 334);
                yield return new sleepstudy(305.5248, 6, 334);
                yield return new sleepstudy(331.5229, 7, 334);
                yield return new sleepstudy(335.7469, 8, 334);
                yield return new sleepstudy(377.299, 9, 334);
                yield return new sleepstudy(241.6083, 0, 335);
                yield return new sleepstudy(273.9472, 1, 335);
                yield return new sleepstudy(254.4907, 2, 335);
                yield return new sleepstudy(270.8021, 3, 335);
                yield return new sleepstudy(251.4519, 4, 335);
                yield return new sleepstudy(254.6362, 5, 335);
                yield return new sleepstudy(245.4523, 6, 335);
                yield return new sleepstudy(235.311, 7, 335);
                yield return new sleepstudy(235.7541, 8, 335);
                yield return new sleepstudy(237.2466, 9, 335);
                yield return new sleepstudy(312.3666, 0, 337);
                yield return new sleepstudy(313.8058, 1, 337);
                yield return new sleepstudy(291.6112, 2, 337);
                yield return new sleepstudy(346.1222, 3, 337);
                yield return new sleepstudy(365.7324, 4, 337);
                yield return new sleepstudy(391.8385, 5, 337);
                yield return new sleepstudy(404.2601, 6, 337);
                yield return new sleepstudy(416.6923, 7, 337);
                yield return new sleepstudy(455.8643, 8, 337);
                yield return new sleepstudy(458.9167, 9, 337);
                yield return new sleepstudy(236.1032, 0, 349);
                yield return new sleepstudy(230.3167, 1, 349);
                yield return new sleepstudy(238.9256, 2, 349);
                yield return new sleepstudy(254.922, 3, 349);
                yield return new sleepstudy(250.7103, 4, 349);
                yield return new sleepstudy(269.7744, 5, 349);
                yield return new sleepstudy(281.5648, 6, 349);
                yield return new sleepstudy(308.102, 7, 349);
                yield return new sleepstudy(336.2806, 8, 349);
                yield return new sleepstudy(351.6451, 9, 349);
                yield return new sleepstudy(256.2968, 0, 350);
                yield return new sleepstudy(243.4543, 1, 350);
                yield return new sleepstudy(256.2046, 2, 350);
                yield return new sleepstudy(255.5271, 3, 350);
                yield return new sleepstudy(268.9165, 4, 350);
                yield return new sleepstudy(329.7247, 5, 350);
                yield return new sleepstudy(379.4445, 6, 350);
                yield return new sleepstudy(362.9184, 7, 350);
                yield return new sleepstudy(394.4872, 8, 350);
                yield return new sleepstudy(389.0527, 9, 350);
                yield return new sleepstudy(250.5265, 0, 351);
                yield return new sleepstudy(300.0576, 1, 351);
                yield return new sleepstudy(269.8939, 2, 351);
                yield return new sleepstudy(280.5891, 3, 351);
                yield return new sleepstudy(271.8274, 4, 351);
                yield return new sleepstudy(304.6336, 5, 351);
                yield return new sleepstudy(287.7466, 6, 351);
                yield return new sleepstudy(266.5955, 7, 351);
                yield return new sleepstudy(321.5418, 8, 351);
                yield return new sleepstudy(347.5655, 9, 351);
                yield return new sleepstudy(221.6771, 0, 352);
                yield return new sleepstudy(298.1939, 1, 352);
                yield return new sleepstudy(326.8785, 2, 352);
                yield return new sleepstudy(346.8555, 3, 352);
                yield return new sleepstudy(348.7402, 4, 352);
                yield return new sleepstudy(352.8287, 5, 352);
                yield return new sleepstudy(354.4266, 6, 352);
                yield return new sleepstudy(360.4326, 7, 352);
                yield return new sleepstudy(375.6406, 8, 352);
                yield return new sleepstudy(388.5417, 9, 352);
                yield return new sleepstudy(271.9235, 0, 369);
                yield return new sleepstudy(268.4369, 1, 369);
                yield return new sleepstudy(257.2424, 2, 369);
                yield return new sleepstudy(277.6566, 3, 369);
                yield return new sleepstudy(314.8222, 4, 369);
                yield return new sleepstudy(317.2135, 5, 369);
                yield return new sleepstudy(298.1353, 6, 369);
                yield return new sleepstudy(348.1229, 7, 369);
                yield return new sleepstudy(340.28, 8, 369);
                yield return new sleepstudy(366.5131, 9, 369);
                yield return new sleepstudy(225.264, 0, 370);
                yield return new sleepstudy(234.5235, 1, 370);
                yield return new sleepstudy(238.9008, 2, 370);
                yield return new sleepstudy(240.473, 3, 370);
                yield return new sleepstudy(267.5373, 4, 370);
                yield return new sleepstudy(344.1937, 5, 370);
                yield return new sleepstudy(281.1481, 6, 370);
                yield return new sleepstudy(347.5855, 7, 370);
                yield return new sleepstudy(365.163, 8, 370);
                yield return new sleepstudy(372.2288, 9, 370);
                yield return new sleepstudy(269.8804, 0, 371);
                yield return new sleepstudy(272.4428, 1, 371);
                yield return new sleepstudy(277.8989, 2, 371);
                yield return new sleepstudy(281.7895, 3, 371);
                yield return new sleepstudy(279.1705, 4, 371);
                yield return new sleepstudy(284.512, 5, 371);
                yield return new sleepstudy(259.2658, 6, 371);
                yield return new sleepstudy(304.6306, 7, 371);
                yield return new sleepstudy(350.7807, 8, 371);
                yield return new sleepstudy(369.4692, 9, 371);
                yield return new sleepstudy(269.4117, 0, 372);
                yield return new sleepstudy(273.474, 1, 372);
                yield return new sleepstudy(297.5968, 2, 372);
                yield return new sleepstudy(310.6316, 3, 372);
                yield return new sleepstudy(287.1726, 4, 372);
                yield return new sleepstudy(329.6076, 5, 372);
                yield return new sleepstudy(334.4818, 6, 372);
                yield return new sleepstudy(343.2199, 7, 372);
                yield return new sleepstudy(369.1417, 8, 372);
                yield return new sleepstudy(364.1236, 9, 372);
            }
        }
    }
}
