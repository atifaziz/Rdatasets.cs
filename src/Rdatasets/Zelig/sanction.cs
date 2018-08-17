// ReSharper disable All

namespace Rdatasets.Zelig
{
    using System.Collections.Generic;

    /// <summary>
    /// Multilateral Economic Sanctions
    /// </summary>

    public class sanction
    {
        public readonly int mil;
        public readonly int coop;
        public readonly int target;
        public readonly int import;
        public readonly int export;
        public readonly int cost;
        public readonly int num;
        public readonly string ncost;

        public sanction(int mil, int coop, int target, int import, int export, int cost, int num, string ncost)
        {
            this.mil = mil;
            this.coop = coop;
            this.target = target;
            this.import = import;
            this.export = export;
            this.cost = cost;
            this.num = num;
            this.ncost = ncost;
        }

        public static IEnumerable<sanction> Data
        {
            get
            {
                yield return new sanction(1, 4, 3, 1, 1, 4, 15, "major loss");
                yield return new sanction(0, 2, 3, 0, 1, 3, 4, "modest loss");
                yield return new sanction(0, 1, 3, 1, 0, 2, 1, "little effect");
                yield return new sanction(1, 1, 3, 1, 1, 2, 1, "little effect");
                yield return new sanction(0, 1, 3, 1, 1, 2, 1, "little effect");
                yield return new sanction(0, 1, 3, 0, 1, 2, 1, "little effect");
                yield return new sanction(1, 2, 2, 0, 1, 2, 3, "little effect");
                yield return new sanction(0, 1, 3, 0, 0, 2, 3, "little effect");
                yield return new sanction(0, 2, 1, 0, 0, 1, 2, "net gain");
                yield return new sanction(1, 2, 3, 1, 1, 2, 1, "little effect");
                yield return new sanction(1, 1, 2, 0, 0, 1, 1, "net gain");
                yield return new sanction(0, 1, 2, 1, 1, 2, 1, "little effect");
                yield return new sanction(0, 3, 1, 1, 1, 2, 8, "little effect");
                yield return new sanction(0, 3, 3, 1, 1, 4, 7, "major loss");
                yield return new sanction(0, 3, 2, 1, 1, 3, 21, "modest loss");
                yield return new sanction(0, 1, 2, 0, 0, 1, 1, "net gain");
                yield return new sanction(0, 4, 2, 1, 1, 2, 7, "little effect");
                yield return new sanction(0, 3, 3, 0, 0, 2, 4, "little effect");
                yield return new sanction(0, 1, 1, 0, 0, 1, 1, "net gain");
                yield return new sanction(0, 3, 3, 1, 0, 3, 120, "modest loss");
                yield return new sanction(0, 4, 3, 0, 0, 2, 7, "little effect");
                yield return new sanction(0, 1, 2, 0, 0, 1, 1, "net gain");
                yield return new sanction(0, 1, 2, 1, 1, 4, 1, "major loss");
                yield return new sanction(0, 1, 2, 0, 0, 1, 1, "net gain");
                yield return new sanction(0, 1, 1, 0, 0, 1, 1, "net gain");
                yield return new sanction(0, 3, 2, 1, 1, 2, 32, "little effect");
                yield return new sanction(0, 1, 2, 1, 0, 2, 1, "little effect");
                yield return new sanction(0, 1, 2, 1, 0, 2, 1, "little effect");
                yield return new sanction(0, 1, 2, 0, 0, 1, 1, "net gain");
                yield return new sanction(0, 4, 2, 1, 1, 3, 150, "modest loss");
                yield return new sanction(0, 1, 2, 0, 0, 1, 1, "net gain");
                yield return new sanction(0, 1, 2, 0, 0, 1, 1, "net gain");
                yield return new sanction(0, 1, 1, 0, 0, 1, 1, "net gain");
                yield return new sanction(0, 1, 2, 0, 1, 1, 5, "net gain");
                yield return new sanction(0, 2, 1, 1, 1, 2, 2, "little effect");
                yield return new sanction(0, 3, 3, 0, 1, 1, 10, "net gain");
                yield return new sanction(0, 1, 2, 0, 0, 1, 1, "net gain");
                yield return new sanction(0, 1, 1, 0, 0, 1, 1, "net gain");
                yield return new sanction(0, 1, 2, 0, 0, 1, 1, "net gain");
                yield return new sanction(0, 2, 3, 0, 1, 2, 2, "little effect");
                yield return new sanction(0, 2, 2, 0, 1, 2, 1, "little effect");
                yield return new sanction(0, 2, 3, 0, 0, 2, 2, "little effect");
                yield return new sanction(0, 1, 3, 1, 0, 2, 1, "little effect");
                yield return new sanction(0, 2, 3, 0, 1, 2, 1, "little effect");
                yield return new sanction(0, 1, 1, 1, 1, 1, 1, "net gain");
                yield return new sanction(0, 1, 2, 0, 1, 1, 1, "net gain");
                yield return new sanction(0, 1, 3, 0, 1, 2, 1, "little effect");
                yield return new sanction(0, 2, 1, 1, 0, 1, 1, "net gain");
                yield return new sanction(0, 1, 3, 0, 0, 1, 1, "net gain");
                yield return new sanction(0, 1, 2, 0, 0, 1, 1, "net gain");
                yield return new sanction(0, 1, 2, 0, 1, 2, 1, "little effect");
                yield return new sanction(0, 1, 3, 0, 1, 2, 1, "little effect");
                yield return new sanction(0, 1, 1, 0, 1, 1, 1, "net gain");
                yield return new sanction(0, 1, 1, 0, 0, 1, 2, "net gain");
                yield return new sanction(0, 1, 2, 0, 0, 1, 1, "net gain");
                yield return new sanction(0, 1, 2, 0, 1, 2, 1, "little effect");
                yield return new sanction(0, 2, 2, 0, 1, 2, 3, "little effect");
                yield return new sanction(0, 2, 3, 0, 1, 2, 2, "little effect");
                yield return new sanction(0, 2, 3, 0, 1, 2, 2, "little effect");
                yield return new sanction(0, 3, 2, 1, 1, 3, 9, "modest loss");
                yield return new sanction(1, 3, 2, 0, 0, 1, 7, "net gain");
                yield return new sanction(0, 1, 3, 1, 1, 3, 1, "modest loss");
                yield return new sanction(0, 3, 1, 1, 1, 3, 10, "modest loss");
                yield return new sanction(0, 2, 2, 0, 0, 1, 2, "net gain");
                yield return new sanction(0, 3, 3, 1, 1, 2, 8, "little effect");
                yield return new sanction(0, 2, 1, 0, 0, 1, 2, "net gain");
                yield return new sanction(0, 3, 3, 0, 1, 3, 13, "modest loss");
                yield return new sanction(0, 1, 2, 0, 1, 2, 1, "little effect");
                yield return new sanction(0, 1, 2, 1, 0, 2, 1, "little effect");
                yield return new sanction(0, 3, 1, 1, 1, 2, 4, "little effect");
                yield return new sanction(0, 2, 3, 0, 1, 3, 1, "modest loss");
                yield return new sanction(0, 2, 2, 0, 0, 1, 8, "net gain");
                yield return new sanction(1, 3, 1, 1, 1, 2, 14, "little effect");
                yield return new sanction(0, 2, 1, 0, 0, 1, 2, "net gain");
                yield return new sanction(0, 1, 3, 0, 1, 2, 1, "little effect");
                yield return new sanction(0, 4, 3, 1, 0, 2, 13, "little effect");
                yield return new sanction(0, 1, 2, 0, 0, 1, 1, "net gain");
                yield return new sanction(1, 3, 1, 1, 1, 2, 10, "little effect");
            }
        }
    }
}
