// ReSharper disable All

namespace Rdatasets.vcd
{
    using System.Collections.Generic;

    /// <summary>
    /// Breathlessness and Wheeze in Coal Miners
    /// </summary>

    public class CoalMiners
    {
        public readonly int κ;
        public readonly string Breathlessness;
        public readonly string Wheeze;
        public readonly string Age;
        public readonly int Freq;

        public CoalMiners(int κ, string Breathlessness, string Wheeze, string Age, int Freq)
        {
            this.κ = κ;
            this.Breathlessness = Breathlessness;
            this.Wheeze = Wheeze;
            this.Age = Age;
            this.Freq = Freq;
        }

        public static IEnumerable<CoalMiners> Data
        {
            get
            {
                yield return new CoalMiners(1, "B", "W", "20-24", 9);
                yield return new CoalMiners(2, "NoB", "W", "20-24", 95);
                yield return new CoalMiners(3, "B", "NoW", "20-24", 7);
                yield return new CoalMiners(4, "NoB", "NoW", "20-24", 1841);
                yield return new CoalMiners(5, "B", "W", "25-29", 23);
                yield return new CoalMiners(6, "NoB", "W", "25-29", 105);
                yield return new CoalMiners(7, "B", "NoW", "25-29", 9);
                yield return new CoalMiners(8, "NoB", "NoW", "25-29", 1654);
                yield return new CoalMiners(9, "B", "W", "30-34", 54);
                yield return new CoalMiners(10, "NoB", "W", "30-34", 177);
                yield return new CoalMiners(11, "B", "NoW", "30-34", 19);
                yield return new CoalMiners(12, "NoB", "NoW", "30-34", 1863);
                yield return new CoalMiners(13, "B", "W", "35-39", 121);
                yield return new CoalMiners(14, "NoB", "W", "35-39", 257);
                yield return new CoalMiners(15, "B", "NoW", "35-39", 48);
                yield return new CoalMiners(16, "NoB", "NoW", "35-39", 2357);
                yield return new CoalMiners(17, "B", "W", "40-44", 169);
                yield return new CoalMiners(18, "NoB", "W", "40-44", 273);
                yield return new CoalMiners(19, "B", "NoW", "40-44", 54);
                yield return new CoalMiners(20, "NoB", "NoW", "40-44", 1778);
                yield return new CoalMiners(21, "B", "W", "45-49", 269);
                yield return new CoalMiners(22, "NoB", "W", "45-49", 324);
                yield return new CoalMiners(23, "B", "NoW", "45-49", 88);
                yield return new CoalMiners(24, "NoB", "NoW", "45-49", 1712);
                yield return new CoalMiners(25, "B", "W", "50-54", 404);
                yield return new CoalMiners(26, "NoB", "W", "50-54", 245);
                yield return new CoalMiners(27, "B", "NoW", "50-54", 117);
                yield return new CoalMiners(28, "NoB", "NoW", "50-54", 1324);
                yield return new CoalMiners(29, "B", "W", "55-59", 406);
                yield return new CoalMiners(30, "NoB", "W", "55-59", 225);
                yield return new CoalMiners(31, "B", "NoW", "55-59", 152);
                yield return new CoalMiners(32, "NoB", "NoW", "55-59", 967);
                yield return new CoalMiners(33, "B", "W", "60-64", 372);
                yield return new CoalMiners(34, "NoB", "W", "60-64", 132);
                yield return new CoalMiners(35, "B", "NoW", "60-64", 106);
                yield return new CoalMiners(36, "NoB", "NoW", "60-64", 526);
            }
        }
    }
}
