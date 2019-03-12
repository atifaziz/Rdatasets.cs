// ReSharper disable All

namespace Rdatasets.Stat2Data
{
    using System.Collections.Generic;

    /// <summary>
    /// Text Prices
    /// </summary>

    public class TextPrices
    {
        public readonly int κ;
        public readonly int Pages;
        public readonly double Price;

        public TextPrices(int κ, int Pages, double Price)
        {
            this.κ = κ;
            this.Pages = Pages;
            this.Price = Price;
        }

        public static IEnumerable<TextPrices> Data
        {
            get
            {
                yield return new TextPrices(1, 600, 95);
                yield return new TextPrices(2, 91, 19.95);
                yield return new TextPrices(3, 200, 51.5);
                yield return new TextPrices(4, 400, 128.5);
                yield return new TextPrices(5, 521, 96);
                yield return new TextPrices(6, 315, 48.5);
                yield return new TextPrices(7, 800, 146.75);
                yield return new TextPrices(8, 800, 92);
                yield return new TextPrices(9, 600, 19.5);
                yield return new TextPrices(10, 488, 85.5);
                yield return new TextPrices(11, 150, 16.95);
                yield return new TextPrices(12, 140, 9.95);
                yield return new TextPrices(13, 194, 5.95);
                yield return new TextPrices(14, 425, 58.75);
                yield return new TextPrices(15, 51, 6.5);
                yield return new TextPrices(16, 930, 70.75);
                yield return new TextPrices(17, 57, 4.25);
                yield return new TextPrices(18, 900, 115.25);
                yield return new TextPrices(19, 746, 158);
                yield return new TextPrices(20, 104, 6.5);
                yield return new TextPrices(21, 696, 130.5);
                yield return new TextPrices(22, 294, 7);
                yield return new TextPrices(23, 526, 41.25);
                yield return new TextPrices(24, 1060, 169.75);
                yield return new TextPrices(25, 502, 71.25);
                yield return new TextPrices(26, 590, 82.25);
                yield return new TextPrices(27, 336, 12.95);
                yield return new TextPrices(28, 816, 127);
                yield return new TextPrices(29, 356, 41.5);
                yield return new TextPrices(30, 248, 31);
            }
        }
    }
}
