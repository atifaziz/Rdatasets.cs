// ReSharper disable All

namespace Rdatasets.drc
{
    using System.Collections.Generic;

    /// <summary>
    /// Leaf length of barley
    /// </summary>

    public class leaflength
    {
        public readonly double Dose;
        public readonly double DW;

        public leaflength(double Dose, double DW)
        {
            this.Dose = Dose;
            this.DW = DW;
        }

        public static IEnumerable<leaflength> Data
        {
            get
            {
                yield return new leaflength(0, 8);
                yield return new leaflength(0, 13.5);
                yield return new leaflength(0, 11);
                yield return new leaflength(0, 7);
                yield return new leaflength(0, 10);
                yield return new leaflength(0, 6);
                yield return new leaflength(0.01, 29);
                yield return new leaflength(0.01, 15);
                yield return new leaflength(0.01, 10);
                yield return new leaflength(0.01, 20);
                yield return new leaflength(0.01, 20);
                yield return new leaflength(0.01, 22);
                yield return new leaflength(0.1, 17);
                yield return new leaflength(0.1, 20);
                yield return new leaflength(0.1, 18);
                yield return new leaflength(0.1, 23);
                yield return new leaflength(0.1, 24);
                yield return new leaflength(0.1, 20);
                yield return new leaflength(1, 15);
                yield return new leaflength(1, 22);
                yield return new leaflength(1, 16);
                yield return new leaflength(1, 14);
                yield return new leaflength(1, 22);
                yield return new leaflength(1, 21);
                yield return new leaflength(10, 15);
                yield return new leaflength(10, 9);
                yield return new leaflength(10, 12);
                yield return new leaflength(10, 9);
                yield return new leaflength(10, 9);
                yield return new leaflength(10, 11);
                yield return new leaflength(100, 3);
                yield return new leaflength(100, 2);
                yield return new leaflength(100, 4);
                yield return new leaflength(100, 8);
                yield return new leaflength(100, 7);
                yield return new leaflength(100, 12);
                yield return new leaflength(1000, 0.1);
                yield return new leaflength(1000, 2);
                yield return new leaflength(1000, 0.1);
                yield return new leaflength(1000, 1);
                yield return new leaflength(1000, 3);
                yield return new leaflength(1000, 2);
            }
        }
    }
}
