// ReSharper disable All

namespace Rdatasets.pscl
{
    using System.Collections.Generic;

    /// <summary>
    /// Applications to a Political Science PhD Program
    /// </summary>

    public class admit
    {
        public readonly int κ;
        public readonly int score;
        public readonly int gre_quant;
        public readonly int gre_verbal;
        public readonly int ap;
        public readonly int pt;
        public readonly int female;

        public admit(int κ, int score, int gre_quant, int gre_verbal, int ap, int pt, int female)
        {
            this.κ = κ;
            this.score = score;
            this.gre_quant = gre_quant;
            this.gre_verbal = gre_verbal;
            this.ap = ap;
            this.pt = pt;
            this.female = female;
        }

        public static IEnumerable<admit> Data
        {
            get
            {
                yield return new admit(1, 2, 630, 630, 0, 0, 1);
                yield return new admit(2, 1, 520, 490, 0, 0, 1);
                yield return new admit(3, 4, 670, 400, 0, 0, 0);
                yield return new admit(4, 1, 600, 560, 0, 0, 0);
                yield return new admit(5, 1, 620, 570, 0, 0, 0);
                yield return new admit(6, 4, 730, 670, 0, 0, 0);
                yield return new admit(7, 1, 640, 590, 0, 0, 1);
                yield return new admit(8, 4, 470, 610, 1, 0, 1);
                yield return new admit(9, 2, 550, 500, 1, 0, 0);
                yield return new admit(10, 5, 720, 710, 0, 0, 1);
                yield return new admit(11, 4, 750, 480, 0, 0, 1);
                yield return new admit(12, 1, 720, 470, 0, 0, 0);
                yield return new admit(13, 2, 590, 550, 0, 0, 1);
                yield return new admit(14, 4, 760, 680, 0, 0, 0);
                yield return new admit(15, 4, 750, 690, 0, 0, 0);
                yield return new admit(16, 1, 580, 440, 0, 0, 0);
                yield return new admit(17, 1, 640, 710, 0, 0, 0);
                yield return new admit(18, 5, 710, 560, 0, 0, 0);
                yield return new admit(19, 4, 610, 720, 1, 0, 0);
                yield return new admit(20, 1, 530, 600, 0, 0, 0);
                yield return new admit(21, 4, 740, 750, 0, 0, 0);
                yield return new admit(22, 5, 740, 730, 1, 0, 0);
                yield return new admit(23, 1, 430, 630, 0, 0, 1);
                yield return new admit(24, 2, 510, 620, 0, 0, 0);
                yield return new admit(25, 4, 620, 680, 0, 1, 1);
                yield return new admit(26, 4, 620, 680, 1, 0, 0);
                yield return new admit(27, 1, 330, 460, 0, 0, 0);
                yield return new admit(28, 5, 700, 730, 1, 0, 0);
                yield return new admit(29, 5, 770, 470, 0, 0, 0);
                yield return new admit(30, 5, 790, 760, 0, 0, 1);
                yield return new admit(31, 2, 660, 640, 0, 1, 0);
                yield return new admit(32, 1, 720, 670, 0, 0, 0);
                yield return new admit(33, 2, 630, 590, 1, 0, 0);
                yield return new admit(34, 1, 420, 640, 0, 0, 0);
                yield return new admit(35, 4, 640, 410, 0, 0, 1);
                yield return new admit(36, 2, 670, 610, 0, 0, 0);
                yield return new admit(37, 2, 690, 640, 0, 0, 1);
                yield return new admit(38, 1, 390, 610, 0, 1, 1);
                yield return new admit(39, 1, 410, 410, 0, 0, 0);
                yield return new admit(40, 2, 700, 470, 0, 0, 0);
                yield return new admit(41, 4, 640, 640, 0, 0, 1);
                yield return new admit(42, 2, 740, 650, 0, 0, 1);
                yield return new admit(43, 1, 720, 370, 0, 1, 0);
                yield return new admit(44, 5, 640, 670, 0, 0, 0);
                yield return new admit(45, 1, 740, 290, 0, 0, 0);
                yield return new admit(46, 5, 770, 420, 0, 0, 1);
                yield return new admit(47, 5, 800, 740, 0, 0, 0);
                yield return new admit(48, 2, 750, 510, 0, 0, 0);
                yield return new admit(49, 1, 670, 530, 0, 0, 0);
                yield return new admit(50, 5, 730, 560, 0, 0, 0);
                yield return new admit(51, 2, 620, 600, 0, 0, 0);
                yield return new admit(52, 2, 560, 530, 0, 0, 1);
                yield return new admit(53, 4, 660, 630, 0, 1, 0);
                yield return new admit(54, 5, 750, 630, 1, 0, 0);
                yield return new admit(55, 2, 730, 410, 0, 0, 1);
                yield return new admit(56, 2, 780, 490, 0, 0, 0);
                yield return new admit(57, 4, 770, 670, 0, 0, 0);
                yield return new admit(58, 5, 770, 750, 0, 0, 0);
                yield return new admit(59, 4, 680, 680, 0, 0, 0);
                yield return new admit(60, 2, 720, 530, 0, 0, 0);
                yield return new admit(61, 4, 720, 760, 1, 0, 0);
                yield return new admit(62, 5, 590, 720, 1, 0, 1);
                yield return new admit(63, 4, 770, 480, 0, 0, 0);
                yield return new admit(64, 5, 790, 720, 0, 0, 0);
                yield return new admit(65, 5, 770, 660, 0, 0, 1);
                yield return new admit(66, 1, 540, 460, 0, 0, 1);
                yield return new admit(67, 4, 740, 730, 0, 0, 0);
                yield return new admit(68, 5, 780, 640, 0, 0, 1);
                yield return new admit(69, 4, 740, 650, 0, 0, 0);
                yield return new admit(70, 5, 770, 670, 1, 0, 0);
                yield return new admit(71, 1, 680, 430, 0, 0, 0);
                yield return new admit(72, 2, 720, 760, 0, 0, 0);
                yield return new admit(73, 4, 770, 720, 0, 0, 0);
                yield return new admit(74, 2, 720, 480, 0, 0, 0);
                yield return new admit(75, 4, 770, 510, 0, 0, 0);
                yield return new admit(76, 2, 640, 580, 0, 1, 0);
                yield return new admit(77, 4, 750, 410, 0, 0, 0);
                yield return new admit(78, 4, 660, 710, 0, 0, 1);
                yield return new admit(79, 4, 750, 570, 0, 0, 0);
                yield return new admit(80, 2, 550, 720, 0, 0, 0);
                yield return new admit(81, 3, 540, 640, 0, 0, 1);
                yield return new admit(82, 4, 650, 670, 0, 1, 1);
                yield return new admit(83, 4, 720, 770, 0, 0, 0);
                yield return new admit(84, 1, 470, 320, 0, 0, 1);
                yield return new admit(85, 4, 750, 720, 0, 0, 0);
                yield return new admit(86, 1, 560, 370, 0, 0, 0);
                yield return new admit(87, 1, 560, 690, 0, 0, 1);
                yield return new admit(88, 5, 710, 610, 0, 0, 0);
                yield return new admit(89, 4, 750, 570, 0, 0, 0);
                yield return new admit(90, 4, 760, 620, 0, 0, 0);
                yield return new admit(91, 3, 740, 310, 0, 0, 1);
                yield return new admit(92, 4, 790, 330, 0, 0, 0);
                yield return new admit(93, 4, 790, 710, 0, 0, 0);
                yield return new admit(94, 4, 670, 620, 0, 0, 0);
                yield return new admit(95, 1, 580, 530, 0, 0, 0);
                yield return new admit(96, 5, 790, 700, 0, 0, 1);
                yield return new admit(97, 4, 740, 720, 0, 0, 1);
                yield return new admit(98, 2, 730, 570, 0, 0, 0);
                yield return new admit(99, 2, 730, 620, 0, 0, 1);
                yield return new admit(100, 2, 750, 500, 0, 1, 0);
                yield return new admit(101, 2, 640, 600, 0, 0, 1);
                yield return new admit(102, 5, 720, 720, 1, 0, 1);
                yield return new admit(103, 4, 770, 600, 0, 0, 0);
                yield return new admit(104, 4, 740, 620, 0, 0, 1);
                yield return new admit(105, 4, 760, 600, 0, 0, 1);
                yield return new admit(106, 4, 650, 710, 0, 0, 0);
            }
        }
    }
}
