// ReSharper disable All

namespace Rdatasets.boot
{
    using System.Collections.Generic;

    /// <summary>
    /// Animal Survival Times
    /// </summary>

    public class poisons
    {
        public readonly double time;
        public readonly int poison;
        public readonly string treat;

        public poisons(double time, int poison, string treat)
        {
            this.time = time;
            this.poison = poison;
            this.treat = treat;
        }

        public static IEnumerable<poisons> Data
        {
            get
            {
                yield return new poisons(0.31, 1, "A");
                yield return new poisons(0.45, 1, "A");
                yield return new poisons(0.46, 1, "A");
                yield return new poisons(0.43, 1, "A");
                yield return new poisons(0.36, 2, "A");
                yield return new poisons(0.29, 2, "A");
                yield return new poisons(0.4, 2, "A");
                yield return new poisons(0.23, 2, "A");
                yield return new poisons(0.22, 3, "A");
                yield return new poisons(0.21, 3, "A");
                yield return new poisons(0.18, 3, "A");
                yield return new poisons(0.23, 3, "A");
                yield return new poisons(0.82, 1, "B");
                yield return new poisons(1.1, 1, "B");
                yield return new poisons(0.88, 1, "B");
                yield return new poisons(0.72, 1, "B");
                yield return new poisons(0.92, 2, "B");
                yield return new poisons(0.61, 2, "B");
                yield return new poisons(0.49, 2, "B");
                yield return new poisons(1.24, 2, "B");
                yield return new poisons(0.3, 3, "B");
                yield return new poisons(0.37, 3, "B");
                yield return new poisons(0.38, 3, "B");
                yield return new poisons(0.29, 3, "B");
                yield return new poisons(0.43, 1, "C");
                yield return new poisons(0.45, 1, "C");
                yield return new poisons(0.63, 1, "C");
                yield return new poisons(0.76, 1, "C");
                yield return new poisons(0.44, 2, "C");
                yield return new poisons(0.35, 2, "C");
                yield return new poisons(0.31, 2, "C");
                yield return new poisons(0.4, 2, "C");
                yield return new poisons(0.23, 3, "C");
                yield return new poisons(0.25, 3, "C");
                yield return new poisons(0.24, 3, "C");
                yield return new poisons(0.22, 3, "C");
                yield return new poisons(0.45, 1, "D");
                yield return new poisons(0.71, 1, "D");
                yield return new poisons(0.66, 1, "D");
                yield return new poisons(0.62, 1, "D");
                yield return new poisons(0.56, 2, "D");
                yield return new poisons(1.02, 2, "D");
                yield return new poisons(0.71, 2, "D");
                yield return new poisons(0.38, 2, "D");
                yield return new poisons(0.3, 3, "D");
                yield return new poisons(0.36, 3, "D");
                yield return new poisons(0.31, 3, "D");
                yield return new poisons(0.33, 3, "D");
            }
        }
    }
}
