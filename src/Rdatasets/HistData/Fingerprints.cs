// ReSharper disable All

namespace Rdatasets.HistData
{
    using System.Collections.Generic;

    /// <summary>
    /// Waite's data on Patterns in Fingerprints
    /// </summary>

    public class Fingerprints
    {
        public readonly int κ;
        public readonly int Whorls;
        public readonly int Loops;
        public readonly int? count;

        public Fingerprints(int κ, int Whorls, int Loops, int? count)
        {
            this.κ = κ;
            this.Whorls = Whorls;
            this.Loops = Loops;
            this.count = count;
        }

        public static IEnumerable<Fingerprints> Data
        {
            get
            {
                yield return new Fingerprints(1, 0, 0, 78);
                yield return new Fingerprints(2, 1, 0, 106);
                yield return new Fingerprints(3, 2, 0, 130);
                yield return new Fingerprints(4, 3, 0, 125);
                yield return new Fingerprints(5, 4, 0, 104);
                yield return new Fingerprints(6, 5, 0, 50);
                yield return new Fingerprints(7, 0, 1, 144);
                yield return new Fingerprints(8, 1, 1, 153);
                yield return new Fingerprints(9, 2, 1, 92);
                yield return new Fingerprints(10, 3, 1, 38);
                yield return new Fingerprints(11, 4, 1, 26);
                yield return new Fingerprints(12, 5, 1, null);
                yield return new Fingerprints(13, 0, 2, 204);
                yield return new Fingerprints(14, 1, 2, 126);
                yield return new Fingerprints(15, 2, 2, 55);
                yield return new Fingerprints(16, 3, 2, 7);
                yield return new Fingerprints(17, 4, 2, null);
                yield return new Fingerprints(18, 5, 2, null);
                yield return new Fingerprints(19, 0, 3, 211);
                yield return new Fingerprints(20, 1, 3, 80);
                yield return new Fingerprints(21, 2, 3, 15);
                yield return new Fingerprints(22, 3, 3, null);
                yield return new Fingerprints(23, 4, 3, null);
                yield return new Fingerprints(24, 5, 3, null);
                yield return new Fingerprints(25, 0, 4, 179);
                yield return new Fingerprints(26, 1, 4, 32);
                yield return new Fingerprints(27, 2, 4, null);
                yield return new Fingerprints(28, 3, 4, null);
                yield return new Fingerprints(29, 4, 4, null);
                yield return new Fingerprints(30, 5, 4, null);
                yield return new Fingerprints(31, 0, 5, 45);
                yield return new Fingerprints(32, 1, 5, null);
                yield return new Fingerprints(33, 2, 5, null);
                yield return new Fingerprints(34, 3, 5, null);
                yield return new Fingerprints(35, 4, 5, null);
                yield return new Fingerprints(36, 5, 5, null);
            }
        }
    }
}
