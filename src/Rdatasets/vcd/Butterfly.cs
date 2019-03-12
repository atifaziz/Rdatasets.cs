// ReSharper disable All

namespace Rdatasets.vcd
{
    using System.Collections.Generic;

    /// <summary>
    /// Butterfly Species in Malaya
    /// </summary>

    public class Butterfly
    {
        public readonly int κ;
        public readonly int nTokens;
        public readonly int Freq;

        public Butterfly(int κ, int nTokens, int Freq)
        {
            this.κ = κ;
            this.nTokens = nTokens;
            this.Freq = Freq;
        }

        public static IEnumerable<Butterfly> Data
        {
            get
            {
                yield return new Butterfly(1, 1, 118);
                yield return new Butterfly(2, 2, 74);
                yield return new Butterfly(3, 3, 44);
                yield return new Butterfly(4, 4, 24);
                yield return new Butterfly(5, 5, 29);
                yield return new Butterfly(6, 6, 22);
                yield return new Butterfly(7, 7, 20);
                yield return new Butterfly(8, 8, 19);
                yield return new Butterfly(9, 9, 20);
                yield return new Butterfly(10, 10, 15);
                yield return new Butterfly(11, 11, 12);
                yield return new Butterfly(12, 12, 14);
                yield return new Butterfly(13, 13, 6);
                yield return new Butterfly(14, 14, 12);
                yield return new Butterfly(15, 15, 6);
                yield return new Butterfly(16, 16, 9);
                yield return new Butterfly(17, 17, 9);
                yield return new Butterfly(18, 18, 6);
                yield return new Butterfly(19, 19, 10);
                yield return new Butterfly(20, 20, 10);
                yield return new Butterfly(21, 21, 11);
                yield return new Butterfly(22, 22, 5);
                yield return new Butterfly(23, 23, 3);
                yield return new Butterfly(24, 24, 3);
            }
        }
    }
}
