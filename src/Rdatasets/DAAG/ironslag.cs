// ReSharper disable All

namespace Rdatasets.DAAG
{
    using System.Collections.Generic;

    /// <summary>
    /// Iron Content Measurements
    /// </summary>

    public class ironslag
    {
        public readonly int chemical;
        public readonly int magnetic;

        public ironslag(int chemical, int magnetic)
        {
            this.chemical = chemical;
            this.magnetic = magnetic;
        }

        public static IEnumerable<ironslag> Data
        {
            get
            {
                yield return new ironslag(24, 25);
                yield return new ironslag(16, 22);
                yield return new ironslag(24, 17);
                yield return new ironslag(18, 21);
                yield return new ironslag(18, 20);
                yield return new ironslag(10, 13);
                yield return new ironslag(14, 16);
                yield return new ironslag(16, 14);
                yield return new ironslag(18, 19);
                yield return new ironslag(20, 10);
                yield return new ironslag(21, 23);
                yield return new ironslag(20, 20);
                yield return new ironslag(21, 19);
                yield return new ironslag(15, 15);
                yield return new ironslag(16, 16);
                yield return new ironslag(15, 16);
                yield return new ironslag(17, 12);
                yield return new ironslag(19, 15);
                yield return new ironslag(16, 15);
                yield return new ironslag(15, 15);
                yield return new ironslag(15, 15);
                yield return new ironslag(13, 17);
                yield return new ironslag(24, 18);
                yield return new ironslag(22, 16);
                yield return new ironslag(21, 18);
                yield return new ironslag(24, 22);
                yield return new ironslag(15, 20);
                yield return new ironslag(20, 21);
                yield return new ironslag(20, 21);
                yield return new ironslag(25, 21);
                yield return new ironslag(27, 25);
                yield return new ironslag(22, 22);
                yield return new ironslag(20, 18);
                yield return new ironslag(24, 21);
                yield return new ironslag(24, 18);
                yield return new ironslag(23, 20);
                yield return new ironslag(29, 25);
                yield return new ironslag(27, 20);
                yield return new ironslag(23, 18);
                yield return new ironslag(19, 19);
                yield return new ironslag(25, 16);
                yield return new ironslag(15, 16);
                yield return new ironslag(16, 16);
                yield return new ironslag(27, 26);
                yield return new ironslag(27, 28);
                yield return new ironslag(30, 28);
                yield return new ironslag(29, 30);
                yield return new ironslag(26, 32);
                yield return new ironslag(25, 28);
                yield return new ironslag(25, 36);
                yield return new ironslag(32, 40);
                yield return new ironslag(28, 33);
                yield return new ironslag(25, 33);
            }
        }
    }
}
