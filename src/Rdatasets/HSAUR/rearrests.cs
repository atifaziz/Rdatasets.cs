// ReSharper disable All

namespace Rdatasets.HSAUR
{
    using System.Collections.Generic;

    /// <summary>
    /// Rearrests of Juvenile Felons
    /// </summary>

    public class rearrests
    {
        public readonly string Adult_court;
        public readonly string Juvenile_court;
        public readonly int Freq;

        public rearrests(string Adult_court, string Juvenile_court, int Freq)
        {
            this.Adult_court = Adult_court;
            this.Juvenile_court = Juvenile_court;
            this.Freq = Freq;
        }

        public static IEnumerable<rearrests> Data
        {
            get
            {
                yield return new rearrests("Rearrest", "Rearrest", 158);
                yield return new rearrests("No rearrest", "Rearrest", 290);
                yield return new rearrests("Rearrest", "No rearrest", 515);
                yield return new rearrests("No rearrest", "No rearrest", 1134);
            }
        }
    }
}
