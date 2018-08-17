// ReSharper disable All

namespace Rdatasets.Stat2Data
{
    using System.Collections.Generic;

    /// <summary>
    /// Grocery
    /// </summary>

    public class Grocery
    {
        public readonly string Discount;
        public readonly int Store;
        public readonly string Display;
        public readonly int Sales;
        public readonly double Price;

        public Grocery(string Discount, int Store, string Display, int Sales, double Price)
        {
            this.Discount = Discount;
            this.Store = Store;
            this.Display = Display;
            this.Sales = Sales;
            this.Price = Price;
        }

        public static IEnumerable<Grocery> Data
        {
            get
            {
                yield return new Grocery("5.00%", 1, "Featured End of Aisl", 240, 8.96);
                yield return new Grocery("5.00%", 1, "Featured Middle of A", 264, 9.19);
                yield return new Grocery("5.00%", 1, "Not Featured", 192, 8.46);
                yield return new Grocery("5.00%", 2, "Featured End of Aisl", 216, 8.58);
                yield return new Grocery("5.00%", 2, "Featured Middle of A", 174, 8.31);
                yield return new Grocery("5.00%", 2, "Not Featured", 264, 9.3);
                yield return new Grocery("5.00%", 3, "Featured End of Aisl", 176, 8.04);
                yield return new Grocery("5.00%", 3, "Featured Middle of A", 220, 8.8);
                yield return new Grocery("5.00%", 3, "Not Featured", 171, 8.03);
                yield return new Grocery("5.00%", 4, "Featured End of Aisl", 199, 8.39);
                yield return new Grocery("5.00%", 4, "Featured Middle of A", 180, 8.17);
                yield return new Grocery("5.00%", 4, "Not Featured", 146, 7.76);
                yield return new Grocery("10.00%", 5, "Featured End of Aisl", 244, 8.91);
                yield return new Grocery("10.00%", 5, "Featured Middle of A", 173, 8.07);
                yield return new Grocery("10.00%", 5, "Not Featured", 225, 8.76);
                yield return new Grocery("10.00%", 6, "Featured End of Aisl", 252, 8.99);
                yield return new Grocery("10.00%", 6, "Featured Middle of A", 192, 8.29);
                yield return new Grocery("10.00%", 6, "Not Featured", 270, 9.25);
                yield return new Grocery("10.00%", 7, "Featured End of Aisl", 202, 8.37);
                yield return new Grocery("10.00%", 7, "Featured Middle of A", 261, 9.15);
                yield return new Grocery("10.00%", 7, "Not Featured", 225, 8.64);
                yield return new Grocery("10.00%", 8, "Featured End of Aisl", 179, 8.06);
                yield return new Grocery("10.00%", 8, "Featured Middle of A", 222, 8.59);
                yield return new Grocery("10.00%", 8, "Not Featured", 168, 8.03);
                yield return new Grocery("15.00%", 9, "Featured End of Aisl", 234, 8.73);
                yield return new Grocery("15.00%", 9, "Featured Middle of A", 233, 8.78);
                yield return new Grocery("15.00%", 9, "Not Featured", 162, 7.91);
                yield return new Grocery("15.00%", 10, "Featured End of Aisl", 220, 8.49);
                yield return new Grocery("15.00%", 10, "Featured Middle of A", 209, 8.41);
                yield return new Grocery("15.00%", 10, "Not Featured", 258, 9.02);
                yield return new Grocery("15.00%", 11, "Featured End of Aisl", 215, 8.5);
                yield return new Grocery("15.00%", 11, "Featured Middle of A", 199, 8.22);
                yield return new Grocery("15.00%", 11, "Not Featured", 242, 8.82);
                yield return new Grocery("15.00%", 12, "Featured End of Aisl", 179, 8.11);
                yield return new Grocery("15.00%", 12, "Featured Middle of A", 206, 8.37);
                yield return new Grocery("15.00%", 12, "Not Featured", 206, 8.42);
            }
        }
    }
}
