// ReSharper disable All

namespace Rdatasets.drc
{
    using System.Collections.Generic;

    /// <summary>
    /// Root length measurements
    /// </summary>

    public class secalonic
    {
        public readonly int κ;
        public readonly double dose;
        public readonly double rootl;

        public secalonic(int κ, double dose, double rootl)
        {
            this.κ = κ;
            this.dose = dose;
            this.rootl = rootl;
        }

        public static IEnumerable<secalonic> Data
        {
            get
            {
                yield return new secalonic(1, 0, 5.5);
                yield return new secalonic(2, 0.01, 5.7);
                yield return new secalonic(3, 0.019, 5.4);
                yield return new secalonic(4, 0.038, 4.6);
                yield return new secalonic(5, 0.075, 3.3);
                yield return new secalonic(6, 0.15, 0.7);
                yield return new secalonic(7, 0.3, 0.4);
            }
        }
    }
}
