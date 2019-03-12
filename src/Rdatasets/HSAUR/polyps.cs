// ReSharper disable All

namespace Rdatasets.HSAUR
{
    using System.Collections.Generic;

    /// <summary>
    /// Familial Andenomatous Polyposis
    /// </summary>

    public class polyps
    {
        public readonly int κ;
        public readonly int number;
        public readonly string treat;
        public readonly int age;

        public polyps(int κ, int number, string treat, int age)
        {
            this.κ = κ;
            this.number = number;
            this.treat = treat;
            this.age = age;
        }

        public static IEnumerable<polyps> Data
        {
            get
            {
                yield return new polyps(1, 63, "placebo", 20);
                yield return new polyps(2, 2, "drug", 16);
                yield return new polyps(3, 28, "placebo", 18);
                yield return new polyps(4, 17, "drug", 22);
                yield return new polyps(5, 61, "placebo", 13);
                yield return new polyps(6, 1, "drug", 23);
                yield return new polyps(7, 7, "placebo", 34);
                yield return new polyps(8, 15, "placebo", 50);
                yield return new polyps(9, 44, "placebo", 19);
                yield return new polyps(10, 25, "drug", 17);
                yield return new polyps(11, 3, "drug", 23);
                yield return new polyps(12, 28, "placebo", 22);
                yield return new polyps(13, 10, "placebo", 30);
                yield return new polyps(14, 40, "placebo", 27);
                yield return new polyps(15, 33, "drug", 23);
                yield return new polyps(16, 46, "placebo", 22);
                yield return new polyps(17, 50, "placebo", 34);
                yield return new polyps(18, 3, "drug", 23);
                yield return new polyps(19, 1, "drug", 22);
                yield return new polyps(20, 4, "drug", 42);
            }
        }
    }
}
