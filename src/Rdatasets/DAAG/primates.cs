// ReSharper disable All

namespace Rdatasets.DAAG
{
    using System.Collections.Generic;

    /// <summary>
    /// Primate Body and Brain Weights
    /// </summary>

    public class primates
    {
        public readonly double Bodywt;
        public readonly int Brainwt;

        public primates(double Bodywt, int Brainwt)
        {
            this.Bodywt = Bodywt;
            this.Brainwt = Brainwt;
        }

        public static IEnumerable<primates> Data
        {
            get
            {
                yield return new primates(10, 115);
                yield return new primates(207, 406);
                yield return new primates(62, 1320);
                yield return new primates(6.8, 179);
                yield return new primates(52.2, 440);
            }
        }
    }
}
