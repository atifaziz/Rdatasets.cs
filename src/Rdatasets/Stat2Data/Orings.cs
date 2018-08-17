// ReSharper disable All

namespace Rdatasets.Stat2Data
{
    using System.Collections.Generic;

    /// <summary>
    /// Orings
    /// </summary>

    public class Orings
    {
        public readonly string Temp;
        public readonly int Failures;

        public Orings(string Temp, int Failures)
        {
            this.Temp = Temp;
            this.Failures = Failures;
        }

        public static IEnumerable<Orings> Data
        {
            get
            {
                yield return new Orings("Above65", 0);
                yield return new Orings("Above65", 0);
                yield return new Orings("Above65", 0);
                yield return new Orings("Above65", 0);
                yield return new Orings("Above65", 0);
                yield return new Orings("Above65", 0);
                yield return new Orings("Above65", 0);
                yield return new Orings("Above65", 0);
                yield return new Orings("Above65", 0);
                yield return new Orings("Above65", 0);
                yield return new Orings("Above65", 0);
                yield return new Orings("Above65", 0);
                yield return new Orings("Above65", 0);
                yield return new Orings("Above65", 0);
                yield return new Orings("Above65", 0);
                yield return new Orings("Above65", 0);
                yield return new Orings("Above65", 0);
                yield return new Orings("Above65", 1);
                yield return new Orings("Above65", 1);
                yield return new Orings("Above65", 2);
                yield return new Orings("Below65", 1);
                yield return new Orings("Below65", 1);
                yield return new Orings("Below65", 1);
                yield return new Orings("Below65", 3);
            }
        }
    }
}
