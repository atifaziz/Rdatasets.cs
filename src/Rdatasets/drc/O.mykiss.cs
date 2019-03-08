// ReSharper disable All

namespace Rdatasets.drc
{
    using System.Collections.Generic;

    /// <summary>
    /// Test data from a 21 day fish test
    /// </summary>

    public class O_mykiss
    {
        public readonly double conc;
        public readonly double? weight;

        public O_mykiss(double conc, double? weight)
        {
            this.conc = conc;
            this.weight = weight;
        }

        public static IEnumerable<O_mykiss> Data
        {
            get
            {
                yield return new O_mykiss(0, 2.8);
                yield return new O_mykiss(0, 3);
                yield return new O_mykiss(0, 2.7);
                yield return new O_mykiss(0, 3.9);
                yield return new O_mykiss(0, 3.1);
                yield return new O_mykiss(0, 1.8);
                yield return new O_mykiss(0, 2.9);
                yield return new O_mykiss(0, 2.5);
                yield return new O_mykiss(0, 2.2);
                yield return new O_mykiss(0, 3.1);
                yield return new O_mykiss(1, 2.7);
                yield return new O_mykiss(1, 3.3);
                yield return new O_mykiss(1, 2.9);
                yield return new O_mykiss(1, 2.2);
                yield return new O_mykiss(1, 2);
                yield return new O_mykiss(1, 3.1);
                yield return new O_mykiss(1, 3.2);
                yield return new O_mykiss(1, 2.5);
                yield return new O_mykiss(1, 2.5);
                yield return new O_mykiss(1, 2.6);
                yield return new O_mykiss(2.2, 2.9);
                yield return new O_mykiss(2.2, 2.6);
                yield return new O_mykiss(2.2, 2.7);
                yield return new O_mykiss(2.2, 3.3);
                yield return new O_mykiss(2.2, 2.7);
                yield return new O_mykiss(2.2, 4);
                yield return new O_mykiss(2.2, 3);
                yield return new O_mykiss(2.2, 2.5);
                yield return new O_mykiss(2.2, 2.2);
                yield return new O_mykiss(2.2, null);
                yield return new O_mykiss(4.6, 2.9);
                yield return new O_mykiss(4.6, 3);
                yield return new O_mykiss(4.6, 3.5);
                yield return new O_mykiss(4.6, 2.7);
                yield return new O_mykiss(4.6, 2.3);
                yield return new O_mykiss(4.6, 2.7);
                yield return new O_mykiss(4.6, 2);
                yield return new O_mykiss(4.6, 4);
                yield return new O_mykiss(4.6, 2.2);
                yield return new O_mykiss(4.6, 2.4);
                yield return new O_mykiss(10, 3.4);
                yield return new O_mykiss(10, 2.8);
                yield return new O_mykiss(10, 2.1);
                yield return new O_mykiss(10, 2.3);
                yield return new O_mykiss(10, 3.1);
                yield return new O_mykiss(10, 1.8);
                yield return new O_mykiss(10, 2.4);
                yield return new O_mykiss(10, 3);
                yield return new O_mykiss(10, 2.3);
                yield return new O_mykiss(10, null);
                yield return new O_mykiss(22, 2.7);
                yield return new O_mykiss(22, 2);
                yield return new O_mykiss(22, 3.5);
                yield return new O_mykiss(22, 1.8);
                yield return new O_mykiss(22, 3.1);
                yield return new O_mykiss(22, 3.2);
                yield return new O_mykiss(22, 2.2);
                yield return new O_mykiss(22, 2.5);
                yield return new O_mykiss(22, 1.8);
                yield return new O_mykiss(22, null);
                yield return new O_mykiss(46, 1.6);
                yield return new O_mykiss(46, 2.8);
                yield return new O_mykiss(46, 1.2);
                yield return new O_mykiss(46, 0.9);
                yield return new O_mykiss(46, null);
                yield return new O_mykiss(46, null);
                yield return new O_mykiss(46, null);
                yield return new O_mykiss(46, null);
                yield return new O_mykiss(46, null);
                yield return new O_mykiss(46, null);
            }
        }
    }
}
