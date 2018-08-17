// ReSharper disable All

namespace Rdatasets.HistData
{
    using System.Collections.Generic;

    /// <summary>
    /// Student's (1906) Yeast Cell Counts
    /// </summary>

    public class Yeast
    {
        public readonly string sample;
        public readonly int count;
        public readonly int freq;

        public Yeast(string sample, int count, int freq)
        {
            this.sample = sample;
            this.count = count;
            this.freq = freq;
        }

        public static IEnumerable<Yeast> Data
        {
            get
            {
                yield return new Yeast("A", 0, 213);
                yield return new Yeast("A", 1, 128);
                yield return new Yeast("A", 2, 37);
                yield return new Yeast("A", 3, 18);
                yield return new Yeast("A", 4, 3);
                yield return new Yeast("A", 5, 1);
                yield return new Yeast("B", 0, 103);
                yield return new Yeast("B", 1, 143);
                yield return new Yeast("B", 2, 98);
                yield return new Yeast("B", 3, 42);
                yield return new Yeast("B", 4, 8);
                yield return new Yeast("B", 5, 4);
                yield return new Yeast("B", 6, 2);
                yield return new Yeast("C", 0, 75);
                yield return new Yeast("C", 1, 103);
                yield return new Yeast("C", 2, 121);
                yield return new Yeast("C", 3, 54);
                yield return new Yeast("C", 4, 30);
                yield return new Yeast("C", 5, 13);
                yield return new Yeast("C", 6, 2);
                yield return new Yeast("C", 7, 1);
                yield return new Yeast("C", 8, 0);
                yield return new Yeast("C", 9, 1);
                yield return new Yeast("D", 0, 0);
                yield return new Yeast("D", 1, 20);
                yield return new Yeast("D", 2, 43);
                yield return new Yeast("D", 3, 53);
                yield return new Yeast("D", 4, 86);
                yield return new Yeast("D", 5, 70);
                yield return new Yeast("D", 6, 54);
                yield return new Yeast("D", 7, 37);
                yield return new Yeast("D", 8, 18);
                yield return new Yeast("D", 9, 10);
                yield return new Yeast("D", 10, 5);
                yield return new Yeast("D", 11, 2);
                yield return new Yeast("D", 12, 2);
            }
        }
    }
}
