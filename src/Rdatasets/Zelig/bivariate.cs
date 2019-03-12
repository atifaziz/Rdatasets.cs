// ReSharper disable All

namespace Rdatasets.Zelig
{
    using System.Collections.Generic;

    /// <summary>
    /// Sample data for bivariate probit regression
    /// </summary>

    public class bivariate
    {
        public readonly int κ;
        public readonly int x3;
        public readonly int x2;
        public readonly int x1;
        public readonly int y2;
        public readonly int y1;
        public readonly int x4;

        public bivariate(int κ, int x3, int x2, int x1, int y2, int y1, int x4)
        {
            this.κ = κ;
            this.x3 = x3;
            this.x2 = x2;
            this.x1 = x1;
            this.y2 = y2;
            this.y1 = y1;
            this.x4 = x4;
        }

        public static IEnumerable<bivariate> Data
        {
            get
            {
                yield return new bivariate(1, 1, 4, 3, 1, 1, 4);
                yield return new bivariate(2, 0, 2, 3, 0, 1, 3);
                yield return new bivariate(3, 0, 1, 3, 1, 0, 2);
                yield return new bivariate(4, 1, 1, 3, 1, 1, 2);
                yield return new bivariate(5, 0, 1, 3, 1, 1, 2);
                yield return new bivariate(6, 0, 1, 3, 0, 1, 2);
                yield return new bivariate(7, 1, 2, 2, 0, 1, 2);
                yield return new bivariate(8, 0, 1, 3, 0, 0, 2);
                yield return new bivariate(9, 0, 2, 1, 0, 0, 1);
                yield return new bivariate(10, 1, 2, 3, 1, 1, 2);
                yield return new bivariate(11, 1, 1, 2, 0, 0, 1);
                yield return new bivariate(12, 0, 1, 2, 1, 1, 2);
                yield return new bivariate(13, 0, 3, 1, 1, 1, 2);
                yield return new bivariate(14, 0, 3, 3, 1, 1, 4);
                yield return new bivariate(15, 0, 3, 2, 1, 1, 3);
                yield return new bivariate(16, 0, 1, 2, 0, 0, 1);
                yield return new bivariate(17, 0, 4, 2, 1, 1, 2);
                yield return new bivariate(18, 0, 3, 3, 0, 0, 2);
                yield return new bivariate(19, 0, 1, 1, 0, 0, 1);
                yield return new bivariate(20, 0, 3, 3, 1, 0, 3);
                yield return new bivariate(21, 0, 4, 3, 0, 0, 2);
                yield return new bivariate(22, 0, 1, 2, 0, 0, 1);
                yield return new bivariate(23, 0, 1, 2, 1, 1, 4);
                yield return new bivariate(24, 0, 1, 2, 0, 0, 1);
                yield return new bivariate(25, 0, 1, 1, 0, 0, 1);
                yield return new bivariate(26, 0, 3, 2, 1, 1, 2);
                yield return new bivariate(27, 0, 1, 2, 1, 0, 2);
                yield return new bivariate(28, 0, 1, 2, 1, 0, 2);
                yield return new bivariate(29, 0, 1, 2, 0, 0, 1);
                yield return new bivariate(30, 0, 4, 2, 1, 1, 3);
                yield return new bivariate(31, 0, 1, 2, 0, 0, 1);
                yield return new bivariate(32, 0, 1, 2, 0, 0, 1);
                yield return new bivariate(33, 0, 1, 1, 0, 0, 1);
                yield return new bivariate(34, 0, 1, 2, 0, 1, 1);
                yield return new bivariate(35, 0, 2, 1, 1, 1, 2);
                yield return new bivariate(36, 0, 3, 3, 0, 1, 1);
                yield return new bivariate(37, 0, 1, 2, 0, 0, 1);
                yield return new bivariate(38, 0, 1, 1, 0, 0, 1);
                yield return new bivariate(39, 0, 1, 2, 0, 0, 1);
                yield return new bivariate(40, 0, 2, 3, 0, 1, 2);
                yield return new bivariate(41, 0, 2, 2, 0, 1, 2);
                yield return new bivariate(42, 0, 2, 3, 0, 0, 2);
                yield return new bivariate(43, 0, 1, 3, 1, 0, 2);
                yield return new bivariate(44, 0, 2, 3, 0, 1, 2);
                yield return new bivariate(45, 0, 1, 1, 1, 1, 1);
                yield return new bivariate(46, 0, 1, 2, 0, 1, 1);
                yield return new bivariate(47, 0, 1, 3, 0, 1, 2);
                yield return new bivariate(48, 0, 2, 1, 1, 0, 1);
                yield return new bivariate(49, 0, 1, 3, 0, 0, 1);
                yield return new bivariate(50, 0, 1, 2, 0, 0, 1);
                yield return new bivariate(51, 0, 1, 2, 0, 1, 2);
                yield return new bivariate(52, 0, 1, 3, 0, 1, 2);
                yield return new bivariate(53, 0, 1, 1, 0, 1, 1);
                yield return new bivariate(54, 0, 1, 1, 0, 0, 1);
                yield return new bivariate(55, 0, 1, 2, 0, 0, 1);
                yield return new bivariate(56, 0, 1, 2, 0, 1, 2);
                yield return new bivariate(57, 0, 2, 2, 0, 1, 2);
                yield return new bivariate(58, 0, 2, 3, 0, 1, 2);
                yield return new bivariate(59, 0, 2, 3, 0, 1, 2);
                yield return new bivariate(60, 0, 3, 2, 1, 1, 3);
                yield return new bivariate(61, 1, 3, 2, 0, 0, 1);
                yield return new bivariate(62, 0, 1, 3, 1, 1, 3);
                yield return new bivariate(63, 0, 3, 1, 1, 1, 3);
                yield return new bivariate(64, 0, 2, 2, 0, 0, 1);
                yield return new bivariate(65, 0, 3, 3, 1, 1, 2);
                yield return new bivariate(66, 0, 2, 1, 0, 0, 1);
                yield return new bivariate(67, 0, 3, 3, 0, 1, 3);
                yield return new bivariate(68, 0, 1, 2, 0, 1, 2);
                yield return new bivariate(69, 0, 1, 2, 1, 0, 2);
                yield return new bivariate(70, 0, 3, 1, 1, 1, 2);
                yield return new bivariate(71, 0, 2, 3, 0, 1, 3);
                yield return new bivariate(72, 0, 2, 2, 0, 0, 1);
                yield return new bivariate(73, 1, 3, 1, 1, 1, 2);
                yield return new bivariate(74, 0, 2, 1, 0, 0, 1);
                yield return new bivariate(75, 0, 1, 3, 0, 1, 2);
                yield return new bivariate(76, 0, 4, 3, 1, 0, 2);
                yield return new bivariate(77, 0, 1, 2, 0, 0, 1);
                yield return new bivariate(78, 1, 3, 1, 1, 1, 2);
            }
        }
    }
}
