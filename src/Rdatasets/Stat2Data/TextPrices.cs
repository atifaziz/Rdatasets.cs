// ReSharper disable All

namespace Rdatasets.Stat2Data
{
    using System.Collections.Generic;

    /// <summary>
    /// Text Prices
    /// </summary>

    public class TextPrices
    {
        public readonly int Pages;
        public readonly double Price;

        public TextPrices(int Pages, double Price)
        {
            this.Pages = Pages;
            this.Price = Price;
        }

        public static IEnumerable<TextPrices> Data
        {
            get
            {
                yield return new TextPrices(600, 95);
                yield return new TextPrices(91, 19.95);
                yield return new TextPrices(200, 51.5);
                yield return new TextPrices(400, 128.5);
                yield return new TextPrices(521, 96);
                yield return new TextPrices(315, 48.5);
                yield return new TextPrices(800, 146.75);
                yield return new TextPrices(800, 92);
                yield return new TextPrices(600, 19.5);
                yield return new TextPrices(488, 85.5);
                yield return new TextPrices(150, 16.95);
                yield return new TextPrices(140, 9.95);
                yield return new TextPrices(194, 5.95);
                yield return new TextPrices(425, 58.75);
                yield return new TextPrices(51, 6.5);
                yield return new TextPrices(930, 70.75);
                yield return new TextPrices(57, 4.25);
                yield return new TextPrices(900, 115.25);
                yield return new TextPrices(746, 158);
                yield return new TextPrices(104, 6.5);
                yield return new TextPrices(696, 130.5);
                yield return new TextPrices(294, 7);
                yield return new TextPrices(526, 41.25);
                yield return new TextPrices(1060, 169.75);
                yield return new TextPrices(502, 71.25);
                yield return new TextPrices(590, 82.25);
                yield return new TextPrices(336, 12.95);
                yield return new TextPrices(816, 127);
                yield return new TextPrices(356, 41.5);
                yield return new TextPrices(248, 31);
            }
        }
    }
}
