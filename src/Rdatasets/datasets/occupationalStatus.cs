// ReSharper disable All

namespace Rdatasets.datasets
{
    using System.Collections.Generic;

    /// <summary>
    /// Occupational Status of Fathers and their Sons
    /// </summary>

    public class occupationalStatus
    {
        public readonly int origin;
        public readonly int destination;
        public readonly int Freq;

        public occupationalStatus(int origin, int destination, int Freq)
        {
            this.origin = origin;
            this.destination = destination;
            this.Freq = Freq;
        }

        public static IEnumerable<occupationalStatus> Data
        {
            get
            {
                yield return new occupationalStatus(1, 1, 50);
                yield return new occupationalStatus(2, 1, 16);
                yield return new occupationalStatus(3, 1, 12);
                yield return new occupationalStatus(4, 1, 11);
                yield return new occupationalStatus(5, 1, 2);
                yield return new occupationalStatus(6, 1, 12);
                yield return new occupationalStatus(7, 1, 0);
                yield return new occupationalStatus(8, 1, 0);
                yield return new occupationalStatus(1, 2, 19);
                yield return new occupationalStatus(2, 2, 40);
                yield return new occupationalStatus(3, 2, 35);
                yield return new occupationalStatus(4, 2, 20);
                yield return new occupationalStatus(5, 2, 8);
                yield return new occupationalStatus(6, 2, 28);
                yield return new occupationalStatus(7, 2, 6);
                yield return new occupationalStatus(8, 2, 3);
                yield return new occupationalStatus(1, 3, 26);
                yield return new occupationalStatus(2, 3, 34);
                yield return new occupationalStatus(3, 3, 65);
                yield return new occupationalStatus(4, 3, 58);
                yield return new occupationalStatus(5, 3, 12);
                yield return new occupationalStatus(6, 3, 102);
                yield return new occupationalStatus(7, 3, 19);
                yield return new occupationalStatus(8, 3, 14);
                yield return new occupationalStatus(1, 4, 8);
                yield return new occupationalStatus(2, 4, 18);
                yield return new occupationalStatus(3, 4, 66);
                yield return new occupationalStatus(4, 4, 110);
                yield return new occupationalStatus(5, 4, 23);
                yield return new occupationalStatus(6, 4, 162);
                yield return new occupationalStatus(7, 4, 40);
                yield return new occupationalStatus(8, 4, 32);
                yield return new occupationalStatus(1, 5, 7);
                yield return new occupationalStatus(2, 5, 11);
                yield return new occupationalStatus(3, 5, 35);
                yield return new occupationalStatus(4, 5, 40);
                yield return new occupationalStatus(5, 5, 25);
                yield return new occupationalStatus(6, 5, 90);
                yield return new occupationalStatus(7, 5, 21);
                yield return new occupationalStatus(8, 5, 15);
                yield return new occupationalStatus(1, 6, 11);
                yield return new occupationalStatus(2, 6, 20);
                yield return new occupationalStatus(3, 6, 88);
                yield return new occupationalStatus(4, 6, 183);
                yield return new occupationalStatus(5, 6, 46);
                yield return new occupationalStatus(6, 6, 554);
                yield return new occupationalStatus(7, 6, 158);
                yield return new occupationalStatus(8, 6, 126);
                yield return new occupationalStatus(1, 7, 6);
                yield return new occupationalStatus(2, 7, 8);
                yield return new occupationalStatus(3, 7, 23);
                yield return new occupationalStatus(4, 7, 64);
                yield return new occupationalStatus(5, 7, 28);
                yield return new occupationalStatus(6, 7, 230);
                yield return new occupationalStatus(7, 7, 143);
                yield return new occupationalStatus(8, 7, 91);
                yield return new occupationalStatus(1, 8, 2);
                yield return new occupationalStatus(2, 8, 3);
                yield return new occupationalStatus(3, 8, 21);
                yield return new occupationalStatus(4, 8, 32);
                yield return new occupationalStatus(5, 8, 12);
                yield return new occupationalStatus(6, 8, 177);
                yield return new occupationalStatus(7, 8, 71);
                yield return new occupationalStatus(8, 8, 106);
            }
        }
    }
}
