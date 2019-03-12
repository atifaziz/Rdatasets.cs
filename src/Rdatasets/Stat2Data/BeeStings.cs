// ReSharper disable All

namespace Rdatasets.Stat2Data
{
    using System.Collections.Generic;

    /// <summary>
    /// BeeStings
    /// </summary>

    public class BeeStings
    {
        public readonly int κ;
        public readonly string Occasion;
        public readonly string Treatment;
        public readonly int Stingers;

        public BeeStings(int κ, string Occasion, string Treatment, int Stingers)
        {
            this.κ = κ;
            this.Occasion = Occasion;
            this.Treatment = Treatment;
            this.Stingers = Stingers;
        }

        public static IEnumerable<BeeStings> Data
        {
            get
            {
                yield return new BeeStings(1, "I", "Stung", 27);
                yield return new BeeStings(2, "II", "Stung", 9);
                yield return new BeeStings(3, "III", "Stung", 33);
                yield return new BeeStings(4, "IV", "Stung", 33);
                yield return new BeeStings(5, "V", "Stung", 4);
                yield return new BeeStings(6, "VI", "Stung", 22);
                yield return new BeeStings(7, "VII", "Stung", 21);
                yield return new BeeStings(8, "VIII", "Stung", 33);
                yield return new BeeStings(9, "IX", "Stung", 70);
                yield return new BeeStings(10, "I", "Fresh", 33);
                yield return new BeeStings(11, "II", "Fresh", 9);
                yield return new BeeStings(12, "III", "Fresh", 21);
                yield return new BeeStings(13, "IV", "Fresh", 15);
                yield return new BeeStings(14, "V", "Fresh", 6);
                yield return new BeeStings(15, "VI", "Fresh", 16);
                yield return new BeeStings(16, "VII", "Fresh", 19);
                yield return new BeeStings(17, "VIII", "Fresh", 15);
                yield return new BeeStings(18, "IX", "Fresh", 10);
            }
        }
    }
}
