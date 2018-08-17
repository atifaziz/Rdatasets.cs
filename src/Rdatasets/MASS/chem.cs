// ReSharper disable All

namespace Rdatasets.MASS
{
    using System.Collections.Generic;

    /// <summary>
    /// Copper in Wholemeal Flour
    /// </summary>

    public class chem
    {
        public readonly double dat;

        public chem(double dat)
        {
            this.dat = dat;
        }

        public static IEnumerable<chem> Data
        {
            get
            {
                yield return new chem(2.9);
                yield return new chem(3.1);
                yield return new chem(3.4);
                yield return new chem(3.4);
                yield return new chem(3.7);
                yield return new chem(3.7);
                yield return new chem(2.8);
                yield return new chem(2.5);
                yield return new chem(2.4);
                yield return new chem(2.4);
                yield return new chem(2.7);
                yield return new chem(2.2);
                yield return new chem(5.28);
                yield return new chem(3.37);
                yield return new chem(3.03);
                yield return new chem(3.03);
                yield return new chem(28.95);
                yield return new chem(3.77);
                yield return new chem(3.4);
                yield return new chem(2.2);
                yield return new chem(3.5);
                yield return new chem(3.6);
                yield return new chem(3.7);
                yield return new chem(3.7);
            }
        }
    }
}
