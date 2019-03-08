// ReSharper disable All

namespace Rdatasets.drc
{
    using System.Collections.Generic;

    /// <summary>
    /// Effect of ferulic acid on growth of ryegrass
    /// </summary>

    public class ryegrass
    {
        public readonly double rootl;
        public readonly double conc;

        public ryegrass(double rootl, double conc)
        {
            this.rootl = rootl;
            this.conc = conc;
        }

        public static IEnumerable<ryegrass> Data
        {
            get
            {
                yield return new ryegrass(7.58, 0);
                yield return new ryegrass(8, 0);
                yield return new ryegrass(8.328571429, 0);
                yield return new ryegrass(7.25, 0);
                yield return new ryegrass(7.375, 0);
                yield return new ryegrass(7.9625, 0);
                yield return new ryegrass(8.355555556, 0.94);
                yield return new ryegrass(6.914285714, 0.94);
                yield return new ryegrass(7.75, 0.94);
                yield return new ryegrass(6.871428571, 1.88);
                yield return new ryegrass(6.45, 1.88);
                yield return new ryegrass(5.922222222, 1.88);
                yield return new ryegrass(1.925, 3.75);
                yield return new ryegrass(2.885714286, 3.75);
                yield return new ryegrass(4.233333333, 3.75);
                yield return new ryegrass(1.1875, 7.5);
                yield return new ryegrass(0.857142857, 7.5);
                yield return new ryegrass(1.057142857, 7.5);
                yield return new ryegrass(0.6875, 15);
                yield return new ryegrass(0.525, 15);
                yield return new ryegrass(0.825, 15);
                yield return new ryegrass(0.25, 30);
                yield return new ryegrass(0.22, 30);
                yield return new ryegrass(0.44, 30);
            }
        }
    }
}
