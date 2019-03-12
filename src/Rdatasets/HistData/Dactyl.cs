// ReSharper disable All

namespace Rdatasets.HistData
{
    using System.Collections.Generic;

    /// <summary>
    /// Edgeworth's counts of dactyls in Virgil's Aeneid
    /// </summary>

    public class Dactyl
    {
        public readonly int κ;
        public readonly int Foot;
        public readonly string Lines;
        public readonly int count;

        public Dactyl(int κ, int Foot, string Lines, int count)
        {
            this.κ = κ;
            this.Foot = Foot;
            this.Lines = Lines;
            this.count = count;
        }

        public static IEnumerable<Dactyl> Data
        {
            get
            {
                yield return new Dactyl(1, 1, "1:5", 3);
                yield return new Dactyl(2, 1, "6:10", 3);
                yield return new Dactyl(3, 1, "11:15", 5);
                yield return new Dactyl(4, 1, "16:20", 5);
                yield return new Dactyl(5, 1, "21:25", 4);
                yield return new Dactyl(6, 1, "26:30", 4);
                yield return new Dactyl(7, 1, "31:35", 2);
                yield return new Dactyl(8, 1, "36:40", 2);
                yield return new Dactyl(9, 1, "41:45", 2);
                yield return new Dactyl(10, 1, "46:50", 1);
                yield return new Dactyl(11, 1, "51:55", 2);
                yield return new Dactyl(12, 1, "56:60", 4);
                yield return new Dactyl(13, 1, "61:65", 3);
                yield return new Dactyl(14, 1, "66:70", 2);
                yield return new Dactyl(15, 1, "71:75", 4);
                yield return new Dactyl(16, 2, "1:5", 1);
                yield return new Dactyl(17, 2, "6:10", 4);
                yield return new Dactyl(18, 2, "11:15", 0);
                yield return new Dactyl(19, 2, "16:20", 3);
                yield return new Dactyl(20, 2, "21:25", 3);
                yield return new Dactyl(21, 2, "26:30", 3);
                yield return new Dactyl(22, 2, "31:35", 5);
                yield return new Dactyl(23, 2, "36:40", 2);
                yield return new Dactyl(24, 2, "41:45", 2);
                yield return new Dactyl(25, 2, "46:50", 4);
                yield return new Dactyl(26, 2, "51:55", 3);
                yield return new Dactyl(27, 2, "56:60", 1);
                yield return new Dactyl(28, 2, "61:65", 2);
                yield return new Dactyl(29, 2, "66:70", 3);
                yield return new Dactyl(30, 2, "71:75", 2);
                yield return new Dactyl(31, 3, "1:5", 1);
                yield return new Dactyl(32, 3, "6:10", 2);
                yield return new Dactyl(33, 3, "11:15", 4);
                yield return new Dactyl(34, 3, "16:20", 2);
                yield return new Dactyl(35, 3, "21:25", 5);
                yield return new Dactyl(36, 3, "26:30", 2);
                yield return new Dactyl(37, 3, "31:35", 1);
                yield return new Dactyl(38, 3, "36:40", 2);
                yield return new Dactyl(39, 3, "41:45", 2);
                yield return new Dactyl(40, 3, "46:50", 2);
                yield return new Dactyl(41, 3, "51:55", 0);
                yield return new Dactyl(42, 3, "56:60", 2);
                yield return new Dactyl(43, 3, "61:65", 2);
                yield return new Dactyl(44, 3, "66:70", 0);
                yield return new Dactyl(45, 3, "71:75", 1);
                yield return new Dactyl(46, 4, "1:5", 2);
                yield return new Dactyl(47, 4, "6:10", 2);
                yield return new Dactyl(48, 4, "11:15", 1);
                yield return new Dactyl(49, 4, "16:20", 0);
                yield return new Dactyl(50, 4, "21:25", 3);
                yield return new Dactyl(51, 4, "26:30", 1);
                yield return new Dactyl(52, 4, "31:35", 2);
                yield return new Dactyl(53, 4, "36:40", 0);
                yield return new Dactyl(54, 4, "41:45", 2);
                yield return new Dactyl(55, 4, "46:50", 1);
                yield return new Dactyl(56, 4, "51:55", 1);
                yield return new Dactyl(57, 4, "56:60", 2);
                yield return new Dactyl(58, 4, "61:65", 1);
                yield return new Dactyl(59, 4, "66:70", 1);
                yield return new Dactyl(60, 4, "71:75", 0);
            }
        }
    }
}
