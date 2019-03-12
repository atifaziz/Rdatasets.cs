// ReSharper disable All

namespace Rdatasets.datasets
{
    using System.Collections.Generic;

    /// <summary>
    /// Reaction Velocity of an Enzymatic Reaction
    /// </summary>

    public class Puromycin
    {
        public readonly int κ;
        public readonly double conc;
        public readonly int rate;
        public readonly string state;

        public Puromycin(int κ, double conc, int rate, string state)
        {
            this.κ = κ;
            this.conc = conc;
            this.rate = rate;
            this.state = state;
        }

        public static IEnumerable<Puromycin> Data
        {
            get
            {
                yield return new Puromycin(1, 0.02, 76, "treated");
                yield return new Puromycin(2, 0.02, 47, "treated");
                yield return new Puromycin(3, 0.06, 97, "treated");
                yield return new Puromycin(4, 0.06, 107, "treated");
                yield return new Puromycin(5, 0.11, 123, "treated");
                yield return new Puromycin(6, 0.11, 139, "treated");
                yield return new Puromycin(7, 0.22, 159, "treated");
                yield return new Puromycin(8, 0.22, 152, "treated");
                yield return new Puromycin(9, 0.56, 191, "treated");
                yield return new Puromycin(10, 0.56, 201, "treated");
                yield return new Puromycin(11, 1.1, 207, "treated");
                yield return new Puromycin(12, 1.1, 200, "treated");
                yield return new Puromycin(13, 0.02, 67, "untreated");
                yield return new Puromycin(14, 0.02, 51, "untreated");
                yield return new Puromycin(15, 0.06, 84, "untreated");
                yield return new Puromycin(16, 0.06, 86, "untreated");
                yield return new Puromycin(17, 0.11, 98, "untreated");
                yield return new Puromycin(18, 0.11, 115, "untreated");
                yield return new Puromycin(19, 0.22, 131, "untreated");
                yield return new Puromycin(20, 0.22, 124, "untreated");
                yield return new Puromycin(21, 0.56, 144, "untreated");
                yield return new Puromycin(22, 0.56, 158, "untreated");
                yield return new Puromycin(23, 1.1, 160, "untreated");
            }
        }
    }
}
