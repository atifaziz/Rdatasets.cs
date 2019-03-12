// ReSharper disable All

namespace Rdatasets.psych
{
    using System.Collections.Generic;

    /// <summary>
    /// The Schutz correlation matrix example from Shapiro and ten Berge
    /// </summary>

    public class Schutz
    {
        public readonly string κ;
        public readonly double V1;
        public readonly double V2;
        public readonly double V3;
        public readonly double V4;
        public readonly double V5;
        public readonly double V6;
        public readonly double V7;
        public readonly double V8;
        public readonly double V9;

        public Schutz(string κ, double V1, double V2, double V3, double V4, double V5, double V6, double V7, double V8, double V9)
        {
            this.κ = κ;
            this.V1 = V1;
            this.V2 = V2;
            this.V3 = V3;
            this.V4 = V4;
            this.V5 = V5;
            this.V6 = V6;
            this.V7 = V7;
            this.V8 = V8;
            this.V9 = V9;
        }

        public static IEnumerable<Schutz> Data
        {
            get
            {
                yield return new Schutz("Word meaning", 1, 0.8, 0.28, 0.29, 0.41, 0.38, 0.44, 0.4, 0.41);
                yield return new Schutz("Odd Words", 0.8, 1, 0.31, 0.33, 0.49, 0.44, 0.5, 0.44, 0.46);
                yield return new Schutz("Boots", 0.28, 0.31, 1, 0.71, 0.32, 0.34, 0.41, 0.41, 0.3);
                yield return new Schutz("Hatchets", 0.29, 0.33, 0.71, 1, 0.32, 0.36, 0.42, 0.41, 0.31);
                yield return new Schutz("Mixed Arithmetic", 0.41, 0.49, 0.32, 0.32, 1, 0.77, 0.5, 0.39, 0.37);
                yield return new Schutz("Remainders", 0.38, 0.44, 0.34, 0.36, 0.77, 1, 0.48, 0.35, 0.37);
                yield return new Schutz("Mixed Series", 0.44, 0.5, 0.41, 0.42, 0.5, 0.48, 1, 0.56, 0.48);
                yield return new Schutz("Figure Changes", 0.4, 0.44, 0.41, 0.41, 0.39, 0.35, 0.56, 1, 0.46);
                yield return new Schutz("Teams", 0.41, 0.46, 0.3, 0.31, 0.37, 0.37, 0.48, 0.46, 1);
            }
        }
    }
}
