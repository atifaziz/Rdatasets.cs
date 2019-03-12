// ReSharper disable All

namespace Rdatasets.MASS
{
    using System.Collections.Generic;

    /// <summary>
    /// Determinations of Nickel Content
    /// </summary>

    public class abbey
    {
        public readonly int κ;
        public readonly double dat;

        public abbey(int κ, double dat)
        {
            this.κ = κ;
            this.dat = dat;
        }

        public static IEnumerable<abbey> Data
        {
            get
            {
                yield return new abbey(1, 5.2);
                yield return new abbey(2, 6.5);
                yield return new abbey(3, 6.9);
                yield return new abbey(4, 7);
                yield return new abbey(5, 7);
                yield return new abbey(6, 7);
                yield return new abbey(7, 7.4);
                yield return new abbey(8, 8);
                yield return new abbey(9, 8);
                yield return new abbey(10, 8);
                yield return new abbey(11, 8);
                yield return new abbey(12, 8.5);
                yield return new abbey(13, 9);
                yield return new abbey(14, 9);
                yield return new abbey(15, 10);
                yield return new abbey(16, 11);
                yield return new abbey(17, 11);
                yield return new abbey(18, 12);
                yield return new abbey(19, 12);
                yield return new abbey(20, 13.7);
                yield return new abbey(21, 14);
                yield return new abbey(22, 14);
                yield return new abbey(23, 14);
                yield return new abbey(24, 16);
                yield return new abbey(25, 17);
                yield return new abbey(26, 17);
                yield return new abbey(27, 18);
                yield return new abbey(28, 24);
                yield return new abbey(29, 28);
                yield return new abbey(30, 34);
                yield return new abbey(31, 125);
            }
        }
    }
}
