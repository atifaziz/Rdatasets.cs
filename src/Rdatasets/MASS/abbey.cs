// ReSharper disable All

namespace Rdatasets.MASS
{
    using System.Collections.Generic;

    /// <summary>
    /// Determinations of Nickel Content
    /// </summary>

    public class abbey
    {
        public readonly double dat;

        public abbey(double dat)
        {
            this.dat = dat;
        }

        public static IEnumerable<abbey> Data
        {
            get
            {
                yield return new abbey(5.2);
                yield return new abbey(6.5);
                yield return new abbey(6.9);
                yield return new abbey(7);
                yield return new abbey(7);
                yield return new abbey(7);
                yield return new abbey(7.4);
                yield return new abbey(8);
                yield return new abbey(8);
                yield return new abbey(8);
                yield return new abbey(8);
                yield return new abbey(8.5);
                yield return new abbey(9);
                yield return new abbey(9);
                yield return new abbey(10);
                yield return new abbey(11);
                yield return new abbey(11);
                yield return new abbey(12);
                yield return new abbey(12);
                yield return new abbey(13.7);
                yield return new abbey(14);
                yield return new abbey(14);
                yield return new abbey(14);
                yield return new abbey(16);
                yield return new abbey(17);
                yield return new abbey(17);
                yield return new abbey(18);
                yield return new abbey(24);
                yield return new abbey(28);
                yield return new abbey(34);
                yield return new abbey(125);
            }
        }
    }
}
