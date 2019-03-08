// ReSharper disable All

namespace Rdatasets.drc
{
    using System.Collections.Generic;

    /// <summary>
    /// Earthworm toxicity test
    /// </summary>

    public class earthworms
    {
        public readonly double dose;
        public readonly int number;
        public readonly int total;

        public earthworms(double dose, int number, int total)
        {
            this.dose = dose;
            this.number = number;
            this.total = total;
        }

        public static IEnumerable<earthworms> Data
        {
            get
            {
                yield return new earthworms(0, 3, 5);
                yield return new earthworms(0, 3, 5);
                yield return new earthworms(0, 3, 4);
                yield return new earthworms(0, 5, 8);
                yield return new earthworms(0, 4, 8);
                yield return new earthworms(0.19, 4, 11);
                yield return new earthworms(0.19, 4, 9);
                yield return new earthworms(0.19, 2, 8);
                yield return new earthworms(0.19, 3, 8);
                yield return new earthworms(0.19, 2, 4);
                yield return new earthworms(0.38, 2, 9);
                yield return new earthworms(0.38, 0, 4);
                yield return new earthworms(0.38, 6, 11);
                yield return new earthworms(0.38, 4, 11);
                yield return new earthworms(0.38, 4, 15);
                yield return new earthworms(0.76, 0, 11);
                yield return new earthworms(0.76, 1, 6);
                yield return new earthworms(0.76, 1, 8);
                yield return new earthworms(0.76, 0, 9);
                yield return new earthworms(0.76, 0, 8);
                yield return new earthworms(1.53, 0, 6);
                yield return new earthworms(1.53, 1, 10);
                yield return new earthworms(1.53, 0, 10);
                yield return new earthworms(1.53, 0, 10);
                yield return new earthworms(1.53, 0, 8);
                yield return new earthworms(3.05, 0, 5);
                yield return new earthworms(3.05, 0, 9);
                yield return new earthworms(3.05, 0, 7);
                yield return new earthworms(3.05, 0, 8);
                yield return new earthworms(3.05, 1, 8);
                yield return new earthworms(6.11, 0, 3);
                yield return new earthworms(6.11, 0, 7);
                yield return new earthworms(6.11, 0, 11);
                yield return new earthworms(6.11, 0, 10);
                yield return new earthworms(6.11, 1, 7);
            }
        }
    }
}
