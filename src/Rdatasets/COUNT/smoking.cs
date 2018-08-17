// ReSharper disable All

namespace Rdatasets.COUNT
{
    using System.Collections.Generic;

    /// <summary>
    /// smoking
    /// </summary>

    public class smoking
    {
        public readonly int sbp;
        public readonly int male;
        public readonly int smoker;
        public readonly int age;

        public smoking(int sbp, int male, int smoker, int age)
        {
            this.sbp = sbp;
            this.male = male;
            this.smoker = smoker;
            this.age = age;
        }

        public static IEnumerable<smoking> Data
        {
            get
            {
                yield return new smoking(131, 1, 1, 34);
                yield return new smoking(132, 1, 1, 36);
                yield return new smoking(122, 1, 0, 30);
                yield return new smoking(119, 0, 0, 32);
                yield return new smoking(123, 0, 1, 26);
                yield return new smoking(115, 0, 0, 23);
            }
        }
    }
}
