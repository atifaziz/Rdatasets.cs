// ReSharper disable All

namespace Rdatasets.MASS
{
    using System.Collections.Generic;

    /// <summary>
    /// Michelson's Speed of Light Data
    /// </summary>

    public class michelson
    {
        public readonly int κ;
        public readonly int Speed;
        public readonly int Run;
        public readonly int Expt;

        public michelson(int κ, int Speed, int Run, int Expt)
        {
            this.κ = κ;
            this.Speed = Speed;
            this.Run = Run;
            this.Expt = Expt;
        }

        public static IEnumerable<michelson> Data
        {
            get
            {
                yield return new michelson(1, 850, 1, 1);
                yield return new michelson(2, 740, 2, 1);
                yield return new michelson(3, 900, 3, 1);
                yield return new michelson(4, 1070, 4, 1);
                yield return new michelson(5, 930, 5, 1);
                yield return new michelson(6, 850, 6, 1);
                yield return new michelson(7, 950, 7, 1);
                yield return new michelson(8, 980, 8, 1);
                yield return new michelson(9, 980, 9, 1);
                yield return new michelson(10, 880, 10, 1);
                yield return new michelson(11, 1000, 11, 1);
                yield return new michelson(12, 980, 12, 1);
                yield return new michelson(13, 930, 13, 1);
                yield return new michelson(14, 650, 14, 1);
                yield return new michelson(15, 760, 15, 1);
                yield return new michelson(16, 810, 16, 1);
                yield return new michelson(17, 1000, 17, 1);
                yield return new michelson(18, 1000, 18, 1);
                yield return new michelson(19, 960, 19, 1);
                yield return new michelson(20, 960, 20, 1);
                yield return new michelson(21, 960, 1, 2);
                yield return new michelson(22, 940, 2, 2);
                yield return new michelson(23, 960, 3, 2);
                yield return new michelson(24, 940, 4, 2);
                yield return new michelson(25, 880, 5, 2);
                yield return new michelson(26, 800, 6, 2);
                yield return new michelson(27, 850, 7, 2);
                yield return new michelson(28, 880, 8, 2);
                yield return new michelson(29, 900, 9, 2);
                yield return new michelson(30, 840, 10, 2);
                yield return new michelson(31, 830, 11, 2);
                yield return new michelson(32, 790, 12, 2);
                yield return new michelson(33, 810, 13, 2);
                yield return new michelson(34, 880, 14, 2);
                yield return new michelson(35, 880, 15, 2);
                yield return new michelson(36, 830, 16, 2);
                yield return new michelson(37, 800, 17, 2);
                yield return new michelson(38, 790, 18, 2);
                yield return new michelson(39, 760, 19, 2);
                yield return new michelson(40, 800, 20, 2);
                yield return new michelson(41, 880, 1, 3);
                yield return new michelson(42, 880, 2, 3);
                yield return new michelson(43, 880, 3, 3);
                yield return new michelson(44, 860, 4, 3);
                yield return new michelson(45, 720, 5, 3);
                yield return new michelson(46, 720, 6, 3);
                yield return new michelson(47, 620, 7, 3);
                yield return new michelson(48, 860, 8, 3);
                yield return new michelson(49, 970, 9, 3);
                yield return new michelson(50, 950, 10, 3);
                yield return new michelson(51, 880, 11, 3);
                yield return new michelson(52, 910, 12, 3);
                yield return new michelson(53, 850, 13, 3);
                yield return new michelson(54, 870, 14, 3);
                yield return new michelson(55, 840, 15, 3);
                yield return new michelson(56, 840, 16, 3);
                yield return new michelson(57, 850, 17, 3);
                yield return new michelson(58, 840, 18, 3);
                yield return new michelson(59, 840, 19, 3);
                yield return new michelson(60, 840, 20, 3);
                yield return new michelson(61, 890, 1, 4);
                yield return new michelson(62, 810, 2, 4);
                yield return new michelson(63, 810, 3, 4);
                yield return new michelson(64, 820, 4, 4);
                yield return new michelson(65, 800, 5, 4);
                yield return new michelson(66, 770, 6, 4);
                yield return new michelson(67, 760, 7, 4);
                yield return new michelson(68, 740, 8, 4);
                yield return new michelson(69, 750, 9, 4);
                yield return new michelson(70, 760, 10, 4);
                yield return new michelson(71, 910, 11, 4);
                yield return new michelson(72, 920, 12, 4);
                yield return new michelson(73, 890, 13, 4);
                yield return new michelson(74, 860, 14, 4);
                yield return new michelson(75, 880, 15, 4);
                yield return new michelson(76, 720, 16, 4);
                yield return new michelson(77, 840, 17, 4);
                yield return new michelson(78, 850, 18, 4);
                yield return new michelson(79, 850, 19, 4);
                yield return new michelson(80, 780, 20, 4);
                yield return new michelson(81, 890, 1, 5);
                yield return new michelson(82, 840, 2, 5);
                yield return new michelson(83, 780, 3, 5);
                yield return new michelson(84, 810, 4, 5);
                yield return new michelson(85, 760, 5, 5);
                yield return new michelson(86, 810, 6, 5);
                yield return new michelson(87, 790, 7, 5);
                yield return new michelson(88, 810, 8, 5);
                yield return new michelson(89, 820, 9, 5);
                yield return new michelson(90, 850, 10, 5);
                yield return new michelson(91, 870, 11, 5);
                yield return new michelson(92, 870, 12, 5);
                yield return new michelson(93, 810, 13, 5);
                yield return new michelson(94, 740, 14, 5);
                yield return new michelson(95, 810, 15, 5);
                yield return new michelson(96, 940, 16, 5);
                yield return new michelson(97, 950, 17, 5);
                yield return new michelson(98, 800, 18, 5);
                yield return new michelson(99, 810, 19, 5);
                yield return new michelson(100, 870, 20, 5);
            }
        }
    }
}
