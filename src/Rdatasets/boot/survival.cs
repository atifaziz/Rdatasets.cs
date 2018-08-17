// ReSharper disable All

namespace Rdatasets.boot
{
    using System.Collections.Generic;

    /// <summary>
    /// Survival of Rats after Radiation Doses
    /// </summary>

    public class survival
    {
        public readonly double dose;
        public readonly double surv;

        public survival(double dose, double surv)
        {
            this.dose = dose;
            this.surv = surv;
        }

        public static IEnumerable<survival> Data
        {
            get
            {
                yield return new survival(117.5, 44);
                yield return new survival(117.5, 55);
                yield return new survival(235, 16);
                yield return new survival(235, 13);
                yield return new survival(470, 4);
                yield return new survival(470, 1.96);
                yield return new survival(470, 6.12);
                yield return new survival(705, 0.5);
                yield return new survival(705, 0.32);
                yield return new survival(940, 0.11);
                yield return new survival(940, 0.015);
                yield return new survival(940, 0.019);
                yield return new survival(1410, 0.7);
                yield return new survival(1410, 0.006);
            }
        }
    }
}
