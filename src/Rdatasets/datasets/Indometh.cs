// ReSharper disable All

namespace Rdatasets.datasets
{
    using System.Collections.Generic;

    /// <summary>
    /// Pharmacokinetics of Indomethacin
    /// </summary>

    public class Indometh
    {
        public readonly int Subject;
        public readonly double time;
        public readonly double conc;

        public Indometh(int Subject, double time, double conc)
        {
            this.Subject = Subject;
            this.time = time;
            this.conc = conc;
        }

        public static IEnumerable<Indometh> Data
        {
            get
            {
                yield return new Indometh(1, 0.25, 1.5);
                yield return new Indometh(1, 0.5, 0.94);
                yield return new Indometh(1, 0.75, 0.78);
                yield return new Indometh(1, 1, 0.48);
                yield return new Indometh(1, 1.25, 0.37);
                yield return new Indometh(1, 2, 0.19);
                yield return new Indometh(1, 3, 0.12);
                yield return new Indometh(1, 4, 0.11);
                yield return new Indometh(1, 5, 0.08);
                yield return new Indometh(1, 6, 0.07);
                yield return new Indometh(1, 8, 0.05);
                yield return new Indometh(2, 0.25, 2.03);
                yield return new Indometh(2, 0.5, 1.63);
                yield return new Indometh(2, 0.75, 0.71);
                yield return new Indometh(2, 1, 0.7);
                yield return new Indometh(2, 1.25, 0.64);
                yield return new Indometh(2, 2, 0.36);
                yield return new Indometh(2, 3, 0.32);
                yield return new Indometh(2, 4, 0.2);
                yield return new Indometh(2, 5, 0.25);
                yield return new Indometh(2, 6, 0.12);
                yield return new Indometh(2, 8, 0.08);
                yield return new Indometh(3, 0.25, 2.72);
                yield return new Indometh(3, 0.5, 1.49);
                yield return new Indometh(3, 0.75, 1.16);
                yield return new Indometh(3, 1, 0.8);
                yield return new Indometh(3, 1.25, 0.8);
                yield return new Indometh(3, 2, 0.39);
                yield return new Indometh(3, 3, 0.22);
                yield return new Indometh(3, 4, 0.12);
                yield return new Indometh(3, 5, 0.11);
                yield return new Indometh(3, 6, 0.08);
                yield return new Indometh(3, 8, 0.08);
                yield return new Indometh(4, 0.25, 1.85);
                yield return new Indometh(4, 0.5, 1.39);
                yield return new Indometh(4, 0.75, 1.02);
                yield return new Indometh(4, 1, 0.89);
                yield return new Indometh(4, 1.25, 0.59);
                yield return new Indometh(4, 2, 0.4);
                yield return new Indometh(4, 3, 0.16);
                yield return new Indometh(4, 4, 0.11);
                yield return new Indometh(4, 5, 0.1);
                yield return new Indometh(4, 6, 0.07);
                yield return new Indometh(4, 8, 0.07);
                yield return new Indometh(5, 0.25, 2.05);
                yield return new Indometh(5, 0.5, 1.04);
                yield return new Indometh(5, 0.75, 0.81);
                yield return new Indometh(5, 1, 0.39);
                yield return new Indometh(5, 1.25, 0.3);
                yield return new Indometh(5, 2, 0.23);
                yield return new Indometh(5, 3, 0.13);
                yield return new Indometh(5, 4, 0.11);
                yield return new Indometh(5, 5, 0.08);
                yield return new Indometh(5, 6, 0.1);
                yield return new Indometh(5, 8, 0.06);
                yield return new Indometh(6, 0.25, 2.31);
                yield return new Indometh(6, 0.5, 1.44);
                yield return new Indometh(6, 0.75, 1.03);
                yield return new Indometh(6, 1, 0.84);
                yield return new Indometh(6, 1.25, 0.64);
                yield return new Indometh(6, 2, 0.42);
                yield return new Indometh(6, 3, 0.24);
                yield return new Indometh(6, 4, 0.17);
                yield return new Indometh(6, 5, 0.13);
                yield return new Indometh(6, 6, 0.1);
                yield return new Indometh(6, 8, 0.09);
            }
        }
    }
}
