// ReSharper disable All

namespace Rdatasets.datasets
{
    using System.Collections.Generic;

    /// <summary>
    /// Death Rates in Virginia (1940)
    /// </summary>

    public class VADeaths
    {
        public readonly double Rural_Male;
        public readonly double Rural_Female;
        public readonly double Urban_Male;
        public readonly double Urban_Female;

        public VADeaths(double Rural_Male, double Rural_Female, double Urban_Male, double Urban_Female)
        {
            this.Rural_Male = Rural_Male;
            this.Rural_Female = Rural_Female;
            this.Urban_Male = Urban_Male;
            this.Urban_Female = Urban_Female;
        }

        public static IEnumerable<VADeaths> Data
        {
            get
            {
                yield return new VADeaths(11.7, 8.7, 15.4, 8.4);
                yield return new VADeaths(18.1, 11.7, 24.3, 13.6);
                yield return new VADeaths(26.9, 20.3, 37, 19.3);
                yield return new VADeaths(41, 30.9, 54.6, 35.1);
                yield return new VADeaths(66, 54.3, 71.1, 50);
            }
        }
    }
}
