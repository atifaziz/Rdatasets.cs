// ReSharper disable All

namespace Rdatasets.Stat2Data
{
    using System.Collections.Generic;

    /// <summary>
    /// LaDainian Tomlinson Rushing Yards
    /// </summary>

    public class TomlinsonRush
    {
        public readonly int κ;
        public readonly int Game;
        public readonly string Opponent;
        public readonly int Attempts;
        public readonly int Yards;

        public TomlinsonRush(int κ, int Game, string Opponent, int Attempts, int Yards)
        {
            this.κ = κ;
            this.Game = Game;
            this.Opponent = Opponent;
            this.Attempts = Attempts;
            this.Yards = Yards;
        }

        public static IEnumerable<TomlinsonRush> Data
        {
            get
            {
                yield return new TomlinsonRush(1, 1, "Raiders", 31, 131);
                yield return new TomlinsonRush(2, 2, "Titans", 19, 71);
                yield return new TomlinsonRush(3, 3, "Ravens", 27, 98);
                yield return new TomlinsonRush(4, 4, "Steelers", 13, 36);
                yield return new TomlinsonRush(5, 5, "49ers", 21, 71);
                yield return new TomlinsonRush(6, 6, "Chiefs", 15, 66);
                yield return new TomlinsonRush(7, 7, "Rams", 25, 183);
                yield return new TomlinsonRush(8, 8, "Browns", 18, 172);
                yield return new TomlinsonRush(9, 9, "Bengals", 22, 104);
                yield return new TomlinsonRush(10, 10, "Broncos", 20, 105);
                yield return new TomlinsonRush(11, 11, "Raiders", 19, 109);
                yield return new TomlinsonRush(12, 12, "Bills", 28, 178);
                yield return new TomlinsonRush(13, 13, "Broncos", 28, 103);
                yield return new TomlinsonRush(14, 14, "Chiefs", 25, 199);
                yield return new TomlinsonRush(15, 15, "Seahawks", 22, 123);
                yield return new TomlinsonRush(16, 16, "Cardinals", 16, 66);
            }
        }
    }
}
