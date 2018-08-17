// ReSharper disable All

namespace Rdatasets.Stat2Data
{
    using System.Collections.Generic;

    /// <summary>
    /// BeeStings
    /// </summary>

    public class BeeStings
    {
        public readonly string Occasion;
        public readonly string Treatment;
        public readonly int Stingers;

        public BeeStings(string Occasion, string Treatment, int Stingers)
        {
            this.Occasion = Occasion;
            this.Treatment = Treatment;
            this.Stingers = Stingers;
        }

        public static IEnumerable<BeeStings> Data
        {
            get
            {
                yield return new BeeStings("I", "Stung", 27);
                yield return new BeeStings("II", "Stung", 9);
                yield return new BeeStings("III", "Stung", 33);
                yield return new BeeStings("IV", "Stung", 33);
                yield return new BeeStings("V", "Stung", 4);
                yield return new BeeStings("VI", "Stung", 22);
                yield return new BeeStings("VII", "Stung", 21);
                yield return new BeeStings("VIII", "Stung", 33);
                yield return new BeeStings("IX", "Stung", 70);
                yield return new BeeStings("I", "Fresh", 33);
                yield return new BeeStings("II", "Fresh", 9);
                yield return new BeeStings("III", "Fresh", 21);
                yield return new BeeStings("IV", "Fresh", 15);
                yield return new BeeStings("V", "Fresh", 6);
                yield return new BeeStings("VI", "Fresh", 16);
                yield return new BeeStings("VII", "Fresh", 19);
                yield return new BeeStings("VIII", "Fresh", 15);
                yield return new BeeStings("IX", "Fresh", 10);
            }
        }
    }
}
