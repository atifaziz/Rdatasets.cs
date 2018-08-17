// ReSharper disable All

namespace Rdatasets.Ecdat
{
    using System.Collections.Generic;

    /// <summary>
    /// Ice Cream Consumption
    /// </summary>

    public class Icecream
    {
        public readonly double cons;
        public readonly int income;
        public readonly double price;
        public readonly int temp;

        public Icecream(double cons, int income, double price, int temp)
        {
            this.cons = cons;
            this.income = income;
            this.price = price;
            this.temp = temp;
        }

        public static IEnumerable<Icecream> Data
        {
            get
            {
                yield return new Icecream(0.386, 78, 0.27, 41);
                yield return new Icecream(0.374, 79, 0.282, 56);
                yield return new Icecream(0.393, 81, 0.277, 63);
                yield return new Icecream(0.425, 80, 0.28, 68);
                yield return new Icecream(0.406, 76, 0.272, 69);
                yield return new Icecream(0.344, 78, 0.262, 65);
                yield return new Icecream(0.327, 82, 0.275, 61);
                yield return new Icecream(0.288, 79, 0.267, 47);
                yield return new Icecream(0.269, 76, 0.265, 32);
                yield return new Icecream(0.256, 79, 0.277, 24);
                yield return new Icecream(0.286, 82, 0.282, 28);
                yield return new Icecream(0.298, 85, 0.27, 26);
                yield return new Icecream(0.329, 86, 0.272, 32);
                yield return new Icecream(0.318, 83, 0.287, 40);
                yield return new Icecream(0.381, 84, 0.277, 55);
                yield return new Icecream(0.381, 82, 0.287, 63);
                yield return new Icecream(0.47, 80, 0.28, 72);
                yield return new Icecream(0.443, 78, 0.277, 72);
                yield return new Icecream(0.386, 84, 0.277, 67);
                yield return new Icecream(0.342, 86, 0.277, 60);
                yield return new Icecream(0.319, 85, 0.292, 44);
                yield return new Icecream(0.307, 87, 0.287, 40);
                yield return new Icecream(0.284, 94, 0.277, 32);
                yield return new Icecream(0.326, 92, 0.285, 27);
                yield return new Icecream(0.309, 95, 0.282, 28);
                yield return new Icecream(0.359, 96, 0.265, 33);
                yield return new Icecream(0.376, 94, 0.265, 41);
                yield return new Icecream(0.416, 96, 0.265, 52);
                yield return new Icecream(0.437, 91, 0.268, 64);
                yield return new Icecream(0.548, 90, 0.26, 71);
            }
        }
    }
}
