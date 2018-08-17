// ReSharper disable All

namespace Rdatasets.carData
{
    using System.Collections.Generic;

    /// <summary>
    /// Davis's Data on Drive for Thinness
    /// </summary>

    public class DavisThin
    {
        public readonly int DT1;
        public readonly int DT2;
        public readonly int DT3;
        public readonly int DT4;
        public readonly int DT5;
        public readonly int DT6;
        public readonly int DT7;

        public DavisThin(int DT1, int DT2, int DT3, int DT4, int DT5, int DT6, int DT7)
        {
            this.DT1 = DT1;
            this.DT2 = DT2;
            this.DT3 = DT3;
            this.DT4 = DT4;
            this.DT5 = DT5;
            this.DT6 = DT6;
            this.DT7 = DT7;
        }

        public static IEnumerable<DavisThin> Data
        {
            get
            {
                yield return new DavisThin(0, 0, 0, 0, 0, 0, 0);
                yield return new DavisThin(0, 0, 0, 0, 0, 0, 0);
                yield return new DavisThin(0, 0, 0, 0, 0, 0, 0);
                yield return new DavisThin(0, 0, 0, 0, 0, 0, 0);
                yield return new DavisThin(0, 0, 0, 0, 0, 0, 0);
                yield return new DavisThin(0, 1, 0, 0, 0, 0, 0);
                yield return new DavisThin(0, 2, 2, 0, 2, 2, 0);
                yield return new DavisThin(2, 3, 3, 2, 3, 3, 3);
                yield return new DavisThin(0, 0, 0, 0, 3, 0, 0);
                yield return new DavisThin(3, 3, 2, 1, 3, 3, 0);
                yield return new DavisThin(1, 0, 3, 3, 3, 1, 3);
                yield return new DavisThin(0, 1, 2, 0, 1, 0, 0);
                yield return new DavisThin(0, 3, 1, 0, 0, 3, 0);
                yield return new DavisThin(1, 3, 2, 2, 1, 3, 0);
                yield return new DavisThin(0, 3, 3, 2, 3, 2, 2);
                yield return new DavisThin(0, 0, 0, 0, 0, 0, 0);
                yield return new DavisThin(0, 2, 3, 2, 3, 2, 0);
                yield return new DavisThin(0, 0, 3, 0, 3, 1, 3);
                yield return new DavisThin(3, 3, 3, 3, 3, 2, 0);
                yield return new DavisThin(0, 0, 0, 0, 0, 0, 0);
                yield return new DavisThin(2, 3, 3, 3, 2, 3, 2);
                yield return new DavisThin(0, 0, 0, 0, 2, 1, 0);
                yield return new DavisThin(0, 3, 0, 0, 3, 0, 0);
                yield return new DavisThin(3, 0, 0, 0, 2, 0, 0);
                yield return new DavisThin(0, 0, 0, 0, 0, 0, 0);
                yield return new DavisThin(0, 0, 0, 0, 0, 0, 0);
                yield return new DavisThin(3, 3, 3, 3, 3, 3, 3);
                yield return new DavisThin(0, 0, 0, 0, 0, 0, 0);
                yield return new DavisThin(0, 0, 0, 0, 0, 0, 0);
                yield return new DavisThin(0, 0, 0, 0, 3, 0, 0);
                yield return new DavisThin(0, 3, 3, 3, 3, 3, 3);
                yield return new DavisThin(0, 0, 0, 0, 0, 0, 0);
                yield return new DavisThin(1, 1, 2, 0, 2, 3, 3);
                yield return new DavisThin(0, 0, 1, 0, 0, 0, 0);
                yield return new DavisThin(0, 0, 0, 0, 0, 0, 0);
                yield return new DavisThin(2, 3, 3, 0, 3, 3, 3);
                yield return new DavisThin(0, 3, 3, 0, 3, 3, 3);
                yield return new DavisThin(0, 0, 0, 0, 0, 0, 0);
                yield return new DavisThin(0, 3, 1, 0, 2, 2, 0);
                yield return new DavisThin(0, 0, 0, 0, 0, 0, 0);
                yield return new DavisThin(0, 0, 1, 0, 0, 0, 0);
                yield return new DavisThin(2, 3, 1, 2, 1, 3, 0);
                yield return new DavisThin(0, 0, 0, 0, 0, 0, 0);
                yield return new DavisThin(0, 3, 3, 0, 3, 3, 3);
                yield return new DavisThin(0, 3, 2, 0, 3, 3, 1);
                yield return new DavisThin(0, 3, 0, 0, 0, 0, 0);
                yield return new DavisThin(2, 3, 3, 0, 3, 3, 1);
                yield return new DavisThin(0, 3, 0, 0, 3, 0, 0);
                yield return new DavisThin(0, 0, 0, 0, 2, 2, 0);
                yield return new DavisThin(0, 0, 0, 0, 0, 0, 0);
                yield return new DavisThin(0, 2, 1, 0, 2, 2, 0);
                yield return new DavisThin(0, 0, 0, 0, 0, 0, 0);
                yield return new DavisThin(0, 0, 0, 0, 0, 0, 0);
                yield return new DavisThin(1, 2, 1, 0, 2, 0, 0);
                yield return new DavisThin(0, 0, 0, 0, 0, 0, 0);
                yield return new DavisThin(0, 3, 1, 1, 3, 0, 0);
                yield return new DavisThin(0, 2, 0, 0, 0, 1, 0);
                yield return new DavisThin(1, 3, 3, 0, 3, 3, 3);
                yield return new DavisThin(0, 0, 0, 0, 0, 0, 0);
                yield return new DavisThin(0, 0, 0, 0, 0, 0, 0);
                yield return new DavisThin(0, 0, 2, 0, 3, 0, 0);
                yield return new DavisThin(1, 0, 0, 0, 0, 0, 0);
                yield return new DavisThin(0, 0, 0, 0, 0, 0, 0);
                yield return new DavisThin(2, 3, 0, 0, 3, 2, 0);
                yield return new DavisThin(1, 0, 0, 0, 0, 0, 0);
                yield return new DavisThin(0, 0, 0, 0, 0, 0, 0);
                yield return new DavisThin(1, 3, 2, 2, 2, 3, 1);
                yield return new DavisThin(0, 0, 0, 0, 0, 0, 0);
                yield return new DavisThin(0, 2, 1, 0, 2, 3, 0);
                yield return new DavisThin(0, 0, 0, 0, 0, 0, 0);
                yield return new DavisThin(0, 0, 0, 0, 0, 0, 0);
                yield return new DavisThin(1, 3, 2, 2, 3, 2, 0);
                yield return new DavisThin(2, 3, 3, 2, 3, 3, 2);
                yield return new DavisThin(0, 0, 3, 0, 2, 1, 0);
                yield return new DavisThin(0, 0, 0, 0, 0, 0, 0);
                yield return new DavisThin(2, 3, 3, 0, 3, 3, 3);
                yield return new DavisThin(0, 0, 0, 0, 0, 0, 0);
                yield return new DavisThin(0, 0, 3, 0, 3, 3, 2);
                yield return new DavisThin(2, 1, 0, 0, 3, 0, 0);
                yield return new DavisThin(0, 0, 0, 0, 0, 0, 0);
                yield return new DavisThin(0, 2, 1, 0, 0, 1, 3);
                yield return new DavisThin(0, 0, 0, 0, 0, 0, 0);
                yield return new DavisThin(0, 0, 0, 0, 0, 1, 1);
                yield return new DavisThin(0, 0, 0, 0, 0, 0, 0);
                yield return new DavisThin(0, 0, 0, 0, 3, 0, 0);
                yield return new DavisThin(0, 0, 0, 0, 0, 0, 0);
                yield return new DavisThin(0, 0, 0, 0, 2, 2, 2);
                yield return new DavisThin(0, 0, 0, 0, 0, 0, 0);
                yield return new DavisThin(0, 0, 0, 0, 0, 0, 0);
                yield return new DavisThin(0, 2, 2, 0, 3, 3, 1);
                yield return new DavisThin(0, 0, 0, 0, 0, 0, 0);
                yield return new DavisThin(3, 0, 0, 0, 0, 0, 0);
                yield return new DavisThin(3, 2, 3, 0, 2, 0, 0);
                yield return new DavisThin(0, 0, 0, 0, 0, 0, 0);
                yield return new DavisThin(0, 0, 1, 0, 0, 0, 0);
                yield return new DavisThin(0, 0, 0, 0, 0, 0, 0);
                yield return new DavisThin(0, 0, 0, 0, 0, 0, 0);
                yield return new DavisThin(0, 0, 0, 0, 0, 0, 0);
                yield return new DavisThin(0, 2, 2, 0, 2, 1, 0);
                yield return new DavisThin(1, 2, 3, 0, 3, 3, 2);
                yield return new DavisThin(0, 0, 0, 0, 0, 0, 0);
                yield return new DavisThin(1, 3, 3, 3, 3, 3, 3);
                yield return new DavisThin(2, 3, 3, 3, 3, 3, 3);
                yield return new DavisThin(0, 3, 3, 0, 3, 3, 3);
                yield return new DavisThin(0, 0, 1, 0, 0, 0, 0);
                yield return new DavisThin(2, 3, 3, 2, 3, 3, 2);
                yield return new DavisThin(0, 0, 0, 0, 0, 0, 0);
                yield return new DavisThin(0, 0, 0, 0, 0, 0, 1);
                yield return new DavisThin(1, 1, 0, 0, 0, 1, 1);
                yield return new DavisThin(2, 2, 1, 0, 0, 1, 0);
                yield return new DavisThin(0, 3, 3, 2, 3, 1, 2);
                yield return new DavisThin(0, 0, 0, 0, 1, 0, 0);
                yield return new DavisThin(0, 0, 0, 0, 0, 0, 0);
                yield return new DavisThin(0, 3, 0, 1, 2, 2, 0);
                yield return new DavisThin(0, 0, 0, 0, 0, 0, 0);
                yield return new DavisThin(3, 3, 3, 2, 3, 3, 2);
                yield return new DavisThin(1, 0, 0, 0, 0, 0, 0);
                yield return new DavisThin(0, 0, 0, 0, 0, 0, 0);
                yield return new DavisThin(2, 2, 2, 0, 3, 2, 2);
                yield return new DavisThin(0, 0, 3, 2, 3, 2, 0);
                yield return new DavisThin(0, 0, 0, 0, 0, 0, 0);
                yield return new DavisThin(0, 1, 1, 0, 1, 1, 0);
                yield return new DavisThin(0, 3, 3, 0, 3, 3, 3);
                yield return new DavisThin(0, 1, 0, 0, 0, 1, 0);
                yield return new DavisThin(1, 1, 0, 0, 0, 0, 0);
                yield return new DavisThin(1, 2, 2, 0, 3, 2, 1);
                yield return new DavisThin(1, 3, 3, 0, 0, 0, 0);
                yield return new DavisThin(0, 1, 0, 0, 2, 2, 2);
                yield return new DavisThin(1, 2, 2, 0, 3, 2, 1);
                yield return new DavisThin(1, 2, 3, 0, 3, 0, 3);
                yield return new DavisThin(1, 0, 0, 0, 0, 1, 0);
                yield return new DavisThin(0, 0, 0, 0, 0, 0, 0);
                yield return new DavisThin(0, 2, 0, 1, 0, 0, 0);
                yield return new DavisThin(1, 3, 3, 0, 3, 3, 3);
                yield return new DavisThin(3, 0, 3, 0, 0, 3, 3);
                yield return new DavisThin(0, 0, 0, 0, 0, 0, 0);
                yield return new DavisThin(0, 0, 0, 0, 0, 0, 0);
                yield return new DavisThin(0, 2, 0, 0, 0, 3, 0);
                yield return new DavisThin(0, 2, 0, 0, 2, 2, 0);
                yield return new DavisThin(0, 3, 3, 0, 3, 3, 3);
                yield return new DavisThin(2, 0, 3, 0, 3, 3, 3);
                yield return new DavisThin(1, 0, 0, 0, 0, 0, 0);
                yield return new DavisThin(0, 1, 2, 0, 0, 0, 0);
                yield return new DavisThin(0, 2, 2, 1, 2, 2, 2);
                yield return new DavisThin(0, 0, 0, 0, 0, 0, 0);
                yield return new DavisThin(0, 3, 3, 1, 3, 3, 2);
                yield return new DavisThin(1, 0, 0, 0, 0, 0, 0);
                yield return new DavisThin(0, 0, 3, 0, 0, 0, 0);
                yield return new DavisThin(0, 2, 3, 2, 2, 2, 0);
                yield return new DavisThin(0, 3, 3, 0, 3, 2, 1);
                yield return new DavisThin(0, 0, 0, 0, 0, 0, 0);
                yield return new DavisThin(0, 0, 0, 0, 0, 0, 0);
                yield return new DavisThin(2, 2, 3, 2, 3, 3, 3);
                yield return new DavisThin(2, 0, 0, 0, 0, 0, 0);
                yield return new DavisThin(0, 0, 0, 0, 0, 0, 0);
                yield return new DavisThin(0, 0, 0, 0, 0, 0, 0);
                yield return new DavisThin(0, 0, 0, 0, 0, 0, 0);
                yield return new DavisThin(0, 0, 0, 0, 1, 2, 0);
                yield return new DavisThin(1, 3, 3, 2, 3, 3, 3);
                yield return new DavisThin(0, 1, 0, 0, 0, 0, 0);
                yield return new DavisThin(0, 0, 0, 0, 0, 0, 0);
                yield return new DavisThin(0, 0, 0, 0, 1, 0, 0);
                yield return new DavisThin(0, 0, 0, 0, 0, 0, 0);
                yield return new DavisThin(0, 3, 0, 1, 0, 2, 0);
                yield return new DavisThin(0, 1, 0, 0, 0, 0, 0);
                yield return new DavisThin(1, 0, 1, 0, 1, 0, 0);
                yield return new DavisThin(0, 0, 0, 0, 1, 0, 0);
                yield return new DavisThin(0, 0, 0, 0, 0, 0, 0);
                yield return new DavisThin(0, 3, 2, 3, 3, 3, 0);
                yield return new DavisThin(0, 0, 0, 2, 1, 1, 0);
                yield return new DavisThin(2, 2, 2, 1, 1, 2, 0);
                yield return new DavisThin(0, 0, 0, 0, 0, 0, 0);
                yield return new DavisThin(1, 0, 0, 0, 0, 0, 0);
                yield return new DavisThin(0, 0, 2, 0, 1, 0, 1);
                yield return new DavisThin(0, 0, 0, 0, 0, 0, 0);
                yield return new DavisThin(0, 0, 2, 0, 0, 0, 0);
                yield return new DavisThin(0, 0, 0, 0, 0, 0, 0);
                yield return new DavisThin(0, 3, 0, 0, 0, 0, 0);
                yield return new DavisThin(0, 3, 2, 0, 1, 0, 0);
                yield return new DavisThin(1, 3, 2, 1, 3, 3, 1);
                yield return new DavisThin(0, 0, 0, 0, 0, 0, 0);
                yield return new DavisThin(0, 0, 0, 0, 0, 0, 0);
                yield return new DavisThin(0, 0, 0, 0, 0, 0, 0);
                yield return new DavisThin(0, 0, 0, 0, 0, 0, 0);
                yield return new DavisThin(2, 1, 3, 0, 0, 0, 0);
                yield return new DavisThin(1, 1, 0, 0, 0, 0, 0);
                yield return new DavisThin(0, 0, 0, 0, 0, 0, 0);
                yield return new DavisThin(2, 0, 1, 0, 3, 0, 1);
                yield return new DavisThin(0, 0, 0, 0, 2, 0, 0);
                yield return new DavisThin(0, 0, 0, 0, 1, 3, 0);
                yield return new DavisThin(0, 0, 0, 0, 0, 0, 0);
            }
        }
    }
}
