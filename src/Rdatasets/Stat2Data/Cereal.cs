// ReSharper disable All

namespace Rdatasets.Stat2Data
{
    using System.Collections.Generic;

    /// <summary>
    /// Cereal
    /// </summary>

    public class Cereal
    {
        public readonly int κ;
        public readonly string Cereal_;
        public readonly double Calories;
        public readonly double Sugar;
        public readonly double Fiber;

        public Cereal(int κ, string Cereal_, double Calories, double Sugar, double Fiber)
        {
            this.κ = κ;
            this.Cereal_ = Cereal_;
            this.Calories = Calories;
            this.Sugar = Sugar;
            this.Fiber = Fiber;
        }

        public static IEnumerable<Cereal> Data
        {
            get
            {
                yield return new Cereal(1, "Common Sense Oat Bran", 100, 6, 3);
                yield return new Cereal(2, "Product 19", 100, 3, 1);
                yield return new Cereal(3, "All Bran Xtra Fiber", 50, 0, 14);
                yield return new Cereal(4, "Just Right", 140, 9, 2);
                yield return new Cereal(5, "Original Oat Bran", 70, 5, 10);
                yield return new Cereal(6, "Heartwise", 90, 5, 6);
                yield return new Cereal(7, "Special K", 110, 3, 0);
                yield return new Cereal(8, "Oatbake Raisin Nut", 110, 8, 2);
                yield return new Cereal(9, "Kenmei Rice Bran", 150, 9, 2);
                yield return new Cereal(10, "Nutri Grain", 100, 2, 3);
                yield return new Cereal(11, "Shredded Wheat Squares", 90, 5, 3);
                yield return new Cereal(12, "Oatmeal raisin Crisp", 110, 6, 1);
                yield return new Cereal(13, "hole Wheat Total", 100, 3, 3);
                yield return new Cereal(14, "Cheerios", 110, 1, 2);
                yield return new Cereal(15, "Total Raisin Bran", 86.7, 9.3, 3.3);
                yield return new Cereal(16, "Wheaties", 100, 3, 3);
                yield return new Cereal(17, "Raisin Nut Bran", 110, 8, 3);
                yield return new Cereal(18, "Wheat Chex", 100, 3, 2);
                yield return new Cereal(19, "Batman", 110, 10, 0);
                yield return new Cereal(20, "Ninja Turtles", 110, 13, 0);
                yield return new Cereal(21, "Capt. Crunch", 120, 12, 0);
                yield return new Cereal(22, "Trix", 110, 12, 0);
                yield return new Cereal(23, "Frosted Flakes", 110, 11, 0);
                yield return new Cereal(24, "Honey Smacks", 110, 15, 1);
                yield return new Cereal(25, "Froot Loops", 110, 13, 1);
                yield return new Cereal(26, "Puffed Rice", 100, 0, 0);
                yield return new Cereal(27, "Mueslix Crispy Blend", 160, 13, 3);
                yield return new Cereal(28, "Uncle Sam", 110, 0, 7);
                yield return new Cereal(29, "100% Bran", 70, 6, 10);
                yield return new Cereal(30, "Fruit & Fiber", 96, 6.4, 4);
                yield return new Cereal(31, "Bran Flakes", 90, 5, 5);
                yield return new Cereal(32, "Bran Buds", 70, 1, 8);
                yield return new Cereal(33, "Fruit'n Oat Bran", 110, 0, 4);
                yield return new Cereal(34, "Fruit'n Oat Bran Crunch", 60, 0, 13);
                yield return new Cereal(35, "Hodgson's Mill Wheat", 108, 0, 4);
                yield return new Cereal(36, "Hodgson's Mill Oat Bran", 77, 0, 6);
            }
        }
    }
}
