// ReSharper disable All

namespace Rdatasets.psych
{
    using System.Collections.Generic;

    /// <summary>
    /// Seven data sets showing a bifactor solution.
    /// </summary>

    public class Thurstone
    {
        public readonly string κ;
        public readonly double Sentences;
        public readonly double Vocabulary;
        public readonly double Sent_Completion;
        public readonly double First_Letters;
        public readonly double Four_Letter_Words;
        public readonly double Suffixes;
        public readonly double Letter_Series;
        public readonly double Pedigrees;
        public readonly double Letter_Group;

        public Thurstone(string κ, double Sentences, double Vocabulary, double Sent_Completion, double First_Letters, double Four_Letter_Words, double Suffixes, double Letter_Series, double Pedigrees, double Letter_Group)
        {
            this.κ = κ;
            this.Sentences = Sentences;
            this.Vocabulary = Vocabulary;
            this.Sent_Completion = Sent_Completion;
            this.First_Letters = First_Letters;
            this.Four_Letter_Words = Four_Letter_Words;
            this.Suffixes = Suffixes;
            this.Letter_Series = Letter_Series;
            this.Pedigrees = Pedigrees;
            this.Letter_Group = Letter_Group;
        }

        public static IEnumerable<Thurstone> Data
        {
            get
            {
                yield return new Thurstone("Sentences", 1, 0.828, 0.776, 0.439, 0.432, 0.447, 0.447, 0.541, 0.38);
                yield return new Thurstone("Vocabulary", 0.828, 1, 0.779, 0.493, 0.464, 0.489, 0.432, 0.537, 0.358);
                yield return new Thurstone("Sent.Completion", 0.776, 0.779, 1, 0.46, 0.425, 0.443, 0.401, 0.534, 0.359);
                yield return new Thurstone("First.Letters", 0.439, 0.493, 0.46, 1, 0.674, 0.59, 0.381, 0.35, 0.424);
                yield return new Thurstone("Four.Letter.Words", 0.432, 0.464, 0.425, 0.674, 1, 0.541, 0.402, 0.367, 0.446);
                yield return new Thurstone("Suffixes", 0.447, 0.489, 0.443, 0.59, 0.541, 1, 0.288, 0.32, 0.325);
                yield return new Thurstone("Letter.Series", 0.447, 0.432, 0.401, 0.381, 0.402, 0.288, 1, 0.555, 0.598);
                yield return new Thurstone("Pedigrees", 0.541, 0.537, 0.534, 0.35, 0.367, 0.32, 0.555, 1, 0.452);
                yield return new Thurstone("Letter.Group", 0.38, 0.358, 0.359, 0.424, 0.446, 0.325, 0.598, 0.452, 1);
            }
        }
    }
}
