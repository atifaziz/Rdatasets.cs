// ReSharper disable All

namespace Rdatasets.geepack
{
    using System.Collections.Generic;

    /// <summary>
    /// Clustered Ordinal Respiratory Disorder
    /// </summary>

    public class respdis
    {
        public readonly int y1;
        public readonly int y2;
        public readonly int y3;
        public readonly int y4;
        public readonly int trt;

        public respdis(int y1, int y2, int y3, int y4, int trt)
        {
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
                yield return new respdis(1, 1, 1, 1, 1);
                yield return new respdis(1, 1, 1, 1, 0);
                yield return new respdis(1, 1, 1, 1, 0);
                yield return new respdis(1, 1, 1, 1, 0);
                yield return new respdis(1, 1, 1, 1, 0);
                yield return new respdis(1, 1, 1, 1, 0);
                yield return new respdis(1, 1, 1, 1, 0);
                yield return new respdis(1, 1, 2, 1, 1);
                yield return new respdis(1, 1, 2, 2, 0);
                yield return new respdis(1, 1, 2, 2, 0);
                yield return new respdis(1, 2, 1, 1, 1);
                yield return new respdis(1, 2, 2, 2, 0);
                yield return new respdis(1, 2, 2, 2, 0);
                yield return new respdis(1, 2, 3, 3, 1);
                yield return new respdis(2, 1, 1, 1, 0);
                yield return new respdis(2, 1, 1, 1, 0);
                yield return new respdis(2, 1, 1, 1, 0);
                yield return new respdis(2, 1, 1, 1, 0);
                yield return new respdis(2, 1, 1, 2, 0);
                yield return new respdis(2, 1, 2, 2, 1);
                yield return new respdis(2, 1, 2, 2, 0);
                yield return new respdis(2, 1, 2, 2, 0);
                yield return new respdis(2, 2, 1, 1, 1);
                yield return new respdis(2, 2, 1, 1, 0);
                yield return new respdis(2, 2, 1, 1, 0);
                yield return new respdis(2, 2, 1, 2, 1);
                yield return new respdis(2, 2, 1, 2, 1);
                yield return new respdis(2, 2, 1, 2, 0);
                yield return new respdis(2, 2, 1, 2, 0);
                yield return new respdis(2, 2, 2, 1, 1);
                yield return new respdis(2, 2, 2, 1, 1);
                yield return new respdis(2, 2, 2, 1, 1);
                yield return new respdis(2, 2, 2, 1, 1);
                yield return new respdis(2, 2, 2, 1, 0);
                yield return new respdis(2, 2, 2, 2, 1);
                yield return new respdis(2, 2, 2, 2, 1);
                yield return new respdis(2, 2, 2, 2, 1);
                yield return new respdis(2, 2, 2, 2, 1);
                yield return new respdis(2, 2, 2, 2, 1);
                yield return new respdis(2, 2, 2, 2, 1);
                yield return new respdis(2, 2, 2, 2, 1);
                yield return new respdis(2, 2, 2, 2, 1);
                yield return new respdis(2, 2, 2, 2, 0);
                yield return new respdis(2, 2, 2, 2, 0);
                yield return new respdis(2, 2, 2, 2, 0);
                yield return new respdis(2, 2, 2, 2, 0);
                yield return new respdis(2, 2, 2, 2, 0);
                yield return new respdis(2, 2, 2, 2, 0);
                yield return new respdis(2, 2, 2, 2, 0);
                yield return new respdis(2, 2, 2, 2, 0);
                yield return new respdis(2, 2, 2, 2, 0);
                yield return new respdis(2, 2, 2, 2, 0);
                yield return new respdis(2, 2, 2, 2, 0);
                yield return new respdis(2, 2, 2, 2, 0);
                yield return new respdis(2, 2, 2, 3, 1);
                yield return new respdis(2, 2, 2, 3, 1);
                yield return new respdis(2, 2, 2, 3, 0);
                yield return new respdis(2, 2, 2, 3, 0);
                yield return new respdis(2, 2, 3, 2, 1);
                yield return new respdis(2, 2, 3, 3, 1);
                yield return new respdis(2, 2, 3, 3, 0);
                yield return new respdis(2, 2, 3, 3, 0);
                yield return new respdis(2, 3, 2, 2, 0);
                yield return new respdis(2, 3, 2, 3, 1);
                yield return new respdis(2, 3, 2, 3, 1);
                yield return new respdis(2, 3, 2, 3, 0);
                yield return new respdis(2, 3, 3, 2, 1);
                yield return new respdis(2, 3, 3, 2, 1);
                yield return new respdis(2, 3, 3, 2, 1);
                yield return new respdis(2, 3, 3, 3, 1);
                yield return new respdis(2, 3, 3, 3, 1);
                yield return new respdis(2, 3, 3, 3, 1);
                yield return new respdis(2, 3, 3, 3, 1);
                yield return new respdis(2, 3, 3, 3, 1);
                yield return new respdis(2, 3, 3, 3, 1);
                yield return new respdis(2, 3, 3, 3, 1);
                yield return new respdis(2, 3, 3, 3, 0);
                yield return new respdis(3, 1, 1, 1, 0);
                yield return new respdis(3, 1, 3, 2, 1);
                yield return new respdis(3, 2, 1, 2, 0);
                yield return new respdis(3, 2, 2, 1, 1);
                yield return new respdis(3, 2, 2, 1, 0);
                yield return new respdis(3, 2, 2, 3, 1);
                yield return new respdis(3, 2, 2, 3, 0);
                yield return new respdis(3, 2, 3, 2, 0);
                yield return new respdis(3, 2, 3, 2, 0);
                yield return new respdis(3, 2, 3, 3, 0);
                yield return new respdis(3, 2, 3, 3, 0);
                yield return new respdis(3, 3, 2, 2, 1);
                yield return new respdis(3, 3, 2, 2, 1);
                yield return new respdis(3, 3, 2, 3, 1);
                yield return new respdis(3, 3, 2, 3, 1);
                yield return new respdis(3, 3, 3, 2, 1);
                yield return new respdis(3, 3, 3, 2, 1);
                yield return new respdis(3, 3, 3, 2, 1);
                yield return new respdis(3, 3, 3, 2, 0);
                yield return new respdis(3, 3, 3, 3, 1);
                yield return new respdis(3, 3, 3, 3, 1);
                yield return new respdis(3, 3, 3, 3, 1);
                yield return new respdis(3, 3, 3, 3, 1);
                yield return new respdis(3, 3, 3, 3, 1);
                yield return new respdis(3, 3, 3, 3, 1);
                yield return new respdis(3, 3, 3, 3, 1);
                yield return new respdis(3, 3, 3, 3, 1);
                yield return new respdis(3, 3, 3, 3, 0);
                yield return new respdis(3, 3, 3, 3, 0);
                yield return new respdis(3, 3, 3, 3, 0);
                yield return new respdis(3, 3, 3, 3, 0);
                yield return new respdis(3, 3, 3, 3, 0);
                yield return new respdis(3, 3, 3, 3, 0);
                yield return new respdis(3, 3, 3, 3, 0);
            }
        }
    }
}
