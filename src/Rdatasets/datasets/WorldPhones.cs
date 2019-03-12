// ReSharper disable All

namespace Rdatasets.datasets
{
    using System.Collections.Generic;

    /// <summary>
    /// The World's Telephones
    /// </summary>

    public class WorldPhones
    {
        public readonly int κ;
        public readonly int N_Amer;
        public readonly int Europe;
        public readonly int Asia;
        public readonly int S_Amer;
        public readonly int Oceania;
        public readonly int Africa;
        public readonly int Mid_Amer;

        public WorldPhones(int κ, int N_Amer, int Europe, int Asia, int S_Amer, int Oceania, int Africa, int Mid_Amer)
        {
            this.κ = κ;
            this.N_Amer = N_Amer;
            this.Europe = Europe;
            this.Asia = Asia;
            this.S_Amer = S_Amer;
            this.Oceania = Oceania;
            this.Africa = Africa;
            this.Mid_Amer = Mid_Amer;
        }

        public static IEnumerable<WorldPhones> Data
        {
            get
            {
                yield return new WorldPhones(1951, 45939, 21574, 2876, 1815, 1646, 89, 555);
                yield return new WorldPhones(1956, 60423, 29990, 4708, 2568, 2366, 1411, 733);
                yield return new WorldPhones(1957, 64721, 32510, 5230, 2695, 2526, 1546, 773);
                yield return new WorldPhones(1958, 68484, 35218, 6662, 2845, 2691, 1663, 836);
                yield return new WorldPhones(1959, 71799, 37598, 6856, 3000, 2868, 1769, 911);
                yield return new WorldPhones(1960, 76036, 40341, 8220, 3145, 3054, 1905, 1008);
                yield return new WorldPhones(1961, 79831, 43173, 9053, 3338, 3224, 2005, 1076);
            }
        }
    }
}
