// ReSharper disable All

namespace Rdatasets.DAAG
{
    using System.Collections.Generic;

    /// <summary>
    /// Aranda House Prices
    /// </summary>

    public class houseprices
    {
        public readonly int κ;
        public readonly int area;
        public readonly int bedrooms;
        public readonly double sale_price;

        public houseprices(int κ, int area, int bedrooms, double sale_price)
        {
            this.κ = κ;
            this.area = area;
            this.bedrooms = bedrooms;
            this.sale_price = sale_price;
        }

        public static IEnumerable<houseprices> Data
        {
            get
            {
                yield return new houseprices(9, 694, 4, 192);
                yield return new houseprices(10, 905, 4, 215);
                yield return new houseprices(11, 802, 4, 215);
                yield return new houseprices(12, 1366, 4, 274);
                yield return new houseprices(13, 716, 4, 112.7);
                yield return new houseprices(14, 963, 4, 185);
                yield return new houseprices(15, 821, 4, 212);
                yield return new houseprices(16, 714, 4, 220);
                yield return new houseprices(17, 1018, 4, 276);
                yield return new houseprices(18, 887, 4, 260);
                yield return new houseprices(19, 790, 4, 221.5);
                yield return new houseprices(20, 696, 5, 255);
                yield return new houseprices(21, 771, 5, 260);
                yield return new houseprices(22, 1006, 5, 293);
                yield return new houseprices(23, 1191, 6, 375);
            }
        }
    }
}
