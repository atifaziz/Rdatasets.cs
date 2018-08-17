// ReSharper disable All

namespace Rdatasets.mosaicData
{
    using System.Collections.Generic;

    /// <summary>
    /// Mites and Wilt Disease
    /// </summary>

    public class Mites
    {
        public readonly string treatment;
        public readonly string outcome;

        public Mites(string treatment, string outcome)
        {
            this.treatment = treatment;
            this.outcome = outcome;
        }

        public static IEnumerable<Mites> Data
        {
            get
            {
                yield return new Mites("mites", "wilt");
                yield return new Mites("mites", "wilt");
                yield return new Mites("mites", "wilt");
                yield return new Mites("mites", "wilt");
                yield return new Mites("mites", "wilt");
                yield return new Mites("mites", "wilt");
                yield return new Mites("mites", "wilt");
                yield return new Mites("mites", "wilt");
                yield return new Mites("mites", "wilt");
                yield return new Mites("mites", "wilt");
                yield return new Mites("mites", "wilt");
                yield return new Mites("no mites", "wilt");
                yield return new Mites("no mites", "wilt");
                yield return new Mites("no mites", "wilt");
                yield return new Mites("no mites", "wilt");
                yield return new Mites("no mites", "wilt");
                yield return new Mites("no mites", "wilt");
                yield return new Mites("no mites", "wilt");
                yield return new Mites("no mites", "wilt");
                yield return new Mites("no mites", "wilt");
                yield return new Mites("no mites", "wilt");
                yield return new Mites("no mites", "wilt");
                yield return new Mites("no mites", "wilt");
                yield return new Mites("no mites", "wilt");
                yield return new Mites("no mites", "wilt");
                yield return new Mites("no mites", "wilt");
                yield return new Mites("no mites", "wilt");
                yield return new Mites("no mites", "wilt");
                yield return new Mites("mites", "no wilt");
                yield return new Mites("mites", "no wilt");
                yield return new Mites("mites", "no wilt");
                yield return new Mites("mites", "no wilt");
                yield return new Mites("mites", "no wilt");
                yield return new Mites("mites", "no wilt");
                yield return new Mites("mites", "no wilt");
                yield return new Mites("mites", "no wilt");
                yield return new Mites("mites", "no wilt");
                yield return new Mites("mites", "no wilt");
                yield return new Mites("mites", "no wilt");
                yield return new Mites("mites", "no wilt");
                yield return new Mites("mites", "no wilt");
                yield return new Mites("mites", "no wilt");
                yield return new Mites("mites", "no wilt");
                yield return new Mites("no mites", "no wilt");
                yield return new Mites("no mites", "no wilt");
                yield return new Mites("no mites", "no wilt");
                yield return new Mites("no mites", "no wilt");
            }
        }
    }
}
