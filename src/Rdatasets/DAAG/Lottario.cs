// ReSharper disable All

namespace Rdatasets.DAAG
{
    using System.Collections.Generic;

    /// <summary>
    /// Ontario Lottery Data
    /// </summary>

    public class Lottario
    {
        public readonly int Number;
        public readonly int Frequency;

        public Lottario(int Number, int Frequency)
        {
            this.Number = Number;
            this.Frequency = Frequency;
        }

        public static IEnumerable<Lottario> Data
        {
            get
            {
                yield return new Lottario(1, 25);
                yield return new Lottario(2, 13);
                yield return new Lottario(3, 19);
                yield return new Lottario(4, 30);
                yield return new Lottario(5, 28);
                yield return new Lottario(6, 26);
                yield return new Lottario(7, 23);
                yield return new Lottario(8, 14);
                yield return new Lottario(9, 25);
                yield return new Lottario(10, 17);
                yield return new Lottario(11, 24);
                yield return new Lottario(12, 29);
                yield return new Lottario(13, 26);
                yield return new Lottario(14, 28);
                yield return new Lottario(15, 24);
                yield return new Lottario(16, 17);
                yield return new Lottario(17, 16);
                yield return new Lottario(18, 24);
                yield return new Lottario(19, 22);
                yield return new Lottario(20, 20);
                yield return new Lottario(21, 18);
                yield return new Lottario(22, 20);
                yield return new Lottario(23, 18);
                yield return new Lottario(24, 20);
                yield return new Lottario(25, 16);
                yield return new Lottario(26, 25);
                yield return new Lottario(27, 23);
                yield return new Lottario(28, 21);
                yield return new Lottario(29, 19);
                yield return new Lottario(30, 17);
                yield return new Lottario(31, 17);
                yield return new Lottario(32, 25);
                yield return new Lottario(33, 25);
                yield return new Lottario(34, 18);
                yield return new Lottario(35, 35);
                yield return new Lottario(36, 15);
                yield return new Lottario(37, 18);
                yield return new Lottario(38, 29);
                yield return new Lottario(39, 25);
            }
        }
    }
}
