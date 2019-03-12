// ReSharper disable All

namespace Rdatasets.drc
{
    using System.Collections.Generic;

    /// <summary>
    /// Leaf length of barley
    /// </summary>

    public class leaflength
    {
        public readonly int κ;
        public readonly double Dose;
        public readonly double DW;

        public leaflength(int κ, double Dose, double DW)
        {
            this.κ = κ;
            this.Dose = Dose;
            this.DW = DW;
        }

        public static IEnumerable<leaflength> Data
        {
            get
            {
                yield return new leaflength(1, 0, 8);
                yield return new leaflength(2, 0, 13.5);
                yield return new leaflength(3, 0, 11);
                yield return new leaflength(4, 0, 7);
                yield return new leaflength(5, 0, 10);
                yield return new leaflength(6, 0, 6);
                yield return new leaflength(7, 0.01, 29);
                yield return new leaflength(8, 0.01, 15);
                yield return new leaflength(9, 0.01, 10);
                yield return new leaflength(10, 0.01, 20);
                yield return new leaflength(11, 0.01, 20);
                yield return new leaflength(12, 0.01, 22);
                yield return new leaflength(13, 0.1, 17);
                yield return new leaflength(14, 0.1, 20);
                yield return new leaflength(15, 0.1, 18);
                yield return new leaflength(16, 0.1, 23);
                yield return new leaflength(17, 0.1, 24);
                yield return new leaflength(18, 0.1, 20);
                yield return new leaflength(19, 1, 15);
                yield return new leaflength(20, 1, 22);
                yield return new leaflength(21, 1, 16);
                yield return new leaflength(22, 1, 14);
                yield return new leaflength(23, 1, 22);
                yield return new leaflength(24, 1, 21);
                yield return new leaflength(25, 10, 15);
                yield return new leaflength(26, 10, 9);
                yield return new leaflength(27, 10, 12);
                yield return new leaflength(28, 10, 9);
                yield return new leaflength(29, 10, 9);
                yield return new leaflength(30, 10, 11);
                yield return new leaflength(31, 100, 3);
                yield return new leaflength(32, 100, 2);
                yield return new leaflength(33, 100, 4);
                yield return new leaflength(34, 100, 8);
                yield return new leaflength(35, 100, 7);
                yield return new leaflength(36, 100, 12);
                yield return new leaflength(37, 1000, 0.1);
                yield return new leaflength(38, 1000, 2);
                yield return new leaflength(39, 1000, 0.1);
                yield return new leaflength(40, 1000, 1);
                yield return new leaflength(41, 1000, 3);
                yield return new leaflength(42, 1000, 2);
            }
        }
    }
}
