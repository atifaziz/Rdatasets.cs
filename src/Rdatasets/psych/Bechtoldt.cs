// ReSharper disable All

namespace Rdatasets.psych
{
    using System.Collections.Generic;

    /// <summary>
    /// Seven data sets showing a bifactor solution.
    /// </summary>

    public class Bechtoldt
    {
        public readonly string κ;
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

        public Bechtoldt(string κ, double First_Names, double Word_Number, double Sentences, double Vocabulary, double Completion, double First_Letters, double Four_letter_words, double Suffixes, double Flags, double Figures, double Cards, double Addition, double Multiplication, double Three_Higher, double Letter_Series, double Pedigrees, double Letter_Grouping)
        {
            this.κ = κ;
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

        public static IEnumerable<Bechtoldt> Data
        {
            get
            {
                yield return new Bechtoldt("First_Names", 1, 0.472, 0.29, 0.401, 0.299, 0.234, 0.254, 0.296, 0.086, 0.061, 0.052, 0.246, 0.274, 0.25, 0.332, 0.313, 0.297);
                yield return new Bechtoldt("Word_Number", 0.472, 1, 0.189, 0.22, 0.232, 0.209, 0.246, 0.193, 0.044, 0.078, 0.157, 0.151, 0.146, 0.06, 0.238, 0.213, 0.17);
                yield return new Bechtoldt("Sentences", 0.29, 0.189, 1, 0.833, 0.761, 0.402, 0.275, 0.374, 0.103, 0.019, 0.077, 0.332, 0.297, 0.352, 0.536, 0.567, 0.468);
                yield return new Bechtoldt("Vocabulary", 0.401, 0.22, 0.833, 1, 0.772, 0.446, 0.358, 0.473, 0.109, 0.045, 0.105, 0.335, 0.352, 0.384, 0.507, 0.514, 0.404);
                yield return new Bechtoldt("Completion", 0.299, 0.232, 0.761, 0.772, 1, 0.394, 0.275, 0.426, 0.342, 0.227, 0.294, 0.329, 0.254, 0.438, 0.49, 0.512, 0.43);
                yield return new Bechtoldt("First_Letters", 0.234, 0.209, 0.402, 0.446, 0.394, 1, 0.627, 0.516, 0.176, 0.104, 0.095, 0.355, 0.365, 0.354, 0.404, 0.365, 0.375);
                yield return new Bechtoldt("Four_letter_words", 0.254, 0.246, 0.275, 0.358, 0.275, 0.627, 1, 0.48, 0.161, 0.138, 0.049, 0.354, 0.327, 0.318, 0.33, 0.275, 0.317);
                yield return new Bechtoldt("Suffixes", 0.296, 0.193, 0.374, 0.473, 0.426, 0.516, 0.48, 1, 0.079, 0.007, 0.012, 0.288, 0.284, 0.28, 0.327, 0.323, 0.285);
                yield return new Bechtoldt("Flags", 0.086, 0.044, 0.103, 0.109, 0.342, 0.176, 0.161, 0.079, 1, 0.672, 0.606, 0.286, 0.189, 0.379, 0.289, 0.277, 0.287);
                yield return new Bechtoldt("Figures", 0.061, 0.078, 0.019, 0.045, 0.227, 0.104, 0.138, 0.007, 0.672, 1, 0.728, 0.164, 0.049, 0.236, 0.16, 0.165, 0.181);
                yield return new Bechtoldt("Cards", 0.052, 0.157, 0.077, 0.105, 0.294, 0.095, 0.049, 0.012, 0.606, 0.728, 1, 0.171, 0.032, 0.251, 0.2, 0.208, 0.207);
                yield return new Bechtoldt("Addition", 0.246, 0.151, 0.332, 0.335, 0.329, 0.355, 0.354, 0.288, 0.286, 0.164, 0.171, 1, 0.651, 0.517, 0.439, 0.32, 0.399);
                yield return new Bechtoldt("Multiplication", 0.274, 0.146, 0.297, 0.352, 0.254, 0.365, 0.327, 0.284, 0.189, 0.049, 0.032, 0.651, 1, 0.546, 0.435, 0.293, 0.452);
                yield return new Bechtoldt("Three_Higher", 0.25, 0.06, 0.352, 0.384, 0.438, 0.354, 0.318, 0.28, 0.379, 0.236, 0.251, 0.517, 0.546, 1, 0.512, 0.442, 0.456);
                yield return new Bechtoldt("Letter_Series", 0.332, 0.238, 0.536, 0.507, 0.49, 0.404, 0.33, 0.327, 0.289, 0.16, 0.2, 0.439, 0.435, 0.512, 1, 0.671, 0.622);
                yield return new Bechtoldt("Pedigrees", 0.313, 0.213, 0.567, 0.514, 0.512, 0.365, 0.275, 0.323, 0.277, 0.165, 0.208, 0.32, 0.293, 0.442, 0.671, 1, 0.538);
                yield return new Bechtoldt("Letter_Grouping", 0.297, 0.17, 0.468, 0.404, 0.43, 0.375, 0.317, 0.285, 0.287, 0.181, 0.207, 0.399, 0.452, 0.456, 0.622, 0.538, 1);
            }
        }
    }
}
