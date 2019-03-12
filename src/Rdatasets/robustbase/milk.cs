// ReSharper disable All

namespace Rdatasets.robustbase
{
    using System.Collections.Generic;

    /// <summary>
    /// Daudin's Milk Composition Data
    /// </summary>

    public class milk
    {
        public readonly int κ;
        public readonly double X1;
        public readonly double X2;
        public readonly double X3;
        public readonly double X4;
        public readonly double X5;
        public readonly double X6;
        public readonly double X7;
        public readonly double X8;

        public milk(int κ, double X1, double X2, double X3, double X4, double X5, double X6, double X7, double X8)
        {
            this.κ = κ;
            this.X1 = X1;
            this.X2 = X2;
            this.X3 = X3;
            this.X4 = X4;
            this.X5 = X5;
            this.X6 = X6;
            this.X7 = X7;
            this.X8 = X8;
        }

        public static IEnumerable<milk> Data
        {
            get
            {
                yield return new milk(1, 1.0318, 37.7, 35.7, 26.5, 27.1, 27.4, 127.1, 15.35);
                yield return new milk(2, 1.0316, 37.5, 35.3, 26, 27.2, 27.2, 128.7, 14.72);
                yield return new milk(3, 1.0314, 37, 32.8, 25.3, 24.8, 23.9, 124.1, 14.61);
                yield return new milk(4, 1.0311, 39.5, 33.7, 26.8, 25.6, 25.8, 127.5, 14.56);
                yield return new milk(5, 1.0309, 36, 32.8, 25.9, 25.1, 24.9, 121.6, 13.74);
                yield return new milk(6, 1.0322, 36, 33.8, 26.9, 25.6, 25.7, 124.5, 14.31);
                yield return new milk(7, 1.0311, 36, 33.8, 26.9, 25.8, 25.4, 125.3, 14.13);
                yield return new milk(8, 1.0314, 36.7, 34.1, 27, 25.9, 25.9, 124.9, 14.16);
                yield return new milk(9, 1.0292, 37.2, 31.5, 24.8, 23.6, 23.9, 122.5, 14.13);
                yield return new milk(10, 1.0297, 35, 31.6, 24.9, 23.9, 23.8, 121, 14.58);
                yield return new milk(11, 1.0282, 34.7, 29.9, 23.5, 22.7, 22.5, 114.7, 13.83);
                yield return new milk(12, 1.0262, 31.5, 30.1, 23.6, 22.8, 22.7, 111.1, 13.18);
                yield return new milk(13, 1.027, 30.5, 30.1, 23.8, 22.7, 22.6, 115, 13.45);
                yield return new milk(14, 1.0269, 31.6, 29.8, 23.3, 22.4, 22.3, 112.7, 12.82);
                yield return new milk(15, 1.0264, 34.9, 29.7, 23.2, 22.2, 22.3, 113.5, 13.36);
                yield return new milk(16, 1.0275, 35.7, 32.5, 25.7, 24.4, 23.8, 120.1, 14.61);
                yield return new milk(17, 1.0275, 37.9, 31.8, 25, 23.4, 23.5, 122.6, 14.74);
                yield return new milk(18, 1.0293, 34.6, 32.9, 26.1, 25.3, 24.4, 120.8, 13.74);
                yield return new milk(19, 1.0282, 36.6, 32.2, 25.3, 24.4, 24.1, 121.1, 14.63);
                yield return new milk(20, 1.03, 37.2, 32.1, 25.6, 25, 24.2, 123.4, 14.74);
                yield return new milk(21, 1.03, 34, 33.1, 26.4, 25.3, 25.1, 119.7, 13.8);
                yield return new milk(22, 1.03, 35.3, 33.3, 26, 25.1, 25, 121.5, 14.07);
                yield return new milk(23, 1.0295, 35.8, 33.9, 26.6, 25.9, 25.5, 121.7, 14.57);
                yield return new milk(24, 1.0295, 35.9, 33.8, 26.5, 25.2, 25.3, 121.4, 14.88);
                yield return new milk(25, 1.0288, 34.8, 32.9, 26.2, 25.2, 25, 118.4, 13.99);
                yield return new milk(26, 1.029, 35.9, 33.4, 26.3, 25.5, 25.4, 121.1, 14.12);
                yield return new milk(27, 1.029, 35.5, 32.7, 25.4, 24, 23.8, 119.9, 13.81);
                yield return new milk(28, 1.0301, 35.8, 35.7, 28, 26.7, 27.2, 122.8, 14.69);
                yield return new milk(29, 1.0302, 37, 34.9, 27.7, 26.6, 26.6, 125.5, 15.31);
                yield return new milk(30, 1.03, 35.8, 33.9, 26.8, 26, 25.8, 122.6, 14.37);
                yield return new milk(31, 1.0305, 34.2, 34.5, 27.2, 26.1, 25.8, 123.9, 14.63);
                yield return new milk(32, 1.0302, 34.8, 33.7, 26.1, 25.2, 25.2, 124.2, 14.59);
                yield return new milk(33, 1.03, 36.5, 33.9, 26.6, 25.5, 25.4, 124.1, 14.89);
                yield return new milk(34, 1.03, 36.6, 33.2, 25.9, 24.6, 24.9, 123.4, 14.6);
                yield return new milk(35, 1.03, 34.8, 34.2, 26.8, 25.5, 25.4, 121.4, 14.66);
                yield return new milk(36, 1.03, 37.3, 34.9, 27.4, 26.7, 26.7, 125.1, 14.75);
                yield return new milk(37, 1.03, 34.6, 34.6, 27, 26.2, 25.8, 122.6, 14.33);
                yield return new milk(38, 1.031, 35.7, 34.8, 27.4, 26.1, 26.3, 123.4, 14.58);
                yield return new milk(39, 1.03, 35.7, 33.4, 26.1, 24.9, 24.9, 120.8, 14.67);
                yield return new milk(40, 1.0302, 37.9, 33.6, 26.1, 25.3, 24.9, 126.1, 15.2);
                yield return new milk(41, 1.03, 36.8, 35.4, 26, 27.1, 27, 125.1, 14.94);
                yield return new milk(42, 1.03, 39.3, 34.8, 27.4, 26.1, 26.2, 127.8, 15.43);
                yield return new milk(43, 1.031, 35.6, 34, 26.8, 26.4, 25.7, 125.5, 14.4);
                yield return new milk(44, 1.03, 37.8, 34.1, 27.2, 25.9, 27, 126.9, 15.97);
                yield return new milk(45, 1.031, 35.6, 33.3, 26.4, 25.1, 24.9, 122.6, 14.77);
                yield return new milk(46, 1.031, 35.7, 34.1, 26.8, 25.8, 25.7, 121.7, 14.59);
                yield return new milk(47, 1.0305, 33.3, 33.2, 26.6, 25.1, 25.3, 126.7, 14.17);
                yield return new milk(48, 1.03, 34.4, 33.3, 26.5, 25.2, 25.4, 123, 14.79);
                yield return new milk(49, 1.03, 33.3, 32.2, 25.6, 24.6, 24.3, 121.5, 14.7);
                yield return new milk(50, 1.0305, 38.4, 32.5, 25.8, 24.9, 24.9, 126.2, 15.2);
                yield return new milk(51, 1.0305, 34, 31.9, 25.5, 24.4, 24.3, 122.6, 14.11);
                yield return new milk(52, 1.03, 33.1, 31.1, 24.8, 23.7, 23.9, 119, 14.06);
                yield return new milk(53, 1.0305, 34.8, 32.3, 25.7, 25.2, 24.7, 122.6, 14.09);
                yield return new milk(54, 1.0305, 35.5, 32.7, 26, 25.1, 24.9, 122.7, 14.41);
                yield return new milk(55, 1.031, 35.6, 33.3, 26.5, 25.6, 25.6, 123.3, 14.16);
                yield return new milk(56, 1.03, 36.1, 32.5, 25.7, 24.9, 24.8, 123.1, 14.34);
                yield return new milk(57, 1.0295, 36.2, 32.6, 25.5, 24.7, 24.9, 121.4, 14.04);
                yield return new milk(58, 1.03, 36, 33.5, 26.7, 25.6, 25.7, 121.9, 14.02);
                yield return new milk(59, 1.029, 35.2, 31.8, 25.1, 24.1, 24.1, 122.2, 14);
                yield return new milk(60, 1.03, 35.4, 32.1, 25.5, 24.3, 24.2, 122.1, 13.78);
                yield return new milk(61, 1.03, 36.6, 32.1, 25.3, 24.5, 24.4, 123.4, 14.14);
                yield return new milk(62, 1.03, 37.5, 32.6, 25.6, 24.8, 24.9, 125.4, 14.86);
                yield return new milk(63, 1.03, 36.9, 33.8, 27, 25.6, 25.6, 124.9, 14.29);
                yield return new milk(64, 1.03, 36.9, 33.8, 27, 25.6, 25.6, 124.9, 14.29);
                yield return new milk(65, 1.03, 37.3, 31.5, 24.9, 23.7, 23.8, 123.4, 14.46);
                yield return new milk(66, 1.03, 35.2, 31.7, 25, 24, 23.9, 121.5, 13.82);
                yield return new milk(67, 1.03, 36.4, 32.3, 25.8, 24.6, 24.4, 123.5, 14.54);
                yield return new milk(68, 1.03, 34.5, 31.4, 24.8, 24.1, 24, 123.9, 14.24);
                yield return new milk(69, 1.03, 35.8, 32.1, 25.9, 24.7, 24.4, 122.6, 14.14);
                yield return new milk(70, 1.0295, 36, 31.2, 24.6, 33.8, 33.7, 122.9, 14.05);
                yield return new milk(71, 1.03, 35.8, 31.3, 24.9, 23.7, 23.9, 121.7, 14.04);
                yield return new milk(72, 1.0305, 36.5, 33.1, 26.6, 25.4, 25.4, 125.1, 14.2);
                yield return new milk(73, 1.0305, 35.5, 31.2, 24.7, 23.3, 23, 122.8, 14.15);
                yield return new milk(74, 1.03, 34.5, 30.2, 23.8, 22.8, 22.7, 112.3, 14);
                yield return new milk(75, 1.0305, 35.9, 32, 25.3, 23.3, 24.3, 124.2, 14.35);
                yield return new milk(76, 1.031, 34.3, 32.2, 25.4, 24.6, 24.4, 122.4, 13.98);
                yield return new milk(77, 1.0295, 34.6, 30.8, 23.9, 22.7, 22.7, 115.7, 13.93);
                yield return new milk(78, 1.031, 36.3, 32.6, 25.8, 24.8, 24.7, 124.7, 14.26);
                yield return new milk(79, 1.0305, 35.2, 32.6, 25.5, 24.8, 24.6, 123.3, 14.07);
                yield return new milk(80, 1.03, 34.9, 32.7, 25.8, 24.7, 24.9, 119, 14.42);
                yield return new milk(81, 1.03, 35.9, 33.7, 26.6, 25.6, 25.7, 123.4, 14.2);
                yield return new milk(82, 1.031, 37.6, 33.2, 26.3, 24.9, 24.8, 125.6, 14.94);
                yield return new milk(83, 1.03, 36.1, 33.6, 26.2, 25.6, 25.6, 125.3, 14.43);
                yield return new milk(84, 1.03, 34.1, 33.2, 26, 25.4, 25.2, 124.2, 14.37);
                yield return new milk(85, 1.0305, 39, 32.3, 25.4, 24.4, 24.7, 123.5, 14.4);
                yield return new milk(86, 1.03, 34.4, 33.1, 26.5, 25.6, 25.5, 123.5, 14.18);
            }
        }
    }
}
