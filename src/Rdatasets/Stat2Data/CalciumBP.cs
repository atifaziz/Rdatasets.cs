// ReSharper disable All

namespace Rdatasets.Stat2Data
{
    using System.Collections.Generic;

    /// <summary>
    /// CalciumBP
    /// </summary>

    public class CalciumBP
    {
        public readonly string Treatment;
        public readonly int Decrease;

        public CalciumBP(string Treatment, int Decrease)
        {
            this.Treatment = Treatment;
            this.Decrease = Decrease;
        }

        public static IEnumerable<CalciumBP> Data
        {
            get
            {
                yield return new CalciumBP("Calcium", 7);
                yield return new CalciumBP("Calcium", -4);
                yield return new CalciumBP("Calcium", 18);
                yield return new CalciumBP("Calcium", 17);
                yield return new CalciumBP("Calcium", -3);
                yield return new CalciumBP("Calcium", -5);
                yield return new CalciumBP("Calcium", 1);
                yield return new CalciumBP("Calcium", 10);
                yield return new CalciumBP("Calcium", 11);
                yield return new CalciumBP("Calcium", -2);
                yield return new CalciumBP("Placebo", -1);
                yield return new CalciumBP("Placebo", 12);
                yield return new CalciumBP("Placebo", -1);
                yield return new CalciumBP("Placebo", -3);
                yield return new CalciumBP("Placebo", 3);
                yield return new CalciumBP("Placebo", -5);
                yield return new CalciumBP("Placebo", 5);
                yield return new CalciumBP("Placebo", 2);
                yield return new CalciumBP("Placebo", -11);
                yield return new CalciumBP("Placebo", 1);
                yield return new CalciumBP("Placebo", -3);
            }
        }
    }
}
