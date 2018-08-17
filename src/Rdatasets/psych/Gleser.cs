// ReSharper disable All

namespace Rdatasets.psych
{
    using System.Collections.Generic;

    /// <summary>
    /// Example data from Gleser, Cronbach and Rajaratnam (1965) to show basic principles of generalizability theory.
    /// </summary>

    public class Gleser
    {
        public readonly int J11;
        public readonly int J12;
        public readonly int J21;
        public readonly int J22;
        public readonly int J31;
        public readonly int J32;
        public readonly int J41;
        public readonly int J42;
        public readonly int J51;
        public readonly int J52;
        public readonly int J61;
        public readonly int J62;

        public Gleser(int J11, int J12, int J21, int J22, int J31, int J32, int J41, int J42, int J51, int J52, int J61, int J62)
        {
            this.J11 = J11;
            this.J12 = J12;
            this.J21 = J21;
            this.J22 = J22;
            this.J31 = J31;
            this.J32 = J32;
            this.J41 = J41;
            this.J42 = J42;
            this.J51 = J51;
            this.J52 = J52;
            this.J61 = J61;
            this.J62 = J62;
        }

        public static IEnumerable<Gleser> Data
        {
            get
            {
                yield return new Gleser(0, 0, 2, 1, 2, 0, 2, 1, 1, 1, 1, 2);
                yield return new Gleser(0, 0, 2, 1, 2, 0, 1, 2, 2, 1, 2, 1);
                yield return new Gleser(0, 0, 1, 1, 3, 3, 2, 1, 2, 1, 1, 2);
                yield return new Gleser(2, 0, 2, 1, 2, 2, 2, 1, 2, 1, 4, 1);
                yield return new Gleser(0, 0, 1, 2, 2, 0, 2, 3, 3, 3, 3, 3);
                yield return new Gleser(2, 0, 2, 1, 2, 0, 4, 1, 3, 3, 3, 1);
                yield return new Gleser(0, 1, 3, 1, 3, 1, 3, 4, 2, 2, 2, 3);
                yield return new Gleser(0, 0, 0, 1, 4, 3, 3, 4, 2, 3, 3, 3);
                yield return new Gleser(1, 2, 2, 1, 3, 6, 1, 3, 2, 3, 2, 1);
                yield return new Gleser(0, 1, 2, 4, 3, 3, 2, 2, 3, 5, 3, 1);
                yield return new Gleser(3, 4, 2, 2, 3, 2, 4, 5, 3, 3, 5, 5);
                yield return new Gleser(1, 1, 2, 4, 4, 4, 3, 3, 4, 6, 6, 6);
            }
        }
    }
}
