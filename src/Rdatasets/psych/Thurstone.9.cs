// ReSharper disable All

namespace Rdatasets.psych
{
    using System.Collections.Generic;

    /// <summary>
    /// Seven data sets showing a bifactor solution.
    /// </summary>

    public class Thurstone_9
    {
        public readonly string κ;
        public readonly double Prefixes;
        public readonly double Suffixes;
        public readonly double Vocabulary;
        public readonly double Sentences;
        public readonly double First_Last;
        public readonly double FirstLetters;
        public readonly double FourLetters;
        public readonly double Completion;
        public readonly double SameorOpposite;

        public Thurstone_9(string κ, double Prefixes, double Suffixes, double Vocabulary, double Sentences, double First_Last, double FirstLetters, double FourLetters, double Completion, double SameorOpposite)
        {
            this.κ = κ;
            this.Prefixes = Prefixes;
            this.Suffixes = Suffixes;
            this.Vocabulary = Vocabulary;
            this.Sentences = Sentences;
            this.First_Last = First_Last;
            this.FirstLetters = FirstLetters;
            this.FourLetters = FourLetters;
            this.Completion = Completion;
            this.SameorOpposite = SameorOpposite;
        }

        public static IEnumerable<Thurstone_9> Data
        {
            get
            {
                yield return new Thurstone_9("Prefixes", 1, 0.554, 0.227, 0.189, 0.461, 0.506, 0.408, 0.28, 0.241);
                yield return new Thurstone_9("Suffixes", 0.554, 1, 0.296, 0.219, 0.479, 0.53, 0.425, 0.311, 0.311);
                yield return new Thurstone_9("Vocabulary", 0.227, 0.296, 1, 0.769, 0.237, 0.243, 0.304, 0.718, 0.73);
                yield return new Thurstone_9("Sentences", 0.189, 0.219, 0.769, 1, 0.212, 0.226, 0.291, 0.681, 0.661);
                yield return new Thurstone_9("First.Last", 0.461, 0.479, 0.237, 0.212, 1, 0.52, 0.514, 0.313, 0.245);
                yield return new Thurstone_9("FirstLetters", 0.506, 0.53, 0.243, 0.226, 0.52, 1, 0.473, 0.348, 0.29);
                yield return new Thurstone_9("FourLetters", 0.408, 0.425, 0.304, 0.291, 0.514, 0.473, 1, 0.374, 0.306);
                yield return new Thurstone_9("Completion", 0.28, 0.311, 0.718, 0.681, 0.313, 0.348, 0.374, 1, 0.672);
                yield return new Thurstone_9("SameorOpposite", 0.241, 0.311, 0.73, 0.661, 0.245, 0.29, 0.306, 0.672, 1);
            }
        }
    }
}
