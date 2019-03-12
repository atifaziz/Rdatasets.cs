// ReSharper disable All

namespace Rdatasets.MASS
{
    using System.Collections.Generic;

    /// <summary>
    /// Spatial Topographic Data
    /// </summary>

    public class topo
    {
        public readonly int κ;
        public readonly double x;
        public readonly double y;
        public readonly int z;

        public topo(int κ, double x, double y, int z)
        {
            this.κ = κ;
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public static IEnumerable<topo> Data
        {
            get
            {
                yield return new topo(1, 0.3, 6.1, 870);
                yield return new topo(2, 1.4, 6.2, 793);
                yield return new topo(3, 2.4, 6.1, 755);
                yield return new topo(4, 3.6, 6.2, 690);
                yield return new topo(5, 5.7, 6.2, 800);
                yield return new topo(6, 1.6, 5.2, 800);
                yield return new topo(7, 2.9, 5.1, 730);
                yield return new topo(8, 3.4, 5.3, 728);
                yield return new topo(9, 3.4, 5.7, 710);
                yield return new topo(10, 4.8, 5.6, 780);
                yield return new topo(11, 5.3, 5, 804);
                yield return new topo(12, 6.2, 5.2, 855);
                yield return new topo(13, 0.2, 4.3, 830);
                yield return new topo(14, 0.9, 4.2, 813);
                yield return new topo(15, 2.3, 4.8, 762);
                yield return new topo(16, 2.5, 4.5, 765);
                yield return new topo(17, 3, 4.5, 740);
                yield return new topo(18, 3.5, 4.5, 765);
                yield return new topo(19, 4.1, 4.6, 760);
                yield return new topo(20, 4.9, 4.2, 790);
                yield return new topo(21, 6.3, 4.3, 820);
                yield return new topo(22, 0.9, 3.2, 855);
                yield return new topo(23, 1.7, 3.8, 812);
                yield return new topo(24, 2.4, 3.8, 773);
                yield return new topo(25, 3.7, 3.5, 812);
                yield return new topo(26, 4.5, 3.2, 827);
                yield return new topo(27, 5.2, 3.2, 805);
                yield return new topo(28, 6.3, 3.4, 840);
                yield return new topo(29, 0.3, 2.4, 890);
                yield return new topo(30, 2, 2.7, 820);
                yield return new topo(31, 3.8, 2.3, 873);
                yield return new topo(32, 6.3, 2.2, 875);
                yield return new topo(33, 0.6, 1.7, 873);
                yield return new topo(34, 1.5, 1.8, 865);
                yield return new topo(35, 2.1, 1.8, 841);
                yield return new topo(36, 2.1, 1.1, 862);
                yield return new topo(37, 3.1, 1.1, 908);
                yield return new topo(38, 4.5, 1.8, 855);
                yield return new topo(39, 5.5, 1.7, 850);
                yield return new topo(40, 5.7, 1, 882);
                yield return new topo(41, 6.2, 1, 910);
                yield return new topo(42, 0.4, 0.5, 940);
                yield return new topo(43, 1.4, 0.6, 915);
                yield return new topo(44, 1.4, 0.1, 890);
                yield return new topo(45, 2.1, 0.7, 880);
                yield return new topo(46, 2.3, 0.3, 870);
                yield return new topo(47, 3.1, 0, 880);
                yield return new topo(48, 4.1, 0.8, 960);
                yield return new topo(49, 5.4, 0.4, 890);
                yield return new topo(50, 6, 0.1, 860);
                yield return new topo(51, 5.7, 3, 830);
                yield return new topo(52, 3.6, 6, 705);
            }
        }
    }
}
