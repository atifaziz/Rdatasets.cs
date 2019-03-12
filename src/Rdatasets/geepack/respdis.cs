// ReSharper disable All

namespace Rdatasets.geepack
{
    using System.Collections.Generic;

    /// <summary>
    /// Clustered Ordinal Respiratory Disorder
    /// </summary>

    public class respdis
    {
        public readonly int κ;
        public readonly int y1;
        public readonly int y2;
        public readonly int y3;
        public readonly int y4;
        public readonly int trt;

        public respdis(int κ, int y1, int y2, int y3, int y4, int trt)
        {
            this.κ = κ;
            this.y1 = y1;
            this.y2 = y2;
            this.y3 = y3;
            this.y4 = y4;
            this.trt = trt;
        }

        public static IEnumerable<respdis> Data
        {
            get
            {
                yield return new respdis(1, 1, 1, 1, 1, 1);
                yield return new respdis(2, 1, 1, 1, 1, 0);
                yield return new respdis(3, 1, 1, 1, 1, 0);
                yield return new respdis(4, 1, 1, 1, 1, 0);
                yield return new respdis(5, 1, 1, 1, 1, 0);
                yield return new respdis(6, 1, 1, 1, 1, 0);
                yield return new respdis(7, 1, 1, 1, 1, 0);
                yield return new respdis(8, 1, 1, 2, 1, 1);
                yield return new respdis(9, 1, 1, 2, 2, 0);
                yield return new respdis(10, 1, 1, 2, 2, 0);
                yield return new respdis(11, 1, 2, 1, 1, 1);
                yield return new respdis(12, 1, 2, 2, 2, 0);
                yield return new respdis(13, 1, 2, 2, 2, 0);
                yield return new respdis(14, 1, 2, 3, 3, 1);
                yield return new respdis(15, 2, 1, 1, 1, 0);
                yield return new respdis(16, 2, 1, 1, 1, 0);
                yield return new respdis(17, 2, 1, 1, 1, 0);
                yield return new respdis(18, 2, 1, 1, 1, 0);
                yield return new respdis(19, 2, 1, 1, 2, 0);
                yield return new respdis(20, 2, 1, 2, 2, 1);
                yield return new respdis(21, 2, 1, 2, 2, 0);
                yield return new respdis(22, 2, 1, 2, 2, 0);
                yield return new respdis(23, 2, 2, 1, 1, 1);
                yield return new respdis(24, 2, 2, 1, 1, 0);
                yield return new respdis(25, 2, 2, 1, 1, 0);
                yield return new respdis(26, 2, 2, 1, 2, 1);
                yield return new respdis(27, 2, 2, 1, 2, 1);
                yield return new respdis(28, 2, 2, 1, 2, 0);
                yield return new respdis(29, 2, 2, 1, 2, 0);
                yield return new respdis(30, 2, 2, 2, 1, 1);
                yield return new respdis(31, 2, 2, 2, 1, 1);
                yield return new respdis(32, 2, 2, 2, 1, 1);
                yield return new respdis(33, 2, 2, 2, 1, 1);
                yield return new respdis(34, 2, 2, 2, 1, 0);
                yield return new respdis(35, 2, 2, 2, 2, 1);
                yield return new respdis(36, 2, 2, 2, 2, 1);
                yield return new respdis(37, 2, 2, 2, 2, 1);
                yield return new respdis(38, 2, 2, 2, 2, 1);
                yield return new respdis(39, 2, 2, 2, 2, 1);
                yield return new respdis(40, 2, 2, 2, 2, 1);
                yield return new respdis(41, 2, 2, 2, 2, 1);
                yield return new respdis(42, 2, 2, 2, 2, 1);
                yield return new respdis(43, 2, 2, 2, 2, 0);
                yield return new respdis(44, 2, 2, 2, 2, 0);
                yield return new respdis(45, 2, 2, 2, 2, 0);
                yield return new respdis(46, 2, 2, 2, 2, 0);
                yield return new respdis(47, 2, 2, 2, 2, 0);
                yield return new respdis(48, 2, 2, 2, 2, 0);
                yield return new respdis(49, 2, 2, 2, 2, 0);
                yield return new respdis(50, 2, 2, 2, 2, 0);
                yield return new respdis(51, 2, 2, 2, 2, 0);
                yield return new respdis(52, 2, 2, 2, 2, 0);
                yield return new respdis(53, 2, 2, 2, 2, 0);
                yield return new respdis(54, 2, 2, 2, 2, 0);
                yield return new respdis(55, 2, 2, 2, 3, 1);
                yield return new respdis(56, 2, 2, 2, 3, 1);
                yield return new respdis(57, 2, 2, 2, 3, 0);
                yield return new respdis(58, 2, 2, 2, 3, 0);
                yield return new respdis(59, 2, 2, 3, 2, 1);
                yield return new respdis(60, 2, 2, 3, 3, 1);
                yield return new respdis(61, 2, 2, 3, 3, 0);
                yield return new respdis(62, 2, 2, 3, 3, 0);
                yield return new respdis(63, 2, 3, 2, 2, 0);
                yield return new respdis(64, 2, 3, 2, 3, 1);
                yield return new respdis(65, 2, 3, 2, 3, 1);
                yield return new respdis(66, 2, 3, 2, 3, 0);
                yield return new respdis(67, 2, 3, 3, 2, 1);
                yield return new respdis(68, 2, 3, 3, 2, 1);
                yield return new respdis(69, 2, 3, 3, 2, 1);
                yield return new respdis(70, 2, 3, 3, 3, 1);
                yield return new respdis(71, 2, 3, 3, 3, 1);
                yield return new respdis(72, 2, 3, 3, 3, 1);
                yield return new respdis(73, 2, 3, 3, 3, 1);
                yield return new respdis(74, 2, 3, 3, 3, 1);
                yield return new respdis(75, 2, 3, 3, 3, 1);
                yield return new respdis(76, 2, 3, 3, 3, 1);
                yield return new respdis(77, 2, 3, 3, 3, 0);
                yield return new respdis(78, 3, 1, 1, 1, 0);
                yield return new respdis(79, 3, 1, 3, 2, 1);
                yield return new respdis(80, 3, 2, 1, 2, 0);
                yield return new respdis(81, 3, 2, 2, 1, 1);
                yield return new respdis(82, 3, 2, 2, 1, 0);
                yield return new respdis(83, 3, 2, 2, 3, 1);
                yield return new respdis(84, 3, 2, 2, 3, 0);
                yield return new respdis(85, 3, 2, 3, 2, 0);
                yield return new respdis(86, 3, 2, 3, 2, 0);
                yield return new respdis(87, 3, 2, 3, 3, 0);
                yield return new respdis(88, 3, 2, 3, 3, 0);
                yield return new respdis(89, 3, 3, 2, 2, 1);
                yield return new respdis(90, 3, 3, 2, 2, 1);
                yield return new respdis(91, 3, 3, 2, 3, 1);
                yield return new respdis(92, 3, 3, 2, 3, 1);
                yield return new respdis(93, 3, 3, 3, 2, 1);
                yield return new respdis(94, 3, 3, 3, 2, 1);
                yield return new respdis(95, 3, 3, 3, 2, 1);
                yield return new respdis(96, 3, 3, 3, 2, 0);
                yield return new respdis(97, 3, 3, 3, 3, 1);
                yield return new respdis(98, 3, 3, 3, 3, 1);
                yield return new respdis(99, 3, 3, 3, 3, 1);
                yield return new respdis(100, 3, 3, 3, 3, 1);
                yield return new respdis(101, 3, 3, 3, 3, 1);
                yield return new respdis(102, 3, 3, 3, 3, 1);
                yield return new respdis(103, 3, 3, 3, 3, 1);
                yield return new respdis(104, 3, 3, 3, 3, 1);
                yield return new respdis(105, 3, 3, 3, 3, 0);
                yield return new respdis(106, 3, 3, 3, 3, 0);
                yield return new respdis(107, 3, 3, 3, 3, 0);
                yield return new respdis(108, 3, 3, 3, 3, 0);
                yield return new respdis(109, 3, 3, 3, 3, 0);
                yield return new respdis(110, 3, 3, 3, 3, 0);
                yield return new respdis(111, 3, 3, 3, 3, 0);
            }
        }
    }
}
