// ReSharper disable All

namespace Rdatasets.mosaicData
{
    using System.Collections.Generic;

    /// <summary>
    /// Standard Deck of Cards
    /// </summary>

    public class Cards
    {
        public readonly string dat;

        public Cards(string dat)
        {
            this.dat = dat;
        }

        public static IEnumerable<Cards> Data
        {
            get
            {
                yield return new Cards("2C");
                yield return new Cards("3C");
                yield return new Cards("4C");
                yield return new Cards("5C");
                yield return new Cards("6C");
                yield return new Cards("7C");
                yield return new Cards("8C");
                yield return new Cards("9C");
                yield return new Cards("10C");
                yield return new Cards("JC");
                yield return new Cards("QC");
                yield return new Cards("KC");
                yield return new Cards("AC");
                yield return new Cards("2D");
                yield return new Cards("3D");
                yield return new Cards("4D");
                yield return new Cards("5D");
                yield return new Cards("6D");
                yield return new Cards("7D");
                yield return new Cards("8D");
                yield return new Cards("9D");
                yield return new Cards("10D");
                yield return new Cards("JD");
                yield return new Cards("QD");
                yield return new Cards("KD");
                yield return new Cards("AD");
                yield return new Cards("2H");
                yield return new Cards("3H");
                yield return new Cards("4H");
                yield return new Cards("5H");
                yield return new Cards("6H");
                yield return new Cards("7H");
                yield return new Cards("8H");
                yield return new Cards("9H");
                yield return new Cards("10H");
                yield return new Cards("JH");
                yield return new Cards("QH");
                yield return new Cards("KH");
                yield return new Cards("AH");
                yield return new Cards("2S");
                yield return new Cards("3S");
                yield return new Cards("4S");
                yield return new Cards("5S");
                yield return new Cards("6S");
                yield return new Cards("7S");
                yield return new Cards("8S");
                yield return new Cards("9S");
                yield return new Cards("10S");
                yield return new Cards("JS");
                yield return new Cards("QS");
                yield return new Cards("KS");
                yield return new Cards("AS");
            }
        }
    }
}
