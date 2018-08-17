// ReSharper disable All

namespace Rdatasets.datasets
{
    using System.Collections.Generic;

    /// <summary>
    /// Hair and Eye Color of Statistics Students
    /// </summary>

    public class HairEyeColor
    {
        public readonly string Hair;
        public readonly string Eye;
        public readonly string Sex;
        public readonly int Freq;

        public HairEyeColor(string Hair, string Eye, string Sex, int Freq)
        {
            this.Hair = Hair;
            this.Eye = Eye;
            this.Sex = Sex;
            this.Freq = Freq;
        }

        public static IEnumerable<HairEyeColor> Data
        {
            get
            {
                yield return new HairEyeColor("Black", "Brown", "Male", 32);
                yield return new HairEyeColor("Brown", "Brown", "Male", 53);
                yield return new HairEyeColor("Red", "Brown", "Male", 10);
                yield return new HairEyeColor("Blond", "Brown", "Male", 3);
                yield return new HairEyeColor("Black", "Blue", "Male", 11);
                yield return new HairEyeColor("Brown", "Blue", "Male", 50);
                yield return new HairEyeColor("Red", "Blue", "Male", 10);
                yield return new HairEyeColor("Blond", "Blue", "Male", 30);
                yield return new HairEyeColor("Black", "Hazel", "Male", 10);
                yield return new HairEyeColor("Brown", "Hazel", "Male", 25);
                yield return new HairEyeColor("Red", "Hazel", "Male", 7);
                yield return new HairEyeColor("Blond", "Hazel", "Male", 5);
                yield return new HairEyeColor("Black", "Green", "Male", 3);
                yield return new HairEyeColor("Brown", "Green", "Male", 15);
                yield return new HairEyeColor("Red", "Green", "Male", 7);
                yield return new HairEyeColor("Blond", "Green", "Male", 8);
                yield return new HairEyeColor("Black", "Brown", "Female", 36);
                yield return new HairEyeColor("Brown", "Brown", "Female", 66);
                yield return new HairEyeColor("Red", "Brown", "Female", 16);
                yield return new HairEyeColor("Blond", "Brown", "Female", 4);
                yield return new HairEyeColor("Black", "Blue", "Female", 9);
                yield return new HairEyeColor("Brown", "Blue", "Female", 34);
                yield return new HairEyeColor("Red", "Blue", "Female", 7);
                yield return new HairEyeColor("Blond", "Blue", "Female", 64);
                yield return new HairEyeColor("Black", "Hazel", "Female", 5);
                yield return new HairEyeColor("Brown", "Hazel", "Female", 29);
                yield return new HairEyeColor("Red", "Hazel", "Female", 7);
                yield return new HairEyeColor("Blond", "Hazel", "Female", 5);
                yield return new HairEyeColor("Black", "Green", "Female", 2);
                yield return new HairEyeColor("Brown", "Green", "Female", 14);
                yield return new HairEyeColor("Red", "Green", "Female", 7);
                yield return new HairEyeColor("Blond", "Green", "Female", 8);
            }
        }
    }
}
