// ReSharper disable All

namespace Rdatasets.HSAUR
{
    using System.Collections.Generic;

    /// <summary>
    /// Total Body Composision Data
    /// </summary>

    public class agefat
    {
        public readonly int age;
        public readonly double fat;
        public readonly string sex;

        public agefat(int age, double fat, string sex)
        {
            this.age = age;
            this.fat = fat;
            this.sex = sex;
        }

        public static IEnumerable<agefat> Data
        {
            get
            {
                yield return new agefat(24, 15.5, "male");
                yield return new agefat(37, 20.9, "male");
                yield return new agefat(41, 18.6, "male");
                yield return new agefat(60, 28, "male");
                yield return new agefat(31, 34.7, "female");
                yield return new agefat(39, 30.2, "female");
                yield return new agefat(58, 21.3, "male");
                yield return new agefat(23, 9.5, "male");
                yield return new agefat(23, 27.9, "female");
                yield return new agefat(27, 7.8, "male");
                yield return new agefat(27, 17.8, "male");
                yield return new agefat(39, 31.4, "female");
                yield return new agefat(41, 25.9, "male");
                yield return new agefat(45, 27.4, "male");
                yield return new agefat(49, 25.2, "female");
                yield return new agefat(50, 31.1, "female");
                yield return new agefat(53, 34.7, "female");
                yield return new agefat(53, 42, "female");
                yield return new agefat(54, 29.1, "female");
                yield return new agefat(56, 32.5, "female");
                yield return new agefat(57, 30.3, "female");
                yield return new agefat(58, 33, "female");
                yield return new agefat(58, 33.8, "female");
                yield return new agefat(60, 41.1, "female");
                yield return new agefat(61, 34.5, "female");
            }
        }
    }
}
