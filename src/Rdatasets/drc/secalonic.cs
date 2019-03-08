// ReSharper disable All

namespace Rdatasets.drc
{
    using System.Collections.Generic;

    /// <summary>
    /// Root length measurements
    /// </summary>

    public class secalonic
    {
        public readonly double dose;
        public readonly double rootl;

        public secalonic(double dose, double rootl)
        {
            this.dose = dose;
            this.rootl = rootl;
        }

        public static IEnumerable<secalonic> Data
        {
            get
            {
                yield return new secalonic(0, 5.5);
                yield return new secalonic(0.01, 5.7);
                yield return new secalonic(0.019, 5.4);
                yield return new secalonic(0.038, 4.6);
                yield return new secalonic(0.075, 3.3);
                yield return new secalonic(0.15, 0.7);
                yield return new secalonic(0.3, 0.4);
            }
        }
    }
}
