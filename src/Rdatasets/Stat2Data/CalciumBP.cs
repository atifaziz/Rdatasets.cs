// ReSharper disable All

namespace Rdatasets.Stat2Data
{
    using System.Collections.Generic;

    /// <summary>
    /// CalciumBP
    /// </summary>

    public class CalciumBP
    {
        public readonly int κ;
        public readonly string Treatment;
        public readonly int Decrease;

        public CalciumBP(int κ, string Treatment, int Decrease)
        {
            this.κ = κ;
            this.Treatment = Treatment;
            this.Decrease = Decrease;
        }

        public static IEnumerable<CalciumBP> Data
        {
            get
            {
                yield return new CalciumBP(1, "Calcium", 7);
                yield return new CalciumBP(2, "Calcium", -4);
                yield return new CalciumBP(3, "Calcium", 18);
                yield return new CalciumBP(4, "Calcium", 17);
                yield return new CalciumBP(5, "Calcium", -3);
                yield return new CalciumBP(6, "Calcium", -5);
                yield return new CalciumBP(7, "Calcium", 1);
                yield return new CalciumBP(8, "Calcium", 10);
                yield return new CalciumBP(9, "Calcium", 11);
                yield return new CalciumBP(10, "Calcium", -2);
                yield return new CalciumBP(11, "Placebo", -1);
                yield return new CalciumBP(12, "Placebo", 12);
                yield return new CalciumBP(13, "Placebo", -1);
                yield return new CalciumBP(14, "Placebo", -3);
                yield return new CalciumBP(15, "Placebo", 3);
                yield return new CalciumBP(16, "Placebo", -5);
                yield return new CalciumBP(17, "Placebo", 5);
                yield return new CalciumBP(18, "Placebo", 2);
                yield return new CalciumBP(19, "Placebo", -11);
                yield return new CalciumBP(20, "Placebo", 1);
                yield return new CalciumBP(21, "Placebo", -3);
            }
        }
    }
}
