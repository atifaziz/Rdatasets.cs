// ReSharper disable All

namespace Rdatasets.boot
{
    using System.Collections.Generic;

    /// <summary>
    /// Survival of Rats after Radiation Doses
    /// </summary>

    public class survival
    {
        public readonly int κ;
        public readonly double dose;
        public readonly double surv;

        public survival(int κ, double dose, double surv)
        {
            this.κ = κ;
            this.dose = dose;
            this.surv = surv;
        }

        public static IEnumerable<survival> Data
        {
            get
            {
                yield return new survival(1, 117.5, 44);
                yield return new survival(2, 117.5, 55);
                yield return new survival(3, 235, 16);
                yield return new survival(4, 235, 13);
                yield return new survival(5, 470, 4);
                yield return new survival(6, 470, 1.96);
                yield return new survival(7, 470, 6.12);
                yield return new survival(8, 705, 0.5);
                yield return new survival(9, 705, 0.32);
                yield return new survival(10, 940, 0.11);
                yield return new survival(11, 940, 0.015);
                yield return new survival(12, 940, 0.019);
                yield return new survival(13, 1410, 0.7);
                yield return new survival(14, 1410, 0.006);
            }
        }
    }
}
