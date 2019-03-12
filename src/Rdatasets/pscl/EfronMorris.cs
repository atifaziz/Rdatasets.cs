// ReSharper disable All

namespace Rdatasets.pscl
{
    using System.Collections.Generic;

    /// <summary>
    /// Batting Averages for 18 major league baseball players, 1970
    /// </summary>

    public class EfronMorris
    {
        public readonly int κ;
        public readonly string name;
        public readonly string team;
        public readonly string league;
        public readonly int r;
        public readonly double y;
        public readonly int n;
        public readonly double p;

        public EfronMorris(int κ, string name, string team, string league, int r, double y, int n, double p)
        {
            this.κ = κ;
            this.name = name;
            this.team = team;
            this.league = league;
            this.r = r;
            this.y = y;
            this.n = n;
            this.p = p;
        }

        public static IEnumerable<EfronMorris> Data
        {
            get
            {
                yield return new EfronMorris(1, "Roberto Clemente", "Pitts", "NL", 18, 0.4, 367, 0.346);
                yield return new EfronMorris(2, "Frank Robinson", "Balt", "AL", 17, 0.378, 426, 0.298);
                yield return new EfronMorris(3, "Frank Howard", "Wash", "AL", 16, 0.356, 521, 0.276);
                yield return new EfronMorris(4, "Jay Johnstone", "Cal", "AL", 15, 0.333, 275, 0.222);
                yield return new EfronMorris(5, "Ken Berry", "Chi", "AL", 14, 0.311, 418, 0.273);
                yield return new EfronMorris(6, "Jim Spencer", "Cal", "AL", 14, 0.311, 466, 0.27);
                yield return new EfronMorris(7, "Don Kessinger", "Chi", "NL", 13, 0.289, 586, 0.263);
                yield return new EfronMorris(8, "Luis Alvarado", "Bos", "AL", 12, 0.267, 138, 0.21);
                yield return new EfronMorris(9, "Ron Santo", "Chi", "NL", 11, 0.244, 510, 0.269);
                yield return new EfronMorris(10, "Ron Swoboda", "NY", "NL", 11, 0.244, 200, 0.23);
                yield return new EfronMorris(11, "Del Unser", "Wash", "AL", 10, 0.222, 277, 0.264);
                yield return new EfronMorris(12, "Billy Williams", "Chi", "AL", 10, 0.222, 270, 0.256);
                yield return new EfronMorris(13, "George Scott", "Bos", "AL", 10, 0.222, 435, 0.303);
                yield return new EfronMorris(14, "Rico Petrocelli", "Bos", "AL", 10, 0.222, 538, 0.264);
                yield return new EfronMorris(15, "Ellie Rodriguez", "KC", "AL", 10, 0.222, 186, 0.226);
                yield return new EfronMorris(16, "Bert Campaneris", "Oak", "AL", 9, 0.2, 558, 0.285);
                yield return new EfronMorris(17, "Thurman Munson", "NY", "AL", 8, 0.178, 408, 0.316);
                yield return new EfronMorris(18, "Max Alvis", "Mil", "NL", 7, 0.156, 70, 0.2);
            }
        }
    }
}
