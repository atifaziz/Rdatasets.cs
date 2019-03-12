// ReSharper disable All

namespace Rdatasets.texmex
{
    using System.Collections.Generic;

    /// <summary>
    /// Rain, wavesurge, portpirie and nidd datasets.
    /// </summary>

    public class nidd
    {
        public readonly int κ;
        public readonly double dat;

        public nidd(int κ, double dat)
        {
            this.κ = κ;
            this.dat = dat;
        }

        public static IEnumerable<nidd> Data
        {
            get
            {
                yield return new nidd(1, 97.24);
                yield return new nidd(2, 189.02);
                yield return new nidd(3, 68.84);
                yield return new nidd(4, 72.21);
                yield return new nidd(5, 77.26);
                yield return new nidd(6, 72.34);
                yield return new nidd(7, 91.8);
                yield return new nidd(8, 82.54);
                yield return new nidd(9, 115.52);
                yield return new nidd(10, 78.17);
                yield return new nidd(11, 70.14);
                yield return new nidd(12, 78.55);
                yield return new nidd(13, 79.33);
                yield return new nidd(14, 119.28);
                yield return new nidd(15, 162.99);
                yield return new nidd(16, 74.93);
                yield return new nidd(17, 69.49);
                yield return new nidd(18, 102.92);
                yield return new nidd(19, 83.56);
                yield return new nidd(20, 80.75);
                yield return new nidd(21, 143.06);
                yield return new nidd(22, 69.62);
                yield return new nidd(23, 76.61);
                yield return new nidd(24, 91.8);
                yield return new nidd(25, 83.69);
                yield return new nidd(26, 153.04);
                yield return new nidd(27, 77.13);
                yield return new nidd(28, 67.02);
                yield return new nidd(29, 74.15);
                yield return new nidd(30, 65.08);
                yield return new nidd(31, 76.22);
                yield return new nidd(32, 149.3);
                yield return new nidd(33, 81.4);
                yield return new nidd(34, 94.08);
                yield return new nidd(35, 72.34);
                yield return new nidd(36, 116.77);
                yield return new nidd(37, 97.87);
                yield return new nidd(38, 72.34);
                yield return new nidd(39, 81.4);
                yield return new nidd(40, 131.82);
                yield return new nidd(41, 77.52);
                yield return new nidd(42, 107.97);
                yield return new nidd(43, 78.81);
                yield return new nidd(44, 104.19);
                yield return new nidd(45, 76.22);
                yield return new nidd(46, 91.55);
                yield return new nidd(47, 86.48);
                yield return new nidd(48, 68.45);
                yield return new nidd(49, 67.15);
                yield return new nidd(50, 80.11);
                yield return new nidd(51, 261.82);
                yield return new nidd(52, 68.45);
                yield return new nidd(53, 110.48);
                yield return new nidd(54, 74.93);
                yield return new nidd(55, 87.75);
                yield return new nidd(56, 181.59);
                yield return new nidd(57, 76.22);
                yield return new nidd(58, 104.19);
                yield return new nidd(59, 89.02);
                yield return new nidd(60, 77.52);
                yield return new nidd(61, 74.93);
                yield return new nidd(62, 90.28);
                yield return new nidd(63, 81.4);
                yield return new nidd(64, 95.47);
                yield return new nidd(65, 99.14);
                yield return new nidd(66, 158.01);
                yield return new nidd(67, 76.22);
                yield return new nidd(68, 92.82);
                yield return new nidd(69, 67.15);
                yield return new nidd(70, 81.4);
                yield return new nidd(71, 172.92);
                yield return new nidd(72, 97.87);
                yield return new nidd(73, 179.12);
                yield return new nidd(74, 88.76);
                yield return new nidd(75, 74.02);
                yield return new nidd(76, 85.85);
                yield return new nidd(77, 67.02);
                yield return new nidd(78, 70.01);
                yield return new nidd(79, 76.74);
                yield return new nidd(80, 65.6);
                yield return new nidd(81, 77.26);
                yield return new nidd(82, 213.7);
                yield return new nidd(83, 78.81);
                yield return new nidd(84, 86.73);
                yield return new nidd(85, 70.52);
                yield return new nidd(86, 69.49);
                yield return new nidd(87, 78.29);
                yield return new nidd(88, 81.4);
                yield return new nidd(89, 79.33);
                yield return new nidd(90, 83.94);
                yield return new nidd(91, 111.74);
                yield return new nidd(92, 81.65);
                yield return new nidd(93, 67.67);
                yield return new nidd(94, 75.06);
                yield return new nidd(95, 96.86);
                yield return new nidd(96, 67.28);
                yield return new nidd(97, 78.29);
                yield return new nidd(98, 75.97);
                yield return new nidd(99, 100.4);
                yield return new nidd(100, 89.65);
                yield return new nidd(101, 78.04);
                yield return new nidd(102, 70.78);
                yield return new nidd(103, 81.27);
                yield return new nidd(104, 77.78);
                yield return new nidd(105, 76.61);
                yield return new nidd(106, 92.82);
                yield return new nidd(107, 69.49);
                yield return new nidd(108, 74.8);
                yield return new nidd(109, 72.34);
                yield return new nidd(110, 99.14);
                yield return new nidd(111, 74.54);
                yield return new nidd(112, 104.19);
                yield return new nidd(113, 74.54);
                yield return new nidd(114, 86.48);
                yield return new nidd(115, 151.79);
                yield return new nidd(116, 79.46);
                yield return new nidd(117, 66.53);
                yield return new nidd(118, 88.89);
                yield return new nidd(119, 73.61);
                yield return new nidd(120, 111.54);
                yield return new nidd(121, 78.98);
                yield return new nidd(122, 87.76);
                yield return new nidd(123, 148.63);
                yield return new nidd(124, 87.76);
                yield return new nidd(125, 90.88);
                yield return new nidd(126, 87.76);
                yield return new nidd(127, 80.12);
                yield return new nidd(128, 96.25);
                yield return new nidd(129, 251.96);
                yield return new nidd(130, 75.87);
                yield return new nidd(131, 121.73);
                yield return new nidd(132, 78.98);
                yield return new nidd(133, 107.58);
                yield return new nidd(134, 108.14);
                yield return new nidd(135, 73.61);
                yield return new nidd(136, 88.04);
                yield return new nidd(137, 76.72);
                yield return new nidd(138, 99.08);
                yield return new nidd(139, 131.92);
                yield return new nidd(140, 138.72);
                yield return new nidd(141, 75.02);
                yield return new nidd(142, 133.06);
                yield return new nidd(143, 70.49);
                yield return new nidd(144, 257.62);
                yield return new nidd(145, 99.93);
                yield return new nidd(146, 123.71);
                yield return new nidd(147, 87.19);
                yield return new nidd(148, 157.12);
                yield return new nidd(149, 305.75);
                yield return new nidd(150, 77);
                yield return new nidd(151, 71.91);
                yield return new nidd(152, 89.46);
                yield return new nidd(153, 226.48);
                yield return new nidd(154, 110.98);
            }
        }
    }
}
