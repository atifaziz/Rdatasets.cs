// ReSharper disable All

namespace Rdatasets.Ecdat
{
    using System.Collections.Generic;

    /// <summary>
    /// Cost Function for Electricity Producers, 1955
    /// </summary>

    public class Nerlove
    {
        public readonly double cost;
        public readonly int output;
        public readonly double pl;
        public readonly double sl;
        public readonly double pk;
        public readonly double sk;
        public readonly double pf;
        public readonly double sf;

        public Nerlove(double cost, int output, double pl, double sl, double pk, double sk, double pf, double sf)
        {
            this.cost = cost;
            this.output = output;
            this.pl = pl;
            this.sl = sl;
            this.pk = pk;
            this.sk = sk;
            this.pf = pf;
            this.sf = sf;
        }

        public static IEnumerable<Nerlove> Data
        {
            get
            {
                yield return new Nerlove(0.082, 2, 2.09, 0.3164, 183, 0.4521, 17.9, 0.2315);
                yield return new Nerlove(0.661, 3, 2.05, 0.2073, 174, 0.6676, 35.1, 0.1251);
                yield return new Nerlove(0.99, 4, 2.05, 0.2349, 171, 0.5799, 35.1, 0.1852);
                yield return new Nerlove(0.315, 4, 1.83, 0.1152, 166, 0.7857, 32.2, 0.099);
                yield return new Nerlove(0.197, 5, 2.12, 0.23, 233, 0.3841, 28.6, 0.3859);
                yield return new Nerlove(0.098, 9, 2.12, 0.1881, 195, 0.2926, 28.6, 0.5193);
                yield return new Nerlove(0.949, 11, 1.98, 0.1584, 206, 0.6093, 35.5, 0.2323);
                yield return new Nerlove(0.675, 13, 2.05, 0.188, 150, 0.4952, 35.1, 0.3169);
                yield return new Nerlove(0.525, 13, 2.19, 0.1852, 155, 0.3651, 29.1, 0.4496);
                yield return new Nerlove(0.501, 22, 1.72, 0.1845, 188, 0.2491, 15, 0.5664);
                yield return new Nerlove(1.194, 25, 2.09, 0.1994, 170, 0.5478, 17.9, 0.2528);
                yield return new Nerlove(0.67, 25, 1.68, 0.1102, 167, 0.6118, 39.7, 0.278);
                yield return new Nerlove(0.349, 35, 1.81, 0.1386, 213, 0.3817, 22.6, 0.4797);
                yield return new Nerlove(0.423, 39, 2.3, 0.1702, 164, 0.4137, 23.6, 0.4161);
                yield return new Nerlove(0.501, 43, 1.75, 0.1143, 170, 0.3481, 42.8, 0.5376);
                yield return new Nerlove(0.55, 63, 1.76, 0.0887, 161, 0.5184, 10.3, 0.3929);
                yield return new Nerlove(0.795, 68, 1.98, 0.1116, 210, 0.3054, 35.5, 0.583);
                yield return new Nerlove(0.664, 81, 2.29, 0.1665, 158, 0.3859, 28.5, 0.4476);
                yield return new Nerlove(0.705, 84, 2.19, 0.1484, 156, 0.363, 29.1, 0.4883);
                yield return new Nerlove(0.903, 73, 1.75, 0.0821, 176, 0.291, 42.8, 0.6269);
                yield return new Nerlove(1.504, 99, 2.2, 0.0906, 170, 0.3947, 36.2, 0.5146);
                yield return new Nerlove(1.615, 101, 1.66, 0.108, 192, 0.3675, 33.4, 0.5245);
                yield return new Nerlove(1.127, 119, 1.92, 0.198, 164, 0.4164, 22.5, 0.3856);
                yield return new Nerlove(0.718, 120, 1.77, 0.1648, 175, 0.2664, 21.3, 0.5688);
                yield return new Nerlove(2.414, 122, 2.09, 0.2402, 180, 0.4949, 17.9, 0.2649);
                yield return new Nerlove(1.13, 130, 1.82, 0.1171, 176, 0.2779, 38.9, 0.6049);
                yield return new Nerlove(0.992, 138, 1.8, 0.1304, 202, 0.4011, 20.2, 0.4686);
                yield return new Nerlove(1.554, 149, 1.92, 0.0553, 227, 0.432, 22.5, 0.5127);
                yield return new Nerlove(1.225, 196, 1.92, 0.0722, 186, 0.455, 29.1, 0.4728);
                yield return new Nerlove(1.565, 197, 2.19, 0.0692, 183, 0.4151, 29.1, 0.5157);
                yield return new Nerlove(1.936, 209, 1.92, 0.0801, 169, 0.4858, 22.5, 0.434);
                yield return new Nerlove(3.154, 214, 1.52, 0.1722, 168, 0.4839, 27.5, 0.3439);
                yield return new Nerlove(2.599, 220, 1.92, 0.15, 164, 0.4886, 22.5, 0.3614);
                yield return new Nerlove(3.298, 234, 2.2, 0.1554, 164, 0.4595, 36.2, 0.3851);
                yield return new Nerlove(2.441, 235, 2.11, 0.1905, 170, 0.3797, 24.4, 0.4298);
                yield return new Nerlove(2.031, 253, 1.92, 0.1608, 158, 0.1879, 22.5, 0.6513);
                yield return new Nerlove(4.666, 279, 2.05, 0.1689, 177, 0.4548, 35.1, 0.3763);
                yield return new Nerlove(1.834, 290, 1.66, 0.164, 195, 0.425, 33.4, 0.411);
                yield return new Nerlove(2.072, 290, 1.8, 0.1156, 176, 0.4768, 20.2, 0.4076);
                yield return new Nerlove(2.039, 295, 1.77, 0.1405, 188, 0.3951, 21.3, 0.4644);
                yield return new Nerlove(3.398, 299, 1.7, 0.0896, 187, 0.5786, 26.9, 0.3318);
                yield return new Nerlove(3.083, 324, 2.02, 0.1509, 152, 0.0904, 35.1, 0.7587);
                yield return new Nerlove(2.344, 333, 2.19, 0.1161, 157, 0.3626, 29.1, 0.5213);
                yield return new Nerlove(2.382, 338, 1.85, 0.0616, 163, 0.4799, 24.6, 0.4585);
                yield return new Nerlove(2.657, 353, 2.19, 0.0809, 143, 0.2829, 29.1, 0.6361);
                yield return new Nerlove(1.705, 353, 2.13, 0.088, 167, 0.6341, 10.7, 0.278);
                yield return new Nerlove(3.23, 416, 1.54, 0.0839, 217, 0.3623, 26.2, 0.5538);
                yield return new Nerlove(5.049, 420, 1.52, 0.1601, 144, 0.3465, 27.5, 0.4934);
                yield return new Nerlove(3.814, 456, 2.09, 0.0883, 178, 0.3349, 30, 0.5768);
                yield return new Nerlove(4.58, 484, 1.75, 0.1009, 176, 0.2828, 42.8, 0.6163);
                yield return new Nerlove(4.358, 516, 2.3, 0.1515, 167, 0.3981, 23.6, 0.4504);
                yield return new Nerlove(4.714, 550, 2.05, 0.0806, 158, 0.292, 35.1, 0.6275);
                yield return new Nerlove(4.357, 563, 2.32, 0.0703, 162, 0.4024, 31.9, 0.5273);
                yield return new Nerlove(3.919, 566, 2.31, 0.065, 198, 0.3776, 33.5, 0.5574);
                yield return new Nerlove(3.442, 592, 1.92, 0.0915, 164, 0.4564, 22.5, 0.4521);
                yield return new Nerlove(4.898, 671, 2.05, 0.1479, 164, 0.3432, 35.1, 0.5089);
                yield return new Nerlove(3.584, 696, 1.76, 0.0702, 161, 0.3709, 10.3, 0.5589);
                yield return new Nerlove(5.535, 719, 1.7, 0.0703, 174, 0.4946, 26.9, 0.4351);
                yield return new Nerlove(4.406, 742, 2.04, 0.1516, 157, 0.4633, 20.7, 0.3851);
                yield return new Nerlove(4.289, 795, 2.24, 0.0483, 185, 0.3569, 26.5, 0.5949);
                yield return new Nerlove(6.731, 800, 1.7, 0.117, 157, 0.3396, 26.9, 0.5434);
                yield return new Nerlove(6.895, 808, 1.68, 0.0859, 203, 0.406, 39.7, 0.5081);
                yield return new Nerlove(5.112, 811, 2.29, 0.0847, 178, 0.2884, 28.5, 0.6269);
                yield return new Nerlove(5.141, 855, 2, 0.1457, 183, 0.4317, 34.3, 0.4226);
                yield return new Nerlove(5.72, 860, 2.31, 0.0597, 168, 0.4528, 33.5, 0.4875);
                yield return new Nerlove(4.691, 909, 1.45, 0.0921, 196, 0.4435, 17.6, 0.4644);
                yield return new Nerlove(6.832, 913, 1.7, 0.125, 166, 0.4028, 26.9, 0.4721);
                yield return new Nerlove(4.813, 924, 1.76, 0.1163, 172, 0.5402, 10.3, 0.3436);
                yield return new Nerlove(6.754, 984, 1.7, 0.1083, 158, 0.2435, 26.9, 0.6482);
                yield return new Nerlove(5.127, 991, 2.09, 0.0861, 174, 0.4965, 30, 0.4174);
                yield return new Nerlove(6.388, 1000, 1.55, 0.0408, 225, 0.3881, 28.2, 0.6667);
                yield return new Nerlove(4.509, 1098, 2.11, 0.0781, 168, 0.4481, 24.4, 0.4738);
                yield return new Nerlove(7.185, 1109, 2.05, 0.0752, 177, 0.2527, 35.1, 0.6721);
                yield return new Nerlove(6.8, 1118, 2.3, 0.1299, 161, 0.3511, 23.6, 0.5311);
                yield return new Nerlove(7.743, 1122, 2.19, 0.0977, 162, 0.3743, 29.1, 0.5279);
                yield return new Nerlove(7.968, 1137, 2.04, 0.0655, 158, 0.4552, 20.7, 0.4793);
                yield return new Nerlove(8.858, 1156, 2.31, 0.1052, 176, 0.3154, 33.5, 0.5794);
                yield return new Nerlove(8.588, 1166, 1.7, 0.1224, 183, 0.4339, 26.9, 0.4436);
                yield return new Nerlove(6.449, 1170, 2.05, 0.0935, 166, 0.2549, 35.1, 0.6516);
                yield return new Nerlove(8.488, 1215, 2.19, 0.0695, 164, 0.439, 29.1, 0.4915);
                yield return new Nerlove(8.877, 1279, 2, 0.0635, 207, 0.333, 34.3, 0.6034);
                yield return new Nerlove(10.274, 1291, 2.32, 0.0559, 175, 0.8048, 31.9, 0.1393);
                yield return new Nerlove(6.024, 1290, 1.55, 0.0432, 225, 0.3511, 28.2, 0.6057);
                yield return new Nerlove(8.258, 1331, 2.13, 0.0462, 178, 0.4353, 30, 0.5185);
                yield return new Nerlove(13.376, 1373, 2.2, 0.1324, 157, 0.3233, 36.2, 0.5443);
                yield return new Nerlove(10.69, 1420, 2.2, 0.0902, 138, 0.3139, 36.2, 0.5959);
                yield return new Nerlove(8.308, 1474, 1.85, 0.0755, 163, 0.4425, 24.6, 0.4819);
                yield return new Nerlove(6.082, 1497, 1.76, 0.0767, 168, 0.5871, 10.3, 0.3362);
                yield return new Nerlove(9.284, 1545, 1.8, 0.0836, 158, 0.4498, 20.2, 0.4665);
                yield return new Nerlove(10.879, 1649, 2.32, 0.0975, 177, 0.3991, 31.9, 0.5035);
                yield return new Nerlove(8.477, 1668, 1.8, 0.0833, 170, 0.4524, 20.2, 0.4643);
                yield return new Nerlove(6.877, 1782, 2.13, 0.0618, 183, 0.6377, 10.7, 0.3005);
                yield return new Nerlove(15.106, 1831, 1.98, 0.1337, 162, 0.3361, 35.5, 0.5302);
                yield return new Nerlove(8.031, 1833, 1.76, 0.0915, 177, 0.6501, 10.3, 0.2584);
                yield return new Nerlove(8.082, 1838, 1.45, 0.0671, 196, 0.481, 17.6, 0.4519);
                yield return new Nerlove(10.866, 1787, 2.24, 0.105, 164, 0.4125, 26.5, 0.4824);
                yield return new Nerlove(8.596, 1918, 1.69, 0.0803, 158, 0.5513, 12.9, 0.3684);
                yield return new Nerlove(8.673, 1930, 1.81, 0.0733, 157, 0.3436, 22.6, 0.5831);
                yield return new Nerlove(15.437, 2028, 2.11, 0.0808, 163, 0.3989, 24.4, 0.5204);
                yield return new Nerlove(8.211, 2057, 1.76, 0.1239, 161, 0.6164, 10.3, 0.2597);
                yield return new Nerlove(11.982, 2084, 1.77, 0.0905, 156, 0.4103, 21.3, 0.4992);
                yield return new Nerlove(16.674, 2226, 2, 0.0779, 217, 0.343, 34.3, 0.5791);
                yield return new Nerlove(12.62, 2304, 2.3, 0.0775, 161, 0.4865, 23.6, 0.436);
                yield return new Nerlove(12.905, 2341, 2.04, 0.0945, 183, 0.4076, 20.7, 0.498);
                yield return new Nerlove(11.615, 2353, 1.69, 0.1006, 167, 0.5561, 12.9, 0.3433);
                yield return new Nerlove(9.321, 2367, 1.76, 0.099, 161, 0.5751, 10.3, 0.3259);
                yield return new Nerlove(12.962, 2451, 2.04, 0.0951, 163, 0.3183, 20.7, 0.5866);
                yield return new Nerlove(16.932, 2457, 2.2, 0.0614, 170, 0.3234, 36.2, 0.6152);
                yield return new Nerlove(9.648, 2507, 1.76, 0.0964, 174, 0.5755, 10.3, 0.3281);
                yield return new Nerlove(18.35, 2530, 2.31, 0.0735, 197, 0.446, 33.5, 0.4805);
                yield return new Nerlove(17.333, 2576, 1.92, 0.1398, 162, 0.4275, 22.5, 0.4327);
                yield return new Nerlove(12.015, 2607, 1.76, 0.1116, 155, 0.532, 10.3, 0.3564);
                yield return new Nerlove(11.32, 2870, 1.76, 0.1333, 167, 0.5822, 10.3, 0.2845);
                yield return new Nerlove(22.337, 2993, 2.31, 0.0581, 176, 0.4385, 33.5, 0.5034);
                yield return new Nerlove(19.035, 3202, 2.3, 0.0983, 170, 0.4974, 23.6, 0.5034);
                yield return new Nerlove(12.205, 3286, 1.61, 0.0681, 183, 0.4779, 17.8, 0.454);
                yield return new Nerlove(17.078, 3312, 1.68, 0.0393, 190, 0.3314, 28.8, 0.6294);
                yield return new Nerlove(25.528, 3498, 2.09, 0.1141, 170, 0.3714, 30, 0.5145);
                yield return new Nerlove(24.021, 3538, 2.09, 0.084, 176, 0.3761, 30, 0.5399);
                yield return new Nerlove(32.197, 3794, 2.05, 0.0976, 159, 0.4118, 35.1, 0.4906);
                yield return new Nerlove(26.652, 3841, 2.29, 0.1059, 157, 0.3679, 28.5, 0.5262);
                yield return new Nerlove(20.164, 4014, 2.11, 0.0809, 161, 0.5348, 24.4, 0.3843);
                yield return new Nerlove(14.132, 4217, 1.53, 0.047, 172, 0.5252, 18.1, 0.4278);
                yield return new Nerlove(21.41, 4305, 2.11, 0.0848, 203, 0.8448, 24.4, 0.0703);
                yield return new Nerlove(23.244, 4494, 2.04, 0.0624, 167, 0.5105, 20.7, 0.4271);
                yield return new Nerlove(29.845, 4764, 2.19, 0.1328, 195, 0.353, 29.1, 0.5143);
                yield return new Nerlove(32.318, 5277, 1.92, 0.0719, 161, 0.3582, 29.1, 0.5699);
                yield return new Nerlove(21.988, 5283, 2.04, 0.063, 159, 0.4491, 20.7, 0.4879);
                yield return new Nerlove(35.229, 5668, 2.11, 0.0977, 177, 0.5088, 24.4, 0.3936);
                yield return new Nerlove(17.467, 5681, 1.76, 0.0802, 157, 0.5323, 10.3, 0.3875);
                yield return new Nerlove(22.828, 5819, 1.79, 0.0854, 196, 0.3921, 18.5, 0.5226);
                yield return new Nerlove(33.154, 6000, 2.11, 0.1043, 183, 0.4186, 24.4, 0.4771);
                yield return new Nerlove(32.228, 6119, 1.54, 0.0797, 189, 0.3503, 26.2, 0.57);
                yield return new Nerlove(34.168, 6136, 1.92, 0.0653, 160, 0.6791, 22.5, 0.2556);
                yield return new Nerlove(40.594, 7193, 2.12, 0.0729, 162, 0.355, 28.6, 0.5721);
                yield return new Nerlove(33.354, 7886, 1.61, 0.0587, 178, 0.5835, 17.8, 0.3578);
                yield return new Nerlove(64.542, 8419, 2.32, 0.1108, 199, 0.391, 31.9, 0.4982);
                yield return new Nerlove(41.238, 8642, 2.24, 0.0517, 182, 0.3259, 26.5, 0.6224);
                yield return new Nerlove(47.993, 8787, 2.31, 0.0841, 190, 0.3407, 33.5, 0.5753);
                yield return new Nerlove(69.878, 9484, 2.11, 0.0759, 165, 0.4044, 24.4, 0.5198);
                yield return new Nerlove(44.894, 9956, 1.68, 0.0688, 203, 0.2942, 28.8, 0.637);
                yield return new Nerlove(67.12, 11477, 2.24, 0.067, 151, 0.3458, 26.5, 0.5872);
                yield return new Nerlove(73.05, 11796, 2.12, 0.1033, 148, 0.3914, 28.6, 0.5054);
                yield return new Nerlove(139.422, 14359, 2.31, 0.105, 212, 0.4102, 33.5, 0.4848);
                yield return new Nerlove(119.939, 16719, 2.3, 0.0906, 162, 0.434, 23.6, 0.4754);
                yield return new Nerlove(23.22, 3018, 2.01, 0.1292, 163, 0.3282, 35.1, 0.5425);
                yield return new Nerlove(7.797, 874, 2.05, 0.1084, 155, 0.2123, 35.1, 0.6793);
                yield return new Nerlove(1.61, 14, 1.99, 0.1764, 199, 0.6352, 35.4, 0.1884);
                yield return new Nerlove(28.996, 4174, 2.28, 0.1067, 157, 0.3675, 28.55, 0.5258);
                yield return new Nerlove(37.767, 6356, 1.92, 0.0713, 160.2, 0.6656, 22.5, 0.2631);
                yield return new Nerlove(37.496, 8291, 1.91, 0.0764, 171, 0.5175, 22.43, 0.406);
                yield return new Nerlove(64.888, 13702, 1.66, 0.0877, 192, 0.3692, 22.9, 0.5431);
                yield return new Nerlove(52.083, 8545, 2.17, 0.085, 186, 0.5933, 26.4, 0.3217);
                yield return new Nerlove(132.901, 19170, 2.3, 0.091, 162, 0.4511, 23.6, 0.3217);
                yield return new Nerlove(31.98, 4548, 2.18, 0.0862, 159, 0.3119, 36, 0.602);
                yield return new Nerlove(12.483, 2106, 1.77, 0.0945, 156, 0.394, 21.3, 0.5115);
                yield return new Nerlove(5.817, 895, 2.27, 0.0924, 174.36, 0.2975, 28.56, 0.6101);
                yield return new Nerlove(12.072, 1787, 2.11, 0.0595, 178, 0.4036, 30, 0.5369);
                yield return new Nerlove(9.391, 2050, 1.8, 0.0803, 157.98, 0.3377, 22.5, 0.582);
            }
        }
    }
}
