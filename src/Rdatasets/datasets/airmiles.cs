// ReSharper disable All

namespace Rdatasets.datasets
{
    using System.Collections.Generic;

    /// <summary>
    /// Passenger Miles on Commercial US Airlines, 1937-1960
    /// </summary>

    public class airmiles
    {
        public readonly int κ;
        public readonly int time;
        public readonly int value;

        public airmiles(int κ, int time, int value)
        {
            this.κ = κ;
            this.time = time;
            this.value = value;
        }

        public static IEnumerable<airmiles> Data
        {
            get
            {
                yield return new airmiles(1, 1937, 412);
                yield return new airmiles(2, 1938, 480);
                yield return new airmiles(3, 1939, 683);
                yield return new airmiles(4, 1940, 1052);
                yield return new airmiles(5, 1941, 1385);
                yield return new airmiles(6, 1942, 1418);
                yield return new airmiles(7, 1943, 1634);
                yield return new airmiles(8, 1944, 2178);
                yield return new airmiles(9, 1945, 3362);
                yield return new airmiles(10, 1946, 5948);
                yield return new airmiles(11, 1947, 6109);
                yield return new airmiles(12, 1948, 5981);
                yield return new airmiles(13, 1949, 6753);
                yield return new airmiles(14, 1950, 8003);
                yield return new airmiles(15, 1951, 10566);
                yield return new airmiles(16, 1952, 12528);
                yield return new airmiles(17, 1953, 14760);
                yield return new airmiles(18, 1954, 16769);
                yield return new airmiles(19, 1955, 19819);
                yield return new airmiles(20, 1956, 22362);
                yield return new airmiles(21, 1957, 25340);
                yield return new airmiles(22, 1958, 25343);
                yield return new airmiles(23, 1959, 29269);
                yield return new airmiles(24, 1960, 30514);
            }
        }
    }
}
