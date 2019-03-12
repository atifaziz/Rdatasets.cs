// ReSharper disable All

namespace Rdatasets.vcd
{
    using System.Collections.Generic;

    /// <summary>
    /// Hospital data
    /// </summary>

    public class Hospital
    {
        public readonly int κ;
        public readonly string Visit_frequency;
        public readonly string Length_of_stay;
        public readonly int Freq;

        public Hospital(int κ, string Visit_frequency, string Length_of_stay, int Freq)
        {
            this.κ = κ;
            this.Visit_frequency = Visit_frequency;
            this.Length_of_stay = Length_of_stay;
            this.Freq = Freq;
        }

        public static IEnumerable<Hospital> Data
        {
            get
            {
                yield return new Hospital(1, "Regular", "2-9", 43);
                yield return new Hospital(2, "Less than monthly", "2-9", 6);
                yield return new Hospital(3, "Never", "2-9", 9);
                yield return new Hospital(4, "Regular", "10-19", 16);
                yield return new Hospital(5, "Less than monthly", "10-19", 11);
                yield return new Hospital(6, "Never", "10-19", 18);
                yield return new Hospital(7, "Regular", "20+", 3);
                yield return new Hospital(8, "Less than monthly", "20+", 10);
                yield return new Hospital(9, "Never", "20+", 16);
            }
        }
    }
}
