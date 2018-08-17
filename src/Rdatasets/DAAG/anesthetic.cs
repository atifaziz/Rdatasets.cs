// ReSharper disable All

namespace Rdatasets.DAAG
{
    using System.Collections.Generic;

    /// <summary>
    /// Anesthetic Effectiveness
    /// </summary>

    public class anesthetic
    {
        public readonly int move;
        public readonly double conc;
        public readonly double logconc;
        public readonly int nomove;

        public anesthetic(int move, double conc, double logconc, int nomove)
        {
            this.move = move;
            this.conc = conc;
            this.logconc = logconc;
            this.nomove = nomove;
        }

        public static IEnumerable<anesthetic> Data
        {
            get
            {
                yield return new anesthetic(0, 1, 0, 1);
                yield return new anesthetic(1, 1.2, 0.182321556793955, 0);
                yield return new anesthetic(0, 1.4, 0.336472236621213, 1);
                yield return new anesthetic(1, 1.4, 0.336472236621213, 0);
                yield return new anesthetic(1, 1.2, 0.182321556793955, 0);
                yield return new anesthetic(0, 2.5, 0.916290731874155, 1);
                yield return new anesthetic(0, 1.6, 0.470003629245736, 1);
                yield return new anesthetic(1, 0.8, -0.22314355131421, 0);
                yield return new anesthetic(0, 1.6, 0.470003629245736, 1);
                yield return new anesthetic(1, 1.4, 0.336472236621213, 0);
                yield return new anesthetic(1, 0.8, -0.22314355131421, 0);
                yield return new anesthetic(0, 1.6, 0.470003629245736, 1);
                yield return new anesthetic(0, 2.5, 0.916290731874155, 1);
                yield return new anesthetic(0, 1.4, 0.336472236621213, 1);
                yield return new anesthetic(0, 1.6, 0.470003629245736, 1);
                yield return new anesthetic(0, 1.4, 0.336472236621213, 1);
                yield return new anesthetic(0, 1.4, 0.336472236621213, 1);
                yield return new anesthetic(1, 0.8, -0.22314355131421, 0);
                yield return new anesthetic(0, 0.8, -0.22314355131421, 1);
                yield return new anesthetic(0, 1.2, 0.182321556793955, 1);
                yield return new anesthetic(1, 0.8, -0.22314355131421, 0);
                yield return new anesthetic(1, 0.8, -0.22314355131421, 0);
                yield return new anesthetic(1, 1, 0, 0);
                yield return new anesthetic(1, 0.8, -0.22314355131421, 0);
                yield return new anesthetic(1, 1, 0, 0);
                yield return new anesthetic(0, 1.2, 0.182321556793955, 1);
                yield return new anesthetic(1, 1, 0, 0);
                yield return new anesthetic(0, 1.2, 0.182321556793955, 1);
                yield return new anesthetic(1, 1, 0, 0);
                yield return new anesthetic(0, 1.2, 0.182321556793955, 1);
            }
        }
    }
}
