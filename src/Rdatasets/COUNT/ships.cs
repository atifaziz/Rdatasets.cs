// ReSharper disable All

namespace Rdatasets.COUNT
{
    using System.Collections.Generic;

    /// <summary>
    /// ships
    /// </summary>

    public class ships
    {
        public readonly int κ;
        public readonly int? accident;
        public readonly int op;
        public readonly int co_65_69;
        public readonly int co_70_74;
        public readonly int co_75_79;
        public readonly int? service;
        public readonly int ship;

        public ships(int κ, int? accident, int op, int co_65_69, int co_70_74, int co_75_79, int? service, int ship)
        {
            this.κ = κ;
            this.accident = accident;
            this.op = op;
            this.co_65_69 = co_65_69;
            this.co_70_74 = co_70_74;
            this.co_75_79 = co_75_79;
            this.service = service;
            this.ship = ship;
        }

        public static IEnumerable<ships> Data
        {
            get
            {
                yield return new ships(1, 0, 0, 0, 0, 0, 127, 1);
                yield return new ships(2, 0, 1, 0, 0, 0, 63, 1);
                yield return new ships(3, 3, 0, 1, 0, 0, 1095, 1);
                yield return new ships(4, 4, 1, 1, 0, 0, 1095, 1);
                yield return new ships(5, 6, 0, 0, 1, 0, 1512, 1);
                yield return new ships(6, 18, 1, 0, 1, 0, 3353, 1);
                yield return new ships(7, null, 0, 0, 0, 1, null, 1);
                yield return new ships(8, 11, 1, 0, 0, 1, 2244, 1);
                yield return new ships(9, 39, 0, 0, 0, 0, 44882, 2);
                yield return new ships(10, 29, 1, 0, 0, 0, 17176, 2);
                yield return new ships(11, 58, 0, 1, 0, 0, 28609, 2);
                yield return new ships(12, 53, 1, 1, 0, 0, 20370, 2);
                yield return new ships(13, 12, 0, 0, 1, 0, 7064, 2);
                yield return new ships(14, 44, 1, 0, 1, 0, 13099, 2);
                yield return new ships(15, null, 0, 0, 0, 1, null, 2);
                yield return new ships(16, 18, 1, 0, 0, 1, 7117, 2);
                yield return new ships(17, 1, 0, 0, 0, 0, 1179, 3);
                yield return new ships(18, 1, 1, 0, 0, 0, 552, 3);
                yield return new ships(19, 0, 0, 1, 0, 0, 781, 3);
                yield return new ships(20, 1, 1, 1, 0, 0, 676, 3);
                yield return new ships(21, 6, 0, 0, 1, 0, 783, 3);
                yield return new ships(22, 2, 1, 0, 1, 0, 1948, 3);
                yield return new ships(23, null, 0, 0, 0, 1, null, 3);
                yield return new ships(24, 1, 1, 0, 0, 1, 274, 3);
                yield return new ships(25, 0, 0, 0, 0, 0, 251, 4);
                yield return new ships(26, 0, 1, 0, 0, 0, 105, 4);
                yield return new ships(27, 0, 0, 1, 0, 0, 288, 4);
                yield return new ships(28, 0, 1, 1, 0, 0, 192, 4);
                yield return new ships(29, 2, 0, 0, 1, 0, 349, 4);
                yield return new ships(30, 11, 1, 0, 1, 0, 1208, 4);
                yield return new ships(31, null, 0, 0, 0, 1, null, 4);
                yield return new ships(32, 4, 1, 0, 0, 1, 2051, 4);
                yield return new ships(33, 0, 0, 0, 0, 0, 45, 5);
                yield return new ships(34, null, 1, 0, 0, 0, null, 5);
                yield return new ships(35, 7, 0, 1, 0, 0, 789, 5);
                yield return new ships(36, 7, 1, 1, 0, 0, 437, 5);
                yield return new ships(37, 5, 0, 0, 1, 0, 1157, 5);
                yield return new ships(38, 12, 1, 0, 1, 0, 2161, 5);
                yield return new ships(39, null, 0, 0, 0, 1, null, 5);
                yield return new ships(40, 1, 1, 0, 0, 1, 542, 5);
            }
        }
    }
}
