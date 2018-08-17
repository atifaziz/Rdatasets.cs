// ReSharper disable All

namespace Rdatasets.lme4
{
    using System.Collections.Generic;

    /// <summary>
    /// Yield of dyestuff by batch
    /// </summary>

    public class Dyestuff
    {
        public readonly string Batch;
        public readonly int Yield;

        public Dyestuff(string Batch, int Yield)
        {
            this.Batch = Batch;
            this.Yield = Yield;
        }

        public static IEnumerable<Dyestuff> Data
        {
            get
            {
                yield return new Dyestuff("A", 1545);
                yield return new Dyestuff("A", 1440);
                yield return new Dyestuff("A", 1440);
                yield return new Dyestuff("A", 1520);
                yield return new Dyestuff("A", 1580);
                yield return new Dyestuff("B", 1540);
                yield return new Dyestuff("B", 1555);
                yield return new Dyestuff("B", 1490);
                yield return new Dyestuff("B", 1560);
                yield return new Dyestuff("B", 1495);
                yield return new Dyestuff("C", 1595);
                yield return new Dyestuff("C", 1550);
                yield return new Dyestuff("C", 1605);
                yield return new Dyestuff("C", 1510);
                yield return new Dyestuff("C", 1560);
                yield return new Dyestuff("D", 1445);
                yield return new Dyestuff("D", 1440);
                yield return new Dyestuff("D", 1595);
                yield return new Dyestuff("D", 1465);
                yield return new Dyestuff("D", 1545);
                yield return new Dyestuff("E", 1595);
                yield return new Dyestuff("E", 1630);
                yield return new Dyestuff("E", 1515);
                yield return new Dyestuff("E", 1635);
                yield return new Dyestuff("E", 1625);
                yield return new Dyestuff("F", 1520);
                yield return new Dyestuff("F", 1455);
                yield return new Dyestuff("F", 1450);
                yield return new Dyestuff("F", 1480);
                yield return new Dyestuff("F", 1445);
            }
        }
    }
}
