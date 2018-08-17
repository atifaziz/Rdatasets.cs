// ReSharper disable All

namespace Rdatasets.Zelig
{
    using System.Collections.Generic;

    /// <summary>
    /// Sample data for bivariate probit regression
    /// </summary>

    public class bivariate
    {
        public readonly int x3;
        public readonly int x2;
        public readonly int x1;
        public readonly int y2;
        public readonly int y1;
        public readonly int x4;

        public bivariate(int x3, int x2, int x1, int y2, int y1, int x4)
        {
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
                yield return new bivariate(1, 4, 3, 1, 1, 4);
                yield return new bivariate(0, 2, 3, 0, 1, 3);
                yield return new bivariate(0, 1, 3, 1, 0, 2);
                yield return new bivariate(1, 1, 3, 1, 1, 2);
                yield return new bivariate(0, 1, 3, 1, 1, 2);
                yield return new bivariate(0, 1, 3, 0, 1, 2);
                yield return new bivariate(1, 2, 2, 0, 1, 2);
                yield return new bivariate(0, 1, 3, 0, 0, 2);
                yield return new bivariate(0, 2, 1, 0, 0, 1);
                yield return new bivariate(1, 2, 3, 1, 1, 2);
                yield return new bivariate(1, 1, 2, 0, 0, 1);
                yield return new bivariate(0, 1, 2, 1, 1, 2);
                yield return new bivariate(0, 3, 1, 1, 1, 2);
                yield return new bivariate(0, 3, 3, 1, 1, 4);
                yield return new bivariate(0, 3, 2, 1, 1, 3);
                yield return new bivariate(0, 1, 2, 0, 0, 1);
                yield return new bivariate(0, 4, 2, 1, 1, 2);
                yield return new bivariate(0, 3, 3, 0, 0, 2);
                yield return new bivariate(0, 1, 1, 0, 0, 1);
                yield return new bivariate(0, 3, 3, 1, 0, 3);
                yield return new bivariate(0, 4, 3, 0, 0, 2);
                yield return new bivariate(0, 1, 2, 0, 0, 1);
                yield return new bivariate(0, 1, 2, 1, 1, 4);
                yield return new bivariate(0, 1, 2, 0, 0, 1);
                yield return new bivariate(0, 1, 1, 0, 0, 1);
                yield return new bivariate(0, 3, 2, 1, 1, 2);
                yield return new bivariate(0, 1, 2, 1, 0, 2);
                yield return new bivariate(0, 1, 2, 1, 0, 2);
                yield return new bivariate(0, 1, 2, 0, 0, 1);
                yield return new bivariate(0, 4, 2, 1, 1, 3);
                yield return new bivariate(0, 1, 2, 0, 0, 1);
                yield return new bivariate(0, 1, 2, 0, 0, 1);
                yield return new bivariate(0, 1, 1, 0, 0, 1);
                yield return new bivariate(0, 1, 2, 0, 1, 1);
                yield return new bivariate(0, 2, 1, 1, 1, 2);
                yield return new bivariate(0, 3, 3, 0, 1, 1);
                yield return new bivariate(0, 1, 2, 0, 0, 1);
                yield return new bivariate(0, 1, 1, 0, 0, 1);
                yield return new bivariate(0, 1, 2, 0, 0, 1);
                yield return new bivariate(0, 2, 3, 0, 1, 2);
                yield return new bivariate(0, 2, 2, 0, 1, 2);
                yield return new bivariate(0, 2, 3, 0, 0, 2);
                yield return new bivariate(0, 1, 3, 1, 0, 2);
                yield return new bivariate(0, 2, 3, 0, 1, 2);
                yield return new bivariate(0, 1, 1, 1, 1, 1);
                yield return new bivariate(0, 1, 2, 0, 1, 1);
                yield return new bivariate(0, 1, 3, 0, 1, 2);
                yield return new bivariate(0, 2, 1, 1, 0, 1);
                yield return new bivariate(0, 1, 3, 0, 0, 1);
                yield return new bivariate(0, 1, 2, 0, 0, 1);
                yield return new bivariate(0, 1, 2, 0, 1, 2);
                yield return new bivariate(0, 1, 3, 0, 1, 2);
                yield return new bivariate(0, 1, 1, 0, 1, 1);
                yield return new bivariate(0, 1, 1, 0, 0, 1);
                yield return new bivariate(0, 1, 2, 0, 0, 1);
                yield return new bivariate(0, 1, 2, 0, 1, 2);
                yield return new bivariate(0, 2, 2, 0, 1, 2);
                yield return new bivariate(0, 2, 3, 0, 1, 2);
                yield return new bivariate(0, 2, 3, 0, 1, 2);
                yield return new bivariate(0, 3, 2, 1, 1, 3);
                yield return new bivariate(1, 3, 2, 0, 0, 1);
                yield return new bivariate(0, 1, 3, 1, 1, 3);
                yield return new bivariate(0, 3, 1, 1, 1, 3);
                yield return new bivariate(0, 2, 2, 0, 0, 1);
                yield return new bivariate(0, 3, 3, 1, 1, 2);
                yield return new bivariate(0, 2, 1, 0, 0, 1);
                yield return new bivariate(0, 3, 3, 0, 1, 3);
                yield return new bivariate(0, 1, 2, 0, 1, 2);
                yield return new bivariate(0, 1, 2, 1, 0, 2);
                yield return new bivariate(0, 3, 1, 1, 1, 2);
                yield return new bivariate(0, 2, 3, 0, 1, 3);
                yield return new bivariate(0, 2, 2, 0, 0, 1);
                yield return new bivariate(1, 3, 1, 1, 1, 2);
                yield return new bivariate(0, 2, 1, 0, 0, 1);
                yield return new bivariate(0, 1, 3, 0, 1, 2);
                yield return new bivariate(0, 4, 3, 1, 0, 2);
                yield return new bivariate(0, 1, 2, 0, 0, 1);
                yield return new bivariate(1, 3, 1, 1, 1, 2);
            }
        }
    }
}
