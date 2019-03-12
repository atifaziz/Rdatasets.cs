// ReSharper disable All

namespace Rdatasets.DAAG
{
    using System.Collections.Generic;

    /// <summary>
    /// Primate Body and Brain Weights
    /// </summary>

    public class primates
    {
        public readonly string κ;
        public readonly double Bodywt;
        public readonly int Brainwt;

        public primates(string κ, double Bodywt, int Brainwt)
        {
            this.κ = κ;
            this.Bodywt = Bodywt;
            this.Brainwt = Brainwt;
        }

        public static IEnumerable<primates> Data
        {
            get
            {
                yield return new primates("Potar monkey", 10, 115);
                yield return new primates("Gorilla", 207, 406);
                yield return new primates("Human", 62, 1320);
                yield return new primates("Rhesus monkey", 6.8, 179);
                yield return new primates("Chimp", 52.2, 440);
            }
        }
    }
}
