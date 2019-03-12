// ReSharper disable All

namespace Rdatasets.MASS
{
    using System.Collections.Generic;

    /// <summary>
    /// Effect of Calcium Chloride on Muscle Contraction in Rat Hearts
    /// </summary>

    public class muscle
    {
        public readonly int κ;
        public readonly string Strip;
        public readonly double Conc;
        public readonly double Length;

        public muscle(int κ, string Strip, double Conc, double Length)
        {
            this.κ = κ;
            this.Strip = Strip;
            this.Conc = Conc;
            this.Length = Length;
        }

        public static IEnumerable<muscle> Data
        {
            get
            {
                yield return new muscle(3, "S01", 1, 15.8);
                yield return new muscle(4, "S01", 2, 20.8);
                yield return new muscle(5, "S01", 3, 22.6);
                yield return new muscle(6, "S01", 4, 23.8);
                yield return new muscle(9, "S02", 1, 20.6);
                yield return new muscle(10, "S02", 2, 26.8);
                yield return new muscle(11, "S02", 3, 28.4);
                yield return new muscle(12, "S02", 4, 27);
                yield return new muscle(13, "S03", 0.25, 7.2);
                yield return new muscle(14, "S03", 0.5, 15.4);
                yield return new muscle(15, "S03", 1, 22.8);
                yield return new muscle(16, "S03", 2, 27.4);
                yield return new muscle(19, "S04", 0.25, 2.2);
                yield return new muscle(20, "S04", 0.5, 9);
                yield return new muscle(21, "S04", 1, 16.6);
                yield return new muscle(25, "S05", 0.25, 2);
                yield return new muscle(26, "S05", 0.5, 6);
                yield return new muscle(27, "S05", 1, 15.2);
                yield return new muscle(31, "S06", 0.25, 5);
                yield return new muscle(32, "S06", 0.5, 9.2);
                yield return new muscle(33, "S06", 1, 14.2);
                yield return new muscle(39, "S07", 1, 28);
                yield return new muscle(40, "S07", 2, 32);
                yield return new muscle(43, "S08", 0.25, 5.6);
                yield return new muscle(45, "S08", 1, 26);
                yield return new muscle(50, "S09", 0.5, 15.4);
                yield return new muscle(51, "S09", 1, 23.2);
                yield return new muscle(55, "S10", 0.25, 11.8);
                yield return new muscle(57, "S10", 1, 29);
                yield return new muscle(61, "S11", 0.25, 11);
                yield return new muscle(62, "S11", 0.5, 18.8);
                yield return new muscle(63, "S11", 1, 26.2);
                yield return new muscle(69, "S12", 1, 26);
                yield return new muscle(70, "S12", 2, 33.8);
                yield return new muscle(75, "S13", 1, 24.2);
                yield return new muscle(76, "S13", 2, 28.8);
                yield return new muscle(80, "S14", 0.5, 15);
                yield return new muscle(81, "S14", 1, 24);
                yield return new muscle(86, "S15", 0.5, 20.8);
                yield return new muscle(87, "S15", 1, 29);
                yield return new muscle(93, "S16", 1, 18.2);
                yield return new muscle(94, "S16", 2, 25.8);
                yield return new muscle(95, "S16", 3, 30);
                yield return new muscle(96, "S16", 4, 32.2);
                yield return new muscle(99, "S17", 1, 21.5);
                yield return new muscle(100, "S17", 2, 28.4);
                yield return new muscle(101, "S17", 3, 32);
                yield return new muscle(102, "S17", 4, 29.6);
                yield return new muscle(105, "S18", 1, 15.4);
                yield return new muscle(106, "S18", 2, 19);
                yield return new muscle(107, "S18", 3, 19.4);
                yield return new muscle(111, "S19", 1, 29);
                yield return new muscle(112, "S19", 2, 34);
                yield return new muscle(113, "S19", 3, 37);
                yield return new muscle(117, "S20", 1, 22.2);
                yield return new muscle(118, "S20", 2, 29);
                yield return new muscle(119, "S20", 3, 32.2);
                yield return new muscle(123, "S21", 1, 23);
                yield return new muscle(124, "S21", 2, 27.4);
                yield return new muscle(125, "S21", 3, 30.4);
            }
        }
    }
}
