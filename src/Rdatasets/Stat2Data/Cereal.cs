// ReSharper disable All

namespace Rdatasets.Stat2Data
{
    using System.Collections.Generic;

    /// <summary>
    /// Cereal
    /// </summary>

    public class Cereal
    {
        public readonly string Cereal_;
        public readonly double Calories;
        public readonly double Sugar;
        public readonly double Fiber;

        public Cereal(string Cereal_, double Calories, double Sugar, double Fiber)
        {
            this.Cereal_ = Cereal_;
            this.Calories = Calories;
            this.Sugar = Sugar;
            this.Fiber = Fiber;
        }

        public static IEnumerable<Cereal> Data
        {
            get
            {
                yield return new Cereal("Common Sense Oat Bran", 100, 6, 3);
                yield return new Cereal("Product 19", 100, 3, 1);
                yield return new Cereal("All Bran Xtra Fiber", 50, 0, 14);
                yield return new Cereal("Just Right", 140, 9, 2);
                yield return new Cereal("Original Oat Bran", 70, 5, 10);
                yield return new Cereal("Heartwise", 90, 5, 6);
                yield return new Cereal("Special K", 110, 3, 0);
                yield return new Cereal("Oatbake Raisin Nut", 110, 8, 2);
                yield return new Cereal("Kenmei Rice Bran", 150, 9, 2);
                yield return new Cereal("Nutri Grain", 100, 2, 3);
                yield return new Cereal("Shredded Wheat Squares", 90, 5, 3);
                yield return new Cereal("Oatmeal raisin Crisp", 110, 6, 1);
                yield return new Cereal("hole Wheat Total", 100, 3, 3);
                yield return new Cereal("Cheerios", 110, 1, 2);
                yield return new Cereal("Total Raisin Bran", 86.7, 9.3, 3.3);
                yield return new Cereal("Wheaties", 100, 3, 3);
                yield return new Cereal("Raisin Nut Bran", 110, 8, 3);
                yield return new Cereal("Wheat Chex", 100, 3, 2);
                yield return new Cereal("Batman", 110, 10, 0);
                yield return new Cereal("Ninja Turtles", 110, 13, 0);
                yield return new Cereal("Capt. Crunch", 120, 12, 0);
                yield return new Cereal("Trix", 110, 12, 0);
                yield return new Cereal("Frosted Flakes", 110, 11, 0);
                yield return new Cereal("Honey Smacks", 110, 15, 1);
                yield return new Cereal("Froot Loops", 110, 13, 1);
                yield return new Cereal("Puffed Rice", 100, 0, 0);
                yield return new Cereal("Mueslix Crispy Blend", 160, 13, 3);
                yield return new Cereal("Uncle Sam", 110, 0, 7);
                yield return new Cereal("100% Bran", 70, 6, 10);
                yield return new Cereal("Fruit & Fiber", 96, 6.4, 4);
                yield return new Cereal("Bran Flakes", 90, 5, 5);
                yield return new Cereal("Bran Buds", 70, 1, 8);
                yield return new Cereal("Fruit'n Oat Bran", 110, 0, 4);
                yield return new Cereal("Fruit'n Oat Bran Crunch", 60, 0, 13);
                yield return new Cereal("Hodgson's Mill Wheat", 108, 0, 4);
                yield return new Cereal("Hodgson's Mill Oat Bran", 77, 0, 6);
            }
        }
    }
}
