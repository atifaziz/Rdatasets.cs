// ReSharper disable All

namespace Rdatasets.boot
{
    using System.Collections.Generic;

    /// <summary>
    /// Animal Survival Times
    /// </summary>

    public class poisons
    {
        public readonly int κ;
        public readonly double time;
        public readonly int poison;
        public readonly string treat;

        public poisons(int κ, double time, int poison, string treat)
        {
            this.κ = κ;
            this.time = time;
            this.poison = poison;
            this.treat = treat;
        }

        public static IEnumerable<poisons> Data
        {
            get
            {
                yield return new poisons(1, 0.31, 1, "A");
                yield return new poisons(2, 0.45, 1, "A");
                yield return new poisons(3, 0.46, 1, "A");
                yield return new poisons(4, 0.43, 1, "A");
                yield return new poisons(5, 0.36, 2, "A");
                yield return new poisons(6, 0.29, 2, "A");
                yield return new poisons(7, 0.4, 2, "A");
                yield return new poisons(8, 0.23, 2, "A");
                yield return new poisons(9, 0.22, 3, "A");
                yield return new poisons(10, 0.21, 3, "A");
                yield return new poisons(11, 0.18, 3, "A");
                yield return new poisons(12, 0.23, 3, "A");
                yield return new poisons(13, 0.82, 1, "B");
                yield return new poisons(14, 1.1, 1, "B");
                yield return new poisons(15, 0.88, 1, "B");
                yield return new poisons(16, 0.72, 1, "B");
                yield return new poisons(17, 0.92, 2, "B");
                yield return new poisons(18, 0.61, 2, "B");
                yield return new poisons(19, 0.49, 2, "B");
                yield return new poisons(20, 1.24, 2, "B");
                yield return new poisons(21, 0.3, 3, "B");
                yield return new poisons(22, 0.37, 3, "B");
                yield return new poisons(23, 0.38, 3, "B");
                yield return new poisons(24, 0.29, 3, "B");
                yield return new poisons(25, 0.43, 1, "C");
                yield return new poisons(26, 0.45, 1, "C");
                yield return new poisons(27, 0.63, 1, "C");
                yield return new poisons(28, 0.76, 1, "C");
                yield return new poisons(29, 0.44, 2, "C");
                yield return new poisons(30, 0.35, 2, "C");
                yield return new poisons(31, 0.31, 2, "C");
                yield return new poisons(32, 0.4, 2, "C");
                yield return new poisons(33, 0.23, 3, "C");
                yield return new poisons(34, 0.25, 3, "C");
                yield return new poisons(35, 0.24, 3, "C");
                yield return new poisons(36, 0.22, 3, "C");
                yield return new poisons(37, 0.45, 1, "D");
                yield return new poisons(38, 0.71, 1, "D");
                yield return new poisons(39, 0.66, 1, "D");
                yield return new poisons(40, 0.62, 1, "D");
                yield return new poisons(41, 0.56, 2, "D");
                yield return new poisons(42, 1.02, 2, "D");
                yield return new poisons(43, 0.71, 2, "D");
                yield return new poisons(44, 0.38, 2, "D");
                yield return new poisons(45, 0.3, 3, "D");
                yield return new poisons(46, 0.36, 3, "D");
                yield return new poisons(47, 0.31, 3, "D");
                yield return new poisons(48, 0.33, 3, "D");
            }
        }
    }
}
