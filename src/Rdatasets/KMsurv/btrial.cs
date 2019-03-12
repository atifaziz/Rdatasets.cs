// ReSharper disable All

namespace Rdatasets.KMsurv
{
    using System.Collections.Generic;

    /// <summary>
    /// data from Section 1.5
    /// </summary>

    public class btrial
    {
        public readonly int κ;
        public readonly int time;
        public readonly int death;
        public readonly int im;

        public btrial(int κ, int time, int death, int im)
        {
            this.κ = κ;
            this.time = time;
            this.death = death;
            this.im = im;
        }

        public static IEnumerable<btrial> Data
        {
            get
            {
                yield return new btrial(1, 19, 1, 1);
                yield return new btrial(2, 25, 1, 1);
                yield return new btrial(3, 30, 1, 1);
                yield return new btrial(4, 34, 1, 1);
                yield return new btrial(5, 37, 1, 1);
                yield return new btrial(6, 46, 1, 1);
                yield return new btrial(7, 47, 1, 1);
                yield return new btrial(8, 51, 1, 1);
                yield return new btrial(9, 56, 1, 1);
                yield return new btrial(10, 57, 1, 1);
                yield return new btrial(11, 61, 1, 1);
                yield return new btrial(12, 66, 1, 1);
                yield return new btrial(13, 67, 1, 1);
                yield return new btrial(14, 74, 1, 1);
                yield return new btrial(15, 78, 1, 1);
                yield return new btrial(16, 86, 1, 1);
                yield return new btrial(17, 122, 0, 1);
                yield return new btrial(18, 123, 0, 1);
                yield return new btrial(19, 130, 0, 1);
                yield return new btrial(20, 130, 0, 1);
                yield return new btrial(21, 133, 0, 1);
                yield return new btrial(22, 134, 0, 1);
                yield return new btrial(23, 136, 0, 1);
                yield return new btrial(24, 141, 0, 1);
                yield return new btrial(25, 143, 0, 1);
                yield return new btrial(26, 148, 0, 1);
                yield return new btrial(27, 151, 0, 1);
                yield return new btrial(28, 152, 0, 1);
                yield return new btrial(29, 153, 0, 1);
                yield return new btrial(30, 154, 0, 1);
                yield return new btrial(31, 156, 0, 1);
                yield return new btrial(32, 162, 0, 1);
                yield return new btrial(33, 164, 0, 1);
                yield return new btrial(34, 165, 0, 1);
                yield return new btrial(35, 182, 0, 1);
                yield return new btrial(36, 189, 0, 1);
                yield return new btrial(37, 22, 1, 2);
                yield return new btrial(38, 23, 1, 2);
                yield return new btrial(39, 38, 1, 2);
                yield return new btrial(40, 42, 1, 2);
                yield return new btrial(41, 73, 1, 2);
                yield return new btrial(42, 77, 1, 2);
                yield return new btrial(43, 89, 1, 2);
                yield return new btrial(44, 115, 1, 2);
                yield return new btrial(45, 144, 0, 2);
            }
        }
    }
}
