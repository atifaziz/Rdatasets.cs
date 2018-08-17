// ReSharper disable All

namespace Rdatasets.robustbase
{
    using System.Collections.Generic;

    /// <summary>
    /// Waterflow Measurements of Kootenay River in Libby and Newgate
    /// </summary>

    public class kootenay
    {
        public readonly double Libby;
        public readonly double Newgate;

        public kootenay(double Libby, double Newgate)
        {
            this.Libby = Libby;
            this.Newgate = Newgate;
        }

        public static IEnumerable<kootenay> Data
        {
            get
            {
                yield return new kootenay(27.1, 19.7);
                yield return new kootenay(20.9, 18);
                yield return new kootenay(33.4, 26.1);
                yield return new kootenay(77.6, 15.7);
                yield return new kootenay(37, 26.1);
                yield return new kootenay(21.6, 19.9);
                yield return new kootenay(17.6, 15.7);
                yield return new kootenay(35.1, 27.6);
                yield return new kootenay(32.6, 24.9);
                yield return new kootenay(26, 23.4);
                yield return new kootenay(27.6, 23.1);
                yield return new kootenay(38.7, 31.3);
                yield return new kootenay(27.8, 23.8);
            }
        }
    }
}
