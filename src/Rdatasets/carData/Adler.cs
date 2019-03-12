// ReSharper disable All

namespace Rdatasets.carData
{
    using System.Collections.Generic;

    /// <summary>
    /// Experimenter Expectations
    /// </summary>

    public class Adler
    {
        public readonly int κ;
        public readonly string instruction;
        public readonly string expectation;
        public readonly int rating;

        public Adler(int κ, string instruction, string expectation, int rating)
        {
            this.κ = κ;
            this.instruction = instruction;
            this.expectation = expectation;
            this.rating = rating;
        }

        public static IEnumerable<Adler> Data
        {
            get
            {
                yield return new Adler(1, "good", "high", 25);
                yield return new Adler(2, "good", "high", 0);
                yield return new Adler(3, "good", "high", -16);
                yield return new Adler(4, "good", "high", 5);
                yield return new Adler(5, "good", "high", 11);
                yield return new Adler(6, "good", "high", -6);
                yield return new Adler(7, "good", "high", 42);
                yield return new Adler(8, "good", "high", -2);
                yield return new Adler(9, "good", "high", -13);
                yield return new Adler(10, "good", "high", 14);
                yield return new Adler(11, "good", "high", 4);
                yield return new Adler(12, "good", "high", -22);
                yield return new Adler(13, "good", "high", 19);
                yield return new Adler(14, "good", "high", 6);
                yield return new Adler(15, "good", "high", -6);
                yield return new Adler(16, "good", "high", 9);
                yield return new Adler(17, "good", "high", 13);
                yield return new Adler(18, "good", "high", -3);
                yield return new Adler(19, "good", "low", -25);
                yield return new Adler(20, "good", "low", -23);
                yield return new Adler(21, "good", "low", -28);
                yield return new Adler(22, "good", "low", -22);
                yield return new Adler(23, "good", "low", -22);
                yield return new Adler(24, "good", "low", -10);
                yield return new Adler(25, "good", "low", -20);
                yield return new Adler(26, "good", "low", -24);
                yield return new Adler(27, "good", "low", -24);
                yield return new Adler(28, "good", "low", -22);
                yield return new Adler(29, "good", "low", -23);
                yield return new Adler(30, "good", "low", -19);
                yield return new Adler(31, "good", "low", -2);
                yield return new Adler(32, "good", "low", 12);
                yield return new Adler(33, "good", "low", -8);
                yield return new Adler(34, "good", "low", -17);
                yield return new Adler(35, "good", "low", -30);
                yield return new Adler(36, "good", "low", -22);
                yield return new Adler(37, "scientific", "high", -19);
                yield return new Adler(38, "scientific", "high", -24);
                yield return new Adler(39, "scientific", "high", -4);
                yield return new Adler(40, "scientific", "high", -24);
                yield return new Adler(41, "scientific", "high", 0);
                yield return new Adler(42, "scientific", "high", -4);
                yield return new Adler(43, "scientific", "high", 5);
                yield return new Adler(44, "scientific", "high", -1);
                yield return new Adler(45, "scientific", "high", -9);
                yield return new Adler(46, "scientific", "high", -5);
                yield return new Adler(47, "scientific", "high", -6);
                yield return new Adler(48, "scientific", "high", 4);
                yield return new Adler(49, "scientific", "high", -13);
                yield return new Adler(50, "scientific", "high", -1);
                yield return new Adler(51, "scientific", "high", -3);
                yield return new Adler(52, "scientific", "high", -11);
                yield return new Adler(53, "scientific", "high", -6);
                yield return new Adler(54, "scientific", "high", -4);
                yield return new Adler(55, "scientific", "low", 6);
                yield return new Adler(56, "scientific", "low", -5);
                yield return new Adler(57, "scientific", "low", 14);
                yield return new Adler(58, "scientific", "low", -11);
                yield return new Adler(59, "scientific", "low", 14);
                yield return new Adler(60, "scientific", "low", -5);
                yield return new Adler(61, "scientific", "low", -22);
                yield return new Adler(62, "scientific", "low", 7);
                yield return new Adler(63, "scientific", "low", 14);
                yield return new Adler(64, "scientific", "low", 15);
                yield return new Adler(65, "scientific", "low", -6);
                yield return new Adler(66, "scientific", "low", 9);
                yield return new Adler(67, "scientific", "low", -5);
                yield return new Adler(68, "scientific", "low", -5);
                yield return new Adler(69, "scientific", "low", -9);
                yield return new Adler(70, "scientific", "low", 3);
                yield return new Adler(71, "scientific", "low", -5);
                yield return new Adler(72, "scientific", "low", 6);
                yield return new Adler(73, "none", "high", -26);
                yield return new Adler(74, "none", "high", -1);
                yield return new Adler(75, "none", "high", 22);
                yield return new Adler(76, "none", "high", 3);
                yield return new Adler(77, "none", "high", -26);
                yield return new Adler(78, "none", "high", 4);
                yield return new Adler(79, "none", "high", -21);
                yield return new Adler(80, "none", "high", -19);
                yield return new Adler(81, "none", "high", -12);
                yield return new Adler(82, "none", "high", 9);
                yield return new Adler(83, "none", "high", -9);
                yield return new Adler(84, "none", "high", -27);
                yield return new Adler(85, "none", "high", -10);
                yield return new Adler(86, "none", "high", -37);
                yield return new Adler(87, "none", "high", 0);
                yield return new Adler(88, "none", "high", -10);
                yield return new Adler(89, "none", "high", -6);
                yield return new Adler(90, "none", "high", -11);
                yield return new Adler(91, "none", "low", -12);
                yield return new Adler(92, "none", "low", -4);
                yield return new Adler(93, "none", "low", 13);
                yield return new Adler(94, "none", "low", -27);
                yield return new Adler(95, "none", "low", -7);
                yield return new Adler(96, "none", "low", -20);
                yield return new Adler(97, "none", "low", -4);
                yield return new Adler(98, "none", "low", -10);
                yield return new Adler(99, "none", "low", -3);
                yield return new Adler(100, "none", "low", -11);
                yield return new Adler(101, "none", "low", 2);
                yield return new Adler(102, "none", "low", -9);
                yield return new Adler(103, "none", "low", 20);
                yield return new Adler(104, "none", "low", 9);
                yield return new Adler(105, "none", "low", -8);
                yield return new Adler(106, "none", "low", 8);
                yield return new Adler(107, "none", "low", -6);
                yield return new Adler(108, "none", "low", 6);
            }
        }
    }
}
