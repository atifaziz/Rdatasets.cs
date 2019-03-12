// ReSharper disable All

namespace Rdatasets.robustbase
{
    using System.Collections.Generic;

    /// <summary>
    /// Waterflow Measurements of Kootenay River in Libby and Newgate
    /// </summary>

    public class kootenay
    {
        public readonly int κ;
        public readonly double Libby;
        public readonly double Newgate;

        public kootenay(int κ, double Libby, double Newgate)
        {
            this.κ = κ;
            this.Libby = Libby;
            this.Newgate = Newgate;
        }

        public static IEnumerable<kootenay> Data
        {
            get
            {
                yield return new kootenay(1931, 27.1, 19.7);
                yield return new kootenay(1932, 20.9, 18);
                yield return new kootenay(1933, 33.4, 26.1);
                yield return new kootenay(1934, 77.6, 15.7);
                yield return new kootenay(1935, 37, 26.1);
                yield return new kootenay(1936, 21.6, 19.9);
                yield return new kootenay(1937, 17.6, 15.7);
                yield return new kootenay(1938, 35.1, 27.6);
                yield return new kootenay(1939, 32.6, 24.9);
                yield return new kootenay(1940, 26, 23.4);
                yield return new kootenay(1941, 27.6, 23.1);
                yield return new kootenay(1942, 38.7, 31.3);
                yield return new kootenay(1943, 27.8, 23.8);
            }
        }
    }
}
