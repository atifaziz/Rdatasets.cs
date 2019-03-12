// ReSharper disable All

namespace Rdatasets.HistData
{
    using System.Collections.Generic;

    /// <summary>
    /// Student's (1906) Yeast Cell Counts
    /// </summary>

    public class Yeast
    {
        public readonly int κ;
        public readonly string sample;
        public readonly int count;
        public readonly int freq;

        public Yeast(int κ, string sample, int count, int freq)
        {
            this.κ = κ;
            this.sample = sample;
            this.count = count;
            this.freq = freq;
        }

        public static IEnumerable<Yeast> Data
        {
            get
            {
                yield return new Yeast(1, "A", 0, 213);
                yield return new Yeast(2, "A", 1, 128);
                yield return new Yeast(3, "A", 2, 37);
                yield return new Yeast(4, "A", 3, 18);
                yield return new Yeast(5, "A", 4, 3);
                yield return new Yeast(6, "A", 5, 1);
                yield return new Yeast(7, "B", 0, 103);
                yield return new Yeast(8, "B", 1, 143);
                yield return new Yeast(9, "B", 2, 98);
                yield return new Yeast(10, "B", 3, 42);
                yield return new Yeast(11, "B", 4, 8);
                yield return new Yeast(12, "B", 5, 4);
                yield return new Yeast(13, "B", 6, 2);
                yield return new Yeast(14, "C", 0, 75);
                yield return new Yeast(15, "C", 1, 103);
                yield return new Yeast(16, "C", 2, 121);
                yield return new Yeast(17, "C", 3, 54);
                yield return new Yeast(18, "C", 4, 30);
                yield return new Yeast(19, "C", 5, 13);
                yield return new Yeast(20, "C", 6, 2);
                yield return new Yeast(21, "C", 7, 1);
                yield return new Yeast(22, "C", 8, 0);
                yield return new Yeast(23, "C", 9, 1);
                yield return new Yeast(24, "D", 0, 0);
                yield return new Yeast(25, "D", 1, 20);
                yield return new Yeast(26, "D", 2, 43);
                yield return new Yeast(27, "D", 3, 53);
                yield return new Yeast(28, "D", 4, 86);
                yield return new Yeast(29, "D", 5, 70);
                yield return new Yeast(30, "D", 6, 54);
                yield return new Yeast(31, "D", 7, 37);
                yield return new Yeast(32, "D", 8, 18);
                yield return new Yeast(33, "D", 9, 10);
                yield return new Yeast(34, "D", 10, 5);
                yield return new Yeast(35, "D", 11, 2);
                yield return new Yeast(36, "D", 12, 2);
            }
        }
    }
}
