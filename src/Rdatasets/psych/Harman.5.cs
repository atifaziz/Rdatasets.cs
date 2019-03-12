// ReSharper disable All

namespace Rdatasets.psych
{
    using System.Collections.Generic;

    /// <summary>
    /// Five data sets from Harman (1967). 9 cognitive variables from Holzinger and 8 emotional variables from Burt
    /// </summary>

    public class Harman_5
    {
        public readonly string κ;
        public readonly int population;
        public readonly double schooling;
        public readonly int employment;
        public readonly int professional;
        public readonly int housevalue;

        public Harman_5(string κ, int population, double schooling, int employment, int professional, int housevalue)
        {
            this.κ = κ;
            this.population = population;
            this.schooling = schooling;
            this.employment = employment;
            this.professional = professional;
            this.housevalue = housevalue;
        }

        public static IEnumerable<Harman_5> Data
        {
            get
            {
                yield return new Harman_5("Tract1", 5700, 12.8, 2500, 270, 25000);
                yield return new Harman_5("Tract2", 1000, 10.9, 600, 10, 10000);
                yield return new Harman_5("Tract3", 3400, 8.8, 1000, 10, 9000);
                yield return new Harman_5("Tract4", 3800, 13.6, 1700, 140, 25000);
                yield return new Harman_5("Tract5", 4000, 12.8, 1600, 140, 25000);
                yield return new Harman_5("Tract6", 8200, 8.3, 2600, 60, 12000);
                yield return new Harman_5("Tract7", 1200, 11.4, 400, 10, 16000);
                yield return new Harman_5("Tract8", 9100, 11.5, 3300, 60, 14000);
                yield return new Harman_5("Tract9", 9900, 12.5, 3400, 180, 18000);
                yield return new Harman_5("Tract10", 9600, 13.7, 3600, 390, 25000);
                yield return new Harman_5("Tract11", 9600, 9.6, 3300, 80, 12000);
                yield return new Harman_5("Tract12", 9400, 11.4, 4000, 100, 13000);
            }
        }
    }
}
