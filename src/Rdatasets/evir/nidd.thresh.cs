// ReSharper disable All

namespace Rdatasets.evir
{
    using System.Collections.Generic;

    /// <summary>
    /// The River Nidd Data
    /// </summary>

    public class nidd_thresh
    {
        public readonly int κ;
        public readonly double dat;

        public nidd_thresh(int κ, double dat)
        {
            this.κ = κ;
            this.dat = dat;
        }

        public static IEnumerable<nidd_thresh> Data
        {
            get
            {
                yield return new nidd_thresh(1, 97.24);
                yield return new nidd_thresh(2, 189.02);
                yield return new nidd_thresh(3, 68.84);
                yield return new nidd_thresh(4, 72.21);
                yield return new nidd_thresh(5, 77.26);
                yield return new nidd_thresh(6, 72.34);
                yield return new nidd_thresh(7, 91.8);
                yield return new nidd_thresh(8, 82.54);
                yield return new nidd_thresh(9, 115.52);
                yield return new nidd_thresh(10, 78.17);
                yield return new nidd_thresh(11, 70.14);
                yield return new nidd_thresh(12, 78.55);
                yield return new nidd_thresh(13, 79.33);
                yield return new nidd_thresh(14, 119.28);
                yield return new nidd_thresh(15, 162.99);
                yield return new nidd_thresh(16, 74.93);
                yield return new nidd_thresh(17, 69.49);
                yield return new nidd_thresh(18, 102.92);
                yield return new nidd_thresh(19, 83.56);
                yield return new nidd_thresh(20, 80.75);
                yield return new nidd_thresh(21, 143.06);
                yield return new nidd_thresh(22, 69.62);
                yield return new nidd_thresh(23, 76.61);
                yield return new nidd_thresh(24, 91.8);
                yield return new nidd_thresh(25, 83.69);
                yield return new nidd_thresh(26, 153.04);
                yield return new nidd_thresh(27, 77.13);
                yield return new nidd_thresh(28, 67.02);
                yield return new nidd_thresh(29, 74.15);
                yield return new nidd_thresh(30, 65.08);
                yield return new nidd_thresh(31, 76.22);
                yield return new nidd_thresh(32, 149.3);
                yield return new nidd_thresh(33, 81.4);
                yield return new nidd_thresh(34, 94.08);
                yield return new nidd_thresh(35, 72.34);
                yield return new nidd_thresh(36, 116.77);
                yield return new nidd_thresh(37, 97.87);
                yield return new nidd_thresh(38, 72.34);
                yield return new nidd_thresh(39, 81.4);
                yield return new nidd_thresh(40, 131.82);
                yield return new nidd_thresh(41, 77.52);
                yield return new nidd_thresh(42, 107.97);
                yield return new nidd_thresh(43, 78.81);
                yield return new nidd_thresh(44, 104.19);
                yield return new nidd_thresh(45, 76.22);
                yield return new nidd_thresh(46, 91.55);
                yield return new nidd_thresh(47, 86.48);
                yield return new nidd_thresh(48, 68.45);
                yield return new nidd_thresh(49, 67.15);
                yield return new nidd_thresh(50, 80.11);
                yield return new nidd_thresh(51, 261.82);
                yield return new nidd_thresh(52, 68.45);
                yield return new nidd_thresh(53, 110.48);
                yield return new nidd_thresh(54, 74.93);
                yield return new nidd_thresh(55, 87.75);
                yield return new nidd_thresh(56, 181.59);
                yield return new nidd_thresh(57, 76.22);
                yield return new nidd_thresh(58, 104.19);
                yield return new nidd_thresh(59, 89.02);
                yield return new nidd_thresh(60, 77.52);
                yield return new nidd_thresh(61, 74.93);
                yield return new nidd_thresh(62, 90.28);
                yield return new nidd_thresh(63, 81.4);
                yield return new nidd_thresh(64, 95.47);
                yield return new nidd_thresh(65, 99.14);
                yield return new nidd_thresh(66, 158.01);
                yield return new nidd_thresh(67, 76.22);
                yield return new nidd_thresh(68, 92.82);
                yield return new nidd_thresh(69, 67.15);
                yield return new nidd_thresh(70, 81.4);
                yield return new nidd_thresh(71, 172.92);
                yield return new nidd_thresh(72, 97.87);
                yield return new nidd_thresh(73, 179.12);
                yield return new nidd_thresh(74, 88.76);
                yield return new nidd_thresh(75, 74.02);
                yield return new nidd_thresh(76, 85.85);
                yield return new nidd_thresh(77, 67.02);
                yield return new nidd_thresh(78, 70.01);
                yield return new nidd_thresh(79, 76.74);
                yield return new nidd_thresh(80, 65.6);
                yield return new nidd_thresh(81, 77.26);
                yield return new nidd_thresh(82, 213.7);
                yield return new nidd_thresh(83, 78.81);
                yield return new nidd_thresh(84, 86.73);
                yield return new nidd_thresh(85, 70.52);
                yield return new nidd_thresh(86, 69.49);
                yield return new nidd_thresh(87, 78.29);
                yield return new nidd_thresh(88, 81.4);
                yield return new nidd_thresh(89, 79.33);
                yield return new nidd_thresh(90, 83.94);
                yield return new nidd_thresh(91, 111.74);
                yield return new nidd_thresh(92, 81.65);
                yield return new nidd_thresh(93, 67.67);
                yield return new nidd_thresh(94, 75.06);
                yield return new nidd_thresh(95, 96.86);
                yield return new nidd_thresh(96, 67.28);
                yield return new nidd_thresh(97, 78.29);
                yield return new nidd_thresh(98, 75.97);
                yield return new nidd_thresh(99, 100.4);
                yield return new nidd_thresh(100, 89.65);
                yield return new nidd_thresh(101, 78.04);
                yield return new nidd_thresh(102, 70.78);
                yield return new nidd_thresh(103, 81.27);
                yield return new nidd_thresh(104, 77.78);
                yield return new nidd_thresh(105, 76.61);
                yield return new nidd_thresh(106, 92.82);
                yield return new nidd_thresh(107, 69.49);
                yield return new nidd_thresh(108, 74.8);
                yield return new nidd_thresh(109, 72.34);
                yield return new nidd_thresh(110, 99.14);
                yield return new nidd_thresh(111, 74.54);
                yield return new nidd_thresh(112, 104.19);
                yield return new nidd_thresh(113, 74.54);
                yield return new nidd_thresh(114, 86.48);
                yield return new nidd_thresh(115, 151.79);
                yield return new nidd_thresh(116, 79.46);
                yield return new nidd_thresh(117, 66.53);
                yield return new nidd_thresh(118, 88.89);
                yield return new nidd_thresh(119, 73.61);
                yield return new nidd_thresh(120, 111.54);
                yield return new nidd_thresh(121, 78.98);
                yield return new nidd_thresh(122, 87.76);
                yield return new nidd_thresh(123, 148.63);
                yield return new nidd_thresh(124, 87.76);
                yield return new nidd_thresh(125, 90.88);
                yield return new nidd_thresh(126, 87.76);
                yield return new nidd_thresh(127, 80.12);
                yield return new nidd_thresh(128, 96.25);
                yield return new nidd_thresh(129, 251.96);
                yield return new nidd_thresh(130, 75.87);
                yield return new nidd_thresh(131, 121.73);
                yield return new nidd_thresh(132, 78.98);
                yield return new nidd_thresh(133, 107.58);
                yield return new nidd_thresh(134, 108.14);
                yield return new nidd_thresh(135, 73.61);
                yield return new nidd_thresh(136, 88.04);
                yield return new nidd_thresh(137, 76.72);
                yield return new nidd_thresh(138, 99.08);
                yield return new nidd_thresh(139, 131.92);
                yield return new nidd_thresh(140, 138.72);
                yield return new nidd_thresh(141, 75.02);
                yield return new nidd_thresh(142, 133.06);
                yield return new nidd_thresh(143, 70.49);
                yield return new nidd_thresh(144, 257.62);
                yield return new nidd_thresh(145, 99.93);
                yield return new nidd_thresh(146, 123.71);
                yield return new nidd_thresh(147, 87.19);
                yield return new nidd_thresh(148, 157.12);
                yield return new nidd_thresh(149, 305.75);
                yield return new nidd_thresh(150, 77);
                yield return new nidd_thresh(151, 71.91);
                yield return new nidd_thresh(152, 89.46);
                yield return new nidd_thresh(153, 226.48);
                yield return new nidd_thresh(154, 110.98);
            }
        }
    }
}
