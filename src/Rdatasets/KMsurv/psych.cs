// ReSharper disable All

namespace Rdatasets.KMsurv
{
    using System.Collections.Generic;

    /// <summary>
    /// data from Section 1.15
    /// </summary>

    public class psych
    {
        public readonly int κ;
        public readonly int sex;
        public readonly int age;
        public readonly int time;
        public readonly int death;

        public psych(int κ, int sex, int age, int time, int death)
        {
            this.κ = κ;
            this.sex = sex;
            this.age = age;
            this.time = time;
            this.death = death;
        }

        public static IEnumerable<psych> Data
        {
            get
            {
                yield return new psych(1, 2, 51, 1, 1);
                yield return new psych(2, 2, 58, 1, 1);
                yield return new psych(3, 2, 55, 2, 1);
                yield return new psych(4, 2, 28, 22, 1);
                yield return new psych(5, 1, 21, 30, 0);
                yield return new psych(6, 1, 19, 28, 1);
                yield return new psych(7, 2, 25, 32, 1);
                yield return new psych(8, 2, 48, 11, 1);
                yield return new psych(9, 2, 47, 14, 1);
                yield return new psych(10, 2, 25, 36, 0);
                yield return new psych(11, 2, 31, 31, 0);
                yield return new psych(12, 1, 24, 33, 0);
                yield return new psych(13, 1, 25, 33, 0);
                yield return new psych(14, 2, 30, 37, 0);
                yield return new psych(15, 2, 33, 35, 0);
                yield return new psych(16, 1, 36, 25, 1);
                yield return new psych(17, 1, 30, 31, 0);
                yield return new psych(18, 1, 41, 22, 1);
                yield return new psych(19, 2, 43, 26, 1);
                yield return new psych(20, 2, 45, 24, 1);
                yield return new psych(21, 2, 35, 35, 0);
                yield return new psych(22, 1, 29, 34, 0);
                yield return new psych(23, 1, 35, 30, 0);
                yield return new psych(24, 1, 32, 35, 1);
                yield return new psych(25, 2, 36, 40, 1);
                yield return new psych(26, 1, 32, 39, 0);
            }
        }
    }
}
