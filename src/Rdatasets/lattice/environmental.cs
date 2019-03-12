// ReSharper disable All

namespace Rdatasets.lattice
{
    using System.Collections.Generic;

    /// <summary>
    /// Atmospheric environmental conditions in New York City
    /// </summary>

    public class environmental
    {
        public readonly int κ;
        public readonly int ozone;
        public readonly int radiation;
        public readonly int temperature;
        public readonly double wind;

        public environmental(int κ, int ozone, int radiation, int temperature, double wind)
        {
            this.κ = κ;
            this.ozone = ozone;
            this.radiation = radiation;
            this.temperature = temperature;
            this.wind = wind;
        }

        public static IEnumerable<environmental> Data
        {
            get
            {
                yield return new environmental(1, 41, 190, 67, 7.4);
                yield return new environmental(2, 36, 118, 72, 8);
                yield return new environmental(3, 12, 149, 74, 12.6);
                yield return new environmental(4, 18, 313, 62, 11.5);
                yield return new environmental(5, 23, 299, 65, 8.6);
                yield return new environmental(6, 19, 99, 59, 13.8);
                yield return new environmental(7, 8, 19, 61, 20.1);
                yield return new environmental(8, 16, 256, 69, 9.7);
                yield return new environmental(9, 11, 290, 66, 9.2);
                yield return new environmental(10, 14, 274, 68, 10.9);
                yield return new environmental(11, 18, 65, 58, 13.2);
                yield return new environmental(12, 14, 334, 64, 11.5);
                yield return new environmental(13, 34, 307, 66, 12);
                yield return new environmental(14, 6, 78, 57, 18.4);
                yield return new environmental(15, 30, 322, 68, 11.5);
                yield return new environmental(16, 11, 44, 62, 9.7);
                yield return new environmental(17, 1, 8, 59, 9.7);
                yield return new environmental(18, 11, 320, 73, 16.6);
                yield return new environmental(19, 4, 25, 61, 9.7);
                yield return new environmental(20, 32, 92, 61, 12);
                yield return new environmental(21, 23, 13, 67, 12);
                yield return new environmental(22, 45, 252, 81, 14.9);
                yield return new environmental(23, 115, 223, 79, 5.7);
                yield return new environmental(24, 37, 279, 76, 7.4);
                yield return new environmental(25, 29, 127, 82, 9.7);
                yield return new environmental(26, 71, 291, 90, 13.8);
                yield return new environmental(27, 39, 323, 87, 11.5);
                yield return new environmental(28, 23, 148, 82, 8);
                yield return new environmental(29, 21, 191, 77, 14.9);
                yield return new environmental(30, 37, 284, 72, 20.7);
                yield return new environmental(31, 20, 37, 65, 9.2);
                yield return new environmental(32, 12, 120, 73, 11.5);
                yield return new environmental(33, 13, 137, 76, 10.3);
                yield return new environmental(34, 135, 269, 84, 4);
                yield return new environmental(35, 49, 248, 85, 9.2);
                yield return new environmental(36, 32, 236, 81, 9.2);
                yield return new environmental(37, 64, 175, 83, 4.6);
                yield return new environmental(38, 40, 314, 83, 10.9);
                yield return new environmental(39, 77, 276, 88, 5.1);
                yield return new environmental(40, 97, 267, 92, 6.3);
                yield return new environmental(41, 97, 272, 92, 5.7);
                yield return new environmental(42, 85, 175, 89, 7.4);
                yield return new environmental(43, 10, 264, 73, 14.3);
                yield return new environmental(44, 27, 175, 81, 14.9);
                yield return new environmental(45, 7, 48, 80, 14.3);
                yield return new environmental(46, 48, 260, 81, 6.9);
                yield return new environmental(47, 35, 274, 82, 10.3);
                yield return new environmental(48, 61, 285, 84, 6.3);
                yield return new environmental(49, 79, 187, 87, 5.1);
                yield return new environmental(50, 63, 220, 85, 11.5);
                yield return new environmental(51, 16, 7, 74, 6.9);
                yield return new environmental(52, 80, 294, 86, 8.6);
                yield return new environmental(53, 108, 223, 85, 8);
                yield return new environmental(54, 20, 81, 82, 8.6);
                yield return new environmental(55, 52, 82, 86, 12);
                yield return new environmental(56, 82, 213, 88, 7.4);
                yield return new environmental(57, 50, 275, 86, 7.4);
                yield return new environmental(58, 64, 253, 83, 7.4);
                yield return new environmental(59, 59, 254, 81, 9.2);
                yield return new environmental(60, 39, 83, 81, 6.9);
                yield return new environmental(61, 9, 24, 81, 13.8);
                yield return new environmental(62, 16, 77, 82, 7.4);
                yield return new environmental(63, 122, 255, 89, 4);
                yield return new environmental(64, 89, 229, 90, 10.3);
                yield return new environmental(65, 110, 207, 90, 8);
                yield return new environmental(66, 44, 192, 86, 11.5);
                yield return new environmental(67, 28, 273, 82, 11.5);
                yield return new environmental(68, 65, 157, 80, 9.7);
                yield return new environmental(69, 22, 71, 77, 10.3);
                yield return new environmental(70, 59, 51, 79, 6.3);
                yield return new environmental(71, 23, 115, 76, 7.4);
                yield return new environmental(72, 31, 244, 78, 10.9);
                yield return new environmental(73, 44, 190, 78, 10.3);
                yield return new environmental(74, 21, 259, 77, 15.5);
                yield return new environmental(75, 9, 36, 72, 14.3);
                yield return new environmental(76, 45, 212, 79, 9.7);
                yield return new environmental(77, 168, 238, 81, 3.4);
                yield return new environmental(78, 73, 215, 86, 8);
                yield return new environmental(79, 76, 203, 97, 9.7);
                yield return new environmental(80, 118, 225, 94, 2.3);
                yield return new environmental(81, 84, 237, 96, 6.3);
                yield return new environmental(82, 85, 188, 94, 6.3);
                yield return new environmental(83, 96, 167, 91, 6.9);
                yield return new environmental(84, 78, 197, 92, 5.1);
                yield return new environmental(85, 73, 183, 93, 2.8);
                yield return new environmental(86, 91, 189, 93, 4.6);
                yield return new environmental(87, 47, 95, 87, 7.4);
                yield return new environmental(88, 32, 92, 84, 15.5);
                yield return new environmental(89, 20, 252, 80, 10.9);
                yield return new environmental(90, 23, 220, 78, 10.3);
                yield return new environmental(91, 21, 230, 75, 10.9);
                yield return new environmental(92, 24, 259, 73, 9.7);
                yield return new environmental(93, 44, 236, 81, 14.9);
                yield return new environmental(94, 21, 259, 76, 15.5);
                yield return new environmental(95, 28, 238, 77, 6.3);
                yield return new environmental(96, 9, 24, 71, 10.9);
                yield return new environmental(97, 13, 112, 71, 11.5);
                yield return new environmental(98, 46, 237, 78, 6.9);
                yield return new environmental(99, 18, 224, 67, 13.8);
                yield return new environmental(100, 13, 27, 76, 10.3);
                yield return new environmental(101, 24, 238, 68, 10.3);
                yield return new environmental(102, 16, 201, 82, 8);
                yield return new environmental(103, 13, 238, 64, 12.6);
                yield return new environmental(104, 23, 14, 71, 9.2);
                yield return new environmental(105, 36, 139, 81, 10.3);
                yield return new environmental(106, 7, 49, 69, 10.3);
                yield return new environmental(107, 14, 20, 63, 16.6);
                yield return new environmental(108, 30, 193, 70, 6.9);
                yield return new environmental(109, 14, 191, 75, 14.3);
                yield return new environmental(110, 18, 131, 76, 8);
                yield return new environmental(111, 20, 223, 68, 11.5);
            }
        }
    }
}
