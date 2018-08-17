// ReSharper disable All

namespace Rdatasets.DAAG
{
    using System.Collections.Generic;

    /// <summary>
    /// Dewpoint Data
    /// </summary>

    public class dewpoint
    {
        public readonly int maxtemp;
        public readonly int mintemp;
        public readonly int dewpt;

        public dewpoint(int maxtemp, int mintemp, int dewpt)
        {
            this.maxtemp = maxtemp;
            this.mintemp = mintemp;
            this.dewpt = dewpt;
        }

        public static IEnumerable<dewpoint> Data
        {
            get
            {
                yield return new dewpoint(18, 8, 7);
                yield return new dewpoint(18, 10, 10);
                yield return new dewpoint(20, 6, 5);
                yield return new dewpoint(20, 8, 7);
                yield return new dewpoint(20, 10, 9);
                yield return new dewpoint(20, 12, 12);
                yield return new dewpoint(22, 8, 6);
                yield return new dewpoint(22, 10, 9);
                yield return new dewpoint(22, 12, 11);
                yield return new dewpoint(22, 14, 14);
                yield return new dewpoint(22, 16, 16);
                yield return new dewpoint(24, 8, 5);
                yield return new dewpoint(24, 10, 8);
                yield return new dewpoint(24, 12, 10);
                yield return new dewpoint(24, 14, 13);
                yield return new dewpoint(24, 16, 15);
                yield return new dewpoint(24, 18, 18);
                yield return new dewpoint(26, 10, 7);
                yield return new dewpoint(26, 12, 9);
                yield return new dewpoint(26, 14, 12);
                yield return new dewpoint(26, 16, 14);
                yield return new dewpoint(26, 18, 17);
                yield return new dewpoint(26, 20, 20);
                yield return new dewpoint(28, 10, 5);
                yield return new dewpoint(28, 12, 8);
                yield return new dewpoint(28, 14, 11);
                yield return new dewpoint(28, 16, 13);
                yield return new dewpoint(28, 18, 16);
                yield return new dewpoint(28, 20, 19);
                yield return new dewpoint(28, 22, 22);
                yield return new dewpoint(28, 24, 24);
                yield return new dewpoint(30, 12, 7);
                yield return new dewpoint(30, 14, 9);
                yield return new dewpoint(30, 16, 12);
                yield return new dewpoint(30, 18, 14);
                yield return new dewpoint(30, 20, 18);
                yield return new dewpoint(30, 22, 20);
                yield return new dewpoint(30, 24, 23);
                yield return new dewpoint(30, 26, 26);
                yield return new dewpoint(32, 12, 5);
                yield return new dewpoint(32, 14, 8);
                yield return new dewpoint(32, 16, 11);
                yield return new dewpoint(32, 18, 13);
                yield return new dewpoint(32, 20, 16);
                yield return new dewpoint(32, 22, 19);
                yield return new dewpoint(32, 24, 22);
                yield return new dewpoint(32, 26, 25);
                yield return new dewpoint(34, 14, 6);
                yield return new dewpoint(34, 16, 9);
                yield return new dewpoint(34, 18, 12);
                yield return new dewpoint(34, 20, 15);
                yield return new dewpoint(34, 22, 18);
                yield return new dewpoint(34, 24, 21);
                yield return new dewpoint(34, 26, 25);
                yield return new dewpoint(36, 14, 5);
                yield return new dewpoint(36, 16, 7);
                yield return new dewpoint(36, 18, 10);
                yield return new dewpoint(36, 20, 13);
                yield return new dewpoint(36, 22, 16);
                yield return new dewpoint(36, 24, 19);
                yield return new dewpoint(36, 26, 22);
                yield return new dewpoint(38, 16, 5);
                yield return new dewpoint(38, 18, 7);
                yield return new dewpoint(38, 20, 10);
                yield return new dewpoint(38, 22, 13);
                yield return new dewpoint(38, 24, 17);
                yield return new dewpoint(38, 26, 20);
                yield return new dewpoint(40, 18, 5);
                yield return new dewpoint(40, 20, 8);
                yield return new dewpoint(40, 22, 11);
                yield return new dewpoint(40, 24, 14);
                yield return new dewpoint(40, 26, 17);
            }
        }
    }
}
