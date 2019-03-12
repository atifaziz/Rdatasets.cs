// ReSharper disable All

namespace Rdatasets.drc
{
    using System.Collections.Generic;

    /// <summary>
    /// Hormesis in lettuce plants
    /// </summary>

    public class lettuce
    {
        public readonly int κ;
        public readonly double conc;
        public readonly double weight;

        public lettuce(int κ, double conc, double weight)
        {
            this.κ = κ;
            this.conc = conc;
            this.weight = weight;
        }

        public static IEnumerable<lettuce> Data
        {
            get
            {
                yield return new lettuce(1, 0, 1.126);
                yield return new lettuce(2, 0, 0.833);
                yield return new lettuce(3, 0.32, 1.096);
                yield return new lettuce(4, 0.32, 1.106);
                yield return new lettuce(5, 1, 1.163);
                yield return new lettuce(6, 1, 1.336);
                yield return new lettuce(7, 3.2, 0.985);
                yield return new lettuce(8, 3.2, 0.754);
                yield return new lettuce(9, 10, 0.716);
                yield return new lettuce(10, 10, 0.683);
                yield return new lettuce(11, 32, 0.56);
                yield return new lettuce(12, 32, 0.488);
                yield return new lettuce(13, 100, 0.375);
                yield return new lettuce(14, 100, 0.344);
            }
        }
    }
}
