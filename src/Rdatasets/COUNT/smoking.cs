// ReSharper disable All

namespace Rdatasets.COUNT
{
    using System.Collections.Generic;

    /// <summary>
    /// smoking
    /// </summary>

    public class smoking
    {
        public readonly int κ;
        public readonly int sbp;
        public readonly int male;
        public readonly int smoker;
        public readonly int age;

        public smoking(int κ, int sbp, int male, int smoker, int age)
        {
            this.κ = κ;
            this.sbp = sbp;
            this.male = male;
            this.smoker = smoker;
            this.age = age;
        }

        public static IEnumerable<smoking> Data
        {
            get
            {
                yield return new smoking(1, 131, 1, 1, 34);
                yield return new smoking(2, 132, 1, 1, 36);
                yield return new smoking(3, 122, 1, 0, 30);
                yield return new smoking(4, 119, 0, 0, 32);
                yield return new smoking(5, 123, 0, 1, 26);
                yield return new smoking(6, 115, 0, 0, 23);
            }
        }
    }
}
