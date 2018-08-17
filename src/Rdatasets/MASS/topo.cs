// ReSharper disable All

namespace Rdatasets.MASS
{
    using System.Collections.Generic;

    /// <summary>
    /// Spatial Topographic Data
    /// </summary>

    public class topo
    {
        public readonly double x;
        public readonly double y;
        public readonly int z;

        public topo(double x, double y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public static IEnumerable<topo> Data
        {
            get
            {
                yield return new topo(0.3, 6.1, 870);
                yield return new topo(1.4, 6.2, 793);
                yield return new topo(2.4, 6.1, 755);
                yield return new topo(3.6, 6.2, 690);
                yield return new topo(5.7, 6.2, 800);
                yield return new topo(1.6, 5.2, 800);
                yield return new topo(2.9, 5.1, 730);
                yield return new topo(3.4, 5.3, 728);
                yield return new topo(3.4, 5.7, 710);
                yield return new topo(4.8, 5.6, 780);
                yield return new topo(5.3, 5, 804);
                yield return new topo(6.2, 5.2, 855);
                yield return new topo(0.2, 4.3, 830);
                yield return new topo(0.9, 4.2, 813);
                yield return new topo(2.3, 4.8, 762);
                yield return new topo(2.5, 4.5, 765);
                yield return new topo(3, 4.5, 740);
                yield return new topo(3.5, 4.5, 765);
                yield return new topo(4.1, 4.6, 760);
                yield return new topo(4.9, 4.2, 790);
                yield return new topo(6.3, 4.3, 820);
                yield return new topo(0.9, 3.2, 855);
                yield return new topo(1.7, 3.8, 812);
                yield return new topo(2.4, 3.8, 773);
                yield return new topo(3.7, 3.5, 812);
                yield return new topo(4.5, 3.2, 827);
                yield return new topo(5.2, 3.2, 805);
                yield return new topo(6.3, 3.4, 840);
                yield return new topo(0.3, 2.4, 890);
                yield return new topo(2, 2.7, 820);
                yield return new topo(3.8, 2.3, 873);
                yield return new topo(6.3, 2.2, 875);
                yield return new topo(0.6, 1.7, 873);
                yield return new topo(1.5, 1.8, 865);
                yield return new topo(2.1, 1.8, 841);
                yield return new topo(2.1, 1.1, 862);
                yield return new topo(3.1, 1.1, 908);
                yield return new topo(4.5, 1.8, 855);
                yield return new topo(5.5, 1.7, 850);
                yield return new topo(5.7, 1, 882);
                yield return new topo(6.2, 1, 910);
                yield return new topo(0.4, 0.5, 940);
                yield return new topo(1.4, 0.6, 915);
                yield return new topo(1.4, 0.1, 890);
                yield return new topo(2.1, 0.7, 880);
                yield return new topo(2.3, 0.3, 870);
                yield return new topo(3.1, 0, 880);
                yield return new topo(4.1, 0.8, 960);
                yield return new topo(5.4, 0.4, 890);
                yield return new topo(6, 0.1, 860);
                yield return new topo(5.7, 3, 830);
                yield return new topo(3.6, 6, 705);
            }
        }
    }
}
