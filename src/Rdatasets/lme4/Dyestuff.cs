// ReSharper disable All

namespace Rdatasets.lme4
{
    using System.Collections.Generic;

    /// <summary>
    /// Yield of dyestuff by batch
    /// </summary>

    public class Dyestuff
    {
        public readonly int κ;
        public readonly string Batch;
        public readonly int Yield;

        public Dyestuff(int κ, string Batch, int Yield)
        {
            this.κ = κ;
            this.Batch = Batch;
            this.Yield = Yield;
        }

        public static IEnumerable<Dyestuff> Data
        {
            get
            {
                yield return new Dyestuff(1, "A", 1545);
                yield return new Dyestuff(2, "A", 1440);
                yield return new Dyestuff(3, "A", 1440);
                yield return new Dyestuff(4, "A", 1520);
                yield return new Dyestuff(5, "A", 1580);
                yield return new Dyestuff(6, "B", 1540);
                yield return new Dyestuff(7, "B", 1555);
                yield return new Dyestuff(8, "B", 1490);
                yield return new Dyestuff(9, "B", 1560);
                yield return new Dyestuff(10, "B", 1495);
                yield return new Dyestuff(11, "C", 1595);
                yield return new Dyestuff(12, "C", 1550);
                yield return new Dyestuff(13, "C", 1605);
                yield return new Dyestuff(14, "C", 1510);
                yield return new Dyestuff(15, "C", 1560);
                yield return new Dyestuff(16, "D", 1445);
                yield return new Dyestuff(17, "D", 1440);
                yield return new Dyestuff(18, "D", 1595);
                yield return new Dyestuff(19, "D", 1465);
                yield return new Dyestuff(20, "D", 1545);
                yield return new Dyestuff(21, "E", 1595);
                yield return new Dyestuff(22, "E", 1630);
                yield return new Dyestuff(23, "E", 1515);
                yield return new Dyestuff(24, "E", 1635);
                yield return new Dyestuff(25, "E", 1625);
                yield return new Dyestuff(26, "F", 1520);
                yield return new Dyestuff(27, "F", 1455);
                yield return new Dyestuff(28, "F", 1450);
                yield return new Dyestuff(29, "F", 1480);
                yield return new Dyestuff(30, "F", 1445);
            }
        }
    }
}
