// ReSharper disable All

namespace Rdatasets.KMsurv
{
    using System.Collections.Generic;

    /// <summary>
    /// data from Exercise 7.14, p225
    /// </summary>

    public class twins
    {
        public readonly int id;
        public readonly int age;
        public readonly int death;
        public readonly int gender;

        public twins(int id, int age, int death, int gender)
        {
            this.id = id;
            this.age = age;
            this.death = death;
            this.gender = gender;
        }

        public static IEnumerable<twins> Data
        {
            get
            {
                yield return new twins(1, 50, 1, 1);
                yield return new twins(1, 63, 0, 2);
                yield return new twins(2, 49, 0, 1);
                yield return new twins(2, 52, 1, 2);
                yield return new twins(3, 56, 0, 1);
                yield return new twins(3, 70, 0, 2);
                yield return new twins(4, 68, 1, 1);
                yield return new twins(4, 75, 1, 2);
                yield return new twins(5, 74, 0, 1);
                yield return new twins(5, 72, 1, 2);
                yield return new twins(6, 69, 0, 1);
                yield return new twins(6, 69, 0, 2);
                yield return new twins(7, 70, 0, 1);
                yield return new twins(7, 70, 0, 2);
                yield return new twins(8, 67, 1, 1);
                yield return new twins(8, 70, 0, 2);
                yield return new twins(9, 74, 0, 1);
                yield return new twins(9, 74, 0, 2);
                yield return new twins(10, 81, 0, 1);
                yield return new twins(10, 81, 0, 2);
                yield return new twins(11, 61, 1, 1);
                yield return new twins(11, 58, 1, 2);
                yield return new twins(12, 75, 0, 1);
                yield return new twins(12, 73, 0, 2);
            }
        }
    }
}
