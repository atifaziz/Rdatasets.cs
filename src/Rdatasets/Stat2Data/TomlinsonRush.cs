// ReSharper disable All

namespace Rdatasets.Stat2Data
{
    using System.Collections.Generic;

    /// <summary>
    /// LaDainian Tomlinson Rushing Yards
    /// </summary>

    public class TomlinsonRush
    {
        public readonly int Game;
        public readonly string Opponent;
        public readonly int Attempts;
        public readonly int Yards;

        public TomlinsonRush(int Game, string Opponent, int Attempts, int Yards)
        {
            this.Game = Game;
            this.Opponent = Opponent;
            this.Attempts = Attempts;
            this.Yards = Yards;
        }

        public static IEnumerable<TomlinsonRush> Data
        {
            get
            {
                yield return new TomlinsonRush(1, "Raiders", 31, 131);
                yield return new TomlinsonRush(2, "Titans", 19, 71);
                yield return new TomlinsonRush(3, "Ravens", 27, 98);
                yield return new TomlinsonRush(4, "Steelers", 13, 36);
                yield return new TomlinsonRush(5, "49ers", 21, 71);
                yield return new TomlinsonRush(6, "Chiefs", 15, 66);
                yield return new TomlinsonRush(7, "Rams", 25, 183);
                yield return new TomlinsonRush(8, "Browns", 18, 172);
                yield return new TomlinsonRush(9, "Bengals", 22, 104);
                yield return new TomlinsonRush(10, "Broncos", 20, 105);
                yield return new TomlinsonRush(11, "Raiders", 19, 109);
                yield return new TomlinsonRush(12, "Bills", 28, 178);
                yield return new TomlinsonRush(13, "Broncos", 28, 103);
                yield return new TomlinsonRush(14, "Chiefs", 25, 199);
                yield return new TomlinsonRush(15, "Seahawks", 22, 123);
                yield return new TomlinsonRush(16, "Cardinals", 16, 66);
            }
        }
    }
}
