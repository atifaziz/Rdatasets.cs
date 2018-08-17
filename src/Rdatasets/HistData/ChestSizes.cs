// ReSharper disable All

namespace Rdatasets.HistData
{
    using System.Collections.Generic;

    /// <summary>
    /// Chest measurements of 5738 Scottish Militiamen
    /// </summary>

    public class ChestSizes
    {
        public readonly int chest;
        public readonly int count;

        public ChestSizes(int chest, int count)
        {
            this.chest = chest;
            this.count = count;
        }

        public static IEnumerable<ChestSizes> Data
        {
            get
            {
                yield return new ChestSizes(33, 3);
                yield return new ChestSizes(34, 18);
                yield return new ChestSizes(35, 81);
                yield return new ChestSizes(36, 185);
                yield return new ChestSizes(37, 420);
                yield return new ChestSizes(38, 749);
                yield return new ChestSizes(39, 1073);
                yield return new ChestSizes(40, 1079);
                yield return new ChestSizes(41, 934);
                yield return new ChestSizes(42, 658);
                yield return new ChestSizes(43, 370);
                yield return new ChestSizes(44, 92);
                yield return new ChestSizes(45, 50);
                yield return new ChestSizes(46, 21);
                yield return new ChestSizes(47, 4);
                yield return new ChestSizes(48, 1);
            }
        }
    }
}
