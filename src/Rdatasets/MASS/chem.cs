// ReSharper disable All

namespace Rdatasets.MASS
{
    using System.Collections.Generic;

    /// <summary>
    /// Copper in Wholemeal Flour
    /// </summary>

    public class chem
    {
        public readonly int κ;
        public readonly double dat;

        public chem(int κ, double dat)
        {
            this.κ = κ;
            this.dat = dat;
        }

        public static IEnumerable<chem> Data
        {
            get
            {
                yield return new chem(1, 2.9);
                yield return new chem(2, 3.1);
                yield return new chem(3, 3.4);
                yield return new chem(4, 3.4);
                yield return new chem(5, 3.7);
                yield return new chem(6, 3.7);
                yield return new chem(7, 2.8);
                yield return new chem(8, 2.5);
                yield return new chem(9, 2.4);
                yield return new chem(10, 2.4);
                yield return new chem(11, 2.7);
                yield return new chem(12, 2.2);
                yield return new chem(13, 5.28);
                yield return new chem(14, 3.37);
                yield return new chem(15, 3.03);
                yield return new chem(16, 3.03);
                yield return new chem(17, 28.95);
                yield return new chem(18, 3.77);
                yield return new chem(19, 3.4);
                yield return new chem(20, 2.2);
                yield return new chem(21, 3.5);
                yield return new chem(22, 3.6);
                yield return new chem(23, 3.7);
                yield return new chem(24, 3.7);
            }
        }
    }
}
