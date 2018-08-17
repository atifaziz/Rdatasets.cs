// ReSharper disable All

namespace Rdatasets.HSAUR
{
    using System.Collections.Generic;

    /// <summary>
    /// Student Risk Taking
    /// </summary>

    public class students
    {
        public readonly string treatment;
        public readonly int low;
        public readonly int high;

        public students(string treatment, int low, int high)
        {
            this.treatment = treatment;
            this.low = low;
            this.high = high;
        }

        public static IEnumerable<students> Data
        {
            get
            {
                yield return new students("AA", 8, 28);
                yield return new students("AA", 18, 28);
                yield return new students("AA", 8, 23);
                yield return new students("AA", 12, 20);
                yield return new students("AA", 15, 30);
                yield return new students("AA", 12, 32);
                yield return new students("AA", 18, 31);
                yield return new students("AA", 29, 25);
                yield return new students("AA", 6, 28);
                yield return new students("AA", 7, 28);
                yield return new students("AA", 6, 24);
                yield return new students("AA", 14, 30);
                yield return new students("AA", 11, 23);
                yield return new students("AA", 12, 20);
                yield return new students("C", 46, 13);
                yield return new students("C", 26, 10);
                yield return new students("C", 47, 22);
                yield return new students("C", 44, 14);
                yield return new students("C", 34, 4);
                yield return new students("C", 34, 4);
                yield return new students("C", 44, 7);
                yield return new students("C", 39, 5);
                yield return new students("C", 20, 0);
                yield return new students("C", 43, 11);
                yield return new students("NC", 50, 5);
                yield return new students("NC", 57, 51);
                yield return new students("NC", 62, 52);
                yield return new students("NC", 56, 52);
                yield return new students("NC", 59, 40);
                yield return new students("NC", 61, 68);
                yield return new students("NC", 66, 49);
                yield return new students("NC", 57, 49);
                yield return new students("NC", 62, 58);
                yield return new students("NC", 47, 58);
                yield return new students("NC", 53, 40);
            }
        }
    }
}
