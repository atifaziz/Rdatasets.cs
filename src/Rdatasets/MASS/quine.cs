// ReSharper disable All

namespace Rdatasets.MASS
{
    using System.Collections.Generic;

    /// <summary>
    /// Absenteeism from School in Rural New South Wales
    /// </summary>

    public class quine
    {
        public readonly int κ;
        public readonly string Eth;
        public readonly string Sex;
        public readonly string Age;
        public readonly string Lrn;
        public readonly int Days;

        public quine(int κ, string Eth, string Sex, string Age, string Lrn, int Days)
        {
            this.κ = κ;
            this.Eth = Eth;
            this.Sex = Sex;
            this.Age = Age;
            this.Lrn = Lrn;
            this.Days = Days;
        }

        public static IEnumerable<quine> Data
        {
            get
            {
                yield return new quine(1, "A", "M", "F0", "SL", 2);
                yield return new quine(2, "A", "M", "F0", "SL", 11);
                yield return new quine(3, "A", "M", "F0", "SL", 14);
                yield return new quine(4, "A", "M", "F0", "AL", 5);
                yield return new quine(5, "A", "M", "F0", "AL", 5);
                yield return new quine(6, "A", "M", "F0", "AL", 13);
                yield return new quine(7, "A", "M", "F0", "AL", 20);
                yield return new quine(8, "A", "M", "F0", "AL", 22);
                yield return new quine(9, "A", "M", "F1", "SL", 6);
                yield return new quine(10, "A", "M", "F1", "SL", 6);
                yield return new quine(11, "A", "M", "F1", "SL", 15);
                yield return new quine(12, "A", "M", "F1", "AL", 7);
                yield return new quine(13, "A", "M", "F1", "AL", 14);
                yield return new quine(14, "A", "M", "F2", "SL", 6);
                yield return new quine(15, "A", "M", "F2", "SL", 32);
                yield return new quine(16, "A", "M", "F2", "SL", 53);
                yield return new quine(17, "A", "M", "F2", "SL", 57);
                yield return new quine(18, "A", "M", "F2", "AL", 14);
                yield return new quine(19, "A", "M", "F2", "AL", 16);
                yield return new quine(20, "A", "M", "F2", "AL", 16);
                yield return new quine(21, "A", "M", "F2", "AL", 17);
                yield return new quine(22, "A", "M", "F2", "AL", 40);
                yield return new quine(23, "A", "M", "F2", "AL", 43);
                yield return new quine(24, "A", "M", "F2", "AL", 46);
                yield return new quine(25, "A", "M", "F3", "AL", 8);
                yield return new quine(26, "A", "M", "F3", "AL", 23);
                yield return new quine(27, "A", "M", "F3", "AL", 23);
                yield return new quine(28, "A", "M", "F3", "AL", 28);
                yield return new quine(29, "A", "M", "F3", "AL", 34);
                yield return new quine(30, "A", "M", "F3", "AL", 36);
                yield return new quine(31, "A", "M", "F3", "AL", 38);
                yield return new quine(32, "A", "F", "F0", "SL", 3);
                yield return new quine(33, "A", "F", "F0", "AL", 5);
                yield return new quine(34, "A", "F", "F0", "AL", 11);
                yield return new quine(35, "A", "F", "F0", "AL", 24);
                yield return new quine(36, "A", "F", "F0", "AL", 45);
                yield return new quine(37, "A", "F", "F1", "SL", 5);
                yield return new quine(38, "A", "F", "F1", "SL", 6);
                yield return new quine(39, "A", "F", "F1", "SL", 6);
                yield return new quine(40, "A", "F", "F1", "SL", 9);
                yield return new quine(41, "A", "F", "F1", "SL", 13);
                yield return new quine(42, "A", "F", "F1", "SL", 23);
                yield return new quine(43, "A", "F", "F1", "SL", 25);
                yield return new quine(44, "A", "F", "F1", "SL", 32);
                yield return new quine(45, "A", "F", "F1", "SL", 53);
                yield return new quine(46, "A", "F", "F1", "SL", 54);
                yield return new quine(47, "A", "F", "F1", "AL", 5);
                yield return new quine(48, "A", "F", "F1", "AL", 5);
                yield return new quine(49, "A", "F", "F1", "AL", 11);
                yield return new quine(50, "A", "F", "F1", "AL", 17);
                yield return new quine(51, "A", "F", "F1", "AL", 19);
                yield return new quine(52, "A", "F", "F2", "SL", 8);
                yield return new quine(53, "A", "F", "F2", "SL", 13);
                yield return new quine(54, "A", "F", "F2", "SL", 14);
                yield return new quine(55, "A", "F", "F2", "SL", 20);
                yield return new quine(56, "A", "F", "F2", "SL", 47);
                yield return new quine(57, "A", "F", "F2", "SL", 48);
                yield return new quine(58, "A", "F", "F2", "SL", 60);
                yield return new quine(59, "A", "F", "F2", "SL", 81);
                yield return new quine(60, "A", "F", "F2", "AL", 2);
                yield return new quine(61, "A", "F", "F3", "AL", 0);
                yield return new quine(62, "A", "F", "F3", "AL", 2);
                yield return new quine(63, "A", "F", "F3", "AL", 3);
                yield return new quine(64, "A", "F", "F3", "AL", 5);
                yield return new quine(65, "A", "F", "F3", "AL", 10);
                yield return new quine(66, "A", "F", "F3", "AL", 14);
                yield return new quine(67, "A", "F", "F3", "AL", 21);
                yield return new quine(68, "A", "F", "F3", "AL", 36);
                yield return new quine(69, "A", "F", "F3", "AL", 40);
                yield return new quine(70, "N", "M", "F0", "SL", 6);
                yield return new quine(71, "N", "M", "F0", "SL", 17);
                yield return new quine(72, "N", "M", "F0", "SL", 67);
                yield return new quine(73, "N", "M", "F0", "AL", 0);
                yield return new quine(74, "N", "M", "F0", "AL", 0);
                yield return new quine(75, "N", "M", "F0", "AL", 2);
                yield return new quine(76, "N", "M", "F0", "AL", 7);
                yield return new quine(77, "N", "M", "F0", "AL", 11);
                yield return new quine(78, "N", "M", "F0", "AL", 12);
                yield return new quine(79, "N", "M", "F1", "SL", 0);
                yield return new quine(80, "N", "M", "F1", "SL", 0);
                yield return new quine(81, "N", "M", "F1", "SL", 5);
                yield return new quine(82, "N", "M", "F1", "SL", 5);
                yield return new quine(83, "N", "M", "F1", "SL", 5);
                yield return new quine(84, "N", "M", "F1", "SL", 11);
                yield return new quine(85, "N", "M", "F1", "SL", 17);
                yield return new quine(86, "N", "M", "F1", "AL", 3);
                yield return new quine(87, "N", "M", "F1", "AL", 4);
                yield return new quine(88, "N", "M", "F2", "SL", 22);
                yield return new quine(89, "N", "M", "F2", "SL", 30);
                yield return new quine(90, "N", "M", "F2", "SL", 36);
                yield return new quine(91, "N", "M", "F2", "AL", 8);
                yield return new quine(92, "N", "M", "F2", "AL", 0);
                yield return new quine(93, "N", "M", "F2", "AL", 1);
                yield return new quine(94, "N", "M", "F2", "AL", 5);
                yield return new quine(95, "N", "M", "F2", "AL", 7);
                yield return new quine(96, "N", "M", "F2", "AL", 16);
                yield return new quine(97, "N", "M", "F2", "AL", 27);
                yield return new quine(98, "N", "M", "F3", "AL", 0);
                yield return new quine(99, "N", "M", "F3", "AL", 30);
                yield return new quine(100, "N", "M", "F3", "AL", 10);
                yield return new quine(101, "N", "M", "F3", "AL", 14);
                yield return new quine(102, "N", "M", "F3", "AL", 27);
                yield return new quine(103, "N", "M", "F3", "AL", 41);
                yield return new quine(104, "N", "M", "F3", "AL", 69);
                yield return new quine(105, "N", "F", "F0", "SL", 25);
                yield return new quine(106, "N", "F", "F0", "AL", 10);
                yield return new quine(107, "N", "F", "F0", "AL", 11);
                yield return new quine(108, "N", "F", "F0", "AL", 20);
                yield return new quine(109, "N", "F", "F0", "AL", 33);
                yield return new quine(110, "N", "F", "F1", "SL", 5);
                yield return new quine(111, "N", "F", "F1", "SL", 7);
                yield return new quine(112, "N", "F", "F1", "SL", 0);
                yield return new quine(113, "N", "F", "F1", "SL", 1);
                yield return new quine(114, "N", "F", "F1", "SL", 5);
                yield return new quine(115, "N", "F", "F1", "SL", 5);
                yield return new quine(116, "N", "F", "F1", "SL", 5);
                yield return new quine(117, "N", "F", "F1", "SL", 5);
                yield return new quine(118, "N", "F", "F1", "SL", 7);
                yield return new quine(119, "N", "F", "F1", "SL", 11);
                yield return new quine(120, "N", "F", "F1", "SL", 15);
                yield return new quine(121, "N", "F", "F1", "AL", 5);
                yield return new quine(122, "N", "F", "F1", "AL", 14);
                yield return new quine(123, "N", "F", "F1", "AL", 6);
                yield return new quine(124, "N", "F", "F1", "AL", 6);
                yield return new quine(125, "N", "F", "F1", "AL", 7);
                yield return new quine(126, "N", "F", "F1", "AL", 28);
                yield return new quine(127, "N", "F", "F2", "SL", 0);
                yield return new quine(128, "N", "F", "F2", "SL", 5);
                yield return new quine(129, "N", "F", "F2", "SL", 14);
                yield return new quine(130, "N", "F", "F2", "SL", 2);
                yield return new quine(131, "N", "F", "F2", "SL", 2);
                yield return new quine(132, "N", "F", "F2", "SL", 3);
                yield return new quine(133, "N", "F", "F2", "SL", 8);
                yield return new quine(134, "N", "F", "F2", "SL", 10);
                yield return new quine(135, "N", "F", "F2", "SL", 12);
                yield return new quine(136, "N", "F", "F2", "AL", 1);
                yield return new quine(137, "N", "F", "F3", "AL", 1);
                yield return new quine(138, "N", "F", "F3", "AL", 9);
                yield return new quine(139, "N", "F", "F3", "AL", 22);
                yield return new quine(140, "N", "F", "F3", "AL", 3);
                yield return new quine(141, "N", "F", "F3", "AL", 3);
                yield return new quine(142, "N", "F", "F3", "AL", 5);
                yield return new quine(143, "N", "F", "F3", "AL", 15);
                yield return new quine(144, "N", "F", "F3", "AL", 18);
                yield return new quine(145, "N", "F", "F3", "AL", 22);
                yield return new quine(146, "N", "F", "F3", "AL", 37);
            }
        }
    }
}
