// ReSharper disable All

namespace Rdatasets.sandwich
{
    using System.Collections.Generic;

    /// <summary>
    /// US Investment Data
    /// </summary>

    public class Investment
    {
        public readonly double GNP;
        public readonly double Investment_;
        public readonly double Price;
        public readonly double Interest;
        public readonly double RealGNP;
        public readonly double RealInv;
        public readonly double? RealInt;

        public Investment(double GNP, double Investment_, double Price, double Interest, double RealGNP, double RealInv, double? RealInt)
        {
            this.GNP = GNP;
            this.Investment_ = Investment_;
            this.Price = Price;
            this.Interest = Interest;
            this.RealGNP = RealGNP;
            this.RealInv = RealInv;
            this.RealInt = RealInt;
        }

        public static IEnumerable<Investment> Data
        {
            get
            {
                yield return new Investment(596.7, 90.9, 0.7167, 3.23, 832.565927166178, 126.83131017162, null);
                yield return new Investment(637.7, 97.4, 0.7277, 3.55, 876.322660436993, 133.84636526041, 2.01518766568997);
                yield return new Investment(691.1, 113.5, 0.7436, 4.04, 929.397525551372, 152.635825712749, 1.85503366772021);
                yield return new Investment(756, 125.7, 0.7676, 4.5, 984.887962480459, 163.757165190203, 1.27245831091986);
                yield return new Investment(799.6, 122.8, 0.7906, 4.19, 1011.38375917025, 155.325069567417, 1.19364773319437);
                yield return new Investment(873.4, 133.3, 0.8254, 5.16, 1058.15362248607, 161.497455779016, 0.758279787503155);
                yield return new Investment(944, 149.3, 0.8679, 5.87, 1087.68291277797, 172.024426777279, 0.720981342379455);
                yield return new Investment(992.7, 144.2, 0.9145, 5.95, 1085.51120831055, 157.681793329688, 0.580717824634178);
                yield return new Investment(1077.6, 166.4, 0.9601, 4.88, 1122.3830850953, 173.315279658369, -0.106331328594858);
                yield return new Investment(1185.9, 195, 1, 4.5, 1185.9, 195, 0.344182897614827);
                yield return new Investment(1326.4, 229.8, 1.0575, 6.44, 1254.27895981087, 217.304964539007, 0.68999999999999);
                yield return new Investment(1434.2, 228.7, 1.1508, 7.83, 1246.26346889121, 198.731317344456, -0.992695035460986);
                yield return new Investment(1549.2, 206.1, 1.2579, 6.25, 1231.57643691867, 163.844502742666, -3.05656934306569);
                yield return new Investment(1718, 257.9, 1.3234, 5.5, 1298.17137675684, 194.87683240139, 0.292908816281112);
                yield return new Investment(1918.3, 324.1, 1.4005, 5.46, 1369.72509817922, 231.417350946091, -0.365902977180004);
                yield return new Investment(2163.9, 386.6, 1.5042, 7.46, 1438.57199840447, 257.013694987369, 0.0555016065690905);
                yield return new Investment(2417.8, 423, 1.6342, 10.28, 1479.50067311223, 258.842246970995, 1.63753224305278);
                yield return new Investment(2631.7, 401.9, 1.7842, 11.77, 1475.00280237642, 225.255016253783, 2.59119691592217);
                yield return new Investment(2954.1, 474.9, 1.9514, 13.42, 1513.83622014964, 243.363738854156, 4.0488532675709);
                yield return new Investment(3073, 414.5, 2.0688, 11.02, 1485.40216550657, 200.357695282289, 5.00380649789895);
            }
        }
    }
}
