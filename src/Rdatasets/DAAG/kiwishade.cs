// ReSharper disable All

namespace Rdatasets.DAAG
{
    using System.Collections.Generic;

    /// <summary>
    /// Kiwi Shading Data
    /// </summary>

    public class kiwishade
    {
        public readonly double yield;
        public readonly string block;
        public readonly string shade;
        public readonly string plot;

        public kiwishade(double yield, string block, string shade, string plot)
        {
            this.yield = yield;
            this.block = block;
            this.shade = shade;
            this.plot = plot;
        }

        public static IEnumerable<kiwishade> Data
        {
            get
            {
                yield return new kiwishade(101.11, "north", "none", "north.none");
                yield return new kiwishade(108.02, "north", "none", "north.none");
                yield return new kiwishade(106.67, "north", "none", "north.none");
                yield return new kiwishade(100.3, "north", "none", "north.none");
                yield return new kiwishade(92.64, "west", "none", "west.none");
                yield return new kiwishade(103.49, "west", "none", "west.none");
                yield return new kiwishade(100.68, "west", "none", "west.none");
                yield return new kiwishade(93.42, "west", "none", "west.none");
                yield return new kiwishade(100.31, "east", "none", "east.none");
                yield return new kiwishade(97, "east", "none", "east.none");
                yield return new kiwishade(98.05, "east", "none", "east.none");
                yield return new kiwishade(100.74, "east", "none", "east.none");
                yield return new kiwishade(105.77, "west", "Aug2Dec", "west.Aug2Dec");
                yield return new kiwishade(101.41, "west", "Aug2Dec", "west.Aug2Dec");
                yield return new kiwishade(97.6, "west", "Aug2Dec", "west.Aug2Dec");
                yield return new kiwishade(97.42, "west", "Aug2Dec", "west.Aug2Dec");
                yield return new kiwishade(103.1, "north", "Aug2Dec", "north.Aug2Dec");
                yield return new kiwishade(102.52, "north", "Aug2Dec", "north.Aug2Dec");
                yield return new kiwishade(104.02, "north", "Aug2Dec", "north.Aug2Dec");
                yield return new kiwishade(104.74, "north", "Aug2Dec", "north.Aug2Dec");
                yield return new kiwishade(108.87, "east", "Aug2Dec", "east.Aug2Dec");
                yield return new kiwishade(103.14, "east", "Aug2Dec", "east.Aug2Dec");
                yield return new kiwishade(108.32, "east", "Aug2Dec", "east.Aug2Dec");
                yield return new kiwishade(101.89, "east", "Aug2Dec", "east.Aug2Dec");
                yield return new kiwishade(86.65, "west", "Dec2Feb", "west.Dec2Feb");
                yield return new kiwishade(90.75, "west", "Dec2Feb", "west.Dec2Feb");
                yield return new kiwishade(87.06, "west", "Dec2Feb", "west.Dec2Feb");
                yield return new kiwishade(84.12, "west", "Dec2Feb", "west.Dec2Feb");
                yield return new kiwishade(92.17, "north", "Dec2Feb", "north.Dec2Feb");
                yield return new kiwishade(93.81, "north", "Dec2Feb", "north.Dec2Feb");
                yield return new kiwishade(94.76, "north", "Dec2Feb", "north.Dec2Feb");
                yield return new kiwishade(94.05, "north", "Dec2Feb", "north.Dec2Feb");
                yield return new kiwishade(85.4, "east", "Dec2Feb", "east.Dec2Feb");
                yield return new kiwishade(81.43, "east", "Dec2Feb", "east.Dec2Feb");
                yield return new kiwishade(93.94, "east", "Dec2Feb", "east.Dec2Feb");
                yield return new kiwishade(94.91, "east", "Dec2Feb", "east.Dec2Feb");
                yield return new kiwishade(92.58, "north", "Feb2May", "north.Feb2May");
                yield return new kiwishade(93.45, "north", "Feb2May", "north.Feb2May");
                yield return new kiwishade(90.29, "north", "Feb2May", "north.Feb2May");
                yield return new kiwishade(91.82, "north", "Feb2May", "north.Feb2May");
                yield return new kiwishade(87.27, "west", "Feb2May", "west.Feb2May");
                yield return new kiwishade(94.99, "west", "Feb2May", "west.Feb2May");
                yield return new kiwishade(89.06, "west", "Feb2May", "west.Feb2May");
                yield return new kiwishade(90.31, "west", "Feb2May", "west.Feb2May");
                yield return new kiwishade(92.45, "east", "Feb2May", "east.Feb2May");
                yield return new kiwishade(97.57, "east", "Feb2May", "east.Feb2May");
                yield return new kiwishade(97.15, "east", "Feb2May", "east.Feb2May");
                yield return new kiwishade(96.35, "east", "Feb2May", "east.Feb2May");
            }
        }
    }
}
