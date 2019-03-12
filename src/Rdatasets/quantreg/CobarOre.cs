// ReSharper disable All

namespace Rdatasets.quantreg
{
    using System.Collections.Generic;

    /// <summary>
    /// Cobar Ore data
    /// </summary>

    public class CobarOre
    {
        public readonly int κ;
        public readonly int x;
        public readonly int y;
        public readonly double z;

        public CobarOre(int κ, int x, int y, double z)
        {
            this.κ = κ;
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public static IEnumerable<CobarOre> Data
        {
            get
            {
                yield return new CobarOre(1, -16, -15, 17);
                yield return new CobarOre(2, -14, -4, 18);
                yield return new CobarOre(3, -13, 4, 17.5);
                yield return new CobarOre(4, -7, 5, 19);
                yield return new CobarOre(5, -6, -43, 22);
                yield return new CobarOre(6, -6, -36, 24);
                yield return new CobarOre(7, 1, -50, 17.4);
                yield return new CobarOre(8, 2, -39, 23);
                yield return new CobarOre(9, 2, -8, 23.5);
                yield return new CobarOre(10, 2, -51, 15);
                yield return new CobarOre(11, 9, -16, 23.5);
                yield return new CobarOre(12, 9, -42, 25);
                yield return new CobarOre(13, 17, -37, 16.5);
                yield return new CobarOre(14, 18, -12, 19.5);
                yield return new CobarOre(15, 24, -57, 12);
                yield return new CobarOre(16, 25, -29, 18.5);
                yield return new CobarOre(17, 26, -40, 18);
                yield return new CobarOre(18, 32, -7, 14);
                yield return new CobarOre(19, 33, -35, 19);
                yield return new CobarOre(20, 40, 4, 13.5);
                yield return new CobarOre(21, 40, -61, 18);
                yield return new CobarOre(22, 44, -29, 19.4);
                yield return new CobarOre(23, 48, -65, 13);
                yield return new CobarOre(24, 48, -7, 14);
                yield return new CobarOre(25, 49, -32, 19.5);
                yield return new CobarOre(26, 55, -71, 16);
                yield return new CobarOre(27, 56, -14, 16);
                yield return new CobarOre(28, 59, -38, 19);
                yield return new CobarOre(29, 62, 7, 19);
                yield return new CobarOre(30, 62, -3, 21.5);
                yield return new CobarOre(31, 64, -29, 22);
                yield return new CobarOre(32, 69, -28, 20.5);
                yield return new CobarOre(33, 70, -72, 11);
                yield return new CobarOre(34, 77, -19, 26);
                yield return new CobarOre(35, 78, -53, 22);
                yield return new CobarOre(36, 79, -37, 26);
                yield return new CobarOre(37, 84, -52, 16);
                yield return new CobarOre(38, 84, -16, 16);
            }
        }
    }
}
