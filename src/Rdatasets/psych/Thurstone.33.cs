// ReSharper disable All

namespace Rdatasets.psych
{
    using System.Collections.Generic;

    /// <summary>
    /// Seven data sets showing a bifactor solution.
    /// </summary>

    public class Thurstone_33
    {
        public readonly string κ;
        public readonly double Definitions;
        public readonly double Arithmetical_Problems;
        public readonly double Classification;
        public readonly double Artificial_Languange;
        public readonly double Antonyms;
        public readonly double Number_Series_Completion;
        public readonly double Analogies;
        public readonly double Logical_Inference;
        public readonly double Paragraph_Reading;

        public Thurstone_33(string κ, double Definitions, double Arithmetical_Problems, double Classification, double Artificial_Languange, double Antonyms, double Number_Series_Completion, double Analogies, double Logical_Inference, double Paragraph_Reading)
        {
            this.κ = κ;
            this.Definitions = Definitions;
            this.Arithmetical_Problems = Arithmetical_Problems;
            this.Classification = Classification;
            this.Artificial_Languange = Artificial_Languange;
            this.Antonyms = Antonyms;
            this.Number_Series_Completion = Number_Series_Completion;
            this.Analogies = Analogies;
            this.Logical_Inference = Logical_Inference;
            this.Paragraph_Reading = Paragraph_Reading;
        }

        public static IEnumerable<Thurstone_33> Data
        {
            get
            {
                yield return new Thurstone_33("Definitions", 1, 0.4819, 0.617, 0.5177, 0.6249, 0.4216, 0.5835, 0.5631, 0.5857);
                yield return new Thurstone_33("Arithmetical_Problems", 0.4819, 1, 0.3973, 0.3966, 0.4105, 0.5923, 0.3976, 0.5049, 0.4404);
                yield return new Thurstone_33("Classification", 0.617, 0.3973, 1, 0.4722, 0.6262, 0.3561, 0.5931, 0.5003, 0.557);
                yield return new Thurstone_33("Artificial_Languange", 0.5177, 0.3966, 0.4722, 1, 0.5197, 0.4405, 0.5413, 0.4797, 0.4034);
                yield return new Thurstone_33("Antonyms", 0.6249, 0.4105, 0.6262, 0.5197, 1, 0.3221, 0.5909, 0.5937, 0.7628);
                yield return new Thurstone_33("Number_Series_Completion", 0.4216, 0.5923, 0.3561, 0.4405, 0.3221, 1, 0.3634, 0.4256, 0.3324);
                yield return new Thurstone_33("Analogies", 0.5835, 0.3976, 0.5931, 0.5413, 0.5909, 0.3634, 1, 0.5921, 0.5321);
                yield return new Thurstone_33("Logical_Inference", 0.5631, 0.5049, 0.5003, 0.4797, 0.5937, 0.4256, 0.5921, 1, 0.6328);
                yield return new Thurstone_33("Paragraph_Reading", 0.5857, 0.4404, 0.557, 0.4034, 0.7628, 0.3324, 0.5321, 0.6328, 1);
            }
        }
    }
}
