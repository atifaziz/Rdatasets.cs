// ReSharper disable All

namespace Rdatasets.Stat2Data
{
    using System.Collections.Generic;

    /// <summary>
    /// Orings
    /// </summary>

    public class Orings
    {
        public readonly int κ;
        public readonly string Temp;
        public readonly int Failures;

        public Orings(int κ, string Temp, int Failures)
        {
            this.κ = κ;
            this.Temp = Temp;
            this.Failures = Failures;
        }

        public static IEnumerable<Orings> Data
        {
            get
            {
                yield return new Orings(1, "Above65", 0);
                yield return new Orings(2, "Above65", 0);
                yield return new Orings(3, "Above65", 0);
                yield return new Orings(4, "Above65", 0);
                yield return new Orings(5, "Above65", 0);
                yield return new Orings(6, "Above65", 0);
                yield return new Orings(7, "Above65", 0);
                yield return new Orings(8, "Above65", 0);
                yield return new Orings(9, "Above65", 0);
                yield return new Orings(10, "Above65", 0);
                yield return new Orings(11, "Above65", 0);
                yield return new Orings(12, "Above65", 0);
                yield return new Orings(13, "Above65", 0);
                yield return new Orings(14, "Above65", 0);
                yield return new Orings(15, "Above65", 0);
                yield return new Orings(16, "Above65", 0);
                yield return new Orings(17, "Above65", 0);
                yield return new Orings(18, "Above65", 1);
                yield return new Orings(19, "Above65", 1);
                yield return new Orings(20, "Above65", 2);
                yield return new Orings(21, "Below65", 1);
                yield return new Orings(22, "Below65", 1);
                yield return new Orings(23, "Below65", 1);
                yield return new Orings(24, "Below65", 3);
            }
        }
    }
}
