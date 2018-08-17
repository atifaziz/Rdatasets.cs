// ReSharper disable All

namespace Rdatasets.carData
{
    using System.Collections.Generic;

    /// <summary>
    /// Format Effects on Recall
    /// </summary>

    public class Friendly
    {
        public readonly string condition;
        public readonly int correct;

        public Friendly(string condition, int correct)
        {
            this.condition = condition;
            this.correct = correct;
        }

        public static IEnumerable<Friendly> Data
        {
            get
            {
                yield return new Friendly("SFR", 39);
                yield return new Friendly("SFR", 25);
                yield return new Friendly("SFR", 37);
                yield return new Friendly("SFR", 25);
                yield return new Friendly("SFR", 29);
                yield return new Friendly("SFR", 39);
                yield return new Friendly("SFR", 21);
                yield return new Friendly("SFR", 39);
                yield return new Friendly("SFR", 24);
                yield return new Friendly("SFR", 25);
                yield return new Friendly("Before", 40);
                yield return new Friendly("Before", 38);
                yield return new Friendly("Before", 39);
                yield return new Friendly("Before", 37);
                yield return new Friendly("Before", 39);
                yield return new Friendly("Before", 24);
                yield return new Friendly("Before", 30);
                yield return new Friendly("Before", 39);
                yield return new Friendly("Before", 40);
                yield return new Friendly("Before", 40);
                yield return new Friendly("Meshed", 40);
                yield return new Friendly("Meshed", 39);
                yield return new Friendly("Meshed", 34);
                yield return new Friendly("Meshed", 37);
                yield return new Friendly("Meshed", 40);
                yield return new Friendly("Meshed", 36);
                yield return new Friendly("Meshed", 36);
                yield return new Friendly("Meshed", 38);
                yield return new Friendly("Meshed", 36);
                yield return new Friendly("Meshed", 30);
            }
        }
    }
}
