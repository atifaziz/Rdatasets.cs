// ReSharper disable All

namespace Rdatasets.pscl
{
    using System.Collections.Generic;

    /// <summary>
    /// Batting Averages for 18 major league baseball players, 1970
    /// </summary>

    public class EfronMorris
    {
        public readonly string name;
        public readonly string team;
        public readonly string league;
        public readonly int r;
        public readonly double y;
        public readonly int n;
        public readonly double p;

        public EfronMorris(string name, string team, string league, int r, double y, int n, double p)
        {
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
                yield return new EfronMorris("Roberto Clemente", "Pitts", "NL", 18, 0.4, 367, 0.346);
                yield return new EfronMorris("Frank Robinson", "Balt", "AL", 17, 0.378, 426, 0.298);
                yield return new EfronMorris("Frank Howard", "Wash", "AL", 16, 0.356, 521, 0.276);
                yield return new EfronMorris("Jay Johnstone", "Cal", "AL", 15, 0.333, 275, 0.222);
                yield return new EfronMorris("Ken Berry", "Chi", "AL", 14, 0.311, 418, 0.273);
                yield return new EfronMorris("Jim Spencer", "Cal", "AL", 14, 0.311, 466, 0.27);
                yield return new EfronMorris("Don Kessinger", "Chi", "NL", 13, 0.289, 586, 0.263);
                yield return new EfronMorris("Luis Alvarado", "Bos", "AL", 12, 0.267, 138, 0.21);
                yield return new EfronMorris("Ron Santo", "Chi", "NL", 11, 0.244, 510, 0.269);
                yield return new EfronMorris("Ron Swoboda", "NY", "NL", 11, 0.244, 200, 0.23);
                yield return new EfronMorris("Del Unser", "Wash", "AL", 10, 0.222, 277, 0.264);
                yield return new EfronMorris("Billy Williams", "Chi", "AL", 10, 0.222, 270, 0.256);
                yield return new EfronMorris("George Scott", "Bos", "AL", 10, 0.222, 435, 0.303);
                yield return new EfronMorris("Rico Petrocelli", "Bos", "AL", 10, 0.222, 538, 0.264);
                yield return new EfronMorris("Ellie Rodriguez", "KC", "AL", 10, 0.222, 186, 0.226);
                yield return new EfronMorris("Bert Campaneris", "Oak", "AL", 9, 0.2, 558, 0.285);
                yield return new EfronMorris("Thurman Munson", "NY", "AL", 8, 0.178, 408, 0.316);
                yield return new EfronMorris("Max Alvis", "Mil", "NL", 7, 0.156, 70, 0.2);
            }
        }
    }
}
