// ReSharper disable All

namespace Rdatasets.carData
{
    using System.Collections.Generic;

    /// <summary>
    /// Wool data
    /// </summary>

    public class Wool
    {
        public readonly int len;
        public readonly int amp;
        public readonly int load;
        public readonly int cycles;

        public Wool(int len, int amp, int load, int cycles)
        {
            this.len = len;
            this.amp = amp;
            this.load = load;
            this.cycles = cycles;
        }

        public static IEnumerable<Wool> Data
        {
            get
            {
                yield return new Wool(250, 8, 40, 674);
                yield return new Wool(250, 8, 45, 370);
                yield return new Wool(250, 8, 50, 292);
                yield return new Wool(250, 9, 40, 338);
                yield return new Wool(250, 9, 45, 266);
                yield return new Wool(250, 9, 50, 210);
                yield return new Wool(250, 10, 40, 170);
                yield return new Wool(250, 10, 45, 118);
                yield return new Wool(250, 10, 50, 90);
                yield return new Wool(300, 8, 40, 1414);
                yield return new Wool(300, 8, 45, 1198);
                yield return new Wool(300, 8, 50, 634);
                yield return new Wool(300, 9, 40, 1022);
                yield return new Wool(300, 9, 45, 620);
                yield return new Wool(300, 9, 50, 438);
                yield return new Wool(300, 10, 40, 443);
                yield return new Wool(300, 10, 45, 332);
                yield return new Wool(300, 10, 50, 220);
                yield return new Wool(350, 8, 40, 3636);
                yield return new Wool(350, 8, 45, 3184);
                yield return new Wool(350, 8, 50, 2000);
                yield return new Wool(350, 9, 40, 1568);
                yield return new Wool(350, 9, 45, 1070);
                yield return new Wool(350, 9, 50, 566);
                yield return new Wool(350, 10, 40, 1140);
                yield return new Wool(350, 10, 45, 884);
                yield return new Wool(350, 10, 50, 360);
            }
        }
    }
}
