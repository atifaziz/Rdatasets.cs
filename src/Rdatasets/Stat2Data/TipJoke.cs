// ReSharper disable All

namespace Rdatasets.Stat2Data
{
    using System.Collections.Generic;

    /// <summary>
    /// Tip Joke
    /// </summary>

    public class TipJoke
    {
        public readonly string Card;
        public readonly int Tip;
        public readonly int Ad;
        public readonly int Joke;
        public readonly int None;

        public TipJoke(string Card, int Tip, int Ad, int Joke, int None)
        {
            this.Card = Card;
            this.Tip = Tip;
            this.Ad = Ad;
            this.Joke = Joke;
            this.None = None;
        }

        public static IEnumerable<TipJoke> Data
        {
            get
            {
                yield return new TipJoke("None", 1, 0, 0, 1);
                yield return new TipJoke("Joke", 1, 0, 1, 0);
                yield return new TipJoke("Ad", 0, 1, 0, 0);
                yield return new TipJoke("None", 0, 0, 0, 1);
                yield return new TipJoke("None", 1, 0, 0, 1);
                yield return new TipJoke("None", 0, 0, 0, 1);
                yield return new TipJoke("Ad", 0, 1, 0, 0);
                yield return new TipJoke("Ad", 0, 1, 0, 0);
                yield return new TipJoke("None", 0, 0, 0, 1);
                yield return new TipJoke("None", 0, 0, 0, 1);
                yield return new TipJoke("None", 1, 0, 0, 1);
                yield return new TipJoke("Ad", 0, 1, 0, 0);
                yield return new TipJoke("None", 0, 0, 0, 1);
                yield return new TipJoke("Ad", 1, 1, 0, 0);
                yield return new TipJoke("Joke", 1, 0, 1, 0);
                yield return new TipJoke("Joke", 0, 0, 1, 0);
                yield return new TipJoke("Joke", 1, 0, 1, 0);
                yield return new TipJoke("None", 0, 0, 0, 1);
                yield return new TipJoke("Joke", 0, 0, 1, 0);
                yield return new TipJoke("None", 0, 0, 0, 1);
                yield return new TipJoke("Ad", 1, 1, 0, 0);
                yield return new TipJoke("Ad", 1, 1, 0, 0);
                yield return new TipJoke("Ad", 0, 1, 0, 0);
                yield return new TipJoke("Joke", 0, 0, 1, 0);
                yield return new TipJoke("Joke", 1, 0, 1, 0);
                yield return new TipJoke("Joke", 0, 0, 1, 0);
                yield return new TipJoke("None", 1, 0, 0, 1);
                yield return new TipJoke("Joke", 1, 0, 1, 0);
                yield return new TipJoke("Joke", 1, 0, 1, 0);
                yield return new TipJoke("None", 1, 0, 0, 1);
                yield return new TipJoke("Joke", 0, 0, 1, 0);
                yield return new TipJoke("None", 1, 0, 0, 1);
                yield return new TipJoke("Joke", 1, 0, 1, 0);
                yield return new TipJoke("Ad", 0, 1, 0, 0);
                yield return new TipJoke("Joke", 0, 0, 1, 0);
                yield return new TipJoke("Ad", 1, 1, 0, 0);
                yield return new TipJoke("Joke", 0, 0, 1, 0);
                yield return new TipJoke("Ad", 0, 1, 0, 0);
                yield return new TipJoke("Joke", 0, 0, 1, 0);
                yield return new TipJoke("Joke", 0, 0, 1, 0);
                yield return new TipJoke("Joke", 1, 0, 1, 0);
                yield return new TipJoke("None", 0, 0, 0, 1);
                yield return new TipJoke("None", 0, 0, 0, 1);
                yield return new TipJoke("Ad", 0, 1, 0, 0);
                yield return new TipJoke("None", 0, 0, 0, 1);
                yield return new TipJoke("None", 0, 0, 0, 1);
                yield return new TipJoke("Ad", 0, 1, 0, 0);
                yield return new TipJoke("Joke", 0, 0, 1, 0);
                yield return new TipJoke("Joke", 1, 0, 1, 0);
                yield return new TipJoke("None", 1, 0, 0, 1);
                yield return new TipJoke("None", 0, 0, 0, 1);
                yield return new TipJoke("Joke", 1, 0, 1, 0);
                yield return new TipJoke("Joke", 1, 0, 1, 0);
                yield return new TipJoke("Joke", 0, 0, 1, 0);
                yield return new TipJoke("None", 1, 0, 0, 1);
                yield return new TipJoke("Ad", 0, 1, 0, 0);
                yield return new TipJoke("Joke", 0, 0, 1, 0);
                yield return new TipJoke("None", 0, 0, 0, 1);
                yield return new TipJoke("Ad", 0, 1, 0, 0);
                yield return new TipJoke("Joke", 1, 0, 1, 0);
                yield return new TipJoke("Ad", 0, 1, 0, 0);
                yield return new TipJoke("None", 1, 0, 0, 1);
                yield return new TipJoke("Joke", 0, 0, 1, 0);
                yield return new TipJoke("Ad", 0, 1, 0, 0);
                yield return new TipJoke("Joke", 0, 0, 1, 0);
                yield return new TipJoke("Ad", 0, 1, 0, 0);
                yield return new TipJoke("Ad", 0, 1, 0, 0);
                yield return new TipJoke("Ad", 0, 1, 0, 0);
                yield return new TipJoke("None", 0, 0, 0, 1);
                yield return new TipJoke("Joke", 1, 0, 1, 0);
                yield return new TipJoke("None", 1, 0, 0, 1);
                yield return new TipJoke("None", 0, 0, 0, 1);
                yield return new TipJoke("None", 0, 0, 0, 1);
                yield return new TipJoke("Joke", 0, 0, 1, 0);
                yield return new TipJoke("Ad", 1, 1, 0, 0);
                yield return new TipJoke("Ad", 0, 1, 0, 0);
                yield return new TipJoke("Ad", 1, 1, 0, 0);
                yield return new TipJoke("Joke", 0, 0, 1, 0);
                yield return new TipJoke("Joke", 0, 0, 1, 0);
                yield return new TipJoke("Ad", 1, 1, 0, 0);
                yield return new TipJoke("Ad", 0, 1, 0, 0);
                yield return new TipJoke("None", 0, 0, 0, 1);
                yield return new TipJoke("Ad", 0, 1, 0, 0);
                yield return new TipJoke("Joke", 0, 0, 1, 0);
                yield return new TipJoke("Joke", 0, 0, 1, 0);
                yield return new TipJoke("Ad", 1, 1, 0, 0);
                yield return new TipJoke("None", 1, 0, 0, 1);
                yield return new TipJoke("Joke", 1, 0, 1, 0);
                yield return new TipJoke("Ad", 0, 1, 0, 0);
                yield return new TipJoke("None", 0, 0, 0, 1);
                yield return new TipJoke("None", 0, 0, 0, 1);
                yield return new TipJoke("Joke", 0, 0, 1, 0);
                yield return new TipJoke("Joke", 0, 0, 1, 0);
                yield return new TipJoke("Ad", 0, 1, 0, 0);
                yield return new TipJoke("Ad", 0, 1, 0, 0);
                yield return new TipJoke("Ad", 0, 1, 0, 0);
                yield return new TipJoke("Joke", 1, 0, 1, 0);
                yield return new TipJoke("None", 0, 0, 0, 1);
                yield return new TipJoke("None", 0, 0, 0, 1);
                yield return new TipJoke("None", 1, 0, 0, 1);
                yield return new TipJoke("Joke", 0, 0, 1, 0);
                yield return new TipJoke("Joke", 0, 0, 1, 0);
                yield return new TipJoke("Ad", 1, 1, 0, 0);
                yield return new TipJoke("Ad", 0, 1, 0, 0);
                yield return new TipJoke("Ad", 0, 1, 0, 0);
                yield return new TipJoke("Ad", 1, 1, 0, 0);
                yield return new TipJoke("Ad", 0, 1, 0, 0);
                yield return new TipJoke("None", 0, 0, 0, 1);
                yield return new TipJoke("Ad", 0, 1, 0, 0);
                yield return new TipJoke("Joke", 1, 0, 1, 0);
                yield return new TipJoke("None", 0, 0, 0, 1);
                yield return new TipJoke("Ad", 0, 1, 0, 0);
                yield return new TipJoke("Ad", 0, 1, 0, 0);
                yield return new TipJoke("None", 0, 0, 0, 1);
                yield return new TipJoke("Ad", 0, 1, 0, 0);
                yield return new TipJoke("None", 0, 0, 0, 1);
                yield return new TipJoke("None", 0, 0, 0, 1);
                yield return new TipJoke("Ad", 0, 1, 0, 0);
                yield return new TipJoke("None", 1, 0, 0, 1);
                yield return new TipJoke("Ad", 1, 1, 0, 0);
                yield return new TipJoke("Ad", 0, 1, 0, 0);
                yield return new TipJoke("Ad", 1, 1, 0, 0);
                yield return new TipJoke("None", 0, 0, 0, 1);
                yield return new TipJoke("None", 0, 0, 0, 1);
                yield return new TipJoke("Joke", 1, 0, 1, 0);
                yield return new TipJoke("Joke", 1, 0, 1, 0);
                yield return new TipJoke("Ad", 0, 1, 0, 0);
                yield return new TipJoke("Joke", 0, 0, 1, 0);
                yield return new TipJoke("Joke", 0, 0, 1, 0);
                yield return new TipJoke("Ad", 0, 1, 0, 0);
                yield return new TipJoke("None", 0, 0, 0, 1);
                yield return new TipJoke("None", 0, 0, 0, 1);
                yield return new TipJoke("None", 0, 0, 0, 1);
                yield return new TipJoke("Joke", 1, 0, 1, 0);
                yield return new TipJoke("Ad", 0, 1, 0, 0);
                yield return new TipJoke("None", 0, 0, 0, 1);
                yield return new TipJoke("Joke", 0, 0, 1, 0);
                yield return new TipJoke("Ad", 0, 1, 0, 0);
                yield return new TipJoke("Ad", 0, 1, 0, 0);
                yield return new TipJoke("None", 0, 0, 0, 1);
                yield return new TipJoke("Joke", 0, 0, 1, 0);
                yield return new TipJoke("None", 0, 0, 0, 1);
                yield return new TipJoke("Ad", 0, 1, 0, 0);
                yield return new TipJoke("None", 1, 0, 0, 1);
                yield return new TipJoke("Joke", 0, 0, 1, 0);
                yield return new TipJoke("Ad", 0, 1, 0, 0);
                yield return new TipJoke("Ad", 0, 1, 0, 0);
                yield return new TipJoke("Ad", 0, 1, 0, 0);
                yield return new TipJoke("Joke", 1, 0, 1, 0);
                yield return new TipJoke("Ad", 1, 1, 0, 0);
                yield return new TipJoke("Joke", 1, 0, 1, 0);
                yield return new TipJoke("None", 0, 0, 0, 1);
                yield return new TipJoke("Ad", 0, 1, 0, 0);
                yield return new TipJoke("None", 0, 0, 0, 1);
                yield return new TipJoke("None", 0, 0, 0, 1);
                yield return new TipJoke("Ad", 0, 1, 0, 0);
                yield return new TipJoke("Ad", 0, 1, 0, 0);
                yield return new TipJoke("Joke", 0, 0, 1, 0);
                yield return new TipJoke("None", 0, 0, 0, 1);
                yield return new TipJoke("Joke", 1, 0, 1, 0);
                yield return new TipJoke("None", 1, 0, 0, 1);
                yield return new TipJoke("Ad", 1, 1, 0, 0);
                yield return new TipJoke("Joke", 0, 0, 1, 0);
                yield return new TipJoke("Joke", 0, 0, 1, 0);
                yield return new TipJoke("Ad", 0, 1, 0, 0);
                yield return new TipJoke("Joke", 1, 0, 1, 0);
                yield return new TipJoke("Joke", 1, 0, 1, 0);
                yield return new TipJoke("Ad", 0, 1, 0, 0);
                yield return new TipJoke("Joke", 1, 0, 1, 0);
                yield return new TipJoke("Joke", 0, 0, 1, 0);
                yield return new TipJoke("Ad", 0, 1, 0, 0);
                yield return new TipJoke("Joke", 0, 0, 1, 0);
                yield return new TipJoke("Joke", 0, 0, 1, 0);
                yield return new TipJoke("Ad", 0, 1, 0, 0);
                yield return new TipJoke("None", 0, 0, 0, 1);
                yield return new TipJoke("Joke", 1, 0, 1, 0);
                yield return new TipJoke("Ad", 0, 1, 0, 0);
                yield return new TipJoke("Joke", 0, 0, 1, 0);
                yield return new TipJoke("Joke", 0, 0, 1, 0);
                yield return new TipJoke("None", 0, 0, 0, 1);
                yield return new TipJoke("None", 0, 0, 0, 1);
                yield return new TipJoke("Ad", 0, 1, 0, 0);
                yield return new TipJoke("None", 0, 0, 0, 1);
                yield return new TipJoke("None", 0, 0, 0, 1);
                yield return new TipJoke("None", 0, 0, 0, 1);
                yield return new TipJoke("None", 0, 0, 0, 1);
                yield return new TipJoke("Ad", 0, 1, 0, 0);
                yield return new TipJoke("None", 1, 0, 0, 1);
                yield return new TipJoke("Ad", 0, 1, 0, 0);
                yield return new TipJoke("Ad", 0, 1, 0, 0);
                yield return new TipJoke("Ad", 0, 1, 0, 0);
                yield return new TipJoke("Joke", 1, 0, 1, 0);
                yield return new TipJoke("Joke", 0, 0, 1, 0);
                yield return new TipJoke("Ad", 0, 1, 0, 0);
                yield return new TipJoke("None", 0, 0, 0, 1);
                yield return new TipJoke("Joke", 1, 0, 1, 0);
                yield return new TipJoke("Joke", 0, 0, 1, 0);
                yield return new TipJoke("Joke", 1, 0, 1, 0);
                yield return new TipJoke("Ad", 0, 1, 0, 0);
                yield return new TipJoke("None", 0, 0, 0, 1);
                yield return new TipJoke("Joke", 1, 0, 1, 0);
                yield return new TipJoke("Joke", 0, 0, 1, 0);
                yield return new TipJoke("Joke", 0, 0, 1, 0);
                yield return new TipJoke("Ad", 0, 1, 0, 0);
                yield return new TipJoke("None", 0, 0, 0, 1);
                yield return new TipJoke("Ad", 0, 1, 0, 0);
                yield return new TipJoke("Ad", 0, 1, 0, 0);
                yield return new TipJoke("Joke", 0, 0, 1, 0);
                yield return new TipJoke("Ad", 0, 1, 0, 0);
                yield return new TipJoke("Joke", 0, 0, 1, 0);
                yield return new TipJoke("None", 0, 0, 0, 1);
            }
        }
    }
}
