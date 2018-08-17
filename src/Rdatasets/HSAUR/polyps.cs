// ReSharper disable All

namespace Rdatasets.HSAUR
{
    using System.Collections.Generic;

    /// <summary>
    /// Familial Andenomatous Polyposis
    /// </summary>

    public class polyps
    {
        public readonly int number;
        public readonly string treat;
        public readonly int age;

        public polyps(int number, string treat, int age)
        {
            this.number = number;
            this.treat = treat;
            this.age = age;
        }

        public static IEnumerable<polyps> Data
        {
            get
            {
                yield return new polyps(63, "placebo", 20);
                yield return new polyps(2, "drug", 16);
                yield return new polyps(28, "placebo", 18);
                yield return new polyps(17, "drug", 22);
                yield return new polyps(61, "placebo", 13);
                yield return new polyps(1, "drug", 23);
                yield return new polyps(7, "placebo", 34);
                yield return new polyps(15, "placebo", 50);
                yield return new polyps(44, "placebo", 19);
                yield return new polyps(25, "drug", 17);
                yield return new polyps(3, "drug", 23);
                yield return new polyps(28, "placebo", 22);
                yield return new polyps(10, "placebo", 30);
                yield return new polyps(40, "placebo", 27);
                yield return new polyps(33, "drug", 23);
                yield return new polyps(46, "placebo", 22);
                yield return new polyps(50, "placebo", 34);
                yield return new polyps(3, "drug", 23);
                yield return new polyps(1, "drug", 22);
                yield return new polyps(4, "drug", 42);
            }
        }
    }
}
