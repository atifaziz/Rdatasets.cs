// ReSharper disable All

namespace Rdatasets.quantreg
{
    using System.Collections.Generic;

    /// <summary>
    /// Cobar Ore data
    /// </summary>

    public class CobarOre
    {
        public readonly int x;
        public readonly int y;
        public readonly double z;

        public CobarOre(int x, int y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public static IEnumerable<CobarOre> Data
        {
            get
            {
                yield return new CobarOre(-16, -15, 17);
                yield return new CobarOre(-14, -4, 18);
                yield return new CobarOre(-13, 4, 17.5);
                yield return new CobarOre(-7, 5, 19);
                yield return new CobarOre(-6, -43, 22);
                yield return new CobarOre(-6, -36, 24);
                yield return new CobarOre(1, -50, 17.4);
                yield return new CobarOre(2, -39, 23);
                yield return new CobarOre(2, -8, 23.5);
                yield return new CobarOre(2, -51, 15);
                yield return new CobarOre(9, -16, 23.5);
                yield return new CobarOre(9, -42, 25);
                yield return new CobarOre(17, -37, 16.5);
                yield return new CobarOre(18, -12, 19.5);
                yield return new CobarOre(24, -57, 12);
                yield return new CobarOre(25, -29, 18.5);
                yield return new CobarOre(26, -40, 18);
                yield return new CobarOre(32, -7, 14);
                yield return new CobarOre(33, -35, 19);
                yield return new CobarOre(40, 4, 13.5);
                yield return new CobarOre(40, -61, 18);
                yield return new CobarOre(44, -29, 19.4);
                yield return new CobarOre(48, -65, 13);
                yield return new CobarOre(48, -7, 14);
                yield return new CobarOre(49, -32, 19.5);
                yield return new CobarOre(55, -71, 16);
                yield return new CobarOre(56, -14, 16);
                yield return new CobarOre(59, -38, 19);
                yield return new CobarOre(62, 7, 19);
                yield return new CobarOre(62, -3, 21.5);
                yield return new CobarOre(64, -29, 22);
                yield return new CobarOre(69, -28, 20.5);
                yield return new CobarOre(70, -72, 11);
                yield return new CobarOre(77, -19, 26);
                yield return new CobarOre(78, -53, 22);
                yield return new CobarOre(79, -37, 26);
                yield return new CobarOre(84, -52, 16);
                yield return new CobarOre(84, -16, 16);
            }
        }
    }
}
