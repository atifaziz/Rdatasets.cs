// ReSharper disable All

namespace Rdatasets.vcd
{
    using System.Collections.Generic;

    /// <summary>
    /// Weldon's Dice Data
    /// </summary>

    public class WeldonDice
    {
        public readonly int κ;
        public readonly int n56;
        public readonly int Freq;

        public WeldonDice(int κ, int n56, int Freq)
        {
            this.κ = κ;
            this.n56 = n56;
            this.Freq = Freq;
        }

        public static IEnumerable<WeldonDice> Data
        {
            get
            {
                yield return new WeldonDice(1, 0, 185);
                yield return new WeldonDice(2, 1, 1149);
                yield return new WeldonDice(3, 2, 3265);
                yield return new WeldonDice(4, 3, 5475);
                yield return new WeldonDice(5, 4, 6114);
                yield return new WeldonDice(6, 5, 5194);
                yield return new WeldonDice(7, 6, 3067);
                yield return new WeldonDice(8, 7, 1331);
                yield return new WeldonDice(9, 8, 403);
                yield return new WeldonDice(10, 9, 105);
                yield return new WeldonDice(11, 10, 18);
            }
        }
    }
}
