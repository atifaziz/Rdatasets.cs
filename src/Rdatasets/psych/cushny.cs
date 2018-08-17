// ReSharper disable All

namespace Rdatasets.psych
{
    using System.Collections.Generic;

    /// <summary>
    /// A data set from Cushny and Peebles (1905) on the effect of three drugs on hours of sleep, used by Student (1908)
    /// </summary>

    public class cushny
    {
        public readonly double Control;
        public readonly double drug1;
        public readonly double drug2L;
        public readonly double drug2R;
        public readonly double delta1;
        public readonly double delta2L;
        public readonly double delta2R;

        public cushny(double Control, double drug1, double drug2L, double drug2R, double delta1, double delta2L, double delta2R)
        {
            this.Control = Control;
            this.drug1 = drug1;
            this.drug2L = drug2L;
            this.drug2R = drug2R;
            this.delta1 = delta1;
            this.delta2L = delta2L;
            this.delta2R = delta2R;
        }

        public static IEnumerable<cushny> Data
        {
            get
            {
                yield return new cushny(0.6, 1.3, 2.5, 2.1, 0.7, 1.9, 1.5);
                yield return new cushny(3, 1.4, 3.8, 4.4, -1.6, 0.8, 1.4);
                yield return new cushny(4.7, 4.5, 5.8, 4.7, -0.2, 1.1, 0);
                yield return new cushny(5.5, 4.3, 5.6, 4.8, -1.2, 0.1, -0.7);
                yield return new cushny(6.2, 6.1, 6.1, 6.7, -0.1, -0.1, 0.5);
                yield return new cushny(3.2, 6.6, 7.6, 8.3, 3.4, 4.4, 5.1);
                yield return new cushny(2.5, 6.2, 8, 8.2, 3.7, 5.5, 5.7);
                yield return new cushny(2.8, 3.6, 4.4, 4.3, 0.8, 1.6, 1.5);
                yield return new cushny(1.1, 1.1, 5.7, 5.8, 0, 4.6, 4.7);
                yield return new cushny(2.9, 4.9, 6.3, 6.4, 2, 3.4, 3.5);
            }
        }
    }
}
