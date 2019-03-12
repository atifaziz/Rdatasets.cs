// ReSharper disable All

namespace Rdatasets.boot
{
    using System.Collections.Generic;

    /// <summary>
    /// CD4 Counts for HIV-Positive Patients
    /// </summary>

    public class cd4
    {
        public readonly int κ;
        public readonly double baseline;
        public readonly double oneyear;

        public cd4(int κ, double baseline, double oneyear)
        {
            this.κ = κ;
            this.baseline = baseline;
            this.oneyear = oneyear;
        }

        public static IEnumerable<cd4> Data
        {
            get
            {
                yield return new cd4(1, 2.12, 2.47);
                yield return new cd4(2, 4.35, 4.61);
                yield return new cd4(3, 3.39, 5.26);
                yield return new cd4(4, 2.51, 3.02);
                yield return new cd4(5, 4.04, 6.36);
                yield return new cd4(6, 5.1, 5.93);
                yield return new cd4(7, 3.77, 3.93);
                yield return new cd4(8, 3.35, 4.09);
                yield return new cd4(9, 4.1, 4.88);
                yield return new cd4(10, 3.35, 3.81);
                yield return new cd4(11, 4.15, 4.74);
                yield return new cd4(12, 3.56, 3.29);
                yield return new cd4(13, 3.39, 5.55);
                yield return new cd4(14, 1.88, 2.82);
                yield return new cd4(15, 2.56, 4.23);
                yield return new cd4(16, 2.96, 3.23);
                yield return new cd4(17, 2.49, 2.56);
                yield return new cd4(18, 3.03, 4.31);
                yield return new cd4(19, 2.66, 4.37);
                yield return new cd4(20, 3, 2.4);
            }
        }
    }
}
