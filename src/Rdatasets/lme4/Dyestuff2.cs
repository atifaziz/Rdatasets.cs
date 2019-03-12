// ReSharper disable All

namespace Rdatasets.lme4
{
    using System.Collections.Generic;

    /// <summary>
    /// Yield of dyestuff by batch
    /// </summary>

    public class Dyestuff2
    {
        public readonly int κ;
        public readonly string Batch;
        public readonly double Yield;

        public Dyestuff2(int κ, string Batch, double Yield)
        {
            this.κ = κ;
            this.Batch = Batch;
            this.Yield = Yield;
        }

        public static IEnumerable<Dyestuff2> Data
        {
            get
            {
                yield return new Dyestuff2(1, "A", 7.298);
                yield return new Dyestuff2(2, "A", 3.846);
                yield return new Dyestuff2(3, "A", 2.434);
                yield return new Dyestuff2(4, "A", 9.566);
                yield return new Dyestuff2(5, "A", 7.99);
                yield return new Dyestuff2(6, "B", 5.22);
                yield return new Dyestuff2(7, "B", 6.556);
                yield return new Dyestuff2(8, "B", 0.608);
                yield return new Dyestuff2(9, "B", 11.788);
                yield return new Dyestuff2(10, "B", -0.892);
                yield return new Dyestuff2(11, "C", 0.11);
                yield return new Dyestuff2(12, "C", 10.386);
                yield return new Dyestuff2(13, "C", 13.434);
                yield return new Dyestuff2(14, "C", 5.51);
                yield return new Dyestuff2(15, "C", 8.166);
                yield return new Dyestuff2(16, "D", 2.212);
                yield return new Dyestuff2(17, "D", 4.852);
                yield return new Dyestuff2(18, "D", 7.092);
                yield return new Dyestuff2(19, "D", 9.288);
                yield return new Dyestuff2(20, "D", 4.98);
                yield return new Dyestuff2(21, "E", 0.282);
                yield return new Dyestuff2(22, "E", 9.014);
                yield return new Dyestuff2(23, "E", 4.458);
                yield return new Dyestuff2(24, "E", 9.446);
                yield return new Dyestuff2(25, "E", 7.198);
                yield return new Dyestuff2(26, "F", 1.722);
                yield return new Dyestuff2(27, "F", 4.782);
                yield return new Dyestuff2(28, "F", 8.106);
                yield return new Dyestuff2(29, "F", 0.758);
                yield return new Dyestuff2(30, "F", 3.758);
            }
        }
    }
}
