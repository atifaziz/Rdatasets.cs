// ReSharper disable All

namespace Rdatasets.datasets
{
    using System.Collections.Generic;

    /// <summary>
    /// Sales Data with Leading Indicator
    /// </summary>

    public class BJsales
    {
        public readonly int time;
        public readonly double value;

        public BJsales(int time, double value)
        {
            this.time = time;
            this.value = value;
        }

        public static IEnumerable<BJsales> Data
        {
            get
            {
                yield return new BJsales(1, 200.1);
                yield return new BJsales(2, 199.5);
                yield return new BJsales(3, 199.4);
                yield return new BJsales(4, 198.9);
                yield return new BJsales(5, 199);
                yield return new BJsales(6, 200.2);
                yield return new BJsales(7, 198.6);
                yield return new BJsales(8, 200);
                yield return new BJsales(9, 200.3);
                yield return new BJsales(10, 201.2);
                yield return new BJsales(11, 201.6);
                yield return new BJsales(12, 201.5);
                yield return new BJsales(13, 201.5);
                yield return new BJsales(14, 203.5);
                yield return new BJsales(15, 204.9);
                yield return new BJsales(16, 207.1);
                yield return new BJsales(17, 210.5);
                yield return new BJsales(18, 210.5);
                yield return new BJsales(19, 209.8);
                yield return new BJsales(20, 208.8);
                yield return new BJsales(21, 209.5);
                yield return new BJsales(22, 213.2);
                yield return new BJsales(23, 213.7);
                yield return new BJsales(24, 215.1);
                yield return new BJsales(25, 218.7);
                yield return new BJsales(26, 219.8);
                yield return new BJsales(27, 220.5);
                yield return new BJsales(28, 223.8);
                yield return new BJsales(29, 222.8);
                yield return new BJsales(30, 223.8);
                yield return new BJsales(31, 221.7);
                yield return new BJsales(32, 222.3);
                yield return new BJsales(33, 220.8);
                yield return new BJsales(34, 219.4);
                yield return new BJsales(35, 220.1);
                yield return new BJsales(36, 220.6);
                yield return new BJsales(37, 218.9);
                yield return new BJsales(38, 217.8);
                yield return new BJsales(39, 217.7);
                yield return new BJsales(40, 215);
                yield return new BJsales(41, 215.3);
                yield return new BJsales(42, 215.9);
                yield return new BJsales(43, 216.7);
                yield return new BJsales(44, 216.7);
                yield return new BJsales(45, 217.7);
                yield return new BJsales(46, 218.7);
                yield return new BJsales(47, 222.9);
                yield return new BJsales(48, 224.9);
                yield return new BJsales(49, 222.2);
                yield return new BJsales(50, 220.7);
                yield return new BJsales(51, 220);
                yield return new BJsales(52, 218.7);
                yield return new BJsales(53, 217);
                yield return new BJsales(54, 215.9);
                yield return new BJsales(55, 215.8);
                yield return new BJsales(56, 214.1);
                yield return new BJsales(57, 212.3);
                yield return new BJsales(58, 213.9);
                yield return new BJsales(59, 214.6);
                yield return new BJsales(60, 213.6);
                yield return new BJsales(61, 212.1);
                yield return new BJsales(62, 211.4);
                yield return new BJsales(63, 213.1);
                yield return new BJsales(64, 212.9);
                yield return new BJsales(65, 213.3);
                yield return new BJsales(66, 211.5);
                yield return new BJsales(67, 212.3);
                yield return new BJsales(68, 213);
                yield return new BJsales(69, 211);
                yield return new BJsales(70, 210.7);
                yield return new BJsales(71, 210.1);
                yield return new BJsales(72, 211.4);
                yield return new BJsales(73, 210);
                yield return new BJsales(74, 209.7);
                yield return new BJsales(75, 208.8);
                yield return new BJsales(76, 208.8);
                yield return new BJsales(77, 208.8);
                yield return new BJsales(78, 210.6);
                yield return new BJsales(79, 211.9);
                yield return new BJsales(80, 212.8);
                yield return new BJsales(81, 212.5);
                yield return new BJsales(82, 214.8);
                yield return new BJsales(83, 215.3);
                yield return new BJsales(84, 217.5);
                yield return new BJsales(85, 218.8);
                yield return new BJsales(86, 220.7);
                yield return new BJsales(87, 222.2);
                yield return new BJsales(88, 226.7);
                yield return new BJsales(89, 228.4);
                yield return new BJsales(90, 233.2);
                yield return new BJsales(91, 235.7);
                yield return new BJsales(92, 237.1);
                yield return new BJsales(93, 240.6);
                yield return new BJsales(94, 243.8);
                yield return new BJsales(95, 245.3);
                yield return new BJsales(96, 246);
                yield return new BJsales(97, 246.3);
                yield return new BJsales(98, 247.7);
                yield return new BJsales(99, 247.6);
                yield return new BJsales(100, 247.8);
                yield return new BJsales(101, 249.4);
                yield return new BJsales(102, 249);
                yield return new BJsales(103, 249.9);
                yield return new BJsales(104, 250.5);
                yield return new BJsales(105, 251.5);
                yield return new BJsales(106, 249);
                yield return new BJsales(107, 247.6);
                yield return new BJsales(108, 248.8);
                yield return new BJsales(109, 250.4);
                yield return new BJsales(110, 250.7);
                yield return new BJsales(111, 253);
                yield return new BJsales(112, 253.7);
                yield return new BJsales(113, 255);
                yield return new BJsales(114, 256.2);
                yield return new BJsales(115, 256);
                yield return new BJsales(116, 257.4);
                yield return new BJsales(117, 260.4);
                yield return new BJsales(118, 260);
                yield return new BJsales(119, 261.3);
                yield return new BJsales(120, 260.4);
                yield return new BJsales(121, 261.6);
                yield return new BJsales(122, 260.8);
                yield return new BJsales(123, 259.8);
                yield return new BJsales(124, 259);
                yield return new BJsales(125, 258.9);
                yield return new BJsales(126, 257.4);
                yield return new BJsales(127, 257.7);
                yield return new BJsales(128, 257.9);
                yield return new BJsales(129, 257.4);
                yield return new BJsales(130, 257.3);
                yield return new BJsales(131, 257.6);
                yield return new BJsales(132, 258.9);
                yield return new BJsales(133, 257.8);
                yield return new BJsales(134, 257.7);
                yield return new BJsales(135, 257.2);
                yield return new BJsales(136, 257.5);
                yield return new BJsales(137, 256.8);
                yield return new BJsales(138, 257.5);
                yield return new BJsales(139, 257);
                yield return new BJsales(140, 257.6);
                yield return new BJsales(141, 257.3);
                yield return new BJsales(142, 257.5);
                yield return new BJsales(143, 259.6);
                yield return new BJsales(144, 261.1);
                yield return new BJsales(145, 262.9);
                yield return new BJsales(146, 263.3);
                yield return new BJsales(147, 262.8);
                yield return new BJsales(148, 261.8);
                yield return new BJsales(149, 262.2);
                yield return new BJsales(150, 262.7);
            }
        }
    }
}
