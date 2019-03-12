// ReSharper disable All

namespace Rdatasets.DAAG
{
    using System.Collections.Generic;

    /// <summary>
    /// Kiwi Shading Data
    /// </summary>

    public class kiwishade
    {
        public readonly int κ;
        public readonly double yield;
        public readonly string block;
        public readonly string shade;
        public readonly string plot;

        public kiwishade(int κ, double yield, string block, string shade, string plot)
        {
            this.κ = κ;
            this.yield = yield;
            this.block = block;
            this.shade = shade;
            this.plot = plot;
        }

        public static IEnumerable<kiwishade> Data
        {
            get
            {
                yield return new kiwishade(1, 101.11, "north", "none", "north.none");
                yield return new kiwishade(2, 108.02, "north", "none", "north.none");
                yield return new kiwishade(3, 106.67, "north", "none", "north.none");
                yield return new kiwishade(4, 100.3, "north", "none", "north.none");
                yield return new kiwishade(5, 92.64, "west", "none", "west.none");
                yield return new kiwishade(6, 103.49, "west", "none", "west.none");
                yield return new kiwishade(7, 100.68, "west", "none", "west.none");
                yield return new kiwishade(8, 93.42, "west", "none", "west.none");
                yield return new kiwishade(9, 100.31, "east", "none", "east.none");
                yield return new kiwishade(10, 97, "east", "none", "east.none");
                yield return new kiwishade(11, 98.05, "east", "none", "east.none");
                yield return new kiwishade(12, 100.74, "east", "none", "east.none");
                yield return new kiwishade(13, 105.77, "west", "Aug2Dec", "west.Aug2Dec");
                yield return new kiwishade(14, 101.41, "west", "Aug2Dec", "west.Aug2Dec");
                yield return new kiwishade(15, 97.6, "west", "Aug2Dec", "west.Aug2Dec");
                yield return new kiwishade(16, 97.42, "west", "Aug2Dec", "west.Aug2Dec");
                yield return new kiwishade(17, 103.1, "north", "Aug2Dec", "north.Aug2Dec");
                yield return new kiwishade(18, 102.52, "north", "Aug2Dec", "north.Aug2Dec");
                yield return new kiwishade(19, 104.02, "north", "Aug2Dec", "north.Aug2Dec");
                yield return new kiwishade(20, 104.74, "north", "Aug2Dec", "north.Aug2Dec");
                yield return new kiwishade(21, 108.87, "east", "Aug2Dec", "east.Aug2Dec");
                yield return new kiwishade(22, 103.14, "east", "Aug2Dec", "east.Aug2Dec");
                yield return new kiwishade(23, 108.32, "east", "Aug2Dec", "east.Aug2Dec");
                yield return new kiwishade(24, 101.89, "east", "Aug2Dec", "east.Aug2Dec");
                yield return new kiwishade(25, 86.65, "west", "Dec2Feb", "west.Dec2Feb");
                yield return new kiwishade(26, 90.75, "west", "Dec2Feb", "west.Dec2Feb");
                yield return new kiwishade(27, 87.06, "west", "Dec2Feb", "west.Dec2Feb");
                yield return new kiwishade(28, 84.12, "west", "Dec2Feb", "west.Dec2Feb");
                yield return new kiwishade(29, 92.17, "north", "Dec2Feb", "north.Dec2Feb");
                yield return new kiwishade(30, 93.81, "north", "Dec2Feb", "north.Dec2Feb");
                yield return new kiwishade(31, 94.76, "north", "Dec2Feb", "north.Dec2Feb");
                yield return new kiwishade(32, 94.05, "north", "Dec2Feb", "north.Dec2Feb");
                yield return new kiwishade(33, 85.4, "east", "Dec2Feb", "east.Dec2Feb");
                yield return new kiwishade(34, 81.43, "east", "Dec2Feb", "east.Dec2Feb");
                yield return new kiwishade(35, 93.94, "east", "Dec2Feb", "east.Dec2Feb");
                yield return new kiwishade(36, 94.91, "east", "Dec2Feb", "east.Dec2Feb");
                yield return new kiwishade(37, 92.58, "north", "Feb2May", "north.Feb2May");
                yield return new kiwishade(38, 93.45, "north", "Feb2May", "north.Feb2May");
                yield return new kiwishade(39, 90.29, "north", "Feb2May", "north.Feb2May");
                yield return new kiwishade(40, 91.82, "north", "Feb2May", "north.Feb2May");
                yield return new kiwishade(41, 87.27, "west", "Feb2May", "west.Feb2May");
                yield return new kiwishade(42, 94.99, "west", "Feb2May", "west.Feb2May");
                yield return new kiwishade(43, 89.06, "west", "Feb2May", "west.Feb2May");
                yield return new kiwishade(44, 90.31, "west", "Feb2May", "west.Feb2May");
                yield return new kiwishade(45, 92.45, "east", "Feb2May", "east.Feb2May");
                yield return new kiwishade(46, 97.57, "east", "Feb2May", "east.Feb2May");
                yield return new kiwishade(47, 97.15, "east", "Feb2May", "east.Feb2May");
                yield return new kiwishade(48, 96.35, "east", "Feb2May", "east.Feb2May");
            }
        }
    }
}
