// ReSharper disable All

namespace Rdatasets.mosaicData
{
    using System.Collections.Generic;

    /// <summary>
    /// Standard Deck of Cards
    /// </summary>

    public class Cards
    {
        public readonly int κ;
        public readonly string dat;

        public Cards(int κ, string dat)
        {
            this.κ = κ;
            this.dat = dat;
        }

        public static IEnumerable<Cards> Data
        {
            get
            {
                yield return new Cards(1, "2C");
                yield return new Cards(2, "3C");
                yield return new Cards(3, "4C");
                yield return new Cards(4, "5C");
                yield return new Cards(5, "6C");
                yield return new Cards(6, "7C");
                yield return new Cards(7, "8C");
                yield return new Cards(8, "9C");
                yield return new Cards(9, "10C");
                yield return new Cards(10, "JC");
                yield return new Cards(11, "QC");
                yield return new Cards(12, "KC");
                yield return new Cards(13, "AC");
                yield return new Cards(14, "2D");
                yield return new Cards(15, "3D");
                yield return new Cards(16, "4D");
                yield return new Cards(17, "5D");
                yield return new Cards(18, "6D");
                yield return new Cards(19, "7D");
                yield return new Cards(20, "8D");
                yield return new Cards(21, "9D");
                yield return new Cards(22, "10D");
                yield return new Cards(23, "JD");
                yield return new Cards(24, "QD");
                yield return new Cards(25, "KD");
                yield return new Cards(26, "AD");
                yield return new Cards(27, "2H");
                yield return new Cards(28, "3H");
                yield return new Cards(29, "4H");
                yield return new Cards(30, "5H");
                yield return new Cards(31, "6H");
                yield return new Cards(32, "7H");
                yield return new Cards(33, "8H");
                yield return new Cards(34, "9H");
                yield return new Cards(35, "10H");
                yield return new Cards(36, "JH");
                yield return new Cards(37, "QH");
                yield return new Cards(38, "KH");
                yield return new Cards(39, "AH");
                yield return new Cards(40, "2S");
                yield return new Cards(41, "3S");
                yield return new Cards(42, "4S");
                yield return new Cards(43, "5S");
                yield return new Cards(44, "6S");
                yield return new Cards(45, "7S");
                yield return new Cards(46, "8S");
                yield return new Cards(47, "9S");
                yield return new Cards(48, "10S");
                yield return new Cards(49, "JS");
                yield return new Cards(50, "QS");
                yield return new Cards(51, "KS");
                yield return new Cards(52, "AS");
            }
        }
    }
}
