// ReSharper disable All

namespace Rdatasets.HistData
{
    using System.Collections.Generic;

    /// <summary>
    /// Edgeworth's counts of dactyls in Virgil's Aeneid
    /// </summary>

    public class Dactyl
    {
        public readonly int Foot;
        public readonly string Lines;
        public readonly int count;

        public Dactyl(int Foot, string Lines, int count)
        {
            this.Foot = Foot;
            this.Lines = Lines;
            this.count = count;
        }

        public static IEnumerable<Dactyl> Data
        {
            get
            {
                yield return new Dactyl(1, "1:5", 3);
                yield return new Dactyl(1, "6:10", 3);
                yield return new Dactyl(1, "11:15", 5);
                yield return new Dactyl(1, "16:20", 5);
                yield return new Dactyl(1, "21:25", 4);
                yield return new Dactyl(1, "26:30", 4);
                yield return new Dactyl(1, "31:35", 2);
                yield return new Dactyl(1, "36:40", 2);
                yield return new Dactyl(1, "41:45", 2);
                yield return new Dactyl(1, "46:50", 1);
                yield return new Dactyl(1, "51:55", 2);
                yield return new Dactyl(1, "56:60", 4);
                yield return new Dactyl(1, "61:65", 3);
                yield return new Dactyl(1, "66:70", 2);
                yield return new Dactyl(1, "71:75", 4);
                yield return new Dactyl(2, "1:5", 1);
                yield return new Dactyl(2, "6:10", 4);
                yield return new Dactyl(2, "11:15", 0);
                yield return new Dactyl(2, "16:20", 3);
                yield return new Dactyl(2, "21:25", 3);
                yield return new Dactyl(2, "26:30", 3);
                yield return new Dactyl(2, "31:35", 5);
                yield return new Dactyl(2, "36:40", 2);
                yield return new Dactyl(2, "41:45", 2);
                yield return new Dactyl(2, "46:50", 4);
                yield return new Dactyl(2, "51:55", 3);
                yield return new Dactyl(2, "56:60", 1);
                yield return new Dactyl(2, "61:65", 2);
                yield return new Dactyl(2, "66:70", 3);
                yield return new Dactyl(2, "71:75", 2);
                yield return new Dactyl(3, "1:5", 1);
                yield return new Dactyl(3, "6:10", 2);
                yield return new Dactyl(3, "11:15", 4);
                yield return new Dactyl(3, "16:20", 2);
                yield return new Dactyl(3, "21:25", 5);
                yield return new Dactyl(3, "26:30", 2);
                yield return new Dactyl(3, "31:35", 1);
                yield return new Dactyl(3, "36:40", 2);
                yield return new Dactyl(3, "41:45", 2);
                yield return new Dactyl(3, "46:50", 2);
                yield return new Dactyl(3, "51:55", 0);
                yield return new Dactyl(3, "56:60", 2);
                yield return new Dactyl(3, "61:65", 2);
                yield return new Dactyl(3, "66:70", 0);
                yield return new Dactyl(3, "71:75", 1);
                yield return new Dactyl(4, "1:5", 2);
                yield return new Dactyl(4, "6:10", 2);
                yield return new Dactyl(4, "11:15", 1);
                yield return new Dactyl(4, "16:20", 0);
                yield return new Dactyl(4, "21:25", 3);
                yield return new Dactyl(4, "26:30", 1);
                yield return new Dactyl(4, "31:35", 2);
                yield return new Dactyl(4, "36:40", 0);
                yield return new Dactyl(4, "41:45", 2);
                yield return new Dactyl(4, "46:50", 1);
                yield return new Dactyl(4, "51:55", 1);
                yield return new Dactyl(4, "56:60", 2);
                yield return new Dactyl(4, "61:65", 1);
                yield return new Dactyl(4, "66:70", 1);
                yield return new Dactyl(4, "71:75", 0);
            }
        }
    }
}
