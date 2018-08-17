// ReSharper disable All

namespace Rdatasets.lattice
{
    using System.Collections.Generic;

    /// <summary>
    /// Atmospheric environmental conditions in New York City
    /// </summary>

    public class environmental
    {
        public readonly int ozone;
        public readonly int radiation;
        public readonly int temperature;
        public readonly double wind;

        public environmental(int ozone, int radiation, int temperature, double wind)
        {
            this.ozone = ozone;
            this.radiation = radiation;
            this.temperature = temperature;
            this.wind = wind;
        }

        public static IEnumerable<environmental> Data
        {
            get
            {
                yield return new environmental(41, 190, 67, 7.4);
                yield return new environmental(36, 118, 72, 8);
                yield return new environmental(12, 149, 74, 12.6);
                yield return new environmental(18, 313, 62, 11.5);
                yield return new environmental(23, 299, 65, 8.6);
                yield return new environmental(19, 99, 59, 13.8);
                yield return new environmental(8, 19, 61, 20.1);
                yield return new environmental(16, 256, 69, 9.7);
                yield return new environmental(11, 290, 66, 9.2);
                yield return new environmental(14, 274, 68, 10.9);
                yield return new environmental(18, 65, 58, 13.2);
                yield return new environmental(14, 334, 64, 11.5);
                yield return new environmental(34, 307, 66, 12);
                yield return new environmental(6, 78, 57, 18.4);
                yield return new environmental(30, 322, 68, 11.5);
                yield return new environmental(11, 44, 62, 9.7);
                yield return new environmental(1, 8, 59, 9.7);
                yield return new environmental(11, 320, 73, 16.6);
                yield return new environmental(4, 25, 61, 9.7);
                yield return new environmental(32, 92, 61, 12);
                yield return new environmental(23, 13, 67, 12);
                yield return new environmental(45, 252, 81, 14.9);
                yield return new environmental(115, 223, 79, 5.7);
                yield return new environmental(37, 279, 76, 7.4);
                yield return new environmental(29, 127, 82, 9.7);
                yield return new environmental(71, 291, 90, 13.8);
                yield return new environmental(39, 323, 87, 11.5);
                yield return new environmental(23, 148, 82, 8);
                yield return new environmental(21, 191, 77, 14.9);
                yield return new environmental(37, 284, 72, 20.7);
                yield return new environmental(20, 37, 65, 9.2);
                yield return new environmental(12, 120, 73, 11.5);
                yield return new environmental(13, 137, 76, 10.3);
                yield return new environmental(135, 269, 84, 4);
                yield return new environmental(49, 248, 85, 9.2);
                yield return new environmental(32, 236, 81, 9.2);
                yield return new environmental(64, 175, 83, 4.6);
                yield return new environmental(40, 314, 83, 10.9);
                yield return new environmental(77, 276, 88, 5.1);
                yield return new environmental(97, 267, 92, 6.3);
                yield return new environmental(97, 272, 92, 5.7);
                yield return new environmental(85, 175, 89, 7.4);
                yield return new environmental(10, 264, 73, 14.3);
                yield return new environmental(27, 175, 81, 14.9);
                yield return new environmental(7, 48, 80, 14.3);
                yield return new environmental(48, 260, 81, 6.9);
                yield return new environmental(35, 274, 82, 10.3);
                yield return new environmental(61, 285, 84, 6.3);
                yield return new environmental(79, 187, 87, 5.1);
                yield return new environmental(63, 220, 85, 11.5);
                yield return new environmental(16, 7, 74, 6.9);
                yield return new environmental(80, 294, 86, 8.6);
                yield return new environmental(108, 223, 85, 8);
                yield return new environmental(20, 81, 82, 8.6);
                yield return new environmental(52, 82, 86, 12);
                yield return new environmental(82, 213, 88, 7.4);
                yield return new environmental(50, 275, 86, 7.4);
                yield return new environmental(64, 253, 83, 7.4);
                yield return new environmental(59, 254, 81, 9.2);
                yield return new environmental(39, 83, 81, 6.9);
                yield return new environmental(9, 24, 81, 13.8);
                yield return new environmental(16, 77, 82, 7.4);
                yield return new environmental(122, 255, 89, 4);
                yield return new environmental(89, 229, 90, 10.3);
                yield return new environmental(110, 207, 90, 8);
                yield return new environmental(44, 192, 86, 11.5);
                yield return new environmental(28, 273, 82, 11.5);
                yield return new environmental(65, 157, 80, 9.7);
                yield return new environmental(22, 71, 77, 10.3);
                yield return new environmental(59, 51, 79, 6.3);
                yield return new environmental(23, 115, 76, 7.4);
                yield return new environmental(31, 244, 78, 10.9);
                yield return new environmental(44, 190, 78, 10.3);
                yield return new environmental(21, 259, 77, 15.5);
                yield return new environmental(9, 36, 72, 14.3);
                yield return new environmental(45, 212, 79, 9.7);
                yield return new environmental(168, 238, 81, 3.4);
                yield return new environmental(73, 215, 86, 8);
                yield return new environmental(76, 203, 97, 9.7);
                yield return new environmental(118, 225, 94, 2.3);
                yield return new environmental(84, 237, 96, 6.3);
                yield return new environmental(85, 188, 94, 6.3);
                yield return new environmental(96, 167, 91, 6.9);
                yield return new environmental(78, 197, 92, 5.1);
                yield return new environmental(73, 183, 93, 2.8);
                yield return new environmental(91, 189, 93, 4.6);
                yield return new environmental(47, 95, 87, 7.4);
                yield return new environmental(32, 92, 84, 15.5);
                yield return new environmental(20, 252, 80, 10.9);
                yield return new environmental(23, 220, 78, 10.3);
                yield return new environmental(21, 230, 75, 10.9);
                yield return new environmental(24, 259, 73, 9.7);
                yield return new environmental(44, 236, 81, 14.9);
                yield return new environmental(21, 259, 76, 15.5);
                yield return new environmental(28, 238, 77, 6.3);
                yield return new environmental(9, 24, 71, 10.9);
                yield return new environmental(13, 112, 71, 11.5);
                yield return new environmental(46, 237, 78, 6.9);
                yield return new environmental(18, 224, 67, 13.8);
                yield return new environmental(13, 27, 76, 10.3);
                yield return new environmental(24, 238, 68, 10.3);
                yield return new environmental(16, 201, 82, 8);
                yield return new environmental(13, 238, 64, 12.6);
                yield return new environmental(23, 14, 71, 9.2);
                yield return new environmental(36, 139, 81, 10.3);
                yield return new environmental(7, 49, 69, 10.3);
                yield return new environmental(14, 20, 63, 16.6);
                yield return new environmental(30, 193, 70, 6.9);
                yield return new environmental(14, 191, 75, 14.3);
                yield return new environmental(18, 131, 76, 8);
                yield return new environmental(20, 223, 68, 11.5);
            }
        }
    }
}
