// ReSharper disable All

namespace Rdatasets.HistData
{
    using System.Collections.Generic;

    /// <summary>
    /// John Snow's Map and Data on the 1854 London Cholera Outbreak
    /// </summary>

    public class Snow_pumps
    {
        public readonly int pump;
        public readonly string label;
        public readonly double x;
        public readonly double y;

        public Snow_pumps(int pump, string label, double x, double y)
        {
            this.pump = pump;
            this.label = label;
            this.x = x;
            this.y = y;
        }

        public static IEnumerable<Snow_pumps> Data
        {
            get
            {
                yield return new Snow_pumps(1, "Oxford Market", 8.6512012, 17.8915997);
                yield return new Snow_pumps(2, "Castle St E", 10.9847803, 18.5178509);
                yield return new Snow_pumps(3, "Oxford St #1", 13.37819, 17.3945408);
                yield return new Snow_pumps(4, "Oxford St #2", 14.8798304, 17.8099194);
                yield return new Snow_pumps(5, "Gt Marlborough", 8.694768, 14.9054699);
                yield return new Snow_pumps(6, "Crown Chapel", 8.8644161, 12.75354);
                yield return new Snow_pumps(7, "Broad St", 12.5713596, 11.72717);
                yield return new Snow_pumps(8, "Warwick", 10.6609697, 7.428647);
                yield return new Snow_pumps(9, "Briddle St", 13.5214596, 7.95825);
                yield return new Snow_pumps(10, "So Soho", 16.4348907, 9.2521296);
                yield return new Snow_pumps(11, "Dean St", 18.9143906, 9.7378187);
                yield return new Snow_pumps(12, "Coventry St", 16.0051098, 5.0468378);
                yield return new Snow_pumps(13, "Vigo St", 8.9994402, 5.1010232);
            }
        }
    }
}
