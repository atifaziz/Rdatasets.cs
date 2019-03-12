// ReSharper disable All

namespace Rdatasets.boot
{
    using System.Collections.Generic;

    /// <summary>
    /// Urine Analysis Data
    /// </summary>

    public class urine
    {
        public readonly int κ;
        public readonly int r;
        public readonly double gravity;
        public readonly double ph;
        public readonly int? osmo;
        public readonly double? cond;
        public readonly int urea;
        public readonly double calc;

        public urine(int κ, int r, double gravity, double ph, int? osmo, double? cond, int urea, double calc)
        {
            this.κ = κ;
            this.r = r;
            this.gravity = gravity;
            this.ph = ph;
            this.osmo = osmo;
            this.cond = cond;
            this.urea = urea;
            this.calc = calc;
        }

        public static IEnumerable<urine> Data
        {
            get
            {
                yield return new urine(1, 0, 1.021, 4.91, 725, null, 443, 2.45);
                yield return new urine(2, 0, 1.017, 5.74, 577, 20, 296, 4.49);
                yield return new urine(3, 0, 1.008, 7.2, 321, 14.9, 101, 2.36);
                yield return new urine(4, 0, 1.011, 5.51, 408, 12.6, 224, 2.15);
                yield return new urine(5, 0, 1.005, 6.52, 187, 7.5, 91, 1.16);
                yield return new urine(6, 0, 1.02, 5.27, 668, 25.3, 252, 3.34);
                yield return new urine(7, 0, 1.012, 5.62, 461, 17.4, 195, 1.4);
                yield return new urine(8, 0, 1.029, 5.67, 1107, 35.9, 550, 8.48);
                yield return new urine(9, 0, 1.015, 5.41, 543, 21.9, 170, 1.16);
                yield return new urine(10, 0, 1.021, 6.13, 779, 25.7, 382, 2.21);
                yield return new urine(11, 0, 1.011, 6.19, 345, 11.5, 152, 1.93);
                yield return new urine(12, 0, 1.025, 5.53, 907, 28.4, 448, 1.27);
                yield return new urine(13, 0, 1.006, 7.12, 242, 11.3, 64, 1.03);
                yield return new urine(14, 0, 1.007, 5.35, 283, 9.9, 147, 1.47);
                yield return new urine(15, 0, 1.011, 5.21, 450, 17.9, 161, 1.53);
                yield return new urine(16, 0, 1.018, 4.9, 684, 26.1, 284, 5.09);
                yield return new urine(17, 0, 1.007, 6.63, 253, 8.4, 133, 1.05);
                yield return new urine(18, 0, 1.025, 6.81, 947, 32.6, 395, 2.03);
                yield return new urine(19, 0, 1.008, 6.88, 395, 26.1, 95, 7.68);
                yield return new urine(20, 0, 1.014, 6.14, 565, 23.6, 214, 1.45);
                yield return new urine(21, 0, 1.024, 6.3, 874, 29.9, 380, 5.16);
                yield return new urine(22, 0, 1.019, 5.47, 760, 33.8, 199, 0.81);
                yield return new urine(23, 0, 1.014, 7.38, 577, 30.1, 87, 1.32);
                yield return new urine(24, 0, 1.02, 5.96, 631, 11.2, 422, 1.55);
                yield return new urine(25, 0, 1.023, 5.68, 749, 29, 239, 1.52);
                yield return new urine(26, 0, 1.017, 6.76, 455, 8.8, 270, 0.77);
                yield return new urine(27, 0, 1.017, 7.61, 527, 25.8, 75, 2.17);
                yield return new urine(28, 0, 1.01, 6.61, 225, 9.8, 72, 0.17);
                yield return new urine(29, 0, 1.008, 5.87, 241, 5.1, 159, 0.83);
                yield return new urine(30, 0, 1.02, 5.44, 781, 29, 349, 3.04);
                yield return new urine(31, 0, 1.017, 7.92, 680, 25.3, 282, 1.06);
                yield return new urine(32, 0, 1.019, 5.98, 579, 15.5, 297, 3.93);
                yield return new urine(33, 0, 1.017, 6.56, 559, 15.8, 317, 5.38);
                yield return new urine(34, 0, 1.008, 5.94, 256, 8.1, 130, 3.53);
                yield return new urine(35, 0, 1.023, 5.85, 970, 38, 362, 4.54);
                yield return new urine(36, 0, 1.02, 5.66, 702, 23.6, 330, 3.98);
                yield return new urine(37, 0, 1.008, 6.4, 341, 14.6, 125, 1.02);
                yield return new urine(38, 0, 1.02, 6.35, 704, 24.5, 260, 3.46);
                yield return new urine(39, 0, 1.009, 6.37, 325, 12.2, 97, 1.19);
                yield return new urine(40, 0, 1.018, 6.18, 694, 23.3, 311, 5.64);
                yield return new urine(41, 0, 1.021, 5.33, 815, 26, 385, 2.66);
                yield return new urine(42, 0, 1.009, 5.64, 386, 17.7, 104, 1.22);
                yield return new urine(43, 0, 1.015, 6.79, 541, 20.9, 187, 2.64);
                yield return new urine(44, 0, 1.01, 5.97, 343, 13.4, 126, 2.31);
                yield return new urine(45, 0, 1.02, 5.68, 876, 35.8, 308, 4.49);
                yield return new urine(46, 1, 1.021, 5.94, 774, 27.9, 325, 6.96);
                yield return new urine(47, 1, 1.024, 5.77, 698, 19.5, 354, 13);
                yield return new urine(48, 1, 1.024, 5.6, 866, 29.5, 360, 5.54);
                yield return new urine(49, 1, 1.021, 5.53, 775, 31.2, 302, 6.19);
                yield return new urine(50, 1, 1.024, 5.36, 853, 27.6, 364, 7.31);
                yield return new urine(51, 1, 1.026, 5.16, 822, 26, 301, 14.34);
                yield return new urine(52, 1, 1.013, 5.86, 531, 21.4, 197, 4.74);
                yield return new urine(53, 1, 1.01, 6.27, 371, 11.2, 188, 2.5);
                yield return new urine(54, 1, 1.011, 7.01, 443, 21.4, 124, 1.27);
                yield return new urine(55, 1, 1.022, 6.21, null, 20.6, 398, 4.18);
                yield return new urine(56, 1, 1.011, 6.13, 364, 10.9, 159, 3.1);
                yield return new urine(57, 1, 1.031, 5.73, 874, 17.4, 516, 3.01);
                yield return new urine(58, 1, 1.02, 7.94, 567, 19.7, 212, 6.81);
                yield return new urine(59, 1, 1.04, 6.28, 838, 14.3, 486, 8.28);
                yield return new urine(60, 1, 1.021, 5.56, 658, 23.6, 224, 2.33);
                yield return new urine(61, 1, 1.025, 5.71, 854, 27, 385, 7.18);
                yield return new urine(62, 1, 1.026, 6.19, 956, 27.6, 473, 5.67);
                yield return new urine(63, 1, 1.034, 5.24, 1236, 27.3, 620, 12.68);
                yield return new urine(64, 1, 1.033, 5.58, 1032, 29.1, 430, 8.94);
                yield return new urine(65, 1, 1.015, 5.98, 487, 14.8, 198, 3.16);
                yield return new urine(66, 1, 1.013, 5.58, 516, 20.8, 184, 3.3);
                yield return new urine(67, 1, 1.014, 5.9, 456, 17.8, 164, 6.99);
                yield return new urine(68, 1, 1.012, 6.75, 251, 5.1, 141, 0.65);
                yield return new urine(69, 1, 1.025, 6.9, 945, 33.6, 396, 4.18);
                yield return new urine(70, 1, 1.026, 6.29, 833, 22.2, 457, 4.45);
                yield return new urine(71, 1, 1.028, 4.76, 312, 12.4, 10, 0.27);
                yield return new urine(72, 1, 1.027, 5.4, 840, 24.5, 395, 7.64);
                yield return new urine(73, 1, 1.018, 5.14, 703, 29, 272, 6.63);
                yield return new urine(74, 1, 1.022, 5.09, 736, 19.8, 418, 8.53);
                yield return new urine(75, 1, 1.025, 7.9, 721, 23.6, 301, 9.04);
                yield return new urine(76, 1, 1.017, 4.81, 410, 13.3, 195, 0.58);
                yield return new urine(77, 1, 1.024, 5.4, 803, 21.8, 394, 7.82);
                yield return new urine(78, 1, 1.016, 6.81, 594, 21.4, 255, 12.2);
                yield return new urine(79, 1, 1.015, 6.03, 416, 12.8, 178, 9.39);
            }
        }
    }
}
