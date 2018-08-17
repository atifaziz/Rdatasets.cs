// ReSharper disable All

namespace Rdatasets.MASS
{
    using System.Collections.Generic;

    /// <summary>
    /// Ships Damage Data
    /// </summary>

    public class ships
    {
        public readonly string type;
        public readonly int year;
        public readonly int period;
        public readonly int service;
        public readonly int incidents;

        public ships(string type, int year, int period, int service, int incidents)
        {
            this.type = type;
            this.year = year;
            this.period = period;
            this.service = service;
            this.incidents = incidents;
        }

        public static IEnumerable<ships> Data
        {
            get
            {
                yield return new ships("A", 60, 60, 127, 0);
                yield return new ships("A", 60, 75, 63, 0);
                yield return new ships("A", 65, 60, 1095, 3);
                yield return new ships("A", 65, 75, 1095, 4);
                yield return new ships("A", 70, 60, 1512, 6);
                yield return new ships("A", 70, 75, 3353, 18);
                yield return new ships("A", 75, 60, 0, 0);
                yield return new ships("A", 75, 75, 2244, 11);
                yield return new ships("B", 60, 60, 44882, 39);
                yield return new ships("B", 60, 75, 17176, 29);
                yield return new ships("B", 65, 60, 28609, 58);
                yield return new ships("B", 65, 75, 20370, 53);
                yield return new ships("B", 70, 60, 7064, 12);
                yield return new ships("B", 70, 75, 13099, 44);
                yield return new ships("B", 75, 60, 0, 0);
                yield return new ships("B", 75, 75, 7117, 18);
                yield return new ships("C", 60, 60, 1179, 1);
                yield return new ships("C", 60, 75, 552, 1);
                yield return new ships("C", 65, 60, 781, 0);
                yield return new ships("C", 65, 75, 676, 1);
                yield return new ships("C", 70, 60, 783, 6);
                yield return new ships("C", 70, 75, 1948, 2);
                yield return new ships("C", 75, 60, 0, 0);
                yield return new ships("C", 75, 75, 274, 1);
                yield return new ships("D", 60, 60, 251, 0);
                yield return new ships("D", 60, 75, 105, 0);
                yield return new ships("D", 65, 60, 288, 0);
                yield return new ships("D", 65, 75, 192, 0);
                yield return new ships("D", 70, 60, 349, 2);
                yield return new ships("D", 70, 75, 1208, 11);
                yield return new ships("D", 75, 60, 0, 0);
                yield return new ships("D", 75, 75, 2051, 4);
                yield return new ships("E", 60, 60, 45, 0);
                yield return new ships("E", 60, 75, 0, 0);
                yield return new ships("E", 65, 60, 789, 7);
                yield return new ships("E", 65, 75, 437, 7);
                yield return new ships("E", 70, 60, 1157, 5);
                yield return new ships("E", 70, 75, 2161, 12);
                yield return new ships("E", 75, 60, 0, 0);
                yield return new ships("E", 75, 75, 542, 1);
            }
        }
    }
}
