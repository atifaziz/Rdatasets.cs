// ReSharper disable All

namespace Rdatasets.psych
{
    using System.Collections.Generic;

    /// <summary>
    /// An example of the distinction between within group and between group correlations
    /// </summary>

    public class withinBetween
    {
        public readonly int κ;
        public readonly string Group;
        public readonly int V1;
        public readonly int V2;
        public readonly int V3;
        public readonly int V4;
        public readonly int V5;
        public readonly int V6;
        public readonly int V7;
        public readonly int V8;
        public readonly int V9;

        public withinBetween(int κ, string Group, int V1, int V2, int V3, int V4, int V5, int V6, int V7, int V8, int V9)
        {
            this.κ = κ;
            this.Group = Group;
            this.V1 = V1;
            this.V2 = V2;
            this.V3 = V3;
            this.V4 = V4;
            this.V5 = V5;
            this.V6 = V6;
            this.V7 = V7;
            this.V8 = V8;
            this.V9 = V9;
        }

        public static IEnumerable<withinBetween> Data
        {
            get
            {
                yield return new withinBetween(1, "A", 1, 3, 4, 8, 10, 11, 9, 11, 12);
                yield return new withinBetween(2, "A", 2, 1, 3, 9, 8, 10, 10, 9, 11);
                yield return new withinBetween(3, "A", 3, 4, 2, 10, 11, 9, 11, 12, 10);
                yield return new withinBetween(4, "A", 4, 2, 1, 11, 9, 8, 12, 10, 9);
                yield return new withinBetween(5, "B", 2, 4, 5, 6, 8, 9, 8, 10, 11);
                yield return new withinBetween(6, "B", 3, 2, 4, 7, 6, 8, 9, 8, 10);
                yield return new withinBetween(7, "B", 4, 5, 3, 8, 9, 7, 10, 11, 9);
                yield return new withinBetween(8, "B", 5, 3, 2, 9, 7, 6, 11, 9, 8);
                yield return new withinBetween(9, "C", 3, 5, 6, 9, 11, 12, 7, 9, 10);
                yield return new withinBetween(10, "C", 4, 3, 5, 10, 9, 11, 8, 7, 9);
                yield return new withinBetween(11, "C", 5, 6, 4, 11, 12, 10, 9, 10, 8);
                yield return new withinBetween(12, "C", 6, 4, 3, 12, 10, 9, 10, 8, 7);
                yield return new withinBetween(13, "D", 4, 6, 7, 7, 9, 10, 6, 8, 9);
                yield return new withinBetween(14, "D", 5, 4, 6, 8, 7, 9, 7, 6, 8);
                yield return new withinBetween(15, "D", 6, 7, 5, 9, 10, 8, 8, 9, 7);
                yield return new withinBetween(16, "D", 7, 5, 4, 10, 8, 7, 9, 7, 6);
            }
        }
    }
}
