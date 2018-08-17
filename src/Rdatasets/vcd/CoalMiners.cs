// ReSharper disable All

namespace Rdatasets.vcd
{
    using System.Collections.Generic;

    /// <summary>
    /// Breathlessness and Wheeze in Coal Miners
    /// </summary>

    public class CoalMiners
    {
        public readonly string Breathlessness;
        public readonly string Wheeze;
        public readonly string Age;
        public readonly int Freq;

        public CoalMiners(string Breathlessness, string Wheeze, string Age, int Freq)
        {
            this.Breathlessness = Breathlessness;
            this.Wheeze = Wheeze;
            this.Age = Age;
            this.Freq = Freq;
        }

        public static IEnumerable<CoalMiners> Data
        {
            get
            {
                yield return new CoalMiners("B", "W", "20-24", 9);
                yield return new CoalMiners("NoB", "W", "20-24", 95);
                yield return new CoalMiners("B", "NoW", "20-24", 7);
                yield return new CoalMiners("NoB", "NoW", "20-24", 1841);
                yield return new CoalMiners("B", "W", "25-29", 23);
                yield return new CoalMiners("NoB", "W", "25-29", 105);
                yield return new CoalMiners("B", "NoW", "25-29", 9);
                yield return new CoalMiners("NoB", "NoW", "25-29", 1654);
                yield return new CoalMiners("B", "W", "30-34", 54);
                yield return new CoalMiners("NoB", "W", "30-34", 177);
                yield return new CoalMiners("B", "NoW", "30-34", 19);
                yield return new CoalMiners("NoB", "NoW", "30-34", 1863);
                yield return new CoalMiners("B", "W", "35-39", 121);
                yield return new CoalMiners("NoB", "W", "35-39", 257);
                yield return new CoalMiners("B", "NoW", "35-39", 48);
                yield return new CoalMiners("NoB", "NoW", "35-39", 2357);
                yield return new CoalMiners("B", "W", "40-44", 169);
                yield return new CoalMiners("NoB", "W", "40-44", 273);
                yield return new CoalMiners("B", "NoW", "40-44", 54);
                yield return new CoalMiners("NoB", "NoW", "40-44", 1778);
                yield return new CoalMiners("B", "W", "45-49", 269);
                yield return new CoalMiners("NoB", "W", "45-49", 324);
                yield return new CoalMiners("B", "NoW", "45-49", 88);
                yield return new CoalMiners("NoB", "NoW", "45-49", 1712);
                yield return new CoalMiners("B", "W", "50-54", 404);
                yield return new CoalMiners("NoB", "W", "50-54", 245);
                yield return new CoalMiners("B", "NoW", "50-54", 117);
                yield return new CoalMiners("NoB", "NoW", "50-54", 1324);
                yield return new CoalMiners("B", "W", "55-59", 406);
                yield return new CoalMiners("NoB", "W", "55-59", 225);
                yield return new CoalMiners("B", "NoW", "55-59", 152);
                yield return new CoalMiners("NoB", "NoW", "55-59", 967);
                yield return new CoalMiners("B", "W", "60-64", 372);
                yield return new CoalMiners("NoB", "W", "60-64", 132);
                yield return new CoalMiners("B", "NoW", "60-64", 106);
                yield return new CoalMiners("NoB", "NoW", "60-64", 526);
            }
        }
    }
}
