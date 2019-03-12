// ReSharper disable All

namespace Rdatasets.Zelig
{
    using System.Collections.Generic;

    /// <summary>
    /// Multilateral Economic Sanctions
    /// </summary>

    public class sanction
    {
        public readonly int κ;
        public readonly int mil;
        public readonly int coop;
        public readonly int target;
        public readonly int import;
        public readonly int export;
        public readonly int cost;
        public readonly int num;
        public readonly string ncost;

        public sanction(int κ, int mil, int coop, int target, int import, int export, int cost, int num, string ncost)
        {
            this.κ = κ;
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
                yield return new sanction(1, 1, 4, 3, 1, 1, 4, 15, "major loss");
                yield return new sanction(2, 0, 2, 3, 0, 1, 3, 4, "modest loss");
                yield return new sanction(3, 0, 1, 3, 1, 0, 2, 1, "little effect");
                yield return new sanction(4, 1, 1, 3, 1, 1, 2, 1, "little effect");
                yield return new sanction(5, 0, 1, 3, 1, 1, 2, 1, "little effect");
                yield return new sanction(6, 0, 1, 3, 0, 1, 2, 1, "little effect");
                yield return new sanction(7, 1, 2, 2, 0, 1, 2, 3, "little effect");
                yield return new sanction(8, 0, 1, 3, 0, 0, 2, 3, "little effect");
                yield return new sanction(9, 0, 2, 1, 0, 0, 1, 2, "net gain");
                yield return new sanction(10, 1, 2, 3, 1, 1, 2, 1, "little effect");
                yield return new sanction(11, 1, 1, 2, 0, 0, 1, 1, "net gain");
                yield return new sanction(12, 0, 1, 2, 1, 1, 2, 1, "little effect");
                yield return new sanction(13, 0, 3, 1, 1, 1, 2, 8, "little effect");
                yield return new sanction(14, 0, 3, 3, 1, 1, 4, 7, "major loss");
                yield return new sanction(15, 0, 3, 2, 1, 1, 3, 21, "modest loss");
                yield return new sanction(16, 0, 1, 2, 0, 0, 1, 1, "net gain");
                yield return new sanction(17, 0, 4, 2, 1, 1, 2, 7, "little effect");
                yield return new sanction(18, 0, 3, 3, 0, 0, 2, 4, "little effect");
                yield return new sanction(19, 0, 1, 1, 0, 0, 1, 1, "net gain");
                yield return new sanction(20, 0, 3, 3, 1, 0, 3, 120, "modest loss");
                yield return new sanction(21, 0, 4, 3, 0, 0, 2, 7, "little effect");
                yield return new sanction(22, 0, 1, 2, 0, 0, 1, 1, "net gain");
                yield return new sanction(23, 0, 1, 2, 1, 1, 4, 1, "major loss");
                yield return new sanction(24, 0, 1, 2, 0, 0, 1, 1, "net gain");
                yield return new sanction(25, 0, 1, 1, 0, 0, 1, 1, "net gain");
                yield return new sanction(26, 0, 3, 2, 1, 1, 2, 32, "little effect");
                yield return new sanction(27, 0, 1, 2, 1, 0, 2, 1, "little effect");
                yield return new sanction(28, 0, 1, 2, 1, 0, 2, 1, "little effect");
                yield return new sanction(29, 0, 1, 2, 0, 0, 1, 1, "net gain");
                yield return new sanction(30, 0, 4, 2, 1, 1, 3, 150, "modest loss");
                yield return new sanction(31, 0, 1, 2, 0, 0, 1, 1, "net gain");
                yield return new sanction(32, 0, 1, 2, 0, 0, 1, 1, "net gain");
                yield return new sanction(33, 0, 1, 1, 0, 0, 1, 1, "net gain");
                yield return new sanction(34, 0, 1, 2, 0, 1, 1, 5, "net gain");
                yield return new sanction(35, 0, 2, 1, 1, 1, 2, 2, "little effect");
                yield return new sanction(36, 0, 3, 3, 0, 1, 1, 10, "net gain");
                yield return new sanction(37, 0, 1, 2, 0, 0, 1, 1, "net gain");
                yield return new sanction(38, 0, 1, 1, 0, 0, 1, 1, "net gain");
                yield return new sanction(39, 0, 1, 2, 0, 0, 1, 1, "net gain");
                yield return new sanction(40, 0, 2, 3, 0, 1, 2, 2, "little effect");
                yield return new sanction(41, 0, 2, 2, 0, 1, 2, 1, "little effect");
                yield return new sanction(42, 0, 2, 3, 0, 0, 2, 2, "little effect");
                yield return new sanction(43, 0, 1, 3, 1, 0, 2, 1, "little effect");
                yield return new sanction(44, 0, 2, 3, 0, 1, 2, 1, "little effect");
                yield return new sanction(45, 0, 1, 1, 1, 1, 1, 1, "net gain");
                yield return new sanction(46, 0, 1, 2, 0, 1, 1, 1, "net gain");
                yield return new sanction(47, 0, 1, 3, 0, 1, 2, 1, "little effect");
                yield return new sanction(48, 0, 2, 1, 1, 0, 1, 1, "net gain");
                yield return new sanction(49, 0, 1, 3, 0, 0, 1, 1, "net gain");
                yield return new sanction(50, 0, 1, 2, 0, 0, 1, 1, "net gain");
                yield return new sanction(51, 0, 1, 2, 0, 1, 2, 1, "little effect");
                yield return new sanction(52, 0, 1, 3, 0, 1, 2, 1, "little effect");
                yield return new sanction(53, 0, 1, 1, 0, 1, 1, 1, "net gain");
                yield return new sanction(54, 0, 1, 1, 0, 0, 1, 2, "net gain");
                yield return new sanction(55, 0, 1, 2, 0, 0, 1, 1, "net gain");
                yield return new sanction(56, 0, 1, 2, 0, 1, 2, 1, "little effect");
                yield return new sanction(57, 0, 2, 2, 0, 1, 2, 3, "little effect");
                yield return new sanction(58, 0, 2, 3, 0, 1, 2, 2, "little effect");
                yield return new sanction(59, 0, 2, 3, 0, 1, 2, 2, "little effect");
                yield return new sanction(60, 0, 3, 2, 1, 1, 3, 9, "modest loss");
                yield return new sanction(61, 1, 3, 2, 0, 0, 1, 7, "net gain");
                yield return new sanction(62, 0, 1, 3, 1, 1, 3, 1, "modest loss");
                yield return new sanction(63, 0, 3, 1, 1, 1, 3, 10, "modest loss");
                yield return new sanction(64, 0, 2, 2, 0, 0, 1, 2, "net gain");
                yield return new sanction(65, 0, 3, 3, 1, 1, 2, 8, "little effect");
                yield return new sanction(66, 0, 2, 1, 0, 0, 1, 2, "net gain");
                yield return new sanction(67, 0, 3, 3, 0, 1, 3, 13, "modest loss");
                yield return new sanction(68, 0, 1, 2, 0, 1, 2, 1, "little effect");
                yield return new sanction(69, 0, 1, 2, 1, 0, 2, 1, "little effect");
                yield return new sanction(70, 0, 3, 1, 1, 1, 2, 4, "little effect");
                yield return new sanction(71, 0, 2, 3, 0, 1, 3, 1, "modest loss");
                yield return new sanction(72, 0, 2, 2, 0, 0, 1, 8, "net gain");
                yield return new sanction(73, 1, 3, 1, 1, 1, 2, 14, "little effect");
                yield return new sanction(74, 0, 2, 1, 0, 0, 1, 2, "net gain");
                yield return new sanction(75, 0, 1, 3, 0, 1, 2, 1, "little effect");
                yield return new sanction(76, 0, 4, 3, 1, 0, 2, 13, "little effect");
                yield return new sanction(77, 0, 1, 2, 0, 0, 1, 1, "net gain");
                yield return new sanction(78, 1, 3, 1, 1, 1, 2, 10, "little effect");
            }
        }
    }
}
