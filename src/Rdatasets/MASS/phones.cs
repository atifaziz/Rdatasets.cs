// ReSharper disable All

namespace Rdatasets.MASS
{
    using System.Collections.Generic;

    /// <summary>
    /// Belgium Phone Calls 1950-1973
    /// </summary>

    public class phones
    {
        public readonly int κ;
        public readonly int year;
        public readonly double calls;

        public phones(int κ, int year, double calls)
        {
            this.κ = κ;
            this.year = year;
            this.calls = calls;
        }

        public static IEnumerable<phones> Data
        {
            get
            {
                yield return new phones(1, 50, 4.4);
                yield return new phones(2, 51, 4.7);
                yield return new phones(3, 52, 4.7);
                yield return new phones(4, 53, 5.9);
                yield return new phones(5, 54, 6.6);
                yield return new phones(6, 55, 7.3);
                yield return new phones(7, 56, 8.1);
                yield return new phones(8, 57, 8.8);
                yield return new phones(9, 58, 10.6);
                yield return new phones(10, 59, 12);
                yield return new phones(11, 60, 13.5);
                yield return new phones(12, 61, 14.9);
                yield return new phones(13, 62, 16.1);
                yield return new phones(14, 63, 21.2);
                yield return new phones(15, 64, 119);
                yield return new phones(16, 65, 124);
                yield return new phones(17, 66, 142);
                yield return new phones(18, 67, 159);
                yield return new phones(19, 68, 182);
                yield return new phones(20, 69, 212);
                yield return new phones(21, 70, 43);
                yield return new phones(22, 71, 24);
                yield return new phones(23, 72, 27);
                yield return new phones(24, 73, 29);
            }
        }
    }
}
