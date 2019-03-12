// ReSharper disable All

namespace Rdatasets.lme4
{
    using System.Collections.Generic;

    /// <summary>
    /// Variation in penicillin testing
    /// </summary>

    public class Penicillin
    {
        public readonly int κ;
        public readonly int diameter;
        public readonly string plate;
        public readonly string sample;

        public Penicillin(int κ, int diameter, string plate, string sample)
        {
            this.κ = κ;
            this.diameter = diameter;
            this.plate = plate;
            this.sample = sample;
        }

        public static IEnumerable<Penicillin> Data
        {
            get
            {
                yield return new Penicillin(1, 27, "a", "A");
                yield return new Penicillin(2, 23, "a", "B");
                yield return new Penicillin(3, 26, "a", "C");
                yield return new Penicillin(4, 23, "a", "D");
                yield return new Penicillin(5, 23, "a", "E");
                yield return new Penicillin(6, 21, "a", "F");
                yield return new Penicillin(7, 27, "b", "A");
                yield return new Penicillin(8, 23, "b", "B");
                yield return new Penicillin(9, 26, "b", "C");
                yield return new Penicillin(10, 23, "b", "D");
                yield return new Penicillin(11, 23, "b", "E");
                yield return new Penicillin(12, 21, "b", "F");
                yield return new Penicillin(13, 25, "c", "A");
                yield return new Penicillin(14, 21, "c", "B");
                yield return new Penicillin(15, 25, "c", "C");
                yield return new Penicillin(16, 24, "c", "D");
                yield return new Penicillin(17, 24, "c", "E");
                yield return new Penicillin(18, 20, "c", "F");
                yield return new Penicillin(19, 26, "d", "A");
                yield return new Penicillin(20, 23, "d", "B");
                yield return new Penicillin(21, 25, "d", "C");
                yield return new Penicillin(22, 23, "d", "D");
                yield return new Penicillin(23, 23, "d", "E");
                yield return new Penicillin(24, 20, "d", "F");
                yield return new Penicillin(25, 25, "e", "A");
                yield return new Penicillin(26, 22, "e", "B");
                yield return new Penicillin(27, 26, "e", "C");
                yield return new Penicillin(28, 22, "e", "D");
                yield return new Penicillin(29, 23, "e", "E");
                yield return new Penicillin(30, 20, "e", "F");
                yield return new Penicillin(31, 24, "f", "A");
                yield return new Penicillin(32, 22, "f", "B");
                yield return new Penicillin(33, 25, "f", "C");
                yield return new Penicillin(34, 23, "f", "D");
                yield return new Penicillin(35, 22, "f", "E");
                yield return new Penicillin(36, 19, "f", "F");
                yield return new Penicillin(37, 24, "g", "A");
                yield return new Penicillin(38, 20, "g", "B");
                yield return new Penicillin(39, 23, "g", "C");
                yield return new Penicillin(40, 21, "g", "D");
                yield return new Penicillin(41, 22, "g", "E");
                yield return new Penicillin(42, 19, "g", "F");
                yield return new Penicillin(43, 26, "h", "A");
                yield return new Penicillin(44, 22, "h", "B");
                yield return new Penicillin(45, 26, "h", "C");
                yield return new Penicillin(46, 24, "h", "D");
                yield return new Penicillin(47, 24, "h", "E");
                yield return new Penicillin(48, 21, "h", "F");
                yield return new Penicillin(49, 24, "i", "A");
                yield return new Penicillin(50, 21, "i", "B");
                yield return new Penicillin(51, 24, "i", "C");
                yield return new Penicillin(52, 22, "i", "D");
                yield return new Penicillin(53, 22, "i", "E");
                yield return new Penicillin(54, 20, "i", "F");
                yield return new Penicillin(55, 24, "j", "A");
                yield return new Penicillin(56, 21, "j", "B");
                yield return new Penicillin(57, 24, "j", "C");
                yield return new Penicillin(58, 23, "j", "D");
                yield return new Penicillin(59, 22, "j", "E");
                yield return new Penicillin(60, 19, "j", "F");
                yield return new Penicillin(61, 26, "k", "A");
                yield return new Penicillin(62, 23, "k", "B");
                yield return new Penicillin(63, 26, "k", "C");
                yield return new Penicillin(64, 24, "k", "D");
                yield return new Penicillin(65, 24, "k", "E");
                yield return new Penicillin(66, 21, "k", "F");
                yield return new Penicillin(67, 25, "l", "A");
                yield return new Penicillin(68, 22, "l", "B");
                yield return new Penicillin(69, 26, "l", "C");
                yield return new Penicillin(70, 24, "l", "D");
                yield return new Penicillin(71, 24, "l", "E");
                yield return new Penicillin(72, 20, "l", "F");
                yield return new Penicillin(73, 26, "m", "A");
                yield return new Penicillin(74, 24, "m", "B");
                yield return new Penicillin(75, 26, "m", "C");
                yield return new Penicillin(76, 24, "m", "D");
                yield return new Penicillin(77, 25, "m", "E");
                yield return new Penicillin(78, 22, "m", "F");
                yield return new Penicillin(79, 26, "n", "A");
                yield return new Penicillin(80, 23, "n", "B");
                yield return new Penicillin(81, 26, "n", "C");
                yield return new Penicillin(82, 23, "n", "D");
                yield return new Penicillin(83, 23, "n", "E");
                yield return new Penicillin(84, 20, "n", "F");
                yield return new Penicillin(85, 26, "o", "A");
                yield return new Penicillin(86, 23, "o", "B");
                yield return new Penicillin(87, 25, "o", "C");
                yield return new Penicillin(88, 24, "o", "D");
                yield return new Penicillin(89, 24, "o", "E");
                yield return new Penicillin(90, 22, "o", "F");
                yield return new Penicillin(91, 25, "p", "A");
                yield return new Penicillin(92, 22, "p", "B");
                yield return new Penicillin(93, 25, "p", "C");
                yield return new Penicillin(94, 23, "p", "D");
                yield return new Penicillin(95, 23, "p", "E");
                yield return new Penicillin(96, 20, "p", "F");
                yield return new Penicillin(97, 25, "q", "A");
                yield return new Penicillin(98, 21, "q", "B");
                yield return new Penicillin(99, 24, "q", "C");
                yield return new Penicillin(100, 23, "q", "D");
                yield return new Penicillin(101, 23, "q", "E");
                yield return new Penicillin(102, 20, "q", "F");
                yield return new Penicillin(103, 25, "r", "A");
                yield return new Penicillin(104, 22, "r", "B");
                yield return new Penicillin(105, 24, "r", "C");
                yield return new Penicillin(106, 23, "r", "D");
                yield return new Penicillin(107, 23, "r", "E");
                yield return new Penicillin(108, 19, "r", "F");
                yield return new Penicillin(109, 24, "s", "A");
                yield return new Penicillin(110, 21, "s", "B");
                yield return new Penicillin(111, 23, "s", "C");
                yield return new Penicillin(112, 21, "s", "D");
                yield return new Penicillin(113, 21, "s", "E");
                yield return new Penicillin(114, 19, "s", "F");
                yield return new Penicillin(115, 26, "t", "A");
                yield return new Penicillin(116, 23, "t", "B");
                yield return new Penicillin(117, 26, "t", "C");
                yield return new Penicillin(118, 24, "t", "D");
                yield return new Penicillin(119, 24, "t", "E");
                yield return new Penicillin(120, 21, "t", "F");
                yield return new Penicillin(121, 25, "u", "A");
                yield return new Penicillin(122, 21, "u", "B");
                yield return new Penicillin(123, 24, "u", "C");
                yield return new Penicillin(124, 22, "u", "D");
                yield return new Penicillin(125, 22, "u", "E");
                yield return new Penicillin(126, 18, "u", "F");
                yield return new Penicillin(127, 25, "v", "A");
                yield return new Penicillin(128, 22, "v", "B");
                yield return new Penicillin(129, 25, "v", "C");
                yield return new Penicillin(130, 22, "v", "D");
                yield return new Penicillin(131, 22, "v", "E");
                yield return new Penicillin(132, 20, "v", "F");
                yield return new Penicillin(133, 24, "w", "A");
                yield return new Penicillin(134, 21, "w", "B");
                yield return new Penicillin(135, 24, "w", "C");
                yield return new Penicillin(136, 22, "w", "D");
                yield return new Penicillin(137, 24, "w", "E");
                yield return new Penicillin(138, 19, "w", "F");
                yield return new Penicillin(139, 24, "x", "A");
                yield return new Penicillin(140, 21, "x", "B");
                yield return new Penicillin(141, 24, "x", "C");
                yield return new Penicillin(142, 22, "x", "D");
                yield return new Penicillin(143, 21, "x", "E");
                yield return new Penicillin(144, 18, "x", "F");
            }
        }
    }
}
