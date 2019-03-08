// ReSharper disable All

namespace Rdatasets.drc
{
    using System.Collections.Generic;

    /// <summary>
    /// Example from Finney (1971)
    /// </summary>

    public class finney71
    {
        public readonly double dose;
        public readonly int total;
        public readonly int affected;

        public finney71(double dose, int total, int affected)
        {
            this.dose = dose;
            this.total = total;
            this.affected = affected;
        }

        public static IEnumerable<finney71> Data
        {
            get
            {
                yield return new finney71(10.2, 50, 44);
                yield return new finney71(7.7, 49, 42);
                yield return new finney71(5.1, 46, 24);
                yield return new finney71(3.8, 48, 16);
                yield return new finney71(2.6, 50, 6);
                yield return new finney71(0, 49, 0);
            }
        }
    }
}
