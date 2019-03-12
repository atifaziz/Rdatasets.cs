// ReSharper disable All

namespace Rdatasets.HSAUR
{
    using System.Collections.Generic;

    /// <summary>
    /// Total Body Composision Data
    /// </summary>

    public class agefat
    {
        public readonly int κ;
        public readonly int age;
        public readonly double fat;
        public readonly string sex;

        public agefat(int κ, int age, double fat, string sex)
        {
            this.κ = κ;
            this.age = age;
            this.fat = fat;
            this.sex = sex;
        }

        public static IEnumerable<agefat> Data
        {
            get
            {
                yield return new agefat(1, 24, 15.5, "male");
                yield return new agefat(2, 37, 20.9, "male");
                yield return new agefat(3, 41, 18.6, "male");
                yield return new agefat(4, 60, 28, "male");
                yield return new agefat(5, 31, 34.7, "female");
                yield return new agefat(6, 39, 30.2, "female");
                yield return new agefat(7, 58, 21.3, "male");
                yield return new agefat(8, 23, 9.5, "male");
                yield return new agefat(9, 23, 27.9, "female");
                yield return new agefat(10, 27, 7.8, "male");
                yield return new agefat(11, 27, 17.8, "male");
                yield return new agefat(12, 39, 31.4, "female");
                yield return new agefat(13, 41, 25.9, "male");
                yield return new agefat(14, 45, 27.4, "male");
                yield return new agefat(15, 49, 25.2, "female");
                yield return new agefat(16, 50, 31.1, "female");
                yield return new agefat(17, 53, 34.7, "female");
                yield return new agefat(18, 53, 42, "female");
                yield return new agefat(19, 54, 29.1, "female");
                yield return new agefat(20, 56, 32.5, "female");
                yield return new agefat(21, 57, 30.3, "female");
                yield return new agefat(22, 58, 33, "female");
                yield return new agefat(23, 58, 33.8, "female");
                yield return new agefat(24, 60, 41.1, "female");
                yield return new agefat(25, 61, 34.5, "female");
            }
        }
    }
}
