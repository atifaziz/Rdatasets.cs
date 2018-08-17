// ReSharper disable All

namespace Rdatasets.Stat2Data
{
    using System.Collections.Generic;

    /// <summary>
    /// WordMemory
    /// </summary>

    public class WordMemory
    {
        public readonly string Subject;
        public readonly string Abstract;
        public readonly string Frequent;
        public readonly int Percent;

        public WordMemory(string Subject, string Abstract, string Frequent, int Percent)
        {
            this.Subject = Subject;
            this.Abstract = Abstract;
            this.Frequent = Frequent;
            this.Percent = Percent;
        }

        public static IEnumerable<WordMemory> Data
        {
            get
            {
                yield return new WordMemory("A", "Yes", "Yes", 60);
                yield return new WordMemory("B", "Yes", "Yes", 52);
                yield return new WordMemory("C", "Yes", "Yes", 20);
                yield return new WordMemory("D", "Yes", "Yes", 36);
                yield return new WordMemory("E", "Yes", "Yes", 40);
                yield return new WordMemory("F", "Yes", "Yes", 36);
                yield return new WordMemory("G", "Yes", "Yes", 36);
                yield return new WordMemory("H", "Yes", "Yes", 44);
                yield return new WordMemory("I", "Yes", "Yes", 35);
                yield return new WordMemory("J", "Yes", "Yes", 52);
                yield return new WordMemory("A", "Yes", "No", 44);
                yield return new WordMemory("B", "Yes", "No", 32);
                yield return new WordMemory("C", "Yes", "No", 32);
                yield return new WordMemory("D", "Yes", "No", 32);
                yield return new WordMemory("E", "Yes", "No", 32);
                yield return new WordMemory("F", "Yes", "No", 20);
                yield return new WordMemory("G", "Yes", "No", 40);
                yield return new WordMemory("H", "Yes", "No", 64);
                yield return new WordMemory("I", "Yes", "No", 40);
                yield return new WordMemory("J", "Yes", "No", 52);
                yield return new WordMemory("A", "No", "Yes", 60);
                yield return new WordMemory("B", "No", "Yes", 44);
                yield return new WordMemory("C", "No", "Yes", 40);
                yield return new WordMemory("D", "No", "Yes", 44);
                yield return new WordMemory("E", "No", "Yes", 52);
                yield return new WordMemory("F", "No", "Yes", 28);
                yield return new WordMemory("G", "No", "Yes", 32);
                yield return new WordMemory("H", "No", "Yes", 44);
                yield return new WordMemory("I", "No", "Yes", 32);
                yield return new WordMemory("J", "No", "Yes", 64);
                yield return new WordMemory("A", "No", "No", 44);
                yield return new WordMemory("B", "No", "No", 28);
                yield return new WordMemory("C", "No", "No", 24);
                yield return new WordMemory("D", "No", "No", 36);
                yield return new WordMemory("E", "No", "No", 44);
                yield return new WordMemory("F", "No", "No", 40);
                yield return new WordMemory("G", "No", "No", 28);
                yield return new WordMemory("H", "No", "No", 64);
                yield return new WordMemory("I", "No", "No", 56);
                yield return new WordMemory("J", "No", "No", 60);
            }
        }
    }
}
