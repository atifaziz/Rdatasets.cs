// ReSharper disable All

namespace Rdatasets.HistData
{
    using System.Collections.Generic;

    /// <summary>
    /// La Felicisima Armada
    /// </summary>

    public class Armada
    {
        public readonly string Armada_;
        public readonly int ships;
        public readonly int tons;
        public readonly int soldiers;
        public readonly int sailors;
        public readonly int men;
        public readonly int artillery;
        public readonly int balls;
        public readonly int gunpowder;
        public readonly int lead;
        public readonly int rope;

        public Armada(string Armada_, int ships, int tons, int soldiers, int sailors, int men, int artillery, int balls, int gunpowder, int lead, int rope)
        {
            this.Armada_ = Armada_;
            this.ships = ships;
            this.tons = tons;
            this.soldiers = soldiers;
            this.sailors = sailors;
            this.men = men;
            this.artillery = artillery;
            this.balls = balls;
            this.gunpowder = gunpowder;
            this.lead = lead;
            this.rope = rope;
        }

        public static IEnumerable<Armada> Data
        {
            get
            {
                yield return new Armada("Portugal", 12, 7737, 3330, 1293, 4623, 347, 18450, 789, 186, 150);
                yield return new Armada("Vizca", 14, 6567, 1937, 863, 2800, 238, 11900, 477, 140, 87);
                yield return new Armada("Castilla", 16, 8714, 2458, 1719, 4171, 384, 23040, 710, 290, 309);
                yield return new Armada("Andalucia", 11, 8762, 2325, 780, 3105, 240, 10200, 415, 63, 119);
                yield return new Armada("Guipuscua", 14, 6991, 1992, 616, 2608, 247, 12150, 518, 139, 109);
                yield return new Armada("Uantiscas", 10, 7705, 2780, 767, 3523, 280, 14000, 584, 177, 141);
                yield return new Armada("Vrcas", 23, 10271, 3121, 608, 3729, 384, 19200, 258, 142, 215);
                yield return new Armada("Pataches", 22, 1221, 479, 574, 1093, 91, 4550, 66, 20, 13);
                yield return new Armada("Napoles", 4, 0, 873, 468, 1341, 200, 10000, 498, 61, 88);
                yield return new Armada("Galeras", 4, 0, 0, 362, 362, 20, 1200, 60, 20, 20);
            }
        }
    }
}
