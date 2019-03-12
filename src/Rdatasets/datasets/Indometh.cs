// ReSharper disable All

namespace Rdatasets.datasets
{
    using System.Collections.Generic;

    /// <summary>
    /// Pharmacokinetics of Indomethacin
    /// </summary>

    public class Indometh
    {
        public readonly int κ;
        public readonly int Subject;
        public readonly double time;
        public readonly double conc;

        public Indometh(int κ, int Subject, double time, double conc)
        {
            this.κ = κ;
            this.Subject = Subject;
            this.time = time;
            this.conc = conc;
        }

        public static IEnumerable<Indometh> Data
        {
            get
            {
                yield return new Indometh(1, 1, 0.25, 1.5);
                yield return new Indometh(2, 1, 0.5, 0.94);
                yield return new Indometh(3, 1, 0.75, 0.78);
                yield return new Indometh(4, 1, 1, 0.48);
                yield return new Indometh(5, 1, 1.25, 0.37);
                yield return new Indometh(6, 1, 2, 0.19);
                yield return new Indometh(7, 1, 3, 0.12);
                yield return new Indometh(8, 1, 4, 0.11);
                yield return new Indometh(9, 1, 5, 0.08);
                yield return new Indometh(10, 1, 6, 0.07);
                yield return new Indometh(11, 1, 8, 0.05);
                yield return new Indometh(12, 2, 0.25, 2.03);
                yield return new Indometh(13, 2, 0.5, 1.63);
                yield return new Indometh(14, 2, 0.75, 0.71);
                yield return new Indometh(15, 2, 1, 0.7);
                yield return new Indometh(16, 2, 1.25, 0.64);
                yield return new Indometh(17, 2, 2, 0.36);
                yield return new Indometh(18, 2, 3, 0.32);
                yield return new Indometh(19, 2, 4, 0.2);
                yield return new Indometh(20, 2, 5, 0.25);
                yield return new Indometh(21, 2, 6, 0.12);
                yield return new Indometh(22, 2, 8, 0.08);
                yield return new Indometh(23, 3, 0.25, 2.72);
                yield return new Indometh(24, 3, 0.5, 1.49);
                yield return new Indometh(25, 3, 0.75, 1.16);
                yield return new Indometh(26, 3, 1, 0.8);
                yield return new Indometh(27, 3, 1.25, 0.8);
                yield return new Indometh(28, 3, 2, 0.39);
                yield return new Indometh(29, 3, 3, 0.22);
                yield return new Indometh(30, 3, 4, 0.12);
                yield return new Indometh(31, 3, 5, 0.11);
                yield return new Indometh(32, 3, 6, 0.08);
                yield return new Indometh(33, 3, 8, 0.08);
                yield return new Indometh(34, 4, 0.25, 1.85);
                yield return new Indometh(35, 4, 0.5, 1.39);
                yield return new Indometh(36, 4, 0.75, 1.02);
                yield return new Indometh(37, 4, 1, 0.89);
                yield return new Indometh(38, 4, 1.25, 0.59);
                yield return new Indometh(39, 4, 2, 0.4);
                yield return new Indometh(40, 4, 3, 0.16);
                yield return new Indometh(41, 4, 4, 0.11);
                yield return new Indometh(42, 4, 5, 0.1);
                yield return new Indometh(43, 4, 6, 0.07);
                yield return new Indometh(44, 4, 8, 0.07);
                yield return new Indometh(45, 5, 0.25, 2.05);
                yield return new Indometh(46, 5, 0.5, 1.04);
                yield return new Indometh(47, 5, 0.75, 0.81);
                yield return new Indometh(48, 5, 1, 0.39);
                yield return new Indometh(49, 5, 1.25, 0.3);
                yield return new Indometh(50, 5, 2, 0.23);
                yield return new Indometh(51, 5, 3, 0.13);
                yield return new Indometh(52, 5, 4, 0.11);
                yield return new Indometh(53, 5, 5, 0.08);
                yield return new Indometh(54, 5, 6, 0.1);
                yield return new Indometh(55, 5, 8, 0.06);
                yield return new Indometh(56, 6, 0.25, 2.31);
                yield return new Indometh(57, 6, 0.5, 1.44);
                yield return new Indometh(58, 6, 0.75, 1.03);
                yield return new Indometh(59, 6, 1, 0.84);
                yield return new Indometh(60, 6, 1.25, 0.64);
                yield return new Indometh(61, 6, 2, 0.42);
                yield return new Indometh(62, 6, 3, 0.24);
                yield return new Indometh(63, 6, 4, 0.17);
                yield return new Indometh(64, 6, 5, 0.13);
                yield return new Indometh(65, 6, 6, 0.1);
                yield return new Indometh(66, 6, 8, 0.09);
            }
        }
    }
}
