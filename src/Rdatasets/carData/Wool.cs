// ReSharper disable All

namespace Rdatasets.carData
{
    using System.Collections.Generic;

    /// <summary>
    /// Wool data
    /// </summary>

    public class Wool
    {
        public readonly int κ;
        public readonly int len;
        public readonly int amp;
        public readonly int load;
        public readonly int cycles;

        public Wool(int κ, int len, int amp, int load, int cycles)
        {
            this.κ = κ;
            this.len = len;
            this.amp = amp;
            this.load = load;
            this.cycles = cycles;
        }

        public static IEnumerable<Wool> Data
        {
            get
            {
                yield return new Wool(1, 250, 8, 40, 674);
                yield return new Wool(2, 250, 8, 45, 370);
                yield return new Wool(3, 250, 8, 50, 292);
                yield return new Wool(4, 250, 9, 40, 338);
                yield return new Wool(5, 250, 9, 45, 266);
                yield return new Wool(6, 250, 9, 50, 210);
                yield return new Wool(7, 250, 10, 40, 170);
                yield return new Wool(8, 250, 10, 45, 118);
                yield return new Wool(9, 250, 10, 50, 90);
                yield return new Wool(10, 300, 8, 40, 1414);
                yield return new Wool(11, 300, 8, 45, 1198);
                yield return new Wool(12, 300, 8, 50, 634);
                yield return new Wool(13, 300, 9, 40, 1022);
                yield return new Wool(14, 300, 9, 45, 620);
                yield return new Wool(15, 300, 9, 50, 438);
                yield return new Wool(16, 300, 10, 40, 443);
                yield return new Wool(17, 300, 10, 45, 332);
                yield return new Wool(18, 300, 10, 50, 220);
                yield return new Wool(19, 350, 8, 40, 3636);
                yield return new Wool(20, 350, 8, 45, 3184);
                yield return new Wool(21, 350, 8, 50, 2000);
                yield return new Wool(22, 350, 9, 40, 1568);
                yield return new Wool(23, 350, 9, 45, 1070);
                yield return new Wool(24, 350, 9, 50, 566);
                yield return new Wool(25, 350, 10, 40, 1140);
                yield return new Wool(26, 350, 10, 45, 884);
                yield return new Wool(27, 350, 10, 50, 360);
            }
        }
    }
}
