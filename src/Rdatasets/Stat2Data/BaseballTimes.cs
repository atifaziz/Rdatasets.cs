// ReSharper disable All

namespace Rdatasets.Stat2Data
{
    using System.Collections.Generic;

    /// <summary>
    /// BaseballTimes
    /// </summary>

    public class BaseballTimes
    {
        public readonly int κ;
        public readonly string Game;
        public readonly string League;
        public readonly int Runs;
        public readonly int Margin;
        public readonly int Pitchers;
        public readonly int Attendance;
        public readonly int Time;

        public BaseballTimes(int κ, string Game, string League, int Runs, int Margin, int Pitchers, int Attendance, int Time)
        {
            this.κ = κ;
            this.Game = Game;
            this.League = League;
            this.Runs = Runs;
            this.Margin = Margin;
            this.Pitchers = Pitchers;
            this.Attendance = Attendance;
            this.Time = Time;
        }

        public static IEnumerable<BaseballTimes> Data
        {
            get
            {
                yield return new BaseballTimes(1, "CLE-DET", "AL", 14, 6, 6, 38774, 168);
                yield return new BaseballTimes(2, "CHI-BAL", "AL", 11, 5, 5, 15398, 164);
                yield return new BaseballTimes(3, "BOS-NYY", "AL", 10, 4, 11, 55058, 202);
                yield return new BaseballTimes(4, "TOR-TAM", "AL", 8, 4, 10, 13478, 172);
                yield return new BaseballTimes(5, "TEX-KC", "AL", 3, 1, 4, 17004, 151);
                yield return new BaseballTimes(6, "OAK-LAA", "AL", 6, 4, 4, 37431, 133);
                yield return new BaseballTimes(7, "MIN-SEA", "AL", 5, 1, 5, 26292, 151);
                yield return new BaseballTimes(8, "CHI-PIT", "NL", 23, 5, 14, 17929, 239);
                yield return new BaseballTimes(9, "LAD-WAS", "NL", 3, 1, 6, 26110, 156);
                yield return new BaseballTimes(10, "FLA-ATL", "NL", 19, 1, 12, 17539, 211);
                yield return new BaseballTimes(11, "CIN-HOU", "NL", 3, 1, 4, 30395, 147);
                yield return new BaseballTimes(12, "MIL-STL", "NL", 12, 12, 9, 41121, 185);
                yield return new BaseballTimes(13, "ARI-SD", "NL", 11, 7, 10, 32104, 164);
                yield return new BaseballTimes(14, "COL-SF", "NL", 9, 5, 7, 32695, 180);
                yield return new BaseballTimes(15, "NYM-PHI", "NL", 15, 1, 16, 45204, 317);
            }
        }
    }
}
