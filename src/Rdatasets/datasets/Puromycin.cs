// ReSharper disable All

namespace Rdatasets.datasets
{
    using System.Collections.Generic;

    /// <summary>
    /// Reaction Velocity of an Enzymatic Reaction
    /// </summary>

    public class Puromycin
    {
        public readonly double conc;
        public readonly int rate;
        public readonly string state;

        public Puromycin(double conc, int rate, string state)
        {
            this.conc = conc;
            this.rate = rate;
            this.state = state;
        }

        public static IEnumerable<Puromycin> Data
        {
            get
            {
                yield return new Puromycin(0.02, 76, "treated");
                yield return new Puromycin(0.02, 47, "treated");
                yield return new Puromycin(0.06, 97, "treated");
                yield return new Puromycin(0.06, 107, "treated");
                yield return new Puromycin(0.11, 123, "treated");
                yield return new Puromycin(0.11, 139, "treated");
                yield return new Puromycin(0.22, 159, "treated");
                yield return new Puromycin(0.22, 152, "treated");
                yield return new Puromycin(0.56, 191, "treated");
                yield return new Puromycin(0.56, 201, "treated");
                yield return new Puromycin(1.1, 207, "treated");
                yield return new Puromycin(1.1, 200, "treated");
                yield return new Puromycin(0.02, 67, "untreated");
                yield return new Puromycin(0.02, 51, "untreated");
                yield return new Puromycin(0.06, 84, "untreated");
                yield return new Puromycin(0.06, 86, "untreated");
                yield return new Puromycin(0.11, 98, "untreated");
                yield return new Puromycin(0.11, 115, "untreated");
                yield return new Puromycin(0.22, 131, "untreated");
                yield return new Puromycin(0.22, 124, "untreated");
                yield return new Puromycin(0.56, 144, "untreated");
                yield return new Puromycin(0.56, 158, "untreated");
                yield return new Puromycin(1.1, 160, "untreated");
            }
        }
    }
}
