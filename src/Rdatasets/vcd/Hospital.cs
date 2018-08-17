// ReSharper disable All

namespace Rdatasets.vcd
{
    using System.Collections.Generic;

    /// <summary>
    /// Hospital data
    /// </summary>

    public class Hospital
    {
        public readonly string Visit_frequency;
        public readonly string Length_of_stay;
        public readonly int Freq;

        public Hospital(string Visit_frequency, string Length_of_stay, int Freq)
        {
            this.Visit_frequency = Visit_frequency;
            this.Length_of_stay = Length_of_stay;
            this.Freq = Freq;
        }

        public static IEnumerable<Hospital> Data
        {
            get
            {
                yield return new Hospital("Regular", "2-9", 43);
                yield return new Hospital("Less than monthly", "2-9", 6);
                yield return new Hospital("Never", "2-9", 9);
                yield return new Hospital("Regular", "10-19", 16);
                yield return new Hospital("Less than monthly", "10-19", 11);
                yield return new Hospital("Never", "10-19", 18);
                yield return new Hospital("Regular", "20+", 3);
                yield return new Hospital("Less than monthly", "20+", 10);
                yield return new Hospital("Never", "20+", 16);
            }
        }
    }
}
