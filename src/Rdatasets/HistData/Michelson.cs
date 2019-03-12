// ReSharper disable All

namespace Rdatasets.HistData
{
    using System.Collections.Generic;

    /// <summary>
    /// Michelson's Determinations of the Velocity of Light
    /// </summary>

    public class Michelson
    {
        public readonly int κ;
        public readonly int velocity;

        public Michelson(int κ, int velocity)
        {
            this.κ = κ;
            this.velocity = velocity;
        }

        public static IEnumerable<Michelson> Data
        {
            get
            {
                yield return new Michelson(1, 850);
                yield return new Michelson(2, 740);
                yield return new Michelson(3, 900);
                yield return new Michelson(4, 1070);
                yield return new Michelson(5, 930);
                yield return new Michelson(6, 850);
                yield return new Michelson(7, 950);
                yield return new Michelson(8, 980);
                yield return new Michelson(9, 980);
                yield return new Michelson(10, 880);
                yield return new Michelson(11, 1000);
                yield return new Michelson(12, 980);
                yield return new Michelson(13, 930);
                yield return new Michelson(14, 650);
                yield return new Michelson(15, 760);
                yield return new Michelson(16, 810);
                yield return new Michelson(17, 1000);
                yield return new Michelson(18, 1000);
                yield return new Michelson(19, 960);
                yield return new Michelson(20, 960);
                yield return new Michelson(21, 960);
                yield return new Michelson(22, 940);
                yield return new Michelson(23, 960);
                yield return new Michelson(24, 940);
                yield return new Michelson(25, 880);
                yield return new Michelson(26, 800);
                yield return new Michelson(27, 850);
                yield return new Michelson(28, 880);
                yield return new Michelson(29, 900);
                yield return new Michelson(30, 840);
                yield return new Michelson(31, 830);
                yield return new Michelson(32, 790);
                yield return new Michelson(33, 810);
                yield return new Michelson(34, 880);
                yield return new Michelson(35, 880);
                yield return new Michelson(36, 830);
                yield return new Michelson(37, 800);
                yield return new Michelson(38, 790);
                yield return new Michelson(39, 760);
                yield return new Michelson(40, 800);
                yield return new Michelson(41, 880);
                yield return new Michelson(42, 880);
                yield return new Michelson(43, 880);
                yield return new Michelson(44, 860);
                yield return new Michelson(45, 720);
                yield return new Michelson(46, 720);
                yield return new Michelson(47, 620);
                yield return new Michelson(48, 860);
                yield return new Michelson(49, 970);
                yield return new Michelson(50, 950);
                yield return new Michelson(51, 880);
                yield return new Michelson(52, 910);
                yield return new Michelson(53, 850);
                yield return new Michelson(54, 870);
                yield return new Michelson(55, 840);
                yield return new Michelson(56, 840);
                yield return new Michelson(57, 850);
                yield return new Michelson(58, 840);
                yield return new Michelson(59, 840);
                yield return new Michelson(60, 840);
                yield return new Michelson(61, 890);
                yield return new Michelson(62, 810);
                yield return new Michelson(63, 810);
                yield return new Michelson(64, 820);
                yield return new Michelson(65, 800);
                yield return new Michelson(66, 770);
                yield return new Michelson(67, 760);
                yield return new Michelson(68, 740);
                yield return new Michelson(69, 750);
                yield return new Michelson(70, 760);
                yield return new Michelson(71, 910);
                yield return new Michelson(72, 920);
                yield return new Michelson(73, 890);
                yield return new Michelson(74, 860);
                yield return new Michelson(75, 880);
                yield return new Michelson(76, 720);
                yield return new Michelson(77, 840);
                yield return new Michelson(78, 850);
                yield return new Michelson(79, 850);
                yield return new Michelson(80, 780);
                yield return new Michelson(81, 890);
                yield return new Michelson(82, 840);
                yield return new Michelson(83, 780);
                yield return new Michelson(84, 810);
                yield return new Michelson(85, 760);
                yield return new Michelson(86, 810);
                yield return new Michelson(87, 790);
                yield return new Michelson(88, 810);
                yield return new Michelson(89, 820);
                yield return new Michelson(90, 850);
                yield return new Michelson(91, 870);
                yield return new Michelson(92, 870);
                yield return new Michelson(93, 810);
                yield return new Michelson(94, 740);
                yield return new Michelson(95, 810);
                yield return new Michelson(96, 940);
                yield return new Michelson(97, 950);
                yield return new Michelson(98, 800);
                yield return new Michelson(99, 810);
                yield return new Michelson(100, 870);
            }
        }
    }
}
