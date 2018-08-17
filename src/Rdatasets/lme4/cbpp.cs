// ReSharper disable All

namespace Rdatasets.lme4
{
    using System.Collections.Generic;

    /// <summary>
    /// Contagious bovine pleuropneumonia
    /// </summary>

    public class cbpp
    {
        public readonly int herd;
        public readonly int incidence;
        public readonly int size;
        public readonly int period;

        public cbpp(int herd, int incidence, int size, int period)
        {
            this.herd = herd;
            this.incidence = incidence;
            this.size = size;
            this.period = period;
        }

        public static IEnumerable<cbpp> Data
        {
            get
            {
                yield return new cbpp(1, 2, 14, 1);
                yield return new cbpp(1, 3, 12, 2);
                yield return new cbpp(1, 4, 9, 3);
                yield return new cbpp(1, 0, 5, 4);
                yield return new cbpp(2, 3, 22, 1);
                yield return new cbpp(2, 1, 18, 2);
                yield return new cbpp(2, 1, 21, 3);
                yield return new cbpp(3, 8, 22, 1);
                yield return new cbpp(3, 2, 16, 2);
                yield return new cbpp(3, 0, 16, 3);
                yield return new cbpp(3, 2, 20, 4);
                yield return new cbpp(4, 2, 10, 1);
                yield return new cbpp(4, 0, 10, 2);
                yield return new cbpp(4, 2, 9, 3);
                yield return new cbpp(4, 0, 6, 4);
                yield return new cbpp(5, 5, 18, 1);
                yield return new cbpp(5, 0, 25, 2);
                yield return new cbpp(5, 0, 24, 3);
                yield return new cbpp(5, 1, 4, 4);
                yield return new cbpp(6, 3, 17, 1);
                yield return new cbpp(6, 0, 17, 2);
                yield return new cbpp(6, 0, 18, 3);
                yield return new cbpp(6, 1, 20, 4);
                yield return new cbpp(7, 8, 16, 1);
                yield return new cbpp(7, 1, 10, 2);
                yield return new cbpp(7, 3, 9, 3);
                yield return new cbpp(7, 0, 5, 4);
                yield return new cbpp(8, 12, 34, 1);
                yield return new cbpp(9, 2, 9, 1);
                yield return new cbpp(9, 0, 6, 2);
                yield return new cbpp(9, 0, 8, 3);
                yield return new cbpp(9, 0, 6, 4);
                yield return new cbpp(10, 1, 22, 1);
                yield return new cbpp(10, 1, 22, 2);
                yield return new cbpp(10, 0, 18, 3);
                yield return new cbpp(10, 2, 22, 4);
                yield return new cbpp(11, 0, 25, 1);
                yield return new cbpp(11, 5, 27, 2);
                yield return new cbpp(11, 3, 22, 3);
                yield return new cbpp(11, 1, 22, 4);
                yield return new cbpp(12, 2, 10, 1);
                yield return new cbpp(12, 1, 8, 2);
                yield return new cbpp(12, 0, 6, 3);
                yield return new cbpp(12, 0, 5, 4);
                yield return new cbpp(13, 1, 21, 1);
                yield return new cbpp(13, 2, 24, 2);
                yield return new cbpp(13, 0, 19, 3);
                yield return new cbpp(13, 0, 23, 4);
                yield return new cbpp(14, 11, 19, 1);
                yield return new cbpp(14, 0, 2, 2);
                yield return new cbpp(14, 0, 3, 3);
                yield return new cbpp(14, 0, 2, 4);
                yield return new cbpp(15, 1, 19, 1);
                yield return new cbpp(15, 1, 15, 2);
                yield return new cbpp(15, 1, 15, 3);
                yield return new cbpp(15, 0, 15, 4);
            }
        }
    }
}
