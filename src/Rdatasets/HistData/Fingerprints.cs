// ReSharper disable All

namespace Rdatasets.HistData
{
    using System.Collections.Generic;

    /// <summary>
    /// Waite's data on Patterns in Fingerprints
    /// </summary>

    public class Fingerprints
    {
        public readonly int Whorls;
        public readonly int Loops;
        public readonly string count;

        public Fingerprints(int Whorls, int Loops, string count)
        {
            this.Whorls = Whorls;
            this.Loops = Loops;
            this.count = count;
        }

        public static IEnumerable<Fingerprints> Data
        {
            get
            {
                yield return new Fingerprints(0, 0, "78");
                yield return new Fingerprints(1, 0, "106");
                yield return new Fingerprints(2, 0, "130");
                yield return new Fingerprints(3, 0, "125");
                yield return new Fingerprints(4, 0, "104");
                yield return new Fingerprints(5, 0, "50");
                yield return new Fingerprints(0, 1, "144");
                yield return new Fingerprints(1, 1, "153");
                yield return new Fingerprints(2, 1, "92");
                yield return new Fingerprints(3, 1, "38");
                yield return new Fingerprints(4, 1, "26");
                yield return new Fingerprints(5, 1, null);
                yield return new Fingerprints(0, 2, "204");
                yield return new Fingerprints(1, 2, "126");
                yield return new Fingerprints(2, 2, "55");
                yield return new Fingerprints(3, 2, "7");
                yield return new Fingerprints(4, 2, null);
                yield return new Fingerprints(5, 2, null);
                yield return new Fingerprints(0, 3, "211");
                yield return new Fingerprints(1, 3, "80");
                yield return new Fingerprints(2, 3, "15");
                yield return new Fingerprints(3, 3, null);
                yield return new Fingerprints(4, 3, null);
                yield return new Fingerprints(5, 3, null);
                yield return new Fingerprints(0, 4, "179");
                yield return new Fingerprints(1, 4, "32");
                yield return new Fingerprints(2, 4, null);
                yield return new Fingerprints(3, 4, null);
                yield return new Fingerprints(4, 4, null);
                yield return new Fingerprints(5, 4, null);
                yield return new Fingerprints(0, 5, "45");
                yield return new Fingerprints(1, 5, null);
                yield return new Fingerprints(2, 5, null);
                yield return new Fingerprints(3, 5, null);
                yield return new Fingerprints(4, 5, null);
                yield return new Fingerprints(5, 5, null);
            }
        }
    }
}
