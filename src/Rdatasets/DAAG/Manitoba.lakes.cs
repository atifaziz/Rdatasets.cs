// ReSharper disable All

namespace Rdatasets.DAAG
{
    using System.Collections.Generic;

    /// <summary>
    /// The Nine Largest Lakes in Manitoba
    /// </summary>

    public class Manitoba_lakes
    {
        public readonly int elevation;
        public readonly int area;

        public Manitoba_lakes(int elevation, int area)
        {
            this.elevation = elevation;
            this.area = area;
        }

        public static IEnumerable<Manitoba_lakes> Data
        {
            get
            {
                yield return new Manitoba_lakes(217, 24387);
                yield return new Manitoba_lakes(254, 5374);
                yield return new Manitoba_lakes(248, 4624);
                yield return new Manitoba_lakes(254, 2247);
                yield return new Manitoba_lakes(253, 1353);
                yield return new Manitoba_lakes(227, 1223);
                yield return new Manitoba_lakes(178, 1151);
                yield return new Manitoba_lakes(207, 755);
                yield return new Manitoba_lakes(217, 657);
            }
        }
    }
}
