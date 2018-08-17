// ReSharper disable All

namespace Rdatasets.boot
{
    using System.Collections.Generic;

    /// <summary>
    /// Pole Positions of New Caledonian Laterites
    /// </summary>

    public class polar
    {
        public readonly double lat;
        public readonly double @long;

        public polar(double lat, double @long)
        {
            this.lat = lat;
            this.@long = @long;
        }

        public static IEnumerable<polar> Data
        {
            get
            {
                yield return new polar(-26.4, 324);
                yield return new polar(-32.2, 163.7);
                yield return new polar(-73.1, 51.9);
                yield return new polar(-80.2, 140.5);
                yield return new polar(-71.1, 267.2);
                yield return new polar(-58.7, 32);
                yield return new polar(-40.8, 28.1);
                yield return new polar(-14.9, 266.3);
                yield return new polar(-66.1, 144.3);
                yield return new polar(-1.8, 256.2);
                yield return new polar(-52.1, 83.2);
                yield return new polar(-77.3, 182.1);
                yield return new polar(-68.8, 110.4);
                yield return new polar(-68.4, 142.2);
                yield return new polar(-29.2, 246.3);
                yield return new polar(-78.5, 222.6);
                yield return new polar(-65.4, 247.7);
                yield return new polar(-49, 65.6);
                yield return new polar(-67, 282.6);
                yield return new polar(-56.7, 56.2);
                yield return new polar(-80.5, 108.4);
                yield return new polar(-77.7, 266);
                yield return new polar(-6.9, 19.1);
                yield return new polar(-59.4, 281.7);
                yield return new polar(-5.6, 107.4);
                yield return new polar(-62.6, 105.3);
                yield return new polar(-74.7, 120.2);
                yield return new polar(-65.3, 286.6);
                yield return new polar(-71.6, 106.4);
                yield return new polar(-23.3, 96.5);
                yield return new polar(-74.3, 90.2);
                yield return new polar(-81, 170.9);
                yield return new polar(-12.7, 199.4);
                yield return new polar(-75.4, 118.6);
                yield return new polar(-85.9, 63.7);
                yield return new polar(-84.8, 74.9);
                yield return new polar(-7.4, 93.8);
                yield return new polar(-29.8, 72.8);
                yield return new polar(-85.2, 113.2);
                yield return new polar(-53.1, 51.5);
                yield return new polar(-38.3, 146.8);
                yield return new polar(-72.7, 103.1);
                yield return new polar(-60.2, 33.2);
                yield return new polar(-63.4, 154.8);
                yield return new polar(-17.2, 89.9);
                yield return new polar(-81.6, 295.6);
                yield return new polar(-40.4, 41);
                yield return new polar(-53.6, 59.1);
                yield return new polar(-56.2, 35.6);
                yield return new polar(-75.1, 70.7);
            }
        }
    }
}
