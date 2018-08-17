// ReSharper disable All

namespace Rdatasets.KMsurv
{
    using System.Collections.Generic;

    /// <summary>
    /// data from Section 1.11
    /// </summary>

    public class tongue
    {
        public readonly int type;
        public readonly int time;
        public readonly int delta;

        public tongue(int type, int time, int delta)
        {
            this.type = type;
            this.time = time;
            this.delta = delta;
        }

        public static IEnumerable<tongue> Data
        {
            get
            {
                yield return new tongue(1, 1, 1);
                yield return new tongue(1, 3, 1);
                yield return new tongue(1, 3, 1);
                yield return new tongue(1, 4, 1);
                yield return new tongue(1, 10, 1);
                yield return new tongue(1, 13, 1);
                yield return new tongue(1, 13, 1);
                yield return new tongue(1, 16, 1);
                yield return new tongue(1, 16, 1);
                yield return new tongue(1, 24, 1);
                yield return new tongue(1, 26, 1);
                yield return new tongue(1, 27, 1);
                yield return new tongue(1, 28, 1);
                yield return new tongue(1, 30, 1);
                yield return new tongue(1, 30, 1);
                yield return new tongue(1, 32, 1);
                yield return new tongue(1, 41, 1);
                yield return new tongue(1, 51, 1);
                yield return new tongue(1, 65, 1);
                yield return new tongue(1, 67, 1);
                yield return new tongue(1, 70, 1);
                yield return new tongue(1, 72, 1);
                yield return new tongue(1, 73, 1);
                yield return new tongue(1, 77, 1);
                yield return new tongue(1, 91, 1);
                yield return new tongue(1, 93, 1);
                yield return new tongue(1, 96, 1);
                yield return new tongue(1, 100, 1);
                yield return new tongue(1, 104, 1);
                yield return new tongue(1, 157, 1);
                yield return new tongue(1, 167, 1);
                yield return new tongue(1, 61, 0);
                yield return new tongue(1, 74, 0);
                yield return new tongue(1, 79, 0);
                yield return new tongue(1, 80, 0);
                yield return new tongue(1, 81, 0);
                yield return new tongue(1, 87, 0);
                yield return new tongue(1, 87, 0);
                yield return new tongue(1, 88, 0);
                yield return new tongue(1, 89, 0);
                yield return new tongue(1, 93, 0);
                yield return new tongue(1, 97, 0);
                yield return new tongue(1, 101, 0);
                yield return new tongue(1, 104, 0);
                yield return new tongue(1, 108, 0);
                yield return new tongue(1, 109, 0);
                yield return new tongue(1, 120, 0);
                yield return new tongue(1, 131, 0);
                yield return new tongue(1, 150, 0);
                yield return new tongue(1, 231, 0);
                yield return new tongue(1, 240, 0);
                yield return new tongue(1, 400, 0);
                yield return new tongue(2, 1, 1);
                yield return new tongue(2, 3, 1);
                yield return new tongue(2, 4, 1);
                yield return new tongue(2, 5, 1);
                yield return new tongue(2, 5, 1);
                yield return new tongue(2, 8, 1);
                yield return new tongue(2, 12, 1);
                yield return new tongue(2, 13, 1);
                yield return new tongue(2, 18, 1);
                yield return new tongue(2, 23, 1);
                yield return new tongue(2, 26, 1);
                yield return new tongue(2, 27, 1);
                yield return new tongue(2, 30, 1);
                yield return new tongue(2, 42, 1);
                yield return new tongue(2, 56, 1);
                yield return new tongue(2, 62, 1);
                yield return new tongue(2, 69, 1);
                yield return new tongue(2, 104, 1);
                yield return new tongue(2, 104, 1);
                yield return new tongue(2, 112, 1);
                yield return new tongue(2, 129, 1);
                yield return new tongue(2, 181, 1);
                yield return new tongue(2, 8, 0);
                yield return new tongue(2, 67, 0);
                yield return new tongue(2, 76, 0);
                yield return new tongue(2, 104, 0);
                yield return new tongue(2, 176, 0);
                yield return new tongue(2, 231, 0);
            }
        }
    }
}
