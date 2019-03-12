// ReSharper disable All

namespace Rdatasets.datasets
{
    using System.Collections.Generic;

    /// <summary>
    /// Harman Example 7.4
    /// </summary>

    public class Harman74_cor
    {
        public readonly string κ;
        public readonly double cov_VisualPerception;
        public readonly double cov_Cubes;
        public readonly double cov_PaperFormBoard;
        public readonly double cov_Flags;
        public readonly double cov_GeneralInformation;
        public readonly double cov_PargraphComprehension;
        public readonly double cov_SentenceCompletion;
        public readonly double cov_WordClassification;
        public readonly double cov_WordMeaning;
        public readonly double cov_Addition;
        public readonly double cov_Code;
        public readonly double cov_CountingDots;
        public readonly double cov_StraightCurvedCapitals;
        public readonly double cov_WordRecognition;
        public readonly double cov_NumberRecognition;
        public readonly double cov_FigureRecognition;
        public readonly double cov_ObjectNumber;
        public readonly double cov_NumberFigure;
        public readonly double cov_FigureWord;
        public readonly double cov_Deduction;
        public readonly double cov_NumericalPuzzles;
        public readonly double cov_ProblemReasoning;
        public readonly double cov_SeriesCompletion;
        public readonly double cov_ArithmeticProblems;
        public readonly int center;
        public readonly int n_obs;

        public Harman74_cor(string κ, double cov_VisualPerception, double cov_Cubes, double cov_PaperFormBoard, double cov_Flags, double cov_GeneralInformation, double cov_PargraphComprehension, double cov_SentenceCompletion, double cov_WordClassification, double cov_WordMeaning, double cov_Addition, double cov_Code, double cov_CountingDots, double cov_StraightCurvedCapitals, double cov_WordRecognition, double cov_NumberRecognition, double cov_FigureRecognition, double cov_ObjectNumber, double cov_NumberFigure, double cov_FigureWord, double cov_Deduction, double cov_NumericalPuzzles, double cov_ProblemReasoning, double cov_SeriesCompletion, double cov_ArithmeticProblems, int center, int n_obs)
        {
            this.κ = κ;
            this.cov_VisualPerception = cov_VisualPerception;
            this.cov_Cubes = cov_Cubes;
            this.cov_PaperFormBoard = cov_PaperFormBoard;
            this.cov_Flags = cov_Flags;
            this.cov_GeneralInformation = cov_GeneralInformation;
            this.cov_PargraphComprehension = cov_PargraphComprehension;
            this.cov_SentenceCompletion = cov_SentenceCompletion;
            this.cov_WordClassification = cov_WordClassification;
            this.cov_WordMeaning = cov_WordMeaning;
            this.cov_Addition = cov_Addition;
            this.cov_Code = cov_Code;
            this.cov_CountingDots = cov_CountingDots;
            this.cov_StraightCurvedCapitals = cov_StraightCurvedCapitals;
            this.cov_WordRecognition = cov_WordRecognition;
            this.cov_NumberRecognition = cov_NumberRecognition;
            this.cov_FigureRecognition = cov_FigureRecognition;
            this.cov_ObjectNumber = cov_ObjectNumber;
            this.cov_NumberFigure = cov_NumberFigure;
            this.cov_FigureWord = cov_FigureWord;
            this.cov_Deduction = cov_Deduction;
            this.cov_NumericalPuzzles = cov_NumericalPuzzles;
            this.cov_ProblemReasoning = cov_ProblemReasoning;
            this.cov_SeriesCompletion = cov_SeriesCompletion;
            this.cov_ArithmeticProblems = cov_ArithmeticProblems;
            this.center = center;
            this.n_obs = n_obs;
        }

        public static IEnumerable<Harman74_cor> Data
        {
            get
            {
                yield return new Harman74_cor("VisualPerception", 1, 0.318, 0.403, 0.468, 0.321, 0.335, 0.304, 0.332, 0.326, 0.116, 0.308, 0.314, 0.489, 0.125, 0.238, 0.414, 0.176, 0.368, 0.27, 0.365, 0.369, 0.413, 0.474, 0.282, 0, 145);
                yield return new Harman74_cor("Cubes", 0.318, 1, 0.317, 0.23, 0.285, 0.234, 0.157, 0.157, 0.195, 0.057, 0.15, 0.145, 0.239, 0.103, 0.131, 0.272, 0.005, 0.255, 0.112, 0.292, 0.306, 0.232, 0.348, 0.211, 0, 145);
                yield return new Harman74_cor("PaperFormBoard", 0.403, 0.317, 1, 0.305, 0.247, 0.268, 0.223, 0.382, 0.184, -0.075, 0.091, 0.14, 0.321, 0.177, 0.065, 0.263, 0.177, 0.211, 0.312, 0.297, 0.165, 0.25, 0.383, 0.203, 0, 145);
                yield return new Harman74_cor("Flags", 0.468, 0.23, 0.305, 1, 0.227, 0.327, 0.335, 0.391, 0.325, 0.099, 0.11, 0.16, 0.327, 0.066, 0.127, 0.322, 0.187, 0.251, 0.137, 0.339, 0.349, 0.38, 0.335, 0.248, 0, 145);
                yield return new Harman74_cor("GeneralInformation", 0.321, 0.285, 0.247, 0.227, 1, 0.622, 0.656, 0.578, 0.723, 0.311, 0.344, 0.215, 0.344, 0.28, 0.229, 0.187, 0.208, 0.263, 0.19, 0.398, 0.318, 0.441, 0.435, 0.42, 0, 145);
                yield return new Harman74_cor("PargraphComprehension", 0.335, 0.234, 0.268, 0.327, 0.622, 1, 0.722, 0.527, 0.714, 0.203, 0.353, 0.095, 0.309, 0.292, 0.251, 0.291, 0.273, 0.167, 0.251, 0.435, 0.263, 0.386, 0.431, 0.433, 0, 145);
                yield return new Harman74_cor("SentenceCompletion", 0.304, 0.157, 0.223, 0.335, 0.656, 0.722, 1, 0.619, 0.685, 0.246, 0.232, 0.181, 0.345, 0.236, 0.172, 0.18, 0.228, 0.159, 0.226, 0.451, 0.314, 0.396, 0.405, 0.437, 0, 145);
                yield return new Harman74_cor("WordClassification", 0.332, 0.157, 0.382, 0.391, 0.578, 0.527, 0.619, 1, 0.532, 0.285, 0.3, 0.271, 0.395, 0.252, 0.175, 0.296, 0.255, 0.25, 0.274, 0.427, 0.362, 0.357, 0.501, 0.388, 0, 145);
                yield return new Harman74_cor("WordMeaning", 0.326, 0.195, 0.184, 0.325, 0.723, 0.714, 0.685, 0.532, 1, 0.17, 0.28, 0.113, 0.28, 0.26, 0.248, 0.242, 0.274, 0.208, 0.274, 0.446, 0.266, 0.483, 0.504, 0.424, 0, 145);
                yield return new Harman74_cor("Addition", 0.116, 0.057, -0.075, 0.099, 0.311, 0.203, 0.246, 0.285, 0.17, 1, 0.484, 0.585, 0.408, 0.172, 0.154, 0.124, 0.289, 0.317, 0.19, 0.173, 0.405, 0.16, 0.262, 0.531, 0, 145);
                yield return new Harman74_cor("Code", 0.308, 0.15, 0.091, 0.11, 0.344, 0.353, 0.232, 0.3, 0.28, 0.484, 1, 0.428, 0.535, 0.35, 0.24, 0.314, 0.362, 0.35, 0.29, 0.202, 0.399, 0.304, 0.251, 0.412, 0, 145);
                yield return new Harman74_cor("CountingDots", 0.314, 0.145, 0.14, 0.16, 0.215, 0.095, 0.181, 0.271, 0.113, 0.585, 0.428, 1, 0.512, 0.131, 0.173, 0.119, 0.278, 0.349, 0.11, 0.246, 0.355, 0.193, 0.35, 0.414, 0, 145);
                yield return new Harman74_cor("StraightCurvedCapitals", 0.489, 0.239, 0.321, 0.327, 0.344, 0.309, 0.345, 0.395, 0.28, 0.408, 0.535, 0.512, 1, 0.195, 0.139, 0.281, 0.194, 0.323, 0.263, 0.241, 0.425, 0.279, 0.382, 0.358, 0, 145);
                yield return new Harman74_cor("WordRecognition", 0.125, 0.103, 0.177, 0.066, 0.28, 0.292, 0.236, 0.252, 0.26, 0.172, 0.35, 0.131, 0.195, 1, 0.37, 0.412, 0.341, 0.201, 0.206, 0.302, 0.183, 0.243, 0.242, 0.304, 0, 145);
                yield return new Harman74_cor("NumberRecognition", 0.238, 0.131, 0.065, 0.127, 0.229, 0.251, 0.172, 0.175, 0.248, 0.154, 0.24, 0.173, 0.139, 0.37, 1, 0.325, 0.345, 0.334, 0.192, 0.272, 0.232, 0.246, 0.256, 0.165, 0, 145);
                yield return new Harman74_cor("FigureRecognition", 0.414, 0.272, 0.263, 0.322, 0.187, 0.291, 0.18, 0.296, 0.242, 0.124, 0.314, 0.119, 0.281, 0.412, 0.325, 1, 0.324, 0.344, 0.258, 0.388, 0.348, 0.283, 0.36, 0.262, 0, 145);
                yield return new Harman74_cor("ObjectNumber", 0.176, 0.005, 0.177, 0.187, 0.208, 0.273, 0.228, 0.255, 0.274, 0.289, 0.362, 0.278, 0.194, 0.341, 0.345, 0.324, 1, 0.448, 0.324, 0.262, 0.173, 0.273, 0.287, 0.326, 0, 145);
                yield return new Harman74_cor("NumberFigure", 0.368, 0.255, 0.211, 0.251, 0.263, 0.167, 0.159, 0.25, 0.208, 0.317, 0.35, 0.349, 0.323, 0.201, 0.334, 0.344, 0.448, 1, 0.358, 0.301, 0.357, 0.317, 0.272, 0.405, 0, 145);
                yield return new Harman74_cor("FigureWord", 0.27, 0.112, 0.312, 0.137, 0.19, 0.251, 0.226, 0.274, 0.274, 0.19, 0.29, 0.11, 0.263, 0.206, 0.192, 0.258, 0.324, 0.358, 1, 0.167, 0.331, 0.342, 0.303, 0.374, 0, 145);
                yield return new Harman74_cor("Deduction", 0.365, 0.292, 0.297, 0.339, 0.398, 0.435, 0.451, 0.427, 0.446, 0.173, 0.202, 0.246, 0.241, 0.302, 0.272, 0.388, 0.262, 0.301, 0.167, 1, 0.413, 0.463, 0.509, 0.366, 0, 145);
                yield return new Harman74_cor("NumericalPuzzles", 0.369, 0.306, 0.165, 0.349, 0.318, 0.263, 0.314, 0.362, 0.266, 0.405, 0.399, 0.355, 0.425, 0.183, 0.232, 0.348, 0.173, 0.357, 0.331, 0.413, 1, 0.374, 0.451, 0.448, 0, 145);
                yield return new Harman74_cor("ProblemReasoning", 0.413, 0.232, 0.25, 0.38, 0.441, 0.386, 0.396, 0.357, 0.483, 0.16, 0.304, 0.193, 0.279, 0.243, 0.246, 0.283, 0.273, 0.317, 0.342, 0.463, 0.374, 1, 0.503, 0.375, 0, 145);
                yield return new Harman74_cor("SeriesCompletion", 0.474, 0.348, 0.383, 0.335, 0.435, 0.431, 0.405, 0.501, 0.504, 0.262, 0.251, 0.35, 0.382, 0.242, 0.256, 0.36, 0.287, 0.272, 0.303, 0.509, 0.451, 0.503, 1, 0.434, 0, 145);
                yield return new Harman74_cor("ArithmeticProblems", 0.282, 0.211, 0.203, 0.248, 0.42, 0.433, 0.437, 0.388, 0.424, 0.531, 0.412, 0.414, 0.358, 0.304, 0.165, 0.262, 0.326, 0.405, 0.374, 0.366, 0.448, 0.375, 0.434, 1, 0, 145);
            }
        }
    }
}
