// ReSharper disable All

namespace Rdatasets.datasets
{
    using System.Collections.Generic;

    /// <summary>
    /// Sales Data with Leading Indicator
    /// </summary>

    public class BJsales
    {
        public readonly int κ;
        public readonly int time;
        public readonly double value;

        public BJsales(int κ, int time, double value)
        {
            this.κ = κ;
            this.time = time;
            this.value = value;
        }

        public static IEnumerable<BJsales> Data
        {
            get
            {
                yield return new BJsales(1, 1, 200.1);
                yield return new BJsales(2, 2, 199.5);
                yield return new BJsales(3, 3, 199.4);
                yield return new BJsales(4, 4, 198.9);
                yield return new BJsales(5, 5, 199);
                yield return new BJsales(6, 6, 200.2);
                yield return new BJsales(7, 7, 198.6);
                yield return new BJsales(8, 8, 200);
                yield return new BJsales(9, 9, 200.3);
                yield return new BJsales(10, 10, 201.2);
                yield return new BJsales(11, 11, 201.6);
                yield return new BJsales(12, 12, 201.5);
                yield return new BJsales(13, 13, 201.5);
                yield return new BJsales(14, 14, 203.5);
                yield return new BJsales(15, 15, 204.9);
                yield return new BJsales(16, 16, 207.1);
                yield return new BJsales(17, 17, 210.5);
                yield return new BJsales(18, 18, 210.5);
                yield return new BJsales(19, 19, 209.8);
                yield return new BJsales(20, 20, 208.8);
                yield return new BJsales(21, 21, 209.5);
                yield return new BJsales(22, 22, 213.2);
                yield return new BJsales(23, 23, 213.7);
                yield return new BJsales(24, 24, 215.1);
                yield return new BJsales(25, 25, 218.7);
                yield return new BJsales(26, 26, 219.8);
                yield return new BJsales(27, 27, 220.5);
                yield return new BJsales(28, 28, 223.8);
                yield return new BJsales(29, 29, 222.8);
                yield return new BJsales(30, 30, 223.8);
                yield return new BJsales(31, 31, 221.7);
                yield return new BJsales(32, 32, 222.3);
                yield return new BJsales(33, 33, 220.8);
                yield return new BJsales(34, 34, 219.4);
                yield return new BJsales(35, 35, 220.1);
                yield return new BJsales(36, 36, 220.6);
                yield return new BJsales(37, 37, 218.9);
                yield return new BJsales(38, 38, 217.8);
                yield return new BJsales(39, 39, 217.7);
                yield return new BJsales(40, 40, 215);
                yield return new BJsales(41, 41, 215.3);
                yield return new BJsales(42, 42, 215.9);
                yield return new BJsales(43, 43, 216.7);
                yield return new BJsales(44, 44, 216.7);
                yield return new BJsales(45, 45, 217.7);
                yield return new BJsales(46, 46, 218.7);
                yield return new BJsales(47, 47, 222.9);
                yield return new BJsales(48, 48, 224.9);
                yield return new BJsales(49, 49, 222.2);
                yield return new BJsales(50, 50, 220.7);
                yield return new BJsales(51, 51, 220);
                yield return new BJsales(52, 52, 218.7);
                yield return new BJsales(53, 53, 217);
                yield return new BJsales(54, 54, 215.9);
                yield return new BJsales(55, 55, 215.8);
                yield return new BJsales(56, 56, 214.1);
                yield return new BJsales(57, 57, 212.3);
                yield return new BJsales(58, 58, 213.9);
                yield return new BJsales(59, 59, 214.6);
                yield return new BJsales(60, 60, 213.6);
                yield return new BJsales(61, 61, 212.1);
                yield return new BJsales(62, 62, 211.4);
                yield return new BJsales(63, 63, 213.1);
                yield return new BJsales(64, 64, 212.9);
                yield return new BJsales(65, 65, 213.3);
                yield return new BJsales(66, 66, 211.5);
                yield return new BJsales(67, 67, 212.3);
                yield return new BJsales(68, 68, 213);
                yield return new BJsales(69, 69, 211);
                yield return new BJsales(70, 70, 210.7);
                yield return new BJsales(71, 71, 210.1);
                yield return new BJsales(72, 72, 211.4);
                yield return new BJsales(73, 73, 210);
                yield return new BJsales(74, 74, 209.7);
                yield return new BJsales(75, 75, 208.8);
                yield return new BJsales(76, 76, 208.8);
                yield return new BJsales(77, 77, 208.8);
                yield return new BJsales(78, 78, 210.6);
                yield return new BJsales(79, 79, 211.9);
                yield return new BJsales(80, 80, 212.8);
                yield return new BJsales(81, 81, 212.5);
                yield return new BJsales(82, 82, 214.8);
                yield return new BJsales(83, 83, 215.3);
                yield return new BJsales(84, 84, 217.5);
                yield return new BJsales(85, 85, 218.8);
                yield return new BJsales(86, 86, 220.7);
                yield return new BJsales(87, 87, 222.2);
                yield return new BJsales(88, 88, 226.7);
                yield return new BJsales(89, 89, 228.4);
                yield return new BJsales(90, 90, 233.2);
                yield return new BJsales(91, 91, 235.7);
                yield return new BJsales(92, 92, 237.1);
                yield return new BJsales(93, 93, 240.6);
                yield return new BJsales(94, 94, 243.8);
                yield return new BJsales(95, 95, 245.3);
                yield return new BJsales(96, 96, 246);
                yield return new BJsales(97, 97, 246.3);
                yield return new BJsales(98, 98, 247.7);
                yield return new BJsales(99, 99, 247.6);
                yield return new BJsales(100, 100, 247.8);
                yield return new BJsales(101, 101, 249.4);
                yield return new BJsales(102, 102, 249);
                yield return new BJsales(103, 103, 249.9);
                yield return new BJsales(104, 104, 250.5);
                yield return new BJsales(105, 105, 251.5);
                yield return new BJsales(106, 106, 249);
                yield return new BJsales(107, 107, 247.6);
                yield return new BJsales(108, 108, 248.8);
                yield return new BJsales(109, 109, 250.4);
                yield return new BJsales(110, 110, 250.7);
                yield return new BJsales(111, 111, 253);
                yield return new BJsales(112, 112, 253.7);
                yield return new BJsales(113, 113, 255);
                yield return new BJsales(114, 114, 256.2);
                yield return new BJsales(115, 115, 256);
                yield return new BJsales(116, 116, 257.4);
                yield return new BJsales(117, 117, 260.4);
                yield return new BJsales(118, 118, 260);
                yield return new BJsales(119, 119, 261.3);
                yield return new BJsales(120, 120, 260.4);
                yield return new BJsales(121, 121, 261.6);
                yield return new BJsales(122, 122, 260.8);
                yield return new BJsales(123, 123, 259.8);
                yield return new BJsales(124, 124, 259);
                yield return new BJsales(125, 125, 258.9);
                yield return new BJsales(126, 126, 257.4);
                yield return new BJsales(127, 127, 257.7);
                yield return new BJsales(128, 128, 257.9);
                yield return new BJsales(129, 129, 257.4);
                yield return new BJsales(130, 130, 257.3);
                yield return new BJsales(131, 131, 257.6);
                yield return new BJsales(132, 132, 258.9);
                yield return new BJsales(133, 133, 257.8);
                yield return new BJsales(134, 134, 257.7);
                yield return new BJsales(135, 135, 257.2);
                yield return new BJsales(136, 136, 257.5);
                yield return new BJsales(137, 137, 256.8);
                yield return new BJsales(138, 138, 257.5);
                yield return new BJsales(139, 139, 257);
                yield return new BJsales(140, 140, 257.6);
                yield return new BJsales(141, 141, 257.3);
                yield return new BJsales(142, 142, 257.5);
                yield return new BJsales(143, 143, 259.6);
                yield return new BJsales(144, 144, 261.1);
                yield return new BJsales(145, 145, 262.9);
                yield return new BJsales(146, 146, 263.3);
                yield return new BJsales(147, 147, 262.8);
                yield return new BJsales(148, 148, 261.8);
                yield return new BJsales(149, 149, 262.2);
                yield return new BJsales(150, 150, 262.7);
            }
        }
    }
}
