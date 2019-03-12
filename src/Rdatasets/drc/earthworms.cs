// ReSharper disable All

namespace Rdatasets.drc
{
    using System.Collections.Generic;

    /// <summary>
    /// Earthworm toxicity test
    /// </summary>

    public class earthworms
    {
        public readonly int κ;
        public readonly double dose;
        public readonly int number;
        public readonly int total;

        public earthworms(int κ, double dose, int number, int total)
        {
            this.κ = κ;
            this.dose = dose;
            this.number = number;
            this.total = total;
        }

        public static IEnumerable<earthworms> Data
        {
            get
            {
                yield return new earthworms(1, 0, 3, 5);
                yield return new earthworms(2, 0, 3, 5);
                yield return new earthworms(3, 0, 3, 4);
                yield return new earthworms(4, 0, 5, 8);
                yield return new earthworms(5, 0, 4, 8);
                yield return new earthworms(6, 0.19, 4, 11);
                yield return new earthworms(7, 0.19, 4, 9);
                yield return new earthworms(8, 0.19, 2, 8);
                yield return new earthworms(9, 0.19, 3, 8);
                yield return new earthworms(10, 0.19, 2, 4);
                yield return new earthworms(11, 0.38, 2, 9);
                yield return new earthworms(12, 0.38, 0, 4);
                yield return new earthworms(13, 0.38, 6, 11);
                yield return new earthworms(14, 0.38, 4, 11);
                yield return new earthworms(15, 0.38, 4, 15);
                yield return new earthworms(16, 0.76, 0, 11);
                yield return new earthworms(17, 0.76, 1, 6);
                yield return new earthworms(18, 0.76, 1, 8);
                yield return new earthworms(19, 0.76, 0, 9);
                yield return new earthworms(20, 0.76, 0, 8);
                yield return new earthworms(21, 1.53, 0, 6);
                yield return new earthworms(22, 1.53, 1, 10);
                yield return new earthworms(23, 1.53, 0, 10);
                yield return new earthworms(24, 1.53, 0, 10);
                yield return new earthworms(25, 1.53, 0, 8);
                yield return new earthworms(26, 3.05, 0, 5);
                yield return new earthworms(27, 3.05, 0, 9);
                yield return new earthworms(28, 3.05, 0, 7);
                yield return new earthworms(29, 3.05, 0, 8);
                yield return new earthworms(30, 3.05, 1, 8);
                yield return new earthworms(31, 6.11, 0, 3);
                yield return new earthworms(32, 6.11, 0, 7);
                yield return new earthworms(33, 6.11, 0, 11);
                yield return new earthworms(34, 6.11, 0, 10);
                yield return new earthworms(35, 6.11, 1, 7);
            }
        }
    }
}
