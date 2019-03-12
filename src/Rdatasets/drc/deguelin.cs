// ReSharper disable All

namespace Rdatasets.drc
{
    using System.Collections.Generic;

    /// <summary>
    /// Deguelin applied to chrysanthemum aphis
    /// </summary>

    public class deguelin
    {
        public readonly int κ;
        public readonly double dose;
        public readonly double log10dose;
        public readonly int r;
        public readonly int n;

        public deguelin(int κ, double dose, double log10dose, int r, int n)
        {
            this.κ = κ;
            this.dose = dose;
            this.log10dose = log10dose;
            this.r = r;
            this.n = n;
        }

        public static IEnumerable<deguelin> Data
        {
            get
            {
                yield return new deguelin(1, 5.12861383991365, 0.71, 16, 49);
                yield return new deguelin(2, 10, 1, 18, 48);
                yield return new deguelin(3, 20.4173794466953, 1.31, 34, 48);
                yield return new deguelin(4, 30.1995172040202, 1.48, 47, 49);
                yield return new deguelin(5, 40.7380277804113, 1.61, 47, 50);
                yield return new deguelin(6, 50.1187233627272, 1.7, 48, 48);
            }
        }
    }
}
