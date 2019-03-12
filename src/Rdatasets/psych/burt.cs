// ReSharper disable All

namespace Rdatasets.psych
{
    using System.Collections.Generic;

    /// <summary>
    /// 11 emotional variables from Burt (1915)
    /// </summary>

    public class burt
    {
        public readonly string κ;
        public readonly double Sociality;
        public readonly double Sorrow;
        public readonly double Tenderness;
        public readonly double Joy;
        public readonly double Wonder;
        public readonly double Elation;
        public readonly double Disgust;
        public readonly double Anger;
        public readonly double Sex;
        public readonly double Fear;
        public readonly double Subjection;

        public burt(string κ, double Sociality, double Sorrow, double Tenderness, double Joy, double Wonder, double Elation, double Disgust, double Anger, double Sex, double Fear, double Subjection)
        {
            this.κ = κ;
            this.Sociality = Sociality;
            this.Sorrow = Sorrow;
            this.Tenderness = Tenderness;
            this.Joy = Joy;
            this.Wonder = Wonder;
            this.Elation = Elation;
            this.Disgust = Disgust;
            this.Anger = Anger;
            this.Sex = Sex;
            this.Fear = Fear;
            this.Subjection = Subjection;
        }

        public static IEnumerable<burt> Data
        {
            get
            {
                yield return new burt("Sociality", 1, 0.83, 0.81, 0.8, 0.71, 0.7, 0.54, 0.53, 0.59, 0.24, 0.13);
                yield return new burt("Sorrow", 0.83, 1, 0.87, 0.62, 0.59, 0.44, 0.58, 0.44, 0.23, 0.45, 0.21);
                yield return new burt("Tenderness", 0.81, 0.87, 1, 0.63, 0.37, 0.31, 0.3, 0.12, 0.33, 0.33, 0.36);
                yield return new burt("Joy", 0.8, 0.62, 0.63, 1, 0.49, 0.54, 0.3, 0.28, 0.42, 0.29, -0.06);
                yield return new burt("Wonder", 0.71, 0.59, 0.37, 0.49, 1, 0.54, 0.34, 0.55, 0.4, 0.19, -0.1);
                yield return new burt("Elation", 0.7, 0.44, 0.31, 0.54, 0.54, 1, 0.5, 0.51, 0.31, 0.11, 0.1);
                yield return new burt("Disgust", 0.54, 0.58, 0.3, 0.3, 0.34, 0.5, 1, 0.38, 0.29, 0.21, 0.08);
                yield return new burt("Anger", 0.53, 0.44, 0.12, 0.28, 0.55, 0.51, 0.38, 1, 0.53, 0.1, -0.16);
                yield return new burt("Sex", 0.59, 0.23, 0.33, 0.42, 0.4, 0.31, 0.29, 0.53, 1, -0.09, -0.1);
                yield return new burt("Fear", 0.24, 0.45, 0.33, 0.29, 0.19, 0.11, 0.21, 0.1, -0.09, 1, 0.41);
                yield return new burt("Subjection", 0.13, 0.21, 0.36, -0.06, -0.1, 0.1, 0.08, -0.16, -0.1, 0.41, 1);
            }
        }
    }
}
