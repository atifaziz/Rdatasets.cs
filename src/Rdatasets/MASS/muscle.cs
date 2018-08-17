// ReSharper disable All

namespace Rdatasets.MASS
{
    using System.Collections.Generic;

    /// <summary>
    /// Effect of Calcium Chloride on Muscle Contraction in Rat Hearts
    /// </summary>

    public class muscle
    {
        public readonly string Strip;
        public readonly double Conc;
        public readonly double Length;

        public muscle(string Strip, double Conc, double Length)
        {
            this.Strip = Strip;
            this.Conc = Conc;
            this.Length = Length;
        }

        public static IEnumerable<muscle> Data
        {
            get
            {
                yield return new muscle("S01", 1, 15.8);
                yield return new muscle("S01", 2, 20.8);
                yield return new muscle("S01", 3, 22.6);
                yield return new muscle("S01", 4, 23.8);
                yield return new muscle("S02", 1, 20.6);
                yield return new muscle("S02", 2, 26.8);
                yield return new muscle("S02", 3, 28.4);
                yield return new muscle("S02", 4, 27);
                yield return new muscle("S03", 0.25, 7.2);
                yield return new muscle("S03", 0.5, 15.4);
                yield return new muscle("S03", 1, 22.8);
                yield return new muscle("S03", 2, 27.4);
                yield return new muscle("S04", 0.25, 2.2);
                yield return new muscle("S04", 0.5, 9);
                yield return new muscle("S04", 1, 16.6);
                yield return new muscle("S05", 0.25, 2);
                yield return new muscle("S05", 0.5, 6);
                yield return new muscle("S05", 1, 15.2);
                yield return new muscle("S06", 0.25, 5);
                yield return new muscle("S06", 0.5, 9.2);
                yield return new muscle("S06", 1, 14.2);
                yield return new muscle("S07", 1, 28);
                yield return new muscle("S07", 2, 32);
                yield return new muscle("S08", 0.25, 5.6);
                yield return new muscle("S08", 1, 26);
                yield return new muscle("S09", 0.5, 15.4);
                yield return new muscle("S09", 1, 23.2);
                yield return new muscle("S10", 0.25, 11.8);
                yield return new muscle("S10", 1, 29);
                yield return new muscle("S11", 0.25, 11);
                yield return new muscle("S11", 0.5, 18.8);
                yield return new muscle("S11", 1, 26.2);
                yield return new muscle("S12", 1, 26);
                yield return new muscle("S12", 2, 33.8);
                yield return new muscle("S13", 1, 24.2);
                yield return new muscle("S13", 2, 28.8);
                yield return new muscle("S14", 0.5, 15);
                yield return new muscle("S14", 1, 24);
                yield return new muscle("S15", 0.5, 20.8);
                yield return new muscle("S15", 1, 29);
                yield return new muscle("S16", 1, 18.2);
                yield return new muscle("S16", 2, 25.8);
                yield return new muscle("S16", 3, 30);
                yield return new muscle("S16", 4, 32.2);
                yield return new muscle("S17", 1, 21.5);
                yield return new muscle("S17", 2, 28.4);
                yield return new muscle("S17", 3, 32);
                yield return new muscle("S17", 4, 29.6);
                yield return new muscle("S18", 1, 15.4);
                yield return new muscle("S18", 2, 19);
                yield return new muscle("S18", 3, 19.4);
                yield return new muscle("S19", 1, 29);
                yield return new muscle("S19", 2, 34);
                yield return new muscle("S19", 3, 37);
                yield return new muscle("S20", 1, 22.2);
                yield return new muscle("S20", 2, 29);
                yield return new muscle("S20", 3, 32.2);
                yield return new muscle("S21", 1, 23);
                yield return new muscle("S21", 2, 27.4);
                yield return new muscle("S21", 3, 30.4);
            }
        }
    }
}
