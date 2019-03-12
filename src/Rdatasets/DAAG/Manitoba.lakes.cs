// ReSharper disable All

namespace Rdatasets.DAAG
{
    using System.Collections.Generic;

    /// <summary>
    /// The Nine Largest Lakes in Manitoba
    /// </summary>

    public class Manitoba_lakes
    {
        public readonly string κ;
        public readonly int elevation;
        public readonly int area;

        public Manitoba_lakes(string κ, int elevation, int area)
        {
            this.κ = κ;
            this.elevation = elevation;
            this.area = area;
        }

        public static IEnumerable<Manitoba_lakes> Data
        {
            get
            {
                yield return new Manitoba_lakes("Winnipeg", 217, 24387);
                yield return new Manitoba_lakes("Winnipegosis", 254, 5374);
                yield return new Manitoba_lakes("Manitoba", 248, 4624);
                yield return new Manitoba_lakes("SouthernIndian", 254, 2247);
                yield return new Manitoba_lakes("Cedar", 253, 1353);
                yield return new Manitoba_lakes("Island", 227, 1223);
                yield return new Manitoba_lakes("Gods", 178, 1151);
                yield return new Manitoba_lakes("Cross", 207, 755);
                yield return new Manitoba_lakes("Playgreen", 217, 657);
            }
        }
    }
}
