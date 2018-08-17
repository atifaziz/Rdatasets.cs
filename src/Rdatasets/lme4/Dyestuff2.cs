// ReSharper disable All

namespace Rdatasets.lme4
{
    using System.Collections.Generic;

    /// <summary>
    /// Yield of dyestuff by batch
    /// </summary>

    public class Dyestuff2
    {
        public readonly string Batch;
        public readonly double Yield;

        public Dyestuff2(string Batch, double Yield)
        {
            this.Batch = Batch;
            this.Yield = Yield;
        }

        public static IEnumerable<Dyestuff2> Data
        {
            get
            {
                yield return new Dyestuff2("A", 7.298);
                yield return new Dyestuff2("A", 3.846);
                yield return new Dyestuff2("A", 2.434);
                yield return new Dyestuff2("A", 9.566);
                yield return new Dyestuff2("A", 7.99);
                yield return new Dyestuff2("B", 5.22);
                yield return new Dyestuff2("B", 6.556);
                yield return new Dyestuff2("B", 0.608);
                yield return new Dyestuff2("B", 11.788);
                yield return new Dyestuff2("B", -0.892);
                yield return new Dyestuff2("C", 0.11);
                yield return new Dyestuff2("C", 10.386);
                yield return new Dyestuff2("C", 13.434);
                yield return new Dyestuff2("C", 5.51);
                yield return new Dyestuff2("C", 8.166);
                yield return new Dyestuff2("D", 2.212);
                yield return new Dyestuff2("D", 4.852);
                yield return new Dyestuff2("D", 7.092);
                yield return new Dyestuff2("D", 9.288);
                yield return new Dyestuff2("D", 4.98);
                yield return new Dyestuff2("E", 0.282);
                yield return new Dyestuff2("E", 9.014);
                yield return new Dyestuff2("E", 4.458);
                yield return new Dyestuff2("E", 9.446);
                yield return new Dyestuff2("E", 7.198);
                yield return new Dyestuff2("F", 1.722);
                yield return new Dyestuff2("F", 4.782);
                yield return new Dyestuff2("F", 8.106);
                yield return new Dyestuff2("F", 0.758);
                yield return new Dyestuff2("F", 3.758);
            }
        }
    }
}
