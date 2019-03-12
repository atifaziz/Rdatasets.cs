// ReSharper disable All

namespace Rdatasets.Stat2Data
{
    using System.Collections.Generic;

    /// <summary>
    /// WordMemory
    /// </summary>

    public class WordMemory
    {
        public readonly int κ;
        public readonly string Subject;
        public readonly string Abstract;
        public readonly string Frequent;
        public readonly int Percent;

        public WordMemory(int κ, string Subject, string Abstract, string Frequent, int Percent)
        {
            this.κ = κ;
            this.Subject = Subject;
            this.Abstract = Abstract;
            this.Frequent = Frequent;
            this.Percent = Percent;
        }

        public static IEnumerable<WordMemory> Data
        {
            get
            {
                yield return new WordMemory(1, "A", "Yes", "Yes", 60);
                yield return new WordMemory(2, "B", "Yes", "Yes", 52);
                yield return new WordMemory(3, "C", "Yes", "Yes", 20);
                yield return new WordMemory(4, "D", "Yes", "Yes", 36);
                yield return new WordMemory(5, "E", "Yes", "Yes", 40);
                yield return new WordMemory(6, "F", "Yes", "Yes", 36);
                yield return new WordMemory(7, "G", "Yes", "Yes", 36);
                yield return new WordMemory(8, "H", "Yes", "Yes", 44);
                yield return new WordMemory(9, "I", "Yes", "Yes", 35);
                yield return new WordMemory(10, "J", "Yes", "Yes", 52);
                yield return new WordMemory(11, "A", "Yes", "No", 44);
                yield return new WordMemory(12, "B", "Yes", "No", 32);
                yield return new WordMemory(13, "C", "Yes", "No", 32);
                yield return new WordMemory(14, "D", "Yes", "No", 32);
                yield return new WordMemory(15, "E", "Yes", "No", 32);
                yield return new WordMemory(16, "F", "Yes", "No", 20);
                yield return new WordMemory(17, "G", "Yes", "No", 40);
                yield return new WordMemory(18, "H", "Yes", "No", 64);
                yield return new WordMemory(19, "I", "Yes", "No", 40);
                yield return new WordMemory(20, "J", "Yes", "No", 52);
                yield return new WordMemory(21, "A", "No", "Yes", 60);
                yield return new WordMemory(22, "B", "No", "Yes", 44);
                yield return new WordMemory(23, "C", "No", "Yes", 40);
                yield return new WordMemory(24, "D", "No", "Yes", 44);
                yield return new WordMemory(25, "E", "No", "Yes", 52);
                yield return new WordMemory(26, "F", "No", "Yes", 28);
                yield return new WordMemory(27, "G", "No", "Yes", 32);
                yield return new WordMemory(28, "H", "No", "Yes", 44);
                yield return new WordMemory(29, "I", "No", "Yes", 32);
                yield return new WordMemory(30, "J", "No", "Yes", 64);
                yield return new WordMemory(31, "A", "No", "No", 44);
                yield return new WordMemory(32, "B", "No", "No", 28);
                yield return new WordMemory(33, "C", "No", "No", 24);
                yield return new WordMemory(34, "D", "No", "No", 36);
                yield return new WordMemory(35, "E", "No", "No", 44);
                yield return new WordMemory(36, "F", "No", "No", 40);
                yield return new WordMemory(37, "G", "No", "No", 28);
                yield return new WordMemory(38, "H", "No", "No", 64);
                yield return new WordMemory(39, "I", "No", "No", 56);
                yield return new WordMemory(40, "J", "No", "No", 60);
            }
        }
    }
}
