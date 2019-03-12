// ReSharper disable All

namespace Rdatasets.mosaicData
{
    using System.Collections.Generic;

    /// <summary>
    /// Mites and Wilt Disease
    /// </summary>

    public class Mites
    {
        public readonly int κ;
        public readonly string treatment;
        public readonly string outcome;

        public Mites(int κ, string treatment, string outcome)
        {
            this.κ = κ;
            this.treatment = treatment;
            this.outcome = outcome;
        }

        public static IEnumerable<Mites> Data
        {
            get
            {
                yield return new Mites(1, "mites", "wilt");
                yield return new Mites(2, "mites", "wilt");
                yield return new Mites(3, "mites", "wilt");
                yield return new Mites(4, "mites", "wilt");
                yield return new Mites(5, "mites", "wilt");
                yield return new Mites(6, "mites", "wilt");
                yield return new Mites(7, "mites", "wilt");
                yield return new Mites(8, "mites", "wilt");
                yield return new Mites(9, "mites", "wilt");
                yield return new Mites(10, "mites", "wilt");
                yield return new Mites(11, "mites", "wilt");
                yield return new Mites(12, "no mites", "wilt");
                yield return new Mites(13, "no mites", "wilt");
                yield return new Mites(14, "no mites", "wilt");
                yield return new Mites(15, "no mites", "wilt");
                yield return new Mites(16, "no mites", "wilt");
                yield return new Mites(17, "no mites", "wilt");
                yield return new Mites(18, "no mites", "wilt");
                yield return new Mites(19, "no mites", "wilt");
                yield return new Mites(20, "no mites", "wilt");
                yield return new Mites(21, "no mites", "wilt");
                yield return new Mites(22, "no mites", "wilt");
                yield return new Mites(23, "no mites", "wilt");
                yield return new Mites(24, "no mites", "wilt");
                yield return new Mites(25, "no mites", "wilt");
                yield return new Mites(26, "no mites", "wilt");
                yield return new Mites(27, "no mites", "wilt");
                yield return new Mites(28, "no mites", "wilt");
                yield return new Mites(29, "mites", "no wilt");
                yield return new Mites(30, "mites", "no wilt");
                yield return new Mites(31, "mites", "no wilt");
                yield return new Mites(32, "mites", "no wilt");
                yield return new Mites(33, "mites", "no wilt");
                yield return new Mites(34, "mites", "no wilt");
                yield return new Mites(35, "mites", "no wilt");
                yield return new Mites(36, "mites", "no wilt");
                yield return new Mites(37, "mites", "no wilt");
                yield return new Mites(38, "mites", "no wilt");
                yield return new Mites(39, "mites", "no wilt");
                yield return new Mites(40, "mites", "no wilt");
                yield return new Mites(41, "mites", "no wilt");
                yield return new Mites(42, "mites", "no wilt");
                yield return new Mites(43, "mites", "no wilt");
                yield return new Mites(44, "no mites", "no wilt");
                yield return new Mites(45, "no mites", "no wilt");
                yield return new Mites(46, "no mites", "no wilt");
                yield return new Mites(47, "no mites", "no wilt");
            }
        }
    }
}
