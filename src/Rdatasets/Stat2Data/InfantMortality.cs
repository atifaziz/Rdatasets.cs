// ReSharper disable All

namespace Rdatasets.Stat2Data
{
    using System.Collections.Generic;

    /// <summary>
    /// InfantMortality
    /// </summary>

    public class InfantMortality
    {
        public readonly int κ;
        public readonly double Mortality;
        public readonly int Year;

        public InfantMortality(int κ, double Mortality, int Year)
        {
            this.κ = κ;
            this.Mortality = Mortality;
            this.Year = Year;
        }

        public static IEnumerable<InfantMortality> Data
        {
            get
            {
                yield return new InfantMortality(1, 85.8, 1920);
                yield return new InfantMortality(2, 64.6, 1930);
                yield return new InfantMortality(3, 47, 1940);
                yield return new InfantMortality(4, 29.2, 1950);
                yield return new InfantMortality(5, 26, 1960);
                yield return new InfantMortality(6, 20, 1970);
                yield return new InfantMortality(7, 12.6, 1980);
                yield return new InfantMortality(8, 9.2, 1990);
                yield return new InfantMortality(9, 6.9, 2000);
            }
        }
    }
}
