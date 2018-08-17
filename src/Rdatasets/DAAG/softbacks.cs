// ReSharper disable All

namespace Rdatasets.DAAG
{
    using System.Collections.Generic;

    /// <summary>
    /// Measurements on a Selection of Paperback Books
    /// </summary>

    public class softbacks
    {
        public readonly int volume;
        public readonly int weight;

        public softbacks(int volume, int weight)
        {
            this.volume = volume;
            this.weight = weight;
        }

        public static IEnumerable<softbacks> Data
        {
            get
            {
                yield return new softbacks(412, 250);
                yield return new softbacks(953, 700);
                yield return new softbacks(929, 650);
                yield return new softbacks(1492, 975);
                yield return new softbacks(419, 350);
                yield return new softbacks(1010, 950);
                yield return new softbacks(595, 425);
                yield return new softbacks(1034, 725);
            }
        }
    }
}
