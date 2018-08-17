// ReSharper disable All

namespace Rdatasets.datasets
{
    using System.Collections.Generic;

    /// <summary>
    /// Passenger Miles on Commercial US Airlines, 1937-1960
    /// </summary>

    public class airmiles
    {
        public readonly int time;
        public readonly int value;

        public airmiles(int time, int value)
        {
            this.time = time;
            this.value = value;
        }

        public static IEnumerable<airmiles> Data
        {
            get
            {
                yield return new airmiles(1937, 412);
                yield return new airmiles(1938, 480);
                yield return new airmiles(1939, 683);
                yield return new airmiles(1940, 1052);
                yield return new airmiles(1941, 1385);
                yield return new airmiles(1942, 1418);
                yield return new airmiles(1943, 1634);
                yield return new airmiles(1944, 2178);
                yield return new airmiles(1945, 3362);
                yield return new airmiles(1946, 5948);
                yield return new airmiles(1947, 6109);
                yield return new airmiles(1948, 5981);
                yield return new airmiles(1949, 6753);
                yield return new airmiles(1950, 8003);
                yield return new airmiles(1951, 10566);
                yield return new airmiles(1952, 12528);
                yield return new airmiles(1953, 14760);
                yield return new airmiles(1954, 16769);
                yield return new airmiles(1955, 19819);
                yield return new airmiles(1956, 22362);
                yield return new airmiles(1957, 25340);
                yield return new airmiles(1958, 25343);
                yield return new airmiles(1959, 29269);
                yield return new airmiles(1960, 30514);
            }
        }
    }
}
