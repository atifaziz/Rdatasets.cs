// ReSharper disable All

namespace Rdatasets.drc
{
    using System.Collections.Generic;

    /// <summary>
    /// Effect of cadmium on growth of green alga
    /// </summary>

    public class S_capricornutum
    {
        public readonly int conc;
        public readonly double count;

        public S_capricornutum(int conc, double count)
        {
            this.conc = conc;
            this.count = count;
        }

        public static IEnumerable<S_capricornutum> Data
        {
            get
            {
                yield return new S_capricornutum(0, 120.9);
                yield return new S_capricornutum(0, 118);
                yield return new S_capricornutum(0, 134);
                yield return new S_capricornutum(5, 121.2);
                yield return new S_capricornutum(5, 118.6);
                yield return new S_capricornutum(5, 120.4);
                yield return new S_capricornutum(10, 82.6);
                yield return new S_capricornutum(10, 62.8);
                yield return new S_capricornutum(10, 81.6);
                yield return new S_capricornutum(20, 49.3);
                yield return new S_capricornutum(20, 41.6);
                yield return new S_capricornutum(20, 41.3);
                yield return new S_capricornutum(40, 12.7);
                yield return new S_capricornutum(40, 14.7);
                yield return new S_capricornutum(40, 14.7);
                yield return new S_capricornutum(80, 4.93);
                yield return new S_capricornutum(80, 4);
                yield return new S_capricornutum(80, 4.4);
            }
        }
    }
}
