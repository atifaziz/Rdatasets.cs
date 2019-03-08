// ReSharper disable All

namespace Rdatasets.drc
{
    using System.Collections.Generic;

    /// <summary>
    /// Effect of an effluent on the growth of mysid shrimp
    /// </summary>

    public class M_bahia
    {
        public readonly double conc;
        public readonly double dryweight;

        public M_bahia(double conc, double dryweight)
        {
            this.conc = conc;
            this.dryweight = dryweight;
        }

        public static IEnumerable<M_bahia> Data
        {
            get
            {
                yield return new M_bahia(0, 0.73);
                yield return new M_bahia(0, 0.49);
                yield return new M_bahia(0, 0.66);
                yield return new M_bahia(0, 0.7);
                yield return new M_bahia(0, 0.59);
                yield return new M_bahia(0, 0.52);
                yield return new M_bahia(0, 0.69);
                yield return new M_bahia(0, 0.68);
                yield return new M_bahia(0.32, 0.76);
                yield return new M_bahia(0.32, 0.59);
                yield return new M_bahia(0.32, 0.62);
                yield return new M_bahia(0.32, 0.6);
                yield return new M_bahia(0.32, 0.58);
                yield return new M_bahia(0.32, 0.63);
                yield return new M_bahia(0.32, 0.55);
                yield return new M_bahia(0.32, 0.73);
                yield return new M_bahia(1, 0.7);
                yield return new M_bahia(1, 0.57);
                yield return new M_bahia(1, 0.56);
                yield return new M_bahia(1, 0.58);
                yield return new M_bahia(1, 0.62);
                yield return new M_bahia(1, 0.64);
                yield return new M_bahia(1, 0.55);
                yield return new M_bahia(1, 0.47);
                yield return new M_bahia(3.2, 0.25);
                yield return new M_bahia(3.2, 0.3);
                yield return new M_bahia(3.2, 0.31);
                yield return new M_bahia(3.2, 0.25);
                yield return new M_bahia(3.2, 0.3);
                yield return new M_bahia(3.2, 0.25);
                yield return new M_bahia(3.2, 0.27);
                yield return new M_bahia(3.2, 0.33);
                yield return new M_bahia(10, 0.22);
                yield return new M_bahia(10, 0.25);
                yield return new M_bahia(10, 0.26);
                yield return new M_bahia(10, 0.27);
                yield return new M_bahia(10, 0.21);
                yield return new M_bahia(10, 0.23);
                yield return new M_bahia(10, 0.27);
                yield return new M_bahia(10, 0.27);
            }
        }
    }
}
