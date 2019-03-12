// ReSharper disable All

namespace Rdatasets.HSAUR
{
    using System.Collections.Generic;

    /// <summary>
    /// Student Risk Taking
    /// </summary>

    public class students
    {
        public readonly int κ;
        public readonly string treatment;
        public readonly int low;
        public readonly int high;

        public students(int κ, string treatment, int low, int high)
        {
            this.κ = κ;
            this.treatment = treatment;
            this.low = low;
            this.high = high;
        }

        public static IEnumerable<students> Data
        {
            get
            {
                yield return new students(1, "AA", 8, 28);
                yield return new students(2, "AA", 18, 28);
                yield return new students(3, "AA", 8, 23);
                yield return new students(4, "AA", 12, 20);
                yield return new students(5, "AA", 15, 30);
                yield return new students(6, "AA", 12, 32);
                yield return new students(7, "AA", 18, 31);
                yield return new students(8, "AA", 29, 25);
                yield return new students(9, "AA", 6, 28);
                yield return new students(10, "AA", 7, 28);
                yield return new students(11, "AA", 6, 24);
                yield return new students(12, "AA", 14, 30);
                yield return new students(13, "AA", 11, 23);
                yield return new students(14, "AA", 12, 20);
                yield return new students(15, "C", 46, 13);
                yield return new students(16, "C", 26, 10);
                yield return new students(17, "C", 47, 22);
                yield return new students(18, "C", 44, 14);
                yield return new students(19, "C", 34, 4);
                yield return new students(20, "C", 34, 4);
                yield return new students(21, "C", 44, 7);
                yield return new students(22, "C", 39, 5);
                yield return new students(23, "C", 20, 0);
                yield return new students(24, "C", 43, 11);
                yield return new students(25, "NC", 50, 5);
                yield return new students(26, "NC", 57, 51);
                yield return new students(27, "NC", 62, 52);
                yield return new students(28, "NC", 56, 52);
                yield return new students(29, "NC", 59, 40);
                yield return new students(30, "NC", 61, 68);
                yield return new students(31, "NC", 66, 49);
                yield return new students(32, "NC", 57, 49);
                yield return new students(33, "NC", 62, 58);
                yield return new students(34, "NC", 47, 58);
                yield return new students(35, "NC", 53, 40);
            }
        }
    }
}
