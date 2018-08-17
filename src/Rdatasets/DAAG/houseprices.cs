// ReSharper disable All

namespace Rdatasets.DAAG
{
    using System.Collections.Generic;

    /// <summary>
    /// Aranda House Prices
    /// </summary>

    public class houseprices
    {
        public readonly int area;
        public readonly int bedrooms;
        public readonly double sale_price;

        public houseprices(int area, int bedrooms, double sale_price)
        {
            this.area = area;
            this.bedrooms = bedrooms;
            this.sale_price = sale_price;
        }

        public static IEnumerable<houseprices> Data
        {
            get
            {
                yield return new houseprices(694, 4, 192);
                yield return new houseprices(905, 4, 215);
                yield return new houseprices(802, 4, 215);
                yield return new houseprices(1366, 4, 274);
                yield return new houseprices(716, 4, 112.7);
                yield return new houseprices(963, 4, 185);
                yield return new houseprices(821, 4, 212);
                yield return new houseprices(714, 4, 220);
                yield return new houseprices(1018, 4, 276);
                yield return new houseprices(887, 4, 260);
                yield return new houseprices(790, 4, 221.5);
                yield return new houseprices(696, 5, 255);
                yield return new houseprices(771, 5, 260);
                yield return new houseprices(1006, 5, 293);
                yield return new houseprices(1191, 6, 375);
            }
        }
    }
}
