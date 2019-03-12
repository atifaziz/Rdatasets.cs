// ReSharper disable All

namespace Rdatasets.datasets
{
    using System.Collections.Generic;

    /// <summary>
    /// Hair and Eye Color of Statistics Students
    /// </summary>

    public class HairEyeColor
    {
        public readonly int κ;
        public readonly string Hair;
        public readonly string Eye;
        public readonly string Sex;
        public readonly int Freq;

        public HairEyeColor(int κ, string Hair, string Eye, string Sex, int Freq)
        {
            this.κ = κ;
            this.Hair = Hair;
            this.Eye = Eye;
            this.Sex = Sex;
            this.Freq = Freq;
        }

        public static IEnumerable<HairEyeColor> Data
        {
            get
            {
                yield return new HairEyeColor(1, "Black", "Brown", "Male", 32);
                yield return new HairEyeColor(2, "Brown", "Brown", "Male", 53);
                yield return new HairEyeColor(3, "Red", "Brown", "Male", 10);
                yield return new HairEyeColor(4, "Blond", "Brown", "Male", 3);
                yield return new HairEyeColor(5, "Black", "Blue", "Male", 11);
                yield return new HairEyeColor(6, "Brown", "Blue", "Male", 50);
                yield return new HairEyeColor(7, "Red", "Blue", "Male", 10);
                yield return new HairEyeColor(8, "Blond", "Blue", "Male", 30);
                yield return new HairEyeColor(9, "Black", "Hazel", "Male", 10);
                yield return new HairEyeColor(10, "Brown", "Hazel", "Male", 25);
                yield return new HairEyeColor(11, "Red", "Hazel", "Male", 7);
                yield return new HairEyeColor(12, "Blond", "Hazel", "Male", 5);
                yield return new HairEyeColor(13, "Black", "Green", "Male", 3);
                yield return new HairEyeColor(14, "Brown", "Green", "Male", 15);
                yield return new HairEyeColor(15, "Red", "Green", "Male", 7);
                yield return new HairEyeColor(16, "Blond", "Green", "Male", 8);
                yield return new HairEyeColor(17, "Black", "Brown", "Female", 36);
                yield return new HairEyeColor(18, "Brown", "Brown", "Female", 66);
                yield return new HairEyeColor(19, "Red", "Brown", "Female", 16);
                yield return new HairEyeColor(20, "Blond", "Brown", "Female", 4);
                yield return new HairEyeColor(21, "Black", "Blue", "Female", 9);
                yield return new HairEyeColor(22, "Brown", "Blue", "Female", 34);
                yield return new HairEyeColor(23, "Red", "Blue", "Female", 7);
                yield return new HairEyeColor(24, "Blond", "Blue", "Female", 64);
                yield return new HairEyeColor(25, "Black", "Hazel", "Female", 5);
                yield return new HairEyeColor(26, "Brown", "Hazel", "Female", 29);
                yield return new HairEyeColor(27, "Red", "Hazel", "Female", 7);
                yield return new HairEyeColor(28, "Blond", "Hazel", "Female", 5);
                yield return new HairEyeColor(29, "Black", "Green", "Female", 2);
                yield return new HairEyeColor(30, "Brown", "Green", "Female", 14);
                yield return new HairEyeColor(31, "Red", "Green", "Female", 7);
                yield return new HairEyeColor(32, "Blond", "Green", "Female", 8);
            }
        }
    }
}
