// ReSharper disable All

namespace Rdatasets.carData
{
    using System.Collections.Generic;

    /// <summary>
    /// Format Effects on Recall
    /// </summary>

    public class Friendly
    {
        public readonly int κ;
        public readonly string condition;
        public readonly int correct;

        public Friendly(int κ, string condition, int correct)
        {
            this.κ = κ;
            this.condition = condition;
            this.correct = correct;
        }

        public static IEnumerable<Friendly> Data
        {
            get
            {
                yield return new Friendly(1, "SFR", 39);
                yield return new Friendly(2, "SFR", 25);
                yield return new Friendly(3, "SFR", 37);
                yield return new Friendly(4, "SFR", 25);
                yield return new Friendly(5, "SFR", 29);
                yield return new Friendly(6, "SFR", 39);
                yield return new Friendly(7, "SFR", 21);
                yield return new Friendly(8, "SFR", 39);
                yield return new Friendly(9, "SFR", 24);
                yield return new Friendly(10, "SFR", 25);
                yield return new Friendly(11, "Before", 40);
                yield return new Friendly(12, "Before", 38);
                yield return new Friendly(13, "Before", 39);
                yield return new Friendly(14, "Before", 37);
                yield return new Friendly(15, "Before", 39);
                yield return new Friendly(16, "Before", 24);
                yield return new Friendly(17, "Before", 30);
                yield return new Friendly(18, "Before", 39);
                yield return new Friendly(19, "Before", 40);
                yield return new Friendly(20, "Before", 40);
                yield return new Friendly(21, "Meshed", 40);
                yield return new Friendly(22, "Meshed", 39);
                yield return new Friendly(23, "Meshed", 34);
                yield return new Friendly(24, "Meshed", 37);
                yield return new Friendly(25, "Meshed", 40);
                yield return new Friendly(26, "Meshed", 36);
                yield return new Friendly(27, "Meshed", 36);
                yield return new Friendly(28, "Meshed", 38);
                yield return new Friendly(29, "Meshed", 36);
                yield return new Friendly(30, "Meshed", 30);
            }
        }
    }
}
