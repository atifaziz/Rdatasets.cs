// ReSharper disable All

namespace Rdatasets.vcd
{
    using System.Collections.Generic;

    /// <summary>
    /// Weldon's Dice Data
    /// </summary>

    public class WeldonDice
    {
        public readonly int n56;
        public readonly int Freq;

        public WeldonDice(int n56, int Freq)
        {
            this.n56 = n56;
            this.Freq = Freq;
        }

        public static IEnumerable<WeldonDice> Data
        {
            get
            {
                yield return new WeldonDice(0, 185);
                yield return new WeldonDice(1, 1149);
                yield return new WeldonDice(2, 3265);
                yield return new WeldonDice(3, 5475);
                yield return new WeldonDice(4, 6114);
                yield return new WeldonDice(5, 5194);
                yield return new WeldonDice(6, 3067);
                yield return new WeldonDice(7, 1331);
                yield return new WeldonDice(8, 403);
                yield return new WeldonDice(9, 105);
                yield return new WeldonDice(10, 18);
            }
        }
    }
}
