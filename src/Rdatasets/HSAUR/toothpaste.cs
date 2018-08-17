// ReSharper disable All

namespace Rdatasets.HSAUR
{
    using System.Collections.Generic;

    /// <summary>
    /// Toothpaste Data
    /// </summary>

    public class toothpaste
    {
        public readonly int Study;
        public readonly int nA;
        public readonly double meanA;
        public readonly double sdA;
        public readonly int nB;
        public readonly double meanB;
        public readonly double sdB;

        public toothpaste(int Study, int nA, double meanA, double sdA, int nB, double meanB, double sdB)
        {
            this.Study = Study;
            this.nA = nA;
            this.meanA = meanA;
            this.sdA = sdA;
            this.nB = nB;
            this.meanB = meanB;
            this.sdB = sdB;
        }

        public static IEnumerable<toothpaste> Data
        {
            get
            {
                yield return new toothpaste(1, 134, 5.96, 4.24, 113, 4.72, 4.72);
                yield return new toothpaste(2, 175, 4.74, 4.64, 151, 5.07, 5.38);
                yield return new toothpaste(3, 137, 2.04, 2.59, 140, 2.51, 3.22);
                yield return new toothpaste(4, 184, 2.7, 2.32, 179, 3.2, 2.46);
                yield return new toothpaste(5, 174, 6.09, 4.86, 169, 5.81, 5.14);
                yield return new toothpaste(6, 754, 4.72, 5.33, 736, 4.76, 5.29);
                yield return new toothpaste(7, 209, 10.1, 8.1, 209, 10.9, 7.9);
                yield return new toothpaste(8, 1151, 2.82, 3.05, 1122, 3.01, 3.32);
                yield return new toothpaste(9, 679, 3.88, 4.85, 673, 4.37, 5.37);
            }
        }
    }
}
