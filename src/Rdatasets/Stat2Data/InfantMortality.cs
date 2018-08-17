// ReSharper disable All

namespace Rdatasets.Stat2Data
{
    using System.Collections.Generic;

    /// <summary>
    /// InfantMortality
    /// </summary>

    public class InfantMortality
    {
        public readonly double Mortality;
        public readonly int Year;

        public InfantMortality(double Mortality, int Year)
        {
            this.Mortality = Mortality;
            this.Year = Year;
        }

        public static IEnumerable<InfantMortality> Data
        {
            get
            {
                yield return new InfantMortality(85.8, 1920);
                yield return new InfantMortality(64.6, 1930);
                yield return new InfantMortality(47, 1940);
                yield return new InfantMortality(29.2, 1950);
                yield return new InfantMortality(26, 1960);
                yield return new InfantMortality(20, 1970);
                yield return new InfantMortality(12.6, 1980);
                yield return new InfantMortality(9.2, 1990);
                yield return new InfantMortality(6.9, 2000);
            }
        }
    }
}
