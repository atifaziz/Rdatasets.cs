// ReSharper disable All

namespace Rdatasets.DAAG
{
    using System.Collections.Generic;

    /// <summary>
    /// Measurements on a Selection of Paperback Books
    /// </summary>

    public class softbacks
    {
        public readonly int κ;
        public readonly int volume;
        public readonly int weight;

        public softbacks(int κ, int volume, int weight)
        {
            this.κ = κ;
            this.volume = volume;
            this.weight = weight;
        }

        public static IEnumerable<softbacks> Data
        {
            get
            {
                yield return new softbacks(1, 412, 250);
                yield return new softbacks(2, 953, 700);
                yield return new softbacks(3, 929, 650);
                yield return new softbacks(4, 1492, 975);
                yield return new softbacks(5, 419, 350);
                yield return new softbacks(6, 1010, 950);
                yield return new softbacks(7, 595, 425);
                yield return new softbacks(8, 1034, 725);
            }
        }
    }
}
