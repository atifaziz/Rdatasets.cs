// ReSharper disable All

namespace Rdatasets.fpp2
{
    using System.Collections.Generic;

    /// <summary>
    /// Insurance quotations and advertising expenditure.
    /// </summary>

    public class insurance
    {
        public readonly double Quotes;
        public readonly double TV_advert;

        public insurance(double Quotes, double TV_advert)
        {
            this.Quotes = Quotes;
            this.TV_advert = TV_advert;
        }

        public static IEnumerable<insurance> Data
        {
            get
            {
                yield return new insurance(12.97065, 7.212725);
                yield return new insurance(15.38714, 9.44357);
                yield return new insurance(13.22957, 7.53425);
                yield return new insurance(12.97065, 7.212725);
                yield return new insurance(15.38714, 9.44357);
                yield return new insurance(11.72288, 6.415215);
                yield return new insurance(10.06177, 5.80699);
                yield return new insurance(10.82279, 6.2036);
                yield return new insurance(13.28707, 7.58643);
                yield return new insurance(14.57832, 8.004935);
                yield return new insurance(15.60542, 8.83498);
                yield return new insurance(15.93515, 8.957255);
                yield return new insurance(16.99486, 9.53299);
                yield return new insurance(16.87821, 9.39295);
                yield return new insurance(16.45128, 8.91856);
                yield return new insurance(15.28118, 8.37412);
                yield return new insurance(15.88901, 9.844505);
                yield return new insurance(15.67747, 9.84939);
                yield return new insurance(13.2878, 8.40273);
                yield return new insurance(12.64484, 7.920675);
                yield return new insurance(11.82771, 7.436085);
                yield return new insurance(9.69184, 6.34049);
                yield return new insurance(10.30415, 6.939995);
                yield return new insurance(11.38253, 6.9771);
                yield return new insurance(12.95149, 8.010201);
                yield return new insurance(13.63092, 9.56546);
                yield return new insurance(9.12098, 6.27251);
                yield return new insurance(8.39468, 5.707495);
                yield return new insurance(12.30076, 7.96354);
                yield return new insurance(13.84831, 8.494221);
                yield return new insurance(15.96246, 9.789085);
                yield return new insurance(14.19738, 8.692825);
                yield return new insurance(12.85922, 8.05723);
                yield return new insurance(12.08837, 7.588995);
                yield return new insurance(12.93375, 8.244881);
                yield return new insurance(11.72235, 6.67554);
                yield return new insurance(15.47126, 9.219604);
                yield return new insurance(18.43898, 10.9638);
                yield return new insurance(17.49186, 10.45629);
                yield return new insurance(14.49168, 8.7286);
            }
        }
    }
}
