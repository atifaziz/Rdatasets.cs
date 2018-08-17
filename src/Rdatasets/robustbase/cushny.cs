// ReSharper disable All

namespace Rdatasets.robustbase
{
    using System.Collections.Generic;

    /// <summary>
    /// Cushny and Peebles Prolongation of Sleep Data
    /// </summary>

    public class cushny
    {
        public readonly double dat;

        public cushny(double dat)
        {
            this.dat = dat;
        }

        public static IEnumerable<cushny> Data
        {
            get
            {
                yield return new cushny(0);
                yield return new cushny(0.8);
                yield return new cushny(1);
                yield return new cushny(1.2);
                yield return new cushny(1.3);
                yield return new cushny(1.3);
                yield return new cushny(1.4);
                yield return new cushny(1.8);
                yield return new cushny(2.4);
                yield return new cushny(4.6);
            }
        }
    }
}
