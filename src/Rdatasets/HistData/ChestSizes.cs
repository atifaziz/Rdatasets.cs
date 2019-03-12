// ReSharper disable All

namespace Rdatasets.HistData
{
    using System.Collections.Generic;

    /// <summary>
    /// Chest measurements of 5738 Scottish Militiamen
    /// </summary>

    public class ChestSizes
    {
        public readonly int κ;
        public readonly int chest;
        public readonly int count;

        public ChestSizes(int κ, int chest, int count)
        {
            this.κ = κ;
            this.chest = chest;
            this.count = count;
        }

        public static IEnumerable<ChestSizes> Data
        {
            get
            {
                yield return new ChestSizes(1, 33, 3);
                yield return new ChestSizes(2, 34, 18);
                yield return new ChestSizes(3, 35, 81);
                yield return new ChestSizes(4, 36, 185);
                yield return new ChestSizes(5, 37, 420);
                yield return new ChestSizes(6, 38, 749);
                yield return new ChestSizes(7, 39, 1073);
                yield return new ChestSizes(8, 40, 1079);
                yield return new ChestSizes(9, 41, 934);
                yield return new ChestSizes(10, 42, 658);
                yield return new ChestSizes(11, 43, 370);
                yield return new ChestSizes(12, 44, 92);
                yield return new ChestSizes(13, 45, 50);
                yield return new ChestSizes(14, 46, 21);
                yield return new ChestSizes(15, 47, 4);
                yield return new ChestSizes(16, 48, 1);
            }
        }
    }
}
