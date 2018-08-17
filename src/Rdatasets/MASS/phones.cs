// ReSharper disable All

namespace Rdatasets.MASS
{
    using System.Collections.Generic;

    /// <summary>
    /// Belgium Phone Calls 1950-1973
    /// </summary>

    public class phones
    {
        public readonly int year;
        public readonly double calls;

        public phones(int year, double calls)
        {
            this.year = year;
            this.calls = calls;
        }

        public static IEnumerable<phones> Data
        {
            get
            {
                yield return new phones(50, 4.4);
                yield return new phones(51, 4.7);
                yield return new phones(52, 4.7);
                yield return new phones(53, 5.9);
                yield return new phones(54, 6.6);
                yield return new phones(55, 7.3);
                yield return new phones(56, 8.1);
                yield return new phones(57, 8.8);
                yield return new phones(58, 10.6);
                yield return new phones(59, 12);
                yield return new phones(60, 13.5);
                yield return new phones(61, 14.9);
                yield return new phones(62, 16.1);
                yield return new phones(63, 21.2);
                yield return new phones(64, 119);
                yield return new phones(65, 124);
                yield return new phones(66, 142);
                yield return new phones(67, 159);
                yield return new phones(68, 182);
                yield return new phones(69, 212);
                yield return new phones(70, 43);
                yield return new phones(71, 24);
                yield return new phones(72, 27);
                yield return new phones(73, 29);
            }
        }
    }
}
