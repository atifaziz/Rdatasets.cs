// ReSharper disable All

namespace Rdatasets.psych
{
    using System.Collections.Generic;

    /// <summary>
    /// Seven data sets showing a bifactor solution.
    /// </summary>

    public class Bechtoldt_2
    {
        public readonly double First_Names;
        public readonly double Word_Number;
        public readonly double Sentences;
        public readonly double Vocabulary;
        public readonly double Completion;
        public readonly double First_Letters;
        public readonly double Four_letter_words;
        public readonly double Suffixes;
        public readonly double Flags;
        public readonly double Figures;
        public readonly double Cards;
        public readonly double Addition;
        public readonly double Multiplication;
        public readonly double Three_Higher;
        public readonly double Letter_Series;
        public readonly double Pedigrees;
        public readonly double Letter_Grouping;

        public Bechtoldt_2(double First_Names, double Word_Number, double Sentences, double Vocabulary, double Completion, double First_Letters, double Four_letter_words, double Suffixes, double Flags, double Figures, double Cards, double Addition, double Multiplication, double Three_Higher, double Letter_Series, double Pedigrees, double Letter_Grouping)
        {
            this.First_Names = First_Names;
            this.Word_Number = Word_Number;
            this.Sentences = Sentences;
            this.Vocabulary = Vocabulary;
            this.Completion = Completion;
            this.First_Letters = First_Letters;
            this.Four_letter_words = Four_letter_words;
            this.Suffixes = Suffixes;
            this.Flags = Flags;
            this.Figures = Figures;
            this.Cards = Cards;
            this.Addition = Addition;
            this.Multiplication = Multiplication;
            this.Three_Higher = Three_Higher;
            this.Letter_Series = Letter_Series;
            this.Pedigrees = Pedigrees;
            this.Letter_Grouping = Letter_Grouping;
        }

        public static IEnumerable<Bechtoldt_2> Data
        {
            get
            {
                yield return new Bechtoldt_2(1, 0.482, 0.299, 0.331, 0.266, 0.335, 0.342, 0.333, 0.124, 0.032, 0.077, 0.151, 0.259, 0.279, 0.377, 0.447, 0.274);
                yield return new Bechtoldt_2(0.482, 1, 0.275, 0.303, 0.273, 0.273, 0.199, 0.29, 0.169, 0.085, 0.193, 0.287, 0.258, 0.223, 0.26, 0.293, 0.216);
                yield return new Bechtoldt_2(0.299, 0.275, 1, 0.828, 0.776, 0.439, 0.432, 0.447, 0.117, 0.051, 0.151, 0.268, 0.319, 0.359, 0.447, 0.541, 0.38);
                yield return new Bechtoldt_2(0.331, 0.303, 0.828, 1, 0.779, 0.493, 0.464, 0.489, 0.121, 0.077, 0.146, 0.312, 0.344, 0.356, 0.432, 0.537, 0.358);
                yield return new Bechtoldt_2(0.266, 0.273, 0.776, 0.779, 1, 0.46, 0.425, 0.443, 0.193, 0.18, 0.174, 0.263, 0.291, 0.342, 0.401, 0.534, 0.359);
                yield return new Bechtoldt_2(0.335, 0.273, 0.439, 0.493, 0.46, 1, 0.674, 0.59, 0.178, 0.081, 0.158, 0.241, 0.338, 0.29, 0.381, 0.35, 0.424);
                yield return new Bechtoldt_2(0.342, 0.199, 0.432, 0.464, 0.425, 0.674, 1, 0.541, 0.223, 0.192, 0.239, 0.18, 0.295, 0.344, 0.402, 0.367, 0.446);
                yield return new Bechtoldt_2(0.333, 0.29, 0.447, 0.489, 0.443, 0.59, 0.541, 1, 0.118, 0.007, 0.114, 0.181, 0.234, 0.298, 0.288, 0.32, 0.325);
                yield return new Bechtoldt_2(0.124, 0.169, 0.117, 0.121, 0.193, 0.178, 0.223, 0.118, 1, 0.593, 0.651, 0.208, 0.179, 0.362, 0.252, 0.085, 0.27);
                yield return new Bechtoldt_2(0.032, 0.085, 0.051, 0.077, 0.18, 0.081, 0.192, 0.007, 0.593, 1, 0.684, 0.109, 0.144, 0.273, 0.203, 0.129, 0.203);
                yield return new Bechtoldt_2(0.077, 0.193, 0.151, 0.146, 0.174, 0.158, 0.239, 0.114, 0.651, 0.684, 1, 0.21, 0.195, 0.331, 0.257, 0.151, 0.293);
                yield return new Bechtoldt_2(0.151, 0.287, 0.268, 0.312, 0.263, 0.241, 0.18, 0.181, 0.208, 0.109, 0.21, 1, 0.661, 0.536, 0.361, 0.206, 0.311);
                yield return new Bechtoldt_2(0.259, 0.258, 0.319, 0.344, 0.291, 0.338, 0.295, 0.234, 0.179, 0.144, 0.195, 0.661, 1, 0.548, 0.379, 0.298, 0.329);
                yield return new Bechtoldt_2(0.279, 0.223, 0.359, 0.356, 0.342, 0.29, 0.344, 0.298, 0.362, 0.273, 0.331, 0.536, 0.548, 1, 0.44, 0.438, 0.41);
                yield return new Bechtoldt_2(0.377, 0.26, 0.447, 0.432, 0.401, 0.381, 0.402, 0.288, 0.252, 0.203, 0.257, 0.361, 0.379, 0.44, 1, 0.555, 0.598);
                yield return new Bechtoldt_2(0.447, 0.293, 0.541, 0.537, 0.534, 0.35, 0.367, 0.32, 0.085, 0.129, 0.151, 0.206, 0.298, 0.438, 0.555, 1, 0.452);
                yield return new Bechtoldt_2(0.274, 0.216, 0.38, 0.358, 0.359, 0.424, 0.446, 0.325, 0.27, 0.203, 0.293, 0.311, 0.329, 0.41, 0.598, 0.452, 1);
            }
        }
    }
}
