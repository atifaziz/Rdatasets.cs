// ReSharper disable All

namespace Rdatasets.DAAG
{
    using System.Collections.Generic;

    /// <summary>
    /// Alcohol consumption in Australia and New Zealand
    /// </summary>

    public class grog
    {
        public readonly int κ;
        public readonly double Beer;
        public readonly double Wine;
        public readonly double Spirit;
        public readonly string Country;
        public readonly int Year;

        public grog(int κ, double Beer, double Wine, double Spirit, string Country, int Year)
        {
            this.κ = κ;
            this.Beer = Beer;
            this.Wine = Wine;
            this.Spirit = Spirit;
            this.Country = Country;
            this.Year = Year;
        }

        public static IEnumerable<grog> Data
        {
            get
            {
                yield return new grog(1, 5.24, 2.86, 1.81, "Australia", 1998);
                yield return new grog(2, 5.15, 2.87, 1.77, "Australia", 1999);
                yield return new grog(3, 5.06, 2.94, 1.88, "Australia", 2000);
                yield return new grog(4, 5.07, 2.95, 2.07, "Australia", 2001);
                yield return new grog(5, 4.8, 2.91, 1.81, "Australia", 2002);
                yield return new grog(6, 4.97, 3.01, 1.86, "Australia", 2003);
                yield return new grog(7, 4.68, 3.07, 2.06, "Australia", 2004);
                yield return new grog(8, 4.58, 3.13, 2.12, "Australia", 2005);
                yield return new grog(9, 4.57, 3.11, 2.15, "Australia", 2006);
                yield return new grog(10, 4.49995484047518, 2.59259649909302, 1.7714486604318, "NewZealand", 1998);
                yield return new grog(11, 4.28379433107245, 2.65169387971947, 1.64051178920809, "NewZealand", 1999);
                yield return new grog(12, 4.38780862118929, 2.74667996149141, 1.80251141731929, "NewZealand", 2000);
                yield return new grog(13, 4.25076364384841, 2.62968684202698, 2.04354951412461, "NewZealand", 2001);
                yield return new grog(14, 4.23134594904052, 2.77336529499246, 1.88528875596702, "NewZealand", 2002);
                yield return new grog(15, 4.21786562098825, 2.87833204197447, 2.04480233703727, "NewZealand", 2003);
                yield return new grog(16, 4.1996066148245, 2.87904802569341, 2.00834535948209, "NewZealand", 2004);
                yield return new grog(17, 4.1623257976577, 2.99934081900903, 2.22233338333326, "NewZealand", 2005);
                yield return new grog(18, 3.9594093294588, 3.08942254209033, 2.20116812845087, "NewZealand", 2006);
            }
        }
    }
}
