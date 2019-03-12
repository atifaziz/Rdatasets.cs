// ReSharper disable All

namespace Rdatasets.robustbase
{
    using System.Collections.Generic;

    /// <summary>
    /// Cushny and Peebles Prolongation of Sleep Data
    /// </summary>

    public class cushny
    {
        public readonly int κ;
        public readonly double dat;

        public cushny(int κ, double dat)
        {
            this.κ = κ;
            this.dat = dat;
        }

        public static IEnumerable<cushny> Data
        {
            get
            {
                yield return new cushny(1, 0);
                yield return new cushny(2, 0.8);
                yield return new cushny(3, 1);
                yield return new cushny(4, 1.2);
                yield return new cushny(5, 1.3);
                yield return new cushny(6, 1.3);
                yield return new cushny(7, 1.4);
                yield return new cushny(8, 1.8);
                yield return new cushny(9, 2.4);
                yield return new cushny(10, 4.6);
            }
        }
    }
}
