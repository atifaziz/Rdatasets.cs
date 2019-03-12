// ReSharper disable All

namespace Rdatasets.datasets
{
    using System.Collections.Generic;

    /// <summary>
    /// Occupational Status of Fathers and their Sons
    /// </summary>

    public class occupationalStatus
    {
        public readonly int κ;
        public readonly int origin;
        public readonly int destination;
        public readonly int Freq;

        public occupationalStatus(int κ, int origin, int destination, int Freq)
        {
            this.κ = κ;
            this.origin = origin;
            this.destination = destination;
            this.Freq = Freq;
        }

        public static IEnumerable<occupationalStatus> Data
        {
            get
            {
                yield return new occupationalStatus(1, 1, 1, 50);
                yield return new occupationalStatus(2, 2, 1, 16);
                yield return new occupationalStatus(3, 3, 1, 12);
                yield return new occupationalStatus(4, 4, 1, 11);
                yield return new occupationalStatus(5, 5, 1, 2);
                yield return new occupationalStatus(6, 6, 1, 12);
                yield return new occupationalStatus(7, 7, 1, 0);
                yield return new occupationalStatus(8, 8, 1, 0);
                yield return new occupationalStatus(9, 1, 2, 19);
                yield return new occupationalStatus(10, 2, 2, 40);
                yield return new occupationalStatus(11, 3, 2, 35);
                yield return new occupationalStatus(12, 4, 2, 20);
                yield return new occupationalStatus(13, 5, 2, 8);
                yield return new occupationalStatus(14, 6, 2, 28);
                yield return new occupationalStatus(15, 7, 2, 6);
                yield return new occupationalStatus(16, 8, 2, 3);
                yield return new occupationalStatus(17, 1, 3, 26);
                yield return new occupationalStatus(18, 2, 3, 34);
                yield return new occupationalStatus(19, 3, 3, 65);
                yield return new occupationalStatus(20, 4, 3, 58);
                yield return new occupationalStatus(21, 5, 3, 12);
                yield return new occupationalStatus(22, 6, 3, 102);
                yield return new occupationalStatus(23, 7, 3, 19);
                yield return new occupationalStatus(24, 8, 3, 14);
                yield return new occupationalStatus(25, 1, 4, 8);
                yield return new occupationalStatus(26, 2, 4, 18);
                yield return new occupationalStatus(27, 3, 4, 66);
                yield return new occupationalStatus(28, 4, 4, 110);
                yield return new occupationalStatus(29, 5, 4, 23);
                yield return new occupationalStatus(30, 6, 4, 162);
                yield return new occupationalStatus(31, 7, 4, 40);
                yield return new occupationalStatus(32, 8, 4, 32);
                yield return new occupationalStatus(33, 1, 5, 7);
                yield return new occupationalStatus(34, 2, 5, 11);
                yield return new occupationalStatus(35, 3, 5, 35);
                yield return new occupationalStatus(36, 4, 5, 40);
                yield return new occupationalStatus(37, 5, 5, 25);
                yield return new occupationalStatus(38, 6, 5, 90);
                yield return new occupationalStatus(39, 7, 5, 21);
                yield return new occupationalStatus(40, 8, 5, 15);
                yield return new occupationalStatus(41, 1, 6, 11);
                yield return new occupationalStatus(42, 2, 6, 20);
                yield return new occupationalStatus(43, 3, 6, 88);
                yield return new occupationalStatus(44, 4, 6, 183);
                yield return new occupationalStatus(45, 5, 6, 46);
                yield return new occupationalStatus(46, 6, 6, 554);
                yield return new occupationalStatus(47, 7, 6, 158);
                yield return new occupationalStatus(48, 8, 6, 126);
                yield return new occupationalStatus(49, 1, 7, 6);
                yield return new occupationalStatus(50, 2, 7, 8);
                yield return new occupationalStatus(51, 3, 7, 23);
                yield return new occupationalStatus(52, 4, 7, 64);
                yield return new occupationalStatus(53, 5, 7, 28);
                yield return new occupationalStatus(54, 6, 7, 230);
                yield return new occupationalStatus(55, 7, 7, 143);
                yield return new occupationalStatus(56, 8, 7, 91);
                yield return new occupationalStatus(57, 1, 8, 2);
                yield return new occupationalStatus(58, 2, 8, 3);
                yield return new occupationalStatus(59, 3, 8, 21);
                yield return new occupationalStatus(60, 4, 8, 32);
                yield return new occupationalStatus(61, 5, 8, 12);
                yield return new occupationalStatus(62, 6, 8, 177);
                yield return new occupationalStatus(63, 7, 8, 71);
                yield return new occupationalStatus(64, 8, 8, 106);
            }
        }
    }
}
