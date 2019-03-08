// ReSharper disable All

namespace Rdatasets.drc
{
    using System.Collections.Generic;

    /// <summary>
    /// Data from toxicology experiments with selenium
    /// </summary>

    public class selenium
    {
        public readonly int type;
        public readonly int conc;
        public readonly int total;
        public readonly int dead;

        public selenium(int type, int conc, int total, int dead)
        {
            this.type = type;
            this.conc = conc;
            this.total = total;
            this.dead = dead;
        }

        public static IEnumerable<selenium> Data
        {
            get
            {
                yield return new selenium(1, 0, 151, 3);
                yield return new selenium(1, 100, 146, 40);
                yield return new selenium(1, 200, 116, 31);
                yield return new selenium(1, 300, 159, 85);
                yield return new selenium(1, 400, 150, 102);
                yield return new selenium(1, 500, 140, 112);
                yield return new selenium(2, 0, 141, 2);
                yield return new selenium(2, 100, 153, 30);
                yield return new selenium(2, 200, 142, 59);
                yield return new selenium(2, 300, 139, 82);
                yield return new selenium(2, 400, 154, 62);
                yield return new selenium(2, 500, 155, 85);
                yield return new selenium(3, 0, 137, 4);
                yield return new selenium(3, 5, 106, 0);
                yield return new selenium(3, 25, 63, 11);
                yield return new selenium(3, 50, 145, 22);
                yield return new selenium(3, 100, 127, 31);
                yield return new selenium(3, 200, 140, 105);
                yield return new selenium(3, 400, 172, 166);
                yield return new selenium(3, 800, 188, 188);
                yield return new selenium(4, 0, 152, 3);
                yield return new selenium(4, 5, 152, 7);
                yield return new selenium(4, 25, 150, 11);
                yield return new selenium(4, 50, 153, 45);
                yield return new selenium(4, 100, 125, 74);
            }
        }
    }
}
