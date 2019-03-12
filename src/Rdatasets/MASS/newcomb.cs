// ReSharper disable All

namespace Rdatasets.MASS
{
    using System.Collections.Generic;

    /// <summary>
    /// Newcomb's Measurements of the Passage Time of Light
    /// </summary>

    public class newcomb
    {
        public readonly int κ;
        public readonly int dat;

        public newcomb(int κ, int dat)
        {
            this.κ = κ;
            this.dat = dat;
        }

        public static IEnumerable<newcomb> Data
        {
            get
            {
                yield return new newcomb(1, 28);
                yield return new newcomb(2, -44);
                yield return new newcomb(3, 29);
                yield return new newcomb(4, 30);
                yield return new newcomb(5, 24);
                yield return new newcomb(6, 28);
                yield return new newcomb(7, 37);
                yield return new newcomb(8, 32);
                yield return new newcomb(9, 36);
                yield return new newcomb(10, 27);
                yield return new newcomb(11, 26);
                yield return new newcomb(12, 28);
                yield return new newcomb(13, 29);
                yield return new newcomb(14, 26);
                yield return new newcomb(15, 27);
                yield return new newcomb(16, 22);
                yield return new newcomb(17, 23);
                yield return new newcomb(18, 20);
                yield return new newcomb(19, 25);
                yield return new newcomb(20, 25);
                yield return new newcomb(21, 36);
                yield return new newcomb(22, 23);
                yield return new newcomb(23, 31);
                yield return new newcomb(24, 32);
                yield return new newcomb(25, 24);
                yield return new newcomb(26, 27);
                yield return new newcomb(27, 33);
                yield return new newcomb(28, 16);
                yield return new newcomb(29, 24);
                yield return new newcomb(30, 29);
                yield return new newcomb(31, 36);
                yield return new newcomb(32, 21);
                yield return new newcomb(33, 28);
                yield return new newcomb(34, 26);
                yield return new newcomb(35, 27);
                yield return new newcomb(36, 27);
                yield return new newcomb(37, 32);
                yield return new newcomb(38, 25);
                yield return new newcomb(39, 28);
                yield return new newcomb(40, 24);
                yield return new newcomb(41, 40);
                yield return new newcomb(42, 21);
                yield return new newcomb(43, 31);
                yield return new newcomb(44, 32);
                yield return new newcomb(45, 28);
                yield return new newcomb(46, 26);
                yield return new newcomb(47, 30);
                yield return new newcomb(48, 27);
                yield return new newcomb(49, 26);
                yield return new newcomb(50, 24);
                yield return new newcomb(51, 32);
                yield return new newcomb(52, 29);
                yield return new newcomb(53, 34);
                yield return new newcomb(54, -2);
                yield return new newcomb(55, 25);
                yield return new newcomb(56, 19);
                yield return new newcomb(57, 36);
                yield return new newcomb(58, 29);
                yield return new newcomb(59, 30);
                yield return new newcomb(60, 22);
                yield return new newcomb(61, 28);
                yield return new newcomb(62, 33);
                yield return new newcomb(63, 39);
                yield return new newcomb(64, 25);
                yield return new newcomb(65, 16);
                yield return new newcomb(66, 23);
            }
        }
    }
}
