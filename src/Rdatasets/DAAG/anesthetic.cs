// ReSharper disable All

namespace Rdatasets.DAAG
{
    using System.Collections.Generic;

    /// <summary>
    /// Anesthetic Effectiveness
    /// </summary>

    public class anesthetic
    {
        public readonly int κ;
        public readonly int move;
        public readonly double conc;
        public readonly double logconc;
        public readonly int nomove;

        public anesthetic(int κ, int move, double conc, double logconc, int nomove)
        {
            this.κ = κ;
            this.move = move;
            this.conc = conc;
            this.logconc = logconc;
            this.nomove = nomove;
        }

        public static IEnumerable<anesthetic> Data
        {
            get
            {
                yield return new anesthetic(1, 0, 1, 0, 1);
                yield return new anesthetic(2, 1, 1.2, 0.182321556793955, 0);
                yield return new anesthetic(3, 0, 1.4, 0.336472236621213, 1);
                yield return new anesthetic(4, 1, 1.4, 0.336472236621213, 0);
                yield return new anesthetic(5, 1, 1.2, 0.182321556793955, 0);
                yield return new anesthetic(6, 0, 2.5, 0.916290731874155, 1);
                yield return new anesthetic(7, 0, 1.6, 0.470003629245736, 1);
                yield return new anesthetic(8, 1, 0.8, -0.22314355131421, 0);
                yield return new anesthetic(9, 0, 1.6, 0.470003629245736, 1);
                yield return new anesthetic(10, 1, 1.4, 0.336472236621213, 0);
                yield return new anesthetic(11, 1, 0.8, -0.22314355131421, 0);
                yield return new anesthetic(12, 0, 1.6, 0.470003629245736, 1);
                yield return new anesthetic(13, 0, 2.5, 0.916290731874155, 1);
                yield return new anesthetic(14, 0, 1.4, 0.336472236621213, 1);
                yield return new anesthetic(15, 0, 1.6, 0.470003629245736, 1);
                yield return new anesthetic(16, 0, 1.4, 0.336472236621213, 1);
                yield return new anesthetic(17, 0, 1.4, 0.336472236621213, 1);
                yield return new anesthetic(18, 1, 0.8, -0.22314355131421, 0);
                yield return new anesthetic(19, 0, 0.8, -0.22314355131421, 1);
                yield return new anesthetic(20, 0, 1.2, 0.182321556793955, 1);
                yield return new anesthetic(21, 1, 0.8, -0.22314355131421, 0);
                yield return new anesthetic(22, 1, 0.8, -0.22314355131421, 0);
                yield return new anesthetic(23, 1, 1, 0, 0);
                yield return new anesthetic(24, 1, 0.8, -0.22314355131421, 0);
                yield return new anesthetic(25, 1, 1, 0, 0);
                yield return new anesthetic(26, 0, 1.2, 0.182321556793955, 1);
                yield return new anesthetic(27, 1, 1, 0, 0);
                yield return new anesthetic(28, 0, 1.2, 0.182321556793955, 1);
                yield return new anesthetic(29, 1, 1, 0, 0);
                yield return new anesthetic(30, 0, 1.2, 0.182321556793955, 1);
            }
        }
    }
}
