// ReSharper disable All

namespace Rdatasets.drc
{
    using System.Collections.Generic;

    /// <summary>
    /// Effect of ferulic acid on growth of ryegrass
    /// </summary>

    public class ryegrass
    {
        public readonly int κ;
        public readonly double rootl;
        public readonly double conc;

        public ryegrass(int κ, double rootl, double conc)
        {
            this.κ = κ;
            this.rootl = rootl;
            this.conc = conc;
        }

        public static IEnumerable<ryegrass> Data
        {
            get
            {
                yield return new ryegrass(1, 7.58, 0);
                yield return new ryegrass(2, 8, 0);
                yield return new ryegrass(3, 8.328571429, 0);
                yield return new ryegrass(4, 7.25, 0);
                yield return new ryegrass(5, 7.375, 0);
                yield return new ryegrass(6, 7.9625, 0);
                yield return new ryegrass(7, 8.355555556, 0.94);
                yield return new ryegrass(8, 6.914285714, 0.94);
                yield return new ryegrass(9, 7.75, 0.94);
                yield return new ryegrass(10, 6.871428571, 1.88);
                yield return new ryegrass(11, 6.45, 1.88);
                yield return new ryegrass(12, 5.922222222, 1.88);
                yield return new ryegrass(13, 1.925, 3.75);
                yield return new ryegrass(14, 2.885714286, 3.75);
                yield return new ryegrass(15, 4.233333333, 3.75);
                yield return new ryegrass(16, 1.1875, 7.5);
                yield return new ryegrass(17, 0.857142857, 7.5);
                yield return new ryegrass(18, 1.057142857, 7.5);
                yield return new ryegrass(19, 0.6875, 15);
                yield return new ryegrass(20, 0.525, 15);
                yield return new ryegrass(21, 0.825, 15);
                yield return new ryegrass(22, 0.25, 30);
                yield return new ryegrass(23, 0.22, 30);
                yield return new ryegrass(24, 0.44, 30);
            }
        }
    }
}
