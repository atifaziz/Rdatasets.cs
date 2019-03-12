// ReSharper disable All

namespace Rdatasets.drc
{
    using System.Collections.Generic;

    /// <summary>
    /// Effect of an effluent on the growth of mysid shrimp
    /// </summary>

    public class M_bahia
    {
        public readonly int κ;
        public readonly double conc;
        public readonly double dryweight;

        public M_bahia(int κ, double conc, double dryweight)
        {
            this.κ = κ;
            this.conc = conc;
            this.dryweight = dryweight;
        }

        public static IEnumerable<M_bahia> Data
        {
            get
            {
                yield return new M_bahia(1, 0, 0.73);
                yield return new M_bahia(2, 0, 0.49);
                yield return new M_bahia(3, 0, 0.66);
                yield return new M_bahia(4, 0, 0.7);
                yield return new M_bahia(5, 0, 0.59);
                yield return new M_bahia(6, 0, 0.52);
                yield return new M_bahia(7, 0, 0.69);
                yield return new M_bahia(8, 0, 0.68);
                yield return new M_bahia(9, 0.32, 0.76);
                yield return new M_bahia(10, 0.32, 0.59);
                yield return new M_bahia(11, 0.32, 0.62);
                yield return new M_bahia(12, 0.32, 0.6);
                yield return new M_bahia(13, 0.32, 0.58);
                yield return new M_bahia(14, 0.32, 0.63);
                yield return new M_bahia(15, 0.32, 0.55);
                yield return new M_bahia(16, 0.32, 0.73);
                yield return new M_bahia(17, 1, 0.7);
                yield return new M_bahia(18, 1, 0.57);
                yield return new M_bahia(19, 1, 0.56);
                yield return new M_bahia(20, 1, 0.58);
                yield return new M_bahia(21, 1, 0.62);
                yield return new M_bahia(22, 1, 0.64);
                yield return new M_bahia(23, 1, 0.55);
                yield return new M_bahia(24, 1, 0.47);
                yield return new M_bahia(25, 3.2, 0.25);
                yield return new M_bahia(26, 3.2, 0.3);
                yield return new M_bahia(27, 3.2, 0.31);
                yield return new M_bahia(28, 3.2, 0.25);
                yield return new M_bahia(29, 3.2, 0.3);
                yield return new M_bahia(30, 3.2, 0.25);
                yield return new M_bahia(31, 3.2, 0.27);
                yield return new M_bahia(32, 3.2, 0.33);
                yield return new M_bahia(33, 10, 0.22);
                yield return new M_bahia(34, 10, 0.25);
                yield return new M_bahia(35, 10, 0.26);
                yield return new M_bahia(36, 10, 0.27);
                yield return new M_bahia(37, 10, 0.21);
                yield return new M_bahia(38, 10, 0.23);
                yield return new M_bahia(39, 10, 0.27);
                yield return new M_bahia(40, 10, 0.27);
            }
        }
    }
}
