// ReSharper disable All

namespace Rdatasets.drc
{
    using System.Collections.Generic;

    /// <summary>
    /// Effect of cadmium on growth of green alga
    /// </summary>

    public class S_capricornutum
    {
        public readonly int κ;
        public readonly int conc;
        public readonly double count;

        public S_capricornutum(int κ, int conc, double count)
        {
            this.κ = κ;
            this.conc = conc;
            this.count = count;
        }

        public static IEnumerable<S_capricornutum> Data
        {
            get
            {
                yield return new S_capricornutum(1, 0, 120.9);
                yield return new S_capricornutum(2, 0, 118);
                yield return new S_capricornutum(3, 0, 134);
                yield return new S_capricornutum(4, 5, 121.2);
                yield return new S_capricornutum(5, 5, 118.6);
                yield return new S_capricornutum(6, 5, 120.4);
                yield return new S_capricornutum(7, 10, 82.6);
                yield return new S_capricornutum(8, 10, 62.8);
                yield return new S_capricornutum(9, 10, 81.6);
                yield return new S_capricornutum(10, 20, 49.3);
                yield return new S_capricornutum(11, 20, 41.6);
                yield return new S_capricornutum(12, 20, 41.3);
                yield return new S_capricornutum(13, 40, 12.7);
                yield return new S_capricornutum(14, 40, 14.7);
                yield return new S_capricornutum(15, 40, 14.7);
                yield return new S_capricornutum(16, 80, 4.93);
                yield return new S_capricornutum(17, 80, 4);
                yield return new S_capricornutum(18, 80, 4.4);
            }
        }
    }
}
